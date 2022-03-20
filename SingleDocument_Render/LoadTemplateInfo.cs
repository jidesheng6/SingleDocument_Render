using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDocument_Render
{
    class LoadTemplateInfo
    {
        public void Fill_TemplateInfo()
        {
            PublicShareClass.WindowStruct.M_F.Template_PaperSize.Text = PublicShareClass.WindowStruct.Template_Size.ToString();//纸张大小
            PublicShareClass.WindowStruct.M_F.Template_Width.Text = PublicShareClass.WindowStruct.TemplatePage_Width.ToString();//页面宽度
            PublicShareClass.WindowStruct.M_F.Template_Height.Text = PublicShareClass.WindowStruct.TemplatePage_Height.ToString();//页面高度
            PublicShareClass.WindowStruct.M_F.SinglePic_Width.Text = PublicShareClass.WindowStruct.SinglePic_Width.ToString();//单人码图片宽度
            PublicShareClass.WindowStruct.M_F.SinglePic_Height.Text = PublicShareClass.WindowStruct.SinglePic_Height.ToString();//单人码图片高度
            PublicShareClass.WindowStruct.M_F.SinglePIc_X.Text = PublicShareClass.WindowStruct.SinglePic_XPoint.ToString();//X轴位置
            PublicShareClass.WindowStruct.M_F.SinglePIc_Y.Text = PublicShareClass.WindowStruct.SinglePic_YPoint.ToString();//Y轴位置
            switch (PublicShareClass.WindowStruct.Template_Direct.ToString())//获取纸张方向
            {
                case "Portrait":
                    PublicShareClass.WindowStruct.M_F.Template_Direct.Text = "纵向";
                    break;
                case "Landscape":
                    PublicShareClass.WindowStruct.M_F.Template_Direct.Text = "横向";
                    break;
            }

        }
    }
}
