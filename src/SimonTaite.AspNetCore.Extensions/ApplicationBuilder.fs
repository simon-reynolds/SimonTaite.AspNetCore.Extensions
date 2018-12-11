namespace SimonTaite.AspNetCore.Extensions

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Builder

module ApplicationBuilder =

    let useDeveloperExceptionPage =
        DeveloperExceptionPageExtensions.UseDeveloperExceptionPage

    let useDeveloperExceptionPageOptions options app =
        DeveloperExceptionPageExtensions.UseDeveloperExceptionPage(app, options)

    let useDatabaseErrorPage =
        DatabaseErrorPageExtensions.UseDatabaseErrorPage

    let useDatabaseErrorPageOptions options app =
        DatabaseErrorPageExtensions.UseDatabaseErrorPage(app, options)

    let useExceptionHandler =
        ExceptionHandlerExtensions.UseExceptionHandler

    let useExceptionHandlerPath (path:string) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, path)

    let useExceptionHandlerConfig (configure:IApplicationBuilder -> unit) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, configure)

    let useExceptionHandlerOptions (options:ExceptionHandlerOptions) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, options)

    let useHsts = HstsBuilderExtensions.UseHsts

    let useHttps = HttpsPolicyBuilderExtensions.UseHttpsRedirection

    let useStaticFiles =
        StaticFileExtensions.UseStaticFiles

    let useStaticFilesPath (requestPath:string) app =
        StaticFileExtensions.UseStaticFiles(app, requestPath)

    let useStaticFilesOptions (options:StaticFileOptions) app =
        StaticFileExtensions.UseStaticFiles(app, options)

    let useCookiePolicy =
        CookiePolicyAppBuilderExtensions.UseCookiePolicy

    let useCookiePolicyOptions options app =
        CookiePolicyAppBuilderExtensions.UseCookiePolicy(app, options)

    let useAuthentication = AuthAppBuilderExtensions.UseAuthentication

    let useMvc = MvcApplicationBuilderExtensions.UseMvc

    let useMvcWithRoutes configureRoutes app =
        MvcApplicationBuilderExtensions.UseMvc(app, configureRoutes)

    let useMvcWithDefaultRoute =
        MvcApplicationBuilderExtensions.UseMvcWithDefaultRoute