using System;
using System.Windows.Forms;

namespace DotNetBrowserIssue
{
    public partial class PdfControl : UserControl
    {
        private readonly BrowserControl _webBrowser;

        public void SetPdf(string pdf)
        {
            _webBrowser.Url = $"file://{Environment.CurrentDirectory}/{pdf}.pdf";
        }

        public PdfControl()
        {
            _webBrowser = new BrowserControl {Dock = DockStyle.Fill};
            InitializeComponent();
            Controls.Add(_webBrowser);
        }
    }
}
