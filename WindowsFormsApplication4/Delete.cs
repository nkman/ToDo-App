using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApplication4
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection con = new SqlConnection(address);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            int varia;
            int.TryParse(deletebutton.Text, out varia);
            SqlCommand coma = new SqlCommand("DELETE check_Assignment_of_works WHERE Id = '"+varia+"'", con);
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM check_Assignment_of_works", con);
            int total = (Int32)cmd.ExecuteScalar() + 1;
            coma.ExecuteNonQuery();
            for (int i = varia; i < total; i++)
            {
                SqlCommand update = new SqlCommand("UPDATE check_Assignment_of_works SET Id = '"+i+"' WHERE Id='"+(i+1)+"'",con);
                update.ExecuteNonQuery();
            }
            
            con.Close();
            MessageBox.Show("Row '"+varia+"' hs been Deleted");
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string address = ConfigurationManager.ConnectionStrings["connection"].ToString();
            SqlConnection con = new SqlConnection(address);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
            int num;
            int.TryParse(deletebutton.Text, out num);
            SqlCommand coma = new SqlCommand("UPDATE check_Assignment_of_works SET Status = 'Done' WHERE Id='" + num + "'", con);            
            coma.ExecuteNonQuery();
            con.Close();
            return;
        }
    }
}
