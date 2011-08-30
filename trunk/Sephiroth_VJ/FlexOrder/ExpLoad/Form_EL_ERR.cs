using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;


namespace FlexOrder.ExpLoad
{
	public class Form_EL_ERR : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.Label lbl_PO_TYPE;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_BEDAT;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.DateTimePicker dpick_Date;
		private C1.Win.C1List.C1Combo cmb_PG_ID;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem ctm_GSSC;
		private System.Windows.Forms.MenuItem ctm_Build_Plan;
		private System.Windows.Forms.MenuItem ctm_PGS_OBS;
		private System.Windows.Forms.MenuItem ctm_MCR_OBS;
		private System.Windows.Forms.MenuItem ctm_MCR_CRTN;
		private System.Windows.Forms.MenuItem ctm_Bar_First;
		private System.Windows.Forms.MenuItem ctm_Bar_Second;
		private System.ComponentModel.IContainer components = null;

		public Form_EL_ERR()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_ERR));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.cmb_PG_ID = new C1.Win.C1List.C1Combo();
			this.lbl_PO_TYPE = new System.Windows.Forms.Label();
			this.dpick_Date = new System.Windows.Forms.DateTimePicker();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.lbl_BEDAT = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.ctm_GSSC = new System.Windows.Forms.MenuItem();
			this.ctm_Build_Plan = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_First = new System.Windows.Forms.MenuItem();
			this.ctm_PGS_OBS = new System.Windows.Forms.MenuItem();
			this.ctm_MCR_OBS = new System.Windows.Forms.MenuItem();
			this.ctm_Bar_Second = new System.Windows.Forms.MenuItem();
			this.ctm_MCR_CRTN = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_PG_ID)).BeginInit();
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
			this.c1ToolBar1.Name = "c1ToolBar1";
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
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1012, 128);
			this.pnl_Search.TabIndex = 37;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.cmb_PG_ID);
			this.pnl_Search1_Image.Controls.Add(this.lbl_PO_TYPE);
			this.pnl_Search1_Image.Controls.Add(this.dpick_Date);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.lbl_BEDAT);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 112);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// cmb_PG_ID
			// 
			this.cmb_PG_ID.AddItemCols = 0;
			this.cmb_PG_ID.AddItemSeparator = ';';
			this.cmb_PG_ID.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_PG_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_PG_ID.Caption = "";
			this.cmb_PG_ID.CaptionHeight = 17;
			this.cmb_PG_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_PG_ID.ColumnCaptionHeight = 18;
			this.cmb_PG_ID.ColumnFooterHeight = 18;
			this.cmb_PG_ID.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_PG_ID.ContentHeight = 16;
			this.cmb_PG_ID.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_PG_ID.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_PG_ID.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PG_ID.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_PG_ID.EditorHeight = 16;
			this.cmb_PG_ID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_PG_ID.GapHeight = 2;
			this.cmb_PG_ID.ItemHeight = 15;
			this.cmb_PG_ID.Location = new System.Drawing.Point(111, 80);
			this.cmb_PG_ID.MatchEntryTimeout = ((long)(2000));
			this.cmb_PG_ID.MaxDropDownItems = ((short)(5));
			this.cmb_PG_ID.MaxLength = 32767;
			this.cmb_PG_ID.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_PG_ID.Name = "cmb_PG_ID";
			this.cmb_PG_ID.PartialRightColumn = false;
			this.cmb_PG_ID.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_PG_ID.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_PG_ID.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_PG_ID.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_PG_ID.Size = new System.Drawing.Size(210, 20);
			this.cmb_PG_ID.TabIndex = 168;
			this.cmb_PG_ID.TextChanged += new System.EventHandler(this.cmb_PG_ID_TextChanged);
			// 
			// lbl_PO_TYPE
			// 
			this.lbl_PO_TYPE.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PO_TYPE.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PO_TYPE.ImageIndex = 1;
			this.lbl_PO_TYPE.ImageList = this.img_Label;
			this.lbl_PO_TYPE.Location = new System.Drawing.Point(10, 80);
			this.lbl_PO_TYPE.Name = "lbl_PO_TYPE";
			this.lbl_PO_TYPE.Size = new System.Drawing.Size(100, 21);
			this.lbl_PO_TYPE.TabIndex = 167;
			this.lbl_PO_TYPE.Text = "PG ID";
			this.lbl_PO_TYPE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_Date
			// 
			this.dpick_Date.CustomFormat = "yyyy-MM-dd";
			this.dpick_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_Date.Location = new System.Drawing.Point(111, 57);
			this.dpick_Date.Name = "dpick_Date";
			this.dpick_Date.Size = new System.Drawing.Size(210, 21);
			this.dpick_Date.TabIndex = 162;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
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
			this.cmb_Factory.ContentHeight = 16;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 16;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(974, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(168, -1);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(812, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      OBS Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(977, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 66);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 98);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_BEDAT
			// 
			this.lbl_BEDAT.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BEDAT.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_BEDAT.ImageIndex = 1;
			this.lbl_BEDAT.ImageList = this.img_Label;
			this.lbl_BEDAT.Location = new System.Drawing.Point(10, 58);
			this.lbl_BEDAT.Name = "lbl_BEDAT";
			this.lbl_BEDAT.Size = new System.Drawing.Size(100, 21);
			this.lbl_BEDAT.TabIndex = 19;
			this.lbl_BEDAT.Text = "Job Date";
			this.lbl_BEDAT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 77);
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.Color.Navy;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(32, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(948, 80);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 98);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(80, 14);
			this.pictureBox11.TabIndex = 6;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(72, 98);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(908, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
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
			this.pnl_Body.Location = new System.Drawing.Point(0, 192);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 448);
			this.pnl_Body.TabIndex = 44;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowEditing = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:1{AllowMerging:True;}\t";
			this.fgrid_Main.ContextMenu = this.contextMenu1;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 448);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;Border:Flat,1,Control,Vertical;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.ctm_GSSC,
																						 this.ctm_Build_Plan,
																						 this.ctm_Bar_First,
																						 this.ctm_PGS_OBS,
																						 this.ctm_MCR_OBS,
																						 this.ctm_Bar_Second,
																						 this.ctm_MCR_CRTN});
			// 
			// ctm_GSSC
			// 
			this.ctm_GSSC.Index = 0;
			this.ctm_GSSC.Text = "Grobal Size Run";
			this.ctm_GSSC.Click += new System.EventHandler(this.ctm_GSSC_Click);
			// 
			// ctm_Build_Plan
			// 
			this.ctm_Build_Plan.Index = 1;
			this.ctm_Build_Plan.Text = "Build Plan";
			this.ctm_Build_Plan.Click += new System.EventHandler(this.ctm_Build_Plan_Click);
			// 
			// ctm_Bar_First
			// 
			this.ctm_Bar_First.Index = 2;
			this.ctm_Bar_First.Text = "-";
			// 
			// ctm_PGS_OBS
			// 
			this.ctm_PGS_OBS.Index = 3;
			this.ctm_PGS_OBS.Text = "OBS In Pegasus";
			this.ctm_PGS_OBS.Click += new System.EventHandler(this.ctm_PGS_OBS_Click);
			// 
			// ctm_MCR_OBS
			// 
			this.ctm_MCR_OBS.Index = 4;
			this.ctm_MCR_OBS.Text = "OBS In Mercury";
			this.ctm_MCR_OBS.Click += new System.EventHandler(this.ctm_MCR_OBS_Click);
			// 
			// ctm_Bar_Second
			// 
			this.ctm_Bar_Second.Index = 5;
			this.ctm_Bar_Second.Text = "-";
			// 
			// ctm_MCR_CRTN
			// 
			this.ctm_MCR_CRTN.Index = 6;
			this.ctm_MCR_CRTN.Text = "Carton In Mercury";
			this.ctm_MCR_CRTN.Click += new System.EventHandler(this.ctm_MCR_CRTN_Click);
			// 
			// Form_EL_ERR
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Form_EL_ERR";
			this.Load += new System.EventHandler(this.Form_EL_ERR_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_PG_ID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		#region 속성 정의

		private int _Rowfixed;  
		COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();

		#endregion

		#region 멤버 메서드 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			//Title
			this.Text = "Loading Error ";
			this.lbl_MainTitle.Text = "Loading Error "; 
			ClassLib.ComFunction.SetLangDic(this);

			#region
			tbtn_Search.Enabled =true;
			tbtn_Append.Enabled =false;
			tbtn_Color.Enabled =false;
			tbtn_Create.Enabled=false;
			tbtn_Delete.Enabled =false;
			tbtn_Insert.Enabled =false;
			tbtn_New.Enabled =true;
			tbtn_Save.Enabled   = false;
			tbtn_Print.Enabled  =true;
			#endregion

			


			DataTable dt_list; 
			DateTime CurDate = DateTime.Now;		
			
			// 그리드 설정
			// fgrid_main (TBSEM_USER_ERR)
			fgrid_Main.Set_Grid( "SEM_USER_ERR", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			_Rowfixed = fgrid_Main.Rows.Fixed;		
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font  = new Font("Verdana",8);
				
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
	
			//Date
			dpick_Date.CustomFormat = ClassLib.ComVar.This_SetedDateType;
			string now  = System.DateTime.Now.ToString("yyyyMMdd");
			dpick_Date.Text = MyComFunction.ConvertDate2Type(now);


			// Loading PG Setting..
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLoadPG);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_PG_ID, 1, 2, false);  
			cmb_PG_ID.SelectedIndex = 0;

		}

		#endregion

		#region DB 컨트롤
		/// <summary>
		/// Select_Err_List : 사이즈 리스트 찾기 
		/// </summary>
		private void Select_Err_List(string arg_factory, string arg_date, string arg_pg_id)
		{
			try
			{
				string strRlt; int iCnt;
				DataSet ret; DataTable dt_list;
		    
				iCnt =  4;
				MyOraDB.ReDim_Parameter(iCnt); 
		    
				strRlt  = "PKG_SEM_USER_ERR.SELECT_SEM_USER_ERR";
				MyOraDB.Process_Name =strRlt;
	
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_JOB_YMD";   
				MyOraDB.Parameter_Name[2] = "ARG_PG_ID";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
				
				MyOraDB.Parameter_Type[0] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] =  (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] =  (int)OracleType.Cursor;						
	
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_date;
				MyOraDB.Parameter_Values[2] = arg_pg_id;  
				MyOraDB.Parameter_Values[3] = "";
				
				MyOraDB.Add_Select_Parameter(true); 
				ret = MyOraDB.Exe_Select_Procedure();
										
				if (ret == null)
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch ,this); return  ;}

				dt_list  =  ret.Tables[strRlt];

				fgrid_Main.Rows.Count = _Rowfixed;  
	 
				for(int i = 0; i < dt_list.Rows.Count; i++)
				{
					fgrid_Main.AddItem(dt_list.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
					fgrid_Main[fgrid_Main.Rows.Count - 1, 0] = "";
				} 

				fgrid_Main.AutoSizeCols();
			}
			catch (Exception eMessage)
			{
				MessageBox.Show("Exception caught : " + eMessage);
			}
		}
		
		#endregion

		#region 이벤트처리

		private void cmb_PG_ID_TextChanged(object sender, System.EventArgs e)
		{
			// 그리드 설정

			

		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			try
			{
				Select_Err_List( cmb_Factory.SelectedValue.ToString(), 
					Convert.ToDateTime(dpick_Date.Text).ToString("yyyyMMdd"), 
					cmb_PG_ID.SelectedValue.ToString());

				
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch,this);
			    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch ,this);

			}
			catch (Exception eMessage)
			{
				MessageBox.Show("Exception caught : " + eMessage);
			}
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{

				string mrd_Filename = "Form_EL_ERR.mrd" ;
				string txt_Filename = this.Name + ".txt"; 
				string Para         = " ";

				FileInfo file = new FileInfo(txt_Filename);
				if(!file.Exists)
				{
					file.Create().Close();
				}
				file = null;

				//조회조건들
				int  iCnt  = 3;
				string [] aHead =  new string[iCnt];	
				aHead[0]    = cmb_Factory.SelectedValue.ToString();
				aHead[1]    = Convert.ToDateTime(dpick_Date.Text).ToString("yyyyMMdd");
				aHead[2]    = cmb_PG_ID.SelectedValue.ToString();


				//Parameter만들기
				Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
				for (int i  = 1 ; i<= iCnt ; i++)
				{
					Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
				}
				Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";


				//File 출력 리스트
				fgrid_Main.SaveGrid(txt_Filename, FileFormatEnum.TextComma);

				//Report Base Form호출..
				FlexOrder.Report.Form_RD_Base  report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
				report.Show();
			}
			catch(Exception ex)
			{
				throw ex;

			}

		}


		#endregion

		#region 콘텍스트 메뉴
		
		private void ctm_GSSC_Click(object sender, System.EventArgs e)
		{
            //FlexOrder.ExpLoad.Form_EL_GSSC frm = new ExpLoad.Form_EL_GSSC();  
            //frm.Show();		
		}

		private void ctm_Build_Plan_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_BP  frm = new ExpLoad.Form_EL_BP();  
			frm.Show();		
		}

		private void ctm_PGS_OBS_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_PGS frm = new ExpLoad.Form_EL_PGS();  
			frm.Show();		
		}

		private void ctm_MCR_OBS_Click(object sender, System.EventArgs e)
		{
			FlexOrder.ExpLoad.Form_EL_MCR frm = new ExpLoad.Form_EL_MCR();  
			frm.Show();		
		}

		private void ctm_MCR_CRTN_Click(object sender, System.EventArgs e)
		{
            //FlexOrder.ExpLoad.Form_EL_CTN frm = new ExpLoad.Form_EL_CTN();  
            //frm.Show();		
		}

		#endregion

		private void Form_EL_ERR_Load(object sender, System.EventArgs e)
		{
			Init_Form();	
		}

		
		
	}
}

