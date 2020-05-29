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

namespace WRDxAddin
{
    partial class Ribbon1
    {
        //mmからptに変換する
        private float mili2point(float size)
        {
            return size * (float)2.835;
        }

        //全余白を指定したmm値にする
        private void page_padding()
        {
            if (paddingCombo.Text == "" || paddingCombo.Text == null)
                return;
            var doc = getDoc();
            int sizenm = Int32.Parse(paddingCombo.Text);
            float size = mili2point(sizenm);
            if(paddingTypeTop.Checked) doc.PageSetup.TopMargin = size;
            if (paddingTypeBottom.Checked) doc.PageSetup.BottomMargin = size;
            if (paddingTypeLeft.Checked) doc.PageSetup.LeftMargin = size;
            if (paddingTypeRight.Checked) doc.PageSetup.RightMargin = size;
        }

        //別名保存する
        private void save_as_desktop()
        {
            string path = _get_docx_save_path();
            object filename = path;
            var doc = getDoc();
            doc.SaveAs2(ref filename);
        }

        //PDF保存する
        private void save_as_PDF_desktop()
        {
            string path = _get_pdf_save_path();
            object filename = path;
            var doc = getDoc();
            object format = Word.WdSaveFormat.wdFormatPDF;
            doc.SaveAs2(ref filename, ref format);
        }


    }
}
