using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Implementacion.ImplementacionesRow>;
using MyRow = InPlan.Implementacion.ImplementacionesRow;

namespace InPlan.Implementacion;

public interface IImplementacionesListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ImplementacionesListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IImplementacionesListHandler
{
    public ImplementacionesListHandler(IRequestContext context)
            : base(context)
    {
    }
}