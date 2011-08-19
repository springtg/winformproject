using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Outgoing
{
	public class Form_BO_Outside_Normal_Print_DPO : COM.PCHWinForm.Form_Top
	{
		#region 디자이너 생성 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_ToDate;
		private C1.Win.C1List.C1Combo cmb_OutDiv;
		private System.Windows.Forms.Label lbl_ProcessDiv;
		private System.Windows.Forms.DateTimePicker dpick_FromDate;
		private System.Windows.Forms.Label lbl_workYmd;
		private System.Windows.Forms.Label lbl_workProcess;
		private C1.Win.C1List.C1Combo cmb_Process;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.RadioButton rad_out_ymd;
		private System.Windows.Forms.RadioButton rad_real_out_ymd;
		private System.ComponentModel.IContainer components = null;


		public Form_BO_Outside_Normal_Print_DPO()
		{
			InitializeComponent();
		}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Outside_Normal_Print_DPO));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.rad_real_out_ymd = new System.Windows.Forms.RadioButton();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.rad_out_ymd = new System.Windows.Forms.RadioButton();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_ToDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_OutDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ProcessDiv = new System.Windows.Forms.Label();
            this.dpick_FromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_workYmd = new System.Windows.Forms.Label();
            this.lbl_workProcess = new System.Windows.Forms.Label();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.GridDefinition = "17.9310344827586:False:True;81.3793103448276:False:False;\t0.393700787401575:False" +
                ":True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.rad_real_out_ymd);
            this.pnl_head.Controls.Add(this.cmb_Line);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.rad_out_ymd);
            this.pnl_head.Controls.Add(this.lbl_between);
            this.pnl_head.Controls.Add(this.dpick_ToDate);
            this.pnl_head.Controls.Add(this.cmb_OutDiv);
            this.pnl_head.Controls.Add(this.lbl_ProcessDiv);
            this.pnl_head.Controls.Add(this.dpick_FromDate);
            this.pnl_head.Controls.Add(this.lbl_workYmd);
            this.pnl_head.Controls.Add(this.lbl_workProcess);
            this.pnl_head.Controls.Add(this.cmb_Process);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 104);
            this.pnl_head.TabIndex = 1;
            // 
            // rad_real_out_ymd
            // 
            this.rad_real_out_ymd.Checked = true;
            this.rad_real_out_ymd.Location = new System.Drawing.Point(480, 80);
            this.rad_real_out_ymd.Name = "rad_real_out_ymd";
            this.rad_real_out_ymd.Size = new System.Drawing.Size(144, 24);
            this.rad_real_out_ymd.TabIndex = 407;
            this.rad_real_out_ymd.TabStop = true;
            this.rad_real_out_ymd.Text = "Real outgoing date";
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemCols = 0;
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style1;
            this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Line.ColumnCaptionHeight = 18;
            this.cmb_Line.ColumnFooterHeight = 18;
            this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Line.ContentHeight = 16;
            this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Line.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.EvenRowStyle = style2;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style3;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style4;
            this.cmb_Line.HighLightRowStyle = style5;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(445, 56);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style6;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style7;
            this.cmb_Line.Size = new System.Drawing.Size(220, 20);
            this.cmb_Line.Style = style8;
            this.cmb_Line.TabIndex = 8;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 0;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(344, 56);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 375;
            this.lbl_workLine.Text = "Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad_out_ymd
            // 
            this.rad_out_ymd.Location = new System.Drawing.Point(352, 80);
            this.rad_out_ymd.Name = "rad_out_ymd";
            this.rad_out_ymd.Size = new System.Drawing.Size(144, 24);
            this.rad_out_ymd.TabIndex = 406;
            this.rad_out_ymd.Text = "Outgoing date";
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(211, 78);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 405;
            this.lbl_between.Text = "~";
            // 
            // dpick_ToDate
            // 
            this.dpick_ToDate.CustomFormat = "";
            this.dpick_ToDate.Enabled = false;
            this.dpick_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToDate.Location = new System.Drawing.Point(231, 78);
            this.dpick_ToDate.Name = "dpick_ToDate";
            this.dpick_ToDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_ToDate.TabIndex = 6;
            // 
            // cmb_OutDiv
            // 
            this.cmb_OutDiv.AddItemCols = 0;
            this.cmb_OutDiv.AddItemSeparator = ';';
            this.cmb_OutDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutDiv.Caption = "";
            this.cmb_OutDiv.CaptionHeight = 17;
            this.cmb_OutDiv.CaptionStyle = style9;
            this.cmb_OutDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutDiv.ColumnCaptionHeight = 18;
            this.cmb_OutDiv.ColumnFooterHeight = 18;
            this.cmb_OutDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutDiv.ContentHeight = 16;
            this.cmb_OutDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutDiv.EditorHeight = 16;
            this.cmb_OutDiv.EvenRowStyle = style10;
            this.cmb_OutDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutDiv.FooterStyle = style11;
            this.cmb_OutDiv.GapHeight = 2;
            this.cmb_OutDiv.HeadingStyle = style12;
            this.cmb_OutDiv.HighLightRowStyle = style13;
            this.cmb_OutDiv.ItemHeight = 15;
            this.cmb_OutDiv.Location = new System.Drawing.Point(109, 56);
            this.cmb_OutDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutDiv.MaxDropDownItems = ((short)(5));
            this.cmb_OutDiv.MaxLength = 32767;
            this.cmb_OutDiv.MouseCursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb_OutDiv.Name = "cmb_OutDiv";
            this.cmb_OutDiv.OddRowStyle = style14;
            this.cmb_OutDiv.PartialRightColumn = false;
            this.cmb_OutDiv.PropBag = resources.GetString("cmb_OutDiv.PropBag");
            this.cmb_OutDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.SelectedStyle = style15;
            this.cmb_OutDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_OutDiv.Style = style16;
            this.cmb_OutDiv.TabIndex = 397;
            // 
            // lbl_ProcessDiv
            // 
            this.lbl_ProcessDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ProcessDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcessDiv.ImageIndex = 0;
            this.lbl_ProcessDiv.ImageList = this.img_Label;
            this.lbl_ProcessDiv.Location = new System.Drawing.Point(8, 56);
            this.lbl_ProcessDiv.Name = "lbl_ProcessDiv";
            this.lbl_ProcessDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_ProcessDiv.TabIndex = 398;
            this.lbl_ProcessDiv.Text = "Out Division";
            this.lbl_ProcessDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_FromDate
            // 
            this.dpick_FromDate.CustomFormat = "";
            this.dpick_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromDate.Location = new System.Drawing.Point(109, 78);
            this.dpick_FromDate.Name = "dpick_FromDate";
            this.dpick_FromDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_FromDate.TabIndex = 5;
            this.dpick_FromDate.CloseUp += new System.EventHandler(this.dpick_FromDate_CloseUp);
            // 
            // lbl_workYmd
            // 
            this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workYmd.ImageIndex = 0;
            this.lbl_workYmd.ImageList = this.img_Label;
            this.lbl_workYmd.Location = new System.Drawing.Point(8, 78);
            this.lbl_workYmd.Name = "lbl_workYmd";
            this.lbl_workYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_workYmd.TabIndex = 50;
            this.lbl_workYmd.Text = "Work Date";
            this.lbl_workYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_workProcess
            // 
            this.lbl_workProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workProcess.ImageIndex = 0;
            this.lbl_workProcess.ImageList = this.img_Label;
            this.lbl_workProcess.Location = new System.Drawing.Point(344, 34);
            this.lbl_workProcess.Name = "lbl_workProcess";
            this.lbl_workProcess.Size = new System.Drawing.Size(100, 21);
            this.lbl_workProcess.TabIndex = 379;
            this.lbl_workProcess.Text = "Process";
            this.lbl_workProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemCols = 0;
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style17;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style18;
            this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style19;
            this.cmb_Process.GapHeight = 2;
            this.cmb_Process.HeadingStyle = style20;
            this.cmb_Process.HighLightRowStyle = style21;
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(445, 34);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style22;
            this.cmb_Process.PartialRightColumn = false;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style23;
            this.cmb_Process.Size = new System.Drawing.Size(220, 20);
            this.cmb_Process.Style = style24;
            this.cmb_Process.TabIndex = 0;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 34);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 88);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 87);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 34);
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 63);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Outgoing Production Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 77);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 108);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 13;
            // 
            // Form_BO_Outside_Normal_Print_DPO
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Outside_Normal_Print_DPO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.Form_BO_Outside_Normal_Print_DPO_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private ArrayList _columnIndex	= new ArrayList();
		private const int COL_WIDTH = 60, COL_START = 12;
		private const int COL_KEY_FROM = 0, COL_KEY_TO = 8, COL_HEAD = 11, COL_DISPLAY = 12;
		private const string _startCol = "A", _endCol = "IV";

		private FlexPurchase.Search.Pop_BW_QE_Wait _waitPop	= new FlexPurchase.Search.Pop_BW_QE_Wait();

		#endregion

		
		#region 이벤트 핸들러

		private void Form_BO_Outside_Normal_Print_DPO_Load(object sender, System.EventArgs e)
		{
			this.Init_Form();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
            this.BindData();		
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			PrintData();
		}

		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{	 
				if(cmb_Factory.SelectedIndex == -1) return;  
			
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;

				DataTable dt_ret;

				//process setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Process, 1, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 
				cmb_Process.SelectedValue = (ClassLib.ComVar.Parameter_PopUp_Object[4] == null ? "" : ClassLib.ComVar.Parameter_PopUp_Object[4]);

				//line setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  
				cmb_Line.SelectedValue = (ClassLib.ComVar.Parameter_PopUp_Object[5] == null ? "" : ClassLib.ComVar.Parameter_PopUp_Object[5]);
  
				dt_ret.Dispose();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}

		private void dpick_FromDate_CloseUp(object sender, System.EventArgs e)
		{
			dpick_ToDate.Value = dpick_FromDate.Value;
		}

		#endregion


		#region 이벤트 처리

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // Form Setting

			lbl_MainTitle.Text = "Outgoing Production Print by DPO";
            this.Text = "Outgoing Production Print by DPO";
            ClassLib.ComFunction.SetLangDic(this);
 

			// Grid Setting
			fgrid_main.Set_Grid("SBO_OUTGOING_PRODUCTION_PRINT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
 

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false);
			vDt.Dispose();
			cmb_Factory.SelectedValue = (ClassLib.ComVar.Parameter_PopUp_Object[0] == null ? ClassLib.ComVar.This_Factory : ClassLib.ComVar.Parameter_PopUp_Object[0]);

			// Process Outgoing division set    cmb_outDiv
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_OutDiv, 1, 2, false, 56, 0);
			cmb_OutDiv.SelectedValue = (ClassLib.ComVar.Parameter_PopUp_Object[1] == null ? "" : ClassLib.ComVar.Parameter_PopUp_Object[1]);

			dpick_FromDate.Value = (DateTime)ClassLib.ComVar.Parameter_PopUp_Object[2];
			dpick_FromDate.Value = (DateTime)ClassLib.ComVar.Parameter_PopUp_Object[3];


			// 초기 버튼 권한 설정 : 조회만을 위함
			tbtn_Save.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;
			fgrid_main.AllowEditing = false; 

			BindData();
		}

		private void BindData()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string factory = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
				string division = ClassLib.ComFunction.Empty_Combo(cmb_OutDiv, "");
				string date_from = dpick_FromDate.Text.Replace("-", "");
				string date_to = dpick_ToDate.Text.Replace("-", "");
				string process = ClassLib.ComFunction.Empty_Combo(cmb_Process, "");
				string line = ClassLib.ComFunction.Empty_Combo(cmb_Line, "");

				if (SELECT_SBO_OUTGOING_PRINT_HEAD(factory, division, date_from, date_to, process, line))
				{
					DataSet vDs = SELECT_SBO_OUTGOING_PRINT_DATA(factory, division, date_from, date_to, process, line);

					Display_CrossTab_Head(vDs.Tables[0], COL_WIDTH, COL_START);
					Display_CrossTab_Data(vDs.Tables[1], COL_KEY_FROM, COL_KEY_TO, COL_HEAD, COL_DISPLAY, COL_DISPLAY, false);
					Display_CrossTab_Calc();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void PrintData()
		{
			this.Cursor = Cursors.WaitCursor;

			Excel.Application oXL = null;
			Excel._Workbook oWB = null;
			Excel._Worksheet oSheet = null;

			try
			{
				Thread thread = new Thread(new ThreadStart(_waitPop.Start));
				thread.Start();
				
				this.Cursor = Cursors.WaitCursor;

				//Start Excel and get Application object.
				oXL = new Excel.Application();
				
				oXL.Visible = false;
				oXL.UserControl = false;

				//Get a new workbook.
				oWB = (Excel._Workbook)(oXL.Workbooks.Add(true));
				oSheet = (Excel._Worksheet)oWB.ActiveSheet;

				// data
				for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
				{
					if (fgrid_main.Rows[vRow].Node.Level == 1)
					{
						int vStartRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
						int vEndRow = fgrid_main.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
						string style = fgrid_main[vRow, 4].ToString();

						object[,] values = new object[fgrid_main.Rows.Count + 2, fgrid_main.Cols.Count];

						for (int vCol = 1, cIdx = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
						{
							if (fgrid_main.Cols[vCol].Visible)
							{
								values[0, cIdx] = fgrid_main[1, vCol];
								values[1, cIdx] = fgrid_main[2, vCol];
								cIdx++;
							}
						}

						for (int vTempRow = vRow, rIdx = 2 ; vTempRow <= vEndRow ; vTempRow++, rIdx++)
						{
							for (int vCol = 1, cIdx = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
							{
								if (fgrid_main.Cols[vCol].Visible)
								{
									values[rIdx, cIdx] = fgrid_main[vTempRow, vCol];
									cIdx++;
								}
							}
						}
						
						vRow = vEndRow;
						Excel._Worksheet newSheet = (Excel._Worksheet)oWB.Sheets.Add(Type.Missing, Type.Missing, 1, Type.Missing);
						newSheet.Name = style;
						newSheet.get_Range(newSheet.Cells[1, 1], newSheet.Cells[fgrid_main.Rows.Count + 2, fgrid_main.Cols.Count]).NumberFormat = "@";
						newSheet.get_Range(newSheet.Cells[1, 1], newSheet.Cells[fgrid_main.Rows.Count + 2, fgrid_main.Cols.Count]).Value2 = values;
					}
				}

				oSheet.Delete();

				oXL.Visible = true;
				oXL.UserControl = true;
			}
			catch(Exception ex)
			{
				if (oXL != null) oXL.Quit();
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				
				oWB = null;
				oXL = null;
				
				GC.Collect();
				_waitPop.Hide();
			}
		}


		private int Display_CrossTab_Head(DataTable dt_col, int arg_width, int arg_startcol)
		{
			try 
			{									
				fgrid_main.Cols.Count  =  arg_startcol ;
				fgrid_main.Cols.Count =  fgrid_main.Cols.Count + dt_col.Rows.Count ;				

				for(int i = 0; i < dt_col.Rows.Count; i++)
				{
					string str_date = dt_col.Rows[i].ItemArray[0].ToString();
					str_date = str_date.Substring(4, 4);
					str_date = str_date.Substring(0, 2) + "-" + str_date.Substring(2, 2);

					fgrid_main[0,arg_startcol+i] = "OUT_DATE";
					fgrid_main[1,arg_startcol+i] = str_date;

					fgrid_main.Cols[arg_startcol+i].Width = arg_width ;
					_columnIndex.Add(dt_col.Rows[i].ItemArray[0].ToString());
				}

				// 추가 필드
				Column newCol = fgrid_main.Cols.Add();
				newCol[0] = "DAY_TOTAL";
				newCol[1] = "Day Total";

				newCol = fgrid_main.Cols.Add();
				newCol[0] = "BALANCE";
				newCol[1] = "Balance";
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_CrossTab_Head",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}

			return 0;
		}

		private void Display_CrossTab_Data(DataTable arg_dt, int arg_key_fr, int arg_key_to, int arg_colhead, int arg_display, int arg_userdata, bool arg_tree)
		{
			try
			{
				int styleCol = 3, styleRow = fgrid_main.Rows.Fixed;
				int itemCol = 5;
				int lotTotCol = 14;

				string str_newStyle = "", str_oldStyle = "";
				string str_newkey = "", str_oldkey = "" ;
			
				//ROW 초기화
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed ; 
				fgrid_main.Tree.Column = itemCol + 1;

				//loop - DATA row
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					str_newStyle = arg_dt.Rows[i].ItemArray[styleCol].ToString();
					str_newkey = "" ;
					
					//key field 생성
					for(int k = arg_key_fr; k <= arg_key_to; k++)
					{
						str_newkey = str_newkey + arg_dt.Rows[i].ItemArray[k].ToString() ;
					}
															
					//loop -DATA column(마지막ROW는 제외)
					for(int j = 0; j <= arg_colhead; j++)
					{							
						if(j <= arg_colhead)
						{
							//key field가 변경시 새로운 row 생성
							if(!str_newStyle.Equals(str_oldStyle) && j == 0)
							{
								styleRow = fgrid_main.AddItem("",fgrid_main.Rows.Count).Index;
								fgrid_main.Rows[styleRow].IsNode = true;
								fgrid_main.Rows[styleRow].Node.Level = 1;
							}
							
							if(!str_newkey.Equals(str_oldkey) && j == 0)
							{
								int itemRow = fgrid_main.AddItem("",fgrid_main.Rows.Count).Index;
								fgrid_main.Rows[itemRow].IsNode = true;
								fgrid_main.Rows[itemRow].Node.Level = 2;
							}

							
							// set division column
							fgrid_main[fgrid_main.Rows.Count-1, 0] = "";

							//칼럼이 크로스탭 항목일때
							if(j == arg_colhead)
							{
								//칼럼헤드의 위치를 조회하여 데이타 디스플레이
								if(_columnIndex.Contains(arg_dt.Rows[i].ItemArray[arg_colhead].ToString()))
								{
									int col = arg_colhead + _columnIndex.IndexOf(arg_dt.Rows[i].ItemArray[arg_colhead].ToString()) + 1;

									fgrid_main[styleRow, col] = arg_dt.Rows[i].ItemArray[lotTotCol];
									fgrid_main[fgrid_main.Rows.Count-1, col] = arg_dt.Rows[i].ItemArray[arg_display];
								}
							}
							else
							{
								if (j == itemCol)
									fgrid_main[styleRow, j+1] = arg_dt.Rows[i].ItemArray[styleCol].ToString() + " : " + arg_dt.Rows[i].ItemArray[styleCol + 1].ToString();
								else
									fgrid_main[styleRow, j+1] = arg_dt.Rows[i].ItemArray[j];

								fgrid_main[fgrid_main.Rows.Count-1, j+1] = arg_dt.Rows[i].ItemArray[j];
							}
						}
					}

					str_oldStyle = str_newStyle;
					str_oldkey = str_newkey;										
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_FlexGrid_Tree",MessageBoxButtons.OK,MessageBoxIcon.Error );
			}
		}

		private void Display_CrossTab_Calc()
		{
			int styleRow = fgrid_main.Rows.Fixed;
			int itemCol = 6, yieldCol = 10, lotTotCol = 11;

			for (int row = fgrid_main.Rows.Fixed ; row < fgrid_main.Rows.Count ; row++)
			{
				if (fgrid_main.Rows[row].Node.Level == 1)
				{
					styleRow = fgrid_main.Rows[row].Node.Row.Index;
					fgrid_main.GetCellRange(row, itemCol + 1, row, itemCol + 4).Clear(C1.Win.C1FlexGrid.ClearFlags.Content);
					fgrid_main.Rows[row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;

					int endRow = fgrid_main.Rows[row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					fgrid_main.GetCellRange(row + 1, fgrid_main.Cols.Frozen, endRow, fgrid_main.Cols.Count - 3).StyleNew.BackColor = Color.LightYellow;

					endRow = fgrid_main.Rows[row].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;
					fgrid_main.GetCellRange(row + 1, fgrid_main.Cols.Count - 2, endRow, fgrid_main.Cols.Count - 1).StyleNew.BackColor = ClassLib.ComVar.Clr_Head_RYellow;
				}
				else
				{
					fgrid_main[row, lotTotCol] = (int)Math.Round(blankToZero(fgrid_main[styleRow, lotTotCol]) * blankToZero(fgrid_main[row, yieldCol]), 1);
					fgrid_main.Rows[row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_3rd;
				}

				double orderTot = 0;
				for (int col = lotTotCol + 1 ; col < fgrid_main.Cols.Count ; col++)
				{
					orderTot += blankToZero(fgrid_main[row, col]);
				}

				fgrid_main[row, fgrid_main.Cols.Count - 1] = blankToZero(fgrid_main[row, lotTotCol]) - orderTot;
				fgrid_main[row, fgrid_main.Cols.Count - 2] = orderTot;
			}
		}

		private double blankToZero(object arg_obj)
		{
			if (arg_obj != null)
			{
				if (arg_obj.ToString().Equals(""))
					return 0;
				else
					return Convert.ToDouble(arg_obj.ToString());
			}

			return 0;
		}

		#endregion


		#region 데이터베이스

		/// <summary>
		/// SELECT_SBO_OUTGOING_PRINT_HEAD
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private bool SELECT_SBO_OUTGOING_PRINT_HEAD (
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line)
		{

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SELECT_SBO_OUTGOING_PRINT_HEAD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[6] = "ARG_YMD_TYPE";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_division;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_process;
			MyOraDB.Parameter_Values[5] = arg_line;
			MyOraDB.Parameter_Values[6] = rad_out_ymd.Checked ? "O" : "R";
			MyOraDB.Parameter_Values[7] = "";  

			MyOraDB.Add_Select_Parameter(true);
			return true;
		}

		/// <summary>
		/// SELECT_SBO_OUTGOING_PRINT_DATA
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private DataSet SELECT_SBO_OUTGOING_PRINT_DATA (
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line)
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_EXPEND.SELECT_SBO_OUTGOING_PRINT_DPO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
			MyOraDB.Parameter_Name[6] = "ARG_YMD_TYPE";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";  

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor; 

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_division;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_process;
			MyOraDB.Parameter_Values[5] = arg_line;
			MyOraDB.Parameter_Values[6] = rad_out_ymd.Checked ? "O" : "R";
			MyOraDB.Parameter_Values[7] = "";  

			MyOraDB.Add_Select_Parameter(false);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret;
		}

		#endregion

	}
}

