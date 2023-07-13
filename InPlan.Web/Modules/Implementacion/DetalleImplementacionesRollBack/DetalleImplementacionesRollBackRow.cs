using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion;

[ConnectionKey("Default"), Module("Implementacion"), TableName("DetalleImplementacionesRollBack")]
[DisplayName("Detalle Implementaciones Roll Back"), InstanceName("Detalle Implementaciones Roll Back")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class DetalleImplementacionesRollBackRow : Row<DetalleImplementacionesRollBackRow.RowFields>, IIdRow, INameRow
{
    const string jIdImplementacion = nameof(jIdImplementacion);
    const string jIdTecnicoResponsable = nameof(jIdTecnicoResponsable);
    const string jIdEstadoTarea = nameof(jIdEstadoTarea);

    class RowTemplate
    {
        [DisplayName("Id Detalle Implementacion Roll Back"), Identity, IdProperty]
        public int? IdDetalleImplementacionRollBack { get; set; }

        [DisplayName("Id Implementacion"), NotNull, ForeignKey("Implementaciones", "IdImplementacion"), LeftJoin(jIdImplementacion), TextualField(nameof(IdImplementacionNroTicket))]
        public int? IdImplementacion { get; set; }

        [DisplayName("Id Tecnico Responsable"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicoResponsable), TextualField(nameof(IdTecnicoResponsableNombreCompleto))]
        public int? IdTecnicoResponsable { get; set; }

        [DisplayName("Orden"), QuickSearch, NameProperty]
        public string Orden { get; set; }

        [DisplayName("Descripcion Tarea")]
        public string DescripcionTarea { get; set; }

        [DisplayName("Notas Adicionales")]
        public string NotasAdicionales { get; set; }

        [DisplayName("Documentos Adicionales")]
        public string DocumentosAdicionales { get; set; }

        [DisplayName("Fecha Inicio"), NotNull]
        public DateTime? FechaInicio { get; set; }

        [DisplayName("Fecha Finalizacion"), NotNull]
        public DateTime? FechaFinalizacion { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Id Estado Tarea"), NotNull, ForeignKey("EstadosTareas", "IdEstadoTarea"), LeftJoin(jIdEstadoTarea), TextualField(nameof(IdEstadoTareaDescripcion))]
        public int? IdEstadoTarea { get; set; }

        [DisplayName("Id Implementacion Nro Ticket"), Expression($"{jIdImplementacion}.[NroTicket]")]
        public string IdImplementacionNroTicket { get; set; }

        [DisplayName("Id Tecnico Responsable Nombre Completo"), Expression($"{jIdTecnicoResponsable}.[NombreCompleto]")]
        public string IdTecnicoResponsableNombreCompleto { get; set; }

        [DisplayName("Id Estado Tarea Descripcion"), Expression($"{jIdEstadoTarea}.[Descripcion]")]
        public string IdEstadoTareaDescripcion { get; set; }
    }
}