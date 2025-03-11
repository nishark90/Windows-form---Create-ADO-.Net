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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Database = Education; Data Source = NISHARK\\SQLEXPRESS ; Integrated Security = True");
            Con.Open();

            String query = "update Student set name = '" + textBox2.Text +"'  where id = '" +  textBox1.Text +"' ";
            SqlCommand cmd =  new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated Successfully!!");
            Con.Close();
            
        }
    }
}
