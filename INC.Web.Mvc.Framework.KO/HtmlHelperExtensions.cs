using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace INC.Web.Mvc.Framework.KO
{
    public static class HtmlHelperExtensions
    {
        private static string GetMemberName<TModel, TProperty>(Expression<Func<TModel, TProperty>> action)
        {
            var expression = (MemberExpression)action.Body;
            return expression.Member.Name;
        }

        // 摘要: 
        //     通过使用指定的 HTML 帮助器和窗体字段的名称，返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name) 
        {
            return KOTextBox(htmlHelper, name, string.Empty, string.Empty, new Dictionary<string, object>());
        }
        //
        // 摘要: 
        //     通过使用指定的 HTML 帮助器、窗体字段的名称和值，返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value) 
        {
            return KOTextBox(htmlHelper, name, value, string.Empty, new Dictionary<string, object>());
        }
        //
        // 摘要: 
        //     通过使用指定的 HTML 帮助器、窗体字段的名称、值和 HTML 特性，返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value, IDictionary<string, object> htmlAttributes)
        {
            return KOTextBox(htmlHelper, name, value, string.Empty, htmlAttributes);
        }
        //
        // 摘要: 
        //     通过使用指定的 HTML 帮助器、窗体字段的名称、值和 HTML 特性，返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value, object htmlAttributes)
        {
            IDictionary<string, object> attributes = null;
            if (null != htmlAttributes)
                attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
            return KOTextBox(htmlHelper, name, value, string.Empty, attributes);
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value, string format) 
        {
            return KOTextBox(htmlHelper, name, string.Empty, string.Empty, new Dictionary<string, object>());
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value, string format, IDictionary<string, object> htmlAttributes) 
        {
            if (null == htmlAttributes)
                htmlAttributes = new Dictionary<string, object>();

            if (!htmlAttributes.ContainsKey("data-bind"))
                htmlAttributes.Add("data-bind", string.Format("value:{0}", name));
            else
                htmlAttributes["data-bind"] = htmlAttributes["data-bind"] + "," + string.Format("value:{0}", name);

            return InputExtensions.TextBox(htmlHelper, name, value, format, htmlAttributes);
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   name:
        //     窗体字段的名称和用于查找值的 System.Web.Mvc.ViewDataDictionary 键。
        //
        //   value:
        //     文本 input 元素的值。如果此值为 null，则将从 System.Web.Mvc.ViewDataDictionary 对象检索该元素的值。如果该对象中不存在任何值，则从
        //     System.Web.Mvc.ModelStateDictionary 对象检索该值。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBox(this HtmlHelper htmlHelper, string name, object value, string format, object htmlAttributes) 
        {
            IDictionary<string, object> attributes=null;
            if (null != htmlAttributes)
                attributes = HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);

            return KOTextBox(htmlHelper, name, value, format, attributes);
        }
        
         //摘要: 
         //    为由指定表达式表示的对象中的每个属性返回对应的文本 input 元素。
        
         //参数: 
         //  htmlHelper:
         //    此方法扩展的 HTML 帮助器实例。
        
         //  expression:
         //    一个表达式，用于标识包含要呈现的属性的对象。
        
         //类型参数: 
         //  TModel:
         //    模型的类型。
        
         //  TProperty:
         //    值的类型。
        
         //返回结果: 
         //    一个 HTML input 元素，其 type 特性针对表达式表示的对象中的每个属性均设置为“text”。
        
         //异常: 
         //  System.ArgumentException:
         //    expression 参数为 null 或为空。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression) 
        {
            return KOTextBoxFor(htmlHelper, expression, string.Empty, new Dictionary<string, object>());
        }
        //
        // 摘要: 
        //     使用指定的 HTML 特性，为由指定表达式表示的对象中的每个属性返回对应的文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   expression:
        //     一个表达式，用于标识包含要呈现的属性的对象。
        //
        //   htmlAttributes:
        //     一个包含要为该元素设置的 HTML 特性的字典。
        //
        // 类型参数: 
        //   TModel:
        //     模型的类型。
        //
        //   TProperty:
        //     值的类型。
        //
        // 返回结果: 
        //     一个 HTML input 元素，其 type 特性针对表达式表示的对象中的每个属性均设置为“text”。
        //
        // 异常: 
        //   System.ArgumentException:
        //     expression 参数为 null 或为空。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IDictionary<string, object> htmlAttributes) 
        {
            return KOTextBoxFor(htmlHelper, expression, string.Empty, htmlAttributes);
        }
        //
        // 摘要: 
        //     使用指定的 HTML 特性，为由指定表达式表示的对象中的每个属性返回对应的文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   expression:
        //     一个表达式，用于标识包含要呈现的属性的对象。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 类型参数: 
        //   TModel:
        //     模型的类型。
        //
        //   TProperty:
        //     值的类型。
        //
        // 返回结果: 
        //     一个 HTML input 元素，其 type 特性针对表达式表示的对象中的每个属性均设置为“text”。
        //
        // 异常: 
        //   System.ArgumentException:
        //     expression 参数为 null 或为空。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object attribute)
        {
            var htmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(attribute);
            return KOTextBoxFor(htmlHelper, expression, string.Empty, htmlAttributes);
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   expression:
        //     一个表达式，用于标识包含要显示的属性的对象。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        // 类型参数: 
        //   TModel:
        //     模型的类型。
        //
        //   TProperty:
        //     值的类型。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format)
        {
            return KOTextBoxFor(htmlHelper, expression, string.Empty, new Dictionary<string, object>());
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   expression:
        //     一个表达式，用于标识包含要显示的属性的对象。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 类型参数: 
        //   TModel:
        //     模型的类型。
        //
        //   TProperty:
        //     值的类型。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format, IDictionary<string, object> htmlAttributes)
        {
            if (null == htmlAttributes)
                htmlAttributes = new Dictionary<string, object>();

            var name = GetMemberName(expression);
            if (!htmlAttributes.ContainsKey("data-bind"))
                htmlAttributes.Add("data-bind", string.Format("value:{0}", name));
            else
                htmlAttributes["data-bind"] = htmlAttributes["data-bind"] + "," + string.Format("value:{0}", name);

            return InputExtensions.TextBoxFor(htmlHelper, expression, format, htmlAttributes);
        }
        //
        // 摘要: 
        //     返回文本 input 元素。
        //
        // 参数: 
        //   htmlHelper:
        //     此方法扩展的 HTML 帮助器实例。
        //
        //   expression:
        //     一个表达式，用于标识包含要显示的属性的对象。
        //
        //   format:
        //     用于设置输入格式的字符串。
        //
        //   htmlAttributes:
        //     一个对象，其中包含要为该元素设置的 HTML 特性。
        //
        // 类型参数: 
        //   TModel:
        //     模型的类型。
        //
        //   TProperty:
        //     值的类型。
        //
        // 返回结果: 
        //     一个 input 元素，其 type 特性设置为“text”。
        public static MvcHtmlString KOTextBoxFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, string format, object attribute)
        {
            var htmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(attribute);
            return KOTextBoxFor(htmlHelper, expression, string.Empty, htmlAttributes);
        }

         //摘要: 
         //    返回一个 HTML label 元素以及由指定表达式表示的属性的属性名称。
        
         //参数: 
         //  html:
         //    此方法扩展的 HTML 帮助器实例。
        
         //  expression:
         //    一个表达式，用于标识要显示的属性。
        
         //类型参数: 
         //  TModel:
         //    模型的类型。
        
         //  TValue:
         //    值的类型。
        
         //返回结果: 
         //    一个 HTML label 元素以及由表达式表示的属性的属性名称。
        public static MvcHtmlString KOLabelFor<TModel, TValue>(this HtmlHelper<TModel> html, Expression<Func<TModel, TValue>> expression)
        {
            var htmlAttributes = new Dictionary<string, object>();
            htmlAttributes.Add("data-bind", string.Format("text:{0}", GetMemberName(expression)));
            return LabelExtensions.LabelFor(html, expression, htmlAttributes);
        }


        #region TextArea
        public static MvcHtmlString KOTextAreaFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, object attribute)
        {
            var htmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(attribute);
            var name = GetMemberName(expression);
            if (!htmlAttributes.ContainsKey("data-bind"))
                htmlAttributes.Add("data-bind", string.Format("value:{0}", name));
            else
                htmlAttributes["data-bind"] = htmlAttributes["data-bind"] + "," + string.Format("value:{0}", name);
            return TextAreaExtensions.TextAreaFor(htmlHelper, expression, htmlAttributes);
        }
        #endregion

        #region Dropdown


        public static MvcHtmlString KODropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel) 
        {
            var htmlAttributes = new Dictionary<string, object>();
            var name = GetMemberName(expression);
            htmlAttributes.Add("data-bind", string.Format("value:{0}", name));
            return SelectExtensions.DropDownListFor(htmlHelper, expression, selectList, optionLabel, htmlAttributes);
        }

        public static MvcHtmlString KODropDownListFor<TModel, TProperty>(this HtmlHelper<TModel> htmlHelper, Expression<Func<TModel, TProperty>> expression, IEnumerable<SelectListItem> selectList, string optionLabel, object attribute) 
        {
            var htmlAttributes = HtmlHelper.AnonymousObjectToHtmlAttributes(attribute);
            var name = GetMemberName(expression);
            if (!htmlAttributes.ContainsKey("data-bind"))
                htmlAttributes.Add("data-bind", string.Format("value:{0}", name));
            else
                htmlAttributes["data-bind"] = htmlAttributes["data-bind"] + "," + string.Format("value:{0}", name);

            return SelectExtensions.DropDownListFor(htmlHelper, expression, selectList, optionLabel, htmlAttributes);
        }

        #endregion
    }
}