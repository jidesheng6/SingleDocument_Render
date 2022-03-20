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
    public partial class OnlyReplaceDocumentContent : Form
    {
        public static OnlyReplaceDocumentContent ORC;
        public OnlyReplaceDocumentContent()
        {
            InitializeComponent();
            ORC = this;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            openFileDialog1.Filter = "word文档|*.doc;*.docx";
            openFileDialog1.Multiselect = true;
            DialogResult DR = openFileDialog1.ShowDialog();
            if(DR==DialogResult.OK)
            {
                PublicShareClass.WindowStruct.OnlyReplaceDocumentFiles = new System.Collections.ArrayList(openFileDialog1.FileNames);
                foreach(string file in openFileDialog1.FileNames)
                {
                    listBox1.Items.Add(file);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(PublicShareClass.WindowStruct.OnlyReplaceDocumentFiles!=null)
            {
                if(OldBox.Text==string.Empty || NewBox.Text==string.Empty)
                {
                    MessageBox.Show("必须输入查找和替换内容", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    Aspose.Words.Replacing.FindReplaceOptions FRO = new Aspose.Words.Replacing.FindReplaceOptions();
                    if (MatchCase.Checked)
                    {
                        FRO.MatchCase = true;
                    }
                    if (MatchFull.Checked)
                    {
                        FRO.FindWholeWordsOnly = true;
                    }
                    new ReplaceDocumentContent().ReplaceDocumentWithOnly(OldBox.Text, NewBox.Text, FRO);
                }
            }
            else
            {
                MessageBox.Show("请先选择要处理的文档","提示",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
        }

        private void OnlyReplaceDocumentContent_Load(object sender, EventArgs e)
        {

        }
    }
}
