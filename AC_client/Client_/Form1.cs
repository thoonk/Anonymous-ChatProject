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
using System.Drawing;



namespace Client_
{
    public partial class Form1 : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream stream = default(NetworkStream);
        string message = string.Empty;
        public Form1()
        {
            InitializeComponent();



            // richTextBox1.BackColor = new SolidBrush(Color.FromArgb(10, 255, 0, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            clientSocket.Connect("192.168.81.10", 9999); //127.0.0.1
            stream = clientSocket.GetStream();

            message = "Connected to Chat Server";
            DisplayText(message);

            byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxNickName.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();

            Thread t_handler = new Thread(GetMessage);
            t_handler.IsBackground = true;
            t_handler.Start();

        }

        private void btnSendText_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxMessage.Text + "$");
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
            textBoxMessage.Clear();
        }

        private void GetMessage()
        {
            while (true)
            {
                stream = clientSocket.GetStream();
                int BUFFERSIZE = clientSocket.ReceiveBufferSize;
                byte[] buffer = new byte[BUFFERSIZE];
                int bytes = stream.Read(buffer, 0, buffer.Length);

                string message = Encoding.Unicode.GetString(buffer, 0, bytes);
                DisplayText(message);
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

        private void textBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {


                byte[] buffer = Encoding.Unicode.GetBytes(this.textBoxMessage.Text + "$");
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
                textBoxMessage.Clear();
            }
            else
            {
                return;
            }
        }

        private void back_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.DefaultExt = "jpg";
            openFile.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            //String strfile = openFile.FileName;
            //openFile.ShowDialog();
            openFile.FileName = "";
            if (openFile.ShowDialog() == DialogResult.OK)
                panel.BackgroundImage = new Bitmap(openFile.FileName);


        }

        private void font_button_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();

            font.ShowColor = true;
            font.ShowDialog();
            richTextBox1.Font = font.Font;
            richTextBox1.ForeColor = font.Color;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }



        private void ToolStripMenuItem_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.SelectedText);
        }

        private void ToolStripMenuItem_paste_Click(object sender, EventArgs e)
        {
            string strPaste = Clipboard.GetText();

            string strContent = textBoxMessage.Text;
            string strResult = strContent.Insert(textBoxMessage.SelectionStart, strPaste);

            textBoxMessage.Text = strResult;
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void ToolStripMenuItem1_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            save.ShowDialog();

            File.WriteAllText(save.FileName, richTextBox1.Text);

        }

        private void ToolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

