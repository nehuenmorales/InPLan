using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.EstadosTareas")]
[BasedOnRow(typeof(EstadosTareasRow), CheckNames = true)]
public class EstadosTareasForm
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