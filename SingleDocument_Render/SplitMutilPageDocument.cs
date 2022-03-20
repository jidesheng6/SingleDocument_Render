using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Words;
using System.IO;
using System.Collections;
using System.Diagnostics;

namespace SingleDocument_Render
{
    class SplitMutilPageDocument//分割Word文档，对于多页的word操作
    {
        public void SplitDocument()//分割Word文档
        {
            if(PublicShareClass.WindowStruct.TemplateFilePath!=string.Empty)
            {
                PublicShareClass.WindowStruct.SplitFileSavePath = $"{Path.GetDirectoryName(PublicShareClass.WindowStruct.TemplateFilePath)}\\SplitTemp";
                Document TempSlplitDocument = new Document(PublicShareClass.WindowStruct.TemplateFilePath);
                TempSlplitDocument.CompatibilityOptions.OptimizeFor(Aspose.Words.Settings.MsWordVersion.Word2010);
                DocumentPageSplitter DPS = new DocumentPageSplitter(TempSlplitDocument);
                TempSlplitDocument.CompatibilityOptions.OptimizeFor(Aspose.Words.Settings.MsWordVersion.Word2010);
                for (int i = 1; i < PublicShareClass.WindowStruct.TemplatePageCount + 1; i++)
                {
                    Document SplitTempDoc = DPS.GetDocumentOfPage(i);
                    string SplitSaveName;
                    if (i < 10)
                    {
                        SplitSaveName = $"00{i}测评人_{Path.GetFileName(PublicShareClass.WindowStruct.TemplateFilePath).Replace(".docx", "").Replace(".doc","")}.docx";
                    }
                    else if (i >= 10 & i < 100)
                    {
                        SplitSaveName = $"0{i}测评人_{Path.GetFileName(PublicShareClass.WindowStruct.TemplateFilePath).Replace(".docx", "").Replace(".doc", "")}.docx";
                    }
                    else
                    {
                        SplitSaveName = $"{i}测评人_{Path.GetFileName(PublicShareClass.WindowStruct.TemplateFilePath).Replace(".docx", "").Replace(".doc", "")}.docx";
                    }
                    SplitTempDoc.Save(Path.Combine(PublicShareClass.WindowStruct.SplitFileSavePath, SplitSaveName), SaveFormat.Docx);
                }
                string[] SplitedFilesName = Directory.GetFiles($"{Path.GetDirectoryName(PublicShareClass.WindowStruct.TemplateFilePath)}\\SplitTemp", "*.docx");
                Array.Sort(SplitedFilesName);
                PublicShareClass.WindowStruct.M_F.progressBar1.Maximum = SplitedFilesName.Length;
                foreach (string FileName in SplitedFilesName)
                {
                    PublicShareClass.WindowStruct.M_F.progressBar1.Value += 1;
                    Document SPlitTemp_Doc_2 = new Document(FileName);
                    NodeCollection ParaGph = SPlitTemp_Doc_2.GetChildNodes(NodeType.Paragraph, true);
                    foreach (Paragraph PH in ParaGph)
                    {
                        //if (PH.GetText() == ControlChar.Cr)
                        //{
                        //    PH.Remove();
                        //}
                        foreach (Run run in PH.Runs)
                        {
                            if (run.Text == ControlChar.ColumnBreak || run.Text == ControlChar.PageBreak || run.Text == ControlChar.ParagraphBreak || run.Text == ControlChar.CrLf || run.Text == ControlChar.Cr || run.Text == ControlChar.SectionBreak)
                            {
                                run.Remove();//如果找到分栏符就删除掉
                            }
                        }
                    }
                    SPlitTemp_Doc_2.Save(FileName, SaveFormat.Docx);
                    PublicShareClass.WindowStruct.OtherWordFIles.Add(FileName);
                }
                PublicShareClass.WindowStruct.M_F.progressBar1.Value = 0;
            }
            
        }
    }
}
