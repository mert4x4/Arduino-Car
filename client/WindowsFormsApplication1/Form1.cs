using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);

        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        char dir;
        char dir1;
        char dir2;
        byte speed = 255;
        int Port;

        bool Key_left;
        bool Key_right;
        bool Key_up;
        bool Key_down;

        public Form1()
        {
            InitializeComponent();
            StringBuilder StrBuild_Port = new StringBuilder(256);
            GetPrivateProfileString("Settings", "Port", "", StrBuild_Port, 255, "./config.ini");
            string temp = Convert.ToString(StrBuild_Port);
            Port = Convert.ToInt32(temp);
        }

        void Send(string text)
        {
            try
            {
                StringBuilder StrBuild_Ip = new StringBuilder(256);
                GetPrivateProfileString("Settings", "Ip", "", StrBuild_Ip, 255, "./config.ini");
                String IpAdress = Convert.ToString(StrBuild_Ip);
                int port = Port;
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                s.Connect(IpAdress, port);
                Byte[] buffer = Encoding.ASCII.GetBytes(text);
                s.Send(buffer);
                s.Close();
                label_connect.Text = "Connected";
            }
            catch
            {
                label_connect.Text = "Could not connect";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Up)
            {
                pictureBox_up.BackColor = Color.FromArgb(0, 0, 255);
                Key_up = true;
                label2.Text = "S";
            }
            else if (e.KeyValue == (int)Keys.Left)
            {
                pictureBox_left.BackColor = Color.FromArgb(0, 0, 255);
                Key_left = true;
            }
            else if (e.KeyValue == (int)Keys.Down)
            {
                pictureBox_down.BackColor = Color.FromArgb(0, 0, 255);
                Key_down = true;
                label2.Text = "R";
            }
            else if (e.KeyValue == (int)Keys.Right)
            {
                pictureBox_right.BackColor = Color.FromArgb(0, 0, 255);
                Key_right = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Right)
            {
                pictureBox_right.BackColor = Color.FromArgb(0, 255, 0);
                Key_right = false;
            }
            else if (e.KeyValue == (int)Keys.Up)
            {
                pictureBox_up.BackColor = Color.FromArgb(0, 255, 0);
                Key_up = false;
            }
            else if (e.KeyValue == (int)Keys.Left)
            {
                pictureBox_left.BackColor = Color.FromArgb(0, 255, 0);
                Key_left = false;
            }
            else if (e.KeyValue == (int)Keys.Down)
            {
                pictureBox_down.BackColor = Color.FromArgb(0, 255, 0);
                Key_down = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Key_up && Key_right)
                dir = 'R';
            else if (Key_up && Key_left)
                dir = 'L';
            else if (Key_down && Key_right)
                dir = 'R';
            else if (Key_down && Key_left)
                dir = 'L';
            else if (Key_up)
                dir = 'F';
            else if (Key_down)
                dir = 'B';
            if (!Key_up && !Key_down)
                dir = 'S';

            dir1 = dir;
            if(dir1 != dir2)
            {
                label1.Text = Convert.ToString(dir);
                //Send(Convert.ToString(dir + " " + speed));
            }
            dir2 = dir;
        }
    }
}
