using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class newProject : Form
    {
        SqlConnection con = new SqlConnection("Data Source= .\\SQLEXPRESS; Initial Catalog = stu_project;user id = sa;password = kist123;");          //for database connection
        public newProject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void login_Click(object sender, EventArgs e)
        { 
           /* try
            { 
            con.Open();
            string query = "Insert into stu_details values('Deepak Khadka','kapan','9851196592','kist','BIT')";
            SqlCommand cmd = new SqlCommand(query, con);        //object in sql command
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved Successfully");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.InnerException);
            }*/
            string data1 = input1.Text;
            string data2 = input2.Text;
            if (data1 == "kistcollege")
            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
                if(data2 == "pass")
                {
                    MessageBox.Show("Login Successfull");
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("!!!Incorrect Username!!!");
                
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
