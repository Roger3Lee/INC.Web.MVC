using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INC.Web.MVC.Framework.Sample.Models
{
    public class IndexModel
    {
        public string DropDownValue { get; set; }
    }

    public class IndexDataModel {

        public List<SelectListItem> DropDownData { get; set; }
    }
}