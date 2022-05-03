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
    public partial class AlterBug_Manager : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AlterBug_Manager(int Bug_id)
        {
            InitializeComponent();
            this.Text = ($"Logged in as {Logon.user_first_name} {Logon.user_last_name}");

            label7.Text = $"Current Values For Bug Number: {Bug_id}";

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string find_data_to_fill = $"SELECT Bug_Status, Bug_Description, Responible_User_ID, Projected_Completion_Date, Priority_Level" +
                $" FROM Bugs" +
                $" WHERE Bug_ID = {Bug_id}";

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

        private void button4_Click(object sender, EventArgs e)
        {
            Manager_view mv = new Manager_view(Logon.user_id);
            mv.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Logon lg = new Logon();
            lg.Show();
            this.Close();
        }
    }
}
