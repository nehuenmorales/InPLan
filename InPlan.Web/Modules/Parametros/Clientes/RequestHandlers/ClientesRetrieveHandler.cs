using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.ClientesRow>;
using MyRow = InPlan.Parametros.ClientesRow;

namespace InPlan.Parametros;

public interface IClientesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ClientesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IClientesRetrieveHandler
{
    public ClientesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}