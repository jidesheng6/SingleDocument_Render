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
    public partial class MegreMutilFiles : Form
    {
        public MegreMutilFiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog1.Filter = "word文件|*.doc;*.docx";
            openFileDialog1.Multiselect = true;
            DialogResult DR = openFileDialog1.ShowDialog();
            if(DR ==DialogResult.OK)
            {
                PublicShareClass.WindowStruct.OnlyMerge_WordFiles = new System.Collections.ArrayList(openFileDialog1.FileNames);
                foreach(string Word in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(Word);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PublicShareClass.WindowStruct.OnlyMerge_WordFiles!=null)
            {
                saveFileDialog1.Filter = "word文档|*.docx";
                saveFileDialog1.DefaultExt = "docx";
                saveFileDialog1.Title = "请设置要保存的文件名称";
                DialogResult DR = saveFileDialog1.ShowDialog();
                if (DR == DialogResult.OK)
                {
                    PublicShareClass.WindowStruct.OnlyMergeSaveFileName = saveFileDialog1.FileName;
                    new MergreFiles().OnlyMerege();//单纯的合并功能
                }
            }
            else
            {
                MessageBox.Show("请先设置要合并的word文档","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
