using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tx_mvc_tutorial.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TemplateEditor()
        {
            var myString = RenderViewToString("Editor.aspx");
            return Content(myString);
        }

        protected string RenderViewToString(string viewPath)
        {
            System.IO.StringWriter htmlStringWriter = new System.IO.StringWriter();
            Server.Execute(viewPath, htmlStringWriter);
            return htmlStringWriter.GetStringBuilder().ToString();
        }

        [HttpPost]
        public bool SaveTemplate(string documentName, string document)
        {
            // these are the values coming from the HTTP Post action
            // of the ASPX page
            string docName = documentName;
            string doc = document;

            // the document can now be saved in your Controller action
            // ...

            // return true, if successful
            return true;
        }
    }
}
