using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Tenencia.Columns;

[ColumnsScript("Tenencia.Empresas")]
[BasedOnRow(typeof(EmpresasRow), CheckNames = true)]
public class EmpresasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdEmpresa { get; set; }
    [EditLink]
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}