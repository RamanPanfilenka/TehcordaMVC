using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TehcordaMVC.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var targetMail = (await output.GetChildContentAsync()).GetContent();
            output.Attributes.SetAttribute("href", $"mailto:{targetMail}");
            output.Content.SetContent(targetMail);
        }
    }
}
