using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace InPlan.Parametros.Pages;

[PageAuthorize(typeof(ClientesRow))]
public class ClientesPage : Controller
{
    [Route("Parametros/Clientes")]
    public ActionResult Index()
    {
        return this.GridPage("@/Parametros/Clientes/ClientesPage",
            ClientesRow.Fields.PageTitle());
    }
}