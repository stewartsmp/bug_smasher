﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp1
{
    public partial class Logon : Form
    {

        public static string username;
        public static int user_id;
        public static string role;
        SQLiteConnection sql_lite_connection = new SQLiteConnection("Data Source = 463.db");

        public Logon()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LOGIN_exc_Click(object sender, EventArgs e)
        {
            sql_lite_connection.Open();
            SQLiteCommand user_pword_valid = new SQLiteCommand(sql_lite_connection);
            user_pword_valid.CommandText = "SELECT EXISTS (SELECT * FROM User_Logon WHERE Username = @p1 AND Password = @p2";
            user_pword_valid.CommandType = CommandType.Text;
            user_pword_valid.Parameters.Add(new SQLiteParameter("@p1", username_text.Text));
            user_pword_valid.Parameters.Add(new SQLiteParameter("@p2", password_text.Text));

            string valid = user_pword_valid.ExecuteScalar().ToString();
            sql_lite_connection.Close();

            if (valid == "true")
            {
                Logon.username = username_text.Text;
                sql_lite_connection.Open();
                // Find User ID
                var staff_id_selectstatement = $"SELECT User_ID FROM User_Logon WHERE Username = '{Logon.username}'";
                SQLiteCommand staffID = new SQLiteCommand(staff_id_selectstatement, sql_lite_connection);
                Logon.user_id = Convert.ToInt32(staffID.ExecuteScalar());
                // Find User Role
                var staff_role_selectstatemetn = $"SELECT Role FROM User_Information WHERE User_ID = '{Logon.username}'";
                SQLiteCommand staffRole = new SQLiteCommand(staff_role_selectstatemetn, sql_lite_connection);
                Logon.role = staffRole.ExecuteScalar().ToString();

            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(username_text.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
