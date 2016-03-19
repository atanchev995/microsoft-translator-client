/// <summary>
/// Set up an AdmAccessToken class which stores the information returned from the Windows Azure Marketplace service
/// </summary>
public class AdmAccessToken
{
    public string access_token { get; set; }

    public string token_type { get; set; }

    public string expires_in { get; set; }

    public string scope { get; set; }
}