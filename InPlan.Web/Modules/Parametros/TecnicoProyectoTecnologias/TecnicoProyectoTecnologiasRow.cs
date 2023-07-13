using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TecnicoProyectoTecnologias")]
[DisplayName("Tecnico Proyecto Tecnologias"), InstanceName("Tecnico Proyecto Tecnologias")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class TecnicoProyectoTecnologiasRow : Row<TecnicoProyectoTecnologiasRow.RowFields>, IIdRow
{
    const string jIdTecnicoProyecto = nameof(jIdTecnicoProyecto);
    const string jIdTecnologia = nameof(jIdTecnologia);

    class RowTemplate
    {
        [DisplayName("Id Tecnico Proyecto Tecnologia"), Identity, IdProperty]
        public int? IdTecnicoProyectoTecnologia { get; set; }

        [LookupEditor(typeof(TecnicosRow))]
        [DisplayName("Técnico"), NotNull, ForeignKey("TecnicosProyectos", "IdTecnicoProyecto"), LeftJoin(jIdTecnicoProyecto), TextualField(nameof(IdTecnicoProyectoObservaciones))]
        public int? IdTecnicoProyecto { get; set; }

        [LookupEditor(typeof(TecnologiasRow))]
        [DisplayName("Tecnología"), NotNull, ForeignKey("Tecnologias", "IdTecnologia"), LeftJoin(jIdTecnologia), TextualField(nameof(IdTecnologiaDescripcion))]
        public int? IdTecnologia { get; set; }

        [DisplayName("Observaciones"), Expression($"{jIdTecnicoProyecto}.[Observaciones]")]
        public string IdTecnicoProyectoObservaciones { get; set; }

        [DisplayName("Descripción"), Expression($"{jIdTecnologia}.[Descripcion]")]
        public string IdTecnologiaDescripcion { get; set; }
    }
}