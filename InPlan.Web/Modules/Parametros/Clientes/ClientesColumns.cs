using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Clientes")]
[BasedOnRow(typeof(ClientesRow), CheckNames = true)]
public class ClientesColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdCliente { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(100)]
    public string IdAreaDescripcion { get; set; }
    [EditLink, Width(150)]
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    //public string Observaciones { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}