using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.AmbientesProyectosRow;

namespace InPlan.Parametros;

public interface IAmbientesProyectosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesProyectosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesProyectosDeleteHandler
{
    public AmbientesProyectosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}