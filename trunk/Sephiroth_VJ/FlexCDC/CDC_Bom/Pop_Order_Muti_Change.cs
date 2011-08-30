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


namespace FlexCDC.CDC_Bom
{
	public class Pop_Order_Muti_Change : COM.PCHWinForm.Pop_Large_B
	{
		#region  컨트롤정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label lbl_Sampletypes;
		private System.Windows.Forms.TextBox txt_Srno;
		private System.Windows.Forms.Label lbl_Srno;
		private System.Windows.Forms.TextBox txt_bomrev;
		private System.Windows.Forms.TextBox txt_bomid;
		private System.Windows.Forms.Label lbl_Bom;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_Sampletypes;
		private System.Windows.Forms.TextBox txt_Srfno;
		private System.Windows.Forms.Label lbl_Srfno;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Panel pnl_body;
		public COM.FSP fgrid_Order;
		private System.ComponentModel.IContainer components = null;

		public Pop_Order_Muti_Change()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Order_Muti_Change));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.lbl_Sampletypes = new System.Windows.Forms.Label();
			this.txt_Srno = new System.Windows.Forms.TextBox();
			this.lbl_Srno = new System.Windows.Forms.Label();
			this.txt_bomrev = new System.Windows.Forms.TextBox();
			this.txt_bomid = new System.Windows.Forms.TextBox();
			this.lbl_Bom = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.cmb_Sampletypes = new C1.Win.C1List.C1Combo();
			this.txt_Srfno = new System.Windows.Forms.TextBox();
			this.lbl_Srfno = new System.Windows.Forms.Label();
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
			this.pnl_body = new System.Windows.Forms.Panel();
			this.fgrid_Order = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).BeginInit();
			this.pnl_body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(521, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(744, 23);
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
			this.pnl_Search.TabIndex = 41;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.lbl_Sampletypes);
			this.pnl_SearchImage.Controls.Add(this.txt_Srno);
			this.pnl_SearchImage.Controls.Add(this.lbl_Srno);
			this.pnl_SearchImage.Controls.Add(this.txt_bomrev);
			this.pnl_SearchImage.Controls.Add(this.txt_bomid);
			this.pnl_SearchImage.Controls.Add(this.lbl_Bom);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.cmb_Sampletypes);
			this.pnl_SearchImage.Controls.Add(this.txt_Srfno);
			this.pnl_SearchImage.Controls.Add(this.lbl_Srfno);
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
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(795, 80);
			this.pnl_SearchImage.TabIndex = 19;
			// 
			// lbl_Sampletypes
			// 
			this.lbl_Sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Sampletypes.ImageIndex = 0;
			this.lbl_Sampletypes.ImageList = this.img_Label;
			this.lbl_Sampletypes.Location = new System.Drawing.Point(569, 28);
			this.lbl_Sampletypes.Name = "lbl_Sampletypes";
			this.lbl_Sampletypes.Size = new System.Drawing.Size(100, 21);
			this.lbl_Sampletypes.TabIndex = 357;
			this.lbl_Sampletypes.Tag = "21";
			this.lbl_Sampletypes.Text = "Round";
			this.lbl_Sampletypes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Srno
			// 
			this.txt_Srno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Srno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Srno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Srno.ForeColor = System.Drawing.Color.Black;
			this.txt_Srno.Location = new System.Drawing.Point(389, 29);
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
			this.lbl_Srno.Location = new System.Drawing.Point(288, 29);
			this.lbl_Srno.Name = "lbl_Srno";
			this.lbl_Srno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Srno.TabIndex = 355;
			this.lbl_Srno.Tag = "21";
			this.lbl_Srno.Text = "Sample Req.#";
			this.lbl_Srno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_bomrev
			// 
			this.txt_bomrev.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_bomrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_bomrev.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_bomrev.ForeColor = System.Drawing.Color.Black;
			this.txt_bomrev.Location = new System.Drawing.Point(469, 52);
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
			this.txt_bomid.Location = new System.Drawing.Point(389, 52);
			this.txt_bomid.MaxLength = 100;
			this.txt_bomid.Name = "txt_bomid";
			this.txt_bomid.ReadOnly = true;
			this.txt_bomid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_bomid.Size = new System.Drawing.Size(79, 20);
			this.txt_bomid.TabIndex = 351;
			this.txt_bomid.Text = "";
			// 
			// lbl_Bom
			// 
			this.lbl_Bom.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Bom.ImageIndex = 0;
			this.lbl_Bom.ImageList = this.img_Label;
			this.lbl_Bom.Location = new System.Drawing.Point(288, 52);
			this.lbl_Bom.Name = "lbl_Bom";
			this.lbl_Bom.Size = new System.Drawing.Size(100, 21);
			this.lbl_Bom.TabIndex = 350;
			this.lbl_Bom.Tag = "21";
			this.lbl_Bom.Text = "BOM Id/Rev";
			this.lbl_Bom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.Location = new System.Drawing.Point(108, 29);
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
			this.cmb_Sampletypes.ContentHeight = 16;
			this.cmb_Sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Sampletypes.EditorBackColor = System.Drawing.SystemColors.Control;
			this.cmb_Sampletypes.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Sampletypes.EditorHeight = 16;
			this.cmb_Sampletypes.Enabled = false;
			this.cmb_Sampletypes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Sampletypes.GapHeight = 2;
			this.cmb_Sampletypes.ItemHeight = 15;
			this.cmb_Sampletypes.Location = new System.Drawing.Point(670, 29);
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
				"out><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Sampletypes.Size = new System.Drawing.Size(120, 20);
			this.cmb_Sampletypes.TabIndex = 358;
			// 
			// txt_Srfno
			// 
			this.txt_Srfno.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Srfno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Srfno.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Srfno.ForeColor = System.Drawing.Color.Black;
			this.txt_Srfno.Location = new System.Drawing.Point(108, 52);
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
			this.lbl_Srfno.Location = new System.Drawing.Point(7, 52);
			this.lbl_Srfno.Name = "lbl_Srfno";
			this.lbl_Srfno.Size = new System.Drawing.Size(100, 21);
			this.lbl_Srfno.TabIndex = 353;
			this.lbl_Srfno.Tag = "21";
			this.lbl_Srfno.Text = "SRF No";
			this.lbl_Srfno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(7, 29);
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
			this.picb_MR.Location = new System.Drawing.Point(694, 25);
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
			this.picb_TR.Location = new System.Drawing.Point(779, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(571, 32);
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
			this.picb_BR.Location = new System.Drawing.Point(779, 65);
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
			this.picb_BM.Size = new System.Drawing.Size(635, 18);
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
			this.picb_MM.Size = new System.Drawing.Size(627, 40);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_body
			// 
			this.pnl_body.Controls.Add(this.fgrid_Order);
			this.pnl_body.Location = new System.Drawing.Point(0, 160);
			this.pnl_body.Name = "pnl_body";
			this.pnl_body.Size = new System.Drawing.Size(805, 400);
			this.pnl_body.TabIndex = 42;
			// 
			// fgrid_Order
			// 
			this.fgrid_Order.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Order.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_Order.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Order.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Order.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Order.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Order.Name = "fgrid_Order";
			this.fgrid_Order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Order.Size = new System.Drawing.Size(805, 400);
			this.fgrid_Order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Order.TabIndex = 108;
			// 
			// Pop_Order_Muti_Change
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(808, 566);
			this.Controls.Add(this.pnl_body);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Pop_Order_Muti_Change";
			this.Load += new System.EventHandler(this.Pop_Order_Muti_Change_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Sampletypes)).EndInit();
			this.pnl_body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Order)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private string _ordtype  ="";

		#endregion 

		#region 공통메쏘드
		private void Init_Form()
		{
            try
			{
                this.Cursor = Cursors.WaitCursor;

				this.Text = "Order Muti Change";
				this.lbl_MainTitle.Text =  "Order Muti Change";
				ClassLib.ComFunction.SetLangDic(this); 

				#region Button & Control Setting
				tbtn_Append.Enabled  = false;
				tbtn_Color.Enabled   = false;
				tbtn_Conform.Enabled = false;
				tbtn_Create.Enabled  = false;
				tbtn_Delete.Enabled  = false;
				tbtn_Insert.Enabled  = false;
				tbtn_New.Enabled	 = false;
				tbtn_Print.Enabled   = false;
				tbtn_Save.Enabled    = true;
				tbtn_Search.Enabled  = false;

                cmb_Factory.Enabled = false;
                cmb_Sampletypes.Enabled = false;
                txt_bomid.Enabled = false;
                txt_bomrev.Enabled = false;
                txt_Srfno.Enabled = false;
                txt_Srno.Enabled = false;
				#endregion 
                			
                #region ComboBox Setting
                DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
				ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;

				dt_ret = Select_sdc_nf_desc();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Sampletypes, 0,2 , false, false);
                #endregion

                #region 속성정보 설정

                cmb_Factory.SelectedValue  = COM.ComVar.Parameter_PopUp[0];
				txt_Srno.Text			   = COM.ComVar.Parameter_PopUp[1];
				txt_Srfno.Text			   = COM.ComVar.Parameter_PopUp[2];
				txt_bomid.Text			   = COM.ComVar.Parameter_PopUp[3];
				txt_bomrev.Text			   = COM.ComVar.Parameter_PopUp[4];
				cmb_Sampletypes.SelectedValue  =  COM.ComVar.Parameter_PopUp[5];
				_ordtype =  COM.ComVar.Parameter_PopUp[6];


				
				


				#endregion  

				#region 그리드			
				fgrid_Order.Set_Grid_CDC("SXD_SRF_ORDER", "4", 1,  COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_Order.Set_Action_Image(img_Action);
				fgrid_Order.Font = new Font("Verdana", 8);
				fgrid_Order.Rows.Count = fgrid_Order.Rows.Fixed;
				#endregion 				
               
				Set_Data();				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message (ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor  = Cursors.Default;
			}
		}

		
		private void Set_Data()
		{
			DataTable dt_list  =  Select_Sdd_Srf_Order();
			Display_Grid(dt_list, fgrid_Order);
		}


		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{           
            
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			if  (arg_dt.Rows.Count  == 0) return; 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count,0);
            } 
			
			arg_fgrid.Rows[arg_fgrid.Rows.Fixed ].AllowEditing = false;
			arg_fgrid[arg_fgrid.Rows.Fixed ,1] ="true";
			arg_fgrid.Rows[arg_fgrid.Rows.Fixed ].StyleNew.ForeColor = Color.Red;		
		}



		#endregion 

		#region 버튼이벤트
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				this.Cursor  = Cursors.WaitCursor;

				//Order 처리 ....
				for (int i  = fgrid_Order.Rows.Fixed;  i<fgrid_Order.Rows.Count ; i++)
				{
					if ( fgrid_Order[i,(int)ClassLib.TBSXD_SAVE_TAIL_MUTI.lxCHECK].ToString() != "True") continue;
				    Save_Srf_Order_Muti(fgrid_Order,"U", i);
					fgrid_Order.GetCellRange(i, 1,i,fgrid_Order.Cols.Count-1 ).StyleNew.BackColor  =  ClassLib.ComVar.ClrLightPink;
				}

                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsEndRun, this);
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


		#endregion 

		#region DB컨넥트	
		private void Save_Srf_Order_Muti( C1FlexGrid arg_fgrid, string arg_division, int arg_row )
		{

	
			int vCount  = 33, a =0, b=0, c=0;

			string Proc_Name = "PKG_SXD_SRF_03.SAVE_SXD_SRF_ORDER";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name = Proc_Name ;



					
			MyOraDB.Parameter_Name[a++] = "ARG_DIVISION";                   
			for (int i = (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxFACTORY ;  i <= (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxUPD_USER ; i++)
			{
				MyOraDB.Parameter_Name[a++] = "ARG_" + fgrid_Order[0, i].ToString();  

			}


			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			for (int i = (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxFACTORY ;    i <= (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxUPD_USER ; i++)
			{
				MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			}



			MyOraDB.Parameter_Values[c++] =arg_division;
			for (int i = (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxFACTORY ;   i <= (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxUPD_USER-1 ; i++)
			{
				if (i <= (int)ClassLib.TBSXD_SAVE_ORDER_MUTI.lxNF_CD)
					MyOraDB.Parameter_Values[c++] = fgrid_Order[arg_row,i].ToString();
				else
					MyOraDB.Parameter_Values[c++] = fgrid_Order[fgrid_Order.Rows.Fixed,i].ToString();
			}
 
			MyOraDB.Parameter_Values[c++] = ClassLib.ComVar.This_User; //User  


			MyOraDB.Add_Run_Parameter(true);
			MyOraDB.Exe_Run_Procedure();


		}
		private DataTable Select_Sdd_Srf_Order()
		{
			int vCount  = 8, a =0, b=0, c=0;
			MyOraDB.ReDim_Parameter(vCount);



			MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_ORDER_MODIFY" ;


			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[a++] = "ARG_BOM_ID";			
			MyOraDB.Parameter_Name[a++] = "ARG_BOM_REV";	
			MyOraDB.Parameter_Name[a++] = "ARG_NF_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_ORD_TYPE";	
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;	
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[b++] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[c++] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[c++] = txt_Srno.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_Srfno.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_bomid.Text.ToString();
			MyOraDB.Parameter_Values[c++] = txt_bomrev.Text.ToString();
			MyOraDB.Parameter_Values[c++] = cmb_Sampletypes.SelectedValue.ToString();	
			MyOraDB.Parameter_Values[c++] = _ordtype;
			MyOraDB.Parameter_Values[c++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}
		private DataTable Select_sdc_nf_desc()
		{			

			MyOraDB.ReDim_Parameter(2);

			MyOraDB.Process_Name = "PKG_SXD_SRF_00_SELECT.SELECT_SXB_NF_DESC" ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}
        #endregion 
        
		private void Pop_Order_Muti_Change_Load(object sender, System.EventArgs e)
		{
		  Init_Form();
		}

	


	}
}

