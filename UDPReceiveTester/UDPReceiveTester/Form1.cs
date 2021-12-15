using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace UDPReceiveTester
{
    public partial class Form1 : Form
    {
        private UdpClient srv;
        public Form1()
        {
            InitializeComponent();
        }
        #region connection related
        private void makeNewConnection(int port)
        {
            srv = new UdpClient(port);
            rtbResult.Text = "The connection is established.\n";
            srv.BeginReceive(dataReceived, null);
        }

        private void closeConnection()
        {
            try
            {
                srv.Client.Shutdown(SocketShutdown.Receive);
                srv.Close();
                rtbResult.Text = "port close";
            }
            catch (Exception)
            {
                rtbResult.Text = "port close is failed.";
            }

        }
        #endregion

        private void dataReceived(IAsyncResult ar)
        {
            IPEndPoint remoteIP = new IPEndPoint(IPAddress.Any, 0);

            byte[] data;

            try
            {
                data = srv.EndReceive(ar, ref remoteIP);
                if (data.Length == 0) return;
                srv.BeginReceive(dataReceived, null);
            }
            catch (ObjectDisposedException)
            {
                return;
            }

            this.BeginInvoke((Action<IPEndPoint, string>)dataReceivedUI, remoteIP, Encoding.UTF8.GetString(data));
        }

        private void dataReceivedUI(IPEndPoint endPoint, string data)
        {
            rtbResult.AppendText("[" + endPoint.ToString() + "] >> " + data + Environment.NewLine);
        }

        private bool chkPortField()
        {
            bool result = true;
            string portStr = tbPort.Text;


            if (portStr.Length != 4 && portStr.Length != 5)
            {
                result = false;
            }

            foreach (char c in portStr)
            {
                if (c < 48 || 57 < c)
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        #region event listener
        private void btnPortOpen_Click(object sender, EventArgs e)
        {
            if (chkPortField() == true)
            {
                switchComponentsStatus(true);
                makeNewConnection(Int32.Parse(tbPort.Text));
            }
            else
            {
                MessageBox.Show("Please chk port is valid!");
            }
        }

        private void btnPortClose_Click(object sender, EventArgs e)
        {
            closeConnection();
            switchComponentsStatus(false);
        }
        #endregion

        /**
         * true : port open btn hit
         * false : port close btn hit
         */
        private void switchComponentsStatus(bool flag)
        {
            if (flag == true)
            {
                btnPortOpen.Enabled = false;
                btnPortClose.Enabled = true;
                tbPort.Enabled = false;
            }
            else
            {
                btnPortOpen.Enabled = true;
                btnPortClose.Enabled = false;
                tbPort.Enabled = true;
            }
        }
    }
}
