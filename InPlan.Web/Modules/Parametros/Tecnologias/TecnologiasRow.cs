using InPlan.Tenencia;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Tecnologias")]
[DisplayName("Tecnologías"), InstanceName("Tecnología")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class TecnologiasRow : Row<TecnologiasRow.RowFields>, IIdRow, INameRow
{
    const string jIdEmpresa = nameof(jIdEmpresa);
    const string jIdArea = nameof(jIdArea);

    class RowTemplate
    {
        [DisplayName("Id Tecnologia"), Identity, IdProperty]
        public int? IdTecnologia { get; set; }

        [LookupEditor(typeof(EmpresasRow))]
        [DisplayName("Empresa"), NotNull, ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaDescripcionCorta))]
        public int? IdEmpresa { get; set; }

        [LookupEditor(typeof(AreasRow))]
        [DisplayName("Área"), NotNull, ForeignKey("Areas", "IdArea"), LeftJoin(jIdArea), TextualField(nameof(IdAreaDescripcion))]
        public int? IdArea { get; set; }

        [DisplayName("Descripción"), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

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