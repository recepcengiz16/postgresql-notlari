using Dapper;
using Npgsql;
using PostgreUrunProje.Models;

namespace PostgreUrunProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string baglanti = "server=localHost;port=5432;Database=dbUrunler;user Id=postgres;password=orjinaladam_96;";

        private async void btnListele_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var result = await connection.QueryAsync<Kategori>("select * from kategoriler;");
            var data = result.ToList();
            dataGridView1.DataSource = data;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var dictionary = new Dictionary<string, object>()
            {
                { "@id", Convert.ToInt32(txtkategoriId.Text) },
                { "@ad", txtKategoriAd.Text },
            };
            var parameters = new DynamicParameters(dictionary);
            var result = await connection.ExecuteAsync("insert into kategoriler values(@id,@ad)", parameters);
            if (result > 0)
            {
                txtkategoriId.Text = "";
                txtKategoriAd.Text = "";
                MessageBox.Show("Kategori baþarýlý bir þekilde eklendi");
            }
        }

       
    }
}
