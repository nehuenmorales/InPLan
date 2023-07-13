using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("AmbientesProyectos")]
[DisplayName("Ambientes Proyectos"), InstanceName("Ambientes Proyectos")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class AmbientesProyectosRow : Row<AmbientesProyectosRow.RowFields>, IIdRow, INameRow
{
    const string jIdProyecto = nameof(jIdProyecto);
    const string jIdAmbiente = nameof(jIdAmbiente);

    class RowTemplate
    {
        [DisplayName("Id Ambiente Proyecto"), Identity, IdProperty]
        public int? IdAmbienteProyecto { get; set; }

        [DisplayName("Id Proyecto"), NotNull, ForeignKey("Proyectos", "IdProyecto"), LeftJoin(jIdProyecto), TextualField(nameof(IdProyectoNombreProyecto))]
        public int? IdProyecto { get; set; }

        [DisplayName("Id Ambiente"), NotNull, ForeignKey("Ambientes", "IdAmbiente"), LeftJoin(jIdAmbiente), TextualField(nameof(IdAmbienteDescripcion))]
        public int? IdAmbiente { get; set; }

        [DisplayName("Servidor Datos"), QuickSearch, NameProperty]
        public string ServidorDatos { get; set; }

        [DisplayName("Instacia Servidor")]
        public string InstaciaServidor { get; set; }

        [DisplayName("Servidor Web")]
        public string ServidorWeb { get; set; }

        [DisplayName("Notas Adicionales")]
        public string NotasAdicionales { get; set; }

        [DisplayName("Documentos Relacionados")]
        public string DocumentosRelacionados { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Id Proyecto Nombre Proyecto"), Expression($"{jIdProyecto}.[NombreProyecto]")]
        public string IdProyectoNombreProyecto { get; set; }

        [DisplayName("Id Ambiente Descripcion"), Expression($"{jIdAmbiente}.[Descripcion]")]
        public string IdAmbienteDescripcion { get; set; }
    }
}