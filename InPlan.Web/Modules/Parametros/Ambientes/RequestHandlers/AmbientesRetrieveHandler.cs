using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.AmbientesRow>;
using MyRow = InPlan.Parametros.AmbientesRow;

namespace InPlan.Parametros;

public interface IAmbientesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesRetrieveHandler
{
    public AmbientesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}