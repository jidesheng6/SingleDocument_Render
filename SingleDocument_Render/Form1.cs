using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using System.Diagnostics;

namespace SingleDocument_Render
{
    public partial class Form1 : Form
    {
        public static Form1 MFR;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MFR = this;//赋值
            CheckForIllegalCrossThreadCalls = false;//允许不安全线程
        }

        private void Chooese_TemplateLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new GetTemplateFile().LoadTemplateFiles();
            new LoadTemplateInfo().Fill_TemplateInfo();
            new SplitMutilPageDocument().SplitDocument();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoadOtherWords().LoadDocFile();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoadDataMartxFiles().LoadDataMartx();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNameForm ANF = new AddNameForm();
            ANF.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(PublicShareClass.WindowStruct.TemplateFilePath!=string.Empty)
            {
                if (PublicShareClass.WindowStruct.SinglePic_Files.Count == PublicShareClass.WindowStruct.OtherWordFIles.Count)
                {
                    MainRunForm MRF = new MainRunForm();
                    MRF.ShowDialog();
                }
                else
                {
                    MessageBox.Show("请选择和文档数量相同的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("请先设置模版","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(PublicShareClass.WindowStruct.TemplateFilePath!=string.Empty&&PublicShareClass.WindowStruct.SinglePic_Status==1)
            {
                SameSinglePicInsert SSP = new SameSinglePicInsert();
                SSP.ShowDialog();
            }
            else
            {
                MessageBox.Show("请先选择带有单人码的word文档作为模版进行参考","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MegreMutilFiles MMD = new MegreMutilFiles();
            MMD.ShowDialog();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new OnlyReplaceDocumentContent().ShowDialog();
        }
    }
}
