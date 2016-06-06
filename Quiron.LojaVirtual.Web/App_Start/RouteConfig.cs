using System.Web.Mvc;
using System.Web.Routing;

namespace Quiron.LojaVirtual.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // 1 - /
            routes.MapRoute(null, "",
                new
                {
                    controller = "Vitrine",
                    action = "VitrineListaProdutoViewModel",
                    categoria = (string)null,
                    pagina = 1
                });

            // 2 - Pagina/1
            routes.MapRoute(null, "Vitrine{pagina}",
            new
            {
                controller = "Vitrine",
                action = "VitrineListaProdutoViewModel",
                categoria = (string)null
            },
            new { pagina = @"\d+" });

            // 3 Categoria
            routes.MapRoute(null, "{categoria}",
                new
                {
                    Controller = "Vitrine",
                    action = "VitrineListaProdutoViewModel",
                    pagina = 1
                });

            // 4 Categoria/Pagina1
            routes.MapRoute(null, "{categoria}/Vitrine{pagina}",
            new
            {
                controller = "Vitrine",
                action = "VitrineListaProdutoViewModel"
            },
            new { pagina = @"\d+" });

           // routes.MapRoute(null, "{controller}/{action}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
