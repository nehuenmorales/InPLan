using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(AmbientesProyectosRow))]
public class AmbientesProyectosPage : Controller
{
    [Route("Parametros/AmbientesProyectos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/AmbientesProyectos/AmbientesProyectosPage",
            AmbientesProyectosRow.Fields.PageTitle());
    }
}