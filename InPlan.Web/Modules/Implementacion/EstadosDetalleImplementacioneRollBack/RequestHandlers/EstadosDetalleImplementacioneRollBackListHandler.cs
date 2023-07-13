using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow>;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacioneRollBackListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacioneRollBackListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacioneRollBackListHandler
{
    public EstadosDetalleImplementacioneRollBackListHandler(IRequestContext context)
            : base(context)
    {
    }
}