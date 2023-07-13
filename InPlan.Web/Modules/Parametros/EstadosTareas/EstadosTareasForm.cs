using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.EstadosTareas")]
[BasedOnRow(typeof(EstadosTareasRow), CheckNames = true)]
public class EstadosTareasForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}