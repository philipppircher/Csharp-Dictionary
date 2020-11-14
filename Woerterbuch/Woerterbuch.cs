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
            SetSelectedDictionaryByStart();

            SetFilePaths();
            SetSelectedDictionaryByStart();
            ReadAllExternalFiles();

            UpdateTranslations();
            SetLabelToDictionaryName(0);
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
        
        private void SetSelectedDictionaryByStart()
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
            lBoxFromWords.DataSource = selectedDictionary
                .OrderByDescending(myWord => myWord.Key)
                .Select(x => $"{x.Key} // {x.Value}") 
                .ToList();

            //var anyLl = selectedDictionary.Any(x => x.Key.Contains("ll"));
            //var anyLl = selectedDictionary.FirstOrDefault(x => x.Key.Contains("ll"));
            //var anyLl = selectedDictionary.First(x => x.Key.Contains("xxx"));

            /* Test Code --
             * 
            var numberList = new List<int>();
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
            numberList.Add(4);
            numberList.Add(5);
            numberList.Add(50);

            int val = numberList.Max();
            int val2 = numberList.Min();
            double val3 = numberList.Average();
            int sum = numberList.Sum();
            int val4 = numberList.Skip(3).Sum();

            var numberList2 = new List<int>();
            numberList2.Add(1000);
            List<int> anyL = numberList2.Union(numberList).ToList();

            var myNewList = from number in numberList
                            where number % 2 == 0 && number > 2
                            select number;

            var myNewList2 = myNewList.ToList();
            */
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

        private void tbSearchInputInDict_TextChanged(object sender, EventArgs e)
        {
            var list = selectedDictionary
                .Where(x => x.Key.Contains(tbSearchInputInDict.Text) )
                .Select(x => x.Key).ToList();
            lBoxFromWords.DataSource = list;
        }

        private void lvLettersSelection_ItemActivate(object sender, EventArgs e)
        {
            string selectedLetter = lvLettersSelection.SelectedItems[0].Text;

            var listUpperCaseLetter = GetListFromSelectedLetter(selectedLetter.ToUpper());
            var listLowerCaseLetter = GetListFromSelectedLetter(selectedLetter.ToLower());
            var listUnion = UnionLists(listUpperCaseLetter, listLowerCaseLetter);

            lBoxFromWords.DataSource = listUnion;
        }

        private List<string> UnionLists(List<string> upperCase, List<string> lowerCase)
        {
            var listUpperAndLowerCase = upperCase.Union(lowerCase).ToList();

            if (listUpperAndLowerCase.Count == 0)
            {
                listUpperAndLowerCase.Add("Keine Wörter für diesen Buchstaben vorhanden.");
            }

            return listUpperAndLowerCase;
        }

        private List<string> GetListFromSelectedLetter(string letter)
        {
            var list = selectedDictionary
               .Where(x => x.Key.StartsWith(letter))
               .Select(x => x.Key).ToList();
            return list;
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
