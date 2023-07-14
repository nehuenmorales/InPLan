using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.EstadosTareasRow;

namespace InPlan.Parametros;

public interface IEstadosTareasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosTareasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosTareasDeleteHandler
{
    public EstadosTareasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}