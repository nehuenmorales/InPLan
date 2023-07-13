using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow>;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacioneRollBackRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacioneRollBackRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacioneRollBackRetrieveHandler
{
    public EstadosDetalleImplementacioneRollBackRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}