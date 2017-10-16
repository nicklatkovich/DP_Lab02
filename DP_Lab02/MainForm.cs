using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP_Lab02 {
    public partial class MainForm : Form {
        public MainForm( ) {
            InitializeComponent( );
        }

        private void Button_OpenFile_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                RestoreDirectory = true,
            };
            if (ofd.ShowDialog( ) == DialogResult.OK) {
#if !DEBUG
                try {
#endif
                TextBox_InputText.Text = TextBox_InputSignal.Text = File.ReadAllText(ofd.FileName);
#if !DEBUG
                } catch (Exception exception) {
                    MessageBox.Show(exception.Message);
                }
#endif
            }
        }

        private void TextBox_InputText_TextChanged(object sender, EventArgs e) {
            ListBox_Probabilities.Items.Clear( );
            Dictionary<char, ulong> charDictionary = new Dictionary<char, ulong>( );
            ulong charsNumber = 0ul;
            char prevChar = '\0';
            foreach (char c in TextBox_InputText.Text) {
                if (char.IsLetter(c)) {
                    char cToUp = char.ToUpper(c);
                    if (!charDictionary.ContainsKey(cToUp)) {
                        charDictionary[cToUp] = 0ul;
                    }
                    charDictionary[cToUp]++;
                    charsNumber++;
                    prevChar = cToUp;
                }
            }
            // Shannon 
            double shannonEntropy = 0d;
            List<Tuple<char, double>> listOfProbabilities = new List<Tuple<char, double>>( );
            foreach (KeyValuePair<char, ulong> pair in charDictionary) {
                double probability = (double)pair.Value / charsNumber;
                listOfProbabilities.Add(new Tuple<char, double>(pair.Key, probability));
                shannonEntropy += probability * Math.Log(probability, 2);
            }
            listOfProbabilities.Sort(new Comparison<Tuple<char, double>>(
                (Tuple<char, double> tupple1, Tuple<char, double> tupple2) =>
                tupple2.Item2.CompareTo(tupple1.Item2)));
            foreach (Tuple<char, double> listItem in listOfProbabilities) {
                ListBox_Probabilities.Items.Add(
                    listItem.Item1 + " - " + (listItem.Item2 * 100d).ToString("0.0000") + "%");
            }
            shannonEntropy = -shannonEntropy;
            Label_Shannon.Text = "Shannon = " + shannonEntropy.ToString( );

            // Conditional
            Label_Hartley.Text = "Hartley = " + Math.Log(charsNumber, 2).ToString( );

            // Effective
            ulong errorsCount = (ulong)Math.Abs(TextBox_InputText.Text.Length - TextBox_InputSignal.Text.Length);
            for (int i = 0; i < Math.Min(TextBox_InputText.Text.Length, TextBox_InputSignal.Text.Length); i++) {
                if (TextBox_InputText.Text[i] != TextBox_InputSignal.Text[i]) {
                    errorsCount++;
                }
            }
            double error =
                (double)errorsCount / Math.Max(TextBox_InputText.Text.Length, TextBox_InputSignal.Text.Length);
            double right = 1d - error;
            double conditionalEntropy = (-error * Math.Log(error, 2) - right * Math.Log(right, 2));
            Label_Conditional.Text =
                "Conditional = " + (conditionalEntropy == double.NaN ? "NaN" : conditionalEntropy.ToString( ));
        }
    }
}
