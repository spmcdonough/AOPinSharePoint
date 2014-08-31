using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;


namespace AOPinSharePoint.AopExamplesWebPart
{
    [ToolboxItemAttribute(false)]
    public class AopExamplesWebPart : WebPart
    {
        // Visual Studio might automatically update this path when you change the Visual Web Part project item.
        private const string _ascxPath = @"~/_CONTROLTEMPLATES/15/AOPinSharePoint/AopExamplesWebPart/AopExamplesWebPartUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }
    }
}
