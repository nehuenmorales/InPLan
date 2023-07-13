using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Ambientes")]
[BasedOnRow(typeof(AmbientesRow), CheckNames = true)]
public class AmbientesForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}