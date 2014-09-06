using System;
using System.Diagnostics;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;
using PostSharp.Aspects;


namespace AOPinSharePoint.AopExamplesWebPart.Aspects
{


    [Serializable]
    public class TimingAspect : OnMethodBoundaryAspect
    {


        #region Overrides: OnMethodBoundaryAspect


        /// <summary>
        /// The OnEntry method fires on the join point that occurs just before
        /// a method is entered and its first lines of code are executed.
        /// </summary>
        public override void OnEntry(MethodExecutionArgs args)
        {
            // Start the stopwatch!
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            args.MethodExecutionTag = stopwatch;
            LoggingSupport.WriteToLog("Stopwatch started.");
        }


        /// <summary>
        /// The OnExit method fires on the join point that occurs just after
        /// a method is exited and its execution is complete.
        /// </summary>
        public override void OnExit(MethodExecutionArgs args)
        {
            var stopWatch = args.MethodExecutionTag as Stopwatch;
            stopWatch.Stop();
            LoggingSupport.WriteToLog("Stopwatch stopped. Elapsed time: " + 
                stopWatch.ElapsedMilliseconds + "ms");
        }


        #endregion Overrides: OnMethodBoundaryAspect


    }
}
