using Microsoft.AspNetCore.Mvc;

namespace IActionEX.Properties
{
    public class AboutController : Controller
    {
        [Route("About-Us")]
        public IActionResult Indexfn()
        {
            return Content("THIS PAGE IS ABOUT OUR ORGANISATION");
        }
    }
}
