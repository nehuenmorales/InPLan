using Serenity.Navigation;

[assembly: NavigationGroup("InPlan", "fa-home", Default = true)]

[assembly: NavigationSection("InPlan/Demo Modules",
    Include = new[] { "Northwind", "Basic Samples", "Advanced Samples", "UI Elements", "Theme Samples" })]

[assembly: NavigationSection("InPlan/Pro Features",
    Include = new[] { "Meeting", "Organization", "Work Log" })]

[assembly: NavigationGroup(9000, "Administration", icon: "fa-tools")]

[assembly: NavigationSection("Administration/General", Default = true)]

[assembly: NavigationSection("Administration/Localization",
    Include = new[] { "Administration/Languages", "Administration/Translations" })]

[assembly: NavigationSection("Administration/Security",
    Include = new[] { "Administration/Roles", "Administration/User Management" })]

[assembly: NavigationLink(1, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]