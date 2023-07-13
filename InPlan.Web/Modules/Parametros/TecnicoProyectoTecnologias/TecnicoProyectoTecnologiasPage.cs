using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(TecnicoProyectoTecnologiasRow))]
public class TecnicoProyectoTecnologiasPage : Controller
{
    [Route("Parametros/TecnicoProyectoTecnologias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/TecnicoProyectoTecnologias/TecnicoProyectoTecnologiasPage",
            TecnicoProyectoTecnologiasRow.Fields.PageTitle());
    }
}