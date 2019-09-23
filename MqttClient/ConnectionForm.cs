using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Options;
using MQTTnet.Formatter;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MqttClient
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();

            btnConnect.Click += async (o, e) => {
                await BtnConnect_ClickAsync(o, e);
            };
        }

        private async Task BtnConnect_ClickAsync(object sender, System.EventArgs e)
        {
            try
            {
                btnConnect.Enabled = false;

                var client = new MqttFactory().CreateMqttClient();

                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(txtHost.Text, int.Parse(txtPort.Text))
                    .WithCredentials(txtUsername.Text, txtPassword.Text)
                    .WithProtocolVersion(MqttProtocolVersion.V311)
                    .Build();

                var auth = await client.ConnectAsync(options);

                if (auth.ResultCode != MqttClientConnectResultCode.Success)
                {
                    throw new Exception(auth.ResultCode.ToString());
                }
                else
                {
                    using (var feedFrm = new FeedForm(client))
                    {
                        try
                        {
                            Hide();
                            feedFrm.ShowDialog(this);
                        }
                        catch(Exception ex)
                        {
                            this.Error(ex);
                        }

                        Close();
                    }
                }
            }
            catch(Exception ex)
            {
                this.Error(ex);
                btnConnect.Enabled = true;
            }
        }
    }
}
