using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace InPlan.Parametros;

[ConnectionKey("Default"), Module("Parametros"), TableName("Tecnicos")]
[DisplayName("Tecnicos"), InstanceName("Tecnicos")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed partial class TecnicosRow : Row<TecnicosRow.RowFields>, IIdRow, INameRow
{
    const string jIdEmpresa = nameof(jIdEmpresa);
    const string jIdArea = nameof(jIdArea);

    class RowTemplate
    {
        [DisplayName("Id Tecnico"), Identity, IdProperty]
        public int? IdTecnico { get; set; }

        [DisplayName("Id Empresa"), NotNull, ForeignKey("Empresas", "IdEmpresa"), LeftJoin(jIdEmpresa), TextualField(nameof(IdEmpresaDescripcionCorta))]
        public int? IdEmpresa { get; set; }

        [DisplayName("Id Area"), NotNull, ForeignKey("Areas", "IdArea"), LeftJoin(jIdArea), TextualField(nameof(IdAreaDescripcion))]
        public int? IdArea { get; set; }

        [DisplayName("Nombre Completo"), Size(250), NotNull, QuickSearch, NameProperty]
        public string NombreCompleto { get; set; }

        [DisplayName("Celular"), Size(200)]
        public string Celular { get; set; }

        [DisplayName("Email"), Size(255)]
        public string Email { get; set; }

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