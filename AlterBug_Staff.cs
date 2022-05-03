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
    public partial class AlterBug_Staff : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        static int Bug_ID;
        public AlterBug_Staff(int Bug_id)
        {
            Bug_ID = Bug_id;
            InitializeComponent();
            this.Text = ($"Logged in as {Logon.user_first_name} {Logon.user_last_name}");
            label9.Text = $"Current Values For Bug Number: {Bug_ID}";

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string find_data_to_fill = $"SELECT Bug_Status, Bug_Description, Responible_User_ID, Projected_Completion_Date, Priority_Level" +
                $" FROM Bugs" +
                $" WHERE Bug_ID = {Bug_ID}";

            SqlCommand data_to_fill = new SqlCommand(find_data_to_fill, connectionString);
            connectionString.Open();
            using (SqlDataReader read = data_to_fill.ExecuteReader(CommandBehavior.SingleRow))
            {

                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                     {
                        read.GetValue(read.GetOrdinal("Bug_Status")),
                        read.GetValue(read.GetOrdinal("Bug_Description")),
                        read.GetValue(read.GetOrdinal("Responible_User_ID")),
                        read.GetValue(read.GetOrdinal("Projected_Completion_Date")),
                        read.GetValue(read.GetOrdinal("Priority_Level")),
                     });

                }

            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Logon lg = new Logon();
            lg.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff_view sv = new Staff_view(Logon.user_id);
            sv.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
             
            
            string bug_status = comboBox3.SelectedItem.ToString();
            string bug_description = textBox1.Text.ToString();
            int owner_user_id = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime projected_completion_date = dateTimePicker2.Value;
            string priority_level = comboBox1.SelectedItem.ToString();

            string update_table_statement = $"UPDATE Bugs" +
                $" SET Bug_Status = '{bug_status}', Bug_Description = '{bug_description}', Responible_User_ID = {owner_user_id}, Projected_Completion_Date = '{projected_completion_date}', Priority_Level = '{priority_level}'" +
                $" WHERE Bug_ID = {Bug_ID}";

            SqlCommand comm_update_bug_data = new SqlCommand(update_table_statement, connectionString);
            connectionString.Open();
            comm_update_bug_data.ExecuteNonQuery();
            connectionString.Close();
            

            Staff_view sv = new Staff_view(Logon.user_id);
            sv.Show();
            this.Close();

        }
    }
}
