using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Register_new_user : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //static private string username;
        public Register_new_user()
        {
            InitializeComponent();
            label11.Visible = false;
            label11.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string First_name = textBox1.Text.ToString();
            string Last_name = textBox2.Text.ToString();
            DateTime date_of_birth = dateTimePicker1.Value;
            int employee_id = Convert.ToInt32(textBox8.Text);
            string role_description = comboBox1.Text.ToString();
            string manager_name = textBox5.Text.ToString();
            string department = textBox6.Text.ToString();
            string company = textBox8.Text.ToString();
            string username = textBox10.Text.ToString();
            string password = textBox9.Text.ToString();

           

            string new_user_submit_statement = $"INSERT INTO User_Information_Updated" +
                $" (First_Name, Last_Name, Date_of_Birth, Employee_ID, Role_Description, Manager_Name, Department, Company_Name)" +
                $" VALUES ('{First_name}', '{Last_name}', '{date_of_birth}', {employee_id}, '{role_description}', '{manager_name}', '{department}', '{company}')";

            SqlCommand comm_new_user = new SqlCommand(new_user_submit_statement, connectionString);

            string find_user_id_statement = "SELECT User_ID FROM User_Information_Updated" +
               $" WHERE First_Name = '{First_name}' AND Last_Name = '{Last_name}' AND Date_of_Birth = '{date_of_birth}' AND Employee_ID = {employee_id} AND Role_Description = '{role_description}' AND " +
               $" Manager_Name = '{manager_name}' AND Department = '{department}' AND Company_Name = '{company}' ";

            SqlCommand find_user_id = new SqlCommand(find_user_id_statement, connectionString);

            

            connectionString.Open();
            
            // insert new user
            comm_new_user.ExecuteNonQuery();
            // retreive user_id from new user - user_id is created automatically
            string user_id = find_user_id.ExecuteScalar().ToString();
            //MessageBox.Show(user_id);

            connectionString.Close();
            
            string new_user_logon_statment = $"INSERT INTO User_Logon_Updated" +
                $" (Username, Password, User_ID)" +
                $" VALUES ('{username}', '{password}', '{user_id}')";

            SqlCommand comm_new_logon = new SqlCommand(new_user_logon_statment, connectionString);

            connectionString.Open();
            // insert new logon information
            comm_new_logon.ExecuteNonQuery();
            connectionString.Close();

            this.Close();
            Logon lg = new Logon();
            lg.Show();



        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            
            string temp_username = textBox10.Text.ToString();
            string username_check_statement = $"SELECT COUNT(*) WHERE EXISTS (SELECT * FROM User_Logon_Updated WHERE Username = '{temp_username}')";
            SqlCommand comm = new SqlCommand(username_check_statement, connectionString);
            connectionString.Open();
            int count;
            count = Convert.ToInt32(comm.ExecuteScalar());
            connectionString.Close();
            if (count == 1)
            {
                label11.Visible = true;
                label11.Text = "Username not available";
                label11.ForeColor = Color.Red;
            }
           
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            label11.Visible = false;

        }
    }
}
