using EasyModbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static EasyModbus.ModbusServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace CheckPoint
{
    public partial class Form1 : Form
    {
        static readonly Timer timer_scaner = new Timer();
        static readonly Timer timer = new Timer();
        static readonly Timer timer_listener_MDB = new Timer();
        static readonly Timer timer_server = new Timer();
        static readonly int alarmCounter = 500;
        public Form1()
        {
            InitializeComponent();
            timer.Interval = alarmCounter;
            timer.Tick += new EventHandler(ChangeColor);
            timer_scaner.Interval = alarmCounter;
            timer_scaner.Tick += new EventHandler(Scaner_Indicator_Paint);
            timer_listener_MDB.Interval = alarmCounter;
            timer_listener_MDB.Tick += new EventHandler(WriteBarcode);
            timer_server.Interval = alarmCounter;
            timer_server.Tick += new EventHandler(ServerIndic);
            //timer.server.Tick += new
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start_Button.BackColor = Color.Green;
            Stop_Button.BackColor = Color.Tomato;
            timer.Start();
           // DataBase.DataBaseCreate();
            ModBusServer.MdbServerStart();
            timer_listener_MDB.Start();
            HTTPServer.HttpServerStart();
            timer_scaner.Start();
            timer_server.Start();
           
        }
        private void Scaner_Indicator_Paint(object sender, EventArgs e)
        {
            if (ModBusServer.NumberClients() > 0 && ModBusServer.NumberClients() > 0 && Stop_Button.BackColor == Color.Tomato)
            {
                Scaner_Indicator.BackColor = Color.YellowGreen;
            }
            else if (Stop_Button.BackColor == Color.Red)
            {
                Scaner_Indicator.BackColor = Color.Gray;
            }
        }
        private void ServerIndic(object sender, EventArgs e)
        {
            if (HTTPServer.HttpServerStart() && Stop_Button.BackColor == Color.Tomato)
            {
                HTTPServer.HttpRequestResponse();
                Server_Indicator.BackColor = Color.YellowGreen;
            }
            else if (Stop_Button.BackColor == Color.Red)
            {
                Server_Indicator.BackColor = Color.Gray;
            }            
        }
            

        private void WriteBarcode(object sender, EventArgs e) 
        {
            if (ModBusServer.Barcode > 0)
            {
                DataBase.AddBarcodeToDB(ModBusServer.Barcode);
                BarcodeInfo_Text.Text = ModBusServer.Barcode.ToString();
                ModBusServer.Barcode = 0;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer_scaner.Stop();
            timer.Stop();
            timer_listener_MDB.Stop();
            timer_server.Stop();
            Stop_Button.BackColor = Color.Red;
            Start_Button.BackColor = Color.SpringGreen;
            Scaner_Indicator.BackColor = Color.Gray;
            Start_Indicator.InnerColor = Color.Gray;
            Server_Indicator.BackColor = Color.Gray;
            BarcodeInfo_Text.Text = "";
            HTTPServer.HttpServerStop();
            ModBusServer.MdbServerStop();
            
        }
        private void ChangeColor(object sender, EventArgs e)
        {
            if (Start_Button.BackColor == Color.Green && Start_Indicator.InnerColor != Color.Green)
            {
                Start_Indicator.InnerColor = Color.Green;
            }
            else
            {
                Start_Indicator.InnerColor = Color.Gray;
            }
        }

        private void BarcodeInfo_Text_TextChang(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ServerInfo_Text_TextChanged(object sender, EventArgs e)
        {

        }
        private void Start_Indicator_Click(object sender, EventArgs e)
        {

        }
        private void BarcodeInfo_Click(object sender, EventArgs e)
        {

        }
        private void TextIndicStart_Click(object sender, EventArgs e)
        {

        }


        private void Scaner_Indicator_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
