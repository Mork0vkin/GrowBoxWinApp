using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace Arduino_app
{
    public partial class Form1 : Form
    {
        bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Код, выполняемый при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            GetComPorts();
        }


        // Функция обновления списка COM портов
        private void GetComPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmbx_select_com.Items.Add(port);
            }

            if (ports.Length == 0)
            {
                richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "COM порты не найдены\n";
                cmbx_select_com.Items.Clear(); // очищаем список
                cmbx_select_com.ResetText();
            }
            else
            {
                cmbx_select_com.SelectedIndex = 0; // выбираем первый в списке COM порт
                cmbx_speed_com.SelectedItem = "9600";
                richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Спискок COM портов получен\n";
            }
        }


        // Функция вывода ошибки в текстовую область
        private void Error(Exception er){
            richTextBox1.Text += "=======================ОШИБКА=======================\n";
            richTextBox1.Text += er.ToString() + "\n";
            richTextBox1.Text += "=======================ОШИБКА=======================\n";
        }


        // Функция подключения к порту
        private void OpenComPort() {
            try
            {
                groupBox1.Enabled = true;
                serialPort1.BaudRate = (int.Parse((string)cmbx_speed_com.SelectedItem));
                serialPort1.PortName = ((string)cmbx_select_com.SelectedItem);
                serialPort1.Open();
                btn_open_com.Text = "Отключиться";
                richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Подключение выполнено\n";
                isConnected = true;

                //string data = serialPort1.ReadExisting();
                //richTextBox2.Text += data + "\n";
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        // Функция отключения от порта
        private void CloseComPort()
        {
            try
            {
                isConnected = false;
                serialPort1.Close();
                btn_open_com.Text = "Подключиться";
                groupBox1.Enabled = false;
                richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Подключение закрыто\n";
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        //Кнопка подключения к Ардуине
        private void btn_open_com_Click_1(object sender, EventArgs e)
        {
            if (!isConnected) { OpenComPort(); } else { CloseComPort(); }
        }


        // Кнопка открытия Диспетчера устройств
        private void btn_disp_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("devmgmt.msc");
                richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Был открыт Диспетчер усройств\n";
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        // Кнопка обновления/получения списка COM портов
        private void btn_upd_com_Click(object sender, EventArgs e)
        {
            GetComPorts();
        }

        
        //Кнопка отправки команды в Arduino
        private void btn_send_com_Click(object sender, EventArgs e)
        {
            string c = txbx_send_com.Text;
            serialPort1.Write(c);
            richTextBox1.Text += "STATUS:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Команда отправлена\n";
        }


        
    }
}
