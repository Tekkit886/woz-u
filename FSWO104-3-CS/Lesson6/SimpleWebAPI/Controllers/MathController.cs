using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers {

    [Route("api/[Controller]")]
    public class MathController : ControllerBase {

        [HttpGet("{x}/{y}")]
        public int Get(int x, int y) {
            return x + y;
        }
    }
}