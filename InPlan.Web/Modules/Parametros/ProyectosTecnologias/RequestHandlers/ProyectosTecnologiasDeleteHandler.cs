using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.ProyectosTecnologiasRow;

namespace InPlan.Parametros;

public interface IProyectosTecnologiasDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosTecnologiasDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosTecnologiasDeleteHandler
{
    public ProyectosTecnologiasDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}