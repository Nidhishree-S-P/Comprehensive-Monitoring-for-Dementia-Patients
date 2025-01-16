using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using System.Speech.Synthesis;
using System.Threading;
using System.IO;
namespace SensorMonitoring
{
    public partial class Form1 : Form
    {
        MqttClient client = null, client1 = null;
        string clientId;
        string mqttserverip = "broker.hivemq.com";
        //string mqttserverip = "broker.emqx.io";
        SpeechSynthesizer synthesizer;
        public Form1()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  // 0...100
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                client = new MqttClient(mqttserverip);
                client1 = new MqttClient(mqttserverip);

                client.Subscribe(new string[] { "alzimers_patient" }, new byte[] { 2 });
                client1.Subscribe(new string[] { "question_answer" }, new byte[] { 2 });

                // sensor data
                client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

                // q & a
                client1.MqttMsgPublishReceived += client_MqttMsgPublishReceived1;


                clientId = Guid.NewGuid().ToString();
                client.Connect(clientId);


                clientId = Guid.NewGuid().ToString();
                client1.Connect(clientId);
                btnStartStop.BackColor = Color.Green;
            }
            else
            {
                client.Disconnect();
                client1.Disconnect();
                btnStartStop.BackColor = Color.Red;
            }
        }

        void client_MqttMsgPublishReceived1(object sender, MqttMsgPublishEventArgs e)
        {
            // answer will be receieved here...
            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            if (ReceivedMessage == "start")
            {
                btnMind.BackColor = Color.Green;
            }
            else if (ReceivedMessage == "stop")
            {
                btnMind.BackColor = Color.Gray;
            }
            else
            {
                FileStream fp = new FileStream("qs.txt", FileMode.Append);
                StreamWriter writer = new StreamWriter(fp);
                writer.WriteLine(DateTime.Now.ToString() + "," + ReceivedMessage);
                writer.Close();
                fp.Close();
            }
        }

        void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            // String pub_data = "[" + String(tilt) + "," + String(pir_current_state) + "," + String(preassure) + "," + String(moisture) + "]";

            string ReceivedMessage = Encoding.UTF8.GetString(e.Message);
            if (!(ReceivedMessage.IndexOf("[") != -1 && ReceivedMessage.IndexOf("]") != -1))
                return;

            string[] threshold = System.IO.File.ReadAllText("threshold.txt").Split(',');

            float t_magnitude = float.Parse(threshold[0]);
            float t_motion= float.Parse(threshold[1]);
            float t_pressure = float.Parse(threshold[2]);
            float t_moisture = float.Parse(threshold[3]);

            string data = ReceivedMessage.Substring(1, ReceivedMessage.Length - 2).Trim();
            string[] vals = data.Split(',');
            float magnitude = float.Parse(vals[0]);
            float motion = float.Parse(vals[1]);
            float pressure = float.Parse(vals[2]);
            float moisture = float.Parse(vals[3]);   // get ph from iot

            TxtTilt.Text  = magnitude.ToString();
            TxtMotion.Text = motion.ToString();
            TxtPressure.Text = pressure.ToString();
            TxtMoisture.Text = moisture.ToString();

           // string speakMsg = "";
            string logdata = "";
            if (magnitude > t_magnitude)
            {
                //  speakMsg = "Magnitude,";
                btnLight1.BackColor = Color.Red;
                logdata += "Fall detection,";
            }
            else
            {
                btnLight1.BackColor = Color.Green;
                logdata += "Normal,";
            }

            if (motion ==1)
            {
                // speakMsg = speakMsg + "Tilt,";
                btnLight2.BackColor = Color.Red;
                logdata += "Motion found,";
            }
            else
            {
                btnLight2.BackColor = Color.Green;
                logdata += "Motion not found,";
            }

            if (pressure > t_pressure)
            {
                //speakMsg = speakMsg + "Sleeping";
                btnLight3.BackColor = Color.Red;
                logdata += "Person sleeping,";
            }
            else
            {
                btnLight3.BackColor = Color.Green;
                logdata += "Person away from bed,";
            }

            if (moisture > t_moisture)
            {
              //  speakMsg = speakMsg + "Load-2";
                btnLight4.BackColor = Color.Red;
                logdata += "Nature call";
            }
            else
            {
                btnLight4.BackColor = Color.Green;
                 logdata += "All is well";
            }

            FileStream fp = new FileStream("logs.txt", FileMode.Append);
            StreamWriter writer = new StreamWriter(fp);
            writer.WriteLine(DateTime.Now.ToString() + "," + logdata);
            writer.Close();
            fp.Close();

            //if (speakMsg.Length > 0)
            //{
            //    synthesizer.Speak(speakMsg + " not fresh , replace immediately else items will be spoiled");
            //}
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            settings frm = new settings();
            frm.ShowDialog();
        }

        private void BtnMedicine_Click(object sender, EventArgs e)
        {
           }

        private void BtnMedicine_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                client.Publish("alzimers_patient_callback", Encoding.UTF8.GetBytes("on"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
            else
                client.Publish("alzimers_patient_callback", Encoding.UTF8.GetBytes("off"), MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE, false);
        }

        
    }
}
