using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Data.SqlClient;

namespace NMTronis_Aaditya
{
    public partial class FF : Form
    {
        public FF()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FF_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source=EDGE;Initial Catalog=Aaditya;Integrated Security=True;Encrypt=False";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            string ID = tbemployeeID.Text;
            string FirstName = tbFirstName.Text;
            string LastName = tbLastname.Text;
            string EmailID = tbEmailID.Text;
            string Query = "INSERT INTO Employee(Employee_ID,First_Name,Last_Name,Email_ID) VALUES ('"+ID+"','"+FirstName+"','"+LastName+"','"+EmailID+"')";
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Has Been Stored into Servers");


        }
    }
}
