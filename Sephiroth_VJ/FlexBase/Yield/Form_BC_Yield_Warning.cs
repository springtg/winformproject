using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 
using C1.Win.C1FlexGrid;


namespace FlexBase.Yield
{
	public class Form_BC_Yield_Warning : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리


		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Style;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.PictureBox picb_ML;
		private System.Windows.Forms.Label lbl_BP;
		private System.Windows.Forms.Label label2;
		public COM.FSP fgrid_Warning;
		private System.Windows.Forms.DateTimePicker dpick_FromBP;
		private System.Windows.Forms.DateTimePicker dpick_ToBP;
		private System.ComponentModel.IContainer components = null;

		public Form_BC_Yield_Warning()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_BC_Yield_Warning));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.fgrid_Warning = new COM.FSP();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.dpick_ToBP = new System.Windows.Forms.DateTimePicker();
			this.dpick_FromBP = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_BP = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Warning)).BeginInit();
			this.pnl_BT.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
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
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.fgrid_Warning);
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.DockPadding.Bottom = 5;
			this.pnl_B.DockPadding.Left = 5;
			this.pnl_B.DockPadding.Right = 5;
			this.pnl_B.Location = new System.Drawing.Point(0, 56);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 586);
			this.pnl_B.TabIndex = 29;
			// 
			// fgrid_Warning
			// 
			this.fgrid_Warning.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Warning.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Warning.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Warning.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Warning.Location = new System.Drawing.Point(5, 64);
			this.fgrid_Warning.Name = "fgrid_Warning";
			this.fgrid_Warning.Size = new System.Drawing.Size(1006, 517);
			this.fgrid_Warning.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Warning.TabIndex = 663;
			this.fgrid_Warning.Click += new System.EventHandler(this.fgrid_Warning_Click);
			// 
			// pnl_BT
			// 
			this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_BT.Controls.Add(this.pnl_SearchImage);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(5, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1006, 64);
			this.pnl_BT.TabIndex = 44;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.dpick_ToBP);
			this.pnl_SearchImage.Controls.Add(this.dpick_FromBP);
			this.pnl_SearchImage.Controls.Add(this.label2);
			this.pnl_SearchImage.Controls.Add(this.lbl_BP);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1006, 59);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// dpick_ToBP
			// 
			this.dpick_ToBP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ToBP.Location = new System.Drawing.Point(526, 32);
			this.dpick_ToBP.Name = "dpick_ToBP";
			this.dpick_ToBP.Size = new System.Drawing.Size(100, 22);
			this.dpick_ToBP.TabIndex = 537;
			// 
			// dpick_FromBP
			// 
			this.dpick_FromBP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_FromBP.Location = new System.Drawing.Point(405, 32);
			this.dpick_FromBP.Name = "dpick_FromBP";
			this.dpick_FromBP.Size = new System.Drawing.Size(100, 22);
			this.dpick_FromBP.TabIndex = 536;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(505, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 21);
			this.label2.TabIndex = 535;
			this.label2.Text = "~";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_BP
			// 
			this.lbl_BP.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_BP.ImageIndex = 0;
			this.lbl_BP.ImageList = this.img_Label;
			this.lbl_BP.Location = new System.Drawing.Point(304, 32);
			this.lbl_BP.Name = "lbl_BP";
			this.lbl_BP.Size = new System.Drawing.Size(100, 21);
			this.lbl_BP.TabIndex = 533;
			this.lbl_BP.Text = "BP";
			this.lbl_BP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory
			// 
			this.cmb_Factory.AccessibleDescription = "";
			this.cmb_Factory.AccessibleName = "";
			this.cmb_Factory.AddItemCols = 0;
			this.cmb_Factory.AddItemSeparator = ';';
			this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
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
			this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(109, 32);
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
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(180, 21);
			this.cmb_Factory.TabIndex = 31;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(741, 32);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(180, 22);
			this.txt_StyleCd.TabIndex = 531;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 528;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(640, 32);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 527;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(905, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 19);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(990, 0);
			this.picb_TR.Name = "picb_TR";
			this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
			this.picb_TM.Size = new System.Drawing.Size(782, 40);
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
			this.lbl_SubTitle1.Text = "      BP Infomation";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(990, 44);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 43);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(846, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 44);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(168, 20);
			this.picb_BL.TabIndex = 22;
			this.picb_BL.TabStop = false;
			// 
			// picb_MM
			// 
			this.picb_MM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MM.Image = ((System.Drawing.Image)(resources.GetObject("picb_MM.Image")));
			this.picb_MM.Location = new System.Drawing.Point(144, 32);
			this.picb_MM.Name = "picb_MM";
			this.picb_MM.Size = new System.Drawing.Size(838, 27);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 26);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// Form_BC_Yield_Warning
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_B);
			this.Name = "Form_BC_Yield_Warning";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Warning)).EndInit();
			this.pnl_BT.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  
		 

		#endregion

		#region 멤버 메소드
 

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
			 
				//Title
				this.Text = "Yield Warning on Build Plan";
                lbl_MainTitle.Text = "Yield Warning on Build Plan";

				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정
				fgrid_Warning.Set_Grid("SBC_YIELD_WARNING", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_Warning.AllowEditing = false;
				fgrid_Warning.ExtendLastCol = false;


				//combobox setting
				Init_Control(); 
 
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable dt_ret;
 

			// 공장코드
			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
   



			dpick_FromBP.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			dpick_ToBP.CustomFormat = ClassLib.ComVar.This_SetedDateType;

			
			dpick_FromBP.Text = DateTime.Now.ToString(ClassLib.ComVar.This_SetedDateType);

			// + 10주 처리 : 3 month 로 계산
			DateTime to_bp = DateTime.Now.AddMonths(3);
			dpick_ToBP.Text = to_bp.ToString(ClassLib.ComVar.This_SetedDateType); 

			

			dt_ret.Dispose();

		}



		
		/// <summary>
		/// Select_SPB_CMP : 그리드 헤더에 Component 리스트 표시
		/// </summary>
		private void Select_SPB_CMP() 
		{

			if(cmb_Factory.SelectedIndex == -1) return;

			fgrid_Warning.Rows.Count = fgrid_Warning.Rows.Fixed;

			DataTable dt_ret;

			dt_ret = Select_SPB_CMP(cmb_Factory.SelectedValue.ToString() );
			

			fgrid_Warning.Cols.Count = (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START + dt_ret.Rows.Count;




			
			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_Warning[1, i + (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START] = dt_ret.Rows[i].ItemArray[0].ToString().Trim();

				fgrid_Warning.Cols[i + (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START].Width = 50;
				fgrid_Warning.Cols[i + (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START].TextAlign = TextAlignEnum.CenterCenter;
			}

			dt_ret.Dispose();


		}



		/// <summary>
		/// Search_Data : Warning 리스트 조회
		/// </summary>
		private void Search_Data()
		{

			if(cmb_Factory.SelectedIndex == -1) return;

			this.Cursor = Cursors.WaitCursor;

			DataTable dt_ret;
			ClassLib.ComFunction myFunction = new ClassLib.ComFunction();

			string factory = cmb_Factory.SelectedValue.ToString();
			string from_bp = myFunction.ConvertDate2DbType(dpick_FromBP.Text);
			string to_bp = myFunction.ConvertDate2DbType(dpick_ToBP.Text);
			string style_cd = txt_StyleCd.Text.Trim().Replace("-", "");

			dt_ret = Select_SBC_YIELD_WARNING(factory, from_bp, to_bp, style_cd); 


			Display_Data(dt_ret); 

			dt_ret.Dispose();

		}


		/// <summary>
		/// Display_Data : 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_Data(DataTable arg_dt)
		{

			string before_key = "", now_key = "";
			int now_row = 0;
			string now_cmp = "", db_cmp = "";
			string exist_count = "";
			int yield_yn_count = 0;
			string bom_tree = "";

			fgrid_Warning.Rows.Count = fgrid_Warning.Rows.Fixed;


			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				

				now_key = "";
				

				for(int j = 0; j < (int)ClassLib.TBSBC_YIELD_WARNING.IxTBCMP_CD; j++)
				{
					// key 에서 제외
					if(j == (int)ClassLib.TBSBC_YIELD_WARNING.IxTBYIELD_STATUS) continue;

					now_key += arg_dt.Rows[i].ItemArray[j].ToString().Trim();
				}



				if(before_key != now_key)
				{
					fgrid_Warning.Rows.Add();
					now_row = fgrid_Warning.Rows.Count - 1;


					for(int j = 0; j < (int)ClassLib.TBSBC_YIELD_WARNING.IxTBCMP_CD; j++)
					{ 
						fgrid_Warning[now_row, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString().Trim();
					}  


					before_key = now_key;

					bom_tree = "";
					yield_yn_count = 0;

				}


				db_cmp = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_WARNING.IxTBCMP_CD].ToString().Trim();

				// 반제별 채산 등록 수량 표시
				for(int j = (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START; j < fgrid_Warning.Cols.Count; j++)
				{
					now_cmp = fgrid_Warning[1, j].ToString().Trim();

					if(db_cmp == now_cmp)
					{

						exist_count = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_WARNING.IxTBEXIST_COUNT].ToString().Trim();

						if(Convert.ToInt32(exist_count) > 0) yield_yn_count++;


						exist_count = (exist_count == "0") ? "X" : "O (" + exist_count + ")";

						fgrid_Warning[now_row, j] = exist_count;

						
						
						if(bom_tree.Trim().Equals("") )
						{
							//bom_tree = db_cmp;
							bom_tree = j.ToString();
						}
						else
						{
							//bom_tree += "/" + db_cmp;
							bom_tree += "/" + j.ToString();
						}


						break;
					}

				} // end for j


				fgrid_Warning[now_row, (int)ClassLib.TBSBC_YIELD_WARNING.IxEXIST_YIELD_YN] = (yield_yn_count > 0) ? "True" : "False";

				// warning 표시
				if(yield_yn_count == 0)
				{
					fgrid_Warning.Rows[now_row].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
				}
				else
				{
					fgrid_Warning.Rows[now_row].StyleNew.Clear();
				}


				fgrid_Warning[now_row, (int)ClassLib.TBSBC_YIELD_WARNING.IxBOM_TREE] = bom_tree;
 
 
				

			} // end for i


		}



		/// <summary>
		/// Display_Style_CMP : 
		/// </summary>
		private void Display_Style_CMP()
		{ 

			int sel_row = fgrid_Warning.Selection.r1;
			string bom_tree = fgrid_Warning[sel_row, (int)ClassLib.TBSBC_YIELD_WARNING.IxBOM_TREE].ToString();

			string[] token = bom_tree.Trim().Split('/');

			for(int i = (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START; i < fgrid_Warning.Cols.Count; i++)
			{
				fgrid_Warning.GetCellRange(1, i).StyleNew.Clear(); 
			}


			for(int i = 0; i < token.Length; i++)
			{
				fgrid_Warning.GetCellRange(1, Convert.ToInt32(token[i]) ).StyleNew.BackColor = ClassLib.ComVar.ClrSel_Yellow;
				fgrid_Warning.GetCellRange(1, Convert.ToInt32(token[i]) ).StyleNew.ForeColor = Color.Black;
			}

		}



		#endregion 

		#region 이벤트 처리
 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
			  
				cmb_Factory.SelectedIndex = -1; 
				
				dpick_FromBP.Text = DateTime.Now.ToString(ClassLib.ComVar.This_SetedDateType);

				// + 10주 처리 : 3 month 로 계산
				DateTime to_bp = DateTime.Now.AddMonths(3);
				dpick_ToBP.Text = to_bp.ToString(ClassLib.ComVar.This_SetedDateType);


				txt_StyleCd.Text = "";

				fgrid_Warning.Rows.Count = fgrid_Warning.Rows.Fixed;
				fgrid_Warning.Cols.Count = (int)ClassLib.TBSBC_YIELD_WARNING.IxCMP_CD_START;


				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Search_Data();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				Select_SPB_CMP();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void fgrid_Warning_Click(object sender, System.EventArgs e)
		{
			try
			{
				// 반제 헤더에서 스타일에 대한 적용 반제 표시
				Display_Style_CMP();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{

			try
			{

				if(e.KeyCode != Keys.Enter) return;

				Search_Data();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

			

		}


		#endregion

		#region DB Connect
 
 
		/// <summary>
		/// Select_SPB_CMP : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable Select_SPB_CMP(string arg_factory)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SPB_CMP";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR"; 
 

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory; 
			MyOraDB.Parameter_Values[1] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		/// <summary>
		/// Select_SBC_YIELD_WARNING : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_frombp"></param>
		/// <param name="arg_tobp"></param>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_WARNING(string arg_factory, string arg_frombp, string arg_tobp, string arg_stylecd)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(5); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_WARNING";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_BP_NO_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_BP_NO_TO";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR"; 
 

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_frombp;
			MyOraDB.Parameter_Values[2] = arg_tobp; 
			MyOraDB.Parameter_Values[3] = arg_stylecd; 
			MyOraDB.Parameter_Values[4] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		#endregion

		

		
	

	}
}

