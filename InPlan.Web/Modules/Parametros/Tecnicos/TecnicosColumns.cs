using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Tecnicos")]
[BasedOnRow(typeof(TecnicosRow), CheckNames = true)]
public class TecnicosColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTecnico { get; set; }
    [EditLink]
    public string NombreCompleto { get; set; }
    [Width(130)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(130)]
    public string IdAreaDescripcion { get; set; }
    [Width(130)]
    public string Celular { get; set; }
    [Width(190)]
    public string Email { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}