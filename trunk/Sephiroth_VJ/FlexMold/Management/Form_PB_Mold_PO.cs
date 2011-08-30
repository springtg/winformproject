using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.IO;

namespace FlexMold.Management
{
	public class Form_PB_Mold_PO : COM.MoldWinForm.Form_Top
	{
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.TextBox txt_status;
		private C1.Win.C1List.C1Combo cmb_purDiv;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_buyDiv;
		private System.Windows.Forms.DateTimePicker dpick_etsYmd;
		private System.Windows.Forms.DateTimePicker dpick_rtaYmd;
		private System.Windows.Forms.DateTimePicker dpick_purYmd;
		private System.Windows.Forms.Label btn_searchPur;
		private C1.Win.C1List.C1Combo cmb_purNo;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private COM.OraDB OraDB = new COM.OraDB();
		private COM.FSP fgrid_size;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label btn_CtItem;
		private System.Windows.Forms.Label lbl_remark;
		private System.Windows.Forms.Label lbl_status;
		private System.Windows.Forms.Label lbl_buydiv;
		private System.Windows.Forms.Label lbl_shipymd;
		private System.Windows.Forms.Label lbl_purdiv;
		private System.Windows.Forms.Label lbl_rtaymd;
		private System.Windows.Forms.Label lbl_purno;
		private System.Windows.Forms.Label lbl_puruser;
		private System.Windows.Forms.Label lbl_purdymd;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.TextBox txt_Mold;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_Mold_PO()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_PB_Mold_PO));
			this.pnl_head = new System.Windows.Forms.Panel();
			this.txt_Mold = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Label();
			this.txt_status = new System.Windows.Forms.TextBox();
			this.btn_CtItem = new System.Windows.Forms.Label();
			this.cmb_purDiv = new C1.Win.C1List.C1Combo();
			this.cmb_purUser = new C1.Win.C1List.C1Combo();
			this.cmb_buyDiv = new C1.Win.C1List.C1Combo();
			this.dpick_etsYmd = new System.Windows.Forms.DateTimePicker();
			this.dpick_rtaYmd = new System.Windows.Forms.DateTimePicker();
			this.lbl_remark = new System.Windows.Forms.Label();
			this.lbl_status = new System.Windows.Forms.Label();
			this.lbl_buydiv = new System.Windows.Forms.Label();
			this.lbl_shipymd = new System.Windows.Forms.Label();
			this.lbl_purdiv = new System.Windows.Forms.Label();
			this.lbl_rtaymd = new System.Windows.Forms.Label();
			this.dpick_purYmd = new System.Windows.Forms.DateTimePicker();
			this.btn_searchPur = new System.Windows.Forms.Label();
			this.cmb_purNo = new C1.Win.C1List.C1Combo();
			this.lbl_purno = new System.Windows.Forms.Label();
			this.cmb_factory = new C1.Win.C1List.C1Combo();
			this.txt_remarks = new System.Windows.Forms.TextBox();
			this.lbl_puruser = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.lbl_purdymd = new System.Windows.Forms.Label();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pic_head2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pic_head1 = new System.Windows.Forms.PictureBox();
			this.pic_head5 = new System.Windows.Forms.PictureBox();
			this.pic_head6 = new System.Windows.Forms.PictureBox();
			this.fgrid_size = new COM.FSP();
			this.fgrid_main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
			this.lbl_MainTitle.Text = "Mold Purchase Order";
			// 
			// pnl_head
			// 
			this.pnl_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.txt_Mold);
			this.pnl_head.Controls.Add(this.btn_search);
			this.pnl_head.Controls.Add(this.txt_status);
			this.pnl_head.Controls.Add(this.btn_CtItem);
			this.pnl_head.Controls.Add(this.cmb_purDiv);
			this.pnl_head.Controls.Add(this.cmb_purUser);
			this.pnl_head.Controls.Add(this.cmb_buyDiv);
			this.pnl_head.Controls.Add(this.dpick_etsYmd);
			this.pnl_head.Controls.Add(this.dpick_rtaYmd);
			this.pnl_head.Controls.Add(this.lbl_remark);
			this.pnl_head.Controls.Add(this.lbl_status);
			this.pnl_head.Controls.Add(this.lbl_buydiv);
			this.pnl_head.Controls.Add(this.lbl_shipymd);
			this.pnl_head.Controls.Add(this.lbl_purdiv);
			this.pnl_head.Controls.Add(this.lbl_rtaymd);
			this.pnl_head.Controls.Add(this.dpick_purYmd);
			this.pnl_head.Controls.Add(this.btn_searchPur);
			this.pnl_head.Controls.Add(this.cmb_purNo);
			this.pnl_head.Controls.Add(this.lbl_purno);
			this.pnl_head.Controls.Add(this.cmb_factory);
			this.pnl_head.Controls.Add(this.txt_remarks);
			this.pnl_head.Controls.Add(this.lbl_puruser);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.lbl_purdymd);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.lbl_factory);
			this.pnl_head.Controls.Add(this.pic_head7);
			this.pnl_head.Controls.Add(this.pic_head2);
			this.pnl_head.Controls.Add(this.label12);
			this.pnl_head.Controls.Add(this.pic_head1);
			this.pnl_head.Controls.Add(this.pic_head5);
			this.pnl_head.Controls.Add(this.pic_head6);
			this.pnl_head.Location = new System.Drawing.Point(9, 48);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(999, 161);
			this.pnl_head.TabIndex = 398;
			// 
			// txt_Mold
			// 
			this.txt_Mold.Enabled = false;
			this.txt_Mold.Location = new System.Drawing.Point(883, 40);
			this.txt_Mold.Name = "txt_Mold";
			this.txt_Mold.Size = new System.Drawing.Size(104, 22);
			this.txt_Mold.TabIndex = 540;
			this.txt_Mold.Text = "";
			// 
			// btn_search
			// 
			this.btn_search.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_search.Font = new System.Drawing.Font("Gulim", 9F);
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.img_Button;
			this.btn_search.Location = new System.Drawing.Point(892, 107);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(104, 23);
			this.btn_search.TabIndex = 539;
			this.btn_search.Text = "Search";
			this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// txt_status
			// 
			this.txt_status.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_status.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_status.Location = new System.Drawing.Point(767, 40);
			this.txt_status.MaxLength = 500;
			this.txt_status.Name = "txt_status";
			this.txt_status.ReadOnly = true;
			this.txt_status.Size = new System.Drawing.Size(113, 21);
			this.txt_status.TabIndex = 538;
			this.txt_status.Text = "";
			// 
			// btn_CtItem
			// 
			this.btn_CtItem.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_CtItem.Font = new System.Drawing.Font("Gulim", 9F);
			this.btn_CtItem.ImageIndex = 0;
			this.btn_CtItem.ImageList = this.img_Button;
			this.btn_CtItem.Location = new System.Drawing.Point(770, 106);
			this.btn_CtItem.Name = "btn_CtItem";
			this.btn_CtItem.Size = new System.Drawing.Size(113, 23);
			this.btn_CtItem.TabIndex = 403;
			this.btn_CtItem.Text = "Get Mold Info";
			this.btn_CtItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CtItem.Click += new System.EventHandler(this.btn_CtItem_Click);
			// 
			// cmb_purDiv
			// 
			this.cmb_purDiv.AddItemCols = 0;
			this.cmb_purDiv.AddItemSeparator = ';';
			this.cmb_purDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_purDiv.AutoSize = false;
			this.cmb_purDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_purDiv.Caption = "";
			this.cmb_purDiv.CaptionHeight = 17;
			this.cmb_purDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_purDiv.ColumnCaptionHeight = 18;
			this.cmb_purDiv.ColumnFooterHeight = 18;
			this.cmb_purDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_purDiv.ContentHeight = 17;
			this.cmb_purDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_purDiv.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_purDiv.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_purDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_purDiv.EditorHeight = 17;
			this.cmb_purDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_purDiv.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_purDiv.GapHeight = 2;
			this.cmb_purDiv.ItemHeight = 15;
			this.cmb_purDiv.Location = new System.Drawing.Point(438, 62);
			this.cmb_purDiv.MatchEntryTimeout = ((long)(2000));
			this.cmb_purDiv.MaxDropDownItems = ((short)(5));
			this.cmb_purDiv.MaxLength = 32767;
			this.cmb_purDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_purDiv.Name = "cmb_purDiv";
			this.cmb_purDiv.PartialRightColumn = false;
			this.cmb_purDiv.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCapt" +
				"ionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollG" +
				"roup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></V" +
				"ScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle pare" +
				"nt=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyl" +
				"e parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"St" +
				"yle6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddR" +
				"ow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><S" +
				"electedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" " +
				"/></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" />" +
				"<Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Styl" +
				"e parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_purDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_purDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_purDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_purDiv.Size = new System.Drawing.Size(220, 21);
			this.cmb_purDiv.TabIndex = 397;
			// 
			// cmb_purUser
			// 
			this.cmb_purUser.AddItemCols = 0;
			this.cmb_purUser.AddItemSeparator = ';';
			this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_purUser.AutoSize = false;
			this.cmb_purUser.Caption = "";
			this.cmb_purUser.CaptionHeight = 17;
			this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_purUser.ColumnCaptionHeight = 18;
			this.cmb_purUser.ColumnFooterHeight = 18;
			this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_purUser.ContentHeight = 15;
			this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_purUser.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_purUser.EditorHeight = 15;
			this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_purUser.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_purUser.GapHeight = 2;
			this.cmb_purUser.ItemHeight = 15;
			this.cmb_purUser.Location = new System.Drawing.Point(109, 84);
			this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
			this.cmb_purUser.MaxDropDownItems = ((short)(5));
			this.cmb_purUser.MaxLength = 32767;
			this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_purUser.Name = "cmb_purUser";
			this.cmb_purUser.PartialRightColumn = false;
			this.cmb_purUser.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCapt" +
				"ionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollG" +
				"roup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></V" +
				"ScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle pare" +
				"nt=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyl" +
				"e parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"St" +
				"yle6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddR" +
				"ow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><S" +
				"electedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" " +
				"/></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" />" +
				"<Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Styl" +
				"e parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_purUser.Size = new System.Drawing.Size(220, 21);
			this.cmb_purUser.TabIndex = 395;
			// 
			// cmb_buyDiv
			// 
			this.cmb_buyDiv.AddItemCols = 0;
			this.cmb_buyDiv.AddItemSeparator = ';';
			this.cmb_buyDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_buyDiv.AutoSize = false;
			this.cmb_buyDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_buyDiv.Caption = "";
			this.cmb_buyDiv.CaptionHeight = 17;
			this.cmb_buyDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_buyDiv.ColumnCaptionHeight = 18;
			this.cmb_buyDiv.ColumnFooterHeight = 18;
			this.cmb_buyDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_buyDiv.ContentHeight = 17;
			this.cmb_buyDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_buyDiv.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_buyDiv.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_buyDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_buyDiv.EditorHeight = 17;
			this.cmb_buyDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_buyDiv.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_buyDiv.GapHeight = 2;
			this.cmb_buyDiv.ItemHeight = 15;
			this.cmb_buyDiv.Location = new System.Drawing.Point(767, 62);
			this.cmb_buyDiv.MatchEntryTimeout = ((long)(2000));
			this.cmb_buyDiv.MaxDropDownItems = ((short)(5));
			this.cmb_buyDiv.MaxLength = 32767;
			this.cmb_buyDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_buyDiv.Name = "cmb_buyDiv";
			this.cmb_buyDiv.PartialRightColumn = false;
			this.cmb_buyDiv.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCapt" +
				"ionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollG" +
				"roup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></V" +
				"ScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle pare" +
				"nt=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyl" +
				"e parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"St" +
				"yle6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddR" +
				"ow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><S" +
				"electedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" " +
				"/></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" />" +
				"<Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Styl" +
				"e parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_buyDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_buyDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_buyDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_buyDiv.Size = new System.Drawing.Size(220, 21);
			this.cmb_buyDiv.TabIndex = 394;
			// 
			// dpick_etsYmd
			// 
			this.dpick_etsYmd.CustomFormat = "";
			this.dpick_etsYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_etsYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_etsYmd.Location = new System.Drawing.Point(767, 84);
			this.dpick_etsYmd.Name = "dpick_etsYmd";
			this.dpick_etsYmd.Size = new System.Drawing.Size(222, 21);
			this.dpick_etsYmd.TabIndex = 389;
			// 
			// dpick_rtaYmd
			// 
			this.dpick_rtaYmd.CustomFormat = "";
			this.dpick_rtaYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_rtaYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_rtaYmd.Location = new System.Drawing.Point(438, 84);
			this.dpick_rtaYmd.Name = "dpick_rtaYmd";
			this.dpick_rtaYmd.Size = new System.Drawing.Size(222, 21);
			this.dpick_rtaYmd.TabIndex = 388;
			// 
			// lbl_remark
			// 
			this.lbl_remark.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_remark.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_remark.ImageIndex = 0;
			this.lbl_remark.ImageList = this.img_Label;
			this.lbl_remark.Location = new System.Drawing.Point(8, 108);
			this.lbl_remark.Name = "lbl_remark";
			this.lbl_remark.Size = new System.Drawing.Size(100, 21);
			this.lbl_remark.TabIndex = 386;
			this.lbl_remark.Text = "Remark";
			this.lbl_remark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_status
			// 
			this.lbl_status.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_status.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_status.ImageIndex = 0;
			this.lbl_status.ImageList = this.img_Label;
			this.lbl_status.Location = new System.Drawing.Point(666, 40);
			this.lbl_status.Name = "lbl_status";
			this.lbl_status.Size = new System.Drawing.Size(100, 21);
			this.lbl_status.TabIndex = 382;
			this.lbl_status.Text = "Status";
			this.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_buydiv
			// 
			this.lbl_buydiv.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_buydiv.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_buydiv.ImageIndex = 0;
			this.lbl_buydiv.ImageList = this.img_Label;
			this.lbl_buydiv.Location = new System.Drawing.Point(666, 62);
			this.lbl_buydiv.Name = "lbl_buydiv";
			this.lbl_buydiv.Size = new System.Drawing.Size(100, 21);
			this.lbl_buydiv.TabIndex = 378;
			this.lbl_buydiv.Text = "Buy Division";
			this.lbl_buydiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_shipymd
			// 
			this.lbl_shipymd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_shipymd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_shipymd.ImageIndex = 0;
			this.lbl_shipymd.ImageList = this.img_Label;
			this.lbl_shipymd.Location = new System.Drawing.Point(666, 84);
			this.lbl_shipymd.Name = "lbl_shipymd";
			this.lbl_shipymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_shipymd.TabIndex = 377;
			this.lbl_shipymd.Text = "Shipping Date";
			this.lbl_shipymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_purdiv
			// 
			this.lbl_purdiv.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purdiv.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purdiv.ImageIndex = 0;
			this.lbl_purdiv.ImageList = this.img_Label;
			this.lbl_purdiv.Location = new System.Drawing.Point(337, 62);
			this.lbl_purdiv.Name = "lbl_purdiv";
			this.lbl_purdiv.Size = new System.Drawing.Size(100, 21);
			this.lbl_purdiv.TabIndex = 376;
			this.lbl_purdiv.Text = "Pur Division";
			this.lbl_purdiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_rtaymd
			// 
			this.lbl_rtaymd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_rtaymd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_rtaymd.ImageIndex = 0;
			this.lbl_rtaymd.ImageList = this.img_Label;
			this.lbl_rtaymd.Location = new System.Drawing.Point(337, 84);
			this.lbl_rtaymd.Name = "lbl_rtaymd";
			this.lbl_rtaymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_rtaymd.TabIndex = 375;
			this.lbl_rtaymd.Text = "RTA Date";
			this.lbl_rtaymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_purYmd
			// 
			this.dpick_purYmd.CustomFormat = "";
			this.dpick_purYmd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_purYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_purYmd.Location = new System.Drawing.Point(109, 63);
			this.dpick_purYmd.Name = "dpick_purYmd";
			this.dpick_purYmd.Size = new System.Drawing.Size(220, 21);
			this.dpick_purYmd.TabIndex = 5;
			this.dpick_purYmd.CloseUp += new System.EventHandler(this.dpick_purYmd_CloseUp);
			// 
			// btn_searchPur
			// 
			this.btn_searchPur.Location = new System.Drawing.Point(656, 24);
			this.btn_searchPur.Name = "btn_searchPur";
			this.btn_searchPur.Size = new System.Drawing.Size(8, 21);
			this.btn_searchPur.TabIndex = 374;
			this.btn_searchPur.Tag = "Search";
			this.btn_searchPur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cmb_purNo
			// 
			this.cmb_purNo.AddItemCols = 0;
			this.cmb_purNo.AddItemSeparator = ';';
			this.cmb_purNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_purNo.AutoSize = false;
			this.cmb_purNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_purNo.Caption = "";
			this.cmb_purNo.CaptionHeight = 17;
			this.cmb_purNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_purNo.ColumnCaptionHeight = 18;
			this.cmb_purNo.ColumnFooterHeight = 18;
			this.cmb_purNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_purNo.ContentHeight = 17;
			this.cmb_purNo.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_purNo.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_purNo.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_purNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_purNo.EditorHeight = 17;
			this.cmb_purNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_purNo.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_purNo.GapHeight = 2;
			this.cmb_purNo.ItemHeight = 15;
			this.cmb_purNo.Location = new System.Drawing.Point(438, 40);
			this.cmb_purNo.MatchEntryTimeout = ((long)(2000));
			this.cmb_purNo.MaxDropDownItems = ((short)(5));
			this.cmb_purNo.MaxLength = 32767;
			this.cmb_purNo.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_purNo.Name = "cmb_purNo";
			this.cmb_purNo.PartialRightColumn = false;
			this.cmb_purNo.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Cont" +
				"rol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}St" +
				"yle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCapt" +
				"ionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollG" +
				"roup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></V" +
				"ScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle pare" +
				"nt=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyl" +
				"e parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"St" +
				"yle6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddR" +
				"ow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><S" +
				"electedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" " +
				"/></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" />" +
				"<Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Styl" +
				"e parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_purNo.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_purNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_purNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_purNo.Size = new System.Drawing.Size(218, 21);
			this.cmb_purNo.TabIndex = 7;
			this.cmb_purNo.SelectedValueChanged += new System.EventHandler(this.cmb_purNo_SelectedValueChanged);
			// 
			// lbl_purno
			// 
			this.lbl_purno.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purno.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purno.ImageIndex = 1;
			this.lbl_purno.ImageList = this.img_Label;
			this.lbl_purno.Location = new System.Drawing.Point(337, 40);
			this.lbl_purno.Name = "lbl_purno";
			this.lbl_purno.Size = new System.Drawing.Size(100, 21);
			this.lbl_purno.TabIndex = 366;
			this.lbl_purno.Text = "Purchase No";
			this.lbl_purno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_factory
			// 
			this.cmb_factory.AddItemCols = 0;
			this.cmb_factory.AddItemSeparator = ';';
			this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_factory.AutoSize = false;
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
			this.cmb_factory.EditorFont = new System.Drawing.Font("Gulim", 9F);
			this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_factory.EditorHeight = 17;
			this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
			this.cmb_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_factory.GapHeight = 2;
			this.cmb_factory.ItemHeight = 15;
			this.cmb_factory.Location = new System.Drawing.Point(109, 40);
			this.cmb_factory.MatchEntryTimeout = ((long)(2000));
			this.cmb_factory.MaxDropDownItems = ((short)(5));
			this.cmb_factory.MaxLength = 32767;
			this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_factory.Name = "cmb_factory";
			this.cmb_factory.PartialRightColumn = false;
			this.cmb_factory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Gulim, 9p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"Split[0,0]\" CaptionHeight=\"18\" ColumnCapt" +
				"ionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollG" +
				"roup=\"1\"><ClientRect>0, 0, 118, 158</ClientRect><VScrollBar><Width>17</Width></V" +
				"ScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Styl" +
				"e2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle pare" +
				"nt=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyl" +
				"e parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"St" +
				"yle6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddR" +
				"ow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><S" +
				"electedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" " +
				"/></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\"" +
				" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><" +
				"Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><S" +
				"tyle parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" />" +
				"<Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Styl" +
				"e parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></" +
				"NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified" +
				"</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_factory.Size = new System.Drawing.Size(220, 21);
			this.cmb_factory.TabIndex = 1;
			// 
			// txt_remarks
			// 
			this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_remarks.Font = new System.Drawing.Font("Gulim", 9F);
			this.txt_remarks.Location = new System.Drawing.Point(109, 106);
			this.txt_remarks.MaxLength = 500;
			this.txt_remarks.Name = "txt_remarks";
			this.txt_remarks.Size = new System.Drawing.Size(659, 21);
			this.txt_remarks.TabIndex = 11;
			this.txt_remarks.Text = "";
			// 
			// lbl_puruser
			// 
			this.lbl_puruser.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_puruser.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_puruser.ImageIndex = 0;
			this.lbl_puruser.ImageList = this.img_Label;
			this.lbl_puruser.Location = new System.Drawing.Point(8, 84);
			this.lbl_puruser.Name = "lbl_puruser";
			this.lbl_puruser.Size = new System.Drawing.Size(100, 21);
			this.lbl_puruser.TabIndex = 365;
			this.lbl_puruser.Text = "Purchase User";
			this.lbl_puruser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(983, 145);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// lbl_purdymd
			// 
			this.lbl_purdymd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_purdymd.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_purdymd.ImageIndex = 1;
			this.lbl_purdymd.ImageList = this.img_Label;
			this.lbl_purdymd.Location = new System.Drawing.Point(8, 62);
			this.lbl_purdymd.Name = "lbl_purdymd";
			this.lbl_purdymd.Size = new System.Drawing.Size(100, 21);
			this.lbl_purdymd.TabIndex = 50;
			this.lbl_purdymd.Text = "Purchase Date";
			this.lbl_purdymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 144);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(959, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// lbl_factory
			// 
			this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_factory.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 1;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(8, 40);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 50;
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head7
			// 
			this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
			this.pic_head7.Location = new System.Drawing.Point(898, 30);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.Size = new System.Drawing.Size(101, 120);
			this.pic_head7.TabIndex = 46;
			this.pic_head7.TabStop = false;
			// 
			// pic_head2
			// 
			this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
			this.pic_head2.Location = new System.Drawing.Point(983, 0);
			this.pic_head2.Name = "pic_head2";
			this.pic_head2.Size = new System.Drawing.Size(16, 32);
			this.pic_head2.TabIndex = 44;
			this.pic_head2.TabStop = false;
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.SystemColors.Window;
			this.label12.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.Color.Navy;
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.Location = new System.Drawing.Point(0, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(231, 30);
			this.label12.TabIndex = 42;
			this.label12.Text = "      Purchase Order";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head1
			// 
			this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
			this.pic_head1.Location = new System.Drawing.Point(208, 0);
			this.pic_head1.Name = "pic_head1";
			this.pic_head1.Size = new System.Drawing.Size(959, 32);
			this.pic_head1.TabIndex = 39;
			this.pic_head1.TabStop = false;
			// 
			// pic_head5
			// 
			this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
			this.pic_head5.Location = new System.Drawing.Point(0, 145);
			this.pic_head5.Name = "pic_head5";
			this.pic_head5.Size = new System.Drawing.Size(168, 20);
			this.pic_head5.TabIndex = 43;
			this.pic_head5.TabStop = false;
			// 
			// pic_head6
			// 
			this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
			this.pic_head6.Location = new System.Drawing.Point(0, 16);
			this.pic_head6.Name = "pic_head6";
			this.pic_head6.Size = new System.Drawing.Size(168, 134);
			this.pic_head6.TabIndex = 41;
			this.pic_head6.TabStop = false;
			// 
			// fgrid_size
			// 
			this.fgrid_size.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_size.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_size.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_size.Location = new System.Drawing.Point(8, 184);
			this.fgrid_size.Name = "fgrid_size";
			this.fgrid_size.Rows.Count = 2;
			this.fgrid_size.Size = new System.Drawing.Size(1000, 72);
			this.fgrid_size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_size.TabIndex = 399;
			// 
			// fgrid_main
			// 
			this.fgrid_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_main.ColumnInfo = @"10,0,0,0,0,95,Columns:0{TextAlign:CenterCenter;}	1{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	2{TextAlign:CenterCenter;TextAlignFixed:CenterCenter;}	6{TextAlign:CenterCenter;}	7{TextAlign:CenterCenter;}	8{TextAlign:CenterCenter;}	9{TextAlign:CenterCenter;}	";
			this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_main.Location = new System.Drawing.Point(8, 256);
			this.fgrid_main.Name = "fgrid_main";
			this.fgrid_main.Rows.Count = 2;
			this.fgrid_main.Size = new System.Drawing.Size(1000, 384);
			this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_main.TabIndex = 400;
			this.fgrid_main.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseDown);
			this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
			// 
			// Form_PB_Mold_PO
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.fgrid_main);
			this.Controls.Add(this.fgrid_size);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_PB_Mold_PO";
			this.Load += new System.EventHandler(this.Form_PB_Mold_PO_Load);
			this.Activated += new System.EventHandler(this.Form_PB_Mold_PO_Activated);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.fgrid_size, 0);
			this.Controls.SetChildIndex(this.fgrid_main, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_purDiv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_buyDiv)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_purNo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_size)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void btn_CtItem_Click(object sender, System.EventArgs e)
		{
			//			if(cmb_factory.SelectedIndex == -1 
			//				|| cmb_stockYY.SelectedIndex == -1 
			//				|| cmb_stockMM.SelectedIndex == -1
			//				|| cmb_wareHouse.SelectedIndex == -1) return;

		    make_new_po();
			Show_Item_Popup();
			btn_search.Enabled = true;
		}
		private void make_new_po()
		{
			dpick_purYmd.Text  = System.DateTime.Now.ToShortDateString().ToString();
			dpick_rtaYmd.Text  = System.DateTime.Now.ToShortDateString().ToString();
			dpick_etsYmd.Text  = System.DateTime.Now.ToShortDateString().ToString();
			fgrid_main.Clear();
			fgrid_size.Clear();
			txt_status.Text    = "New";
		}
		private void Show_Item_Popup()
		{
			try
			{
				FlexMold.Master.Pop_Mold_List vPopup = new FlexMold.Master.Pop_Mold_List();
				vPopup.ShowDialog(); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_Item_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Form_PB_Mold_PO_Load(object sender, System.EventArgs e)
		{

			//init_fgrid_size();
			Init_Form();


		}
		private void Init_Form()
		{
			fgrid_main.Enabled  = false;
			fgrid_size.Enabled = false;
			Init_Combo();
			btn_search.Enabled = false;
		}
		private void Init_Combo()
		{
			try
			{
				DataTable vDt;
				
				// factory set
				vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_factory.SelectedValue    = ClassLib.ComVar.This_Factory;
				
				// cmb_buyDiv SBC01
				vDt = Select_com_filter_code_List("SBC01");
				COM.ComCtl.Set_ComboList(vDt, cmb_buyDiv, 0, 1, true, 56,0);
				cmb_buyDiv.SelectedIndex = 3;
//
//				// cmb_purUser
				vDt = ClassLib.ComFunction.Select_Man_Charge_ByCom(COM.ComVar.This_Factory,"SCM02");
				ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 1, true, 0, 210);
				//cmb_purUser.ValueMember = "Name";
				cmb_purUser.SelectedValue = "PHUNG.JIT";
//
//				// cmb_purDiv SBM07
				vDt = Select_com_filter_code_List("SDV33");
				COM.ComCtl.Set_ComboList(vDt, cmb_purDiv, 0, 1, true, 56,0);
				cmb_purDiv.SelectedIndex = 1;
//
//				vDt.Dispose();
//
//				tbtn_Create.Enabled = false;
//				btn_sizeItem.Enabled = false;
//				btn_CtItem.Enabled = false;
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}
		}
		private DataTable Select_com_filter_code_List(string com_cd)
		{
			string Proc_Name = "pkg_scm_code.select_com_filter_code_list";

			OraDB.ReDim_Parameter(3);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_COM_CD";
			OraDB.Parameter_Name[2] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = com_cd;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];


		}
		public void init_fgrid_size()
		{
			string temp="";
			string temp1="";
			//string [,] arr;
			try
			{
				if( ClassLib.ComVar._mold_cd !="")
				{
					DataTable dt = Select_mold_size_by_tool(ClassLib.ComVar._mold_cd);
					int dt_rows = dt.Rows.Count;
					int dt_cols = dt.Columns.Count;
					int k =0;
					int l =0;
					int n =1;
					string  qty ="";
					string [,] arr = new string[dt_cols,dt_rows];
					fgrid_size.Clear();
					fgrid_size.ExtendLastCol = false;
					this.Cursor = Cursors.WaitCursor;
					fgrid_size.Rows.Count = 2;
					for (int j = 0; j < dt_rows; j++)
					{
						if(k<dt_rows)
						{
							temp1 = dt.Rows[k].ItemArray[0].ToString();
							temp= dt.Rows[k].ItemArray[2].ToString();
							qty = dt.Rows[k].ItemArray[1].ToString();
							for (int i=k;i<dt_rows;i++)
							{
								if ( temp == dt.Rows[i].ItemArray[2].ToString() && temp != dt.Rows[i].ItemArray[0].ToString())
								{
										
									temp1 = temp1 +"/"+ dt.Rows[i].ItemArray[0].ToString() ;
									k++;
									l++;
								}
							}
							if (temp !="")
							{
								arr[0,j] =temp1;
								arr[1,j] =qty;
								temp="";
								k=k+1;
								l=0;
								n++;
							}
								
						}
							
								
					}
						
					fgrid_size.Cols.Count = n +2;
//					fgrid_main.Rows.Count = n+2;
					for (int i = 0; i <n -1 ; i++)
					{
						fgrid_size[0, i+3] = arr[0,i];
						
					}
					
					fgrid_size[0, 0] = "   ";
					fgrid_size[0, 1] = "Mold Code";
					fgrid_size[1, 1] = ClassLib.ComVar._mold_cd;
					fgrid_size[0, 2] = "Order Qty";
					fgrid_size[1, 2] = "";
					fgrid_size.AutoSizeCols();
					
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			init_fgrid_main();

		}
		private void init_fgrid_main()
		{
			fgrid_main.Cols.Count = fgrid_size.Cols.Count - 2;
			for (int i =0 ; i < fgrid_main.Cols.Count -1;i++)
			{
				fgrid_main[0,i + 1] = fgrid_size[0,i+ 3].ToString();
				fgrid_main.Cols[i + 1].TextAlign = TextAlignEnum.CenterCenter;
			}
//			for (int i = 0; i < fgrid_main.Rows.Count-1 ;i++)
//			{
//				fgrid_main[i+1,0] = (char)(65+i);
//			}
			fgrid_main[0,0]="Seq";
			fgrid_main.AutoSizeCols();
			
		}
		private void init_fgrid_main_new()
		{
			fgrid_main.Cols.Count = fgrid_size.Cols.Count - 2;
			for (int i =0 ; i < fgrid_main.Cols.Count -1;i++)
			{
				fgrid_main[0,i + 1] = fgrid_size[0,i+ 3].ToString();
				fgrid_main.Cols[i + 1].TextAlign = TextAlignEnum.CenterCenter;
			}
			//			for (int i = 0; i < fgrid_main.Rows.Count-1 ;i++)
			//			{
			//				fgrid_main[i+1,0] = (char)(65+i);
			//			}
			Search_Seq_Stand();  
			fgrid_main[0,0]="Seq";
			fgrid_main.AutoSizeCols();
		}
		private DataTable Select_mold_size_by_tool(string arg_mold)
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_SIZE_BY_TOOL";

			OraDB.ReDim_Parameter(2);
			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0] = "ARG_MOLD_CODE";
			OraDB.Parameter_Name[1] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = arg_mold;
			OraDB.Parameter_Values[1] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		void btn_search_Click(object sender, System.EventArgs e)
		{
			fgrid_main.Enabled  = true;
			fgrid_size.Enabled  = true;
			fgrid_size.Clear();
			fgrid_main.Clear();
			init_fgrid_size();
			for(int k =1 ; k <=fgrid_main.Cols.Count-1 ; k++)
				fgrid_main.Cols[k].AllowEditing = false;
			fgrid_main.Cols[0].StyleNew.BackColor = COM.ComVar.GridCol0_Color;	
		}

		private void Form_PB_Mold_PO_Activated(object sender, System.EventArgs e)
		{
			//init_fgrid_size();
		}

		private void fgrid_main_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel>0)
			{
//				if (fgrid_main[fgrid_main.RowSel -1,fgrid_main.ColSel] == null || fgrid_main[fgrid_main.RowSel-1,fgrid_main.ColSel] =="")
//				{
//					ClassLib.ComVar._startmouse=0;
//				}
//				else
//				{
					//if(check_mold_po_seq()
					ClassLib.ComVar._startmouse = fgrid_main.RowSel;
//				}
			}
		}

		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (fgrid_main.RowSel >0)
			{
				if (ClassLib.ComVar._startmouse > 0)
				{
					ClassLib.ComVar._endmouse = fgrid_main.RowSel;
					init_mold_order(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_main.ColSel);
					if (txt_status.Text == "Save")
						fgrid_size[1,0] = "U";
					else
						fgrid_size[1,0] = "I";

					init_mold_order_seq(ClassLib.ComVar._startmouse,ClassLib.ComVar._endmouse, fgrid_main.ColSel);
				}
				//fgrid_size.Cols[0].Format.
				fgrid_size.AutoSizeCols();
			}
		}
		private void init_mold_order(int _start, int _end, int _col)
		{
			DataTable vDt= null;
			if (_end >= _start)
			{
				if(_col >= 1)
				{
					for (int i = _start; i <= _end; i++)
					{					
						if(fgrid_main[i,_col] != null && fgrid_main[i,_col] !="")
						{
							if(fgrid_main[i,_col].ToString() == "I")
								fgrid_main[i,_col] = "I";					
							else
								fgrid_main[i,_col] = "";					
							//
							//						fgrid_main[i,_col] = "";
							mold_ord_count(_col);
							mold_ord_sum();
						}					
						else 
						{
							//vDt = check_po_seq(fgrid_size[1,1].ToString(),fgrid_main[i,0],fgrid_main[0,_col]);
							//if(vDt.Rows.Count > 0)
							//{
							fgrid_main[i,_col] = "O";
							mold_ord_count(_col);
							mold_ord_sum();
							//}
						}	//fgrid_main.fo
					}
				}
			}
		}
		private void mold_ord_count(int _cols)
		{
			int _mcnt =0;
			for(int i =1;i<fgrid_main.Rows.Count;i++)
			{
				if (fgrid_main[i,_cols]!= null && fgrid_main[i,_cols] !="")
				{
					if(fgrid_main[i,_cols].ToString().Trim()=="O")
						_mcnt++;
				}
			}
			for(int j=2;j<fgrid_size.Cols.Count;j++)
			{
				if(fgrid_main[0,_cols]==fgrid_size[0,j])
				{
					fgrid_size[1,j] = _mcnt;
				}
			}
		}
		private void mold_ord_sum()
		{
			int _msum =0;
			//string _ssum;
			for(int j=3;j<fgrid_size.Cols.Count;j++)
			{
				if(fgrid_size[1,j] != null && fgrid_size[1,j] !="") 
				{
					//_ssum = fgrid_size[1,j];
					_msum = _msum + System.Convert.ToInt32(fgrid_size[1,j].ToString());
				}
				
			}
			fgrid_size[1,2] = _msum.ToString();
		}

		private void dpick_purYmd_CloseUp(object sender, System.EventArgs e)
		{
			DataTable vDt = select_pur_no();
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_purNo, 1, 1, true, 0, 210);
		}

		private DataTable select_pur_no()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_PUR_NO_BYUSER";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name;
			
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_PUR_YMD";
			OraDB.Parameter_Name[2] = "ARG_PURUSER";
			OraDB.Parameter_Name[3] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
			OraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			OraDB.Parameter_Values[1] = dpick_purYmd.Text.Replace("-","");
			OraDB.Parameter_Values[2] = cmb_purUser.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//save pold purchase order

			DataTable pur_seq = select_pur_seq();
			save_mold_purchase_order(pur_seq.Rows[0].ItemArray[0].ToString());
			save_mold_purchase_order_tail(pur_seq.Rows[0].ItemArray[0].ToString());

