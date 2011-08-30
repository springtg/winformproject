using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;


namespace FlexOrder.ExpBP
{
	public class Form_EB_HIST : COM.OrderWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnl_save_image;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_Region;
		private System.Windows.Forms.CheckBox chk_BP_NO;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Region;
		private System.Windows.Forms.Label lbl_BP_NO;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.Windows.Forms.DateTimePicker dpick_BP_NO;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pictureBox2;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.TextBox txt_OBS_ID;
		private C1.Win.C1List.C1Combo cmb_Del_Month;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;

		public Form_EB_HIST()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_HIST));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnl_save_image = new System.Windows.Forms.Panel();
			this.txt_OBS_ID = new System.Windows.Forms.TextBox();
			this.cmb_Del_Month = new C1.Win.C1List.C1Combo();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.txt_Region = new System.Windows.Forms.TextBox();
			this.chk_BP_NO = new System.Windows.Forms.CheckBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_Region = new System.Windows.Forms.Label();
			this.lbl_BP_NO = new System.Windows.Forms.Label();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.dpick_BP_NO = new System.Windows.Forms.DateTimePicker();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_save_image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_Month)).BeginInit();
			this.panel1.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(712, 3);
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
			this.stbar.Size = new System.Drawing.Size(1000, 22);
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
			this.pnl_Search.Controls.Add(this.panel2);
			this.pnl_Search.Controls.Add(this.panel1);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1000, 148);
			this.pnl_Search.TabIndex = 43;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pnl_save_image);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(496, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(496, 132);
			this.panel2.TabIndex = 130;
			// 
			// pnl_save_image
			// 
			this.pnl_save_image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_save_image.Controls.Add(this.txt_OBS_ID);
			this.pnl_save_image.Controls.Add(this.cmb_Del_Month);
			this.pnl_save_image.Controls.Add(this.txt_Style);
			this.pnl_save_image.Controls.Add(this.txt_Region);
			this.pnl_save_image.Controls.Add(this.chk_BP_NO);
			this.pnl_save_image.Controls.Add(this.lbl_Style);
			this.pnl_save_image.Controls.Add(this.lbl_Region);
			this.pnl_save_image.Controls.Add(this.lbl_BP_NO);
			this.pnl_save_image.Controls.Add(this.lbl_OBS_ID);
			this.pnl_save_image.Controls.Add(this.dpick_BP_NO);
			this.pnl_save_image.Controls.Add(this.pictureBox3);
			this.pnl_save_image.Controls.Add(this.pictureBox4);
			this.pnl_save_image.Controls.Add(this.label5);
			this.pnl_save_image.Controls.Add(this.pictureBox6);
			this.pnl_save_image.Controls.Add(this.pictureBox8);
			this.pnl_save_image.Controls.Add(this.pictureBox9);
			this.pnl_save_image.Controls.Add(this.pictureBox14);
			this.pnl_save_image.Controls.Add(this.pictureBox15);
			this.pnl_save_image.Controls.Add(this.pictureBox16);
			this.pnl_save_image.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_save_image.Location = new System.Drawing.Point(0, 0);
			this.pnl_save_image.Name = "pnl_save_image";
			this.pnl_save_image.Size = new System.Drawing.Size(496, 132);
			this.pnl_save_image.TabIndex = 128;
			// 
			// txt_OBS_ID
			// 
			this.txt_OBS_ID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_ID.Location = new System.Drawing.Point(201, 36);
			this.txt_OBS_ID.MaxLength = 100;
			this.txt_OBS_ID.Name = "txt_OBS_ID";
			this.txt_OBS_ID.ReadOnly = true;
			this.txt_OBS_ID.Size = new System.Drawing.Size(120, 20);
			this.txt_OBS_ID.TabIndex = 182;
			this.txt_OBS_ID.Text = "";
			// 
			// cmb_Del_Month
			// 
			this.cmb_Del_Month.AddItemCols = 0;
			this.cmb_Del_Month.AddItemSeparator = ';';
			this.cmb_Del_Month.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Del_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Del_Month.Caption = "";
			this.cmb_Del_Month.CaptionHeight = 17;
			this.cmb_Del_Month.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Del_Month.ColumnCaptionHeight = 18;
			this.cmb_Del_Month.ColumnFooterHeight = 18;
			this.cmb_Del_Month.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Del_Month.ContentHeight = 16;
			this.cmb_Del_Month.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Del_Month.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Del_Month.EditorFont = new System.Drawing.Font("Verdana", 8.2F);
			this.cmb_Del_Month.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Del_Month.EditorHeight = 16;
			this.cmb_Del_Month.Font = new System.Drawing.Font("Verdana", 8.2F);
			this.cmb_Del_Month.GapHeight = 2;
			this.cmb_Del_Month.ItemHeight = 15;
			this.cmb_Del_Month.Location = new System.Drawing.Point(111, 36);
			this.cmb_Del_Month.MatchEntryTimeout = ((long)(2000));
			this.cmb_Del_Month.MaxDropDownItems = ((short)(5));
			this.cmb_Del_Month.MaxLength = 32767;
			this.cmb_Del_Month.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Del_Month.Name = "cmb_Del_Month";
			this.cmb_Del_Month.PartialRightColumn = false;
			this.cmb_Del_Month.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.2pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight" +
				";}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:" +
				"True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:" +
				"Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Lis" +
				"t.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHei" +
				"ght=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"" +
				"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScroll" +
				"Bar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me" +
				"=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Fo" +
				"oter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pare" +
				"nt=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" " +
				"/><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me" +
				"=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selecte" +
				"dStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1" +
				".Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><St" +
				"yle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style " +
				"parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style p" +
				"arent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style" +
				" parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pare" +
				"nt=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedS" +
				"tyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layo" +
				"ut><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Del_Month.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Del_Month.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Del_Month.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Del_Month.Size = new System.Drawing.Size(89, 20);
			this.cmb_Del_Month.TabIndex = 181;
			this.cmb_Del_Month.TextChanged += new System.EventHandler(this.cmb_Del_Month_TextChanged);
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.White;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(111, 105);
			this.txt_Style.MaxLength = 100;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(210, 20);
			this.txt_Style.TabIndex = 180;
			this.txt_Style.Text = "";
			// 
			// txt_Region
			// 
			this.txt_Region.BackColor = System.Drawing.Color.White;
			this.txt_Region.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Region.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Region.Location = new System.Drawing.Point(111, 82);
			this.txt_Region.MaxLength = 100;
			this.txt_Region.Name = "txt_Region";
			this.txt_Region.Size = new System.Drawing.Size(210, 20);
			this.txt_Region.TabIndex = 179;
			this.txt_Region.Text = "";
			// 
			// chk_BP_NO
			// 
			this.chk_BP_NO.BackColor = System.Drawing.Color.White;
			this.chk_BP_NO.Location = new System.Drawing.Point(324, 59);
			this.chk_BP_NO.Name = "chk_BP_NO";
			this.chk_BP_NO.Size = new System.Drawing.Size(12, 21);
			this.chk_BP_NO.TabIndex = 172;
			this.chk_BP_NO.CheckedChanged += new System.EventHandler(this.chk_BP_NO_CheckedChanged);
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 105);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 171;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Region
			// 
			this.lbl_Region.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Region.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Region.ImageIndex = 0;
			this.lbl_Region.ImageList = this.img_Label;
			this.lbl_Region.Location = new System.Drawing.Point(10, 82);
			this.lbl_Region.Name = "lbl_Region";
			this.lbl_Region.Size = new System.Drawing.Size(100, 21);
			this.lbl_Region.TabIndex = 170;
			this.lbl_Region.Text = "Region";
			this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_BP_NO
			// 
			this.lbl_BP_NO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BP_NO.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BP_NO.ImageIndex = 0;
			this.lbl_BP_NO.ImageList = this.img_Label;
			this.lbl_BP_NO.Location = new System.Drawing.Point(10, 59);
			this.lbl_BP_NO.Name = "lbl_BP_NO";
			this.lbl_BP_NO.Size = new System.Drawing.Size(100, 21);
			this.lbl_BP_NO.TabIndex = 169;
			this.lbl_BP_NO.Text = "Lasting Week";
			this.lbl_BP_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 0;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(10, 36);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 168;
			this.lbl_OBS_ID.Text = "Delivery Month";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_BP_NO
			// 
			this.dpick_BP_NO.CustomFormat = "yyyyMMdd";
			this.dpick_BP_NO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_BP_NO.Location = new System.Drawing.Point(111, 58);
			this.dpick_BP_NO.Name = "dpick_BP_NO";
			this.dpick_BP_NO.Size = new System.Drawing.Size(212, 20);
			this.dpick_BP_NO.TabIndex = 163;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(165, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(320, 30);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(483, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(13, 30);
			this.pictureBox4.TabIndex = 1;
			this.pictureBox4.TabStop = false;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.SystemColors.Highlight;
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 30);
			this.label5.TabIndex = 0;
			this.label5.Text = "      Build Plan Info.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(465, 30);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(31, 86);
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(471, 102);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(25, 30);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(0, 24);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(32, 97);
			this.pictureBox9.TabIndex = 3;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 102);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(72, 40);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(72, 102);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(408, 30);
			this.pictureBox15.TabIndex = 9;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.Color.Navy;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(32, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(448, 100);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pnl_Search1_Image);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.DockPadding.Right = 4;
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(488, 132);
			this.panel1.TabIndex = 128;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox13);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Search1_Image.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(484, 132);
			this.pnl_Search1_Image.TabIndex = 1;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 163;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(300, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
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
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 38);
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
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(462, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Search Date";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(465, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 86);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(0, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(32, 97);
			this.pictureBox10.TabIndex = 3;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(394, 118);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(90, 14);
			this.pictureBox11.TabIndex = 8;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 118);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(396, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.Color.Blue;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 118);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(80, 14);
			this.pictureBox13.TabIndex = 6;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.Color.Navy;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(32, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(436, 100);
			this.pictureBox7.TabIndex = 4;
			this.pictureBox7.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 211);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1000, 433);
			this.pnl_Body.TabIndex = 47;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(984, 433);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 36;
			// 
			// Form_EB_HIST
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1000, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EB_HIST";
			this.Text = "Build Plan History";
			this.Load += new System.EventHandler(this.Form_EB_History_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_save_image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Del_Month)).EndInit();
			this.panel1.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
   
		private int _Rowfixed;    
		COM.OraDB MyOraDB = new COM.OraDB();     

		#endregion 	

		#region 멤버 메서드 

		private void Init_Form()
		{ 
				
			//Title
			this.Text = "Build Plan History";
			this.lbl_MainTitle.Text = "BP History"; 
			ClassLib.ComFunction.SetLangDic(this);


			#region 버튼 권한
//
//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//
//				tbtn_Delete.Enabled = false; tbtn_Print.Enabled  = false;
//			}
//			catch
//			{
//			}

			#endregion


			DataTable dt_list; 
			DateTime CurDate = DateTime.Now;
			int i;
			
			// 그리드 설정
			fgrid_Main.Set_Grid( "SEM_BP", "4", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;	
			fgrid_Main.Font  = new Font("Verdana",8);
	
			// 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			///del_month
			cmb_Del_Month.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			cmb_Del_Month.ClearItems();
			cmb_Del_Month.ExtendRightColumn = true;
			cmb_Del_Month.ColumnHeaders = false;
			cmb_Del_Month.AddItem(" ");
			for(i = -5; i <= 5; i++)
				cmb_Del_Month.AddItem( CurDate.AddMonths(i).ToString("yyyyMM") + "01" );
			cmb_Del_Month.MaxDropDownItems = Convert.ToInt16(cmb_Del_Month.ListCount);

			dpick_BP_NO.Enabled = false;
			chk_BP_NO.Checked   = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Save.Enabled   = false;

			// set up Subtotal
			fgrid_Main.Tree.Column = 1;
			CellStyle s = fgrid_Main.Styles[CellStyleEnum.Subtotal0];
			s.BackColor = Color.YellowGreen;
			s.ForeColor = Color.White;
			s.Font = new Font(fgrid_Main.Font, FontStyle.Bold);
			s = fgrid_Main.Styles[CellStyleEnum.Subtotal1];
			s.BackColor = Color.Gray;
			s.ForeColor = Color.Black;
			s = fgrid_Main.Styles[CellStyleEnum.Subtotal2];
			s.BackColor = Color.LightGray;
			s.ForeColor = Color.Black;

			chk_BP_NO.Enabled = false;
		}

		/// <summary>
		/// Select_BP_List : Build Plan 리스트 찾기 
		/// </summary>
		private DataTable Select_BP_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_BP.SELECT_SEM_BP_HISTORY";

			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DEL_MONTH";
			MyOraDB.Parameter_Name[2] = "ARG_BP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_REGION";
			MyOraDB.Parameter_Name[4] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(cmb_Del_Month.Text, " ");
			string sBP_NO;
			if (chk_BP_NO.Checked) sBP_NO = Convert.ToDateTime(dpick_BP_NO.Text).ToString("yyyyMMdd");
			else                   sBP_NO = " ";
			MyOraDB.Parameter_Values[2] = sBP_NO;
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_Region, " ");
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_TextBox(txt_Style,  " ");
			MyOraDB.Parameter_Values[5] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}

		/// <summary>
		/// Display_fgrid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_fgrid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			int iPRD_QTY = (int)ClassLib.TBSEM_BP_HISTORY.IxPRD_QTY;
			int iDel_Month = (int)ClassLib.TBSEM_BP_HISTORY.IxDEL_MONTH;
			int iOBS_ID    = (int)ClassLib.TBSEM_BP_HISTORY.IxOBS_ID;
			int iStyle     = (int)ClassLib.TBSEM_BP_HISTORY.IxSTYLE_CD;
			int iBP_NO     = (int)ClassLib.TBSEM_BP_HISTORY.IxBP_NO;
			int iRegion    = (int)ClassLib.TBSEM_BP_HISTORY.IxREGION;

			int iTOTQty=0;
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = "";

				iTOTQty += Convert.ToInt32(arg_fgrid[arg_fgrid.Rows.Count-1, iPRD_QTY].ToString());

				string sDel_Month = fgrid_Main[i+_Rowfixed, (int)ClassLib.TBSEM_BP_HISTORY.IxDEL_MONTH].ToString();
				string sOBS_ID    = ClassLib.ComFunction.Convert_ToDate(sDel_Month).AddMonths(-2).ToString("yyMM") + sDel_Month.Substring(4,2);

				fgrid_Main[i+_Rowfixed, (int)ClassLib.TBSEM_BP_HISTORY.IxOBS_ID] = sOBS_ID;
			} 
		
			arg_fgrid.SubtotalPosition = SubtotalPositionEnum.BelowData;
