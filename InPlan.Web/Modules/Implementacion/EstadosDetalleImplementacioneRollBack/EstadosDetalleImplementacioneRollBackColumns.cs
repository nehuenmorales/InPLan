using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.EstadosDetalleImplementacioneRollBack")]
[BasedOnRow(typeof(EstadosDetalleImplementacioneRollBackRow), CheckNames = true)]
public class EstadosDetalleImplementacioneRollBackColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdEstadoDetalleImplementacionRollBack { get; set; }
    [Width(100), EditLink]
    public string IdDetalleImplementacionRollBackOrden { get; set; }
    [Width(100), EditLink]
    public string IdEstadoTareaDescripcion { get; set; }
    [Width(150)]
    public string IdTecnicoTareaNombreCompleto { get; set; }
    public DateTime FechaEstado { get; set; }
    public DateTime FechaCarga { get; set; }
    public string NotasAdicionales { get; set; }
    //public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
    //public string Username { get; set; }
}