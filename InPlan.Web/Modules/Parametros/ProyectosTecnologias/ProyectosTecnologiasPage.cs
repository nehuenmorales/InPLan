using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(ProyectosTecnologiasRow))]
public class ProyectosTecnologiasPage : Controller
{
    [Route("Parametros/ProyectosTecnologias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/ProyectosTecnologias/ProyectosTecnologiasPage",
            ProyectosTecnologiasRow.Fields.PageTitle());
    }
}