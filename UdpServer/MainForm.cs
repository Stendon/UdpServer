using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace UdpServer
{
    public partial class MainForm : Form
    {
        private UdpServer udpServer;
        private Thread recvThread;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            udpServer = new UdpServer(44000);
            udpServer.receiveMsg += OnUpdateRecvMessage ;
            recvThread = new Thread(udpServer.Receive);
            recvThread.Start();
        }

        private void OnSendMsgButtonClick(object sender, EventArgs e)
        {
            udpServer.SendMsg(SendMsgTextBox.Text);
            MessageDisplayTextBox.AppendText(SendMsgTextBox.Text + System.Environment.NewLine);
            MessageDisplayTextBox.Refresh();
            Switch2FirstLine();
        }

        private void OnCloseWindowButtonClick(object sender, EventArgs e)
        {
            CloseWindow();
        }

        private void OnUpdateRecvMessage(string msg)
        {
            if (MessageDisplayTextBox.InvokeRequired)
            {
                UdpServer.OnReceivceMsg recvMessage = new UdpServer.OnReceivceMsg(OnUpdateRecvMessage);
                this.Invoke(recvMessage, msg);
            }
            else
            {
                MessageDisplayTextBox.AppendText(msg + System.Environment.NewLine);
                MessageDisplayTextBox.Refresh();
            }
        }


        private void CloseWindow()
        {
            if (recvThread.IsAlive)
                recvThread.Join();

            this.Close();
        }

        private void OnMsgKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                udpServer.SendMsg(SendMsgTextBox.Text);
                MessageDisplayTextBox.AppendText(SendMsgTextBox.Text + System.Environment.NewLine);
                MessageDisplayTextBox.Refresh();
                Switch2FirstLine();
            }
        }


        private void Switch2FirstLine()
        {
            SendMsgTextBox.Text = "";
            SendMsgTextBox.ScrollToCaret();
            
        }
    }
}
