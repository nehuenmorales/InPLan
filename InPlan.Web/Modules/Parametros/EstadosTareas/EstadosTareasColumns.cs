using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.EstadosTareas")]
[BasedOnRow(typeof(EstadosTareasRow), CheckNames = true)]
public class EstadosTareasColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdEstadoTarea { get; set; }
    [EditLink]
    [Width(130)]
    public string Descripcion { get; set; }
    [Width(130)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(130)]
    public string IdAreaDescripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}