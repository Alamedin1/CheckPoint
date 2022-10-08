using EasyModbus;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static EasyModbus.ModbusServer;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CheckPoint
{

    /*  public class DataCheckPoint 
      {
          public int Id { get; set; }
          public string InfoBarcode { get; set; }
          public DateTime DateTime;
          public bool ServerResponse { get; set; }
      }*/
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
               
               

               /* Console.WriteLine($"В таблицу Barcode добавлено объектов: {1}");

                using (SqliteDataReader reader = sqliteCommand.ExecuteReader())
                {
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            var Id = reader.GetValue(0);
                            var Barcode = reader.GetValue(1);
                            *//*var Date = reader.GetValue(2);
                            var Server = reader.GetValue(3);*//*

                            Console.WriteLine($"{Id} \t {Barcode}");
                        }
                    }
                }*/
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
                //sqliteCommand.CommandText = "INSERT INTO Table_Barcode (Barcode) VALUES (@barcode)";

                SqliteParameter nameParam = new SqliteParameter("@barcode", barcode);
                sqliteCommand.Parameters.Add(nameParam);
                sqliteCommand.ExecuteNonQuery();
                Console.WriteLine("Barcode added in database!, barcode:{0} ", barcode);

                connection.Close();
              
            }
            
        }
        public static bool ChangedDB()
        {
            using (var connection = new SqliteConnection("Data Source=checkpoint.db"))
            {
                connection.Open();
                SqliteCommand sqliteCommand = new SqliteCommand();
                sqliteCommand.Connection = connection;

                sqliteCommand.CommandText = "SELECT * FROM Table_Barcode"; //WHERE(Barcode) =
                using (SqliteDataReader reader = sqliteCommand.ExecuteReader())
                {
                   
                    if (reader.HasRows) // если есть данные
                    {
                        while (reader.Read())   // построчно считываем данные
                        {
                            int Id = reader.GetInt32(0);
                            int Barcode = reader.GetInt32(1);
                            Console.WriteLine($"{Id} \t {Barcode}");
                        }
                        return true;
                    }
                    
                }
                connection.Close();
                return false;
            }
        }


    }
}
