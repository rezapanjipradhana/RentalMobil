using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //variabel untuk proses
        long biaya_per_jam;
        short waktu;
        String mobil;
        DateTime tanggal_pinjam;
        DateTime tanggal_kembali;


        private void cbmobil_SelectedIndexChanged(object sender, EventArgs e){

            mobil = Convert.ToString(cbmobil.SelectedItem);

            if (mobil == "Avanza"){
                txtbiaya.Text = Convert.ToString(400000);
            }else if (mobil == "Xenia"){
                txtbiaya.Text = Convert.ToString(400000);
            }else if (mobil == "APV"){
                txtbiaya.Text = Convert.ToString(450000);
            }else if (mobil == "Innova"){
                txtbiaya.Text = Convert.ToString(500000);
            }else if (mobil == "Alphard"){
                txtbiaya.Text = Convert.ToString(1000000);
            }

        }

        private void tmpinjam_ValueChanged(object sender, EventArgs e){

            
        }

        private void btnhitung_Click(object sender, EventArgs e){

            if (Int64.TryParse(txtbiaya.Text, out biaya_per_jam) && Int16.TryParse(txtdurasi.Text, out waktu)){
                txtbayar.Text = "Rp. " + Convert.ToString(biaya_per_jam * waktu) + ",-";
            }
        }

        private void tmkembali_ValueChanged(object sender, EventArgs e){

            tanggal_pinjam = tmpinjam.Value.Date + twpinjam.Value.TimeOfDay;
            tanggal_kembali = tmkembali.Value.Date + twkembali.Value.TimeOfDay;

            if (tanggal_kembali < tanggal_pinjam){
                MessageBox.Show("Tanggal yang anda masukan salah");
            }else{
                TimeSpan temp = tanggal_kembali - tanggal_pinjam;
                txtdurasi.Text = Convert.ToString(Math.Round(temp.TotalHours));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
