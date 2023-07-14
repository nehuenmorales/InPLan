using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.TecnicosProyectosRow>;
using MyRow = InPlan.Parametros.TecnicosProyectosRow;

namespace InPlan.Parametros;

public interface ITecnicosProyectosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosProyectosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosProyectosListHandler
{
    public TecnicosProyectosListHandler(IRequestContext context)
            : base(context)
    {
    }
}