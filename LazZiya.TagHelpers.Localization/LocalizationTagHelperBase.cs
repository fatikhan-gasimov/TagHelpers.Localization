using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace LazZiya.TagHelpers.Localization
{
    /// <summary>
    /// base class for localize tag helpers
    /// </summary>
    public class LocalizationTagHelperBase : TagHelper
    {
        private readonly SharedCultureLocalizer _loc;

        /// <summary>
        /// pass array of objects for arguments
        /// </summary>
        [HtmlAttributeName("localize-args")]
        public object[] Args { get; set; }

        /// <summary>
        /// inject SharedCultureLocalizer
        /// </summary>
        /// <param name="loc"></param>
        public LocalizationTagHelperBase(SharedCultureLocalizer loc)
        {
            _loc = loc;
        }
        
        /// <summary>
        /// process localize tag helper
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var content = await output.GetChildContentAsync();

            if (!string.IsNullOrWhiteSpace(content.GetContent()))
            {
                var str = content.GetContent().Trim();

                var _localStr = _loc.Text(str, Args);

                output.Content.SetHtmlContent(_localStr);
            }
        }
    }
}
