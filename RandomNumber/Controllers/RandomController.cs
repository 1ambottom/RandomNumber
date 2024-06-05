using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomNumber.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetGenerateId()
        {
            string result = await GenerateCode();
            return Ok(result);
        }
        private async Task<string> GenerateCode()
        {
            Random rand = new Random();

            int stringlen = rand.Next(0, 9);
            int randValue;
            string str = "";
            char letter;
            for (int i = 0; i < 8; i++)
            {
                str += stringlen;  
                if (i >= 3 && i <= 7)
                {
                    randValue = rand.Next(0, 10);
                    letter = Convert.ToChar(randValue + 65);
                    str = str + letter;
                }
            }
            return str;
        }
    }
}
