using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.DetalleImplementacionesRollBackRow>;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRollBackRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesRollBackRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesRollBackRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesRollBackRetrieveHandler
{
    public DetalleImplementacionesRollBackRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}