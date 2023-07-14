using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.DetalleImplementaciones")]
[BasedOnRow(typeof(DetalleImplementacionesRow), CheckNames = true)]
public class DetalleImplementacionesForm
{
    //public int IdImplementacion { get; set; }
    [HalfWidth]
    public int IdTecnicoResponsable { get; set; }
    [HalfWidth]
    public string Orden { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string DescripcionTarea { get; set; }
    [HalfWidth]
    public DateTime FechaInicio { get; set; }
    [HalfWidth]
    public DateTime FechaFinalizacion { get; set; }
    public string NotasAdicionales { get; set; }
    [HalfWidth]
    public int IdEstadoTarea { get; set; }
    [HalfWidth]
    public string DocumentosAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
}