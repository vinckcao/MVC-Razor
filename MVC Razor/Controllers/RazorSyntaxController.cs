using MVC_Razor.Models;
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
        public ActionResult HtmlRaw()
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

        public ActionResult HtmlTextBox()
        {
            ViewBag.Album = new Album() { Title = "范特西" };
            ViewBag.Price = "100";
            return View("HtmlTextBox");
        }

        public ActionResult EditFormSample()
        {
            ViewBag.Genres = new SelectList(new List<string> { "爵士", "摇滚", "民族" });
            return View(new MVC_Razor.Models.Album() { Title = "范特西" });
        }

        public ActionResult StrongTypeModel()
        {
            ViewBag.Genres = new SelectList(new List<string> { "爵士", "摇滚", "R&B" });
            return View(new MVC_Razor.Models.Album() { Title = "范特西", GenreId = "R&B" });
        }

        public ActionResult HtmlEditorFor()
        {
            return View(new MVC_Razor.Models.Album() { Title = "范特西", GenreId = "R&B" });
        }

        public ActionResult HtmlActionLink()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            return PartialView("JavaScriptStringEncode");
        }

    }
}
