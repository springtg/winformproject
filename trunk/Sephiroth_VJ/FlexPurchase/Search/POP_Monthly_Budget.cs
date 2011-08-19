using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;


namespace FlexPurchase.Search
{
	public class POP_Monthly_Budget : COM.OrderWinForm.Pop_Small
	{
		#region 컨트롤정의 및 리소스 정의 
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txt_Month;
		private System.Windows.Forms.Label lbl_Month;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.GroupBox gb_OA;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo c1Combo2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label lbl_Close;
		private System.Windows.Forms.Label lbl_Save;
		private System.Windows.Forms.MenuItem cmt_Delete_Row;
		private System.Windows.Forms.ContextMenu cmt_Menu;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.MenuItem cmt_Insert_Row;
		private System.ComponentModel.IContainer components = null;




		public POP_Monthly_Budget()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(POP_Monthly_Budget));
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbl_Month = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Month = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.gb_OA = new System.Windows.Forms.GroupBox();
			this.fgrid_Main = new COM.FSP();
			this.cmt_Menu = new System.Windows.Forms.ContextMenu();
			this.cmt_Delete_Row = new System.Windows.Forms.MenuItem();
			this.label3 = new System.Windows.Forms.Label();
			this.c1Combo2 = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.lbl_Close = new System.Windows.Forms.Label();
			this.lbl_Save = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.cmt_Insert_Row = new System.Windows.Forms.MenuItem();
			this.panel2.SuspendLayout();
			this.gb_OA.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).BeginInit();
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
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RosyBrown;
			this.panel2.Controls.Add(this.lbl_Month);
			this.panel2.Controls.Add(this.lbl_Factory);
			this.panel2.Controls.Add(this.txt_Month);
			this.panel2.Controls.Add(this.txt_Factory);
			this.panel2.Controls.Add(this.gb_OA);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.c1Combo2);
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.pictureBox7);
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.pictureBox10);
			this.panel2.Controls.Add(this.pictureBox11);
			this.panel2.Controls.Add(this.pictureBox12);
			this.panel2.Location = new System.Drawing.Point(5, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(392, 367);
			this.panel2.TabIndex = 52;
			// 
			// lbl_Month
			// 
			this.lbl_Month.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Month.ImageIndex = 1;
			this.lbl_Month.ImageList = this.img_Label;
			this.lbl_Month.Location = new System.Drawing.Point(8, 49);
			this.lbl_Month.Name = "lbl_Month";
			this.lbl_Month.Size = new System.Drawing.Size(98, 27);
			this.lbl_Month.TabIndex = 183;
			this.lbl_Month.Text = "Month";
			this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(8, 26);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(98, 27);
			this.lbl_Factory.TabIndex = 175;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Month
			// 
			this.txt_Month.BackColor = System.Drawing.Color.White;
			this.txt_Month.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Month.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Month.Location = new System.Drawing.Point(108, 53);
			this.txt_Month.MaxLength = 100;
			this.txt_Month.Name = "txt_Month";
			this.txt_Month.Size = new System.Drawing.Size(120, 20);
			this.txt_Month.TabIndex = 184;
			this.txt_Month.Text = "";
			this.txt_Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Month_KeyPress);
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.LightYellow;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Factory.Location = new System.Drawing.Point(108, 30);
			this.txt_Factory.MaxLength = 100;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(120, 20);
			this.txt_Factory.TabIndex = 182;
			this.txt_Factory.Text = "";
			// 
			// gb_OA
			// 
			this.gb_OA.BackColor = System.Drawing.SystemColors.Window;
			this.gb_OA.Controls.Add(this.fgrid_Main);
			this.gb_OA.Location = new System.Drawing.Point(8, 72);
			this.gb_OA.Name = "gb_OA";
			this.gb_OA.Size = new System.Drawing.Size(376, 296);
			this.gb_OA.TabIndex = 174;
			this.gb_OA.TabStop = false;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ContextMenu = this.cmt_Menu;
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(3, 17);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(370, 276);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 57;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// cmt_Menu
			// 
			this.cmt_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.cmt_Delete_Row,
																					 this.cmt_Insert_Row});
			// 
			// cmt_Delete_Row
			// 
			this.cmt_Delete_Row.Index = 0;
			this.cmt_Delete_Row.Text = "Delete Row";
			this.cmt_Delete_Row.Click += new System.EventHandler(this.cmt_Delete_Row_Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 0;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(768, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 173;
			this.label3.Text = "Style Code";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.c1Combo2.EditorBackColor = System.Drawing.SystemColors.Window;
			this.c1Combo2.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.c1Combo2.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.c1Combo2.EditorHeight = 17;
			this.c1Combo2.Font = new System.Drawing.Font("Verdana", 8F);
			this.c1Combo2.GapHeight = 2;
			this.c1Combo2.ItemHeight = 15;
			this.c1Combo2.Location = new System.Drawing.Point(868, 29);
			this.c1Combo2.MatchEntryTimeout = ((long)(2000));
			this.c1Combo2.MaxDropDownItems = ((short)(5));
			this.c1Combo2.MaxLength = 32767;
			this.c1Combo2.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.c1Combo2.Name = "c1Combo2";
			this.c1Combo2.PartialRightColumn = false;
			this.c1Combo2.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.c1Combo2.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.c1Combo2.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.c1Combo2.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.c1Combo2.Size = new System.Drawing.Size(124, 21);
			this.c1Combo2.TabIndex = 172;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(370, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(208, 32);
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Highlight;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 30);
			this.label4.TabIndex = 0;
			this.label4.Text = "      Monthly Budget";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(373, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 344);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox7.BackColor = System.Drawing.Color.Blue;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(302, 362);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(90, 14);
			this.pictureBox7.TabIndex = 8;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(32, 344);
			this.pictureBox8.TabIndex = 3;
			this.pictureBox8.TabStop = false;
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
			this.pictureBox10.Size = new System.Drawing.Size(344, 344);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 362);
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
			this.pictureBox12.Location = new System.Drawing.Point(72, 362);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(304, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// lbl_Close
			// 
			this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Close.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Close.ImageIndex = 2;
			this.lbl_Close.ImageList = this.img_Label;
			this.lbl_Close.Location = new System.Drawing.Point(288, 384);
			this.lbl_Close.Name = "lbl_Close";
			this.lbl_Close.Size = new System.Drawing.Size(100, 21);
			this.lbl_Close.TabIndex = 183;
			this.lbl_Close.Text = "Close";
			this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Close.Click += new System.EventHandler(this.lbl_Close_Click);
			// 
			// lbl_Save
			// 
			this.lbl_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Save.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Save.ImageIndex = 2;
			this.lbl_Save.ImageList = this.img_Label;
			this.lbl_Save.Location = new System.Drawing.Point(8, 384);
			this.lbl_Save.Name = "lbl_Save";
			this.lbl_Save.Size = new System.Drawing.Size(100, 21);
			this.lbl_Save.TabIndex = 182;
			this.lbl_Save.Text = "Save";
			this.lbl_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_Save.Click += new System.EventHandler(this.lbl_Save_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// cmt_Insert_Row
			// 
			this.cmt_Insert_Row.Index = 1;
			this.cmt_Insert_Row.Text = "Insert Row";
			this.cmt_Insert_Row.Click += new System.EventHandler(this.cmt_Insert_Row_Click);
			// 
			// POP_Monthly_Budget
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(402, 416);
			this.Controls.Add(this.lbl_Close);
			this.Controls.Add(this.lbl_Save);
			this.Controls.Add(this.panel2);
			this.Name = "POP_Monthly_Budget";
			this.Load += new System.EventHandler(this.POP_Monthly_Budget_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.Controls.SetChildIndex(this.lbl_Save, 0);
			this.Controls.SetChildIndex(this.lbl_Close, 0);
			this.panel2.ResumeLayout(false);
			this.gb_OA.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Combo2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		#endregion 

		#region 공통 메쏘드 

		private void Init_Form()
		{


			//Setting  Title
			this.Text = "Monthly Budget";
			this.lbl_MainTitle.Text =  "Monthly Budget";
			ClassLib.ComFunction.SetLangDic(this);

			//Setting Grid(TBSEM_BUDGET)
			fgrid_Main.Set_Grid( "SEM_BUDGET", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Font = new Font("Verdana",8);
			//fgrid_Main.Set_Action_Image(img_Action); 

			txt_Factory.Text   = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Month.Text     =  ClassLib.ComVar.Parameter_PopUp[1].Substring(0,4);
			txt_Month.Enabled   = true;


			txt_Month_KeyPress(null,null);

		}

		#endregion 

		#region 이벤트 처리
	

		private void lbl_Save_Click(object sender, System.EventArgs e)
		{
			try
			{


				fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1);


				DialogResult vDr = MessageBox.Show("Do you want to save budget?", "Monthly Fob", MessageBoxButtons.YesNo);


				if ((fgrid_Main[fgrid_Main.Rows.Count -1, (int)ClassLib.TBSEM_BUDGET.lxBUDGET] ==null) ||
					(fgrid_Main[fgrid_Main.Rows.Count -1, (int)ClassLib.TBSEM_BUDGET.lxBUDGET_MONTH].ToString().Length < 6)) 
					fgrid_Main.Rows.Count  = fgrid_Main.Rows.Count  -1;
																														     
																														   
				if (vDr == DialogResult.Yes)
				{
					SAVE_SEM_BUDGET();
					fgrid_Main.Rows.Count  = fgrid_Main.Rows.Count  + 1; 
					fgrid_Main[fgrid_Main.Rows.Count-1,(int)ClassLib.TBSEM_BUDGET.lxFACTORY ] = txt_Factory.Text;
				}


				txt_Month_KeyPress(null,null);
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString(), "lbl_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error );

			}
		}


		private void lbl_Close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		

		private void txt_Month_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//if (e.KeyChar.ToString() != "13") return;
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;

			DataTable   vDt;
			vDt  =  SELECT_SEM_BUDGET(txt_Factory.Text, txt_Month.Text+ "01", txt_Month.Text+ "12") ;
			

			for( int i  =0 ;  i < vDt.Rows.Count  ;  i++)
			{

				fgrid_Main.AddItem(vDt.Rows[i].ItemArray, fgrid_Main.Rows.Count , 1);

			}

			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Count+1;
			fgrid_Main[fgrid_Main.Rows.Count-1,(int)ClassLib.TBSEM_BUDGET.lxFACTORY ]  =  txt_Factory.Text;
			//fgrid_Main[fgrid_Main.Rows.Count,(int)ClassLib.TBSEM_FOB.lxFOB_MONTH] =  " ";
		
		}




		private void cmt_Delete_Row_Click(object sender, System.EventArgs e)
		{
			fgrid_Main.RemoveItem(fgrid_Main.Selection.r1);
		}



		private void cmt_Insert_Row_Click(object sender, System.EventArgs e)
		{
			fgrid_Main.Rows.Count =  fgrid_Main.Rows.Count+1;
		}



		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Main.Select(fgrid_Main.Selection.r1, fgrid_Main.Selection.c1);
			
		}





		#endregion 

		#region  DB컨넥트

		/// <summary>
		/// SELECT_ORDER_ANALYSIS 
		/// </summary>
		public static  DataTable SELECT_SEM_BUDGET(string arg_factory, string arg_month_from , string arg_month_to )
		{
			DataSet ds_ret;

			COM.OraDB MyOraDB = new COM.OraDB(); 


			string process_name = "PKG_SEM_MNT.SELECT_SEM_BUDGET";

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_MONTH_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_MONTH_TO";
			MyOraDB.Parameter_Name[3]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = arg_factory ; 
			MyOraDB.Parameter_Values[1]  = arg_month_from;
			MyOraDB.Parameter_Values[2]  = arg_month_to ;
			MyOraDB.Parameter_Values[3]  = "";

	
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}

		private bool SAVE_SEM_BUDGET()
		{

			try
			{

				

				int vParm = 8 ;

				MyOraDB.ReDim_Parameter(vParm); 

				MyOraDB.Process_Name = "PKG_SEM_MNT.SAVE_SEM_BUDGET";

				for(int i = 0; i < vParm; i++)
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				
				MyOraDB.Parameter_Name[0]  = "ARG_FLAG";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_MONTH";  
				MyOraDB.Parameter_Name[3]  = "ARG_BUDGET"; 
				MyOraDB.Parameter_Name[4]  = "ARG_TARGET_QUANTITY"; 
				MyOraDB.Parameter_Name[5]  = "ARG_FOB"; 
				MyOraDB.Parameter_Name[6]  = "ARG_UPD_USER";  
				MyOraDB.Parameter_Name[7]  = "ARG_UPD_YMD";   
 

				int  vCount  =  0;
				for (int i = fgrid_Main.Rows.Fixed ;  i< fgrid_Main.Rows.Count ; i++) 
					vCount ++;

				MyOraDB.Parameter_Values  = new string[vParm* vCount ];



				int  vValue  =0;
				for (int i = fgrid_Main.Rows.Fixed ;  i< fgrid_Main.Rows.Count ; i++) 
				{
					
					MyOraDB.Parameter_Values[vValue++]  =  (vValue ==1)? "H":"T";
					MyOraDB.Parameter_Values[vValue++]  = fgrid_Main[i,(int)ClassLib.TBSEM_BUDGET.lxFACTORY].ToString().Trim();
					MyOraDB.Parameter_Values[vValue++]  = fgrid_Main[i,(int)ClassLib.TBSEM_BUDGET.lxBUDGET_MONTH].ToString().Trim();
					MyOraDB.Parameter_Values[vValue++]  = fgrid_Main[i,(int)ClassLib.TBSEM_BUDGET.lxBUDGET].ToString().Trim();
					MyOraDB.Parameter_Values[vValue++]  = fgrid_Main[i,(int)ClassLib.TBSEM_BUDGET.lxTARGET_QUANTITY].ToString().Trim();
					MyOraDB.Parameter_Values[vValue++]  = fgrid_Main[i,(int)ClassLib.TBSEM_BUDGET.lxFOB].ToString().Trim();
					MyOraDB.Parameter_Values[vValue++]  = ClassLib.ComVar.This_User;
					MyOraDB.Parameter_Values[vValue++]  = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

				}


				MyOraDB.Add_Modify_Parameter(true);										
				MyOraDB.Exe_Modify_Procedure();

				return true;
			}
			catch
			{
					              
				return false;
			}
		
		}
		

		#endregion 

		private void POP_Monthly_Budget_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}




	}
}

