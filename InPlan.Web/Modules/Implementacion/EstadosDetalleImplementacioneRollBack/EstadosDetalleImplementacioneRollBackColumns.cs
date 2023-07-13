using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.EstadosDetalleImplementacioneRollBack")]
[BasedOnRow(typeof(EstadosDetalleImplementacioneRollBackRow), CheckNames = true)]
public class EstadosDetalleImplementacioneRollBackColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdEstadoDetalleImplementacionRollBack { get; set; }
    public string IdDetalleImplementacionRollBackOrden { get; set; }
    public string IdEstadoTareaDescripcion { get; set; }
    public string IdTecnicoTareaNombreCompleto { get; set; }
    public DateTime FechaEstado { get; set; }
    public DateTime FechaCarga { get; set; }
    [EditLink]
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public string Observaciones { get; set; }
    public string Username { get; set; }
}