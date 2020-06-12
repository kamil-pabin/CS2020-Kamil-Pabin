using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighter
{
    public partial class Sklep : Form
    {
        public sklepMoney AddItemCallbackMoney;
        int moneySk;
        int silnikSk;
        int bronSk;
        int zycieSk;
        bool eliteP;
        public Sklep(int money, int silnik, int bron, int zycie, bool elite)
        {
            moneySk = money;
            silnikSk = silnik;
            bronSk = bron;
            zycieSk = zycie;
            eliteP = elite;           
            InitializeComponent();
            groupBox2.Visible = false;
        }
        public void wylaczeniesklepu()
        {
            AddItemCallbackMoney(moneySk.ToString(), silnikSk.ToString(), bronSk.ToString(), zycieSk.ToString(), eliteP);
            this.Close();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            wylaczeniesklepu();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelMoney.Text = moneySk.ToString();
            label1.Text = silnikSk.ToString();
            label2.Text = bronSk.ToString();
            label3.Text = zycieSk.ToString();
            if (moneySk >= 100)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            if (eliteP == true)
            {
                elitekup.Enabled = false;
            }
            else
            {
                if (moneySk >= 500)
                {
                    elitekup.Enabled = true;
                }
                else
                {
                    elitekup.Enabled = false;
                }
            }

            if (silnikSk >= 3)
            {
                button1.Enabled = false;
            }
            if (bronSk >= 3)
            {
                button2.Enabled = false;
            }
            if (zycieSk >= 3)
            {
                button3.Enabled = false;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (moneySk >= 100)
            {
                silnikSk += 1;
                moneySk -= 100;
            }                      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (moneySk >= 100)
            {
                bronSk += 1;
                moneySk -= 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (moneySk >= 100)
            {
                zycieSk += 1;
                moneySk -= 100;
            }
        }

        private void elitekup_Click(object sender, EventArgs e)
        {
            eliteP = true;
            moneySk -= 500;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            BoxSelectPlane.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            BoxSelectPlane.Visible = false;
        }
    }
}
