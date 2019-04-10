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
        string s = DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ");

        public Form1()
        {
            InitializeComponent();
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
                richTextBox1.Text += "STATUS:" + s + "COM порты не найдены\n";
                cmbx_select_com.Items.Clear(); // очищаем список
                cmbx_select_com.ResetText();
            }
            else
            {
                cmbx_select_com.SelectedIndex = 0; // выбираем первый в списке COM порт
                cmbx_speed_com.SelectedItem = "9600";
                richTextBox1.Text += "STATUS:" + s + "Спискок COM портов получен\n";
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
                serialPort1.BaudRate = (int.Parse((string)cmbx_speed_com.SelectedItem));
                serialPort1.PortName = ((string)cmbx_select_com.SelectedItem);
                serialPort1.Open();
                btn_open_com.Text = "Отключиться";
                groupBox1.Enabled = true;
                richTextBox1.Text += "STATUS:" + s + "Подключение выполнено\n";
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        //Получаем данные с Ардуино
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           //
        }

        //Кнопка подключения к Ардуине
        private void btn_open_com_Click_1(object sender, EventArgs e)
        {
            if (btn_open_com.Text == "Подключиться")
            {
                OpenComPort();

                    string inf = serialPort1.ReadLine();
                    richTextBox1.Text += inf;
                }
            else
            {
                serialPort1.Close();
                btn_open_com.Text = "Подключиться";
                groupBox1.Enabled = false;
                richTextBox1.Text += "STATUS:" + s + "Подключение закрыто\n";
            }
        }


        // Кнопка открытия Диспетчера устройств
        private void btn_disp_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("devmgmt.msc");
                richTextBox1.Text += "STATUS:" + s + "Был открыт Диспетчер усройств\n";
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

        // Код, выполняемый при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            GetComPorts();
        }
    }
}
