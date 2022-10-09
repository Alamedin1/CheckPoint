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
       public static string serverResponse = "";
        public static void HttpClient()
        {/*
           HttpClient client = new HttpClient();
            string url = "http://localhost:8085/barcode/";
            var result = await client.GetAsync(url);
            string response = result.ToString();
            Console.WriteLine("{0}, {1}", result, response);*/


            WebRequest request = WebRequest.Create("http://localhost:8085/barcode/");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    
                    while ((serverResponse = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(serverResponse);
                        
                    }
                }
            }
            response.Close();
            Console.WriteLine("Запрос выполнен");

        }
    }

}
           
 
      


/*
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
        }*/



    /*string varible_url = "@123";
    // установка адресов прослушки
    listener.Prefixes.Add("http://127.0.0.1:8085/barcode/"); // как указывать переменную @123 в URL
    listener.Start();
    Console.WriteLine("Ожидание подключения...");
    return true;
}

public static bool HttpRequestResponse() 
{
   if (HttpServerStart()) 
    {
        // метод GetContext блокирует текущий поток, ожидая получение запроса 
        HttpListenerContext context = listener.GetContext();
        HttpListenerRequest request = context.Request;
        context.Response.StatusCode = 200;
        // получаем объект ответа
        HttpListenerResponse response = context.Response;
        // создаем ответ
        string responseStr = "true";
        byte[] buffer = Encoding.UTF8.GetBytes(responseStr);
        // получаем поток ответа и пишем в него ответ
        response.ContentLength64 = buffer.Length;
        Stream output = response.OutputStream;
        output.Write(buffer, 0, buffer.Length);
        // закрываем поток
        output.Close();
        return true;
    }
    return false;


}*/

    /*
        КАК ОТПРАВИТЬ ПОСЛЕ ПРОВЕРКИ ЗАПИСИ БАРКОДА ОТВЕТ HTTP КЛИЕНТУ TRUE!!?
        СКОРРЕКТИРОВАТЬ SQL ПРОВЕРКА НАЛИЧИЯ БАРКОДА!
        КАК ХРАНИТЬ ДАННЫЕ О БАРКОДЕ ПРИ ПОЛУЧЕНИИ HTTP КЛИЕНТОМ?
        ПОСЛЕ ПОДКЛЮЧЕНИЯ СОЗДАТЬ ИНДИКАТОР МИГАЮЩИЙ НА ПОДКЛ HTTP SERVER
        ЗАПИСАТЬ ЗНАЧЕНИЕ ОТВЕТА HTTP СЕРВЕРА В ВЕБ МОРДУ В ТЕКСТ
        СОЗДАТЬ ЕЩЕ ОДНУ БД И СОХРАНЯТЬ БАРКОД ВРЕМЯ ПРОХОЖДЕНИЕ И ОТВЕТ ОТ СЕРВЕРА
        НАПИСАТЬ ОБРАБОТЧИКИ ОШИБОК ВСЕХ ИСКЛЮЧЕНИЙ
        СОЗДАТЬ ЛОГ ФАЙЛ ОШИБОК
     */

    // метод GetContext блокирует текущий поток, ожидая получение запроса 
    //HttpListenerContext context = listener.GetContext();
    //HttpListenerRequest request = context.Request;
    // получаем объект ответа



/*internal class HTTP
{
    static readonly int port = 8085;
    public static void HttpServer()
    {

        // получаем адреса для запуска сокета
        IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

        // создаем сокет
        Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        try
        {
            // связываем сокет с локальной точкой, по которой будем принимать данные
            listenSocket.Bind(ipPoint);

            // начинаем прослушивание
            listenSocket.Listen(2);

            Console.WriteLine("Сервер запущен. Ожидание подключений...");

            while (true)
            {
                Socket handler = listenSocket.Accept(); // извлекает из очереди ожидающих запрос первый запрос и создает для его обработки объект Socket 
                                                        // получаем сообщение
                StringBuilder builder = new StringBuilder();
                int bytes = 0; // количество полученных байтов
                byte[] data = new byte[256]; // буфер для получаемых данных

                do
                {
                    bytes = handler.Receive(data); // получаем данные в виде массива байтов и возвращает количество байтов
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (handler.Available > 0); // отслеживание наличия данных

                Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                // отправляем ответ
                string message = "ваше сообщение доставлено";
                data = Encoding.Unicode.GetBytes(message);
                handler.Send(data); // отправка сообщения клиенту о том что данные пришли
                                    // закрываем сокет
                handler.Shutdown(SocketShutdown.Both); // гарантирует что никаких необработанных данных нет данных
                handler.Close(); // закытие сокета
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); // нужно http библиотеку с функциями подключения и запросов как обрабатывать http запросы
        }
    }
}*/
