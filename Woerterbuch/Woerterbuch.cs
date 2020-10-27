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
        Dictionary<string, string> germanToEnglishDict = new Dictionary<string, string>();
        Dictionary<string, string> englishToFrenchDict = new Dictionary<string, string>();
        Dictionary<string, string> selectedDictionary = null;
        List<Dictionary<string, string>> listOfDictionaries = new List<Dictionary<string, string>>();
        private string filePath, selectedFile, filePathDeToEn, filePathDeToFr, filePathEnToFr;

        public Woerterbuch()
        {
            InitializeComponent();

            AddAllDictionariesToList();
            SetSelectedDictionary();
            SetLabelToDictionaryName(0);

            SetFilePaths();
            SetSelectedDictionary();
            ReadAllExternalFiles();

            UpdateTranslations();
        }   

        private void SetFilePaths()
        {
            filePath = @"C:\Users\DCV\Desktop\Code\05 C#\Woerterbuch\Woerterbuch\bin\Debug";
            filePathDeToEn = @"\deToEn.txt";
            filePathDeToFr = @"\deToFr.txt";
            filePathEnToFr = @"\enToFr.txt";
        }
        private void AddAllDictionariesToList()
        {
            listOfDictionaries.Add(germanToEnglishDict);
            listOfDictionaries.Add(germanToFrenchDict);
            listOfDictionaries.Add(englishToFrenchDict);
        }

        private void SetSelectedDictionary()
        {
            selectedDictionary = germanToEnglishDict;
        }

        private void lBoxFromWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxFromWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && selectedDictionary.ContainsKey(selectedWord))
            {
                tbTranslation.Text = selectedDictionary[selectedWord];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fromWord = tbFromWord.Text;
            var toWord = tbToWord.Text;

            if (!string.IsNullOrEmpty(fromWord) && !string.IsNullOrEmpty(toWord))
            {
                selectedDictionary.Add(fromWord, toWord);
                SetFromTextboxAndToTextboxEmptyString();
                UpdateTranslations();
            }
        }

        private void UpdateTranslations()
        {
            lBoxFromWords.DataSource = selectedDictionary.Keys.ToList();
        }

        private void WriteTxtFile(string path, Dictionary<string, string> dict)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var element in selectedDictionary)
                {
                    writer.WriteLine(element.Key + ";" + element.Value);
                }
            }
        }

        private void ReadAllExternalFiles()
        {
            ReadExternalFile(filePathDeToEn, germanToEnglishDict);
            ReadExternalFile(filePathDeToFr, germanToFrenchDict);
            ReadExternalFile(filePathEnToFr, englishToFrenchDict);
        }

        private void ReadExternalFile(string fileName, Dictionary<string, string> dict)
        {
            string[] lines = System.IO.File.ReadLines(this.filePath + fileName).ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');
                dict.Add(temp[0], temp[1]);
            }
        }

        private void btn_ExportToCsv_Click(object sender, EventArgs e)
        {
            WriteTxtFile(filePath +  selectedFile,selectedDictionary);
        }

        private void SetFromTextboxAndToTextboxEmptyString()
        {
            tbFromWord.Text = "";
            tbToWord.Text = "";
        }

        private void SetLabelToDictionaryName(int currentSelectedValue)
        {
            switch (currentSelectedValue)
            {
                case 0:
                    lbTranslation.Text = "de <> en";
                    selectedFile = filePathDeToEn;
                    break;
                case 1:
                    lbTranslation.Text = "de <> fr";
                    selectedFile = filePathDeToFr;
                    break;
                case 2:
                    lbTranslation.Text = "en <> fr";
                    selectedFile = filePathEnToFr;
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int currentSelectedValue = Convert.ToInt32(numericUpDown1.Value);
            selectedDictionary = listOfDictionaries[currentSelectedValue];

            SetFromTextboxAndToTextboxEmptyString();
            SetLabelToDictionaryName(currentSelectedValue);
            UpdateTranslations();
        }
    }
}
