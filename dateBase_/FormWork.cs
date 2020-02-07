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
                   dataGridViewWork.Rows.Add(Convert.ToString(sqlReader["Id"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Paul"]), Convert.ToString(sqlReader["Age"]), Convert.ToString(sqlReader["Position"]));
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
            
            if (RowIndex + 1 == dataGridViewWork.Rows.Count) // Добавление нового элемента в базу
            {
                if (!checkColumn(RowIndex))
                {
                    SqlCommand commandAdd = new SqlCommand("INSERT INTO [Test] (Login, Name, Paul, Age, Position, Date)VALUES(@Login, @Name, @Paul, @Age, @Position, @Date)", sqlConnection);
                    commandAdd.Parameters.AddWithValue("Login", Login);
                    commandAdd.Parameters.AddWithValue("Name", dataGridViewWork[1, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Paul", dataGridViewWork[2, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Age", dataGridViewWork[3, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Position", dataGridViewWork[4, RowIndex].Value);
                    commandAdd.Parameters.AddWithValue("Date", DateTime.Now);

                    await commandAdd.ExecuteNonQueryAsync();
                    commandAdd.CommandText = "SELECT @@IDENTITY";//вернуть id
                    int lastId = Convert.ToInt32(commandAdd.ExecuteScalar());
                    dataGridViewWork[0, RowIndex].Value = lastId;
                }
            }
            else
            {
               
                String temp = Convert.ToString(dataGridViewWork[ColumnIndex, RowIndex].Value);
                if (CurrentCellText != temp)
                {
                    if (temp == "") //проверка на пустоту строки
                    {
                        dataGridViewWork[ColumnIndex, RowIndex].Value = CurrentCellText;
                    }
                    else //изменение в бд
                    {
                        
                        SqlCommand command = null;

                        switch (ColumnIndex)//добавить обновление даты
                        {
                            case 1:
                                command = new SqlCommand("UPDATE [Test] SET [Name] = @Name , [Date] = @Date WHERE [Id] = @Id", sqlConnection);
                                command.Parameters.AddWithValue("Id", Convert.ToString(dataGridViewWork[0, RowIndex].Value));
                                command.Parameters.AddWithValue("Name", temp);
                                command.Parameters.AddWithValue("Date", DateTime.Now);
                                break;
                            case 2:
                                command = new SqlCommand("UPDATE [Test] SET [Paul] = @Paul , [Date] = @Date WHERE [Id] = @Id", sqlConnection);
                                command.Parameters.AddWithValue("Id", Convert.ToString(dataGridViewWork[0, RowIndex].Value));
                                command.Parameters.AddWithValue("Paul", temp);
                                command.Parameters.AddWithValue("Date", DateTime.Now);
                                break;
                            case 3:
                                command = new SqlCommand("UPDATE [Test] SET [Age] = @Age , [Date] = @Date WHERE [Id] = @Id", sqlConnection);
                                command.Parameters.AddWithValue("Id", Convert.ToString(dataGridViewWork[0, RowIndex].Value));
                                command.Parameters.AddWithValue("Age", temp);
                                command.Parameters.AddWithValue("Date", DateTime.Now);
                                break;
                            case 4:
                                command = new SqlCommand("UPDATE [Test] SET [Position] = @Position , [Date] = @Date WHERE [Id] = @Id", sqlConnection);
                                command.Parameters.AddWithValue("Id", Convert.ToString(dataGridViewWork[0, RowIndex].Value));
                                command.Parameters.AddWithValue("Position", temp);
                                command.Parameters.AddWithValue("Date", DateTime.Now);
                                break;
                        }
                        await command.ExecuteNonQueryAsync();

                    }

                }
            }
        }

        private bool checkColumn (int rowIndex) //Проверка на пустые колонки в последней строке
        {
            for (int i = 1; i < 5; i++)
            {
                if (Convert.ToString(dataGridViewWork[i, rowIndex].Value) == "")
                    return true;
            }
            dataGridViewWork.Rows.Add();
            return false;
        }

        private void DataGridViewWork_CellClick(object sender, DataGridViewCellEventArgs e) //считывает ячейку
        {
            CurrentCellText = Convert.ToString(dataGridViewWork.CurrentCell.Value);
            RowIndex = dataGridViewWork.CurrentCell.RowIndex;
            ColumnIndex = dataGridViewWork.CurrentCell.ColumnIndex;
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RowIndex + 1 != dataGridViewWork.Rows.Count)
            {
                SqlCommand command = new SqlCommand("DELETE FROM [Test] WHERE [Id] = @Id", sqlConnection);
                command.Parameters.AddWithValue("@Id", dataGridViewWork[0, RowIndex].Value);
                command.ExecuteNonQuery();
                dataGridViewWork.Rows.RemoveAt(dataGridViewWork.CurrentCell.RowIndex);//удалене строки
            }
        }

        private void DataGridViewWork_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (RowIndex + 1 != dataGridViewWork.Rows.Count)
            {
                e.Control.ContextMenuStrip = contextMenuStrip1;
                this.удалитьToolStripMenuItem.Enabled = true;
            }
            else
            {
                e.Control.ContextMenuStrip = contextMenuStrip1;
                this.удалитьToolStripMenuItem.Enabled = false;
            }
        }

        private void IntelligToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Log in] WHERE Login = @Login ", sqlConnection);
            command.Parameters.AddWithValue("Login", Login);
            String name = null;
            using (var dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                name = Convert.ToString(dataReader["Name"]);
            }
            MessageBox.Show("Ваш логин: " + Login + "\n" +
                            "Ваше имя: " + name + "\n\n" +
                            "Разработчик: Калинин В.А.", "Cведениe");
        }
    }


}
