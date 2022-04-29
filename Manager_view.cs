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
        
        public Manager_view()
        {
            InitializeComponent();
            showdata();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fillDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            var fillSelectStatement = "SELECT First_Name FROM User_Information_Updated";
            SqlCommand comm = new SqlCommand(fillSelectStatement, connectionString);
            connectionString.Open();
            using (SqlDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                        read.GetValue(read.GetOrdinal("First_Name"))
                    });
                }
            }
            connectionString.Close();
        }


        public void showdata()
        {
            fillDataGrid();
        }


    }
}
