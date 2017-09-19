using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace DP_Lab02 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
        }

        private void Button_OpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true
            };
            if (ofd.ShowDialog() == DialogResult.OK) {
                try {
                    TextBox_InputText.Text = File.ReadAllText(ofd.FileName);
                } catch {
                    // TODO: show error message
                }
            }
        }

        private void TextBox_InputText_TextChanged(object sender, EventArgs e) {
            ListBox_Entropy.Items.Clear( );
            Dictionary<char, ulong> charDictionary = new Dictionary<char, ulong>( );
            ulong charsNumber = 0ul;
            foreach (char c in TextBox_InputText.Text) {
                if (char.IsLetter(c)) {
                    char cToUp = char.ToUpper(c);
                    if (charDictionary.ContainsKey(cToUp)) {
                        charDictionary[cToUp]++;
                    } else {
                        charDictionary[cToUp] = 1ul;
                    }
                    charsNumber++;
                }
            }
            double entropy = 0d;
            foreach (KeyValuePair<char, ulong> pair in charDictionary) {
                double probability = (double)pair.Value / charsNumber;
                ListBox_Entropy.Items.Add(pair.Key + " - " + (probability * 100d).ToString(".0000") + "%");
                entropy += probability * Math.Log(probability, 2);
            }
            entropy = -entropy;
            Label_Entropy.Text = "Entropy = " + entropy.ToString( );
        }
    }
}
