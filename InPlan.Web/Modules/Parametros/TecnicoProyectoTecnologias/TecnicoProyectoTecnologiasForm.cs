using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.TecnicoProyectoTecnologias")]
[BasedOnRow(typeof(TecnicoProyectoTecnologiasRow), CheckNames = true)]
public class TecnicoProyectoTecnologiasForm
{
    public int IdTecnicoProyecto { get; set; }
    public int IdTecnologia { get; set; }
}