using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace IActionEX.Properties
{
    public class HomeController : Controller
    {
        [Route("book")]
        public IActionResult Index()
        {
            // If Book id is not supplied in URL 
            if(Convert.ToBoolean(Request.Query.ContainsKey("bookID"))==false)
            {
                
                return BadRequest("Book ID Not Supplied ");
            }
            // IF Book ID is supplied with empty 
            if(string.IsNullOrEmpty(Request.Query["bookID"]))
            {
                return BadRequest("Book Id Can't Be Empty ");
            }
            // Book ID should be 1 - 1000 in between 
            int bookID = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookID"]);
            if (bookID < 0 || bookID > 1000)
                
                return BadRequest("BookID must be within (0-1000) ");
            //else if(bookID >= 0 || bookID <= 1000)
            //{
            //    return Content("You Can Acces The Databases");
            //}
            if (!Convert.ToBoolean(Request.Query["isLoggedIn"]))
            {
                Response.StatusCode = 401;
                return Unauthorized("User Must Be Authenticated Daa !!");
                //Here Response Body will be Empty 
                //return StatusCode(401);
            }
            //return PhysicalFile("C:\\Users\\2408696\\Downloads\\PAT – PYTHON ROADMAP.pdf", "application/pdf", "PythonRoadmap.pdf");
            return RedirectToAction("Indexfn", "About");

        }
    }
}
