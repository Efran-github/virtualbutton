
namespace VirtualButtons
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Disconnect = new System.Windows.Forms.Button();
            this.BaudRate = new System.Windows.Forms.TextBox();
            this.SerialPortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Disconnect
            // 
            this.Disconnect.BackColor = System.Drawing.Color.Orange;
            this.Disconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Disconnect.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Disconnect.FlatAppearance.BorderSize = 0;
            this.Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Disconnect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Disconnect.Location = new System.Drawing.Point(76, 300);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(2);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(255, 48);
            this.Disconnect.TabIndex = 11;
            this.Disconnect.Text = "断开";
            this.Disconnect.UseVisualStyleBackColor = false;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // BaudRate
            // 
            this.BaudRate.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.BaudRate.Location = new System.Drawing.Point(197, 185);
            this.BaudRate.Margin = new System.Windows.Forms.Padding(2);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(134, 30);
            this.BaudRate.TabIndex = 10;
            this.BaudRate.Text = "9600";
            // 
            // SerialPortNum
            // 
            this.SerialPortNum.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.SerialPortNum.Location = new System.Drawing.Point(197, 126);
            this.SerialPortNum.Margin = new System.Windows.Forms.Padding(2);
            this.SerialPortNum.Name = "SerialPortNum";
            this.SerialPortNum.Size = new System.Drawing.Size(134, 30);
            this.SerialPortNum.TabIndex = 9;
            this.SerialPortNum.Text = "COM5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(121, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(121, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "串口号";
            // 
            // Connect
            // 
            this.Connect.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Connect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Connect.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Connect.FlatAppearance.BorderSize = 0;
            this.Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Connect.Location = new System.Drawing.Point(76, 244);
            this.Connect.Margin = new System.Windows.Forms.Padding(2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(255, 48);
            this.Connect.TabIndex = 6;
            this.Connect.Text = "连接";
            this.Connect.UseVisualStyleBackColor = false;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(174, 368);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "20012302045凌奕锋";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Enabled = false;
            this.Logo.FlatAppearance.BorderSize = 0;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Location = new System.Drawing.Point(12, -12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(406, 135);
            this.Logo.TabIndex = 14;
            this.Logo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(76, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 38);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(76, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(392, 398);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.SerialPortNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "单片机最小应用系统设计";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.TextBox BaudRate;
        private System.Windows.Forms.TextBox SerialPortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

