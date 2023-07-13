using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Tenencia.Columns;

[ColumnsScript("Tenencia.Areas")]
[BasedOnRow(typeof(AreasRow), CheckNames = true)]
public class AreasColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdArea { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [EditLink, Width(150)]
    public string Descripcion { get; set; }
    [Width(100)]
    public string Observaciones { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}