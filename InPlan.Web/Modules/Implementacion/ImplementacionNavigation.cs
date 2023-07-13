using Serenity.Navigation;
using MyPages = InPlan.Implementacion.Pages;
[assembly: NavigationMenu(1000, "Implementacion", icon: "fa fa-wrench")]

[assembly: NavigationLink(1100, "Implementacion/Implementaciones", typeof(MyPages.ImplementacionesPage), icon: "fa fa-wrench")]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Detalle Implementaciones Roll Back", typeof(MyPages.DetalleImplementacionesRollBackPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Estados Detalle Implementacione Roll Back", typeof(MyPages.EstadosDetalleImplementacioneRollBackPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Tipos Implementacion", typeof(MyPages.TiposImplementacionPage), icon: null)]