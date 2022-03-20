using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SingleDocument_Render
{
    class LoadOtherWords
    {
        public void LoadDocFile()
        {
            PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.Filter = "word文件|*.doc;*.docx";
            PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.Multiselect = true;
            DialogResult OtherWordFilesStatus = PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.ShowDialog();
            if(OtherWordFilesStatus==DialogResult.OK)
            {
                PublicShareClass.WindowStruct.OtherWordFIles = new System.Collections.ArrayList(PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.FileNames);
            }

        }
    }
}
