using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.DetalleImplementacionesRollBackRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.DetalleImplementacionesRollBackRow;

namespace InPlan.Implementacion;

public interface IDetalleImplementacionesRollBackSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class DetalleImplementacionesRollBackSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IDetalleImplementacionesRollBackSaveHandler
{
    public DetalleImplementacionesRollBackSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}