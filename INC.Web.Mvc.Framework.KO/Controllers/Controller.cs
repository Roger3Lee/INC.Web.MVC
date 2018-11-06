using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace INC.Web.Mvc.Framework.KO.Controllers
{
    public class BaseController : System.Web.Mvc.Controller
    {
        /// <summary>
        /// Creates a <see cref="ViewResult"/> object by specifying a <paramref name="viewName"/>
        /// and the <paramref name="model"/> to be rendered by the view.
        /// </summary>
        /// <param name="model">The model that is rendered by the view.</param>
        /// <param name="data">The data that is rendered by the view.</param>
        /// <returns>The created <see cref="ViewResult"/> object for the response.</returns>
        [NonAction]
        public virtual ViewResult View(object model, object data)
        {
            return View(viewName: null, model: model, data: data);
        }

        /// <summary>
        /// Creates a <see cref="ViewResult"/> object by specifying a <paramref name="viewName"/>
        /// and the <paramref name="model"/> to be rendered by the view.
        /// </summary>
        /// <param name="viewName">The name or path of the view that is rendered to the response.</param>
        /// <param name="model">The model that is rendered by the view.</param>
        /// <param name="data">The data that is rendered by the view.</param>
        /// <returns>The created <see cref="ViewResult"/> object for the response.</returns>
        [NonAction]
        public virtual ViewResult View(string viewName, object model, object data)
        {
            ViewData.Model = model;
            ViewData["TData"] = data;
            return new ViewResult()
            {
                ViewName = viewName,
                ViewData = ViewData,
                TempData = TempData
            };
        }

        /// <summary>
        /// Creates a <see cref="PartialViewResult"/> object by specifying a <paramref name="model"/>
        /// to be rendered by the partial view.
        /// </summary>
        /// <param name="model">The model that is rendered by the partial view.</param>
        /// <param name="data">The data that is rendered by the view.</param>
        /// <returns>The created <see cref="PartialViewResult"/> object for the response.</returns>
        [NonAction]
        public virtual PartialViewResult PartialView(object model, object data)
        {
            return PartialView(viewName: null, model: model, data: data);
        }

        /// <summary>
        /// Creates a <see cref="PartialViewResult"/> object by specifying a <paramref name="viewName"/>
        /// and the <paramref name="model"/> to be rendered by the partial view.
        /// </summary>
        /// <param name="viewName">The name or path of the partial view that is rendered to the response.</param>
        /// <param name="model">The model that is rendered by the partial view.</param>
        /// <param name="data">The data that is rendered by the view.</param>
        /// <returns>The created <see cref="PartialViewResult"/> object for the response.</returns>
        [NonAction]
        public virtual PartialViewResult PartialView(string viewName, object model, object data)
        {
            ViewData.Model = model;
            ViewData["TData"] = data;

            return new PartialViewResult()
            {
                ViewName = viewName,
                ViewData = ViewData,
                TempData = TempData
            };
        }
    }
}
