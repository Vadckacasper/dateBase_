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
    public partial class FormLoginPassword : Form
    {
        SqlConnection sqlConnection;
        String stringConnection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=first_dataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public FormLoginPassword()
        {
            InitializeComponent();
        }

        private void TextBoxLogin_Enter(object sender, EventArgs e)
        {
            if (this.textBoxLogin.Text == "Login")
            {
                this.textBoxLogin.Text = "";
                this.textBoxLogin.ForeColor = Color.Black;
            }
        }

        private void TextBoxPassword_Click(object sender, EventArgs e)
        {
            if(this.textBoxPassword.Text == "Password")
            {
                this.textBoxPassword.Text = "";
                this.textBoxPassword.ForeColor = Color.Black;
                this.textBoxPassword.PasswordChar = '*';
            }
        }

        private void LabelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LabelClose_MouseEnter(object sender, EventArgs e)
        {
            this.labelClose.ForeColor = Color.Black;
        }

        private void LabelClose_MouseLeave(object sender, EventArgs e)
        {
            this.labelClose.ForeColor = Color.DimGray;
        }

        Point lastPoint;
        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool success = false;
            bool temp = false;
            try
            {
                sqlConnection = new SqlConnection(stringConnection);
                SqlCommand command = new SqlCommand("SELECT * FROM [Log in] WHERE Login = @Login AND Password = @Password", sqlConnection);
                command.Parameters.AddWithValue("@Login", textBoxLogin.Text);
                command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
                sqlConnection.Open();

                using (var dataReader = command.ExecuteReader())
                {
                    success = dataReader.Read();
                    if (success)
                    temp = Convert.ToBoolean(dataReader["AccessTest"]);

                }
            }
            finally
            {
                sqlConnection.Close();
            }
            
            if (success)
            {
                if (temp)
                {
                    Form1 form1 = new Form1();
                    Hide();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    form1.ShowDialog();
                    this.Visible = true;
                }
                else
                {
                    FormWork form1 = new FormWork(textBoxLogin.Text);
                    Hide();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    form1.ShowDialog();
                    this.Visible = true;
                }
                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }

        }
    }
}
