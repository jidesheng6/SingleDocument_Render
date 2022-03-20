using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Aspose.Words;
using Aspose.Words.Drawing;
using System.Text.RegularExpressions;
using System.Collections;
namespace SingleDocument_Render
{//公共区域用来共享变量的地方
    class PublicShareClass
    {
        public struct WindowStruct
        {
            public static Form1 M_F = Form1.MFR;//窗体的变量
            public static string TemplateFilePath=string.Empty;//模板文件的路径
            public static int TemplatePageCount;//模板文件的页数信息
            public static int SinglePic_Width;//单人码图片宽度
            public static int SinglePic_Height;//单人码图片高度
            public static float SinglePic_XPoint;//单人码的X轴位置
            public static float SinglePic_YPoint;//单人码的Y轴位置
            public static RelativeHorizontalPosition SinglePic_RH;//水平位置
            public static RelativeVerticalPosition SinglePic_RV;//垂直位置
            public static double TemplatePage_Width;//页面宽度
            public static double TemplatePage_Height;//页面高度
            public static Orientation Template_Direct;//纸张方向
            public static PaperSize Template_Size;//纸张大小
            public static ArrayList SinglePic_Files = new ArrayList() { };//单人码图片路径
            public static ArrayList OtherWordFIles = new ArrayList { };//被处理的Word路径
            public static string SetReplaceRule=string.Empty;//被搜索的内容
            public static ArrayList ReplaceContents;//将要被替换的内容
            public static int SinglePic_Status;//是否存在单人码
            public static string MutilSaveFloder = string.Empty;//保存多文件目录的地方
            public static string SplitFileSavePath = string.Empty;//分割文件被保存的路径
            public static string MergeFileName = string.Empty;//合并文件的名称
            public static string SingPic_One_Path = string.Empty;//单个单人码的路径信息
            public static ArrayList SingPic_Insert_WordFiles;//需要进行处理插入相同二维码的word文件
            public static string SamePicInsert_SavePath=string.Empty;//插入统一码保存的路径
            public static ArrayList OnlyMerge_WordFiles;//合并文档功能的文档名称数组
            public static string OnlyMergeSaveFileName = string.Empty;//合并后文档设置的名称
            public static ArrayList OnlyReplaceDocumentFiles;//替换文档功能中存放文档的完整路径
            public static int MutilFolderFLag;//点击ok后的flag
            public static int MegreFlag;//点击ok后的flag
        }
    }
}
