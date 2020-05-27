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

namespace WRDxAddin
{
    partial class Ribbon1
    {
        private string br_sp = "<bkmk:br>";

        //選択範囲を取得
        private Word.Selection getSelection()
        {
            return Globals.ThisAddIn.Application.Selection;
        }

        //挿入可能場所か判定
        private Boolean write_enabled()
        {
            var sa = getSelection();
            if (sa.Type == Word.WdSelectionType.wdSelectionIP)
                return true;
            else
                return false;
        }

        //コンボで選択した文字列を挿入する
        private void write_comment()
        {
            var sa = Globals.ThisAddIn.Application.Selection;
            if(write_enabled())
            {
                string src = writeCommentCombo.Text;
                src = src.Replace(br_sp, "\r\n");
                sa.TypeText(src);
            }
        }

        //ドロップダウンに値を追加する
        private void do_add_comment()
        {
            var sa = getSelection();
            string buff = sa.Text;
            buff = buff.Replace("\r\n", br_sp);
            buff = buff.Replace("\r", br_sp);
            if (buff != "")
            {
                //check onなら全クリア
                if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = buff;
                writeCommentCombo.Items.Add(item);
                MessageBox.Show("値の追加に成功しました");
            }
        }

        //テキストファイルからドロップダウンに値を追加する
        private void do_add_comment_from_file()
        {
            string filename = "";
            string body = "";
            List<string> arr = new List<string>();

            //check onなら全クリア
            if (addCommentPreClearCheck.Checked == true) do_clear_combo_comment_all();

            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "テキストファイル(*.txt)|*.txt";
            if (f.ShowDialog() == DialogResult.OK)
            {
                filename = f.FileName;
            }
            if (filename == "") return;
            StreamReader sr = new StreamReader(filename, System.Text.Encoding.GetEncoding("shift_jis"));
            while (sr.Peek() > -1)
            {
                string line = sr.ReadLine();
                arr.Add(line);
            }
            sr.Close();

            for (int i = 0; i < arr.Count; i++)
            {
                RibbonDropDownItem item = Factory.CreateRibbonDropDownItem();
                item.Label = arr[i].ToString();
                writeCommentCombo.Items.Add(item);
            }
            MessageBox.Show("値の追加に成功しました");

        }

        //ドロップダウン選択項目削除
        private void do_clear_combo_comment_single()
        {
            int idx = 0;
            string cr = writeCommentCombo.Text;

            for (int i = 0; i < writeCommentCombo.Items.Count; i++)
            {
                RibbonDropDownItem opt = writeCommentCombo.Items[i];
                if (opt.Label.Equals(cr))
                {
                    writeCommentCombo.Items.RemoveAt(idx);
                    writeCommentCombo.Text = "";
                    break;
                }
                idx++;
            }
        }

        //ドロップダウン項目全削除
        private void do_clear_combo_comment_all()
        {
            writeCommentCombo.Items.Clear();
            writeCommentCombo.Text = "";
        }

        //ドロップダウンの値を保存
        private void do_save_val_comment()
        {
            int cnt = writeCommentCombo.Items.Count;
            string body = "";
            for (int i = 0; i < cnt; i++)
            {
                string val = writeCommentCombo.Items[i].Label;
                body += val;
                if (i != (cnt - 1)) body += "\r\n";
            }
            string path = _get_txt_save_path();
            Encoding enc = Encoding.GetEncoding("Shift_JIS");
            StreamWriter sw = new StreamWriter(path, false, enc);
            sw.WriteLine(body);
            sw.Close();
            MessageBox.Show("保存できました!");
        }
    }
}
