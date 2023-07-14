using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.TiposImplementacion")]
[BasedOnRow(typeof(TiposImplementacionRow), CheckNames = true)]
public class TiposImplementacionColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTipoImplementacion { get; set; }
    [EditLink, Width(150)]
    public string Descripcion { get; set; }
    //public string Observaciones { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(150)]
    public string IdAreaDescripcion { get; set; }
    public bool Baja { get; set; }
}