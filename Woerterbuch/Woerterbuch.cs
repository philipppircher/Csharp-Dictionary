﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WoerterbuchLogic;

namespace Woerterbuch
{
    public partial class Woerterbuch : Form
    {
        WoerterbuchController controller;

        public Woerterbuch()
        {
            InitializeComponent();

            controller = new WoerterbuchController();
            SetLabelToDictionaryName(0);
        }   

        private void lBoxFromWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxFromWords.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedWord) && controller.selectedDictionary.ContainsKey(selectedWord))
            {
                tbTranslation.Text = controller.selectedDictionary[selectedWord];
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var fromWord = tbFromWord.Text;
            var toWord = tbToWord.Text;

            try
            {
                controller.AddEntryToDictionary(fromWord, toWord);
                MessageBox.Show("Ein neues Wort wurde dem Wörterbuch hinzugefügt");
                SetFromTextboxAndToTextboxEmptyString();
                UpdateTranslations();
            }
            catch (ExceptionEmptyWords ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbSearchInputInDict_TextChanged(object sender, EventArgs e)
        {
            var list = controller.selectedDictionary
                .Where(x => x.Key.Contains(tbSearchInputInDict.Text) )
                .Select(x => x.Key).ToList();
            lBoxFromWords.DataSource = list;
        }

        private void lvLettersSelection_ItemActivate(object sender, EventArgs e)
        {
            PrintEntriesBySelectedLetter();
        }

        private void PrintEntriesBySelectedLetter()
        {
            string selectedLetter = lvLettersSelection.SelectedItems[0].Text;
            List<string> listUnion = GetUpperLowerCaseList(selectedLetter);

            lBoxFromWords.DataSource = listUnion;
            tbTranslation.Text = "";
        }

        private List<string> GetUpperLowerCaseList(string selectedLetter)
        {
            var listUpperCaseLetter = controller.GetListFromSelectedLetter(selectedLetter.ToUpper());
            var listLowerCaseLetter = controller.GetListFromSelectedLetter(selectedLetter.ToLower());
            var listUnion = controller.UnionLists(listUpperCaseLetter, listLowerCaseLetter);
            return listUnion;
        }

        private void Woerterbuch_Load(object sender, EventArgs e)
        {

        }

        private void UpdateTranslations()
        {
            lBoxFromWords.DataSource = controller.selectedDictionary
                .OrderByDescending(myWord => myWord.Key)
                .Select(x => $"{x.Key} // {x.Value}")
                .ToList();
        }

        private void btn_ExportToCsv_Click(object sender, EventArgs e)
        {
            try
            {
                controller.WriteTxtFile();
                MessageBox.Show("Wörterbuch als CSV exportiert\n\n" + controller.SelectedFilePath);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("Wörterbuch als CSV exportieren fehlgeschlagen\n\n" + ex.Message);
            }
        }

        private void SetFromTextboxAndToTextboxEmptyString()
        {
            tbFromWord.Text = "";
            tbToWord.Text = "";
        }

        private void SetLabelToDictionaryName(int currentSelectedValue)
        {
            controller.SetSelectedDictionary(currentSelectedValue);
            UpdateTranslations();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int currentSelectedValue = Convert.ToInt32(numericUpDown1.Value);
            controller.selectedDictionary = controller.listOfDictionaries[currentSelectedValue];

            SetFromTextboxAndToTextboxEmptyString();
            SetLabelToDictionaryName(currentSelectedValue);
            UpdateTranslations();
            tbTranslation.Text = "";
        }
    }
}
