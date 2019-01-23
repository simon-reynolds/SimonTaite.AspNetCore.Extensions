namespace SimonTaite.AspNetCore.Extensions

open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting

module DependencyInjection =

    let addHostedService<'THostedService when 'THostedService : not struct and 'THostedService :> IHostedService > services =
        ServiceCollectionHostedServiceExtensions.AddHostedService<'THostedService>(services)

    let addScoped<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddScoped<'a>
        
    let addSingleton<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddSingleton<'a>
        
    let addTransient<'a when 'a : not struct> =
        ServiceCollectionServiceExtensions.AddTransient<'a>
