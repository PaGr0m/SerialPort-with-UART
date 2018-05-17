namespace Network_Network
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Connect = new System.Windows.Forms.Button();
            this.comboBoxPortsName = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Disconnect = new System.Windows.Forms.Button();
            this.comboBoxBaudrate = new System.Windows.Forms.ComboBox();
            this.listBoxStatus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timerPort = new System.Windows.Forms.Timer(this.components);
            this.PortConsole = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 158);
            this.Connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(121, 26);
            this.Connect.TabIndex = 2;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // comboBoxPortsName
            // 
            this.comboBoxPortsName.FormattingEnabled = true;
            this.comboBoxPortsName.Location = new System.Drawing.Point(11, 34);
            this.comboBoxPortsName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPortsName.Name = "comboBoxPortsName";
            this.comboBoxPortsName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPortsName.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(157, 34);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(87, 26);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Disconnect);
            this.groupBox1.Controls.Add(this.comboBoxBaudrate);
            this.groupBox1.Controls.Add(this.comboBoxPortsName);
            this.groupBox1.Controls.Add(this.Connect);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(49, 49);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(308, 226);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(157, 158);
            this.Disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(121, 26);
            this.Disconnect.TabIndex = 6;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // comboBoxBaudrate
            // 
            this.comboBoxBaudrate.FormattingEnabled = true;
            this.comboBoxBaudrate.Location = new System.Drawing.Point(11, 82);
            this.comboBoxBaudrate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxBaudrate.Name = "comboBoxBaudrate";
            this.comboBoxBaudrate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaudrate.TabIndex = 5;
            // 
            // listBoxStatus
            // 
            this.listBoxStatus.FormattingEnabled = true;
            this.listBoxStatus.ItemHeight = 16;
            this.listBoxStatus.Location = new System.Drawing.Point(60, 331);
            this.listBoxStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxStatus.Name = "listBoxStatus";
            this.listBoxStatus.Size = new System.Drawing.Size(161, 20);
            this.listBoxStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Send";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Location = new System.Drawing.Point(553, 62);
            this.textBoxWrite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(189, 22);
            this.textBoxWrite.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 361);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timerPort
            // 
            this.timerPort.Enabled = true;
            this.timerPort.Interval = 1000;
            this.timerPort.Tick += new System.EventHandler(this.timerPort_Tick);
            // 
            // PortConsole
            // 
            this.PortConsole.Location = new System.Drawing.Point(487, 207);
            this.PortConsole.Multiline = true;
            this.PortConsole.Name = "PortConsole";
            this.PortConsole.Size = new System.Drawing.Size(234, 107);
            this.PortConsole.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PortConsole);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxStatus);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ComboBox comboBoxPortsName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBaudrate;
        private System.Windows.Forms.ListBox listBoxStatus;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timerPort;
        private System.Windows.Forms.TextBox PortConsole;
    }
}

