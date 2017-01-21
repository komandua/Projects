using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
namespace DatabaseFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            comboBoxSourceType.Items.Add("MySql");
            SearchDB sdb = new SearchDB();
            sdb.Execute("Show Databases");
            sdb.AddToListBox(listBoxDatabases, "Database");
        }

        private void listBoxDatabases_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string dbname = listBoxDatabases.SelectedItem as string;
            string sql = MakeSqlString(dbname);
            SearchDB sdb = new SearchDB();
            treeView.Items.Clear();
            sdb.Execute(sql);
            sdb.AddToTreeView(treeView);
        }
        private string MakeSqlString(string dbname)
        {
            string sql = "SELECT ke.referenced_table_name 'parent table'," +
                         "ke.referenced_column_name 'parent column'," +
                         "ke.table_name 'child table'," +
                         "ke.column_name 'child column'," +
                         "ke.constraint_name" +
                         " FROM information_schema.KEY_COLUMN_USAGE ke " +
                         " WHERE ke.referenced_table_name IS NOT NULL" +
                         " AND table_schema = '" + dbname + "'" +
                         " ORDER BY ke.referenced_table_name;";
            return sql;
        }
    }
}
