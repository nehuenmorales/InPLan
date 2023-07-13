using Serenity.ComponentModel;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.TecnicoProyectoTecnologias")]
[BasedOnRow(typeof(TecnicoProyectoTecnologiasRow), CheckNames = true)]
public class TecnicoProyectoTecnologiasColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdTecnicoProyectoTecnologia { get; set; }
    public string IdTecnicoProyectoObservaciones { get; set; }
    public string IdTecnologiaDescripcion { get; set; }
}