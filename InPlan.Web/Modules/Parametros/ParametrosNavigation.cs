using Serenity.Navigation;
using MyPages = InPlan.Parametros.Pages;

[assembly: NavigationMenu(98, "Parametros", icon: "fa-cogs")]

[assembly: NavigationLink(100, "Parametros/Ambientes", typeof(MyPages.AmbientesPage), icon: "fa fa-cubes")]
[assembly: NavigationLink(300, "Parametros/Clientes", typeof(MyPages.ClientesPage), icon: "fa-user-lock")]
[assembly: NavigationLink(400, "Parametros/Estados Tareas", typeof(MyPages.EstadosTareasPage), icon: "fas fa-tasks")]
[assembly: NavigationLink(450, "Proyectos/Proyectos", typeof(MyPages.ProyectosPage), icon: "fa-lightbulb")]
[assembly: NavigationLink(500, "Parametros/Tecnologías", typeof(MyPages.TecnologiasPage), icon: "fa-code")]
[assembly: NavigationLink(600, "Parametros/Técnicos", typeof(MyPages.TecnicosPage), icon: "fa-users-cog")]
