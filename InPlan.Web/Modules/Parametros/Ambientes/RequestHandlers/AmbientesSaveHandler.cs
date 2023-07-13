using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.AmbientesRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.AmbientesRow;

namespace InPlan.Parametros;

public interface IAmbientesSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesSaveHandler
{
    public AmbientesSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}