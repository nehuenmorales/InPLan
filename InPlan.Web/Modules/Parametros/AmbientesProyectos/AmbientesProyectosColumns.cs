using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.AmbientesProyectos")]
[BasedOnRow(typeof(AmbientesProyectosRow), CheckNames = true)]
public class AmbientesProyectosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdAmbienteProyecto { get; set; }
    public string IdProyectoNombreProyecto { get; set; }
    public string IdAmbienteDescripcion { get; set; }
    [EditLink]
    public string ServidorDatos { get; set; }
    public string InstaciaServidor { get; set; }
    public string ServidorWeb { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosRelacionados { get; set; }
    public string Observaciones { get; set; }
}