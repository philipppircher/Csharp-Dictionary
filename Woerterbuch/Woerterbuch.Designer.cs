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
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbFromWord = new System.Windows.Forms.TextBox();
            this.tbToWord = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.lBoxFromWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btn_ExportToCsv = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 145);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbFromWord
            // 
            this.tbFromWord.Location = new System.Drawing.Point(21, 101);
            this.tbFromWord.Name = "tbFromWord";
            this.tbFromWord.Size = new System.Drawing.Size(207, 22);
            this.tbFromWord.TabIndex = 1;
            // 
            // tbToWord
            // 
            this.tbToWord.Location = new System.Drawing.Point(328, 101);
            this.tbToWord.Name = "tbToWord";
            this.tbToWord.Size = new System.Drawing.Size(155, 22);
            this.tbToWord.TabIndex = 1;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(253, 106);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(57, 17);
            this.lbTranslation.TabIndex = 2;
            this.lbTranslation.Text = "FromTo";
            // 
            // lBoxFromWords
            // 
            this.lBoxFromWords.FormattingEnabled = true;
            this.lBoxFromWords.ItemHeight = 16;
            this.lBoxFromWords.Location = new System.Drawing.Point(21, 201);
            this.lBoxFromWords.Name = "lBoxFromWords";
            this.lBoxFromWords.Size = new System.Drawing.Size(326, 116);
            this.lBoxFromWords.TabIndex = 3;
            this.lBoxFromWords.SelectedIndexChanged += new System.EventHandler(this.lBoxFromWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(353, 201);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(130, 22);
            this.tbTranslation.TabIndex = 4;
            // 
            // btn_ExportToCsv
            // 
            this.btn_ExportToCsv.Location = new System.Drawing.Point(353, 245);
            this.btn_ExportToCsv.Name = "btn_ExportToCsv";
            this.btn_ExportToCsv.Size = new System.Drawing.Size(130, 23);
            this.btn_ExportToCsv.TabIndex = 5;
            this.btn_ExportToCsv.Text = "Export CSV";
            this.btn_ExportToCsv.UseVisualStyleBackColor = true;
            this.btn_ExportToCsv.Click += new System.EventHandler(this.btn_ExportToCsv_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(256, 61);
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
            // Woerterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 343);
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
    }
}

