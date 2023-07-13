using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.AmbientesRow>;
using MyRow = InPlan.Parametros.AmbientesRow;

namespace InPlan.Parametros;

public interface IAmbientesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesListHandler
{
    public AmbientesListHandler(IRequestContext context)
            : base(context)
    {
    }
}