namespace SimonTaite.AspNetCore.Extensions

open Microsoft.AspNetCore.Identity
open Microsoft.Extensions.DependencyInjection

module Identity =

    let addDefaultIdentity<'TUser when 'TUser : not struct> services =
        IdentityServiceCollectionUIExtensions.AddDefaultIdentity<'TUser> services

    let addDefaultIdentityOptions<'TUser when 'TUser : not struct> options services =
        IdentityServiceCollectionUIExtensions.AddDefaultIdentity<'TUser>(services, options)

    let addDefaultUI builder =
        IdentityBuilderUIExtensions.AddDefaultUI builder

    let addDefaultUIFramework framework builder =
        IdentityBuilderUIExtensions.AddDefaultUI(builder, framework)
