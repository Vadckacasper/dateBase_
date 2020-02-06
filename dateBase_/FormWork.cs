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
        String CurrentCellText = null;
        int RowIndex = 0;
        int ColumnIndex = 0;

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
                   dataGridViewWork.Rows.Add(Convert.ToString(sqlReader["Login"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Paul"]), Convert.ToString(sqlReader["Age"]), Convert.ToString(sqlReader["Position"]), Convert.ToString(sqlReader["Date"]));
                }
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            dataGridViewWork.Rows.Add();
        }



        private void LabelExit_Click(object sender, EventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            this.labelEx.ForeColor = Color.White;
        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            this.labelEx.ForeColor = Color.DimGray;
        }
        //////////////////////////////

        //Перетаскивание формы
        Point lastPoint;
        private void MenuStrip1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MenuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        ///////////////////////

        //Свернуть
        private void LabelRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void LabelRollUp_MouseEnter(object sender, EventArgs e)
        {
            this.label_.ForeColor = Color.White;
        }

        private void LabelRollUp_MouseLeave(object sender, EventArgs e)
        {
            this.label_.ForeColor = Color.DimGray;
        }


        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }

        private async void DataGridViewWork_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (RowIndex+1 == dataGridViewWork.Rows.Count) // Добавление нового элемента в базу
            {
                if (!checkColumn(RowIndex))
                {
                    SqlCommand commandAdd = new SqlCommand("INSERT INTO [Test] (Login, Name, Paul, Age, Position, Date)VALUES(@Login, @Name, @Paul, @Age, @Position, @Date)", sqlConnection);
                    commandAdd.Parameters.AddWithValue("Login", Login);
                    dataGridViewWork[0, RowIndex].Value = Login;
                    commandAdd.Parameters.AddWithValue("Name", dataGridViewWork[1, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Paul", dataGridViewWork[2, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Age", dataGridViewWork[3, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Position", dataGridViewWork[4, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Date",DateTime.Now);
                    dataGridViewWork[5, RowIndex].Value = DateTime.Now;

                    await commandAdd.ExecuteNonQueryAsync();
                    dataGridViewWork.Rows.Add();
                }
            }
        }

        private bool checkColumn (int rowIndex)
        {
            for (int i = 1; i < 5; i++)
            {
                if (Convert.ToString(dataGridViewWork[i, rowIndex].Value) == "")
                    return true;
            }
            return false;
        }

        private void DataGridViewWork_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentCellText = Convert.ToString(dataGridViewWork.CurrentCell.Value);
            RowIndex = dataGridViewWork.CurrentCell.RowIndex;
            ColumnIndex = dataGridViewWork.CurrentCell.ColumnIndex;
        }
    }
}
