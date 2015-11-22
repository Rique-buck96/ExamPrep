namespace ExamUI
{
    partial class TestCreate
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
            this.rtxtAnswer = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstKeywords = new System.Windows.Forms.ListBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.rtxtQestion = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtxtAnswer
            // 
            this.rtxtAnswer.Location = new System.Drawing.Point(18, 155);
            this.rtxtAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtAnswer.Name = "rtxtAnswer";
            this.rtxtAnswer.Size = new System.Drawing.Size(213, 78);
            this.rtxtAnswer.TabIndex = 0;
            this.rtxtAnswer.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(19, 42);
            this.txtKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(68, 20);
            this.txtKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Keyword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Question";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Answer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter Keyword";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddKWords_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKeywords);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 247);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(379, 110);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keyword Entry";
            // 
            // lstKeywords
            // 
            this.lstKeywords.FormattingEnabled = true;
            this.lstKeywords.Location = new System.Drawing.Point(244, 10);
            this.lstKeywords.Name = "lstKeywords";
            this.lstKeywords.Size = new System.Drawing.Size(120, 95);
            this.lstKeywords.TabIndex = 12;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(17, 376);
            this.btnAddQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(177, 26);
            this.btnAddQuestion.TabIndex = 9;
            this.btnAddQuestion.Text = "Add Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // rtxtQestion
            // 
            this.rtxtQestion.Location = new System.Drawing.Point(18, 46);
            this.rtxtQestion.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtQestion.Name = "rtxtQestion";
            this.rtxtQestion.Size = new System.Drawing.Size(213, 75);
            this.rtxtQestion.TabIndex = 10;
            this.rtxtQestion.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(255, 376);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(117, 26);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TestCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(438, 413);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtxtQestion);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtAnswer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TestCreate";
            this.Text = "TestCreate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxtAnswer;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.RichTextBox rtxtQestion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lstKeywords;
    }
}