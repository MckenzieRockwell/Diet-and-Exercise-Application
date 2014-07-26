using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace Diet_and_Exercise_Application
{
    public partial class Graph : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set chart palette colors to match Bootstrap United theme
            foreach (Control control in Page.Controls)
            {
                if (control is Chart) {
                    ((Chart)control).PaletteCustomColors = new Color[] {
                        ColorTranslator.FromHtml("#DD4814"), // Primary
                        ColorTranslator.FromHtml("#38B44A"), // Success
                        ColorTranslator.FromHtml("#772953"), // Info
                        ColorTranslator.FromHtml("#EFB73E"), // Warning
                        ColorTranslator.FromHtml("#DF382C"), // Danger
                        ColorTranslator.FromHtml("#AEA79F")  // Default
                    };
                }
            }
        }
    }
}
