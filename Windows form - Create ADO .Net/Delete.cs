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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection("Database = Education; Data Source = NISHARK\\SQLEXPRESS; Integrated Security = True");
            con.Open();

            String query = "delete from Student where id = '"+ textBox1.Text + "'";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully");
            con.Close();
        }
    }
}
