using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(TecnicosRow))]
public class TecnicosPage : Controller
{
    [Route("Parametros/Tecnicos")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Tecnicos/TecnicosPage",
            TecnicosRow.Fields.PageTitle());
    }
}