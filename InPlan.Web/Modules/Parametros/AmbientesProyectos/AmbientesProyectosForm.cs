using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.AmbientesProyectos")]
[BasedOnRow(typeof(AmbientesProyectosRow), CheckNames = true)]
public class AmbientesProyectosForm
{
    public int IdProyecto { get; set; }
    public int IdAmbiente { get; set; }
    public string ServidorDatos { get; set; }
    public string InstaciaServidor { get; set; }
    public string ServidorWeb { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosRelacionados { get; set; }
    public string Observaciones { get; set; }
}