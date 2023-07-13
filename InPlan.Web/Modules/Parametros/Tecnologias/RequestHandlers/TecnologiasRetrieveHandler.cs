using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.TecnologiasRow>;
using MyRow = InPlan.Parametros.TecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnologiasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnologiasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnologiasRetrieveHandler
{
    public TecnologiasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}