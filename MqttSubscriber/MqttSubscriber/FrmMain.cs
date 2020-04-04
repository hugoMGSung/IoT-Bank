using System;
using System.Net;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace MqttSubscriber
{
    public partial class FrmMain : Form
    {
        MqttClient client;
        delegate void UpdateTextCallback(string message);

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                IPAddress hostIP;
                hostIP = IPAddress.Parse(TxtConnectionString.Text);
                client = new MqttClient(hostIP);

                client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            try
            {
                //UpdateText(">>> Received Message");
                //UpdateText(">>> Topic: " + e.Topic);
                UpdateText(">>> Message: " + Encoding.UTF8.GetString(e.Message));

                // 메시지가 발생할 경우 DB에 저장
            }
            catch (Exception ex)
            {
                UpdateText("[ERROR] " + ex.Message);
            }
        }

        private void UpdateText(string message)
        {
            if (RtbRecieved.InvokeRequired)
            {
                UpdateTextCallback d = new UpdateTextCallback(UpdateText);
                this.Invoke(d, new object[] { message });
            }
            else
            {
                this.RtbRecieved.AppendText(message + "\n");
                this.RtbRecieved.ScrollToCaret();
            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(TxtClientId.Text + "_sub");
                UpdateText(">>>>> Client connected");
                client.Subscribe(new string[] { TxtTopic.Text }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                UpdateText(">>>>> Subscribing to : " + TxtTopic.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Disconnect();
                UpdateText(">> Client disconnected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
