using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.TecnicosProyectosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.TecnicosProyectosRow;

namespace InPlan.Parametros;

public interface ITecnicosProyectosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosProyectosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosProyectosSaveHandler
{
    public TecnicosProyectosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}