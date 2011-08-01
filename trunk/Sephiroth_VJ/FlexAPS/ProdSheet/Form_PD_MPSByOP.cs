using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdSheet
{
	public class Form_PD_MPSByOP : COM.APSWinForm.Form_Top
	{ 
		
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_DirLOT;
		private System.Windows.Forms.Label lbl_RealLOT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_LineType;
		public System.Windows.Forms.DateTimePicker dpick_ToYMD;
		public System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private C1.Win.C1List.C1Combo cmb_OpCd;
		public System.Windows.Forms.Panel pnl_Body;
		private C1.Win.C1List.C1Combo cmb_LineGroup;
		private System.Windows.Forms.Label lbl_CmpCd;
		private C1.Win.C1List.C1Combo cmb_CmpCd;
		private System.Windows.Forms.ImageList img_SmallLabel;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_OpCd;
		private C1.Win.C1List.C1Combo cmb_Area;
		private System.Windows.Forms.Label lbl_Area;
		private COM.FSP fgrid_MPS;
		private System.Windows.Forms.Label lbl_VirtualLOT;
		private System.Windows.Forms.Label btn_Check;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_View;
		private System.Windows.Forms.RadioButton rad_Line;
		private System.Windows.Forms.RadioButton rad_LOT;
		private System.ComponentModel.IContainer components = null;

		public Form_PD_MPSByOP()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PD_MPSByOP));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.btn_Check = new System.Windows.Forms.Label();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_View = new System.Windows.Forms.Label();
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rad_LOT = new System.Windows.Forms.RadioButton();
			this.rad_Line = new System.Windows.Forms.RadioButton();
			this.lbl_CmpCd = new System.Windows.Forms.Label();
			this.cmb_CmpCd = new C1.Win.C1List.C1Combo();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_VirtualLOT = new System.Windows.Forms.Label();
			this.lbl_DirLOT = new System.Windows.Forms.Label();
			this.lbl_RealLOT = new System.Windows.Forms.Label();
			this.cmb_Area = new C1.Win.C1List.C1Combo();
			this.lbl_Area = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.cmb_LineGroup = new C1.Win.C1List.C1Combo();
			this.lbl_LineType = new System.Windows.Forms.Label();
			this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_MPS = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Area)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MPS)).BeginInit();
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
			this.img_Button.ImageSize = new System.Drawing.Size(156, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// c1ToolBar1
			// 
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 100);
			this.pnl_Search.TabIndex = 36;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.btn_Check);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_View);
			this.pnl_SearchImage.Controls.Add(this.groupBox2);
			this.pnl_SearchImage.Controls.Add(this.lbl_CmpCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_CmpCd);
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.cmb_Area);
			this.pnl_SearchImage.Controls.Add(this.lbl_Area);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchImage.Controls.Add(this.cmb_OpCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_OpCd);
			this.pnl_SearchImage.Controls.Add(this.cmb_LineGroup);
			this.pnl_SearchImage.Controls.Add(this.lbl_LineType);
			this.pnl_SearchImage.Controls.Add(this.dpick_ToYMD);
			this.pnl_SearchImage.Controls.Add(this.dpick_FromYMD);
			this.pnl_SearchImage.Controls.Add(this.label1);
			this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 84);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// btn_Check
			// 
			this.btn_Check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Check.ImageIndex = 0;
			this.btn_Check.ImageList = this.img_Button;
			this.btn_Check.Location = new System.Drawing.Point(840, 56);
			this.btn_Check.Name = "btn_Check";
			this.btn_Check.Size = new System.Drawing.Size(156, 23);
			this.btn_Check.TabIndex = 202;
			this.btn_Check.Text = "Check MPS";
			this.btn_Check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
			this.btn_Check.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Check.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Check.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Check.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(707, 36);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.TabIndex = 198;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_StyleCd_KeyPress);
			// 
			// lbl_View
			// 
			this.lbl_View.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_View.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_View.ImageIndex = 0;
			this.lbl_View.ImageList = this.img_SmallLabel;
			this.lbl_View.Location = new System.Drawing.Point(656, 58);
			this.lbl_View.Name = "lbl_View";
			this.lbl_View.Size = new System.Drawing.Size(50, 21);
			this.lbl_View.TabIndex = 204;
			this.lbl_View.Text = "View";
			this.lbl_View.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rad_LOT);
			this.groupBox2.Controls.Add(this.rad_Line);
			this.groupBox2.Location = new System.Drawing.Point(707, 52);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(101, 28);
			this.groupBox2.TabIndex = 203;
			this.groupBox2.TabStop = false;
			// 
			// rad_LOT
			// 
			this.rad_LOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_LOT.Font = new System.Drawing.Font("Verdana", 7.5F);
			this.rad_LOT.Location = new System.Drawing.Point(49, 8);
			this.rad_LOT.Name = "rad_LOT";
			this.rad_LOT.Size = new System.Drawing.Size(45, 16);
			this.rad_LOT.TabIndex = 1;
			this.rad_LOT.Text = "LOT";
			this.rad_LOT.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Line
			// 
			this.rad_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Line.Font = new System.Drawing.Font("Verdana", 7.5F);
			this.rad_Line.Location = new System.Drawing.Point(4, 8);
			this.rad_Line.Name = "rad_Line";
			this.rad_Line.Size = new System.Drawing.Size(45, 16);
			this.rad_Line.TabIndex = 0;
			this.rad_Line.Text = "Line";
			this.rad_Line.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// lbl_CmpCd
			// 
			this.lbl_CmpCd.ImageIndex = 0;
			this.lbl_CmpCd.ImageList = this.img_Label;
			this.lbl_CmpCd.Location = new System.Drawing.Point(168, 58);
			this.lbl_CmpCd.Name = "lbl_CmpCd";
			this.lbl_CmpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpCd.TabIndex = 195;
			this.lbl_CmpCd.Text = "Component";
			this.lbl_CmpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_CmpCd
			// 
			this.cmb_CmpCd.AddItemCols = 0;
			this.cmb_CmpCd.AddItemSeparator = ';';
			this.cmb_CmpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_CmpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_CmpCd.Caption = "";
			this.cmb_CmpCd.CaptionHeight = 17;
			this.cmb_CmpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_CmpCd.ColumnCaptionHeight = 18;
			this.cmb_CmpCd.ColumnFooterHeight = 18;
			this.cmb_CmpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_CmpCd.ContentHeight = 17;
			this.cmb_CmpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_CmpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CmpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_CmpCd.EditorHeight = 17;
			this.cmb_CmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.GapHeight = 2;
			this.cmb_CmpCd.ItemHeight = 15;
			this.cmb_CmpCd.Location = new System.Drawing.Point(269, 58);
			this.cmb_CmpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_CmpCd.MaxDropDownItems = ((short)(5));
			this.cmb_CmpCd.MaxLength = 32767;
			this.cmb_CmpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_CmpCd.Name = "cmb_CmpCd";
			this.cmb_CmpCd.PartialRightColumn = false;
			this.cmb_CmpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_CmpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CmpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.Size = new System.Drawing.Size(100, 21);
			this.cmb_CmpCd.TabIndex = 196;
			this.cmb_CmpCd.SelectedValueChanged += new System.EventHandler(this.cmb_CmpCd_SelectedValueChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.lbl_VirtualLOT);
			this.groupBox1.Controls.Add(this.lbl_DirLOT);
			this.groupBox1.Controls.Add(this.lbl_RealLOT);
			this.groupBox1.Location = new System.Drawing.Point(784, -6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(208, 32);
			this.groupBox1.TabIndex = 19;
			this.groupBox1.TabStop = false;
			// 
			// lbl_VirtualLOT
			// 
			this.lbl_VirtualLOT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(166)));
			this.lbl_VirtualLOT.Location = new System.Drawing.Point(70, 11);
			this.lbl_VirtualLOT.Name = "lbl_VirtualLOT";
			this.lbl_VirtualLOT.Size = new System.Drawing.Size(65, 15);
			this.lbl_VirtualLOT.TabIndex = 76;
			this.lbl_VirtualLOT.Text = "Finished";
			this.lbl_VirtualLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_DirLOT
			// 
			this.lbl_DirLOT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(213)), ((System.Byte)(213)));
			this.lbl_DirLOT.Location = new System.Drawing.Point(5, 11);
			this.lbl_DirLOT.Name = "lbl_DirLOT";
			this.lbl_DirLOT.Size = new System.Drawing.Size(65, 15);
			this.lbl_DirLOT.TabIndex = 75;
			this.lbl_DirLOT.Text = "Released";
			this.lbl_DirLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_RealLOT
			// 
			this.lbl_RealLOT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(180)), ((System.Byte)(180)), ((System.Byte)(255)));
			this.lbl_RealLOT.Location = new System.Drawing.Point(135, 11);
			this.lbl_RealLOT.Name = "lbl_RealLOT";
			this.lbl_RealLOT.Size = new System.Drawing.Size(65, 15);
			this.lbl_RealLOT.TabIndex = 73;
			this.lbl_RealLOT.Text = "Planning";
			this.lbl_RealLOT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_Area
			// 
			this.cmb_Area.AddItemCols = 0;
			this.cmb_Area.AddItemSeparator = ';';
			this.cmb_Area.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Area.Caption = "";
			this.cmb_Area.CaptionHeight = 17;
			this.cmb_Area.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Area.ColumnCaptionHeight = 18;
			this.cmb_Area.ColumnFooterHeight = 18;
			this.cmb_Area.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Area.ContentHeight = 17;
			this.cmb_Area.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Area.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Area.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Area.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Area.EditorHeight = 17;
			this.cmb_Area.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Area.GapHeight = 2;
			this.cmb_Area.ItemHeight = 15;
			this.cmb_Area.Location = new System.Drawing.Point(547, 58);
			this.cmb_Area.MatchEntryTimeout = ((long)(2000));
			this.cmb_Area.MaxDropDownItems = ((short)(5));
			this.cmb_Area.MaxLength = 32767;
			this.cmb_Area.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Area.Name = "cmb_Area";
			this.cmb_Area.PartialRightColumn = false;
			this.cmb_Area.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Area.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Area.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Area.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Area.Size = new System.Drawing.Size(100, 21);
			this.cmb_Area.TabIndex = 200;
			// 
			// lbl_Area
			// 
			this.lbl_Area.ImageIndex = 0;
			this.lbl_Area.ImageList = this.img_SmallLabel;
			this.lbl_Area.Location = new System.Drawing.Point(496, 58);
			this.lbl_Area.Name = "lbl_Area";
			this.lbl_Area.Size = new System.Drawing.Size(50, 21);
			this.lbl_Area.TabIndex = 199;
			this.lbl_Area.Text = "Area";
			this.lbl_Area.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_SmallLabel;
			this.lbl_Style.Location = new System.Drawing.Point(656, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(50, 21);
			this.lbl_Style.TabIndex = 197;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OpCd
			// 
			this.cmb_OpCd.AddItemCols = 0;
			this.cmb_OpCd.AddItemSeparator = ';';
			this.cmb_OpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OpCd.Caption = "";
			this.cmb_OpCd.CaptionHeight = 17;
			this.cmb_OpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OpCd.ColumnCaptionHeight = 18;
			this.cmb_OpCd.ColumnFooterHeight = 18;
			this.cmb_OpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OpCd.ContentHeight = 17;
			this.cmb_OpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OpCd.EditorHeight = 17;
			this.cmb_OpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.GapHeight = 2;
			this.cmb_OpCd.ItemHeight = 15;
			this.cmb_OpCd.Location = new System.Drawing.Point(61, 58);
			this.cmb_OpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_OpCd.MaxDropDownItems = ((short)(5));
			this.cmb_OpCd.MaxLength = 32767;
			this.cmb_OpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OpCd.Name = "cmb_OpCd";
			this.cmb_OpCd.PartialRightColumn = false;
			this.cmb_OpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_OpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.Size = new System.Drawing.Size(100, 21);
			this.cmb_OpCd.TabIndex = 196;
			this.cmb_OpCd.SelectedValueChanged += new System.EventHandler(this.cmb_OpCd_SelectedValueChanged);
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_SmallLabel;
			this.lbl_OpCd.Location = new System.Drawing.Point(10, 58);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(50, 21);
			this.lbl_OpCd.TabIndex = 195;
			this.lbl_OpCd.Text = "Proc";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LineGroup
			// 
			this.cmb_LineGroup.AddItemCols = 0;
			this.cmb_LineGroup.AddItemSeparator = ';';
			this.cmb_LineGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineGroup.Caption = "";
			this.cmb_LineGroup.CaptionHeight = 17;
			this.cmb_LineGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineGroup.ColumnCaptionHeight = 18;
			this.cmb_LineGroup.ColumnFooterHeight = 18;
			this.cmb_LineGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineGroup.ContentHeight = 17;
			this.cmb_LineGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineGroup.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineGroup.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineGroup.EditorHeight = 17;
			this.cmb_LineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineGroup.GapHeight = 2;
			this.cmb_LineGroup.ItemHeight = 15;
			this.cmb_LineGroup.Location = new System.Drawing.Point(547, 36);
			this.cmb_LineGroup.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineGroup.MaxDropDownItems = ((short)(5));
			this.cmb_LineGroup.MaxLength = 32767;
			this.cmb_LineGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineGroup.Name = "cmb_LineGroup";
			this.cmb_LineGroup.PartialRightColumn = false;
			this.cmb_LineGroup.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LineGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineGroup.Size = new System.Drawing.Size(100, 21);
			this.cmb_LineGroup.TabIndex = 194;
			this.cmb_LineGroup.SelectedValueChanged += new System.EventHandler(this.cmb_LineGroup_SelectedValueChanged);
			// 
			// lbl_LineType
			// 
			this.lbl_LineType.ImageIndex = 0;
			this.lbl_LineType.ImageList = this.img_SmallLabel;
			this.lbl_LineType.Location = new System.Drawing.Point(496, 36);
			this.lbl_LineType.Name = "lbl_LineType";
			this.lbl_LineType.Size = new System.Drawing.Size(50, 21);
			this.lbl_LineType.TabIndex = 193;
			this.lbl_LineType.Text = "Line";
			this.lbl_LineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_ToYMD
			// 
			this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ToYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToYMD.Location = new System.Drawing.Point(386, 36);
			this.dpick_ToYMD.Name = "dpick_ToYMD";
			this.dpick_ToYMD.Size = new System.Drawing.Size(102, 22);
			this.dpick_ToYMD.TabIndex = 192;
			this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
			// 
			// dpick_FromYMD
			// 
			this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
			this.dpick_FromYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromYMD.Location = new System.Drawing.Point(269, 36);
			this.dpick_FromYMD.Name = "dpick_FromYMD";
			this.dpick_FromYMD.Size = new System.Drawing.Size(102, 22);
			this.dpick_FromYMD.TabIndex = 191;
			this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(371, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 16);
			this.label1.TabIndex = 73;
			this.label1.Text = "~";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(168, 36);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 72;
			this.lbl_PlanYMD.Text = "Plan Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(61, 36);
			this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory.MaxDropDownItems = ((short)(5));
			this.cmb_Factory.MaxLength = 32767;
			this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory.Name = "cmb_Factory";
			this.cmb_Factory.PartialRightColumn = false;
			this.cmb_Factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(100, 21);
			this.cmb_Factory.TabIndex = 34;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_SmallLabel;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(50, 21);
			this.lbl_Factory.TabIndex = 32;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(983, 32);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(17, 36);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
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
			this.lbl_SubTitle1.Text = "      Selected Information";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(984, 68);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 23;
			this.picb_BR.TabStop = false;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(144, 68);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(840, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 69);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 47);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 44);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_MPS);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 164);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 476);
			this.pnl_Body.TabIndex = 38;
			// 
			// fgrid_MPS
			// 
			this.fgrid_MPS.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MPS.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_MPS.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MPS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MPS.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MPS.Location = new System.Drawing.Point(8, 0);
			this.fgrid_MPS.Name = "fgrid_MPS";
			this.fgrid_MPS.Size = new System.Drawing.Size(1000, 476);
			this.fgrid_MPS.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MPS.TabIndex = 38;
			this.fgrid_MPS.Click += new System.EventHandler(this.fgrid_MPS_Click);
			// 
			// Form_PD_MPSByOP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_PD_MPSByOP";
			this.Text = "MPS (Master Plan Schedule) By OP";
			this.Load += new System.EventHandler(this.Form_PD_MPSByOP_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Area)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineGroup)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MPS)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		private int _TBDay_Row = 0;
		private int _Month_Row = 1;
		private int _Day_Row = 2;

		private string _SelCmpCd = "";
		private string _SelOpCd = "";
		private string _SelArea = "";


		//----------------------------------------------
		// 선적 구간 표시
		//---------------------------------------------- 
		private string _ShipDateF_20 = "";  // 선적중
		private string _ShipDateT_20 = "";
		private string _ShipDateF_30 = "";  // 선적준비중
		private string _ShipDateT_30 = "";
		private string _ShipDateF_40 = "";  // 다음 선적 진행중
		private string _ShipDateT_40 = "";
		private string _ShipDateF_50 = "";  // Free 구간
		private string _ShipDateT_50 = "";

		Color _ClrShipDate_20;
		Color _ClrShipDate_30;
		Color _ClrShipDate_40; 

		private string _WarningShippingDateF = "";  // 다음 선적 진행 구간 + n일 처리
		private string _WarningShippingDateT = ""; 

		private int _WarningShippingDateF_Col = -1;
		private int _WarningShippingDateT_Col = -1;

		private int _Display_Next_Shipping_Area_Count = 3;
		private int _WarningLineCapa = 2000;
		//----------------------------------------------



		#endregion 

		#region 멤버 메서드


		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			
			try
			{ 
			
				//Title
				this.Text = "MPS (Master Plan Schedule) By OP";
				lbl_MainTitle.Text = "MPS (Master Plan Schedule) By OP"; 

				fgrid_MPS.Set_Grid("SPD_WORKSHEET_MPS_BSC", "1", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_MPS.ExtendLastCol = false;
				fgrid_MPS.AllowEditing = false;
				fgrid_MPS.AllowSorting = AllowSortingEnum.None;
				fgrid_MPS.AllowDragging = AllowDraggingEnum.None;
				fgrid_MPS.Font = new Font("Verdana", 7); 
				fgrid_MPS.Styles.Alternate.BackColor = Color.White;
				fgrid_MPS.SelectionMode = SelectionModeEnum.Default;
 

				Init_Control();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

  
		}


		
		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
  
			tbtn_Save.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Color.Enabled = false; 


			dpick_FromYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			
			rad_LOT.Checked = true;

			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code); 
			dt_ret.Dispose();

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 


		}  



		#endregion
		  
		#region 조회

 
		/// <summary>
		/// Set_Grid_Date : 조회 일자에 걸리는 날짜 세팅
		/// </summary>
		private void Set_Grid_Date()
		{
			

			try
			{

				if(cmb_Factory.SelectedIndex == -1) return;


				// shipping area 이후 3일 표시하기 위함
				int next_shipping_count = 0;


				string factory = cmb_Factory.SelectedValue.ToString();
				string from_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
				string to_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
				DataTable dt_ret = Select_OPSIZE_MPS_YMD(factory, from_ymd, to_ymd);
 
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
				fgrid_MPS.Cols.Count = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START + 1;
				fgrid_MPS.Cols.Count = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START + dt_ret.Rows.Count;

				
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Width = 40;
					fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].TextAlign = TextAlignEnum.RightCenter;
 
					//실제 날짜 표시
					fgrid_MPS[_TBDay_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString();
 
				 
					fgrid_MPS[_Month_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(0, 4)
						+ ClassLib.ComVar.This_SetedDateSign
						+ dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(4, 2);


					fgrid_MPS[_Day_Row, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START] 
						= dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString().Substring(6, 2);


					//fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Style.Clear();

					//휴일 색깔 처리
					if(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_HOLI_YN].ToString() == "Y")
					{
						fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = ClassLib.ComVar.ClrDisableHead;
						fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Width = 20;

						CellRange cr = fgrid_MPS.GetCellRange(0, i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START);
						cr.UserData = "Y";

					}
					else
					{


						//-----------------------------------------------------------------------------
						// 1. 30 : shipping area
						// 2. 40 : next shipping area
						// 3. 마지막 shipping area 일자 + 3일 (휴일제외)
						//-----------------------------------------------------------------------------
						int now_ymd = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBYMD_THEDAY].ToString() );

						// 1. 30 : shipping area
						if(_ShipDateF_30 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_30) && now_ymd < Convert.ToInt32(_ShipDateF_40) )
						{
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = _ClrShipDate_30;
						}
							// 2. 40 : next shipping area
						else if(_ShipDateF_40 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_40) && now_ymd < Convert.ToInt32(_ShipDateF_50) )
						{
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = _ClrShipDate_40; 
						} 
							// 3. 마지막 shipping area 일자 + 3일 (휴일제외) 
						else if(_ShipDateF_40 != "" && now_ymd >= Convert.ToInt32(_ShipDateF_50) && next_shipping_count < _Display_Next_Shipping_Area_Count)
						{
 
							// 선적 warning 표시 구간 from
							if(next_shipping_count == 0) 
							{
								_WarningShippingDateF_Col = i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
								_WarningShippingDateF = now_ymd.ToString();
							}
							
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].StyleNew.BackColor = ClassLib.ComVar.ClrOA;
							next_shipping_count++;

							// 선적 warning 표시 구간 to
							if(next_shipping_count == _Display_Next_Shipping_Area_Count)
							{
								_WarningShippingDateT_Col = i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
								_WarningShippingDateT = now_ymd.ToString();
							}

						}  
						else
						{  
							fgrid_MPS.Cols[i + (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START].Style.Clear();
						}
						//-----------------------------------------------------------------------------

					}


				}

				fgrid_MPS.AllowMerging = AllowMergingEnum.FixedOnly;
				fgrid_MPS.Rows[_Month_Row].AllowMerging = true;
				fgrid_MPS.Cols.Frozen = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_Grid_Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		/// <summary>
		/// Display_Head : 
		/// </summary>
		/// <param name="dt_ret"></param>
		private void Display_Head(DataTable arg_dt)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
				fgrid_MPS.Rows.InsertRange(fgrid_MPS.Rows.Fixed, arg_dt.Rows.Count);
				
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					for(int j = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_CD; j < (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; j++)
					{
						fgrid_MPS[i + fgrid_MPS.Rows.Fixed, j] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
					}
				} 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Display_Detail : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Detail(DataTable arg_dt)
		{
			int findrow = 0;
			int findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
			string beforelot = "", findlot = ""; 
			//int sum = 0;

			try
			{
				this.Cursor = Cursors.WaitCursor;

				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					findlot = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_LOT].ToString();
					findrow = fgrid_MPS.FindRow(findlot, fgrid_MPS.Rows.Fixed, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT, false, true, false);
					if(findrow == -1) continue;
 
					if(beforelot != findlot)
					{ 
						findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
						//sum = 0;
						beforelot = findlot;
					}

					
					for(int j = findcol; j < fgrid_MPS.Cols.Count; j++)
					{
						if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_OP_STR_YMD].ToString() == fgrid_MPS[_TBDay_Row, j].ToString())
						{
							fgrid_MPS[findrow, j] = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_SIZE_QTY].ToString();
							//sum += Convert.ToInt32(fgrid_MPS[findrow, j].ToString());
							findcol = j;

							// 작업지시 나가지 않은 일자에 대해서 색깔 표시 (Real, Virtual LOT)
							if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_PLAN_STATUS].ToString() == "L")
							{


								//rgac deadline date 에 걸린 일자 색깔 표시
								if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_DEADLINE_YN].ToString().ToString() == "Y")
								{
									////fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrWarning;
									//fgrid_MPS.GetCellRange(findrow, j).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;	
									fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRealLOT;	
								}
								else
								{
									// Real LOT
									if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_REAL_LOTYN].ToString() == "Y")
									{
										fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRealLOT;
									}
										// Virtual LOT
									else
									{
										fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrReadOnly;
									}
								}
 

								// finished 표시
								if(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxTBD_TS_FINISH_YN].ToString() == "Y")
								{
									fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;	
								}


							}
								// 작업지시 이후의 상태
							else
							{ 
								fgrid_MPS.GetCellRange(findrow, j).StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
							} 

							break;
						}
					} // end for j


					//fgrid_MPS[findrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY] = sum.ToString();

				} // end for i
 

				//--------------------------------------------------------------
				//Merge 속성
				fgrid_MPS.AllowMerging = AllowMergingEnum.Free; 

				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxORD_QTY].AllowMerging = false;
				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOSS_QTY].AllowMerging = false;
				fgrid_MPS.Cols[(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY].AllowMerging = false;

				for(int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++)
					fgrid_MPS.Cols[i].AllowMerging = false;
    
				//-------------------------------------------------------------- 
				// 총합 계산  
				fgrid_MPS.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
				fgrid_MPS.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;
				//fgrid_MPS.Styles[CellStyleEnum.Subtotal0].Font = new Font(fgrid_MPS.Styles[CellStyleEnum.Subtotal0].Font, FontStyle.Bold);
				fgrid_MPS.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
				fgrid_MPS.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black; 
				//fgrid_MPS.Styles[CellStyleEnum.Subtotal1].Font = new Font(fgrid_MPS.Styles[CellStyleEnum.Subtotal1].Font, FontStyle.Bold);

				fgrid_MPS.Tree.Column = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME;
				fgrid_MPS.SubtotalPosition = SubtotalPositionEnum.AboveData; 
				fgrid_MPS.Subtotal(AggregateEnum.Clear); 
 
				for (int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++) 
					fgrid_MPS.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME, i, "{0}");

				for (int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++) 
					fgrid_MPS.Subtotal(AggregateEnum.Sum, 0, -1, i, "Total");



				fgrid_MPS.Tree.Show(-1);
				rad_LOT.Checked = true;



				this.Cursor = Cursors.Default;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// Display_LineSummary : 
		/// </summary>
		private void Display_LineSummary()
		{

			double sum_qty = 0;


			for (int i = fgrid_MPS.Rows.Fixed; i < fgrid_MPS.Rows.Count; i++)
			{

				if (!fgrid_MPS.Rows[i].IsNode) continue;

				sum_qty = 0;

				for (int j = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; j < fgrid_MPS.Cols.Count; j++)
				{

					if (fgrid_MPS[i, j] == null || fgrid_MPS[i, j].ToString().Trim().Equals(""))
					{
						sum_qty += 0;
					}
					else
					{
						sum_qty += Convert.ToDouble(fgrid_MPS[i, j].ToString());
					}

				} // end for j


				fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY] = sum_qty.ToString();

				CellRange cr = fgrid_MPS.GetCellRange(i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY);
				cr.StyleNew.Font = new Font("Verdana", 8, FontStyle.Bold);


			} // end for i



		}



		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
			fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
  

			DataSet ds_ret;
			DataTable dt_h, dt_d;

			 
			if(cmb_Factory.SelectedIndex == -1 || dpick_FromYMD.CustomFormat == " "
				|| dpick_ToYMD.CustomFormat == " " || cmb_OpCd.SelectedIndex == -1) return;


			//조회 일자에 걸리는 날짜 세팅
			Set_Grid_Date();

			string factory = cmb_Factory.SelectedValue.ToString();
			string from_ymd = dpick_FromYMD.Value.ToString("yyyyMMdd");
			string to_ymd = dpick_ToYMD.Value.ToString("yyyyMMdd");
			string line_group = ClassLib.ComFunction.Empty_Combo(cmb_LineGroup, " ");
			string cmp_cd = ClassLib.ComFunction.Empty_Combo(cmb_CmpCd, " ");
			string op_cd = ClassLib.ComFunction.Empty_Combo(cmb_OpCd, " ");
			string area_cd = ClassLib.ComFunction.Empty_Combo(cmb_Area, " ");
			string style_cd = ClassLib.ComFunction.Empty_String(txt_StyleCd.Text.Trim().Replace("-", ""), " "); 


			if(cmb_OpCd.SelectedValue.ToString() == "FGA")
			{
				ds_ret = Select_OPSIZE_MPS_FGA(factory, from_ymd, to_ymd, line_group, style_cd);
			}
			else
			{
				ds_ret = Select_OPSIZE_MPS(factory, from_ymd, to_ymd, line_group, cmp_cd, op_cd, area_cd, style_cd);
			}

			dt_h = ds_ret.Tables[0];
			dt_d = ds_ret.Tables[1];
			Display_Head(dt_h);
			Display_Detail(dt_d); 

			// 라인 일자 합계 처리
			Display_LineSummary();


		}


		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{

			string filename = Application.StartupPath + @"\Report\Production\" + this.Name + ".txt";
			
			FileInfo file = new FileInfo(filename);
			if(!file.Exists)
			{
				file.Create().Close();
			}

			file = null;


			string message = "";
			string message1 = "";
			string message2 = "";
 


			for(int i=3; i<fgrid_MPS.Rows.Count; i++)
			{
				message1 = fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@";

				try
				{
					
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxMODEL_NAME].ToString() + " @"; //Model
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSTYLE_CD].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxGEN].ToString() + "@";
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxOBS_ID].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxOBS_TYPE].ToString() + "@";
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxRTS_YMD].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxOGAC].ToString() + "@";   
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxORD_QTY].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOSS_QTY].ToString() + "@";
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxSUM_QTY].ToString() + " @"; 
				}
				catch
				{
					 
					// summary row
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@";  
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += fgrid_MPS[i, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_NAME].ToString() + "@"; 
					message1 += "" + "@"; 
					message1 += "" + "@";
					message1 += "" + "@"; 

				}
 

				for(int j=(int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; j<fgrid_MPS.Cols.Count; j++)
				{
					message2 = fgrid_MPS[1, j].ToString() + "@"; 
					message2 += fgrid_MPS[2, j].ToString() + "@"; 

					if(fgrid_MPS[i, j] != null)
					{
						message2 += fgrid_MPS[i, j].ToString()+"@";
					}
					else
					{
						message2 += " @";
					}
					
					message += message1+message2+"\r\n";


				}
				
				
			}

			FileStream Message = new FileStream(filename, FileMode.Create, FileAccess.Write);
			StreamWriter sw = new StreamWriter(Message);

			sw.Write(message);
			sw.Flush();

			sw.Close();
			Message.Close();


			string line = cmb_LineGroup.SelectedValue.ToString();

			if(cmb_LineGroup.SelectedIndex == 0)
			{
				line = "All";
			}


			string para = "/rfn [" + filename + "]  /rv V_FDATE[" + dpick_FromYMD.Text 
				+ "] V_TDATE[" + dpick_ToYMD.Text + "] V_LINE[" + line + "] V_OP[" + cmb_OpCd.SelectedValue.ToString() + "]";

			string sDir = ClassLib.ComFunction.Set_RD_Directory(this.Name); 
			COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("MPS By OP", sDir, para);
			report.Show();
  

		}
 

		#endregion

		#region 그리드 이벤트 메서드

 
		/// <summary>
		/// Event_Click_fgrid_MPS : 
		/// </summary>
		private void Event_Click_fgrid_MPS()
		{

			if(fgrid_MPS.Rows.Count <= fgrid_MPS.Rows.Fixed) return;


			int findcol = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START;
			int selrow = fgrid_MPS.Selection.r1;
			int selcol = fgrid_MPS.Selection.c1;


			if(selcol > (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START) return;
			
			if(fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT] == null
				|| fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLOT].ToString() == "") return;

			
			for(int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i < fgrid_MPS.Cols.Count; i++)
			{
				if(fgrid_MPS[selrow, i] == null || fgrid_MPS[selrow, i].ToString() == "") continue;
				if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(Color.Empty)) continue;

				//모두 작업지시 나간 경우 표시하기 위함
				findcol = i;

				if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrRelease)) continue;

				if(fgrid_MPS[selrow, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxREAL_LOTYN].ToString() == "Y") 
					if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrRealLOT)) findcol = i; 
					else 
						if(fgrid_MPS.GetCellRange(selrow, i).Style.BackColor.Equals(ClassLib.ComVar.ClrReadOnly)) findcol = i; 


				break;

			}

			fgrid_MPS.LeftCol = findcol - 2;
			 


		}


		#endregion

		#region 버튼 및 기타 이벤트 메서드

 
		/// <summary>
		/// Event_SelectedValueChanged_cmb_Factory : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_Factory()
		{

			DataTable dt_ret;

			string year = "", frommonth = "", fromday = "", fromymd = "";
			string toyear = "", tomonth = "", today = "", toymd = "";
 
			 
//			if(ClassLib.ComVar.FormClick_Flag == true)
//			{ 
//				fromymd = ClassLib.ComVar.Parameter_PopUp[0];
//				toymd = ClassLib.ComVar.Parameter_PopUp[1]; 
//			}
//			else
//			{   
				
				year = System.DateTime.Now.Year.ToString(); 
				frommonth = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
				fromday = "01";	
				fromymd = year + frommonth + fromday;
	
				toyear = System.DateTime.Now.AddMonths(2).Year.ToString();
				tomonth = System.DateTime.Now.AddMonths(2).Month.ToString().PadLeft(2, '0');
				today = System.DateTime.DaysInMonth(Convert.ToInt32(toyear), Convert.ToInt32(tomonth)).ToString().PadLeft(2, '0');
				toymd = toyear + tomonth + today; 

			
//			}  
			
			
			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(fromymd);
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(toymd); 
		
			if(ClassLib.ComVar.This_FormDate == "") 
			{
				ClassLib.ComVar.This_FormDate = fromymd;
				ClassLib.ComVar.This_ToDate = toymd;
			} 


			/////////////////////////////////////////////////////////////////////////////////
			//조회 일자에 걸리는 날짜 세팅
			Set_Grid_Date();

			/////////////////////////////////////////////////////////////////////////////////
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLineType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineGroup, 1, 2, true, COM.ComVar.ComboList_Visible.Name);  
			cmb_LineGroup.SelectedIndex = 0;


			string factory = cmb_Factory.SelectedValue.ToString(); 
			dt_ret = Select_SPB_OPCD(factory);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OpCd, 0, 1, false, COM.ComVar.ComboList_Visible.Code);

			if(_SelOpCd == "")
			{
				if(cmb_OpCd.ListCount == 0)
				{
					cmb_OpCd.SelectedIndex = -1;
				}
				else
				{
					cmb_OpCd.SelectedIndex = 0; 
				}
			}
			else 
			{
				cmb_OpCd.SelectedValue = _SelOpCd;
			} 
			 

		}

		

		/// <summary>
		/// Event_SelectedValueChanged_cmb_OpCd : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_OpCd()
		{

			fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;

			if(cmb_Factory.SelectedIndex == -1 || dpick_FromYMD.CustomFormat == " "
				|| dpick_ToYMD.CustomFormat == " " || cmb_OpCd.SelectedIndex == -1) return;

				
			_SelOpCd = cmb_OpCd.SelectedValue.ToString();


			// 반제 코드
			string factory = cmb_Factory.SelectedValue.ToString(); 
			string op_cd = cmb_OpCd.SelectedValue.ToString();

			DataTable dt_ret = Select_SPB_OPCD_CMPCD(factory, op_cd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CmpCd, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
		
			if(_SelCmpCd == "") 
			{
				cmb_CmpCd.SelectedIndex = 0; 
			}
			else 
			{
				cmb_CmpCd.SelectedValue = _SelCmpCd; 
			}
 


			// 작업장 코드 
			dt_ret = Select_SPB_OPCD_LINE_AREA(factory, op_cd);    
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Area, 0, 1, true, COM.ComVar.ComboList_Visible.Name);

			if(_SelArea == "") 
			{
				cmb_Area.SelectedIndex = 0; 
			}
			else 
			{
				cmb_Area.SelectedValue = _SelArea;
			}

		}


		/// <summary>
		/// Event_KeyPress_txt_StyleCd : 
		/// </summary>
		private void Event_KeyPress_txt_StyleCd(System.Windows.Forms.KeyPressEventArgs e)
		{

			//13 : enter
			if(e.KeyChar != (char)13) return; 

			Event_Tbtn_Search();


		}




		// SS 를 위한 MPS 체크
		
		/// <summary>
		/// Event_Click_btn_Check : 
		/// </summary>
		private void Event_Click_btn_Check()
		{

			if(cmb_Factory.SelectedIndex == -1) return;

			string factory = cmb_Factory.SelectedValue.ToString();
			DataTable dt_ret = Select_SBM_SHIPPING_MASTER(factory);


			_ShipDateF_20 = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_F].ToString();
			_ShipDateT_20 = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_T].ToString();
			_ClrShipDate_20 = Color.FromArgb( Convert.ToInt32(dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxBACK_COLOR].ToString() ) );

			_ShipDateF_30 = dt_ret.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_F].ToString();
			_ShipDateT_30 = dt_ret.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_T].ToString();
			_ClrShipDate_30 = Color.FromArgb( Convert.ToInt32(dt_ret.Rows[1].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxBACK_COLOR].ToString() ) );

			_ShipDateF_40 = dt_ret.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_F].ToString();
			_ShipDateT_40 = dt_ret.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_T].ToString();
			_ClrShipDate_40 = Color.FromArgb( Convert.ToInt32(dt_ret.Rows[2].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxBACK_COLOR].ToString() ) );

			_ShipDateF_50 = dt_ret.Rows[3].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_F].ToString();
			_ShipDateT_50 = dt_ret.Rows[3].ItemArray[(int)ClassLib.TBSPD_WORKSHEET_MPS_CHECK_MPS_BSC.IxPLAN_DATE_T].ToString(); 


			int date_to_year = Convert.ToInt32(_ShipDateF_30.Substring(0, 4) );
			int date_to_month = Convert.ToInt32(_ShipDateF_30.Substring(4, 2) );
			int date_to_day = Convert.ToInt32(_ShipDateF_30.Substring(6, 2) );

			DateTime shipping_date_to_1 = new DateTime(date_to_year, date_to_month, date_to_day).AddDays(-1);

			date_to_year = Convert.ToInt32(_ShipDateF_50.Substring(0, 4) );
			date_to_month = Convert.ToInt32(_ShipDateF_50.Substring(4, 2) );
			date_to_day = Convert.ToInt32(_ShipDateF_50.Substring(6, 2) );

			DateTime shipping_date_to_2 = new DateTime(date_to_year, date_to_month, date_to_day).AddDays(15);
 
 
			string date_from = shipping_date_to_1.ToString("yyyyMMdd");
			string date_to = shipping_date_to_2.ToString("yyyyMMdd"); 
			
			dpick_FromYMD.Text = MyComFunction.ConvertDate2Type(date_from); 
			dpick_ToYMD.Text = MyComFunction.ConvertDate2Type(date_to); 

			Event_Tbtn_Search();
			Display_Shipping_Warning();


			_ShipDateF_20 = ""; 
			_ShipDateT_20 = "";
			_ShipDateF_30 = ""; 
			_ShipDateT_30 = "";
			_ShipDateF_40 = ""; 
			_ShipDateT_40 = "";
			_ShipDateF_50 = ""; 
			_ShipDateT_50 = ""; 
			_WarningShippingDateF = "";   
			_WarningShippingDateT = "";  
			_WarningShippingDateF_Col = -1;
			_WarningShippingDateT_Col = -1;  


		}


		/// <summary>
		/// Display_Shipping_Warning : 
		/// </summary>
		private void Display_Shipping_Warning()
		{
 
			// next shipping range mps data warning
			// warning : sum(day qty)/line < 2000 
 
			//for(int i = _WarningShippingDateF_Col; i <= _WarningShippingDateT_Col; i++)

			for(int i = (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START; i <= _WarningShippingDateT_Col; i++)
			{

				for(int j = fgrid_MPS.Rows.Fixed; j < fgrid_MPS.Rows.Count; j++)
				{

					if(! fgrid_MPS.Rows[j].IsNode)  continue; 


					if(fgrid_MPS.Rows[j].Node.Level == 0)
					{
						fgrid_MPS.GetCellRange(j, i, j, i).StyleNew.BackColor = ClassLib.ComVar.ClrSubTotal0;
					}
					else
					{ 
						fgrid_MPS.GetCellRange(j, i, j, i).StyleNew.BackColor = ClassLib.ComVar.ClrSubTotal1; 
					} 


					if(i < _WarningShippingDateF_Col || i > _WarningShippingDateT_Col) continue;

					// line 별 총 mps 수량이 2000족 이하일때, mps node 에 경고 표시

					// 휴일 제외
					CellRange cr = fgrid_MPS.GetCellRange(0, i);
					cr.UserData = (cr.UserData == null) ? "N" : cr.UserData.ToString(); 
					if(cr.UserData.ToString() == "Y") continue;

					if(Convert.ToInt32(fgrid_MPS[j, i].ToString() ) >= _WarningLineCapa) continue;
					 
					int findrow = fgrid_MPS.FindRow(fgrid_MPS[j - 1, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_CD].ToString(), fgrid_MPS.Rows.Fixed, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxLINE_CD, false, true, false);
 
					fgrid_MPS.GetCellRange(findrow, 1, j - 1, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START - 1).StyleNew.BackColor = ClassLib.ComVar.ClrOA;
					fgrid_MPS.GetCellRange(findrow, 1, j - 1, (int)ClassLib.TBSPD_WORKSHEET_MPS_BSC.IxYMD_START - 1).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					 
					fgrid_MPS.GetCellRange(j, i, j, i).StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					fgrid_MPS.GetCellRange(j, i, j, i).StyleNew.Font = new Font(fgrid_MPS.GetCellRange(j, i, j, i).Style.Font, FontStyle.Bold);

					
				}

			} // end for i



			fgrid_MPS.LeftCol = _WarningShippingDateF_Col - 1; 

		}




		/// <summary>
		/// Event_rad_CheckedChanged : 
		/// </summary>
		/// <param name="sender"></param>
		private void Event_rad_CheckedChanged(object sender)
		{


			RadioButton src = sender as RadioButton;


			if (src == rad_Line)
			{

				fgrid_MPS.Tree.Show(1);

			}
			else if (src == rad_LOT)
			{

				fgrid_MPS.Tree.Show(-1);

			}



		}


		#endregion

		#region 컨텍스트 메뉴 이벤트 메서드

  

		#endregion
 

		#endregion   
		
		#region 이벤트 처리

		#region 툴바 이벤트


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{ 
				Event_Tbtn_New();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_New", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Search(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 
		 
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_Tbtn_Print(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		#endregion

		#region 그리드 이벤트


		
		private void fgrid_MPS_Click(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_Click_fgrid_MPS();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_fgrid_MPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			

		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{

			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			}  

		}

		#endregion



		private void Form_PD_MPSByOP_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 
				Event_SelectedValueChanged_cmb_Factory();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_Factory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_LineGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LineGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void cmb_OpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Event_SelectedValueChanged_cmb_OpCd();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_OpCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void cmb_CmpCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_CmpCd.SelectedIndex == -1) return;

				_SelCmpCd = cmb_CmpCd.SelectedValue.ToString();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_CmpCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				fgrid_MPS.Rows.Count = fgrid_MPS.Rows.Fixed;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ToYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void txt_StyleCd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
		
			try
			{
				Event_KeyPress_txt_StyleCd(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_KeyPress_txt_StyleCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		} 

		// SS 를 위한 MPS 체크
		private void btn_Check_Click(object sender, System.EventArgs e)
		{
			try
			{
				
				this.Cursor = Cursors.WaitCursor;

				Event_Click_btn_Check();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_btn_Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		} 


		private void rad_CheckedChanged(object sender, EventArgs e)
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_rad_CheckedChanged(sender);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		#endregion   

		#region 컨텍스트 메뉴 이벤트


	 

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 콤보


		/// <summary>
		/// Select_SPB_LINE : 라인 리스트 가져오기
		/// </summary>
		public static DataTable Select_SPB_LINE(string arg_factory, string arg_line_group)
		{
			
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;
			
				string process_name = "PKG_SPB_LINE.SELECT_SPB_LINE_GROUP";

				LMyOraDB.ReDim_Parameter(3); 
 
				LMyOraDB.Process_Name = process_name;
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				LMyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP"; 
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_line_group; 
				LMyOraDB.Parameter_Values[2] = ""; 

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
		}



		/// <summary>
		/// Select_SPB_OPCD : Routing 에 종속되어 있는 공정 리스트 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		public static DataTable Select_SPB_OPCD(string arg_factory)
		{
		
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;


				string process_name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_SPB_OPCD_ROUT";

				LMyOraDB.ReDim_Parameter(2); 
 
				LMyOraDB.Process_Name = process_name;
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				LMyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = ""; 

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			} 
		}

		 
		/// <summary>
		/// Select_SPB_OPCD_CMPCD : Routing 에 종속되어 있는 반제 리스트
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_opcd"></param>
		/// <returns></returns>
		public static DataTable Select_SPB_OPCD_CMPCD(string arg_factory, string arg_opcd)
		{
			 
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;

				string process_name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_SPB_ROUT_OPCD_CMPCD";

				LMyOraDB.ReDim_Parameter(3); 
 
				LMyOraDB.Process_Name = process_name;
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				LMyOraDB.Parameter_Name[1] = "ARG_OP_CD";
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_opcd;
				LMyOraDB.Parameter_Values[2] = ""; 

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			} 
		}

 
		/// <summary>
		/// Select_SPB_OPCD_LINE_AREA :  
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_opcd"></param>
		/// <returns></returns>
		public static DataTable Select_SPB_OPCD_LINE_AREA(string arg_factory, string arg_opcd)
		{
			 
			try
			{ 

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret; 

				LMyOraDB.ReDim_Parameter(3);  
				LMyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_SPB_OPCD_LINE_AREA";
 
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				LMyOraDB.Parameter_Name[1] = "ARG_OP_CD";
				LMyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				LMyOraDB.Parameter_Values[0] = arg_factory; 
				LMyOraDB.Parameter_Values[1] = arg_opcd;
				LMyOraDB.Parameter_Values[2] = "";

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
				return ds_ret.Tables[LMyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}
		}
 


		/// <summary>
		/// Select_SPD_DAILY_WORKSHEET_TS_OPCD : SPD_DAILY_WORKSHEET_TS 의 OPCD 리스트  
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_line_group"></param>
		/// <param name="arg_line_cd"></param>
		/// <param name="arg_op_str_ymd"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <param name="arg_op_cd"></param>
		/// <returns></returns>
		public static DataTable Select_SPD_DAILY_WORKSHEET_TS_MLINECD(string arg_factory,
			string arg_line_group,
			string arg_line_cd,
			string arg_op_str_ymd,
			string arg_cmp_cd,
			string arg_op_cd)
		{
			
			try
			{

				COM.OraDB LMyOraDB = new COM.OraDB();

				DataSet ds_ret;

				string process_name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_WORKSHEET_TS_MLINECD";

				LMyOraDB.ReDim_Parameter(7); 
 
				LMyOraDB.Process_Name = process_name;
  
				LMyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				LMyOraDB.Parameter_Name[1] = "ARG_LINE_GROUP";
				LMyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				LMyOraDB.Parameter_Name[3] = "ARG_OP_STR_YMD";
				LMyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
				LMyOraDB.Parameter_Name[5] = "ARG_OP_CD"; 
				LMyOraDB.Parameter_Name[6] = "OUT_CURSOR";
 
				LMyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				LMyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				LMyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;
			  
				LMyOraDB.Parameter_Values[0] = arg_factory;
				LMyOraDB.Parameter_Values[1] = arg_line_group;
				LMyOraDB.Parameter_Values[2] = arg_line_cd;
				LMyOraDB.Parameter_Values[3] = arg_op_str_ymd;
				LMyOraDB.Parameter_Values[4] = arg_cmp_cd;
				LMyOraDB.Parameter_Values[5] = arg_op_cd;
				LMyOraDB.Parameter_Values[6] = ""; 

				LMyOraDB.Add_Select_Parameter(true); 
				ds_ret = LMyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			} 
		}



		#endregion

		#region 조회

		
		/// <summary>
		/// Select_OPSIZE_MPS_YMD : 조회일자 + 월력 적용 리스트 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_ymd"></param>
		/// <param name="arg_to_ymd"></param>
		/// <returns></returns>
		private DataTable Select_OPSIZE_MPS_YMD(string arg_factory, string arg_from_ymd, string arg_to_ymd)
		{
			DataSet ds_ret; 
 
			try
			{  
				MyOraDB.ReDim_Parameter(4);  
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_OPSIZE_MPS_YMD";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ;
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}
		}


		/// <summary>
		/// Select_OPSIZE_MPS_FGA : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_ymd"></param>
		/// <param name="arg_to_ymd"></param>
		/// <param name="arg_line_group"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataSet Select_OPSIZE_MPS_FGA(string arg_factory, 
			string arg_from_ymd, 
			string arg_to_ymd, 
			string arg_line_group, 
			string arg_style_cd)
		{
			DataSet ds_ret; 
 
			try
			{  
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_OPSIZE_MPS_HEAD_FGA";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP"; 
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_style_cd;
				MyOraDB.Parameter_Values[5] = "";

				MyOraDB.Add_Select_Parameter(true);  
 

				//////////////////////////////////////////////////////////////////////////////
				 
				MyOraDB.ReDim_Parameter(6);  
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_OPSIZE_MPS_DETAIL_FGA";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP"; 
				MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_style_cd;
				MyOraDB.Parameter_Values[5] = "";


				MyOraDB.Add_Select_Parameter(false); 

				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null;
				return ds_ret; 
			}
			catch
			{
				return null;
			}
		}

		

		/// <summary>
		/// Select_OPSIZE_MPS : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from_ymd"></param>
		/// <param name="arg_to_ymd"></param>
		/// <param name="arg_line_group"></param>
		/// <param name="arg_cmp_cd"></param>
		/// <param name="arg_op_cd"></param>
		/// <param name="arg_area_cd"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		private DataSet Select_OPSIZE_MPS(string arg_factory, 
			string arg_from_ymd, 
			string arg_to_ymd, 
			string arg_line_group,
			string arg_cmp_cd,
			string arg_op_cd,
			string arg_area_cd,
			string arg_style_cd)
		{
			DataSet ds_ret; 
 
			try
			{  
 
				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_OPSIZE_MPS_HEAD";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP";
				MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_AREA_CD";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_cmp_cd;
				MyOraDB.Parameter_Values[5] = arg_op_cd;
				MyOraDB.Parameter_Values[6] = arg_area_cd;
				MyOraDB.Parameter_Values[7] = arg_style_cd;
				MyOraDB.Parameter_Values[8] = "";

				MyOraDB.Add_Select_Parameter(true);  
 

				//////////////////////////////////////////////////////////////////////////////
				 
				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = "PKG_SPD_WORKSHEET_SEARCH_BSC.SELECT_OPSIZE_MPS_DETAIL";
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_TO_YMD";
				MyOraDB.Parameter_Name[3] = "ARG_LINE_GROUP";
				MyOraDB.Parameter_Name[4] = "ARG_CMP_CD";
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_AREA_CD";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from_ymd;
				MyOraDB.Parameter_Values[2] = arg_to_ymd;
				MyOraDB.Parameter_Values[3] = arg_line_group;
				MyOraDB.Parameter_Values[4] = arg_cmp_cd;
				MyOraDB.Parameter_Values[5] = arg_op_cd;
				MyOraDB.Parameter_Values[6] = arg_area_cd;
				MyOraDB.Parameter_Values[7] = arg_style_cd;
				MyOraDB.Parameter_Values[8] = "";

				MyOraDB.Add_Select_Parameter(false); 

				ds_ret = MyOraDB.Exe_Select_Procedure(); 
				if(ds_ret == null) return null;
				return ds_ret; 
			}
			catch
			{
				return null;
			}
		}

		 
		#endregion     

		#region SS 를 위한 MPS 체크

		/// <summary>
		/// Select_SBM_SHIPPING_MASTER : Shipping section date search
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataTable Select_SBM_SHIPPING_MASTER(string arg_factory)
		{
			
			try
			{

				DataSet ds_ret;

				 
				string process_name = "PKG_SPO_MPS_BSC.SELECT_SBM_SHIPPING_MASTER";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true);   
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{
				return null;
			}

		}


		#endregion  

	
		#endregion

		


 


	}
}

