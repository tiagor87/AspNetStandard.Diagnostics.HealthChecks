﻿using System.Net.Http;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]

namespace AspNetStandard.Diagnostics.HealthChecks.Services
{
    internal interface IAuthenticationService
    {
        bool NeedAuthentication();

        bool ValidateApiKey(HttpRequestMessage request);
    }
}