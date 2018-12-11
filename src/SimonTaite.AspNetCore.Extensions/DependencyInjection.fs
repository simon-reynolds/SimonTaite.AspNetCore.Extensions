namespace SimonTaite.AspNetCore.Extensions

open Microsoft.Extensions.DependencyInjection

module DependencyInjection =

    let addHostedService =
        ServiceCollectionHostedServiceExtensions.AddHostedService

    let addScoped<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddScoped<'a>
        
    let addSingleton<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddSingleton<'a>
        
    let addTransient<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddTransient<'a>