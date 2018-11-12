using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using INC.Web.Mvc.Framework.KO.Controllers;
using INC.Web.MVC.Framework.Sample.Models;

namespace INC.Web.MVC.Framework.Sample.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var model = new IndexModel() { DropDownValue = "\"1\\" };
            var data = new IndexDataModel()
            {
                DropDownData = new List<SelectListItem>(){
                new SelectListItem(){Text="eeee",Value="1"},
                new SelectListItem(){Text="eee22222",Value="2"}
            }};
            return View(model, data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}