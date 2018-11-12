using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;

namespace INC.Web.Mvc.KO.WebPages
{
    public abstract class WebViewPage<TModel, TData> : System.Web.Mvc.WebViewPage<TModel> where TData : class
    {
        private TData _tData;

        protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData)
        {
            base.SetViewData(viewData);
            _tData = ViewData["TData"] as TData;
        }

        public TData Data
        {
            get
            {
                return _tData;
            }
        }

        public IHtmlString ModelJson
        {
            get
            {
              return  Html.Raw(Json.Encode(Model));
            }
        }

        public override void Execute()
        {
        }
    }
}
