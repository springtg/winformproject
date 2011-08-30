using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;


namespace FlexOrder.ExpOBS
{
	public class POP_EO_Type_Change : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_From;
		private C1.Win.C1List.C1Combo cmb_OBS_Type_From;
		private System.Windows.Forms.Label lbl_Del_Month;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory_From;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel panel1;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_To;
		private C1.Win.C1List.C1Combo cmb_OBS_Type_To;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Factory_To;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Label lbl_SubTitle2;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_OBS_Seq_Nu;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_OBS_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Nu;
		private System.Windows.Forms.TextBox txt_OBS_Seq_Nu;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.TextBox txt_Chg_Nu;
		private System.Windows.Forms.Label lbl_Chg_Nu;
		private System.Windows.Forms.Label btn_Apply;
		private System.ComponentModel.IContainer components = null;

		public POP_EO_Type_Change()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_EO_Type_Change));
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.cmb_OBS_ID_From = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type_From = new C1.Win.C1List.C1Combo();
			this.lbl_Del_Month = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory_From = new C1.Win.C1List.C1Combo();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cmb_OBS_ID_To = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_Type_To = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmb_Factory_To = new C1.Win.C1List.C1Combo();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.lbl_OBS_Seq_Nu = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_OBS_Nu = new System.Windows.Forms.Label();
			this.txt_OBS_Nu = new System.Windows.Forms.TextBox();
			this.txt_OBS_Seq_Nu = new System.Windows.Forms.TextBox();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.txt_Chg_Nu = new System.Windows.Forms.TextBox();
			this.lbl_Chg_Nu = new System.Windows.Forms.Label();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_From)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_To)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(-16, 16);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(8, 8);
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Chg_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Chg_Nu);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.txt_OBS_Seq_Nu);
			this.pnl_Search1_Image.Controls.Add(this.txt_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Seq_Nu);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Nu);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID_From);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_Type_From);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Del_Month);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory_From);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_Search1_Image.Location = new System.Drawing.Point(0, 0);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(330, 192);
			this.pnl_Search1_Image.TabIndex = 127;
			// 
			// cmb_OBS_ID_From
			// 
			this.cmb_OBS_ID_From.AddItemCols = 0;
			this.cmb_OBS_ID_From.AddItemSeparator = ';';
			this.cmb_OBS_ID_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID_From.Caption = "";
			this.cmb_OBS_ID_From.CaptionHeight = 17;
			this.cmb_OBS_ID_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID_From.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID_From.ColumnFooterHeight = 18;
			this.cmb_OBS_ID_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID_From.ContentHeight = 15;
			this.cmb_OBS_ID_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID_From.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_ID_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_From.EditorHeight = 15;
			this.cmb_OBS_ID_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.GapHeight = 2;
			this.cmb_OBS_ID_From.ItemHeight = 15;
			this.cmb_OBS_ID_From.Location = new System.Drawing.Point(111, 76);
			this.cmb_OBS_ID_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID_From.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID_From.MaxLength = 32767;
			this.cmb_OBS_ID_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID_From.Name = "cmb_OBS_ID_From";
			this.cmb_OBS_ID_From.PartialRightColumn = false;
			this.cmb_OBS_ID_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_ID_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_From.Size = new System.Drawing.Size(209, 19);
			this.cmb_OBS_ID_From.TabIndex = 129;
			// 
			// cmb_OBS_Type_From
			// 
			this.cmb_OBS_Type_From.AddItemCols = 0;
			this.cmb_OBS_Type_From.AddItemSeparator = ';';
			this.cmb_OBS_Type_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type_From.Caption = "";
			this.cmb_OBS_Type_From.CaptionHeight = 17;
			this.cmb_OBS_Type_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type_From.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type_From.ColumnFooterHeight = 18;
			this.cmb_OBS_Type_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type_From.ContentHeight = 15;
			this.cmb_OBS_Type_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type_From.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_Type_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type_From.EditorHeight = 15;
			this.cmb_OBS_Type_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_From.GapHeight = 2;
			this.cmb_OBS_Type_From.ItemHeight = 15;
			this.cmb_OBS_Type_From.Location = new System.Drawing.Point(111, 54);
			this.cmb_OBS_Type_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type_From.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type_From.MaxLength = 32767;
			this.cmb_OBS_Type_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type_From.Name = "cmb_OBS_Type_From";
			this.cmb_OBS_Type_From.PartialRightColumn = false;
			this.cmb_OBS_Type_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_Type_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_From.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type_From.TabIndex = 128;
			this.cmb_OBS_Type_From.TextChanged += new System.EventHandler(this.cmb_OBS_Type_From_TextChanged);
			// 
			// lbl_Del_Month
			// 
			this.lbl_Del_Month.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Del_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Del_Month.ImageIndex = 2;
			this.lbl_Del_Month.ImageList = this.img_Label;
			this.lbl_Del_Month.Location = new System.Drawing.Point(10, 75);
			this.lbl_Del_Month.Name = "lbl_Del_Month";
			this.lbl_Del_Month.Size = new System.Drawing.Size(100, 21);
			this.lbl_Del_Month.TabIndex = 127;
			this.lbl_Del_Month.Text = "Delivery Month";
			this.lbl_Del_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 2;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 31);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 124;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory_From
			// 
			this.cmb_Factory_From.AddItemCols = 0;
			this.cmb_Factory_From.AddItemSeparator = ';';
			this.cmb_Factory_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_From.Caption = "";
			this.cmb_Factory_From.CaptionHeight = 17;
			this.cmb_Factory_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_From.ColumnCaptionHeight = 18;
			this.cmb_Factory_From.ColumnFooterHeight = 18;
			this.cmb_Factory_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_From.ContentHeight = 15;
			this.cmb_Factory_From.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_From.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Factory_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_From.EditorHeight = 15;
			this.cmb_Factory_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_From.GapHeight = 2;
			this.cmb_Factory_From.ItemHeight = 15;
			this.cmb_Factory_From.Location = new System.Drawing.Point(111, 32);
			this.cmb_Factory_From.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_From.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_From.MaxLength = 32767;
			this.cmb_Factory_From.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_From.Name = "cmb_Factory_From";
			this.cmb_Factory_From.PartialRightColumn = false;
			this.cmb_Factory_From.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_Factory_From.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_From.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory_From.TabIndex = 126;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 2;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 53);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 125;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(308, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(146, 32);
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
			this.lbl_SubTitle1.Text = "      Original Info";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(311, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 146);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(240, 178);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 157);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 178);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(80, 14);
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.Color.Blue;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(72, 178);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(242, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.Color.Navy;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(32, 24);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(282, 160);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RosyBrown;
			this.panel1.Controls.Add(this.cmb_OBS_ID_To);
			this.panel1.Controls.Add(this.cmb_OBS_Type_To);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmb_Factory_To);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox10);
			this.panel1.Controls.Add(this.lbl_SubTitle2);
			this.panel1.Controls.Add(this.pictureBox11);
			this.panel1.Controls.Add(this.pictureBox12);
			this.panel1.Controls.Add(this.pictureBox13);
			this.panel1.Controls.Add(this.pictureBox14);
			this.panel1.Controls.Add(this.pictureBox15);
			this.panel1.Controls.Add(this.pictureBox16);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 192);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 104);
			this.panel1.TabIndex = 128;
			// 
			// cmb_OBS_ID_To
			// 
			this.cmb_OBS_ID_To.AddItemCols = 0;
			this.cmb_OBS_ID_To.AddItemSeparator = ';';
			this.cmb_OBS_ID_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_ID_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_ID_To.Caption = "";
			this.cmb_OBS_ID_To.CaptionHeight = 17;
			this.cmb_OBS_ID_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_ID_To.ColumnCaptionHeight = 18;
			this.cmb_OBS_ID_To.ColumnFooterHeight = 18;
			this.cmb_OBS_ID_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_ID_To.ContentHeight = 15;
			this.cmb_OBS_ID_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_ID_To.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_ID_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_To.EditorHeight = 15;
			this.cmb_OBS_ID_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.GapHeight = 2;
			this.cmb_OBS_ID_To.ItemHeight = 15;
			this.cmb_OBS_ID_To.Location = new System.Drawing.Point(111, 76);
			this.cmb_OBS_ID_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_ID_To.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_ID_To.MaxLength = 32767;
			this.cmb_OBS_ID_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_ID_To.Name = "cmb_OBS_ID_To";
			this.cmb_OBS_ID_To.PartialRightColumn = false;
			this.cmb_OBS_ID_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_ID_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_ID_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_ID_To.Size = new System.Drawing.Size(209, 19);
			this.cmb_OBS_ID_To.TabIndex = 129;
			// 
			// cmb_OBS_Type_To
			// 
			this.cmb_OBS_Type_To.AddItemCols = 0;
			this.cmb_OBS_Type_To.AddItemSeparator = ';';
			this.cmb_OBS_Type_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OBS_Type_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OBS_Type_To.Caption = "";
			this.cmb_OBS_Type_To.CaptionHeight = 17;
			this.cmb_OBS_Type_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OBS_Type_To.ColumnCaptionHeight = 18;
			this.cmb_OBS_Type_To.ColumnFooterHeight = 18;
			this.cmb_OBS_Type_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OBS_Type_To.ContentHeight = 15;
			this.cmb_OBS_Type_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_OBS_Type_To.EditorBackColor = System.Drawing.Color.White;
			this.cmb_OBS_Type_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_Type_To.EditorHeight = 15;
			this.cmb_OBS_Type_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_Type_To.GapHeight = 2;
			this.cmb_OBS_Type_To.ItemHeight = 15;
			this.cmb_OBS_Type_To.Location = new System.Drawing.Point(111, 54);
			this.cmb_OBS_Type_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_OBS_Type_To.MaxDropDownItems = ((short)(5));
			this.cmb_OBS_Type_To.MaxLength = 32767;
			this.cmb_OBS_Type_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OBS_Type_To.Name = "cmb_OBS_Type_To";
			this.cmb_OBS_Type_To.PartialRightColumn = false;
			this.cmb_OBS_Type_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_OBS_Type_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OBS_Type_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OBS_Type_To.Size = new System.Drawing.Size(210, 19);
			this.cmb_OBS_Type_To.TabIndex = 128;
			this.cmb_OBS_Type_To.TextChanged += new System.EventHandler(this.cmb_OBS_Type_To_TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(10, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 127;
			this.label1.Text = "OBS ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label2.Font = new System.Drawing.Font("Verdana", 8F);
			this.label2.ImageIndex = 1;
			this.label2.ImageList = this.img_Label;
			this.label2.Location = new System.Drawing.Point(10, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 124;
			this.label2.Text = "Factory";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory_To
			// 
			this.cmb_Factory_To.AddItemCols = 0;
			this.cmb_Factory_To.AddItemSeparator = ';';
			this.cmb_Factory_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Factory_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_To.Caption = "";
			this.cmb_Factory_To.CaptionHeight = 17;
			this.cmb_Factory_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_To.ColumnCaptionHeight = 18;
			this.cmb_Factory_To.ColumnFooterHeight = 18;
			this.cmb_Factory_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_To.ContentHeight = 15;
			this.cmb_Factory_To.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_To.EditorBackColor = System.Drawing.Color.White;
			this.cmb_Factory_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_To.EditorHeight = 15;
			this.cmb_Factory_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory_To.GapHeight = 2;
			this.cmb_Factory_To.ItemHeight = 15;
			this.cmb_Factory_To.Location = new System.Drawing.Point(111, 32);
			this.cmb_Factory_To.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_To.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_To.MaxLength = 32767;
			this.cmb_Factory_To.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_To.Name = "cmb_Factory_To";
			this.cmb_Factory_To.PartialRightColumn = false;
			this.cmb_Factory_To.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
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
			this.cmb_Factory_To.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_To.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory_To.TabIndex = 126;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(10, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 125;
			this.label3.Text = "OBS Type";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(308, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(22, 32);
			this.pictureBox7.TabIndex = 1;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(168, -1);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(146, 32);
			this.pictureBox10.TabIndex = 2;
			this.pictureBox10.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle2.TabIndex = 0;
			this.lbl_SubTitle2.Text = "      Target Info.";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(311, 32);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(19, 58);
			this.pictureBox11.TabIndex = 5;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.Color.Blue;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(240, 90);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(90, 14);
			this.pictureBox12.TabIndex = 8;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(0, 24);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(32, 69);
			this.pictureBox13.TabIndex = 3;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.Color.Blue;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 90);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(80, 14);
			this.pictureBox14.TabIndex = 6;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.Color.Blue;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(72, 90);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(242, 14);
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
			this.pictureBox16.Size = new System.Drawing.Size(282, 72);
			this.pictureBox16.TabIndex = 4;
			this.pictureBox16.TabStop = false;
			// 
			// btn_Apply
			// 
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(184, 300);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 240;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(256, 300);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 239;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_OBS_Seq_Nu
			// 
			this.lbl_OBS_Seq_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Seq_Nu.ImageIndex = 2;
			this.lbl_OBS_Seq_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Seq_Nu.Location = new System.Drawing.Point(10, 141);
			this.lbl_OBS_Seq_Nu.Name = "lbl_OBS_Seq_Nu";
			this.lbl_OBS_Seq_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Seq_Nu.TabIndex = 132;
			this.lbl_OBS_Seq_Nu.Text = "OBS Seq Nu";
			this.lbl_OBS_Seq_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style.ImageIndex = 2;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 97);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 130;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OBS_Nu
			// 
			this.lbl_OBS_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Nu.ImageIndex = 2;
			this.lbl_OBS_Nu.ImageList = this.img_Label;
			this.lbl_OBS_Nu.Location = new System.Drawing.Point(10, 119);
			this.lbl_OBS_Nu.Name = "lbl_OBS_Nu";
			this.lbl_OBS_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Nu.TabIndex = 131;
			this.lbl_OBS_Nu.Text = "OBS Nu";
			this.lbl_OBS_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_OBS_Nu
			// 
			this.txt_OBS_Nu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Nu.Enabled = false;
			this.txt_OBS_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Nu.Location = new System.Drawing.Point(112, 119);
			this.txt_OBS_Nu.MaxLength = 10;
			this.txt_OBS_Nu.Name = "txt_OBS_Nu";
			this.txt_OBS_Nu.Size = new System.Drawing.Size(208, 20);
			this.txt_OBS_Nu.TabIndex = 225;
			this.txt_OBS_Nu.Text = "";
			// 
			// txt_OBS_Seq_Nu
			// 
			this.txt_OBS_Seq_Nu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OBS_Seq_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OBS_Seq_Nu.Enabled = false;
			this.txt_OBS_Seq_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_OBS_Seq_Nu.Location = new System.Drawing.Point(112, 141);
			this.txt_OBS_Seq_Nu.MaxLength = 10;
			this.txt_OBS_Seq_Nu.Name = "txt_OBS_Seq_Nu";
			this.txt_OBS_Seq_Nu.ReadOnly = true;
			this.txt_OBS_Seq_Nu.Size = new System.Drawing.Size(208, 20);
			this.txt_OBS_Seq_Nu.TabIndex = 224;
			this.txt_OBS_Seq_Nu.Text = "";
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Enabled = false;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Style.Location = new System.Drawing.Point(112, 97);
			this.txt_Style.MaxLength = 6;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.Size = new System.Drawing.Size(208, 20);
			this.txt_Style.TabIndex = 223;
			this.txt_Style.Text = "";
			// 
			// txt_Chg_Nu
			// 
			this.txt_Chg_Nu.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Chg_Nu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Chg_Nu.Enabled = false;
			this.txt_Chg_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Chg_Nu.Location = new System.Drawing.Point(113, 163);
			this.txt_Chg_Nu.MaxLength = 10;
			this.txt_Chg_Nu.Name = "txt_Chg_Nu";
			this.txt_Chg_Nu.ReadOnly = true;
			this.txt_Chg_Nu.Size = new System.Drawing.Size(208, 20);
			this.txt_Chg_Nu.TabIndex = 227;
			this.txt_Chg_Nu.Text = "";
			// 
			// lbl_Chg_Nu
			// 
			this.lbl_Chg_Nu.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Chg_Nu.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Chg_Nu.ImageIndex = 2;
			this.lbl_Chg_Nu.ImageList = this.img_Label;
			this.lbl_Chg_Nu.Location = new System.Drawing.Point(9, 163);
			this.lbl_Chg_Nu.Name = "lbl_Chg_Nu";
			this.lbl_Chg_Nu.Size = new System.Drawing.Size(100, 21);
			this.lbl_Chg_Nu.TabIndex = 226;
			this.lbl_Chg_Nu.Text = "Change Nu";
			this.lbl_Chg_Nu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// POP_EO_Type_Change
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(330, 328);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Search1_Image);
			this.Name = "POP_EO_Type_Change";
			this.Load += new System.EventHandler(this.POP_EO_Type_Change_Load);
			this.Controls.SetChildIndex(this.pnl_Search1_Image, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_Type_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_To)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{ 
			//Title
			this.Text = "Order Type/ID Change";
			lbl_SubTitle1.Text  ="Original Info";
			lbl_SubTitle2.Text  ="Target Info";
			ClassLib.ComFunction.SetLangDic(this);

			DataTable dt_list;
		
			// 콤보박스 설정
			///Factory
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory_From,0,1,false,0);
			cmb_Factory_From.SelectedValue = ClassLib.ComVar.This_Factory;
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory_To,0,1,false,0);
			cmb_Factory_To.SelectedValue = ClassLib.ComVar.This_Factory;

			///OBS_Type
			dt_list = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOBS_Type);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type_From, 1, 2, false);  				
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_OBS_Type_To, 1, 2, false);  
			
			
			cmb_Factory_From.Enabled   = false;
			cmb_OBS_Type_From.Enabled  = false;
			cmb_OBS_ID_From.Enabled    = false;

			cmb_Factory_To.Enabled     = false;
			cmb_OBS_Type_To.Enabled    = true;
			cmb_OBS_ID_To.Enabled      = true;


			cmb_Factory_From.SelectedValue     = COM.ComVar.Parameter_PopUp[0];
			cmb_OBS_Type_From.SelectedValue    = COM.ComVar.Parameter_PopUp[2];
			cmb_OBS_ID_From.Text               = COM.ComVar.Parameter_PopUp[1]; 
		    txt_Style.Text					   = COM.ComVar.Parameter_PopUp[3] +  "  /  " +  COM.ComVar.Parameter_PopUp[6];
			txt_OBS_Nu.Text                    = COM.ComVar.Parameter_PopUp[4];
			txt_OBS_Seq_Nu.Text				   = COM.ComVar.Parameter_PopUp[5];
			txt_Chg_Nu.Text                    = COM.ComVar.Parameter_PopUp[6];
			
			
		}

		#endregion

				
		#region DB컨트롤


		/// <summary>
		/// Save_OBS_Type : Request 리스트 저장
		/// </summary>
		/// <param name="arg_para_count">파라미터 개수</param>
		/// <param name="arg_proc_name">프로세스 이름</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		public DataSet Save_OBS_Type()
		{

//			DataSet ret;
//									    
//			int  intParm =9 ;
//			MyOraDB.ReDim_Parameter(intParm); 
//
//			//Package Name
//			MyOraDB.Process_Name=  "PKG_SEM_OBS.UPDATE_SEM_OBS_TYPE";
//			
//			//Parameter Name
//			int i =0;
//			MyOraDB.Parameter_Name[i++] = "ARG_OLD_FACTORY";
//			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_ID";
//			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_TYPE";
//			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_NU";
//			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_SEQ_NU";
//			MyOraDB.Parameter_Name[i++] = "ARG_NEW_OBS_ID";
//			MyOraDB.Parameter_Name[i++] = "ARG_NEW_OBS_TYPE";
//			MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";
//			MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";
//
//
//			//Parameter Type
//			for (i =0 ; i< intParm-1; i++)
//				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
//			MyOraDB.Parameter_Type[intParm-1] = (int)OracleType.Cursor;
//
//			//Parameter Value
//			 i =0;
//			MyOraDB.Parameter_Values[i++] = cmb_Factory_From.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[i++] = cmb_OBS_ID_From.Text;
//			MyOraDB.Parameter_Values[i++] = cmb_OBS_Type_From.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[i++] = txt_OBS_Nu.Text;
//			MyOraDB.Parameter_Values[i++] = txt_OBS_Seq_Nu.Text;
//			MyOraDB.Parameter_Values[i++] = cmb_OBS_ID_To.Text;
//			MyOraDB.Parameter_Values[i++] = cmb_OBS_Type_To.SelectedValue.ToString();
//			MyOraDB.Parameter_Values[i++] = ClassLib.ComVar.This_User;                                        
//			MyOraDB.Parameter_Values[i++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");  
//
//
//			MyOraDB.Add_Modify_Parameter(true);	
//			ret =  MyOraDB.Exe_Modify_Procedure();	
//		    



			DataSet ds_ret;

            int intParm  = 11;
			MyOraDB.ReDim_Parameter(intParm);  

			MyOraDB.Process_Name = "PKG_SEM_OBS.UPDATE_SEM_OBS_TYPE";
  
			//Parameter Name
			int i =0;
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_FACTORY";
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_ID";
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_TYPE";
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_NU";
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[i++] = "ARG_OLD_CHG_NU";
			MyOraDB.Parameter_Name[i++] = "ARG_NEW_OBS_ID";
			MyOraDB.Parameter_Name[i++] = "ARG_NEW_OBS_TYPE";
			MyOraDB.Parameter_Name[i++] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[i++] = "ARG_UPD_YMD";
			MyOraDB.Parameter_Name[i++]  = "OUT_CURSOR";


			//Parameter Type
			for (i =0 ; i< intParm-1; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[intParm-1]  = (int)OracleType.Cursor;
			

			//Parameter Value
				i =0;
			MyOraDB.Parameter_Values[i++] = cmb_Factory_From.SelectedValue.ToString();
			MyOraDB.Parameter_Values[i++] = cmb_OBS_ID_From.Text;
			MyOraDB.Parameter_Values[i++] = cmb_OBS_Type_From.SelectedValue.ToString();
			MyOraDB.Parameter_Values[i++] = txt_OBS_Nu.Text;
			MyOraDB.Parameter_Values[i++] = txt_OBS_Seq_Nu.Text;
		    MyOraDB.Parameter_Values[i++] = txt_Chg_Nu.Text;
			MyOraDB.Parameter_Values[i++] = cmb_OBS_ID_To.Text;
			MyOraDB.Parameter_Values[i++] = cmb_OBS_Type_To.SelectedValue.ToString();
			MyOraDB.Parameter_Values[i++] = ClassLib.ComVar.This_User;                                        
			MyOraDB.Parameter_Values[i++] = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); 
			MyOraDB.Parameter_Values[i++] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();


			
			return ds_ret;

		

		}
		#endregion
				
		#region 이벤트처리

		private void cmb_OBS_Type_To_TextChanged(object sender, System.EventArgs e)
		{
			
			cmb_OBS_ID_To.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type_To.SelectedValue.ToString(), cmb_OBS_ID_To);  

		}

		private void cmb_OBS_Type_From_TextChanged(object sender, System.EventArgs e)
		{
			cmb_OBS_ID_From.ClearItems();
			ClassLib.ComFunction.Set_OBSID_CmbList(cmb_OBS_Type_From.SelectedValue.ToString(), cmb_OBS_ID_From );  


		

		}

		
		private void btn_Apply_Click(object sender, System.EventArgs e)
		{

			
			try
			{
				if( (cmb_OBS_ID_To.SelectedIndex  == -1)||(cmb_OBS_Type_To.SelectedIndex  == -1))
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput,this);
					return;
				}

				DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(DialogResult.Yes != dr) return;


				DataSet  ds_ret = Save_OBS_Type();

				if ((ds_ret == null) || (Convert.ToString(ds_ret.Tables[0].Rows[0].ItemArray[0]) ==ClassLib.ComVar.ConsReal_N))
					ClassLib.ComFunction.User_Message("Production request already..You can't change information","Caution");
				else
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave,this);


			}
			catch 
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave,this);
			}
		}


		
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		#endregion

		private void POP_EO_Type_Change_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

