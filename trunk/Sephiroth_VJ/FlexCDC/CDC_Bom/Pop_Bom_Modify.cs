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
	public class Pop_Bom_Modify : COM.PCHWinForm.Pop_Large_B
	{
		#region 컨트롤 정의 및 리소스 정의 
		public System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox6;
		public System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.Label lbl_srf_info;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.Label lbl_SrfNo;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_SrfNo;
		private System.Windows.Forms.Label lbl_SrNo;
		private System.Windows.Forms.TextBox txt_SrNo;
		private System.Windows.Forms.Label lbl_SampleType;
		private System.Windows.Forms.TabControl tab_control;
		private System.Windows.Forms.TabPage Bom_Info;
		private System.Windows.Forms.TabPage Bom_Mat;
		private System.Windows.Forms.TabPage Order_Sheet;
		private COM.FSP fgrid_order;
		private COM.FSP fgrid_bom_mat;
		private COM.FSP fgrid_bom_info;
		private C1.Win.C1List.C1Combo cmb_sampletypes;
		private System.ComponentModel.IContainer components = null;

		public Pop_Bom_Modify()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Bom_Modify));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_SrfNo = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.lbl_srf_info = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.txt_SrfNo = new System.Windows.Forms.TextBox();
			this.lbl_SrNo = new System.Windows.Forms.Label();
			this.txt_SrNo = new System.Windows.Forms.TextBox();
			this.lbl_SampleType = new System.Windows.Forms.Label();
			this.tab_control = new System.Windows.Forms.TabControl();
			this.Bom_Info = new System.Windows.Forms.TabPage();
			this.Bom_Mat = new System.Windows.Forms.TabPage();
			this.Order_Sheet = new System.Windows.Forms.TabPage();
			this.fgrid_order = new COM.FSP();
			this.fgrid_bom_mat = new COM.FSP();
			this.fgrid_bom_info = new COM.FSP();
			this.cmb_sampletypes = new C1.Win.C1List.C1Combo();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.panel3.SuspendLayout();
			this.tab_control.SuspendLayout();
			this.Bom_Info.SuspendLayout();
			this.Bom_Mat.SuspendLayout();
			this.Order_Sheet.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_bom_mat)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_bom_info)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).BeginInit();
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
			this.c1ToolBar1.Location = new System.Drawing.Point(665, 4);
			this.c1ToolBar1.Name = "c1ToolBar1";
			// 
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(888, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.lbl_SampleType);
			this.panel2.Controls.Add(this.txt_SrNo);
			this.panel2.Controls.Add(this.lbl_SrNo);
			this.panel2.Controls.Add(this.txt_SrfNo);
			this.panel2.Controls.Add(this.lbl_SrfNo);
			this.panel2.Controls.Add(this.cmb_Factory);
			this.panel2.Controls.Add(this.lbl_Factory);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.textBox3);
			this.panel2.Controls.Add(this.textBox4);
			this.panel2.Controls.Add(this.textBox5);
			this.panel2.Controls.Add(this.textBox6);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.DockPadding.Bottom = 8;
			this.panel2.DockPadding.Left = 8;
			this.panel2.DockPadding.Right = 8;
			this.panel2.Location = new System.Drawing.Point(0, 85);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(960, 80);
			this.panel2.TabIndex = 136;
			// 
			// lbl_SrfNo
			// 
			this.lbl_SrfNo.ImageIndex = 0;
			this.lbl_SrfNo.ImageList = this.img_Label;
			this.lbl_SrfNo.Location = new System.Drawing.Point(248, 36);
			this.lbl_SrfNo.Name = "lbl_SrfNo";
			this.lbl_SrfNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_SrfNo.TabIndex = 303;
			this.lbl_SrfNo.Text = "SRF No";
			this.lbl_SrfNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.TabIndex = 272;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(16, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 271;
			this.lbl_Factory.Tag = "0";
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.Black;
			this.textBox1.Location = new System.Drawing.Point(768, 304);
			this.textBox1.MaxLength = 100;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(150, 21);
			this.textBox1.TabIndex = 270;
			this.textBox1.Tag = "60";
			this.textBox1.Text = "";
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox2.ForeColor = System.Drawing.Color.Black;
			this.textBox2.Location = new System.Drawing.Point(560, 304);
			this.textBox2.MaxLength = 100;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(150, 21);
			this.textBox2.TabIndex = 268;
			this.textBox2.Tag = "60";
			this.textBox2.Text = "";
			// 
			// textBox3
			// 
			this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox3.ForeColor = System.Drawing.Color.Black;
			this.textBox3.Location = new System.Drawing.Point(384, 328);
			this.textBox3.MaxLength = 100;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(416, 21);
			this.textBox3.TabIndex = 267;
			this.textBox3.Tag = "60";
			this.textBox3.Text = "";
			// 
			// textBox4
			// 
			this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox4.ForeColor = System.Drawing.Color.Black;
			this.textBox4.Location = new System.Drawing.Point(376, 304);
			this.textBox4.MaxLength = 100;
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(150, 21);
			this.textBox4.TabIndex = 264;
			this.textBox4.Tag = "60";
			this.textBox4.Text = "";
			// 
			// textBox5
			// 
			this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox5.ForeColor = System.Drawing.Color.Black;
			this.textBox5.Location = new System.Drawing.Point(200, 304);
			this.textBox5.MaxLength = 100;
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(150, 21);
			this.textBox5.TabIndex = 263;
			this.textBox5.Tag = "60";
			this.textBox5.Text = "";
			// 
			// textBox6
			// 
			this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.ForeColor = System.Drawing.Color.Black;
			this.textBox6.Location = new System.Drawing.Point(24, 304);
			this.textBox6.MaxLength = 100;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(150, 21);
			this.textBox6.TabIndex = 262;
			this.textBox6.Tag = "60";
			this.textBox6.Text = "";
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.cmb_sampletypes);
			this.panel3.Controls.Add(this.pictureBox11);
			this.panel3.Controls.Add(this.lbl_srf_info);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.pictureBox1);
			this.panel3.Controls.Add(this.pictureBox10);
			this.panel3.Controls.Add(this.pictureBox12);
			this.panel3.Controls.Add(this.pictureBox13);
			this.panel3.Controls.Add(this.pictureBox14);
			this.panel3.Controls.Add(this.pictureBox15);
			this.panel3.Controls.Add(this.pictureBox16);
			this.panel3.Controls.Add(this.pictureBox17);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.DockPadding.Right = 8;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(8, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(944, 72);
			this.panel3.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Window;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(426, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 21);
			this.label1.TabIndex = 112;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(919, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 29);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(920, 0);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(16, 32);
			this.pictureBox10.TabIndex = 21;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(224, 0);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(696, 40);
			this.pictureBox11.TabIndex = 0;
			this.pictureBox11.TabStop = false;
			// 
			// lbl_srf_info
			// 
			this.lbl_srf_info.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_srf_info.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_srf_info.ForeColor = System.Drawing.Color.Navy;
			this.lbl_srf_info.Image = ((System.Drawing.Image)(resources.GetObject("lbl_srf_info.Image")));
			this.lbl_srf_info.Location = new System.Drawing.Point(0, 0);
			this.lbl_srf_info.Name = "lbl_srf_info";
			this.lbl_srf_info.Size = new System.Drawing.Size(231, 30);
			this.lbl_srf_info.TabIndex = 28;
			this.lbl_srf_info.Text = "      BOM Information";
			this.lbl_srf_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(920, 57);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 16);
			this.pictureBox12.TabIndex = 23;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(144, 56);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(780, 18);
			this.pictureBox13.TabIndex = 24;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(0, 57);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(168, 20);
			this.pictureBox14.TabIndex = 22;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(0, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(168, 39);
			this.pictureBox15.TabIndex = 25;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(152, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(780, 32);
			this.pictureBox16.TabIndex = 27;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(472, 72);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(936, 32);
			this.pictureBox17.TabIndex = 27;
			this.pictureBox17.TabStop = false;
			// 
			// txt_SrfNo
			// 
			this.txt_SrfNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SrfNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SrfNo.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_SrfNo.ForeColor = System.Drawing.Color.Black;
			this.txt_SrfNo.Location = new System.Drawing.Point(349, 36);
			this.txt_SrfNo.MaxLength = 100;
			this.txt_SrfNo.Name = "txt_SrfNo";
			this.txt_SrfNo.ReadOnly = true;
			this.txt_SrfNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SrfNo.Size = new System.Drawing.Size(120, 20);
			this.txt_SrfNo.TabIndex = 306;
			this.txt_SrfNo.Text = "";
			this.txt_SrfNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_SrNo
			// 
			this.lbl_SrNo.ImageIndex = 0;
			this.lbl_SrNo.ImageList = this.img_Label;
			this.lbl_SrNo.Location = new System.Drawing.Point(480, 36);
			this.lbl_SrNo.Name = "lbl_SrNo";
			this.lbl_SrNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_SrNo.TabIndex = 307;
			this.lbl_SrNo.Text = "SR No";
			this.lbl_SrNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_SrNo
			// 
			this.txt_SrNo.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_SrNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SrNo.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_SrNo.ForeColor = System.Drawing.Color.Black;
			this.txt_SrNo.Location = new System.Drawing.Point(581, 36);
			this.txt_SrNo.MaxLength = 100;
			this.txt_SrNo.Name = "txt_SrNo";
			this.txt_SrNo.ReadOnly = true;
			this.txt_SrNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SrNo.Size = new System.Drawing.Size(120, 20);
			this.txt_SrNo.TabIndex = 308;
			this.txt_SrNo.Text = "";
			this.txt_SrNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbl_SampleType
			// 
			this.lbl_SampleType.ImageIndex = 0;
			this.lbl_SampleType.ImageList = this.img_Label;
			this.lbl_SampleType.Location = new System.Drawing.Point(712, 36);
			this.lbl_SampleType.Name = "lbl_SampleType";
			this.lbl_SampleType.Size = new System.Drawing.Size(100, 21);
			this.lbl_SampleType.TabIndex = 309;
			this.lbl_SampleType.Text = "Sample Type";
			this.lbl_SampleType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tab_control
			// 
			this.tab_control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tab_control.Controls.Add(this.Bom_Info);
			this.tab_control.Controls.Add(this.Bom_Mat);
			this.tab_control.Controls.Add(this.Order_Sheet);
			this.tab_control.Location = new System.Drawing.Point(0, 165);
			this.tab_control.Name = "tab_control";
			this.tab_control.SelectedIndex = 0;
			this.tab_control.Size = new System.Drawing.Size(952, 401);
			this.tab_control.TabIndex = 310;
			// 
			// Bom_Info
			// 
			this.Bom_Info.BackColor = System.Drawing.Color.Transparent;
			this.Bom_Info.Controls.Add(this.fgrid_bom_info);
			this.Bom_Info.Location = new System.Drawing.Point(4, 21);
			this.Bom_Info.Name = "Bom_Info";
			this.Bom_Info.Size = new System.Drawing.Size(944, 376);
			this.Bom_Info.TabIndex = 0;
			this.Bom_Info.Text = "Bom Information";
			// 
			// Bom_Mat
			// 
			this.Bom_Mat.Controls.Add(this.fgrid_bom_mat);
			this.Bom_Mat.Location = new System.Drawing.Point(4, 21);
			this.Bom_Mat.Name = "Bom_Mat";
			this.Bom_Mat.Size = new System.Drawing.Size(784, 253);
			this.Bom_Mat.TabIndex = 2;
			this.Bom_Mat.Text = "Bom Material";
			this.Bom_Mat.Visible = false;
			// 
			// Order_Sheet
			// 
			this.Order_Sheet.BackColor = System.Drawing.Color.Transparent;
			this.Order_Sheet.Controls.Add(this.fgrid_order);
			this.Order_Sheet.Location = new System.Drawing.Point(4, 21);
			this.Order_Sheet.Name = "Order_Sheet";
			this.Order_Sheet.Size = new System.Drawing.Size(784, 253);
			this.Order_Sheet.TabIndex = 1;
			this.Order_Sheet.Text = "Order Sheet";
			this.Order_Sheet.Visible = false;
			// 
			// fgrid_order
			// 
			this.fgrid_order.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_order.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_order.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_order.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_order.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_order.Location = new System.Drawing.Point(0, 0);
			this.fgrid_order.Name = "fgrid_order";
			this.fgrid_order.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_order.Size = new System.Drawing.Size(784, 253);
			this.fgrid_order.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_order.TabIndex = 104;
			// 
			// fgrid_bom_mat
			// 
			this.fgrid_bom_mat.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_bom_mat.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_bom_mat.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_bom_mat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_bom_mat.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_bom_mat.Location = new System.Drawing.Point(0, 0);
			this.fgrid_bom_mat.Name = "fgrid_bom_mat";
			this.fgrid_bom_mat.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_bom_mat.Size = new System.Drawing.Size(784, 253);
			this.fgrid_bom_mat.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_bom_mat.TabIndex = 105;
			// 
			// fgrid_bom_info
			// 
			this.fgrid_bom_info.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_bom_info.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_bom_info.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_bom_info.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_bom_info.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_bom_info.Location = new System.Drawing.Point(0, 0);
			this.fgrid_bom_info.Name = "fgrid_bom_info";
			this.fgrid_bom_info.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_bom_info.Size = new System.Drawing.Size(944, 376);
			this.fgrid_bom_info.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_bom_info.TabIndex = 105;
			// 
			// cmb_sampletypes
			// 
			this.cmb_sampletypes.AddItemCols = 0;
			this.cmb_sampletypes.AddItemSeparator = ';';
			this.cmb_sampletypes.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_sampletypes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_sampletypes.Caption = "";
			this.cmb_sampletypes.CaptionHeight = 17;
			this.cmb_sampletypes.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_sampletypes.ColumnCaptionHeight = 18;
			this.cmb_sampletypes.ColumnFooterHeight = 18;
			this.cmb_sampletypes.ContentHeight = 17;
			this.cmb_sampletypes.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_sampletypes.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_sampletypes.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sampletypes.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_sampletypes.EditorHeight = 17;
			this.cmb_sampletypes.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sampletypes.GapHeight = 2;
			this.cmb_sampletypes.ItemHeight = 15;
			this.cmb_sampletypes.Location = new System.Drawing.Point(805, 36);
			this.cmb_sampletypes.MatchEntryTimeout = ((long)(2000));
			this.cmb_sampletypes.MaxDropDownItems = ((short)(5));
			this.cmb_sampletypes.MaxLength = 32767;
			this.cmb_sampletypes.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_sampletypes.Name = "cmb_sampletypes";
			this.cmb_sampletypes.PartialRightColumn = false;
			this.cmb_sampletypes.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_sampletypes.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_sampletypes.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_sampletypes.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_sampletypes.Size = new System.Drawing.Size(120, 21);
			this.cmb_sampletypes.TabIndex = 348;
			// 
			// Pop_Bom_Modify
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(952, 566);
			this.Controls.Add(this.tab_control);
			this.Controls.Add(this.panel2);
			this.Name = "Pop_Bom_Modify";
			this.Load += new System.EventHandler(this.Pop_Bom_Modify_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.tab_control, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.panel3.ResumeLayout(false);
			this.tab_control.ResumeLayout(false);
			this.Bom_Info.ResumeLayout(false);
			this.Bom_Mat.ResumeLayout(false);
			this.Order_Sheet.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_order)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_bom_mat)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_bom_info)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sampletypes)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
		public string _factory;
		public string _srf_no;
		public string _sr_no;
		public string _sampletype;
		public string _part_no;
		#endregion

		#region 공통메서드
		private void Init_Form()
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                this.Text = "Modify Bom";
                this.lbl_MainTitle.Text = "Modify Bom";
                ClassLib.ComFunction.SetLangDic(this);

                #region ComboBox Setting
                //factory 
                DataTable dt_ret = COM.ComFunction.Select_Factory_List_CDC();
                COM.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
                cmb_Factory.SelectedValue = _factory;

                dt_ret = Select_sdc_nf_desc();
                ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_sampletypes, 0, 2, false, false);
                cmb_sampletypes.SelectedValue = _sampletype;
                cmb_sampletypes.Enabled = false;

                dt_ret.Dispose();
                #endregion

                #region TextBox Setting
                txt_SrfNo.Text = _srf_no;
                txt_SrNo.Text = _sr_no;
                #endregion

                #region Grid Setting
                fgrid_bom_info.Set_Grid_CDC("SXD_SRF_HEAD", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_bom_info.Set_Action_Image(img_Action);
                fgrid_bom_info.Font = new Font("Verdana", 8);
                fgrid_bom_info.Rows.Count = fgrid_bom_info.Rows.Fixed;

                fgrid_bom_mat.Set_Grid_CDC("SXD_SRF_TAIL", "5", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_bom_mat.Set_Action_Image(img_Action);
                fgrid_bom_mat.Font = new Font("Verdana", 8);
                fgrid_bom_mat.Rows.Count = fgrid_bom_mat.Rows.Fixed;
                fgrid_bom_mat.Styles.Normal.WordWrap = true;
                fgrid_bom_mat.Tree.Column = (int)ClassLib.TBSXD_SRF_TAIL_MODIFY.IxSRF_SEQ;

                fgrid_order.Set_Grid_CDC("SXD_SRF_ORDER", "3", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_order.Set_Action_Image(img_Action);
                fgrid_order.Font = new Font("Verdana", 8);
                fgrid_order.Rows.Count = fgrid_order.Rows.Fixed;
                fgrid_order.Styles.Normal.WordWrap = true;
                fgrid_order.Tree.Column = (int)ClassLib.TBSXD_SRF_ORDER.IxSRF_SEQ;


                #endregion

                Display_Data();
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


		private void Display_Data()
		{
			DataTable dt_list;
			#region Bom Information
			dt_list = Select_Sdd_Srf_Head();
			
			int dt_rows = dt_list.Rows.Count;
			fgrid_bom_info.Rows.Count  = fgrid_bom_info.Rows.Fixed;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_bom_info.AddItem(dt_list.Rows[i].ItemArray, fgrid_bom_info.Rows.Count, 0);	
			}

			#endregion

			#region Bom Material
			dt_list = Select_Sdd_Srf_Tail();

			dt_rows = dt_list.Rows.Count;
			int dt_cols = dt_list.Columns.Count;

			fgrid_bom_mat.Rows.Count  = fgrid_bom_mat.Rows.Fixed;
			for(int i=0; i<dt_rows; i++)
			{
				int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_TAIL_MODIFY.IxSRF_LEVEL].ToString());
				fgrid_bom_mat.Rows.InsertNode(fgrid_bom_mat.Rows.Count, tree_level);				
				
				for(int j=0; j<dt_cols; j++)
				{
					fgrid_bom_mat[fgrid_bom_mat.Rows.Count-1, j] = dt_list.Rows[i].ItemArray[j].ToString();

					if(j==(int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL)
					{
						if(!dt_list.Rows[i].ItemArray[j].Equals("1"))
						{
							fgrid_bom_mat.Rows[fgrid_bom_mat.Rows.Count-1].AllowEditing = false;
						}
					}
				}
			}
			fgrid_bom_mat.Tree.Show(1);

			#endregion

			#region Order Sheet
			dt_list = Select_Sdd_Srf_Order();

			dt_rows = dt_list.Rows.Count;
			dt_cols = dt_list.Columns.Count;
			fgrid_order.Rows.Count = fgrid_order.Rows.Fixed;


			for(int i=0; i<dt_rows; i++)
			{
				int tree_level = int.Parse(dt_list.Rows[i].ItemArray[(int)ClassLib.TBSXD_SRF_ORDER_MODIFY.IxSRF_LEVEL].ToString());
				fgrid_order.Rows.InsertNode(fgrid_order.Rows.Count, tree_level);

				for(int j=0; j<dt_cols; j++)
				{
					fgrid_order[fgrid_order.Rows.Count-1, j] = dt_list.Rows[i].ItemArray[j].ToString();

					if(j == (int)ClassLib.TBSXD_SRF_ORDER_MODIFY.IxSRF_LEVEL)
					{
						
						if(!dt_list.Rows[i].ItemArray[j].Equals("1"))
						{
							fgrid_order.Rows[fgrid_order.Rows.Count-1].AllowEditing = false;
						}
					}
				}
			}
			fgrid_order.Tree.Show(1);			
			#endregion
		}

		#endregion

		#region 이벤트 처리
		#endregion

		#region DB Connect
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

		private DataTable Select_Sdd_Srf_Head()
		{
			MyOraDB.ReDim_Parameter(5);

			MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_HEAD_MODIFY" ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[3] = "ARG_NF_CD";			
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_SrfNo, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_SrNo, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_sampletypes, "");			
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Sdd_Srf_Tail()
		{
			MyOraDB.ReDim_Parameter(6);

			MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_TAIL_MODIFY" ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[3] = "ARG_NF_CD";
			MyOraDB.Parameter_Name[4] = "ARG_PART_NO";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_SrfNo, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_SrNo, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_sampletypes, "");
			MyOraDB.Parameter_Values[4] = _part_no;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}

		private DataTable Select_Sdd_Srf_Order()
		{
			MyOraDB.ReDim_Parameter(5);

			MyOraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXD_SRF_ORDER_MODIFY" ;

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SRF_NO";
			MyOraDB.Parameter_Name[2] = "ARG_SR_NO";
			MyOraDB.Parameter_Name[3] = "ARG_NF_CD";			
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_SrfNo, "");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_SrNo, "");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_sampletypes, "");			
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[MyOraDB.Process_Name];

		}

		#endregion

		private void Pop_Bom_Modify_Load(object sender, System.EventArgs e)
		{
			Init_Form();		
		}
	}
}

