using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(TecnologiasRow))]
public class TecnologiasPage : Controller
{
    [Route("Parametros/Tecnologias")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Tecnologias/TecnologiasPage",
            TecnologiasRow.Fields.PageTitle());
    }
}