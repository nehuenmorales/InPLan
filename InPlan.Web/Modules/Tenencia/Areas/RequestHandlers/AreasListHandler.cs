using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Tenencia.AreasRow>;
using MyRow = InPlan.Tenencia.AreasRow;

namespace InPlan.Tenencia;

public interface IAreasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class AreasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IAreasListHandler
{
    public AreasListHandler(IRequestContext context)
            : base(context)
    {
    }
}