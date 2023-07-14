using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Tenencia.AreasRow>;
using MyRow = InPlan.Tenencia.AreasRow;

namespace InPlan.Tenencia;

public interface IAreasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class AreasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IAreasRetrieveHandler
{
    public AreasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}