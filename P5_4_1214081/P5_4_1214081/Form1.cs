using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P5_4_1214081
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            //Jadwal
            if (radioButton1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00 - 16.00";
            }
            else if (radioButton2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00 - 16.00";
            }
            else if (radioButton3.Checked)
            {
                jadwal = "Sabtu & Minggu, 09.00 - 11.00";
            }
            else if (radioButton4.Checked)
            {
                jadwal = "Minggu, 13.00 - 17.00";
            }

            //Kelas
            if (checkBoxBiola.Checked)
            {
                kelas = kelas + "Biola, ";

            }
            if (checkBoxDrum.Checked)
            {
                kelas = kelas + "Drum, ";
            }
            if (checkBoxGitar.Checked)
            {
                kelas = kelas + "Gitar, ";
            }
            if (checkBoxKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (checkBoxKonduktor.Checked)
            {
                kelas = kelas + "Konduktor, ";
            }
            if (checkBoxKomposer.Checked)
            {
                kelas = kelas + "Komposer, ";
            }
            if (checkBoxPiano.Checked)
            {
                kelas = kelas + "Piano, ";
            }
            if (checkBoxSaxophone.Checked)
            {
                kelas = kelas + "Saxophone, ";
            }
            if (checkBoxVokal.Checked)
            {
                kelas = kelas + "Vokal, ";
            }
            else
            {
                
            }

            //Tampilkan
            if (textBoxNama.Text == "")
            {
                MessageBox.Show("Harus memasukkan nama anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxJenisKelamin.Text == "")
            {
                MessageBox.Show("Harus memasukkan jenis kelamin anda", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (comboBoxJenisKelamin.Text != "Laki - Laki" || comboBoxJenisKelamin.Text != "Perempuan")
            {
                MessageBox.Show("Jenis kelamin yang anda masukkan tidak dapat diidentifikasi", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (kelas == "")
            {
                MessageBox.Show("Harus memiliki salah satu dari pilihan kelas", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jadwal == "")
            {
                MessageBox.Show("Harus memiliki salah satu dari pilihan jadwal", "Warning!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show
                ("Nama\t\t: " + textBoxNama.Text +
                "\nJenis Kelamin\t: " + comboBoxJenisKelamin.Text +
                "\nTanggal Lahir\t: " + dateTimePicker1.Text +
                "\nPilihan Kelas\t: " + kelas +
                "\nPilihan Jadwal\t: " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
