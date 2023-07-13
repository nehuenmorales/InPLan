using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Proyectos")]
[BasedOnRow(typeof(ProyectosRow), CheckNames = true)]
public class ProyectosColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdProyecto { get; set; }
    public string IdEmpresaDescripcionCorta { get; set; }
    public string IdAreaDescripcion { get; set; }
    [EditLink]
    public string NombreProyecto { get; set; }
    public string DescripcionProyecto { get; set; }
    public string NroTicket { get; set; }
    public DateTime FechaCarga { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFin { get; set; }
    public string DocumentosRelacionados { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}