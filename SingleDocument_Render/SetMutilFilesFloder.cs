using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SingleDocument_Render
{
    class SetMutilFilesFloder
    {
        public void SetFolder()
        {
           DialogResult Status =  MainRunForm.MRF.ChooseMutilFilesDialog.ShowDialog();
            if(Status == DialogResult.OK)
            {
                PublicShareClass.WindowStruct.MutilSaveFloder = MainRunForm.MRF.ChooseMutilFilesDialog.SelectedPath;
                PublicShareClass.WindowStruct.MutilFolderFLag = 1;
            }
            else
            {
                PublicShareClass.WindowStruct.MutilFolderFLag = 0;
            }
        }
        public void SetMergeFile()//设置保存文件名
        {
            MainRunForm.MRF.SaveMergeDialog.DefaultExt = ".docx";
            MainRunForm.MRF.SaveMergeDialog.Filter = "word文件|*.docx";
            DialogResult Status = MainRunForm.MRF.SaveMergeDialog.ShowDialog();
            if(Status==DialogResult.OK)
            {
                PublicShareClass.WindowStruct.MergeFileName = MainRunForm.MRF.SaveMergeDialog.FileName;
                PublicShareClass.WindowStruct.MegreFlag = 1;
            }
            else
            {
                PublicShareClass.WindowStruct.MegreFlag = 0;
            }
        }
    }
}
