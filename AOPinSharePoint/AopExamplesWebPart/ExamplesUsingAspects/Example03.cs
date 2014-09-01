using System;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects
{


    /// <summary>
    /// Example03: demonstrates a simpler way to develop cross-cutting logging
    /// code with the creation and usage of a simple aspect.
    /// </summary>
    [LoggingToTextboxAspect]
    internal class Example03
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example03(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        public void WriteExampleOutput()
        {
            _outputTextBox.Text += GenerateLine1();
            _outputTextBox.Text += GenerateLine2();
            _outputTextBox.Text += GenerateLine3();
            _outputTextBox.Text += GenerateLine4();
            _outputTextBox.Text += GenerateLine5();
        }


        private String GenerateLine1()
        {
            return "It is by caffeine alone that I set my mind in motion.\n";
        }


        private String GenerateLine2()
        {
            return "It is by the beans of Java that thoughts acquire speed,\n";
        }


        private String GenerateLine3()
        {
            return "  the hands acquire shakes,\n";
        }


        private String GenerateLine4()
        {
            return "  the shakes become a warning.\n";
        }


        private String GenerateLine5()
        {
            return "It is by caffeine alone I set my mind in motion.\n";
        }


        #endregion ExampleMethods


    }
}
