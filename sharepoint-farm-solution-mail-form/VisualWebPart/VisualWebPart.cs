using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;

namespace Karamem0.Samples
{

    [ToolboxItem(false)]
    public class VisualWebPart : WebPart
    {

        private const string _ascxPath = @"~/_CONTROLTEMPLATES/15/MyApplication/VisualWebPart/VisualWebPartUserControl.ascx";

        protected override void CreateChildControls()
        {
            Control control = Page.LoadControl(_ascxPath);
            Controls.Add(control);
        }

    }

}
