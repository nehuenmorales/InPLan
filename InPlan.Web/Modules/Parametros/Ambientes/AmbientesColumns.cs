using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Ambientes")]
[BasedOnRow(typeof(AmbientesRow), CheckNames = true)]
public class AmbientesColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdAmbiente { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    [Width(150)]
    public string IdAreaDescripcion { get; set; }
    [Width(150)]
    public string IdEmpresaDescripcionCorta { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}