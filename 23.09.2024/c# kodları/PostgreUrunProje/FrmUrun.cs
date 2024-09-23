using Dapper;
using Npgsql;
using PostgreUrunProje.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreUrunProje
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private string baglanti = "server=localHost;port=5432;Database=dbUrunler;user Id=postgres;password=orjinaladam_96;";

        private async void btnListele_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var result = await connection.QueryAsync<Urun>("select * from urunler;");
            var data = result.ToList();
            dataGridView1.DataSource = data;

        }

        private async void FrmUrun_Load(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var kategoriler = await connection.QueryAsync<Kategori>("select * from kategoriler;");
            var data = kategoriler.ToList();
            comboBox1.DisplayMember = "ad";
            comboBox1.ValueMember = "id";
            comboBox1.DataSource = data;
        }

        private async void btnEkle_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var dictionary = new Dictionary<string, object>()
            {
                { "@id", Convert.ToInt32(txtUrunId.Text) },
                { "@ad", txtUrunAd.Text },
                { "@stok", Convert.ToInt32(stok.Value) },
                { "@alis", Convert.ToDouble(txtAlisFiyat.Text) },
                { "@satis", Convert.ToDouble(txtSatisFiyat.Text) },
                { "@gorsel", txtGorsel.Text },
                { "@kategori", Convert.ToInt32(comboBox1.SelectedValue.ToString()) },
            };
            var parameters = new DynamicParameters(dictionary);
            var result = await connection.ExecuteAsync("insert into urunler values(@id,@ad,@stok,@alis,@satis,@gorsel,@kategori)", parameters);
            if (result > 0)
            {
                MessageBox.Show("Ürün kaydı başarılı.");
            }
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var dictionary = new Dictionary<string, object>()
            {
                { "@id", Convert.ToInt32(txtUrunId.Text) }
            };
            var parameters = new DynamicParameters(dictionary);
            var result = await connection.ExecuteAsync("delete from urunler where urunid=@id", parameters);
            if (result > 0)
            {
                MessageBox.Show("Silme işlemi başarılı");
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var dictionary = new Dictionary<string, object>()
            {
                { "@id", Convert.ToInt32(txtUrunId.Text) },
                { "@ad", txtUrunAd.Text },
                { "@stok", Convert.ToInt32(stok.Value) },
                { "@alis", Convert.ToDecimal(txtAlisFiyat.Text) }

            };
            var parameters = new DynamicParameters(dictionary);
            var result = await connection.ExecuteAsync("update urunler set urunad=@ad, stok=@stok, alisfiyat=@alis where urunid=@id", parameters);
            if (result > 0)
            {
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
        }

        private async void btnView_Click(object sender, EventArgs e)
        {
            await using var connection = new NpgsqlConnection(baglanti);
            var result = await connection.QueryAsync("select * from urunlerigetir");
            var data = result.ToList();
            dataGridView1.DataSource = data;
        }
    }
}
