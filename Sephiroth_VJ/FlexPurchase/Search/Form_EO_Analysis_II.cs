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
	public class Form_EO_Analysis_II : COM.OrderWinForm.Form_Top
	{   
		#region 컨트롤정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Search;
		private System.Windows.Forms.Panel pnl_Search1_Image;
		private System.Windows.Forms.GroupBox grp_Option;
		private System.Windows.Forms.RadioButton rad_Factory;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_To;
		private C1.Win.C1List.C1Combo cmb_OBS_ID_From;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.RadioButton rad_Out_Sole;
		private System.Windows.Forms.Label lbl_Style_Cd;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.RadioButton rad_Style_Cd;
		private System.Windows.Forms.Label lbl_Category;
		private C1.Win.C1List.C1Combo cmb_Category;
		private System.Windows.Forms.Label lbl_Out_Sole;
		private C1.Win.C1List.C1Combo cmb_Outsole;
		private System.Windows.Forms.Label lbl_Dev_Name;
		private C1.Win.C1List.C1Combo cmb_Dev_Name;
		private System.Windows.Forms.Label lbl_Gender;
		private C1.Win.C1List.C1Combo cmb_Gender;
		private System.Windows.Forms.Label lbl_dev_Code;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Dev_Code;
		private System.Windows.Forms.TextBox txt_Dev_Code;
		private System.Windows.Forms.TextBox txt_Dev_Name;
		private System.Windows.Forms.TextBox txt_Outsole;
		private System.ComponentModel.IContainer components = null;

		public Form_EO_Analysis_II()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_EO_Analysis_II));
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_Search1_Image = new System.Windows.Forms.Panel();
			this.txt_Outsole = new System.Windows.Forms.TextBox();
			this.txt_Dev_Name = new System.Windows.Forms.TextBox();
			this.txt_Dev_Code = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_dev_Code = new System.Windows.Forms.Label();
			this.cmb_Dev_Code = new C1.Win.C1List.C1Combo();
			this.lbl_Gender = new System.Windows.Forms.Label();
			this.cmb_Gender = new C1.Win.C1List.C1Combo();
			this.lbl_Dev_Name = new System.Windows.Forms.Label();
			this.cmb_Dev_Name = new C1.Win.C1List.C1Combo();
			this.lbl_Out_Sole = new System.Windows.Forms.Label();
			this.cmb_Outsole = new C1.Win.C1List.C1Combo();
			this.lbl_Category = new System.Windows.Forms.Label();
			this.cmb_Category = new C1.Win.C1List.C1Combo();
			this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
			this.lbl_Style_Cd = new System.Windows.Forms.Label();
			this.grp_Option = new System.Windows.Forms.GroupBox();
			this.rad_Style_Cd = new System.Windows.Forms.RadioButton();
			this.rad_Out_Sole = new System.Windows.Forms.RadioButton();
			this.rad_Factory = new System.Windows.Forms.RadioButton();
			this.cmb_OBS_ID_To = new C1.Win.C1List.C1Combo();
			this.cmb_OBS_ID_From = new C1.Win.C1List.C1Combo();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Search.SuspendLayout();
			this.pnl_Search1_Image.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Code)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gender)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Name)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Outsole)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
			this.grp_Option.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).BeginInit();
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
			// tbtn_New
			// 
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
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
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_Search1_Image);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 64);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(1012, 128);
			this.pnl_Search.TabIndex = 46;
			// 
			// pnl_Search1_Image
			// 
			this.pnl_Search1_Image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search1_Image.BackColor = System.Drawing.Color.RosyBrown;
			this.pnl_Search1_Image.Controls.Add(this.txt_Outsole);
			this.pnl_Search1_Image.Controls.Add(this.txt_Dev_Name);
			this.pnl_Search1_Image.Controls.Add(this.txt_Dev_Code);
			this.pnl_Search1_Image.Controls.Add(this.txt_StyleCd);
			this.pnl_Search1_Image.Controls.Add(this.lbl_dev_Code);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Dev_Code);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Gender);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Gender);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Dev_Name);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Dev_Name);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Out_Sole);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Outsole);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Category);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Category);
			this.pnl_Search1_Image.Controls.Add(this.cmb_StyleCd);
			this.pnl_Search1_Image.Controls.Add(this.lbl_Style_Cd);
			this.pnl_Search1_Image.Controls.Add(this.grp_Option);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID_To);
			this.pnl_Search1_Image.Controls.Add(this.cmb_OBS_ID_From);
			this.pnl_Search1_Image.Controls.Add(this.label1);
			this.pnl_Search1_Image.Controls.Add(this.label2);
			this.pnl_Search1_Image.Controls.Add(this.label3);
			this.pnl_Search1_Image.Controls.Add(this.cmb_Factory);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox3);
			this.pnl_Search1_Image.Controls.Add(this.lbl_SubTitle1);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox5);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox8);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox7);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox10);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox11);
			this.pnl_Search1_Image.Controls.Add(this.pictureBox12);
			this.pnl_Search1_Image.Location = new System.Drawing.Point(8, 8);
			this.pnl_Search1_Image.Name = "pnl_Search1_Image";
			this.pnl_Search1_Image.Size = new System.Drawing.Size(996, 112);
			this.pnl_Search1_Image.TabIndex = 0;
			// 
			// txt_Outsole
			// 
			this.txt_Outsole.BackColor = System.Drawing.Color.White;
			this.txt_Outsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Outsole.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Outsole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Outsole.Location = new System.Drawing.Point(776, 35);
			this.txt_Outsole.MaxLength = 10;
			this.txt_Outsole.Name = "txt_Outsole";
			this.txt_Outsole.Size = new System.Drawing.Size(75, 20);
			this.txt_Outsole.TabIndex = 566;
			this.txt_Outsole.Text = "";
			this.txt_Outsole.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Outsole_KeyUp);
			// 
			// txt_Dev_Name
			// 
			this.txt_Dev_Name.BackColor = System.Drawing.Color.White;
			this.txt_Dev_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dev_Name.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Dev_Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Dev_Name.Location = new System.Drawing.Point(445, 55);
			this.txt_Dev_Name.MaxLength = 10;
			this.txt_Dev_Name.Name = "txt_Dev_Name";
			this.txt_Dev_Name.Size = new System.Drawing.Size(75, 20);
			this.txt_Dev_Name.TabIndex = 565;
			this.txt_Dev_Name.Text = "";
			this.txt_Dev_Name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Dev_Name_KeyUp);
			// 
			// txt_Dev_Code
			// 
			this.txt_Dev_Code.BackColor = System.Drawing.Color.White;
			this.txt_Dev_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Dev_Code.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Dev_Code.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_Dev_Code.Location = new System.Drawing.Point(117, 76);
			this.txt_Dev_Code.MaxLength = 10;
			this.txt_Dev_Code.Name = "txt_Dev_Code";
			this.txt_Dev_Code.Size = new System.Drawing.Size(75, 20);
			this.txt_Dev_Code.TabIndex = 564;
			this.txt_Dev_Code.Text = "";
			this.txt_Dev_Code.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Dev_Code_KeyUp);
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.White;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.txt_StyleCd.Location = new System.Drawing.Point(445, 76);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(75, 20);
			this.txt_StyleCd.TabIndex = 563;
			this.txt_StyleCd.Text = "";
			this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
			// 
			// lbl_dev_Code
			// 
			this.lbl_dev_Code.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_dev_Code.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_dev_Code.ImageIndex = 1;
			this.lbl_dev_Code.ImageList = this.img_Label;
			this.lbl_dev_Code.Location = new System.Drawing.Point(16, 76);
			this.lbl_dev_Code.Name = "lbl_dev_Code";
			this.lbl_dev_Code.Size = new System.Drawing.Size(100, 21);
			this.lbl_dev_Code.TabIndex = 561;
			this.lbl_dev_Code.Text = "Dev Code";
			this.lbl_dev_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Dev_Code
			// 
			this.cmb_Dev_Code.AddItemCols = 0;
			this.cmb_Dev_Code.AddItemSeparator = ';';
			this.cmb_Dev_Code.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dev_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dev_Code.Caption = "";
			this.cmb_Dev_Code.CaptionHeight = 17;
			this.cmb_Dev_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dev_Code.ColumnCaptionHeight = 18;
			this.cmb_Dev_Code.ColumnFooterHeight = 18;
			this.cmb_Dev_Code.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dev_Code.ContentHeight = 15;
			this.cmb_Dev_Code.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dev_Code.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Dev_Code.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dev_Code.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dev_Code.EditorHeight = 15;
			this.cmb_Dev_Code.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dev_Code.GapHeight = 2;
			this.cmb_Dev_Code.ItemHeight = 15;
			this.cmb_Dev_Code.Location = new System.Drawing.Point(195, 76);
			this.cmb_Dev_Code.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dev_Code.MaxDropDownItems = ((short)(5));
			this.cmb_Dev_Code.MaxLength = 32767;
			this.cmb_Dev_Code.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dev_Code.Name = "cmb_Dev_Code";
			this.cmb_Dev_Code.PartialRightColumn = false;
			this.cmb_Dev_Code.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Dev_Code.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dev_Code.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dev_Code.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dev_Code.Size = new System.Drawing.Size(133, 19);
			this.cmb_Dev_Code.TabIndex = 562;
			this.cmb_Dev_Code.TextChanged += new System.EventHandler(this.cmb_Dev_Code_TextChanged);
			// 
			// lbl_Gender
			// 
			this.lbl_Gender.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Gender.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Gender.ImageIndex = 1;
			this.lbl_Gender.ImageList = this.img_Label;
			this.lbl_Gender.Location = new System.Drawing.Point(674, 56);
			this.lbl_Gender.Name = "lbl_Gender";
			this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gender.TabIndex = 559;
			this.lbl_Gender.Text = "Gender";
			this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Gender
			// 
			this.cmb_Gender.AddItemCols = 0;
			this.cmb_Gender.AddItemSeparator = ';';
			this.cmb_Gender.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Gender.Caption = "";
			this.cmb_Gender.CaptionHeight = 17;
			this.cmb_Gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Gender.ColumnCaptionHeight = 18;
			this.cmb_Gender.ColumnFooterHeight = 18;
			this.cmb_Gender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Gender.ContentHeight = 15;
			this.cmb_Gender.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Gender.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Gender.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Gender.EditorHeight = 15;
			this.cmb_Gender.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Gender.GapHeight = 2;
			this.cmb_Gender.ItemHeight = 15;
			this.cmb_Gender.Location = new System.Drawing.Point(776, 56);
			this.cmb_Gender.MatchEntryTimeout = ((long)(2000));
			this.cmb_Gender.MaxDropDownItems = ((short)(5));
			this.cmb_Gender.MaxLength = 32767;
			this.cmb_Gender.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Gender.Name = "cmb_Gender";
			this.cmb_Gender.PartialRightColumn = false;
			this.cmb_Gender.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Gender.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Gender.Size = new System.Drawing.Size(210, 19);
			this.cmb_Gender.TabIndex = 560;
			// 
			// lbl_Dev_Name
			// 
			this.lbl_Dev_Name.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Dev_Name.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Dev_Name.ImageIndex = 1;
			this.lbl_Dev_Name.ImageList = this.img_Label;
			this.lbl_Dev_Name.Location = new System.Drawing.Point(343, 56);
			this.lbl_Dev_Name.Name = "lbl_Dev_Name";
			this.lbl_Dev_Name.Size = new System.Drawing.Size(100, 21);
			this.lbl_Dev_Name.TabIndex = 557;
			this.lbl_Dev_Name.Text = "Dev Name";
			this.lbl_Dev_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Dev_Name
			// 
			this.cmb_Dev_Name.AddItemCols = 0;
			this.cmb_Dev_Name.AddItemSeparator = ';';
			this.cmb_Dev_Name.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Dev_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Dev_Name.Caption = "";
			this.cmb_Dev_Name.CaptionHeight = 17;
			this.cmb_Dev_Name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Dev_Name.ColumnCaptionHeight = 18;
			this.cmb_Dev_Name.ColumnFooterHeight = 18;
			this.cmb_Dev_Name.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Dev_Name.ContentHeight = 15;
			this.cmb_Dev_Name.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Dev_Name.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Dev_Name.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dev_Name.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Dev_Name.EditorHeight = 15;
			this.cmb_Dev_Name.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Dev_Name.GapHeight = 2;
			this.cmb_Dev_Name.ItemHeight = 15;
			this.cmb_Dev_Name.Location = new System.Drawing.Point(521, 55);
			this.cmb_Dev_Name.MatchEntryTimeout = ((long)(2000));
			this.cmb_Dev_Name.MaxDropDownItems = ((short)(5));
			this.cmb_Dev_Name.MaxLength = 32767;
			this.cmb_Dev_Name.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Dev_Name.Name = "cmb_Dev_Name";
			this.cmb_Dev_Name.PartialRightColumn = false;
			this.cmb_Dev_Name.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Dev_Name.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Dev_Name.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Dev_Name.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Dev_Name.Size = new System.Drawing.Size(133, 19);
			this.cmb_Dev_Name.TabIndex = 558;
			this.cmb_Dev_Name.TextChanged += new System.EventHandler(this.cmb_Dev_Name_TextChanged);
			// 
			// lbl_Out_Sole
			// 
			this.lbl_Out_Sole.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Out_Sole.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Out_Sole.ImageIndex = 1;
			this.lbl_Out_Sole.ImageList = this.img_Label;
			this.lbl_Out_Sole.Location = new System.Drawing.Point(675, 35);
			this.lbl_Out_Sole.Name = "lbl_Out_Sole";
			this.lbl_Out_Sole.Size = new System.Drawing.Size(100, 21);
			this.lbl_Out_Sole.TabIndex = 555;
			this.lbl_Out_Sole.Text = "OutSole";
			this.lbl_Out_Sole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Outsole
			// 
			this.cmb_Outsole.AddItemCols = 0;
			this.cmb_Outsole.AddItemSeparator = ';';
			this.cmb_Outsole.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Outsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Outsole.Caption = "";
			this.cmb_Outsole.CaptionHeight = 17;
			this.cmb_Outsole.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Outsole.ColumnCaptionHeight = 18;
			this.cmb_Outsole.ColumnFooterHeight = 18;
			this.cmb_Outsole.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Outsole.ContentHeight = 15;
			this.cmb_Outsole.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Outsole.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Outsole.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Outsole.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Outsole.EditorHeight = 15;
			this.cmb_Outsole.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Outsole.GapHeight = 2;
			this.cmb_Outsole.ItemHeight = 15;
			this.cmb_Outsole.Location = new System.Drawing.Point(853, 35);
			this.cmb_Outsole.MatchEntryTimeout = ((long)(2000));
			this.cmb_Outsole.MaxDropDownItems = ((short)(5));
			this.cmb_Outsole.MaxLength = 32767;
			this.cmb_Outsole.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Outsole.Name = "cmb_Outsole";
			this.cmb_Outsole.PartialRightColumn = false;
			this.cmb_Outsole.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Outsole.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Outsole.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Outsole.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Outsole.Size = new System.Drawing.Size(133, 19);
			this.cmb_Outsole.TabIndex = 556;
			this.cmb_Outsole.TextChanged += new System.EventHandler(this.cmb_Outsole_TextChanged);
			// 
			// lbl_Category
			// 
			this.lbl_Category.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Category.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Category.ImageIndex = 1;
			this.lbl_Category.ImageList = this.img_Label;
			this.lbl_Category.Location = new System.Drawing.Point(343, 34);
			this.lbl_Category.Name = "lbl_Category";
			this.lbl_Category.Size = new System.Drawing.Size(100, 21);
			this.lbl_Category.TabIndex = 553;
			this.lbl_Category.Text = "Category";
			this.lbl_Category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Category
			// 
			this.cmb_Category.AddItemCols = 0;
			this.cmb_Category.AddItemSeparator = ';';
			this.cmb_Category.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Category.Caption = "";
			this.cmb_Category.CaptionHeight = 17;
			this.cmb_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Category.ColumnCaptionHeight = 18;
			this.cmb_Category.ColumnFooterHeight = 18;
			this.cmb_Category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Category.ContentHeight = 15;
			this.cmb_Category.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Category.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Category.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Category.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Category.EditorHeight = 15;
			this.cmb_Category.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_Category.GapHeight = 2;
			this.cmb_Category.ItemHeight = 15;
			this.cmb_Category.Location = new System.Drawing.Point(444, 35);
			this.cmb_Category.MatchEntryTimeout = ((long)(2000));
			this.cmb_Category.MaxDropDownItems = ((short)(5));
			this.cmb_Category.MaxLength = 32767;
			this.cmb_Category.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Category.Name = "cmb_Category";
			this.cmb_Category.PartialRightColumn = false;
			this.cmb_Category.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Category.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Category.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Category.Size = new System.Drawing.Size(210, 19);
			this.cmb_Category.TabIndex = 554;
			// 
			// cmb_StyleCd
			// 
			this.cmb_StyleCd.AddItemCols = 0;
			this.cmb_StyleCd.AddItemSeparator = ';';
			this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleCd.Caption = "";
			this.cmb_StyleCd.CaptionHeight = 17;
			this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleCd.ColumnCaptionHeight = 18;
			this.cmb_StyleCd.ColumnFooterHeight = 18;
			this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleCd.ContentHeight = 16;
			this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleCd.EditorHeight = 16;
			this.cmb_StyleCd.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.cmb_StyleCd.GapHeight = 2;
			this.cmb_StyleCd.ItemHeight = 15;
			this.cmb_StyleCd.Location = new System.Drawing.Point(521, 76);
			this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
			this.cmb_StyleCd.MaxLength = 32767;
			this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleCd.Name = "cmb_StyleCd";
			this.cmb_StyleCd.PartialRightColumn = false;
			this.cmb_StyleCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 8.25p" +
				"t;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}St" +
				"yle9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True" +
				";AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Cont" +
				"rol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.Li" +
				"stBoxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18" +
				"\" ColumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horiz" +
				"ontalScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>1" +
				"7</Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle " +
				"parent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><Foot" +
				"erStyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" />" +
				"<HeadingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"Highligh" +
				"tRow\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle " +
				"parent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"S" +
				"tyle10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" " +
				"me=\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\"" +
				" me=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=" +
				"\"Footer\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"In" +
				"active\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"High" +
				"lightRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"Odd" +
				"Row\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=" +
				"\"Group\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Lay" +
				"out>Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleCd.Size = new System.Drawing.Size(133, 20);
			this.cmb_StyleCd.TabIndex = 551;
			this.cmb_StyleCd.TextChanged += new System.EventHandler(this.cmb_StyleCd_TextChanged);
			// 
			// lbl_Style_Cd
			// 
			this.lbl_Style_Cd.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style_Cd.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Style_Cd.ImageIndex = 1;
			this.lbl_Style_Cd.ImageList = this.img_Label;
			this.lbl_Style_Cd.Location = new System.Drawing.Point(343, 76);
			this.lbl_Style_Cd.Name = "lbl_Style_Cd";
			this.lbl_Style_Cd.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_Cd.TabIndex = 181;
			this.lbl_Style_Cd.Text = "Style Code";
			this.lbl_Style_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// grp_Option
			// 
			this.grp_Option.BackColor = System.Drawing.Color.White;
			this.grp_Option.Controls.Add(this.rad_Style_Cd);
			this.grp_Option.Controls.Add(this.rad_Out_Sole);
			this.grp_Option.Controls.Add(this.rad_Factory);
			this.grp_Option.ForeColor = System.Drawing.Color.Black;
			this.grp_Option.Location = new System.Drawing.Point(674, 72);
			this.grp_Option.Name = "grp_Option";
			this.grp_Option.Size = new System.Drawing.Size(312, 32);
			this.grp_Option.TabIndex = 180;
			this.grp_Option.TabStop = false;
			// 
			// rad_Style_Cd
			// 
			this.rad_Style_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_Style_Cd.Location = new System.Drawing.Point(192, 8);
			this.rad_Style_Cd.Name = "rad_Style_Cd";
			this.rad_Style_Cd.Size = new System.Drawing.Size(73, 20);
			this.rad_Style_Cd.TabIndex = 186;
			this.rad_Style_Cd.Text = "Style";
			this.rad_Style_Cd.CheckedChanged += new System.EventHandler(this.rad_Style_Cd_CheckedChanged);
			// 
			// rad_Out_Sole
			// 
			this.rad_Out_Sole.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_Out_Sole.Location = new System.Drawing.Point(104, 9);
			this.rad_Out_Sole.Name = "rad_Out_Sole";
			this.rad_Out_Sole.Size = new System.Drawing.Size(73, 20);
			this.rad_Out_Sole.TabIndex = 185;
			this.rad_Out_Sole.Text = "OutSole";
			this.rad_Out_Sole.CheckedChanged += new System.EventHandler(this.rad_Out_Sole_CheckedChanged);
			// 
			// rad_Factory
			// 
			this.rad_Factory.Checked = true;
			this.rad_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rad_Factory.Location = new System.Drawing.Point(15, 9);
			this.rad_Factory.Name = "rad_Factory";
			this.rad_Factory.Size = new System.Drawing.Size(104, 20);
			this.rad_Factory.TabIndex = 184;
			this.rad_Factory.TabStop = true;
			this.rad_Factory.Text = "Factory";
			this.rad_Factory.CheckedChanged += new System.EventHandler(this.rad_Factory_CheckedChanged);
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
			this.cmb_OBS_ID_To.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID_To.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_To.EditorHeight = 15;
			this.cmb_OBS_ID_To.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_To.GapHeight = 2;
			this.cmb_OBS_ID_To.ItemHeight = 15;
			this.cmb_OBS_ID_To.Location = new System.Drawing.Point(233, 55);
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
			this.cmb_OBS_ID_To.Size = new System.Drawing.Size(95, 19);
			this.cmb_OBS_ID_To.TabIndex = 178;
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
			this.cmb_OBS_ID_From.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OBS_ID_From.EditorFont = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OBS_ID_From.EditorHeight = 15;
			this.cmb_OBS_ID_From.Font = new System.Drawing.Font("Verdana", 8F);
			this.cmb_OBS_ID_From.GapHeight = 2;
			this.cmb_OBS_ID_From.ItemHeight = 15;
			this.cmb_OBS_ID_From.Location = new System.Drawing.Point(117, 55);
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
			this.cmb_OBS_ID_From.Size = new System.Drawing.Size(95, 19);
			this.cmb_OBS_ID_From.TabIndex = 177;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8F);
			this.label1.ImageIndex = 1;
			this.label1.ImageList = this.img_Label;
			this.label1.Location = new System.Drawing.Point(16, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 21);
			this.label1.TabIndex = 176;
			this.label1.Text = "OBS ID";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(216, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 16);
			this.label2.TabIndex = 175;
			this.label2.Text = "~";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8F);
			this.label3.ImageIndex = 1;
			this.label3.ImageList = this.img_Label;
			this.label3.Location = new System.Drawing.Point(16, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 21);
			this.label3.TabIndex = 173;
			this.label3.Text = "Factory";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(210, 19);
			this.cmb_Factory.TabIndex = 174;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(974, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(22, 32);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(168, -1);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(812, 32);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(172, 32);
			this.lbl_SubTitle1.TabIndex = 0;
			this.lbl_SubTitle1.Text = "      Order Analysis";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(977, 32);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(19, 66);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.Color.Blue;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(906, 98);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(90, 14);
			this.pictureBox8.TabIndex = 8;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(32, 77);
			this.pictureBox7.TabIndex = 3;
			this.pictureBox7.TabStop = false;
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
			this.pictureBox10.Size = new System.Drawing.Size(948, 80);
			this.pictureBox10.TabIndex = 4;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox11.BackColor = System.Drawing.Color.Blue;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(0, 98);
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
			this.pictureBox12.Location = new System.Drawing.Point(72, 98);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(908, 14);
			this.pictureBox12.TabIndex = 9;
			this.pictureBox12.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.DockPadding.Left = 10;
			this.pnl_Body.DockPadding.Right = 10;
			this.pnl_Body.DockPadding.Top = 10;
			this.pnl_Body.Location = new System.Drawing.Point(0, 192);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 472);
			this.pnl_Body.TabIndex = 47;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.Color.White;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Main.Location = new System.Drawing.Point(10, 10);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(996, 462);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 36;
			// 
			// Form_EO_Analysis_II
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Form_EO_Analysis_II";
			this.Load += new System.EventHandler(this.Form_EO_Analysis_II_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Search.ResumeLayout(false);
			this.pnl_Search1_Image.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Code)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Gender)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Dev_Name)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Outsole)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Category)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
			this.grp_Option.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_To)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OBS_ID_From)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private COM.OraDB   MyOraDB = new COM.OraDB(); 



		#endregion 

		#region 공통메쏘드
		private void Init_Form()
		{ 
			DataTable dt_list;
		
			//Title
			this.Text = "Order Analysis";
			this.lbl_MainTitle.Text = "Order Analysis"; 
			ClassLib.ComFunction.SetLangDic(this);

		
			#region 버튼 컨트롤

			tbtn_Append.Enabled =false;
			tbtn_Color.Enabled  =false;
			tbtn_Create.Enabled=false;
			tbtn_Delete.Enabled =false;
			tbtn_Insert.Enabled =false;
			tbtn_New.Enabled  =true;
			tbtn_Print.Enabled =true;
			tbtn_Save.Enabled=false;
			tbtn_Search.Enabled =true;



			#endregion

			//그리드 설정(TBSEM_OBS_ANALYSIS_D)
			fgrid_Main.Set_Grid( "SEM_OBS_ANALYSIS", "2", 2, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch,false);			
			fgrid_Main.Font  = new Font("Verdana",8);
			fgrid_Main.AutoResize = false;

			// 공장설정
			dt_list = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComFunction.Set_ComboList(dt_list,cmb_Factory,0,1,false,COM.ComVar.ComboList_Visible.Code);
			//ClassLib.ComFunction.Set_Factory_List(dt_list,cmb_Factory,0,1,true,0);
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			//OBSID
			dt_list = Select_OBSID_List();
			if (dt_list.Rows.Count !=0)
			{
				ClassLib.ComFunction.Set_ComboList(dt_list,cmb_OBS_ID_From,0,0,false,COM.ComVar.ComboList_Visible.Name);
				ClassLib.ComFunction.Set_ComboList(dt_list,cmb_OBS_ID_To,0,0,false,COM.ComVar.ComboList_Visible.Name);
				cmb_OBS_ID_From.SelectedIndex =0;
				cmb_OBS_ID_To.SelectedIndex =0;
			}


			// CATEGORY
			dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"MD02");
			ClassLib.ComFunction.Set_ComboList(dt_list,cmb_Category,1,2,true,COM.ComVar.ComboList_Visible.Name);
			cmb_Category.SelectedIndex =0;


			
			// GENDER
			dt_list = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SEM01");
			ClassLib.ComFunction.Set_ComboList(dt_list,cmb_Gender,1,2,true,COM.ComVar.ComboList_Visible.Name);
			cmb_Gender.SelectedIndex =0;

			//Style
			dt_list  = Select_Data_List("SC");
			ClassLib.ComFunction.Set_ComboList_AddItem(dt_list, cmb_StyleCd, 0,1,true);
			cmb_StyleCd.Splits[0].DisplayColumns[0].Width = 65;
			cmb_StyleCd.Splits[0].DisplayColumns[1].Width = 250;
			cmb_StyleCd.SelectedIndex =0;


			//DevCode
			dt_list  = Select_Data_List("DC");
			ClassLib.ComFunction.Set_ComboList(dt_list, cmb_Dev_Code, 0,1,true,COM.ComVar.ComboList_Visible.Name);
			cmb_Dev_Code.SelectedIndex =0;

			//DevName
			dt_list  = Select_Data_List("DN");
			ClassLib.ComFunction.Set_ComboList_AddItem(dt_list, cmb_Dev_Name, 0,1,true);
			cmb_Dev_Name.Splits[0].DisplayColumns[0].Width = 65;
			cmb_Dev_Name.Splits[0].DisplayColumns[1].Width = 250;
			cmb_Dev_Name.SelectedIndex =0;

			//Outsole
			dt_list = Select_Data_List("ON");
			ClassLib.ComFunction.Set_ComboList(dt_list, cmb_Outsole, 0,1,true,COM.ComVar.ComboList_Visible.Name);
			cmb_Outsole.SelectedIndex =0;
			

			rad_Out_Sole.Checked  =  true;

		}


		private void Display_Order(DataTable arg_dt_title, DataTable arg_dt_data)
		{
			//fgrid_Main.Cols.Count  = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxSTYLE_CD+2;

			fgrid_Main.Rows.Count   = fgrid_Main.Rows.Fixed;
			fgrid_Main.Cols.Count   = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxTOT_QTY;


			for (int i =0 ;   i< arg_dt_title.Rows.Count ; i++)
			{				
				fgrid_Main.Cols.Count  = fgrid_Main.Cols.Count +3; 
				fgrid_Main.Cols[fgrid_Main.Cols.Count-1].Width = 80;
				
				fgrid_Main[1,fgrid_Main.Cols.Count-3] = arg_dt_title.Rows[i].ItemArray[1]; fgrid_Main.Cols[fgrid_Main.Cols.Count-3] .Format = "#,###.##";
				fgrid_Main[1,fgrid_Main.Cols.Count-2] = arg_dt_title.Rows[i].ItemArray[1]; fgrid_Main.Cols[fgrid_Main.Cols.Count-2] .Format = "#,###.##";
				fgrid_Main[1,fgrid_Main.Cols.Count-1] = arg_dt_title.Rows[i].ItemArray[1]; fgrid_Main.Cols[fgrid_Main.Cols.Count-1] .Format = "#,###.##";

				fgrid_Main[2,fgrid_Main.Cols.Count-3] = "Qty";
				fgrid_Main[2,fgrid_Main.Cols.Count-2] = "FOB($)";
				fgrid_Main[2,fgrid_Main.Cols.Count-1] = "Amount($)";


			}


			string  vStyle ="";
			for (int i =0 ;   i< arg_dt_data.Rows.Count ; i++)
			{			
				if (vStyle  != arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxSTYLE_CD-1].ToString())
				{
					
					fgrid_Main.Rows.Count = fgrid_Main.Rows.Count   +1;

					for (int  k=0 ;  k <= (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxOBSID ; k++)
					{
						fgrid_Main[fgrid_Main.Rows.Count -1,k+1 ] =  arg_dt_data.Rows[i].ItemArray[k].ToString();						

					}

					fgrid_Main[fgrid_Main.Rows.Count -1,(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxTOT_QTY ] ="";
					fgrid_Main[fgrid_Main.Rows.Count -1,(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxFOB ] ="";
					fgrid_Main[fgrid_Main.Rows.Count -1,(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxAMOUNT ] ="";

					
				}


				for (int j = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxTOT_QTY; j<=fgrid_Main.Cols.Count -1 ; j++)
				{
					if (fgrid_Main[1,j].ToString()  == arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxOBSID-1].ToString())
					{
                       fgrid_Main[fgrid_Main.Rows.Count -1,j]    = arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxTOT_QTY-1].ToString();
					   fgrid_Main[fgrid_Main.Rows.Count -1,j+1]  = arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxFOB-1].ToString();
					   fgrid_Main[fgrid_Main.Rows.Count -1,j+2]  = arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxAMOUNT-1].ToString();
					}
					j= j+2;
				}


			   vStyle = arg_dt_data.Rows[i].ItemArray[(int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxSTYLE_CD-1].ToString();


			}

		
		}


	

        private void Set_Subtotal()
        {



            fgrid_Main.AllowMerging = AllowMergingEnum.Free;
            fgrid_Main.Rows[1].AllowMerging = true;
            for (int i = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxFACTORY; i < (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxMODEL_NAME; i++)
                fgrid_Main.Cols[i].AllowMerging = true;



            CellStyle cStyle = fgrid_Main.Styles[CellStyleEnum.Subtotal0];
            cStyle.Font = new Font(fgrid_Main.Font, FontStyle.Regular);


            int iFactory = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxFACTORY;
            int iOutSole = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxOUT_SOLE;


            fgrid_Main.SubtotalPosition = SubtotalPositionEnum.AboveData;

            //BY Factory//OutSole
            fgrid_Main.Tree.Column = iFactory;

			int vCnt  =0;

			for (int c = (int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxSTYLE_CD +1; c < fgrid_Main.Cols.Count; c++)
            {

				fgrid_Main.Styles[CellStyleEnum.Subtotal1].Format = "#,###.##";
				fgrid_Main.Styles[CellStyleEnum.Subtotal4].Format = "#,###.##";

				if ( fgrid_Main[2,c].ToString() == "FOB($)" )
				{
					fgrid_Main.Subtotal(AggregateEnum.Average, iFactory, iFactory, c, "{0}");
					fgrid_Main.Subtotal(AggregateEnum.Average, iOutSole, iOutSole, c, "{0}");
					
				}
				else
				{

					fgrid_Main.Subtotal(AggregateEnum.Sum, iFactory, iFactory, c, "{0}");					
					fgrid_Main.Subtotal(AggregateEnum.Sum, iOutSole, iOutSole, c, "{0}");	
				

					
					
				}

				fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Red;
				fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = Color.Transparent;
				


				fgrid_Main.Styles[CellStyleEnum.Subtotal4].ForeColor = Color.Blue;
				fgrid_Main.Styles[CellStyleEnum.Subtotal4].BackColor = Color.Transparent;
				

				vCnt++;
				vCnt  =  (vCnt == 2) ?0: vCnt ;



            }
 

        }


		
		private void Set_Display_Option()
		{
			if  (rad_Factory.Checked     == true) fgrid_Main .Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxFACTORY);
			if  (rad_Out_Sole.Checked     == true) fgrid_Main.Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxOUT_SOLE);
			if  (rad_Style_Cd.Checked     == true) fgrid_Main.Tree.Show((int)ClassLib.TBSEM_OBS_ANALYSIS_D.lxSTYLE_CD);
	
		}



		private void  Set_Text_Clear()
		{
			txt_Dev_Code.Clear();
			txt_Dev_Name.Clear();
			txt_Outsole.Clear();
			txt_StyleCd.Clear();
		


		}
	



		#endregion 

		#region 이벤트처리

		private void cmb_Dev_Code_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (cmb_Dev_Code.SelectedIndex  == 0) return;

				txt_Dev_Code.Text = cmb_Dev_Code.SelectedValue.ToString();
			}
			catch
			{
			}

		}

		private void cmb_Dev_Name_TextChanged(object sender, System.EventArgs e)
		{
			try
		    {
				if (cmb_Dev_Name.SelectedIndex  == 0) return;
				txt_Dev_Name.Text = cmb_Dev_Name.SelectedValue.ToString();
			}
		    catch
			{

			}

		}

		private void cmb_Outsole_TextChanged(object sender, System.EventArgs e)
		{	
			try
			{
				if (cmb_Outsole.SelectedIndex  == 0) return;
				txt_Outsole.Text =  cmb_Outsole.SelectedValue.ToString();
			}
			catch
			{

			}
		}

		private void cmb_StyleCd_TextChanged(object sender, System.EventArgs e)
		{	
			try
			{
				if (cmb_StyleCd.SelectedIndex  == 0) return;
				txt_StyleCd.Text =  cmb_StyleCd.SelectedValue.ToString();
			}
			catch
			{

			}
		}


		
	


		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			cmb_Category.SelectedIndex =0;
			cmb_Dev_Code.SelectedIndex =0;
			cmb_Dev_Name.SelectedIndex =0;
			cmb_Gender.SelectedIndex=0;
			cmb_Outsole.SelectedIndex=0;
			cmb_StyleCd.SelectedIndex =0;

			txt_Dev_Code.Text ="";
			txt_Dev_Name.Text ="";
			txt_Outsole.Text ="";
			txt_StyleCd.Text ="";
			

			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
		}

	

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if (e.KeyCode!= Keys.Enter) return;

				DataTable vDT_Combo;
  
				vDT_Combo  = Select_Data_List("SC");

				ClassLib.ComFunction.Set_ComboList_AddItem(vDT_Combo, cmb_StyleCd, 0,1,true);
			}
			catch
			{

			}

		}


		
		private void txt_Dev_Code_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if (e.KeyCode!= Keys.Enter) return;

				DataTable vDT_Combo;
  
				vDT_Combo  = Select_Data_List("DC");

				ClassLib.ComFunction.Set_ComboList(vDT_Combo, cmb_Dev_Code, 0,1,true,COM.ComVar.ComboList_Visible.Name);
			}
			catch
			{

			}
		}


		private void txt_Outsole_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if (e.KeyCode!= Keys.Enter) return;

				DataTable vDT_Combo;
  
				vDT_Combo  = Select_Data_List("ON");

				ClassLib.ComFunction.Set_ComboList(vDT_Combo, cmb_Outsole, 0,1,true,COM.ComVar.ComboList_Visible.Name);
			}
			catch
			{

			}
		}



		private void txt_Dev_Name_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				
				if (e.KeyCode!= Keys.Enter) return;

				DataTable vDT_Combo;
  
				vDT_Combo  = Select_Data_List("DN");

				ClassLib.ComFunction.Set_ComboList_AddItem(vDT_Combo, cmb_Dev_Name, 0,1,true);
			}
			catch
			{

			}
		}

	



		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if (cmb_Factory.SelectedIndex  == -1) return;

			//OBSID
			DataTable   dt_list = Select_OBSID_List();
			if (dt_list.Rows.Count !=0)
			{
				ClassLib.ComFunction.Set_ComboList(dt_list,cmb_OBS_ID_From,0,0,false,COM.ComVar.ComboList_Visible.Name);
				cmb_OBS_ID_From.SelectedIndex =0;

				ClassLib.ComFunction.Set_ComboList(dt_list,cmb_OBS_ID_To,0,0,false,COM.ComVar.ComboList_Visible.Name);				
				cmb_OBS_ID_To.SelectedIndex =0;
			}


		}
