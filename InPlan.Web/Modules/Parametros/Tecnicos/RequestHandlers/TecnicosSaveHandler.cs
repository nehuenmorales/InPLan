using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.TecnicosRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.TecnicosRow;

namespace InPlan.Parametros;

public interface ITecnicosSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosSaveHandler
{
    public TecnicosSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}