using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.ImplementacionesRow>;
using MyRow = InPlan.Implementacion.ImplementacionesRow;

namespace InPlan.Implementacion;

public interface IImplementacionesRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ImplementacionesRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IImplementacionesRetrieveHandler
{
    public ImplementacionesRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}