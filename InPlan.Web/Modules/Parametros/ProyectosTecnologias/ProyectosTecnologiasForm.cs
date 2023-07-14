using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.ProyectosTecnologias")]
[BasedOnRow(typeof(ProyectosTecnologiasRow), CheckNames = true)]
public class ProyectosTecnologiasForm
{
    public int IdProyecto { get; set; }
    public int IdTecnologia { get; set; }
}