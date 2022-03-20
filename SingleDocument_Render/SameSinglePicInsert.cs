using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleDocument_Render
{
    public partial class SameSinglePicInsert : Form
    {
        public SameSinglePicInsert()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BarcodeDialog.Filter = "图片文件|*.bmp";
            BarcodeDialog.Multiselect = false;
            DialogResult DR = BarcodeDialog.ShowDialog();
            if(DR == DialogResult.OK)
            {
                PublicShareClass.WindowStruct.SingPic_One_Path = BarcodeDialog.FileName;//加载二维码图片
                pictureBox1.Image = Image.FromFile(BarcodeDialog.FileName);//显示二维码图片
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            listBox1.Items.Clear();
            BarcodeDialog.Filter = "word文件|*.doc;*.docx";
            BarcodeDialog.Multiselect = true;
            DialogResult DR = BarcodeDialog.ShowDialog();
            if (DR == DialogResult.OK)
            {
                foreach(string File in BarcodeDialog.FileNames)
                {
                    listBox1.Items.Add(File);
                }
                PublicShareClass.WindowStruct.SingPic_Insert_WordFiles = new System.Collections.ArrayList(BarcodeDialog.FileNames);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(PublicShareClass.WindowStruct.SingPic_Insert_WordFiles!=null&&PublicShareClass.WindowStruct.SingPic_One_Path!=string.Empty)
            {
                DialogResult DR = folderBrowserDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    PublicShareClass.WindowStruct.SamePicInsert_SavePath = folderBrowserDialog1.SelectedPath;//处理后保存的目录
                    new InsertSameImg().InsertInto();//对word文件进行插入操作
                }
            }
            else
            {
                MessageBox.Show("请先设置二维码图片和要处理的word文档","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }
    }
}
