using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.TecnologiasRow>;
using MyRow = InPlan.Parametros.TecnologiasRow;

namespace InPlan.Parametros;

public interface ITecnologiasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TecnologiasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITecnologiasListHandler
{
    public TecnologiasListHandler(IRequestContext context)
            : base(context)
    {
    }
}