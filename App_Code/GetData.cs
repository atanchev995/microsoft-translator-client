using System.Web.UI.WebControls;

public class GetData
{
    private string[] languageCodes;
    private string[] languageNames;
    GetAccessToken auth = new GetAccessToken();
    TranslatorService.LanguageServiceClient client = new TranslatorService.LanguageServiceClient();

    // Gets the codes of the languages available in the Microsoft Translator service
    public string[] GetLanguageCodes()
    {
        string appId = auth.GetAccessTokenString();
        languageCodes = client.GetLanguagesForTranslate(appId);
        return languageCodes;
    }

    // Gets the names of the languages available in the Microsoft Translator service
    public string[] GetLanguageNames()
    {
        string appId = auth.GetAccessTokenString();
        languageCodes = GetLanguageCodes();
        languageNames = client.GetLanguageNames(appId, "en", languageCodes, false);
        return languageNames;
    }

    // Fills the dropdown lists with the languages available in the Microsoft Translator service
    public void FillLanguageList(DropDownList fromLanguage, DropDownList toLanguage)
    {
        languageNames = GetLanguageNames();

        for (int i = 0; i < languageNames.Length; i++)
        {
            fromLanguage.Items.Add(new ListItem(languageNames[i], languageCodes[i]));
            toLanguage.Items.Add(new ListItem(languageNames[i], languageCodes[i]));
        }
    }
}