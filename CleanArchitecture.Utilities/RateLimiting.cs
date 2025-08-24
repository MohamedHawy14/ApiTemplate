using Microsoft.AspNetCore.RateLimiting;
using System.Threading.RateLimiting;

namespace CleanArchitecture.Utilities.RateLimiting;

    /// <summary>
    /// Endpoint-specific rate limiting policies for the API.
    /// Apply by using [EnableRateLimiting(PolicyName)] on controllers/actions.
    /// </summary>
    public static class EndpointRateLimitPolicies
    {
        // Policy name constants for easy reuse
        public const string LoginPolicyName = "LoginPolicy";
        public const string GeneralPolicyName = "GeneralPolicy";

        public static void Register(RateLimiterOptions options)
        {
            // Stricter policy for login endpoints (partitioned by username or IP)
            options.AddFixedWindowLimiter(LoginPolicyName, httpContext =>
                RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: httpContext.User.Identity?.Name 
                        ?? httpContext.Connection.RemoteIpAddress?.ToString() 
                        ?? "anonymous",
                    factory: _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 5, // 5 requests
                        Window = TimeSpan.FromMinutes(5),
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                        QueueLimit = 2
                    }
                )
            );

            // Relaxed policy for general GET endpoints (partitioned by IP)
            options.AddFixedWindowLimiter(GeneralPolicyName, httpContext =>
                RateLimitPartition.GetFixedWindowLimiter(
                    partitionKey: httpContext.Connection.RemoteIpAddress?.ToString() ?? "unknown",
                    factory: _ => new FixedWindowRateLimiterOptions
                    {
                        PermitLimit = 100, // 100 requests
                        Window = TimeSpan.FromMinutes(1),
                        QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                        QueueLimit = 10
                    }
                )
            );
        }
    }
