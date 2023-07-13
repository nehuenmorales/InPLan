using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.EstadosTareasRow>;
using MyRow = InPlan.Parametros.EstadosTareasRow;

namespace InPlan.Parametros;

public interface IEstadosTareasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosTareasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosTareasRetrieveHandler
{
    public EstadosTareasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}