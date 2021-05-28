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
    public partial class MainForm : Form
    {
        private void ShowTableKorzina()
        {
            string commandText = "select Корзина.[Название книги],Корзина.[Количество книг],Корзина.Цена from Корзина where Корзина.Логин=@login";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            MyCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = LabelNick.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Католог книг]");
            dataGridView2.DataSource = ds.Tables["[Католог книг]"].DefaultView;
            conn.Close();

        }
        SqlConnection sqlConnection;
        public MainForm()
        {
            InitializeComponent();
        }
        ///////загрузка списка книг
        private async void MainForm_Load(object sender, EventArgs e)
        {
            if (LabelNick.Text=="Admin")
            {
                adminFormButton.Visible = true;
            }

            string conectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(conectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("select * from [Католог книг]", sqlConnection);
            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    listBox1.Items.Add((Convert.ToString(sqlDataReader["Название книги"])));
                    
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
        
        ///Добавить в корзину
        private void button1_Click(object sender, EventArgs e)
        {
            if (kolvotextbox.Text!="")
            {


                int indexbook = listBox1.SelectedIndex;
                string namebooklistbox = (string)listBox1.Items[indexbook];
                string commandText = "INSERT Корзина(Логин, [Название книги], [Количество книг],Цена) SELECT @login,[Название книги],@kol,Цена*@kol FROM [Католог книг] where [Католог книг].[Название книги]=@namebook update [Католог книг] set [Количество книг]=[Количество книг]-@kol where [Католог книг].[Название книги]=@namebook";
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand MyCommand = new SqlCommand();
                MyCommand.Connection = conn;
                MyCommand.CommandText = commandText;
                MyCommand.Parameters.Add("@namebook", SqlDbType.VarChar).Value = namebooklistbox;
                MyCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = LabelNick.Text;
                MyCommand.Parameters.Add("@kol", SqlDbType.VarChar).Value = kolvotextbox.Text;
                int UspeshnoeIzmenenie = MyCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Книга добавлена в корзину");
                    kolvotextbox.Clear();
                }
                else
                {
                    MessageBox.Show("Не удалось внести изменения", "Изменение записи");

                }
                conn.Close();
            }
            else
            {
                MessageBox.Show(" Выбирете книгу и напишите количество книг");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void adminFormButton_Click(object sender, EventArgs e)
        {
            admin adminForm = new admin();
            adminForm.ShowDialog();
        }
        
        ///подробнее о книге
        private async void button2_Click(object sender, EventArgs e)
        {
            int indexbook = listBox1.SelectedIndex;
            string namebooklistbox = (string)listBox1.Items[indexbook];
            string commandText = "select [Католог книг].[Название книги],[Католог книг].[Автор книги],[Католог книг].Цена from [Католог книг] where [Католог книг].[Название книги]=@namebook";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            MyCommand.Parameters.Add("@namebook", SqlDbType.VarChar).Value = namebooklistbox;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Католог книг]");
            dataGridView1.DataSource = ds.Tables["[Католог книг]"].DefaultView;

            sqlConnection = new SqlConnection(ConnectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader sqlDataReader = null;
            SqlCommand sqlCommand = new SqlCommand("select Описание from [Католог книг] where [Католог книг].[Название книги]=@namebook", sqlConnection);
            sqlCommand.Parameters.Add("@namebook", SqlDbType.VarChar).Value = namebooklistbox;
            try
            {
                sqlDataReader = await sqlCommand.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {

                    opisaniebox.Text = Convert.ToString(sqlDataReader["Описание"]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }
        
        ///обновить корзину
        private void button3_Click(object sender, EventArgs e)
        {
            ShowTableKorzina();
            double balans = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                double incom;
                double.TryParse((row.Cells[2].Value ?? "0").ToString().Replace(".", ","), out incom);
                balans += incom;
            }
            label4.Text = balans.ToString();
        }

        private void OplataButton_Click(object sender, EventArgs e)
        {
            oplata oplata = new oplata();
            oplata.oplataLogin.Text = LabelNick.Text;
            oplata.ShowDialog();
        }

        private void LabelNick_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void DeleteKorzinaButton_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                string cmd_text;
                int index;
                string num_book;
                index = dataGridView2.CurrentRow.Index;
                num_book = Convert.ToString(dataGridView2[0, index].Value);
                cmd_text = "DELETE FROM Корзина  where [Название книги]= '" + num_book + "'";
                SqlConnection sql_conn = new SqlConnection(ConnectionString);
                SqlCommand sql_comm = new SqlCommand(cmd_text, sql_conn);
                sql_conn.Open();
                sql_comm.ExecuteNonQuery();
                sql_conn.Close();
                MessageBox.Show("книга удалена");
                ShowTableKorzina();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка удаления");
            }
        }

        private void HistoryButton_Click(object sender, EventArgs e)
        {
            string commandText = "select Заказы.Дата, Заказы.Название,Заказы.[Количество книг],Заказы.Цена from Заказы where Заказы.Логин=@login";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            MyCommand.Parameters.Add("@login", SqlDbType.VarChar).Value = LabelNick.Text;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Заказы]");
            dataGridView3.DataSource = ds.Tables["[Заказы]"].DefaultView;
            conn.Close();
        }
    }
}
