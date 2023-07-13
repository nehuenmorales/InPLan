using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Parametros.TecnicoProyectoTecnologiasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Parametros.TecnicoProyectoTecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnicoProyectoTecnologiasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicoProyectoTecnologiasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicoProyectoTecnologiasSaveHandler
{
    public TecnicoProyectoTecnologiasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}