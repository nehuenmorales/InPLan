using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(DetalleImplementacionesRow))]
public class DetalleImplementacionesPage : Controller
{
    [Route("Implementacion/DetalleImplementaciones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/DetalleImplementaciones/DetalleImplementacionesPage",
            DetalleImplementacionesRow.Fields.PageTitle());
    }
}