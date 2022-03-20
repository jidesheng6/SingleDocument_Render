using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace SingleDocument_Render
{
    class LoadDataMartxFiles
    {
        public void LoadDataMartx()
        {
            PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.Filter = "图片文件|*.bmp";
            PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.Multiselect = true;
            DialogResult OtherWordFilesStatus = PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.ShowDialog();
            if (OtherWordFilesStatus == DialogResult.OK)
            {
                PublicShareClass.WindowStruct.SinglePic_Files =  new System.Collections.ArrayList(PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.FileNames);//要插入的图片信息
            }
        }
    }
}
