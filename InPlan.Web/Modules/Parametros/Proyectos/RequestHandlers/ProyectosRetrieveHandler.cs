using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.ProyectosRow>;
using MyRow = InPlan.Parametros.ProyectosRow;

namespace InPlan.Parametros;

public interface IProyectosRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosRetrieveHandler
{
    public ProyectosRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}