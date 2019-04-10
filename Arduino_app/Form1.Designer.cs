namespace Arduino_app
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_open_com = new System.Windows.Forms.Button();
            this.cmbx_speed_com = new System.Windows.Forms.ComboBox();
            this.cmbx_select_com = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disp = new System.Windows.Forms.Button();
            this.btn_upd_com = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Location = new System.Drawing.Point(0, 307);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(684, 139);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 307);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_upd_com);
            this.groupBox2.Controls.Add(this.btn_open_com);
            this.groupBox2.Controls.Add(this.cmbx_speed_com);
            this.groupBox2.Controls.Add(this.cmbx_select_com);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_disp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 44);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_open_com
            // 
            this.btn_open_com.Location = new System.Drawing.Point(415, 13);
            this.btn_open_com.Name = "btn_open_com";
            this.btn_open_com.Size = new System.Drawing.Size(103, 25);
            this.btn_open_com.TabIndex = 7;
            this.btn_open_com.Text = "Подключиться";
            this.btn_open_com.UseVisualStyleBackColor = true;
            this.btn_open_com.Click += new System.EventHandler(this.btn_open_com_Click_1);
            // 
            // cmbx_speed_com
            // 
            this.cmbx_speed_com.FormattingEnabled = true;
            this.cmbx_speed_com.Items.AddRange(new object[] {
            "300",
            "1200",
            "9600",
            "250000"});
            this.cmbx_speed_com.Location = new System.Drawing.Point(310, 16);
            this.cmbx_speed_com.Name = "cmbx_speed_com";
            this.cmbx_speed_com.Size = new System.Drawing.Size(85, 21);
            this.cmbx_speed_com.TabIndex = 12;
            // 
            // cmbx_select_com
            // 
            this.cmbx_select_com.FormattingEnabled = true;
            this.cmbx_select_com.Location = new System.Drawing.Point(154, 16);
            this.cmbx_select_com.Name = "cmbx_select_com";
            this.cmbx_select_com.Size = new System.Drawing.Size(70, 21);
            this.cmbx_select_com.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(246, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Скорость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(113, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порт:";
            // 
            // btn_disp
            // 
            this.btn_disp.Location = new System.Drawing.Point(524, 13);
            this.btn_disp.Name = "btn_disp";
            this.btn_disp.Size = new System.Drawing.Size(127, 25);
            this.btn_disp.TabIndex = 8;
            this.btn_disp.Text = "Диспетчер устройств";
            this.btn_disp.UseVisualStyleBackColor = true;
            this.btn_disp.Click += new System.EventHandler(this.btn_disp_Click_1);
            // 
            // btn_upd_com
            // 
            this.btn_upd_com.Location = new System.Drawing.Point(12, 13);
            this.btn_upd_com.Name = "btn_upd_com";
            this.btn_upd_com.Size = new System.Drawing.Size(75, 25);
            this.btn_upd_com.TabIndex = 13;
            this.btn_upd_com.Text = "Обновить";
            this.btn_upd_com.UseVisualStyleBackColor = true;
            this.btn_upd_com.Click += new System.EventHandler(this.btn_upd_com_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(684, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbx_speed_com;
        private System.Windows.Forms.ComboBox cmbx_select_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_disp;
        private System.Windows.Forms.Button btn_open_com;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_upd_com;
    }
}

