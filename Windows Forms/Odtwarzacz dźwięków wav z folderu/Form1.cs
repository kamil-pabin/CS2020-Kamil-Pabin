using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BindMaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EnsurePathExists(Directory.GetCurrentDirectory() + (@"\sounds"));
        }
        public static void EnsurePathExists(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception) { }
        }
        private void okresleniesciezki(object sender, EventArgs e)
        {            
            string calosc = sender.ToString();
            string nazwaButtonu = calosc.Split().Last();           
            player(nazwaButtonu);
        }
        private void player(string plik)
        {
            string path = Directory.GetCurrentDirectory();
            string sciezka = path + (@"\sounds\") + plik;
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(sciezka);
            player.Play();
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Directory.GetCurrentDirectory() + (@"\sounds"));
            FileInfo[] Files = dinfo.GetFiles("*.wav");
            foreach (FileInfo file in Files)
            {
                listBox1.Items.Add(file.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
