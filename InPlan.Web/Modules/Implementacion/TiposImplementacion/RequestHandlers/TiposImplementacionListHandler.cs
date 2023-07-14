using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.TiposImplementacionRow>;
using MyRow = InPlan.Implementacion.TiposImplementacionRow;

namespace InPlan.Implementacion;

public interface ITiposImplementacionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class TiposImplementacionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ITiposImplementacionListHandler
{
    public TiposImplementacionListHandler(IRequestContext context)
            : base(context)
    {
    }
}