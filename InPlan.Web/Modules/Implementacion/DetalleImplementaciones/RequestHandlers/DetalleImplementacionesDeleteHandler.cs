using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesDeleteHandler
{
    public DetalleImplementacionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}