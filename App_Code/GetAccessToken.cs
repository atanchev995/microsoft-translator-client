using System;
using System.Web;

/// <summary>
/// Get the access token
/// </summary>
public class GetAccessToken
{
    public string GetAccessTokenString()
    {
        string clientID = "MicrosoftTranlatorClient";
        string clientSecret = "zogF5l/5doT3vGSCYTNdvjhvmhjN+XoNTHoi22CSIRw=";

        String strTranslatorAccessURI = "https://datamarket.accesscontrol.windows.net/v2/OAuth2-13";
        String strRequestDetails = string.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=http://api.microsofttranslator.com", HttpUtility.UrlEncode(clientID), HttpUtility.UrlEncode(clientSecret));

        System.Net.WebRequest webRequest = System.Net.WebRequest.Create(strTranslatorAccessURI);
        webRequest.ContentType = "application/x-www-form-urlencoded";
        webRequest.Method = "POST";

        byte[] bytes = System.Text.Encoding.ASCII.GetBytes(strRequestDetails);
        webRequest.ContentLength = bytes.Length;
        using (System.IO.Stream outputStream = webRequest.GetRequestStream())
        {
            outputStream.Write(bytes, 0, bytes.Length);
        }
        System.Net.WebResponse webResponse = webRequest.GetResponse();

        System.Runtime.Serialization.Json.DataContractJsonSerializer serializer = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(AdmAccessToken));
        //Get deserialized object from JSON stream 
        AdmAccessToken token = (AdmAccessToken)serializer.ReadObject(webResponse.GetResponseStream());

        string headerValue = "Bearer " + token.access_token;
        return headerValue;
    }
}