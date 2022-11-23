using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Text;


namespace TestCustomApi.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class CustomController : ControllerBase
    {
        public String Add()
        {
            var val = "from custom add controller";
            return val;
        }
        public String Sub()
        {
            var val = "from custom sub controller";
            return val;
        }
        //[Route("[action]/{id}")]
        public int AddInt(int i)
        {
            var val = i+5;
            return val;
        }
    }
}
