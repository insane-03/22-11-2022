using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomWebApi.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class TestController : ControllerBase
    {
        [Route("{id:MAX(5)}")]
        public string showText(int i)
        {
            return "HEY HI I AM TEST" + i;
        }
    }
}
