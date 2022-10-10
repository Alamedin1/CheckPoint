using EasyModbus;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static EasyModbus.ModbusServer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CheckPoint
{


    public class DataBase
    {
        public static void DataBaseCreate()
        {
            //string sqlExpression = "SELECT * FROM Barcode";
            using (var connection = new SqliteConnection("Data Source=checkpoint.db"))
            {

                connection.Open();
                Console.WriteLine();

                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = connection;
                sqliteCommand.CommandText = "CREATE TABLE Table_Barcode(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Barcode INTEGER NOT NULL)";
                sqliteCommand.ExecuteNonQuery();

                Console.WriteLine("DataBase created!");

                connection.Close();
            }

        }

        public static void AddBarcodeToDB(int barcode)
        {
            string sqlExpression = "INSERT INTO Table_Barcode (Barcode) VALUES (@barcode)";
            using (var connection = new SqliteConnection("Data Source=checkpoint.db"))
            {
                connection.Open();

                SqliteCommand sqliteCommand = new SqliteCommand(sqlExpression);
                sqliteCommand.Connection = connection;


                SqliteParameter nameParam = new SqliteParameter("@barcode", barcode);
                sqliteCommand.Parameters.Add(nameParam);
                sqliteCommand.ExecuteNonQuery();
                Console.WriteLine("Barcode added in database!, barcode:{0} ", barcode);

                connection.Close();

            }

        }
        public static bool CheckBarcode(int barcode)
        {
            using (var connection = new SqliteConnection("Data Source=checkpoint.db"))
            {
                connection.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = connection;

                sqliteCommand.CommandText = String.Format("SELECT Barcode FROM Table_Barcode WHERE Barcode = '{0}'", barcode); ; //
                using (SqliteDataReader reader = sqliteCommand.ExecuteReader())
                {

                    if (reader.HasRows) // если есть данные
                    {
                        return true;
                    }

                }
                connection.Close();
                return false;
            }
        }


    }





    public class DataCheckPoint
    {

        public static void DataBaseCreate()
        {
            using (var connection = new SqliteConnection("Data Source=DataCheck_Point.db"))
            {

                connection.Open();
                Console.WriteLine();

                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = connection;
                sqliteCommand.CommandText = "CREATE TABLE DataCheck_Point(Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, Barcode INTEGER NOT NULL, ServerResponse TEXT)";
                sqliteCommand.ExecuteNonQuery();

                Console.WriteLine("DataBase DataCheck_Point created!");

                connection.Close();
            }
        }
        //string serverResponse
        public static void AddDataCheckPoint(int barcode, string serverResponse)
        {
            string sqlExpression = "INSERT INTO DataCheck_Point (Barcode, ServerResponse) VALUES (@barcode, @serverResponse)";
            using (var connection = new SqliteConnection("Data Source=DataCheck_Point.db"))
            {
                connection.Open();

                SqliteCommand sqliteCommand = new SqliteCommand(sqlExpression);
                sqliteCommand.Connection = connection;


                SqliteParameter barc = new SqliteParameter("@barcode", barcode);
                sqliteCommand.Parameters.Add(barc);
                SqliteParameter serverresponse = new SqliteParameter("@serverResponse", serverResponse);
                sqliteCommand.Parameters.Add(serverresponse);
                sqliteCommand.ExecuteNonQuery();
                Console.WriteLine("Barcode added in database!, barcode:{0}, serverresponse:{1} ", barcode, serverresponse);

                connection.Close();

            }

        }
        public static bool CheckDataCheckPoint(int barcode, string serverResponse)
        {
            using (var connection = new SqliteConnection("Data Source=DataCheck_Point.db"))
            {
                connection.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = connection;

                sqliteCommand.CommandText = String.Format("SELECT Barcode FROM DataCheck_Point WHERE Barcode = '{0}', ServerResponse = '{1}'", barcode, serverResponse); ; //
                using (SqliteDataReader reader = sqliteCommand.ExecuteReader())
                {

                    if (reader.HasRows) // если есть данные
                    {
                        return true;
                    }

                }
                connection.Close();
                return false;
            }
        }

        /* public class ApplicationContext : DbContext
         {
             public DbSet<DataCheckPoint> DataCheckPoint => Set<DataCheckPoint>();
             public ApplicationContext() => Database.EnsureCreated();


             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
             {
                 optionsBuilder.UseSqlite("Data Source=DataCheckPoint.db");
             }

             public static void AddDataCheckPoint(int Barcode, string ServerResponse)
             {
                 using (ApplicationContext db = new ApplicationContext())
                 {
                     // создаем объекты
                     DataCheckPoint infobarcode = new DataCheckPoint { InfoBarcode = Barcode.ToString() };
                     DataCheckPoint datetime = new DataCheckPoint { DateTime = DateTime.Now };
                     DataCheckPoint serverresponse = new DataCheckPoint { ServerResponse = ServerResponse };

                     // добавляем их в бд
                     db.DataCheckPoint.Add(infobarcode);
                     db.DataCheckPoint.Add(datetime);
                     db.DataCheckPoint.Add(serverresponse);
                     db.SaveChanges();
                     Console.WriteLine("Объекты успешно сохранены");

                     // получаем объекты из бд и выводим на консоль
                     var datacheckpoint = db.DataCheckPoint.ToList();
                     Console.WriteLine("Список объектов:");
                     foreach (DataCheckPoint u in datacheckpoint)
                     {
                         Console.WriteLine($"{u.Id}.{u.InfoBarcode} - {u.DateTime} - {u.ServerResponse}");
                     }
                 }
             }
              }*/



    }
}
