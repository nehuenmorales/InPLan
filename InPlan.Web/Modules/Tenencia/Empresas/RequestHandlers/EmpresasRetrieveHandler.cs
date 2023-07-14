using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<InPlan.Tenencia.EmpresasRow>;
using MyRow = InPlan.Tenencia.EmpresasRow;

namespace InPlan.Tenencia;

public interface IEmpresasRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasRetrieveHandler
{
    public EmpresasRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}