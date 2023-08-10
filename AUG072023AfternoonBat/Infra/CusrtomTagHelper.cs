using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AUG072023AfternoonBat
{
    [HtmlTargetElement("IBMGreet-tag-helper")]
    public class GreetTagHelper : TagHelper
    {
        public string Name
        {
            get;
            set;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.PreContent.SetHtmlContent($"<h1>Hi {this.Name} , Greeting from Custom Tag Helper! </h1>");

        }
    }
}
