using InPlan.Parametros;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion;

[ConnectionKey("Default"), Module("Implementacion"), TableName("EstadosDetalleImplementaciones")]
[DisplayName("Estados Detalle Implementaciones"), InstanceName("Estados Detalle Implementaciones")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class EstadosDetalleImplementacionesRow : Row<EstadosDetalleImplementacionesRow.RowFields>, IIdRow, INameRow
{
    const string jIdDetalleImplementacion = nameof(jIdDetalleImplementacion);
    const string jIdEstadoTarea = nameof(jIdEstadoTarea);
    const string jIdTecnicoTarea = nameof(jIdTecnicoTarea);
    const string jUser = nameof(jUser);

    class RowTemplate
    {
        [DisplayName("Id Estado Detalle Implementacion"), Identity, IdProperty]
        public int? IdEstadoDetalleImplementacion { get; set; }

        [LookupEditor(typeof(DetalleImplementacionesRow))]
        [DisplayName("Detalle Implementacion"), NotNull, ForeignKey("DetalleImplementaciones", "IdDetalleImplementacion"), LeftJoin(jIdDetalleImplementacion), TextualField(nameof(IdDetalleImplementacionOrden))]
        public int? IdDetalleImplementacion { get; set; }

        [LookupEditor(typeof(EstadosTareasRow))]
        [DisplayName("Estado Tarea"), NotNull, ForeignKey("EstadosTareas", "IdEstadoTarea"), LeftJoin(jIdEstadoTarea), TextualField(nameof(IdEstadoTareaDescripcion))]
        public int? IdEstadoTarea { get; set; }

        [LookupEditor(typeof(TecnicosRow))]
        [DisplayName("Técnico Tarea"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicoTarea), TextualField(nameof(IdTecnicoTareaNombreCompleto))]
        public int? IdTecnicoTarea { get; set; }

        [DisplayName("Fecha Estado"), NotNull]
        public DateTime? FechaEstado { get; set; }

        [DisplayName("Fecha Carga"), NotNull]
        public DateTime? FechaCarga { get; set; }

        [DisplayName("Notas Adicionales"), QuickSearch, NameProperty]
        public string NotasAdicionales { get; set; }

        [DisplayName("Documentos Adicionales"), MultipleFileUploadEditor]
        public string DocumentosAdicionales { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("User"), NotNull, ForeignKey("Users", "UserId"), LeftJoin(jUser), TextualField(nameof(Username))]
        public int? UserId { get; set; }

        [DisplayName("Detalle Implementación"), Expression($"{jIdDetalleImplementacion}.[Orden]")]
        public string IdDetalleImplementacionOrden { get; set; }

        [DisplayName("Estado"), Expression($"{jIdEstadoTarea}.[Descripcion]")]
        public string IdEstadoTareaDescripcion { get; set; }

        [DisplayName("Técnico"), Expression($"{jIdTecnicoTarea}.[NombreCompleto]")]
        public string IdTecnicoTareaNombreCompleto { get; set; }

        [DisplayName("User"), Expression($"{jUser}.[Username]")]
        public string Username { get; set; }
    }
}