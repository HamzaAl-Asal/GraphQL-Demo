using GraphQL.Demo.App.GraphQL.Schemas;
using GraphQL.Demo.App.GraphQL.Types;
using GraphQL.Demo.App.Repositories.Authors;
using GraphQL.MicrosoftDI;
using GraphQL.Server;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.Demo.App
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection RegisterAppModuleServices(this IServiceCollection services)
        {
            // repos registration
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            // services registration
            services.AddScoped<AuthorType>();
            services.AddScoped<BookType>();

            // schema registration
            services.AddScoped<ISchema, AppSchema>(services => new AppSchema(new SelfActivatingServiceProvider(services)));
            services.AddGraphQL(options =>
            {
                options.EnableMetrics = false;
            }).AddSystemTextJson();

            return services;
        }
    }
}