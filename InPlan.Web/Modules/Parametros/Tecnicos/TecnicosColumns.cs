using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Tecnicos")]
[BasedOnRow(typeof(TecnicosRow), CheckNames = true)]
public class TecnicosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTecnico { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    public string IdAreaDescripcion { get; set; }
    [EditLink]
    public string NombreCompleto { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}