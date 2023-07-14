using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.ProyectosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.ProyectosRow;

namespace InPlan.Parametros;

public interface IProyectosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosSaveHandler
{
    public ProyectosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}