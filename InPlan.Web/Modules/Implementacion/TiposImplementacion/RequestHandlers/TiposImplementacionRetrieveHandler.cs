using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Implementacion.TiposImplementacionRow>;
using MyRow = InPlan.Implementacion.TiposImplementacionRow;

namespace InPlan.Implementacion;

public interface ITiposImplementacionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class TiposImplementacionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, ITiposImplementacionRetrieveHandler
{
    public TiposImplementacionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}