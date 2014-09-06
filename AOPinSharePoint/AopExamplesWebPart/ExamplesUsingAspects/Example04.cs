using System;
using System.IO;
using System.Net;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;
using Newtonsoft.Json.Linq;


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


        [TimingAspect]
        private String FetchChuckNorrisJoke()
        {
            // URL for the Internet Chuck Norris Database to get a nerdy joke
            const String icndbUrl = "http://api.icndb.com/jokes/random?limitTo=[nerdy]";
            String theJoke;
            
            // Make the HTTP call, process the JSON response, and extract the joke
            // so that it can be shown in the output "window."
            var requestJoke = WebRequest.Create(icndbUrl);
            var response = (HttpWebResponse) requestJoke.GetResponse();
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                var jsonResponse = sr.ReadToEnd();
                JObject jokeObject = JObject.Parse(jsonResponse);
                theJoke = jokeObject["value"]["joke"].ToString();
            }

            return theJoke;
        }


        public void WriteExampleOutput()
        {
            _outputTextBox.Text += FetchChuckNorrisJoke();
        }


        #endregion Example Methods


    }
}
