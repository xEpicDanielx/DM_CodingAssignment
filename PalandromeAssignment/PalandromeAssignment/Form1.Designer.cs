namespace PalandromeAssignment
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paragraph_Label = new System.Windows.Forms.Label();
            this.submit_Btn = new System.Windows.Forms.Button();
            this.paragraph_TB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pWordCount_Label = new System.Windows.Forms.Label();
            this.pSentenceCount_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wordDisplay_LB = new System.Windows.Forms.ListView();
            this.Word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wrdSearchLabel = new System.Windows.Forms.Label();
            this.letterSrch_BTN = new System.Windows.Forms.Button();
            this.letterSearch_TB = new System.Windows.Forms.TextBox();
            this.individualWords_View = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paragraph_Label);
            this.groupBox1.Controls.Add(this.submit_Btn);
            this.groupBox1.Controls.Add(this.paragraph_TB);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paragraph";
            // 
            // paragraph_Label
            // 
            this.paragraph_Label.Location = new System.Drawing.Point(16, 90);
            this.paragraph_Label.Name = "paragraph_Label";
            this.paragraph_Label.Size = new System.Drawing.Size(287, 73);
            this.paragraph_Label.TabIndex = 1;
            this.paragraph_Label.Text = "Please enter a paragraph in the text box below";
            // 
            // submit_Btn
            // 
            this.submit_Btn.Location = new System.Drawing.Point(104, 354);
            this.submit_Btn.Name = "submit_Btn";
            this.submit_Btn.Size = new System.Drawing.Size(75, 23);
            this.submit_Btn.TabIndex = 1;
            this.submit_Btn.Text = "Submit";
            this.submit_Btn.UseVisualStyleBackColor = true;
            this.submit_Btn.Click += new System.EventHandler(this.submit_Btn_Click);
            // 
            // paragraph_TB
            // 
            this.paragraph_TB.Location = new System.Drawing.Point(19, 204);
            this.paragraph_TB.Multiline = true;
            this.paragraph_TB.Name = "paragraph_TB";
            this.paragraph_TB.Size = new System.Drawing.Size(284, 114);
            this.paragraph_TB.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pWordCount_Label);
            this.groupBox2.Controls.Add(this.pSentenceCount_Label);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(361, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 74);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palandrome Stats";
            // 
            // pWordCount_Label
            // 
            this.pWordCount_Label.AutoSize = true;
            this.pWordCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pWordCount_Label.Location = new System.Drawing.Point(316, 38);
            this.pWordCount_Label.Name = "pWordCount_Label";
            this.pWordCount_Label.Size = new System.Drawing.Size(24, 25);
            this.pWordCount_Label.TabIndex = 3;
            this.pWordCount_Label.Text = "0";
            this.pWordCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pSentenceCount_Label
            // 
            this.pSentenceCount_Label.AutoSize = true;
            this.pSentenceCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSentenceCount_Label.Location = new System.Drawing.Point(48, 38);
            this.pSentenceCount_Label.Name = "pSentenceCount_Label";
            this.pSentenceCount_Label.Size = new System.Drawing.Size(24, 25);
            this.pSentenceCount_Label.TabIndex = 2;
            this.pSentenceCount_Label.Text = "0";
            this.pSentenceCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palandrome Words";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palandrome Sentences";
            // 
            // wordDisplay_LB
            // 
            this.wordDisplay_LB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Word,
            this.Count});
            this.wordDisplay_LB.GridLines = true;
            this.wordDisplay_LB.HideSelection = false;
            this.wordDisplay_LB.Location = new System.Drawing.Point(237, 19);
            this.wordDisplay_LB.Name = "wordDisplay_LB";
            this.wordDisplay_LB.Size = new System.Drawing.Size(184, 268);
            this.wordDisplay_LB.TabIndex = 3;
            this.wordDisplay_LB.UseCompatibleStateImageBehavior = false;
            this.wordDisplay_LB.View = System.Windows.Forms.View.Details;
            // 
            // Word
            // 
            this.Word.Text = "Word";
            this.Word.Width = 120;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 61;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wrdSearchLabel);
            this.groupBox3.Controls.Add(this.letterSrch_BTN);
            this.groupBox3.Controls.Add(this.letterSearch_TB);
            this.groupBox3.Controls.Add(this.individualWords_View);
            this.groupBox3.Controls.Add(this.wordDisplay_LB);
            this.groupBox3.Location = new System.Drawing.Point(361, 102);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 309);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Individual Words";
            // 
            // wrdSearchLabel
            // 
            this.wrdSearchLabel.Location = new System.Drawing.Point(6, 16);
            this.wrdSearchLabel.Name = "wrdSearchLabel";
            this.wrdSearchLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.wrdSearchLabel.Size = new System.Drawing.Size(225, 33);
            this.wrdSearchLabel.TabIndex = 7;
            this.wrdSearchLabel.Text = "Input 1 Letter into box below. Then hit search to find all words with matching le" +
    "tter.";
            this.wrdSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letterSrch_BTN
            // 
            this.letterSrch_BTN.Location = new System.Drawing.Point(14, 156);
            this.letterSrch_BTN.Name = "letterSrch_BTN";
            this.letterSrch_BTN.Size = new System.Drawing.Size(75, 23);
            this.letterSrch_BTN.TabIndex = 6;
            this.letterSrch_BTN.Text = "Search";
            this.letterSrch_BTN.UseVisualStyleBackColor = true;
            this.letterSrch_BTN.Click += new System.EventHandler(this.letterSrch_BTN_Click);
            // 
            // letterSearch_TB
            // 
            this.letterSearch_TB.Location = new System.Drawing.Point(35, 114);
            this.letterSearch_TB.MaxLength = 1;
            this.letterSearch_TB.Name = "letterSearch_TB";
            this.letterSearch_TB.Size = new System.Drawing.Size(28, 20);
            this.letterSearch_TB.TabIndex = 5;
            // 
            // individualWords_View
            // 
            this.individualWords_View.GridLines = true;
            this.individualWords_View.HideSelection = false;
            this.individualWords_View.Location = new System.Drawing.Point(95, 52);
            this.individualWords_View.Name = "individualWords_View";
            this.individualWords_View.Size = new System.Drawing.Size(123, 222);
            this.individualWords_View.TabIndex = 4;
            this.individualWords_View.UseCompatibleStateImageBehavior = false;
            this.individualWords_View.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label paragraph_Label;
        private System.Windows.Forms.Button submit_Btn;
        private System.Windows.Forms.TextBox paragraph_TB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label pWordCount_Label;
        private System.Windows.Forms.Label pSentenceCount_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView wordDisplay_LB;
        private System.Windows.Forms.ColumnHeader Word;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView individualWords_View;
        private System.Windows.Forms.TextBox letterSearch_TB;
        private System.Windows.Forms.Label wrdSearchLabel;
        private System.Windows.Forms.Button letterSrch_BTN;
    }
}

