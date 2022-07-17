using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;

namespace Filter
{
    public class Log : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            log("this is form onaction executred", context.RouteData);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            log("this is form on action executed", context.RouteData);
        }

        private void log(string methodname , RouteData routedata)
        {
            var controllername = (string)routedata.Values["controller"];

            var actionname = (string)routedata.Values["action"];

            var id = (string)routedata.Values["id"];    
            var name = (string)routedata.Values["name"];    

            var message = string.Format("{0} controller :{1} action: {2} id: {3} name: {4} ", methodname, controllername, actionname,id,name);

            Console.WriteLine(message, "hemanth filter");

        }
    }
}
