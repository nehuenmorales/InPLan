using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.TecnicoProyectoTecnologiasRow>;
using MyRow = InPlan.Parametros.TecnicoProyectoTecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnicoProyectoTecnologiasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicoProyectoTecnologiasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicoProyectoTecnologiasListHandler
{
    public TecnicoProyectoTecnologiasListHandler(IRequestContext context)
            : base(context)
    {
    }
}