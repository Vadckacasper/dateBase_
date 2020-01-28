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
        String CurrentCellText = null;
        int RowIndex = 0;
        int ColumnIndex = 0;
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
                    dataGridView.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Work"]), Convert.ToString(sqlReader["Date"]));
                }
                CurrentCellText = Convert.ToString(dataGridView[1, 0].Value);
                RowIndex = 0;
                ColumnIndex = 1;

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
        //Выход
        private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }


        private void LabelExit_Click(object sender, EventArgs e)
        {

            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
            this.Close();
        }

        private void LabelExit_MouseEnter(object sender, EventArgs e)
        {
            this.labelExit.ForeColor = Color.White;
        }

        private void LabelExit_MouseLeave(object sender, EventArgs e)
        {
            this.labelExit.ForeColor = Color.DimGray;
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
            this.labelRollUp.ForeColor = Color.White;
        }

        private void LabelRollUp_MouseLeave(object sender, EventArgs e)
        {
            this.labelRollUp.ForeColor = Color.DimGray;
        }
        ///////////////////////

        //Добавление в БД
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNameAdd.Text == "" || textBoxWorkAdd.Text == "" || textBoxDateAdd.Text == "")
            {
                labelErorr.Text = "Для добавление в базу, все поля должны быть заполнены!";
                labelErorr.Visible = true;
            }
            else
            {
                labelErorr.Visible = false;
                SqlCommand commandAdd = new SqlCommand("INSERT INTO [Test] (Name, Work, Date)VALUES(@Name,@Work,@Date)", sqlConnection);

                commandAdd.Parameters.AddWithValue("Name", textBoxNameAdd.Text);
                commandAdd.Parameters.AddWithValue("Work", textBoxWorkAdd.Text);
                commandAdd.Parameters.AddWithValue("Date", textBoxDateAdd.Text);

                await commandAdd.ExecuteNonQueryAsync();

                commandAdd.CommandText = "SELECT @@IDENTITY";
                int lastID = Convert.ToInt32(commandAdd.ExecuteScalar());

                //Вывод добавленной строки
                OutputByID(lastID);
            }

        }
        //////////////////////

        //Вывод в таблицу по ID
        private async void OutputByID(int lastID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Test] WHERE id=" + Convert.ToString(lastID), sqlConnection);
            SqlDataReader sqlReader = null;

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    dataGridView.Rows.Add(Convert.ToString(sqlReader["id"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Work"]), Convert.ToString(sqlReader["Date"]));
                }
            }
            catch (Exception ex)
            {

            }
            if (sqlReader != null)
                sqlReader.Close();
        }/////////////////////





        //Обновление в таблице и в бд
        private async void DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (RowIndex >= dataGridView.Rows.Count) //срабатывает после удаления последней строки
            {
                CurrentCellText = Convert.ToString(dataGridView.CurrentCell.Value);
                RowIndex = dataGridView.CurrentCell.RowIndex;
                ColumnIndex = dataGridView.CurrentCell.ColumnIndex;
            }
            String temp = Convert.ToString(dataGridView[ColumnIndex, RowIndex].Value);
            if (CurrentCellText != temp)
            {
                if (temp == "") //проверка на пустоту строки
                {
                    dataGridView[ColumnIndex, RowIndex].Value = CurrentCellText;
                }
                else if (Convert.ToString(dataGridView[0, RowIndex].Value) == "") //проверка id
                {
                    // добавление в бд (сделать)
                }
                else //изменение в бд
                {
                    SqlCommand command = null;
                    switch (ColumnIndex)
                    {
                        case 1: //Имя
                            command = new SqlCommand("UPDATE [Test] SET [Name] = @Name WHERE [Id] = @Id", sqlConnection);
                            command.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView[0, RowIndex].Value));
                            command.Parameters.AddWithValue("Name", temp);
                            break;
                        case 2://Работа
                            command = new SqlCommand("UPDATE [Test] SET [Work] = @Work WHERE [Id] = @Id", sqlConnection);
                            command.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView[0, RowIndex].Value));
                            command.Parameters.AddWithValue("Work", temp);
                            break;
                        case 3://Дата
                            command = new SqlCommand("UPDATE [Test] SET [Date] = @Date WHERE [Id] = @Id", sqlConnection);
                            command.Parameters.AddWithValue("id", Convert.ToInt32(dataGridView[0, RowIndex].Value));
                            command.Parameters.AddWithValue("Date", temp);
                            break;

                    }
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentCellText = Convert.ToString(dataGridView.CurrentCell.Value);
            RowIndex = dataGridView.CurrentCell.RowIndex;
            ColumnIndex = dataGridView.CurrentCell.ColumnIndex;
        }/////////////////////////////////////////

        //Контекстное меню
        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.ContextMenuStrip = contextMenuStrip1;
        }

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Test] WHERE [Id] = @Id", sqlConnection);
            command.Parameters.AddWithValue("@Id", dataGridView[0, RowIndex].Value);
            command.ExecuteNonQuery();

            dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);//удалене строки
        }
    }
    
}

