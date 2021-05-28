using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exсel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Reflection;

namespace BookByMail
{
    public partial class admin : Form
    {
        private void ShowTable()
        {
            string commandText = "SELECT * FROM [Католог книг]";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "[Католог книг]");
            dataGridView2.DataSource = ds.Tables["[Католог книг]"].DefaultView;
            conn.Close();

        }
        private void ShowTableZakazi()
        {
            string commandText = "select Заказы.Название, count(Заказы.Название) as [Количество книг] from Заказы  group by Заказы.Название order by count(Заказы.Название) desc ";
            string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            SqlCommand MyCommand = new SqlCommand();
            MyCommand.Connection = conn;
            MyCommand.CommandText = commandText;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = MyCommand;
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Заказы");
            datastat.DataSource = ds.Tables["Заказы"].DefaultView;
            conn.Close();
        }
        public admin()
        {
            InitializeComponent();
            ShowTable();
            ShowTableZakazi();
        }
        
        private void admin_Load(object sender, EventArgs e)
        {

        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                int ID = int.Parse(AdminDeleteId.Text);
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "delete from [Католог книг] where [Католог книг].[ID книги]=@id";
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                    ShowTable();
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

        private void EdditButton_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = int.Parse(AdminIdTexbox.Text);
                int Price= int.Parse(AdminPriceTextbox.Text);
                int kolvo= int.Parse(AdminKolvoTextbox.Text);
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "UPDATE [Католог книг] SET  Цена = @price ,[Количество книг]=@kolvo WHERE [ID книги]=@id";
                myCommand.Parameters.Add("@price", SqlDbType.Int).Value = Price;
                myCommand.Parameters.Add("@kolvo", SqlDbType.Int).Value = kolvo;
                myCommand.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                    ShowTable();
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string NameBook = Convert.ToString(AdminAddNamebookTextbox.Text);
                string Author= Convert.ToString(AdminAddAuthorTextbox.Text);
                int Price = int.Parse(AdminAddPriceTextbox.Text);
                int kolvo = int.Parse(AdminAddKolvoTextbox.Text);
                string Opisanie = Convert.ToString(AdminAddOpisanieTextbox.Text);
                string ConnectionString = "Server=localhost;Database=master;Trusted_Connection=True;";
                SqlConnection conn = new SqlConnection(ConnectionString);
                conn.Open();
                SqlCommand myCommand = conn.CreateCommand();
                myCommand.CommandText = "INSERT INTO [Католог книг]([Название книги],[Автор книги],Цена,[Количество книг],Описание)VALUES(@NameBook, @Author, @Price, @Kolvo, @Opisanie)";
                myCommand.Parameters.Add("@Namebook", SqlDbType.VarChar).Value = NameBook;
                myCommand.Parameters.Add("@Author", SqlDbType.VarChar).Value = Author;
                myCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Price;
                myCommand.Parameters.Add("@Kolvo", SqlDbType.Int).Value = kolvo;
                myCommand.Parameters.Add("@Opisanie", SqlDbType.VarChar).Value = Opisanie;
                int UspeshnoeIzmenenie = myCommand.ExecuteNonQuery();
                if (UspeshnoeIzmenenie != 0)
                {
                    MessageBox.Show("Изменения внесены", "Изменение записи");
                    AdminAddNamebookTextbox.Clear();
                    AdminAddAuthorTextbox.Clear();
                    AdminAddPriceTextbox.Clear();
                    AdminAddKolvoTextbox.Clear();
                    AdminAddOpisanieTextbox.Clear();
                    ShowTable();
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

        private void reportbutton_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            for (int i = 0; i < datastat.ColumnCount; i++)
            {
                for (int j = 0; j < datastat.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (datastat[i, j].Value).ToString();
                }

            }
            ExcelApp.Visible = true;
        }
       
    }
}
