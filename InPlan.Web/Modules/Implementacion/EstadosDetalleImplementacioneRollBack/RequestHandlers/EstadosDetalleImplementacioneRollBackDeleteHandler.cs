using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacioneRollBackDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacioneRollBackDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacioneRollBackDeleteHandler
{
    public EstadosDetalleImplementacioneRollBackDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}