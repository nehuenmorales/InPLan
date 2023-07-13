using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Tenencia.Pages;

[PageAuthorize(typeof(EmpresasRow))]
public class EmpresasPage : Controller
{
    [Route("Tenencia/Empresas")]
    public ActionResult Index()
    {
        return this.GridPage("@/Tenencia/Empresas/EmpresasPage",
            EmpresasRow.Fields.PageTitle());
    }
}