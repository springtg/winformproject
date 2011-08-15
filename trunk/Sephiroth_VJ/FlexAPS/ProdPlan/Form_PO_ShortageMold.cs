using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Form_PO_ShortageMold : COM.APSWinForm.Form_Top
	{
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.DateTimePicker dpick_Stop;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_Start;
		private System.Windows.Forms.Label lbl_plan_ymd;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_PopPgId;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_shortM;

		#region ����

		private COM.OraDB oraDB = null;
		private int _IxGen_Value, _IxStart_Size, _IxTotal;
		private int _Ix_gen_s = 1;
		private int _Ix_gen_e = 6;
		private int _Ix_size_s = 6;
		private int _Ix_size_e = 0;
		private int col_width = 40;
		public COM.FSP fgrid_style;
		private System.Windows.Forms.Label lbl_check;
		private System.Windows.Forms.CheckBox chk_short;
		private int gen_width = 25;

		#endregion

		public Form_PO_ShortageMold()
		{
			// �� ȣ���� Windows Form �����̳ʿ� �ʿ��մϴ�.
			InitializeComponent();

			// TODO: InitializeComponent�� ȣ���� ���� �ʱ�ȭ �۾��� �߰��մϴ�.
		}

		/// <summary>
		/// ��� ���� ��� ���ҽ��� �����մϴ�.
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

		#region �����̳ʿ��� ������ �ڵ�
		/// <summary>
		/// �����̳� ������ �ʿ��� �޼����Դϴ�.
		/// �� �޼����� ������ �ڵ� ������� �������� ���ʽÿ�.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_ShortageMold));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.chk_short = new System.Windows.Forms.CheckBox();
			this.lbl_check = new System.Windows.Forms.Label();
			this.dpick_Stop = new System.Windows.Forms.DateTimePicker();
			this.lblexcep_mark = new System.Windows.Forms.Label();
			this.dpick_Start = new System.Windows.Forms.DateTimePicker();
			this.lbl_plan_ymd = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.fgrid_shortM = new COM.FSP();
			this.fgrid_style = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_shortM)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_style)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Menu
			// 
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.chk_short);
			this.pnl_Search.Controls.Add(this.lbl_check);
			this.pnl_Search.Controls.Add(this.dpick_Stop);
			this.pnl_Search.Controls.Add(this.lblexcep_mark);
			this.pnl_Search.Controls.Add(this.dpick_Start);
			this.pnl_Search.Controls.Add(this.lbl_plan_ymd);
			this.pnl_Search.Controls.Add(this.lbl_Factory);
			this.pnl_Search.Controls.Add(this.cmb_Factory);
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.Bottom = 5;
			this.pnl_Search.DockPadding.Left = 10;
			this.pnl_Search.DockPadding.Right = 10;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Search.TabIndex = 44;
			// 
			// chk_short
			// 
			this.chk_short.Checked = true;
			this.chk_short.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chk_short.Location = new System.Drawing.Point(781, 36);
			this.chk_short.Name = "chk_short";
			this.chk_short.Size = new System.Drawing.Size(21, 21);
			this.chk_short.TabIndex = 82;
			// 
			// lbl_check
			// 
			this.lbl_check.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_check.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_check.ImageIndex = 0;
			this.lbl_check.ImageList = this.img_Label;
			this.lbl_check.Location = new System.Drawing.Point(680, 36);
			this.lbl_check.Name = "lbl_check";
			this.lbl_check.Size = new System.Drawing.Size(100, 21);
			this.lbl_check.TabIndex = 81;
			this.lbl_check.Text = "Only Shortage";
			this.lbl_check.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Stop
			// 
			this.dpick_Stop.CustomFormat = "";
			this.dpick_Stop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Stop.Location = new System.Drawing.Point(539, 35);
			this.dpick_Stop.Name = "dpick_Stop";
			this.dpick_Stop.Size = new System.Drawing.Size(120, 22);
			this.dpick_Stop.TabIndex = 80;
			// 
			// lblexcep_mark
			// 
			this.lblexcep_mark.Location = new System.Drawing.Point(517, 35);
			this.lblexcep_mark.Name = "lblexcep_mark";
			this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblexcep_mark.Size = new System.Drawing.Size(22, 22);
			this.lblexcep_mark.TabIndex = 79;
			this.lblexcep_mark.Text = "~";
			this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dpick_Start
			// 
			this.dpick_Start.CustomFormat = "";
			this.dpick_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Start.Location = new System.Drawing.Point(397, 35);
			this.dpick_Start.Name = "dpick_Start";
			this.dpick_Start.Size = new System.Drawing.Size(120, 22);
			this.dpick_Start.TabIndex = 78;
			// 
			// lbl_plan_ymd
			// 
			this.lbl_plan_ymd.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_plan_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_plan_ymd.ImageIndex = 0;
			this.lbl_plan_ymd.ImageList = this.img_Label;
			this.lbl_plan_ymd.Location = new System.Drawing.Point(296, 36);
			this.lbl_plan_ymd.Name = "lbl_plan_ymd";
			this.lbl_plan_ymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_plan_ymd.TabIndex = 36;
			this.lbl_plan_ymd.Text = "Plan ymd";
			this.lbl_plan_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(18, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 35;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory.Caption = "";
			this.cmb_Factory.CaptionHeight = 17;
			this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory.ColumnCaptionHeight = 18;
			this.cmb_Factory.ColumnFooterHeight = 18;
			this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory.ContentHeight = 17;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Enabled = false;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(119, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(150, 21);
			this.cmb_Factory.TabIndex = 34;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(10, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(996, 67);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.Location = new System.Drawing.Point(412, 36);
			this.btn_PopPgId.Name = "btn_PopPgId";
			this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
			this.btn_PopPgId.TabIndex = 34;
			this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(981, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 27);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(980, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 32);
			this.picb_TR.TabIndex = 21;
			this.picb_TR.TabStop = false;
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(224, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(772, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Select Plan YMD";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(980, 51);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 49);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(836, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 47);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 27);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(160, 24);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(828, 27);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// fgrid_shortM
			// 
			this.fgrid_shortM.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_shortM.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_shortM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_shortM.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_shortM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_shortM.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_shortM.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_shortM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_shortM.Location = new System.Drawing.Point(10, 136);
			this.fgrid_shortM.Name = "fgrid_shortM";
			this.fgrid_shortM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_shortM.Size = new System.Drawing.Size(996, 384);
			this.fgrid_shortM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_shortM.TabIndex = 47;
			this.fgrid_shortM.Click += new System.EventHandler(this.fgrid_shortM_Click);
			this.fgrid_shortM.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_shortM_AfterScroll);
			this.fgrid_shortM.DoubleClick += new System.EventHandler(this.fgrid_shortM_DoubleClick);
			// 
			// fgrid_style
			// 
			this.fgrid_style.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
			this.fgrid_style.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_style.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_style.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_style.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_style.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_style.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_style.Location = new System.Drawing.Point(10, 528);
			this.fgrid_style.Name = "fgrid_style";
			this.fgrid_style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_style.Size = new System.Drawing.Size(996, 112);
			this.fgrid_style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 6.75pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_style.TabIndex = 48;
			this.fgrid_style.Click += new System.EventHandler(this.fgrid_style_Click);
			this.fgrid_style.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_shortM_AfterScroll);
			// 
			// Form_PO_ShortageMold
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_style);
			this.Controls.Add(this.fgrid_shortM);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PO_ShortageMold";
			this.Text = "Shortage Mold";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_PO_ShortageMold_Closing);
			this.Load += new System.EventHandler(this.Form_PO_ShortageMold_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.fgrid_shortM, 0);
			this.Controls.SetChildIndex(this.fgrid_style, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_shortM)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_style)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region �޼ҵ�

		private void Init_Form()
		{
			this.Text = "Shortage Mold In Line";
			this.lbl_MainTitle.Text = "Shortage Mold In Line";
			ClassLib.ComFunction.SetLangDic(this);
			

			#region ��ư ����

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion


			tbtn_Append.Enabled = false;
			tbtn_Color.Enabled = false;
			tbtn_Create.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Print.Enabled = false;
			tbtn_Save.Enabled = false;

			oraDB = new COM.OraDB();

			//Fastroy ComboBox Setting
			DataTable dt_list = ClassLib.ComFunction.Select_Factory_List(); 
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1,false,COM.ComVar.ComboList_Visible.Code);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;


			COM.ComFunction cfun = new COM.ComFunction();
			dpick_Start.Text = cfun.ConvertDate2Type(Select_NextWorkDay(cmb_Factory.SelectedValue.ToString()).Rows[0].ItemArray[2].ToString());//Select_NextWorkDay().Rows[0].ItemArray[2].ToString();//
			dpick_Stop.Value  = DateTime.Now.Add(System.TimeSpan.FromDays(+7));

			dpick_Start.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_Stop.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			


			//���� ������ �׸���
			fgrid_shortM.Set_Grid("SPO_MOLD_CAPA", "7", 1, ClassLib.ComVar.This_Lang, false);
			Set_Gender_Grid(fgrid_shortM);
			fgrid_shortM.Cols.Frozen = 6;


			fgrid_style.Set_Grid("SPO_MOLD_CAPA", "8", 1, ClassLib.ComVar.This_Lang, false);
			Set_Gender_Grid(fgrid_style);


			if(COM.ComVar.ShortMold_From_Date.Trim().Length > 0 && COM.ComVar.ShortMold_To_Date.Trim().Length > 0)
			{
				dpick_Start.Text = cfun.ConvertDate2Type(COM.ComVar.ShortMold_From_Date.Trim());
				dpick_Stop.Text = cfun.ConvertDate2Type(COM.ComVar.ShortMold_To_Date.Trim());
				tbtn_Search_Click(null,null);
			}

			ClassLib.ComFunction.Get_Values(this, dpick_Start.Name, dpick_Stop.Name);
		}


		/// <summary>
		/// Set_Gender_Grid : 
		/// </summary>
		/// <param name="arg_fgrid"></param>
		private void Set_Gender_Grid(C1FlexGrid arg_fgrid)
		{
			
			DataTable dt_list;
			DataTable dt_size_list;

			arg_fgrid.Cols.Frozen = 5; 

			string[] new_data = new string[arg_fgrid.Cols.Count]; 
			
			int size_count = 0;

			

			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGen);  

			
			//------------------------------------------------
			new_data[0] = ""; 

			for(int i = 1; i < arg_fgrid.Cols.Count; i++)
			{
				new_data[i] = arg_fgrid[1, i].ToString();
			}

			//------------------------------------------------
			for(int i = 0; i < dt_list.Rows.Count - 1; i++)
			{ 
				arg_fgrid.AddItem(new_data, arg_fgrid.Rows.Count, 0);  
			}


			arg_fgrid.Rows.Fixed = dt_list.Rows.Count + 1;

 			

			//------------------------------------------------
			//���� �Է�

			_IxGen_Value = (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_CS_SIZE;

			arg_fgrid.Cols.Insert(_IxGen_Value);

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{				arg_fgrid[i + 1, _IxGen_Value] = dt_list.Rows[i].ItemArray[3].ToString();

				//------------------------------------------------------------------
				
//				if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME" 
//					|| arg_fgrid[i + 1, _IxGen_Value].ToString() == "WO") continue;
//
//				arg_fgrid.Rows[i + 1].Visible = false;
//
				if(arg_fgrid.Name == "fgrid_style")
				{
					if(arg_fgrid[i + 1, _IxGen_Value].ToString() == "ME") continue;
					arg_fgrid.Rows[i + 1].Visible = false;
				}
 
				//------------------------------------------------------------------


			}


			//------------------------------------------------
			//������ ���� ǥ��
			
			_IxStart_Size = _IxGen_Value + 1;

			for(int i = 0; i < dt_list.Rows.Count; i++)
			{
				dt_size_list = Select_Gen_Size(dt_list.Rows[i].ItemArray[3].ToString());

				size_count = dt_size_list.Rows.Count + _IxStart_Size;

				if(size_count > arg_fgrid.Cols.Count)
				{
					arg_fgrid.Cols.Count = size_count;
				}
 
				for(int j = 0; j < dt_size_list.Rows.Count; j++)
				{
					arg_fgrid[i + 1, _IxStart_Size + j] = dt_size_list.Rows[j].ItemArray[0];
				}
			}

			//------------------------------------------------
			//total ǥ��
			_IxTotal = arg_fgrid.Cols.Count;

			arg_fgrid.Cols.Add();

			for(int i = 0; i < arg_fgrid.Rows.Count; i++)
			{
				arg_fgrid[i, _IxTotal] = "Total"; 
				arg_fgrid.Rows[i].TextAlign = TextAlignEnum.CenterCenter; 
			}

			//------------------------------------------------
		 
			for(int i = _IxGen_Value; i < arg_fgrid.Cols.Count; i++)
			{
				

				arg_fgrid.Cols[i].Width = col_width; 
				
				if(i == _IxGen_Value)
				{
					arg_fgrid.Cols[i].Width = gen_width; 
				} 

				for(int j = 1; j < arg_fgrid.Rows.Fixed; j++)
				{
					if(arg_fgrid[j, i] == null) arg_fgrid[j, i] = "x";
				}
			}
 
			 
 
			arg_fgrid.AllowMerging = AllowMergingEnum.FixedOnly;

			for(int i = 1; i <= _IxGen_Value; i++)
			{
				arg_fgrid.Cols[i].AllowMerging = true;
			}

			arg_fgrid.Cols[_IxTotal].AllowMerging = true;
		}


		private void Set_Grid()
		{
			fgrid_shortM.Rows.Count = _Ix_gen_e;

			_Ix_size_e = fgrid_shortM.Cols.Count-1;

			DataTable dt;

			if(chk_short.Checked)
			{
				dt = Select_Shortage_Mold();
			}
			else
			{
				dt = Select_Shortage_Mold1();
			}

			int row_count = dt.Rows.Count;

			string new_data = "";
			string old_data = "";
			string new_plan_ymd = "";
			string old_plan_ymd = "";

			for(int i=0; i<dt.Rows.Count; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxFACTORY].ToString()
					 + dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxPLAN_YMD].ToString()
					 + dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_LINE_CD].ToString()
					 + dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_CD].ToString();

				new_plan_ymd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxPLAN_YMD].ToString();
				
				int insert_row = fgrid_shortM.Rows.Count;


				if(old_plan_ymd != new_plan_ymd)
				{
					fgrid_shortM.Rows.Add();
					fgrid_shortM.Rows[fgrid_shortM.Rows.Count-1].StyleNew.BackColor = Color.FromArgb(94, 154, 227);
					fgrid_shortM.Rows[fgrid_shortM.Rows.Count-1].Height = 2;

					old_plan_ymd = new_plan_ymd;

					insert_row = fgrid_shortM.Rows.Count;

				}
				
				
			
			
				string gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_GEN].ToString();
				string size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxCS_SIZE].ToString();
				string req_mold = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxREQ_MOLD].ToString();

				if(new_data != old_data)
				{
					fgrid_shortM.Rows.Add();

				

					fgrid_shortM[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_PLAN_YMD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxPLAN_YMD].ToString();
					fgrid_shortM[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_LINE_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxLINE_CD].ToString();
					fgrid_shortM[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_TYPE] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_TYPE].ToString();
					fgrid_shortM[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_CD] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_CD].ToString();
					fgrid_shortM[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN] = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_GEN].ToString();

					old_data = new_data;
					Req_Mold_Qty(insert_row, gen, size, req_mold);
				}
				else
				{
					insert_row = fgrid_shortM.Rows.Count-1;
					Req_Mold_Qty(insert_row, gen, size, req_mold);
				}
			}




			fgrid_shortM.AllowMerging = AllowMergingEnum.Free;

			fgrid_shortM.Cols[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN].AllowMerging = false;
		}

		private void Set_Grid_Style(string arg_plan_ymd, string arg_mold_cd)
		{
			_Ix_size_e = fgrid_style.Cols.Count-2;
			_IxTotal = fgrid_style.Cols.Count-1;

			fgrid_style.Rows.Count = _Ix_gen_e;

			DataTable dt = Select_Style_info(arg_plan_ymd, arg_mold_cd);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			string old_data = "";
			string new_data = "";

			int insert_row;


			string plan_ymd, line, style_cd, gen, size, qty;

			for(int i=0; i<rowcount; i++)
			{
				new_data = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_PLAN_YMD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_LINE_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_STYLE_CD].ToString()
					+ dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_GEN].ToString();


				plan_ymd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_PLAN_YMD].ToString();
				line = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_LINE_CD].ToString();
				style_cd = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_STYLE_CD].ToString();
				gen = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_GEN].ToString();
				size = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_CS_SIZE].ToString();
				qty = dt.Rows[i].ItemArray[(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxSTY_SIZE_QTY].ToString();




				if(old_data != new_data)
				{
					fgrid_style.Rows.Add();

					insert_row = fgrid_style.Rows.Count-1;

					fgrid_style[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_PLAN_YMD] = plan_ymd;
					fgrid_style[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_LINE_CD] = line;
					fgrid_style[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_TYPE] = style_cd;
					fgrid_style[insert_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_CD] = gen;

					old_data = new_data;

					Order_Qty(insert_row, gen, size, qty);

				}
				else
				{
					insert_row = fgrid_style.Rows.Count-1;
					Order_Qty(insert_row, gen, size, qty);
				}
			}
		}


		private void Req_Mold_Qty(int arg_row_num, string arg_gen, string arg_size, string arg_req_mold)
		{

			System.Drawing.Color font_color = Color.Black; 

			int j;

			for(j=_Ix_gen_s; j<_Ix_gen_e; j++)
			{
				if(fgrid_shortM[j,(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN].ToString() == arg_gen)
				{
					for(int k=_Ix_size_s; k<_Ix_size_e; k++)
					{
						if(fgrid_shortM[j,k].ToString() == arg_size)
						{
							fgrid_shortM[arg_row_num,k] = arg_req_mold;

							if(int.Parse(arg_req_mold) >= 0)
								font_color = Color.Blue;
							else
								font_color = Color.Red;


							fgrid_shortM.GetCellRange(arg_row_num,k).StyleNew.ForeColor =  font_color;
							fgrid_shortM.GetCellRange(arg_row_num,k).StyleNew.ForeColor =  font_color;
						}
					}
				}
			}
		}


		private void Order_Qty(int arg_row_num, string arg_gen, string arg_size, string arg_qty)
		{
			int j;

			for(j=_Ix_gen_s; j<_Ix_gen_e; j++)
			{
				if(fgrid_style[j,(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN].ToString() == arg_gen)
				{
					for(int k=_Ix_size_s; k<_Ix_size_e; k++)
					{
						if(fgrid_style[j,k].ToString() == arg_size)
						{
							fgrid_style[arg_row_num,k] = arg_qty;
						}
					}
				}
			}
		}



		/// <summary>
		/// Total_Shortage_Mold : �Ϻ�, ���κ� ���� ���� �հ�
		/// </summary>
		private void Total_Shortage_Mold()
		{
			_Ix_size_e = fgrid_shortM.Cols.Count-2;
			_IxTotal   = fgrid_shortM.Cols.Count-1;

			int total_Mold;

			for(int i=_Ix_gen_e; i<fgrid_shortM.Rows.Count; i++)
			{
				if(fgrid_shortM[i,(int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN] != null)
				{
					total_Mold = 0;
					for(int j=_Ix_size_s; j<_Ix_size_e; j++)
					{
						if(fgrid_shortM[i,j] != null)
						{
							total_Mold += int.Parse(fgrid_shortM[i,j].ToString());
						}
						
						fgrid_shortM[i, _IxTotal] = total_Mold.ToString();
					}
				}
			}
		}


		private void Set_Grid_Style_Sum()
		{
			if(fgrid_style.Rows.Count <= _Ix_gen_e) return;


			_Ix_size_e = fgrid_style.Cols.Count-1;
			_IxTotal = fgrid_style.Cols.Count-1;

			int sum_style_qty;

			for(int i=_Ix_gen_e; i<fgrid_style.Rows.Count; i++)
			{
				sum_style_qty = 0;
				for(int j=_Ix_size_s; j<_Ix_size_e; j++)
				{
					if(fgrid_style[i, j] != null)
					{
						sum_style_qty += int.Parse(fgrid_style[i, j].ToString());
					}
				}

				fgrid_style[i, _IxTotal] = sum_style_qty.ToString();
			}
		}

		private void Set_Grid_Style_Size_Sum()
		{
			fgrid_style.Rows.Add();

			_Ix_size_e = fgrid_style.Cols.Count-1;
			int row_num = fgrid_style.Rows.Count-1;

			int sum_size;

			for(int i=_Ix_size_s; i<_Ix_size_e; i++)
			{
				sum_size = 0;
				for(int j=_Ix_gen_e; j<row_num; j++)
				{
					if(fgrid_style[j, i] != null)
					{
						sum_size += int.Parse(fgrid_style[j, i].ToString());
					}
				}

				fgrid_style[row_num, i] = sum_size;
			}


			//fgrid_style[row_num, (int)ClassLib.TBSPO_SHORTAGE_MOLD.
		}

		#endregion

		#region �̺�Ʈ

		private void Form_PO_ShortageMold_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}


		/// <summary>
		/// ��ġ ��ư Ŭ�� �� �߻�.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Set_Grid();
			Total_Shortage_Mold();
		}


		private void fgrid_shortM_DoubleClick(object sender, System.EventArgs e)
		{
			int select_row = fgrid_shortM.Selection.r1;
			int select_col = fgrid_shortM.Selection.c1;

			if(select_row > _Ix_gen_e)
			{
				string plan_ymd = fgrid_shortM[select_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_PLAN_YMD].ToString();
				string mold_cd  = fgrid_shortM[select_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_CD].ToString();
				Set_Grid_Style(plan_ymd, mold_cd);
				Set_Grid_Style_Size_Sum();
				Set_Grid_Style_Sum();
				
			}
		}


		private void fgrid_shortM_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_shortM.Selection.r1;
			int sct_col = fgrid_shortM.Selection.c1;

			try
			{
				int row_num = 0;

				string sct_gen = fgrid_shortM[sct_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_GEN].ToString();

				for(int i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					fgrid_shortM.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.BackColor = COM.ComVar.GridLightFixed_Color;
					fgrid_shortM.GetCellRange(i,_Ix_size_s,i,_Ix_size_e).StyleNew.ForeColor = Color.White;

					if(fgrid_shortM[i, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxMOLD_GEN].ToString() == sct_gen)
					{
						row_num = i;
					}
				}

				fgrid_shortM.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.BackColor = Color.FromArgb(251, 248, 185);//COM.ComVar.GridDarkFixed_Color;
				fgrid_shortM.GetCellRange(row_num,_Ix_size_s,row_num,_Ix_size_e).StyleNew.ForeColor = Color.Black;
			}
			catch
			{
			}


			 fgrid_shortM_DoubleClick(null, null);
		}


		private void fgrid_style_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Ix_size_e = 15;//fgrid_style.Cols.Count;

				int sct_row = fgrid_style.Selection.r1;
				int sct_col = fgrid_style.Selection.c1;

				int row_num = 0;

				string sct_gen = fgrid_style[sct_row, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_CD].ToString();

				int i;
				for(i=_Ix_gen_s; i<_Ix_gen_e; i++)
				{
					if(fgrid_style[i, (int)ClassLib.TBSPO_SHORTAGE_MOLD.IxGR_MOLD_GEN].ToString() == sct_gen)
					{
						row_num = i;
						fgrid_style.Rows[i].Visible = true;
					}
					else
					{
						fgrid_style.Rows[i].Visible = false;
					}
				}
			}
			catch
			{
			}
		}


		#region ��ũ�� ����ȭ �۾�

		// synchronize grid scrolling
		bool _synchronizing = false;

		private void fgrid_shortM_AfterScroll(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			if (!_synchronizing)
			{
				// avoid reentrant calls
				_synchronizing = true;

				// get new scrollposition for sender control
				C1FlexGrid src = sender as C1FlexGrid;
				src.Update();
				Point pt = src.ScrollPosition;

				// apply to others
				if (src.Equals(this.fgrid_shortM))
				{ 
					fgrid_style.ScrollPosition = new Point(pt.X, fgrid_style.ScrollPosition.Y);
				}
				 
				else if (src.Equals(this.fgrid_style))
				{
					fgrid_shortM.ScrollPosition = new Point(pt.X, fgrid_shortM.ScrollPosition.Y); 
					fgrid_shortM.ScrollPosition = new Point(pt.X, fgrid_shortM.ScrollPosition.Y); 
				}
				 

				// done
				_synchronizing = false;

			} // end if
		}


		#endregion

		#endregion

		#region DB ����

		/// <summary>
		/// Select_Gen_Size : 
		/// </summary>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		private DataTable Select_Gen_Size(string arg_gen)
		{
			string Proc_Name = "PKG_SPO_ORDER_MOLD.SELECT_MOLD_SIZE1";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_GEN";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_gen;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Shortage_Mold()
		{
			COM.ComFunction cfun = new COM.ComFunction();
			string Proc_Name = "PKG_SPO_SHORTAGEMOLD.SELECT_SHORTMOLD";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROMDATE";
			oraDB.Parameter_Name[2] = "ARG_TODATE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cfun.ConvertDate2DbType(dpick_Start.Text);
			oraDB.Parameter_Values[2] = cfun.ConvertDate2DbType(dpick_Stop.Text);
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		private DataTable Select_Shortage_Mold1()
		{
			COM.ComFunction cfun = new COM.ComFunction();
			string Proc_Name = "PKG_SPO_SHORTAGEMOLD.SELECT_SHORTMOLD_1";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_FROMDATE";
			oraDB.Parameter_Name[2] = "ARG_TODATE";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cfun.ConvertDate2DbType(dpick_Start.Text);
			oraDB.Parameter_Values[2] = cfun.ConvertDate2DbType(dpick_Stop.Text);
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}



		private DataTable Select_Style_info(string arg_plan_ymd, string arg_mold_cd)
		{
			string Proc_Name = "PKG_SPO_SHORTAGEMOLD.SELECT_STYLE_INFO";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
			oraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = arg_plan_ymd;
			oraDB.Parameter_Values[2] = arg_mold_cd;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		public DataTable Select_NextWorkDay(string arg_factory)
		{
			COM.OraDB MyoraDB = new COM.OraDB();
			string Proc_Name = "PKG_SPD_WORKSHEET_BSC.SELECT_NEXTWORKDAY";

			MyoraDB.ReDim_Parameter(2);
			MyoraDB.Process_Name = Proc_Name ;


			MyoraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyoraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyoraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyoraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyoraDB.Parameter_Values[0] = arg_factory;
			MyoraDB.Parameter_Values[1] = "";

			MyoraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyoraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion

		private void Form_PO_ShortageMold_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ClassLib.ComFunction.Set_Values(this, dpick_Start.Name,dpick_Stop.Name);
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

		
	}
}
