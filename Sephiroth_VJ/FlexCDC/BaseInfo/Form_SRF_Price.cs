using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;
using System.Threading;

namespace FlexCDC.BaseInfo
{
	public class Form_SRF_Price : COM.CDCWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Label lbl_Material;
		private System.Windows.Forms.TextBox txt_Material;
		private C1.Win.C1List.C1Combo cmb_Material;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.TextBox txt_Spec;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.TextBox txt_Color;
		private System.Windows.Forms.ContextMenu ctMnu01;
		private System.Windows.Forms.MenuItem mnu_Pur_User;
		private System.Windows.Forms.MenuItem mnu_Vendor;
		private System.ComponentModel.IContainer components = null;

		public Form_SRF_Price()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SRF_Price));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.lbl_Spec = new System.Windows.Forms.Label();
			this.lbl_Material = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_Color = new System.Windows.Forms.TextBox();
			this.txt_Spec = new System.Windows.Forms.TextBox();
			this.cmb_Material = new C1.Win.C1List.C1Combo();
			this.txt_Material = new System.Windows.Forms.TextBox();
			this.btn_openfile = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.ctMnu01 = new System.Windows.Forms.ContextMenu();
			this.mnu_Pur_User = new System.Windows.Forms.MenuItem();
			this.mnu_Vendor = new System.Windows.Forms.MenuItem();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Material)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_New
			// 
			this.tbtn_New.Text = "";
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Text = "";
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Text = "";
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Text = "";
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Text = "";
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Text = "";
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// c1CommandLink8
			// 
			this.c1CommandLink8.Text = "Confirm";
			// 
			// tbtn_Color
			// 
			this.tbtn_Color.Text = "";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Text = "";
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.lbl_Color);
			this.pnl_Top.Controls.Add(this.lbl_Spec);
			this.pnl_Top.Controls.Add(this.lbl_Material);
			this.pnl_Top.Controls.Add(this.cmb_Factory);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 64);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
			this.pnl_Top.TabIndex = 137;
			// 
			// lbl_Color
			// 
			this.lbl_Color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Color.ImageIndex = 0;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.Location = new System.Drawing.Point(16, 58);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 346;
			this.lbl_Color.Tag = "0";
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Spec
			// 
			this.lbl_Spec.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Spec.ImageIndex = 0;
			this.lbl_Spec.ImageList = this.img_Label;
			this.lbl_Spec.Location = new System.Drawing.Point(674, 36);
			this.lbl_Spec.Name = "lbl_Spec";
			this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec.TabIndex = 345;
			this.lbl_Spec.Tag = "1";
			this.lbl_Spec.Text = "Spec";
			this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Material
			// 
			this.lbl_Material.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Material.ImageIndex = 0;
			this.lbl_Material.ImageList = this.img_Label;
			this.lbl_Material.Location = new System.Drawing.Point(340, 36);
			this.lbl_Material.Name = "lbl_Material";
			this.lbl_Material.Size = new System.Drawing.Size(100, 21);
			this.lbl_Material.TabIndex = 344;
			this.lbl_Material.Tag = "1";
			this.lbl_Material.Text = "Material";
			this.lbl_Material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
			this.cmb_Factory.TabIndex = 272;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(16, 36);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 271;
			this.lbl_factory.Tag = "0";
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Color);
			this.pnl_SearchImage.Controls.Add(this.txt_Spec);
			this.pnl_SearchImage.Controls.Add(this.cmb_Material);
			this.pnl_SearchImage.Controls.Add(this.txt_Material);
			this.pnl_SearchImage.Controls.Add(this.btn_openfile);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox3);
			this.pnl_SearchImage.Controls.Add(this.lbl_title);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.pictureBox7);
			this.pnl_SearchImage.Controls.Add(this.pictureBox8);
			this.pnl_SearchImage.Controls.Add(this.pictureBox9);
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_Color
			// 
			this.txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Color.Location = new System.Drawing.Point(109, 58);
			this.txt_Color.Name = "txt_Color";
			this.txt_Color.Size = new System.Drawing.Size(200, 21);
			this.txt_Color.TabIndex = 553;
			this.txt_Color.Text = "";
			// 
			// txt_Spec
			// 
			this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Spec.Location = new System.Drawing.Point(767, 36);
			this.txt_Spec.Name = "txt_Spec";
			this.txt_Spec.Size = new System.Drawing.Size(200, 21);
			this.txt_Spec.TabIndex = 551;
			this.txt_Spec.Text = "";
			// 
			// cmb_Material
			// 
			this.cmb_Material.AddItemCols = 0;
			this.cmb_Material.AddItemSeparator = ';';
			this.cmb_Material.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Material.Caption = "";
			this.cmb_Material.CaptionHeight = 17;
			this.cmb_Material.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Material.ColumnCaptionHeight = 18;
			this.cmb_Material.ColumnFooterHeight = 18;
			this.cmb_Material.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Material.ContentHeight = 16;
			this.cmb_Material.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Material.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Material.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Material.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Material.EditorHeight = 16;
			this.cmb_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Material.GapHeight = 2;
			this.cmb_Material.ItemHeight = 15;
			this.cmb_Material.Location = new System.Drawing.Point(503, 36);
			this.cmb_Material.MatchEntryTimeout = ((long)(2000));
			this.cmb_Material.MaxDropDownItems = ((short)(5));
			this.cmb_Material.MaxLength = 32767;
			this.cmb_Material.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Material.Name = "cmb_Material";
			this.cmb_Material.PartialRightColumn = false;
			this.cmb_Material.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;BackColor:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:C" +
				"enter;}Style8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits>" +
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
			this.cmb_Material.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Material.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Material.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Material.Size = new System.Drawing.Size(130, 20);
			this.cmb_Material.TabIndex = 550;
			this.cmb_Material.SelectedValueChanged += new System.EventHandler(this.cmb_Material_SelectedValueChanged);
			// 
			// txt_Material
			// 
			this.txt_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Material.Location = new System.Drawing.Point(433, 36);
			this.txt_Material.Name = "txt_Material";
			this.txt_Material.Size = new System.Drawing.Size(69, 21);
			this.txt_Material.TabIndex = 549;
			this.txt_Material.Text = "";
			this.txt_Material.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Material_KeyUp);
			// 
			// btn_openfile
			// 
			this.btn_openfile.BackColor = System.Drawing.SystemColors.Window;
			this.btn_openfile.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_openfile.Location = new System.Drawing.Point(426, 36);
			this.btn_openfile.Name = "btn_openfile";
			this.btn_openfile.Size = new System.Drawing.Size(21, 21);
			this.btn_openfile.TabIndex = 112;
			this.btn_openfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(983, 30);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(24, 45);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(984, 0);
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
			this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_title
			// 
			this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_title.ForeColor = System.Drawing.Color.Navy;
			this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
			this.lbl_title.Location = new System.Drawing.Point(0, 0);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(231, 30);
			this.lbl_title.TabIndex = 28;
			this.lbl_title.Text = "       CBD Infomation";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(984, 73);
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
			this.pictureBox5.Location = new System.Drawing.Point(136, 72);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(1000, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 73);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(168, 20);
			this.pictureBox6.TabIndex = 22;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 55);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(152, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(1000, 48);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(472, 72);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(1000, 48);
			this.pictureBox9.TabIndex = 27;
			this.pictureBox9.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Body.Location = new System.Drawing.Point(0, 160);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 483);
			this.pnl_Body.TabIndex = 138;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_Main.ContextMenu = this.ctMnu01;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
			this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Fixed = 0;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1016, 483);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 318;
			this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			this.fgrid_Main.AfterSelChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Main_AfterSelChange);
			// 
			// ctMnu01
			// 
			this.ctMnu01.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnu_Pur_User,
																					this.mnu_Vendor});
			// 
			// mnu_Pur_User
			// 
			this.mnu_Pur_User.Index = 0;
			this.mnu_Pur_User.Text = "Purchase User";
			this.mnu_Pur_User.Click += new System.EventHandler(this.mnu_Pur_User_Click);
			// 
			// mnu_Vendor
			// 
			this.mnu_Vendor.Index = 1;
			this.mnu_Vendor.Text = "Vendor";
			this.mnu_Vendor.Click += new System.EventHandler(this.mnu_Vendor_Click);
			// 
			// Form_SRF_Price
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_SRF_Price";
			this.Load += new System.EventHandler(this.Form_SRF_CBD_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Material)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();
        private string Group_Dir = null;
		private int _RowFixed;

		#endregion

		#region 공통 메서드

		private void Init_Form()
		{
			this.Text = "PCC_Price Master";
			this.lbl_MainTitle.Text = "PCC_Price Master";
			this.lbl_title.Text = "      Price Information";

			ClassLib.ComFunction.SetLangDic(this); 

			#region Button Setting		
			tbtn_Append.Enabled  = false;
			tbtn_Color.Enabled   = false;		
			tbtn_Insert.Enabled  = false;				
			tbtn_Print.Enabled   = false;
			tbtn_Create.Enabled  = false;
            tbtn_Delete.Enabled = false;
            //tbtn_Save.Enabled = false;
			#endregion 			
			
			#region ComboBox Setting			
			//Material Setting 
			DataTable dt_ret = Select_Material_List( cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_TextBox(txt_Material, ""));
			COM.ComCtl.Set_ComboList( dt_ret, cmb_Material, 0, 1, true, 0, 200 );
			cmb_Material.SelectedIndex = 0;
			
			dt_ret.Dispose();
			#endregion

			#region Grid Setting			
			fgrid_Main.Set_Grid_CDC( "SXD_SRF_M_CBD", "1", 2 , COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false );
			fgrid_Main.Set_Action_Image( img_Action );
			fgrid_Main.Font = new Font( "Verdana", 8 );		
			_RowFixed = fgrid_Main.Rows.Fixed;				
			#endregion

			#region TextBox Setting			
			txt_Material.CharacterCasing = CharacterCasing.Upper;				
			txt_Spec.CharacterCasing = CharacterCasing.Upper;				
			txt_Color.CharacterCasing = CharacterCasing.Upper;				
			txt_Material.Focus();
			#endregion
	 
		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{
			
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{				
				arg_fgrid.AddItem( arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1 );
			}


		}
		#endregion

		#region 이벤트 처리
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
					return;

				COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

				Init_Form();
			}
			catch
			{
				this.Cursor = Cursors.Default;	
			}
			finally
			{
				this.Cursor = Cursors.Default;	
			}
		}
		private void fgrid_Main_AfterSelChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
		{
			ctMnu01.MenuItems[0].Visible = false; 
			ctMnu01.MenuItems[1].Visible = false; 		

			switch(fgrid_Main.Selection.c1)	
			{

				case (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_USER : 	
				{
					ctMnu01.MenuItems[0].Text    = "Purchase User";
					ctMnu01.MenuItems[0].Visible = true;
					ctMnu01.MenuItems[1].Visible = false;
					break;
				}	
				case (int)ClassLib.TBSXD_SRF_M_CBD.IxVENDOR_DESC :
				{
					ctMnu01.MenuItems[1].Text    = "Vendor";
					ctMnu01.MenuItems[1].Visible = true;
					ctMnu01.MenuItems[0].Visible = false;
					break;
				}
			
			}			
		}
		
		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
					fgrid_Main.Buffer_CellData = "";				
				else
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();				
			}		
		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Main.Update_Row();		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
			txt_Material.Clear();
			txt_Spec.Clear();
			txt_Color.Clear();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;		
			cmb_Material.SelectedValue = 0;
		}
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;				
				 
				DataTable dt_ret = Select_Sxd_Srf_M_CBD(cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_TextBox(txt_Material,""), ClassLib.ComFunction.Empty_TextBox(txt_Spec,""), ClassLib.ComFunction.Empty_TextBox(txt_Color,""));				
				Display_Grid(dt_ret, fgrid_Main); 				
								
				dt_ret.Dispose();
			}
			catch
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);  
				MyOraDB.Save_FlexGird("PKG_SXB_BASE_02.SAVE_SXD_SRF_M_CBD", fgrid_Main, (int)ClassLib.TBSXD_SRF_M_CBD.IxMaxCt);

				for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count ;i++)
				{
//					if(fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_CBD.IxDIVISION] != null && fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_CBD.IxDIVISION].ToString() != "")										
//						Update_Item(i);					
					
					fgrid_Main[i,0] = "";			
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;				
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}		
  	    }

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Delete_Row();		
		}		
		
		private void txt_Material_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(txt_Material.Text != null && e.KeyData == Keys.Enter)
			{								
				//Material Setting 
				DataTable dt_ret = Select_Material_List(cmb_Factory.SelectedValue.ToString(), ClassLib.ComFunction.Empty_TextBox(txt_Material, ""));
				COM.ComCtl.Set_ComboList( dt_ret, cmb_Material, 0, 1, true, 0, 200 );
				cmb_Material.SelectedIndex = 0;
			
				dt_ret.Dispose();								
			}		
		
		}

		private void cmb_Material_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_Material.SelectedValue != null)
				txt_Material.Text = cmb_Material.SelectedValue.ToString().Trim();
		
		}
		private void mnu_Pur_User_Click(object sender, System.EventArgs e)
		{
			BaseInfo.Pop_Purchase_User pur_user = new Pop_Purchase_User(this);
			pur_user.r1 = fgrid_Main.Selection.r1;
			pur_user.r2 = fgrid_Main.Selection.r2;
			pur_user.div = "P";
			pur_user.ShowDialog();
		
		}

		private void mnu_Vendor_Click(object sender, System.EventArgs e)
		{
			BaseInfo.Pop_Vendor Vendor = new Pop_Vendor(this);
			Vendor.r1 = fgrid_Main.Selection.r1;
			Vendor.r2 = fgrid_Main.Selection.r2;
			Vendor.div = "P";
			Vendor.ShowDialog();	
		
		}
		#endregion

		#region DB Connect

		private DataTable Select_Material_List( string arg_factory, string arg_mat_cd)
		{

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_MAT_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";			
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_mat_cd;			
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Sxd_Srf_M_CBD(string arg_factory, string arg_mat_cd, string arg_spec_desc, string arg_color_desc)
		{		

			DataSet ds_list;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_CBD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SPEC_DESC";
			MyOraDB.Parameter_Name[3] = "ARG_COLOR_DESC";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_mat_cd;
			MyOraDB.Parameter_Values[2] = arg_spec_desc;			
			MyOraDB.Parameter_Values[3] = arg_color_desc;			
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}		

		private void Update_Item( int row_cnt )
		{

			MyOraDB.ReDim_Parameter(27);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SAVE_SXD_SRF_M_CBD";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[3]  = "ARG_PCC_SPEC_CD";
			MyOraDB.Parameter_Name[4]  = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_PUR_USER";
			MyOraDB.Parameter_Name[6]  = "ARG_PK_QTY";
			MyOraDB.Parameter_Name[7]  = "ARG_PUR_CURRENCY";
			MyOraDB.Parameter_Name[8]  = "ARG_PUR_PRICE";
			MyOraDB.Parameter_Name[9]  = "ARG_OUTSIDE_CURRENCY";
			MyOraDB.Parameter_Name[10] = "ARG_OUTSIDE_PRICE";
			MyOraDB.Parameter_Name[11] = "ARG_CBD_CURRENCY";
			MyOraDB.Parameter_Name[12] = "ARG_CBD_PRICE";
			MyOraDB.Parameter_Name[13] = "ARG_SHIP_CURRENCY";
			MyOraDB.Parameter_Name[14] = "ARG_SHIP_PRICE";
			MyOraDB.Parameter_Name[15] = "ARG_LAMINATION_CURRENCY";
			MyOraDB.Parameter_Name[16] = "ARG_LAMINATION_PRICE";
			MyOraDB.Parameter_Name[17] = "ARG_VEN_SEQ";
			MyOraDB.Parameter_Name[18] = "ARG_CBM";
			MyOraDB.Parameter_Name[19] = "ARG_GROSS_WEIGHT";
			MyOraDB.Parameter_Name[20] = "ARG_NET_WEIGHT";
			MyOraDB.Parameter_Name[21] = "ARG_NIKE_FLG";
			MyOraDB.Parameter_Name[22] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[23] = "ARG_SEND_CHK";
			MyOraDB.Parameter_Name[24] = "ARG_SEND_YMD";
			MyOraDB.Parameter_Name[25] = "ARG_STATUS";
			MyOraDB.Parameter_Name[26] = "ARG_UPD_USER";				

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[10]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[11]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[12]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[13]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[14]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[21]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[22]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[23]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[24]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[25]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[26]  = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxDIVISION] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxDIVISION].ToString();
			MyOraDB.Parameter_Values[1] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxFACTORY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[2] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxMAT_CD] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxMAT_CD].ToString();
			MyOraDB.Parameter_Values[3] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPCC_SPEC_CD] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPCC_SPEC_CD].ToString();
			MyOraDB.Parameter_Values[4] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCOLOR_CD] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCOLOR_CD].ToString();
			MyOraDB.Parameter_Values[5] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_USER] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_USER].ToString();
			MyOraDB.Parameter_Values[6] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPK_QTY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPK_QTY].ToString();
			MyOraDB.Parameter_Values[7] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_CURRENCY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_CURRENCY].ToString();
			MyOraDB.Parameter_Values[8] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxPUR_PRICE].ToString();
			MyOraDB.Parameter_Values[9] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_CURRENCY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_CURRENCY].ToString();
			MyOraDB.Parameter_Values[10] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_PRICE].ToString();
			MyOraDB.Parameter_Values[11] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCBD_CURRENCY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCBD_CURRENCY].ToString();
			MyOraDB.Parameter_Values[12] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCBD_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxCBD_PRICE].ToString();
			MyOraDB.Parameter_Values[13] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxSHIP_CURRENCY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxSHIP_CURRENCY].ToString();
			MyOraDB.Parameter_Values[14] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxSHIP_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxSHIP_PRICE].ToString();
			MyOraDB.Parameter_Values[15] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxLAMINATION_CURRENCY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxLAMINATION_CURRENCY].ToString();
			MyOraDB.Parameter_Values[16] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxLAMINATION_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxLAMINATION_PRICE].ToString();
			MyOraDB.Parameter_Values[17] = "";
			MyOraDB.Parameter_Values[18] = "";
			MyOraDB.Parameter_Values[19] = "";
			MyOraDB.Parameter_Values[20] = "";
			MyOraDB.Parameter_Values[21] = "";
			MyOraDB.Parameter_Values[22] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_PRICE] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_CBD.IxOUTSIDE_PRICE].ToString();
			MyOraDB.Parameter_Values[23] = "";
			MyOraDB.Parameter_Values[24] = "";
			MyOraDB.Parameter_Values[25] = "";
			MyOraDB.Parameter_Values[26] = ClassLib.ComVar.This_User;
			
			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Modify_Procedure();		
		}
		#endregion 

		private void Form_SRF_CBD_Load(object sender, System.EventArgs e)
		{
			try
			{
				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;			
			}
			catch
			{

			}
		}	
	}
}

