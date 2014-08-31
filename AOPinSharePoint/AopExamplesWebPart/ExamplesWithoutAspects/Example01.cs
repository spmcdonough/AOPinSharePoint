using System;
using System.Web.UI.WebControls;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesWithoutAspects
{


    /// <summary>
    /// Example01: includes some very basic "business logic" to demonstrate
    /// how feature development might start before cross-cutting concerns are
    /// introduced.
    /// </summary>
    internal class Example01
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example01(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        public void GenerateExampleOutput()
        {
            _outputTextBox.Text = _outputTextBox.Text + GenerateLine1();
            _outputTextBox.Text = _outputTextBox.Text + GenerateLine2();
            _outputTextBox.Text = _outputTextBox.Text + GenerateLine3();
            _outputTextBox.Text = _outputTextBox.Text + GenerateLine4();
            _outputTextBox.Text = _outputTextBox.Text + GenerateLine5();
        }


        private String GenerateLine1()
        {
            String whatToWrite = "It is by caffeine alone that I set my mind in motion.\n\n";
            return whatToWrite;
        }


        private String GenerateLine2()
        {
            String whatToWrite = "It is by the beans of Java that thoughts acquire speed,\n\n";
            return whatToWrite;
        }


        private String GenerateLine3()
        {
            String whatToWrite = "the hands acquire shakes,\n\n";
            return whatToWrite;
        }


        private String GenerateLine4()
        {
            String whatToWrite = "the shakes become a warning.\n\n";
            return whatToWrite;
        }


        private String GenerateLine5()
        {
            String whatToWrite = "It is by caffeine alone I set my mind in motion.\n\n";
            return whatToWrite;
        }


        #endregion ExampleMethods


    }
}
