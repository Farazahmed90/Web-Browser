using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
    public partial class MainForm : Form
    {
        WebBrowser web = new WebBrowser();
        int i = 0;
        private string homepage = Properties.Settings.Default.Homepage;
        public MainForm()
        {
            InitializeComponent();
        }
        private void CloseTabinstripmenu_Click(object sender, EventArgs e)
        {
            Close_Tab();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Open_New_Tab();
        }
        void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = Tab_Control_Index().DocumentTitle;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            Tab_Control_Index().Navigate(homepage);
            ComboBoxUrl.Text = homepage;
        }
        private void GoButton_Click(object sender, EventArgs e)
        {
            Navigate_To_Address();
           
        }
        private void ComboBoxUrl_KeyUp(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
                {
                    Navigate_To_Address();     
                }
        }
        private void NewtabButton_Click(object sender, EventArgs e)
        {
            Open_New_Tab();
        }
        private void BackButton_Click(object sender, WebBrowserNavigatingEventArgs e)
        {
            Tab_Control_Index().GoBack();
           
             
        }
        private void ForwardButton_Click(object sender, EventArgs e)
        {
            Tab_Control_Index().GoForward();
           
        }
        private void CloseTabButton_Click(object sender, EventArgs e)
        {
            Close_Tab();
        }
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open_New_Tab();
        }
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Tab_Control_Index().Refresh();
           
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingForm().ShowDialog();
        } 
        
        private void Open_New_Tab()        //Method for open new Tab (Start)
        {
            web = new WebBrowser();
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.Visible = true;
            web.DocumentCompleted += web_DocumentCompleted;
            tabControl.TabPages.Add("New Tab");
            tabControl.SelectTab(i);
            tabControl.SelectedTab.Controls.Add(web);
            i += 1;
            ComboBoxUrl.Text = "";
        }                                 //Method for open new Tab (End)
        
        private void Close_Tab()            // Method For Close Tab (Starts)
        {
            if (tabControl.TabPages.Count - 1 > 0)
            {

                tabControl.TabPages.RemoveAt(tabControl.SelectedIndex);
                tabControl.SelectTab(tabControl.TabPages.Count - 1);
                i -= 1;

            }
            else
                Application.Exit();
        }                                   //Method For Close Tab (Ends)
        
        private WebBrowser Tab_Control_Index()   //Method For Tab Control index (starts)
        {
            return ((WebBrowser)tabControl.SelectedTab.Controls[0]);
        }                                        //Method For Tab Control index (Ends)

        private void Navigate_To_Address()     //Method For Navigatoion (Starts)
        {
            Tab_Control_Index().Navigate(ComboBoxUrl.Text);
            if (!ComboBoxUrl.Items.Contains(ComboBoxUrl.Text))
            {

                ComboBoxUrl.Items.Add(ComboBoxUrl.Text);
                

            }
            
        }                                     //Method For Navigation (Ends)                                             
    }
}
