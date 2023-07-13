using Serenity.ComponentModel;

namespace InPlan.Parametros.Forms;

[FormScript("Parametros.Clientes")]
[BasedOnRow(typeof(ClientesRow), CheckNames = true)]
public class ClientesForm
{
    public int IdEmpresa { get; set; }
    public int IdArea { get; set; }
    public string DescripcionCorta { get; set; }
    public string Descripcion { get; set; }
    public string Observaciones { get; set; }
    public bool Baja { get; set; }
}