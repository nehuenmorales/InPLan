using InPlan.Tenencia;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Proyectos")]
[DisplayName("Proyectos"), InstanceName("Proyecto")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class ProyectosRow : Row<ProyectosRow.RowFields>, IIdRow, INameRow
{
    const string jIdEmpresa = nameof(jIdEmpresa);
    const string jIdArea = nameof(jIdArea);

    class RowTemplate
    {
        [DisplayName("Id Proyecto"), Identity, IdProperty]
        public int? IdProyecto { get; set; }

        [LookupEditor(typeof(EmpresasRow))]
        [DisplayName("Empresa"), NotNull, ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaDescripcionCorta))]
        public int? IdEmpresa { get; set; }

        [LookupEditor(typeof(AreasRow))]
        [DisplayName("Área"), NotNull, ForeignKey("Areas", "IdArea"), LeftJoin(jIdArea), TextualField(nameof(IdAreaDescripcion))]
        public int? IdArea { get; set; }

        [DisplayName("Nombre"), Size(250), NotNull, QuickSearch, NameProperty]
        public string NombreProyecto { get; set; }

        [DisplayName("Descripción"), Size(250)]
        public string DescripcionProyecto { get; set; }

        [DisplayName("Nro Ticket"), Size(50)]
        public string NroTicket { get; set; }

        [DisplayName("Fecha Carga"), NotNull]
        public DateTime? FechaCarga { get; set; }

        [DisplayName("Fecha Inicio"), NotNull]
        public DateTime? FechaInicio { get; set; }

        [DisplayName("Fecha Fin")]
        public DateTime? FechaFin { get; set; }

        [DisplayName("Documentos Relacionados"), MultipleFileUploadEditor]
        public string DocumentosRelacionados { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Empresa"), Expression($"{jIdEmpresa}.[DescripcionCorta]")]
        public string IdEmpresaDescripcionCorta { get; set; }

        [DisplayName("Área"), Expression($"{jIdArea}.[Descripcion]")]
        public string IdAreaDescripcion { get; set; }
    }
}