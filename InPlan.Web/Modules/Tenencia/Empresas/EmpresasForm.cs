using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Tenencia.Forms;

[FormScript("Tenencia.Empresas")]
[BasedOnRow(typeof(EmpresasRow), CheckNames = true)]
public class EmpresasForm
{
    [DisplayName("Nombre")]
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}