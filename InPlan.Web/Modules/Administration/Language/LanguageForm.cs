using Serenity.ComponentModel;

namespace InPlan.Administration.Forms
{
    [FormScript("Administration.Language")]
    [BasedOnRow(typeof(LanguageRow), CheckNames = true)]
    public class LanguageForm
    {
        public string LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}