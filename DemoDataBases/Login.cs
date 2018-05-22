using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDataBases
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
            main_form = new MainForm();
        }
        static public MainForm main_form;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
            IDbConnection conn = new SqlConnection(connectString);
            bool admin;
            conn.Open();
            IDbCommand command = conn.CreateCommand();
            command.CommandText = "SELECT Admin from Login where UserName= '" + textBoxLogin.Text + "' and Password='" + textBoxPassword.Text + "'";
            using (IDataReader dataReader = command.ExecuteReader())
            {
                try
                {
                    if (dataReader.Read())
                    {
                        admin = (bool)dataReader["Admin"];
                        if (admin == true)
                        {
                            this.Hide();
                            main_form.EnableControls();
                            main_form.Show();
                        }
                        else if(admin == false)
                        {
                            this.Hide();
                            main_form.DisableControls();
                            main_form.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login or password was incorrect");
                    }
                }
                catch (DbException ex)
                {
                    MessageBox.Show(ex.Message, "Error Detected");
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }
    }
}
