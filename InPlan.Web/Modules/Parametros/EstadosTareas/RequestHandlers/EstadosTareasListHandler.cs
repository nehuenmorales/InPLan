using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.EstadosTareasRow>;
using MyRow = InPlan.Parametros.EstadosTareasRow;

namespace InPlan.Parametros;

public interface IEstadosTareasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosTareasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosTareasListHandler
{
    public EstadosTareasListHandler(IRequestContext context)
            : base(context)
    {
    }
}