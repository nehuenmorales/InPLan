using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.EstadosDetalleImplementacioneRollBack")]
[BasedOnRow(typeof(EstadosDetalleImplementacioneRollBackRow), CheckNames = true)]
public class EstadosDetalleImplementacioneRollBackForm
{
    [Tab("Datos")]
    public int IdDetalleImplementacionRollBack { get; set; }
    [HalfWidth]
    public int IdEstadoTarea { get; set; }
    [HalfWidth]
    public int IdTecnicoTarea { get; set; }
    [HalfWidth]
    public DateTime FechaEstado { get; set; }
    [HalfWidth]
    public DateTime FechaCarga { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string NotasAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    public int UserId { get; set; }
    [Tab("Documentos")]
    public string DocumentosAdicionales { get; set; }
}