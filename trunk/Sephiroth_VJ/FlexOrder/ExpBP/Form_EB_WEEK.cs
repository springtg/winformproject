
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;

namespace FlexOrder.ExpBP
{
	public class Form_EB_WEEK : COM.OrderWinForm.Form_Top
	{
		#region 컨트롤 정의 및 리소스 정리
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_BP_NO;
		private System.Windows.Forms.Label lbl_Del_Month;
		private C1.Win.C1List.C1Combo cmb_Qty_Div;
		private C1.Win.C1List.C1Combo cmb_OBS_Type;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.DateTimePicker dpick_LW_To;
		private System.Windows.Forms.DateTimePicker dpick_LW_From;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.Label lbl_Subtitle2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label lbl_SubTitle3;
		//private System.Windows.Forms.Label lbl_SubTitle;
		private System.ComponentModel.IContainer components = null;

		public Form_EB_WEEK()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EB_WEEK));
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbl_Subtitle2 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmb_OBS_Type = new C1.Win.C1List.C1Combo();
			this.cmb_Qty_Div = new C1.Win.C1List.C1Combo();
			this.lbl_BP_NO = new System.Windows.Forms.Label();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dpick_LW_From = new System.Windows.Forms.DateTimePicker();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.dpick_LW_To = new System.Windows.Forms.DateTimePicker();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.lbl_SubTitle3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Qty_Div)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
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
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.DockPadding.All = 8;
			this.panel3.Location = new System.Drawing.Point(0, 60);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1000, 124);
			this.panel3.TabIndex = 49;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbl_Subtitle2);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(512, 8);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(480, 108);
			this.panel4.TabIndex = 130;
			// 
			// lbl_Subtitle2
			// 
			this.lbl_Subtitle2.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_Subtitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Subtitle2.Image")));
			this.lbl_Subtitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_Subtitle2.Name = "lbl_Subtitle2";
			this.lbl_Subtitle2.Size = new System.Drawing.Size(165, 30);
			this.lbl_Subtitle2.TabIndex = 170;
			this.lbl_Subtitle2.Text = "      BP Info.";
			this.lbl_Subtitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.RosyBrown;
			this.panel5.Controls.Add(this.cmb_OBS_Type);
			this.panel5.Controls.Add(this.cmb_Qty_Div);
			this.panel5.Controls.Add(this.lbl_BP_NO);
			this.panel5.Controls.Add(this.lbl_Del_Month);
			this.panel5.Controls.Add(this.pictureBox17);
			this.panel5.Controls.Add(this.pictureBox18);
			this.panel5.Controls.Add(this.pictureBox19);
			this.panel5.Controls.Add(this.pictureBox20);
			this.panel5.Controls.Add(this.pictureBox21);
			this.panel5.Controls.Add(this.pictureBox22);
			this.panel5.Controls.Add(this.pictureBox23);
			this.panel5.Controls.Add(this.pictureBox24);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(480, 108);
			this.panel5.TabIndex = 128;
			// 
			// cmb_OBS_Type
			// 
			this.cmb_OBS_Type.AddItemCols = 0;
			this.cmb_OBS_Type.AddItemSeparator = ';';
			this.cmb_OBS_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type.Caption = "";
			this.cmb_OBS_Type.CaptionHeight = 17;
			this.cmb_OBS_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type.ColumnFooterHeight = 18;
			this.cmb_OBS_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type.ContentHeight = 15;
			this.cmb_OBS_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_Type.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type.EditorHeight = 15;
			this.cmb_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type.GapHeight = 2;
			this.cmb_OBS_Type.ItemHeight = 15;
			this.cmb_OBS_Type.Location = new System.Drawing.Point(118, 53);
			this.cmb_OBS_Type.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type.MaxLength = 32767;
			this.cmb_OBS_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type.Name = "cmb_OBS_Type";
			this.cmb_OBS_Type.PartialRightColumn = false;
			this.cmb_OBS_Type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_OBS_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type.TabIndex = 120;
			// 
			// cmb_Qty_Div
			// 
			this.cmb_Qty_Div.AddItemCols = 0;
			this.cmb_Qty_Div.AddItemSeparator = ';';
			this.cmb_Qty_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Qty_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Qty_Div.Caption = "";
			this.cmb_Qty_Div.CaptionHeight = 17;
			this.cmb_Qty_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Qty_Div.ColumnCaptionHeight = 18;
			this.cmb_Qty_Div.ColumnFooterHeight = 18;
			this.cmb_Qty_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Qty_Div.ContentHeight = 15;
			this.cmb_Qty_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Qty_Div.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Qty_Div.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Qty_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Qty_Div.EditorHeight = 15;
			this.cmb_Qty_Div.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Qty_Div.GapHeight = 2;
			this.cmb_Qty_Div.ItemHeight = 15;
			this.cmb_Qty_Div.Location = new System.Drawing.Point(118, 33);
			this.cmb_Qty_Div.MatchEntryTimeout = ((long)(2000));
			this.cmb_Qty_Div.MaxDropDownItems = ((short)(5));
			this.cmb_Qty_Div.MaxLength = 32767;
			this.cmb_Qty_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Qty_Div.Name = "cmb_Qty_Div";
			this.cmb_Qty_Div.PartialRightColumn = false;
			this.cmb_Qty_Div.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tru" +
				"e;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Con" +
				"trol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Qty_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Qty_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Qty_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Qty_Div.Size = new System.Drawing.Size(210, 19);
			this.cmb_Qty_Div.TabIndex = 119;
			// 
			// lbl_BP_NO
			// 
			this.lbl_BP_NO.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_BP_NO.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_BP_NO.ImageIndex = 0;
			this.lbl_BP_NO.ImageList = this.img_Label;
			this.lbl_BP_NO.Location = new System.Drawing.Point(17, 32);
			this.lbl_BP_NO.Name = "lbl_BP_NO";
			this.lbl_BP_NO.Size = new System.Drawing.Size(100, 21);
			this.lbl_BP_NO.TabIndex = 118;
			this.lbl_BP_NO.Text = "Quantity Div.";
			this.lbl_BP_NO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Del_Month
			// 
			this.lbl_Del_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Del_Month.ImageIndex = 0;
			this.lbl_Del_Month.ImageList = this.img_Label;
			this.lbl_Del_Month.Location = new System.Drawing.Point(17, 53);
			this.lbl_Del_Month.Name = "lbl_Del_Month";
			this.lbl_Del_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Del_Month.TabIndex = 117;
			this.lbl_Del_Month.Text = "Po Type";
			this.lbl_Del_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(165, 0);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(304, 30);
			this.pictureBox17.TabIndex = 2;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox18.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(467, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(13, 30);
			this.pictureBox18.TabIndex = 1;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(449, 30);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(31, 62);
			this.pictureBox19.TabIndex = 5;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox20.BackColor = System.Drawing.Color.Blue;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(455, 78);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(25, 30);
			this.pictureBox20.TabIndex = 8;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(0, 24);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(32, 73);
			this.pictureBox21.TabIndex = 3;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox22.BackColor = System.Drawing.Color.Blue;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(0, 78);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(72, 40);
			this.pictureBox22.TabIndex = 6;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox23.BackColor = System.Drawing.Color.Blue;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(72, 78);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(392, 30);
			this.pictureBox23.TabIndex = 9;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.Color.Navy;
			this.pictureBox24.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(32, 24);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(432, 76);
			this.pictureBox24.TabIndex = 4;
			this.pictureBox24.TabStop = false;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.lbl_SubTitle3);
			this.panel6.Controls.Add(this.panel7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.DockPadding.Right = 4;
			this.panel6.Location = new System.Drawing.Point(8, 8);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(504, 108);
			this.panel6.TabIndex = 128;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.RosyBrown;
			this.panel7.Controls.Add(this.label3);
			this.panel7.Controls.Add(this.label2);
			this.panel7.Controls.Add(this.txt_Style_Cd);
			this.panel7.Controls.Add(this.label1);
			this.panel7.Controls.Add(this.dpick_LW_From);
			this.panel7.Controls.Add(this.lbl_Factory);
			this.panel7.Controls.Add(this.cmb_Factory);
			this.panel7.Controls.Add(this.dpick_LW_To);
			this.panel7.Controls.Add(this.pictureBox25);
			this.panel7.Controls.Add(this.pictureBox26);
			this.panel7.Controls.Add(this.pictureBox27);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(500, 108);
			this.panel7.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(16, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 200;
			this.label3.Text = "Style Cd";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 1;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(16, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 199;
			this.label2.Text = "LastingWeek";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style_Cd.Location = new System.Drawing.Point(117, 75);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.Size = new System.Drawing.Size(210, 21);
			this.txt_Style_Cd.TabIndex = 198;
			this.txt_Style_Cd.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(216, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(10, 16);
			this.label1.TabIndex = 196;
			this.label1.Text = "~";
			// 
			// dpick_LW_From
			// 
			this.dpick_LW_From.CustomFormat = "yyyyMMdd";
			this.dpick_LW_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_LW_From.Location = new System.Drawing.Point(117, 54);
			this.dpick_LW_From.Name = "dpick_LW_From";
			this.dpick_LW_From.Size = new System.Drawing.Size(100, 20);
			this.dpick_LW_From.TabIndex = 194;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(16, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 115;
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
			this.cmb_Factory.ContentHeight = 15;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 15;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(117, 33);
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
				"8pt;BackColor:White;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}S" +
				"tyle1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Con" +
				"trol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}S" +
				"tyle10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.L" +
				"istBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeight" +
				"=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\">" +
				"<ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBar" +
				"><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"S" +
				"tyle9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foote" +
				"r\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent=" +
				"\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" /><" +
				"InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"S" +
				"tyle8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedSt" +
				"yle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.Wi" +
				"n.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Style" +
				" parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style par" +
				"ent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style pare" +
				"nt=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style pa" +
				"rent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent=" +
				"\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedStyl" +
				"es><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout>" +
				"<DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 118;
			// 
			// dpick_LW_To
			// 
			this.dpick_LW_To.CustomFormat = "yyyyMMdd";
			this.dpick_LW_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dpick_LW_To.Location = new System.Drawing.Point(228, 54);
			this.dpick_LW_To.Name = "dpick_LW_To";
			this.dpick_LW_To.Size = new System.Drawing.Size(100, 20);
			this.dpick_LW_To.TabIndex = 195;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(165, -1);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(316, 32);
			this.pictureBox25.TabIndex = 2;
			this.pictureBox25.TabStop = false;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(478, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(22, 32);
			this.pictureBox26.TabIndex = 1;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(481, 32);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(19, 62);
			this.pictureBox27.TabIndex = 5;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(32, 73);
			this.pictureBox28.TabIndex = 3;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(410, 94);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(90, 14);
			this.pictureBox29.TabIndex = 8;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(72, 94);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(412, 14);
			this.pictureBox30.TabIndex = 9;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox31.BackColor = System.Drawing.Color.Blue;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 94);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(80, 14);
			this.pictureBox31.TabIndex = 6;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.Color.Navy;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(32, 24);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(452, 76);
			this.pictureBox32.TabIndex = 4;
			this.pictureBox32.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.TabIndex = 0;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 9;
			this.pnl_Body.DockPadding.Right = 9;
			this.pnl_Body.Location = new System.Drawing.Point(0, 184);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1000, 456);
			this.pnl_Body.TabIndex = 50;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,85,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(9, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(982, 456);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 35;
			this.fgrid_Main.Click += new System.EventHandler(this.fgrid_Main_Click);
			// 
			// lbl_SubTitle3
			// 
			this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
			this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle3.Name = "lbl_SubTitle3";
			this.lbl_SubTitle3.Size = new System.Drawing.Size(165, 30);
			this.lbl_SubTitle3.TabIndex = 171;
			this.lbl_SubTitle3.Text = "      BP Info.";
			this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form_EB_WEEK
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 13);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.panel3);
			this.Font = new System.Drawing.Font("Verdana", 8F);
			this.Name = "Form_EB_WEEK";
			this.Load += new System.EventHandler(this.Form_EB_WEEK_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.panel3, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Qty_Div)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의
		 int _Rowfixed  = 2;
		 COM.OraDB MyOraDB = new COM.OraDB();   
		#endregion

		#region 멤버 메서드 
		private void Init_Form()
		{ 

			//Title
			this.Text = "Search Weekly Order Sheet";
			this.lbl_MainTitle.Text = "Weekly Order"; 
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한
//
//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				
//				
//				btn_control = null;
//
//
//				//Button 활성화
//			    tbtn_Append.Enabled = false;   tbtn_Delete.Enabled = false;   tbtn_Insert.Enabled = false;  tbtn_Save.Enabled = false;
//
//			}
//			catch
//			{
//			}

			#endregion

			#region 그리드 적용
			DataTable dt_list; 
						
			// 그리드 설정(TBSEM_BP_SEARCH)
			_Rowfixed = 6;
			fgrid_Main.Set_Grid( "SEM_BP_WEEK", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			ClassLib.ComFunction.Set_Size_Grid(fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_BP_WEEK.lxGEN);
			fgrid_Main.Font  = new Font("Verdana",8);

			//Gender Size  색상 + Bold
			
            ClassLib.ComFunction.Set_Gen_Color("01", fgrid_Main, _Rowfixed, 1, (int)ClassLib.TBSEM_BP_WEEK.lxGEN);
            ClassLib.ComFunction.Set_Head_Bold("01", fgrid_Main, _Rowfixed, (int)ClassLib.TBSEM_BP_WEEK.lxGEN);

			//merge
			fgrid_Main.AllowMerging = AllowMergingEnum.Free;
			for (int i = (int)ClassLib.TBSEM_BP_WEEK.lxGEN+1 ;i< fgrid_Main.Cols.Count-1;  i++)
			{fgrid_Main.Cols[i].AllowMerging = false;}

			#endregion 

			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxQTY_Div);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_Qty_Div, 1, 2,false,true);
			cmb_Qty_Div.SelectedIndex = 0;
			
			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type , 1, 2,false,true);		
			cmb_OBS_Type.SelectedIndex = 0;
			
		}


		private void Display_fgrid(DataTable arg_dt)
		{
			fgrid_Main.Rows.Count = _Rowfixed;

			// Set List
			int iRow_Gen=0;
			int iLAST_WK   = (int)ClassLib.TBSEM_BP_WEEK.lxBP_NO; 
			int iOBS_ID    = (int)ClassLib.TBSEM_BP_WEEK.lxDPO_ID;
			int iSTYLE_CD  = (int)ClassLib.TBSEM_BP_WEEK.lxSTYLE_CD;
			int iGEN       = (int)ClassLib.TBSEM_BP_WEEK.lxGEN;
			int iTot	   =0;
			
			#region  사이즈런 배분
			for(int i=0; i<arg_dt.Rows.Count; i++)
			{					
				string sLAST_WK   = arg_dt.Rows[i].ItemArray[iLAST_WK -1].ToString();
				string sOBS_ID    = arg_dt.Rows[i].ItemArray[iOBS_ID-1].ToString();
				string sSTYLE_CD  = arg_dt.Rows[i].ItemArray[iSTYLE_CD-1].ToString();
				string sSIZE      = arg_dt.Rows[i].ItemArray[iGEN].ToString();
				string sQTY       = arg_dt.Rows[i].ItemArray[iGEN+1].ToString();	

				if (( fgrid_Main.Rows.Count == _Rowfixed ) ||
					( sLAST_WK  != fgrid_Main[fgrid_Main.Rows.Count-1, iLAST_WK].ToString()) || 
					( sOBS_ID   != fgrid_Main[fgrid_Main.Rows.Count-1, iOBS_ID].ToString()) || 
					( sSTYLE_CD != fgrid_Main[fgrid_Main.Rows.Count-1, iSTYLE_CD].ToString()))
				{
					fgrid_Main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+1] = " ";
					fgrid_Main[fgrid_Main.Rows.Count-1, iGEN+2] = " ";
											
					string sGEN = arg_dt.Rows[i].ItemArray[iGEN-1].ToString();
					for(int j=1; j<_Rowfixed; j++)
						if (fgrid_Main[j, iGEN].ToString() == sGEN)
							iRow_Gen = j;

					iTot = 0;
					
					//Size qty 0 : For Reporting
					for(int j=(int)ClassLib.TBSEM_BP_WEEK.lxCS_SIZE; j<fgrid_Main.Cols.Count; j++)
						fgrid_Main[fgrid_Main.Rows.Count-1, j]=0;


				}

				for(int j=iGEN; j<fgrid_Main.Cols.Count; j++)
				{
					if (fgrid_Main[iRow_Gen, j].ToString() == sSIZE)
					{
						fgrid_Main[fgrid_Main.Rows.Count-1, j] = sQTY;
						iTot = iTot +Convert.ToInt32( fgrid_Main[fgrid_Main.Rows.Count-1, j].ToString());
						break;
					}
				}



				fgrid_Main[fgrid_Main.Rows.Count-1, (int)ClassLib.TBSEM_BP_WEEK.lxMPS_QTY] = iTot;
			} 
			#endregion

			//서브 토털
//			fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;
//			fgrid_Main.Tree.Column = (int)ClassLib.TBSEM_BP_WEEK.lxBP_NO;
//
//			for (int c = (int)ClassLib.TBSEM_BP_WEEK.lxGEN  +1 ; c < fgrid_Main.Cols.Count; c++)
//			{
//				fgrid_Main.Subtotal(AggregateEnum.Sum, 1, 1, (int)ClassLib.TBSEM_BP_WEEK.lxMPS_QTY, "Grand Total {0}");
//				fgrid_Main.Subtotal(AggregateEnum.Sum, 1, 1, c, "Style Total {0}");
//				fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor  = ClassLib.ComVar.ClrTotFirst;
//				fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor  = Color.Black;
//
//			}
		}


		#endregion

		#region DB 컨트롤
		private DataTable Select_Data_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_LOT.SELECT_SEM_WEEK";
            
			int iCnt  = 7;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_LASTING_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_LASTING_TO";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_QTY_DIV";
			MyOraDB.Parameter_Name[5] = "ARG_PO_TYPE";
			MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

			//03.DATA TYPE
			for (int i =0 ; i <  iCnt-1 ;i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

			MyOraDB.Parameter_Type[iCnt-1] = (int)OracleType.Cursor;


			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = Convert.ToDateTime(dpick_LW_From.Text).ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[2] = Convert.ToDateTime(dpick_LW_To.Text).ToString("yyyyMMdd");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_TextBox(txt_Style_Cd," ");
			MyOraDB.Parameter_Values[4] = cmb_Qty_Div.SelectedValue.ToString();
			MyOraDB.Parameter_Values[5] = cmb_OBS_Type.SelectedValue.ToString();
			MyOraDB.Parameter_Values[6] ="";
			

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}

		#endregion

		#region 이벤트처리

		private void fgrid_Main_Click(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_Gen_Color("01",fgrid_Main,_Rowfixed,fgrid_Main.Selection.r1,(int)ClassLib.TBSEM_BP_WEEK.lxGEN);
		}


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				DataTable dt_list ;
				
				dt_list = Select_Data_List();
				Display_fgrid(dt_list);

				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSearch, this); 


			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this); 
			}			
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			string mrd_Filename = "Form_EB_WEEK.mrd" ;
			string txt_Filename = this.Name + ".txt"; 
			string Para         = " ";


			//조회조건들----------------------------------------------------------------------
			int  iCnt  = 6;
			string [] aHead =  new string[iCnt];	
			aHead[0]    = cmb_Factory.SelectedValue.ToString();
			aHead[1]    = dpick_LW_From.Text.ToString();
			aHead[2]    = dpick_LW_To.Text.ToString();
			aHead[3]    = txt_Style_Cd.Text;
			aHead[4]    = cmb_Qty_Div.SelectedValue.ToString();
			aHead[5]    = cmb_OBS_Type.SelectedValue.ToString();
			//------------------- ------------------------------------------------------------


			//Parameter만들기-----------------------------------------------------------------
			Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
			for (int i  = 1 ; i<= iCnt ; i++)
			{
				Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
			}
			Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";
			//------------------- ------------------------------------------------------------

			//File 출력 리스트
			fgrid_Main.SaveGrid(txt_Filename, FileFormatEnum.TextComma);

			//Report Base Form호출..
			FlexOrder.Report.Form_RD_Base report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
			report.Show();

		}


		#endregion

		
		private void Form_EB_WEEK_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}
	}
}

