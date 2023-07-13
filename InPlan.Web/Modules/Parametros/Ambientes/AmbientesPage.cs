using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(AmbientesRow))]
public class AmbientesPage : Controller
{
    [Route("Parametros/Ambientes")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Ambientes/AmbientesPage",
            AmbientesRow.Fields.PageTitle());
    }
}