using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CheckPoint
{
    public static class HTTPClient
    {
       
        public static string HttpClient()
        {
            WebRequest request = WebRequest.Create("http://localhost:8085/barcode/");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string serverResponse = "";
                    while ((serverResponse = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(serverResponse);
                        return serverResponse;
                    }
                }
            }
            response.Close();
            Console.WriteLine("Запрос выполнен");
            return null;

        }
    }


           
 
      


    
    public class HTTPServer
    {
        public static bool flagHttp = false;
        private static Thread bgThread;
        public static void StartListen()
        {
            bgThread = new Thread(new ThreadStart(HttpServerStart));
            bgThread.IsBackground = true;
            bgThread.Name = "HTTPServer";
            bgThread.Start();
        }
        private static HttpListener listener = new HttpListener();
        public static void HttpServerStart()
        {
            string url = "http://127.0.0.1";
            string port = "8085";
            string prefix = String.Format("{0}:{1}/barcode/", url, port);
            listener.Prefixes.Add(prefix);
            listener.Start();
            flagHttp = true;
            Console.WriteLine("Welcome to simple HttpListener.\n", port);
            Console.WriteLine("Listening on {0}...", prefix);

            while (flagHttp)
            {
                //Ожидание входящего запроса
                HttpListenerContext context = listener.GetContext();
                //Объект запроса
                HttpListenerRequest request = context.Request;
                //Объект ответа
                HttpListenerResponse response = context.Response;

                //Создаем ответ
                Console.WriteLine("{0} request was caught: {1}",
                                   request.HttpMethod, request.Url);

                var stringURL = request.Url.ToString();
               var barcode =  stringURL.Remove(0, 31);
                Console.WriteLine(barcode);
                var barcodeInt = int.Parse(barcode);
                var isExist = DataBase.CheckBarcode(barcodeInt);
                Console.WriteLine("{0}; {1}", isExist, barcodeInt);
                response.StatusCode = (int)HttpStatusCode.OK;
                
                //Возвращаем ответ
                using (Stream stream = response.OutputStream) { }

            }


        }
        public static void HttpServerStop()
        {
            // останавливаем прослушивание подключений
            flagHttp = false;
            listener.Stop();
            bgThread.Abort();
            Console.WriteLine("Обработка подключений завершена");
        }
    }
}
