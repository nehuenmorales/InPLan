using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.EstadosDetalleImplementacionesRow>;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacionesListHandler
{
    public EstadosDetalleImplementacionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}