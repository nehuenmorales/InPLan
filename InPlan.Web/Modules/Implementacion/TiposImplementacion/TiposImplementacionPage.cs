using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Implementacion.Pages;

[PageAuthorize(typeof(TiposImplementacionRow))]
public class TiposImplementacionPage : Controller
{
    [Route("Implementacion/TiposImplementacion")]
    public ActionResult Index()
    {
        return this.GridPage("@/Implementacion/TiposImplementacion/TiposImplementacionPage",
            TiposImplementacionRow.Fields.PageTitle());
    }
}