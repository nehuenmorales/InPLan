using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Clientes")]
[BasedOnRow(typeof(ClientesRow), CheckNames = true)]
public class ClientesColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdCliente { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    public string IdAreaDescripcion { get; set; }
    [EditLink]
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}