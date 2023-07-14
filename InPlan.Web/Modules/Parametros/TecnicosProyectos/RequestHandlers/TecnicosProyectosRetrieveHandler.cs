using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.TecnicosProyectosRow>;
using MyRow = InPlan.Parametros.TecnicosProyectosRow;

namespace InPlan.Parametros;

public interface ITecnicosProyectosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosProyectosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosProyectosRetrieveHandler
{
    public TecnicosProyectosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}