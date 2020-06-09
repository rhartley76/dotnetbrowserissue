using System;
using System.Windows.Forms;

namespace DotNetBrowserIssue
{
    public partial class Form1 : Form
    {
        private readonly PdfControl _pdfControl;

        public Form1()
        {
            _pdfControl = new PdfControl { Dock = DockStyle.Fill };
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _pdfControl?.Dispose();
        }

        private void _optionsList_SelectedValueChanged(object sender, EventArgs e)
        {
            _splitView.Panel2.Controls.Clear();

            switch (_optionsList.Text)
            {
                case "Item1":
                case "Item2":
                    _displayLabel.Text = _optionsList.Text;
                    _splitView.Panel2.Controls.Add(_displayLabel);
                    break;
                case "Item3":
                    _pdfControl.SetPdf(_optionsList.Text);
                    _splitView.Panel2.Controls.Add(_pdfControl);
                    break;
            }
        }
    }
}
