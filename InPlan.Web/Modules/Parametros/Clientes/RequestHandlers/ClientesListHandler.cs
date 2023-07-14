using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.ClientesRow>;
using MyRow = InPlan.Parametros.ClientesRow;

namespace InPlan.Parametros;

public interface IClientesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ClientesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IClientesListHandler
{
    public ClientesListHandler(IRequestContext context)
            : base(context)
    {
    }
}