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
using System.Text.RegularExpressions;
using System.Collections;


namespace SingleDocument_Render
{
    public partial class AddNameForm : Form
    {
        public AddNameForm()
        {
            InitializeComponent();
        }
        
        private void 粘贴姓名ToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void AddNameForm_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


        private void 粘贴姓名职务ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PublicShareClass.WindowStruct.SetReplaceRule = ReplaceRule.Text;
            PublicShareClass.WindowStruct.ReplaceContents = new ArrayList(ReplaceContent.Lines);
            if(PublicShareClass.WindowStruct.ReplaceContents.Count!=PublicShareClass.WindowStruct.OtherWordFIles.Count)
            {
                MessageBox.Show("请设置和文档数量相同的替换内容","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReplaceContent.Text = "";
        }
    }
}
