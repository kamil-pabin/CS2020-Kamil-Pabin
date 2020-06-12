using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fighter
{
    
    public partial class Form1 : Form
    {
        public AddItemDelegate AddItemCallback;
        //potrzebne zmienne globalne
        bool up, down;

        int bulletcount = 0;    
        
        int wynikk = 0;
        int monej = 0;

        int gameSpeed = 0;
        int Lost;
        int endscore = 0;
        int sekundyczas = 30;
        int ms = 1000;

        int samolot;
        int silnik;
        int bron;
        int zycie;
        public Form1(int poziom, int typsamolotu, int silnikLvl, int bronLvl, int zycieLvl)
        {
            InitializeComponent();
            gameSpeed = poziom;
            samolot = typsamolotu;
            silnik = silnikLvl;
            bron = bronLvl;
            zycie = zycieLvl;
            if (samolot == 1)
            {
                jet.Visible = true;
                rakieton.Visible = false;
            }
            if (samolot == 2)
            {
                jet.Visible = false;
                rakieton.Visible = true;
            }
            start();
            
        }
        //to co dzieje sie na koncu gry
        void gamestop()
        {
            jettimer.Enabled = false;
            przeciwnicy.Enabled = false;
            hardgame.Enabled = false;
            sektimer.Enabled = false;
            mstimer.Enabled = false;
            fire1.Enabled = false;
            fire2.Enabled = false;
            fire3.Enabled = false;
            bullet1.Visible = false;
            bullet2.Visible = false;
            bullet3.Visible = false;
        }
        //to co dzieje sie przy starcie aplikacji
        void start()
        {
            
            endmenu.Visible = false;
            winBox.Visible = false;
            bullet1.Visible = false;
            bullet2.Visible = false;
            bullet3.Visible = false;

            if(zycie == 1)
            {
                Lost = -3;
            }
            if(zycie == 2)
            {
                Lost = -4;
                hp4.Visible = true;
            }
            if(zycie == 3)
            {
                Lost = -5;
                hp4.Visible = true;
                hp5.Visible = true;
            }

            enemy1.Left = 1200;
            enemy2.Left = 1500;
            enemy3.Left = 1900;
            
        }
        //ruch przeciwnika
        void przeciwnik(PictureBox enemyObj) 
        {
            enemyObj.Left -= 10;
        }
        //niestety wymagane, windows forms sobie je wstawił i nie moge usunac
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jet_Click(object sender, EventArgs e)
        {

        }

        
        //funkcja odpowiadajaca za latanie naszego samolotu
        private void jettimer_Tick(object sender, EventArgs e)
        {
            if(samolot == 1)
            {
                if (up == true)
                {
                    if (jet.Top > 15)
                    {
                        jet.Top -= (10 + (silnik * 2));
                    }
                }
                if (down == true)
                {
                    if (jet.Top < 550)
                    {
                        jet.Top += (10 + (silnik * 2));
                    }
                }
            }
            if (samolot == 2)
            {
                if (up == true)
                {
                    if (rakieton.Top > 15)
                    {
                        rakieton.Top -= (10 + (silnik) * 2);
                    }
                }
                if (down == true)
                {
                    if (rakieton.Top < 550)
                    {
                        rakieton.Top += (10 + (silnik) * 2);
                    }
                }
            }
            
        }
        // sprawdzenie naciskania klawiszy
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                down = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                if (samolot == 1)
                {
                    if (bulletcount == 0)
                    {
                        bullet1.Location = jet.Location;
                        fire1.Enabled = true;
                        bulletcount++;
                    }
                    else if (bulletcount == 1)
                    {
                        bullet2.Location = jet.Location;
                        fire2.Enabled = true;
                        bulletcount++;
                    }
                    else if (bulletcount == 2)
                    {
                        bullet3.Location = jet.Location;
                        fire3.Enabled = true;
                        bulletcount = 0;
                    }
                }
                if (samolot == 2)
                {
                    if (bulletcount == 0)
                    {
                        bullet1.Location = rakieton.Location;
                        fire1.Enabled = true;
                        bulletcount++;
                    }
                    else if (bulletcount == 1)
                    {
                        bullet2.Location = rakieton.Location;
                        fire2.Enabled = true;
                        bulletcount++;
                    }
                    else if (bulletcount == 2)
                    {
                        bullet3.Location = rakieton.Location;
                        fire3.Enabled = true;
                        bulletcount = 0;
                    }
                }










            }
            
        }
        //pociski, ich latanie oraz zderzenia z przeciwnikiem
        private void fire1_Tick(object sender, EventArgs e)
        {
            bullet1.Visible = true;   
            
            bullet1.Left += 10 + (bron*2);

            if (bullet1.Right >= enemy1.Left && bullet1.Right <= enemy1.Left + gameSpeed*3 && bullet1.Top < enemy1.Top+enemy1.Height && bullet1.Top >= enemy1.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset1();
                bulletReset1();
            }
            if (bullet1.Right >= enemy2.Left && bullet1.Right <= enemy2.Left + gameSpeed*3 && bullet1.Top < enemy2.Top + enemy2.Height && bullet1.Top >= enemy2.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset2();
                bulletReset1();
            }
            if (bullet1.Right >= enemy3.Left && bullet1.Right <= enemy3.Left + gameSpeed*3 && bullet1.Top < enemy3.Top + enemy3.Height && bullet1.Top >= enemy3.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset3();
                bulletReset1();               
            }
        }

        private void fire2_Tick(object sender, EventArgs e)
        {
            bullet2.Visible = true;
            bullet2.Left += 10 + (bron * 2);
            if (bullet2.Right >= enemy1.Left && bullet2.Right <= enemy1.Left + gameSpeed*3 && bullet2.Top < enemy1.Top + enemy1.Height && bullet2.Top >= enemy1.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset1();
                bulletReset2();
            }
            if (bullet2.Right >= enemy2.Left && bullet2.Right <= enemy2.Left + gameSpeed*3 && bullet2.Top < enemy2.Top + enemy2.Height && bullet2.Top >= enemy2.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset2();
                bulletReset2();
            }
            if (bullet2.Right >= enemy3.Left && bullet2.Right <= enemy3.Left + gameSpeed*3 && bullet2.Top < enemy3.Top + enemy3.Height && bullet2.Top >= enemy3.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset3();
                bulletReset2();
            }
        }
        private void fire3_Tick(object sender, EventArgs e)
        {
            bullet3.Visible = true;
            bullet3.Left += 10 + (bron * 2);
            if (bullet3.Right >= enemy1.Left && bullet3.Right <= enemy1.Left + gameSpeed*3 && bullet3.Top < enemy1.Top + enemy1.Height && bullet3.Top >= enemy1.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset1();
                bulletReset3();
                
            }
            if (bullet3.Right >= enemy2.Left && bullet3.Right <= enemy2.Left + gameSpeed * 3 && bullet3.Top < enemy2.Top + enemy2.Height && bullet3.Top >= enemy2.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                wynikk += 1;               
                punkty.Text = wynikk.ToString();
                enemyReset2();
                bulletReset3();
            }
            if (bullet3.Right >= enemy3.Left && bullet3.Right <= enemy3.Left + gameSpeed * 3 && bullet3.Top < enemy3.Top + enemy3.Height && bullet3.Top >= enemy3.Top)
            {
                if (wynikk > 0)
                {
                    if (wynikk % 8 == 0)
                    {
                        gameSpeed += 2;
                    }
                }
                
                wynikk += 1;
                punkty.Text = wynikk.ToString();
                enemyReset3();
                bulletReset3();
            }
        }
        
        //wlasne funkcje wykorzystywane w programie
        
        int randomNumber()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int rInt = r.Next(30, 500);
            return rInt;
        }
        
        void enemyReset1()
        {           
            enemy1.Left = rakieton.Left + 1400;
            enemy1.Top = randomNumber();
        }
        void bulletReset1()
        {
            if(samolot == 1)
            {
                bullet1.Visible = false;
                bullet1.Location = jet.Location;
                fire1.Enabled = false;
            }
            if (samolot == 2)
            {
                bullet1.Visible = false;
                fire1.Enabled = false;
                bullet1.Location = rakieton.Location;
                
            }
        }

        void enemyReset2()
        {
            enemy2.Left = jet.Left + 1400;
            enemy2.Top = randomNumber();
        }
        void bulletReset2()
        {
            if (samolot == 1)
            {
                bullet2.Visible = false;
                bullet2.Location = jet.Location;
                fire2.Enabled = false;
            }
            if (samolot == 2)
            {
                bullet2.Visible = false;
                fire2.Enabled = false;
                bullet2.Location = rakieton.Location;
                
            }
        }
        void enemyReset3()
        {
            enemy3.Left = jet.Left + 1400;
            enemy3.Top = randomNumber();           
        }
        void bulletReset3()
        {
            if (samolot == 1)
            {
                bullet3.Visible = false;
                fire3.Enabled = false;
                bullet3.Location = jet.Location;
                
            }
            if (samolot == 2)
            {
                bullet3.Visible = false;
                fire3.Enabled = false;
                bullet3.Location = rakieton.Location;
                
            }
        }
        //hp gracza (serduszka)
        void hp(int LostPoints)
        {
            if (zycie == 1)
            {
                if (LostPoints == -2)
                {
                    hp3.Visible = false;
                }
                if (LostPoints == -1)
                {
                    hp2.Visible = false;
                }
                if (LostPoints == 0)
                {
                    hp1.Visible = false;
                }
            }
            else if (zycie == 2)
            {

                if (LostPoints == -3)
                {
                    hp4.Visible = false;
                }
                if (LostPoints == -2)
                {
                    hp3.Visible = false;
                }
                if (LostPoints == -1)
                {
                    hp2.Visible = false;
                }
                if (LostPoints == 0)
                {
                    hp1.Visible = false;
                }               
            }
            else if (zycie == 3)
            {
                if (LostPoints == -4)
                {
                    hp5.Visible = false;
                }
                if (LostPoints == -3)
                {
                    hp4.Visible = false;
                }
                if (LostPoints == -2)
                {
                    hp3.Visible = false;
                }
                if (LostPoints == -1)
                {
                    hp2.Visible = false;
                }
                if (LostPoints == 0)
                {
                    hp1.Visible = false;
                }
            }
            
        }
        
        //przeciwnicy i ich zachowanie
        private void przeciwnicy_Tick(object sender, EventArgs e)
        {
            //ruch przeciwnikow
            //1
            if (enemy1.Left > -20)
            {
                enemy1.Left -= gameSpeed;              
            }
            else
            {
                Lost++;
                hp(Lost);
                lostcounter.Text = Lost.ToString();
                if (Lost == 0)
                {
                    endscore = wynikk - Lost;
                    wynikKoniec.Text = endscore.ToString();
                    monej = wynikk * 2;
                    endmenu.Visible = true;
                    gamestop();
                    AddItemCallback(endscore.ToString(), monej.ToString()); //przenoszenie score do glownego menu
                }               
                enemyReset1();
            }
            //2
            if (enemy2.Left > -20)
            {
                enemy2.Left -= gameSpeed;
            }
            else
            {
                Lost++;
                hp(Lost);
                lostcounter.Text = Lost.ToString();
                if (Lost == 0)
                {
                    endscore = wynikk - Lost;
                    wynikKoniec.Text = endscore.ToString();
                    monej = wynikk * 2;
                    endmenu.Visible = true;
                    gamestop();
                    AddItemCallback(endscore.ToString(), monej.ToString()); //przenoszenie score do glownego menu
                }
                enemyReset2();
            }
            //3
            if (enemy3.Left > -20)
            {
                enemy3.Left -= gameSpeed;
            }
            else
            {
                Lost++;
                hp(Lost);
                lostcounter.Text = Lost.ToString();
                if (Lost == 0)
                {
                    endscore = wynikk - Lost;
                    wynikKoniec.Text = endscore.ToString();
                    monej = wynikk * 2;
                    endmenu.Visible = true;
                    gamestop();
                    AddItemCallback(endscore.ToString(), monej.ToString()); //przenoszenie score do glownego menu
                }
                enemyReset3();
            }
            


        }
        //sprawdzenie czy nalezy skonczyc gre czasowo

        private void hardgame_Tick(object sender, EventArgs e)
        {
            
           
            endscore = wynikk;
            monej = wynikk * 3;
            WynikKoniecWin.Text = endscore.ToString();
            gamestop();
            AddItemCallback(endscore.ToString(), monej.ToString()); //przenoszenie score do glownego menu
            winBox.Visible = true;
                
            
        }
        //restart
        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        
        
       //wiadomo
        private void exit(object sender, EventArgs e)
        {
            
            this.Close();
        }
        //zegar, sekundy i milisekundy
        private void sektimer_Tick(object sender, EventArgs e)
        {
            if (sekundyczas > 0)
            {
                sekundyczas--;
                sekundy.Text = sekundyczas.ToString();
            }
        }

        private void mstimer_Tick(object sender, EventArgs e)
        {
            if (sekundyczas > 0)
            {
                if (ms == 0)
                {
                    ms = 1000;
                }
                else
                {
                    ms-=20;
                    milisekundy.Text = ms.ToString();
                }
               
            }
        }

        //sprawdzanie puszczania klawiszy góra dół, do funkcji latania
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                down = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                up = false;
            }
        }
    }
}
