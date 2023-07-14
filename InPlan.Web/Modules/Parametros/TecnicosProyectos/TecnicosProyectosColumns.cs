using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.TecnicosProyectos")]
[BasedOnRow(typeof(TecnicosProyectosRow), CheckNames = true)]
public class TecnicosProyectosColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTecnicoProyecto { get; set; }
    [Width(120), EditLink]
    public string IdProyectoNombreProyecto { get; set; }
    [Width(120)]
    public string IdTecnicosNombreCompleto { get; set; }
    [EditLink]
    public string Observaciones { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}