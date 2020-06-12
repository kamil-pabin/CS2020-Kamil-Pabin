using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        float wynik;
        float[] liczby = new float[2];
        string liczbaString;
        string liczbaString2;
        string znak;

        public Form1()
        {
            InitializeComponent();           
            Reseter();
            
        }
        private void wczytywanie(object sender, EventArgs e) //wczytywanie klikanej liczby do pamieci
        {
            //liczba w danym okienku, sprawdzana
            if (label6.Text == wynik.ToString())
            {
                Reseter();
            }     
            
            if (znak == null)
            {
                string calosc = sender.ToString();
                char[] delimeterChars = { ':' };
                string[] podzielonaCalosc = calosc.Split(delimeterChars);
                liczbaString += podzielonaCalosc.Last().Trim();
                //zabezpieczenia nizej          
                liczby[0] = float.Parse(liczbaString); //to samo ale format float rzucany do tablicy   
                wyswietlDzialanie(1);
                checkBox1.Enabled = false;
                button10.Enabled = true;
                button13.Enabled = true;
                button14.Enabled = true;
                if (checkBox2.Checked == true)
                {
                    checkBox2.Enabled = false;
                    checkBox2.Checked = false;
                }
            }
            else
            {
                
                string calosc = sender.ToString();
                char[] delimeterChars = { ':' };
                string[] podzielonaCalosc = calosc.Split(delimeterChars);
                liczbaString2 += podzielonaCalosc.Last().Trim();
                //zabezpieczenia nizej          
                liczby[1] = float.Parse(liczbaString2); //to samo ale format float rzucany do tablicy 
                wyswietlDzialanie(2);
                button12.Enabled = true;
                checkBox1.Enabled = false;
                if (checkBox2.Checked == true)
                {
                    checkBox2.Enabled = false;
                    checkBox2.Checked = false;
                }
            }
                              
        }    
        private void wczytajZnak(object sender, EventArgs e)
        {    
            string calosc = sender.ToString();
            char[] delimeterChars = { ':' };
            string[] podzielonaCalosc = calosc.Split(delimeterChars);
            string znakString = podzielonaCalosc.Last();
            znak = znakString;
            checkBox2.Enabled = true;
            checkBox1.Enabled = true;

        }
        private void wyswietlDzialanie(int check)
        {
            if (check == 1)
            {
                label3.Text = liczby[0].ToString();
                label3.Visible = true;
            }
            else if(check == 2) 
            {
                
                label3.Text = liczby[0].ToString();
                label4.Text = znak;
                label5.Text = liczby[1].ToString();
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
            }
          

        }
        private void liczbyUjemne(object sender, EventArgs e)
        {
            if (button1.Text == "-1")
            {
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                button5.Text = "5";
                button6.Text = "6";
                button7.Text = "7";
                button8.Text = "8";
                button9.Text = "9";
            }
            else
            {
                button1.Text = "-1";
                button2.Text = "-2";
                button3.Text = "-3";
                button4.Text = "-4";
                button5.Text = "-5";
                button6.Text = "-6";
                button7.Text = "-7";
                button8.Text = "-8";
                button9.Text = "-9";
            }
            

        }
        private void liczbyPrzecinek(object sender, EventArgs e)
        {
            if (button1.Text == ",1")
            {
                button1.Text = "1";
                button2.Text = "2";
                button3.Text = "3";
                button4.Text = "4";
                button5.Text = "5";
                button6.Text = "6";
                button7.Text = "7";
                button8.Text = "8";
                button9.Text = "9";
            }
            else
            {
                button1.Text = ",1";
                button2.Text = ",2";
                button3.Text = ",3";
                button4.Text = ",4";
                button5.Text = ",5";
                button6.Text = ",6";
                button7.Text = ",7";
                button8.Text = ",8";
                button9.Text = ",9";
            }


        }
        private void wyswietlWynik(object sender, EventArgs e)
        {
            int state = 0;
            if (znak == " +")
            {
                dodawanie(liczby[0], liczby[1]);
            }
            if (znak == " -")
            {
                odejmowanie(liczby[0], liczby[1]);
            }
            if (znak == " *")
            {
                mnozenie(liczby[0], liczby[1]);
            }
            if (znak == " /")
            {
                if (liczby[0] != 0 && liczby[1] != 0)
                {
                    dzielenie(liczby[0], liczby[1]);
                }
                else
                {
                    state = 1;
                }
            }
            if(state == 0)
            {
                label6.Text = wynik.ToString();
                label6.Visible = true;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Nie można dzielić przez zero ani dzielić zera!");
                Reseter();
            }
            
        }
        private void resetuj(object sender, EventArgs e)
        {
            Reseter();
        }
        public void Reseter()
        {
            znak = null;
            Array.Clear(liczby, 0, 2);
            liczbaString = "";
            liczbaString2 = "";
            label3.Text = "Liczba 1";
            label4.Text = "Znak";
            label5.Text = "Liczba 2";
            label6.Text = "Wynik";
            button12.Enabled = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9";

        }
        private void dodawanie(float a, float b)
        {
            wynik = a + b;          
        }
        private void odejmowanie(float a, float b)
        {
            wynik = a - b;
        }
        private void mnozenie(float a, float b)
        {
            wynik = a * b;
        }
        private void dzielenie(float a, float b)
        {         
            wynik = a / b;
        }
    }
}
