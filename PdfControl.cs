using System;
using System.Windows.Forms;

namespace DotNetBrowserIssue
{
    public partial class PdfControl : UserControl
    {
        public void SetPdf(string pdf)
        {
            Browser.Url = $"file://{Environment.CurrentDirectory}/{pdf}.pdf";
        }

        public BrowserControl Browser { get; set; }

        public PdfControl()
        {
            Browser = new BrowserControl {Dock = DockStyle.Fill};
            InitializeComponent();
            Controls.Add(Browser);
        }
    }
}
