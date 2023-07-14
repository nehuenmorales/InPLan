using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.AmbientesProyectosRow>;
using MyRow = InPlan.Parametros.AmbientesProyectosRow;

namespace InPlan.Parametros;

public interface IAmbientesProyectosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesProyectosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesProyectosListHandler
{
    public AmbientesProyectosListHandler(IRequestContext context)
            : base(context)
    {
    }
}