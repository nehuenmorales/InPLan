using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Tenencia.EmpresasRow>;
using MyRow = InPlan.Tenencia.EmpresasRow;

namespace InPlan.Tenencia;

public interface IEmpresasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasListHandler
{
    public EmpresasListHandler(IRequestContext context)
            : base(context)
    {
    }
}