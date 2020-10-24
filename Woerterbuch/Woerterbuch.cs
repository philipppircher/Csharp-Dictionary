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

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        Dictionary<string, string> germanToFrenchDict = new Dictionary<string, string>();
        public Woerterbuch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGermanWord.Text;
            var frenchWord = tbFrenchWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(frenchWord))
            {
                germanToFrenchDict.Add(germanWord, frenchWord);
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            lBoxGermanWords.DataSource = germanToFrenchDict.Keys.ToList();
        }

        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && germanToFrenchDict.ContainsKey(selectedWord))
            {
                tbTranslation.Text = germanToFrenchDict[selectedWord];
            }
        }

        private void btn_ExportToCsv_Click(object sender, EventArgs e)
        {

        }
    }
}
