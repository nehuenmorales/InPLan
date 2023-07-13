﻿using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Tecnologias")]
[BasedOnRow(typeof(TecnologiasRow), CheckNames = true)]
public class TecnologiasForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}