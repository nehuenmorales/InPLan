using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.TecnicoProyectoTecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnicoProyectoTecnologiasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicoProyectoTecnologiasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicoProyectoTecnologiasDeleteHandler
{
    public TecnicoProyectoTecnologiasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}