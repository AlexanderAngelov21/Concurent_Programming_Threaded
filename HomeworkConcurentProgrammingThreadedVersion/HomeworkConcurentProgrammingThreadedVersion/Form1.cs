using System.Text.RegularExpressions;

namespace HomeworkConcurentProgrammingThreadedVersion
{
    public partial class Form1 : Form
    {
        static string filePath = "C:\\Users\\Asi\\Desktop\\book.txt";
        static FileStream fs = new FileStream(filePath, FileMode.Open);
        static StreamReader sr = new StreamReader(fs);
        public Form1()
        {
            InitializeComponent();
        }

        CancellationTokenSource cts;
        private void cancellationBtn_Click(object sender, EventArgs e)
        {
            if (cts != null) cts.Cancel();
            backgroundWorker1.CancelAsync();
        }
        delegate void SetTextCallback(string text);
        private void SetTextForCountTestBox(string text)
        {
            
            if (this.textBoxCountWords.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForCountTestBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxCountWords.Text = text;
            }
        }
        private void SetTextForShortestTextBox(string text)
        {

            if (this.textBoxShortestWord.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForShortestTextBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxShortestWord.Text = text;
            }
        }
        private void SetTextForLongestTextBox(string text)
        {

            if (this.textBoxLongestWord.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForLongestTextBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxLongestWord.Text = text;
            }
        }
        private void SetTextForAverageLengthTextBox(string text)
        {

            if (this.textBoxAverageLength.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForAverageLengthTextBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBoxAverageLength.Text = text;
            }
        }
        private void SetTextForMostCommonTextBox(string text)
        {

            if (this.textBox5MostCommon.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForMostCommonTextBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox5MostCommon.Text += text;
            }
        }
        private void SetTextForLeastCommonTextBox(string text)
        {

            if (this.textBox5LeastCommon.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTextForLeastCommonTextBox);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.textBox5LeastCommon.Text += text;
            }
        }
     
        private void WordCountWorker(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            string content = sr.ReadToEnd();
            content = content.Replace("\r\n", "\r");
            int charCount = content.Length;
            int lineCount = content.Split('\r').Length;
            content = content.Replace('\r', ' ');
            List<string> words = content.Split(' ').ToList();
            List<string> countWords = new List<string>();
            foreach (string word in words)
            {
                countWords.Add(Regex.Match(word, @"\w{3,}").Value);
                if (token.IsCancellationRequested) break;
            }
            
            int WordsCount = countWords.Count;
            SetTextForCountTestBox($"Брой думи с 3 или повече букви: {WordsCount} ,общ брой букви на думите: {charCount} ,редове: {lineCount}");
            BeginInvoke((Action)(() => countWordsBtn.Enabled = true));
          
        }
        private void ShortestWordWorker(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            List<string> list = content.Split(delimiterChars).ToList();
            string shortestWord = list.OrderBy(n => n.Length).Where(n => n.Length >= 3).FirstOrDefault();
            SetTextForShortestTextBox(shortestWord);
            BeginInvoke((Action)(() => shortestWordBtn.Enabled = true));
        }
        private void LongestWordWorker(object tkn)
        {
            CancellationToken token = (CancellationToken)tkn;
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            List<string> list = content.Split(delimiterChars).ToList();
            string longestWord = list.OrderByDescending(n => n.Length).Where(n => n.Length >= 3).FirstOrDefault();
            SetTextForLongestTextBox(longestWord);
            BeginInvoke((Action)(() => longestWordBtn.Enabled = true));
        }
        private void AverageLengthWorker(object tkn)
        {
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };
            var list = content.Split(delimiterChars).ToList();
            var averageCount = list.Average(n => n.Length);
            SetTextForAverageLengthTextBox($"Средна дължина на думите(букви): {averageCount.ToString("#.##")}");

            BeginInvoke((Action)(() => averageCountBtn.Enabled = true));
        }
        private void FiveMostCommonWorker(object tkn)
        {
            string content = sr.ReadToEnd();
            string[] splitWords = content.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var commonWords = splitWords.ToList().GroupBy(e => e).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(e => e.Count).Where(l => l.Value.Length >= 3).Take(5);
            foreach (var x in commonWords)
            {
                var temp = x.Value;
                var temp2 = x.Count;
                SetTextForMostCommonTextBox($"Дума: \"{temp}\" среща се - \"{temp2}\" пъти. ");  
            }
   

            BeginInvoke((Action)(() => mostCommonWordsBtm.Enabled = true));
        }
        private void FiveLeastCommonWorker(object tkn)
        {
            string content = sr.ReadToEnd();
            char[] delimiterChars = { ' ', ',', '.', ':', '\t', '!', '?' };

            string[] splitWords = content.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);
            var commonWords = splitWords.ToList().GroupBy(e => e).Select(g => new { Value = g.Key, Count = g.Count() }).OrderBy(e => e.Count).Where(l => l.Value.Length >= 3).Take(5);
            foreach (var x in commonWords)
            {
                SetTextForLeastCommonTextBox($"Дума: \"{x.Value}\" среща се - \"{x.Count}\" пъти. ");
            }
            BeginInvoke((Action)(() => leastCommonWordsBtn.Enabled = true));
        }
        private void countWordsBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(WordCountWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            countWordsBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void shortestWordBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(ShortestWordWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            shortestWordBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void longestWordBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(LongestWordWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            longestWordBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void averageCountBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(AverageLengthWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            averageCountBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
            
        }

        private void mostCommonWordsBtm_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(FiveMostCommonWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            mostCommonWordsBtm.Enabled = false;
            backgroundWorker1.RunWorkerAsync();

        }

        private void leastCommonWordsBtn_Click(object sender, EventArgs e)
        {
            cts = new CancellationTokenSource();
            var thread = new Thread(FiveLeastCommonWorker);
            thread.IsBackground = true;
            thread.Start(cts.Token);
            leastCommonWordsBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    simulateHeavyJob();
                    backgroundWorker1.ReportProgress(i);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            percentageLabel.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                display("You have cancelled");
                progressBar1.Value = 0;
                percentageLabel.Text = "0";
            }
            else
            {
                display("Work completed succesfully");
            }
        }
        private void simulateHeavyJob()
        {
            Thread.Sleep(100);
        }
        private void display(string text)
        {
            MessageBox.Show(text);
        }
    }
}