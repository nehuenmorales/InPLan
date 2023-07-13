using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Parametros.Columns;

[ColumnsScript("Parametros.Proyectos")]
[BasedOnRow(typeof(ProyectosRow), CheckNames = true)]
public class ProyectosColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdProyecto { get; set; }
    [Width(100)]
    public string IdEmpresaDescripcionCorta { get; set; }
    [Width(150)]
    public string IdAreaDescripcion { get; set; }
    [EditLink, Width(100)]
    public string NombreProyecto { get; set; }
    //public string DescripcionProyecto { get; set; }
    [Width(100)]
    public string NroTicket { get; set; }
    [Width(100)]
    public DateTime FechaCarga { get; set; }
    //public DateTime FechaInicio { get; set; }
    //public DateTime FechaFin { get; set; }
    //public string DocumentosRelacionados { get; set; }
    [Width(80)]
    public bool Baja { get; set; }
}