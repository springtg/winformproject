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


namespace FlexOrder.ExpLoad
{
	public class Form_EL_ID_ORDER : COM.OrderWinForm.Form_Top
	{
		#region  컨트롤 정의 및 리소스 정리
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.Label btn_path;
		private System.Windows.Forms.TextBox txt_Path;
		private System.Windows.Forms.Label lbl_Factory;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ProgressBar pgb_process;
		
		private System.Windows.Forms.Label lbl_Load_Count;
		private System.Windows.Forms.Label lbl_Failure_Count;
		private System.Windows.Forms.Label lbl_Total_Count;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		
		private System.ComponentModel.IContainer components = null;

		
		public Form_EL_ID_ORDER()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EL_ID_ORDER));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.lbl_Load_Count = new System.Windows.Forms.Label();
			this.lbl_Failure_Count = new System.Windows.Forms.Label();
			this.lbl_Total_Count = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pgb_process = new System.Windows.Forms.ProgressBar();
			this.btn_path = new System.Windows.Forms.Label();
			this.txt_Path = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
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
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1016, 104);
			this.pnl_Search.TabIndex = 38;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.lbl_Load_Count);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Failure_Count);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Total_Count);
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.label2);
			this.pnl_Search1_Image.Controls.Add(this.label3);
			this.pnl_Search1_Image.Controls.Add(this.pgb_process);
			this.pnl_Search1_Image.Controls.Add(this.btn_path);
			this.pnl_Search1_Image.Controls.Add(this.txt_Path);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Factory);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox2);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.lbl_OBS_Type);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox4);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox6);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox9);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(1000, 88);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// lbl_Load_Count
			// 
			this.lbl_Load_Count.BackColor = System.Drawing.Color.White;
			this.lbl_Load_Count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Load_Count.ForeColor = System.Drawing.Color.Black;
			this.lbl_Load_Count.Location = new System.Drawing.Point(908, 59);
			this.lbl_Load_Count.Name = "lbl_Load_Count";
			this.lbl_Load_Count.Size = new System.Drawing.Size(64, 20);
			this.lbl_Load_Count.TabIndex = 116;
			this.lbl_Load_Count.Text = "0";
			this.lbl_Load_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_Failure_Count
			// 
			this.lbl_Failure_Count.BackColor = System.Drawing.Color.White;
			this.lbl_Failure_Count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Failure_Count.ForeColor = System.Drawing.Color.Red;
			this.lbl_Failure_Count.Location = new System.Drawing.Point(657, 59);
			this.lbl_Failure_Count.Name = "lbl_Failure_Count";
			this.lbl_Failure_Count.Size = new System.Drawing.Size(42, 20);
			this.lbl_Failure_Count.TabIndex = 115;
			this.lbl_Failure_Count.Text = "0";
			this.lbl_Failure_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbl_Total_Count
			// 
			this.lbl_Total_Count.BackColor = System.Drawing.Color.White;
			this.lbl_Total_Count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Total_Count.Location = new System.Drawing.Point(432, 59);
			this.lbl_Total_Count.Name = "lbl_Total_Count";
			this.lbl_Total_Count.Size = new System.Drawing.Size(48, 20);
			this.lbl_Total_Count.TabIndex = 114;
			this.lbl_Total_Count.Text = "0";
			this.lbl_Total_Count.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(794, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 119;
			this.label1.Text = "*Loading Count : ";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Red;
			this.label2.Location = new System.Drawing.Point(550, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 118;
			this.label2.Text = "*Failure Count : ";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(336, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 20);
			this.label3.TabIndex = 117;
			this.label3.Text = "*Total Count :";
			// 
			// pgb_process
			// 
			this.pgb_process.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pgb_process.Location = new System.Drawing.Point(336, 36);
			this.pgb_process.Name = "pgb_process";
			this.pgb_process.Size = new System.Drawing.Size(656, 20);
			this.pgb_process.TabIndex = 113;
			// 
			// btn_path
			// 
			this.btn_path.Image = ((System.Drawing.Image)(resources.GetObject("btn_path.Image")));
			this.btn_path.Location = new System.Drawing.Point(299, 58);
			this.btn_path.Name = "btn_path";
			this.btn_path.Size = new System.Drawing.Size(21, 21);
			this.btn_path.TabIndex = 111;
			this.btn_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
			// 
			// txt_Path
			// 
			this.txt_Path.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Path.Font = new System.Drawing.Font("Verdana", 8F);
			this.txt_Path.ForeColor = System.Drawing.Color.Black;
			this.txt_Path.Location = new System.Drawing.Point(111, 58);
			this.txt_Path.MaxLength = 100;
			this.txt_Path.Name = "txt_Path";
			this.txt_Path.ReadOnly = true;
			this.txt_Path.Size = new System.Drawing.Size(187, 20);
			this.txt_Path.TabIndex = 110;
			this.txt_Path.Text = "";
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 18;
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
			this.cmb_Factory.FetchRowStyles = true;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(111, 36);
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
				"8pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" FetchRowStyles=\"True\" VerticalScrollGroup=\"1\" Hor" +
				"izontalScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width" +
				">17</Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyl" +
				"e parent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><Fo" +
				"oterStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" " +
				"/><HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highli" +
				"ghtRow\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyl" +
				"e parent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=" +
				"\"Style10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal" +
				"\" me=\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=" +
				"\"\" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" m" +
				"e=\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"" +
				"Inactive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Hi" +
				"ghlightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"O" +
				"ddRow\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" m" +
				"e=\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><L" +
				"ayout>Modified</Layout><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 37;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(978, 0);
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
			this.pictureBox2.Size = new System.Drawing.Size(816, 32);
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
			this.lbl_SubTitle1.Text = "      ID Order.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(981, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 42);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(910, 74);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 1;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(10, 58);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 19;
			this.lbl_OBS_Type.Text = "File name";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 24);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(32, 53);
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
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
			this.pictureBox4.Size = new System.Drawing.Size(952, 56);
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox6.BackColor = System.Drawing.Color.Blue;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 74);
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
			this.pictureBox9.Location = new System.Drawing.Point(72, 74);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(912, 14);
			this.pictureBox9.TabIndex = 9;
			this.pictureBox9.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 8;
			this.pnl_Body.DockPadding.Right = 8;
			this.pnl_Body.Location = new System.Drawing.Point(0, 176);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 472);
			this.pnl_Body.TabIndex = 44;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowEditing = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:1{AllowMerging:True;}\t";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1000, 472);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;Border:Flat,1,Control,Vertical;}	Fixed{BackColor:226, 245, 153;ForeColor:Black;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;ForeColor:Black;}	Focus{BackColor:236, 247, 187;ForeColor:Black;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 38;
			// 
			// Form_EL_ID_ORDER
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_EL_ID_ORDER";
			this.Load += new System.EventHandler(this.Form_EL_ID_ORDER_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 속성 정의 

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();
		private COM.ComFunction MyComFunction    = new COM.ComFunction();
	

		#endregion 

		#region 공통 메쏘드
		private void Init_Form()
		{ 
			try
			{
						
				Init_Control();
				Init_Grid();
			}
			catch(Exception ex)
			{
				throw ex;

			}
									

		}

		private void Init_Control()
		{ 

			//Title
			this.Text = "ID Order Loading";
			this.lbl_MainTitle.Text = "ID Order Loading"; 
			//ClassLib.ComFunction.SetLangDic(this);


			
			tbtn_Search.Enabled =false;
			tbtn_Append.Enabled =false;
			tbtn_Color.Enabled =false;
			tbtn_Create.Enabled=false;
			tbtn_Delete.Enabled =false;
			tbtn_Insert.Enabled =false;
			tbtn_New.Enabled =true;
			tbtn_Save.Enabled   = true;
			tbtn_Print.Enabled  =false;
			

			

			DataTable dt_list;
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,false,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;



		}


		private void Init_Grid()
		{ 

		
			fgrid_Main.Set_Grid( "SEM_ID_ORDER", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch,false); 	
			fgrid_Main.Set_Action_Image(img_Action); 
			fgrid_Main.Font = new Font("Verdana", 8);

			


		}

		
		#endregion 

		#region 버튼 컨트롤

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			//			try
			//			{
			//
			//				string mrd_Filename = "Form_EL_ERR.mrd" ;
			//				string txt_Filename = this.Name + ".txt"; 
			//				string Para         = " ";
			//
			//				FileInfo file = new FileInfo(txt_Filename);
			//				if(!file.Exists)
			//				{
			//					file.Create().Close();
			//				}
			//				file = null;
			//
			//				//조회조건들
			//				int  iCnt  = 3;
			//				string [] aHead =  new string[iCnt];	
			//				aHead[0]    = cmb_Factory.SelectedValue.ToString();
			//				aHead[1]    = Convert.ToDateTime(dpick_Date.Text).ToString("yyyyMMdd");
			//				aHead[2]    = cmb_PG_ID.SelectedValue.ToString();
			//
			//
			//				//Parameter만들기
			//				Para  = "/rfn [" + Application.StartupPath + @"\"+ txt_Filename+ "]  /rv "; 			
			//				for (int i  = 1 ; i<= iCnt ; i++)
			//				{
			//					Para = Para +  "V_" + i.ToString().PadLeft (2,'0').ToString() + "[" + aHead[i-1] + "] ";
			//				}
			//				Para = Para + "V_USER[" + ClassLib.ComVar.This_User + "]";
			//
			//
			//				//File 출력 리스트
			//				fgrid_Main.SaveGrid(txt_Filename, FileFormatEnum.TextComma, false);
			//
			//				//Report Base Form호출..
			//				FlexOrder.Report.Form_RD_Base  report = new FlexOrder.Report.Form_RD_Base(txt_Filename,  mrd_Filename, Para);
			//				report.Show();
			//			}
			//			catch(Exception ex)
			//			{
			//				throw ex;
			//
			//			}
		}


		private void btn_path_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;

				if (!File_Open()) return;

				
				DataSet vDataSet = Read_XML_File();
				DisplayGrid(vDataSet.Tables[0]);
				vDataSet.Dispose();


				

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private bool  File_Open()
		{
			try
			{

				openFileDialog.InitialDirectory = "";

				if (openFileDialog.ShowDialog() == DialogResult.Cancel)
				{
					return false;
				}

				txt_Path.Text = openFileDialog.FileName;

				return true;

				
			}
			catch
			{
				return false;
			}
				

		}


	
			
		private DataSet Read_XML_File()
		{



			System.IO.FileStream fsReadXml = new System.IO.FileStream(txt_Path.Text, System.IO.FileMode.Open);	
			System.Xml.XmlTextReader myXmlReader = new System.Xml.XmlTextReader(fsReadXml);

			
			DataSet vDataSet = new DataSet();
			vDataSet.ReadXml(myXmlReader);
			myXmlReader.Close();


			//lbl_Total.Text ="Total:" + vDataSet.Tables[0].Rows.Count.ToString();
			lbl_Total_Count.Text  =  vDataSet.Tables[0].Rows.Count.ToString();		
			lbl_Load_Count.Text  = "0";
			lbl_Failure_Count.Text = "0";
			pgb_process.Minimum =0;

			return vDataSet;



		}



		private void Save_ID_Order( )
		{

			try
			{
														
		        


				string[] vArr= new string[39]; 
				string vOrderID ="";
				//string  vOrderI_dtest = "";
				int  vValueJobLine  =0,vCompJobLine =0, vOrderSeq =1;


				pgb_process.Maximum =_dt_workOrder.Rows.Count;
				pgb_process.Minimum =0;


				
				for (int i = 0;  i<_dt_request.Rows.Count ; i++)
				{
					//				if (_dt_workOrder.Rows[i].ItemArray[0].ToString() =="ID-QD-20090605-0174")
					//					MessageBox.Show("aaa");
					//
					//
					//				if (_dt_request.Rows[i].ItemArray[1].ToString().Length <= 10) return;
					for (int j =0;j<_dt_request.Columns.Count  ;j++)
					{
						if (_dt_request.Columns[j].ColumnName.ToLower().Equals("request"))
							if (_dt_request.Rows[i].ItemArray[j].ToString().Length >= 10)
							{
								Save_Error(_dt_workOrder.Rows[i].ItemArray[0].ToString(),
									_dt_workOrder.Rows[i].ItemArray[1].ToString(),	
									_dt_workOrder.Rows[i].ItemArray[2].ToString(),		       
									_dt_request.Rows[i].ItemArray[j].ToString());
							}

					}

				}


				for (int vOrderLine=0; vOrderLine < _dt_workOrder.Rows.Count  ; vOrderLine++)  //전체 Order갯수 만큼 
				{
              

					_OrderLine   =vOrderLine; 
						 
					if ( vOrderLine  == 194) 
						//MessageBox.Show("aa");

			    

					lbl_Total_Count.Text  = _dt_workOrder.Rows.Count.ToString();
					lbl_Load_Count.Text  = _LoadCount.ToString();
					lbl_Failure_Count.Text  =  _FailCount.ToString();
				
				
					pgb_process.Value  = Convert.ToInt32(vOrderLine+1);
				


					int vCnt  =0;	
					//	_dt_workOrder.Columns[0].ToString()	"workOrderId"	string
					//	_dt_workOrder.Columns[1].ToString()	"shipGroupId"	string
					//	_dt_workOrder.Columns[2].ToString()	"orderId"	string
					//	_dt_workOrder.Columns[3].ToString()	"workOrder_Id"	string
					//	_dt_workOrder.Columns[4].ToString()	"priority"	string
					//	_dt_workOrder.Columns[5].ToString()	"factoryReceivedDate"	string
					//	_dt_workOrder.Columns[6].ToString()	"factoryAcceptDate"	string
					//	_dt_workOrder.Columns[7].ToString()	"initialEstimatedShipDate"	string
					//	_dt_workOrder.Columns[8].ToString()	"requiredShipDate"	string
					//	_dt_workOrder.Columns[9].ToString()	"exotic"	string
					//	_dt_workOrder.Columns[10].ToString()	"remake"	string
					//	_dt_workOrder.Columns[11].ToString()	"shipToRegion"	string
					//	_dt_workOrder.Columns[12].ToString()	"shipToCountry"	string
					//	_dt_workOrder.Columns[13].ToString()	"shipper"	string
					//	_dt_workOrder.Columns[14].ToString()	"billToRegion"	string
					//	_dt_workOrder.Columns[15].ToString()	"shipToStudio"	string
					for (int a =0; a<_dt_workOrder.Columns.Count;  a++)
					{
						if (_dt_workOrder.Columns[a].ToString() == "workOrderId")
							vArr[0]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "shipGroupId")
							vArr[1]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "orderId")
							vArr[2]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "workOrder_Id")
							vArr[3]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "priority")
							vArr[4]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "factoryReceivedDate")
							vArr[5]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "factoryAcceptDate")
							vArr[6]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "initialEstimatedShipDate")
							vArr[7]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "requiredShipDate")
							vArr[8]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "exotic")
							vArr[9]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "remake")
							vArr[10]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "shipToRegion")
							vArr[11]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "shipToCountry")
							vArr[12]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "shipper")
							vArr[13]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "billToRegion")
							vArr[14]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");
						if (_dt_workOrder.Columns[a].ToString() == "shipToStudio")
							vArr[15]  =  _dt_workOrder.Rows[vOrderLine].ItemArray[a].ToString().Replace(",","");

					}




					//_dt_packing.Columns[0].ToString()	"total"	string
					//_dt_packing.Columns[1].ToString()	"itemNumber"	string
					//_dt_packing.Columns[2].ToString()	"workOrder_Id"	string
					for (int b =0; b<_dt_packing.Columns.Count;  b++)//3
					{
						if (_dt_packing.Columns[b].ToString() == "total")
							vArr[16]  =  _dt_packing.Rows[vOrderLine].ItemArray[b].ToString().Replace(",","");
						if (_dt_packing.Columns[b].ToString() == "itemNumber")
							vArr[17]  =  _dt_packing.Rows[vOrderLine].ItemArray[b].ToString().Replace(",","");
						if (_dt_packing.Columns[b].ToString() == "workOrder_Id")
							vArr[18]  =  _dt_packing.Rows[vOrderLine].ItemArray[b].ToString().Replace(",","");
								

					}

					//Request
					//_dt_request.Columns[0].ToString()	"buildInfo_Id"	string
					//_dt_request.Columns[1].ToString()	"request"	string
					//_dt_request.Columns[2].ToString()	"workOrder_Id"	string
					for (int c =0; c<_dt_request.Columns.Count;  c++)//3
					{
						if (_dt_request.Columns[c].ToString() == "buildInfo_Id")
							vArr[19]  =  _dt_request.Rows[vOrderLine].ItemArray[c].ToString().Replace(",","");
						if (_dt_request.Columns[c].ToString() == "request")
							vArr[20]  =  _dt_request.Rows[vOrderLine].ItemArray[c].ToString().Replace(",","");
						if (_dt_request.Columns[c].ToString() == "workOrder_Id")
							vArr[21]  =  _dt_request.Rows[vOrderLine].ItemArray[c].ToString().Replace(",","");
								

					}

					
					//_dt_bom.Columns[0].ToString()	"style"	string
					//_dt_bom.Columns[1].ToString()	"color"	string
					//_dt_bom.Columns[2].ToString()	"name"	string
					//_dt_bom.Columns[3].ToString()	"bom_Id"	string
					for (int d =0; d<_dt_bom.Columns.Count;  d++)//4
					{
						if (_dt_bom.Columns[d].ToString() == "style")
							vArr[22]  =  _dt_bom.Rows[vOrderLine].ItemArray[d].ToString().Replace(",","");
						if (_dt_bom.Columns[d].ToString() == "color")
							vArr[23]  =  _dt_bom.Rows[vOrderLine].ItemArray[d].ToString().Replace(",","");
						if (_dt_bom.Columns[d].ToString() == "name")
							vArr[24]  =  _dt_bom.Rows[vOrderLine].ItemArray[d].ToString().Replace(",","");
						if (_dt_bom.Columns[d].ToString() == "bom_Id")
							vArr[25]  =  _dt_bom.Rows[vOrderLine].ItemArray[d].ToString().Replace(",","");						
					}


					for (int e =0; e<_dt_item.Columns.Count;  e++)//4
					{
						if (_dt_item.Columns[e].ToString() == "SizeLeft")
							vArr[26]  =  _dt_item.Rows[vOrderLine].ItemArray[e].ToString().Replace(",","");
						if (_dt_item.Columns[e].ToString() == "SizeRight")
							vArr[27]  =  _dt_item.Rows[vOrderLine].ItemArray[e].ToString().Replace(",","");
						if (_dt_item.Columns[e].ToString() == "bom_Id")
							vArr[28]  =  _dt_item.Rows[vOrderLine].ItemArray[e].ToString().Replace(",","");
					
					}

					

                
					//component(Grp + Def)		
					
					for (int vCompLine = vCompJobLine; vCompLine <_dt_comp.Rows.Count  ; vCompLine++)
					{
						
						int vCompsid  = 0;

						for (int e =0; e<_dt_comp.Columns.Count;  e++)//4
						{

							if  (_dt_comp.Columns[e].ToString() == "comps_Id")
								vCompsid  = e;

						}

//						+	["comps_Id"]	{System.Data.DataColumn}	System.Object
//						+	["comp_Id"]	{System.Data.DataColumn}	System.Object
//						+	["defV"]	{System.Data.DataColumn}	System.Object
//						+	["name"]	{System.Data.DataColumn}	System.Object
//						+	["values"]	{System.Data.DataTable}	System.Object
//						+	["grp"]	{System.Data.DataColumn}	System.Object
//

				 
						if   (vOrderLine  == Convert.ToUInt32(_dt_comp.Rows[vCompLine].ItemArray[vCompsid].ToString())) //상단 테이블의 종속성 찾기(Order)
						{

							for (int e =0; e<_dt_comp.Columns.Count;  e++)//4
							{
								if (_dt_comp.Columns[e].ToString() == "grp")							
									vArr[29] = _dt_comp.Rows[vCompLine].ItemArray[e].ToString();  //grp
								if (_dt_comp.Columns[e].ToString() == "defV")		
									vArr[30] = _dt_comp.Rows[vCompLine].ItemArray[e].ToString();  //defV
								if (_dt_comp.Columns[e].ToString() == "name")		
									vArr[31] = _dt_comp.Rows[vCompLine].ItemArray[e].ToString();  //name
							}

							for (int vValueLine  = vValueJobLine;  vValueLine <_dt_value.Rows.Count; vValueLine++)  //상단 테이블의 종속성 찾기(Compo)
							{
								
                                int vValueid  = 0;

								for (int e =0; e<_dt_value.Columns.Count;  e++)//4
								{

									if  (_dt_value.Columns[e].ToString() == "values_Id")
										vValueid  = e;

								}

								if (vCompLine ==   Convert.ToUInt32(_dt_value.Rows[vValueLine].ItemArray[vValueid].ToString()))
								{
									vCnt  =32;
									
									for (int e =0; e<_dt_value.Columns.Count;  e++)//4
									{
										if (_dt_value.Columns[e].ToString() == "type")																				
											   vArr[32] =  _dt_value.Rows[vValueLine].ItemArray[e].ToString();  //COLO																				  
										if (_dt_value.Columns[e].ToString() == "code")
											vArr[33]  =  _dt_value.Rows[vValueLine].ItemArray[e].ToString().Replace(",","");
										if (_dt_value.Columns[e].ToString() == "name")
											vArr[34]  =  _dt_value.Rows[vValueLine].ItemArray[e].ToString().Replace(",","");
										if (_dt_value.Columns[e].ToString() == "value_Text")
											vArr[35]  =  _dt_value.Rows[vValueLine].ItemArray[e].ToString().Replace(",","");
										
//										+	["value_Text"]	{System.Data.DataColumn}	System.Object
//										+	["name"]	{System.Data.DataColumn}	System.Object
//										+	["type"]	{System.Data.DataColumn}	System.Object
//										+	["code"]	{System.Data.DataColumn}	System.Object
//										+	["values_Id"]	{System.Data.DataColumn}	System.Object

										
									}
									
									vArr[36] =  System.DateTime.Now.ToString("yyyyMMdd");
									vArr[37] =  ClassLib.ComVar.This_User;
									vArr[38] =  Convert.ToString(vOrderSeq);

									vOrderSeq++;
					
                                    //if  (vColor == false) continue;
									if (!Save_Nid_Order_Mast_Load(vArr,fgrid_Main.Rows.Fixed + vOrderLine))
										if (vOrderID !=_dt_workOrder.Rows[vOrderLine].ItemArray[0].ToString())
										{
											_FailCount++;
											lbl_Total_Count.Text  =  _dt_workOrder.Rows.Count.ToString();
											lbl_Load_Count.Text  =  Convert.ToString(_LoadCount);
											lbl_Failure_Count.Text  = Convert.ToString(_FailCount);
											
										}
										else
											if (vOrderID !=_dt_workOrder.Rows[vOrderLine].ItemArray[0].ToString())
										{
											
											_LoadCount++;
											lbl_Total_Count.Text  =  _dt_workOrder.Rows.Count.ToString();
											lbl_Load_Count.Text  =  Convert.ToString(_LoadCount);
											lbl_Failure_Count.Text  = Convert.ToString(_FailCount);
											
											
										}

									


								
									vOrderID= _dt_workOrder.Rows[vOrderLine].ItemArray[0].ToString();  //order id
									vValueJobLine++;

								}
								else
									break;
							
							}

						
						
							vCompJobLine++;
						
						
						

						}
						else 
							break;

                    
					

					}


					fgrid_Main.TopRow = fgrid_Main.Rows.Fixed + vOrderLine;
					vOrderSeq=1;

				
				}

			
			}
			catch
			{

				//에러처리 프로세스
				for (int i  =_OrderLine+1;   i< fgrid_Main.Rows.Count  ; i++)
				{

					fgrid_Main.GetCellRange(i, 0,i ,fgrid_Main.Cols.Count-1).StyleNew.ForeColor = Color.Red;
					fgrid_Main[i,1] ="False";

					_FailCount++;
					lbl_Total_Count.Text  =  _dt_workOrder.Rows.Count.ToString();
					lbl_Load_Count.Text  = _LoadCount.ToString();
					lbl_Failure_Count.Text  = _FailCount.ToString();
											



					Save_Error(fgrid_Main[i,(int)ClassLib.TBSEM_ID_ORDER.IxWorkOrderID].ToString().Replace(",",""),
						fgrid_Main[i,(int)ClassLib.TBSEM_ID_ORDER.IxShipGroupID].ToString().Replace(",",""),
						fgrid_Main[i,(int)ClassLib.TBSEM_ID_ORDER.IxOrderID].ToString().Replace(",","")," ");
				}
			}
			finally
			{

				lbl_Total_Count.Text  = _dt_workOrder.Rows.Count.ToString();
				lbl_Load_Count.Text  = Convert.ToString(_dt_workOrder.Rows.Count-_FailCount);
				lbl_Failure_Count.Text  =  _FailCount.ToString();







			}



			
			

		}




		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
			txt_Path.Clear();
		
		}

	


		private int _OrderLine=0;
		private int _FailCount=0, _LoadCount =0;
		//private string _FailOrderId  ="";
		private DataTable _dt_workOrder    =null;
		private DataTable _dt_packing      =null;
		private DataTable _dt_request      =null;
		private DataTable _dt_bom	       =null;
		private DataTable _dt_item	       =null;
		private DataTable _dt_comp	       =null;
		private DataTable _dt_value	       =null;
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			
			try
			{
				this.Cursor = Cursors.WaitCursor;
				
				DataSet vDataSet = Read_XML_File();


				_OrderLine =0; _FailCount=0;_LoadCount=0;
			
				//DataSet   vDataSet  = Read_XML_File();
	
//				_dt_workOrder     = vDataSet.Tables[0];
//				_dt_packing       = vDataSet.Tables[1];
//				_dt_request       = vDataSet.Tables[2];   //Build info  
//
//				_dt_bom	          = vDataSet.Tables[4];
//				_dt_item	      = vDataSet.Tables[5];
//				_dt_comp	      = vDataSet.Tables[7];
//				_dt_value	      = vDataSet.Tables[9];

				_dt_workOrder     = vDataSet.Tables[0];
				_dt_packing       = vDataSet.Tables[1];
				_dt_request       = vDataSet.Tables[2];   //Build info  

				_dt_bom	          = vDataSet.Tables[4]; //bom info , [4] = product info
				_dt_item	      = vDataSet.Tables[5];
				_dt_comp	      = vDataSet.Tables[7];
				_dt_value	      = vDataSet.Tables[9];



				//기존의 error 로그 삭제
				Delete_Error();


				lbl_Total_Count.Text = _dt_workOrder.Rows.Count.ToString();
				lbl_Load_Count.Text = "0"; 
                lbl_Failure_Count.Text =_dt_workOrder.Rows.Count.ToString();

				if (_dt_workOrder.Rows.Count !=_dt_packing.Rows.Count)
				{

                    Save_Err_XML();
					MessageBox.Show("Nike XML Error. Please Ask System..");
					return;

				}

				
				if (_dt_workOrder.Rows.Count !=_dt_packing.Rows.Count) 
				{

					Save_Err_XML();
					MessageBox.Show("Nike XML Error. Please Ask System..");
					return;

				}

				
				if (_dt_workOrder.Rows.Count !=_dt_item.Rows.Count)
				{

					Save_Err_XML();
					MessageBox.Show("Nike XML Error. Please Ask System..");
					return;

				}


					

						

				Save_ID_Order();


				

                

			
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				this.Cursor = Cursors.Default;


				
				FlexOrder.ExpLoad.POP_EL_ID  pop_form = new  ExpLoad.POP_EL_ID(cmb_Factory.SelectedValue.ToString(),
					lbl_Total_Count.Text, lbl_Load_Count.Text, lbl_Failure_Count.Text);

				
				 
				pop_form.ShowDialog();
     

			}


		}


		private void Save_Err_XML()
		{


			for (int i = 0;  i<_dt_request.Rows.Count ; i++)
			{
//				if (_dt_workOrder.Rows[i].ItemArray[0].ToString() =="ID-QD-20090605-0174")
//					MessageBox.Show("aaa");
//
//
//				if (_dt_request.Rows[i].ItemArray[1].ToString().Length <= 10) return;
				for (int j =0;j<_dt_request.Columns.Count  ;j++)
				{
					if (_dt_request.Columns[j].ColumnName.ToLower().Equals("request"))
						if (_dt_request.Rows[i].ItemArray[j].ToString().Length >= 10)
						{
							Save_Error(_dt_workOrder.Rows[i].ItemArray[0].ToString(),
								_dt_workOrder.Rows[i].ItemArray[1].ToString(),	
								_dt_workOrder.Rows[i].ItemArray[2].ToString(),		       
								_dt_request.Rows[i].ItemArray[j].ToString());
						}

				}

                
				
			}


					//if (arg_ds_xml.Tables[i].Columns[col].ColumnName.ToLower().Equals("nike_bom_id"))
//						xml_bom_id = arg_ds_xml.Tables[i].Rows[row].ItemArray[col].ToString();
//

			
			


	    }


		private void DisplayGrid(DataTable arg_workorker)
		{

			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;


			for ( int i =0; i<  arg_workorker.Rows.Count ; i++)
			{

               fgrid_Main.AddItem(arg_workorker.Rows[i].ItemArray,fgrid_Main.Rows.Count,2) ; 
			   fgrid_Main[fgrid_Main.Rows.Count-1,1] ="False";


			   fgrid_Main.GetCellRange(fgrid_Main.Rows.Count -1, 0,
					fgrid_Main.Rows.Count -1 ,fgrid_Main.Cols.Count-1).StyleNew.ForeColor = Color.Black;

			}


		}



		#endregion 

		#region DB 컨넥트

		
		private bool Save_Nid_Order_Mast_Load(string[] arg_arr, int arg_orderline)  
		{

			string vWorkOrderId ="",vGroupNO="", vComponentName ="";
            int    vOrderline =0; 

		
			int col_ct = arg_arr.Length;

			MyOraDB.ReDim_Parameter(col_ct);

		


			MyOraDB.Process_Name = "PKG_SEM_NID_RECV_ORDER_LOAD.SAVE_NID_RECV_ORDER_LOAD";

			//type
			for(int i = 0; i < arg_arr.Length; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

		
			//Name
			int j=0;
		     


			
		MyOraDB.Parameter_Name[j++]  ="ARG_WORKORDERID"; 		                   
		MyOraDB.Parameter_Name[j++]  ="ARG_SHIPGROUPID"; 		               
		MyOraDB.Parameter_Name[j++]  ="ARG_ORDERID"; 			                 
		MyOraDB.Parameter_Name[j++]  ="ARG_WORKORDERID2"; 		            	  
		MyOraDB.Parameter_Name[j++]  ="ARG_PRIORITY"; 			                 
		MyOraDB.Parameter_Name[j++]  ="ARG_FACTORYRECEIVEDDATE";            
		MyOraDB.Parameter_Name[j++]  ="ARG_FACTORYACCEPTDATE"; 	           
		MyOraDB.Parameter_Name[j++]  ="ARG_INITIALESTIMATEDSHIPDATE";       
		MyOraDB.Parameter_Name[j++]  ="ARG_REQUIREDSHIPDATE"; 		           
		MyOraDB.Parameter_Name[j++]  ="ARG_EXOTIC"; 					               
		MyOraDB.Parameter_Name[j++]  ="ARG_REMAKE"; 					               
		MyOraDB.Parameter_Name[j++]  ="ARG_SHIPTOREGION"; 			             
		MyOraDB.Parameter_Name[j++]  ="ARG_SHIPTOCOUNTRY"; 			           
		MyOraDB.Parameter_Name[j++]  ="ARG_SHIPPER"; 				               
		MyOraDB.Parameter_Name[j++]  ="ARG_BILLTOREGION"; 			             
		MyOraDB.Parameter_Name[j++]  ="ARG_SHIPTOSTUDIO"; 			             
		MyOraDB.Parameter_Name[j++]  ="ARG_TOTAL"; 				                 
		MyOraDB.Parameter_Name[j++]  ="ARG_ITEMNUMBER"; 			               
		MyOraDB.Parameter_Name[j++]  ="ARG_WORKORDER_ID3";   	             
		MyOraDB.Parameter_Name[j++]  ="ARG_BUILDINFO_ID";                   
		MyOraDB.Parameter_Name[j++]  ="ARG_REQUEST_MSG";                    
		MyOraDB.Parameter_Name[j++]  ="ARG_WORKORDER_ID4";                  
		MyOraDB.Parameter_Name[j++]  ="ARG_STYLE"; 					               
		MyOraDB.Parameter_Name[j++]  ="ARG_COLOR"; 					               
		MyOraDB.Parameter_Name[j++]  ="ARG_NAME"; 					                 
		MyOraDB.Parameter_Name[j++]  ="ARG_BOM_ID"; 				                 
		MyOraDB.Parameter_Name[j++]  ="ARG_SIZELEFT"; 				               
		MyOraDB.Parameter_Name[j++]  ="ARG_SIZERIGHT"; 				             
		MyOraDB.Parameter_Name[j++]  ="ARG_BOM_ID2"; 				               
		MyOraDB.Parameter_Name[j++]  ="ARG_GRP"; 					                 
		MyOraDB.Parameter_Name[j++]  ="ARG_DEFV"; 					                 
		MyOraDB.Parameter_Name[j++]  ="ARG_NAME2"; 					 	             
		MyOraDB.Parameter_Name[j++]  ="ARG_TYPES"; 					           
		MyOraDB.Parameter_Name[j++]  ="ARG_CODE"; 					                 
		MyOraDB.Parameter_Name[j++]  ="ARG_NAME3"; 					              
		MyOraDB.Parameter_Name[j++]  ="ARG_CDATA"; 					               
		MyOraDB.Parameter_Name[j++]  ="ARG_LOAD_DATE";                
		MyOraDB.Parameter_Name[j++]  ="ARG_LOAD_USER";                
		MyOraDB.Parameter_Name[j++]  ="ARG_WORKORDERID_SEQ";  
	

//			string vTest ="";
//		    if (arg_orderline  == 195)
//			   vTest  ="aa";
//


			//Value
			for(int i=0; i < arg_arr.Length; i++)
				MyOraDB.Parameter_Values[i]  = arg_arr[i];


			vWorkOrderId =  arg_arr[0];   vGroupNO=arg_arr[24];  vComponentName =arg_arr[26];
			vOrderline   =  arg_orderline;

			MyOraDB.Add_Modify_Parameter(true);

			if ( MyOraDB.Exe_Modify_Procedure() == null)
			{
				//MessageBox.Show("Error  WorkOrderID : "+ vWorkOrderId + "/"+ vGroupNO + "/" +vComponentName  );
				//insert error db
				fgrid_Main.GetCellRange(vOrderline, 0,vOrderline ,fgrid_Main.Cols.Count-1).StyleNew.ForeColor = Color.Red;
				fgrid_Main[vOrderline,1] ="False";
	
				Save_Error(arg_arr[0],arg_arr[1],arg_arr[2]," ");
				return false;
				

			}
			else 
			{
				fgrid_Main[vOrderline,1] ="True";
				return true;
				
			}
				
		
			
		
		}



		private bool Save_Error(string  arg_workorderid, string arg_shipgroupid,  string arg_orderid, string arg_remarks)
		{

			
		

		
			int col_ct = 18;

			MyOraDB.ReDim_Parameter(col_ct);

		


			MyOraDB.Process_Name = "PKG_SEM_USER_ERR.SAVE_SEM_USER_ERR";

			//type
			for(int i = 0; i <col_ct; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

		
			//Name
			int j=0;




			MyOraDB.Parameter_Name[j++]  ="ARG_FACTORY";	
			MyOraDB.Parameter_Name[j++]  ="ARG_JOB_YMD"; 	        
			MyOraDB.Parameter_Name[j++]  ="ARG_PG_ID"; 		
			MyOraDB.Parameter_Name[j++]  ="ARG_PG_NAME"; 		           	  
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_NAME"; 	   

			MyOraDB.Parameter_Name[j++]  ="ARG_COM_VALUE1"; 		   	  
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_DESC1"; 	       
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_VALUE2"; 			
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_DESC2"; 	       
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_VALUE3"; 	     

			MyOraDB.Parameter_Name[j++]  ="ARG_COM_DESC3"; 	     
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_VALUE4"; 	       
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_DESC4"; 	         
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_VALUE5"; 	       
			MyOraDB.Parameter_Name[j++]  ="ARG_COM_DESC5"; 	

			MyOraDB.Parameter_Name[j++]  ="ARG_REMARKS"; 	   
			MyOraDB.Parameter_Name[j++]  ="ARG_UPD_USER"; 	
			MyOraDB.Parameter_Name[j++]  ="ARG_UPD_YMD";  	
			
			//Value
			int k=0;
			MyOraDB.Parameter_Values[k++]  = cmb_Factory.SelectedValue.ToString();	
			MyOraDB.Parameter_Values[k++]  = System.DateTime.Now.ToString("yyyyMMdd");        
			MyOraDB.Parameter_Values[k++]  ="Form_EL_ID"; 		
			MyOraDB.Parameter_Values[k++]  ="lD_UPlOADING"; 		           	  
			MyOraDB.Parameter_Values[k++]  = arg_workorderid; 	   
			MyOraDB.Parameter_Values[k++]  = arg_orderid;
			MyOraDB.Parameter_Values[k++]  = " ";
			MyOraDB.Parameter_Values[k++]  =" ";  			
			MyOraDB.Parameter_Values[k++]  =" ";  			       
			MyOraDB.Parameter_Values[k++]  =" ";  			  
			MyOraDB.Parameter_Values[k++]  =" ";  				     
			MyOraDB.Parameter_Values[k++]  =" ";  			     
			MyOraDB.Parameter_Values[k++]  =" ";  			         
			MyOraDB.Parameter_Values[k++]  =" ";  				       
			MyOraDB.Parameter_Values[k++]  =" ";  
				
			MyOraDB.Parameter_Values[k++]  =arg_remarks;
			MyOraDB.Parameter_Values[k++]  =ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[k++]  =System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
			


			MyOraDB.Add_Modify_Parameter(true);
			if (MyOraDB.Exe_Modify_Procedure() == null)
			{
				
				return false;
				

			}
			else 
			{
				
				return true;
				
			}
				
		
			
		
		}


		private bool Delete_Error()
		{

			
		

		
			int col_ct = 4;

			MyOraDB.ReDim_Parameter(col_ct);

		


			MyOraDB.Process_Name = "PKG_SEM_USER_ERR.DELETE_SEM_USER_ERR";

			//type
			for(int i = 0; i <col_ct; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

		
			//Name
			int j=0;




			MyOraDB.Parameter_Name[j++]  ="ARG_FACTORY";	
			MyOraDB.Parameter_Name[j++]  ="ARG_JOB_YMD"	;	
			MyOraDB.Parameter_Name[j++]  ="ARG_PG_ID"; 	        
			MyOraDB.Parameter_Name[j++]  ="ARG_PG_NAME"; ; 	
			
			//Value
			int k=0;
			MyOraDB.Parameter_Values[k++]  = cmb_Factory.SelectedValue.ToString();	
			MyOraDB.Parameter_Values[k++]  = System.DateTime.Now.ToString("yyyyMMdd");        
			MyOraDB.Parameter_Values[k++]  ="Form_EL_ID"; 		
			MyOraDB.Parameter_Values[k++]  ="lD_UPlOADING"; 


			MyOraDB.Add_Modify_Parameter(true);
			if (MyOraDB.Exe_Modify_Procedure() == null)
			{
				
				return false;
				

			}
			else 
			{
				
				return true;
				
			}
				
		
			
		
		}




		#endregion

		private void Form_EL_ID_ORDER_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
		}

	

	}
}

