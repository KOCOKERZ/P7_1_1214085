using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214085
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(816, 312);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (radioButton1.Text != "")
                    {
                        if (radioButton2.Text != "")
                        {
                            if (textBox3.Text != "")
                            {
                                if (comboBox1.Text != "")
                                {
                                    if (textBox4.Text != "")
                                    {
                                        if (Regex.IsMatch(textBox4.Text, @"^\d{4}/\d{4}$"))
                                        {
                                            if (textBox5.Text != "")
                                            {
                                                if ((textBox5.Text).All(Char.IsLetter))
                                                {
                                                    MessageBox.Show
                                                    ("Inputan Semester Hanya Boleh Angka !!!",
                                                    "Informasi Data Submit",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                }
                                                else
                                                {
                                                    MessageBox.Show
                                                    ("Data Lengkap !!!",
                                                    "Informasi Data Submit",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    this.Size = new Size(816, 597);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show
                                                ("Semester Belum Diisi !!!",
                                                "Informasi Data Submit",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            }
                                        }
                                        else
                                        {
                                              MessageBox.Show
                                              ("Format Tahun Akademik Salah !!!",
                                              "Informasi Data Submit",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show
                                            ("Tahun Akademik Belum Diisi !!!",
                                            "Informasi Data Submit",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show
                                        ("Pilih Program Studi !!!",
                                        "Informasi Data Submit",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            else
                            {
                                MessageBox.Show
                                    ("Pilih Jenis Kelamin !!!",
                                    "Informasi Data Submit",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show
                                ("Pilih Jenis Kelamin  !!!",
                                "Informasi Data Submit",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    else
                    {
                        MessageBox.Show
                            ("Alamat Belum Diisi !!!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                        ("Nama Belum Diisi !!!",
                        "Informasi Data Submit",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                    ("NIM Belum Diisi !!!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                epWrong.SetError(textBox4, "");
            }
            else
            {
                if (Regex.IsMatch(textBox4.Text, @"^\d{4}/\d{4}$"))
                {
                    epWrong.SetError(textBox4, "");
                }
                else
                {
                    epWrong.SetError(textBox4, "Format Tahun Akademik Salah!");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                epWrong.SetError(textBox5, "");
            }
            else
            {
                if ((textBox5.Text).All(Char.IsNumber))
                {
                    epWrong.SetError(textBox5, "");
                }
                else
                {
                    epWrong.SetError(textBox5, "Inputan Semester Hanya Boleh Angka!");
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                checkBox1.Enabled = true; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox7.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox7.Checked = false;
                checkBox9.Enabled = true; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = false; checkBox12.Checked = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                checkBox1.Enabled = false; checkBox1.Checked = false;
                checkBox2.Enabled = true; checkBox2.Checked = false;
                checkBox3.Enabled = true; checkBox3.Checked = false;
                checkBox4.Enabled = true; checkBox4.Checked = false;
                checkBox5.Enabled = true; checkBox5.Checked = false;
                checkBox6.Enabled = true; checkBox6.Checked = false;
                checkBox7.Enabled = true; checkBox7.Checked = false;
                checkBox8.Enabled = true; checkBox7.Checked = false;
                checkBox9.Enabled = false; checkBox9.Checked = false;
                checkBox10.Enabled = true; checkBox10.Checked = false;
                checkBox11.Enabled = true; checkBox11.Checked = false;
                checkBox12.Enabled = true; checkBox12.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string jeniskelamin = null;
            
            if (radioButton1.Checked)
            {
                jeniskelamin = radioButton1.Text;
            }
            else
            {
                jeniskelamin = radioButton2.Text;
            }

            string kurikulumpilihan = null;

            if (radioButton3.Checked)
            {
                kurikulumpilihan = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                kurikulumpilihan = radioButton4.Text;
            }
            else
            {
                kurikulumpilihan = radioButton5.Text;
            }

            string matakuliahpilihan = null;

            if (checkBox1.Checked)
            { 
                matakuliahpilihan += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                matakuliahpilihan += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                matakuliahpilihan += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                matakuliahpilihan += checkBox4.Text + ", ";
            }
            if (checkBox5.Checked)
            {
                matakuliahpilihan += checkBox5.Text + ", ";
            }
            if (checkBox6.Checked)
            {
                matakuliahpilihan += checkBox6.Text + ", ";
            }
            if (checkBox7.Checked)
            {
                matakuliahpilihan += checkBox7.Text + ", ";
            }
            if (checkBox8.Checked)
            {
                matakuliahpilihan += checkBox8.Text + ", ";
            }
            if (checkBox9.Checked)
            {
                matakuliahpilihan += checkBox9.Text + ", ";
            }
            if (checkBox10.Checked)
            {
                matakuliahpilihan += checkBox10.Text + ", ";
            }
            if (checkBox11.Checked)
            {
                matakuliahpilihan += checkBox11.Text + ", ";
            }
            if (checkBox12.Checked)
            {
                matakuliahpilihan += checkBox12.Text + ", ";
            }

            MessageBox.Show
            ("NIM\t\t\t: " + textBox1.Text +
            "\nNama\t\t\t: " + textBox2.Text +
            "\nJenis Kelamin\t\t: " + jeniskelamin +
            "\nAlamat\t\t\t: " + textBox3.Text +
            "\nProgram Studi\t\t: " + comboBox1.Text +
            "\nTahun Akademik\t\t: " + textBox4.Text +
            "\nSemester\t\t\t: " + textBox5.Text +
            "\nKurikulum Pilihan\t\t: " + kurikulumpilihan +
            "\nMata Kuliah Pilihan\t: " + matakuliahpilihan,
            "Informasi Pilihan Mata kuliah Mahasiswa",
            MessageBoxButtons.OK, MessageBoxIcon.Information) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(816, 312);
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            comboBox1.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
        }
    }
}
