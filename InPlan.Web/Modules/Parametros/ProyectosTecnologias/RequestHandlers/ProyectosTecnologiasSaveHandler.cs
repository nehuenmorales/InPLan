using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.ProyectosTecnologiasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.ProyectosTecnologiasRow;

namespace InPlan.Parametros;

public interface IProyectosTecnologiasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosTecnologiasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosTecnologiasSaveHandler
{
    public ProyectosTecnologiasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}