using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.SqlClient;

namespace DemoDataBases
{
    public partial class RemoveRerson : UserControl
    {
        public RemoveRerson()
        {
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
            IDbConnection conn = new SqlConnection(connectString);
            try
            {
                conn.Open();
                IDbCommand command = conn.CreateCommand();
                command.CommandText = String.Format(
                @"DELETE FROM Department WHERE OrderNumberOfEmployment = '{0}'",
                textBoxKey.Text.ToString());
                command.ExecuteNonQuery();
                MessageBox.Show("Deletion completed successfully");
                textBoxKey.Text = "";
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
