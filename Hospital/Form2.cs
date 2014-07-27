using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String imagepath;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=.\; Integrated Security=True;" +
                 "Database=Hospital_Management";
            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection failed!");
            }

            int hospitalindex=0;
            if (Hospitalbox.Text.ToString()=="Devlet")
            {
                hospitalindex = 1;
            }
            else if (Hospitalbox.Text.ToString() == "Anadolu")
            {
                hospitalindex = 2;
            }
            else if (Hospitalbox.Text.ToString() == "Comu")
            {
                hospitalindex = 3;
            }
            else
            {
                MessageBox.Show("Wrong hospital name or empty!");
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO doctors(id,name,lname,tel,address,e_area,image) " +
                                "VALUES('"+idtext.Text+"', '"+nametext.Text+"', '"+lnametext.Text+"', '"+
                                phonetext.Text+"', '"+addresstext.Text+"', '"+specialitytext.Text+ "', '" + imagepath +
                                "') ;",conn); 
            try
            {
                
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Doctor insertion operation failed!");
            }
            SqlCommand cmd2 = new SqlCommand("INSERT INTO H_D(id,h_id,d_id) "+
	                                     "VALUES((SELECT MAX(CAST(id as int))+1 FROM H_D), '"+hospitalindex.ToString()+"', '"+idtext.Text+"');", conn);
            try
            {
                cmd2.ExecuteNonQuery();
            }
            catch (Exception)
            {

                MessageBox.Show("Relation insertion failed!");
            }
            finally
            {
                conn.Close();
                MessageBox.Show("Operation successful!");
            }

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagepath = Path.GetFullPath(openFileDialog1.FileName);
            }
        }


    }
}
