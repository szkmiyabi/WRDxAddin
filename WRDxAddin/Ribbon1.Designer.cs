namespace WRDxAddin
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl1 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl2 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl3 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl4 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl5 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl6 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl7 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl8 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl9 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl10 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl11 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl12 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl13 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl14 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl15 = this.Factory.CreateRibbonDropDownItem();
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.box1 = this.Factory.CreateRibbonBox();
            this.writeCommentCombo = this.Factory.CreateRibbonComboBox();
            this.writeCommentInputButton = this.Factory.CreateRibbonButton();
            this.box2 = this.Factory.CreateRibbonBox();
            this.writeCommentAddButton = this.Factory.CreateRibbonButton();
            this.writeCommentAddFromFormButton = this.Factory.CreateRibbonButton();
            this.writeCommentAddFromFileButton = this.Factory.CreateRibbonButton();
            this.addCommentPreClearCheck = this.Factory.CreateRibbonCheckBox();
            this.box3 = this.Factory.CreateRibbonBox();
            this.delCommentSingleButton = this.Factory.CreateRibbonButton();
            this.delCommentAllButton = this.Factory.CreateRibbonButton();
            this.doEditComboButton = this.Factory.CreateRibbonButton();
            this.writeCommentComboSaveButton = this.Factory.CreateRibbonButton();
            this.box6 = this.Factory.CreateRibbonBox();
            this.writeMarkCombo = this.Factory.CreateRibbonComboBox();
            this.writeMarkInputButton = this.Factory.CreateRibbonButton();
            this.writeMarkHamCheck = this.Factory.CreateRibbonCheckBox();
            this.box8 = this.Factory.CreateRibbonBox();
            this.divideBy10Button = this.Factory.CreateRibbonButton();
            this.writeEnterButton = this.Factory.CreateRibbonButton();
            this.textDuplicateButton = this.Factory.CreateRibbonButton();
            this.insertPageBreakButton = this.Factory.CreateRibbonButton();
            this.box4 = this.Factory.CreateRibbonBox();
            this.insertOpacityTextBoxButton = this.Factory.CreateRibbonButton();
            this.insertNoFillRoundedRectButton = this.Factory.CreateRibbonButton();
            this.insertRectangleCalloutButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box5 = this.Factory.CreateRibbonBox();
            this.paddingCombo = this.Factory.CreateRibbonComboBox();
            this.paddingButton = this.Factory.CreateRibbonButton();
            this.paddingTypeSplitButton = this.Factory.CreateRibbonSplitButton();
            this.paddingTypeTop = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeBottom = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeLeft = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeRight = this.Factory.CreateRibbonToggleButton();
            this.box7 = this.Factory.CreateRibbonBox();
            this.saveAsDesktopButton = this.Factory.CreateRibbonButton();
            this.saveAsPDFButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.box6.SuspendLayout();
            this.box8.SuspendLayout();
            this.box4.SuspendLayout();
            this.group2.SuspendLayout();
            this.box5.SuspendLayout();
            this.box7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "WRDxA";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.box1);
            this.group1.Items.Add(this.box2);
            this.group1.Items.Add(this.box3);
            this.group1.Items.Add(this.box6);
            this.group1.Items.Add(this.box8);
            this.group1.Items.Add(this.box4);
            this.group1.Label = "文章編集";
            this.group1.Name = "group1";
            // 
            // box1
            // 
            this.box1.Items.Add(this.writeCommentCombo);
            this.box1.Items.Add(this.writeCommentInputButton);
            this.box1.Name = "box1";
            // 
            // writeCommentCombo
            // 
            this.writeCommentCombo.Label = "comboBox1";
            this.writeCommentCombo.Name = "writeCommentCombo";
            this.writeCommentCombo.ShowLabel = false;
            this.writeCommentCombo.SizeString = "AAAAAAAAAAA";
            this.writeCommentCombo.Text = null;
            // 
            // writeCommentInputButton
            // 
            this.writeCommentInputButton.Label = "語句挿入";
            this.writeCommentInputButton.Name = "writeCommentInputButton";
            this.writeCommentInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentInputButton_Click);
            // 
            // box2
            // 
            this.box2.Items.Add(this.writeCommentAddButton);
            this.box2.Items.Add(this.writeCommentAddFromFormButton);
            this.box2.Items.Add(this.writeCommentAddFromFileButton);
            this.box2.Items.Add(this.addCommentPreClearCheck);
            this.box2.Name = "box2";
            // 
            // writeCommentAddButton
            // 
            this.writeCommentAddButton.Label = "選択範囲";
            this.writeCommentAddButton.Name = "writeCommentAddButton";
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFormButton
            // 
            this.writeCommentAddFromFormButton.Label = "フォーム";
            this.writeCommentAddFromFormButton.Name = "writeCommentAddFromFormButton";
            this.writeCommentAddFromFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFormButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイル";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全クリア追加";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // box3
            // 
            this.box3.Items.Add(this.delCommentSingleButton);
            this.box3.Items.Add(this.delCommentAllButton);
            this.box3.Items.Add(this.doEditComboButton);
            this.box3.Items.Add(this.writeCommentComboSaveButton);
            this.box3.Name = "box3";
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Label = "1件削除";
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Label = "全件削除";
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentAllButton_Click);
            // 
            // doEditComboButton
            // 
            this.doEditComboButton.Label = "値編集";
            this.doEditComboButton.Name = "doEditComboButton";
            this.doEditComboButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doEditComboButton_Click);
            // 
            // writeCommentComboSaveButton
            // 
            this.writeCommentComboSaveButton.Label = "ファイル保存";
            this.writeCommentComboSaveButton.Name = "writeCommentComboSaveButton";
            this.writeCommentComboSaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentComboSaveButton_Click);
            // 
            // box6
            // 
            this.box6.Items.Add(this.writeMarkCombo);
            this.box6.Items.Add(this.writeMarkInputButton);
            this.box6.Items.Add(this.writeMarkHamCheck);
            this.box6.Name = "box6";
            // 
            // writeMarkCombo
            // 
            ribbonDropDownItemImpl1.Label = "※";
            ribbonDropDownItemImpl2.Label = "●";
            ribbonDropDownItemImpl3.Label = "○";
            ribbonDropDownItemImpl4.Label = "×";
            ribbonDropDownItemImpl5.Label = "■";
            ribbonDropDownItemImpl6.Label = "←";
            ribbonDropDownItemImpl7.Label = "→";
            ribbonDropDownItemImpl8.Label = "↑";
            ribbonDropDownItemImpl9.Label = "↓";
            ribbonDropDownItemImpl10.Label = "【 】";
            ribbonDropDownItemImpl11.Label = "[ ]";
            ribbonDropDownItemImpl12.Label = "「 」";
            ribbonDropDownItemImpl13.Label = "『 』";
            ribbonDropDownItemImpl14.Label = "\" \"";
            ribbonDropDownItemImpl15.Label = "\' \'";
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl1);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl2);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl3);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl4);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl5);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl6);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl7);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl8);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl9);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl10);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl11);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl12);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl13);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl14);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl15);
            this.writeMarkCombo.Label = "comboBox1";
            this.writeMarkCombo.Name = "writeMarkCombo";
            this.writeMarkCombo.ShowLabel = false;
            this.writeMarkCombo.SizeString = "AA";
            this.writeMarkCombo.Text = null;
            // 
            // writeMarkInputButton
            // 
            this.writeMarkInputButton.Label = "記号挿入";
            this.writeMarkInputButton.Name = "writeMarkInputButton";
            this.writeMarkInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeMarkInputButton_Click);
            // 
            // writeMarkHamCheck
            // 
            this.writeMarkHamCheck.Label = "挟込";
            this.writeMarkHamCheck.Name = "writeMarkHamCheck";
            // 
            // box8
            // 
            this.box8.Items.Add(this.divideBy10Button);
            this.box8.Items.Add(this.writeEnterButton);
            this.box8.Items.Add(this.textDuplicateButton);
            this.box8.Items.Add(this.insertPageBreakButton);
            this.box8.Name = "box8";
            // 
            // divideBy10Button
            // 
            this.divideBy10Button.Label = "金額10%";
            this.divideBy10Button.Name = "divideBy10Button";
            this.divideBy10Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.divideBy10Button_Click);
            // 
            // writeEnterButton
            // 
            this.writeEnterButton.Label = "改行";
            this.writeEnterButton.Name = "writeEnterButton";
            this.writeEnterButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeEnterButton_Click);
            // 
            // textDuplicateButton
            // 
            this.textDuplicateButton.Label = "文字複製";
            this.textDuplicateButton.Name = "textDuplicateButton";
            this.textDuplicateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.textDuplicateButton_Click);
            // 
            // insertPageBreakButton
            // 
            this.insertPageBreakButton.Label = "改ページ";
            this.insertPageBreakButton.Name = "insertPageBreakButton";
            this.insertPageBreakButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertPageBreakButton_Click);
            // 
            // box4
            // 
            this.box4.Items.Add(this.insertOpacityTextBoxButton);
            this.box4.Items.Add(this.insertNoFillRoundedRectButton);
            this.box4.Items.Add(this.insertRectangleCalloutButton);
            this.box4.Name = "box4";
            // 
            // insertOpacityTextBoxButton
            // 
            this.insertOpacityTextBoxButton.Label = "透明枠";
            this.insertOpacityTextBoxButton.Name = "insertOpacityTextBoxButton";
            this.insertOpacityTextBoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertOpacityTextBoxButton_Click);
            // 
            // insertNoFillRoundedRectButton
            // 
            this.insertNoFillRoundedRectButton.Label = "赤枠";
            this.insertNoFillRoundedRectButton.Name = "insertNoFillRoundedRectButton";
            this.insertNoFillRoundedRectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertNoFillRoundedRectButton_Click);
            // 
            // insertRectangleCalloutButton
            // 
            this.insertRectangleCalloutButton.Label = "吹出";
            this.insertRectangleCalloutButton.Name = "insertRectangleCalloutButton";
            this.insertRectangleCalloutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertRectangleCalloutButton_Click);
            // 
            // group2
            // 
            this.group2.Items.Add(this.box5);
            this.group2.Items.Add(this.box7);
            this.group2.Label = "ページ設定";
            this.group2.Name = "group2";
            // 
            // box5
            // 
            this.box5.Items.Add(this.paddingCombo);
            this.box5.Items.Add(this.paddingButton);
            this.box5.Items.Add(this.paddingTypeSplitButton);
            this.box5.Name = "box5";
            // 
            // paddingCombo
            // 
            this.paddingCombo.Label = "comboBox1";
            this.paddingCombo.Name = "paddingCombo";
            this.paddingCombo.ShowLabel = false;
            this.paddingCombo.SizeString = "A";
            this.paddingCombo.Text = null;
            // 
            // paddingButton
            // 
            this.paddingButton.Label = "余白";
            this.paddingButton.Name = "paddingButton";
            this.paddingButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.paddingButton_Click);
            // 
            // paddingTypeSplitButton
            // 
            this.paddingTypeSplitButton.Items.Add(this.paddingTypeTop);
            this.paddingTypeSplitButton.Items.Add(this.paddingTypeBottom);
            this.paddingTypeSplitButton.Items.Add(this.paddingTypeLeft);
            this.paddingTypeSplitButton.Items.Add(this.paddingTypeRight);
            this.paddingTypeSplitButton.Label = "属性";
            this.paddingTypeSplitButton.Name = "paddingTypeSplitButton";
            this.paddingTypeSplitButton.OfficeImageId = "TableCellCustomMarginsDialog";
            this.paddingTypeSplitButton.ShowLabel = false;
            // 
            // paddingTypeTop
            // 
            this.paddingTypeTop.Checked = true;
            this.paddingTypeTop.Label = "上";
            this.paddingTypeTop.Name = "paddingTypeTop";
            this.paddingTypeTop.ShowImage = true;
            // 
            // paddingTypeBottom
            // 
            this.paddingTypeBottom.Checked = true;
            this.paddingTypeBottom.Label = "下";
            this.paddingTypeBottom.Name = "paddingTypeBottom";
            this.paddingTypeBottom.ShowImage = true;
            // 
            // paddingTypeLeft
            // 
            this.paddingTypeLeft.Checked = true;
            this.paddingTypeLeft.Label = "左";
            this.paddingTypeLeft.Name = "paddingTypeLeft";
            this.paddingTypeLeft.ShowImage = true;
            // 
            // paddingTypeRight
            // 
            this.paddingTypeRight.Checked = true;
            this.paddingTypeRight.Label = "右";
            this.paddingTypeRight.Name = "paddingTypeRight";
            this.paddingTypeRight.ShowImage = true;
            // 
            // box7
            // 
            this.box7.Items.Add(this.saveAsDesktopButton);
            this.box7.Items.Add(this.saveAsPDFButton);
            this.box7.Name = "box7";
            // 
            // saveAsDesktopButton
            // 
            this.saveAsDesktopButton.Label = "別名保存";
            this.saveAsDesktopButton.Name = "saveAsDesktopButton";
            this.saveAsDesktopButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsDesktopButton_Click);
            // 
            // saveAsPDFButton
            // 
            this.saveAsPDFButton.Label = "PDF保存";
            this.saveAsPDFButton.Name = "saveAsPDFButton";
            this.saveAsPDFButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsPDFButton_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.box1.ResumeLayout(false);
            this.box1.PerformLayout();
            this.box2.ResumeLayout(false);
            this.box2.PerformLayout();
            this.box3.ResumeLayout(false);
            this.box3.PerformLayout();
            this.box6.ResumeLayout(false);
            this.box6.PerformLayout();
            this.box8.ResumeLayout(false);
            this.box8.PerformLayout();
            this.box4.ResumeLayout(false);
            this.box4.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.box5.ResumeLayout(false);
            this.box5.PerformLayout();
            this.box7.ResumeLayout(false);
            this.box7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box1;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox writeCommentCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddFromFormButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentAddFromFileButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox addCommentPreClearCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentSingleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton delCommentAllButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton doEditComboButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeCommentComboSaveButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox writeMarkCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeMarkInputButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox writeMarkHamCheck;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton writeEnterButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box5;
        internal Microsoft.Office.Tools.Ribbon.RibbonComboBox paddingCombo;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton paddingButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonSplitButton paddingTypeSplitButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton paddingTypeTop;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton paddingTypeBottom;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton paddingTypeLeft;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton paddingTypeRight;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box6;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton divideBy10Button;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton textDuplicateButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveAsDesktopButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton saveAsPDFButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertOpacityTextBoxButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertNoFillRoundedRectButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box4;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertPageBreakButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertRectangleCalloutButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
