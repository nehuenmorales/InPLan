using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.TecnicosProyectos")]
[BasedOnRow(typeof(TecnicosProyectosRow), CheckNames = true)]
public class TecnicosProyectosForm
{
    [HalfWidth]
    public int IdProyecto { get; set; }
    [HalfWidth]
    public int IdTecnico { get; set; }
    [TextAreaEditor( Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}