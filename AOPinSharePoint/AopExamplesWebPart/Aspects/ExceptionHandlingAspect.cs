using System;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;
using PostSharp.Aspects;


namespace AOPinSharePoint.AopExamplesWebPart.Aspects
{
    
    
    /// <summary>
    /// This method interception aspect can be used to add "automatic"
    /// exception handling to a method. When a method is set up to use
    /// this aspect, the method is wrapped in an exception handler that
    /// prevents exceptions from bubbling-up. Any trapped exception is
    /// also written to the log window.
    /// </summary>
    [Serializable]
    public class ExceptionHandlingAspect : MethodInterceptionAspect
    {


        #region Overrides: MethodInterceptionAspect 


        /// <summary>
        /// Whenever a MethodInterceptionAspect is applied to a method,
        /// execution of that method is bypassed and control is passed
        /// to the <c>OnInvoke</c> method of the aspect. The aspect then
        /// has the option of invoking the method to which the aspect is
        /// applied, carrying out it's own actions, or a combination of
        /// the two.
        /// </summary>
        public override void OnInvoke(MethodInterceptionArgs args)
        {
            try
            {
                args.Proceed();
            }
            catch (Exception ex)
            {
                // Something went wrong calling the targeted method. We
                // need to log the problem.
                LoggingSupport.WriteToLog(String.Format("Exception encountered " +
                    "executing the '{0}'.\n - Exception Message: '{1}'",
                    args.Method.Name, ex.Message));

                // Chances are the method we're intercepting passes back a
                // String; if so, assign something funny for return.
                if (args.ReturnValue is String)
                {
                    args.ReturnValue = "Oops!";
                }
            }
        }


        #endregion Overrides : MethodInterceptionAspect


    }
}
