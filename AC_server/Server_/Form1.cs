using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace Server_
{
    public partial class Form1 : Form
    {
        TcpListener server = null;
        TcpClient clientSocket = null;
        static int counter = 0;

        public Dictionary<TcpClient, string> clientList = new Dictionary<TcpClient, string>();


        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(InitSocket);
            t.IsBackground = true;
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitSocket()
        {
            server = new TcpListener(IPAddress.Any, 9999);
            clientSocket = default(TcpClient);
            server.Start();
            DisplayText("\t\t\t\tServer Started");

            while (true)
            {
                try
                {
                    counter++;
                    clientSocket = server.AcceptTcpClient();
                    

                    NetworkStream stream = clientSocket.GetStream();
                    byte[] buffer = new byte[1024];
                    int bytes = stream.Read(buffer, 0, buffer.Length);
                    string user_name = Encoding.Unicode.GetString(buffer, 0, bytes);
                    user_name = user_name.Substring(0, user_name.IndexOf("$"));

                    clientList.Add(clientSocket, user_name);
                    DisplayText(DateTime.Now+" >> "+user_name+" accept connection from client");
                    // send message all user
                    SendMessageAll(user_name + " 님이 접속했습니다. ", "", false);

                    handleClient h_client = new handleClient();
                    h_client.OnReceived += new handleClient.MessageDisplayHandler(OnReceived);
                    h_client.OnDisconnected += new handleClient.DisconnectedHandler(h_client_OnDisconnected);
                    h_client.startClient(clientSocket, clientList);
                }
                catch (SocketException se)
                {
                    Trace.WriteLine(string.Format("InitSocket - SocketException : {0}", se.Message));
                    break;
                }
                catch (Exception ex)
                {
                    Trace.WriteLine(string.Format("InitSocket - Exception : {0}", ex.Message));
                    break;
                }
            }

            clientSocket.Close();
            server.Stop();
        }

        void h_client_OnDisconnected(TcpClient clientSocket)
        {
            if (clientList.ContainsKey(clientSocket))
                clientList.Remove(clientSocket);
        }

        private void OnReceived(string message, string user_name)
        {
            string displayMessage = DateTime.Now+" >> " + user_name + " : " + message;
            DisplayText(displayMessage);
            SendMessageAll(message, user_name, true);
        }

        public void SendMessageAll(string message, string user_name, bool flag)
        {
            foreach (var pair in clientList)
            {
                Trace.WriteLine(string.Format("tcpclient : {0} user_name : {1}", pair.Key, pair.Value));

                TcpClient client = pair.Key as TcpClient;
                NetworkStream stream = client.GetStream();
                byte[] buffer = null;

                if (flag)
                {
                    buffer = Encoding.Unicode.GetBytes(user_name + " ☞ " + message);
                }
                else
                {
                    buffer = Encoding.Unicode.GetBytes(message);
                }

                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
        }

        private void DisplayText(string text)
        {
            if (richTextBox1.InvokeRequired)
            {
                richTextBox1.BeginInvoke(new MethodInvoker(delegate
                {
                    richTextBox1.AppendText(text + Environment.NewLine);
                }));
            }
            else
                richTextBox1.AppendText(text + Environment.NewLine);

             }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            save.ShowDialog();

            File.WriteAllText(save.FileName, richTextBox1.Text);
           
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("서버를 종료하시겠습니까?", "확인", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }
            else{

            }
        }
    }


       
    }
    class handleClient
    {
        TcpClient clientSocket = null;
        public Dictionary<TcpClient, string> clientList = null;

        public void startClient(TcpClient clientSocket, Dictionary<TcpClient, string> clientList)
        {
            this.clientSocket = clientSocket;
            this.clientList = clientList;

            Thread t_hanlder = new Thread(doChat);
            t_hanlder.IsBackground = true;
            t_hanlder.Start();
        }

        public delegate void MessageDisplayHandler(string message, string user_name);
        public event MessageDisplayHandler OnReceived;

        public delegate void DisconnectedHandler(TcpClient clientSocket);
        public event DisconnectedHandler OnDisconnected;

        private void doChat()
        {
            NetworkStream stream = null;
            try
            {
                byte[] buffer = new byte[1024];
                string msg = string.Empty;
                int bytes = 0;
                int MessageCount = 0;

                while (true)
                {
                    MessageCount++;
                    stream = clientSocket.GetStream();
                    bytes = stream.Read(buffer, 0, buffer.Length);
                    msg = Encoding.Unicode.GetString(buffer, 0, bytes);
                    msg = msg.Substring(0, msg.IndexOf("$"));

                    if (OnReceived != null)
                        OnReceived(msg, clientList[clientSocket].ToString());
                }
            }
            catch (SocketException se)
            {
                Trace.WriteLine(string.Format("doChat - SocketException : {0}", se.Message));

                if (clientSocket != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(clientSocket);

                    clientSocket.Close();
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(string.Format("doChat - Exception : {0}", ex.Message));

                if (clientSocket != null)
                {
                    if (OnDisconnected != null)
                        OnDisconnected(clientSocket);

                    clientSocket.Close();
                    stream.Close();
                }
            }
        }

    }


   
