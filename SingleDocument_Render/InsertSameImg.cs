using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Aspose.Words;
using System.Drawing;


namespace SingleDocument_Render
{
    class InsertSameImg
    {
        public void InsertInto()
        {
            if(PublicShareClass.WindowStruct.SingPic_Insert_WordFiles!=null&&PublicShareClass.WindowStruct.SingPic_One_Path!=string.Empty)
            {
                Image CodeImage = Image.FromFile(PublicShareClass.WindowStruct.SingPic_One_Path);
                foreach (string Word in PublicShareClass.WindowStruct.SingPic_Insert_WordFiles)
                {
                    Document Temp_doc = new Document(Word);
                    DocumentBuilder Temp_DB = new DocumentBuilder(Temp_doc);
                    string SaveName = Path.GetFileName(Word);
                    Temp_DB.InsertImage(CodeImage,PublicShareClass.WindowStruct.SinglePic_RH,PublicShareClass.WindowStruct.SinglePic_XPoint,PublicShareClass.WindowStruct.SinglePic_RV,PublicShareClass.WindowStruct.SinglePic_YPoint,CodeImage.Width/5,CodeImage.Height/5,Aspose.Words.Drawing.WrapType.None);
                    Temp_doc.Save(Path.Combine(PublicShareClass.WindowStruct.SamePicInsert_SavePath,SaveName),SaveFormat.Docx);
                }
                System.Windows.Forms.MessageBox.Show("处理完毕","提示",System.Windows.Forms.MessageBoxButtons.OK,System.Windows.Forms.MessageBoxIcon.Information);
            }
        }
    }
}
