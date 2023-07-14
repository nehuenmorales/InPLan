using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.EstadosDetalleImplementacioneRollBackRow;

namespace InPlan.Implementacion;

public interface IEstadosDetalleImplementacioneRollBackSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosDetalleImplementacioneRollBackSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosDetalleImplementacioneRollBackSaveHandler
{
    public EstadosDetalleImplementacioneRollBackSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}