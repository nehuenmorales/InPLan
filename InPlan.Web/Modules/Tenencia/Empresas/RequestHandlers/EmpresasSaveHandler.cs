using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Tenencia.EmpresasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Tenencia.EmpresasRow;

namespace InPlan.Tenencia;

public interface IEmpresasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class EmpresasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IEmpresasSaveHandler
{
    public EmpresasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}