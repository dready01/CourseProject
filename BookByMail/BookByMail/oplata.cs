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
    public partial class oplata : Form
    {
        SqlConnection sqlConnection;
        public oplata()
        {
            InitializeComponent();
        }

        private async void oplata_Load(object sender, EventArgs e)
        {
           
            string conectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(conectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("select * from Пользователи where Пользователи.Логин=@login", sqlConnection);
            sqlCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = oplataLogin.Text;
            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    
                    OplataAdressTextBox.Text=Convert.ToString(sqlDataReader["Адрес"]);
                    OplataMailTextBox.Text= Convert.ToString(sqlDataReader["Почта"]);
                    OplataPhoneTextBox.Text= Convert.ToString(sqlDataReader["Телефон"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                    sqlDataReader.Close();

            }
        }

        private void Oplatabutton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            string commandText = "INSERT Заказы(Логин, Дата, Название,[Количество книг],Цена) SELECT Логин, @date, [Название книги],[Количество книг],Цена FROM Корзина where Корзина.Логин=@login delete from Корзина where Логин=@login";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            MyCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = oplataLogin.Text;
            MyCommand.Parameters.Add("@date", SqlDbType.Date).Value = date;

            int UspeshnoeIzmenenie = MyCommand.ExecuteNonQuery();
            if (UspeshnoeIzmenenie != 0)
            {
                MessageBox.Show("Оплата прошла успешна");

            }
            else
            {
                MessageBox.Show("Не все поля были заполнены");

            }
            conn.Close();
        }
    }
}
