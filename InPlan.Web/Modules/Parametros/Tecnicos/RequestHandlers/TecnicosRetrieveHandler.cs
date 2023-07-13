using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.TecnicosRow>;
using MyRow = InPlan.Parametros.TecnicosRow;

namespace InPlan.Parametros;

public interface ITecnicosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosRetrieveHandler
{
    public TecnicosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}