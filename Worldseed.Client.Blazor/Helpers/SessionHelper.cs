using Worldseed.Client.Blazor.DTOs;

namespace Worldseed.Client.Blazor.Helpers
{
    public static class SessionHelper
    {
        public static bool IsAuthenticated(LoginTokenResponseDTO tokenInformation)
        {
            return tokenInformation != null;
        }
    }
}
