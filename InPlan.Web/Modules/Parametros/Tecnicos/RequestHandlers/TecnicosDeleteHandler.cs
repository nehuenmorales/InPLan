using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.TecnicosRow;

namespace InPlan.Parametros;

public interface ITecnicosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TecnicosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITecnicosDeleteHandler
{
    public TecnicosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}