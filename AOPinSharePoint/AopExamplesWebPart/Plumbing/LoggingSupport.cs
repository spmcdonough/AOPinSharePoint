using System;
using System.Text;
using System.Web.UI.WebControls;


namespace AOPinSharePoint.AopExamplesWebPart.Plumbing
{

    
    /// <summary>
    /// This class takes care of writing messages to a "log" - which, in the
    /// case of this sample project, is just an ASP.NET Textbox. In a normal
    /// production application, this class would likely be more complex and
    /// include support for the SharePoint ULS log, Windows Event Log, etc.
    /// </summary>
    public static class LoggingSupport
    {


        public static void WriteToLog(String message, TextBox logSource)
        {
            // If no entry depth is specified, assume it's a top level (i.e., depth 1)
            // entry and call the overload.
            WriteToLog(message, logSource, 1);
        }


        public static void WriteToLog(String message, TextBox logSource, Int32 depth)
        {
            StringBuilder logEntryBuilder = new StringBuilder();
            
            // Format the log entry to distinguish it from the functional entries
            logEntryBuilder.Append(new String(' ', depth * 3));
            logEntryBuilder.Append(new String('+', depth * 3));
            logEntryBuilder.Append(message);

            // If the entry was passed in without a new line, add it to keep the output
            // looking relatively clean
            if (!message.EndsWith("\n"))
            {
                logEntryBuilder.Append("\n");
            }

            logSource.Text += logEntryBuilder.ToString();
        }
    }
}
