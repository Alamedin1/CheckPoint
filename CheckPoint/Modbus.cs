using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using Microsoft.Win32;
using static EasyModbus.ModbusServer;

namespace CheckPoint
{
    internal class ModBusServer
    {
        public static int Barcode;
        static readonly ModbusServer modbusServer = new ModbusServer();
        public static void MdbServerStart() {
            modbusServer.HoldingRegistersChanged += new HoldingRegistersChangedHandler(HoldingRegistersChanged);
            modbusServer.Listen();
        }

        public static int NumberClients() {

            return modbusServer.NumberOfConnections;
        }

        public static HoldingRegisters HoldingRegisters()
        {
            return modbusServer.holdingRegisters;
        }
        public static void HoldingRegistersChanged(int startingAddress, int quantity)
        {
            HoldingRegisters registers = HoldingRegisters();
            Barcode = registers[11] << 16 + registers[12];
            
            /*Console.WriteLine(startingAddress);
            Console.WriteLine(quantity);*/
        }

        public static void MdbServerStop() {
            modbusServer.StopListening();
        }

        
        

    }
}
