using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Tecnologias")]
[BasedOnRow(typeof(TecnologiasRow), CheckNames = true)]
public class TecnologiasColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTecnologia { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(150)]
    public string IdAreaDescripcion { get; set; }
    [EditLink, Width(100)]
    public string Descripcion { get; set; }
    //public string Observaciones { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}