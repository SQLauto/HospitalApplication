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

namespace Hospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            deletebutton.Enabled = false;
            comboBox1.Text = "name";        
        }
        List<doctor> doctors = new List<doctor>();
        public void connect() {
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
        }
        private void button1_Click(object sender, EventArgs e)
        {
            while (doctors.Count>0)
            {
                for (int i = 0; i < doctors.Count; i++)
                {
                    doctors.Remove(doctors[i]);
                    listBox1.Items.RemoveAt(i);
                }
            }

            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = @"Server=.\; Integrated Security=True;" +
                "Database=Hospital_Management";
            String name = d_nametext.Text;
            try
            {
                conn.Open();
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection failed!");
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT doctors.id, name, doctors.lname, doctors.tel, doctors.address, " +
                                            "doctors.e_area, h_name, h_location, image " +
                                            "FROM Hospital_Management.dbo.Hospital, Hospital_Management.dbo.H_D, Hospital_Management.dbo.doctors " +
                                            "WHERE Hospital.h_id=H_D.h_id AND doctors.id=H_D.d_id AND " +
                                            "doctors." + comboBox1.SelectedItem.ToString() + "='" + d_nametext.Text + "';";
            cmd.Connection = conn;

            try
            {
                SqlDataReader rdr = cmd.ExecuteReader();
                for (int i = 0; rdr.Read() == true; i++)
                {
                    
                    listBox1.Items.Add(rdr.GetValue(0).ToString());
                    doctor d = new doctor(
                            rdr.GetValue(0).ToString(),
                            rdr.GetValue(1).ToString(),
                            rdr.GetValue(2).ToString(),
                            rdr.GetValue(3).ToString(),
                            rdr.GetValue(4).ToString(),
                            rdr.GetValue(5).ToString(),
                            rdr.GetValue(6).ToString(),
                            rdr.GetValue(7).ToString(),
                            rdr.GetValue(8).ToString()
                        );
                    doctors.Add(d);
                    if (rdr.GetValue(8).ToString() == "")
                    {
                        doctors[i].Image = @"C:\Users\-ZaferAYAN-\Documents\Visual Studio 2012\Projects\Hospital\none.jpg";
                    }
                    
                }
                if (doctors.Count > 1)
                {
                    
                    listBox1.Visible = true;
                }
                idtext.Text = doctors[0].ID;
                nametext.Text = doctors[0].Name;
                lnametext.Text = doctors[0].LName;
                phonetext.Text = doctors[0].Tel;
                addresstext.Text = doctors[0].Address;
                specialitytext.Text = doctors[0].E_area;
                hospitaltext.Text = doctors[0].H_name;
                locationtext.Text = doctors[0].H_location;
                pictureBox1.Image = Image.FromFile(@"" + doctors[0].Image);
            }
            catch 
            {
                if (doctors.Count == 0) 
                {
                    MessageBox.Show(d_nametext.Text + " not found!");
                }
            }
            finally
            {
                conn.Close();
            }
        }

        private void d_nametext_TextChanged(object sender, EventArgs e)
        {
            if (d_nametext.Text != "")
            {
                button1.Enabled = true;
                deletebutton.Enabled = true;
            }
            else 
            {
                button1.Enabled = false;
                deletebutton.Enabled = false;
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < doctors.Count; i++)
            {
                int index = Convert.ToInt32(listBox1.SelectedIndex);
                if (index==-1)
                {
                    index = 0;
                }
                if (listBox1.Items[index].ToString().Equals(doctors[i].ID))
                {
                    idtext.Text = doctors[i].ID;
                    nametext.Text = doctors[i].Name;
                    lnametext.Text = doctors[i].LName;
                    phonetext.Text = doctors[i].Tel;
                    addresstext.Text = doctors[i].Address;
                    specialitytext.Text = doctors[i].E_area;
                    hospitaltext.Text = doctors[i].H_name;
                    locationtext.Text = doctors[i].H_location;
                    if (doctors[i].Image == "")
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\-ZaferAYAN-\Documents\Visual Studio 2012\Projects\Hospital\none.jpg");
                    }
                    else
                    {
                        try
                        {
                            pictureBox1.Image = Image.FromFile(@"" + doctors[i].Image);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Image not found!");
                        }
                        
                    }
                }
            }
        }

        private void d_nametext_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.ToString() == "Return")
            {
                button1.PerformClick();
            }
        }
        //public static void ThreadProc()
        //{
        //    Application.Run(new Form2());
        //}
        private void insertbutton_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start();
            Form2 form = new Form2();
            form.Show();

        }

        private void deletebutton_Click(object sender, EventArgs e)
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
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            if (comboBox1.Text=="id")
            {
                cmd.CommandText = "DELETE FROM H_D WHERE d_id='" + d_nametext.Text + "';" +
                               "DELETE FROM doctors WHERE doctors.id='" + d_nametext.Text + "';";
            }
            else if (comboBox1.Text == "name")
            {
                cmd.CommandText = "DELETE FROM H_D WHERE d_id  IN (Select d_id FROM H_D, doctors " +
                                "WHERE H_D.d_id=doctors.id AND doctors.name='" + d_nametext.Text + "'); " +
                                 "DELETE FROM doctors WHERE name = '"+d_nametext.Text+"';";
            }
            String message = "Are you sure you want to delete this item:\n\t       name: "+d_nametext.Text.ToString();
            String caption = "Deletion";
            DialogResult result;
            result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int a = 0;
                try
                {
                    a = cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    MessageBox.Show("Deletion failed!");
                }
                if (a==0)
                {
                    MessageBox.Show(d_nametext + " not found!", "Not Found");
                }
                else
                {
                    MessageBox.Show((a / 2).ToString() + " record(s) deleted!", "Deletion Successful");
                }
            }
            
           
        }


    }
}
