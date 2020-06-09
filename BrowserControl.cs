using System.Windows.Forms;
using DotNetBrowser.Browser;
using DotNetBrowser.Engine;
using DotNetBrowser.WinForms;

namespace DotNetBrowserIssue
{
    public partial class BrowserControl : UserControl
    {
        private readonly IEngine _engine;
        private readonly IBrowser _browser;

        public string Url
        {
            get => _browser.Url;
            set => _browser.Navigation.LoadUrl(value);
        }

        public BrowserControl()
        {
            var webView = new BrowserView { Dock = DockStyle.Fill };
            _engine = EngineFactory.Create(
                new EngineOptions.Builder
                    {
                        RenderingMode = RenderingMode.HardwareAccelerated
                    }
                    .Build());
            _browser = _engine.CreateBrowser();
            webView.InitializeFrom(_browser);
            InitializeComponent();
            Controls.Add(webView);
        }
    }
}
