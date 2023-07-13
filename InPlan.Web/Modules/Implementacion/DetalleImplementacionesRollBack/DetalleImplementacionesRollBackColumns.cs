using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.DetalleImplementacionesRollBack")]
[BasedOnRow(typeof(DetalleImplementacionesRollBackRow), CheckNames = true)]
public class DetalleImplementacionesRollBackColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int IdDetalleImplementacionRollBack { get; set; }
    public string IdImplementacionNroTicket { get; set; }
    public string IdTecnicoResponsableNombreCompleto { get; set; }
    [EditLink]
    public string Orden { get; set; }
    public string DescripcionTarea { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
    public string Observaciones { get; set; }
    public string IdEstadoTareaDescripcion { get; set; }
}