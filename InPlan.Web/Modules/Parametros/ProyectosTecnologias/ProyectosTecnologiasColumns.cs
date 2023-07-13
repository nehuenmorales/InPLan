using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.ProyectosTecnologias")]
[BasedOnRow(typeof(ProyectosTecnologiasRow), CheckNames = true)]
public class ProyectosTecnologiasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdProyectoTecnologia { get; set; }
    public string IdProyectoNombreProyecto { get; set; }
    public string IdTecnologiaDescripcion { get; set; }
}