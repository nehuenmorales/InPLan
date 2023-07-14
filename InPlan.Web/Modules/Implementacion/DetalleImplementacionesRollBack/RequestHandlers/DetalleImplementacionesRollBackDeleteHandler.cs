using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRollBackRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesRollBackDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesRollBackDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesRollBackDeleteHandler
{
    public DetalleImplementacionesRollBackDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}