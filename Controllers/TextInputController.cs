using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace editor_vowel_count.Controllers
{
    [ApiController]
    [Route("/")]
    public class TextInputController : ControllerBase
    {
        [HttpGet]
        public string Get([FromQuery(Name = "text")] string text)
        {
    
            if( text == null) {
                var responseNull = JsonConvert.SerializeObject(
                new{
                    error = "true",
                    sentence = "No input detected. Please enter a sentence",
                    answer = "0"
                }
            );
                Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return responseNull;
            } else {
                VowelCount vc = new VowelCount();
                int numOfVowels = vc.NumberOfVowels(text);

                var response = JsonConvert.SerializeObject(
                    new{
                        error = "false",
                        sentence = text,
                        answer = numOfVowels
                    }
                );

                Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return response;
            }
        }
    }
}
