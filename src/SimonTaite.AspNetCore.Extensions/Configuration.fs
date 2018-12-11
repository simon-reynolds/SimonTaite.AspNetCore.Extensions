namespace SimonTaite.AspNetCore.Extensions

open Microsoft.Extensions.Configuration
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Configuration.Json

module FileConfiguration =

    let getFileLoadExceptionHandler =
        FileConfigurationExtensions.GetFileLoadExceptionHandler

    let getFileProvider =
        FileConfigurationExtensions.GetFileProvider

    let setBasePath path config =
        FileConfigurationExtensions.SetBasePath(config, path)

    let setFileProvider fileProvider config =
        FileConfigurationExtensions.SetFileProvider(config, fileProvider)    

    let setFileLoadExceptionHandler handler config =
        FileConfigurationExtensions.SetFileLoadExceptionHandler(config, handler)    


module JsonConfiguration =

    let addJsonByConfig (configureSource: JsonConfigurationSource -> unit) config =
        JsonConfigurationExtensions.AddJsonFile(config, configureSource)

    let addJson (path:string) config =
        JsonConfigurationExtensions.AddJsonFile(config, path)

    let addAppsettingsJson config =
        JsonConfigurationExtensions.AddJsonFile(config, "appsettings.json")

    let addAppsettingsPerEnvironmentJson (hosting:IHostingEnvironment) config =
        let path = sprintf "appsettings.%s.json" hosting.EnvironmentName
        JsonConfigurationExtensions.AddJsonFile(config, path, true)  

    let addJsonOptional path optional config =
        JsonConfigurationExtensions.AddJsonFile(config, path, optional)

    let addJsonOptionalReload path optional reloadOnChange config =
        JsonConfigurationExtensions.AddJsonFile(config, path, optional, reloadOnChange)

    let addJsonWithOptions path optional reloadOnChange config =
        let method = 
            match optional, reloadOnChange with
            | Some o, Some r -> addJsonOptionalReload path o r
            | Some o, None -> addJsonOptional path o
            | None, Some r -> addJsonOptionalReload path false r
            | None, None -> addJson path

        method config        