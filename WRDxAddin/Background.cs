using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using System.Globalization;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using System.IO;
using System.Text.RegularExpressions;
using System.Drawing;

namespace WRDxAddin
{
    partial class Ribbon1
    {

        //設定保存先のイニシャライザ
        private void init_save_storage()
        {
            string savepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WRDxAddin\";
            if (!System.IO.Directory.Exists(savepath))
                System.IO.Directory.CreateDirectory(savepath);

            WriteUtilStorage = savepath + "WriteUtilData.txt";
        }
        
        //余白コンボセットアップ
        private void init_paddingCombo()
        {
            int[] sizes =
            {
                0,5,8,9,10,11,12,13,14,15,20,25,30
            };
            foreach(int i in sizes)
            {
                RibbonDropDownItem itm = Factory.CreateRibbonDropDownItem();
                itm.Label = i.ToString();
                paddingCombo.Items.Add(itm);
            }

        }

        //TXTファイル保存先を取得
        private string _get_txt_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Textファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            fda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //DOCXファイル保存先を取得
        private string _get_docx_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Wordファイル(*.docx)|*.docx";
            fda.Title = "名前を付けて保存";
            fda.FileName = getDoc().Name;
            fda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //PDFファイル保存先を取得
        private string _get_pdf_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Wordファイル(*.pdf)|*.pdf";
            fda.Title = "名前を付けて保存";
            string crName = getDoc().Name;
            crName = crName.Replace(".docx",".pdf");
            crName = crName.Replace(".doc", ".pdf");
            fda.FileName = crName;
            fda.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
        }

        //選択範囲を取得
        private Word.Selection getSelection()
        {
            return Globals.ThisAddIn.Application.Selection;
        }

        //アクティブなドキュメントを取得
        private Word.Document getDoc()
        {
            return Globals.ThisAddIn.Application.ActiveDocument;
        }

        //カーソル横座標取得
        private float getCursorLeft()
        {
            return (float)getSelection().Information[Word.WdInformation.wdHorizontalPositionRelativeToPage];
        }

        //カーソル縦座標取得
        private float getCursorTop()
        {
            return (float)getSelection().Information[Word.WdInformation.wdVerticalPositionRelativeToPage];
        }

        //挿入可能場所か判定
        private Boolean write_enabled()
        {
            var sa = getSelection();
            if (sa.Type == Word.WdSelectionType.wdSelectionIP || sa.Type == Word.WdSelectionType.wdSelectionNormal)
                return true;
            else
                return false;
        }

        //月初日を取得
        private DateTime first_date()
        {
            DateTime ymd = DateTime.Now;
            string y = String.Format("{0, 4}", (int)ymd.Year);
            string m = String.Format("{0, 2}", (int)ymd.Month);
            string d = "01";
            return DateTime.Parse(y + "/" + m + "/" + d);
        }

        //Word用RGBスカラーを取得
        private int getWordRGB(int r, int g, int b)
        {
            Color c = Color.FromArgb(r, g, b);
            var cint = (Word.WdColor)(c.R + 0x100 * c.G + 0x10000 * c.B);
            return (int)cint;
        }


    }
}
