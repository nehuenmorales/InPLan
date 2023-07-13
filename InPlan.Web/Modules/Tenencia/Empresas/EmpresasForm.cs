using Serenity.ComponentModel;

namespace InPlan.Tenencia.Forms;

[FormScript("Tenencia.Empresas")]
[BasedOnRow(typeof(EmpresasRow), CheckNames = true)]
public class EmpresasForm
{
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}