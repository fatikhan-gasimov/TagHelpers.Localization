using LazZiya.ExpressLocalization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace LazZiya.TagHelpers.Localization
{
    /// <summary>
    /// Localization tag helper, localize text inside <![CDATA[<localize>Hellow</localize>]]>
    /// </summary>
    /// 
    [HtmlTargetElement(Attributes = "localize*")]
    public class LocalizeAttributeTagHelper : LocalizationTagHelperBase
    {
        /// <summary>
        /// Bool value, true to localize content
        /// </summary>
        [HtmlAttributeName("localize-content")]
        public bool Localize { get; set; } = true;

        /// <summary>
        /// inject SharedCultureLocalizer
        /// </summary>
        /// <param name="loc"></param>
        public LocalizeAttributeTagHelper(SharedCultureLocalizer loc) : base(loc)
        {
        }
        /// <summary>
        /// process localize tag helper
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (Localize || (Args != null && Args.Length > 0) || !string.IsNullOrEmpty(Culture) || ResourceSource != null)
            {
                await base.ProcessAsync(context, output);
            }
        }
    }
}
