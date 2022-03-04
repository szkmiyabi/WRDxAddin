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
using Microsoft.Office.Interop.Word;

namespace WRDxAddin
{
    partial class Ribbon1
    {
        private string br_sp = "<bkmk:br>";
        private string dt_ph = @"(<date)(:)(.+?)(:)([\-0-9]+)(>)";
        private string rp_ph = @"(.+)(<rep)(:)([0-9]+)(>)";


        //日付文字列タグをデコード
        private string decode_date_tag(string str)
        {
            Regex pt = new Regex(dt_ph, RegexOptions.Compiled);
            if (!pt.IsMatch(str))
                return str;
            MatchCollection mc = pt.Matches(str);
            foreach(Match m in mc)
            {
                string line = m.Groups[0].Value;
                string fmt = m.Groups[3].Value;
                int offset = Int32.Parse(m.Groups[5].Value);
                DateTime ymd = first_date();
                ymd = ymd.AddMonths(offset);
                Regex fmtpt = new Regex(@"^ggyy", RegexOptions.Compiled);
                str = (fmtpt.IsMatch(fmt)) ? str.Replace(line, ymd.ToString(fmt, culture)) : str.Replace(line, ymd.ToString(fmt));
            }
            return str;
        }

        //繰り返し文字列タグをデコード
        private string decode_repeat_tag(string str)
        {
            string ret = "";
            Regex pt = new Regex(rp_ph, RegexOptions.Compiled);
            if (!pt.IsMatch(str))
                return str;
            Match mt = pt.Match(str);
            string tar = mt.Groups[1].Value;
            string cn = mt.Groups[4].Value;
            int ncn = Int32.Parse(cn);
            for(int i=1; i<=ncn; i++)
            {
                ret += tar;
            }
            return ret;
        }

        //コンボで選択した文字列を挿入する
        private void write_comment()
        {
            var sa = getSelection();
            string src = writeCommentCombo.Text;
            src = src.Replace(br_sp, "\r\n");
            src = decode_date_tag(src);
            src = decode_repeat_tag(src);
            sa.TypeText(src);
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

        //コンボボックスデフォルト値のロード
        private void init_writeCommentCombo()
        {
            if (!System.IO.File.Exists(WriteUtilStorage))
                return;
            List<string> arr = new List<string>();
            StreamReader sr = new StreamReader(WriteUtilStorage, System.Text.Encoding.GetEncoding("shift_jis"));
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

        }

        //記号で前後を挟む
        private string mark_ham(string mark, string body)
        {
            Regex pt = new Regex(@"(\[|【|「|『|""|\'|\(|（|<|＜)( )(\]|】|」|』|""|\'|\)|）|>|＞)", RegexOptions.Compiled);
            if (!pt.IsMatch(mark))
                return body;
            Match mt = pt.Match(mark);
            return mt.Groups[1].Value + body + mt.Groups[3].Value;
        }

        //コンボで選択した記号を挿入する
        private void write_mark()
        {
            var sa = getSelection();
            string src = writeMarkCombo.Text;

            if (writeMarkHamCheck.Checked)
            {
                string body = sa.Text;
                body = mark_ham(src, body);
                sa.TypeText(body);
            }
            else
            {
                sa.TypeText(src);
            }

        }

        //改行挿入
        private void write_enter()
        {
            var sa = getSelection();
            sa.TypeText("\r\n");
        }

        //改ページ
        private void page_break()
        {
            var sa = getSelection();
            sa.InsertBreak(WdBreakType.wdPageBreak);
            
        }

        //コンマ除去
        private string comma_decode(string price)
        {
            return price.Replace(",", "");
        }

        //コンマ付与
        private string comma_encode(string price)
        {
            if (Int32.Parse(price) < 100)
                return price;
            int n = 1;
            StringBuilder sb = new StringBuilder();
            StringBuilder rsb = new StringBuilder();
            foreach(char w in price.Reverse<char>())
            {
                sb.Append(w);
                if ((n % 3) == 0 && n != price.Length) sb.Append(",");
                n++;
            }
            string tmp = sb.ToString();
            foreach(char w in tmp.Reverse<char>())
            {
                rsb.Append(w);
            }
            return rsb.ToString();
        }

        //金額を10分の1にする
        private void divide_by_10()
        {
            var sa = getSelection();
            if (sa.Text == "")
                return;
            string val = sa.Text;
            val = comma_decode(val);
            int inval = Int32.Parse(val);
            inval /= 10;
            string calcval = inval.ToString();
            calcval = comma_encode(calcval);
            sa.TypeText(calcval);

        }

        //選択範囲の文字を複製
        private void duplicate_selection()
        {
            var sa = getSelection();
            var old_text = sa.Text;
            sa.TypeText(old_text);
            sa.TypeText(old_text);
        }

        //透明枠を挿入
        private void insert_textbox()
        {
            var doc = getDoc();
            float[] size = { 200, 100 };
            var textBox = doc.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, getCursorLeft(), getCursorTop(), size[0], size[1]);
            textBox.Fill.Visible = MsoTriState.msoFalse;
            textBox.Line.Visible = MsoTriState.msoFalse;
            //textBox.TextFrame.TextRange.Font.Size = 9;
            //textBox.TextFrame.TextRange.Font.Name = "ＭＳ Ｐゴシック";
            textBox.TextFrame.TextRange.Text = "説明を入力";
            textBox.Select();
        }

