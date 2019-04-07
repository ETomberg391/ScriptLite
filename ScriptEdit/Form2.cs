
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Translation.V2;

namespace ScriptEdit
{
    public partial class Form2 : Form
    {

        public string[,] _result;
        public String translatedText = "";
        public String untranslatedText = "";
        public int lineNum;
        public int lineHoldernum;
        public int holdering;
        public int lineCounter = 0;
        
        public Form2()
        {
            InitializeComponent();
            this.toolOpen.Click += new System.EventHandler(this.ToolOpen_Click);
            this.toolSave.Click += new System.EventHandler(this.ToolSave_Click);
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            this.lineButton.Click += new System.EventHandler(this.LineButton_Click);
            this.translatedTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckEnter);
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            openFile.Filter = "Text files (.txt)|*.txt";
        }
        private void ToolOpen_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFile.FileName);

                _result = new string[File.ReadLines(openFile.FileName).Count(), 4];
                this.lineCounter = File.ReadLines(openFile.FileName).Count();

                using (var streamReader = new StreamReader(openFile.FileName))
                {
                    var line = string.Empty;
                    var lineCount = 0;
                    while (line != null)
                    {
                        line = streamReader.ReadLine();

                        if (string.IsNullOrWhiteSpace(line)) continue;

                        // wait for user to enter a translation
                        //var translation = await _translationSubmittedSource.Task;
                        var translation = "";
                        // split line at tabstop
                        var parts = line.Split(new string[] { "\t" }, 2, StringSplitOptions.None); ;
                        // populate result
                        _result[lineCount, 0] = lineCount.ToString();
                        _result[lineCount, 1] = parts[0];
                        _result[lineCount, 2] = parts[1];
                        _result[lineCount, 3] = translation;

                        // reset source
                        //_translationSubmittedSource = new TaskCompletionSource<string>();
                        // increase line count
                        lineCount++;
                    }
                }
                holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                this.untranslatedText = _result[lineHoldernum, 2];
                this.translatedText = _result[lineHoldernum, 3];

                lineHolder.Text = "Line #" + holdering.ToString();
                lineName.Text = _result[lineHoldernum, 1];
                scriptHolder.Text = _result[lineHoldernum, 2];
                translatedTextHolder.Text = _result[lineHoldernum, 3];
            }
        }
        private void ToolSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream s = File.Open(saveFile.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    for (int rowIndex = 0; rowIndex < (lineCounter); rowIndex++)
                    {
                        if (_result[rowIndex, 3] == "")
                        {
                            var line = _result[rowIndex, 1] + "\t" + _result[rowIndex, 2];
                            sw.WriteLine(line);
                        }
                        else
                        {
                            var line = _result[rowIndex, 1] + "\t" + _result[rowIndex, 3];
                            sw.WriteLine(line);
                        }
                    }
                    MessageBox.Show("File : \n" + saveFile.FileName + "\n has successfully saved");
                }
            }
        }
        private void LineButton_Click(object sender, EventArgs e)
        {
            this.lineNum = Int32.Parse(lineBox.Text) - 1;
            if (this.lineNum > this.lineCounter)
            {
                MessageBox.Show("Out of bounds! End of script is Line #" + lineCounter);
            }
            else
            {
                this.lineHoldernum = this.lineNum;

                holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                lineHolder.Text = "Line #" + holdering.ToString();
                lineName.Text = _result[lineHoldernum, 1];
                scriptHolder.Text = _result[lineHoldernum, 2];
                translatedTextHolder.Text = _result[lineHoldernum, 3];
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            _result[lineHoldernum, 3] = translatedTextbox.Text.Trim();

            holdering = Int32.Parse(_result[lineHoldernum, 0] + 1);
            lineHolder.Text = "Line #" + holdering.ToString();
            lineName.Text = _result[lineHoldernum, 1];
            scriptHolder.Text = _result[lineHoldernum, 2];
            translatedTextHolder.Text = _result[lineHoldernum, 3];
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (this.lineHoldernum != this.lineCounter - 1) {
                this.lineHoldernum++;
                holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                lineHolder.Text = "Line #" + holdering.ToString();
                lineName.Text = _result[lineHoldernum, 1];
                scriptHolder.Text = _result[lineHoldernum, 2];
                translatedTextHolder.Text = _result[lineHoldernum, 3];
            }
            else { };
        }
        private void BackButton_Click(object sender, EventArgs e)
        {

            if (lineHoldernum != 0) {
                this.lineHoldernum--;
                holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                lineHolder.Text = "Line #" + holdering.ToString();
                lineName.Text = _result[lineHoldernum, 1];
                scriptHolder.Text = _result[lineHoldernum, 2];
                translatedTextHolder.Text = _result[lineHoldernum, 3];
            }
            else { };
        }
        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e) { }
        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }
        private void LineHolder_Click(object sender, EventArgs e) { }
        private void lineName_Click(object sender, EventArgs e) { }

        private void lineBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13) {
                if (e.KeyChar == (char)13 && Control.ModifierKeys == Keys.Shift)
                {
                }
                else if (e.KeyChar == (char)13) {

                    _result[lineHoldernum, 3] = translatedTextbox.Text.Trim();

                    holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                    lineHolder.Text = "Line #" + holdering.ToString();
                    lineName.Text = _result[lineHoldernum, 1];
                    scriptHolder.Text = _result[lineHoldernum, 2];
                    translatedTextHolder.Text = _result[lineHoldernum, 3];

                    translatedTextbox.Text = "";
                }
            }

        }
        private void translatedTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.PageUp)
            {
                if (lineHoldernum != 0)
                {
                    this.lineHoldernum--;
                    holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                    lineHolder.Text = "Line #" + holdering.ToString();
                    lineName.Text = _result[lineHoldernum, 1];
                    scriptHolder.Text = _result[lineHoldernum, 2];
                    translatedTextHolder.Text = _result[lineHoldernum, 3];
                }
                else { };
            }
            if (e.KeyCode == Keys.PageDown)
            {
                if (this.lineHoldernum != this.lineCounter - 1)
                {
                    this.lineHoldernum++;
                    holdering = Int32.Parse(_result[lineHoldernum, 0]) + 1;
                    lineHolder.Text = "Line #" + holdering.ToString();
                    lineName.Text = _result[lineHoldernum, 1];
                    scriptHolder.Text = _result[lineHoldernum, 2];
                    translatedTextHolder.Text = _result[lineHoldernum, 3];
                }
                else { };
            }
        }
        private void translateButton_Click(object sender, EventArgs e)
        {
            int countFileHolder = 0;
            int doneCount = 0;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            TranslationClient client = TranslationClient.Create();
            for (int rowIndex = 0; rowIndex < (lineCounter); rowIndex++)
            {
                var response = client.TranslateText(_result[rowIndex, 2], "en");
                _result[rowIndex, 3] = response.TranslatedText;
                lineHolder.Text = "Line #" + _result[countFileHolder, 0].ToString();
                lineName.Text = _result[countFileHolder, 1];
                scriptHolder.Text = _result[countFileHolder, 2];
                translatedTextHolder.Text = _result[countFileHolder, 3];
                System.Threading.Thread.Sleep(500);
                    countFileHolder++;
                    doneCount++;
            }
            if(countFileHolder > 0)
            {
                MessageBox.Show("Translations finished!!");
                
            }
            else
            {
                MessageBox.Show("No text was Translated");
            }
        }
    }
}
