using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Tenencia.EmpresasRow;

namespace InPlan.Tenencia;

public interface IEmpresasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasDeleteHandler
{
    public EmpresasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}