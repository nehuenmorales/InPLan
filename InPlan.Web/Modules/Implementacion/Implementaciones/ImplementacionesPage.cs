using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(ImplementacionesRow))]
public class ImplementacionesPage : Controller
{
    [Route("Implementacion/Implementaciones")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/Implementaciones/ImplementacionesPage",
            ImplementacionesRow.Fields.PageTitle());
    }
}