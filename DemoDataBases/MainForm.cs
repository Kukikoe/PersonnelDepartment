using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDataBases
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
            IDbConnection conn = new SqlConnection(connectString);
            Read(conn);
            Width = 557;
            Height = 394;
            removeRerson1.Visible = false;
            addPerson1.Visible = false;
            listViewOfDepartment.Visible = true;
            addNewUser1.Visible = false;
        }
        public void DisableControls()
        {
            AddToolStripMenuItem.Enabled = false;
            removePersonToolStripMenuItem.Enabled = false;
            addNewToolStripMenuItem.Enabled = false;

        }

        public void EnableControls()
        {
            AddToolStripMenuItem.Enabled = true;
            removePersonToolStripMenuItem.Enabled = true;
            addNewToolStripMenuItem.Enabled = true;
        }

        private void Read(IDbConnection conn)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                int buffSize = 100;

                byte[] buffer = new byte[buffSize];


                conn.Open();
                IDbCommand command_for_read = conn.CreateCommand();
                command_for_read.CommandType = CommandType.StoredProcedure;
                command_for_read.CommandText = "GetUsers";
                IDataReader read = command_for_read.ExecuteReader();
                while (read.Read())
                {
                    ListViewItem item = new ListViewItem(read.GetString(read.GetOrdinal("FirstName")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("LastName")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("Sername")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("Birthday")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("Position")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("OrderNumberOfEmployment")));
                    item.SubItems.Add(read.GetString(read.GetOrdinal("OrderNumberOfDismissal")));
                    listViewOfDepartment.Items.Add(item);
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

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeRerson1.Visible = false;
            addPerson1.Visible = true;
            listViewOfDepartment.Visible = false;
            addNewUser1.Visible = false;
            Width = 470;
            Height = 394;
        }

        private void removePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeRerson1.Visible = true;
            addPerson1.Visible = false;
            listViewOfDepartment.Visible = false;
            addNewUser1.Visible = false;
            Width = 470;
            Height = 394;
        }

        private void watchTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listViewOfDepartment.Items.Clear();
            string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
            IDbConnection conn = new SqlConnection(connectString);
            Read(conn);
            listViewOfDepartment.Visible = true;
            removeRerson1.Visible = false;
            addPerson1.Visible = false;
            addNewUser1.Visible = false;
            Width = 557;
            Height = 394;
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login_form = new Login();
            login_form.Show();
            this.Hide();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewUser1.Visible = true;
            listViewOfDepartment.Visible = false;
            removeRerson1.Visible = false;
            addPerson1.Visible = false;
            Width = 557;
            Height = 394;
        }
    }
}
