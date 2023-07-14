using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.TecnicosProyectosRow;

namespace InPlan.Parametros;

public interface ITecnicosProyectosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosProyectosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosProyectosDeleteHandler
{
    public TecnicosProyectosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}