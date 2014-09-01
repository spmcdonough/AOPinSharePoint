using System;
using System.Web;
using System.Web.Caching;
using AOPinSharePoint.AopExamplesWebPart.Plumbing;


namespace AOPinSharePoint.AopExamplesWebPart.Unrelated_Sample_Code
{


    /// <summary>
    /// This class contains some code that was written for use as examples in
    /// the presentation but isn't actually part of the sample solution; i.e.,
    /// it has nothing to do with the executing web part.
    /// </summary>
    internal class NotPartOfExamples
    {


        private String GenerateLine1()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine1", 2);
            String whatToWrite;

            try
            {
                whatToWrite = "It is by caffeine alone that I set my mind in motion.\n";
            }
            catch (Exception ex)
            {
                var newAppException = new Exception("Unexpected problem generating line 1", ex);
                LoggingSupport.WriteToLog(newAppException.ToString(), 3);
                throw newAppException;
            }

            LoggingSupport.WriteToLog("Exiting Method GenerateLine1", 2);
            return whatToWrite;
        }


        private String GenerateLine01()
        {
            LoggingSupport.WriteToLog("Entering Method GenerateLine1", 2);
            const String lineCacheKey = "TESTAPP_GenerateLine1_KEY";
            String whatToWrite;

            try
            {
                var aspNetCache = HttpContext.Current.Cache;
                Object targetLineObject = aspNetCache[lineCacheKey];
                if (targetLineObject == null)
                {
                    targetLineObject = "It is by caffeine alone that I set my mind in motion.\n";
                    aspNetCache.Add(lineCacheKey, targetLineObject, null, Cache.NoAbsoluteExpiration, 
                        TimeSpan.FromMinutes(15), CacheItemPriority.Default, null);
                }
                whatToWrite = targetLineObject.ToString();
            }
            catch (Exception ex)
            {
                var newAppException = new Exception("Unexpected problem generating line 1", ex);
                LoggingSupport.WriteToLog(newAppException.ToString(), 3);
                LoggingSupport.WriteToLog("Exiting Method GenerateLine1 due to exception", 2);
                throw newAppException;
            }

            LoggingSupport.WriteToLog("Exiting Method GenerateLine1", 2);
            return whatToWrite;
        }

    }
}
