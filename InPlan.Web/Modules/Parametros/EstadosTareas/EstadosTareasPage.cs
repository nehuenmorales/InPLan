using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(EstadosTareasRow))]
public class EstadosTareasPage : Controller
{
    [Route("Parametros/EstadosTareas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/EstadosTareas/EstadosTareasPage",
            EstadosTareasRow.Fields.PageTitle());
    }
}