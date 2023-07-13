using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Tenencia.Columns;

[ColumnsScript("Tenencia.Areas")]
[BasedOnRow(typeof(AreasRow), CheckNames = true)]
public class AreasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdArea { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}