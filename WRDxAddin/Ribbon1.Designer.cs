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
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl16 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl17 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl18 = this.Factory.CreateRibbonDropDownItem();
            Microsoft.Office.Tools.Ribbon.RibbonDropDownItem ribbonDropDownItemImpl19 = this.Factory.CreateRibbonDropDownItem();
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
            this.textCopyButton = this.Factory.CreateRibbonButton();
            this.textPasteButton = this.Factory.CreateRibbonButton();
            this.box6 = this.Factory.CreateRibbonBox();
            this.writeMarkCombo = this.Factory.CreateRibbonComboBox();
            this.writeMarkInputButton = this.Factory.CreateRibbonButton();
            this.writeMarkHamCheck = this.Factory.CreateRibbonCheckBox();
            this.divideBy10Button = this.Factory.CreateRibbonButton();
            this.box8 = this.Factory.CreateRibbonBox();
            this.writeEnterButton = this.Factory.CreateRibbonButton();
            this.textDuplicateButton = this.Factory.CreateRibbonButton();
            this.insertPageBreakButton = this.Factory.CreateRibbonButton();
            this.box4 = this.Factory.CreateRibbonBox();
            this.fontRedButton = this.Factory.CreateRibbonButton();
            this.fontBlueButton = this.Factory.CreateRibbonButton();
            this.fontBlackButton = this.Factory.CreateRibbonButton();
            this.fontBoldButton = this.Factory.CreateRibbonButton();
            this.fontNarrowButton = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.box9 = this.Factory.CreateRibbonBox();
            this.insertNoFillRoundedRectButton = this.Factory.CreateRibbonButton();
            this.insertLineArrowButton = this.Factory.CreateRibbonButton();
            this.insertArrowButton = this.Factory.CreateRibbonButton();
            this.insertRectangleCalloutButton = this.Factory.CreateRibbonButton();
            this.insertOpacityTextBoxButton = this.Factory.CreateRibbonButton();
            this.box10 = this.Factory.CreateRibbonBox();
            this.resetShapeStyleButton = this.Factory.CreateRibbonButton();
            this.bringFrontButton = this.Factory.CreateRibbonButton();
            this.positionFrontButton = this.Factory.CreateRibbonButton();
            this.flipHorizontalButton = this.Factory.CreateRibbonButton();
            this.flipVerticalButton = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.box5 = this.Factory.CreateRibbonBox();
            this.paddingCombo = this.Factory.CreateRibbonComboBox();
            this.paddingTypeSplitButton = this.Factory.CreateRibbonSplitButton();
            this.paddingTypeTop = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeBottom = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeLeft = this.Factory.CreateRibbonToggleButton();
            this.paddingTypeRight = this.Factory.CreateRibbonToggleButton();
            this.paddingButton = this.Factory.CreateRibbonButton();
            this.box7 = this.Factory.CreateRibbonBox();
            this.saveAsDesktopButton = this.Factory.CreateRibbonButton();
            this.saveAsPDFButton = this.Factory.CreateRibbonButton();
            this.pageRotateButton = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.box1.SuspendLayout();
            this.box2.SuspendLayout();
            this.box3.SuspendLayout();
            this.box6.SuspendLayout();
            this.box8.SuspendLayout();
            this.box4.SuspendLayout();
            this.group3.SuspendLayout();
            this.box9.SuspendLayout();
            this.box10.SuspendLayout();
            this.group2.SuspendLayout();
            this.box5.SuspendLayout();
            this.box7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group3);
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
            this.writeCommentCombo.SizeString = "AAAAAAAAAAAAAAAAA";
            this.writeCommentCombo.Text = null;
            // 
            // writeCommentInputButton
            // 
            this.writeCommentInputButton.Label = "語句挿入";
            this.writeCommentInputButton.Name = "writeCommentInputButton";
            this.writeCommentInputButton.OfficeImageId = "BrowseNext";
            this.writeCommentInputButton.ShowImage = true;
            this.writeCommentInputButton.ShowLabel = false;
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
            this.writeCommentAddButton.OfficeImageId = "SectionRename";
            this.writeCommentAddButton.ShowImage = true;
            this.writeCommentAddButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddButton_Click);
            // 
            // writeCommentAddFromFormButton
            // 
            this.writeCommentAddFromFormButton.Label = "フォーム";
            this.writeCommentAddFromFormButton.Name = "writeCommentAddFromFormButton";
            this.writeCommentAddFromFormButton.OfficeImageId = "FormControlInsertMenu";
            this.writeCommentAddFromFormButton.ShowImage = true;
            this.writeCommentAddFromFormButton.ShowLabel = false;
            this.writeCommentAddFromFormButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFormButton_Click);
            // 
            // writeCommentAddFromFileButton
            // 
            this.writeCommentAddFromFileButton.Label = "ファイル";
            this.writeCommentAddFromFileButton.Name = "writeCommentAddFromFileButton";
            this.writeCommentAddFromFileButton.OfficeImageId = "CreateDocumentLibrary";
            this.writeCommentAddFromFileButton.ShowImage = true;
            this.writeCommentAddFromFileButton.ShowLabel = false;
            this.writeCommentAddFromFileButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentAddFromFileButton_Click);
            // 
            // addCommentPreClearCheck
            // 
            this.addCommentPreClearCheck.Label = "全削除追加";
            this.addCommentPreClearCheck.Name = "addCommentPreClearCheck";
            // 
            // box3
            // 
            this.box3.Items.Add(this.delCommentSingleButton);
            this.box3.Items.Add(this.delCommentAllButton);
            this.box3.Items.Add(this.doEditComboButton);
            this.box3.Items.Add(this.writeCommentComboSaveButton);
            this.box3.Items.Add(this.textCopyButton);
            this.box3.Items.Add(this.textPasteButton);
            this.box3.Name = "box3";
            // 
            // delCommentSingleButton
            // 
            this.delCommentSingleButton.Label = "1件削除";
            this.delCommentSingleButton.Name = "delCommentSingleButton";
            this.delCommentSingleButton.OfficeImageId = "SectionMergeWithPrevious";
            this.delCommentSingleButton.ShowImage = true;
            this.delCommentSingleButton.ShowLabel = false;
            this.delCommentSingleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentSingleButton_Click);
            // 
            // delCommentAllButton
            // 
            this.delCommentAllButton.Label = "全件削除";
            this.delCommentAllButton.Name = "delCommentAllButton";
            this.delCommentAllButton.OfficeImageId = "SectionRemoveAll";
            this.delCommentAllButton.ShowImage = true;
            this.delCommentAllButton.ShowLabel = false;
            this.delCommentAllButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.delCommentAllButton_Click);
            // 
            // doEditComboButton
            // 
            this.doEditComboButton.Label = "値編集";
            this.doEditComboButton.Name = "doEditComboButton";
            this.doEditComboButton.OfficeImageId = "SearchTools";
            this.doEditComboButton.ShowImage = true;
            this.doEditComboButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.doEditComboButton_Click);
            // 
            // writeCommentComboSaveButton
            // 
            this.writeCommentComboSaveButton.Label = "値保存";
            this.writeCommentComboSaveButton.Name = "writeCommentComboSaveButton";
            this.writeCommentComboSaveButton.OfficeImageId = "SaveHollow";
            this.writeCommentComboSaveButton.ShowImage = true;
            this.writeCommentComboSaveButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeCommentComboSaveButton_Click);
            // 
            // textCopyButton
            // 
            this.textCopyButton.Label = "文字コピー";
            this.textCopyButton.Name = "textCopyButton";
            this.textCopyButton.OfficeImageId = "ContactCardCopy";
            this.textCopyButton.ShowImage = true;
            this.textCopyButton.ShowLabel = false;
            this.textCopyButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.textCopyButton_Click);
            // 
            // textPasteButton
            // 
            this.textPasteButton.Label = "文字貼付";
            this.textPasteButton.Name = "textPasteButton";
            this.textPasteButton.OfficeImageId = "ContactCardPaste";
            this.textPasteButton.ShowImage = true;
            this.textPasteButton.ShowLabel = false;
            this.textPasteButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.textPasteButton_Click);
            // 
            // box6
            // 
            this.box6.Items.Add(this.writeMarkCombo);
            this.box6.Items.Add(this.writeMarkInputButton);
            this.box6.Items.Add(this.writeMarkHamCheck);
            this.box6.Items.Add(this.divideBy10Button);
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
            ribbonDropDownItemImpl10.Label = "( )";
            ribbonDropDownItemImpl11.Label = "（ ）";
            ribbonDropDownItemImpl12.Label = "＜ ＞";
            ribbonDropDownItemImpl13.Label = "【 】";
            ribbonDropDownItemImpl14.Label = "[ ]";
            ribbonDropDownItemImpl15.Label = "< >";
            ribbonDropDownItemImpl16.Label = "「 」";
            ribbonDropDownItemImpl17.Label = "『 』";
            ribbonDropDownItemImpl18.Label = "\" \"";
            ribbonDropDownItemImpl19.Label = "\' \'";
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
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl16);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl17);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl18);
            this.writeMarkCombo.Items.Add(ribbonDropDownItemImpl19);
            this.writeMarkCombo.Label = "comboBox1";
            this.writeMarkCombo.Name = "writeMarkCombo";
            this.writeMarkCombo.ShowLabel = false;
            this.writeMarkCombo.SizeString = "AAAA";
            this.writeMarkCombo.Text = null;
            // 
            // writeMarkInputButton
            // 
            this.writeMarkInputButton.Label = "記号挿入";
            this.writeMarkInputButton.Name = "writeMarkInputButton";
            this.writeMarkInputButton.OfficeImageId = "BrowseNext";
            this.writeMarkInputButton.ShowImage = true;
            this.writeMarkInputButton.ShowLabel = false;
            this.writeMarkInputButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeMarkInputButton_Click);
            // 
            // writeMarkHamCheck
            // 
            this.writeMarkHamCheck.Label = "はさみこみ";
            this.writeMarkHamCheck.Name = "writeMarkHamCheck";
            // 
            // divideBy10Button
            // 
            this.divideBy10Button.Label = "10%";
            this.divideBy10Button.Name = "divideBy10Button";
            this.divideBy10Button.OfficeImageId = "DataTypeCurrencyBasic";
            this.divideBy10Button.ShowImage = true;
            this.divideBy10Button.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.divideBy10Button_Click);
            // 
            // box8
            // 
            this.box8.Items.Add(this.writeEnterButton);
            this.box8.Items.Add(this.textDuplicateButton);
            this.box8.Items.Add(this.insertPageBreakButton);
            this.box8.Name = "box8";
            // 
            // writeEnterButton
            // 
            this.writeEnterButton.Label = "改行";
            this.writeEnterButton.Name = "writeEnterButton";
            this.writeEnterButton.OfficeImageId = "ParagraphDialog";
            this.writeEnterButton.ShowImage = true;
            this.writeEnterButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.writeEnterButton_Click);
            // 
            // textDuplicateButton
            // 
            this.textDuplicateButton.Label = "複製";
            this.textDuplicateButton.Name = "textDuplicateButton";
            this.textDuplicateButton.OfficeImageId = "DelegateAccess";
            this.textDuplicateButton.ShowImage = true;
            this.textDuplicateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.textDuplicateButton_Click);
            // 
            // insertPageBreakButton
            // 
            this.insertPageBreakButton.Label = "改ページ";
            this.insertPageBreakButton.Name = "insertPageBreakButton";
            this.insertPageBreakButton.OfficeImageId = "BreaksGallery";
            this.insertPageBreakButton.ShowImage = true;
            this.insertPageBreakButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertPageBreakButton_Click);
            // 
            // box4
            // 
            this.box4.Items.Add(this.fontRedButton);
            this.box4.Items.Add(this.fontBlueButton);
            this.box4.Items.Add(this.fontBlackButton);
            this.box4.Items.Add(this.fontBoldButton);
            this.box4.Items.Add(this.fontNarrowButton);
            this.box4.Name = "box4";
            // 
            // fontRedButton
            // 
            this.fontRedButton.Label = "赤";
            this.fontRedButton.Name = "fontRedButton";
            this.fontRedButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontRedButton_Click);
            // 
            // fontBlueButton
            // 
            this.fontBlueButton.Label = "青";
            this.fontBlueButton.Name = "fontBlueButton";
            this.fontBlueButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontBlueButton_Click);
            // 
            // fontBlackButton
            // 
            this.fontBlackButton.Label = "黒";
            this.fontBlackButton.Name = "fontBlackButton";
            this.fontBlackButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontBlackButton_Click);
            // 
            // fontBoldButton
            // 
            this.fontBoldButton.Label = "太字";
            this.fontBoldButton.Name = "fontBoldButton";
            this.fontBoldButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontBoldButton_Click);
            // 
            // fontNarrowButton
            // 
            this.fontNarrowButton.Label = "細字";
            this.fontNarrowButton.Name = "fontNarrowButton";
            this.fontNarrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.fontNarrowButton_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.box9);
            this.group3.Items.Add(this.box10);
            this.group3.Label = "図形処理";
            this.group3.Name = "group3";
            // 
            // box9
            // 
            this.box9.Items.Add(this.insertNoFillRoundedRectButton);
            this.box9.Items.Add(this.insertLineArrowButton);
            this.box9.Items.Add(this.insertArrowButton);
            this.box9.Items.Add(this.insertRectangleCalloutButton);
            this.box9.Items.Add(this.insertOpacityTextBoxButton);
            this.box9.Name = "box9";
            // 
            // insertNoFillRoundedRectButton
            // 
            this.insertNoFillRoundedRectButton.Label = "赤枠";
            this.insertNoFillRoundedRectButton.Name = "insertNoFillRoundedRectButton";
            this.insertNoFillRoundedRectButton.OfficeImageId = "InkFeltTipPen";
            this.insertNoFillRoundedRectButton.ShowImage = true;
            this.insertNoFillRoundedRectButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertNoFillRoundedRectButton_Click);
            // 
            // insertLineArrowButton
            // 
            this.insertLineArrowButton.Label = "矢印";
            this.insertLineArrowButton.Name = "insertLineArrowButton";
            this.insertLineArrowButton.OfficeImageId = "Arrow";
            this.insertLineArrowButton.ShowImage = true;
            this.insertLineArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertLineArrowButton_Click);
            // 
            // insertArrowButton
            // 
            this.insertArrowButton.Label = "図矢印";
            this.insertArrowButton.Name = "insertArrowButton";
            this.insertArrowButton.OfficeImageId = "MultipleSelect";
            this.insertArrowButton.ShowImage = true;
            this.insertArrowButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertArrowButton_Click);
            // 
            // insertRectangleCalloutButton
            // 
            this.insertRectangleCalloutButton.Label = "吹出";
            this.insertRectangleCalloutButton.Name = "insertRectangleCalloutButton";
            this.insertRectangleCalloutButton.OfficeImageId = "Callout";
            this.insertRectangleCalloutButton.ShowImage = true;
            this.insertRectangleCalloutButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertRectangleCalloutButton_Click);
            // 
            // insertOpacityTextBoxButton
            // 
            this.insertOpacityTextBoxButton.Label = "透明枠";
            this.insertOpacityTextBoxButton.Name = "insertOpacityTextBoxButton";
            this.insertOpacityTextBoxButton.OfficeImageId = "DrawTextBox";
            this.insertOpacityTextBoxButton.ShowImage = true;
            this.insertOpacityTextBoxButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.insertOpacityTextBoxButton_Click);
            // 
            // box10
            // 
            this.box10.Items.Add(this.resetShapeStyleButton);
            this.box10.Items.Add(this.bringFrontButton);
            this.box10.Items.Add(this.positionFrontButton);
            this.box10.Items.Add(this.flipHorizontalButton);
            this.box10.Items.Add(this.flipVerticalButton);
            this.box10.Name = "box10";
            // 
            // resetShapeStyleButton
            // 
            this.resetShapeStyleButton.Label = "書式無";
            this.resetShapeStyleButton.Name = "resetShapeStyleButton";
            this.resetShapeStyleButton.OfficeImageId = "Clear";
            this.resetShapeStyleButton.ShowImage = true;
            this.resetShapeStyleButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.resetShapeStyleButton_Click);
            // 
            // bringFrontButton
            // 
            this.bringFrontButton.Label = "最前面";
            this.bringFrontButton.Name = "bringFrontButton";
            this.bringFrontButton.OfficeImageId = "CircularReferences";
            this.bringFrontButton.ShowImage = true;
            this.bringFrontButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.bringFrontButton_Click);
            // 
            // positionFrontButton
            // 
            this.positionFrontButton.Label = "自由配置";
            this.positionFrontButton.Name = "positionFrontButton";
            this.positionFrontButton.OfficeImageId = "EmptyPictureInsert";
            this.positionFrontButton.ShowImage = true;
            this.positionFrontButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.positionFrontButton_Click);
            // 
            // flipHorizontalButton
            // 
            this.flipHorizontalButton.Label = "横反転";
            this.flipHorizontalButton.Name = "flipHorizontalButton";
            this.flipHorizontalButton.OfficeImageId = "ReviewCompareTwoVersions";
            this.flipHorizontalButton.ShowImage = true;
            this.flipHorizontalButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.flipHorizontalButton_Click);
            // 
            // flipVerticalButton
            // 
            this.flipVerticalButton.Label = "縦反転";
            this.flipVerticalButton.Name = "flipVerticalButton";
            this.flipVerticalButton.OfficeImageId = "RowHeight";
            this.flipVerticalButton.ShowImage = true;
            this.flipVerticalButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.flipVerticalButton_Click);
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
            this.box5.Items.Add(this.paddingTypeSplitButton);
            this.box5.Items.Add(this.paddingButton);
            this.box5.Name = "box5";
            // 
            // paddingCombo
            // 
            this.paddingCombo.Label = "comboBox1";
            this.paddingCombo.Name = "paddingCombo";
            this.paddingCombo.ShowLabel = false;
            this.paddingCombo.SizeString = "AAA";
            this.paddingCombo.Text = null;
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
            // paddingButton
            // 
            this.paddingButton.Label = "余白";
            this.paddingButton.Name = "paddingButton";
            this.paddingButton.OfficeImageId = "AutoSizePage";
            this.paddingButton.ShowImage = true;
            this.paddingButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.paddingButton_Click);
            // 
            // box7
            // 
            this.box7.Items.Add(this.saveAsDesktopButton);
            this.box7.Items.Add(this.saveAsPDFButton);
            this.box7.Items.Add(this.pageRotateButton);
            this.box7.Name = "box7";
            // 
            // saveAsDesktopButton
            // 
            this.saveAsDesktopButton.Label = "別名";
            this.saveAsDesktopButton.Name = "saveAsDesktopButton";
            this.saveAsDesktopButton.OfficeImageId = "SaveHollow";
            this.saveAsDesktopButton.ShowImage = true;
            this.saveAsDesktopButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsDesktopButton_Click);
            // 
            // saveAsPDFButton
            // 
            this.saveAsPDFButton.Label = "PDF";
            this.saveAsPDFButton.Name = "saveAsPDFButton";
            this.saveAsPDFButton.OfficeImageId = "XlNewOdataConnLegacy";
            this.saveAsPDFButton.ShowImage = true;
            this.saveAsPDFButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.saveAsPDFButton_Click);
            // 
            // pageRotateButton
            // 
            this.pageRotateButton.Label = "回転";
            this.pageRotateButton.Name = "pageRotateButton";
            this.pageRotateButton.OfficeImageId = "DrawConvertInkToGeometry";
            this.pageRotateButton.ShowImage = true;
            this.pageRotateButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.pageRotateButton_Click);
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
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.box9.ResumeLayout(false);
            this.box9.PerformLayout();
            this.box10.ResumeLayout(false);
            this.box10.PerformLayout();
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
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertArrowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton insertLineArrowButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonBox box10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton resetShapeStyleButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton flipHorizontalButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton flipVerticalButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton positionFrontButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton bringFrontButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton pageRotateButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton textCopyButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton textPasteButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontBoldButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontRedButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontBlueButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontBlackButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton fontNarrowButton;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