//
			arg_fgrid.Subtotal(AggregateEnum.Sum, 0,         -1, iPRD_QTY, "Grand Total");
			arg_fgrid.Subtotal(AggregateEnum.Sum, 1, iDel_Month, iPRD_QTY, "Total for {0}");
     		arg_fgrid.Subtotal(AggregateEnum.Sum, 2,     iStyle, iPRD_QTY, "Total for {0}");


			fgrid_Main.AllowMerging = AllowMergingEnum.Free;
			for(int i = 0; i < arg_fgrid.Cols.Count; i++)
			{


				if ((i != iDel_Month) && (i != iOBS_ID) &&					 
					(i != iStyle)     && (i != iBP_NO)  &&					
					(i != iRegion)                         )

//				if ((i != iDel_Month) && (i != iOBS_ID) && (i != iStyle))
					arg_fgrid.Cols[i].AllowMerging = false;
			}

//			arg_fgrid[arg_fgrid.Rows.Count-1, iDel_Month] = "SubTotal for Style";
//			arg_fgrid[arg_fgrid.Rows.Count-1, iDel_Month] = "Grand Total";

			arg_fgrid.AutoSizeCols();

			//fgrid_Main.Cols[iDel_Month].StyleNew.BackColor = Color.White;
//			fgrid_Main.Cols[iOBS_ID].StyleNew.BackColor = Color.White;
//			fgrid_Main.Cols[iStyle].StyleNew.BackColor = Color.White;


