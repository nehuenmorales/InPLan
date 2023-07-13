using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(EstadosDetalleImplementacionesRow))]
public class EstadosDetalleImplementacionesPage : Controller
{
    [Route("Implementacion/EstadosDetalleImplementaciones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/EstadosDetalleImplementaciones/EstadosDetalleImplementacionesPage",
            EstadosDetalleImplementacionesRow.Fields.PageTitle());
    }
}