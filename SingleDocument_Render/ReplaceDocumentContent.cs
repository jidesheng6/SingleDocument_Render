using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using Aspose.Words.Replacing;
namespace SingleDocument_Render
{
    class ReplaceDocumentContent
    {
        public void ReplaceContent()
        {
            if(!MainRunForm.MRF.MergeFilesBox.Checked)
            {
                if (PublicShareClass.WindowStruct.SetReplaceRule != string.Empty || PublicShareClass.WindowStruct.ReplaceContents != null)
                {
                    if (PublicShareClass.WindowStruct.ReplaceContents.Count == PublicShareClass.WindowStruct.OtherWordFIles.Count)
                    {
                        for (int i = 0; i < PublicShareClass.WindowStruct.OtherWordFIles.Count; i++)
                        {
                            Document ReplaceTemp_Docuemnt = new Document(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString());
                            ReplaceTemp_Docuemnt.Range.Replace(PublicShareClass.WindowStruct.SetReplaceRule, PublicShareClass.WindowStruct.ReplaceContents[i].ToString());
                            ReplaceTemp_Docuemnt.Save(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString(), SaveFormat.Docx);
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("请设置和文档数量相同的替换内容", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
                    }

                }
            }
        }
        public void ReplaceDocumentWithOnly(string old,string newstring,FindReplaceOptions fos)
        {
            if(PublicShareClass.WindowStruct.OnlyReplaceDocumentFiles!=null)
            {
                OnlyReplaceDocumentContent.ORC.progressBar1.Maximum = PublicShareClass.WindowStruct.OnlyReplaceDocumentFiles.Count;
                foreach(string File in PublicShareClass.WindowStruct.OnlyReplaceDocumentFiles)
                {
                    OnlyReplaceDocumentContent.ORC.progressBar1.Value += 1;
                    Document ReplaceDocu = new Document(File);
                    ReplaceDocu.Range.Replace(old,newstring,fos);
                    ReplaceDocu.Save(File,SaveFormat.Docx);
                }
                OnlyReplaceDocumentContent.ORC.progressBar1.Value = 0;
                System.Windows.Forms.MessageBox.Show("执行完毕，请在源目录查看文件","提示",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
