namespace SimonTaite.AspNetCore.Extensions

open Microsoft.AspNetCore.Identity
open Microsoft.Extensions.DependencyInjection

module Identity =

    let addDefaultIdentity =
        IdentityServiceCollectionUIExtensions.AddDefaultIdentity

    let addDefaultIdentityOptions options services =
        IdentityServiceCollectionUIExtensions.AddDefaultIdentity(services, options)

    let addDefaultUI =
        IdentityBuilderUIExtensions.AddDefaultUI

    let addDefaultUIFramework framework builder =
        IdentityBuilderUIExtensions.AddDefaultUI(builder, framework)
