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

namespace Windows_form___Create_ADO.Net
{
    public partial class max_mark : Form
    {
        public max_mark()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Database = Education; Data Source = NISHARK\\SQLEXPRESS; Integrated Security = True");
            con.Open();

            String query = "select max(mark) from Student";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Maximum Marks: " + dr[0].ToString());
            }
            con.Close();

        }
    }
}
