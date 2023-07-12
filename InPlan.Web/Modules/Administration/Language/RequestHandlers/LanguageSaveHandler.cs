using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<InPlan.Administration.LanguageRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = InPlan.Administration.LanguageRow;


namespace InPlan.Administration
{
    public interface ILanguageSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> { }
    public class LanguageSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageSaveHandler
    {
        public LanguageSaveHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}