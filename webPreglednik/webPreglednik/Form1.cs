using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace webPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBoxSearchBar.Text);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void buttonBookmark_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();   
        }

        private void buttonNewTab_Click(object sender, EventArgs e)
        {
              TabPage tabPage = new TabPage();
               tabPage.Text = "New Tab";
               TabControl tabControl = new TabControl();   
               tabControl.Controls.Add(tabPage);

               WebBrowser webBrowser = new WebBrowser();
               webBrowser.Parent = tabPage;
               webBrowser.Dock = DockStyle.Fill;
               webBrowser.Navigate("www.google.com");

            string title = "TabPage " + (tabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            tabControl1.TabPages.Add(myTabPage);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
       

          
        }

        private void buttonRemoveTab_Click(object sender, EventArgs e)
        {
            // Removes the selected tab:  
            tabControl1.TabPages.Remove(tabControl1.SelectedTab);
           
        }
    }
}
