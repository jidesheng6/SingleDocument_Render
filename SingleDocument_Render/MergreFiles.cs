using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.IO;

namespace SingleDocument_Render
{
    class MergreFiles
    {
        public void MergeFile()
        {
            Document MergeDocument = new Document();
            DocumentBuilder MergeBulider = new DocumentBuilder(MergeDocument);
            string[] SplitTempName = Directory.GetFiles(PublicShareClass.WindowStruct.SplitFileSavePath,"*.docx");//获取临时目录中的所有文件
            foreach (string SplitName in SplitTempName)
            {
               Document MergeTemp = new Document(SplitName);
                MergeBulider.InsertDocument(MergeTemp,ImportFormatMode.KeepSourceFormatting);
            }
            MergeDocument.Save(PublicShareClass.WindowStruct.MergeFileName);
        }
        public void OnlyMerege()
        {
            Document MergeDocument = new Document();
            DocumentBuilder MergeBulider = new DocumentBuilder(MergeDocument);
            if(PublicShareClass.WindowStruct.OnlyMerge_WordFiles!=null)
            {
                foreach(string WordF in PublicShareClass.WindowStruct.OnlyMerge_WordFiles)
                {
                    Document MergeTemp = new Document(WordF);
                    MergeBulider.InsertDocument(MergeTemp,ImportFormatMode.KeepSourceFormatting);//合并文档
                }
                MergeDocument.Save(PublicShareClass.WindowStruct.OnlyMergeSaveFileName,SaveFormat.Docx);
                System.Windows.Forms.MessageBox.Show("执行完毕","提示",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
