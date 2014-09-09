using System;
using System.Web.UI;
using AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects;
using AOPinSharePoint.AopExamplesWebPart.ExamplesWithoutAspects;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;


namespace AOPinSharePoint.AopExamplesWebPart
{


    /// <summary>
    /// This class contains the UI wire-up between the AopExamplePart web part and the back-end
    /// classes/code that provide the examples for Sean P McDonough's "Leveraging AOP in 
    /// SharePoint Custom Development" presentation.
    /// </summary>
    public partial class AopExamplesWebPartUserControl : UserControl
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            // Take care of a few housekeeping items - like letting the various plumbing
            // pieces know about the web part's textbox.
            LoggingSupport.LoggingTextBox = LogTextbox;
        }


        protected void Example01Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example01(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }


        protected void Example02Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example02(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }


        protected void Example03Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example03(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }

        protected void Example04Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example04(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }

        protected void Example05Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example05(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }

        protected void Example06Button_Click(object sender, EventArgs e)
        {
            ResultsTextbox.Text = String.Empty;
            var exampleCode = new Example06(ResultsTextbox);
            exampleCode.WriteExampleOutput();
        }

    }
}