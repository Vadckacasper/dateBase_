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
                    dataGridView.Rows.Add(Convert.ToString(sqlReader["Login"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["Paul"]), Convert.ToString(sqlReader["Age"]), Convert.ToString(sqlReader["Position"]), Convert.ToString(sqlReader["Date"]), Convert.ToString(sqlReader["id"]));
                    }
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



        //Вывод в таблицу по ID
        private async void OutputByID(string lastID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Log in] WHERE Login = @Login" , sqlConnection);
            SqlDataReader sqlReader = null;
            command.Parameters.AddWithValue("Login", Convert.ToString(lastID));
            try
            {
                sqlReader = await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    dataGridViewLog.Rows.Add(Convert.ToString(sqlReader["Login"]), Convert.ToString(sqlReader["Password"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["AccessTest"]));
                }
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
                textBoxLog.Text = "";
                textBoxPass.Text = "";
                textBoxName.Text = "";
                textBoxAss.Text = "";
            }
        }/////////////////////



        //Контекстное меню

        private void УдалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM [Log in] WHERE [Login] = @Login", sqlConnection);
            command.Parameters.AddWithValue("@Login", dataGridViewLog[0, RowIndex].Value);
            command.ExecuteNonQuery();

            dataGridViewLog.Rows.RemoveAt(dataGridViewLog.CurrentCell.RowIndex);//удалене строки
        }

        bool flag = true;//переделать
        private async void TabControl1_Click(object sender, EventArgs e)
        {
            
            if (tabControl1.SelectedTab.Text == "Log in" && flag)
            {
                flag = false;
                SqlDataReader sqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Log in]", sqlConnection);
                try
                {
                    sqlReader = await command.ExecuteReaderAsync();

                    while (await sqlReader.ReadAsync())
                    {
                       dataGridViewLog.Rows.Add(Convert.ToString(sqlReader["Login"]), Convert.ToString(sqlReader["Password"]), Convert.ToString(sqlReader["Name"]), Convert.ToString(sqlReader["AccessTest"]));
                    }
                    CurrentCellText = Convert.ToString(dataGridViewLog.CurrentCell.Value);
                    RowIndex = dataGridViewLog.CurrentCell.RowIndex;
                    ColumnIndex = dataGridViewLog.CurrentCell.ColumnIndex;

                }
                finally
                {
                    if (sqlReader != null)
                        sqlReader.Close();
                }
            }
        }

        private async void DataGridViewLog_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (RowIndex >= dataGridViewLog.Rows.Count) //срабатывает после удаления последней строки
            {
                CurrentCellText = Convert.ToString(dataGridViewLog.CurrentCell.Value);
                RowIndex = dataGridViewLog.CurrentCell.RowIndex;
                ColumnIndex = dataGridViewLog.CurrentCell.ColumnIndex;
            }
            String temp = Convert.ToString(dataGridViewLog[ColumnIndex, RowIndex].Value);
            if (CurrentCellText != temp)
            {
                if (temp == "") //проверка на пустоту строки
                {
                    dataGridViewLog[ColumnIndex, RowIndex].Value = CurrentCellText;
                }
                else //изменение в бд
                {
                    SqlCommand command = null;
                    switch (ColumnIndex)
                    {
                        case 1: //пароль
                            command = new SqlCommand("UPDATE [Log in] SET [Password] = @Password WHERE [Login] = @Login", sqlConnection);
                            command.Parameters.AddWithValue("Login", Convert.ToString(dataGridViewLog[0, RowIndex].Value));
                            command.Parameters.AddWithValue("Password", temp);
                            break;
                        case 2://Имя
                            command = new SqlCommand("UPDATE [Log in] SET [Name] = @Name WHERE [Login] = @Login", sqlConnection);
                            command.Parameters.AddWithValue("Login", Convert.ToString(dataGridViewLog[0, RowIndex].Value));
                            command.Parameters.AddWithValue("Name", temp);
                            break;
                        case 3://Доступ
                            command = new SqlCommand("UPDATE [Log in] SET [AccessTest] = @AccessTest WHERE [Login] = @Login", sqlConnection);
                            command.Parameters.AddWithValue("Login", Convert.ToString(dataGridViewLog[0, RowIndex].Value));
                            if (temp == "1" || temp == "True" || temp == "true")
                            {
                                command.Parameters.AddWithValue("AccessTest", true);
                                dataGridViewLog[ColumnIndex, RowIndex].Value = "True";
                            }
                            else
                            {
                                command.Parameters.AddWithValue("AccessTest", false);
                                dataGridViewLog[ColumnIndex, RowIndex].Value = "False";
                            }
                            break;

                    }
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        private void DataGridViewLog_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            CurrentCellText = Convert.ToString(dataGridViewLog.CurrentCell.Value);
            RowIndex = dataGridViewLog.CurrentCell.RowIndex;
            ColumnIndex = dataGridViewLog.CurrentCell.ColumnIndex;
        }

        private void DataGridViewLog_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.ContextMenuStrip = contextMenuStrip1;
        }

        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            labelErorr.Visible = false;
            if (!CheckLogin(textBoxLog.Text)) //проверка логина
            if (textBoxLog.Text == "" || textBoxPass.Text == "" || textBoxName.Text == "" || textBoxAss.Text == "")
            {
                labelErorr.Text = "Для добавление в базу, все поля должны быть заполнены!";
                labelErorr.Visible = true;
            }
            else
            {
                labelErorr.Visible = false;
                SqlCommand commandAdd = new SqlCommand("INSERT INTO [Log in] (Login, Password, Name, AccessTest)VALUES(@Login, @Password, @Name, @AccessTest)", sqlConnection);
                commandAdd.Parameters.AddWithValue("Login", textBoxLog.Text);
                commandAdd.Parameters.AddWithValue("Password", textBoxPass.Text);
                commandAdd.Parameters.AddWithValue("Name", textBoxName.Text);
                if (textBoxAss.Text == "1" || textBoxAss.Text == "True" || textBoxAss.Text == "true")
                {
                    commandAdd.Parameters.AddWithValue("AccessTest", true);
                }
                else
                {
                    commandAdd.Parameters.AddWithValue("AccessTest", false);
                }

                await commandAdd.ExecuteNonQueryAsync();
                string lastID = textBoxLog.Text;

                //Вывод добавленной строки
                OutputByID(lastID);
            }
        }

        private bool CheckLogin(string login)//Проверка логина на существование в бд
        {
            bool success = false;
            try
            {
                SqlCommand command = new SqlCommand("SELECT [Login] FROM [Log in] WHERE Login = @Login ", sqlConnection);
                command.Parameters.AddWithValue("@Login", login);

                using (var dataReader = command.ExecuteReader())
                {
                    success = dataReader.Read();
                }
            }
            finally
            {
                if (success)
                {
                    labelErorr.Text = "Логин уже существует!";
                    labelErorr.Visible = true;
                }
            }
            return success;
        }
        
    }
}

