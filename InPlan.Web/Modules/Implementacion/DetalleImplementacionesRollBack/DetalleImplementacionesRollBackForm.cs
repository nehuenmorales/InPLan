﻿using Serenity.ComponentModel;
using System;

namespace InPlan.Implementacion.Forms;

[FormScript("Implementacion.DetalleImplementacionesRollBack")]
[BasedOnRow(typeof(DetalleImplementacionesRollBackRow), CheckNames = true)]
public class DetalleImplementacionesRollBackForm
{
    public int IdImplementacion { get; set; }
    public int IdTecnicoResponsable { get; set; }
    public string Orden { get; set; }
    public string DescripcionTarea { get; set; }
    public string NotasAdicionales { get; set; }
    public string DocumentosAdicionales { get; set; }
    public DateTime FechaInicio { get; set; }
    public DateTime FechaFinalizacion { get; set; }
    public string Observaciones { get; set; }
    public int IdEstadoTarea { get; set; }
}