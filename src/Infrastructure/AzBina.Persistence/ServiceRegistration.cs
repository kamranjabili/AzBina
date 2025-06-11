using AzBina.Application.Abstracts.Repositories;
using AzBina.Application.Abstracts.Services;
using AzBina.Persistence.Repositories;
using AzBina.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AzBina.Persistence;

public static class ServiceRegistration
{
    public static void RegisterService(this IServiceCollection services)
    {
        #region Repositories
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        #endregion

        #region Servicies
        services.AddScoped<ICategoryService, CategoryService>();
        #endregion

    }
}
