using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DemoDataBases
{
    public partial class AddNewUser : UserControl
    {
        public AddNewUser()
        {
            InitializeComponent();
        }

        private void AddUserutton_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
                IDbConnection conn = new SqlConnection(connectString);
                try
                {
                    IDbCommand command = conn.CreateCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "InsertUseres";
                    SqlParameter UserNameParam = new SqlParameter
                    {
                        ParameterName = "@UserName",
                        Value = textBoxName.Text.ToString(),
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(UserNameParam);
                    SqlParameter PasswordParam = new SqlParameter
                    {
                        ParameterName = "@Password",
                        Value = textBoxPassword.Text.ToString(),
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(PasswordParam);
                    SqlParameter AdminParam = new SqlParameter
                    {
                        ParameterName = "@Admin",
                        Value = textBoxAdmin.Text.ToString(),
                        Direction = ParameterDirection.Input
                    };
                    command.Parameters.Add(AdminParam);
                    conn.Open();
                    MessageBox.Show("Person was add successfully");
                    IDataReader reader = command.ExecuteReader();
                    conn.Close();
                }

                //    string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
                //IDbConnection conn = new SqlConnection(connectString);
                //try
                //{
                //    conn.Open();
                //    IDbCommand command = conn.CreateCommand();
                //    command.CommandText = String.Format(
                //    @"INSERT INTO Login (UserName, Password, Admin) VALUES ('{0}', {1}, '{2}')", textBoxName.Text.ToString(), textBoxPassword.Text.ToString(), textBoxAdmin.Text);
                //    command.ExecuteNonQuery();
                //    MessageBox.Show("Deletion completed successfully");

                //}
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error Detected");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
               
               
            }
            else
            {
                MessageBox.Show("Password was confirmad uncorrect");
            }
        }
    }
}
