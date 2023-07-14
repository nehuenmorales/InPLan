using InPlan.Parametros;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion;

[ConnectionKey("Default"), Module("Implementacion"), TableName("DetalleImplementaciones")]
[DisplayName("Detalle Implementaciones"), InstanceName("Detalle Implementaciones")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class DetalleImplementacionesRow : Row<DetalleImplementacionesRow.RowFields>, IIdRow, INameRow
{
    const string jIdImplementacion = nameof(jIdImplementacion);
    const string jIdTecnicoResponsable = nameof(jIdTecnicoResponsable);
    const string jIdEstadoTarea = nameof(jIdEstadoTarea);

    class RowTemplate
    {
        [DisplayName("Id Detalle Implementacion"), Identity, IdProperty]
        public int? IdDetalleImplementacion { get; set; }

        [LookupEditor(typeof(ImplementacionesRow))]
        [DisplayName("Implementación"), NotNull, ForeignKey("Implementaciones", "IdImplementacion"), LeftJoin(jIdImplementacion), TextualField(nameof(IdImplementacionNroTicket))]
        public int? IdImplementacion { get; set; }

        [LookupEditor(typeof(TecnicosRow))]
        [DisplayName("Tecnico"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicoResponsable), TextualField(nameof(IdTecnicoResponsableNombreCompleto))]
        public int? IdTecnicoResponsable { get; set; }

        [DisplayName("Orden"), QuickSearch, NameProperty]
        public string Orden { get; set; }

        [DisplayName("Descripción Tarea")]
        public string DescripcionTarea { get; set; }

        [DisplayName("Notas Adicionales")]
        public string NotasAdicionales { get; set; }

        [DisplayName("Documentos Adicionales"), MultipleFileUploadEditor]
        public string DocumentosAdicionales { get; set; }

        [DisplayName("Fecha Inicio"), NotNull]
        public DateTime? FechaInicio { get; set; }

        [DisplayName("Fecha Finalización")]
        public DateTime? FechaFinalizacion { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [LookupEditor(typeof(EstadosTareasRow))]
        [DisplayName("Estado Tarea"), NotNull, ForeignKey("EstadosTareas", "IdEstadoTarea"), LeftJoin(jIdEstadoTarea), TextualField(nameof(IdEstadoTareaDescripcion))]
        public int? IdEstadoTarea { get; set; }

        [DisplayName("Implementación"), Expression($"{jIdImplementacion}.[NroTicket]")]
        public string IdImplementacionNroTicket { get; set; }

        [DisplayName("Técnico"), Expression($"{jIdTecnicoResponsable}.[NombreCompleto]")]
        public string IdTecnicoResponsableNombreCompleto { get; set; }

        [DisplayName("Estado Tarea Descripción"), Expression($"{jIdEstadoTarea}.[Descripcion]")]
        public string IdEstadoTareaDescripcion { get; set; }
    }
}