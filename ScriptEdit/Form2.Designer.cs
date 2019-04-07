using System;
using System.Windows.Forms;

namespace ScriptEdit
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.lineHolder = new System.Windows.Forms.Label();
            this.lineButton = new System.Windows.Forms.Button();
            this.lineBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.lineName = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.lineDetail = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolOpen = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.scriptHolder = new System.Windows.Forms.RichTextBox();
            this.translatedTextbox = new System.Windows.Forms.RichTextBox();
            this.translatedTextHolder = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.translateButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(689, 492);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(72, 30);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(258, 492);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(72, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // lineHolder
            // 
            this.lineHolder.AutoSize = true;
            this.lineHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineHolder.Location = new System.Drawing.Point(467, 25);
            this.lineHolder.Name = "lineHolder";
            this.lineHolder.Size = new System.Drawing.Size(67, 24);
            this.lineHolder.TabIndex = 0;
            this.lineHolder.Text = "Line #";
            this.lineHolder.Click += new System.EventHandler(this.LineHolder_Click);
            // 
            // lineButton
            // 
            this.lineButton.Location = new System.Drawing.Point(961, 29);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(39, 30);
            this.lineButton.TabIndex = 4;
            this.lineButton.Text = "Go!";
            this.lineButton.UseVisualStyleBackColor = true;
            // 
            // lineBox
            // 
            this.lineBox.Location = new System.Drawing.Point(892, 35);
            this.lineBox.MaxLength = 6;
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(63, 20);
            this.lineBox.TabIndex = 5;
            this.lineBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lineBox_KeyPress);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(471, 492);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(72, 30);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // lineName
            // 
            this.lineName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lineName.AutoSize = true;
            this.lineName.Location = new System.Drawing.Point(201, 33);
            this.lineName.Name = "lineName";
            this.lineName.Size = new System.Drawing.Size(29, 13);
            this.lineName.TabIndex = 7;
            this.lineName.Text = "NPC";
            this.lineName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lineName.Click += new System.EventHandler(this.lineName_Click);
            // 
            // lineDetail
            // 
            this.lineDetail.AutoSize = true;
            this.lineDetail.Location = new System.Drawing.Point(820, 38);
            this.lineDetail.Name = "lineDetail";
            this.lineDetail.Size = new System.Drawing.Size(66, 13);
            this.lineDetail.TabIndex = 9;
            this.lineDetail.Text = "Skip to Line:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolOpen,
            this.toolSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1012, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolOpen
            // 
            this.toolOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolOpen.Image")));
            this.toolOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolOpen.Name = "toolOpen";
            this.toolOpen.Size = new System.Drawing.Size(23, 22);
            this.toolOpen.Text = "Open";
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(23, 22);
            this.toolSave.Text = "Save";
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // scriptHolder
            // 
            this.scriptHolder.BackColor = System.Drawing.SystemColors.Control;
            this.scriptHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptHolder.Location = new System.Drawing.Point(0, 65);
            this.scriptHolder.Name = "scriptHolder";
            this.scriptHolder.ReadOnly = true;
            this.scriptHolder.Size = new System.Drawing.Size(1012, 150);
            this.scriptHolder.TabIndex = 11;
            this.scriptHolder.Text = "";
            // 
            // translatedTextbox
            // 
            this.translatedTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatedTextbox.Location = new System.Drawing.Point(0, 336);
            this.translatedTextbox.Name = "translatedTextbox";
            this.translatedTextbox.Size = new System.Drawing.Size(1012, 150);
            this.translatedTextbox.TabIndex = 12;
            this.translatedTextbox.Text = "";
            this.translatedTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.translatedTextbox_KeyPress);
            // 
            // translatedTextHolder
            // 
            this.translatedTextHolder.BackColor = System.Drawing.SystemColors.Control;
            this.translatedTextHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translatedTextHolder.Location = new System.Drawing.Point(0, 236);
            this.translatedTextHolder.Name = "translatedTextHolder";
            this.translatedTextHolder.ReadOnly = true;
            this.translatedTextHolder.Size = new System.Drawing.Size(1012, 81);
            this.translatedTextHolder.TabIndex = 13;
            this.translatedTextHolder.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Original:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Translation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Input:";
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(12, 493);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(72, 30);
            this.translateButton.TabIndex = 17;
            this.translateButton.Text = "Translate";
            this.translateButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 534);
            this.Controls.Add(this.translateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.translatedTextHolder);
            this.Controls.Add(this.translatedTextbox);
            this.Controls.Add(this.scriptHolder);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lineName);
            this.Controls.Add(this.lineDetail);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.lineButton);
            this.Controls.Add(this.lineHolder);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "ScriptLite";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label lineHolder;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.TextBox lineBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label lineName;
        private System.Windows.Forms.SaveFileDialog saveFile;
        private System.Windows.Forms.Label lineDetail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolOpen;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.RichTextBox scriptHolder;
        private System.Windows.Forms.RichTextBox translatedTextbox;
        private System.Windows.Forms.RichTextBox translatedTextHolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button translateButton;
    }
}