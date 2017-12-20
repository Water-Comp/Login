using Login;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace explorator
{
    class Sharing
    {
        DB dB = null;
        public Sharing(DB db)
        {
            dB = db;
        }

        private bool Check(int file_id, int u_id)
        {
            string sql = "Select ID from sharing where FILE_ID = '" + file_id + "' and U_ID = '" + u_id + "'";
            try
            {
                SQLiteCommand check = new SQLiteCommand(sql, dB.m_dbConnection);
                SQLiteDataReader reader = check.ExecuteReader();
                reader.Read();
                int? ID = reader.GetInt32(reader.VisibleFieldCount - 1);

                if (ID.HasValue)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch
            {
                return true;
            }
        }

        public List<bool> Get_Perm(int file_id, int u_id)
        {
            List<bool> perms = new List<bool>();
            for (int i = 0; i <= 3; i++)
            {
                string sql = "select prm_" + i + " from sharing where FILE_ID = " + file_id + " and U_ID = " + u_id;
                //System.Console.WriteLine(sql);
                SQLiteCommand get = new SQLiteCommand(sql, dB.m_dbConnection);
                SQLiteDataReader get_perm = get.ExecuteReader();
                get_perm.Read();
                get_perm.GetString(0);
                string per = get_perm.GetString(0);
                //System.Console.WriteLine(per);
                if (get_perm.GetString(0) == "false")
                {
                    perms.Add(false);
                }
                else
                {
                    perms.Add(true);
                }
            }   
            return perms;
        }

        public bool Start(int file_id, int u_id, List<bool> permission)
        {
            if (Check(file_id, u_id) == true)
            {
                List<string> perm_to_db = new List<string>();
                string sql_where = "";
                string sql_what = "";
                for (int i = 0; i < permission.Count; i++)
                {
                    if (permission[i] == true) perm_to_db.Add("true");
                    else perm_to_db.Add("false");
                    sql_where += ",prm_" + i;
                    sql_what += ", '" + perm_to_db[i] + "'";
                }

                string sql = "insert into sharing (FILE_ID,U_ID" + sql_where + ") values ('" + file_id + "', '" + u_id + "'" + sql_what + ")";

                dB.Query(sql);

                return true;
            }
            else return false;
        }

        public void Stop(int file_id, int u_id)
        {
            dB.Query("delete from sharing where FILE_ID = '" + file_id + "' and U_ID = '" + u_id + "'");
        }

        public bool Update(int file_id, int u_id, List<bool> permission)
        {
            if (Check(file_id, u_id) == false)
            {
                List<string> perm_to_db = new List<string>();
                string sql_set = "";
                List<string> sql_vector = new List<string>();
                for (int i = 0; i < permission.Count; i++)
                {
                    if (permission[i] == true)
                    {
                        perm_to_db.Add("true");
                    }
                    else
                    {
                        perm_to_db.Add("false");
                    }

                    sql_set += ("prm_" + i + " = '" + perm_to_db[i] + "'");
                    if (i != permission.Count - 1)
                    {
                        sql_set += ", ";
                    }
                }

                string sql = "update sharing set " + sql_set + " where FILE_ID = " + file_id + " and U_ID = " + u_id;

                dB.Query(sql);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
