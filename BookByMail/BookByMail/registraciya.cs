using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookByMail
{
    public partial class registraciya : Form
    {
        public registraciya()
        {
            InitializeComponent();
        }
       
        private void registrbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckUser())
                    return;
                string RegLogin = Convert.ToString(RegistrLoginField.Text);
                string RegPassword = Convert.ToString(RegistrPasswordField.Text);
                string RegNameUser = Convert.ToString(RegistrNameField.Text);
                string RegSurname = Convert.ToString(RegistrSurnameField.Text);
                string RegMiddleName = Convert.ToString(RegistrMiddlenameField.Text);
                string RegPhone = Convert.ToString(RegistrPhoneField.Text);
                string RegMail = Convert.ToString(RegistrMailField.Text);
                string RegAddres = Convert.ToString(RegistrAddressField.Text);
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "INSERT INTO Пользователи(Логин,Пароль,Фамилия,Имя,Отчество,Телефон,Почта,Адрес)VALUES(@RegLog, @RegPass, @RegSurName, @RegName, @RegMiddle, @RegPhone, @RegMail, @RegAddres)";
                myCommand.Parameters.Add("@RegLog", SqlDbType.VarChar).Value = RegLogin;
                myCommand.Parameters.Add("@RegPass", SqlDbType.VarChar).Value = RegPassword;
                myCommand.Parameters.Add("@RegSurName", SqlDbType.VarChar).Value = RegSurname;
                myCommand.Parameters.Add("@RegName", SqlDbType.VarChar).Value = RegNameUser;
                myCommand.Parameters.Add("@RegMiddle", SqlDbType.VarChar).Value = RegMiddleName;
                myCommand.Parameters.Add("@RegPhone", SqlDbType.VarChar).Value = RegPhone;
                myCommand.Parameters.Add("@RegMail", SqlDbType.VarChar).Value = RegMail;
                myCommand.Parameters.Add("@RegAddres", SqlDbType.VarChar).Value = RegAddres;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Аккаунт создан,регистрация прошла успешна");
                   
                   
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");

                }
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void RegistrFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrFormClose_MouseEnter(object sender, EventArgs e)
        {
            RegistrFormClose.ForeColor = Color.Black;
            RegistrFormClose.BackColor = Color.Red;
        }

        private void RegistrFormClose_MouseLeave(object sender, EventArgs e)
        {
            RegistrFormClose.ForeColor = Color.White;
            RegistrFormClose.BackColor = Color.MidnightBlue;
        }
        
        public Boolean CheckUser()
        {
            string connectString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection myConnection = new SqlConnection(connectString);
            myConnection.Open();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("select *from Пользователи where Логин = @LogUser", myConnection);
            command.Parameters.Add("@LogUser", SqlDbType.VarChar).Value = RegistrLoginField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с этим логином существует");
                return true;
            }
            else
            {
                return false;
            }
        }
        Point LastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
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