        //図複製
        private void duplicate_shape()
        {
            var sa = getSelection();
            var shape = sa.ShapeRange[1].Duplicate();
            shape.Select();
            shape.IncrementLeft(5);
            shape.IncrementTop(5);
        }

        //角丸赤枠を挿入
        private void insert_rounded_rect()
        {
            var doc = getDoc();
            float[] size = { 120, 90 };
            var textBox = doc.Shapes.AddShape(5, getCursorLeft(), getCursorTop(), size[0], size[1]);
            // border設定
            textBox.Fill.Visible = MsoTriState.msoFalse;
            textBox.Line.ForeColor.RGB = getWordRGB(255, 0, 0);
            textBox.Line.Transparency = 0.2F;
            textBox.Line.Weight = 2.25F;
            // shadow設定
            textBox.Shadow.Visible = MsoTriState.msoTrue;
            textBox.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            textBox.Shadow.OffsetX = 1;
            textBox.Shadow.OffsetY = 1;
            textBox.Shadow.Transparency = 0.5F;
            textBox.Select();
        }

        //吹出を挿入
        private void insert_callout()
        {
            var doc = getDoc();
            float[] size = { 120, 90 };
            var rectCallout = doc.Shapes.AddShape(105, getCursorLeft(), getCursorTop(), size[0], size[1]);
            rectCallout.Fill.ForeColor.RGB = getWordRGB(255, 255, 255);
            rectCallout.TextFrame.TextRange.Font.ColorIndex = WdColorIndex.wdBlack;
            rectCallout.TextFrame.TextRange.Font.Size = 7;
            rectCallout.TextFrame.TextRange.Font.Name = "ＭＳ Ｐゴシック";
            rectCallout.Line.ForeColor.RGB = getWordRGB(255, 192, 0);
            rectCallout.Line.Weight = 1.5F;
            rectCallout.Select();
        }

        //文字枠を挿入
        private void insert_bordered_rect()
        {
            var doc = getDoc();
            float[] size = { 100, 80 };
            var textBox = doc.Shapes.AddTextbox(MsoTextOrientation.msoTextOrientationHorizontal, getCursorLeft(), getCursorTop(), size[0], size[1]);
            textBox.Fill.Visible = MsoTriState.msoFalse;
            textBox.Line.ForeColor.RGB = getWordRGB(166, 166, 166);
            textBox.TextFrame.TextRange.Font.ColorIndex = WdColorIndex.wdBlack;
            textBox.TextFrame.TextRange.Font.Size = 7;
            textBox.TextFrame.TextRange.Font.Name = "ＭＳ Ｐゴシック";
            textBox.Line.Weight = 1.5F;
            textBox.Fill.ForeColor.RGB = getWordRGB(255, 255, 255);
            textBox.Select();
        }

        //図形矢印を挿入
        private void insert_arrow()
        {
            var doc = getDoc();
            float[] size = { 200, 75 };
            var arrow = doc.Shapes.AddShape(33, 90, 90, size[0], size[1]);
            arrow.Fill.ForeColor.RGB = getWordRGB(255, 153, 0);
            arrow.Line.Visible = MsoTriState.msoFalse;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            arrow.Shadow.OffsetX = 1;
            arrow.Shadow.OffsetY = 1;
            arrow.Shadow.Transparency = 0.5F;
        }

