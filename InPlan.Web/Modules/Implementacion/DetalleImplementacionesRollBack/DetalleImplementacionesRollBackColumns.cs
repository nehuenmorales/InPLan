using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.DetalleImplementacionesRollBack")]
[BasedOnRow(typeof(DetalleImplementacionesRollBackRow), CheckNames = true)]
public class DetalleImplementacionesRollBackColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdDetalleImplementacionRollBack { get; set; }
    [EditLink, Width(100)]
    public string IdImplementacionNroTicket { get; set; }
    public string DescripcionTarea { get; set; }
    [Width(150)]
    public string IdEstadoTareaDescripcion { get; set; }
    [Width(150)]
    public string IdTecnicoResponsableNombreCompleto { get; set; }
    [Width(100)]
    public string Orden { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
    public string NotasAdicionales { get; set; }
    //public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
}