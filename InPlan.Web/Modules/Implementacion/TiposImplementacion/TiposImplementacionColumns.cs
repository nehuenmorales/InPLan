using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.TiposImplementacion")]
[BasedOnRow(typeof(TiposImplementacionRow), CheckNames = true)]
public class TiposImplementacionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTipoImplementacion { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    public string IdAreaDescripcion { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}