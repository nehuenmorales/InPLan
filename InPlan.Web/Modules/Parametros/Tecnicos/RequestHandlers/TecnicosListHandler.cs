using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.TecnicosRow>;
using MyRow = InPlan.Parametros.TecnicosRow;

namespace InPlan.Parametros;

public interface ITecnicosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosListHandler
{
    public TecnicosListHandler(IRequestContext context)
            : base(context)
    {
    }
}