        //線矢印を挿入
        private void insert_line_arrow()
        {
            var doc = getDoc();
            float[] matrix = { 85, 85 };
            var arrow = doc.Shapes.AddLine(matrix[0], matrix[1], matrix[0] + 60, matrix[1] + 10);
            arrow.Line.EndArrowheadStyle = MsoArrowheadStyle.msoArrowheadOpen;
            arrow.Line.EndArrowheadLength = MsoArrowheadLength.msoArrowheadLong;
            arrow.Line.EndArrowheadWidth = MsoArrowheadWidth.msoArrowheadWide;
            arrow.Line.ForeColor.RGB = getWordRGB(255, 0, 0);
            arrow.Line.Weight = 2.5F;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Visible = MsoTriState.msoTrue;
            arrow.Shadow.Style = MsoShadowStyle.msoShadowStyleOuterShadow;
            arrow.Shadow.OffsetX = 1;
            arrow.Shadow.OffsetY = 1;
            arrow.Shadow.Transparency = 0.5F;
        }

        //図形の書式無効化
        private void reset_shape_style()
        {
            var sa = getSelection();
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Fill.Visible = MsoTriState.msoFalse;
                sp.Line.Visible = MsoTriState.msoFalse;
                //sp.TextFrame.TextRange.Font.Bold = MsoTriState.msoFalse;
            }
        }

        //横反転
        private void horizontal_flip()
        {
            var sa = getSelection();
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Flip(MsoFlipCmd.msoFlipHorizontal);
            }
        }

        //縦反転
        private void vertical_flip()
        {
            var sa = getSelection();
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.Flip(MsoFlipCmd.msoFlipVertical);
            }
        }

        //文書内の全オブジェクトを選択
        private void select_object()
        {
            try
            {
                var doc = getDoc();
                var shapes = doc.Shapes;
                var sa = getSelection();
                int cnt = 0;
                for (int i = 1; i <= shapes.Count; i++)
                {
                    var sp = shapes[i];
                    if (sp.Type != MsoShapeType.msoPlaceholder && sp.Type != MsoShapeType.msoTable)
                    {
                        if (cnt == 0) sp.Select(MsoTriState.msoTrue);
                        else sp.Select(MsoTriState.msoFalse);
                        cnt++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("実行エラー：" + ex.Message);
            }
        }

        //前面に配置
        private void position_front()
        {
            var sa = getSelection();
            var sps = sa.InlineShapes;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                var spc = sp.ConvertToShape();
                spc.WrapFormat.Type = WdWrapType.wdWrapFront;
            }
        }

        //最前面に移動
        private void bring_front()
        {
            var sa = getSelection();
            var sps = sa.ShapeRange;
            for (int i = 1; i <= sps.Count; i++)
            {
                var sp = sps[i];
                sp.ZOrder(MsoZOrderCmd.msoBringToFront);
            }
        }

        //テキストのみコピー
        private void text_copy()
        {
            try
            {
                var sa = getSelection();
                sa.Copy();
            }
            catch (Exception ex)
            {
                MessageBox.Show("この機能はテキストのみです。テキストを選択してください。");
            }

        }

        //テキストのみ貼り付け
        private void text_paste()
        {
            try
            {
                var sa = getSelection();
                sa.PasteSpecial(DataType: WdPasteDataType.wdPasteText);
            }
            catch (Exception ex)
            {
                MessageBox.Show("この機能はテキストのみです。テキストを選択して再度試してください。");
            }
        }

        //赤字
        private void paint_text_red()
        {
            var sa = getSelection();
            sa.Font.Color = WdColor.wdColorRed;
        }

        //青字
        private void paint_text_blue()
        {
            var sa = getSelection();
            sa.Font.Color = WdColor.wdColorBlue;
        }

        //黒字
        private void paint_text_black()
        {
            var sa = getSelection();
            sa.Font.Color = WdColor.wdColorBlack;
        }

        //太字
        private void bold_text()
        {
            var sa = getSelection();
            sa.Font.Bold = 1;
        }

        //細字
        private void narrow_text()
        {
            var sa = getSelection();
            sa.Font.Bold = 0;
        }


    }
}
