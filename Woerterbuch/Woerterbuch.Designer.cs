namespace Woerterbuch
{
    partial class Woerterbuch
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("A");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("B");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("C");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("D");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("E");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("F");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("G");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("H");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("I");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("J");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("K");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("L");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("M");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("N");
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("O");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("P");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("Q");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("R");
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("S");
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("T");
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("U");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("V");
            System.Windows.Forms.ListViewItem listViewItem23 = new System.Windows.Forms.ListViewItem("W");
            System.Windows.Forms.ListViewItem listViewItem24 = new System.Windows.Forms.ListViewItem("X");
            System.Windows.Forms.ListViewItem listViewItem25 = new System.Windows.Forms.ListViewItem("Y");
            System.Windows.Forms.ListViewItem listViewItem26 = new System.Windows.Forms.ListViewItem("Z");
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFromWord = new System.Windows.Forms.TextBox();
            this.tbToWord = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.lBoxFromWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btn_ExportToCsv = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbSearchInputInDict = new System.Windows.Forms.TextBox();
            this.lvLettersSelection = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 90);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFromWord
            // 
            this.tbFromWord.Location = new System.Drawing.Point(63, 50);
            this.tbFromWord.Name = "tbFromWord";
            this.tbFromWord.Size = new System.Drawing.Size(197, 22);
            this.tbFromWord.TabIndex = 1;
            // 
            // tbToWord
            // 
            this.tbToWord.Location = new System.Drawing.Point(358, 50);
            this.tbToWord.Name = "tbToWord";
            this.tbToWord.Size = new System.Drawing.Size(167, 22);
            this.tbToWord.TabIndex = 1;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(279, 55);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(57, 17);
            this.lbTranslation.TabIndex = 2;
            this.lbTranslation.Text = "FromTo";
            // 
            // lBoxFromWords
            // 
            this.lBoxFromWords.FormattingEnabled = true;
            this.lBoxFromWords.ItemHeight = 16;
            this.lBoxFromWords.Location = new System.Drawing.Point(63, 150);
            this.lBoxFromWords.Name = "lBoxFromWords";
            this.lBoxFromWords.Size = new System.Drawing.Size(326, 116);
            this.lBoxFromWords.TabIndex = 3;
            this.lBoxFromWords.SelectedIndexChanged += new System.EventHandler(this.lBoxFromWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(395, 150);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(130, 22);
            this.tbTranslation.TabIndex = 4;
            // 
            // btn_ExportToCsv
            // 
            this.btn_ExportToCsv.Location = new System.Drawing.Point(395, 194);
            this.btn_ExportToCsv.Name = "btn_ExportToCsv";
            this.btn_ExportToCsv.Size = new System.Drawing.Size(130, 23);
            this.btn_ExportToCsv.TabIndex = 5;
            this.btn_ExportToCsv.Text = "Export CSV";
            this.btn_ExportToCsv.UseVisualStyleBackColor = true;
            this.btn_ExportToCsv.Click += new System.EventHandler(this.btn_ExportToCsv_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(298, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 22);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbSearchInputInDict
            // 
            this.tbSearchInputInDict.Location = new System.Drawing.Point(63, 122);
            this.tbSearchInputInDict.Name = "tbSearchInputInDict";
            this.tbSearchInputInDict.Size = new System.Drawing.Size(197, 22);
            this.tbSearchInputInDict.TabIndex = 7;
            this.tbSearchInputInDict.TextChanged += new System.EventHandler(this.tbSearchInputInDict_TextChanged);
            // 
            // lvLettersSelection
            // 
            this.lvLettersSelection.HideSelection = false;
            this.lvLettersSelection.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22,
            listViewItem23,
            listViewItem24,
            listViewItem25,
            listViewItem26});
            this.lvLettersSelection.Location = new System.Drawing.Point(17, 46);
            this.lvLettersSelection.MultiSelect = false;
            this.lvLettersSelection.Name = "lvLettersSelection";
            this.lvLettersSelection.Size = new System.Drawing.Size(29, 219);
            this.lvLettersSelection.TabIndex = 9;
            this.lvLettersSelection.UseCompatibleStateImageBehavior = false;
            this.lvLettersSelection.View = System.Windows.Forms.View.List;
            this.lvLettersSelection.ItemActivate += new System.EventHandler(this.lvLettersSelection_ItemActivate);
            // 
            // Woerterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 278);
            this.Controls.Add(this.lvLettersSelection);
            this.Controls.Add(this.tbSearchInputInDict);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_ExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxFromWords);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbToWord);
            this.Controls.Add(this.tbFromWord);
            this.Controls.Add(this.btnAdd);
            this.Name = "Woerterbuch";
            this.Text = "Woerterbuch";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbFromWord;
        private System.Windows.Forms.TextBox tbToWord;
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.ListBox lBoxFromWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btn_ExportToCsv;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox tbSearchInputInDict;
        private System.Windows.Forms.ListView lvLettersSelection;
    }
}

