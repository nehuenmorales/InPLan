using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.EstadosDetalleImplementaciones")]
[BasedOnRow(typeof(EstadosDetalleImplementacionesRow), CheckNames = true)]
public class EstadosDetalleImplementacionesForm
{
    [HalfWidth]
    public int IdDetalleImplementacion { get; set; }
    [HalfWidth]
    public int IdEstadoTarea { get; set; }
    [HalfWidth]
    public int IdTecnicoTarea { get; set; }
    [HalfWidth]
    public string NotasAdicionales { get; set; }
    [HalfWidth]
    public int UserId { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [Category("Fechas"), HalfWidth]
    public DateTime FechaEstado { get; set; }
    [HalfWidth]
    public DateTime FechaCarga { get; set; }
    [Category("Documentos")]
    public string DocumentosAdicionales { get; set; }
}