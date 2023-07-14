using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.DetalleImplementacionesRow>;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesListHandler
{
    public DetalleImplementacionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}