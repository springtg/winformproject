using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexAPS.ProdPlan
{
	public class Form_PO_LOTDaily_History : COM.APSWinForm.Form_Top
	{
		
		#region 컨트롤 정의 및 리소스 정리
		
		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
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
		private System.Windows.Forms.ImageList img_SmallLabel;
		private C1.Win.C1List.C1Combo cmb_OBSId;
		private System.Windows.Forms.Label lbl_OBSId;
		private System.Windows.Forms.Label lbl_Style;
		private C1.Win.C1List.C1Combo cmb_LOT;
		private System.Windows.Forms.Label lbl_LOT;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.Label lbl_LOTinfo;
		private System.Windows.Forms.TextBox txt_LOTInfo;
		private COM.FSP fgrid_Main;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rad_Level3;
		private System.Windows.Forms.RadioButton rad_Level2;
		private System.Windows.Forms.RadioButton rad_Level1;
		private System.ComponentModel.IContainer components = null;

		public Form_PO_LOTDaily_History()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PO_LOTDaily_History));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rad_Level3 = new System.Windows.Forms.RadioButton();
			this.rad_Level2 = new System.Windows.Forms.RadioButton();
			this.rad_Level1 = new System.Windows.Forms.RadioButton();
			this.txt_LOTInfo = new System.Windows.Forms.TextBox();
			this.lbl_LOTinfo = new System.Windows.Forms.Label();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.txt_Presto = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_Gender = new System.Windows.Forms.TextBox();
			this.lbl_Gender = new System.Windows.Forms.Label();
			this.cmb_LOT = new C1.Win.C1List.C1Combo();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.cmb_OBSId = new C1.Win.C1List.C1Combo();
			this.lbl_OBSId = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
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
			this.img_SmallLabel = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			this.lbl_MainTitle.Text = "MPS History";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.fgrid_Main);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.All = 8;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 576);
			this.pnl_B.TabIndex = 29;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 98);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 470);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:137, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:217, 250, 216;ForeColor:Black;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 43;
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.Color.Transparent;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 8);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 90);
			this.pnl_BT.TabIndex = 42;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.groupBox1);
			this.pnl_SearchImage.Controls.Add(this.txt_LOTInfo);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOTinfo);
			this.pnl_SearchImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchImage.Controls.Add(this.cmb_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.txt_Presto);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.txt_Gender);
			this.pnl_SearchImage.Controls.Add(this.lbl_Gender);
			this.pnl_SearchImage.Controls.Add(this.cmb_LOT);
			this.pnl_SearchImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchImage.Controls.Add(this.cmb_OBSId);
			this.pnl_SearchImage.Controls.Add(this.lbl_OBSId);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 85);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.rad_Level3);
			this.groupBox1.Controls.Add(this.rad_Level2);
			this.groupBox1.Controls.Add(this.rad_Level1);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F);
			this.groupBox1.Location = new System.Drawing.Point(910, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(88, 65);
			this.groupBox1.TabIndex = 544;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "View Option";
			// 
			// rad_Level3
			// 
			this.rad_Level3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level3.Location = new System.Drawing.Point(8, 46);
			this.rad_Level3.Name = "rad_Level3";
			this.rad_Level3.Size = new System.Drawing.Size(64, 16);
			this.rad_Level3.TabIndex = 2;
			this.rad_Level3.Tag = "2";
			this.rad_Level3.Text = "Version";
			this.rad_Level3.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level2
			// 
			this.rad_Level2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level2.Location = new System.Drawing.Point(8, 30);
			this.rad_Level2.Name = "rad_Level2";
			this.rad_Level2.Size = new System.Drawing.Size(68, 16);
			this.rad_Level2.TabIndex = 1;
			this.rad_Level2.Tag = "1";
			this.rad_Level2.Text = "Day";
			this.rad_Level2.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Level1
			// 
			this.rad_Level1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rad_Level1.Location = new System.Drawing.Point(8, 14);
			this.rad_Level1.Name = "rad_Level1";
			this.rad_Level1.Size = new System.Drawing.Size(48, 16);
			this.rad_Level1.TabIndex = 0;
			this.rad_Level1.Tag = "0";
			this.rad_Level1.Text = "LOT";
			this.rad_Level1.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// txt_LOTInfo
			// 
			this.txt_LOTInfo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOTInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOTInfo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_LOTInfo.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_LOTInfo.Location = new System.Drawing.Point(642, 58);
			this.txt_LOTInfo.MaxLength = 100;
			this.txt_LOTInfo.Name = "txt_LOTInfo";
			this.txt_LOTInfo.ReadOnly = true;
			this.txt_LOTInfo.Size = new System.Drawing.Size(221, 21);
			this.txt_LOTInfo.TabIndex = 543;
			this.txt_LOTInfo.Text = "";
			// 
			// lbl_LOTinfo
			// 
			this.lbl_LOTinfo.ImageIndex = 0;
			this.lbl_LOTinfo.ImageList = this.img_Label;
			this.lbl_LOTinfo.Location = new System.Drawing.Point(541, 58);
			this.lbl_LOTinfo.Name = "lbl_LOTinfo";
			this.lbl_LOTinfo.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOTinfo.TabIndex = 542;
			this.lbl_LOTinfo.Text = "Order/ LOT Qty";
			this.lbl_LOTinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.White;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_LOT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_LOT.Location = new System.Drawing.Point(642, 36);
			this.txt_LOT.MaxLength = 10;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.Size = new System.Drawing.Size(90, 21);
			this.txt_LOT.TabIndex = 541;
			this.txt_LOT.Text = "";
			this.txt_LOT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_LOT_KeyUp);
			// 
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 17;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 17;
			this.cmb_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(401, 36);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"" +
				"18\" ColumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Hor" +
				"izontalScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width" +
				">17</Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyl" +
				"e parent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><Fo" +
				"oterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" " +
				"/><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highli" +
				"ghtRow\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyl" +
				"e parent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=" +
				"\"Style10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal" +
				"\" me=\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=" +
				"\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" m" +
				"e=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"" +
				"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Hi" +
				"ghlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"O" +
				"ddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" m" +
				"e=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" +
				"ayout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(130, 21);
			this.cmb_StyleCd.TabIndex = 537;
			this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
			// 
			// txt_Presto
			// 
			this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Presto.Location = new System.Drawing.Point(401, 58);
			this.txt_Presto.MaxLength = 100;
			this.txt_Presto.Name = "txt_Presto";
			this.txt_Presto.ReadOnly = true;
			this.txt_Presto.Size = new System.Drawing.Size(130, 21);
			this.txt_Presto.TabIndex = 540;
			this.txt_Presto.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(320, 36);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 539;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// txt_Gender
			// 
			this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gender.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Gender.Location = new System.Drawing.Point(320, 58);
			this.txt_Gender.MaxLength = 100;
			this.txt_Gender.Name = "txt_Gender";
			this.txt_Gender.ReadOnly = true;
			this.txt_Gender.Size = new System.Drawing.Size(80, 21);
			this.txt_Gender.TabIndex = 536;
			this.txt_Gender.Text = "";
			// 
			// lbl_Gender
			// 
			this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Gender.ImageIndex = 0;
			this.lbl_Gender.ImageList = this.img_Label;
			this.lbl_Gender.Location = new System.Drawing.Point(219, 58);
			this.lbl_Gender.Name = "lbl_Gender";
			this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender.TabIndex = 538;
			this.lbl_Gender.Text = "Gender/ Presto";
			this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LOT
			// 
			this.cmb_LOT.AddItemCols = 0;
			this.cmb_LOT.AddItemSeparator = ';';
			this.cmb_LOT.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LOT.Caption = "";
			this.cmb_LOT.CaptionHeight = 17;
			this.cmb_LOT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LOT.ColumnCaptionHeight = 18;
			this.cmb_LOT.ColumnFooterHeight = 18;
			this.cmb_LOT.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LOT.ContentHeight = 17;
			this.cmb_LOT.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LOT.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LOT.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOT.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LOT.EditorHeight = 17;
			this.cmb_LOT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOT.GapHeight = 2;
			this.cmb_LOT.ItemHeight = 15;
			this.cmb_LOT.Location = new System.Drawing.Point(733, 36);
			this.cmb_LOT.MatchEntryTimeout = ((long)(2000));
			this.cmb_LOT.MaxDropDownItems = ((short)(5));
			this.cmb_LOT.MaxLength = 32767;
			this.cmb_LOT.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LOT.Name = "cmb_LOT";
			this.cmb_LOT.PartialRightColumn = false;
			this.cmb_LOT.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LOT.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LOT.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LOT.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LOT.Size = new System.Drawing.Size(130, 21);
			this.cmb_LOT.TabIndex = 202;
			this.cmb_LOT.SelectedValueChanged += new System.EventHandler(this.cmb_LOT_SelectedValueChanged);
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(541, 36);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 201;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_OBSId
			// 
			this.cmb_OBSId.AddItemCols = 0;
			this.cmb_OBSId.AddItemSeparator = ';';
			this.cmb_OBSId.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBSId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBSId.Caption = "";
			this.cmb_OBSId.CaptionHeight = 17;
			this.cmb_OBSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBSId.ColumnCaptionHeight = 18;
			this.cmb_OBSId.ColumnFooterHeight = 18;
			this.cmb_OBSId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBSId.ContentHeight = 17;
			this.cmb_OBSId.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBSId.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBSId.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBSId.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBSId.EditorHeight = 17;
			this.cmb_OBSId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OBSId.GapHeight = 2;
			this.cmb_OBSId.ItemHeight = 15;
			this.cmb_OBSId.Location = new System.Drawing.Point(111, 58);
			this.cmb_OBSId.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBSId.MaxDropDownItems = ((short)(5));
			this.cmb_OBSId.MaxLength = 32767;
			this.cmb_OBSId.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBSId.Name = "cmb_OBSId";
			this.cmb_OBSId.PartialRightColumn = false;
			this.cmb_OBSId.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OBSId.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBSId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBSId.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBSId.Size = new System.Drawing.Size(96, 21);
			this.cmb_OBSId.TabIndex = 196;
			this.cmb_OBSId.SelectedValueChanged += new System.EventHandler(this.cmb_OBSId_SelectedValueChanged);
			// 
			// lbl_OBSId
			// 
			this.lbl_OBSId.ImageIndex = 1;
			this.lbl_OBSId.ImageList = this.img_Label;
			this.lbl_OBSId.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBSId.Name = "lbl_OBSId";
			this.lbl_OBSId.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBSId.TabIndex = 195;
			this.lbl_OBSId.Text = "DPO";
			this.lbl_OBSId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.ImageIndex = 1;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(219, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 34;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(96, 21);
			this.cmb_Factory.TabIndex = 33;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
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
			this.picb_MR.Location = new System.Drawing.Point(985, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 45);
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
			this.picb_BR.Location = new System.Drawing.Point(984, 69);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 67);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 65);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 42);
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
			this.picb_MM.Size = new System.Drawing.Size(832, 50);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// img_SmallLabel
			// 
			this.img_SmallLabel.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_SmallLabel.ImageSize = new System.Drawing.Size(50, 21);
			this.img_SmallLabel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallLabel.ImageStream")));
			this.img_SmallLabel.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Form_PO_LOTDaily_History
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_PO_LOTDaily_History";
			this.Text = "MPS History";
			this.Load += new System.EventHandler(this.Form_PO_LOTDaily_History_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
   
		#region 변수 정의

 
		private COM.OraDB MyOraDB = new COM.OraDB(); 



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
				this.Text = "MPS History";
				lbl_MainTitle.Text = "MPS History"; 
 

				fgrid_Main.Set_Grid("SPO_LOT_DAILY_HISTORY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Main.ExtendLastCol = false;
				fgrid_Main.AllowEditing = false;
				//fgrid_Main.Font = new Font("Verdana", 7);



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



			rad_Level3.Checked = true;



			// Factory Combobox Add Items
			DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			dt_ret.Dispose();

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

 

		}  



		
		/// <summary>
		/// Init_Combo_Style : 
		/// </summary>
		private void Init_Combo_Style()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_OBSId.SelectedIndex == -1) return;

 

			//-------------------------------------------------------------------------
			// 기타 콘트롤 초기화 
			cmb_StyleCd.SelectedIndex = -1;
			txt_Gender.Text = ""; 
			txt_Presto.Text = "";

			cmb_LOT.SelectedIndex = -1;
			txt_LOT.Text = "";
			txt_LOTInfo.Text = "";
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
			//-------------------------------------------------------------------------

			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id = cmb_OBSId.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ");

			DataTable dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(factory, obs_id, style_cd); 
				 
			
			//ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 


			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComCtl.Set_ComboList_AddItem_Multi(dt_ret, cmb_StyleCd, new int[]{0, 1, 2, 3, 4}, false);

			string[] cmb_titles = new string[] {"Code", "Name", "Gen", "Presto", "Model"};
			int[] cmb_width = new int[] {100, 180, 0, 0, 0};
			bool[] cmb_visible = new bool[] {true, true, false, false, false}; 

			ClassLib.ComCtl.SetComboStyle(cmb_StyleCd, cmb_titles, cmb_width, cmb_visible, "Name"); 
			cmb_LOT.DropDownWidth = 300;






			string stylecd = "";
			int exist_index = -1;

			stylecd = txt_StyleCd.Text.Trim();

			exist_index = txt_StyleCd.Text.IndexOf("-", 0);

			if(exist_index == -1 && stylecd.Length == 9)
			{
				stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
			}
 
			cmb_StyleCd.SelectedValue = stylecd;

			dt_ret.Dispose();

		}





		/// <summary>
		/// Init_Combo_LOT : 
		/// </summary>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		private void Init_Combo_LOT(string arg_lot_no, string arg_lot_seq)
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1 || cmb_OBSId.SelectedIndex == -1) return;
  
			string factory = cmb_Factory.SelectedValue.ToString();
			string obs_id = cmb_OBSId.SelectedValue.ToString();
			string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");

			DataTable dt_ret = ClassLib.ComFunction.Select_SPO_LOT_COMBO(factory, obs_id, style_cd, arg_lot_no, arg_lot_seq);

			//0 : lot_no, 1 : lot_seq, 2 : lot, 3 : lot_qty, 4 : loss_qty, 5 : tot_qty, 6 : order_qty, 7 : order_loss_qty, 8 : order_tot_qty
			ClassLib.ComCtl.Set_ComboList_AddItem_Multi(dt_ret, cmb_LOT, new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8}, true);

			string[] cmb_titles = new string[] {"LOT No", "LOT Seq", "LOT", "LOT Qty", "Loss Qty", "TOT Qty", "Order Qty", "Order Loss Qty", "Order TOT Qty"};
			int[] cmb_width = new int[] {0, 0, 100, 0, 0, 0, 0, 0, 0};
			bool[] cmb_visible = new bool[] {false, false, true, false, false, false, false, false, false}; 

			ClassLib.ComCtl.SetComboStyle(cmb_LOT, cmb_titles, cmb_width, cmb_visible, "LOT"); 
			cmb_LOT.DropDownWidth = cmb_LOT.Size.Width;


			dt_ret.Dispose();


		}






		#endregion
		  
		#region 조회

 
		/// <summary>
		/// 
		/// </summary>
		private void Display_Data()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;
 

				if(cmb_Factory.SelectedIndex == -1 || cmb_OBSId.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 
 
				string factory = cmb_Factory.SelectedValue.ToString(); 
				string obs_id = cmb_OBSId.SelectedValue.ToString();
				string style_cd = cmb_StyleCd.SelectedValue.ToString().Replace("-", "");
				string lot_no = " "; 
				string lot_seq = " ";

				if(cmb_LOT.SelectedIndex != -1 && ! cmb_LOT.SelectedValue.ToString().Trim().Equals("") )
				{  
					lot_no = cmb_LOT.Columns[0].Text;
					lot_seq = cmb_LOT.Columns[1].Text;
				}



				DataTable dt_ret = Select_MPS_HISTORY(factory, obs_id, style_cd, lot_no, lot_seq);
  

				fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

				if(dt_ret.Rows.Count == 0)
				{
					return; 
				}
			

			
				int level = 0;  

				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
 

					level = Convert.ToInt32(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_LEVEL - 1].ToString() );  
					fgrid_Main.Rows.InsertNode(fgrid_Main.Rows.Count, level);  

					for(int j = 1; j < fgrid_Main.Cols.Count; j++)
					{
						
						if(dt_ret.Rows[i].ItemArray[j - 1] == null) continue; 
						
						if( j == (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_LEVEL )
						{
							fgrid_Main[fgrid_Main.Rows.Count - 1, j] = dt_ret.Rows[i].ItemArray[j - 1].ToString(); 
						}
						else
						{
							fgrid_Main[fgrid_Main.Rows.Count - 1, j] 
								= (dt_ret.Rows[i].ItemArray[j - 1].ToString() == "0") ? "" : dt_ret.Rows[i].ItemArray[j - 1].ToString(); 
						}

					} // end for j
	

 
					
					if(level == 0)  // lot
					{
						fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st; 
					}
					else if(level == 1)  // day_seq
					{
						fgrid_Main.Rows[fgrid_Main.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd; 
					}



				} // end for i 
			
  
				fgrid_Main.Tree.Column = (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_DESC;
			
				rad_Level3.Checked = true;
				fgrid_Main.Tree.Show(2); 
  

				Display_Version_Check();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}



		}



		/// <summary>
		/// Display_Version_Check : max version, max-1 version 데이터 다른 경우 표시
		/// </summary>
		private void Display_Version_Check()
		{

			int row_max_version = -1;


			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{

				// day_seq 일때만 처리
				if( Convert.ToInt32( fgrid_Main[i, (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_LEVEL].ToString() ) != 1) continue;

				if( fgrid_Main.Rows[i].Node.GetNode(NodeTypeEnum.FirstChild) == null) continue;


				row_max_version = i + 1;

				if(row_max_version > fgrid_Main.Rows.Count - 1 || row_max_version + 1 > fgrid_Main.Rows.Count - 1) continue;


				if( Convert.ToInt32( fgrid_Main[row_max_version, (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_LEVEL].ToString() ) != 2) continue;
				if( Convert.ToInt32( fgrid_Main[row_max_version + 1, (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxTREE_LEVEL].ToString() ) != 2) continue;


				for(int j = (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxLINE_CD; j <= (int)ClassLib.TBSPO_MPS_HISTORY_BSC.IxREMARKS; j++)
				{

					fgrid_Main[row_max_version, j] = (fgrid_Main[row_max_version, j] == null) ? "" : fgrid_Main[row_max_version, j].ToString();
					fgrid_Main[row_max_version + 1, j] = (fgrid_Main[row_max_version + 1, j] == null) ? "" : fgrid_Main[row_max_version + 1, j].ToString();

 
					 
					if(fgrid_Main[row_max_version, j].ToString().Trim() == fgrid_Main[row_max_version + 1, j].ToString().Trim() ) continue;

					CellStyle cellst = fgrid_Main.Styles.Add("CHANGE" + row_max_version.ToString() + j.ToString(), fgrid_Main.GetCellRange(row_max_version, j).Style);
					cellst.ForeColor = ClassLib.ComVar.ClrWarning;
					cellst.BackColor = ClassLib.ComVar.ClrWarning_Back;
					cellst.Font = new Font("Verdana", 8, FontStyle.Bold);

					fgrid_Main.SetCellStyle(row_max_version, j, cellst);
					fgrid_Main.SetCellStyle(row_max_version + 1, j, cellst);

				} // end for j
 

			} // end for i
		}



		#endregion

		#region 툴바 이벤트 메서드


		/// <summary>
		/// Event_Tbtn_New : 
		/// </summary>
		private void Event_Tbtn_New()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_OBSId.SelectedIndex = -1;
			cmb_StyleCd.SelectedIndex = -1;
			txt_StyleCd.Text = "";
			txt_Gender.Text= "";
			txt_Presto.Text = "";
			cmb_LOT.SelectedIndex = -1;
			txt_LOT.Text = "";
			txt_LOTInfo.Text = "";

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}


		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{ 
			 
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			if(cmb_Factory.SelectedIndex == -1 || cmb_OBSId.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 
 
			Display_Data(); 
			
		}


		/// <summary>
		/// Event_Tbtn_Print : 
		/// </summary>
		private void Event_Tbtn_Print()
		{

  
		}
 

		#endregion

		#region 그리드 이벤트 메서드
 
  
		#endregion

		#region 버튼 및 기타 이벤트 메서드

	
		/// <summary>
		/// Event_SelectedValueChanged_cmb_Factory : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_Factory()
		{

			if(cmb_Factory.SelectedIndex == -1) return; 

			string factory = cmb_Factory.SelectedValue.ToString();

			DataTable dt_ret = ClassLib.ComFunction.Select_DPO(factory, "P");  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OBSId, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  
			dt_ret.Dispose();

			if(cmb_OBSId.ListCount != 0) cmb_OBSId.SelectedIndex = 0; 


		}


		/// <summary>
		/// Event_SelectedValueChanged_cmb_OBSId : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_OBSId()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_OBSId.SelectedIndex == -1) return;

			  
			cmb_StyleCd.SelectedIndex = -1;
			txt_StyleCd.Text = "";
			txt_Gender.Text = ""; 
			txt_Presto.Text = "";

			cmb_LOT.SelectedIndex = -1;
			txt_LOT.Text = "";
			txt_LOTInfo.Text = "";
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
			

			// style list
			Init_Combo_Style();
		    
			
			// lot list
			string[] token = txt_LOT.Text.Split('-');

			string lot_no = " ";
			string lot_seq = " ";


			if(token.Length == 1)
			{
				lot_no = token[0];
				lot_seq = " ";
			}
			else
			{
				lot_no = token[0];
				lot_seq = token[1];
			}

			
			Init_Combo_LOT(lot_no, lot_seq);

			cmb_LOT.SelectedValue = txt_LOT.Text;




		}



		/// <summary>
		/// Event_KeyUp_txt_StyleCd : 
		/// </summary>
		/// <param name="e"></param>
		private void Event_KeyUp_txt_StyleCd(System.Windows.Forms.KeyEventArgs e)
		{
		
			if(e.KeyCode != Keys.Enter) return;

			Init_Combo_Style();
		}



		/// <summary>
		/// Event_SelectedValueChanged_cmb_StyleCd : 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_StyleCd()
		{

			if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return;
  

			//---------------------------------------------------------------------------------------------------
			// 기타 콘트롤 초기화  
			txt_Gender.Text = ""; 
			txt_Presto.Text = "";

			cmb_LOT.SelectedIndex = -1;
			txt_LOT.Text = "";
			txt_LOTInfo.Text = "";
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed; 
			//---------------------------------------------------------------------------------------------------

				

			// 0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name

			txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();
			txt_Gender.Text = cmb_StyleCd.Columns[2].Text; 
			txt_Presto.Text = cmb_StyleCd.Columns[3].Text;

 

			
			// lot list 
			string lot_no = " ";
			string lot_seq = " ";
			Init_Combo_LOT(lot_no, lot_seq);


		}


		private void Event_KeyUp_txt_LOT(System.Windows.Forms.KeyEventArgs e)
		{


			if(e.KeyCode != Keys.Enter) return; 
 
 
			cmb_LOT.SelectedIndex = -1;
			txt_LOT.Text = "";
			txt_LOTInfo.Text = "";
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;  


			// lot list
			string[] token = txt_LOT.Text.Split('-');

			string lot_no = " ";
			string lot_seq = " ";


			if(token.Length == 1)
			{
				lot_no = token[0];
				lot_seq = " ";
			}
			else
			{
				lot_no = token[0];
				lot_seq = token[1];
			}

			
			Init_Combo_LOT(lot_no, lot_seq);

			cmb_LOT.SelectedValue = txt_LOT.Text;



		}


		
		/// <summary>
		/// 
		/// </summary>
		private void Event_SelectedValueChanged_cmb_LOT()
		{
			
			if(cmb_LOT.SelectedIndex == -1) return; 


			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;  


			//0 : lot_no, 1 : lot_seq, 2 : lot, 3 : lot_qty, 4 : loss_qty, 5 : tot_qty, 6 : order_qty, 7 : order_loss_qty, 8 : order_tot_qty

			txt_LOT.Text = cmb_LOT.Columns[2].Text;

//			// lot_qty + loss_qty = tot_qty
//			txt_LOTInfo.Text = cmb_LOT.Columns[3].Text + " + " + cmb_LOT.Columns[4].Text + " = " + cmb_LOT.Columns[5].Text; 
  

			// order qty/ lot qty
			txt_LOTInfo.Text = "order : " + cmb_LOT.Columns[8].Text + " / " + "LOT : " + cmb_LOT.Columns[5].Text;



			Event_Tbtn_Search();



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

		private void Form_PO_LOTDaily_History_Load(object sender, System.EventArgs e)
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
  
		private void cmb_OBSId_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				Event_SelectedValueChanged_cmb_OBSId();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_OBSId", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			
			try
			{
				 Event_KeyUp_txt_StyleCd(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_KeyUp_txt_StyleCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				Event_SelectedValueChanged_cmb_StyleCd();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_StyleCd", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txt_LOT_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				Event_KeyUp_txt_LOT(e);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_KeyUp_txt_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_LOT_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				Event_SelectedValueChanged_cmb_LOT();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_SelectedValueChanged_cmb_LOT", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		} 

		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				RadioButton src = sender as RadioButton; 
				fgrid_Main.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) );

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}


		#endregion   

		#region 컨텍스트 메뉴 이벤트


	 

		#endregion


		#endregion
		 
		#region 디비 연결


		#region 콤보
  
		#endregion

		#region 조회

		
		/// <summary>
		/// Select_MPS_HISTORY : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns> 
		private DataTable Select_MPS_HISTORY(string arg_factory,
			string arg_obs_id,
			string arg_style_cd,
			string arg_lot_no,
			string arg_lot_seq)
		{
			DataSet ds_ret;

			try
			{ 
 
				string process_name = "PKG_SPO_MPS_HISTORY_BSC.SELECT_MPS_HISTORY";

				MyOraDB.ReDim_Parameter(6); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_obs_id; 
				MyOraDB.Parameter_Values[2] = arg_style_cd; 
				MyOraDB.Parameter_Values[3] = arg_lot_no;
				MyOraDB.Parameter_Values[4] = arg_lot_seq;   
				MyOraDB.Parameter_Values[5] = ""; 

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

