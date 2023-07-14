using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Tenencia.Pages;

[PageAuthorize(typeof(AreasRow))]
public class AreasPage : Controller
{
    [Route("Tenencia/Areas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Tenencia/Areas/AreasPage",
            AreasRow.Fields.PageTitle());
    }
}