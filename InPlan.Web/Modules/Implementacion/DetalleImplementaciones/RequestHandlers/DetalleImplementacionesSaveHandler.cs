using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.DetalleImplementacionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesSaveHandler
{
    public DetalleImplementacionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}