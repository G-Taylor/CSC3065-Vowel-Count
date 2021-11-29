using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace editor_vowel_count.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public string error()
        {
            var response = JsonConvert.SerializeObject(
                new{
                    error = true,
                    sentence = "Incorrect Parameters",
                    answer = "0"
                }
            );
            
            return response;
        }
    }
}
