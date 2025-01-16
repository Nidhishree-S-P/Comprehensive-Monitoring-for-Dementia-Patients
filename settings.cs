using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SensorMonitoring
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            string [ ] v = System.IO.File.ReadAllText("threshold.txt").Split(',');
            TxtTilt.Text = v[0];
            TxtMotion.Text = v[1];
            TxtPressure.Text = v[2];
            TxtMoisture.Text = v[3];
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string data = TxtTilt.Text + "," + TxtMotion.Text + "," + TxtPressure.Text + "," + TxtMoisture.Text;
            System.IO.File.WriteAllText("threshold.txt", data);
            MessageBox.Show("Settings saved", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
