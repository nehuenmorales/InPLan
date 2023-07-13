using Serenity.Navigation;
using MyPages = InPlan.Tenencia.Pages;

[assembly: NavigationLink(int.MaxValue, "Tenencia/Areas", typeof(MyPages.AreasPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Tenencia/Empresas", typeof(MyPages.EmpresasPage), icon: null)]