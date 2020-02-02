using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateBase_
{
    public partial class FormWork : Form
    {
        SqlConnection sqlConnection;
        String Login = null;
        public FormWork(String login)
        {
            InitializeComponent();
            this.Login = login;
        }

        private async void FormWork_Load(object sender, EventArgs e)
        {
            string stringConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first_dataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(stringConnection);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Test] WHERE Login = @Login", sqlConnection);
            command.Parameters.AddWithValue("@Login", Login);
            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                   dataGridViewWork.Rows.Add(Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Paul"]), Convert.ToString(sqlReader["Age"]), Convert.ToString(sqlReader["Position"]), Convert.ToString(sqlReader["Arranged"]), Convert.ToString(sqlReader["Time"]));
                }
                //CurrentCellText = Convert.ToString(dataGridView[1, 0].Value);
                //RowIndex = 0;
                //ColumnIndex = 1;

            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
    }
}
