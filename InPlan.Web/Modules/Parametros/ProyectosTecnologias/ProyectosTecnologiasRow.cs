using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("ProyectosTecnologias")]
[DisplayName("Proyectos Tecnologias"), InstanceName("Proyectos Tecnologias")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class ProyectosTecnologiasRow : Row<ProyectosTecnologiasRow.RowFields>, IIdRow
{
    const string jIdProyecto = nameof(jIdProyecto);
    const string jIdTecnologia = nameof(jIdTecnologia);

    class RowTemplate
    {
        [DisplayName("Id Proyecto Tecnologia"), Identity, IdProperty]
        public int? IdProyectoTecnologia { get; set; }

        [DisplayName("Id Proyecto"), NotNull, ForeignKey("Proyectos", "IdProyecto"), LeftJoin(jIdProyecto), TextualField(nameof(IdProyectoNombreProyecto))]
        public int? IdProyecto { get; set; }

        [DisplayName("Id Tecnologia"), NotNull, ForeignKey("Tecnologias", "IdTecnologia"), LeftJoin(jIdTecnologia), TextualField(nameof(IdTecnologiaDescripcion))]
        public int? IdTecnologia { get; set; }

        [DisplayName("Id Proyecto Nombre Proyecto"), Expression($"{jIdProyecto}.[NombreProyecto]")]
        public string IdProyectoNombreProyecto { get; set; }

        [DisplayName("Id Tecnologia Descripcion"), Expression($"{jIdTecnologia}.[Descripcion]")]
        public string IdTecnologiaDescripcion { get; set; }
    }
}