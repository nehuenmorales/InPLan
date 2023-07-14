using InPlan.Colaboradores;
using Serenity.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.Implementaciones")]
[BasedOnRow(typeof(ImplementacionesRow), CheckNames = true)]
public class ImplementacionesForm
{
    [Tab("Datos")]
    [Category("Sobre la implementación")]
    [HalfWidth]
    public int IdProyecto { get; set; }
    [HalfWidth]
    public int IdAmbienteProyecto { get; set; }
    [DisplayName("Tipo") ,HalfWidth]
    public int IdTipoImplementacion { get; set; }
    [HalfWidth]
    public string NroTicket { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Descripcion { get; set; }
    [Category("Tecnicos relacionados")]
    [DisplayName("Solicitante") ,HalfWidth]
    public int IdTecnicoSolicitante { get; set; }
    [DisplayName("Implementador"), HalfWidth]
    public int IdTecnicoImplementa { get; set; }
    [Category("Fechas y Consideraciones")]
    [HalfWidth]
    public DateTime FechaSolicitud { get; set; }
    [HalfWidth]
    public DateTime FechaPlanificada { get; set; }
    [DisplayName("Implementación") , HalfWidth]
    public DateTime FechaImplementacion { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string ConsideracionesPrevias { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string ConsideracionesPosteriores { get; set; }
    [Category("Notas")]
    public string NotasAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    public int UserId { get; set; }
    [DetalleImplementacionesEditor, Category("Tareas")]
    public List<DetalleImplementacionesRow> DetallesList { get; set; }

    [Tab("Documentos")]
    [Category("")]
    public string DocumentosAdicionales { get; set; }

}