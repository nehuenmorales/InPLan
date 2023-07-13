using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.Implementaciones")]
[BasedOnRow(typeof(ImplementacionesRow), CheckNames = true)]
public class ImplementacionesForm
{
    [HalfWidth]
    public int IdProyecto { get; set; }
    [HalfWidth]
    public int IdAmbienteProyecto { get; set; }
    [HalfWidth]
    public int IdTecnicoSolicitante { get; set; }
    [HalfWidth]
    public int IdTecnicoImplementa { get; set; }
    [HalfWidth]
    public int IdTipoImplementacion { get; set; }
    [HalfWidth]
    public string NroTicket { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Descripcion { get; set; }
    [HalfWidth]
    public DateTime FechaSolicitud { get; set; }
    [HalfWidth]
    public DateTime FechaPlanificada { get; set; }
    [HalfWidth]
    public DateTime FechaImplementacion { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string ConsideracionesPrevias { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string ConsideracionesPosteriores { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    public int UserId { get; set; }
}