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
using LiveCharts;
using LiveCharts.Wpf;
using System.Media;
using System.Windows.Media;

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
            this.Text = ($"Logged in as {manager_name_first} {manager_name_last}");

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
            // TODO: This line of code loads data into the '_csci455_emrDataSet3.User_Bug_Counts' table. You can move, or remove it, as needed.
            this.user_Bug_CountsTableAdapter.Fill(this._csci455_emrDataSet3.User_Bug_Counts);
            manager_name_first = Logon.user_first_name;
            manager_name_last = Logon.user_last_name;

           

        }

        private void fillDataGrid()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            string fillSelectStatement = $"SELECT First_Name, Last_Name, User_Information_Updated.User_ID, [Bug Count Updated 2].Bug_Count" +
                $" FROM User_Information_Updated " +
                $" LEFT JOIN [Bug Count Updated 2] ON User_Information_Updated.User_ID = [Bug Count Updated 2].User_ID" +
                $" WHERE Manager_Name = '{Manager_view.manager_name_last}'";
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
                        read.GetValue(read.GetOrdinal("User_ID")),
                        read.GetValue(read.GetOrdinal("Bug_Count"))
                    });
                }
            }
            connectionString.Close();
        }


        public void showdata()
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P}))", chartPoint.Y, chartPoint.Participation);

            SeriesCollection pieChartData = new SeriesCollection();
            /*
            string number_of_bugs_statement = "SELECT User_ID, COUNT(*) Bug_Count " +
                "FROM User_Information_Updated " +
                "INNER JOIN Bugs ON User_Information_Updated.User_ID = Bugs.Responible_User_ID " +
                "GROUP BY User_ID;";
            */
            string number_of_bugs_statement = "SELECT Last_Name, [Bug Count Updated 2].Bug_Count " +
                " FROM User_Information_Updated " +
                " LEFT JOIN [Bug Count Updated 2] ON User_Information_Updated.User_ID = [Bug Count Updated 2].User_ID " +
                $" WHERE Manager_Name = '{Manager_view.manager_name_last}'";

            SqlCommand comm = new SqlCommand(number_of_bugs_statement, connectionString);
            connectionString.Open();
            DataTable tb = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(comm);

            adapter.Fill(tb);

            string[] brushArray = typeof(System.Windows.Media.Brushes).GetProperties().
                                    Select(c => c.Name).ToArray();

            Random randomGen = new Random();
            string randomColorName = brushArray[randomGen.Next(brushArray.Length)];
            System.Windows.Media.SolidColorBrush color = (SolidColorBrush)new BrushConverter().ConvertFromString(randomColorName);

            foreach (DataRow row in tb.Rows)
            {
                if (row["Bug_Count"] is DBNull)
                {
                    int zero = 0;
                    row["Bug_Count"] = zero;
                }
                pieChartData.Add(
                    new PieSeries
                    {
                        Title = row["Last_Name"].ToString(),
                        Values = new ChartValues<double> { Convert.ToDouble(row["Bug_Count"]) },
                        DataLabels = true,
                        LabelPoint = labelPoint,
                        Fill = color
                    }
                    );
                color = null;
            }

            color = null;

            pieChart1.Series = pieChartData;
            pieChart1.LegendLocation = LegendLocation.Right;

            connectionString.Close();


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
            DataTable table = new DataTable();
            table.Columns.Add("Last_Name", typeof(string));
            table.Rows.Add("All");
            employees_managed.Tables.Add(table);
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

        private void button2_Click(object sender, MouseEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Logon lg = new Logon();
            lg.Show();
            this.Close();
        }

        

        private void pieChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
