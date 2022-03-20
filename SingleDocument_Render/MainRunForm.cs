using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SingleDocument_Render
{
    public partial class MainRunForm : Form
    {
        public static MainRunForm MRF;
        public MainRunForm()
        {
            InitializeComponent();
            MRF = this;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void MainRunForm_Load(object sender, EventArgs e)
        {
                MergeFilesBox.Enabled = false;
                SinglePicView.BeginUpdate();
                for (int i=0;i<PublicShareClass.WindowStruct.SinglePic_Files.Count;i++)
                {
                    ListViewItem LVI = new ListViewItem();
                    LVI.Text = PublicShareClass.WindowStruct.SinglePic_Files[i].ToString();
                    LVI.SubItems.Add(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString());
                    SinglePicView.Items.Add(LVI);
                }
                SinglePicView.EndUpdate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            if (MRF.MergeFilesBox.Checked)
            {
                if (AutoInsertOption.Checked)
                {
                    PublicShareClass.WindowStruct.MutilSaveFloder = string.Empty;
                    new SetMutilFilesFloder().SetMergeFile();
                    if(PublicShareClass.WindowStruct.MegreFlag == 1)
                    {
                        if (PublicShareClass.WindowStruct.SinglePic_Status == 1)
                        {
                            new InsertImage().InsetImageWithSinglePic();
                        }
                        else
                        {
                            new InsertImage().InsertImageWithAuto();
                        }
                        new MergreFiles().MergeFile();//合并文件
                    }
                }
                else
                {
                    new ReplaceDocumentContent().ReplaceContent();
                    MessageBox.Show("替换完成，如需要当前进度的文档，请在文档目录split目录查找","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                if (AutoInsertOption.Checked)
                {
                    PublicShareClass.WindowStruct.MergeFileName = string.Empty;
                    new SetMutilFilesFloder().SetFolder();//设置保存目录
                    if(PublicShareClass.WindowStruct.MutilFolderFLag==1)
                    {
                        if (PublicShareClass.WindowStruct.SinglePic_Status == 1)
                        {
                            new InsertImage().InsetImageWithSinglePic();
                        }
                        else
                        {
                            new InsertImage().InsertImageWithAuto();
                        }
                    }
                }
                else
                {
                    new ReplaceDocumentContent().ReplaceContent();
                    MessageBox.Show("替换完成，如需要当前进度的文档，请在文档目录split目录查找", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void MainRunForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void MainRunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult DR = MessageBox.Show("确认要关闭吗？关闭后程序会自动清理文件的计数", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (DR == DialogResult.OK)
            {
                PublicShareClass.WindowStruct.OtherWordFIles.Clear();//清理数组元素
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void AutoInsertOption_CheckedChanged(object sender, EventArgs e)
        {
            if(AutoInsertOption.Checked)
            {
                MergeFilesBox.Enabled = true;
            }
            else
            {
                MergeFilesBox.Enabled = false;
            }
        }
    }
}
