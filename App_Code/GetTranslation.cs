using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

public class GetTranslation
{
    // detects the language from the user input
    public void DetectLanguage(string toDetect, DropDownList fromLanguage)
    {
        GetAccessToken auth = new GetAccessToken();
        string appId = auth.GetAccessTokenString();
        TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();

        string languageToDetect = toDetect;
        string detectedLanguage = client.Detect(appId, languageToDetect);
        fromLanguage.SelectedValue = detectedLanguage;
    }
}