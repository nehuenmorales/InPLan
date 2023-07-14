using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.ProyectosTecnologiasRow>;
using MyRow = InPlan.Parametros.ProyectosTecnologiasRow;

namespace InPlan.Parametros;

public interface IProyectosTecnologiasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosTecnologiasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosTecnologiasRetrieveHandler
{
    public ProyectosTecnologiasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}