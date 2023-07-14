using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.EstadosDetalleImplementaciones")]
[BasedOnRow(typeof(EstadosDetalleImplementacionesRow), CheckNames = true)]
public class EstadosDetalleImplementacionesColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdEstadoDetalleImplementacion { get; set; }
    [Width(100), EditLink]
    public string IdDetalleImplementacionOrden { get; set; }
    [Width(100)]
    public string IdEstadoTareaDescripcion { get; set; }
    [Width(100)]
    public string IdTecnicoTareaNombreCompleto { get; set; }
    //public DateTime FechaEstado { get; set; }
    //public DateTime FechaCarga { get; set; }
    [EditLink, Width(150)]
    public string NotasAdicionales { get; set; }
    //public string DocumentosAdicionales { get; set; }
    //public string Observaciones { get; set; }
    [Width(100)]
    public string Username { get; set; }
}