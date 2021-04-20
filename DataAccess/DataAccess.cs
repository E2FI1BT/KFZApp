using CommonTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace DataAccess
{
    public class DataAccess
    {
        public void SaveKFZ(KFZ kfz)
        {
            MessageBox.Show($"Data-Access SaveKFZ {kfz.Kennzeichen}");

            //Verbindung zur DB aufbauen.
            MySqlConnection myConnection = new SqlConnection("SERVER=localhost;DATABASE=;UID=root;PASSWORD=;");
            myConnection.Open();

            //Einfüge SQL-Befehl zusammenbauen.
            string myInsertQuery = "INSERT INTO t_chatquote (alias, quote, timestamp) Values('""')";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

            //Dem SQL-Befehl noch sagen, welche Verbindung zum Server verwendet werden soll.
            myCommand.Connection = myConnection;

            //Befehl ausführen.
            myCommand.ExecuteNonQuery();

            //Verbindung zur Datenbank wieder abbauen.
            myConnection.Close();

        }
    }
}
