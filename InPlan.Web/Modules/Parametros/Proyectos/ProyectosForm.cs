using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Proyectos")]
[BasedOnRow(typeof(ProyectosRow), CheckNames = true)]
public class ProyectosForm
{
    [HalfWidth]
    public int IdEmpresa { get; set; }
    [HalfWidth]
    public int IdArea { get; set; }
    [HalfWidth]
    public string NombreProyecto { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string DescripcionProyecto { get; set; }
    [HalfWidth]
    public string NroTicket { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
    [Category("Fechas") ,HalfWidth]
    public DateTime FechaCarga { get; set; }
    [HalfWidth]
    public DateTime FechaInicio { get; set; }
    [HalfWidth]
    public DateTime FechaFin { get; set; }
    [Category("Documentos")]
    public string DocumentosRelacionados { get; set; }
}