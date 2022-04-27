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

namespace cdrkontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void btndosyagetir_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                FileInfo fi = new FileInfo(file.FileName);
                if (fi.Exists)
                {
                    var dosyalar = File.ReadLines(@file.FileName.ToString());
                    foreach (var dosya in dosyalar)
                    {
                        listBox1.Items.Add(dosya);
                    }
                }
                else 
                {
                    
                }
            }
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btndosyacopy_Click(object sender, EventArgs e)
        {
            foreach(var dosyaismi in listBox1.Items)
            {
                string kaynak = @"C:\Dosyalar\" + dosyaismi.ToString() +".cdr";
                string hedef = @"C:\Kopyalar\" + dosyaismi.ToString() + ".cdr";

                if (System.IO.File.Exists(kaynak))
                {
                    File.Copy(kaynak, hedef, true);
                }
                else { }

            }

        }      
    }
}
