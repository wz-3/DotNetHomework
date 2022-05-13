using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            crawler.Download += Crawler_PageDownloaded;
        }
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        BindingSource bindingSource = new BindingSource();
        Crawler crawler = new Crawler();
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                Uri startUri = new Uri(textInitURL.Text);
            }
            catch (FormatException ex)
            {
                textInitURL.Clear();
                throw ex;
            }
            bindingSource.Clear();
            crawler.startUrl = textInitURL.Text;
            Match match = Regex.Match(crawler.startUrl, @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)");
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            Task.Run(() => crawler.Crawl());
            
        }
        private void Crawler_PageDownloaded(string url, string info)
        {
            var pageInfo = new { Column1 = bindingSource.Count + 1, URL = url, Column3 = info };
            Action action = () => { bindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }
        private void textInitURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
