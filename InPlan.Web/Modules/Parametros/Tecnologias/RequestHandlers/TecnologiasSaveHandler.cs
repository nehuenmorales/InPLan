using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.TecnologiasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.TecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnologiasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnologiasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnologiasSaveHandler
{
    public TecnologiasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}