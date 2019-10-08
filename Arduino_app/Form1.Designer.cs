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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_upd_com = new System.Windows.Forms.Button();
            this.btn_open_com = new System.Windows.Forms.Button();
            this.cmbx_speed_com = new System.Windows.Forms.ComboBox();
            this.cmbx_select_com = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_disp = new System.Windows.Forms.Button();
            this.btn_led_off = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_led_on = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.ReadBufferSize = 2048;
            this.serialPort1.ReadTimeout = 1000;
            this.serialPort1.WriteTimeout = 1000;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btn_upd_com);
            this.groupBox2.Controls.Add(this.btn_open_com);
            this.groupBox2.Controls.Add(this.cmbx_speed_com);
            this.groupBox2.Controls.Add(this.cmbx_select_com);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_disp);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.MaximumSize = new System.Drawing.Size(343, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 174);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_upd_com
            // 
            this.btn_upd_com.Location = new System.Drawing.Point(167, 68);
            this.btn_upd_com.Name = "btn_upd_com";
            this.btn_upd_com.Size = new System.Drawing.Size(146, 25);
            this.btn_upd_com.TabIndex = 13;
            this.btn_upd_com.Text = "Обновить список портов";
            this.btn_upd_com.UseVisualStyleBackColor = true;
            this.btn_upd_com.Click += new System.EventHandler(this.btn_upd_com_Click);
            // 
            // btn_open_com
            // 
            this.btn_open_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open_com.Location = new System.Drawing.Point(87, 108);
            this.btn_open_com.Name = "btn_open_com";
            this.btn_open_com.Size = new System.Drawing.Size(146, 25);
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
            this.cmbx_speed_com.Location = new System.Drawing.Point(12, 71);
            this.cmbx_speed_com.Name = "cmbx_speed_com";
            this.cmbx_speed_com.Size = new System.Drawing.Size(85, 21);
            this.cmbx_speed_com.TabIndex = 12;
            // 
            // cmbx_select_com
            // 
            this.cmbx_select_com.FormattingEnabled = true;
            this.cmbx_select_com.Location = new System.Drawing.Point(12, 44);
            this.cmbx_select_com.Name = "cmbx_select_com";
            this.cmbx_select_com.Size = new System.Drawing.Size(85, 21);
            this.cmbx_select_com.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(103, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Скорость:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(103, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порт:";
            // 
            // btn_disp
            // 
            this.btn_disp.Location = new System.Drawing.Point(167, 41);
            this.btn_disp.Name = "btn_disp";
            this.btn_disp.Size = new System.Drawing.Size(146, 25);
            this.btn_disp.TabIndex = 8;
            this.btn_disp.Text = "Диспетчер устройств";
            this.btn_disp.UseVisualStyleBackColor = true;
            this.btn_disp.Click += new System.EventHandler(this.btn_disp_Click_1);
            // 
            // btn_led_off
            // 
            this.btn_led_off.Location = new System.Drawing.Point(139, 12);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(127, 31);
            this.btn_led_off.TabIndex = 0;
            this.btn_led_off.Text = "Выключить свет";
            this.btn_led_off.UseVisualStyleBackColor = true;
            this.btn_led_off.Click += new System.EventHandler(this.btn_led_off_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_led_on);
            this.groupBox1.Controls.Add(this.btn_led_off);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(415, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(343, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 174);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(758, 266);
            this.textBox1.TabIndex = 10;
            // 
            // button_led_on
            // 
            this.button_led_on.Location = new System.Drawing.Point(6, 12);
            this.button_led_on.Name = "button_led_on";
            this.button_led_on.Size = new System.Drawing.Size(127, 31);
            this.button_led_on.TabIndex = 1;
            this.button_led_on.Text = "Включить свет";
            this.button_led_on.UseVisualStyleBackColor = true;
            this.button_led_on.Click += new System.EventHandler(this.button_led_on_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(758, 446);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbx_speed_com;
        private System.Windows.Forms.ComboBox cmbx_select_com;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_disp;
        private System.Windows.Forms.Button btn_open_com;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn_upd_com;
        private System.Windows.Forms.Button btn_led_off;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_led_on;
    }
}

