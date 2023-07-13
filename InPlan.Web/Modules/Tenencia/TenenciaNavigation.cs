using Serenity.Navigation;
using MyPages = InPlan.Tenencia.Pages;

[assembly: NavigationMenu(9, "Tenencia", icon: "fa-bars")]
[assembly: NavigationLink(10, "Tenencia/Áreas", typeof(MyPages.AreasPage), icon: "fa-briefcase")]
[assembly: NavigationLink(20, "Tenencia/Empresas", typeof(MyPages.EmpresasPage), icon: "fas fa-industry")]