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
    
    public partial class Staff_Bugs : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public Staff_Bugs(int user_id)
        {
            InitializeComponent();
            this.Text = ($"Logged in as {Logon.user_first_name} {Logon.user_last_name}");


            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string fillSelectStatement = $"SELECT Bug_ID, Bug_Status, Bug_Description, Date_of_creation, Projected_Completion_Date, Priority_Level" +
                $" FROM Bugs " +
                $" WHERE Responible_User_Id = '{user_id}'";
            SqlCommand comm = new SqlCommand(fillSelectStatement, connectionString);
            connectionString.Open();
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        read.GetValue(read.GetOrdinal("Bug_ID")),
                        read.GetValue(read.GetOrdinal("Bug_Status")),
                        read.GetValue(read.GetOrdinal("Bug_Description")),
                        read.GetValue(read.GetOrdinal("Date_of_creation")),
                        read.GetValue(read.GetOrdinal("Projected_Completion_Date")),
                        read.GetValue(read.GetOrdinal("Priority_Level")),
                    });
                }
            }
            connectionString.Close();





            label1.Text = "Viewing Bug for {First_Name} {Last_Name}";


        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Logon lg = new Logon();
            lg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_view mg = new Manager_view(Logon.user_id);
            mg.Show();
            this.Hide();
        }
    }
}
