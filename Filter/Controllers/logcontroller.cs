using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Filter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class logcontroller : ControllerBase
    {

        [HttpGet]
        [Route("log/{id}/{name}")]
        [Log]
        public string get(int id , string name )
        {
            return " hello " + " " +  name  +  "  my id is"  + id;
        }
    }
}
