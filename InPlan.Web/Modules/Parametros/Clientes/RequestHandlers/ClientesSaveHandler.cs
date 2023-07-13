using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.ClientesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.ClientesRow;

namespace InPlan.Parametros;

public interface IClientesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ClientesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IClientesSaveHandler
{
    public ClientesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}