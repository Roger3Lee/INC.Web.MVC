using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INC.Web.Mvc.Framework.KO.WebPages
{
    public abstract class WebViewPage<TModel, TData> : System.Web.Mvc.WebViewPage<TModel> where TData : class
    {
        private TData _tData;
        public WebViewPage()
        {

            this._tData = ViewBag.TData as TData;
        }
        public TData Data
        {
            get
            {
                return _tData;
            }
        }

        public override void Execute()
        {
        }
    }
}
