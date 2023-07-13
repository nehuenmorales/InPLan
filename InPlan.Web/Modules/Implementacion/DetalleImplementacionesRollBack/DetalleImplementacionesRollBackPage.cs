using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(DetalleImplementacionesRollBackRow))]
public class DetalleImplementacionesRollBackPage : Controller
{
    [Route("Implementacion/DetalleImplementacionesRollBack")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/DetalleImplementacionesRollBack/DetalleImplementacionesRollBackPage",
            DetalleImplementacionesRollBackRow.Fields.PageTitle());
    }
}