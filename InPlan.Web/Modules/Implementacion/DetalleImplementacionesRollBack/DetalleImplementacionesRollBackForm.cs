using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.DetalleImplementacionesRollBack")]
[BasedOnRow(typeof(DetalleImplementacionesRollBackRow), CheckNames = true)]
public class DetalleImplementacionesRollBackForm
{
    [Tab("Datos")]
    [HalfWidth]
    public int IdImplementacion { get; set; }
    [DisplayName("Responsable") ,HalfWidth]
    public int IdTecnicoResponsable { get; set; }
    [HalfWidth]
    public int IdEstadoTarea { get; set; }
    [HalfWidth]
    public string Orden { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string DescripcionTarea { get; set; }
    [TextAreaEditor(Rows = 4)]
    public string NotasAdicionales { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HalfWidth]
    public DateTime FechaInicio { get; set; }
    [HalfWidth]
    public DateTime FechaFinalizacion { get; set; }
    [Tab("Documentos")]
    public string DocumentosAdicionales { get; set; }
}