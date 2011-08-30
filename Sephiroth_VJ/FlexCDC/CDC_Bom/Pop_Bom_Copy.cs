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
using System.IO;


namespace FlexCDC.CDC_Bom
{
	public class Pop_Bom_Copy : COM.PCHWinForm.Pop_Large_B
	{
		#region 컨트롤정의 및 리소스 정의 
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.TextBox txt_bomrev;
		private System.Windows.Forms.TextBox txt_bomid;
		private C1.Win.C1List.C1Combo cmb_Sampletypes;
		private System.Windows.Forms.Label lbl_Sampletypes;
		private System.Windows.Forms.TextBox txt_Srno;
		private System.Windows.Forms.Label lbl_Srno;
		private System.Windows.Forms.TextBox txt_Srfno;
		private System.Windows.Forms.Label lbl_Srfno;
		private System.Windows.Forms.Label lbl_Bom;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Panel pnl_grid;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel2;
		private C1.Win.C1List.C1Combo c1Combo2;
		private System.Windows.Forms.Label lbl_Copy_Factory;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_Copy_Label;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1List.C1Combo cmb_Copy_Sampletypes;
		private System.Windows.Forms.TextBox txt_Copy_Srfno;
		private System.Windows.Forms.Label lbl_Copy_Srfno;
		private System.Windows.Forms.TextBox txt_Copy_Bomrev;
		private System.Windows.Forms.TextBox txt_Copy_bomid;
		private System.Windows.Forms.Label lbl_Copy_Bom;
		public COM.FSP fgrid_Bom;
		private System.Windows.Forms.Label lbl_Copy_Sampletypes;
		private System.Windows.Forms.TextBox txt_Copy_Srno;
		private System.Windows.Forms.Label lbl_Copy_Srno;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.ComponentModel.IContainer components = null;

		
		public Pop_Bom_Copy()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Bom_Copy));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.cmb_Sampletypes = new C1.Win.C1List.C1Combo();
			this.lbl_Sampletypes = new System.Windows.Forms.Label();
			this.txt_Srno = new System.Windows.Forms.TextBox();
			this.lbl_Srno = new System.Windows.Forms.Label();
			this.txt_Srfno = new System.Windows.Forms.TextBox();
			this.lbl_Srfno = new System.Windows.Forms.Label();
			this.txt_bomrev = new System.Windows.Forms.TextBox();
			this.txt_bomid = new System.Windows.Forms.TextBox();
			this.lbl_Bom = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_grid = new System.Windows.Forms.Panel();
			this.fgrid_Bom = new COM.FSP();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cmb_Copy_Sampletypes = new C1.Win.C1List.C1Combo();
			this.lbl_Copy_Sampletypes = new System.Windows.Forms.Label();
			this.txt_Copy_Srno = new System.Windows.Forms.TextBox();
			this.lbl_Copy_Srno = new System.Windows.Forms.Label();
			this.txt_Copy_Srfno = new System.Windows.Forms.TextBox();
			this.lbl_Copy_Srfno = new System.Windows.Forms.Label();
			this.txt_Copy_Bomrev = new System.Windows.Forms.TextBox();
			this.txt_Copy_bomid = new System.Windows.Forms.TextBox();
			this.lbl_Copy_Bom = new System.Windows.Forms.Label();
			this.c1Combo2 = new C1.Win.C1List.C1Combo();
			this.lbl_Copy_Factory = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_Copy_Label = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).BeginInit();
			this.pnl_grid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Bom)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Copy_Sampletypes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(529, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(752, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_Search
			// 
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(820, 96);
			this.pnl_Search.TabIndex = 38;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.cmb_Sampletypes);
			this.pnl_SearchImage.Controls.Add(this.lbl_Sampletypes);
			this.pnl_SearchImage.Controls.Add(this.txt_Srno);
			this.pnl_SearchImage.Controls.Add(this.lbl_Srno);
			this.pnl_SearchImage.Controls.Add(this.txt_Srfno);
			this.pnl_SearchImage.Controls.Add(this.lbl_Srfno);
			this.pnl_SearchImage.Controls.Add(this.txt_bomrev);
			this.pnl_SearchImage.Controls.Add(this.txt_bomid);
			this.pnl_SearchImage.Controls.Add(this.lbl_Bom);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_title);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(804, 80);
			this.pnl_SearchImage.TabIndex = 19;
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
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 17;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(117, 32);
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
			this.cmb_Factory.Size = new System.Drawing.Size(120, 21);
			this.cmb_Factory.TabIndex = 359;
			// 
			// cmb_Sampletypes
			// 
			this.cmb_Sampletypes.AddItemCols = 0;
			this.cmb_Sampletypes.AddItemSeparator = ';';
			this.cmb_Sampletypes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Sampletypes.Caption = "";
			this.cmb_Sampletypes.CaptionHeight = 17;
			this.cmb_Sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Sampletypes.ColumnCaptionHeight = 18;
			this.cmb_Sampletypes.ColumnFooterHeight = 18;
			this.cmb_Sampletypes.ContentHeight = 17;
			this.cmb_Sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Sampletypes.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Sampletypes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Sampletypes.EditorHeight = 17;
			this.cmb_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Sampletypes.GapHeight = 2;
			this.cmb_Sampletypes.ItemHeight = 15;
			this.cmb_Sampletypes.Location = new System.Drawing.Point(584, 32);
			this.cmb_Sampletypes.MatchEntryTimeout = ((long)(2000));
			this.cmb_Sampletypes.MaxDropDownItems = ((short)(5));
			this.cmb_Sampletypes.MaxLength = 32767;
			this.cmb_Sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Sampletypes.Name = "cmb_Sampletypes";
			this.cmb_Sampletypes.PartialRightColumn = false;
			this.cmb_Sampletypes.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Sampletypes.Size = new System.Drawing.Size(120, 21);
			this.cmb_Sampletypes.TabIndex = 358;
			// 
			// lbl_Sampletypes
			// 
			this.lbl_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Sampletypes.ImageIndex = 0;
			this.lbl_Sampletypes.ImageList = this.img_Label;
			this.lbl_Sampletypes.Location = new System.Drawing.Point(480, 32);
			this.lbl_Sampletypes.Name = "lbl_Sampletypes";
			this.lbl_Sampletypes.Size = new System.Drawing.Size(100, 21);
			this.lbl_Sampletypes.TabIndex = 357;
			this.lbl_Sampletypes.Tag = "21";
			this.lbl_Sampletypes.Text = "Sample Types";
			this.lbl_Sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Srno
			// 
			this.txt_Srno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Srno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Srno.ForeColor = System.Drawing.Color.Black;
			this.txt_Srno.Location = new System.Drawing.Point(352, 32);
			this.txt_Srno.MaxLength = 100;
			this.txt_Srno.Name = "txt_Srno";
			this.txt_Srno.ReadOnly = true;
			this.txt_Srno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Srno.Size = new System.Drawing.Size(120, 20);
			this.txt_Srno.TabIndex = 356;
			this.txt_Srno.Text = "";
			// 
			// lbl_Srno
			// 
			this.lbl_Srno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Srno.ImageIndex = 0;
			this.lbl_Srno.ImageList = this.img_Label;
			this.lbl_Srno.Location = new System.Drawing.Point(248, 32);
			this.lbl_Srno.Name = "lbl_Srno";
			this.lbl_Srno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Srno.TabIndex = 355;
			this.lbl_Srno.Tag = "21";
			this.lbl_Srno.Text = "Sample Req.#";
			this.lbl_Srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Srfno
			// 
			this.txt_Srfno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Srfno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Srfno.ForeColor = System.Drawing.Color.Black;
			this.txt_Srfno.Location = new System.Drawing.Point(117, 55);
			this.txt_Srfno.MaxLength = 100;
			this.txt_Srfno.Name = "txt_Srfno";
			this.txt_Srfno.ReadOnly = true;
			this.txt_Srfno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Srfno.Size = new System.Drawing.Size(120, 20);
			this.txt_Srfno.TabIndex = 354;
			this.txt_Srfno.Text = "";
			// 
			// lbl_Srfno
			// 
			this.lbl_Srfno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Srfno.ImageIndex = 0;
			this.lbl_Srfno.ImageList = this.img_Label;
			this.lbl_Srfno.Location = new System.Drawing.Point(16, 55);
			this.lbl_Srfno.Name = "lbl_Srfno";
			this.lbl_Srfno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Srfno.TabIndex = 353;
			this.lbl_Srfno.Tag = "21";
			this.lbl_Srfno.Text = "SRF No";
			this.lbl_Srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_bomrev
			// 
			this.txt_bomrev.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_bomrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_bomrev.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_bomrev.ForeColor = System.Drawing.Color.Black;
			this.txt_bomrev.Location = new System.Drawing.Point(432, 55);
			this.txt_bomrev.MaxLength = 100;
			this.txt_bomrev.Name = "txt_bomrev";
			this.txt_bomrev.ReadOnly = true;
			this.txt_bomrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_bomrev.Size = new System.Drawing.Size(39, 20);
			this.txt_bomrev.TabIndex = 352;
			this.txt_bomrev.Text = "";
			// 
			// txt_bomid
			// 
			this.txt_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_bomid.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_bomid.ForeColor = System.Drawing.Color.Black;
			this.txt_bomid.Location = new System.Drawing.Point(352, 55);
			this.txt_bomid.MaxLength = 100;
			this.txt_bomid.Name = "txt_bomid";
			this.txt_bomid.ReadOnly = true;
			this.txt_bomid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_bomid.Size = new System.Drawing.Size(80, 20);
			this.txt_bomid.TabIndex = 351;
			this.txt_bomid.Text = "";
			// 
			// lbl_Bom
			// 
			this.lbl_Bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Bom.ImageIndex = 0;
			this.lbl_Bom.ImageList = this.img_Label;
			this.lbl_Bom.Location = new System.Drawing.Point(248, 55);
			this.lbl_Bom.Name = "lbl_Bom";
			this.lbl_Bom.Size = new System.Drawing.Size(100, 21);
			this.lbl_Bom.TabIndex = 350;
			this.lbl_Bom.Tag = "21";
			this.lbl_Bom.Text = "BOM Id/Rev";
			this.lbl_Bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(16, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 348;
			this.lbl_Factory.Tag = "0";
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(703, 25);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(101, 40);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(788, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(580, 32);
			this.picb_TM.TabIndex = 0;
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
			this.lbl_title.Tag = "";
			this.lbl_title.Text = "      Bom Information";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(788, 65);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 64);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(644, 18);
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
			this.picb_ML.Size = new System.Drawing.Size(211, 47);
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
			this.picb_MM.Size = new System.Drawing.Size(636, 40);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_grid
			// 
			this.pnl_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_grid.Controls.Add(this.fgrid_Bom);
			this.pnl_grid.Location = new System.Drawing.Point(0, 160);
			this.pnl_grid.Name = "pnl_grid";
			this.pnl_grid.Size = new System.Drawing.Size(816, 312);
			this.pnl_grid.TabIndex = 108;
			// 
			// fgrid_Bom
			// 
			this.fgrid_Bom.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Bom.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Bom.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_Bom.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Bom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Bom.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Bom.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Bom.Name = "fgrid_Bom";
			this.fgrid_Bom.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Bom.Size = new System.Drawing.Size(816, 312);
			this.fgrid_Bom.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Bom.TabIndex = 104;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.DockPadding.All = 8;
			this.panel1.Location = new System.Drawing.Point(0, 470);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(816, 96);
			this.panel1.TabIndex = 109;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.cmb_Copy_Sampletypes);
			this.panel2.Controls.Add(this.lbl_Copy_Sampletypes);
			this.panel2.Controls.Add(this.txt_Copy_Srno);
			this.panel2.Controls.Add(this.lbl_Copy_Srno);
			this.panel2.Controls.Add(this.txt_Copy_Srfno);
			this.panel2.Controls.Add(this.lbl_Copy_Srfno);
			this.panel2.Controls.Add(this.txt_Copy_Bomrev);
			this.panel2.Controls.Add(this.txt_Copy_bomid);
			this.panel2.Controls.Add(this.lbl_Copy_Bom);
			this.panel2.Controls.Add(this.c1Combo2);
			this.panel2.Controls.Add(this.lbl_Copy_Factory);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.lbl_Copy_Label);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox6);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(8, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 80);
			this.panel2.TabIndex = 19;
			// 
			// cmb_Copy_Sampletypes
			// 
			this.cmb_Copy_Sampletypes.AddItemCols = 0;
			this.cmb_Copy_Sampletypes.AddItemSeparator = ';';
			this.cmb_Copy_Sampletypes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Copy_Sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Copy_Sampletypes.Caption = "";
			this.cmb_Copy_Sampletypes.CaptionHeight = 17;
			this.cmb_Copy_Sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Copy_Sampletypes.ColumnCaptionHeight = 18;
			this.cmb_Copy_Sampletypes.ColumnFooterHeight = 18;
			this.cmb_Copy_Sampletypes.ContentHeight = 17;
			this.cmb_Copy_Sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Copy_Sampletypes.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Copy_Sampletypes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Copy_Sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Copy_Sampletypes.EditorHeight = 17;
			this.cmb_Copy_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Copy_Sampletypes.GapHeight = 2;
			this.cmb_Copy_Sampletypes.ItemHeight = 15;
			this.cmb_Copy_Sampletypes.Location = new System.Drawing.Point(584, 32);
			this.cmb_Copy_Sampletypes.MatchEntryTimeout = ((long)(2000));
			this.cmb_Copy_Sampletypes.MaxDropDownItems = ((short)(5));
			this.cmb_Copy_Sampletypes.MaxLength = 32767;
			this.cmb_Copy_Sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Copy_Sampletypes.Name = "cmb_Copy_Sampletypes";
			this.cmb_Copy_Sampletypes.PartialRightColumn = false;
			this.cmb_Copy_Sampletypes.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Copy_Sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Copy_Sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Copy_Sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Copy_Sampletypes.Size = new System.Drawing.Size(120, 21);
			this.cmb_Copy_Sampletypes.TabIndex = 358;
			// 
			// lbl_Copy_Sampletypes
			// 
			this.lbl_Copy_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Sampletypes.ImageIndex = 0;
			this.lbl_Copy_Sampletypes.ImageList = this.img_Label;
			this.lbl_Copy_Sampletypes.Location = new System.Drawing.Point(480, 32);
			this.lbl_Copy_Sampletypes.Name = "lbl_Copy_Sampletypes";
			this.lbl_Copy_Sampletypes.Size = new System.Drawing.Size(100, 21);
			this.lbl_Copy_Sampletypes.TabIndex = 357;
			this.lbl_Copy_Sampletypes.Tag = "21";
			this.lbl_Copy_Sampletypes.Text = "Sample Types";
			this.lbl_Copy_Sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Copy_Srno
			// 
			this.txt_Copy_Srno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Copy_Srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Copy_Srno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Copy_Srno.ForeColor = System.Drawing.Color.Black;
			this.txt_Copy_Srno.Location = new System.Drawing.Point(352, 32);
			this.txt_Copy_Srno.MaxLength = 100;
			this.txt_Copy_Srno.Name = "txt_Copy_Srno";
			this.txt_Copy_Srno.ReadOnly = true;
			this.txt_Copy_Srno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Copy_Srno.Size = new System.Drawing.Size(120, 20);
			this.txt_Copy_Srno.TabIndex = 356;
			this.txt_Copy_Srno.Text = " ";
			this.txt_Copy_Srno.TextChanged += new System.EventHandler(this.txt_Copy_Srno_TextChanged);
			// 
			// lbl_Copy_Srno
			// 
			this.lbl_Copy_Srno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Srno.ImageIndex = 0;
			this.lbl_Copy_Srno.ImageList = this.img_Label;
			this.lbl_Copy_Srno.Location = new System.Drawing.Point(248, 32);
			this.lbl_Copy_Srno.Name = "lbl_Copy_Srno";
			this.lbl_Copy_Srno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Copy_Srno.TabIndex = 355;
			this.lbl_Copy_Srno.Tag = "21";
			this.lbl_Copy_Srno.Text = "Sample Req.#";
			this.lbl_Copy_Srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Copy_Srfno
			// 
			this.txt_Copy_Srfno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Copy_Srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Copy_Srfno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Copy_Srfno.ForeColor = System.Drawing.Color.Black;
			this.txt_Copy_Srfno.Location = new System.Drawing.Point(120, 55);
			this.txt_Copy_Srfno.MaxLength = 100;
			this.txt_Copy_Srfno.Name = "txt_Copy_Srfno";
			this.txt_Copy_Srfno.ReadOnly = true;
			this.txt_Copy_Srfno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Copy_Srfno.Size = new System.Drawing.Size(120, 20);
			this.txt_Copy_Srfno.TabIndex = 354;
			this.txt_Copy_Srfno.Text = "";
			// 
			// lbl_Copy_Srfno
			// 
			this.lbl_Copy_Srfno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Srfno.ImageIndex = 0;
			this.lbl_Copy_Srfno.ImageList = this.img_Label;
			this.lbl_Copy_Srfno.Location = new System.Drawing.Point(16, 55);
			this.lbl_Copy_Srfno.Name = "lbl_Copy_Srfno";
			this.lbl_Copy_Srfno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Copy_Srfno.TabIndex = 353;
			this.lbl_Copy_Srfno.Tag = "21";
			this.lbl_Copy_Srfno.Text = "SRF No";
			this.lbl_Copy_Srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Copy_Bomrev
			// 
			this.txt_Copy_Bomrev.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Copy_Bomrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Copy_Bomrev.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Copy_Bomrev.ForeColor = System.Drawing.Color.Black;
			this.txt_Copy_Bomrev.Location = new System.Drawing.Point(432, 55);
			this.txt_Copy_Bomrev.MaxLength = 100;
			this.txt_Copy_Bomrev.Name = "txt_Copy_Bomrev";
			this.txt_Copy_Bomrev.ReadOnly = true;
			this.txt_Copy_Bomrev.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Copy_Bomrev.Size = new System.Drawing.Size(39, 20);
			this.txt_Copy_Bomrev.TabIndex = 352;
			this.txt_Copy_Bomrev.Text = "";
			// 
			// txt_Copy_bomid
			// 
			this.txt_Copy_bomid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Copy_bomid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Copy_bomid.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Copy_bomid.ForeColor = System.Drawing.Color.Black;
			this.txt_Copy_bomid.Location = new System.Drawing.Point(352, 55);
			this.txt_Copy_bomid.MaxLength = 100;
			this.txt_Copy_bomid.Name = "txt_Copy_bomid";
			this.txt_Copy_bomid.ReadOnly = true;
			this.txt_Copy_bomid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Copy_bomid.Size = new System.Drawing.Size(80, 20);
			this.txt_Copy_bomid.TabIndex = 351;
			this.txt_Copy_bomid.Text = "";
			// 
			// lbl_Copy_Bom
			// 
			this.lbl_Copy_Bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Bom.ImageIndex = 0;
			this.lbl_Copy_Bom.ImageList = this.img_Label;
			this.lbl_Copy_Bom.Location = new System.Drawing.Point(248, 55);
			this.lbl_Copy_Bom.Name = "lbl_Copy_Bom";
			this.lbl_Copy_Bom.Size = new System.Drawing.Size(100, 21);
			this.lbl_Copy_Bom.TabIndex = 350;
			this.lbl_Copy_Bom.Tag = "21";
			this.lbl_Copy_Bom.Text = "BOM Id/Rev";
			this.lbl_Copy_Bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// c1Combo2
			// 
			this.c1Combo2.AddItemCols = 0;
			this.c1Combo2.AddItemSeparator = ';';
			this.c1Combo2.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.c1Combo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Combo2.Caption = "";
			this.c1Combo2.CaptionHeight = 17;
			this.c1Combo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.c1Combo2.ColumnCaptionHeight = 18;
			this.c1Combo2.ColumnFooterHeight = 18;
			this.c1Combo2.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.c1Combo2.ContentHeight = 17;
			this.c1Combo2.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Control;
			this.c1Combo2.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 17;
			this.c1Combo2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(120, 32);
			this.c1Combo2.MatchEntryTimeout = ((long)(2000));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.PartialRightColumn = false;
			this.c1Combo2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.Size = new System.Drawing.Size(120, 21);
			this.c1Combo2.TabIndex = 349;
			// 
			// lbl_Copy_Factory
			// 
			this.lbl_Copy_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Factory.ImageIndex = 0;
			this.lbl_Copy_Factory.ImageList = this.img_Label;
			this.lbl_Copy_Factory.Location = new System.Drawing.Point(16, 32);
			this.lbl_Copy_Factory.Name = "lbl_Copy_Factory";
			this.lbl_Copy_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Copy_Factory.TabIndex = 348;
			this.lbl_Copy_Factory.Tag = "0";
			this.lbl_Copy_Factory.Text = "Factory";
			this.lbl_Copy_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(699, 25);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 40);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(784, 0);
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
			this.pictureBox3.Size = new System.Drawing.Size(576, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_Copy_Label
			// 
			this.lbl_Copy_Label.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Copy_Label.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Copy_Label.ForeColor = System.Drawing.Color.Navy;
			this.lbl_Copy_Label.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Copy_Label.Image")));
			this.lbl_Copy_Label.Location = new System.Drawing.Point(0, 0);
			this.lbl_Copy_Label.Name = "lbl_Copy_Label";
			this.lbl_Copy_Label.Size = new System.Drawing.Size(231, 30);
			this.lbl_Copy_Label.TabIndex = 28;
			this.lbl_Copy_Label.Tag = "";
			this.lbl_Copy_Label.Text = "      Copy Bom Information";
			this.lbl_Copy_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(784, 65);
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
			this.pictureBox5.Location = new System.Drawing.Point(144, 64);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(640, 18);
			this.pictureBox5.TabIndex = 24;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 65);
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
			this.pictureBox7.Size = new System.Drawing.Size(211, 47);
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
			this.pictureBox8.Location = new System.Drawing.Point(160, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(632, 40);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// Pop_Bom_Copy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(816, 566);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_grid);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Pop_Bom_Copy";
			this.Load += new System.EventHandler(this.Pop_Bom_Copy_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_grid, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).EndInit();
			this.pnl_grid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Bom)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Copy_Sampletypes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 상용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
	
		#endregion

		#region 공통메쏘드
		private void Init_Form()
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.Text = "Bom Information";
                this.lbl_MainTitle.Text = "Bom Information";
                this.lbl_title.Text = "      Bom Information";

                ClassLib.ComFunction.SetLangDic(this);

                tbtn_Append.Enabled = false;
                tbtn_Color.Enabled = false;
                tbtn_Conform.Enabled = true;
                tbtn_Create.Enabled = false;
                tbtn_Delete.Enabled = false;
                tbtn_Insert.Enabled = false;
                tbtn_New.Enabled = false;
                tbtn_Print.Enabled = false;
                tbtn_Save.Enabled = true;
                tbtn_Search.Enabled = false;

                //Main window값 Setting하기. 


                fgrid_Bom.Set_Grid_CDC("SXD_SRF_TAIL", "5", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Bom.Set_Action_Image(img_Action);
                fgrid_Bom.ExtendLastCol = false;
                fgrid_Bom.Rows.Count = fgrid_Bom.Rows.Fixed;

                Set_Bom_Data();



            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.User_Message(ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}


		private void 	Set_Bom_Data()
		{
			try
			{

				DataTable dt_list  = Select_Bom_Data();

				Display_Grid(dt_list, fgrid_Bom);

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "Set_Bom_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			//arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{

				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 0);
				//arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

			} 

			//arg_fgrid.AutoSizeCols(false);
		}



		#endregion  

		#region 공통이벤트

		#endregion

		#region DB컨넥트

		private DataTable  Select_Bom_Data()
		{

			int vCount = 6, a=0, b=0;

			string  Proc_Name= "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL_MODIFY";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_NF_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_PART_NO";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  txt_Srfno.Text;
			MyOraDB.Parameter_Values[b++] =  txt_Srno.Text;
			MyOraDB.Parameter_Values[b++] =  cmb_Sampletypes.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  " ";
			MyOraDB.Parameter_Values[b++] =  "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		#endregion


		private void Pop_Bom_Copy_Load(object sender, System.EventArgs e)
		{
			 Init_Form();
		}

		private void txt_Copy_Srno_TextChanged(object sender, System.EventArgs e)
		{
		
		}
		
	}

}

