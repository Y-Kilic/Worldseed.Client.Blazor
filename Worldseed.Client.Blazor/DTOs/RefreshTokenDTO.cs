namespace Worldseed.Client.Blazor.DTOs
{
    public class RefreshTokenDTO
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }

    }
}
