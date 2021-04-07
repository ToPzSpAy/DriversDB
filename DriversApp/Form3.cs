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
using System.Diagnostics;


namespace DriversApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewPerson2 frm = new NewPerson2();
            frm.Show();
        }

        SqlConnection sqlConnection;

        private async void Form3_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView3.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();

            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Drivers;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [Amogus]", sqlConnection);

            List<string[]> data = new List<string[]>();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[12]);

                    for (int i = 0; i < 12; i++)
                    {
                        data[data.Count - 1][i] = sqlReader[i].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            dataGridView1.Columns.Add("column", "ID");
            dataGridView1.Columns.Add("column", "Имя");
            dataGridView1.Columns.Add("column", "Отчество");
            dataGridView1.Columns.Add("column", "Паспорт");
            dataGridView1.Columns.Add("column", "Индекс");
            dataGridView1.Columns.Add("column", "Адрес");
            dataGridView1.Columns.Add("column", "Город");
            dataGridView1.Columns.Add("column", "Компания");
            dataGridView1.Columns.Add("column", "Должность");
            dataGridView1.Columns.Add("column", "Телефон");
            dataGridView1.Columns.Add("column", "Почта");
            dataGridView1.Columns.Add("column", "Фото");
            
            dataGridView1.AutoResizeColumns();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

            command = new SqlCommand("SELECT * FROM [driver_licence]", sqlConnection);

            data = new List<string[]>();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[7]);

                    for (int i = 0; i < 7; i++)
                    {
                        data[data.Count - 1][i] = sqlReader[i].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            dataGridView2.Columns.Add("column", "ID");
            dataGridView2.Columns.Add("column", "Дата лизенции");
            dataGridView2.Columns.Add("column", "Годен до");
            dataGridView2.Columns.Add("column", "Категория");
            dataGridView2.Columns.Add("column", "Серия лицензии");
            dataGridView2.Columns.Add("column", "Лицензионный номер");
            dataGridView2.Columns.Add("column", "Статус");
            foreach (string[] s in data)
                dataGridView2.Rows.Add(s);

            command = new SqlCommand("SELECT * FROM [auto]", sqlConnection);

            data = new List<string[]>();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[8]);

                    for (int i = 0; i < 8; i++)
                    {
                        data[data.Count - 1][i] = sqlReader[i].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
            dataGridView3.Columns.Add("column", "ID");
            dataGridView3.Columns.Add("column", "VIN");
            dataGridView3.Columns.Add("column", "Монуфактура");
            dataGridView3.Columns.Add("column", "Модель");
            dataGridView3.Columns.Add("column", "Год");
            dataGridView3.Columns.Add("column", "Масса");
            dataGridView3.Columns.Add("column", "Цвет");
            dataGridView3.Columns.Add("column", "Тип двигателя");
            foreach (string[] s in data)
                dataGridView3.Rows.Add(s);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Drivers;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();

            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM [licence]", sqlConnection);

            List<string[]> data = new List<string[]>();

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[12]);

                    for (int i = 0; i < 24; i++)
                    {
                        data[data.Count - 1][i] = sqlReader[i].ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }

            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e) // правильное закрытие приложения
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e) 
        {
            Form3 frm = new Form3();
            frm.Show(this);
        }

        private  async void PicSave_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlReader = null;

            SqlCommand command = new SqlCommand("SELECT * FROM Amogus as t1 LEFT JOIN driver_licence as t2 on t1.id = t2.id WHERE t1.id =" + IDbox.Text, sqlConnection);

            try
            {
                sqlReader = await command.ExecuteReaderAsync();

                while (await sqlReader.ReadAsync())
                {
                    string name = Convert.ToString(sqlReader["name"]);
                    string middlename = Convert.ToString(sqlReader["middlename"]);
                    string address_life = Convert.ToString(sqlReader["address_life"]);
                    string licence_date = Convert.ToString(sqlReader["licence_date"]);
                    string expire_date = Convert.ToString(sqlReader["expire_date"]);
                    string licence_series = Convert.ToString(sqlReader["licence_series"]);
                    string licence_number = Convert.ToString(sqlReader["licence_number"]);
                    string categories = Convert.ToString(sqlReader["categories"]);
                    string Status = Convert.ToString(sqlReader["Status"]);

                    int r=0, g=0, b=0;

                    switch (Status) //определение цвета индекатора
                    {
                        case "Active":
                            r = 0; g = 255; b = 0;
                            break;
                        case "Paused":
                            r = 255; g = 0; b = 0;
                            break;
                        case "Withdrawn":
                            r = 255; g = 0; b = 0;
                            break;
                        case "Expire":
                            r = 128; g = 128; b = 128;
                            break;
                        default:
                            r = 0; g = 0; b = 0;
                            break;

                    }


                    Image a = Image.FromFile(@"driver_license_template.jpg"); //получаем исходное изображение из файла 
                    Graphics part = Graphics.FromImage(a); //получаем его часть
                    part.DrawString(middlename + "\n" + name + "\n\n" + address_life + "\n\n" + licence_date + "                   " + expire_date + "\n\n" + licence_series + " " + licence_number + "\n\n" + address_life + "\n \n" + categories,
                    new System.Drawing.Font("Arial", 27, FontStyle.Bold),
                    new SolidBrush(Color.Black), new RectangleF(370, 220, 0, 0),
                    new StringFormat(StringFormatFlags.NoWrap)); // наносим на эту часть текст с параметрами
                    Image img = Image.FromFile("photo//" + Convert.ToString(sqlReader["photo"])); // берём исходник
                    part.DrawImage(img, 80, 265, img.Width / 3, img.Height / 3); // наносим фото
                    part.FillRectangle(new SolidBrush(Color.FromArgb(r,g,b)), 880, 550, 80, 80); // наносим индикатор
                    a.Save("save\\test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);//записываем получающееся изображение в файл 


                    DialogResult result = MessageBox.Show("водительское удостоверение создано. Открыть папку файла?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                        Process.Start("save\\");
                    
                    break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPersonDL frm = new NewPersonDL();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewPersonAuto frm = new NewPersonAuto();
            frm.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }
    }
}
