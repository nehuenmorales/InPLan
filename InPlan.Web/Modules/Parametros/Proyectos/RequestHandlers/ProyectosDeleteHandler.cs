using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = InPlan.Parametros.ProyectosRow;

namespace InPlan.Parametros;

public interface IProyectosDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ProyectosDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IProyectosDeleteHandler
{
    public ProyectosDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}