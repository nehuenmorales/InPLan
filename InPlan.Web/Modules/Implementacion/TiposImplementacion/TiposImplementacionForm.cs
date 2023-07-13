using Serenity.ComponentModel;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.TiposImplementacion")]
[BasedOnRow(typeof(TiposImplementacionRow), CheckNames = true)]
public class TiposImplementacionForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}