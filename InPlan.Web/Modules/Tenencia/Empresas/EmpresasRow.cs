using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Tenencia;

[ConnectionKey("Default"), Module("Tenencia"), TableName("Empresas")]
[DisplayName("Empresas"), InstanceName("Empresas")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class EmpresasRow : Row<EmpresasRow.RowFields>, IIdRow, INameRow
{
    class RowTemplate
    {
        [DisplayName("Id Empresa"), Identity, IdProperty]
        public int? IdEmpresa { get; set; }

        [DisplayName("Empresa"), Size(200), NotNull, QuickSearch, NameProperty]
        public string DescripcionCorta { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

        [DisplayName("Observaciones")]
        public string Observaciones { get; set; }

        [DisplayName("Baja"), NotNull]
        public bool? Baja { get; set; }
    }
}