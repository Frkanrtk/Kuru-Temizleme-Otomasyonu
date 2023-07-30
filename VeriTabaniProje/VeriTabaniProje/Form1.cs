using System.Data;
using System.Data.SqlClient;

namespace veriTabaniProje
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }
        void MusteriGetir()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Musteri", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Musteri", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            string Sorgu = "INSERT INTO dbo.Musteri(Ad, Soyad, Telefon, [E-Mail], Adres) VALUES (@ad, @soyad, @telefon, @email, @adres)";
            SqlCommand komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@email", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            string Sorgu = "DELETE FROM dbo.Musteri WHERE Ad = @ad and Soyad = @soyad";
            SqlCommand komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            string Sorgu = "UPDATE dbo.Musteri SET Ad = @ad, Soyad = @soyad, Telefon = @telefon , [E-Mail] = @email, Adres = @adres WHERE MusteriID = @mid";
            SqlCommand komut = new SqlCommand(Sorgu, baglanti);
            komut.Parameters.AddWithValue("@mid", textBox6.Text);
            komut.Parameters.AddWithValue("@ad", textBox1.Text);
            komut.Parameters.AddWithValue("@soyad", textBox2.Text);
            komut.Parameters.AddWithValue("@telefon", textBox3.Text);
            komut.Parameters.AddWithValue("@email", textBox4.Text);
            komut.Parameters.AddWithValue("@adres", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.UrunHamMadde", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.FaturaTuru", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Fatura", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.IslemTarihi", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Odeme", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.OdemeTuru", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.UrunTuru", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.YapilanIslem", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.Urun", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=FURKAN\SQLEXPRESS;Initial Catalog=kuruTemizleme;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM dbo.IslemTuru", baglanti);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
            baglanti.Close();
        }
    }
}