using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacionesDeleteHandler
{
    public EstadosDetalleImplementacionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}