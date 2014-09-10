using System;
using System.Web.UI.WebControls;
using AOPinSharePoint.AopExamplesWebPart.Aspects;
using Microsoft.SharePoint;


namespace AOPinSharePoint.AopExamplesWebPart.ExamplesUsingAspects
{


    /// <summary>
    /// Example06: This method demonstrates how a Location Interception Aspect can
    /// be used to carry out lazy loading and caching of a property value that is
    /// supplied by a remote system. Location Interception Aspects are useful for
    /// adding code and capabilities in and around property gets/sets and fields.
    /// </summary>
    public class Example06
    {


        #region Member Declarations


        // A reference to the Textbox to which we'll be sending output
        private readonly TextBox _outputTextBox;


        #endregion Member Declarations


        #region Constructor(s)


        public Example06(TextBox outputTextBox)
        {
            _outputTextBox = outputTextBox;
        }


        #endregion Constructor(s)


        #region Example Methods


        [TimingAspect]
        public void WriteExampleOutput()
        {
            String outputLine = "Total song count in the 2013 Bunker Tuneage " +
                                "collection = " + BunkerTuneage2013SongCount;
            _outputTextBox.Text += outputLine;
        }


        /// <summary>
        /// Returns the total number of songs in the Bunker Tuneage 2013 catalog
        /// using a library in another site collection.
        /// </summary>
        [RemoteReadOnlyPropertyAspect]
        public Int32 BunkerTuneage2013SongCount
        {
            get
            {
                Int32 itemCount = 0;
                using (SPSite otherSiteCollection = new SPSite("http://sp2013-dev:18580/"))
                {
                    SPWeb rootWeb = otherSiteCollection.RootWeb;
                    SPList btMusicList = rootWeb.GetList("/BunkerTuneage");
                    itemCount = btMusicList.ItemCount;
                }

                return itemCount;
            }
        }


        #endregion Example Methods


    }
}