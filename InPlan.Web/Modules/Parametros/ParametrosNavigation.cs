using Serenity.Navigation;
using MyPages = InPlan.Parametros.Pages;

[assembly: NavigationMenu(98, "Parametros", icon: "fa-cogs")]

[assembly: NavigationLink(100, "Parametros/Ambientes", typeof(MyPages.AmbientesPage), icon: "fa fa-cubes")]
[assembly: NavigationLink(int.MaxValue, "Parametros/Ambientes Proyectos", typeof(MyPages.AmbientesProyectosPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Clientes", typeof(MyPages.ClientesPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Estados Tareas", typeof(MyPages.EstadosTareasPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Proyectos", typeof(MyPages.ProyectosPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Proyectos Tecnologias", typeof(MyPages.ProyectosTecnologiasPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Tecnico Proyecto Tecnologias", typeof(MyPages.TecnicoProyectoTecnologiasPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Tecnicos", typeof(MyPages.TecnicosPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Tecnicos Proyectos", typeof(MyPages.TecnicosProyectosPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Parametros/Tecnologias", typeof(MyPages.TecnologiasPage), icon: null)]