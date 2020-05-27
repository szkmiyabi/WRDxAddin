﻿using System;
using System.Collections.Generic;
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

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

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

        //TXTファイル保存先を取得
        private string _get_txt_save_path()
        {
            string path = "";
            SaveFileDialog fda = new SaveFileDialog();
            fda.Filter = "Textファイル(*.txt)|*.txt";
            fda.Title = "名前を付けて保存";
            if (fda.ShowDialog() == DialogResult.OK)
            {
                path = fda.FileName;
            }
            return path;
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
    }
}
