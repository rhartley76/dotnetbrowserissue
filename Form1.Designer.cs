namespace DotNetBrowserIssue
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._optionsList = new System.Windows.Forms.ListBox();
            this._splitView = new System.Windows.Forms.SplitContainer();
            this._displayLabel = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this._splitView)).BeginInit();
            this._splitView.Panel1.SuspendLayout();
            this._splitView.Panel2.SuspendLayout();
            this._splitView.SuspendLayout();
            this.SuspendLayout();
            // 
            // _optionsList
            // 
            this._optionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._optionsList.FormattingEnabled = true;
            this._optionsList.ItemHeight = 29;
            this._optionsList.Items.AddRange(new object[] {
            "Item1",
            "Item2",
            "Item3"});
            this._optionsList.Location = new System.Drawing.Point(0, 0);
            this._optionsList.Name = "_optionsList";
            this._optionsList.Size = new System.Drawing.Size(495, 818);
            this._optionsList.TabIndex = 0;
            this._optionsList.SelectedValueChanged += new System.EventHandler(this._optionsList_SelectedValueChanged);
            // 
            // _splitView
            // 
            this._splitView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitView.Location = new System.Drawing.Point(0, 0);
            this._splitView.Name = "_splitView";
            // 
            // _splitView.Panel1
            // 
            this._splitView.Panel1.Controls.Add(this._optionsList);
            // 
            // _splitView.Panel2
            // 
            this._splitView.Panel2.Controls.Add(this._displayLabel);
            this._splitView.Size = new System.Drawing.Size(1486, 818);
            this._splitView.SplitterDistance = 495;
            this._splitView.TabIndex = 1;
            // 
            // _displayLabel
            // 
            this._displayLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._displayLabel.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._displayLabel.Location = new System.Drawing.Point(0, 0);
            this._displayLabel.Name = "_displayLabel";
            this._displayLabel.Size = new System.Drawing.Size(987, 818);
            this._displayLabel.TabIndex = 0;
            this._displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 818);
            this.Controls.Add(this._splitView);
            this.Name = "Form1";
            this.Text = "Form1";
            this._splitView.Panel1.ResumeLayout(false);
            this._splitView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitView)).EndInit();
            this._splitView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox _optionsList;
        private System.Windows.Forms.SplitContainer _splitView;
        private System.Windows.Forms.Label _displayLabel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

