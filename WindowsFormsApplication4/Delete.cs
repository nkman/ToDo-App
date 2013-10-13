using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


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
            string address = "Data Source=NAIRITYA\\HACKSQL;Initial Catalog=nkman_todo_db;Integrated Security=True;Pooling=False";
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
            for (int i = varia+1; i < total; i++)
            {
                SqlCommand commandis = new SqlCommand("SELECT * FROM check_Assignment_of_works WHERE Id = '" + varia + "'", con);
                DataSet dataset = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(commandis);
                adapter.Fill(dataset);
                dataset.Tables[0].Rows[0][i] = i - 1;
                //SqlCommand comma = new SqlCommand("Modify Id in each row");         //Modification
            }
            
            con.Close();
            /*Form1 f = new Form1();
            f.ShowDialog();*/
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string address = "Data Source=NAIRITYA\\HACKSQL;Initial Catalog=nkman_todo_db;Integrated Security=True;Pooling=False";
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
            SqlCommand coma = new SqlCommand("Set Status from no to yes where Id = deletebutton.text", con);            //Modification;

            coma.ExecuteNonQuery();
            con.Close();
            return;
        }
    }
}
