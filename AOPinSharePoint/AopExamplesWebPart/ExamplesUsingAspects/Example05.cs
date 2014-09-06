using System;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;
using Newtonsoft.Json.Linq;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects
{


    /// <summary>
    /// Example05: 
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





    }
}
