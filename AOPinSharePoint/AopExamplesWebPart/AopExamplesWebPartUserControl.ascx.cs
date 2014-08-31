using System;
using System.Web.UI;
using AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects;
using AOPinSharePoint.AopExamplesWebPart.ExamplesWithoutAspects;


namespace AOPinSharePoint.AopExamplesWebPart
{


    /// <summary>
    /// This class contains the UI wire-up between the AopExamplePart web part and the back-end
    /// classes/code that provide the examples for Sean P McDonough's "Leveraging AOP in 
    /// SharePoint Custom Development" presentation.
    /// </summary>
    public partial class AopExamplesWebPartUserControl : UserControl
    {


        protected void Example01Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example01(ResultsTextbox);
            exampleCode.GenerateExampleOutput();
        }


        protected void Example02Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example02(ResultsTextbox);
            exampleCode.GenerateExampleOutput();
        }


        protected void Example03Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example03(ResultsTextbox);
            exampleCode.GenerateExampleOutput();
        }


    }
}