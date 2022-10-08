using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint
{

    public class HTTPServer
    {
        private static HttpListener listener = new HttpListener();
        public static void HttpServerStart()
        {
            // установка адресов прослушки
            listener.Prefixes.Add("http://127.0.0.1:8085/barcode/{id}"); // как указывать переменную @123 в URL
            listener.Start();
            Console.WriteLine("Ожмдание подключения...");
        }
        public static void HttpServerStop() 
        {
            // останавливаем прослушивание подключений
            listener.Stop();
            Console.WriteLine("Обработка подключений завершена");
        }
        private void Recieve() // rquest есть состав //response состав
        {
            listener.BeginGetContext(new AsyncCallback(ListenerCallback), listener);
        }
        private void ListenerCallback(IAsyncResult result)
        {
            var context = listener.EndGetContext(result);
            var request = context.Request;
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
            if (DataBase.ChangedDB() == true)
            {
                var response = context.Response;
                response.StatusCode = (int)HttpStatusCode.OK;
                // создаем ответ
                bool[] boolresponse;


                // получаем поток ответа и пишем в него ответ
                response.ContentLength64 = boolresponse;
                Stream output = response.OutputStream;
                output.Write(boolresponse, 0, boolresponse.ToString());

                // закрываем поток
                output.Close();
            }
        }
    }   
}

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
