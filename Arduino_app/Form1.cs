using System;
using System.Threading;
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


        // Код, выполняемый при закрытии формы
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isConnected) { CloseComPort(); }
        }


        // Код, выполняемый при загрузке формы
        private void Form1_Load(object sender, EventArgs e)
        {
            GetComPorts();
            serialPort1.ReadTimeout = 1000;
            serialPort1.WriteTimeout = 1000;
            serialPort1.Encoding = System.Text.Encoding.UTF8;
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
                System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "COM порты не найдены");
                cmbx_select_com.Items.Clear(); // очищаем список
                cmbx_select_com.ResetText();
            }
            else
            {
                cmbx_select_com.SelectedIndex = 0; // выбираем первый в списке COM порт
                cmbx_speed_com.SelectedItem = "9600";
                System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Спискок COM портов получен");
            }
        }


        // Функция вывода ошибки в текстовую область
        private void Error(Exception er){
            System.Console.WriteLine(er.ToString() + "");
        }


        // Функция подключения к порту
        private void OpenComPort() {
            try
            {
                if (cmbx_select_com.Text == "" || cmbx_speed_com.Text == "")
                {
                    System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Не выбраны настройки подключения к Arduino");
                }
                else {
                    
                    groupBox1.Enabled = true;
                    serialPort1.BaudRate = (int.Parse((string)cmbx_speed_com.SelectedItem));
                    serialPort1.PortName = ((string)cmbx_select_com.SelectedItem);
                    serialPort1.Open();
                    btn_open_com.Text = "Отключиться";
                    System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Подключение выполнено");
                    isConnected = true;

                }
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
                System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Подключение закрыто");
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        //Кнопка подключения к Ардуине
        private void btn_open_com_Click_1(object sender, EventArgs e)
        {
            if (!isConnected) {
                OpenComPort();
                Thread.Sleep(500);
                System.Console.WriteLine(serialPort1.ReadExisting());
            } else {
                CloseComPort();
            }
        }


        // Кнопка открытия Диспетчера устройств
        private void btn_disp_Click_1(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("devmgmt.msc");
                System.Console.WriteLine("PC:" + DateTime.Now.ToString(" [dd.MM.yy] [HH:mm:ss]  -  ") + "Был открыт Диспетчер усройств");
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
        private void btn_led_off_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("led1 off;");
                Thread.Sleep(500);
                System.Console.WriteLine(serialPort1.ReadLine());
                //очищаем буфер обмена
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
            catch (Exception er)
            {
                Error(er);
            }
        }


        private void button_led_on_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.WriteLine("led1 on;");
                Thread.Sleep(500);
                System.Console.WriteLine(serialPort1.ReadLine());
                //очищаем буфер обмена
                serialPort1.DiscardInBuffer();
                serialPort1.DiscardOutBuffer();
            }
            catch (Exception er)
            {
                Error(er);
            }
        }
    }
}
