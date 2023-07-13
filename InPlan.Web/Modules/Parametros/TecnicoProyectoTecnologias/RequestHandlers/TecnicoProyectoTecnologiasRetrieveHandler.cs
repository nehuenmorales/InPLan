using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Parametros.TecnicoProyectoTecnologiasRow>;
using MyRow = InPlan.Parametros.TecnicoProyectoTecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnicoProyectoTecnologiasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicoProyectoTecnologiasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicoProyectoTecnologiasRetrieveHandler
{
    public TecnicoProyectoTecnologiasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}