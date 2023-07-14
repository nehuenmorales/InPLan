using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Tecnologias")]
[BasedOnRow(typeof(TecnologiasRow), CheckNames = true)]
public class TecnologiasForm
{
    [HalfWidth]
    public int IdEmpresa { get; set; }
    [HalfWidth]
    public int IdArea { get; set; }
    [HalfWidth]
    public string Descripcion { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}