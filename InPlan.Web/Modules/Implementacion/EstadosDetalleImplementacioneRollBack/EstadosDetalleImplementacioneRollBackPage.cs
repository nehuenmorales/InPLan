using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(EstadosDetalleImplementacioneRollBackRow))]
public class EstadosDetalleImplementacioneRollBackPage : Controller
{
    [Route("Implementacion/EstadosDetalleImplementacioneRollBack")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/EstadosDetalleImplementacioneRollBack/EstadosDetalleImplementacioneRollBackPage",
            EstadosDetalleImplementacioneRollBackRow.Fields.PageTitle());
    }
}