namespace DictionaryApp
{
    partial class frm_Dictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Word = new System.Windows.Forms.Label();
            this.lbl_Meaning = new System.Windows.Forms.Label();
            this.txt_Word = new System.Windows.Forms.TextBox();
            this.txt_Meaning = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_UpdateWord = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_Update = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_Display = new System.Windows.Forms.Button();
            this.btn_UpdateMeaning = new System.Windows.Forms.Button();
            this.txt_UpdateM = new System.Windows.Forms.TextBox();
            this.lbl_UpdateW = new System.Windows.Forms.Label();
            this.lbl_UpdateM = new System.Windows.Forms.Label();
            this.lbl_SearchW = new System.Windows.Forms.Label();
            this.lbl_SearchM = new System.Windows.Forms.Label();
            this.txt_SearchM = new System.Windows.Forms.TextBox();
            this.lbl_heading = new System.Windows.Forms.Label();
            this.lbl_DicName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Word
            // 
            this.lbl_Word.AutoSize = true;
            this.lbl_Word.Location = new System.Drawing.Point(286, 446);
            this.lbl_Word.Name = "lbl_Word";
            this.lbl_Word.Size = new System.Drawing.Size(33, 13);
            this.lbl_Word.TabIndex = 0;
            this.lbl_Word.Text = "Word";
            // 
            // lbl_Meaning
            // 
            this.lbl_Meaning.AutoSize = true;
            this.lbl_Meaning.Location = new System.Drawing.Point(548, 446);
            this.lbl_Meaning.Name = "lbl_Meaning";
            this.lbl_Meaning.Size = new System.Drawing.Size(48, 13);
            this.lbl_Meaning.TabIndex = 1;
            this.lbl_Meaning.Text = "Meaning";
            // 
            // txt_Word
            // 
            this.txt_Word.Location = new System.Drawing.Point(338, 443);
            this.txt_Word.Multiline = true;
            this.txt_Word.Name = "txt_Word";
            this.txt_Word.Size = new System.Drawing.Size(99, 30);
            this.txt_Word.TabIndex = 2;
            this.txt_Word.TextChanged += new System.EventHandler(this.txt_Word_TextChanged);
            // 
            // txt_Meaning
            // 
            this.txt_Meaning.Location = new System.Drawing.Point(606, 447);
            this.txt_Meaning.Multiline = true;
            this.txt_Meaning.Name = "txt_Meaning";
            this.txt_Meaning.Size = new System.Drawing.Size(106, 26);
            this.txt_Meaning.TabIndex = 3;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(418, 509);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_UpdateWord
            // 
            this.btn_UpdateWord.Location = new System.Drawing.Point(81, 567);
            this.btn_UpdateWord.Name = "btn_UpdateWord";
            this.btn_UpdateWord.Size = new System.Drawing.Size(133, 23);
            this.btn_UpdateWord.TabIndex = 7;
            this.btn_UpdateWord.Text = "Word Update";
            this.btn_UpdateWord.UseVisualStyleBackColor = true;
            this.btn_UpdateWord.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(509, 509);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_Update
            // 
            this.txt_Update.Location = new System.Drawing.Point(220, 567);
            this.txt_Update.Multiline = true;
            this.txt_Update.Name = "txt_Update";
            this.txt_Update.Size = new System.Drawing.Size(140, 31);
            this.txt_Update.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(928, 212);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(5, 79);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(209, 31);
            this.txt_Search.TabIndex = 11;
            this.txt_Search.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Display
            // 
            this.btn_Display.Location = new System.Drawing.Point(873, 327);
            this.btn_Display.Name = "btn_Display";
            this.btn_Display.Size = new System.Drawing.Size(75, 23);
            this.btn_Display.TabIndex = 12;
            this.btn_Display.Text = "Display";
            this.btn_Display.UseVisualStyleBackColor = true;
            this.btn_Display.Click += new System.EventHandler(this.btn_Display_Click);
            // 
            // btn_UpdateMeaning
            // 
            this.btn_UpdateMeaning.Location = new System.Drawing.Point(509, 567);
            this.btn_UpdateMeaning.Name = "btn_UpdateMeaning";
            this.btn_UpdateMeaning.Size = new System.Drawing.Size(133, 23);
            this.btn_UpdateMeaning.TabIndex = 13;
            this.btn_UpdateMeaning.Text = "Meaning Update";
            this.btn_UpdateMeaning.UseVisualStyleBackColor = true;
            this.btn_UpdateMeaning.Click += new System.EventHandler(this.btn_UpdateMeaning_Click);
            // 
            // txt_UpdateM
            // 
            this.txt_UpdateM.Location = new System.Drawing.Point(648, 569);
            this.txt_UpdateM.Multiline = true;
            this.txt_UpdateM.Name = "txt_UpdateM";
            this.txt_UpdateM.Size = new System.Drawing.Size(151, 31);
            this.txt_UpdateM.TabIndex = 14;
            // 
            // lbl_UpdateW
            // 
            this.lbl_UpdateW.AutoSize = true;
            this.lbl_UpdateW.Location = new System.Drawing.Point(266, 553);
            this.lbl_UpdateW.Name = "lbl_UpdateW";
            this.lbl_UpdateW.Size = new System.Drawing.Size(98, 13);
            this.lbl_UpdateW.TabIndex = 15;
            this.lbl_UpdateW.Text = "Enter The Meaning";
            // 
            // lbl_UpdateM
            // 
            this.lbl_UpdateM.AutoSize = true;
            this.lbl_UpdateM.Location = new System.Drawing.Point(719, 556);
            this.lbl_UpdateM.Name = "lbl_UpdateM";
            this.lbl_UpdateM.Size = new System.Drawing.Size(83, 13);
            this.lbl_UpdateM.TabIndex = 16;
            this.lbl_UpdateM.Text = "Enter The Word";
            // 
            // lbl_SearchW
            // 
            this.lbl_SearchW.AutoSize = true;
            this.lbl_SearchW.Location = new System.Drawing.Point(6, 64);
            this.lbl_SearchW.Name = "lbl_SearchW";
            this.lbl_SearchW.Size = new System.Drawing.Size(85, 13);
            this.lbl_SearchW.TabIndex = 17;
            this.lbl_SearchW.Text = "Search By Word";
            // 
            // lbl_SearchM
            // 
            this.lbl_SearchM.AutoSize = true;
            this.lbl_SearchM.Location = new System.Drawing.Point(870, 64);
            this.lbl_SearchM.Name = "lbl_SearchM";
            this.lbl_SearchM.Size = new System.Drawing.Size(100, 13);
            this.lbl_SearchM.TabIndex = 18;
            this.lbl_SearchM.Text = "Search By Meaning";
            // 
            // txt_SearchM
            // 
            this.txt_SearchM.Location = new System.Drawing.Point(761, 80);
            this.txt_SearchM.Multiline = true;
            this.txt_SearchM.Name = "txt_SearchM";
            this.txt_SearchM.Size = new System.Drawing.Size(209, 31);
            this.txt_SearchM.TabIndex = 19;
            this.txt_SearchM.TextChanged += new System.EventHandler(this.txt_SearchM_TextChanged);
            // 
            // lbl_heading
            // 
            this.lbl_heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_heading.Location = new System.Drawing.Point(35, 383);
            this.lbl_heading.Name = "lbl_heading";
            this.lbl_heading.Size = new System.Drawing.Size(929, 36);
            this.lbl_heading.TabIndex = 20;
            this.lbl_heading.Text = "You Can Insert More Words with Meaning ,Delete And Update\r\n";
            // 
            // lbl_DicName
            // 
            this.lbl_DicName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DicName.Location = new System.Drawing.Point(358, 9);
            this.lbl_DicName.Name = "lbl_DicName";
            this.lbl_DicName.Size = new System.Drawing.Size(354, 44);
            this.lbl_DicName.TabIndex = 21;
            this.lbl_DicName.Text = "E2B   AND   B2E";
            // 
            // frm_Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 606);
            this.Controls.Add(this.lbl_DicName);
            this.Controls.Add(this.lbl_heading);
            this.Controls.Add(this.txt_SearchM);
            this.Controls.Add(this.lbl_SearchM);
            this.Controls.Add(this.lbl_SearchW);
            this.Controls.Add(this.lbl_UpdateM);
            this.Controls.Add(this.lbl_UpdateW);
            this.Controls.Add(this.txt_UpdateM);
            this.Controls.Add(this.btn_UpdateMeaning);
            this.Controls.Add(this.btn_Display);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_Update);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_UpdateWord);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Meaning);
            this.Controls.Add(this.txt_Word);
            this.Controls.Add(this.lbl_Meaning);
            this.Controls.Add(this.lbl_Word);
            this.Name = "frm_Dictionary";
            this.Text = "DicTionary";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Close);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Word;
        private System.Windows.Forms.Label lbl_Meaning;
        private System.Windows.Forms.TextBox txt_Word;
        private System.Windows.Forms.TextBox txt_Meaning;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_UpdateWord;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_Display;
        private System.Windows.Forms.Button btn_UpdateMeaning;
        private System.Windows.Forms.TextBox txt_UpdateM;
        private System.Windows.Forms.Label lbl_UpdateW;
        private System.Windows.Forms.Label lbl_UpdateM;
        private System.Windows.Forms.Label lbl_SearchW;
        private System.Windows.Forms.Label lbl_SearchM;
        private System.Windows.Forms.TextBox txt_SearchM;
        private System.Windows.Forms.Label lbl_heading;
        private System.Windows.Forms.Label lbl_DicName;
    }
}

