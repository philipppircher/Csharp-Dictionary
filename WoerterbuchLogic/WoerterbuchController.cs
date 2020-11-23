
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WoerterbuchLogic
{
    public sealed class WoerterbuchController
    {
        public Dictionary<string, string> germanToFrenchDict = new Dictionary<string, string>();
        public Dictionary<string, string> germanToEnglishDict = new Dictionary<string, string>();
        public Dictionary<string, string> englishToFrenchDict = new Dictionary<string, string>();
        public Dictionary<string, string> selectedDictionary = null;
        public List<Dictionary<string, string>> listOfDictionaries = new List<Dictionary<string, string>>();
        public string filePathDeToEn, filePathDeToFr, filePathEnToFr;
        private string orignPath, filePath;

        public string SelectedFile 
        { 
            get 
            { return filePath; } 
            set 
            {
                filePath = orignPath;
                filePath += value; 
            } 
        }

        public WoerterbuchController()
        {
            SetFilePaths();
            AddAllDictionariesToList();
            SetSelectedDictionary(0);
            ReadAllExternalFiles();
        }

        private void SetFilePaths()
        {
            orignPath = @"C:\Users\DCV\Desktop\Code\05 C#\Woerterbuch\WoerterbuchLogic\bin\Debug\netstandard2.0";
            filePath = orignPath;

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

        public void SetSelectedDictionary(int currentIndex)
        {
            selectedDictionary = listOfDictionaries[currentIndex];
            SetSelectedFilePath(currentIndex);
        }

        private void SetSelectedFilePath(int currentIndex)
        {
            switch (currentIndex)
            {
                case 0: 
                    SelectedFile = filePathDeToEn;
                    break;
                case 1:
                    SelectedFile = filePathDeToFr;
                    break;
                case 2:
                    SelectedFile = filePathEnToFr;
                    break;
            }
        }

        public void WriteTxtFile()
        {
            using (StreamWriter writer = new StreamWriter(SelectedFile))
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
            string[] lines = System.IO.File.ReadLines(orignPath + fileName).ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');
                dict.Add(temp[0], temp[1]);
            }
        }

        public List<string> UnionLists(List<string> upperCase, List<string> lowerCase)
        {
            var listUpperAndLowerCase = upperCase.Union(lowerCase).ToList();

            if (listUpperAndLowerCase.Count == 0)
            {
                listUpperAndLowerCase.Add("Keine Wörter für diesen Buchstaben vorhanden.");
            }

            return listUpperAndLowerCase;
        }

        public List<string> GetListFromSelectedLetter(string letter)
        {
            var list = selectedDictionary
               .Where(x => x.Key.StartsWith(letter))
               .Select(x => x.Key).ToList();
            return list;
        }
    }
}
