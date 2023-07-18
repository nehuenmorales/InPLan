using Serenity.Navigation;
using MyPages = InPlan.Implementacion.Pages;

[assembly: NavigationMenu(1000, "Proyectos", icon: "fas fa-project-diagram")]

[assembly: NavigationLink(1100, "Proyectos/Implementaciones", typeof(MyPages.ImplementacionesPage), icon: "fa-wrench")]
[assembly: NavigationLink(1200, "Proyectos/Tipos Implementacion", typeof(MyPages.TiposImplementacionPage), icon: "fa-puzzle-piece")]
