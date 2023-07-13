using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(TecnicosProyectosRow))]
public class TecnicosProyectosPage : Controller
{
    [Route("Parametros/TecnicosProyectos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TecnicosProyectos/TecnicosProyectosPage",
            TecnicosProyectosRow.Fields.PageTitle());
    }
}