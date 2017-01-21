using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Controls;
namespace DatabaseFinder
{
   public class SearchDB
    {
        string connectionString = "server=127.0.0.1;uid=root;pwd=123lugia;";
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySqlCommand comm;
        MySqlDataReader dr;
        public SearchDB()
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            conn.Open();
        }
        public void Execute(string Sql)
        {
            comm = new MySqlCommand(Sql, conn);
            dr = comm.ExecuteReader();
        }
        public void AddToListBox(ListBox lb, string colName)
        {
            string databasename;
            while (dr.Read())
            {
                databasename = dr[colName].ToString();
                lb.Items.Add(databasename);
            }
        }
        public void AddToTreeView(TreeView tv)
        {
            int i = 0;
            while (dr.Read())
            {
                i++;
                TreeViewItem tvir = new TreeViewItem() { Header = "Relation" + i.ToString() };
                TreeViewItem tvip = new TreeViewItem() { Header = dr["parent table"].ToString() };
                TreeViewItem tvic = new TreeViewItem() { Header = dr["child table"].ToString() };
                tvip.Items.Add(tvic);
                tvir.Items.Add(tvip);
                tv.Items.Add(tvir);
            }
        }
    }
}
