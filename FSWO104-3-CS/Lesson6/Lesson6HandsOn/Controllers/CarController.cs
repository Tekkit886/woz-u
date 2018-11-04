using Microsoft.AspNetCore.Mvc;

namespace Lesson6HandsOn.Controllers{
     [Route("api/[Controller]")]
    public class CarController : ControllerBase {

        [HttpGet("{Id}, {Year}, {Make}, {Model}, {NumOfPass},")]
        public int Get(int Id, int year, string make, string model, int numofpass) {
            return Id + " " + year + " " + make + " " + model + " " + numofpass;
        }
    }
}