//
//		
//		private void cmb_OBS_ID_To_SelectedValueChanged(object sender, System.EventArgs e)
//		{
//		
//			txt_StyleCd_KeyUp(null,null);
//
//
//
//		}
//
//		
//
//
//		private void cmb_OBS_ID_From_SelectedValueChanged(object sender, System.EventArgs e)
//		{
//			
//			
//			txt_StyleCd_KeyUp(null,null);
//
//		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			
			try
			{
				this.Cursor = Cursors.WaitCursor;
				DataTable  vDt_Title  = null,  vDt_Data =null;
				
					

				vDt_Title  = SELECT_ORDER_ANALYSIS_T();
				vDt_Data   = SELECT_ORDER_ANALYSIS_D();

				Display_Order(vDt_Title, vDt_Data);
				Set_Subtotal();

				Set_Display_Option();

				//Set_Text_Clear();
				this.Cursor = Cursors.Default;



			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(),  "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

			}
			finally
			{
				this.Cursor = Cursors.Default;

			}
		}



		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_Factory, cmb_OBS_ID_From, cmb_OBS_ID_To}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 
	
				if ( FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) 
				{
					
	
					string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_EO_Analysis_II");
	
					string sPara  = " /rp ";
					sPara += "[" + COM.ComFunction.Empty_Combo(cmb_Factory," ") +"] ";
					sPara += "[" + COM.ComFunction.Empty_String(cmb_OBS_ID_From.Text, " ")+"] ";
						sPara += "[" + COM.ComFunction.Empty_String(cmb_OBS_ID_To.Text, " ")+"] ";

					sPara += "[" +  ClassLib.ComFunction.Empty_Combo(cmb_Category," ")+"] ";
					sPara += "[" + ClassLib.ComFunction.Empty_Combo(cmb_Outsole," ")+"] ";
					sPara += "[" + ClassLib.ComFunction.Empty_Combo(cmb_Dev_Name," ")+"] ";

					sPara += "[" + ClassLib.ComFunction.Empty_Combo(cmb_Gender," ")+"] ";
					sPara += "[" + ClassLib.ComFunction.Empty_Combo(cmb_Dev_Code," ")+"] ";
					sPara += "[" + ClassLib.ComFunction.Empty_Combo(cmb_StyleCd," ")+"] ";



				//	string vCategory  = (cmb_Category.Text=="ALL")? " ":cmb_Category.Text;
					//string vDevName   = (cmb_Dev_Name.Text=="ALL")? " ":cmb_Dev_Name.Text;

				
					sPara += "[" +  ClassLib.ComFunction.Empty_String(cmb_Category.Text," ").Replace("ALL"," ")+"] ";
					sPara += "[" +  ClassLib.ComFunction.Empty_String(cmb_Dev_Name.Text," ").Replace("ALL"," ")+"] ";


					FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
	
					MyReport.Text = "Order Analysis";
					MyReport.Show();		
				}

		}

		

		private void rad_Out_Sole_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Display_Option();
		}

		private void rad_Factory_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Display_Option();
		}

		private void rad_Style_Cd_CheckedChanged(object sender, System.EventArgs e)
		{
			Set_Display_Option();
		}



		#endregion 

		#region DB 컨넥트

	/// <summary>
	/// SELECT_STYLE_LIST
	/// </summary>
	private DataTable Select_Data_List(string arg_div)
	{
		DataSet ds_ret;

		string process_name = "PKG_SEM_COMMON.SELECT_DATA_LIST";

		MyOraDB.ReDim_Parameter(5); 

		//01.PROCEDURE명
		MyOraDB.Process_Name = process_name;
 
		//02.ARGURMENT명 
		MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
		MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
		MyOraDB.Parameter_Name[2]  = "ARG_CODE";
		MyOraDB.Parameter_Name[3]  = "ARG_NAME";
		MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

		//03.DATA TYPE
		MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
		MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
		MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
		MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
		MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

		//04.DATA 정의  
		MyOraDB.Parameter_Values[0]  = arg_div;
		MyOraDB.Parameter_Values[1]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");

		switch (arg_div)
		{

			case "SC":
			{
				
				MyOraDB.Parameter_Values[2]  = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd," ").ToUpper();;
				MyOraDB.Parameter_Values[3]  = " ";
				break;
			}
			case "DC":
			{
				
				MyOraDB.Parameter_Values[2]  = ClassLib.ComFunction.Empty_TextBox(txt_Dev_Code," ").ToUpper();;
				MyOraDB.Parameter_Values[3]  = " ";
				break;
			}
			case "DN":
			{
				
				MyOraDB.Parameter_Values[2]  = " ";
				MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_TextBox(txt_Dev_Name," ").ToUpper();;
				break;
			}
			default:
			{
				
				MyOraDB.Parameter_Values[2]  = ClassLib.ComFunction.Empty_TextBox(txt_Outsole," ").ToUpper();;
				MyOraDB.Parameter_Values[3]  = " ";
				break;
			}

		}	
		MyOraDB.Parameter_Values[4]  =  "";
			


		MyOraDB.Add_Select_Parameter(true);
 
		ds_ret = MyOraDB.Exe_Select_Procedure();

		if(ds_ret == null) return null ;
			
		return ds_ret.Tables[process_name]; 

	}


		/// <summary>
		/// Select_Outsole_List()
		/// </summary>
		private DataTable Select_Outsole_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_COMMON.SELECT_BP_OUT_SOLE";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  =  "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}



		/// <summary>
		/// Select_Outsole_List()
		/// </summary>
		private DataTable Select_Model()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_COMMON.SELECT_SDC_MODEL";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  =  "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		/// <summary>
		/// Select_OBSID_List()
		/// </summary>
		private DataTable Select_OBSID_List()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_MNT.SELECT_OBSID_LIST";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = " "; //ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  =  "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}
		
		/// <summary>
		/// Select_Outsole_List()
		/// </summary>
		private DataTable Select_DevCode()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_COMMON.SELECT_SDC_DEV_CD";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  =  "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}






		/// <summary>
		/// SELECT_ORDER_ANALYSIS 
		/// </summary>
		private DataTable SELECT_ORDER_ANALYSIS_T()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_MNT.SELECT_SEM_OBS_ANALYSIS_T";

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[3]  = "ARG_CATEGORY";
			MyOraDB.Parameter_Name[4]  = "ARG_OUT_SOLE_01";
			MyOraDB.Parameter_Name[5]  = "ARG_MODEL_NAME";
			MyOraDB.Parameter_Name[6]  = "ARG_GEN";
			MyOraDB.Parameter_Name[7]  = "ARG_DEV_CD";
			MyOraDB.Parameter_Name[8]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[9]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[9]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID_From.Text;
			MyOraDB.Parameter_Values[2]  = cmb_OBS_ID_To.Text;
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_Category," ");
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_Combo(cmb_Outsole," ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_Combo(cmb_Dev_Name," ");
			MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_Combo(cmb_Gender," ");
			MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_Combo(cmb_Dev_Code," ");
			MyOraDB.Parameter_Values[8]  = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd," ");
			MyOraDB.Parameter_Values[9]  ="";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}




		/// <summary>
		/// SELECT_ORDER_ANALYSIS_D
		/// </summary>
		private DataTable SELECT_ORDER_ANALYSIS_D()
		{
			DataSet ds_ret;

			string process_name = "PKG_SEM_MNT.SELECT_SEM_OBS_ANALYSIS_D";

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 

			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_ID_FROM";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_ID_TO";
			MyOraDB.Parameter_Name[3]  = "ARG_CATEGORY";
			MyOraDB.Parameter_Name[4]  = "ARG_OUT_SOLE_01";
			MyOraDB.Parameter_Name[5]  = "ARG_MODEL_NAME";
			MyOraDB.Parameter_Name[6]  = "ARG_GEN";
			MyOraDB.Parameter_Name[7]  = "ARG_DEV_CD";
			MyOraDB.Parameter_Name[8]  = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[9]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[9]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComFunction.Empty_Combo(cmb_Factory," ");
			MyOraDB.Parameter_Values[1]  = cmb_OBS_ID_From.Text;
			MyOraDB.Parameter_Values[2]  = cmb_OBS_ID_To.Text;
			MyOraDB.Parameter_Values[3]  = ClassLib.ComFunction.Empty_Combo(cmb_Category," ");
			MyOraDB.Parameter_Values[4]  = ClassLib.ComFunction.Empty_Combo(cmb_Outsole," ");
			MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_Combo(cmb_Dev_Name," ");
			MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_Combo(cmb_Gender," ");
			MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_Combo(cmb_Dev_Code," ");
			MyOraDB.Parameter_Values[8]  = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd," ");
			MyOraDB.Parameter_Values[9]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		#endregion 
		
		private void Form_EO_Analysis_II_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
	}
}

