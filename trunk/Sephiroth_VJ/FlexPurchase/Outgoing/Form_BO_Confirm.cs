using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;


namespace FlexPurchase.Outgoing
{
	public class Form_BO_Confirm : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Panel pnl_head;
		private C1.Win.C1List.C1Combo cmb_outProcess;
		private System.Windows.Forms.Label lbl_cont;
		private System.Windows.Forms.Label lbl_headInfo;
		private C1.Win.C1List.C1Combo cmb_outDiv;
		private System.Windows.Forms.Label lbl_outDiv;
		private C1.Win.C1List.C1Combo cmb_outType;
		private System.Windows.Forms.Label lbl_outType;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.Label lbl_outYmd;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label lbl_between;
		private C1.Win.C1List.C1Combo cmb_workLine;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_Confirm;
		private System.Windows.Forms.Label lbl_Confirm;
		private System.Windows.Forms.DateTimePicker dpick_outYmd_To;
		private System.Windows.Forms.DateTimePicker dpick_outYmd_From;
		private System.ComponentModel.IContainer components = null;

		public Form_BO_Confirm()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();
		}

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Confirm));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_Confirm = new C1.Win.C1List.C1Combo();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.cmb_workLine = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_outYmd_To = new System.Windows.Forms.DateTimePicker();
            this.cmb_outProcess = new C1.Win.C1List.C1Combo();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.dpick_outYmd_From = new System.Windows.Forms.DateTimePicker();
            this.cmb_outDiv = new C1.Win.C1List.C1Combo();
            this.lbl_outDiv = new System.Windows.Forms.Label();
            this.cmb_outType = new C1.Win.C1List.C1Combo();
            this.lbl_outType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_outYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Confirm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.GridDefinition = "17.9794520547945:False:True;79.2808219178082:False:False;0:False:True;\t0.39370078" +
                "7401575:False:True;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 113);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 463);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 171;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_Confirm);
            this.pnl_head.Controls.Add(this.lbl_Confirm);
            this.pnl_head.Controls.Add(this.cmb_workLine);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.lbl_between);
            this.pnl_head.Controls.Add(this.dpick_outYmd_To);
            this.pnl_head.Controls.Add(this.cmb_outProcess);
            this.pnl_head.Controls.Add(this.lbl_cont);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.dpick_outYmd_From);
            this.pnl_head.Controls.Add(this.cmb_outDiv);
            this.pnl_head.Controls.Add(this.lbl_outDiv);
            this.pnl_head.Controls.Add(this.cmb_outType);
            this.pnl_head.Controls.Add(this.lbl_outType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_outYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 105);
            this.pnl_head.TabIndex = 1;
            // 
            // cmb_Confirm
            // 
            this.cmb_Confirm.AddItemCols = 0;
            this.cmb_Confirm.AddItemSeparator = ';';
            this.cmb_Confirm.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Confirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Confirm.Caption = "";
            this.cmb_Confirm.CaptionHeight = 17;
            this.cmb_Confirm.CaptionStyle = style1;
            this.cmb_Confirm.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Confirm.ColumnCaptionHeight = 18;
            this.cmb_Confirm.ColumnFooterHeight = 18;
            this.cmb_Confirm.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Confirm.ContentHeight = 16;
            this.cmb_Confirm.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Confirm.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Confirm.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Confirm.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Confirm.EditorHeight = 16;
            this.cmb_Confirm.EvenRowStyle = style2;
            this.cmb_Confirm.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Confirm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Confirm.FooterStyle = style3;
            this.cmb_Confirm.GapHeight = 2;
            this.cmb_Confirm.HeadingStyle = style4;
            this.cmb_Confirm.HighLightRowStyle = style5;
            this.cmb_Confirm.ItemHeight = 15;
            this.cmb_Confirm.Location = new System.Drawing.Point(109, 76);
            this.cmb_Confirm.MatchEntryTimeout = ((long)(2000));
            this.cmb_Confirm.MaxDropDownItems = ((short)(5));
            this.cmb_Confirm.MaxLength = 32767;
            this.cmb_Confirm.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Confirm.Name = "cmb_Confirm";
            this.cmb_Confirm.OddRowStyle = style6;
            this.cmb_Confirm.PartialRightColumn = false;
            this.cmb_Confirm.PropBag = resources.GetString("cmb_Confirm.PropBag");
            this.cmb_Confirm.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Confirm.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Confirm.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Confirm.SelectedStyle = style7;
            this.cmb_Confirm.Size = new System.Drawing.Size(220, 20);
            this.cmb_Confirm.Style = style8;
            this.cmb_Confirm.TabIndex = 418;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Confirm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.ImageIndex = 2;
            this.lbl_Confirm.ImageList = this.img_Label;
            this.lbl_Confirm.Location = new System.Drawing.Point(8, 76);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(100, 21);
            this.lbl_Confirm.TabIndex = 417;
            this.lbl_Confirm.Text = "Outgoing Type";
            this.lbl_Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_workLine
            // 
            this.cmb_workLine.AddItemCols = 0;
            this.cmb_workLine.AddItemSeparator = ';';
            this.cmb_workLine.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine.Caption = "";
            this.cmb_workLine.CaptionHeight = 17;
            this.cmb_workLine.CaptionStyle = style9;
            this.cmb_workLine.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workLine.ColumnCaptionHeight = 18;
            this.cmb_workLine.ColumnFooterHeight = 18;
            this.cmb_workLine.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workLine.ContentHeight = 16;
            this.cmb_workLine.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workLine.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workLine.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workLine.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workLine.EditorHeight = 16;
            this.cmb_workLine.EvenRowStyle = style10;
            this.cmb_workLine.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine.FooterStyle = style11;
            this.cmb_workLine.GapHeight = 2;
            this.cmb_workLine.HeadingStyle = style12;
            this.cmb_workLine.HighLightRowStyle = style13;
            this.cmb_workLine.ItemHeight = 15;
            this.cmb_workLine.Location = new System.Drawing.Point(437, 32);
            this.cmb_workLine.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine.MaxDropDownItems = ((short)(5));
            this.cmb_workLine.MaxLength = 32767;
            this.cmb_workLine.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine.Name = "cmb_workLine";
            this.cmb_workLine.OddRowStyle = style14;
            this.cmb_workLine.PartialRightColumn = false;
            this.cmb_workLine.PropBag = resources.GetString("cmb_workLine.PropBag");
            this.cmb_workLine.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine.SelectedStyle = style15;
            this.cmb_workLine.Size = new System.Drawing.Size(220, 20);
            this.cmb_workLine.Style = style16;
            this.cmb_workLine.TabIndex = 415;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 1;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(336, 32);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 416;
            this.lbl_workLine.Text = "Work Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(210, 55);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 414;
            this.lbl_between.Text = "~";
            // 
            // dpick_outYmd_To
            // 
            this.dpick_outYmd_To.CustomFormat = "";
            this.dpick_outYmd_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_outYmd_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_outYmd_To.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_outYmd_To.Location = new System.Drawing.Point(229, 55);
            this.dpick_outYmd_To.Name = "dpick_outYmd_To";
            this.dpick_outYmd_To.Size = new System.Drawing.Size(100, 21);
            this.dpick_outYmd_To.TabIndex = 398;
            this.dpick_outYmd_To.Value = new System.DateTime(2006, 12, 20, 12, 16, 10, 485);
            // 
            // cmb_outProcess
            // 
            this.cmb_outProcess.AddItemCols = 0;
            this.cmb_outProcess.AddItemSeparator = ';';
            this.cmb_outProcess.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outProcess.Caption = "";
            this.cmb_outProcess.CaptionHeight = 17;
            this.cmb_outProcess.CaptionStyle = style17;
            this.cmb_outProcess.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outProcess.ColumnCaptionHeight = 18;
            this.cmb_outProcess.ColumnFooterHeight = 18;
            this.cmb_outProcess.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outProcess.ContentHeight = 16;
            this.cmb_outProcess.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outProcess.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outProcess.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outProcess.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outProcess.EditorHeight = 16;
            this.cmb_outProcess.EvenRowStyle = style18;
            this.cmb_outProcess.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outProcess.FooterStyle = style19;
            this.cmb_outProcess.GapHeight = 2;
            this.cmb_outProcess.HeadingStyle = style20;
            this.cmb_outProcess.HighLightRowStyle = style21;
            this.cmb_outProcess.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_outProcess.ItemHeight = 15;
            this.cmb_outProcess.Location = new System.Drawing.Point(760, 55);
            this.cmb_outProcess.MatchEntryTimeout = ((long)(2000));
            this.cmb_outProcess.MaxDropDownItems = ((short)(5));
            this.cmb_outProcess.MaxLength = 32767;
            this.cmb_outProcess.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outProcess.Name = "cmb_outProcess";
            this.cmb_outProcess.OddRowStyle = style22;
            this.cmb_outProcess.PartialRightColumn = false;
            this.cmb_outProcess.PropBag = resources.GetString("cmb_outProcess.PropBag");
            this.cmb_outProcess.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outProcess.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outProcess.SelectedStyle = style23;
            this.cmb_outProcess.Size = new System.Drawing.Size(220, 20);
            this.cmb_outProcess.Style = style24;
            this.cmb_outProcess.TabIndex = 397;
            // 
            // lbl_cont
            // 
            this.lbl_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cont.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.ImageIndex = 0;
            this.lbl_cont.ImageList = this.img_Label;
            this.lbl_cont.Location = new System.Drawing.Point(664, 55);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(100, 21);
            this.lbl_cont.TabIndex = 394;
            this.lbl_cont.Text = "Out Process";
            this.lbl_cont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 392;
            this.lbl_headInfo.Text = "      Outgoing Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_outYmd_From
            // 
            this.dpick_outYmd_From.CustomFormat = "";
            this.dpick_outYmd_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_outYmd_From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_outYmd_From.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_outYmd_From.Location = new System.Drawing.Point(109, 55);
            this.dpick_outYmd_From.Name = "dpick_outYmd_From";
            this.dpick_outYmd_From.Size = new System.Drawing.Size(100, 21);
            this.dpick_outYmd_From.TabIndex = 381;
            this.dpick_outYmd_From.Value = new System.DateTime(2006, 12, 20, 12, 16, 10, 485);
            // 
            // cmb_outDiv
            // 
            this.cmb_outDiv.AddItemCols = 0;
            this.cmb_outDiv.AddItemSeparator = ';';
            this.cmb_outDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outDiv.Caption = "";
            this.cmb_outDiv.CaptionHeight = 17;
            this.cmb_outDiv.CaptionStyle = style25;
            this.cmb_outDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outDiv.ColumnCaptionHeight = 18;
            this.cmb_outDiv.ColumnFooterHeight = 18;
            this.cmb_outDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outDiv.ContentHeight = 16;
            this.cmb_outDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outDiv.EditorHeight = 16;
            this.cmb_outDiv.EvenRowStyle = style26;
            this.cmb_outDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outDiv.FooterStyle = style27;
            this.cmb_outDiv.GapHeight = 2;
            this.cmb_outDiv.HeadingStyle = style28;
            this.cmb_outDiv.HighLightRowStyle = style29;
            this.cmb_outDiv.ItemHeight = 15;
            this.cmb_outDiv.Location = new System.Drawing.Point(760, 32);
            this.cmb_outDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_outDiv.MaxDropDownItems = ((short)(5));
            this.cmb_outDiv.MaxLength = 32767;
            this.cmb_outDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outDiv.Name = "cmb_outDiv";
            this.cmb_outDiv.OddRowStyle = style30;
            this.cmb_outDiv.PartialRightColumn = false;
            this.cmb_outDiv.PropBag = resources.GetString("cmb_outDiv.PropBag");
            this.cmb_outDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outDiv.SelectedStyle = style31;
            this.cmb_outDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_outDiv.Style = style32;
            this.cmb_outDiv.TabIndex = 361;
            // 
            // lbl_outDiv
            // 
            this.lbl_outDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outDiv.ImageIndex = 0;
            this.lbl_outDiv.ImageList = this.img_Label;
            this.lbl_outDiv.Location = new System.Drawing.Point(664, 32);
            this.lbl_outDiv.Name = "lbl_outDiv";
            this.lbl_outDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_outDiv.TabIndex = 360;
            this.lbl_outDiv.Text = "Outgoing Div";
            this.lbl_outDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_outType
            // 
            this.cmb_outType.AddItemCols = 0;
            this.cmb_outType.AddItemSeparator = ';';
            this.cmb_outType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outType.Caption = "";
            this.cmb_outType.CaptionHeight = 17;
            this.cmb_outType.CaptionStyle = style33;
            this.cmb_outType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outType.ColumnCaptionHeight = 18;
            this.cmb_outType.ColumnFooterHeight = 18;
            this.cmb_outType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outType.ContentHeight = 16;
            this.cmb_outType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outType.EditorHeight = 16;
            this.cmb_outType.EvenRowStyle = style34;
            this.cmb_outType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outType.FooterStyle = style35;
            this.cmb_outType.GapHeight = 2;
            this.cmb_outType.HeadingStyle = style36;
            this.cmb_outType.HighLightRowStyle = style37;
            this.cmb_outType.ItemHeight = 15;
            this.cmb_outType.Location = new System.Drawing.Point(437, 55);
            this.cmb_outType.MatchEntryTimeout = ((long)(2000));
            this.cmb_outType.MaxDropDownItems = ((short)(5));
            this.cmb_outType.MaxLength = 32767;
            this.cmb_outType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outType.Name = "cmb_outType";
            this.cmb_outType.OddRowStyle = style38;
            this.cmb_outType.PartialRightColumn = false;
            this.cmb_outType.PropBag = resources.GetString("cmb_outType.PropBag");
            this.cmb_outType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outType.SelectedStyle = style39;
            this.cmb_outType.Size = new System.Drawing.Size(220, 20);
            this.cmb_outType.Style = style40;
            this.cmb_outType.TabIndex = 358;
            // 
            // lbl_outType
            // 
            this.lbl_outType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outType.ImageIndex = 2;
            this.lbl_outType.ImageList = this.img_Label;
            this.lbl_outType.Location = new System.Drawing.Point(336, 55);
            this.lbl_outType.Name = "lbl_outType";
            this.lbl_outType.Size = new System.Drawing.Size(100, 21);
            this.lbl_outType.TabIndex = 357;
            this.lbl_outType.Text = "Outgoing Type";
            this.lbl_outType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 89);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_outYmd
            // 
            this.lbl_outYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outYmd.ImageIndex = 1;
            this.lbl_outYmd.ImageList = this.img_Label;
            this.lbl_outYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_outYmd.Name = "lbl_outYmd";
            this.lbl_outYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_outYmd.TabIndex = 50;
            this.lbl_outYmd.Text = "Outgoing Date";
            this.lbl_outYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 88);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style41;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style42;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style43;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style44;
            this.cmb_factory.HighLightRowStyle = style45;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style46;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style47;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style48;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 64);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(976, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 89);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 78);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Location = new System.Drawing.Point(12, 580);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(992, 0);
            this.pnl_menu.TabIndex = 170;
            // 
            // Form_BO_Confirm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Confirm";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Confirm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의
		private COM.OraDB MyOraDB      = new COM.OraDB();
		#endregion

		#region  db 컨넥트
		/// <summary>
		/// SELECT_SBO_MUTI_CONFIRM : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBO_MUTI_CONFIRM()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_NORMAL.SELECT_SBO_MUTI_CONFIRM";

			//02.ARGURMENT 명	
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_TO";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_TYPE";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_DIVISION";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[6] = "ARG_OUT_LINE";
		    MyOraDB.Parameter_Name[7] = "ARG_CONFIRM";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] =  (int)OracleType.Cursor;
			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, " ");
			MyOraDB.Parameter_Values[1] = dpick_outYmd_From.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = dpick_outYmd_To.Text.Replace("-","");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_outType, " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_outDiv, " ");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_outProcess, " ");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_workLine , " ");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_Confirm , " ");
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];

			
		}

		#endregion

		#region 공통 메서드
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting

            lbl_MainTitle.Text = "Outgoing Muti Confirm";
            this.Text = "Outgoing Muti Confirm";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			fgrid_main.Set_Grid("SBO_OUTGOING_CONFIRM", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);

			// user define varible set
			

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// cmb_workLine
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine, 0, 1, false);
			vDt.Dispose() ;


			//	cmb_workProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_outProcess, 1, 1, false);
			vDt.Dispose() ;

			// out_div set    cmb_outDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
			COM.ComCtl.Set_ComboList(vDt, cmb_outDiv , 1, 2, false, 56,0);
			cmb_outDiv.SelectedIndex = -1;

			// out_type set    cmb_outType
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO01");
			COM.ComCtl.Set_ComboList(vDt, cmb_outType , 1, 2, false, 56,0);
			cmb_outType.SelectedIndex = -1;


			// confirm yn
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBP03");
			COM.ComCtl.Set_ComboList(vDt, cmb_Confirm , 1, 2, false, 56,0);
			cmb_Confirm.SelectedIndex = -1;


			tbtn_Append.Enabled  = false;
			tbtn_Confirm.Enabled = false;
			tbtn_Create.Enabled  = false;
			tbtn_Delete.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			tbtn_Save.Enabled    = false;


		}



		private void Tbtn_PrintProcess(bool arg_bool)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 


			
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Confirm");

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_factory, "") +		"' ";
				sPara += "'" + dpick_outYmd_From.Text.Replace("-","") +		"' ";
				sPara += "'" + dpick_outYmd_To.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Confirm, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_workLine , "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outType, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outDiv, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_outProcess, "") +		"' ";
				

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
				MyReport.Text = "Outgoing By Option";
				MyReport.Show();

			



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		private void Tbtn_SearchProcess(bool arg_bool)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_factory}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					DataTable vDt = this.SELECT_SBO_MUTI_CONFIRM();

					if (vDt.Rows.Count > 0)
					{
						ClassLib.ComFunction.Display_FlexGrid_Normal(fgrid_main, vDt);
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
						
						
					
					}
					else
					{
						fgrid_main.ClearAll();
					}

				
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}




		#endregion

		#region 이벤트 처리
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SearchProcess(true);
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		    this.Tbtn_PrintProcess(true); 
		}



		#endregion



	}
}

