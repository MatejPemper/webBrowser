namespace webPreglednik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRemoveTab = new System.Windows.Forms.Button();
            this.buttonNewTab = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1065, 564);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Location = new System.Drawing.Point(139, 32);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(890, 20);
            this.textBoxSearchBar.TabIndex = 2;
            this.textBoxSearchBar.Text = "google";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(167, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 23);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 0);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveTab
            // 
            this.buttonRemoveTab.BackgroundImage = global::webPreglednik.Properties.Resources.img_510916;
            this.buttonRemoveTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRemoveTab.Location = new System.Drawing.Point(1003, 10);
            this.buttonRemoveTab.Name = "buttonRemoveTab";
            this.buttonRemoveTab.Size = new System.Drawing.Size(26, 23);
            this.buttonRemoveTab.TabIndex = 9;
            this.buttonRemoveTab.UseVisualStyleBackColor = true;
            this.buttonRemoveTab.Click += new System.EventHandler(this.buttonRemoveTab_Click);
            // 
            // buttonNewTab
            // 
            this.buttonNewTab.BackgroundImage = global::webPreglednik.Properties.Resources.newtab;
            this.buttonNewTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNewTab.Location = new System.Drawing.Point(139, 11);
            this.buttonNewTab.Name = "buttonNewTab";
            this.buttonNewTab.Size = new System.Drawing.Size(22, 23);
            this.buttonNewTab.TabIndex = 7;
            this.buttonNewTab.UseVisualStyleBackColor = true;
            this.buttonNewTab.Click += new System.EventHandler(this.buttonNewTab_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonHome.BackgroundImage = global::webPreglednik.Properties.Resources._60817__1_;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHome.Location = new System.Drawing.Point(13, 26);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(36, 34);
            this.buttonHome.TabIndex = 6;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackgroundImage = global::webPreglednik.Properties.Resources.ezgif_com_gif_maker__1_;
            this.buttonRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRefresh.Location = new System.Drawing.Point(110, 32);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(23, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.BackgroundImage = global::webPreglednik.Properties.Resources.icon_ios7_arrow_forward_512;
            this.buttonForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonForward.Location = new System.Drawing.Point(83, 32);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(21, 23);
            this.buttonForward.TabIndex = 4;
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::webPreglednik.Properties.Resources.ezgif_com_gif_maker;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBack.Location = new System.Drawing.Point(55, 32);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(22, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBrowse.BackgroundImage = global::webPreglednik.Properties.Resources._1024px_Search_Icon_svg;
            this.buttonBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonBrowse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonBrowse.Location = new System.Drawing.Point(1035, 26);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(39, 36);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 644);
            this.Controls.Add(this.buttonRemoveTab);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonNewTab);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WebBrowser";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonNewTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonRemoveTab;
    }
}

