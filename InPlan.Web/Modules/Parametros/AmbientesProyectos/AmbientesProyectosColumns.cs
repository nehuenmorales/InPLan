using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.AmbientesProyectos")]
[BasedOnRow(typeof(AmbientesProyectosRow), CheckNames = true)]
public class AmbientesProyectosColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdAmbienteProyecto { get; set; }
    [Width(100), EditLink]
    public string IdProyectoNombreProyecto { get; set; }
    [Width(100)]
    public string IdAmbienteDescripcion { get; set; }
    [Width(200)]
    public string InstaciaServidor { get; set; }
    [Width(200), EditLink]
    public string ServidorWeb { get; set; }

    public string ServidorDatos { get; set; }
    public string NotasAdicionales { get; set; }
    //public string DocumentosRelacionados { get; set; }
    public string Observaciones { get; set; }
}