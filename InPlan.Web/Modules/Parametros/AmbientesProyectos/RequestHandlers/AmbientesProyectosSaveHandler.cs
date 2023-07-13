using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.AmbientesProyectosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.AmbientesProyectosRow;

namespace InPlan.Parametros;

public interface IAmbientesProyectosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesProyectosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesProyectosSaveHandler
{
    public AmbientesProyectosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}