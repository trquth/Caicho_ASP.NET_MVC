using System.Web.Mvc;

namespace Caicho.Demo.Areas.Web2
{
    public class Web2AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Web2";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Web2_default",
                "w/{controller}/{action}/{id}",
                new { action = "Index",controller = "Home", id = UrlParameter.Optional },
                namespaces: new string[] { "Caicho.Demo.Areas.Web2.Controllers" }
            );
        }
    }
}