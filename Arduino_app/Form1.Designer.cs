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
            this.btn_off_fan = new System.Windows.Forms.Button();
            this.btn_on_fan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_led_time_s = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_led_time_po = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_poliv_time = new System.Windows.Forms.TextBox();
            this.btn_set_time_poliv = new System.Windows.Forms.Button();
            this.button_led_on = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.MaximumSize = new System.Drawing.Size(343, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 144);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // btn_upd_com
            // 
            this.btn_upd_com.Location = new System.Drawing.Point(167, 38);
            this.btn_upd_com.Name = "btn_upd_com";
            this.btn_upd_com.Size = new System.Drawing.Size(146, 25);
            this.btn_upd_com.TabIndex = 13;
            this.btn_upd_com.Text = "Обновить список портов";
            this.btn_upd_com.UseVisualStyleBackColor = true;
            this.btn_upd_com.Click += new System.EventHandler(this.btn_upd_com_Click);
            // 
            // btn_open_com
            // 
            this.btn_open_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open_com.Location = new System.Drawing.Point(12, 68);
            this.btn_open_com.Name = "btn_open_com";
            this.btn_open_com.Size = new System.Drawing.Size(301, 41);
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
            this.cmbx_speed_com.Location = new System.Drawing.Point(12, 41);
            this.cmbx_speed_com.Name = "cmbx_speed_com";
            this.cmbx_speed_com.Size = new System.Drawing.Size(85, 21);
            this.cmbx_speed_com.TabIndex = 12;
            // 
            // cmbx_select_com
            // 
            this.cmbx_select_com.FormattingEnabled = true;
            this.cmbx_select_com.Location = new System.Drawing.Point(12, 14);
            this.cmbx_select_com.Name = "cmbx_select_com";
            this.cmbx_select_com.Size = new System.Drawing.Size(85, 21);
            this.cmbx_select_com.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(99, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Скорость";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(99, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Порт";
            // 
            // btn_disp
            // 
            this.btn_disp.Location = new System.Drawing.Point(167, 11);
            this.btn_disp.Name = "btn_disp";
            this.btn_disp.Size = new System.Drawing.Size(146, 25);
            this.btn_disp.TabIndex = 8;
            this.btn_disp.Text = "Диспетчер устройств";
            this.btn_disp.UseVisualStyleBackColor = true;
            this.btn_disp.Click += new System.EventHandler(this.btn_disp_Click_1);
            // 
            // btn_led_off
            // 
            this.btn_led_off.Location = new System.Drawing.Point(6, 35);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(138, 21);
            this.btn_led_off.TabIndex = 0;
            this.btn_led_off.Text = "Выключить свет";
            this.btn_led_off.UseVisualStyleBackColor = true;
            this.btn_led_off.Click += new System.EventHandler(this.btn_led_off_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_off_fan);
            this.groupBox1.Controls.Add(this.btn_on_fan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtb_led_time_s);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_led_time_po);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtb_poliv_time);
            this.groupBox1.Controls.Add(this.btn_set_time_poliv);
            this.groupBox1.Controls.Add(this.button_led_on);
            this.groupBox1.Controls.Add(this.btn_led_off);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 153);
            this.groupBox1.MaximumSize = new System.Drawing.Size(343, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 298);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_off_fan
            // 
            this.btn_off_fan.Location = new System.Drawing.Point(6, 232);
            this.btn_off_fan.Name = "btn_off_fan";
            this.btn_off_fan.Size = new System.Drawing.Size(138, 21);
            this.btn_off_fan.TabIndex = 11;
            this.btn_off_fan.Text = "Выключить вентиляцию";
            this.btn_off_fan.UseVisualStyleBackColor = true;
            // 
            // btn_on_fan
            // 
            this.btn_on_fan.Location = new System.Drawing.Point(6, 205);
            this.btn_on_fan.Name = "btn_on_fan";
            this.btn_on_fan.Size = new System.Drawing.Size(138, 21);
            this.btn_on_fan.TabIndex = 10;
            this.btn_on_fan.Text = "Включить вентиляцию";
            this.btn_on_fan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Время освещения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "с";
            // 
            // txtb_led_time_s
            // 
            this.txtb_led_time_s.Location = new System.Drawing.Point(185, 35);
            this.txtb_led_time_s.Name = "txtb_led_time_s";
            this.txtb_led_time_s.Size = new System.Drawing.Size(27, 20);
            this.txtb_led_time_s.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "по";
            // 
            // txtb_led_time_po
            // 
            this.txtb_led_time_po.Location = new System.Drawing.Point(242, 35);
            this.txtb_led_time_po.Name = "txtb_led_time_po";
            this.txtb_led_time_po.Size = new System.Drawing.Size(27, 20);
            this.txtb_led_time_po.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Время полива";
            // 
            // txtb_poliv_time
            // 
            this.txtb_poliv_time.Location = new System.Drawing.Point(165, 129);
            this.txtb_poliv_time.Name = "txtb_poliv_time";
            this.txtb_poliv_time.Size = new System.Drawing.Size(27, 20);
            this.txtb_poliv_time.TabIndex = 3;
            // 
            // btn_set_time_poliv
            // 
            this.btn_set_time_poliv.Location = new System.Drawing.Point(6, 128);
            this.btn_set_time_poliv.Name = "btn_set_time_poliv";
            this.btn_set_time_poliv.Size = new System.Drawing.Size(138, 21);
            this.btn_set_time_poliv.TabIndex = 2;
            this.btn_set_time_poliv.Text = "Установить";
            this.btn_set_time_poliv.UseVisualStyleBackColor = true;
            // 
            // button_led_on
            // 
            this.button_led_on.Location = new System.Drawing.Point(6, 12);
            this.button_led_on.Name = "button_led_on";
            this.button_led_on.Size = new System.Drawing.Size(138, 21);
            this.button_led_on.TabIndex = 1;
            this.button_led_on.Text = "Включить свет";
            this.button_led_on.UseVisualStyleBackColor = true;
            this.button_led_on.Click += new System.EventHandler(this.button_led_on_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(343, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(538, 454);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 320F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 454);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.richTextBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 460F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(884, 456);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 456);
            this.Controls.Add(this.tableLayoutPanel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arduino Control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button_led_on;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_set_time_poliv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_led_time_s;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_led_time_po;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_poliv_time;
        private System.Windows.Forms.Button btn_on_fan;
        private System.Windows.Forms.Button btn_off_fan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

