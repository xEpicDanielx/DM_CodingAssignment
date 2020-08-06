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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pSentenceCount_Label = new System.Windows.Forms.Label();
            this.pWordCount_Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.paragraph_Label.AutoSize = true;
            this.paragraph_Label.Location = new System.Drawing.Point(41, 102);
            this.paragraph_Label.Name = "paragraph_Label";
            this.paragraph_Label.Size = new System.Drawing.Size(226, 13);
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
            this.groupBox2.Size = new System.Drawing.Size(427, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Palandrome Stats";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Palandrome Words";
            // 
            // pSentenceCount_Label
            // 
            this.pSentenceCount_Label.AutoSize = true;
            this.pSentenceCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pSentenceCount_Label.Location = new System.Drawing.Point(48, 49);
            this.pSentenceCount_Label.Name = "pSentenceCount_Label";
            this.pSentenceCount_Label.Size = new System.Drawing.Size(24, 25);
            this.pSentenceCount_Label.TabIndex = 2;
            this.pSentenceCount_Label.Text = "0";
            this.pSentenceCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pWordCount_Label
            // 
            this.pWordCount_Label.AutoSize = true;
            this.pWordCount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pWordCount_Label.Location = new System.Drawing.Point(315, 49);
            this.pWordCount_Label.Name = "pWordCount_Label";
            this.pWordCount_Label.Size = new System.Drawing.Size(24, 25);
            this.pWordCount_Label.TabIndex = 3;
            this.pWordCount_Label.Text = "0";
            this.pWordCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}

