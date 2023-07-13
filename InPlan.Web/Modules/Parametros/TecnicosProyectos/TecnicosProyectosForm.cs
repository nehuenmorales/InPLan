using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.TecnicosProyectos")]
[BasedOnRow(typeof(TecnicosProyectosRow), CheckNames = true)]
public class TecnicosProyectosForm
{
    public int IdProyecto { get; set; }
    public int IdTecnicos { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}