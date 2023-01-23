using Microsoft.AspNetCore.Mvc;

namespace OnlyCats.Controllers.ReplaceDogController
{
    //Controller handling the replace of "dog" with "cat"
    public class ReplaceDogController : Controller
    {
        //Handle the post request
        [HttpPost]
        //Define the route (only route is replacedog)
        [Route("api/[controller]")]
        public IActionResult ReplaceDog([FromBody] object json)
        {
            try
            {
                //take the json object from the body and stringify it
                var jsonString = json.ToString();
                //check to make sure the jsonString is not null
                if (jsonString is not null)
                {
                    //if there is any instance of the exact string "dog" in the string replace it with the exact string "cat" 
                    jsonString = jsonString.Replace("dog", "cat");
                    //return status code 200 OK and the modified JSON string
                    return Ok(jsonString);
                }
                else
                {
                    //return status code 404
                    return NotFound();
                }
            } 
            catch (Exception ex)
            {
                //return status code 400 and the exception message
                return BadRequest(ex.Message);
            }
        }
    }
}



