using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.Implementaciones")]
[BasedOnRow(typeof(ImplementacionesRow), CheckNames = true)]
public class ImplementacionesForm
{
    public int IdProyecto { get; set; }
    public int IdAmbienteProyecto { get; set; }
    public int IdTecnicoSolicitante { get; set; }
    public int IdTecnicoImplementa { get; set; }
    public int IdTipoImplementacion { get; set; }
    public string NroTicket { get; set; }
    public DateTime FechaSolicitud { get; set; }
    public DateTime FechaPlanificada { get; set; }
    public DateTime FechaImplementacion { get; set; }
    public string ConsideracionesPrevias { get; set; }
    public string Descripcion { get; set; }
    public string ConsideracionesPosteriores { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
    public int UserId { get; set; }
}