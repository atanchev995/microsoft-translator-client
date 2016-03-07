using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    // fill the dropdown lists with languages when the page loads
    protected void Page_Load(object sender, EventArgs e)
    { 
        GetData fillList = new GetData();
        fillList.FillLanguageList(ddlTranslateFrom, ddlTranslateTo);
    }

    GetTranslation translate = new GetTranslation();

    // call the function for detecting the language
    protected void btnDetect_Click(object sender, EventArgs e)
    {
        string languageToDetect = txtInput.InnerText;
        translate.DetectLanguage(languageToDetect, ddlTranslateFrom);
        txtInput.InnerText = languageToDetect;
    }
}