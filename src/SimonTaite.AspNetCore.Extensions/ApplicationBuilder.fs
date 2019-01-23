namespace SimonTaite.AspNetCore.Extensions

open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Builder

module ApplicationBuilder =

    let useDeveloperExceptionPage  app=
        DeveloperExceptionPageExtensions.UseDeveloperExceptionPage app

    let useDeveloperExceptionPageOptions options app =
        DeveloperExceptionPageExtensions.UseDeveloperExceptionPage(app, options)

    let useDatabaseErrorPage app =
        DatabaseErrorPageExtensions.UseDatabaseErrorPage app

    let useDatabaseErrorPageOptions options app =
        DatabaseErrorPageExtensions.UseDatabaseErrorPage(app, options)

    let useExceptionHandler app =
        ExceptionHandlerExtensions.UseExceptionHandler app

    let useExceptionHandlerPath (path:string) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, path)

    let useExceptionHandlerConfig (configure:IApplicationBuilder -> unit) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, configure)

    let useExceptionHandlerOptions (options:ExceptionHandlerOptions) app =
        ExceptionHandlerExtensions.UseExceptionHandler(app, options)

    let useHsts app = HstsBuilderExtensions.UseHsts app

    let useHttps app = HttpsPolicyBuilderExtensions.UseHttpsRedirection app

    let useStaticFiles app =
        StaticFileExtensions.UseStaticFiles app

    let useStaticFilesPath (requestPath:string) app =
        StaticFileExtensions.UseStaticFiles(app, requestPath)

    let useStaticFilesOptions (options:StaticFileOptions) app =
        StaticFileExtensions.UseStaticFiles(app, options)

    let useCookiePolicy app =
        CookiePolicyAppBuilderExtensions.UseCookiePolicy app

    let useCookiePolicyOptions options app =
        CookiePolicyAppBuilderExtensions.UseCookiePolicy(app, options)

    let useAuthentication app = AuthAppBuilderExtensions.UseAuthentication app

    let useMvc app = MvcApplicationBuilderExtensions.UseMvc app

    let useMvcWithRoutes configureRoutes app =
        MvcApplicationBuilderExtensions.UseMvc(app, configureRoutes)

    let useMvcWithDefaultRoute app =
        MvcApplicationBuilderExtensions.UseMvcWithDefaultRoute app
