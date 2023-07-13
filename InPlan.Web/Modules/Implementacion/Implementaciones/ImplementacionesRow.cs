using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion;

[ConnectionKey("Default"), Module("Implementacion"), TableName("Implementaciones")]
[DisplayName("Implementaciones"), InstanceName("Implementaciones")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class ImplementacionesRow : Row<ImplementacionesRow.RowFields>, IIdRow, INameRow
{
    const string jIdProyecto = nameof(jIdProyecto);
    const string jIdAmbienteProyecto = nameof(jIdAmbienteProyecto);
    const string jIdTecnicoSolicitante = nameof(jIdTecnicoSolicitante);
    const string jIdTecnicoImplementa = nameof(jIdTecnicoImplementa);
    const string jIdTipoImplementacion = nameof(jIdTipoImplementacion);
    const string jUser = nameof(jUser);

    class RowTemplate
    {
        [DisplayName("Id Implementacion"), Identity, IdProperty]
        public int? IdImplementacion { get; set; }

        [DisplayName("Id Proyecto"), NotNull, ForeignKey("Proyectos", "IdProyecto"), LeftJoin(jIdProyecto), TextualField(nameof(IdProyectoNombreProyecto))]
        public int? IdProyecto { get; set; }

        [DisplayName("Id Ambiente Proyecto"), NotNull, ForeignKey("AmbientesProyectos", "IdAmbienteProyecto"), LeftJoin(jIdAmbienteProyecto), TextualField(nameof(IdAmbienteProyectoServidorDatos))]
        public int? IdAmbienteProyecto { get; set; }

        [DisplayName("Id Tecnico Solicitante"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicoSolicitante), TextualField(nameof(IdTecnicoSolicitanteNombreCompleto))]
        public int? IdTecnicoSolicitante { get; set; }

        [DisplayName("Id Tecnico Implementa"), NotNull, ForeignKey("Tecnicos", "IdTecnico"), LeftJoin(jIdTecnicoImplementa), TextualField(nameof(IdTecnicoImplementaNombreCompleto))]
        public int? IdTecnicoImplementa { get; set; }

        [DisplayName("Id Tipo Implementacion"), NotNull, ForeignKey("TiposImplementacion", "IdTipoImplementacion"), LeftJoin(jIdTipoImplementacion), TextualField(nameof(IdTipoImplementacionDescripcion))]
        public int? IdTipoImplementacion { get; set; }

        [DisplayName("Nro Ticket"), Size(100), QuickSearch, NameProperty]
        public string NroTicket { get; set; }

        [DisplayName("Fecha Solicitud"), NotNull]
        public DateTime? FechaSolicitud { get; set; }

        [DisplayName("Fecha Planificada"), NotNull]
        public DateTime? FechaPlanificada { get; set; }

        [DisplayName("Fecha Implementacion"), NotNull]
        public DateTime? FechaImplementacion { get; set; }

        [DisplayName("Consideraciones Previas"), Size(250)]
        public string ConsideracionesPrevias { get; set; }

        [DisplayName("Descripcion"), Size(250)]
        public string Descripcion { get; set; }

        [DisplayName("Consideraciones Posteriores"), Size(250)]
        public string ConsideracionesPosteriores { get; set; }

        [DisplayName("Notas Adicionales"), Size(250)]
        public string NotasAdicionales { get; set; }

        [DisplayName("Documentos Adicionales")]
        public string DocumentosAdicionales { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("User"), NotNull, ForeignKey("Users", "UserId"), LeftJoin(jUser), TextualField(nameof(Username))]
        public int? UserId { get; set; }

        [DisplayName("Id Proyecto Nombre Proyecto"), Expression($"{jIdProyecto}.[NombreProyecto]")]
        public string IdProyectoNombreProyecto { get; set; }

        [DisplayName("Id Ambiente Proyecto Servidor Datos"), Expression($"{jIdAmbienteProyecto}.[ServidorDatos]")]
        public string IdAmbienteProyectoServidorDatos { get; set; }

        [DisplayName("Id Tecnico Solicitante Nombre Completo"), Expression($"{jIdTecnicoSolicitante}.[NombreCompleto]")]
        public string IdTecnicoSolicitanteNombreCompleto { get; set; }

        [DisplayName("Id Tecnico Implementa Nombre Completo"), Expression($"{jIdTecnicoImplementa}.[NombreCompleto]")]
        public string IdTecnicoImplementaNombreCompleto { get; set; }

        [DisplayName("Id Tipo Implementacion Descripcion"), Expression($"{jIdTipoImplementacion}.[Descripcion]")]
        public string IdTipoImplementacionDescripcion { get; set; }

        [DisplayName("User Username"), Expression($"{jUser}.[Username]")]
        public string Username { get; set; }
    }
}