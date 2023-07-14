using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.EstadosDetalleImplementacionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacionesSaveHandler
{
    public EstadosDetalleImplementacionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}