using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.AmbientesProyectosRow>;
using MyRow = InPlan.Parametros.AmbientesProyectosRow;

namespace InPlan.Parametros;

public interface IAmbientesProyectosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesProyectosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesProyectosRetrieveHandler
{
    public AmbientesProyectosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}