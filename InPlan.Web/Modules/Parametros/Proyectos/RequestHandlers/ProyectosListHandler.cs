using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.ProyectosRow>;
using MyRow = InPlan.Parametros.ProyectosRow;

namespace InPlan.Parametros;

public interface IProyectosListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosListHandler
{
    public ProyectosListHandler(IRequestContext context)
            : base(context)
    {
    }
}