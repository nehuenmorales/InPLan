using Serenity.ComponentModel;
using System;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Proyectos")]
[BasedOnRow(typeof(ProyectosRow), CheckNames = true)]
public class ProyectosForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
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