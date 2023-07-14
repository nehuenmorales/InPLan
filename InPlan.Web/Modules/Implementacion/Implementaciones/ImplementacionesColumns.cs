using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace InPlan.Implementacion.Columns;

[ColumnsScript("Implementacion.Implementaciones")]
[BasedOnRow(typeof(ImplementacionesRow), CheckNames = true)]
public class ImplementacionesColumns
{
    [EditLink]
    [Width(100)]
    public string NroTicket { get; set; }
    [Width(100)]
    public string IdProyectoNombreProyecto { get; set; }
    [Width(150)]
    public string IdTipoImplementacionDescripcion { get; set; }
    
    [Width(100)]
    public string IdTecnicoSolicitanteNombreCompleto { get; set; }
    [Width(100)]
    public string IdTecnicoImplementaNombreCompleto { get; set; }
    [Width(110)]
    public DateTime FechaSolicitud { get; set; }
    [Width(115)]
    public DateTime FechaPlanificada { get; set; }
    [Width(115)]
    public DateTime FechaImplementacion { get; set; }
    //public string ConsideracionesPrevias { get; set; }
    //public string ConsideracionesPosteriores { get; set; }
    //public string NotasAdicionales { get; set; }
    //public string Observaciones { get; set; }

    //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    //public int IdImplementacion { get; set; }
    //public string DocumentosAdicionales { get; set; }
    //public string Username { get; set; }
    //public string Descripcion { get; set; }
    //public string IdAmbienteProyectoServidorDatos { get; set; }

}