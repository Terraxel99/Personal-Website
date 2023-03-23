using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

using PersonalWebsite.ViewModels.Pages;

using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;

namespace PersonalWebsite.Controllers
{
    public class HomepageController : RenderController
    {
        public HomepageController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor)
            : base(logger, compositeViewEngine, umbracoContextAccessor)
        { }

        public override IActionResult Index()
            => this.CurrentTemplate(new HomepageViewModel(this.CurrentPage));
    }
}
