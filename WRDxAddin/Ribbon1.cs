using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace WRDxAddin
{
    public partial class Ribbon1
    {

        //Formオブジェクト
        private static InputForm _inpfrmObj;
        private static ComboEditForm _cmbefrmObj;

        //設定保存データ
        private string WriteUtilStorage;

        //日付時刻設定
        private CultureInfo culture;

        //コンストラクタ
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {
            //設定保存先
            init_save_storage();

            //日付時刻設定
            culture = new CultureInfo("ja-jp", true);
            culture.DateTimeFormat.Calendar = new JapaneseCalendar();

            init_writeCommentCombo();
            init_paddingCombo();
        }

        //InputFormインスタンスの取得
        public static InputForm inpfrmObj
        {
            get
            {
                if (_inpfrmObj == null || _inpfrmObj.IsDisposed)
                {
                    _inpfrmObj = new InputForm();
                }
                return _inpfrmObj;
            }
        }

        //ComboEditFormインスタンスの取得
        public static ComboEditForm cmbefrmObj
        {
            get
            {
                if (_cmbefrmObj == null || _cmbefrmObj.IsDisposed)
                {
                    _cmbefrmObj = new ComboEditForm();
                }
                return _cmbefrmObj;
            }
        }

        //コンボで選択した文字列を挿入する
        private void writeCommentInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            write_comment();
        }

        //ドロップダウンに値を追加する
        private void writeCommentAddButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment();
        }

        //フォームから値追加
        private void writeCommentAddFromFormButton_Click(object sender, RibbonControlEventArgs e)
        {
            inpfrmObj.Show();
        }

        //テキストファイルからドロップダウンに値を追加する
        private void writeCommentAddFromFileButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_add_comment_from_file();
        }

        //ドロップダウン選択項目削除
        private void delCommentSingleButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_clear_combo_comment_single();
        }

        //ドロップダウン項目全削除
        private void delCommentAllButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_clear_combo_comment_all();
        }

        //値編集
        private void doEditComboButton_Click(object sender, RibbonControlEventArgs e)
        {
            cmbefrmObj.Show();
        }

        //ドロップダウンの値を保存
        private void writeCommentComboSaveButton_Click(object sender, RibbonControlEventArgs e)
        {
            do_save_val_comment();
        }

        //ドロップダウンから記号を挿入
        private void writeMarkInputButton_Click(object sender, RibbonControlEventArgs e)
        {
            write_mark();
        }

        //改行挿入
        private void writeEnterButton_Click(object sender, RibbonControlEventArgs e)
        {
            write_enter();
        }

        //余白設定
        private void paddingButton_Click(object sender, RibbonControlEventArgs e)
        {
            page_padding();
        }

        //金額を10分の1にする
        private void divideBy10Button_Click(object sender, RibbonControlEventArgs e)
        {
            divide_by_10();
        }

        private void textDuplicateButton_Click(object sender, RibbonControlEventArgs e)
        {
            duplicate_selection();
        }
    }
}
