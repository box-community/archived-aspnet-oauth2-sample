namespace BoxApi.V2.Samples.WebAuthentication.MVC.Models
{
    public class AuthModel
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string AuthToken { get; set; }
        public string RefreshToken { get; set; }
    }
}