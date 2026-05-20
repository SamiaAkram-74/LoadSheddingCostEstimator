using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace LoadSheddingCostEstimator.Database
{
    /// <summary>
    /// Centralised database access layer.
    /// All SQL operations (SELECT / INSERT / UPDATE / DELETE) go through this class.
    /// Forms never open connections directly.
    /// </summary>
    public static class DBHelper
    {
        // =====================================================
        //   Connection String
        //   bin\Debug\ folder me LoadSheddingDB.sqlite hona chahiye
        //   Data Source  --> SQLite file ka path
        //   Version=3    --> SQLite version
        //   Pooling=False --> fresh connection every time
        // =====================================================
        public static string ConnectionString =>
            @"Data Source=" + Application.StartupPath +
            @"\LoadSheddingDB.sqlite;Version=3;Pooling=False;";

        // ---- Open Connection ----
        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection con = new SQLiteConnection(ConnectionString);
            con.Open();
            return con;
        }

        // ---- INSERT / UPDATE / DELETE ----
        // params SQLiteParameter[] --> multiple parameters easily pass kar sakte hain
        public static int ExecuteNonQuery(string query, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd   = new SQLiteCommand(query, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        // ---- COUNT / SUM / AVG / Single value ----
        // Sirf ek value return karne wali queries ke liye
        public static object ExecuteScalar(string query, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd   = new SQLiteCommand(query, con))
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                object result = cmd.ExecuteScalar();
                return (result == null || result == DBNull.Value) ? 0 : result;
            }
        }

        // ---- SELECT - DataGridView / ComboBox ke liye ----
        // Multiple rows return karne wali SELECT queries ke liye
        public static DataTable GetDataTable(string query, params SQLiteParameter[] parameters)
        {
            using (SQLiteConnection con = GetConnection())
            using (SQLiteCommand cmd   = new SQLiteCommand(query, con)) //cmd query run karega, da cmd se data fetch karke dt mein fill karega
            {
                if (parameters != null) cmd.Parameters.AddRange(parameters);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);  // DB aur DataTable ke beech bridge
                DataTable dt = new DataTable();                     // In-memory table
                da.Fill(dt);
                return dt;
            }
        }

        // ---- Parameter shortcut ----
        // New SQLiteParameter banana easy karna ke liye
        public static SQLiteParameter Param(string name, object value)
        {
            return new SQLiteParameter(name, value ?? DBNull.Value);
        }
    }
}
