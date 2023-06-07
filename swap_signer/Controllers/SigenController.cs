using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace swap_signer.Controllers
{
    [ApiController]
    [Route("api/[action]")]
    public class SigenController : ControllerBase
    {

        [HttpPost]
       
        [HttpPost("{UseSerial}/{TokenName}/{TokenPin}")]
        public async Task<ActionResult> signdoc([FromQuery] int UseSerial, [FromQuery] string TokenName, [FromQuery] string TokenPin)
        {
            var reader = new StreamReader(HttpContext.Request.Body);
            var body = await reader.ReadToEndAsync();

            string  singeddoc = Signer.add_signatuer(body, TokenPin, Convert.ToBoolean(UseSerial), TokenName);
            //JObject o = JObject.Parse(singeddoc);

            if (singeddoc == "No slots found" || singeddoc == "No slots found")

            {
                return BadRequest(singeddoc);
            }
            else
            {
                return Ok(singeddoc);
            }
                

        }



        [HttpPost]
        public async Task<ActionResult> SigenRecipt()
        {
            var reader = new StreamReader(HttpContext.Request.Body);
            var body= await reader.ReadToEndAsync();

            string SingedRecipt = Signer.add_pos_signatuer(body);


          

            return Ok(SingedRecipt);

        }
    }
}