//			fgrid_Main.AllowMerging = AllowMergingEnum.None;
//			fgrid_Main.AllowMerging = AllowMergingEnum.RestrictAll;
//
//			foreach (Column col in fgrid_Main.Cols)
//				col.AllowMerging = checkBox1.Checked;
		}

		#endregion 	

		#region 이벤트 처리  

		private void cmb_Del_Month_TextChanged(object sender, System.EventArgs e)
		{
			if (cmb_Del_Month.SelectedIndex == 0)
			{
				txt_OBS_ID.Clear();
			}
			else
			{
				txt_OBS_ID.Text = ClassLib.ComFunction.Convert_ToDate(cmb_Del_Month.Text).AddMonths(-2).ToString("yyMM") + 
					              cmb_Del_Month.Text.Substring(4,2);		
			}
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_ret;

				//SEM_BP 정보를 읽어온다
				dt_ret = Select_BP_Data_List();

				if (dt_ret.Rows.Count  == 0)
				{
                   ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this);  return;
				}

				Display_fgrid(dt_ret, fgrid_Main);

			}
			catch 
			{
			    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this); 
			}					
		}

		private void chk_BP_NO_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chk_BP_NO.Checked) dpick_BP_NO.Enabled = true;
			else                   dpick_BP_NO.Enabled = false;		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;	
			cmb_Del_Month.SelectedIndex = 0;
			txt_Region.Clear();
			txt_Style.Clear();				
			dpick_BP_NO.Text = DateTime.Now.ToString();
			chk_BP_NO.Checked = false;
			fgrid_Main.Rows.Count = _Rowfixed;										
		}

		#endregion 	


		private void Form_EB_History_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

	}
}

