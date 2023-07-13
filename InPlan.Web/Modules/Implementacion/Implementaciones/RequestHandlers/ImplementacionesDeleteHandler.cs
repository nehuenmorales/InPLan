using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.ImplementacionesRow;

namespace InPlan.Implementacion;

public interface IImplementacionesDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ImplementacionesDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IImplementacionesDeleteHandler
{
    public ImplementacionesDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}