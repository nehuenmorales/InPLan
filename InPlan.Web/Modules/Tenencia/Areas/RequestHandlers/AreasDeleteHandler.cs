using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Tenencia.AreasRow;

namespace InPlan.Tenencia;

public interface IAreasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class AreasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IAreasDeleteHandler
{
    public AreasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}