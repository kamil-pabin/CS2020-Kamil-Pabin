namespace fighter
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.punkty = new System.Windows.Forms.Label();
            this.scoretext = new System.Windows.Forms.Label();
            this.koniec = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.wynikKoniec = new System.Windows.Forms.Label();
            this.endmenu = new System.Windows.Forms.GroupBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.winBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WynikKoniecWin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.przeciwnicy = new System.Windows.Forms.Timer(this.components);
            this.fire1 = new System.Windows.Forms.Timer(this.components);
            this.fire2 = new System.Windows.Forms.Timer(this.components);
            this.fire3 = new System.Windows.Forms.Timer(this.components);
            this.jettimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lostcounter = new System.Windows.Forms.Label();
            this.hardgame = new System.Windows.Forms.Timer(this.components);
            this.sekundy = new System.Windows.Forms.Label();
            this.timestamp = new System.Windows.Forms.Label();
            this.milisekundy = new System.Windows.Forms.Label();
            this.sektimer = new System.Windows.Forms.Timer(this.components);
            this.mstimer = new System.Windows.Forms.Timer(this.components);
            this.hp2 = new System.Windows.Forms.PictureBox();
            this.hp3 = new System.Windows.Forms.PictureBox();
            this.hp1 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.jet = new System.Windows.Forms.PictureBox();
            this.rakieton = new System.Windows.Forms.PictureBox();
            this.hp4 = new System.Windows.Forms.PictureBox();
            this.hp5 = new System.Windows.Forms.PictureBox();
            this.endmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            this.winBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp5)).BeginInit();
            this.SuspendLayout();
            // 
            // punkty
            // 
            this.punkty.AutoSize = true;
            this.punkty.BackColor = System.Drawing.Color.Gray;
            this.punkty.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punkty.Location = new System.Drawing.Point(1074, 9);
            this.punkty.Name = "punkty";
            this.punkty.Size = new System.Drawing.Size(33, 35);
            this.punkty.TabIndex = 4;
            this.punkty.Text = "0";
            // 
            // scoretext
            // 
            this.scoretext.AutoSize = true;
            this.scoretext.BackColor = System.Drawing.Color.Gray;
            this.scoretext.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoretext.Location = new System.Drawing.Point(945, 9);
            this.scoretext.Name = "scoretext";
            this.scoretext.Size = new System.Drawing.Size(123, 35);
            this.scoretext.TabIndex = 5;
            this.scoretext.Text = "SCORE:";
            // 
            // koniec
            // 
            this.koniec.AutoSize = true;
            this.koniec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.koniec.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koniec.Location = new System.Drawing.Point(65, 203);
            this.koniec.Name = "koniec";
            this.koniec.Size = new System.Drawing.Size(474, 97);
            this.koniec.TabIndex = 6;
            this.koniec.Text = "PRZEGRANA";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(241, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 122);
            this.button2.TabIndex = 8;
            this.button2.Text = "WYJSCIE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.exit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 97);
            this.label1.TabIndex = 9;
            this.label1.Text = "Wynik:";
            // 
            // wynikKoniec
            // 
            this.wynikKoniec.AutoSize = true;
            this.wynikKoniec.BackColor = System.Drawing.Color.Transparent;
            this.wynikKoniec.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wynikKoniec.Location = new System.Drawing.Point(373, 49);
            this.wynikKoniec.Name = "wynikKoniec";
            this.wynikKoniec.Size = new System.Drawing.Size(90, 97);
            this.wynikKoniec.TabIndex = 10;
            this.wynikKoniec.Text = "0";
            this.wynikKoniec.Click += new System.EventHandler(this.label2_Click);
            // 
            // endmenu
            // 
            this.endmenu.BackColor = System.Drawing.Color.Silver;
            this.endmenu.Controls.Add(this.label1);
            this.endmenu.Controls.Add(this.button2);
            this.endmenu.Controls.Add(this.wynikKoniec);
            this.endmenu.Controls.Add(this.koniec);
            this.endmenu.Location = new System.Drawing.Point(226, 47);
            this.endmenu.Name = "endmenu";
            this.endmenu.Size = new System.Drawing.Size(608, 461);
            this.endmenu.TabIndex = 11;
            this.endmenu.TabStop = false;
            // 
            // bullet3
            // 
            this.bullet3.BackColor = System.Drawing.Color.Transparent;
            this.bullet3.Image = global::fighter.Properties.Resources.bullets_PNG35578;
            this.bullet3.Location = new System.Drawing.Point(174, 224);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(21, 24);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 14;
            this.bullet3.TabStop = false;
            // 
            // winBox
            // 
            this.winBox.BackColor = System.Drawing.Color.Silver;
            this.winBox.Controls.Add(this.label3);
            this.winBox.Controls.Add(this.button1);
            this.winBox.Controls.Add(this.WynikKoniecWin);
            this.winBox.Controls.Add(this.label5);
            this.winBox.Location = new System.Drawing.Point(434, 42);
            this.winBox.Name = "winBox";
            this.winBox.Size = new System.Drawing.Size(608, 461);
            this.winBox.TabIndex = 12;
            this.winBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 97);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wynik:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MingLiU-ExtB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(203, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 122);
            this.button1.TabIndex = 8;
            this.button1.Text = "WYJSCIE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.exit);
            // 
            // WynikKoniecWin
            // 
            this.WynikKoniecWin.AutoSize = true;
            this.WynikKoniecWin.BackColor = System.Drawing.Color.Transparent;
            this.WynikKoniecWin.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WynikKoniecWin.Location = new System.Drawing.Point(373, 49);
            this.WynikKoniecWin.Name = "WynikKoniecWin";
            this.WynikKoniecWin.Size = new System.Drawing.Size(90, 97);
            this.WynikKoniecWin.TabIndex = 10;
            this.WynikKoniecWin.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGreen;
            this.label5.Font = new System.Drawing.Font("SimSun-ExtB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 97);
            this.label5.TabIndex = 6;
            this.label5.Text = "ZWYCIESTWO!";
            // 
            // przeciwnicy
            // 
            this.przeciwnicy.Enabled = true;
            this.przeciwnicy.Interval = 1;
            this.przeciwnicy.Tick += new System.EventHandler(this.przeciwnicy_Tick);
            // 
            // fire1
            // 
            this.fire1.Interval = 1;
            this.fire1.Tick += new System.EventHandler(this.fire1_Tick);
            // 
            // fire2
            // 
            this.fire2.Interval = 1;
            this.fire2.Tick += new System.EventHandler(this.fire2_Tick);
            // 
            // fire3
            // 
            this.fire3.Interval = 1;
            this.fire3.Tick += new System.EventHandler(this.fire3_Tick);
            // 
            // jettimer
            // 
            this.jettimer.Enabled = true;
            this.jettimer.Interval = 1;
            this.jettimer.Tick += new System.EventHandler(this.jettimer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "LOST:";
            // 
            // lostcounter
            // 
            this.lostcounter.AutoSize = true;
            this.lostcounter.BackColor = System.Drawing.Color.Gray;
            this.lostcounter.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lostcounter.Location = new System.Drawing.Point(875, 9);
            this.lostcounter.Name = "lostcounter";
            this.lostcounter.Size = new System.Drawing.Size(33, 35);
            this.lostcounter.TabIndex = 17;
            this.lostcounter.Text = "0";
            // 
            // hardgame
            // 
            this.hardgame.Enabled = true;
            this.hardgame.Interval = 30000;
            this.hardgame.Tick += new System.EventHandler(this.hardgame_Tick);
            // 
            // sekundy
            // 
            this.sekundy.AutoSize = true;
            this.sekundy.BackColor = System.Drawing.Color.Gray;
            this.sekundy.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekundy.Location = new System.Drawing.Point(492, 6);
            this.sekundy.Name = "sekundy";
            this.sekundy.Size = new System.Drawing.Size(51, 35);
            this.sekundy.TabIndex = 21;
            this.sekundy.Text = "30";
            // 
            // timestamp
            // 
            this.timestamp.AutoSize = true;
            this.timestamp.BackColor = System.Drawing.Color.Gray;
            this.timestamp.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timestamp.Location = new System.Drawing.Point(291, 6);
            this.timestamp.Name = "timestamp";
            this.timestamp.Size = new System.Drawing.Size(195, 35);
            this.timestamp.TabIndex = 22;
            this.timestamp.Text = "TIME LEFT:";
            // 
            // milisekundy
            // 
            this.milisekundy.AutoSize = true;
            this.milisekundy.BackColor = System.Drawing.Color.Gray;
            this.milisekundy.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milisekundy.Location = new System.Drawing.Point(549, 6);
            this.milisekundy.Name = "milisekundy";
            this.milisekundy.Size = new System.Drawing.Size(51, 35);
            this.milisekundy.TabIndex = 23;
            this.milisekundy.Text = "00";
            // 
            // sektimer
            // 
            this.sektimer.Enabled = true;
            this.sektimer.Interval = 1000;
            this.sektimer.Tick += new System.EventHandler(this.sektimer_Tick);
            // 
            // mstimer
            // 
            this.mstimer.Enabled = true;
            this.mstimer.Interval = 1;
            this.mstimer.Tick += new System.EventHandler(this.mstimer_Tick);
            // 
            // hp2
            // 
            this.hp2.Image = global::fighter.Properties.Resources.heart;
            this.hp2.Location = new System.Drawing.Point(53, 9);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(35, 32);
            this.hp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp2.TabIndex = 20;
            this.hp2.TabStop = false;
            // 
            // hp3
            // 
            this.hp3.Image = global::fighter.Properties.Resources.heart;
            this.hp3.Location = new System.Drawing.Point(94, 9);
            this.hp3.Name = "hp3";
            this.hp3.Size = new System.Drawing.Size(35, 32);
            this.hp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp3.TabIndex = 19;
            this.hp3.TabStop = false;
            // 
            // hp1
            // 
            this.hp1.Image = global::fighter.Properties.Resources.heart;
            this.hp1.Location = new System.Drawing.Point(12, 9);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(35, 32);
            this.hp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp1.TabIndex = 18;
            this.hp1.TabStop = false;
            // 
            // bullet2
            // 
            this.bullet2.BackColor = System.Drawing.Color.Transparent;
            this.bullet2.Image = global::fighter.Properties.Resources.bullets_PNG35578;
            this.bullet2.Location = new System.Drawing.Point(174, 224);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(21, 24);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 13;
            this.bullet2.TabStop = false;
            // 
            // bullet1
            // 
            this.bullet1.BackColor = System.Drawing.Color.Transparent;
            this.bullet1.Image = global::fighter.Properties.Resources.bullets_PNG35578;
            this.bullet1.Location = new System.Drawing.Point(174, 224);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(21, 24);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 12;
            this.bullet1.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::fighter.Properties.Resources.PinClipart_com_clip_art_helicopter_876533;
            this.enemy1.Location = new System.Drawing.Point(789, 157);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(126, 49);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::fighter.Properties.Resources.PinClipart_com_clip_art_helicopter_876533;
            this.enemy2.Location = new System.Drawing.Point(729, 248);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(126, 49);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy3
            // 
            this.enemy3.Image = global::fighter.Properties.Resources.PinClipart_com_clip_art_helicopter_876533;
            this.enemy3.Location = new System.Drawing.Point(812, 408);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(126, 49);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 1;
            this.enemy3.TabStop = false;
            // 
            // jet
            // 
            this.jet.BackColor = System.Drawing.Color.Transparent;
            this.jet.Image = global::fighter.Properties.Resources.samolot;
            this.jet.Location = new System.Drawing.Point(42, 204);
            this.jet.Name = "jet";
            this.jet.Size = new System.Drawing.Size(126, 44);
            this.jet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jet.TabIndex = 0;
            this.jet.TabStop = false;
            this.jet.Click += new System.EventHandler(this.jet_Click);
            // 
            // rakieton
            // 
            this.rakieton.Image = global::fighter.Properties.Resources.samolot2;
            this.rakieton.Location = new System.Drawing.Point(42, 213);
            this.rakieton.Name = "rakieton";
            this.rakieton.Size = new System.Drawing.Size(126, 54);
            this.rakieton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rakieton.TabIndex = 24;
            this.rakieton.TabStop = false;
            this.rakieton.Visible = false;
            // 
            // hp4
            // 
            this.hp4.Image = global::fighter.Properties.Resources.heart;
            this.hp4.Location = new System.Drawing.Point(133, 9);
            this.hp4.Name = "hp4";
            this.hp4.Size = new System.Drawing.Size(35, 32);
            this.hp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp4.TabIndex = 25;
            this.hp4.TabStop = false;
            this.hp4.Visible = false;
            // 
            // hp5
            // 
            this.hp5.Image = global::fighter.Properties.Resources.heart;
            this.hp5.Location = new System.Drawing.Point(174, 9);
            this.hp5.Name = "hp5";
            this.hp5.Size = new System.Drawing.Size(35, 32);
            this.hp5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hp5.TabIndex = 26;
            this.hp5.TabStop = false;
            this.hp5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1134, 611);
            this.Controls.Add(this.hp5);
            this.Controls.Add(this.hp4);
            this.Controls.Add(this.rakieton);
            this.Controls.Add(this.milisekundy);
            this.Controls.Add(this.timestamp);
            this.Controls.Add(this.sekundy);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.winBox);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp3);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.lostcounter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.endmenu);
            this.Controls.Add(this.scoretext);
            this.Controls.Add(this.punkty);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.jet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.endmenu.ResumeLayout(false);
            this.endmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            this.winBox.ResumeLayout(false);
            this.winBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rakieton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox jet;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.Label punkty;
        private System.Windows.Forms.Label scoretext;
        private System.Windows.Forms.Label koniec;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wynikKoniec;
        private System.Windows.Forms.GroupBox endmenu;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.Timer przeciwnicy;
        private System.Windows.Forms.Timer fire1;
        private System.Windows.Forms.Timer fire2;
        private System.Windows.Forms.Timer fire3;
        private System.Windows.Forms.Timer jettimer;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lostcounter;
        private System.Windows.Forms.PictureBox hp1;
        private System.Windows.Forms.PictureBox hp3;
        private System.Windows.Forms.PictureBox hp2;
        private System.Windows.Forms.Timer hardgame;
        private System.Windows.Forms.GroupBox winBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label WynikKoniecWin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label sekundy;
        private System.Windows.Forms.Label timestamp;
        private System.Windows.Forms.Label milisekundy;
        private System.Windows.Forms.Timer sektimer;
        private System.Windows.Forms.Timer mstimer;
        private System.Windows.Forms.PictureBox rakieton;
        private System.Windows.Forms.PictureBox hp4;
        private System.Windows.Forms.PictureBox hp5;
    }
}

