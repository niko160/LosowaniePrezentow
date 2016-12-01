using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LosowaniePrezentow
{
    public partial class Form1 : Form
    {
        DodawaniaOsob nowa = new DodawaniaOsob();

        public Form1()
        {
            InitializeComponent();
            this.ReadingFromFile();
            
           
            
        }

        private void MakeList_Click(object sender, EventArgs e)
        {
            new DodawaniaOsob().Show();
            DodawaniaOsob PersonList = new DodawaniaOsob();
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomPerson_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Wylosowałeś : {0}", PersonChecked.Text);
        }

        private void ReadingFromFile()
        {
            StreamReader read = new StreamReader(@"C:\Users\dnikodex\Documents\Visual Studio 2013\Projects\ZadaniaCSharp\LosowaniePrezentow\LosowaniePrezentow\Osoby.txt");

            string linia = null;
            while (!read.EndOfStream)
            {
                linia = read.ReadToEnd();
                MessageBox.Show(linia);
            }
            


        }


    }
}
