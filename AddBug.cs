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
    public partial class AddBug : Form
    {
        static Microsoft.Data.SqlClient.SqlConnection connectionString = new Microsoft.Data.SqlClient.SqlConnection(@"Data Source = csci455-emr.database.windows.net; Initial Catalog = csci455-emr; User ID = SuperUser; Password=Pword123!;Connect Timeout = 30; Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public AddBug()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string bug_status = comboBox3.SelectedItem.ToString();
            string bug_description = textBox1.Text.ToString();
            int owner_user_id = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime creation_date = dateTimePicker1.Value;
            DateTime projected_completion_date = dateTimePicker2.Value;
            string priority_level = comboBox1.SelectedItem.ToString();
            int secondary_owner_user_id = Convert.ToInt32(comboBox5.SelectedValue);

            string submit_bug_statement =
                $"INSERT INTO Bugs" +
                $"(Bug_Status, Bug_Description, Responible_User_ID, Date_of_creation, Projected_Completion_Date, Priority_Level, Secondary_Responsible_User_ID, Date_of_completion, Anticipated_Completion_Date)" +
                $"VALUES ('{bug_status}', '{bug_description}', {owner_user_id}, '{creation_date}', '{projected_completion_date}', '{priority_level}', {secondary_owner_user_id}, null, '{projected_completion_date}');";

            SqlCommand comm = new SqlCommand(submit_bug_statement, connectionString);
            connectionString.Open();
            comm.ExecuteNonQuery();
            connectionString.Close();

            this.Close();
            Manager_view mv = new Manager_view(Logon.user_id);
            mv.Show();
        }

        
        private void AddBug_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_csci455_emrDataSet2.User_Information_Updated' table. You can move, or remove it, as needed.
            this.user_Information_UpdatedTableAdapter1.Fill(this._csci455_emrDataSet2.User_Information_Updated);
            // TODO: This line of code loads data into the '_csci455_emrDataSet1.User_Information' table. You can move, or remove it, as needed.
            this.user_InformationTableAdapter.Fill(this._csci455_emrDataSet1.User_Information);
            // TODO: This line of code loads data into the '_csci455_emrDataSet.User_Information_Updated' table. You can move, or remove it, as needed.
            this.user_Information_UpdatedTableAdapter.Fill(this._csci455_emrDataSet.User_Information_Updated);

        }
    }
}
