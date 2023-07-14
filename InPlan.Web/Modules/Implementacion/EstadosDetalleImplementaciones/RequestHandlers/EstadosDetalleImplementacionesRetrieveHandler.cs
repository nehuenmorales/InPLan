using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.EstadosDetalleImplementacionesRow>;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacionesRetrieveHandler
{
    public EstadosDetalleImplementacionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}