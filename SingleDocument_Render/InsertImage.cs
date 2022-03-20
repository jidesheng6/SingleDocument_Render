using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.IO;
using System.Drawing;
using Aspose.Words.Drawing;
using System.Collections;
using System.Diagnostics;
namespace SingleDocument_Render
{
    class InsertImage
    {
        string CustomSaveName;
        public void InsertImageWithAuto()//自动计算页面差值进行插码操作
        {
            new ReplaceDocumentContent().ReplaceContent();
            if (MainRunForm.MRF.AutoInsertOption.Checked)
            {
                for (int i = 0; i < PublicShareClass.WindowStruct.OtherWordFIles.Count; i++)
                {
                    if (PublicShareClass.WindowStruct.MergeFileName == string.Empty)
                    {
                        CustomSaveName = $"{Path.Combine(PublicShareClass.WindowStruct.MutilSaveFloder, Path.GetFileName(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString()))}";//自定义保存的路径
                    }
                    else
                    {
                        CustomSaveName = PublicShareClass.WindowStruct.OtherWordFIles[i].ToString();//自定义保存的路径
                    }
                    Document Template_SplitDoc = new Document(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString());
                    Template_SplitDoc.CompatibilityOptions.OptimizeFor(Aspose.Words.Settings.MsWordVersion.Word2010);
                    DocumentBuilder SplitDoc_Bulid = new DocumentBuilder(Template_SplitDoc);
                    Image CodeImg = Image.FromFile(PublicShareClass.WindowStruct.SinglePic_Files[i].ToString());
                    SplitDoc_Bulid.InsertImage(CodeImg, RelativeHorizontalPosition.LeftMargin, PublicShareClass.WindowStruct.TemplatePage_Width - 73.4, RelativeVerticalPosition.TopMargin, PublicShareClass.WindowStruct.TemplatePage_Height - 86.95, CodeImg.Width / 5, CodeImg.Height / 5, WrapType.None);
                    Template_SplitDoc.Save(CustomSaveName, SaveFormat.Docx);

                    CodeImg.Dispose();
                }
                System.Windows.Forms.MessageBox.Show("执行完毕", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
        }
        public void InsetImageWithSinglePic()//存在单人码则根据单人码位置信息来准确插码
        {
            new ReplaceDocumentContent().ReplaceContent();
            if (MainRunForm.MRF.AutoInsertOption.Checked)
            {
                for (int i = 0; i < PublicShareClass.WindowStruct.OtherWordFIles.Count; i++)
                {
                    if (PublicShareClass.WindowStruct.MergeFileName == string.Empty)
                    {
                        CustomSaveName = $"{Path.Combine(PublicShareClass.WindowStruct.MutilSaveFloder, Path.GetFileName(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString()))}";//自定义保存的路径
                    }
                    else
                    {
                        CustomSaveName = PublicShareClass.WindowStruct.OtherWordFIles[i].ToString();//自定义保存的路径
                    }
                    Document Template_SplitDoc = new Document(PublicShareClass.WindowStruct.OtherWordFIles[i].ToString());
                    Template_SplitDoc.CompatibilityOptions.OptimizeFor(Aspose.Words.Settings.MsWordVersion.Word2010);
                    DocumentBuilder SplitDoc_Bulid = new DocumentBuilder(Template_SplitDoc);
                    Image CodeImg = Image.FromFile(PublicShareClass.WindowStruct.SinglePic_Files[i].ToString());
                    SplitDoc_Bulid.InsertImage(CodeImg, PublicShareClass.WindowStruct.SinglePic_RH, PublicShareClass.WindowStruct.SinglePic_XPoint, PublicShareClass.WindowStruct.SinglePic_RV, PublicShareClass.WindowStruct.SinglePic_YPoint, CodeImg.Width / 5, CodeImg.Height / 5, WrapType.None);
                    Template_SplitDoc.Save(CustomSaveName, SaveFormat.Docx);
                    CodeImg.Dispose();
                }
                System.Windows.Forms.MessageBox.Show("执行完毕", "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk);
            }
            
        }
    }
}
