using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.DetalleImplementaciones")]
[BasedOnRow(typeof(DetalleImplementacionesRow), CheckNames = true)]
public class DetalleImplementacionesColumns
{
    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdDetalleImplementacion { get; set; }
    //[Width(100), EditLink]
    //public string IdImplementacionNroTicket { get; set; }
    [Width(100), EditLink]
    public string IdTecnicoResponsableNombreCompleto { get; set; }
    [EditLink, Width(100)]
    public string Orden { get; set; }
    //public string DescripcionTarea { get; set; }
    //public string NotasAdicionales { get; set; }
    //public string DocumentosAdicionales { get; set; }
    [Width(100)]
    public DateTime FechaInicio { get; set; }
    //public DateTime FechaFinalizacion { get; set; }
    //public string Observaciones { get; set; }
    [Width(80)]
    public string IdEstadoTareaDescripcion { get; set; }
}