using FluentMigrator;

namespace InPlan.Migrations.DefaultDB
{
    [Migration(20230712_1938)]
    public class DefaultDB_20230712_1938_EmpresaArea : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("Clientes")
                .WithColumn("IdCliente").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Clientes_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_Clientes_Areas", "Areas", "IdArea")
                .WithColumn("DescripcionCorta").AsString(200).NotNullable()
                .WithColumn("Descripcion").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("Tecnicos")
                .WithColumn("IdTecnico").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Tecnicos_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_Tecnicos_Areas", "Areas", "IdArea")
                .WithColumn("NombreCompleto").AsString(250).NotNullable()
                .WithColumn("Celular").AsString(200).Nullable()
                .WithColumn("Email").AsString(255).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("Ambientes")
                .WithColumn("IdAmbiente").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Ambientes_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_Ambientes_Areas", "Areas", "IdArea")
                .WithColumn("Descripcion").AsString(200).NotNullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("Tecnologias")
                .WithColumn("IdTecnologia").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Tecnologias_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_Tecnologias_Areas", "Areas", "IdArea")
                .WithColumn("Descripcion").AsString(int.MaxValue).NotNullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("Proyectos")
                .WithColumn("IdProyecto").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_Proyectos_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_Proyectos_Areas", "Areas", "IdArea")
                .WithColumn("NombreProyecto").AsString(250).NotNullable()
                .WithColumn("DescripcionProyecto").AsString(250).Nullable()
                .WithColumn("NroTicket").AsString(50).Nullable()
                .WithColumn("FechaCarga").AsDate().NotNullable().WithDefault(SystemMethods.CurrentDateTime)
                .WithColumn("FechaInicio").AsDate().NotNullable()
                .WithColumn("FechaFin").AsDate().Nullable()
                .WithColumn("DocumentosRelacionados").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("EstadosTareas")
                .WithColumn("IdEstadoTarea").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosTareas_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosTareas_Areas", "Areas", "IdArea")
                .WithColumn("Descripcion").AsString(int.MaxValue).NotNullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("TiposImplementacion")
                .WithColumn("IdTipoImplementacion").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdEmpresa").AsInt32().NotNullable()
                    .ForeignKey("FK_TiposImplementacion_Empresas", "Empresas", "IdEmpresa")
                .WithColumn("IdArea").AsInt32().NotNullable()
                    .ForeignKey("FK_TiposImplementacion_Areas", "Areas", "IdArea")
                .WithColumn("Descripcion").AsString(int.MaxValue).NotNullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);
        }
    }
}