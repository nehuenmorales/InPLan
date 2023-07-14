using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.AmbientesRow;

namespace InPlan.Parametros;

public interface IAmbientesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AmbientesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAmbientesDeleteHandler
{
    public AmbientesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}