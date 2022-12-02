namespace HomeworkConcurentProgrammingThreadedVersion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancellationBtn = new System.Windows.Forms.Button();
            this.countWordsBtn = new System.Windows.Forms.Button();
            this.shortestWordBtn = new System.Windows.Forms.Button();
            this.longestWordBtn = new System.Windows.Forms.Button();
            this.averageCountBtn = new System.Windows.Forms.Button();
            this.textBoxCountWords = new System.Windows.Forms.TextBox();
            this.textBoxShortestWord = new System.Windows.Forms.TextBox();
            this.textBoxLongestWord = new System.Windows.Forms.TextBox();
            this.textBoxAverageLength = new System.Windows.Forms.TextBox();
            this.mostCommonWordsBtm = new System.Windows.Forms.Button();
            this.leastCommonWordsBtn = new System.Windows.Forms.Button();
            this.textBox5MostCommon = new System.Windows.Forms.TextBox();
            this.textBox5LeastCommon = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancellationBtn
            // 
            this.cancellationBtn.AutoSize = true;
            this.cancellationBtn.Location = new System.Drawing.Point(639, 408);
            this.cancellationBtn.Name = "cancellationBtn";
            this.cancellationBtn.Size = new System.Drawing.Size(149, 30);
            this.cancellationBtn.TabIndex = 0;
            this.cancellationBtn.Text = "Cancellation button";
            this.cancellationBtn.UseVisualStyleBackColor = true;
            this.cancellationBtn.Click += new System.EventHandler(this.cancellationBtn_Click);
            // 
            // countWordsBtn
            // 
            this.countWordsBtn.AutoSize = true;
            this.countWordsBtn.Location = new System.Drawing.Point(13, 12);
            this.countWordsBtn.Name = "countWordsBtn";
            this.countWordsBtn.Size = new System.Drawing.Size(197, 30);
            this.countWordsBtn.TabIndex = 1;
            this.countWordsBtn.Text = "Show me number of words";
            this.countWordsBtn.UseVisualStyleBackColor = true;
            this.countWordsBtn.Click += new System.EventHandler(this.countWordsBtn_Click);
            // 
            // shortestWordBtn
            // 
            this.shortestWordBtn.AutoSize = true;
            this.shortestWordBtn.Location = new System.Drawing.Point(216, 12);
            this.shortestWordBtn.Name = "shortestWordBtn";
            this.shortestWordBtn.Size = new System.Drawing.Size(174, 30);
            this.shortestWordBtn.TabIndex = 2;
            this.shortestWordBtn.Text = "Show me shortest word";
            this.shortestWordBtn.UseVisualStyleBackColor = true;
            this.shortestWordBtn.Click += new System.EventHandler(this.shortestWordBtn_Click);
            // 
            // longestWordBtn
            // 
            this.longestWordBtn.AutoSize = true;
            this.longestWordBtn.Location = new System.Drawing.Point(396, 12);
            this.longestWordBtn.Name = "longestWordBtn";
            this.longestWordBtn.Size = new System.Drawing.Size(171, 30);
            this.longestWordBtn.TabIndex = 3;
            this.longestWordBtn.Text = "Show me longest word";
            this.longestWordBtn.UseVisualStyleBackColor = true;
            this.longestWordBtn.Click += new System.EventHandler(this.longestWordBtn_Click);
            // 
            // averageCountBtn
            // 
            this.averageCountBtn.AutoSize = true;
            this.averageCountBtn.Location = new System.Drawing.Point(573, 12);
            this.averageCountBtn.Name = "averageCountBtn";
            this.averageCountBtn.Size = new System.Drawing.Size(171, 30);
            this.averageCountBtn.TabIndex = 4;
            this.averageCountBtn.Text = "Average Word Length";
            this.averageCountBtn.UseVisualStyleBackColor = true;
            this.averageCountBtn.Click += new System.EventHandler(this.averageCountBtn_Click);
            // 
            // textBoxCountWords
            // 
            this.textBoxCountWords.Location = new System.Drawing.Point(13, 48);
            this.textBoxCountWords.Multiline = true;
            this.textBoxCountWords.Name = "textBoxCountWords";
            this.textBoxCountWords.Size = new System.Drawing.Size(197, 124);
            this.textBoxCountWords.TabIndex = 5;
            // 
            // textBoxShortestWord
            // 
            this.textBoxShortestWord.Location = new System.Drawing.Point(216, 48);
            this.textBoxShortestWord.Multiline = true;
            this.textBoxShortestWord.Name = "textBoxShortestWord";
            this.textBoxShortestWord.Size = new System.Drawing.Size(174, 124);
            this.textBoxShortestWord.TabIndex = 6;
            // 
            // textBoxLongestWord
            // 
            this.textBoxLongestWord.Location = new System.Drawing.Point(396, 48);
            this.textBoxLongestWord.Multiline = true;
            this.textBoxLongestWord.Name = "textBoxLongestWord";
            this.textBoxLongestWord.Size = new System.Drawing.Size(171, 124);
            this.textBoxLongestWord.TabIndex = 7;
            // 
            // textBoxAverageLength
            // 
            this.textBoxAverageLength.Location = new System.Drawing.Point(573, 48);
            this.textBoxAverageLength.Multiline = true;
            this.textBoxAverageLength.Name = "textBoxAverageLength";
            this.textBoxAverageLength.Size = new System.Drawing.Size(171, 124);
            this.textBoxAverageLength.TabIndex = 8;
            // 
            // mostCommonWordsBtm
            // 
            this.mostCommonWordsBtm.AutoSize = true;
            this.mostCommonWordsBtm.Location = new System.Drawing.Point(13, 178);
            this.mostCommonWordsBtm.Name = "mostCommonWordsBtm";
            this.mostCommonWordsBtm.Size = new System.Drawing.Size(206, 30);
            this.mostCommonWordsBtm.TabIndex = 9;
            this.mostCommonWordsBtm.Text = "5 Most common words";
            this.mostCommonWordsBtm.UseVisualStyleBackColor = true;
            this.mostCommonWordsBtm.Click += new System.EventHandler(this.mostCommonWordsBtm_Click);
            // 
            // leastCommonWordsBtn
            // 
            this.leastCommonWordsBtn.AutoSize = true;
            this.leastCommonWordsBtn.Location = new System.Drawing.Point(225, 178);
            this.leastCommonWordsBtn.Name = "leastCommonWordsBtn";
            this.leastCommonWordsBtn.Size = new System.Drawing.Size(203, 30);
            this.leastCommonWordsBtn.TabIndex = 10;
            this.leastCommonWordsBtn.Text = "5 Least common words";
            this.leastCommonWordsBtn.UseVisualStyleBackColor = true;
            this.leastCommonWordsBtn.Click += new System.EventHandler(this.leastCommonWordsBtn_Click);
            // 
            // textBox5MostCommon
            // 
            this.textBox5MostCommon.Location = new System.Drawing.Point(12, 214);
            this.textBox5MostCommon.Multiline = true;
            this.textBox5MostCommon.Name = "textBox5MostCommon";
            this.textBox5MostCommon.Size = new System.Drawing.Size(207, 196);
            this.textBox5MostCommon.TabIndex = 11;
            // 
            // textBox5LeastCommon
            // 
            this.textBox5LeastCommon.Location = new System.Drawing.Point(225, 214);
            this.textBox5LeastCommon.Multiline = true;
            this.textBox5LeastCommon.Name = "textBox5LeastCommon";
            this.textBox5LeastCommon.Size = new System.Drawing.Size(203, 196);
            this.textBox5LeastCommon.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(486, 408);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 13;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(522, 379);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(0, 20);
            this.percentageLabel.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBox5LeastCommon);
            this.Controls.Add(this.textBox5MostCommon);
            this.Controls.Add(this.leastCommonWordsBtn);
            this.Controls.Add(this.mostCommonWordsBtm);
            this.Controls.Add(this.textBoxAverageLength);
            this.Controls.Add(this.textBoxLongestWord);
            this.Controls.Add(this.textBoxShortestWord);
            this.Controls.Add(this.textBoxCountWords);
            this.Controls.Add(this.averageCountBtn);
            this.Controls.Add(this.longestWordBtn);
            this.Controls.Add(this.shortestWordBtn);
            this.Controls.Add(this.countWordsBtn);
            this.Controls.Add(this.cancellationBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button cancellationBtn;
        private Button countWordsBtn;
        private Button shortestWordBtn;
        private Button longestWordBtn;
        private Button averageCountBtn;
        private TextBox textBoxCountWords;
        private TextBox textBoxShortestWord;
        private TextBox textBoxLongestWord;
        private TextBox textBoxAverageLength;
        private Button mostCommonWordsBtm;
        private Button leastCommonWordsBtn;
        private TextBox textBox5MostCommon;
        private TextBox textBox5LeastCommon;
        private ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label percentageLabel;
    }
}