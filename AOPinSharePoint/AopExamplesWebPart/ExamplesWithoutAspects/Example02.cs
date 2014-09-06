using System;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesWithoutAspects
{


    /// <summary>
    /// Example02: includes the same code as Example01, but we've introduced
    /// logging code so that we can follow the chain of execution within the
    /// application as it writes its output.
    /// </summary>
    internal class Example02
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example02(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        public void WriteExampleOutput()
        {
            LoggingSupport.WriteToLog("Entering Method WriteExampleOutput");

            _outputTextBox.Text += GenerateLine1();
            _outputTextBox.Text += GenerateLine2();
            _outputTextBox.Text += GenerateLine3();
            _outputTextBox.Text += GenerateLine4();
            _outputTextBox.Text += GenerateLine5();

            LoggingSupport.WriteToLog("Exiting Method WriteExampleOutput");
        }


        private String GenerateLine1()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine1", 2);
            String whatToWrite = "It is by caffeine alone that I set my mind in motion.\n";
            LoggingSupport.WriteToLog("Exiting Method GenerateLine1", 2);
            return whatToWrite;
        }


        private String GenerateLine2()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine2", 2);
            String whatToWrite = "It is by the beans of Java that thoughts acquire speed,\n";
            LoggingSupport.WriteToLog("Exiting Method GenerateLine2", 2);
            return whatToWrite;
        }


        private String GenerateLine3()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine3", 2);
            String whatToWrite = "  the hands acquire shakes,\n";
            LoggingSupport.WriteToLog("Exiting Method GenerateLine3", 2);
            return whatToWrite;
        }


        private String GenerateLine4()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine4", 2);
            String whatToWrite = "  the shakes become a warning.\n";
            LoggingSupport.WriteToLog("Exiting Method GenerateLine4", 2);
            return whatToWrite;
        }


        private String GenerateLine5()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine5", 2);
            String whatToWrite = "It is by caffeine alone I set my mind in motion.\n";
            LoggingSupport.WriteToLog("Exiting Method GenerateLine5", 2);
            return whatToWrite;
        }


        #endregion ExampleMethods


    }
}