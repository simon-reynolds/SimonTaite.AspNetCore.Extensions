namespace SimonTaite.AspNetCore.Extensions

open Microsoft.Extensions.Hosting

module HostingEnvironment =

    let isDevelopment = HostingEnvironmentExtensions.IsDevelopment
    let isEnvironment = HostingEnvironmentExtensions.IsEnvironment
    let isProduction = HostingEnvironmentExtensions.IsProduction
    let isStaging = HostingEnvironmentExtensions.IsStaging

module HostBuilder =

    let start = HostingAbstractionsHostBuilderExtensions.Start


module Host =

    let run = HostingAbstractionsHostExtensions.Run
    let runAsync host token =
        let task = HostingAbstractionsHostExtensions.RunAsync(host, token)
        Async.AwaitTask task

    let start = HostingAbstractionsHostExtensions.Start
    let stopAsync host timeout =
        let task = HostingAbstractionsHostExtensions.StopAsync(host, timeout)
        Async.AwaitTask task

    let waitForShutdown = HostingAbstractionsHostExtensions.WaitForShutdown

    let waitForShutdownAsync host =
        let task = HostingAbstractionsHostExtensions.WaitForShutdownAsync host
        Async.AwaitTask task