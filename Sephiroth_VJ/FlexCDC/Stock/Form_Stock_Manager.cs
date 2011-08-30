using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Threading;

namespace FlexCDC.Stock
{
	public class Form_Stock_Manager : COM.PCHWinForm.Form_Top
	{
		#region 컨트롤정의 및 리소스정의 
		public System.Windows.Forms.Panel pnl_Top;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_grid;
		private C1.Win.C1List.C1Combo cmb_location;
		private System.Windows.Forms.Label lbl_color_name;
		private System.Windows.Forms.Label lbl_location;
		private C1.Win.C1List.C1Combo cmb_factory;
		public COM.FSP fgrid_stock;
		public C1.Win.C1List.C1Combo cmb_close_ym;
		private System.Windows.Forms.ContextMenu ctm_Mat;
		private System.Windows.Forms.MenuItem mnt_Insert;
		private System.Windows.Forms.Label lbl_material_name;
		private System.Windows.Forms.TextBox txt_material_name;
		private System.Windows.Forms.TextBox txt_color_name;
		private System.Windows.Forms.Label lbl_Close_YM;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.TextBox txt_Spec;
		private System.ComponentModel.IContainer components = null;

		public Form_Stock_Manager()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Stock_Manager));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.lbl_location = new System.Windows.Forms.Label();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_Spec = new System.Windows.Forms.TextBox();
			this.lbl_Spec = new System.Windows.Forms.Label();
			this.txt_color_name = new System.Windows.Forms.TextBox();
			this.lbl_material_name = new System.Windows.Forms.Label();
			this.txt_material_name = new System.Windows.Forms.TextBox();
			this.lbl_color_name = new System.Windows.Forms.Label();
			this.lbl_Close_YM = new System.Windows.Forms.Label();
			this.cmb_close_ym = new C1.Win.C1List.C1Combo();
			this.cmb_location = new C1.Win.C1List.C1Combo();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.btn_openfile = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pnl_grid = new System.Windows.Forms.Panel();
			this.fgrid_stock = new COM.FSP();
			this.ctm_Mat = new System.Windows.Forms.ContextMenu();
			this.mnt_Insert = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_close_ym)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_location)).BeginInit();
			this.pnl_grid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_stock)).BeginInit();
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
			this.lbl_MainTitle.Text = "PCC_Stock_Manager";
			// 
			// tbtn_Create
			// 
			this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// tbtn_Confirm
			// 
			this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.cmb_factory);
			this.pnl_Top.Controls.Add(this.lbl_location);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 64);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 96);
			this.pnl_Top.TabIndex = 138;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_factory.Caption = "";
			this.cmb_factory.CaptionHeight = 17;
			this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_factory.ColumnCaptionHeight = 18;
			this.cmb_factory.ColumnFooterHeight = 18;
			this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_factory.ContentHeight = 17;
			this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(117, 36);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(211, 21);
			this.cmb_factory.TabIndex = 350;
			this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
			// 
			// lbl_location
			// 
			this.lbl_location.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_location.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_location.ImageIndex = 0;
			this.lbl_location.ImageList = this.img_Label;
			this.lbl_location.Location = new System.Drawing.Point(344, 36);
			this.lbl_location.Name = "lbl_location";
			this.lbl_location.Size = new System.Drawing.Size(100, 21);
			this.lbl_location.TabIndex = 313;
			this.lbl_location.Text = "Location";
			this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
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
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Spec);
			this.pnl_SearchImage.Controls.Add(this.lbl_Spec);
			this.pnl_SearchImage.Controls.Add(this.txt_color_name);
			this.pnl_SearchImage.Controls.Add(this.lbl_material_name);
			this.pnl_SearchImage.Controls.Add(this.txt_material_name);
			this.pnl_SearchImage.Controls.Add(this.lbl_color_name);
			this.pnl_SearchImage.Controls.Add(this.lbl_Close_YM);
			this.pnl_SearchImage.Controls.Add(this.cmb_close_ym);
			this.pnl_SearchImage.Controls.Add(this.cmb_location);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_title);
			this.pnl_SearchImage.Controls.Add(this.btn_openfile);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.pictureBox7);
			this.pnl_SearchImage.Controls.Add(this.pictureBox8);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 88);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_Spec
			// 
			this.txt_Spec.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Spec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Spec.ForeColor = System.Drawing.Color.Black;
			this.txt_Spec.Location = new System.Drawing.Point(437, 58);
			this.txt_Spec.MaxLength = 100;
			this.txt_Spec.Name = "txt_Spec";
			this.txt_Spec.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Spec.Size = new System.Drawing.Size(211, 20);
			this.txt_Spec.TabIndex = 358;
			this.txt_Spec.Text = "";
			// 
			// lbl_Spec
			// 
			this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Spec.ImageIndex = 0;
			this.lbl_Spec.ImageList = this.img_Label;
			this.lbl_Spec.Location = new System.Drawing.Point(336, 58);
			this.lbl_Spec.Name = "lbl_Spec";
			this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec.TabIndex = 357;
			this.lbl_Spec.Text = "Spec";
			this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_color_name
			// 
			this.txt_color_name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_color_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_color_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_color_name.ForeColor = System.Drawing.Color.Black;
			this.txt_color_name.Location = new System.Drawing.Point(773, 58);
			this.txt_color_name.MaxLength = 100;
			this.txt_color_name.Name = "txt_color_name";
			this.txt_color_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_color_name.Size = new System.Drawing.Size(211, 20);
			this.txt_color_name.TabIndex = 356;
			this.txt_color_name.Text = "";
			// 
			// lbl_material_name
			// 
			this.lbl_material_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_material_name.ImageIndex = 0;
			this.lbl_material_name.ImageList = this.img_Label;
			this.lbl_material_name.Location = new System.Drawing.Point(7, 58);
			this.lbl_material_name.Name = "lbl_material_name";
			this.lbl_material_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_material_name.TabIndex = 354;
			this.lbl_material_name.Text = "Material";
			this.lbl_material_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_material_name
			// 
			this.txt_material_name.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_material_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_material_name.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_material_name.ForeColor = System.Drawing.Color.Black;
			this.txt_material_name.Location = new System.Drawing.Point(109, 58);
			this.txt_material_name.MaxLength = 100;
			this.txt_material_name.Name = "txt_material_name";
			this.txt_material_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_material_name.Size = new System.Drawing.Size(211, 20);
			this.txt_material_name.TabIndex = 0;
			this.txt_material_name.Text = "";
			// 
			// lbl_color_name
			// 
			this.lbl_color_name.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_color_name.ImageIndex = 0;
			this.lbl_color_name.ImageList = this.img_Label;
			this.lbl_color_name.Location = new System.Drawing.Point(672, 58);
			this.lbl_color_name.Name = "lbl_color_name";
			this.lbl_color_name.Size = new System.Drawing.Size(100, 21);
			this.lbl_color_name.TabIndex = 327;
			this.lbl_color_name.Text = "Color";
			this.lbl_color_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Close_YM
			// 
			this.lbl_Close_YM.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Close_YM.ImageIndex = 0;
			this.lbl_Close_YM.ImageList = this.img_Label;
			this.lbl_Close_YM.Location = new System.Drawing.Point(672, 36);
			this.lbl_Close_YM.Name = "lbl_Close_YM";
			this.lbl_Close_YM.Size = new System.Drawing.Size(100, 21);
			this.lbl_Close_YM.TabIndex = 353;
			this.lbl_Close_YM.Text = "Close";
			this.lbl_Close_YM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_close_ym
			// 
			this.cmb_close_ym.AddItemCols = 0;
			this.cmb_close_ym.AddItemSeparator = ';';
			this.cmb_close_ym.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_close_ym.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_close_ym.Caption = "";
			this.cmb_close_ym.CaptionHeight = 17;
			this.cmb_close_ym.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_close_ym.ColumnCaptionHeight = 18;
			this.cmb_close_ym.ColumnFooterHeight = 18;
			this.cmb_close_ym.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_close_ym.ContentHeight = 17;
			this.cmb_close_ym.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_close_ym.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_close_ym.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_close_ym.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_close_ym.EditorHeight = 17;
			this.cmb_close_ym.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_close_ym.GapHeight = 2;
			this.cmb_close_ym.ItemHeight = 15;
			this.cmb_close_ym.Location = new System.Drawing.Point(773, 36);
			this.cmb_close_ym.MatchEntryTimeout = ((long)(2000));
			this.cmb_close_ym.MaxDropDownItems = ((short)(5));
			this.cmb_close_ym.MaxLength = 32767;
			this.cmb_close_ym.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_close_ym.Name = "cmb_close_ym";
			this.cmb_close_ym.PartialRightColumn = false;
			this.cmb_close_ym.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_close_ym.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_close_ym.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_close_ym.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_close_ym.Size = new System.Drawing.Size(210, 21);
			this.cmb_close_ym.TabIndex = 352;
			// 
			// cmb_location
			// 
			this.cmb_location.AddItemCols = 0;
			this.cmb_location.AddItemSeparator = ';';
			this.cmb_location.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_location.Caption = "";
			this.cmb_location.CaptionHeight = 17;
			this.cmb_location.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_location.ColumnCaptionHeight = 18;
			this.cmb_location.ColumnFooterHeight = 18;
			this.cmb_location.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_location.ContentHeight = 17;
			this.cmb_location.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_location.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_location.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_location.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_location.EditorHeight = 17;
			this.cmb_location.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_location.GapHeight = 2;
			this.cmb_location.ItemHeight = 15;
			this.cmb_location.Location = new System.Drawing.Point(437, 36);
			this.cmb_location.MatchEntryTimeout = ((long)(2000));
			this.cmb_location.MaxDropDownItems = ((short)(5));
			this.cmb_location.MaxLength = 32767;
			this.cmb_location.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_location.Name = "cmb_location";
			this.cmb_location.PartialRightColumn = false;
			this.cmb_location.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_location.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_location.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_location.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_location.Size = new System.Drawing.Size(211, 21);
			this.cmb_location.TabIndex = 351;
			this.cmb_location.SelectedValueChanged += new System.EventHandler(this.cmb_location_SelectedValueChanged);
			// 
			// picb_TM
			// 
			this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
			this.picb_TM.Location = new System.Drawing.Point(219, 0);
			this.picb_TM.Name = "picb_TM";
			this.picb_TM.Size = new System.Drawing.Size(776, 32);
			this.picb_TM.TabIndex = 113;
			this.picb_TM.TabStop = false;
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
			this.lbl_title.Text = "      Stock Infomation";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 72);
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
			this.pictureBox8.Location = new System.Drawing.Point(150, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(1000, 48);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Location = new System.Drawing.Point(0, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.TabIndex = 0;
			this.pictureBox9.TabStop = false;
			// 
			// pnl_grid
			// 
			this.pnl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_grid.Controls.Add(this.fgrid_stock);
			this.pnl_grid.Location = new System.Drawing.Point(0, 164);
			this.pnl_grid.Name = "pnl_grid";
			this.pnl_grid.Size = new System.Drawing.Size(1016, 480);
			this.pnl_grid.TabIndex = 139;
			// 
			// fgrid_stock
			// 
			this.fgrid_stock.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_stock.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_stock.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_stock.ContextMenu = this.ctm_Mat;
			this.fgrid_stock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_stock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_stock.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_stock.Location = new System.Drawing.Point(0, 0);
			this.fgrid_stock.Name = "fgrid_stock";
			this.fgrid_stock.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_stock.Size = new System.Drawing.Size(1016, 480);
			this.fgrid_stock.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_stock.TabIndex = 105;
			this.fgrid_stock.DoubleClick += new System.EventHandler(this.fgrid_stock_DoubleClick);
			this.fgrid_stock.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_stock_AfterEdit);
			// 
			// ctm_Mat
			// 
			this.ctm_Mat.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnt_Insert});
			// 
			// mnt_Insert
			// 
			this.mnt_Insert.Index = 0;
			this.mnt_Insert.Text = "Insert Record";
			this.mnt_Insert.Click += new System.EventHandler(this.mnt_Insert_Click);
			// 
			// Form_Stock_Manager
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_grid);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_Stock_Manager";
			this.Load += new System.EventHandler(this.Form_Stock_Manager_Load);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_grid, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_close_ym)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_location)).EndInit();
			this.pnl_grid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_stock)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자정의 변수
		
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction  MyComFunction= new COM.ComFunction();

		string _stock_ymd  ="", _edit_type  ="";

		#endregion 

		#region 공통메쏘드

		private void  Init_Form()
		{


			try
			{
				this.Text = "PCC_Stock Manager";
				this.lbl_MainTitle.Text = "PCC_Stock Manager";
				this.lbl_title.Text = "      Stock Information";
				ClassLib.ComFunction.SetLangDic(this); 
				
				#region 버튼 권한

				tbtn_New.Enabled     = true;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = true;
				
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
					
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = true;			
				tbtn_Print.Enabled   = false;
				tbtn_Confirm.Enabled = true;
				tbtn_Create.Enabled  = true;

				//tbtn_Delete.ToolTipText ="Confirm Cancel";	
				tbtn_Confirm.ToolTipText ="Confirm";
				tbtn_Create.ToolTipText ="Create";

				

				#endregion 			



				//Location
				DataTable dt_list;
				dt_list = null;
				dt_list = ClassLib.ComFunction.Select_Stock_Location(cmb_factory.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_location,0,1,false,0,140);
				if (dt_list.Rows.Count != 0)  cmb_location.SelectedIndex = 0;			


				//SXK_STOCK
				fgrid_stock.Set_Grid_CDC("SXK_STOCK_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_stock.Set_Action_Image(img_Action);		
				
			}
			catch
			{
				//cmb_location  = null;
				//cmb_close_ym = null;	
				//ClassLib.ComFunction.User_Message (ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}


		private  void  DisPlay_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{

			for(int i=0; i<arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, fgrid_stock.Rows.Count, 1);
				fgrid_stock[i+ fgrid_stock.Rows.Fixed,0]=" "; 
					
			}

		}


		#endregion

		#region 이벤트 처리

		#region 버튼 컨트롤

		private void cmb_location_SelectedValueChanged(object sender, System.EventArgs e)
		{			
			try
			{
				//Stock Ym
				DataTable dt_list;

				dt_list = ClassLib.ComFunction.Select_Close_YM(cmb_factory.SelectedValue.ToString(),cmb_location.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_close_ym,1,1,false,0,140);
				if (dt_list.Rows.Count  !=0) 
					cmb_close_ym.SelectedIndex = 0;
			    else
					cmb_close_ym= null;
			}
			catch
			{
				//cmb_close_ym  = null;

			}

		}

		

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{

			ClassLib.ComVar.This_CDC_Factory = cmb_factory.SelectedValue.ToString();
			Init_Form();
		
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			fgrid_stock.Rows.Count  = fgrid_stock.Rows.Fixed;
			cmb_close_ym.SelectedIndex =0;

		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor  = Cursors.WaitCursor;
				fgrid_stock.Rows.Count  = fgrid_stock.Rows.Fixed;			
				
				if (cmb_close_ym.Text.Length ==0) 
				{
					ClassLib.ComFunction.User_Message("Input Error : Closing Date",  "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				
				#region   Stock day지정

				string div = ":";
				string[] stock_no_div = null;
				string stock_no = "";
				string stock_no_status = "";

				stock_no_div    = cmb_close_ym.GetItemText(cmb_close_ym.SelectedIndex,1).Split(div.ToCharArray());
				stock_no        = stock_no_div[1];
				stock_no_status = stock_no_div[0].Trim();
				_stock_ymd      = stock_no_div[1].Trim();

				#endregion  

				DataTable  dt_list ;				

				if(stock_no_status == "Ready")
				{
					fgrid_stock.Set_Grid_CDC("SXK_STOCK_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					fgrid_stock.Set_Action_Image(img_Action);		
					dt_list = Search_Ready_List();					
					
					fgrid_stock.AllowEditing = true;
//					fgrid_stock.Cols[(int)ClassLib.TBSXK_STOCK.lxADJUST_DESC].AllowEditing  = true;
//					fgrid_stock.Cols[(int)ClassLib.TBSXK_STOCK.lxVALUE_ADJUST].AllowEditing = true;
//					fgrid_stock.Cols[(int)ClassLib.TBSXK_STOCK.lxREMARKS].AllowEditing= true;      
				}
				else
				{
					fgrid_stock.Set_Grid_CDC("SXK_STOCK_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
					fgrid_stock.Set_Action_Image(img_Action);	

					dt_list  =Search_Confirm_List();

					fgrid_stock.AllowEditing = false;
				}

				DisPlay_Grid(dt_list, fgrid_stock);
			}
			catch
			{

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch,this);

			}
			finally
			{
				this.Cursor  = Cursors.Default; 
			}

		}


		private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
			
				
				
				if (cmb_close_ym.Text.Length ==0) 
				{
                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotHaveData, this);
					return;

				}
							
				    

				#region confirm Check

				string div = ":";
				string[] stock_no_div = null;
				string stock_no = "";
				string stock_no_status = "";

				
				
				

				stock_no_div = cmb_close_ym.GetItemText(cmb_close_ym.SelectedIndex,0).Split(div.ToCharArray());
				
				stock_no = stock_no_div[1];
				stock_no_status =stock_no_div[0].Trim();
				_stock_ymd =stock_no_div[1].Trim();

				if(stock_no_div[0].Trim().Substring(0,1)  == ClassLib.ComVar.ConsCDC_R)
				{
					return;					
				}	

				_stock_ymd = 			
					Convert.ToDateTime(MyComFunction.ConvertDate2Type(_stock_ymd+"20")).AddMonths(1).ToString("yyyy-MM-dd HH:mm:ss").Replace("-","").Substring(0,6);

				DataTable dt_list  = Check_Stock_Info();

				if (dt_list.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsCDC_C)
				{
                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
					return;
				}


				
				#endregion

				this.Cursor  = Cursors.WaitCursor;

				fgrid_stock.Rows.Count  = fgrid_stock.Rows.Fixed;

				Create_Stock_Base();

							
				//Stock Ym
				dt_list = ClassLib.ComFunction.Select_Close_YM(cmb_factory.SelectedValue.ToString(),cmb_location.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_close_ym, 1, 1, false, 0, 140);
				cmb_close_ym.SelectedIndex = 0;


				tbtn_Search_Click(null,null);	
		
				

			}
			catch
			{

                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);

			}
			finally
			{
				this.Cursor  = Cursors.Default; 
			}
		}


		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
			
				if(fgrid_stock.Rows.Fixed == fgrid_stock.Rows.Count)
				{
					return;
				}
				if (cmb_close_ym.Text.Length ==0) 
				{
                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotHaveData, this);
					return;
				}
                				
				#region confirm Check
				
				
				
				string div = ":";
				string[] stock_no_div = null;
				string stock_no = "";
				string stock_no_status = "";

				stock_no_div = cmb_close_ym.GetItemText(cmb_close_ym.SelectedIndex,1).Split(div.ToCharArray());
				stock_no = stock_no_div[1];
				stock_no_status =stock_no_div[0].Trim();
				_stock_ymd =stock_no_div[1].Trim();

				DataTable dt_list  = Check_Stock_Info();

				if (dt_list.Rows[0].ItemArray[0].ToString() == ClassLib.ComVar.ConsCDC_C )
				{

                    ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);

					return;

				}
				#endregion

				this.Cursor  = Cursors.WaitCursor;

				fgrid_stock.Rows.Count  = fgrid_stock.Rows.Fixed;



				Save_Confrim_Stock();

							
				//Stock Ym
				dt_list = ClassLib.ComFunction.Select_Close_YM(cmb_factory.SelectedValue.ToString(),cmb_location.SelectedValue.ToString());
				ClassLib.ComCtl.Set_ComboList(dt_list, cmb_close_ym,1,1,false,0,140);
				cmb_close_ym.SelectedIndex = 0;


				tbtn_Search_Click(null,null);


				

			}
			catch
			{

                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);

			}
			finally
			{
				this.Cursor  = Cursors.Default; 
			}

		
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				if(fgrid_stock.Rows.Fixed == fgrid_stock.Rows.Count)
				{
					return;
				}

				if (cmb_close_ym.Text.Length ==0)
				{
					ClassLib.ComFunction.User_Message("CloseDate Is Empty.");
					return;
				}

				#region  stock ymd설정

				string div = ":";
				string[] stock_no_div = null;
				string stock_no = "";
				string stock_no_status = "";

				stock_no_div = cmb_close_ym.GetItemText(cmb_close_ym.SelectedIndex,1).Split(div.ToCharArray());
				stock_no = stock_no_div[1];
				stock_no_status =stock_no_div[0].Trim();
				_stock_ymd =stock_no_div[1].Trim();

				# endregion 


				for( int i  =0; i<fgrid_stock.Rows.Count  ; i++)
				{
					if ((fgrid_stock[i,0] == null) || (fgrid_stock[i,0].ToString() == "")|| (fgrid_stock[i,0].ToString() == " ")) continue;

					if (fgrid_stock[i,0].ToString() == "I")
					{Insert_Stock_Row(i);   fgrid_stock[i,0] ="";}
					else
					{Update_Stock_Row(i);  fgrid_stock[i,0] ="";}
				}

			
			}
			catch
			{

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave,this);

			}
			finally
			{
				
				this.Cursor  = Cursors.Default; 
				
			}
		}




		#endregion 


		#region 그리드 컨트롤

		private void mnt_Insert_Click(object sender, System.EventArgs e)
		{
			
		

			fgrid_stock.Rows.Count  = fgrid_stock.Rows.Count  +1;

			int sct_row = fgrid_stock.Rows.Count-1;

			for (int i = 0; i<fgrid_stock.Cols.Count  ;i++) 
			fgrid_stock[fgrid_stock.Rows.Count-1,i] ="";										   

			

		

			_edit_type = null;

			_edit_type = "M";


			#region 공통 코드 팝업
			int vCount = 16;
			COM.ComVar.Parameter_PopUp = new string[vCount];
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY -1] = cmb_factory.SelectedValue.ToString();
		
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1] = " ";

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1] = " ";
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1] = " ";
					
					
					


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1] = " ";
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1] = " ";
			


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1] = " ";
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1] = " ";


			#endregion

			BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(_edit_type);
			codeMaster.ShowDialog();

			#region 공통 코드 팝업 다운
		
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxFACTORY] = "I";	
			
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxLOCATION] = cmb_location.SelectedValue.ToString();
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1];
					
					
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1];
			
					
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.IxPCC_SPEC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxSPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxSTOCK_YMD1] = _stock_ymd;
		
					

			fgrid_stock.TopRow = fgrid_stock.Rows.Count -1;
			fgrid_stock.Select( fgrid_stock.Rows.Count -1,0, fgrid_stock.Rows.Count -1,fgrid_stock.Cols.Count-1,false);
			fgrid_stock[fgrid_stock.Rows.Count -1,0] ="I";
			#endregion 

		
		}

		


		private void fgrid_stock_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			if(fgrid_stock[fgrid_stock.Selection.r1,0].ToString() =="I") return;
			fgrid_stock[fgrid_stock.Selection.r1,0]="U";

		}

		private void fgrid_stock_DoubleClick(object sender, System.EventArgs e)
		{
		

			int sct_row = fgrid_stock.Selection.r1;
			int sct_col = fgrid_stock.Selection.c1;


		

			_edit_type = null;

			 if(sct_col >= (int)ClassLib.TBSXK_STOCK.lxMAT_CD && sct_col <= (int)ClassLib.TBSXK_STOCK.lxMAT_COMMENT)
			{
				
				_edit_type = "M";
			}
			else if(sct_col >= (int)ClassLib.TBSXK_STOCK.lxCOLOR && sct_col <= (int)ClassLib.TBSXK_STOCK.lxCOLOR_DESC)
			{
				
				_edit_type = "C";
			}
			else if(sct_col >= (int)ClassLib.TBSXK_STOCK.lxSPEC_NAME && sct_col <= (int)ClassLib.TBSXK_STOCK.lxSPEC_NAME)
			{
				
				_edit_type = "U";
			}


			if(_edit_type == null) return;



			#region 공통 코드 팝업
			int vCount = 16;
			COM.ComVar.Parameter_PopUp = new string[vCount];

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY -1] = cmb_factory.SelectedValue.ToString();

		
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_CD].ToString();

			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_COMMENT].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_DESC].ToString();
					
					
					


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR_DESC].ToString();
			


			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.IxPCC_SPEC].ToString();
			COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1] = fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxSPEC_NAME].ToString();


			#endregion

			BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(_edit_type);
			codeMaster.ShowDialog();


			#region 공통 팝업 다운
			if(!fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxDIVISION].ToString().Equals("I"))
			{

				fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxDIVISION] = "U";
			}

		
					
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_CD] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_COMMENT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_COMMENT -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxMAT_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxMAT_NAME -1];
					
					
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxCOLOR_DESC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC -1];
			
					
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.IxPCC_SPEC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD -1];
			fgrid_stock[sct_row, (int)ClassLib.TBSXK_STOCK.lxSPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME -1];
					

			#endregion 


		
		}



		#endregion 

		#endregion 

		#region DB 컨넥트
		private void Insert_Stock_Row(int rows)
		{
			string Proc_Name = "PKG_SXK_STOCK_01.INSERT_SXK_STOCK_CLOSE";

			int vCnt  = 21, a=0, b=0 ,c=0;

			MyOraDB.ReDim_Parameter(vCnt);
			MyOraDB.Process_Name = Proc_Name ;



			MyOraDB.Parameter_Name[a++]  = "ARG_FACTORY";       
			MyOraDB.Parameter_Name[a++]  = "ARG_LOCATION";         
			MyOraDB.Parameter_Name[a++]  = "ARG_STOCK_YM";         
			MyOraDB.Parameter_Name[a++]  = "ARG_MAT_CD";           	
			MyOraDB.Parameter_Name[a++]  = "ARG_PCC_SPEC_CD";      
			MyOraDB.Parameter_Name[a++]  = "ARG_COLOR_CD";  
       
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_INIT";      
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_IN";         
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_OUT";        
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_STOCK";      
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_ADJUST";  
   
			MyOraDB.Parameter_Name[a++]  = "ARG_ADJUST_REASON"; 
			MyOraDB.Parameter_Name[a++]  = "ARG_PUR_CURRENCY";     
			MyOraDB.Parameter_Name[a++]  = "ARG_PUR_PRICE";        
			MyOraDB.Parameter_Name[a++]  = "ARG_OUTSIDE_CURRENCY"; 
			MyOraDB.Parameter_Name[a++]  = "ARG_OUTSIDE_PRICE";  
  
			MyOraDB.Parameter_Name[a++]  = "ARG_CBD_CURRENCY";     
			MyOraDB.Parameter_Name[a++]  = "ARG_CBD_PRICE";        
			MyOraDB.Parameter_Name[a++]  = "ARG_STATUS";           
			MyOraDB.Parameter_Name[a++]  = "ARG_REMARKS";          
			MyOraDB.Parameter_Name[a++]  = "ARG_UPD_USER";         




			for (int  i=0;  i < vCnt ; i++)
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			
			
			

			MyOraDB.Parameter_Values[c++]  = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++]  = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++]  = _stock_ymd;
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxMAT_CD].ToString();
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.IxPCC_SPEC].ToString();
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxCOLOR].ToString();

			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_INIT].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_IN].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_OUT].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String( fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_STOCK].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_ADJUST].ToString(),"0");


			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxADJUST_DESC].ToString()," ");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxPUR_CURRENCY].ToString()," ");
			MyOraDB.Parameter_Values[c++]  =  ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxPUR_PRICE].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  = " ";
			MyOraDB.Parameter_Values[c++]  = "0";			

			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxCBD_CURRENCY].ToString()," ");
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String( fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxCBD_PRICE].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxSTATUS].ToString()," ");
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String( fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxREMARKS].ToString()," ");
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComVar.This_User;
			
			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
			
		}


		private void Update_Stock_Row(int rows)
		{
			string Proc_Name = "PKG_SXK_STOCK_01.UPDATE_SXK_STOCK_CLOSE";

			int vCnt  = 10, a=0, b=0 ,c=0;

			MyOraDB.ReDim_Parameter(vCnt);
			MyOraDB.Process_Name = Proc_Name ;


			MyOraDB.Parameter_Name[a++]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++]  = "ARG_LOCATION";
			MyOraDB.Parameter_Name[a++]  = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[a++]  = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[a++]  = "ARG_PCC_SPEC_CD";
			MyOraDB.Parameter_Name[a++]  = "ARG_COLOR_CD";			
			MyOraDB.Parameter_Name[a++]  = "ARG_VALUE_ADJUST";
			MyOraDB.Parameter_Name[a++]  = "ARG_ADJUST_REASON";
			MyOraDB.Parameter_Name[a++]  = "ARG_REMARKS";
			MyOraDB.Parameter_Name[a++] =  "ARG_UPD_USER";

			for (int  i=0;  i < vCnt ; i++)
				MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;


			MyOraDB.Parameter_Values[c++]  = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++]  = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++]  = _stock_ymd;
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxMAT_CD].ToString();
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.IxPCC_SPEC].ToString();
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxCOLOR].ToString();
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxVALUE_ADJUST].ToString(),"0");
			MyOraDB.Parameter_Values[c++]  = ClassLib.ComFunction.Empty_String(fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxADJUST_DESC].ToString()," ");
			MyOraDB.Parameter_Values[c++]  = fgrid_stock[rows,(int)ClassLib.TBSXK_STOCK.lxREMARKS].ToString();
			MyOraDB.Parameter_Values[c++] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
			
		}

		
		private DataTable Check_Stock_Info()
		{
			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.CHECK_SXK_STOCK_INFO";
			MyOraDB.ReDim_Parameter(4);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = _stock_ymd;
			MyOraDB.Parameter_Values[3] = "";


			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




		private DataTable Search_Ready_List()
		{
			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXK_STOCK_BASE_CREATE";
			MyOraDB.ReDim_Parameter(7);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[3] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[4] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_SPEC_DESC";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] =_stock_ymd;
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_material_name," ").ToUpper();
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_TextBox(txt_color_name," ").ToUpper();
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_Spec," ").ToUpper();
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}




		private DataTable Search_Confirm_List()
		{
			

			string Proc_Name = "PKG_SXK_STOCK_01_SELECT.SELECT_SXK_STOCK_MANAGER";
			MyOraDB.ReDim_Parameter(7);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[3] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[4] = "ARG_COLOR_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_SPEC_DESC";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] =_stock_ymd;
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_material_name," ").ToUpper();
			MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.Empty_TextBox(txt_color_name," ").ToUpper();
			MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_TextBox(txt_Spec," ").ToUpper();
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}

		private void Create_Stock_Base()
		{
			string Proc_Name = "PKG_SXK_STOCK_01.ADD_SXK_STOCK_CLOSE";

			MyOraDB.ReDim_Parameter(4);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;


			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = _stock_ymd;
			MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}


		private void Save_Confrim_Stock()
		{
			string Proc_Name = "PKG_SXK_STOCK_01.SAVE_CONFORM_SXK_STOCK_CLOSE";

			MyOraDB.ReDim_Parameter(4);
			MyOraDB.Process_Name = Proc_Name ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LOCATION";
			MyOraDB.Parameter_Name[2] = "ARG_STOCK_YM";
			MyOraDB.Parameter_Name[3] = "ARG_UPD_USER";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;


			MyOraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_location.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] =  _stock_ymd;
			MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}




		#endregion 


		private void Form_Stock_Manager_Load(object sender, System.EventArgs e)
		{

			
			// Factory Combobox Add Items
			DataTable dt_list;
			dt_list = COM.ComFunction.Select_Factory_List_CDC();
			COM.ComCtl.Set_ComboList(dt_list, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;
		


			Init_Form();
		}

		

	

	}
}

