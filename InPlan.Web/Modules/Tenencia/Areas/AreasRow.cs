using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Tenencia;

[ConnectionKey("Default"), Module("Tenencia"), TableName("Areas")]
[DisplayName("Areas"), InstanceName("Areas")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class AreasRow : Row<AreasRow.RowFields>, IIdRow, INameRow
{
    const string jIdEmpresa = nameof(jIdEmpresa);

    class RowTemplate
    {
        [DisplayName("Id Area"), Identity, IdProperty]
        public int? IdArea { get; set; }

        [DisplayName("Id Empresa"), NotNull, ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaDescripcionCorta))]
        public int? IdEmpresa { get; set; }

        [DisplayName("Descripcion"), Size(200), NotNull, QuickSearch, NameProperty]
        public string Descripcion { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }

        [DisplayName("Id Empresa Descripcion Corta"), Expression($"{jIdEmpresa}.[DescripcionCorta]")]
        public string IdEmpresaDescripcionCorta { get; set; }
    }
}