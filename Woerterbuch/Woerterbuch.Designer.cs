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
            this.tbGermanWord = new System.Windows.Forms.TextBox();
            this.tbFrenchWord = new System.Windows.Forms.TextBox();
            this.lbTranslation = new System.Windows.Forms.Label();
            this.lBoxGermanWords = new System.Windows.Forms.ListBox();
            this.tbTranslation = new System.Windows.Forms.TextBox();
            this.btn_ExportToCsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Hinzufügen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbGermanWord
            // 
            this.tbGermanWord.Location = new System.Drawing.Point(136, 70);
            this.tbGermanWord.Name = "tbGermanWord";
            this.tbGermanWord.Size = new System.Drawing.Size(210, 22);
            this.tbGermanWord.TabIndex = 1;
            // 
            // tbFrenchWord
            // 
            this.tbFrenchWord.Location = new System.Drawing.Point(460, 70);
            this.tbFrenchWord.Name = "tbFrenchWord";
            this.tbFrenchWord.Size = new System.Drawing.Size(210, 22);
            this.tbFrenchWord.TabIndex = 1;
            // 
            // lbTranslation
            // 
            this.lbTranslation.AutoSize = true;
            this.lbTranslation.Location = new System.Drawing.Point(368, 75);
            this.lbTranslation.Name = "lbTranslation";
            this.lbTranslation.Size = new System.Drawing.Size(66, 17);
            this.lbTranslation.TabIndex = 2;
            this.lbTranslation.Text = "DE <>EN";
            // 
            // lBoxGermanWords
            // 
            this.lBoxGermanWords.FormattingEnabled = true;
            this.lBoxGermanWords.ItemHeight = 16;
            this.lBoxGermanWords.Location = new System.Drawing.Point(28, 168);
            this.lBoxGermanWords.Name = "lBoxGermanWords";
            this.lBoxGermanWords.Size = new System.Drawing.Size(534, 116);
            this.lBoxGermanWords.TabIndex = 3;
            this.lBoxGermanWords.SelectedIndexChanged += new System.EventHandler(this.lBoxGermanWords_SelectedIndexChanged);
            // 
            // tbTranslation
            // 
            this.tbTranslation.Location = new System.Drawing.Point(608, 168);
            this.tbTranslation.Name = "tbTranslation";
            this.tbTranslation.Size = new System.Drawing.Size(100, 22);
            this.tbTranslation.TabIndex = 4;
            // 
            // btn_ExportToCsv
            // 
            this.btn_ExportToCsv.Location = new System.Drawing.Point(608, 229);
            this.btn_ExportToCsv.Name = "btn_ExportToCsv";
            this.btn_ExportToCsv.Size = new System.Drawing.Size(132, 23);
            this.btn_ExportToCsv.TabIndex = 5;
            this.btn_ExportToCsv.Text = "Export CSV";
            this.btn_ExportToCsv.UseVisualStyleBackColor = true;
            this.btn_ExportToCsv.Click += new System.EventHandler(this.btn_ExportToCsv_Click);
            // 
            // Woerterbuch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_ExportToCsv);
            this.Controls.Add(this.tbTranslation);
            this.Controls.Add(this.lBoxGermanWords);
            this.Controls.Add(this.lbTranslation);
            this.Controls.Add(this.tbFrenchWord);
            this.Controls.Add(this.tbGermanWord);
            this.Controls.Add(this.btnAdd);
            this.Name = "Woerterbuch";
            this.Text = "Woerterbuch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbGermanWord;
        private System.Windows.Forms.TextBox tbFrenchWord;
        private System.Windows.Forms.Label lbTranslation;
        private System.Windows.Forms.ListBox lBoxGermanWords;
        private System.Windows.Forms.TextBox tbTranslation;
        private System.Windows.Forms.Button btn_ExportToCsv;
    }
}

