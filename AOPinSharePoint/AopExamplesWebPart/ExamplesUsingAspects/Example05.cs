using System;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects
{


    /// <summary>
    /// Example05: this example demonstrates how a MethodInterceptionAspect
    /// operates and can be used for something like exception handling -
    /// even "creative" exception handling. Method Interception Aspects run
    /// in place of the method they are applied to; the aspect can (and
    /// usually does) call the method in some way, but it also adds some
    /// value to the call.
    /// </summary>
    public class Example05
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example05(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        public void WriteExampleOutput()
        {
            _outputTextBox.Text += GetJoke();
        }


        [ExceptionHandlingAspect]
        private String GetJoke()
        {
            // Simulate an exception instead of actually trying to fetch 
            // a joke.
            // throw new Exception("Sorry - lost network connection");

            return IcndbMethods.FetchChuckNorrisJoke();
        }


        #endregion Example Methods


    }
}
