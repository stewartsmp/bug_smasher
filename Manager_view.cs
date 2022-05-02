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
    public partial class Manager_view : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        static string manager_name_first = Logon.user_first_name;
        static string manager_name_last = Logon.user_last_name;
        public Manager_view()
        {
            InitializeComponent();
            
            /*
            // Find manager name
            connectionString.Open();
            
            // Find first name
            string find_manager_first_name_statement = $"SELECT First_Name FROM User_Information_Updated WHERE User_ID = {Logon.user_id}";
            SqlCommand find_manager_name_first = new SqlCommand(find_manager_first_name_statement, connectionString);
            Manager_view.manager_name_first = find_manager_name_first.ExecuteScalar().ToString();
            
            // Find Last name
            string find_manager_last_name_statement = $"SELECT Last_Name FROM User_Information_Updated WHERE User_ID = {Logon.user_id}";
            SqlCommand find_manager_name_last = new SqlCommand(find_manager_last_name_statement, connectionString);
            Manager_view.manager_name_last = find_manager_name_last.ExecuteScalar().ToString();
            
            // Show welcome message
            MessageBox.Show($"Welcome {Manager_view.manager_name_first} {Manager_view.manager_name_last}");
            connectionString.Close();
            */

            manager_name_first = Logon.user_first_name;
            manager_name_last = Logon.user_last_name;

            showdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager_name_first = Logon.user_first_name;
            manager_name_last = Logon.user_last_name;
        }

        private void fillDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var fillSelectStatement = $"SELECT First_Name, Last_Name, User_ID FROM User_Information_Updated WHERE Manager_Name = '{Manager_view.manager_name_last}'";
            SqlCommand comm = new SqlCommand(fillSelectStatement, connectionString);
            connectionString.Open();
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        read.GetValue(read.GetOrdinal("First_Name")),
                        read.GetValue(read.GetOrdinal("Last_Name")),
                        read.GetValue(read.GetOrdinal("User_ID"))
                    });
                }
            }
            connectionString.Close();
        }


        public void showdata()
        {
            fillDataGrid();
            fillListBox();
        }

        private void fillListBox()
        {
            connectionString.Open();
            
            string find_managed_employee_statement = $"SELECT First_Name, Last_Name FROM User_Information_Updated WHERE Manager_Name = '{Manager_view.manager_name_last}'";
            SqlCommand find_managed_employees = new SqlCommand(find_managed_employee_statement, connectionString);
            SqlDataAdapter list_box_adp = new SqlDataAdapter(find_managed_employees);
            DataSet employees_managed = new DataSet();
            list_box_adp.Fill(employees_managed);
            find_managed_employees.ExecuteNonQuery();
            comboBox1.DataSource = employees_managed.Tables[0];
            comboBox1.DisplayMember = "Last_Name";
            //comboBox1.ValueMember = "Last_Name";

            connectionString.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBug add_bug = new AddBug();
            add_bug.Show();
            this.Close();
        }
    }
}
