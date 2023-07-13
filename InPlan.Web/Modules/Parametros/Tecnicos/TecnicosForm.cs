using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Tecnicos")]
[BasedOnRow(typeof(TecnicosRow), CheckNames = true)]
public class TecnicosForm
{
    [HalfWidth]
    public int IdEmpresa { get; set; }
    [HalfWidth]
    public int IdArea { get; set; }
    [HalfWidth]
    public string NombreCompleto { get; set; }
    [HalfWidth]
    public string Celular { get; set; }
    [HalfWidth]
    public string Email { get; set; }
    [TextAreaEditor(Rows = 5)]
    public string Observaciones { get; set; }
    [HideOnInsert]
    public bool Baja { get; set; }
}