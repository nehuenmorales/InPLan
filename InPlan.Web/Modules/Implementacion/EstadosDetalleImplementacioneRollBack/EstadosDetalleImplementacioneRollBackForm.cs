using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.EstadosDetalleImplementacioneRollBack")]
[BasedOnRow(typeof(EstadosDetalleImplementacioneRollBackRow), CheckNames = true)]
public class EstadosDetalleImplementacioneRollBackForm
{
    public int IdDetalleImplementacionRollBack { get; set; }
    public int IdEstadoTarea { get; set; }
    public int IdTecnicoTarea { get; set; }
    public DateTime FechaEstado { get; set; }
    public DateTime FechaCarga { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
    public int UserId { get; set; }
}