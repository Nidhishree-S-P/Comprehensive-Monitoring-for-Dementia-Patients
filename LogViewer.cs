using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SensorMonitoring
{
    public partial class LogViewer : Form
    {
        public LogViewer()
        {
            InitializeComponent();
        }

        private void btnLogger_Click(object sender, EventArgs e)
        {
            SensorLogLoader();
            QsLogLoader();
        }

        private void SensorLogLoader()
        {
            lstSesnsorDataViewer.Items.Clear();
            FileStream fp = new FileStream("logs.txt", FileMode.Open);
            StreamReader reader = new StreamReader(fp);
            string data = null;
            while ((data = reader.ReadLine()) != null)
            {
                string[] vals = data.Split(',');
                ListViewItem L = new ListViewItem(vals[0]);
                L.SubItems.Add(vals[1]);
                L.SubItems.Add(vals[2]);
                L.SubItems.Add(vals[3]);
                L.SubItems.Add(vals[4]);
                lstSesnsorDataViewer.Items.Add(L);
            }
        }

        private void QsLogLoader()
        {
            lstQS.Items.Clear();
            FileStream fp = new FileStream("qs.txt", FileMode.Open);
            StreamReader reader = new StreamReader(fp);
            string data = null;
            while ((data = reader.ReadLine()) != null)
            {
                string[] vals = data.Split(',');
                if (vals.Length == 0) continue;
                ListViewItem L = new ListViewItem(vals[0]);
                L.SubItems.Add(vals[1]);
                lstQS.Items.Add(L);
            }
        }

    }
}
