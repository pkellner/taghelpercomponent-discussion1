using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelperComponentApp
{
    public class GoogleAnalyticsTagHelperComponent : TagHelperComponent
    {
        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "body", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml("<script>console.log('Pretend this is google analytics code being injected by GoogleAnalyticsTagHelperComponent ');</script>");
            }
            return Task.CompletedTask;
        }
    }
}
