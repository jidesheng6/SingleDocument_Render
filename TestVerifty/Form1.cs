using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Aspose.Words;
using DataMatrix.net;
using Aspose.Words.Drawing;
using System.Diagnostics;

namespace TestVerifty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> ls = new List<string>();
            string[,] a = new string[100,100];
            foreach (string s in  Directory.GetFiles("test","*.docx"))
            {
                Debug.WriteLine(ls.Count);
                Document d = new Document(s);
                NodeCollection nc = d.GetChildNodes(NodeType.Shape,true);
                foreach(Shape i in nc)
                {
                    if(i.HasImage)
                    {
                        DmtxImageDecoder di = new DmtxImageDecoder();
                        Bitmap bm = new Bitmap(i.ImageData.ToImage());
                        ls = di.DecodeImage(bm);

                    }
                }
                System.Diagnostics.Debug.Write(ls.Count);
            }

        }
    }
}
