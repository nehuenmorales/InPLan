using Serenity.ComponentModel;

namespace InPlan.Tenencia.Forms;

[FormScript("Tenencia.Areas")]
[BasedOnRow(typeof(AreasRow), CheckNames = true)]
public class AreasForm
{
    [HalfWidth]
    public int IdEmpresa { get; set; }
    [HalfWidth]
    public string Descripcion { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}