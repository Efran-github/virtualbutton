using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace VirtualButtons {
    public partial class Form1 : Form {
        private static readonly string[] Key = new string[16] {"{*}","{UP}","{*}","{*}",
                                                               "{LEFT}","{DOWN}","{RIGHT}","{*}",
                                                                    "{NUMLOCK}","^C","^V","{*}",
                                                                    "{ESC}","{BACKSPACE}","{TAB}","{ENTER}" };

        public Form1() {
            InitializeComponent();
        }

        private void Connect_Click(object sender, EventArgs e) {
            try {
                serialPort1.PortName = SerialPortNum.Text;
                serialPort1.BaudRate = int.Parse(BaudRate.Text);
                serialPort1.Open();
            }
            catch {
                if (serialPort1.IsOpen) serialPort1.Close();
                MessageBox.Show(@"无法打开串口！", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(@"确认开始，缩小窗口！",@"提示",MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.WindowState = FormWindowState.Minimized;
            timer1.Enabled = true;
            Connect.Enabled = false;
            Disconnect.Enabled = true;
        }




        private void Disconnect_Click(object sender, EventArgs e) {
            timer1.Enabled = false;
            if (!serialPort1.IsOpen) return;
            serialPort1.Close();
            Connect.Enabled = true;
            Disconnect.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (serialPort1.BytesToRead != 0) {
                int rec=serialPort1.ReadByte();
                serialPort1.DiscardInBuffer();
                if(rec>=0&&rec<=15) SendKeys.Send(Key[rec]);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            Connect.Enabled = true;
            Disconnect.Enabled = false;
        }

    }
}
