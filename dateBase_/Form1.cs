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
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string stringConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first_dataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection = new SqlConnection(stringConnection);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Test]", sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    listBox_Wiew.Items.Add(Convert.ToString(sqlReader["id"]) + "\t" + Convert.ToString(sqlReader["Name"]) + "\t" + Convert.ToString(sqlReader["Work"]) + "\t" + Convert.ToString(sqlReader["date"]));
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

        }

        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }
    }
}
