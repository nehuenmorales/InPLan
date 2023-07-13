using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Implementacion;

[ConnectionKey("Default"), Module("Implementacion"), TableName("TiposImplementacion")]
[DisplayName("Tipos Implementacion"), InstanceName("Tipos Implementacion")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript]
public sealed partial class TiposImplementacionRow : Row<TiposImplementacionRow.RowFields>, IIdRow, INameRow
{
    const string jIdEmpresa = nameof(jIdEmpresa);
    const string jIdArea = nameof(jIdArea);

    class RowTemplate
    {
        [DisplayName("Id Tipo Implementacion"), Identity, IdProperty]
        public int? IdTipoImplementacion { get; set; }

        [DisplayName("Id Empresa"), NotNull, ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaDescripcionCorta))]
        public int? IdEmpresa { get; set; }

        [DisplayName("Id Area"), NotNull, ForeignKey("Areas", "IdArea"), LeftJoin(jIdArea), TextualField(nameof(IdAreaDescripcion))]
        public int? IdArea { get; set; }

        [DisplayName("Descripcion"), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Empresa Descripcion Corta"), Expression($"{jIdEmpresa}.[DescripcionCorta]")]
        public string IdEmpresaDescripcionCorta { get; set; }

        [DisplayName("Id Area Descripcion"), Expression($"{jIdArea}.[Descripcion]")]
        public string IdAreaDescripcion { get; set; }
    }
}