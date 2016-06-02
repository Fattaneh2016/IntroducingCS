using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ParameterizedSP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        //{
        //    Application.EnableVisualStyles();
        //    Application.SetCompatibleTextRenderingDefault(false);
        //    Application.Run(new Form1());

        //    string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); CopyDataToTextFile(myDocumentsPath + @"\CustomerList.txt"); DisplayTextFile(myDocumentsPath + @"\CustomerList.txt");
        //}
        //    static private void CopyDataToTextFile(string fileName)
        //{
        //    try
        //    {      // Change the connection string     
        //           // to match with your system.     
        //        string connectionString =     @"Data Source=.\SQLEXPRESS;" +     @"AttachDbFilename=" +     @"c:\SqlSampleDB\NORTHWND.MDF;" +     @"Integrated Security=True;" +     @"Connect Timeout=30;User Instance=True";      SqlConnection connection =       new SqlConnection(connectionString);      SqlCommand command =       connection.CreateCommand();

        //        command.CommandText = "SELECT CustomerId, CompanyName," + "ContactName, Phone FROM Customers"; using (connection) { connection.Open(); SqlDataReader reader = command.ExecuteReader(); using (StreamWriter sw = new StreamWriter(fileName)) { while (reader.Read()) { string customerRow = String.Format("{0}, {1}, {2}, {3}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3)); sw.WriteLine(customerRow); } } }
        //    }
        //    catch (Exception ex) { Console.WriteLine(ex.Message); }
        //}
        //static void DisplayTextFile(string fileName)
        //{
        //    try { using (StreamReader sr = new StreamReader(fileName)) { string line; while ((line = sr.ReadLine()) != null) { Console.WriteLine(line); } } }


        //    catch (Exception ex)
        //    { Console.WriteLine(ex.Message); }

            //xml file

            using (XmlReader reader = XmlReader.Create("Customers.xml"))
            {
                while (reader.Read())
                {

        if (reader.IsStartElement())    {      switch (reader.Name)      {        case "CompanyName":          if (reader.Read())          {            Console.Write(            "Company Name: {0}, ",             reader.Value);          }          break;        case "Phone":          if (reader.Read())          {            Console.WriteLine(             "Phone: {0}", reader.Value);          }          break;      }    }  } } 
                }

            }
    }

