﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AspNetStandard.Diagnostics.HealthChecks.Entities
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HealthStatus
    {
        Unhealthy = 0,

        Degraded = 1,

        Healthy = 2
    }
}