using Serenity.ComponentModel;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.TiposImplementacion")]
[BasedOnRow(typeof(TiposImplementacionRow), CheckNames = true)]
public class TiposImplementacionForm
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