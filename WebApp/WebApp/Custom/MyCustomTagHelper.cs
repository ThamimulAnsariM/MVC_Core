using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.Custom
{
    [HtmlTargetElement("custom")]
    public class MyCustomTagHelper:TagHelper
    {
        public string Message { get; set; } //Dynamically pass message and reuse this for taghelper.

        public ModelExpression ProductName { get; set; }

        //public override void Process(TagHelperContext context, TagHelperOutput output)
        //{
        //    //output.Content.SetHtmlContent("<div class='alert alert-warning'>This is a custom tag helper </div>");
        //    output.Content.SetHtmlContent($"<div class='alert alert-warning'>{Message}</div>");

        //}
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";
            var existingContext =await output.GetChildContentAsync();
            var existingdata=existingContext.GetContent();
            var names=existingdata.Split(",",StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in names)
            {
                output.Content.AppendHtml($"<li>{item}</li>");
            }
            //return base.ProcessAsync(context, output);
        }
    }
}
