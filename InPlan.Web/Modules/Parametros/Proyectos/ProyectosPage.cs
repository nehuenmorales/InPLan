using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(ProyectosRow))]
public class ProyectosPage : Controller
{
    [Route("Parametros/Proyectos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Proyectos/ProyectosPage",
            ProyectosRow.Fields.PageTitle());
    }
}