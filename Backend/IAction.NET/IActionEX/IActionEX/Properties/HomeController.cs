using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace IActionEX.Properties
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // If Book id is not supplied in URL 
            if(!Request.Query.ContainsKey("bookID"))
            {
                
                return Content("Book ID Not Supplied ");
            }
            // IF Book ID is supplied with empty 
            if(string.IsNullOrEmpty(Convert.ToString(Request.Query.ContainsKey("bookID"))))
            {
                return Content("Book Id Can't Be Empty ");
            }
            // Book ID should be 1 - 1000 in between 
            int bookID = Convert.ToInt32(ControllerContext.HttpContext.Request.Query["bookID"]);
            if(bookID<=0)
            {
                return Content("BookID can not be less than 0");

            }
            if(bookID>1000)
            {
                return Content("BookID Can not be more thaan 1000");
            }
            return File("C:\\PersonalGitFolder\\Backend\\IAction.NET\\IActionEX\\IActionEX\\wwwroot\\PAT – PYTHON ROADMAP.pdf", "application/pdf");
        }
    }
}
