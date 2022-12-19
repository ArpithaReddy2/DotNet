using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Action_Results.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
    }
    /*public class HomeController : Controller
    {
        public PartialViewResult Index()
        {
            return PartialView("Second View");
        }
    }*/

/*public class HomeController : Controller  
{  
public EmptyResult Index()  
{  
    return new EmptyResult();  
}  
}*/
/*public class HomeController : Controller  
{  
    public FileResult Index()  
    {  
        return File(Url.Content("~/Files/text.txt"), "text/plain", "testFile.txt");  
    }  
}*/
/*public JavaScriptResult Index()  
{  
    return JavaScript("alert('Zain Ul hassan')");  
} */
/*public RedirectResult Index()  
{  
    return Redirect("https://www.c-sharpcorner.com/members/zain-ul-hassan2");  
} */



}