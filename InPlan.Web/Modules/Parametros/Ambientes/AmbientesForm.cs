using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Ambientes")]
[BasedOnRow(typeof(AmbientesRow), CheckNames = true)]
public class AmbientesForm
{
    [HalfWidth]
    public int IdEmpresa { get; set; }
    [HalfWidth]
    public int IdArea { get; set; }
    public string Descripcion { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}