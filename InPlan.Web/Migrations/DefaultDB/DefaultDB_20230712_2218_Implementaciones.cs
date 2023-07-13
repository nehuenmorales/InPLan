using FluentMigrator;

namespace InPlan.Migrations.DefaultDB
{
    [Migration(20230712_2218)]
    public class DefaultDB_20230712_2218_Implementaciones : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("TecnicoProyectoTecnologias")
                .WithColumn("IdTecnicoProyectoTecnologia").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdTecnicoProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_TecnicoProyectoTecnologias_TecnicosProyectos", "TecnicosProyectos", "IdTEcnicoProyecto")
                .WithColumn("IdTecnologia").AsInt32().NotNullable()
                    .ForeignKey("FK_TecnicoProyectoTecnologias_Tecnologias", "Tecnologias", "IdTecnologia");



            Create.Table("DetalleImplementaciones")
                .WithColumn("IdDetalleImplementacion").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdImplementacion").AsInt32().NotNullable()
                    .ForeignKey("FK_DetalleImplementaciones_Implementaciones", "Implementaciones", "IdImplementacion")
                .WithColumn("IdTecnicoResponsable").AsInt32().NotNullable()
                    .ForeignKey("FK_DetalleImplementaciones_Tecnicos", "Tecnicos", "IdTecnico")
                .WithColumn("Orden").AsString(int.MaxValue).Nullable()
                .WithColumn("DescripcionTarea").AsString(int.MaxValue).Nullable()
                .WithColumn("NotasAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("DocumentosAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("FechaInicio").AsDate().NotNullable()
                .WithColumn("FechaFinalizacion").AsDate().NotNullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("IdEstadoTarea").AsInt32().NotNullable()
                    .ForeignKey("FK_DetalleImplementaciones_EstadosTareas", "EstadosTareas", "IdEstadoTarea");



            Create.Table("EstadosDetalleImplementaciones")
                .WithColumn("IdEstadoDetalleImplementacion").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdDetalleImplementacion").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementacione_DetalleImplementaciones", "DetalleImplementaciones", "IdDetalleImplementacion")
                .WithColumn("IdEstadoTarea").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementacione_EstadosTareas", "EstadosTareas", "IdEstadoTarea")
                .WithColumn("IdTecnicoTarea").AsInt32().NotNullable()
                   .ForeignKey("FK_EstadosDetalleImplementacione_Tecnicos", "Tecnicos", "IdTecnico")
                .WithColumn("FechaEstado").AsDate().NotNullable()
                .WithColumn("FechaCarga").AsDate().NotNullable()
                .WithColumn("NotasAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("DocumentosAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("UserId").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementaciones_Users", "Users", "UserId");



            Create.Table("DetalleImplementacionesRollBack")
               .WithColumn("IdDetalleImplementacionRollBack").AsInt32().Identity().PrimaryKey().NotNullable()
               .WithColumn("IdImplementacion").AsInt32().NotNullable()
                   .ForeignKey("FK_DetalleImplementacionesRollBack_Implementaciones", "Implementaciones", "IdImplementacion")
               .WithColumn("IdTecnicoResponsable").AsInt32().NotNullable()
                   .ForeignKey("FK_DetalleImplementacionesRollBack_Tecnicos", "Tecnicos", "IdTecnico")
               .WithColumn("Orden").AsString(int.MaxValue).Nullable()
               .WithColumn("DescripcionTarea").AsString(int.MaxValue).Nullable()
               .WithColumn("NotasAdicionales").AsString(int.MaxValue).Nullable()
               .WithColumn("DocumentosAdicionales").AsString(int.MaxValue).Nullable()
               .WithColumn("FechaInicio").AsDate().NotNullable()
               .WithColumn("FechaFinalizacion").AsDate().NotNullable()
               .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
               .WithColumn("IdEstadoTarea").AsInt32().NotNullable()
                   .ForeignKey("FK_DetalleImplementacionesRollBack_EstadosTareas", "EstadosTareas", "IdEstadoTarea");



            Create.Table("EstadosDetalleImplementacioneRollBack")
                .WithColumn("IdEstadoDetalleImplementacionRollBack").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdDetalleImplementacionRollBack").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementacioneRollBack_DetalleImplementacionesRollBack", "DetalleImplementacionesRollBack", "IdDetalleImplementacionRollBack")
                .WithColumn("IdEstadoTarea").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementacioneRollBack_EstadosTareas", "EstadosTareas", "IdEstadoTarea")
                .WithColumn("IdTecnicoTarea").AsInt32().NotNullable()
                   .ForeignKey("FK_EstadosDetalleImplementacioneRollBack_Tecnicos", "Tecnicos", "IdTecnico")
                .WithColumn("FechaEstado").AsDate().NotNullable()
                .WithColumn("FechaCarga").AsDate().NotNullable()
                .WithColumn("NotasAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("DocumentosAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("UserId").AsInt32().NotNullable()
                    .ForeignKey("FK_EstadosDetalleImplementacioneRollBack_Users", "Users", "UserId");

        }
    }
}