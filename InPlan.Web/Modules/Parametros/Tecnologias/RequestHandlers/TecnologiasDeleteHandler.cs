using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.TecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnologiasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TecnologiasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITecnologiasDeleteHandler
{
    public TecnologiasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}