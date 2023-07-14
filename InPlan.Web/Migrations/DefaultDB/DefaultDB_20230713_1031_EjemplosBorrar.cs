using FluentMigrator;
using System;

namespace InPlan.Migrations.DefaultDB
{
    [Migration(20230713_1031)]
    public class DefaultDB_20230713_1031_EjemplosBorrar : AutoReversingMigration
    {
        public override void Up()
        {
            Insert.IntoTable("Empresas").Row(new
            {
                DescripcionCorta = "Ejemplos S.A.",
                Descripcion = "Ejemplos Sociedad Anónima"
            }).Row(new
            {
                DescripcionCorta = "Ejemplos2 S.A.",
                Descripcion = "Ejemplos2 Sociedad Anónima"
            });

            Insert.IntoTable("Areas").Row(new
            {
                Descripcion = "BASE DE DATOS",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "DESARROLLO",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "ADMINISTRACION",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "GERENCIA",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "RR.HH.",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "I.T.",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "CIBERSEGURIDAD",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "Venta",
                IdEmpresa = 1
            }).Row(new
            {
                Descripcion = "Reparto",
                IdEmpresa = 1
            })
            .Row(new
            {
                Descripcion = "BASE DE DATOS",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "DESARROLLO",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "ADMINISTRACION",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "GERENCIA",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "RR.HH.",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "I.T.",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "CIBERSEGURIDAD",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "Venta",
                IdEmpresa = 2
            }).Row(new
            {
                Descripcion = "Reparto",
                IdEmpresa = 2
            });

            Insert.IntoTable("Clientes").Row(new 
            { 
                IdEmpresa = 1,
                IdArea = 1,
                DescripcionCorta = "Cliente de ejemplo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                DescripcionCorta = "Cliente2 de ejemplo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 3,
                DescripcionCorta = "Cliente3 de ejemplo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                DescripcionCorta = "Cliente4 de ejemplo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                DescripcionCorta = "Cliente5 de ejemplo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 3,
                DescripcionCorta = "Cliente6 de ejemplo"
            });

            Insert.IntoTable("Tecnicos").Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                NombreCompleto = "Pedro Avilar"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                NombreCompleto = "Juan Avilar"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 3,
                NombreCompleto = "Julián Martinez"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                NombreCompleto = "Elian Santillan"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                NombreCompleto = "Alan Cormillon"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 3,
                NombreCompleto = "Leo Santoro"
            });

            Insert.IntoTable("Ambientes").Row(new 
            { 
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Ambiente Desarrollo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Ambiente QA"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 3,
                Descripcion = "Ambiente Producción"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Ambiente Desarrollo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Ambiente QA"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 3,
                Descripcion = "Ambiente Producción"
            });

            Insert.IntoTable("Tecnologias").Row(new 
            {
                IdEmpresa = 1,
                IdArea =1,
                Descripcion = "SQL Server"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Oracle"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Postgres"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "SQL Server"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Oracle"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Postgres"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "C#"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Javascript"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = ".NET"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "C#"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Javascript"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = ".NET"
            });

            Insert.IntoTable("EstadosTareas").Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Activo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Inactivo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Activo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Inactivo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Activo"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Inactivo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Activo"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Inactivo"
            });

            Insert.IntoTable("Proyectos").Row(new 
            {
                IdEmpresa = 1,
                IdArea = 2,
                NombreProyecto = "Omnes",
                FechaInicio = new DateTime(2023,7,1),
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                NombreProyecto = "Omnes DB",
                FechaInicio = new DateTime(2023, 7, 1),
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                NombreProyecto = "InPlan",
                FechaInicio = new DateTime(2023, 7, 11),
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                NombreProyecto = "InPlan DB",
                FechaInicio = new DateTime(2023, 7, 11),
            });

            Insert.IntoTable("TiposImplementacion").Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Tipo 1"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 1,
                Descripcion = "Tipo 2"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Tipo 1"
            }).Row(new
            {
                IdEmpresa = 1,
                IdArea = 2,
                Descripcion = "Tipo 2"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Tipo 1"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 1,
                Descripcion = "Tipo 2"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Tipo 1"
            }).Row(new
            {
                IdEmpresa = 2,
                IdArea = 2,
                Descripcion = "Tipo 2"
            });

            Insert.IntoTable("AmbientesProyectos").Row(new
            {
                IdProyecto = 1,
                IdAmbiente = 1,
            }).Row(new
            {
                IdProyecto = 2,
                IdAmbiente = 1,
            });

            Insert.IntoTable("Implementaciones").Row(new 
            {
                IdProyecto = 1,
                IdAmbienteProyecto = 1,
                IdTecnicoSolicitante = 1,
                IdTecnicoImplementa = 1,
                IdTipoImplementacion = 1,
                NroTicket = "4564561",
                FechaImplementacion = new DateTime(2023,5,6),
                FechaPlanificada = new DateTime(2023,6,1),
                FechaSolicitud = new DateTime(2023,5,5),
                UserId = 1
            }).Row(new
            {
                IdProyecto = 2,
                IdAmbienteProyecto = 2,
                IdTecnicoSolicitante = 2,
                IdTecnicoImplementa = 3,
                IdTipoImplementacion = 1,
                NroTicket = "425486",
                FechaImplementacion = new DateTime(2023,6,1),
                FechaPlanificada = new DateTime(2023,7,1),
                FechaSolicitud = new DateTime(2023,6,1),
                UserId = 1
            });

        }
    }
}