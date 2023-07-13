using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Tenencia.AreasRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Tenencia.AreasRow;

namespace InPlan.Tenencia;

public interface IAreasSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class AreasSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IAreasSaveHandler
{
    public AreasSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}