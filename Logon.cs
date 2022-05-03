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
    public partial class Logon : Form
    {

        public static string username;
        public static int user_id;
        public static string role;
        public static string user_first_name;
        public static string user_last_name;

        //SQLiteConnection sql_lite_connection = new SQLiteConnection("Data Source = 463.db");

        // Connection to Azure Database
        Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public Logon()
        {
            InitializeComponent();
            

        }


        private void welcome_message()
        {
            // Find name
            connectionString.Open();

            // Find first name
            string find_first_name_statement = $"SELECT First_Name FROM User_Information_Updated WHERE User_ID = {Logon.user_id}";
            SqlCommand find_name_first = new SqlCommand(find_first_name_statement, connectionString);
            Logon.user_first_name = find_name_first.ExecuteScalar().ToString();
            

            // Find Last name
            string find_last_name_statement = $"SELECT Last_Name FROM User_Information_Updated WHERE User_ID = {Logon.user_id}";
            SqlCommand find_name_last = new SqlCommand(find_last_name_statement, connectionString);
            Logon.user_last_name = find_name_last.ExecuteScalar().ToString();

            // Show welcome message
            MessageBox.Show($"Welcome {Logon.user_first_name} {Logon.user_last_name}");

            connectionString.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_new_user reg_new_user = new Register_new_user();
            reg_new_user.Show();

        }

        private void LOGIN_exc_Click(object sender, EventArgs e)
        {
            var blank_text_field = "Please enter the requested information";

            if (String.IsNullOrEmpty(username_text.Text) || String.IsNullOrEmpty(password_text.Text))
            {
                MessageBox.Show(blank_text_field,"Enter username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                //var user_pword_selectstatemetn = ;
                connectionString.Open();

                //SQLiteCommand user_pword_valid = new SQLiteCommand(sql_lite_connection);
                string pword_valid_selectstatment = "SELECT COUNT(*) FROM User_Logon_Updated WHERE Username = @p1 AND Password = @p2;";
                SqlCommand user_pword_valid = new SqlCommand(pword_valid_selectstatment, connectionString);
                //user_pword_valid.CommandType = CommandType.Text;
                user_pword_valid.Parameters.Add(new SqlParameter("@p1", username_text.Text));
                user_pword_valid.Parameters.Add(new SqlParameter("@p2", password_text.Text));
                //Console.WriteLine(user_pword_valid.ToString());
                
                int valid = 0;
                valid = Convert.ToInt32(user_pword_valid.ExecuteScalar());
                
                connectionString.Close();
                

                if (valid == 1)
                {
                    // Assign Username
                    Logon.username = username_text.Text;
                    connectionString.Open();
                    // Assign User ID
                    var staff_id_selectstatement = $"SELECT User_ID FROM User_Logon_Updated WHERE Username = '{Logon.username}'";
                    SqlCommand staffID = new SqlCommand(staff_id_selectstatement, connectionString);
                    Logon.user_id = Convert.ToInt32(staffID.ExecuteScalar());
                    // Assign User Role
                    var staff_role_selectstatemetn = $"SELECT Role_Description FROM User_Information_Updated WHERE User_ID = {Logon.user_id}";
                    SqlCommand staffRole = new SqlCommand (staff_role_selectstatemetn, connectionString);
                    Logon.role = staffRole.ExecuteScalar().ToString();
                    connectionString.Close();
                    // Switch between views based on role
                    switch (Logon.role)
                    {
                        case "Developer":
                            welcome_message();
                            Staff_view sv = new Staff_view(Logon.user_id);
                           
                            sv.Show();
                            this.Hide();
                            //Console.WriteLine(Logon.username + " is a Developer");
                            break;
                        case "Manager":
                            welcome_message();
                            Manager_view mv = new Manager_view(Logon.user_id);
                            
                            mv.Show();
                            this.Hide();
                            //Console.WriteLine(Logon.username + " is a Manager");
                            break;

                    }


                }
                else
                {
                    MessageBox.Show(username_text.Text, "Invalid username or password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void username_text_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(username_text.Text))
            {
                e.Cancel = true;
                username_text.Focus();
                errorProvider1.SetError(username_text, "Please enter your username");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(username_text, null);
            }

        }
    }
}
