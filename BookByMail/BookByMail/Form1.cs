using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookByMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void registrbutton_Click(object sender, EventArgs e)
        {
            registraciya reg = new registraciya();
            reg.ShowDialog();
        }

        private void SignInbutton_Click(object sender, EventArgs e)
        {
            
            string connectString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            string LogUser = LoginField.Text;
            string PassUser = PasswordField.Text;
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select *from Пользователи where Логин = @LogUser and Пароль = @PassUser", myConnection);
            command.Parameters.Add("@LogUser", SqlDbType.VarChar).Value = LogUser;
            command.Parameters.Add("@PassUser", SqlDbType.VarChar).Value = PassUser;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count>0)
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.LabelNick.Text = LoginField.Text;
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }
           

            

        }
        ///Дизайн
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
            label1.BackColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
            label1.BackColor = Color.MidnightBlue;
        }
        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }
    }
}
