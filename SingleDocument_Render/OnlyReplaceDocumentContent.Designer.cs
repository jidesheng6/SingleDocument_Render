
namespace SingleDocument_Render
{
    partial class OnlyReplaceDocumentContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyReplaceDocumentContent));
            this.label1 = new System.Windows.Forms.Label();
            this.OldBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MatchFull = new System.Windows.Forms.CheckBox();
            this.MatchCase = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "将文档中的：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OldBox
            // 
            this.OldBox.Location = new System.Drawing.Point(88, 20);
            this.OldBox.Name = "OldBox";
            this.OldBox.Size = new System.Drawing.Size(175, 21);
            this.OldBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(272, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "替换为：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewBox
            // 
            this.NewBox.Location = new System.Drawing.Point(324, 20);
            this.NewBox.Name = "NewBox";
            this.NewBox.Size = new System.Drawing.Size(194, 21);
            this.NewBox.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(492, 196);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(14, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 232);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "替换的文档信息";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "选择要替换的文档";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 51);
            this.button3.TabIndex = 8;
            this.button3.Text = "开始替换";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MatchFull
            // 
            this.MatchFull.AutoSize = true;
            this.MatchFull.Location = new System.Drawing.Point(139, 367);
            this.MatchFull.Name = "MatchFull";
            this.MatchFull.Size = new System.Drawing.Size(72, 16);
            this.MatchFull.TabIndex = 9;
            this.MatchFull.Text = "精准匹配";
            this.MatchFull.UseVisualStyleBackColor = true;
            // 
            // MatchCase
            // 
            this.MatchCase.AutoSize = true;
            this.MatchCase.Location = new System.Drawing.Point(274, 367);
            this.MatchCase.Name = "MatchCase";
            this.MatchCase.Size = new System.Drawing.Size(84, 16);
            this.MatchCase.TabIndex = 10;
            this.MatchCase.Text = "区分大小写";
            this.MatchCase.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(14, 306);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(504, 37);
            this.progressBar1.TabIndex = 11;
            // 
            // OnlyReplaceDocumentContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(530, 411);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.MatchCase);
            this.Controls.Add(this.MatchFull);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NewBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OldBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OnlyReplaceDocumentContent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "批量替换文档内容";
            this.Load += new System.EventHandler(this.OnlyReplaceDocumentContent_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OldBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox MatchFull;
        private System.Windows.Forms.CheckBox MatchCase;
        public System.Windows.Forms.ProgressBar progressBar1;
    }
}