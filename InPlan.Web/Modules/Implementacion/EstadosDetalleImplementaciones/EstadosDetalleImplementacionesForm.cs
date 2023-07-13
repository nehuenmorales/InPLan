using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.EstadosDetalleImplementaciones")]
[BasedOnRow(typeof(EstadosDetalleImplementacionesRow), CheckNames = true)]
public class EstadosDetalleImplementacionesForm
{
    public int IdDetalleImplementacion { get; set; }
    public int IdEstadoTarea { get; set; }
    public int IdTecnicoTarea { get; set; }
    public DateTime FechaEstado { get; set; }
    public DateTime FechaCarga { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
    public int UserId { get; set; }
}