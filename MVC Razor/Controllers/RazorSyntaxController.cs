using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Razor.Controllers
{
    public class RazorSyntaxController : Controller
    {
        //
        // GET: /RazorSyntax/

        public ActionResult Index()
        {
            return View("DemoLists");
        }

        public ActionResult DemoLists()
        {
            return View("DemoLists");
        }


        public ActionResult ForeachDemo()
        {
            return View("ForeachDemo");
        }

        public ActionResult BracketDemo()
        {
            return View("BracketDemo");
        }
        public ActionResult HtmlRawDemo()
        {
            return View("HtmlRaw");
        }

        public ActionResult JavaScriptStringEncode()
        {
            return View("JavaScriptStringEncode");
        }

        public ActionResult HtmlBeginForm()
        {
            return View("HtmlBeginForm");
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("JavaScriptStringEncode");
        }

    }
}
