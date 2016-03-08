using System;
using System.Web.UI;

public partial class _Default : System.Web.UI.Page 
{
    // fill the dropdown lists with languages when the page loads
    protected void Page_Load(object sender, EventArgs e)
    { 
        GetData fillList = new GetData();
        if (!Page.IsPostBack)
            fillList.FillLanguageList(ddlTranslateFrom, ddlTranslateTo);

        lblError.Text = String.Empty;
    }

    GetTranslation translate = new GetTranslation();

    // call the function for detecting the language
    protected void btnDetect_Click(object sender, EventArgs e)
    {
        string languageToDetect = txtInput.InnerText;

        try
        {
            translate.DetectLanguage(languageToDetect, ddlTranslateFrom);
        }
        catch (Exception er)
        {
            string error = er.ToString();
            lblError.Text = error;
        }

        txtInput.InnerText = languageToDetect;
    }

    // call the function for translating the user input
    protected void btnTranslate_Click(object sender, EventArgs e)
    {
        string textToTranslate = txtInput.InnerText;
        string fromLanguage = ddlTranslateFrom.SelectedValue;
        string toLanguage = ddlTranslateTo.SelectedValue;

        try
        {
            string translation = translate.TranslateLanguage(textToTranslate, fromLanguage, toLanguage);
            txtOutput.InnerText = translation;
        }
        catch (Exception er)
        {
            string error = er.ToString();
            lblError.Text = error;
        }
    }
}