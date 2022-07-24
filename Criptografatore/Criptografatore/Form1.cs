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

namespace Criptografatore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CriTextBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (CriTextBox.Text.Length > 5 && CriTextBox.Text.Length <= 30)
            {
                e.Cancel = false;
                CriTextBox.ForeColor = Color.Green;
                error.SetError(CriTextBox, null);
            }
            else
            {
                e.Cancel = true;
                CriTextBox.ForeColor = Color.Red;
                error.SetError(CriTextBox, "chiave poco sicura (min 6)");
                CriTextBox.Focus();

            }
        }
        private void DecriTextBox_Validating(object sender, CancelEventArgs e)
        {
            ErrorProvider error = new ErrorProvider();
            if (DecriTextBox.Text.Length > 5 && DecriTextBox.Text.Length <= 30)
            {
                e.Cancel = false;
                DecriTextBox.ForeColor = Color.Green;
                error.SetError(DecriTextBox, null);
            }
            else
            {
                e.Cancel = true;
                DecriTextBox.ForeColor = Color.Red;
                error.SetError(DecriTextBox, "chiave poco sicura (min 6)");
                DecriTextBox.Focus();

            }
        }


        private void CritButton_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (ValidateChildren(ValidationConstraints.Visible))
            {
                openFileDialog1.Filter = "*.txt|";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = openFileDialog1.FileName;
                    string[] linee = File.ReadAllLines(FilePath);
                    string[] crpStr = new string[linee.Length];
                    for (int j = 0; j < linee.Length; j++)
                    {
                        foreach (char ch in linee[j])
                        {
                            int code = ch + CriTextBox.Text[x % CriTextBox.Text.Length] + Fibonacci(x % CriTextBox.Text.Length *2);
                            //MessageBox.Show(((char)(code+1)).ToString());
                            //MessageBox.Show(code.ToString());
                            crpStr[j] += (char)code;
                            x++;
                        }

                    }
                    File.WriteAllLines(Directory.GetParent(FilePath) + "//Crittograta.txt", crpStr);
                    MessageBox.Show("CRITTOGRAFIA COMPLETATA");
                }
            }
        }

        private void DecriButton_Click(object sender, EventArgs e)
        {
            int x = 0;

            if (ValidateChildren(ValidationConstraints.Visible))
            {
                openFileDialog1.Filter = "*.txt|";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = openFileDialog1.FileName;
                    string[] linee = File.ReadAllLines(FilePath);
                    string[] crpStr = new string[linee.Length];
                    for (int j = 0; j < linee.Length; j++)
                    {
                        foreach (char ch in linee[j])
                        {
                            int code = ch - DecriTextBox.Text[x % DecriTextBox.Text.Length] - Fibonacci(x % DecriTextBox.Text.Length * 2);
                            crpStr[j] += (char)code;
                            x++;
                        }

                    }
                    File.WriteAllLines(Directory.GetParent(FilePath) + "//Decrittograta.txt", crpStr);
                    MessageBox.Show("DECRITTOGRAFIA COMPLETATA");
                }
            }
        }



        public static int Fibonacci(int number)
        {
            if (number <= 1)
                return 1;
            else
                return Fibonacci(number - 2) + Fibonacci(number - 1);
        }

    }


}
