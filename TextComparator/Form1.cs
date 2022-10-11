/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2022, Aioanei A., Burechita C., Sprinceana R, Chirila *
 *  Description: Text Comparator                                          *
 *                                                                        *
 **************************************************************************/

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

namespace TextComparator
{

    public partial class Form1 : Form
    {
        string filename, filename1;
        string readFile, readFile1;
        string aux;
       

        static List<string> diff = new List<string>(); // Lista de cuvinte diferite din cel de-al doilea fisier
        


        public Form1()
        {
            InitializeComponent();
        }



        private void LoadFile1(object sender, EventArgs e)// Primul buton de load files 
        {
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            readFile = File.ReadAllText(filename);
            richTextBoxFile1.Text = readFile;
        }

        private void LoadFile2(object sender, EventArgs e)//Al doilea buton de load files
        {
            openFileDialog2.ShowDialog();
            filename1 = openFileDialog2.FileName;
            readFile1 = File.ReadAllText(filename1);
            richTextBoxFile2.Text = readFile1;

        }

        private void HelpButton(object sender, EventArgs e)// Butonul de Help
        {
            //Help.ShowHelp(this, "help.chm");
            System.Diagnostics.Process.Start("help.chm");
        }

        private void ExitButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void CompareTexts(object sender, EventArgs e)// Butonul de Compare
        {

            textBoxNrCuvinteDiff.Clear();

            string text = "";

            try
            {
                text = Difference.Difference.DifferenceF(readFile, readFile1, ref diff);
                List<string> words = text.Split(' ').ToList();
                words.RemoveAt(words.Count - 1);
                text = string.Join(" ", words);
                aux = diff[diff.Count-1];
                diff.RemoveAt(diff.Count - 1);
                textBoxNrCuvinteDiff.Clear();
                textBoxNrCuvinteDiff.Text = aux;// Afisarea numarului de cuvinte diferite
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            richTextBox3.Text = text;
            try
            {


                List<string> newSet = new List<string>();
                List<string> set2 = readFile1.Split(new char[] { ' ', '\t' }).ToList();

                richTextBoxFile2.Clear();

                foreach (string str in set2)
                {
                    Font font = new Font("Tahoma", 8, FontStyle.Regular);
                    richTextBoxFile2.SelectionFont = font;
                    richTextBoxFile2.SelectionColor = Color.Black;


                    if (diff.Contains(str))// Evidentierea cu rosu a textului diferit din fisierul al doilea
                    {
                        richTextBoxFile2.SelectionColor = Color.Red;
                        richTextBoxFile2.SelectedText += (str + " ");
                    }
                    else
                    {
                        richTextBoxFile2.SelectionColor = Color.Black;
                        richTextBoxFile2.SelectedText += (str + " ");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    
        
    }
    
}
