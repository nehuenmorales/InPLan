using FluentMigrator;

namespace InPlan.Migrations.DefaultDB
{
    [Migration(20230712_1927)]
    public class DefaultDB_20230712_1927_Tennant : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Empresas")
                .WithColumn("IdEmpresa").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("DescripcionCorta").AsString(200).NotNullable()
                .WithColumn("Descripcion").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("Areas")
                .WithColumn("IdArea").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Areas_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("Descripcion").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);

        }
    }
}