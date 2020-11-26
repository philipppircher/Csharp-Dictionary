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
        private string originPath, filePath;

        public string SelectedFilePath
        {
            get
            { return filePath; }
            set
            {
                filePath = originPath;
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

        /// <summary>
        /// Adds a new entry to selected dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void AddEntryToDictionary(string key, string value)
        {
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            {
                selectedDictionary.Add(key, value);
            }
            else
            {
                throw new ExceptionEmptyWords();
            }
        }

        /// <summary>
        /// Set paths of all dictionaries as string
        /// </summary>
        private void SetFilePaths()
        {
            originPath = @"C:\Users\DCV\Desktop\Code\05 C#\Woerterbuch\WoerterbuchLogic\bin\Debug\netstandard2.0";
            filePath = originPath;

            filePathDeToEn = @"\deToEn.txt";
            filePathDeToFr = @"\deToFr.txt";
            filePathEnToFr = @"\enToFr.txt";
        }

        /// <summary>
        /// Add all dictionaries in one list of dictionaries
        /// </summary>
        private void AddAllDictionariesToList()
        {
            listOfDictionaries.Add(germanToEnglishDict);
            listOfDictionaries.Add(germanToFrenchDict);
            listOfDictionaries.Add(englishToFrenchDict);
        }

        /// <summary>
        /// Set dictionary by int value
        /// </summary>
        /// <param name="currentIndex"></param>
        public void SetSelectedDictionary(int currentIndex)
        {
            selectedDictionary = listOfDictionaries[currentIndex];
            SetSelectedFilePath(currentIndex);
        }

        /// <summary>
        /// Set selectedfile path by int value
        /// </summary>
        /// <param name="currentIndex"></param>
        private void SetSelectedFilePath(int currentIndex)
        {
            switch (currentIndex)
            {
                case 0:
                    SelectedFilePath = filePathDeToEn;
                    break;
                case 1:
                    SelectedFilePath = filePathDeToFr;
                    break;
                case 2:
                    SelectedFilePath = filePathEnToFr;
                    break;
            }
        }

        /// <summary>
        /// Write all entries of selectedDictionary to SelectedFilePath
        /// </summary>
        public void WriteTxtFile()
        {
            using (StreamWriter writer = new StreamWriter(SelectedFilePath))
            {
                foreach (var element in selectedDictionary)
                {
                    writer.WriteLine(element.Key + ";" + element.Value);
                }
            }
        }

        /// <summary>
        /// Reads every file of path and
        /// </summary>
        private void ReadAllExternalFiles()
        {
            ReadExternalFile(filePathDeToEn, germanToEnglishDict);
            ReadExternalFile(filePathDeToFr, germanToFrenchDict);
            ReadExternalFile(filePathEnToFr, englishToFrenchDict);
        }

        /// <summary>
        /// Read a single external file from associated path and add entries to dictionary
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="dict"></param>
        private void ReadExternalFile(string fileName, Dictionary<string, string> dict)
        {
            string[] lines = System.IO.File.ReadLines(originPath + fileName).ToArray();

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(';');
                dict.Add(temp[0], temp[1]);
            }
        }

        /// <summary>
        /// Merge 2 lists together and returns them as one list
        /// </summary>
        /// <param name="upperCase"></param>
        /// <param name="lowerCase"></param>
        /// <returns></returns>
        public List<string> UnionLists(List<string> upperCase, List<string> lowerCase)
        {
            var listUpperAndLowerCase = upperCase.Union(lowerCase).ToList();

            if (listUpperAndLowerCase.Count == 0)
            {
                listUpperAndLowerCase.Add("Keine Wörter für diesen Buchstaben vorhanden.");
            }

            return listUpperAndLowerCase;
        }

        /// <summary>
        /// Returns a list from selected Letter
        /// </summary>
        /// <param name="letter"></param>
        /// <returns></returns>
        public List<string> GetListFromSelectedLetter(string letter)
        {
            var list = selectedDictionary
               .Where(x => x.Key.StartsWith(letter))
               .Select(x => x.Key).ToList();
            return list;
        }
    }
}