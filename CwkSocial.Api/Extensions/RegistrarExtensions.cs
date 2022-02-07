using CwkSocial.Api.Registrars;

namespace CwkSocial.Api.Extensions;

public static class RegistrarExtensions
{
    public static void RegisterServices(this WebApplicationBuilder builder, Type scanningType)
    {
        foreach (var registrar in GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType))
        {
            registrar.RegisterServices(builder);
        }
    }
    public static void RegisterPipelineComponents(this WebApplication app, Type scanningType)
    {
        foreach (var registrar in GetRegistrars<IWebApplicationRegistrar>(scanningType))
        {
            registrar.RegisterPipelineComponents(app);
        }
    }
    private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T: IRegistrar
    {
        return scanningType.Assembly.GetTypes()
            .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
            .Select(Activator.CreateInstance)
            .Cast<T>();
    }
}