//			MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
//			fgrid_size.Clear();
//			fgrid_main.Clear();

		}
		private DataTable select_pur_seq()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_MAXSEQ";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			OraDB.Process_Name = Proc_Name;

			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_YMD";
			OraDB.Parameter_Name[2]  = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = dpick_purYmd.Text.Replace("-","");
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
		private void save_mold_purchase_order(string _seq)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_PURHEAD";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(18); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;

			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO"; //ARG_SPEC_CD

			OraDB.Parameter_Name[2]  = "ARG_PUR_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";
			
			OraDB.Parameter_Name[4]  = "ARG_TOTAL_QTY";
			OraDB.Parameter_Name[5]  = "ARG_PUR_YMD";

			OraDB.Parameter_Name[6]  = "ARG_PUR_USER";
			OraDB.Parameter_Name[7]  = "ARG_RTA_YMD";

			OraDB.Parameter_Name[8]  = "ARG_ETS_YMD";
			OraDB.Parameter_Name[9]  = "ARG_PUR_DIV";

			OraDB.Parameter_Name[10]  = "ARG_BUY_DIV";
			OraDB.Parameter_Name[11]  = "ARG_MRP_SHIP_NO";

			OraDB.Parameter_Name[12] = "ARG_STATUS";
			OraDB.Parameter_Name[13] = "ARG_REMARKS";

			OraDB.Parameter_Name[14] = "ARG_SEND_CHK";
			OraDB.Parameter_Name[15] = "ARG_SEND_YMD";

			OraDB.Parameter_Name[16] = "ARG_UPD_USER";
			OraDB.Parameter_Name[17] = "ARG_UPD_YMD";

			for(int i=0; i< 16; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			
			OraDB.Parameter_Values[0] = "VJ"; 
			if (txt_status.Text == "Save")
			{
				OraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString().Substring(2,8);
				OraDB.Parameter_Values[2] = cmb_purNo.SelectedValue.ToString().Substring(10,3);
			}
			else
			{
				OraDB.Parameter_Values[1] = dpick_purYmd.Text.Replace("-",""); 
				OraDB.Parameter_Values[2] = _seq.ToString().PadLeft(3,'0').ToString(); 
			}
			OraDB.Parameter_Values[3] = fgrid_size[1,1].ToString ();

			OraDB.Parameter_Values[4] = fgrid_size[1,2].ToString();
			OraDB.Parameter_Values[5] = dpick_purYmd.Text.Replace("-",""); 

			OraDB.Parameter_Values[6] = cmb_purUser.SelectedValue.ToString(); 
			OraDB.Parameter_Values[7] = dpick_rtaYmd.Text.Replace("-","");   //rta

			OraDB.Parameter_Values[8] = dpick_etsYmd.Text.Replace("-","");   //ets
			OraDB.Parameter_Values[9] = cmb_purDiv.SelectedValue.ToString(); 

			OraDB.Parameter_Values[10] = cmb_buyDiv.SelectedValue.ToString();
			OraDB.Parameter_Values[11] = "";

			OraDB.Parameter_Values[12] = "Save";
			OraDB.Parameter_Values[13] = "";

			OraDB.Parameter_Values[14] = ""; 
			OraDB.Parameter_Values[15] = "";

			OraDB.Parameter_Values[16] = cmb_purUser.SelectedValue.ToString(); 
			OraDB.Parameter_Values[17] = ""; 
			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
			
		}
		private void save_mold_purchase_order_tail(string _seq)
		{
			try
			{
				for (int i =0;i < fgrid_main.Cols.Count - 1; i++)
				{
					for (int j=0;j<fgrid_main.Rows.Count -1 ;j++)
					{
						if (fgrid_main[j+1,i+1]!= null && fgrid_main[j+1,i+1]!= "" )
						{
							if ( fgrid_main[j+1,i+1].ToString() == "O")
							{
								save_mold_purchase_tail(_seq,fgrid_size[1,1].ToString(),fgrid_main[0,i+1].ToString(),fgrid_main[j+1,0].ToString(),fgrid_main[j+1,i+1].ToString());						
							}
						}  
//						else
//						{
//							break;
//						}
					}
				}
				MessageBox.Show("Save Complete","Save", MessageBoxButtons.OK ,MessageBoxIcon.Information);
				fgrid_size.Clear();
				fgrid_main.Clear();
			}
			catch
			{
			}
			finally
			{

			}

		}
		private void save_mold_purchase_tail(string _purseq,string _mold, string _size, string _moldseq, string _ord)
		{
			string process_name = "PKG_SDT_MOLD.SAVE_MOLD_PURTAIL";
			string [] _usesize = null;
			char [] _determid ="/".ToCharArray();
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(31); 

			//01.PROCEDURE명
			OraDB.Process_Name = process_name;

			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO"; //ARG_SPEC_CD

			OraDB.Parameter_Name[2]  = "ARG_PUR_SEQ";
			OraDB.Parameter_Name[3]  = "ARG_MOLD_CD";

			OraDB.Parameter_Name[4]  = "ARG_USE_SIZE";
            OraDB.Parameter_Name[5]  = "ARG_SEQ_NO";

			OraDB.Parameter_Name[6]  = "ARG_REQ_DEPT";
			OraDB.Parameter_Name[7]  = "ARG_PUR_DEPT";

			OraDB.Parameter_Name[8]  = "ARG_CUST_CD";
			OraDB.Parameter_Name[9]  = "ARG_TAX_CD";

			OraDB.Parameter_Name[10] = "ARG_REQ_QTY";
			OraDB.Parameter_Name[11] = "ARG_NEED_QTY";

			OraDB.Parameter_Name[12] = "ARG_PUR_QTY";
			OraDB.Parameter_Name[13] = "ARG_IN_QTY";

			OraDB.Parameter_Name[14] = "ARG_PK_UNIT_QTY";
			OraDB.Parameter_Name[15] = "ARG_PUR_CURRENCY";

			OraDB.Parameter_Name[16] = "ARG_PUR_PRICE";
			OraDB.Parameter_Name[17] = "ARG_RTA_YMD";

			OraDB.Parameter_Name[18] = "ARG_ETS_YMD1";
			OraDB.Parameter_Name[19] = "ARG_ETS_YMD2";

			OraDB.Parameter_Name[20] = "ARG_ETS_YMD3";
			OraDB.Parameter_Name[21] = "ARG_PAY_CD";

			OraDB.Parameter_Name[22] = "ARG_LC_NO";
			OraDB.Parameter_Name[23] = "ARG_REQ_NO";

			OraDB.Parameter_Name[24] = "ARG_REQ_SEQ";
			OraDB.Parameter_Name[25] = "ARG_PUR_STATUS";

			OraDB.Parameter_Name[26] = "ARG_REMARKS";
			OraDB.Parameter_Name[27] = "ARG_SEND_CHK";

			OraDB.Parameter_Name[28] = "ARG_SEND_YMD";
			OraDB.Parameter_Name[29] = "ARG_UPD_USER";

			OraDB.Parameter_Name[30] = "ARG_UPD_YMD";
			
			for(int i=0; i< 16; i++)
			{
				OraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}
			
			OraDB.Parameter_Values[0] = "VJ"; 
			if (txt_status.Text == "Save")
			{
				OraDB.Parameter_Values[1] = cmb_purNo.SelectedValue.ToString();
				OraDB.Parameter_Values[2] = cmb_purNo.SelectedValue.ToString().Substring(10,3);
			}
			else
			{
				OraDB.Parameter_Values[1] = "VJ" + dpick_purYmd.Text.Replace("-","") + _purseq.ToString().PadLeft(3,'0').ToString(); 
				OraDB.Parameter_Values[2] = _purseq.ToString().PadLeft(3,'0').ToString();  //pur_seq
			}
			OraDB.Parameter_Values[3] = _mold; 
            
			_usesize = _size.ToString().Split(_determid);

			OraDB.Parameter_Values[4] = _usesize[0];  //get the use size
			OraDB.Parameter_Values[5] = _moldseq;   

			OraDB.Parameter_Values[6] = "";   //ets
			OraDB.Parameter_Values[7] = "JIT"; 

			OraDB.Parameter_Values[8] = "";
			OraDB.Parameter_Values[9] = "";

			OraDB.Parameter_Values[10] = "1";
			OraDB.Parameter_Values[11] = "1";

			OraDB.Parameter_Values[12] = "1"; 
			OraDB.Parameter_Values[13] = "0";

			OraDB.Parameter_Values[14] = "1"; 
			OraDB.Parameter_Values[15] = ""; 

			OraDB.Parameter_Values[16] = "0"; 
			OraDB.Parameter_Values[17] = dpick_rtaYmd.Text.Replace("-","");

			OraDB.Parameter_Values[18] = dpick_etsYmd.Text.Replace("-",""); 
			OraDB.Parameter_Values[19] = "";

			OraDB.Parameter_Values[20] = ""; 
			OraDB.Parameter_Values[21] = "";

			OraDB.Parameter_Values[22] = ""; 
			OraDB.Parameter_Values[23] = "";

			OraDB.Parameter_Values[24] = ""; 
			OraDB.Parameter_Values[25] = "O";

			OraDB.Parameter_Values[26] = ""; 
			OraDB.Parameter_Values[27] = "";

			OraDB.Parameter_Values[28] = ""; 
			OraDB.Parameter_Values[29] = cmb_purUser.SelectedValue.ToString();

			OraDB.Parameter_Values[30] = ""; 
			

			OraDB.Add_Modify_Parameter(true);	
			OraDB.Exe_Modify_Procedure();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.Clear();
			fgrid_size.Clear();
						
			ClassLib.ComVar._mold_cd = txt_Mold.Text.ToString().Trim();
			init_fgrid_size_new();
			search_mold_purhead_info();		
//			Search_Seq_Stand();  
			search_mold_purtail_info();
			fgrid_main.Enabled  = true;
			for(int k =1 ; k <=fgrid_main.Cols.Count-1 ; k++)
					fgrid_main.Cols[k].AllowEditing = false;
			fgrid_main.Cols[0].StyleNew.BackColor = COM.ComVar.GridCol0_Color;	
		
			fgrid_size.Enabled  = true;
			btn_search.Enabled = false;
		}
		public void init_fgrid_size_new()
		{
			string temp="";
			string temp1="";
			//string [,] arr;
			try
			{
				if( ClassLib.ComVar._mold_cd !="")
				{
					DataTable dt = Select_mold_size_by_tool(ClassLib.ComVar._mold_cd);
					int dt_rows = dt.Rows.Count;
					int dt_cols = dt.Columns.Count;
					int k =0;
					int l =0;
					int n =1;
					string  qty ="";
					string [,] arr = new string[dt_cols,dt_rows];
					fgrid_size.Clear();
					fgrid_size.ExtendLastCol = false;
					this.Cursor = Cursors.WaitCursor;
					fgrid_size.Rows.Count = 2;
					for (int j = 0; j < dt_rows; j++)
					{
						if(k<dt_rows)
						{
							temp1 = dt.Rows[k].ItemArray[0].ToString();
							temp= dt.Rows[k].ItemArray[2].ToString();
							qty = dt.Rows[k].ItemArray[1].ToString();
							for (int i=k;i<dt_rows;i++)
							{
								if ( temp == dt.Rows[i].ItemArray[2].ToString() && temp != dt.Rows[i].ItemArray[0].ToString())
								{
										
									temp1 = temp1 +"/"+ dt.Rows[i].ItemArray[0].ToString() ;
									k++;
									l++;
								}
							}
							if (temp !="")
							{
								arr[0,j] =temp1;
								arr[1,j] =qty;
								temp="";
								k=k+1;
								l=0;
								n++;
							}
						}
					}
					fgrid_size.Cols.Count = n +2;
					//					fgrid_main.Rows.Count = n+2;
					for (int i = 0; i <n -1 ; i++)
					{
						fgrid_size[0, i+3] = arr[0,i];
					}
					
					fgrid_size[0, 0] = "   ";
					fgrid_size[0, 1] = "Mold Code";
					fgrid_size[1, 1] = ClassLib.ComVar._mold_cd;
					fgrid_size[0, 2] = "Order Qty";
					fgrid_size[1, 2] = "";
					fgrid_size.AutoSizeCols();
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
			
			init_fgrid_main_new();
		}
		private void search_mold_purhead_info()
		{
			int _total =0;
			string _rtaymd="";
			string _estymd="";
			try
			{
				DataTable vDt= null;
				vDt = select_mold_purhead();
//				fgrid_size.Cols.Count = vDt.Rows.Count + 3;
				for(int i =0;i< vDt.Rows.Count ;i++)
				{
					for(int j = 0; j < fgrid_size.Cols.Count-3 ; j++)
					{
						if (vDt.Rows[i].ItemArray[4].ToString() == fgrid_size[0,j+3].ToString())
						{
							fgrid_size[1,j+3] = vDt.Rows[i].ItemArray[6];//.ToString();
						}
					}
					_total = _total + System.Convert.ToInt32(vDt.Rows[i].ItemArray[6].ToString());
				}
				fgrid_size[0,0] = "        ";
				fgrid_size[0,1] = "Mold_code";
				fgrid_size[1,1] = vDt.Rows[1].ItemArray[3].ToString();
				fgrid_size[0,2] = "Total_Qty";
				fgrid_size[1,2] = _total;
				_rtaymd = vDt.Rows[1].ItemArray[9].ToString ().Substring(0,4) +"-"+ vDt.Rows[1].ItemArray[9].ToString().Substring(4,2) +"-"+ vDt.Rows[1].ItemArray[9].ToString().Substring(6,2);
				_estymd = vDt.Rows[1].ItemArray[10].ToString().Substring(0,4) +"-"+ vDt.Rows[1].ItemArray[10].ToString().Substring(4,2) +"-"+vDt.Rows[1].ItemArray[10].ToString().Substring(6,2);
				cmb_purDiv.SelectedValue = vDt.Rows[1].ItemArray[12].ToString();
				txt_status.Text          = vDt.Rows[1].ItemArray[11].ToString();
				cmb_buyDiv.SelectedValue = vDt.Rows[1].ItemArray[13].ToString();
				dpick_rtaYmd.Text        = _rtaymd.ToString();
				dpick_etsYmd.Text        = _estymd.ToString();
				//mold_ord_sum();
				fgrid_size.AutoSizeCols();

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
		private DataTable select_mold_purhead()
		{
			string Proc_Name = "PKG_SDT_MOLD.SEARCH_MOLD_PURHEAD";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			OraDB.Process_Name = Proc_Name;

			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[2]  = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = cmb_purNo.Text;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}
		private void search_mold_purtail_info()
		{
			//int _total =0;
			try
			{
				DataTable vDt= null;
				vDt = select_mold_purtail();
				//--------------------------------------
				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count ; i++)
					{
						for (int k = 0 ; k < fgrid_main.Cols.Count-1 ; k++)
						{
							if (vDt.Rows[i].ItemArray[1].ToString() == fgrid_main[0,k+1].ToString()) 
							{
								for (int j = 0 ; j <fgrid_main.Rows.Count -1 ; j++)
								{
									if (vDt.Rows[i].ItemArray[2].ToString()== fgrid_main[j+1,0].ToString()) 
										fgrid_main[j+1,k+1] = vDt.Rows[i].ItemArray[3].ToString() ; 
								}
							}
						}
					}
				}
				else
				{
				}

				//-------------------------------------
				
				fgrid_main.AutoSizeCols();
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
		private DataTable select_mold_purtail()
		{
			string Proc_Name = "PKG_SDT_MOLD.SEARCH_MOLD_PURTAIL";
			//int arg_len =arg_array.Length + 7;
			OraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			OraDB.Process_Name = Proc_Name;

			//02.ARGURMENT명
			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[2]  = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = cmb_purNo.Text;
			OraDB.Parameter_Values[2] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

		private void init_mold_order_seq(int _start, int _end, int _col)
		{
			//_start = _start -2;
			int l =0;
			char f,s;
			if (_end >= _start)
			{
				for (int i = _start; i <= _end; i++)
				{
					if(i > 27)
					{
						f = (char)(65);
						s = (char)(65+l);
						fgrid_main[i,0] = f.ToString() + s.ToString(); //(char)(65) + (char)(65+l);
//						fgrid_main[i,0] = i - 1;
						l++;
					}
					else
					{
						if(_col < 1)
							fgrid_main[i,0] = (char)(65+i-1);
//							fgrid_main[i,0] = i - 1;
					}
				}
			}
		}

		private void Search_Seq_Stand()
		{
			System.Data.DataTable vDt = null;
			try
			{
				vDt = SELECT_MOLD_SEQ_STAND();    
//				fgrid_main.Clear();

				if(vDt.Rows.Count > 0)
				{
					for(int i = 0; i < vDt.Rows.Count; i++)
					{
						fgrid_main.Rows.Count  = vDt.Rows.Count + 1 ; 						
						fgrid_main[i+1,0] = vDt.Rows[i].ItemArray[0].ToString() ;						
//						fgrid_main[i+2,1] = vDt.Rows[i].ItemArray[0].ToString() ;						
						fgrid_main.AutoSizeCols();
						fgrid_main.Cols[0].TextAlign = TextAlignEnum.CenterCenter;
					}
				}
				else
				{
					
				}
				vDt.Dispose();
			}
			finally
			{
				if (vDt != null) 
					vDt.Dispose();
			}	
		}
		private System.Data.DataTable SELECT_MOLD_SEQ_STAND()
		{
			System.Data.DataSet retDS;
			
			OraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SDT_MOLD.SEARCH_OUT_TAIL_SEQ";

			//02.ARGURMENT 명
			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_OUT_NU";
			OraDB.Parameter_Name[2] = "ARG_MOLD_CD";
			OraDB.Parameter_Name[3] = "ARG_DIVISION";
			OraDB.Parameter_Name[4] = "ARG_WH_CD";

			OraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;		
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			OraDB.Parameter_Values[0] = "VJ";
			OraDB.Parameter_Values[1] = "";
			if ((cmb_purNo.Text == "")||(cmb_purNo.Text == null))
				OraDB.Parameter_Values[2] = "";
			else
				OraDB.Parameter_Values[2] = cmb_purNo.SelectedValue.ToString();
			OraDB.Parameter_Values[3] = "2";
			OraDB.Parameter_Values[4] = "";
			OraDB.Parameter_Values[5] = "";
			
			OraDB.Add_Select_Parameter(true);
			retDS = OraDB.Exe_Select_Procedure();
			if(retDS == null) return null ;
			return retDS.Tables[OraDB.Process_Name];
		}

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_main.Rows.Add();
		}

		private void cmb_purNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			ClassLib.ComVar._mold_cd = cmb_purNo.SelectedValue.ToString().Substring(14,10).Trim();	
			if ((cmb_purNo.Text != "")||(cmb_purNo.Text == null))
			{
				DataTable Mold = Select_mold();
				string temp = Mold.Rows[0].ItemArray[0].ToString();
				txt_Mold.Text = temp;
			}
		}
		private DataTable Select_mold()
		{
			string Proc_Name = "PKG_SDT_MOLD.SELECT_MOLD_CD";
			
			OraDB.ReDim_Parameter(4); 

			OraDB.Process_Name = Proc_Name;

			OraDB.Parameter_Name[0]  = "ARG_FACTORY";
			OraDB.Parameter_Name[1]  = "ARG_PUR_YMD";
			OraDB.Parameter_Name[2]  = "ARG_PUR_NO";
			OraDB.Parameter_Name[3]  = "OUT_CURSOR";
 
			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = "VJ";
			//			OraDB.Parameter_Values[1] = dtp_PO_date.Text.Replace("-","").Replace("/","");
			OraDB.Parameter_Values[1] = dpick_purYmd.Value.ToString("yyyyMMdd").Replace("-","").Replace("/","");
			OraDB.Parameter_Values[2] = cmb_purNo.Text.ToString();
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);

			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if (DS_Ret == null) return null;

			return DS_Ret.Tables[Proc_Name];
		}

	}
}

