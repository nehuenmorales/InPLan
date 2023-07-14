using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.DetalleImplementacionesRollBackRow>;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRollBackRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesRollBackListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesRollBackListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesRollBackListHandler
{
    public DetalleImplementacionesRollBackListHandler(IRequestContext context)
            : base(context)
    {
    }
}