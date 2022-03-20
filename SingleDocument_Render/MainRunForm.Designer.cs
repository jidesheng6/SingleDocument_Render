
namespace SingleDocument_Render
{
    partial class MainRunForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainRunForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SinglePicView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.ChooseMutilFilesDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MergeFilesBox = new System.Windows.Forms.CheckBox();
            this.SaveMergeDialog = new System.Windows.Forms.SaveFileDialog();
            this.AutoInsertOption = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SinglePicView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(968, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单人码图片路径信息";
            // 
            // SinglePicView
            // 
            this.SinglePicView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.SinglePicView.FullRowSelect = true;
            this.SinglePicView.HideSelection = false;
            this.SinglePicView.Location = new System.Drawing.Point(6, 16);
            this.SinglePicView.Name = "SinglePicView";
            this.SinglePicView.Size = new System.Drawing.Size(956, 300);
            this.SinglePicView.TabIndex = 0;
            this.SinglePicView.UseCompatibleStateImageBehavior = false;
            this.SinglePicView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "图片路径";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "待处理文档路径";
            this.columnHeader2.Width = 481;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MergeFilesBox
            // 
            this.MergeFilesBox.Location = new System.Drawing.Point(870, 368);
            this.MergeFilesBox.Name = "MergeFilesBox";
            this.MergeFilesBox.Size = new System.Drawing.Size(104, 67);
            this.MergeFilesBox.TabIndex = 2;
            this.MergeFilesBox.Text = "是否合并文件";
            this.MergeFilesBox.UseVisualStyleBackColor = true;
            // 
            // SaveMergeDialog
            // 
            this.SaveMergeDialog.DefaultExt = "docx";
            this.SaveMergeDialog.Title = "设置要保存的文件名称";
            // 
            // AutoInsertOption
            // 
            this.AutoInsertOption.AutoSize = true;
            this.AutoInsertOption.Location = new System.Drawing.Point(700, 393);
            this.AutoInsertOption.Name = "AutoInsertOption";
            this.AutoInsertOption.Size = new System.Drawing.Size(144, 16);
            this.AutoInsertOption.TabIndex = 3;
            this.AutoInsertOption.Text = "是否需要自动插入图片";
            this.AutoInsertOption.UseVisualStyleBackColor = true;
            this.AutoInsertOption.CheckedChanged += new System.EventHandler(this.AutoInsertOption_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(204, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 67);
            this.label1.TabIndex = 4;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainRunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(992, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutoInsertOption);
            this.Controls.Add(this.MergeFilesBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainRunForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "运行窗口";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainRunForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainRunForm_FormClosed);
            this.Load += new System.EventHandler(this.MainRunForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView SinglePicView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.FolderBrowserDialog ChooseMutilFilesDialog;
        public System.Windows.Forms.CheckBox MergeFilesBox;
        public System.Windows.Forms.SaveFileDialog SaveMergeDialog;
        public System.Windows.Forms.CheckBox AutoInsertOption;
        public System.Windows.Forms.Label label1;
    }
}