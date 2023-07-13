using Serenity.ComponentModel;

namespace InPlan.Tenencia.Forms;

[FormScript("Tenencia.Areas")]
[BasedOnRow(typeof(AreasRow), CheckNames = true)]
public class AreasForm
{
    public int IdEmpresa { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}