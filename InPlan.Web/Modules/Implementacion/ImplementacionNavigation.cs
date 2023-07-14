using Serenity.Navigation;
using MyPages = InPlan.Implementacion.Pages;

[assembly: NavigationMenu(1000, "Implementación", icon: "fa-sitemap")]

[assembly: NavigationLink(1100, "Implementación/Implementaciones", typeof(MyPages.ImplementacionesPage), icon: "fa-wrench")]
[assembly: NavigationLink(1200, "Implementación/Tipos Implementacion", typeof(MyPages.TiposImplementacionPage), icon: "fa-puzzle-piece")]
