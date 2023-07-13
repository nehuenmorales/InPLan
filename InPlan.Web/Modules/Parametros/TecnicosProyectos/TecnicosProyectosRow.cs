using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("TecnicosProyectos")]
[DisplayName("Tecnicos Proyectos"), InstanceName("Tecnicos Proyectos")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class TecnicosProyectosRow : Row<TecnicosProyectosRow.RowFields>, IIdRow, INameRow
{
    const string jIdProyecto = nameof(jIdProyecto);
    const string jIdTecnicos = nameof(jIdTecnicos);

    class RowTemplate
    {
        [DisplayName("Id Tecnico Proyecto"), Identity, IdProperty]
        public int? IdTecnicoProyecto { get; set; }

        [DisplayName("Id Proyecto"), NotNull, ForeignKey("Proyectos", "IdProyecto"), LeftJoin(jIdProyecto), TextualField(nameof(IdProyectoNombreProyecto))]
        public int? IdProyecto { get; set; }

        [DisplayName("Id Tecnicos"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicos), TextualField(nameof(IdTecnicosNombreCompleto))]
        public int? IdTecnicos { get; set; }

        [DisplayName("Observaciones"), QuickSearch, NameProperty]
        public string Observaciones { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Proyecto Nombre Proyecto"), Expression($"{jIdProyecto}.[NombreProyecto]")]
        public string IdProyectoNombreProyecto { get; set; }

        [DisplayName("Id Tecnicos Nombre Completo"), Expression($"{jIdTecnicos}.[NombreCompleto]")]
        public string IdTecnicosNombreCompleto { get; set; }
    }
}