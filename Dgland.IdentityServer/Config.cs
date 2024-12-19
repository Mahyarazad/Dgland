﻿using Duende.IdentityServer.Models;

namespace Dgland.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("webapi", "Dgland Web API")
                {
                    Scopes = { "webapi.fullread" }
                }
        };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("webapi.fullread"),

            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {

                new Client
                {   
                    ClientId = "webapim2m.client",
                    ClientName = "Client Credentials Client",
                    AccessTokenLifetime = 10,
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("511536EF-F270-4058-80CA-1C89C192F69A".Sha256()) },

                    AllowedScopes = {  "openid", "profile" , "webapi.fullread" }
                },

                // interactive client using code flow + pkce
                new Client
                {
                    ClientId = "interactive",
                    ClientSecrets = { new Secret("49C1A7E1-0C79-4A89-A3D6-A37998FB86B0".Sha256()) },

                    AllowedGrantTypes = GrantTypes.Code,

                    RedirectUris = { "https://localhost:44300/signin-oidc" },
                    FrontChannelLogoutUri = "https://localhost:44300/signout-oidc",
                    PostLogoutRedirectUris = { "https://localhost:44300/signout-callback-oidc" },

                    AllowOfflineAccess = true,
                    AllowedScopes = { "openid", "profile", "webapi.fullread" }
                },
            };
    }
}
