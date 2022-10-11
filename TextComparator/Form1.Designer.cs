
namespace TextComparator
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
            System.Windows.Forms.Button buttonLoadFile1;
            this.richTextBoxFile1 = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFile2 = new System.Windows.Forms.RichTextBox();
            this.buttonLoadFile2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.buttonCompare = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.labelNumarCuvinteDiff = new System.Windows.Forms.Label();
            this.textBoxNrCuvinteDiff = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            buttonLoadFile1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxFile1
            // 
            this.richTextBoxFile1.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxFile1.Name = "richTextBoxFile1";
            this.richTextBoxFile1.Size = new System.Drawing.Size(241, 235);
            this.richTextBoxFile1.TabIndex = 0;
            this.richTextBoxFile1.Text = "";
            // 
            // richTextBoxFile2
            // 
            this.richTextBoxFile2.Location = new System.Drawing.Point(535, 12);
            this.richTextBoxFile2.Name = "richTextBoxFile2";
            this.richTextBoxFile2.Size = new System.Drawing.Size(241, 235);
            this.richTextBoxFile2.TabIndex = 1;
            this.richTextBoxFile2.Text = "";
            // 
            // buttonLoadFile1
            // 
            buttonLoadFile1.Cursor = System.Windows.Forms.Cursors.Default;
            buttonLoadFile1.Location = new System.Drawing.Point(12, 253);
            buttonLoadFile1.Name = "buttonLoadFile1";
            buttonLoadFile1.Size = new System.Drawing.Size(75, 23);
            buttonLoadFile1.TabIndex = 2;
            buttonLoadFile1.Text = "Load file";
            buttonLoadFile1.UseVisualStyleBackColor = true;
            buttonLoadFile1.Click += new System.EventHandler(this.LoadFile1);
            // 
            // buttonLoadFile2
            // 
            this.buttonLoadFile2.Location = new System.Drawing.Point(701, 253);
            this.buttonLoadFile2.Name = "buttonLoadFile2";
            this.buttonLoadFile2.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadFile2.TabIndex = 3;
            this.buttonLoadFile2.Text = "Load file";
            this.buttonLoadFile2.UseVisualStyleBackColor = true;
            this.buttonLoadFile2.Click += new System.EventHandler(this.LoadFile2);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // buttonCompare
            // 
            this.buttonCompare.Location = new System.Drawing.Point(360, 253);
            this.buttonCompare.Name = "buttonCompare";
            this.buttonCompare.Size = new System.Drawing.Size(75, 23);
            this.buttonCompare.TabIndex = 4;
            this.buttonCompare.Text = "Compare";
            this.buttonCompare.UseVisualStyleBackColor = true;
            this.buttonCompare.Click += new System.EventHandler(this.CompareTexts);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(274, 12);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(241, 235);
            this.richTextBox3.TabIndex = 5;
            this.richTextBox3.Text = "";
            // 
            // labelNumarCuvinteDiff
            // 
            this.labelNumarCuvinteDiff.AutoSize = true;
            this.labelNumarCuvinteDiff.Location = new System.Drawing.Point(271, 296);
            this.labelNumarCuvinteDiff.Name = "labelNumarCuvinteDiff";
            this.labelNumarCuvinteDiff.Size = new System.Drawing.Size(125, 13);
            this.labelNumarCuvinteDiff.TabIndex = 6;
            this.labelNumarCuvinteDiff.Text = "Numar de cuvinte diferite";
            // 
            // textBoxNrCuvinteDiff
            // 
            this.textBoxNrCuvinteDiff.Location = new System.Drawing.Point(402, 293);
            this.textBoxNrCuvinteDiff.Name = "textBoxNrCuvinteDiff";
            this.textBoxNrCuvinteDiff.Size = new System.Drawing.Size(100, 20);
            this.textBoxNrCuvinteDiff.TabIndex = 7;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "help";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(360, 328);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.HelpButton);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(687, 338);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(88, 24);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 377);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxNrCuvinteDiff);
            this.Controls.Add(this.labelNumarCuvinteDiff);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.buttonCompare);
            this.Controls.Add(this.buttonLoadFile2);
            this.Controls.Add(buttonLoadFile1);
            this.Controls.Add(this.richTextBoxFile2);
            this.Controls.Add(this.richTextBoxFile1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxFile1;
        private System.Windows.Forms.RichTextBox richTextBoxFile2;
        private System.Windows.Forms.Button buttonLoadFile2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button buttonCompare;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label labelNumarCuvinteDiff;
        private System.Windows.Forms.TextBox textBoxNrCuvinteDiff;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
    }
}

