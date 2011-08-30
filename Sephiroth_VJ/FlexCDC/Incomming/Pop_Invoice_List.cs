using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Incomming
{
	public class Pop_Invoice_List : COM.PCHWinForm.Pop_Large_B
	{
		#region 컨트롤 정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.TextBox txt_MatName;
		private System.Windows.Forms.Label lbl_MaterialName;
		private System.Windows.Forms.DateTimePicker dtp_Fin_Ymd;
		private System.Windows.Forms.DateTimePicker dtp_Std_Ymd;
		public C1.Win.C1List.C1Combo cmb_Vendor;
		public C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Vendor;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;
		public C1.Win.C1List.C1Combo cmb_ShipNo;
		private System.Windows.Forms.Label lbl_ShipNo;
		private System.Windows.Forms.Label lbl_ShipDate;
		public Incomming.Form_Incomming_Manager arg_request = null;  

		public Pop_Invoice_List()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_Invoice_List(Incomming.Form_Incomming_Manager arg_request1)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			 arg_request = arg_request1;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Invoice_List));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.txt_MatName = new System.Windows.Forms.TextBox();
			this.lbl_MaterialName = new System.Windows.Forms.Label();
			this.cmb_ShipNo = new C1.Win.C1List.C1Combo();
			this.lbl_ShipNo = new System.Windows.Forms.Label();
			this.dtp_Fin_Ymd = new System.Windows.Forms.DateTimePicker();
			this.dtp_Std_Ymd = new System.Windows.Forms.DateTimePicker();
			this.cmb_Vendor = new C1.Win.C1List.C1Combo();
			this.lbl_ShipDate = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Vendor = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(581, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(804, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.txt_MatName);
			this.pnl_Top.Controls.Add(this.lbl_MaterialName);
			this.pnl_Top.Controls.Add(this.cmb_ShipNo);
			this.pnl_Top.Controls.Add(this.lbl_ShipNo);
			this.pnl_Top.Controls.Add(this.dtp_Fin_Ymd);
			this.pnl_Top.Controls.Add(this.dtp_Std_Ymd);
			this.pnl_Top.Controls.Add(this.cmb_Vendor);
			this.pnl_Top.Controls.Add(this.lbl_ShipDate);
			this.pnl_Top.Controls.Add(this.cmb_Factory);
			this.pnl_Top.Controls.Add(this.lbl_Vendor);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 64);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(868, 95);
			this.pnl_Top.TabIndex = 128;
			// 
			// txt_MatName
			// 
			this.txt_MatName.BackColor = System.Drawing.SystemColors.Window;
			this.txt_MatName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MatName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_MatName.ImeMode = System.Windows.Forms.ImeMode.On;
			this.txt_MatName.Location = new System.Drawing.Point(386, 58);
			this.txt_MatName.MaxLength = 10;
			this.txt_MatName.Name = "txt_MatName";
			this.txt_MatName.Size = new System.Drawing.Size(198, 21);
			this.txt_MatName.TabIndex = 275;
			this.txt_MatName.Text = "";
			// 
			// lbl_MaterialName
			// 
			this.lbl_MaterialName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MaterialName.ImageIndex = 0;
			this.lbl_MaterialName.ImageList = this.img_Label;
			this.lbl_MaterialName.Location = new System.Drawing.Point(285, 58);
			this.lbl_MaterialName.Name = "lbl_MaterialName";
			this.lbl_MaterialName.Size = new System.Drawing.Size(100, 21);
			this.lbl_MaterialName.TabIndex = 274;
			this.lbl_MaterialName.Tag = "1";
			this.lbl_MaterialName.Text = "Material Name";
			this.lbl_MaterialName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_ShipNo
			// 
			this.cmb_ShipNo.AddItemCols = 0;
			this.cmb_ShipNo.AddItemSeparator = ';';
			this.cmb_ShipNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ShipNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ShipNo.Caption = "";
			this.cmb_ShipNo.CaptionHeight = 17;
			this.cmb_ShipNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ShipNo.ColumnCaptionHeight = 18;
			this.cmb_ShipNo.ColumnFooterHeight = 18;
			this.cmb_ShipNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ShipNo.ContentHeight = 16;
			this.cmb_ShipNo.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_ShipNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ShipNo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_ShipNo.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ShipNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ShipNo.EditorHeight = 16;
			this.cmb_ShipNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ShipNo.GapHeight = 2;
			this.cmb_ShipNo.ItemHeight = 15;
			this.cmb_ShipNo.Location = new System.Drawing.Point(692, 36);
			this.cmb_ShipNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_ShipNo.MaxDropDownItems = ((short)(5));
			this.cmb_ShipNo.MaxLength = 32767;
			this.cmb_ShipNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ShipNo.Name = "cmb_ShipNo";
			this.cmb_ShipNo.PartialRightColumn = false;
			this.cmb_ShipNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
				"Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
				"xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
				"<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
				"umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
				"ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
				"dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
				"t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
				"le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
				"ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
				" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
				"t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
				"0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
				"tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
				"Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
				"/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
				"p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
				"odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_ShipNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ShipNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ShipNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ShipNo.Size = new System.Drawing.Size(160, 20);
			this.cmb_ShipNo.TabIndex = 273;
			// 
			// lbl_ShipNo
			// 
			this.lbl_ShipNo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ShipNo.ImageIndex = 0;
			this.lbl_ShipNo.ImageList = this.img_Label;
			this.lbl_ShipNo.Location = new System.Drawing.Point(591, 36);
			this.lbl_ShipNo.Name = "lbl_ShipNo";
			this.lbl_ShipNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_ShipNo.TabIndex = 272;
			this.lbl_ShipNo.Tag = "1";
			this.lbl_ShipNo.Text = "Ship No";
			this.lbl_ShipNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dtp_Fin_Ymd
			// 
			this.dtp_Fin_Ymd.CustomFormat = "yyyyMMdd";
			this.dtp_Fin_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtp_Fin_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Fin_Ymd.Location = new System.Drawing.Point(495, 36);
			this.dtp_Fin_Ymd.Name = "dtp_Fin_Ymd";
			this.dtp_Fin_Ymd.Size = new System.Drawing.Size(91, 21);
			this.dtp_Fin_Ymd.TabIndex = 271;
			// 
			// dtp_Std_Ymd
			// 
			this.dtp_Std_Ymd.CustomFormat = "yyyyMMdd";
			this.dtp_Std_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dtp_Std_Ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtp_Std_Ymd.Location = new System.Drawing.Point(386, 36);
			this.dtp_Std_Ymd.Name = "dtp_Std_Ymd";
			this.dtp_Std_Ymd.Size = new System.Drawing.Size(91, 21);
			this.dtp_Std_Ymd.TabIndex = 270;
			// 
			// cmb_Vendor
			// 
			this.cmb_Vendor.AddItemCols = 0;
			this.cmb_Vendor.AddItemSeparator = ';';
			this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Vendor.Caption = "";
			this.cmb_Vendor.CaptionHeight = 17;
			this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Vendor.ColumnCaptionHeight = 18;
			this.cmb_Vendor.ColumnFooterHeight = 18;
			this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Vendor.ContentHeight = 16;
			this.cmb_Vendor.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Vendor.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Vendor.EditorHeight = 16;
			this.cmb_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Vendor.GapHeight = 2;
			this.cmb_Vendor.ItemHeight = 15;
			this.cmb_Vendor.Location = new System.Drawing.Point(117, 58);
			this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
			this.cmb_Vendor.MaxDropDownItems = ((short)(5));
			this.cmb_Vendor.MaxLength = 32767;
			this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Vendor.Name = "cmb_Vendor";
			this.cmb_Vendor.PartialRightColumn = false;
			this.cmb_Vendor.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
				"Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
				"xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
				"<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
				"umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
				"ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
				"dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
				"t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
				"le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
				"ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
				" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
				"t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
				"0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
				"tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
				"Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
				"/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
				"p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
				"odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Vendor.Size = new System.Drawing.Size(160, 20);
			this.cmb_Vendor.TabIndex = 269;
			// 
			// lbl_ShipDate
			// 
			this.lbl_ShipDate.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ShipDate.ImageIndex = 0;
			this.lbl_ShipDate.ImageList = this.img_Label;
			this.lbl_ShipDate.Location = new System.Drawing.Point(285, 36);
			this.lbl_ShipDate.Name = "lbl_ShipDate";
			this.lbl_ShipDate.Size = new System.Drawing.Size(100, 21);
			this.lbl_ShipDate.TabIndex = 267;
			this.lbl_ShipDate.Tag = "1";
			this.lbl_ShipDate.Text = "Shipping Date";
			this.lbl_ShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 16;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(117, 36);
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
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
				"Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
				"xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
				"<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
				"umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
				"ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
				"dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
				"t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
				"le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
				"ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
				" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
				"t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
				"0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
				"tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
				"Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
				"/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
				"p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
				"odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(160, 20);
			this.cmb_Factory.TabIndex = 264;
			// 
			// lbl_Vendor
			// 
			this.lbl_Vendor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Vendor.ImageIndex = 0;
			this.lbl_Vendor.ImageList = this.img_Label;
			this.lbl_Vendor.Location = new System.Drawing.Point(16, 58);
			this.lbl_Vendor.Name = "lbl_Vendor";
			this.lbl_Vendor.Size = new System.Drawing.Size(100, 21);
			this.lbl_Vendor.TabIndex = 204;
			this.lbl_Vendor.Tag = "1";
			this.lbl_Vendor.Text = "Vendor";
			this.lbl_Vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(16, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 203;
			this.lbl_factory.Tag = "1";
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lbl);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox3);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.pictureBox8);
			this.pnl_SearchImage.Controls.Add(this.pictureBox10);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(852, 87);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// lbl
			// 
			this.lbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl.Location = new System.Drawing.Point(471, 36);
			this.lbl.Name = "lbl";
			this.lbl.Size = new System.Drawing.Size(16, 16);
			this.lbl.TabIndex = 29;
			this.lbl.Text = "~";
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(835, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 44);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(836, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(852, 40);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle
			// 
			this.lbl_SubTitle.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle.Image")));
			this.lbl_SubTitle.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle.Name = "lbl_SubTitle";
			this.lbl_SubTitle.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle.TabIndex = 28;
			this.lbl_SubTitle.Text = "      Invoice Information";
			this.lbl_SubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(836, 72);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(16, 16);
			this.pictureBox4.TabIndex = 23;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(144, 71);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(852, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 72);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 54);
			this.pictureBox8.TabIndex = 30;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(152, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(852, 47);
			this.pictureBox10.TabIndex = 31;
			this.pictureBox10.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Body.Location = new System.Drawing.Point(0, 159);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(868, 460);
			this.pnl_Body.TabIndex = 142;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_Main.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
			this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Fixed = 0;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(868, 460);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 318;
			// 
			// Pop_Invoice_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(868, 619);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Pop_Invoice_List";
			this.Load += new System.EventHandler(this.Pop_Invoice_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ShipNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();		
		
		#endregion

		#region 공통메서드

		private void Init_Form()
		{
			this.Text               = "PCC_Invoice List";
			this.lbl_MainTitle.Text = "PCC_Invoice List";

			#region Button Setting			
			tbtn_Delete.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Print.Enabled   = false;	
			tbtn_Conform.Enabled = false;
			tbtn_Create.Enabled  = false;	
			#endregion	

			#region TextBox Setting
			txt_MatName.CharacterCasing = CharacterCasing.Upper;	
			txt_MatName.Focus();
			#endregion

			#region ComboBox Setting
//			//Factory Setting		 
//			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
//			COM.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
//			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory ;			
//
//			//Ship No Setting 
//			dt_ret = Select_SXP_Pur_Head_Get_Pur_No(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text );
//			COM.ComCtl.Set_ComboList(dt_ret, cmb_PurNo, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
//			cmb_PurNo.SelectedIndex = 0;
//	
//			//Vendor Setting 
//			dt_ret = Select_SXP_Pur_Vendor(cmb_Factory.SelectedValue.ToString(), dtp_Std_Ymd.Text, dtp_Fin_Ymd.Text, ClassLib.ComFunction.Empty_Combo(cmb_PurNo, "") );
//			COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 0, true, COM.ComVar.ComboList_Visible.Name);
//			cmb_Vendor.SelectedIndex = 0;
//			
//			dt_ret.Dispose();
			#endregion
		}
		#endregion 


		private void Pop_Invoice_List_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

