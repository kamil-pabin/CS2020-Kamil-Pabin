using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsokienka
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text.Trim();
            label1.Text = tekst;
            return;
        }
        private void labeldblClick(object sender, MouseEventArgs e)
        {
            label1.Text = "****";
            return;
        }
        private void lista(object sender, EventArgs e)
        {
            label3.Text = "Do kupienia: \n";
            bool test = false;
            if (checkBox1.Checked)
            {
                
                label3.Text += checkBox1.Text;
                test = true;
            }
            if (checkBox2.Checked)
            {
                if (test)
                    label3.Text += "\n";
                label3.Text += checkBox2.Text;
                test = true;
            }
            if (checkBox3.Checked)
            {
                if (test)
                    label3.Text += "\n";
                label3.Text += checkBox3.Text;
                test = true;
            }
            if (checkBox4.Checked)
            {
                if (test)
                    label3.Text += "\n";
                label3.Text += checkBox4.Text;
                test = true;
            }
            if (checkBox5.Checked)
            {
                if (test)
                    label3.Text += "\n";
                label3.Text += checkBox5.Text;
                test = true;
            }
            MessageBox.Show(label3.Text, "Lista zakupow");
        }
        private void gaszenie1(object sender, EventArgs e)
        {
            
            if (groupBox1.Visible)
            {
                groupBox1.Visible = false;
                przepisywanieToolStripMenuItem.Checked = false;
            }
            else
            {
                groupBox1.Visible = true;
                przepisywanieToolStripMenuItem.Checked = true;
            }
           
             
        }
        private void gaszenie2(object sender, EventArgs e)
        {
            
            if (groupBox2.Visible)
            {
                groupBox2.Visible = false;
                zakupyToolStripMenuItem.Checked = false;
            }
            else
            {
                groupBox2.Visible = true;
                zakupyToolStripMenuItem.Checked = true;
            }
            
        }
        private void gaszenie4(object sender, EventArgs e)
        {
            if (groupBox3.Visible)
            {
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
            }
        }
        private void gaszenie5(object sender, EventArgs e)
        {
            if (groupBox4.Visible)
            {
                groupBox4.Visible = false;
            }
            else
            {
                groupBox4.Visible = true;
            }
        }
        private void gaszenie6(object sender, EventArgs e)
        {
            if (groupBox5.Visible)
            {
                groupBox5.Visible = false;
            }
            else
            {
                groupBox5.Visible = true;
            }
        }
        private void restartgaszenia(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            
        }
        private void komunikat (object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString(), "liczba");
        }
        private void wartoscTrack (object sender, EventArgs e)
        {
            int wartosc1 = trackBar1.Value;
            progressBar1.Value = wartosc1;
            numericUpDown1.Value = wartosc1;
        }
        private void wartoscNumeric(object sender, EventArgs e)
        {
            int wartosc3 = (int)numericUpDown1.Value;
            progressBar1.Value = wartosc3;
            trackBar1.Value = wartosc3;
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            string czas = DateTime.Now.ToLongTimeString();
            button4.Text = czas;
        }
        private void zegarClick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }

        private void combinedzad1(object sender, EventArgs e)
        {
            if (przepisywanieToolStripMenuItem.Checked)
            {
                przepisywanieToolStripMenuItem.Checked = false;
            }
            else
            {
                przepisywanieToolStripMenuItem.Checked = true;
            }

        }
        private void combinedzad2(object sender, EventArgs e)
        {
            if (zakupyToolStripMenuItem.Checked)
            {
                zakupyToolStripMenuItem.Checked = false;
            }
            else
            {
                zakupyToolStripMenuItem.Checked = true;
            }

        }
        private void combinedzad4(object sender, EventArgs e)
        {
            if (przepiszToolStripMenuItem.Checked)
            {
                przepiszToolStripMenuItem.Checked = false;
            }
            else
            {
                przepiszToolStripMenuItem.Checked = true;
            }

        }
        private void combinedzad5(object sender, EventArgs e)
        {
            if (listaToolStripMenuItem.Checked)
            {
                listaToolStripMenuItem.Checked = false;
            }
            else
            {
                listaToolStripMenuItem.Checked = true;
            }

        }
        private void combinedzad6(object sender, EventArgs e)
        {
            if (zegarToolStripMenuItem.Checked)
            {
                zegarToolStripMenuItem.Checked = false;
            }
            else
            {
                zegarToolStripMenuItem.Checked = true;
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Exitttt(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye");
            Application.Exit();
        }
    }
}
