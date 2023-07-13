using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.DetalleImplementacionesRow>;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesRetrieveHandler
{
    public DetalleImplementacionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}