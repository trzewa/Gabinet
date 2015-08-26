using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using mysettings = Gabinet.Properties.Settings;

namespace Gabinet
{
    class Database
    {
        public string Conect()
        {
            String password = Cryption.DecryptRijndael(mysettings.Default.password);
            string dbconnection_gabinet = "datasource=" + mysettings.Default.datasource + ";database=" + mysettings.Default.database + ";port=" + mysettings.Default.port + ";username=" + mysettings.Default.user + ";password=" + password + ";charset=utf8";
            return dbconnection_gabinet;
        }       

        public MySqlDataAdapter Select(string query, string db_connection)
        {
                MySqlConnection myConn = new MySqlConnection(db_connection);
                MySqlDataAdapter myDataAdapter = new MySqlDataAdapter();
                myDataAdapter.SelectCommand = new MySqlCommand(query, myConn);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(myDataAdapter);
                myConn.Open();
                return myDataAdapter;
                
        }

        public OleDbDataAdapter SelectDbf(string query, string db_connection)
        {
            OleDbConnection myConn = new OleDbConnection(db_connection);
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter();
            myDataAdapter.SelectCommand = new OleDbCommand(query, myConn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(myDataAdapter);
            myConn.Open();
            return myDataAdapter;
        }

      public void Delete(string query, string db_connection)
        {
            MySqlConnection MyConn = new MySqlConnection(db_connection);
            MySqlCommand MyCommand = new MySqlCommand(query, MyConn);
            MySqlDataReader MyReader;
            MyConn.Open();
            MyReader = MyCommand.ExecuteReader();            
            while (MyReader.Read())
            {

            }
            MyConn.Close();

        }
     
      public void Update(string query, string db_connection)
      {
          try
          {
             
              MySqlConnection myConn = new MySqlConnection(db_connection);
              MySqlCommand MyCommand = new MySqlCommand(query, myConn);
              MySqlDataReader MyReader;
              myConn.Open();
              MyReader = MyCommand.ExecuteReader();              
              while (MyReader.Read())
              {

              }
              myConn.Close();


          }

          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }
      }

      

        public void Insert(string query, string db_connection)
        {
            MySqlConnection conDataBase = new MySqlConnection(db_connection);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                
                while (myReader.Read())
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }       
    }
}
