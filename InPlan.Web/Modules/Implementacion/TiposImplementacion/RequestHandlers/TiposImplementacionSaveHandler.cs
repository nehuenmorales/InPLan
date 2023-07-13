using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Implementacion.TiposImplementacionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Implementacion.TiposImplementacionRow;

namespace InPlan.Implementacion;

public interface ITiposImplementacionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposImplementacionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposImplementacionSaveHandler
{
    public TiposImplementacionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}