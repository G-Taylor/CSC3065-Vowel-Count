using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
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
            return response.ToLower();
        }
    }
}
