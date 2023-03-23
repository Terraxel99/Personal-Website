using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace PersonalWebsite.ViewModels.Pages
{
    public class HomepageViewModel : ContentModel
    {
        public HomepageViewModel(IPublishedContent? content) : base(content)
        {
        }
    }
}
