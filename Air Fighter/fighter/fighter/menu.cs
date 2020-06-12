using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighter
{
    public delegate void AddItemDelegate(string item, string monej);

    public delegate void sklepMoney(string itemMoney, string itemSilnik, string itemBron, string itemZycie, bool elite);
    public partial class menu : Form
    {
        int wybor = 1;
        int trudnosc = 4;
        int strona = 0;

        int topscore = 0;
        int money = 150;

        bool eliteplane = false;
        int silnikLvl = 1;
        int bronLvl = 1;
        int zycieLvl = 1;
        public menu()
        {
            InitializeComponent();
            wlacznik();
        }
        void wlacznik()
        {
            zasadybox.Visible = false;
            groupBox1.Visible = false;
            moneyLabel.Text = money.ToString();
            

        }
        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void wyjscie_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Autor_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            
        }
        void zasady()
        {
            zasadybox.Visible = true;
            groupBox2.Visible = true;
            
        }
        
        private void start_Click(object sender, EventArgs e)
        {
            
            zasady();            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(wybor == 1)
            {
                Form1 Gra = new Form1(trudnosc, wybor, silnikLvl, bronLvl, zycieLvl);
                Gra.AddItemCallback = new AddItemDelegate(this.AddItemCallbackFn);
                Gra.Show();
            }
            else if (wybor == 2)
            {
                Form1 Gra = new Form1(trudnosc, wybor, 3, 3, 3);
                Gra.AddItemCallback = new AddItemDelegate(this.AddItemCallbackFn);
                Gra.Show();
            }
            
            
        }
        //otwarcie sklepu
        private void labelSklep_Click(object sender, EventArgs e)
        {
            Sklep Sklep = new Sklep(money, silnikLvl, bronLvl, zycieLvl, eliteplane);
            Sklep.AddItemCallbackMoney = new sklepMoney(this.sklepMoney);
            Sklep.Show();
        }
        private void AddItemCallbackFn(string item, string monej)
        {
            if (Int32.Parse(item) > topscore)
            {
                topscorelabel.Text = item;
                topscore = Int32.Parse(item);
            }
            else
            {
                topscorelabel.Text = topscore.ToString();
            }

            money += Int32.Parse(monej);
            moneyLabel.Text = money.ToString();
        }
        private void sklepMoney(string itemMoney, string itemSilnik, string itemBron, string itemZycie, bool elite)
        {
            eliteplane = elite;
            money = Int32.Parse(itemMoney);
            silnikLvl = Int32.Parse(itemSilnik);
            bronLvl = Int32.Parse(itemBron);
            zycieLvl = Int32.Parse(itemZycie);

            moneyLabel.Text = money.ToString();
            labelSilnik.Text = itemSilnik;
            labelBron.Text = itemBron;
            labelZycie.Text = itemZycie;
            

        }
        private void powrot(object sender, EventArgs e)
        {
            zasadybox.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            
        }
        //wybor trudnosci
        private void button3_Click(object sender, EventArgs e)
        {
            trudnosc = 2;
            label4.Text = "Łatwy";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            trudnosc = 4;
            label4.Text = "Normalny";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            trudnosc = 6;
            label4.Text = "Trudny";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trudnosc = 9;
            label4.Text = "Irak";
        }
        //wybor samolotu
        private void typ1_CheckedChanged(object sender, EventArgs e)
        {
            typ2.Checked = false;
            wybor = 1;
        }

        private void typ2_CheckedChanged(object sender, EventArgs e)
        {
            typ1.Checked = false;
            wybor = 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(typ1.Checked == true)
            {
                groupBox3.Visible = true;
            }
            else groupBox3.Visible = false;

            if (eliteplane == true)
            {
                typ2.Enabled = true;
            }
            else
            {
                typ2.Enabled = false;
            }
            if(strona < 2)
            {
                button7.Enabled = true;
            }
            else
            {
                button7.Enabled = false;
            }
            if (strona > 0)
            {
                button8.Enabled = true;
            }
            else
            {
                button8.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (strona < 2)
            {
                strona += 1;
            }
            

            if (strona == 1)
            {
                label1.Visible = true;
                label10.Visible = false;
            }
            if (strona == 2)
            {
                label1.Visible = false;
                label11.Visible = true;
            }

            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            if (strona > 0)
            {
                strona -= 1;
            }
            if (strona == 0)
            {
                label1.Visible = false;
                label10.Visible = true;
            }
            if (strona == 1)
            {
                label11.Visible = false;
                label1.Visible = true;
            }
        }
    }
}
