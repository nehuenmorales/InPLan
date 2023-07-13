using Serenity.Navigation;
using MyPages = InPlan.Implementacion.Pages;

[assembly: NavigationLink(int.MaxValue, "Implementacion/Detalle Implementaciones Roll Back", typeof(MyPages.DetalleImplementacionesRollBackPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Estados Detalle Implementacione Roll Back", typeof(MyPages.EstadosDetalleImplementacioneRollBackPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Estados Detalle Implementaciones", typeof(MyPages.EstadosDetalleImplementacionesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Implementaciones", typeof(MyPages.ImplementacionesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Implementacion/Tipos Implementacion", typeof(MyPages.TiposImplementacionPage), icon: null)]