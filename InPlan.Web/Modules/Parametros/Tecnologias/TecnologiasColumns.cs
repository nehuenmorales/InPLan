using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Tecnologias")]
[BasedOnRow(typeof(TecnologiasRow), CheckNames = true)]
public class TecnologiasColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdTecnologia { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    public string IdAreaDescripcion { get; set; }
    [EditLink]
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}