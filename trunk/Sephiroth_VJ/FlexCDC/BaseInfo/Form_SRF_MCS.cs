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
using System.Threading;
namespace FlexCDC.BaseInfo
{
	public class Form_SRF_MCS : COM.CDCWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정의
		public System.Windows.Forms.Panel pnl_Top;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_openfile;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_title;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.TextBox txt_MCS_Code;
		private System.Windows.Forms.TextBox txt_MCS_Desc;
		private System.Windows.Forms.Label lbl_MCSCode;
		private System.Windows.Forms.Label lbl_MCSDesc;
		private System.ComponentModel.IContainer components = null;

		public Form_SRF_MCS()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_SRF_MCS));
			this.pnl_Top = new System.Windows.Forms.Panel();
			this.lbl_MCSCode = new System.Windows.Forms.Label();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_factory = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_MCS_Desc = new System.Windows.Forms.TextBox();
			this.txt_MCS_Code = new System.Windows.Forms.TextBox();
			this.lbl_MCSDesc = new System.Windows.Forms.Label();
			this.btn_openfile = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_title = new System.Windows.Forms.Label();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Main = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			// c1CommandLink1
			// 
			this.c1CommandLink1.ToolTipText = "Clear";
			// 
			// tbtn_New
			// 
			this.tbtn_New.Text = "";
			this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
			// 
			// c1CommandLink2
			// 
			this.c1CommandLink2.ToolTipText = "Search";
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Text = "";
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// c1CommandLink3
			// 
			this.c1CommandLink3.ToolTipText = "Save";
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Text = "";
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// tbtn_Append
			// 
			this.tbtn_Append.Text = "";
			// 
			// tbtn_Insert
			// 
			this.tbtn_Insert.Text = "";
			// 
			// tbtn_Delete
			// 
			this.tbtn_Delete.Text = "";
			this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// c1CommandLink8
			// 
			this.c1CommandLink8.Text = "Confirm";
			// 
			// tbtn_Color
			// 
			this.tbtn_Color.Text = "";
			// 
			// c1CommandLink6
			// 
			this.c1CommandLink6.ToolTipText = "Delete";
			// 
			// tbtn_Print
			// 
			this.tbtn_Print.Text = "";
			// 
			// pnl_Top
			// 
			this.pnl_Top.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Top.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Top.Controls.Add(this.lbl_MCSCode);
			this.pnl_Top.Controls.Add(this.cmb_Factory);
			this.pnl_Top.Controls.Add(this.lbl_factory);
			this.pnl_Top.Controls.Add(this.pnl_SearchImage);
			this.pnl_Top.DockPadding.Bottom = 8;
			this.pnl_Top.DockPadding.Left = 8;
			this.pnl_Top.DockPadding.Right = 8;
			this.pnl_Top.Location = new System.Drawing.Point(0, 64);
			this.pnl_Top.Name = "pnl_Top";
			this.pnl_Top.Size = new System.Drawing.Size(1016, 80);
			this.pnl_Top.TabIndex = 137;
			// 
			// lbl_MCSCode
			// 
			this.lbl_MCSCode.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_MCSCode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MCSCode.ImageIndex = 0;
			this.lbl_MCSCode.ImageList = this.img_Label;
			this.lbl_MCSCode.Location = new System.Drawing.Point(352, 35);
			this.lbl_MCSCode.Name = "lbl_MCSCode";
			this.lbl_MCSCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_MCSCode.TabIndex = 344;
			this.lbl_MCSCode.Tag = "1";
			this.lbl_MCSCode.Text = "MCS Code";
			this.lbl_MCSCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.cmb_Factory.ContentHeight = 16;
			this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory.EditorHeight = 16;
			this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory.GapHeight = 2;
			this.cmb_Factory.ItemHeight = 15;
			this.cmb_Factory.Location = new System.Drawing.Point(117, 35);
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
				"8.25pt, style=Bold;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackCo" +
				"lor:Highlight;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}" +
				"Heading{Wrap:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlTe" +
				"xt;BackColor:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits>" +
				"<C1.Win.C1List.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" Col" +
				"umnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizontal" +
				"ScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Wi" +
				"dth></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle paren" +
				"t=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterSty" +
				"le parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><Head" +
				"ingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\"" +
				" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle paren" +
				"t=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style1" +
				"0\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"S" +
				"tyle1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"" +
				"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Foot" +
				"er\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactiv" +
				"e\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlight" +
				"Row\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" " +
				"/><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Grou" +
				"p\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>M" +
				"odified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory.Size = new System.Drawing.Size(200, 20);
			this.cmb_Factory.TabIndex = 272;
			this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
			// 
			// lbl_factory
			// 
			this.lbl_factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_factory.ImageIndex = 0;
			this.lbl_factory.ImageList = this.img_Label;
			this.lbl_factory.Location = new System.Drawing.Point(16, 35);
			this.lbl_factory.Name = "lbl_factory";
			this.lbl_factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_factory.TabIndex = 271;
			this.lbl_factory.Tag = "0";
			this.lbl_factory.Text = "Factory";
			this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_MCS_Desc);
			this.pnl_SearchImage.Controls.Add(this.txt_MCS_Code);
			this.pnl_SearchImage.Controls.Add(this.lbl_MCSDesc);
			this.pnl_SearchImage.Controls.Add(this.btn_openfile);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.pictureBox2);
			this.pnl_SearchImage.Controls.Add(this.pictureBox4);
			this.pnl_SearchImage.Controls.Add(this.pictureBox5);
			this.pnl_SearchImage.Controls.Add(this.pictureBox6);
			this.pnl_SearchImage.Controls.Add(this.pictureBox7);
			this.pnl_SearchImage.Controls.Add(this.pictureBox8);
			this.pnl_SearchImage.Controls.Add(this.pictureBox9);
			this.pnl_SearchImage.Controls.Add(this.pictureBox3);
			this.pnl_SearchImage.Controls.Add(this.lbl_title);
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 72);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_MCS_Desc
			// 
			this.txt_MCS_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MCS_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_MCS_Desc.Location = new System.Drawing.Point(789, 35);
			this.txt_MCS_Desc.Name = "txt_MCS_Desc";
			this.txt_MCS_Desc.Size = new System.Drawing.Size(200, 21);
			this.txt_MCS_Desc.TabIndex = 545;
			this.txt_MCS_Desc.Text = "";
			// 
			// txt_MCS_Code
			// 
			this.txt_MCS_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MCS_Code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_MCS_Code.Location = new System.Drawing.Point(445, 35);
			this.txt_MCS_Code.Name = "txt_MCS_Code";
			this.txt_MCS_Code.Size = new System.Drawing.Size(200, 21);
			this.txt_MCS_Code.TabIndex = 544;
			this.txt_MCS_Code.Text = "";
			// 
			// lbl_MCSDesc
			// 
			this.lbl_MCSDesc.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_MCSDesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MCSDesc.ImageIndex = 0;
			this.lbl_MCSDesc.ImageList = this.img_Label;
			this.lbl_MCSDesc.Location = new System.Drawing.Point(688, 35);
			this.lbl_MCSDesc.Name = "lbl_MCSDesc";
			this.lbl_MCSDesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_MCSDesc.TabIndex = 542;
			this.lbl_MCSDesc.Tag = "1";
			this.lbl_MCSDesc.Text = "MCS Desc";
			this.lbl_MCSDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.picb_MR.Size = new System.Drawing.Size(24, 29);
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
			this.pictureBox4.Location = new System.Drawing.Point(984, 57);
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
			this.pictureBox5.Location = new System.Drawing.Point(136, 56);
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
			this.pictureBox6.Location = new System.Drawing.Point(0, 57);
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 39);
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
			this.pictureBox8.Location = new System.Drawing.Point(152, 24);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(1000, 32);
			this.pictureBox8.TabIndex = 27;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(472, 72);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(1000, 32);
			this.pictureBox9.TabIndex = 27;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(1000, 40);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
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
			this.lbl_title.Text = "        MCS Information";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_Body
			// 
			this.pnl_Body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Main);
			this.pnl_Body.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Body.Location = new System.Drawing.Point(0, 144);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(1016, 499);
			this.pnl_Body.TabIndex = 138;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_Main.AutoResize = false;
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.None;
			this.fgrid_Main.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.Rows.Fixed = 0;
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(1016, 499);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 318;
			this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// Form_SRF_MCS
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Top);
			this.Name = "Form_SRF_MCS";
			this.Load += new System.EventHandler(this.Form_SRF_MCS_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.pnl_Top, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수 

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 공통 메서드 
		
		private void Init_Form()
		{
			
			this.Text = "PCC_Mcs Master";
			this.lbl_MainTitle.Text = "PCC_Mcs Master";
			this.lbl_title.Text = "      Mcs Information";

			ClassLib.ComFunction.SetLangDic(this);

			#region Button Setting			
			tbtn_Create.Enabled  = false;
			tbtn_Append.Enabled  = false;
			tbtn_Insert.Enabled  = false;
			tbtn_Color.Enabled   = false;
			tbtn_Print.Enabled   = false;
            tbtn_Delete.Enabled = false;
            tbtn_Save.Enabled = false;
			#endregion				

			#region Grid Setting			 
			fgrid_Main.Set_Grid_CDC("SXD_SRF_M_MCS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			fgrid_Main.Set_Action_Image(img_Action);
			fgrid_Main.Font =new Font("Verdana", 8);
			#endregion

			#region TextBox Setting			
			txt_MCS_Code.CharacterCasing = CharacterCasing.Upper;
			txt_MCS_Desc.CharacterCasing = CharacterCasing.Upper;
			txt_MCS_Code.Focus();
			#endregion

		}

		private void Display_Grid(DataTable arg_list, COM.FSP arg_fgrid)
		{
			
			fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;
			
			for(int i=0; i< arg_list.Rows.Count  ; i++)
			{			
				
				arg_fgrid.AddItem(arg_list.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);				
			

				#region Use YN Setting
				if( arg_list.Rows[i].ItemArray[ (int)ClassLib.TBSXD_SRF_M_MCS.IxUSE_YN-1 ].ToString() == ClassLib.ComVar.ConsCDC_N )
				{					
					arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 1, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor
						=ClassLib.ComVar.Clr_Text_Red;
				}
				#endregion				

			}			

		}
		

		#endregion		

		#region 이벤트 처리 
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				if(cmb_Factory.SelectedIndex == -1)
					return;

				COM.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();

				Init_Form();
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
		
		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			}

		}

		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_Main.Update_Row();
		}
				
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Init_Form();
			txt_MCS_Code.Clear();
			txt_MCS_Desc.Clear();

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{
				this.Cursor = Cursors.WaitCursor;
				fgrid_Main.Rows.Count  = fgrid_Main.Rows.Fixed;				
				
				DataTable dt_ret = Select_Item( cmb_Factory.SelectedValue.ToString(), txt_MCS_Code.Text, txt_MCS_Code.Text );
				Display_Grid(dt_ret, fgrid_Main); 					
				
				dt_ret.Dispose();	
			}
			catch
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSearch, this);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
  
				for(int i = fgrid_Main.Rows.Fixed ; i < fgrid_Main.Rows.Count ;i++)
				{
					if(fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_MCS.IxDIVISION] != null && fgrid_Main[ i, (int)ClassLib.TBSXD_SRF_M_MCS.IxDIVISION].ToString() != "")										
						Update_Item(i);					
					
					fgrid_Main[i,0] = "";	
				}
			}
			catch
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
		
		}
		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			fgrid_Main.Delete_Row();		
		}


		#endregion

		#region DB Connect

		private DataTable Select_Item(string arg_factory,string arg_mcs_cd, string arg_mcs_desc)
		{
			

			DataSet ds_list;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MCS";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MCS_CD";
			MyOraDB.Parameter_Name[2] = "ARG_MCS_DESC";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_MCS_Code, arg_mcs_cd);
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_TextBox(txt_MCS_Desc, arg_mcs_desc);
			MyOraDB.Parameter_Values[3] = "";



			MyOraDB.Add_Select_Parameter(true);
			ds_list = MyOraDB.Exe_Select_Procedure();			

			return ds_list.Tables[MyOraDB.Process_Name];

		}

		private void Update_Item(int row_cnt)
		{

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SXB_BASE_02.SAVE_SXD_SRF_M_MCS";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_MCS_CD";
			MyOraDB.Parameter_Name[3]  = "ARG_MCS_DESC";			
			MyOraDB.Parameter_Name[4]  = "ARG_USE_YN";
			MyOraDB.Parameter_Name[5]  = "ARG_SEND_CHK";
			MyOraDB.Parameter_Name[6]  = "ARG_SEND_YMD";
			MyOraDB.Parameter_Name[7] = "ARG_STATUS";
			MyOraDB.Parameter_Name[8] = "ARG_UPD_USER";
			

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;			

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxDIVISION] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxDIVISION].ToString();
			MyOraDB.Parameter_Values[1] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxFACTORY] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxFACTORY].ToString();
			MyOraDB.Parameter_Values[2] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxMCS_CD] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxMCS_CD].ToString();
			MyOraDB.Parameter_Values[3] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxMCS_DESC] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxMCS_DESC].ToString();			
			MyOraDB.Parameter_Values[4] = (fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxUSE_YN] == null)? "" :fgrid_Main[row_cnt, (int)ClassLib.TBSXD_SRF_M_MCS.IxUSE_YN].ToString(); 
			MyOraDB.Parameter_Values[5] = "";
			MyOraDB.Parameter_Values[6] = "";
			MyOraDB.Parameter_Values[7] = "";
			MyOraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;
			
			MyOraDB.Add_Modify_Parameter(true);
			DataSet ds_list = MyOraDB.Exe_Modify_Procedure();		

			
		}		
		#endregion 
		
		private void Form_SRF_MCS_Load(object sender, System.EventArgs e)
		{
			try
			{
				//factory 
				DataTable dt_list = COM.ComFunction.Select_Factory_List_CDC();
				COM.ComCtl.Set_Factory_List(dt_list, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;			
			}
			catch
			{

			}
		}

		
	}
}

