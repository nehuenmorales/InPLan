using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<InPlan.Parametros.ProyectosTecnologiasRow>;
using MyRow = InPlan.Parametros.ProyectosTecnologiasRow;

namespace InPlan.Parametros;

public interface IProyectosTecnologiasListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosTecnologiasListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosTecnologiasListHandler
{
    public ProyectosTecnologiasListHandler(IRequestContext context)
            : base(context)
    {
    }
}