using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Implementacion.TiposImplementacionRow;

namespace InPlan.Implementacion;

public interface ITiposImplementacionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class TiposImplementacionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, ITiposImplementacionDeleteHandler
{
    public TiposImplementacionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}