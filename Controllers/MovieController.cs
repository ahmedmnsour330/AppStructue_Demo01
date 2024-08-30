using Microsoft.AspNetCore.Mvc;

namespace AppStructue_Demo01.Controllers
{
    public class MovieController:Controller
    {
        // Action --> public None-static function => Movie/GetMovie
        public IActionResult GetMovie(int id)
        {
            //ContentResult result = new ContentResult(); 
            //result.Content = $"Movie with id = {id}"; 
            //result.ContentType = "text/html" ;  
            //result.StatusCode = 200 ;

            //  return result;
            return Content($"Movie with id = {id}", "text/html");
        }
        [ActionName("Hmadaa")]
        [HttpGet]
        [ AcceptVerbs("Post","Get")] 
        public IActionResult Index() 
        {
            //RedirectResult redirect = new RedirectResult("https://localhost:44343/Movie/GetMpvie/10");
            //return redirect;
            //return Redirect("https://localhost:44343/Movie/GetMpvie/10");
            //    return RedirectToAction("GetMovie",new {id = 10});
            //return RedirectToAction(nameof(GetMovie), new { id = 10 });
            return RedirectToPage("default", new { Controller = "product", action = "GetProduct" });
        }

    }
}
