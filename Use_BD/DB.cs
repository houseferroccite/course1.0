using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_project
{

    static class DB
    {

        //Settings connection
        static string connectionString = course1._0.Properties.Settings.Default.CONN;
        static SqlConnection conn;

        //Create Data
        public static DataSet ds = new DataSet();
        static DB()
        {
            //Install connection
            conn = new SqlConnection(connectionString);
            
            //Load all Tables DB
            AddTableInDS();
        }
        public static DataTable LoadTable(string query, string nameTable)
        {
            
            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (!ds.Tables.Contains(nameTable))
            {
                adapter.Fill(ds, nameTable);
            }
            
            return ds.Tables[nameTable];
        }

        public static DataTable UpdateTable(string query, string tablename)
        {

            SqlCommand command = conn.CreateCommand();
            command.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            if (ds.Tables.Contains(tablename))
            {
                ds.Tables[tablename].Clear();
            }
            adapter.Fill(ds, tablename);

            return ds.Tables[tablename];
        }

        public static void UpdateTable(SqlCommand command, string tablename)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            if (ds.Tables.Contains(tablename))
            {
                ds.Tables[tablename].Clear();
            }
            adapter.Fill(ds, tablename);

        }
        //Load list tables in DataSet
        public static void AddTableInDS()
        {
            SqlCommand commnad = conn.CreateCommand();
            commnad.CommandType = CommandType.StoredProcedure;
            commnad.CommandText = "LoadAllTables";
           
            //Load list tables our BD
            UpdateTable(commnad, "tables");

            string tableName = "";
            for (int i = 0, n = ds.Tables["tables"].Rows.Count; i < n; i++)
            {
                tableName = ds.Tables["tables"].Rows[i]["TABLE_NAME"].ToString();
                SqlDataAdapter adapter = new SqlDataAdapter($"select * from [{tableName}]", conn);

                if (!ds.Tables.Contains(tableName) && tableName != "sysdiagrams")
                {
                    adapter.Fill(ds, tableName);
                }
            }
            
        }

        //INSERT COMMAND
        public static int changeData(string nameProc, string tableName, List<Parametrs_command> listParams, Parametrs_command outParam)
        {
            //Create command
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nameProc;

            //Add input parametrs (together VALUE)
            //collection parametrs command 
            foreach (Parametrs_command p in listParams)
            {
                command.Parameters.AddWithValue(p.paramName, p.paramValue);
            }

            //Add in command output parametrs - ID insert types
            command.Parameters.Add(outParam.paramName, outParam.paramType);
            command.Parameters[outParam.paramName].Direction = ParameterDirection.Output;

            //Upadte Data in table 

            UpdateTable(command, tableName);
            return (int)command.Parameters["@ID"].Value;
        }
        public static  void GetTables(ComboBox cb)
        {
            DataTable schema = conn.GetSchema("Tables");
            foreach (DataRow row in schema.Rows)
            {
                cb.Items.Add(row[2].ToString());
            }
        }
        //Update COMMAND
        public static void changeData(string nameProc, string tableName, List<Parametrs_command> listParams)
        {
            //Create command
            SqlCommand command = conn.CreateCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = nameProc;
            //Add input parametrs (together VALUE)
            //collection parametrs command 
            foreach (Parametrs_command p in listParams)
            {
                command.Parameters.AddWithValue(p.paramName, p.paramValue);
            }
            //Upadte Data in table 
            UpdateTable(command, tableName);
        }

        public static List<string> GetTables(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                List<string> TableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    TableNames.Add(row[2].ToString());
                }
                return TableNames;
            }
        }

        
    }
}
