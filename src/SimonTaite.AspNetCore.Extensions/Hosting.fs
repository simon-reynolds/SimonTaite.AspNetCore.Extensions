namespace SimonTaite.AspNetCore.Extensions

open Microsoft.Extensions.Hosting

module HostingEnvironment =

    let isDevelopment env = HostingEnvironmentExtensions.IsDevelopment(env)
    let isEnvironment environmentName env = HostingEnvironmentExtensions.IsEnvironment(env, environmentName)
    let isProduction env = HostingEnvironmentExtensions.IsProduction(env)
    let isStaging env = HostingEnvironmentExtensions.IsStaging(env)

module HostBuilder =

    let start hostbuilder = HostingAbstractionsHostBuilderExtensions.Start hostbuilder


module Host =

    let run host = HostingAbstractionsHostExtensions.Run host
    let runAsync host token =
        let task = HostingAbstractionsHostExtensions.RunAsync(host, token)
        Async.AwaitTask task

    let start host = HostingAbstractionsHostExtensions.Start host
    let stopAsync host timeout =
        let task = HostingAbstractionsHostExtensions.StopAsync(host, timeout)
        Async.AwaitTask task

    let waitForShutdown host = HostingAbstractionsHostExtensions.WaitForShutdown host

    let waitForShutdownAsync host =
        let task = HostingAbstractionsHostExtensions.WaitForShutdownAsync host
        Async.AwaitTask task
