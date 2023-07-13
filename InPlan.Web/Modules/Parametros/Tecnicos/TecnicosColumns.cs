using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Tecnicos")]
[BasedOnRow(typeof(TecnicosRow), CheckNames = true)]
public class TecnicosColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTecnico { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(150)]
    public string IdAreaDescripcion { get; set; }
    [EditLink, Width(150)]
    public string NombreCompleto { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    //public string Observaciones { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}