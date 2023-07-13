using FluentMigrator;

namespace InPlan.Migrations.DefaultDB
{
    [Migration(20230712_2013)]
    public class DefaultDB_20230712_2013_Proyecto : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("ProyectosTecnologias")
                .WithColumn("IdProyectoTecnologia").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_ProyectosTecnologias_Proyectos", "Proyectos", "IdProyecto")
                .WithColumn("IdTecnologia").AsInt32().NotNullable()
                    .ForeignKey("FK_ProyectosTecnologias_Tecnologias", "Tecnologias", "IdTecnologia");



            Create.Table("TecnicosProyectos")
                .WithColumn("IdTecnicoProyecto").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_TecnicosProyectos_Proyectos", "Proyectos", "IdProyecto")
                .WithColumn("IdTecnico").AsInt32().NotNullable()
                    .ForeignKey("FK_TecnicosProyectos_Tecnologias", "Tecnicos", "IdTecnico")
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("Baja").AsBoolean().NotNullable().WithDefaultValue(false);



            Create.Table("AmbientesProyectos")
                .WithColumn("IdAmbienteProyecto").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_AmbientesProyectos_Proyectos", "Proyectos", "IdProyecto")
                .WithColumn("IdAmbiente").AsInt32().NotNullable()
                    .ForeignKey("FK_AmbientesProyectos_Ambientes", "Ambientes", "IdAmbiente")
                .WithColumn("ServidorDatos").AsString(int.MaxValue).Nullable()
                .WithColumn("InstaciaServidor").AsString(int.MaxValue).Nullable()
                .WithColumn("ServidorWeb").AsString(int.MaxValue).Nullable()
                .WithColumn("NotasAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("DocumentosRelacionados").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable();



            Create.Table("Implementaciones")
                .WithColumn("IdImplementacion").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("IdProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_Proyectos", "Proyectos", "IdProyecto")
                .WithColumn("IdAmbienteProyecto").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_AmbientesProyectos", "AmbientesProyectos", "IdAmbienteProyecto")
                .WithColumn("IdTecnicoSolicitante").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_TecnicoSocitante", "Tecnicos", "IdTecnico")
                .WithColumn("IdTecnicoImplementa").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_TecnicoImplementa", "Tecnicos", "IdTecnico")
                .WithColumn("IdTipoImplementacion").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_TiposImplementacion", "TiposImplementacion", "IdTipoImplementacion")
                .WithColumn("NroTicket").AsString(100).Nullable()
                .WithColumn("FechaSolicitud").AsDate().NotNullable()
                .WithColumn("FechaPlanificada").AsDate().NotNullable()
                .WithColumn("FechaImplementacion").AsDate().NotNullable()
                .WithColumn("ConsideracionesPrevias").AsString(250).Nullable()
                .WithColumn("Descripcion").AsString(250).Nullable()
                .WithColumn("ConsideracionesPosteriores").AsString(250).Nullable()
                .WithColumn("NotasAdicionales").AsString(250).Nullable()
                .WithColumn("DocumentosAdicionales").AsString(int.MaxValue).Nullable()
                .WithColumn("Observaciones").AsString(int.MaxValue).Nullable()
                .WithColumn("UserId").AsInt32().NotNullable()
                    .ForeignKey("FK_Implementacion_Users", "Users", "UserId");
        }
    }
}