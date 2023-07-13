using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Tecnicos")]
[BasedOnRow(typeof(TecnicosRow), CheckNames = true)]
public class TecnicosForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string NombreCompleto { get; set; }
    public string Celular { get; set; }
    public string Email { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}