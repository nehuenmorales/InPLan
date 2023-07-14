using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.ClientesRow;

namespace InPlan.Parametros;

public interface IClientesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ClientesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IClientesDeleteHandler
{
    public ClientesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}