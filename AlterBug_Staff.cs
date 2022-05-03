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
        public AlterBug_Staff(int Bug_id)
        {
            int Bug_ID = Bug_id;
            InitializeComponent();
            this.Text = ($"Logged in as {Logon.user_first_name} {Logon.user_last_name}");

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




    }
}
