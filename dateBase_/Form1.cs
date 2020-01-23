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
            listBox_Wiew.Items.Add("Id\t" + "Name\t\t\t\t" + "Work\t\t\t" + "Date");
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
    }
}
