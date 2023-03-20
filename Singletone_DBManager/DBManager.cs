using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Singletone_DBManager
{
    public class DBManager
    {
        public static DBManager Instance()
        {
            if (_instance == null)
            {
                _instance = new DBManager();
                return _instance;
            }
            else
            {
                return null;
            }
        }
        private DBManager()
        {
            con = new System.Data.OleDb.OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vlad\Documents\БД\БД каталог відеопродукції.mdb");
           // con = new SqlConnection(conStr);
            cmd = new System.Data.OleDb.OleDbCommand();
            cmd.Connection = con;
            
        }
        private static DBManager _instance = null;
        System.Data.OleDb.OleDbConnection con;
        System.Data.OleDb.OleDbCommand cmd;
        //String conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vlad\Documents\БД\БД каталог відеопродукції.mdb";
        String conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Vlad\Documents\БД\БД каталог відеопродукції.mdb";
        public void connectTo(string conStr)
        {
            con.ConnectionString = conStr;
        }
        public void connectTo()
        {
            con.ConnectionString = conStr;
        }
        public List<List<Object>> SelectAll(String tablename)
        {
            try
            {
                var res = new List<List<Object>>();
                cmd.CommandText = "select * from " + tablename;
                con.Open();
                System.Data.OleDb.OleDbDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    List<Object> row = new List<object>();
                    for (int i = 0; i < r.FieldCount; i++)
                    {
                        row.Add(r[i]);
                    }
                    res.Add(row);
                };
                con.Close();
                return res;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }

}
