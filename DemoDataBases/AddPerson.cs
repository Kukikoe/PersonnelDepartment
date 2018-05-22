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
using System.IO;

namespace DemoDataBases
{
    public partial class AddPerson : UserControl
    {
        public byte[] image;
        public AddPerson()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string dismissal = String.Empty;
            if (textBoxOrderDismissal.Text == String.Empty)
            {
                dismissal = "";
            }
            else
            {
                dismissal = textBoxOrderDismissal.Text;
            }
            string connectString = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=Department;Integrated Security=True";
            IDbConnection conn = new SqlConnection(connectString);
            try
            {
                IDbCommand command = conn.CreateCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "InsertUseresss";
                SqlParameter FirstNameParam = new SqlParameter
                {
                    ParameterName = "@FirstName",
                    Value = textBoxName.Text.ToString(),
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(FirstNameParam);
                SqlParameter LastNameParam = new SqlParameter
                {
                    ParameterName = "@LastName",
                    Value = textBoxLastName.Text.ToString(),
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(LastNameParam);
                SqlParameter SernameParam = new SqlParameter
                {
                    ParameterName = "@Sername",
                    Value = textBoxSername.Text.ToString(),
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(SernameParam);
                SqlParameter BirthdayParam = new SqlParameter
                {
                    ParameterName = "@Birthday",
                    Value = BirthdayDataTime.Text.ToString(),
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(BirthdayParam);
                SqlParameter PositionParam = new SqlParameter
                {
                    ParameterName = "@Position",
                    Value = textBoxPosition.Text.ToString(),
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(PositionParam);
                SqlParameter OrderNumberOfEmploymentParam = new SqlParameter
                {
                    ParameterName = "@OrderNumberOfEmployment",
                    Value = textBoxNumberEmployed.Text,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(OrderNumberOfEmploymentParam);
                SqlParameter OrderNumberOfDismissalParam = new SqlParameter
                {
                    ParameterName = "@OrderNumberOfDismissal",
                    Value = dismissal,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(OrderNumberOfDismissalParam);
                SqlParameter PhotoParam = new SqlParameter("@Photo", SqlDbType.Image);

                PhotoParam.Value = image;

                PhotoParam.Direction = ParameterDirection.Input;
                command.Parameters.Add(PhotoParam);
                conn.Open();
                MessageBox.Show("Person was add successfully");
                IDataReader reader = command.ExecuteReader();
                conn.Close();
            }
            catch (DbException ex)
            {
                MessageBox.Show(ex.Message, "Error Detected");
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            textBoxName.Text = textBoxLastName.Text = textBoxSername.Text = textBoxPosition.Text = textBoxNumberEmployed.Text = textBoxOrderDismissal.Text = "";
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Jpeg Files (*.jpg)|*.jpg|All Files (*.*)|*.*";
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    Bitmap myBmp = new Bitmap(dlg.FileName);
                    Image.GetThumbnailImageAbort myCallBack = new Image.GetThumbnailImageAbort(ThumbnailCallBack);
                    Image imgPreview = myBmp.GetThumbnailImage(200, 200, myCallBack, IntPtr.Zero);
                    MemoryStream ms = new MemoryStream();
                    imgPreview.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    ms.Flush();
                    ms.Seek(0, SeekOrigin.Begin);
                    BinaryReader br = new BinaryReader(ms);
                    image = br.ReadBytes((int)ms.Length);
                    ms.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public bool ThumbnailCallBack()
        {
            return false;
        }
    }
}
