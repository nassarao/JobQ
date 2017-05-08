using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace JobQUI.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString AlertError(this HtmlHelper htmlHelper, ModelErrorCollection errors)
        {
            StringBuilder builder = new StringBuilder();
            if (errors.Count > 0)
            {
                builder.Append("<div class=\"alert alert-danger\"> <ul>");
                foreach (ModelError error in errors)
                {
                    builder.Append("<li>" + error.ErrorMessage + "</li>");
                }
                builder.Append("</ul></div>");
            }
            MvcHtmlString temp = new MvcHtmlString(builder.ToString());
            return temp;

        }

        public static MvcHtmlString AlertWarning(this HtmlHelper htmlHelper, ModelErrorCollection warnings)
        {
            StringBuilder builder = new StringBuilder();
            if (warnings.Count > 0)
            {
                builder.Append("<div class=\"alert alert-warning\"> <ul>");
                foreach (ModelError warn in warnings)
                {
                    builder.Append("<li>" + warn.ErrorMessage + "</li>");
                }
                builder.Append("</ul></div>");
            }
            MvcHtmlString temp = new MvcHtmlString(builder.ToString());
            return temp;
        }
    }
}