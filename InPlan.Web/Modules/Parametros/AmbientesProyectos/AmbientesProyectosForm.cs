using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.AmbientesProyectos")]
[BasedOnRow(typeof(AmbientesProyectosRow), CheckNames = true)]
public class AmbientesProyectosForm
{
    [Tab("Datos")]
    [HalfWidth]
    public int IdProyecto { get; set; }
    [HalfWidth]
    public int IdAmbiente { get; set; }
    public string ServidorWeb { get; set; }
    public string InstaciaServidor { get; set; }
    [HalfWidth, TextAreaEditor(Rows = 4)]
    public string ServidorDatos { get; set; }
    [HalfWidth, TextAreaEditor(Rows = 4)]
    public string NotasAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [Tab("Documentos")]
    public string DocumentosRelacionados { get; set; }
}