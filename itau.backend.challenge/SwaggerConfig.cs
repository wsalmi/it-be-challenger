using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Linq;

namespace Itau.Backend.Challenge
{
    public static class SwaggerConfig
    {
        const string BASE_TITLE = "Itaú Backend Challenge V{0}";

        public static IServiceCollection AddCustomSwaggerGen(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = string.Format(BASE_TITLE, 1), Version = "v1" });
                c.SwaggerDoc("v2", new OpenApiInfo { Title = string.Format(BASE_TITLE, 2), Version = "v2" });

                c.OperationFilter<RemoveVersionFromParameter>();
                c.DocumentFilter<ReplaceVersionWithExactValueInPath>();

                c.DocInclusionPredicate((version, desc) =>
                {
                    var versions = desc.CustomAttributes()
                        .OfType<ApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions);

                    var docName = desc.CustomAttributes()
                        .OfType<MapToApiVersionAttribute>()
                        .SelectMany(attr => attr.Versions)
                        .ToArray();

                    return versions.Any(v => $"v{v}" == version) && (docName.Length == 0 || docName.Any(v => $"v{v}" == version));
                });
            });

            return services;
        }
    }

    internal class ReplaceVersionWithExactValueInPath : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var newPaths = new OpenApiPaths();
            foreach (var item in swaggerDoc.Paths)
            {
                newPaths.Add(item.Key.Replace("v{version}", swaggerDoc.Info.Version), item.Value);
            }
            swaggerDoc.Paths = newPaths;
        }
    }

    internal class RemoveVersionFromParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            operation.Parameters.Remove(operation.Parameters.Single(p => p.Name == "version"));
        }
    }
}
