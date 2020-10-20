using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace Replication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ConnectionDB db = new ConnectionDB();
            SqlConnection conn = db.GetConnection();
            DataTable table = new DataTable();
            if (conn.State == ConnectionState.Open)
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Persons", conn);
                adapter.Fill(table);
                for(int i = 0; i < table.Rows.Count; i++)
                {
                    
                    textBox2.Text += table.Rows[i][1].ToString();
                }
                textBox2.Text += "Connection ok";
            }
            else
            {
                textBox2.Text = "Connection error";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
