using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.EstadosTareasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.EstadosTareasRow;

namespace InPlan.Parametros;

public interface IEstadosTareasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EstadosTareasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEstadosTareasSaveHandler
{
    public EstadosTareasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}