using System;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects
{


    /// <summary>
    /// Example04: another method boundary aspect that demonstrates two things.
    /// First, it shows how some simple timing and performance requirements
    /// can be addressed with AOP. Second, it highlights how objects and state
    /// can be passed between method boundary aspect invocations.
    /// </summary>
    internal class Example04
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example04(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        public void WriteExampleOutput()
        {
            _outputTextBox.Text += GetJoke();
        }


        [TimingAspect]
        private String GetJoke()
        {
            return IcndbMethods.FetchChuckNorrisJoke();
        }


        #endregion Example Methods


    }
}
