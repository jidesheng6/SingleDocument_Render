using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Aspose.Words;
using Aspose.Words.Drawing;
using Aspose.Words.Loading;
using Aspose.Words.Layout;
using Aspose.Words.Saving;
using Aspose.Words.Tables;
using System.IO;
using System.Drawing;
using DataMatrix.net;
using System.Text.RegularExpressions;

namespace SingleDocument_Render
{
     class GetTemplateFile
    {
        
        private void GetTemplateFileName()//获取模板对话框选择后的目录名称
        {
            PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.Filter = "模版文件|*.doc;*.docx";
            DialogResult ChooseStatus = PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.ShowDialog();//打开选择模版的对话框
            if(ChooseStatus == DialogResult.OK)
            {
                PublicShareClass.WindowStruct.TemplateFilePath = PublicShareClass.WindowStruct.M_F.ChooseTemplateDialog.FileName;//为公共区域模板文件名赋值
            }
            else
            {
                PublicShareClass.WindowStruct.TemplateFilePath = string.Empty;
            }
        }
        public void LoadTemplateFiles()//通过Aspose加载文档,得到单人码的位置信息，如果没有，则就没有
        {
            GetTemplateFileName();//调用文件框
            if(PublicShareClass.WindowStruct.TemplateFilePath!=string.Empty)
            {
                int SinglePicNum = 0;//单人码图片计数
                Document TemplateDocument = new Document(PublicShareClass.WindowStruct.TemplateFilePath);//加载模版文件
                PublicShareClass.WindowStruct.TemplatePageCount = TemplateDocument.PageCount;//模板的页数信息
                TemplateDocument.CompatibilityOptions.OptimizeFor(Aspose.Words.Settings.MsWordVersion.Word2010);//去除兼容模式
                NodeCollection Template_Nodes = TemplateDocument.GetChildNodes(NodeType.Shape, true);//获取节点
                PublicShareClass.WindowStruct.M_F.progressBar1.Maximum = Template_Nodes.Count;
                SectionCollection Sections = TemplateDocument.Sections;//文档节
                                                                       //像素点到厘米转换公式：(point/72)*2.54
                foreach (Section Section in Sections)//此处用于获取页面相关信息
                {
                    PublicShareClass.WindowStruct.TemplatePage_Height = Section.PageSetup.PageHeight;//页面高度
                    PublicShareClass.WindowStruct.TemplatePage_Width = Section.PageSetup.PageWidth;//页面宽度
                    PublicShareClass.WindowStruct.Template_Direct = Section.PageSetup.Orientation;//纸张方向
                    PublicShareClass.WindowStruct.Template_Size = Section.PageSetup.PaperSize;//纸张大小
                }
                foreach (Shape Temp_Shape in Template_Nodes)//此处用于探测单人码信息，如果探测到，则可以使用其参数进行下一步操作
                {
                    PublicShareClass.WindowStruct.M_F.progressBar1.Value += 1;
                    if (Temp_Shape.HasImage)
                    {
                        Image Temp_PicData = Temp_Shape.ImageData.ToImage();
                        Bitmap Temp_BitMap = new Bitmap(Temp_PicData);
                        DmtxImageDecoder DataMartxDecode = new DmtxImageDecoder();
                        List<string> DecodeStrings = DataMartxDecode.DecodeImage(Temp_BitMap);//解析martx二维码
                        foreach (string DecodeString in DecodeStrings)
                        {
                            if (int.TryParse(DecodeString, out int result))
                            {
                                SinglePicNum++;//证明为单人码
                                PublicShareClass.WindowStruct.SinglePic_Height = Temp_BitMap.Height;//图片高度
                                PublicShareClass.WindowStruct.SinglePic_Width = Temp_BitMap.Width;//图片宽度
                                PublicShareClass.WindowStruct.SinglePic_XPoint = Temp_Shape.Bounds.X;//X轴相对位置
                                PublicShareClass.WindowStruct.SinglePic_YPoint = Temp_Shape.Bounds.Y;//Y轴相对位置
                                PublicShareClass.WindowStruct.SinglePic_RH = Temp_Shape.RelativeHorizontalPosition;//水平相对位置
                                PublicShareClass.WindowStruct.SinglePic_RV = Temp_Shape.RelativeVerticalPosition;//垂直相对位置
                                PublicShareClass.WindowStruct.SinglePic_Status = 1;
                            }
                            Application.DoEvents();
                        }
                    }
                }
                PublicShareClass.WindowStruct.M_F.progressBar1.Value = 0;
            }



        }
    }
}
