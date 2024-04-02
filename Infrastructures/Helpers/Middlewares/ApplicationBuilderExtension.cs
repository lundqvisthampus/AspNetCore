using Microsoft.AspNetCore.Builder;

namespace Infrastructures.Helpers.Middlewares;

public static class ApplicationBuilderExtension
{
    public static IApplicationBuilder UserSessionValidation(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<UserSesseionValidation>();
    }
}
