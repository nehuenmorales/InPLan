using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.ImplementacionesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.ImplementacionesRow;

namespace InPlan.Implementacion;

public interface IImplementacionesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ImplementacionesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IImplementacionesSaveHandler
{
    public ImplementacionesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}