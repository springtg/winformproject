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

namespace FlexCDC.BaseInfo
{
	public class Pop_Material_Infomation : COM.CDCWinForm.Pop_Large
	{
		#region 컨트롤정의 및 리소스 정의

		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Button btn_Apply;
		private System.Windows.Forms.TabControl tab_Body;
		private System.Windows.Forms.TabPage tab_Part;
		private System.Windows.Forms.TabPage tab_Material;
		private System.Windows.Forms.TabPage tab_Specification;
		private System.Windows.Forms.TabPage tab_Color;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.TabPage tab_Mcs;
		private System.Windows.Forms.Panel pnl_Body;
		private System.Windows.Forms.Panel pnl_Information;
		private COM.FSP fgrid_Part;
		private COM.FSP fgrid_Material;
		private COM.FSP fgrid_Specification;
		private COM.FSP fgrid_Color;
		private COM.FSP fgrid_Mcs;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.Label lbl_Part;
		private System.Windows.Forms.Label lbl_Material;
		private System.Windows.Forms.TextBox txt_Spec_Desc;
		private System.Windows.Forms.TextBox txt_Sepc_Cd;
		private System.Windows.Forms.Label lbl_Spec;
		private System.Windows.Forms.TextBox txt_Color_Commnet;
		private System.Windows.Forms.TextBox txt_Color_Desc;
		private System.Windows.Forms.TextBox txt_Color_Cd;
		private System.Windows.Forms.Label lbl_Color;
		private System.Windows.Forms.TextBox txt_Mcs_Desc;
		private System.Windows.Forms.TextBox txt_Mcs_Cd;
		private System.Windows.Forms.Label lbl_Mcs;
		private System.Windows.Forms.TextBox txt_Mat_Name;
		private System.Windows.Forms.TextBox txt_Mat_Comment;
		private System.Windows.Forms.TextBox txt_Mat_Comment_Seq;
		private System.Windows.Forms.TextBox txt_Mat_Cd;
		private System.Windows.Forms.TextBox txt_Part_Seq;
		private System.Windows.Forms.TextBox txt_Part_Type;
		private System.Windows.Forms.TextBox txt_Part_Desc;


		#region 사전정의 변수
		private string _loadingfromtype ="";
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.TextBox txt_Mat_Description;
		private string _Fisrstloadingfromtype ="";
		#endregion 





		public Pop_Material_Infomation()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		
		public Pop_Material_Infomation( string arg_job_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_loadingfromtype  = arg_job_type;
			_Fisrstloadingfromtype = arg_job_type;
			
			 

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Material_Infomation));
			this.btn_Close = new System.Windows.Forms.Button();
			this.btn_Apply = new System.Windows.Forms.Button();
			this.pnl_Search = new System.Windows.Forms.Panel();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.lbl_Code = new System.Windows.Forms.Label();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.cmb_Factory = new C1.Win.C1List.C1Combo();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.pnl_Information = new System.Windows.Forms.Panel();
			this.txt_Part_Type = new System.Windows.Forms.TextBox();
			this.txt_Part_Seq = new System.Windows.Forms.TextBox();
			this.txt_Mat_Name = new System.Windows.Forms.TextBox();
			this.txt_Mat_Comment = new System.Windows.Forms.TextBox();
			this.txt_Mat_Comment_Seq = new System.Windows.Forms.TextBox();
			this.txt_Mat_Cd = new System.Windows.Forms.TextBox();
			this.txt_Mcs_Desc = new System.Windows.Forms.TextBox();
			this.txt_Mcs_Cd = new System.Windows.Forms.TextBox();
			this.lbl_Mcs = new System.Windows.Forms.Label();
			this.txt_Color_Commnet = new System.Windows.Forms.TextBox();
			this.txt_Color_Desc = new System.Windows.Forms.TextBox();
			this.txt_Color_Cd = new System.Windows.Forms.TextBox();
			this.lbl_Color = new System.Windows.Forms.Label();
			this.txt_Spec_Desc = new System.Windows.Forms.TextBox();
			this.txt_Sepc_Cd = new System.Windows.Forms.TextBox();
			this.lbl_Spec = new System.Windows.Forms.Label();
			this.txt_Part_Desc = new System.Windows.Forms.TextBox();
			this.lbl_Material = new System.Windows.Forms.Label();
			this.lbl_Part = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.tab_Body = new System.Windows.Forms.TabControl();
			this.tab_Part = new System.Windows.Forms.TabPage();
			this.fgrid_Part = new COM.FSP();
			this.tab_Material = new System.Windows.Forms.TabPage();
			this.fgrid_Material = new COM.FSP();
			this.tab_Specification = new System.Windows.Forms.TabPage();
			this.fgrid_Specification = new COM.FSP();
			this.tab_Color = new System.Windows.Forms.TabPage();
			this.fgrid_Color = new COM.FSP();
			this.tab_Mcs = new System.Windows.Forms.TabPage();
			this.fgrid_Mcs = new COM.FSP();
			this.txt_Mat_Description = new System.Windows.Forms.TextBox();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.pnl_Body.SuspendLayout();
			this.pnl_Information.SuspendLayout();
			this.tab_Body.SuspendLayout();
			this.tab_Part.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Part)).BeginInit();
			this.tab_Material.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Material)).BeginInit();
			this.tab_Specification.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Specification)).BeginInit();
			this.tab_Color.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).BeginInit();
			this.tab_Mcs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// btn_Close
			// 
			this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.btn_Close.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Close.Location = new System.Drawing.Point(368, 539);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(120, 25);
			this.btn_Close.TabIndex = 76;
			this.btn_Close.Text = "Close";
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.Location = new System.Drawing.Point(4, 539);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(120, 25);
			this.btn_Apply.TabIndex = 75;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(0, 24);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(496, 88);
			this.pnl_Search.TabIndex = 77;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_Code);
			this.pnl_SearchImage.Controls.Add(this.lbl_Code);
			this.pnl_SearchImage.Controls.Add(this.txt_Name);
			this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
			this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(480, 72);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_Code
			// 
			this.txt_Code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Code.ForeColor = System.Drawing.Color.Black;
			this.txt_Code.Location = new System.Drawing.Point(104, 47);
			this.txt_Code.MaxLength = 100;
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.Size = new System.Drawing.Size(124, 21);
			this.txt_Code.TabIndex = 381;
			this.txt_Code.Tag = "32";
			this.txt_Code.Text = "";
			this.txt_Code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Code_KeyPress);
			// 
			// lbl_Code
			// 
			this.lbl_Code.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Code.ImageIndex = 2;
			this.lbl_Code.ImageList = this.img_Label;
			this.lbl_Code.Location = new System.Drawing.Point(3, 47);
			this.lbl_Code.Name = "lbl_Code";
			this.lbl_Code.Size = new System.Drawing.Size(100, 21);
			this.lbl_Code.TabIndex = 380;
			this.lbl_Code.Tag = "1";
			this.lbl_Code.Text = "Code/Name";
			this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Name
			// 
			this.txt_Name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Name.ForeColor = System.Drawing.Color.Black;
			this.txt_Name.Location = new System.Drawing.Point(229, 47);
			this.txt_Name.MaxLength = 100;
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.ReadOnly = true;
			this.txt_Name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txt_Name.Size = new System.Drawing.Size(245, 21);
			this.txt_Name.TabIndex = 379;
			this.txt_Name.Text = "";
			this.txt_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Name_KeyPress);
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
			this.cmb_Factory.Location = new System.Drawing.Point(104, 25);
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
			this.cmb_Factory.Size = new System.Drawing.Size(124, 20);
			this.cmb_Factory.TabIndex = 35;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 1;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(3, 25);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 36;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(464, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(256, 32);
			this.picb_TM.TabIndex = 0;
			this.picb_TM.TabStop = false;
			// 
			// lbl_SubTitle1
			// 
			this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
			this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle1.Name = "lbl_SubTitle1";
			this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle1.TabIndex = 28;
			this.lbl_SubTitle1.Text = "      Bom Manager";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(464, 57);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 56);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(320, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 57);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 39);
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
			this.picb_MM.Size = new System.Drawing.Size(312, 32);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.pnl_Information);
			this.pnl_Body.Controls.Add(this.splitter1);
			this.pnl_Body.Controls.Add(this.tab_Body);
			this.pnl_Body.DockPadding.Left = 4;
			this.pnl_Body.DockPadding.Right = 4;
			this.pnl_Body.Location = new System.Drawing.Point(0, 112);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(496, 424);
			this.pnl_Body.TabIndex = 78;
			// 
			// pnl_Information
			// 
			this.pnl_Information.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pnl_Information.Controls.Add(this.txt_Mat_Description);
			this.pnl_Information.Controls.Add(this.txt_Part_Type);
			this.pnl_Information.Controls.Add(this.txt_Part_Seq);
			this.pnl_Information.Controls.Add(this.txt_Mat_Name);
			this.pnl_Information.Controls.Add(this.txt_Mat_Comment);
			this.pnl_Information.Controls.Add(this.txt_Mat_Comment_Seq);
			this.pnl_Information.Controls.Add(this.txt_Mat_Cd);
			this.pnl_Information.Controls.Add(this.txt_Mcs_Desc);
			this.pnl_Information.Controls.Add(this.txt_Mcs_Cd);
			this.pnl_Information.Controls.Add(this.lbl_Mcs);
			this.pnl_Information.Controls.Add(this.txt_Color_Commnet);
			this.pnl_Information.Controls.Add(this.txt_Color_Desc);
			this.pnl_Information.Controls.Add(this.txt_Color_Cd);
			this.pnl_Information.Controls.Add(this.lbl_Color);
			this.pnl_Information.Controls.Add(this.txt_Spec_Desc);
			this.pnl_Information.Controls.Add(this.txt_Sepc_Cd);
			this.pnl_Information.Controls.Add(this.lbl_Spec);
			this.pnl_Information.Controls.Add(this.txt_Part_Desc);
			this.pnl_Information.Controls.Add(this.lbl_Material);
			this.pnl_Information.Controls.Add(this.lbl_Part);
			this.pnl_Information.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Information.Location = new System.Drawing.Point(4, 203);
			this.pnl_Information.Name = "pnl_Information";
			this.pnl_Information.Size = new System.Drawing.Size(488, 221);
			this.pnl_Information.TabIndex = 4;
			// 
			// txt_Part_Type
			// 
			this.txt_Part_Type.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Part_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Part_Type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Part_Type.ForeColor = System.Drawing.Color.Black;
			this.txt_Part_Type.Location = new System.Drawing.Point(232, 8);
			this.txt_Part_Type.MaxLength = 100;
			this.txt_Part_Type.Name = "txt_Part_Type";
			this.txt_Part_Type.Size = new System.Drawing.Size(250, 21);
			this.txt_Part_Type.TabIndex = 423;
			this.txt_Part_Type.Tag = "32";
			this.txt_Part_Type.Text = "";
			// 
			// txt_Part_Seq
			// 
			this.txt_Part_Seq.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Part_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Part_Seq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Part_Seq.ForeColor = System.Drawing.Color.Black;
			this.txt_Part_Seq.Location = new System.Drawing.Point(107, 8);
			this.txt_Part_Seq.MaxLength = 100;
			this.txt_Part_Seq.Name = "txt_Part_Seq";
			this.txt_Part_Seq.Size = new System.Drawing.Size(124, 21);
			this.txt_Part_Seq.TabIndex = 422;
			this.txt_Part_Seq.Tag = "32";
			this.txt_Part_Seq.Text = "";
			// 
			// txt_Mat_Name
			// 
			this.txt_Mat_Name.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mat_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mat_Name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mat_Name.ForeColor = System.Drawing.Color.Black;
			this.txt_Mat_Name.Location = new System.Drawing.Point(357, 62);
			this.txt_Mat_Name.MaxLength = 100;
			this.txt_Mat_Name.Name = "txt_Mat_Name";
			this.txt_Mat_Name.Size = new System.Drawing.Size(124, 21);
			this.txt_Mat_Name.TabIndex = 421;
			this.txt_Mat_Name.Tag = "32";
			this.txt_Mat_Name.Text = "";
			// 
			// txt_Mat_Comment
			// 
			this.txt_Mat_Comment.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mat_Comment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mat_Comment.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mat_Comment.ForeColor = System.Drawing.Color.Black;
			this.txt_Mat_Comment.Location = new System.Drawing.Point(107, 84);
			this.txt_Mat_Comment.MaxLength = 100;
			this.txt_Mat_Comment.Name = "txt_Mat_Comment";
			this.txt_Mat_Comment.Size = new System.Drawing.Size(186, 21);
			this.txt_Mat_Comment.TabIndex = 420;
			this.txt_Mat_Comment.Tag = "32";
			this.txt_Mat_Comment.Text = "";
			// 
			// txt_Mat_Comment_Seq
			// 
			this.txt_Mat_Comment_Seq.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mat_Comment_Seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mat_Comment_Seq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mat_Comment_Seq.ForeColor = System.Drawing.Color.Black;
			this.txt_Mat_Comment_Seq.Location = new System.Drawing.Point(232, 62);
			this.txt_Mat_Comment_Seq.MaxLength = 100;
			this.txt_Mat_Comment_Seq.Name = "txt_Mat_Comment_Seq";
			this.txt_Mat_Comment_Seq.Size = new System.Drawing.Size(124, 21);
			this.txt_Mat_Comment_Seq.TabIndex = 419;
			this.txt_Mat_Comment_Seq.Tag = "32";
			this.txt_Mat_Comment_Seq.Text = "";
			// 
			// txt_Mat_Cd
			// 
			this.txt_Mat_Cd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mat_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mat_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mat_Cd.ForeColor = System.Drawing.Color.Black;
			this.txt_Mat_Cd.Location = new System.Drawing.Point(107, 62);
			this.txt_Mat_Cd.MaxLength = 100;
			this.txt_Mat_Cd.Name = "txt_Mat_Cd";
			this.txt_Mat_Cd.Size = new System.Drawing.Size(124, 21);
			this.txt_Mat_Cd.TabIndex = 418;
			this.txt_Mat_Cd.Tag = "32";
			this.txt_Mat_Cd.Text = "";
			// 
			// txt_Mcs_Desc
			// 
			this.txt_Mcs_Desc.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mcs_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mcs_Desc.ForeColor = System.Drawing.Color.Black;
			this.txt_Mcs_Desc.Location = new System.Drawing.Point(232, 192);
			this.txt_Mcs_Desc.MaxLength = 100;
			this.txt_Mcs_Desc.Name = "txt_Mcs_Desc";
			this.txt_Mcs_Desc.Size = new System.Drawing.Size(250, 21);
			this.txt_Mcs_Desc.TabIndex = 416;
			this.txt_Mcs_Desc.Tag = "32";
			this.txt_Mcs_Desc.Text = "";
			// 
			// txt_Mcs_Cd
			// 
			this.txt_Mcs_Cd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mcs_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mcs_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mcs_Cd.ForeColor = System.Drawing.Color.Black;
			this.txt_Mcs_Cd.Location = new System.Drawing.Point(107, 192);
			this.txt_Mcs_Cd.MaxLength = 100;
			this.txt_Mcs_Cd.Name = "txt_Mcs_Cd";
			this.txt_Mcs_Cd.Size = new System.Drawing.Size(124, 21);
			this.txt_Mcs_Cd.TabIndex = 415;
			this.txt_Mcs_Cd.Tag = "32";
			this.txt_Mcs_Cd.Text = "";
			// 
			// lbl_Mcs
			// 
			this.lbl_Mcs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Mcs.ImageIndex = 2;
			this.lbl_Mcs.ImageList = this.img_Label;
			this.lbl_Mcs.Location = new System.Drawing.Point(5, 192);
			this.lbl_Mcs.Name = "lbl_Mcs";
			this.lbl_Mcs.Size = new System.Drawing.Size(100, 21);
			this.lbl_Mcs.TabIndex = 414;
			this.lbl_Mcs.Tag = "1";
			this.lbl_Mcs.Text = "Mcs";
			this.lbl_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Color_Commnet
			// 
			this.txt_Color_Commnet.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Color_Commnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color_Commnet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Color_Commnet.ForeColor = System.Drawing.Color.Black;
			this.txt_Color_Commnet.Location = new System.Drawing.Point(107, 162);
			this.txt_Color_Commnet.MaxLength = 100;
			this.txt_Color_Commnet.Name = "txt_Color_Commnet";
			this.txt_Color_Commnet.Size = new System.Drawing.Size(375, 21);
			this.txt_Color_Commnet.TabIndex = 413;
			this.txt_Color_Commnet.Tag = "32";
			this.txt_Color_Commnet.Text = "";
			// 
			// txt_Color_Desc
			// 
			this.txt_Color_Desc.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Color_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Color_Desc.ForeColor = System.Drawing.Color.Black;
			this.txt_Color_Desc.Location = new System.Drawing.Point(232, 140);
			this.txt_Color_Desc.MaxLength = 100;
			this.txt_Color_Desc.Name = "txt_Color_Desc";
			this.txt_Color_Desc.Size = new System.Drawing.Size(250, 21);
			this.txt_Color_Desc.TabIndex = 412;
			this.txt_Color_Desc.Tag = "32";
			this.txt_Color_Desc.Text = "";
			// 
			// txt_Color_Cd
			// 
			this.txt_Color_Cd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Color_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Color_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Color_Cd.ForeColor = System.Drawing.Color.Black;
			this.txt_Color_Cd.Location = new System.Drawing.Point(107, 140);
			this.txt_Color_Cd.MaxLength = 100;
			this.txt_Color_Cd.Name = "txt_Color_Cd";
			this.txt_Color_Cd.Size = new System.Drawing.Size(124, 21);
			this.txt_Color_Cd.TabIndex = 411;
			this.txt_Color_Cd.Tag = "32";
			this.txt_Color_Cd.Text = "";
			// 
			// lbl_Color
			// 
			this.lbl_Color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Color.ImageIndex = 2;
			this.lbl_Color.ImageList = this.img_Label;
			this.lbl_Color.Location = new System.Drawing.Point(5, 140);
			this.lbl_Color.Name = "lbl_Color";
			this.lbl_Color.Size = new System.Drawing.Size(100, 21);
			this.lbl_Color.TabIndex = 410;
			this.lbl_Color.Tag = "1";
			this.lbl_Color.Text = "Color";
			this.lbl_Color.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Spec_Desc
			// 
			this.txt_Spec_Desc.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Spec_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Spec_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Spec_Desc.ForeColor = System.Drawing.Color.Black;
			this.txt_Spec_Desc.Location = new System.Drawing.Point(232, 112);
			this.txt_Spec_Desc.MaxLength = 100;
			this.txt_Spec_Desc.Name = "txt_Spec_Desc";
			this.txt_Spec_Desc.Size = new System.Drawing.Size(250, 21);
			this.txt_Spec_Desc.TabIndex = 409;
			this.txt_Spec_Desc.Tag = "32";
			this.txt_Spec_Desc.Text = "";
			// 
			// txt_Sepc_Cd
			// 
			this.txt_Sepc_Cd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Sepc_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Sepc_Cd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Sepc_Cd.ForeColor = System.Drawing.Color.Black;
			this.txt_Sepc_Cd.Location = new System.Drawing.Point(107, 112);
			this.txt_Sepc_Cd.MaxLength = 100;
			this.txt_Sepc_Cd.Name = "txt_Sepc_Cd";
			this.txt_Sepc_Cd.Size = new System.Drawing.Size(124, 21);
			this.txt_Sepc_Cd.TabIndex = 408;
			this.txt_Sepc_Cd.Tag = "32";
			this.txt_Sepc_Cd.Text = "";
			// 
			// lbl_Spec
			// 
			this.lbl_Spec.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Spec.ImageIndex = 2;
			this.lbl_Spec.ImageList = this.img_Label;
			this.lbl_Spec.Location = new System.Drawing.Point(5, 112);
			this.lbl_Spec.Name = "lbl_Spec";
			this.lbl_Spec.Size = new System.Drawing.Size(100, 21);
			this.lbl_Spec.TabIndex = 407;
			this.lbl_Spec.Tag = "1";
			this.lbl_Spec.Text = "Spec";
			this.lbl_Spec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Part_Desc
			// 
			this.txt_Part_Desc.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Part_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Part_Desc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Part_Desc.ForeColor = System.Drawing.Color.Black;
			this.txt_Part_Desc.Location = new System.Drawing.Point(107, 30);
			this.txt_Part_Desc.MaxLength = 100;
			this.txt_Part_Desc.Name = "txt_Part_Desc";
			this.txt_Part_Desc.Size = new System.Drawing.Size(375, 21);
			this.txt_Part_Desc.TabIndex = 406;
			this.txt_Part_Desc.Tag = "32";
			this.txt_Part_Desc.Text = "";
			// 
			// lbl_Material
			// 
			this.lbl_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Material.ImageIndex = 2;
			this.lbl_Material.ImageList = this.img_Label;
			this.lbl_Material.Location = new System.Drawing.Point(5, 60);
			this.lbl_Material.Name = "lbl_Material";
			this.lbl_Material.Size = new System.Drawing.Size(100, 21);
			this.lbl_Material.TabIndex = 403;
			this.lbl_Material.Tag = "1";
			this.lbl_Material.Text = "Material";
			this.lbl_Material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Part
			// 
			this.lbl_Part.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Part.ImageIndex = 2;
			this.lbl_Part.ImageList = this.img_Label;
			this.lbl_Part.Location = new System.Drawing.Point(5, 8);
			this.lbl_Part.Name = "lbl_Part";
			this.lbl_Part.Size = new System.Drawing.Size(100, 21);
			this.lbl_Part.TabIndex = 399;
			this.lbl_Part.Tag = "1";
			this.lbl_Part.Text = "Part";
			this.lbl_Part.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
			this.splitter1.Location = new System.Drawing.Point(4, 200);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(488, 3);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// tab_Body
			// 
			this.tab_Body.Controls.Add(this.tab_Part);
			this.tab_Body.Controls.Add(this.tab_Material);
			this.tab_Body.Controls.Add(this.tab_Specification);
			this.tab_Body.Controls.Add(this.tab_Color);
			this.tab_Body.Controls.Add(this.tab_Mcs);
			this.tab_Body.Dock = System.Windows.Forms.DockStyle.Top;
			this.tab_Body.Location = new System.Drawing.Point(4, 0);
			this.tab_Body.Name = "tab_Body";
			this.tab_Body.SelectedIndex = 0;
			this.tab_Body.Size = new System.Drawing.Size(488, 200);
			this.tab_Body.TabIndex = 2;
			this.tab_Body.SelectedIndexChanged += new System.EventHandler(this.tab_Body_SelectedIndexChanged);
			// 
			// tab_Part
			// 
			this.tab_Part.BackColor = System.Drawing.SystemColors.Window;
			this.tab_Part.Controls.Add(this.fgrid_Part);
			this.tab_Part.Location = new System.Drawing.Point(4, 21);
			this.tab_Part.Name = "tab_Part";
			this.tab_Part.Size = new System.Drawing.Size(480, 175);
			this.tab_Part.TabIndex = 1;
			this.tab_Part.Tag = "Part";
			this.tab_Part.Text = "Part";
			// 
			// fgrid_Part
			// 
			this.fgrid_Part.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Part.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Part.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Part.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Part.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Part.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Part.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Part.Name = "fgrid_Part";
			this.fgrid_Part.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Part.Size = new System.Drawing.Size(480, 175);
			this.fgrid_Part.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Part.TabIndex = 105;
			this.fgrid_Part.DoubleClick += new System.EventHandler(this.fgrid_Part_DoubleClick);
			// 
			// tab_Material
			// 
			this.tab_Material.BackColor = System.Drawing.SystemColors.Window;
			this.tab_Material.Controls.Add(this.fgrid_Material);
			this.tab_Material.Location = new System.Drawing.Point(4, 21);
			this.tab_Material.Name = "tab_Material";
			this.tab_Material.Size = new System.Drawing.Size(480, 175);
			this.tab_Material.TabIndex = 2;
			this.tab_Material.Tag = "_Material";
			this.tab_Material.Text = "Material";
			this.tab_Material.Visible = false;
			// 
			// fgrid_Material
			// 
			this.fgrid_Material.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Material.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Material.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Material.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Material.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Material.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Material.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Material.Name = "fgrid_Material";
			this.fgrid_Material.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Material.Size = new System.Drawing.Size(480, 175);
			this.fgrid_Material.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Material.TabIndex = 105;
			this.fgrid_Material.DoubleClick += new System.EventHandler(this.fgrid_Material_DoubleClick);
			// 
			// tab_Specification
			// 
			this.tab_Specification.BackColor = System.Drawing.SystemColors.Window;
			this.tab_Specification.Controls.Add(this.fgrid_Specification);
			this.tab_Specification.Location = new System.Drawing.Point(4, 21);
			this.tab_Specification.Name = "tab_Specification";
			this.tab_Specification.Size = new System.Drawing.Size(480, 175);
			this.tab_Specification.TabIndex = 3;
			this.tab_Specification.Tag = "_Specification";
			this.tab_Specification.Text = "Specification";
			this.tab_Specification.Visible = false;
			// 
			// fgrid_Specification
			// 
			this.fgrid_Specification.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Specification.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Specification.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Specification.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Specification.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Specification.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Specification.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Specification.Name = "fgrid_Specification";
			this.fgrid_Specification.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Specification.Size = new System.Drawing.Size(480, 175);
			this.fgrid_Specification.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Specification.TabIndex = 105;
			this.fgrid_Specification.DoubleClick += new System.EventHandler(this.fgrid_Specification_DoubleClick);
			// 
			// tab_Color
			// 
			this.tab_Color.BackColor = System.Drawing.SystemColors.Window;
			this.tab_Color.Controls.Add(this.fgrid_Color);
			this.tab_Color.Location = new System.Drawing.Point(4, 21);
			this.tab_Color.Name = "tab_Color";
			this.tab_Color.Size = new System.Drawing.Size(480, 175);
			this.tab_Color.TabIndex = 4;
			this.tab_Color.Tag = "Color";
			this.tab_Color.Text = "Color";
			this.tab_Color.Visible = false;
			// 
			// fgrid_Color
			// 
			this.fgrid_Color.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Color.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Color.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Color.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Color.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Color.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Color.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Color.Name = "fgrid_Color";
			this.fgrid_Color.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Color.Size = new System.Drawing.Size(480, 175);
			this.fgrid_Color.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Color.TabIndex = 105;
			this.fgrid_Color.DoubleClick += new System.EventHandler(this.fgrid_Color_DoubleClick);
			// 
			// tab_Mcs
			// 
			this.tab_Mcs.BackColor = System.Drawing.SystemColors.Window;
			this.tab_Mcs.Controls.Add(this.fgrid_Mcs);
			this.tab_Mcs.Location = new System.Drawing.Point(4, 21);
			this.tab_Mcs.Name = "tab_Mcs";
			this.tab_Mcs.Size = new System.Drawing.Size(480, 175);
			this.tab_Mcs.TabIndex = 5;
			this.tab_Mcs.Tag = "Mcs";
			this.tab_Mcs.Text = "Mcs";
			// 
			// fgrid_Mcs
			// 
			this.fgrid_Mcs.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Mcs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Mcs.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Mcs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Mcs.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Mcs.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Mcs.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Mcs.Name = "fgrid_Mcs";
			this.fgrid_Mcs.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Mcs.Size = new System.Drawing.Size(480, 175);
			this.fgrid_Mcs.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Mcs.TabIndex = 105;
			this.fgrid_Mcs.DoubleClick += new System.EventHandler(this.fgrid_Mcs_DoubleClick);
			// 
			// txt_Mat_Description
			// 
			this.txt_Mat_Description.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Mat_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Mat_Description.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_Mat_Description.ForeColor = System.Drawing.Color.Black;
			this.txt_Mat_Description.Location = new System.Drawing.Point(295, 84);
			this.txt_Mat_Description.MaxLength = 100;
			this.txt_Mat_Description.Name = "txt_Mat_Description";
			this.txt_Mat_Description.Size = new System.Drawing.Size(186, 21);
			this.txt_Mat_Description.TabIndex = 424;
			this.txt_Mat_Description.Tag = "32";
			this.txt_Mat_Description.Text = "";
			// 
			// Pop_Material_Infomation
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(494, 568);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_Search);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Apply);
			this.Name = "Pop_Material_Infomation";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Material_Infomation_Closing);
			this.Load += new System.EventHandler(this.Pop_Material_Infomation_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.pnl_Body.ResumeLayout(false);
			this.pnl_Information.ResumeLayout(false);
			this.tab_Body.ResumeLayout(false);
			this.tab_Part.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Part)).EndInit();
			this.tab_Material.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Material)).EndInit();
			this.tab_Specification.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Specification)).EndInit();
			this.tab_Color.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Color)).EndInit();
			this.tab_Mcs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수
		private COM.OraDB MyOraDB = new COM.OraDB();
        int _PartIndex  =0, _MaterialIndex =1, _SpecIndex= 2, _ColorIndex = 3, _McsIndex = 4;

		public static string  _ReturnData="";
		

		#endregion

		#region 공통메쏘드

		private void Init_Form()
		{
			try
			{
				this.Text = "Material Information";
				this.lbl_MainTitle.Text = "Material Information";
				ClassLib.ComFunction.SetLangDic(this); 
			  

				DataTable  dt_list;
			
				// Factory Combobox Add Items
				dt_list = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
				
				
				Set_Grid();
		
				//tab위치잡기...


			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}


		}


		private void Set_Grid()
		{

			fgrid_Part.Rows.Count =fgrid_Part.Rows.Fixed;
			fgrid_Material.Rows.Count =fgrid_Material.Rows.Fixed;
			fgrid_Specification.Rows.Count =fgrid_Specification.Rows.Fixed;
			fgrid_Color.Rows.Count =fgrid_Color.Rows.Fixed;
			fgrid_Mcs.Rows.Count =fgrid_Mcs.Rows.Fixed;
			


			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
					
					fgrid_Part.Set_Grid("SXD_SRF_M_PART", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Part.Set_Action_Image(img_Action);
					fgrid_Part.Font = new Font("Verdana", 8);
					tab_Body.SelectedIndex = _PartIndex;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
					
					fgrid_Material.Set_Grid("SXD_SRF_M_MAT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Material.Set_Action_Image(img_Action);
					fgrid_Material.Font = new Font("Verdana", 8);
					tab_Body.SelectedIndex = _MaterialIndex;


					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
					
					fgrid_Specification.Set_Grid("SXD_SRF_M_SPEC", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Specification.Set_Action_Image(img_Action);
					fgrid_Specification.Font = new Font("Verdana", 8);
					tab_Body.SelectedIndex = _SpecIndex;


					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
					
					fgrid_Color.Set_Grid("SXD_SRF_M_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Color.Set_Action_Image(img_Action);
					fgrid_Color.Font = new Font("Verdana", 8);
					tab_Body.SelectedIndex = _ColorIndex;

					//tab_Color.Select();


					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
					
					fgrid_Mcs.Set_Grid("SXD_SRF_M_MCS", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Mcs.Set_Action_Image(img_Action);
					fgrid_Mcs.Font = new Font("Verdana", 8);
					tab_Body.SelectedIndex = _McsIndex;


					return;
				}
				default :
				{
					
					fgrid_Part.Set_Grid("SXD_SRF_M_PART", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Part.Set_Action_Image(img_Action);
					fgrid_Part.Font = new Font("Verdana", 8);

					fgrid_Material.Set_Grid("SXD_SRF_M_MAT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Material.Set_Action_Image(img_Action);
					fgrid_Material.Font = new Font("Verdana", 8);

					fgrid_Specification.Set_Grid("SXD_SRF_M_SPEC", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Specification.Set_Action_Image(img_Action);
					fgrid_Specification.Font = new Font("Verdana", 8);

					
					fgrid_Color.Set_Grid("SXD_SRF_M_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Color.Set_Action_Image(img_Action);
					fgrid_Color.Font = new Font("Verdana", 8);

					fgrid_Mcs.Set_Grid("SXD_SRF_M_MCS", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Mcs.Set_Action_Image(img_Action);
					fgrid_Mcs.Font = new Font("Verdana", 8);

					tab_Body.SelectedIndex = _PartIndex;


					if ((_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_MatInfo_Type) && (_loadingfromtype  == ClassLib.ComVar.ConsCDC_MatInfo_Type)) 
						_loadingfromtype = ClassLib.ComVar.ConsCDC_MatInfo_Type_Part;

					return;
				}
			}



		

		

		}


		private void Select_Data_List()
		{
			DataTable dt_list ; 

			fgrid_Part.Rows.Count =fgrid_Part.Rows.Fixed;
			fgrid_Material.Rows.Count =fgrid_Material.Rows.Fixed;
			fgrid_Specification.Rows.Count =fgrid_Specification.Rows.Fixed;
			fgrid_Color.Rows.Count =fgrid_Color.Rows.Fixed;
			fgrid_Mcs.Rows.Count =fgrid_Mcs.Rows.Fixed;

			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
				
					dt_list = Select_SRF_M_Part();
					Display_Grid(dt_list, fgrid_Part); 

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
				
					dt_list = Select_SRF_M_Material();
					Display_Grid(dt_list, fgrid_Material) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
				
					dt_list = Select_SRF_M_Spec();
					Display_Grid(dt_list, fgrid_Specification) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
				
					dt_list = Select_SRF_M_Color();
					Display_Grid(dt_list, fgrid_Color) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
				
					dt_list = Select_SRF_M_Mcs();
					Display_Grid(dt_list, fgrid_Mcs) ;

					return;
				}
				default:
				{

					if (tab_Body.SelectedIndex == _PartIndex) {dt_list = Select_SRF_M_Part(); Display_Grid(dt_list, fgrid_Part);}
					if (tab_Body.SelectedIndex == _MaterialIndex) {dt_list = Select_SRF_M_Material();Display_Grid(dt_list, fgrid_Material) ;}
					if (tab_Body.SelectedIndex == _SpecIndex) {dt_list = Select_SRF_M_Spec();Display_Grid(dt_list, fgrid_Specification) ;}
					if (tab_Body.SelectedIndex == _ColorIndex) {dt_list = Select_SRF_M_Color();	Display_Grid(dt_list, fgrid_Color) ;}
					if (tab_Body.SelectedIndex == _McsIndex) {dt_list = Select_SRF_M_Mcs();Display_Grid(dt_list, fgrid_Mcs) ;}
					
					return;
				}

			}
		

		}

		private void Display_Grid( DataTable arg_dt, COM.FSP arg_grid)
		{

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_grid.AddItem(arg_dt.Rows[i].ItemArray, arg_grid.Rows.Count, 1);
				arg_grid[arg_grid.Rows.Count - 1, 0] = ""; 
			}


		}

		
		private void Display_Property()
		{
			
			

			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
					if (fgrid_Part.Selection.r1 < fgrid_Part.Rows.Fixed ) return;
					
					txt_Part_Seq.Text = fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_SEQ].ToString();
					txt_Part_Type.Text = fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_TYPE].ToString();
				    txt_Part_Desc.Text =  fgrid_Part[fgrid_Part.Selection.r1, (int)ClassLib.SXD_SRF_M_PART_POP.lxPART_DESC].ToString();

					txt_Part_Seq.Tag =  txt_Part_Seq.Text;
					txt_Part_Type.Tag = txt_Part_Type.Text;
					txt_Part_Desc.Tag = txt_Part_Desc.Text;
					
					if (_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_LoadingFrom_Type)
					{_loadingfromtype  = ClassLib.ComVar.ConsCDC_MatInfo_Type_Material ;tab_Body.SelectedIndex ++; return;}

					tab_Body.SelectedIndex = _PartIndex; 
					return;

				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
					if (fgrid_Material.Selection.r1 < fgrid_Material.Rows.Fixed ) return;

					txt_Mat_Cd.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_CD].ToString();
					txt_Mat_Comment_Seq.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_COMMENT_SEQ].ToString();
					txt_Mat_Name.Text = fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_NAME].ToString();
					txt_Mat_Comment.Text =  fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_COMMENT].ToString();
					txt_Mat_Description.Text =  fgrid_Material[fgrid_Material.Selection.r1, (int)ClassLib.SXD_SRF_M_MATERIAL_POP.lxMAT_DESC].ToString();

					txt_Part_Seq.Tag =  txt_Part_Seq.Text;
					txt_Mat_Comment_Seq.Tag =  txt_Mat_Comment_Seq.Text;
					txt_Mat_Name.Tag =  txt_Mat_Name.Text;
					txt_Mat_Comment.Tag =  txt_Mat_Comment.Text;
					txt_Mat_Description.Tag =  txt_Mat_Description.Text;

					if (_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_LoadingFrom_Type)  
					{_loadingfromtype  = ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec ;tab_Body.SelectedIndex ++;return;}
					tab_Body.SelectedIndex = _MaterialIndex; return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
					if (fgrid_Specification.Selection.r1 < fgrid_Specification.Rows.Fixed ) return;

					txt_Sepc_Cd.Text  = fgrid_Specification[fgrid_Specification.Selection.r1, (int)ClassLib.SXD_SRF_M_SPEC_POP.lxSPEC_CD].ToString();
					txt_Spec_Desc.Text  = fgrid_Specification[fgrid_Specification.Selection.r1, (int)ClassLib.SXD_SRF_M_SPEC_POP.lxSPEC_DESC].ToString();

					txt_Sepc_Cd.Tag =  txt_Sepc_Cd.Text;
					txt_Spec_Desc.Tag =  txt_Spec_Desc.Text;

					if (_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_LoadingFrom_Type)  
					{_loadingfromtype  = ClassLib.ComVar.ConsCDC_MatInfo_Type_Color ; tab_Body.SelectedIndex ++;return;}
					tab_Body.SelectedIndex = _SpecIndex; return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
					if (fgrid_Color.Selection.r1 < fgrid_Color.Rows.Fixed ) return;

					
					txt_Color_Cd.Text  = fgrid_Color[fgrid_Color.Selection.r1, (int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_CD].ToString();
					txt_Color_Desc.Text  = fgrid_Color[fgrid_Color.Selection.r1, (int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_DESC].ToString();
					txt_Color_Commnet.Text  = fgrid_Color[fgrid_Color.Selection.r1, (int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_COMMENT].ToString();

					txt_Color_Cd.Tag =  txt_Color_Cd.Text;
					txt_Color_Desc.Tag =  txt_Color_Desc.Text;
					txt_Color_Commnet.Tag =  txt_Color_Commnet.Text;

					if (_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_LoadingFrom_Type)  
					{_loadingfromtype  = ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs ; tab_Body.SelectedIndex ++;return;}
					tab_Body.SelectedIndex = _ColorIndex; return;

				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
					if (fgrid_Mcs.Selection.r1 < fgrid_Mcs.Rows.Fixed ) return;

					txt_Mcs_Cd.Text  = fgrid_Mcs[fgrid_Mcs.Selection.r1, (int)ClassLib.SXD_SRF_M_MCS_POP.lxMCS_CD].ToString();
					txt_Mcs_Desc.Text  = fgrid_Mcs[fgrid_Mcs.Selection.r1, (int)ClassLib.SXD_SRF_M_MCS_POP.lxMCS_DESC].ToString();				

					txt_Mcs_Cd.Tag =  txt_Mcs_Cd.Text;
					txt_Mcs_Desc.Tag =  txt_Mcs_Desc.Text;

					if (_Fisrstloadingfromtype  == ClassLib.ComVar.ConsCDC_LoadingFrom_Type)  
					{_loadingfromtype  = ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs ;tab_Body.SelectedIndex =0;return;}
					tab_Body.SelectedIndex = _McsIndex; return;

				}
				default:
				{

//					if ((fgrid_Part.Selection.r1 < fgrid_Part.Rows.Fixed )|| (fgrid_Material.Selection.r1 < fgrid_Material.Rows.Fixed ) ||
//                        (fgrid_Specification.Selection.r1 < fgrid_Specification.Rows.Fixed )|| (fgrid_Color.Selection.r1 < fgrid_Color.Rows.Fixed )||
//						(fgrid_Mcs.Selection.r1 < fgrid_Mcs.Rows.Fixed )) return;
//
//					if  (tab_Body.SelectedIndex ==  _McsIndex)   tab_Body.SelectedIndex = _PartIndex;
//					else  tab_Body.SelectedIndex += tab_Body.SelectedIndex ;
//
//
//					//이런씨~~~
				

					return;

				}

			}


			

		}



		#endregion

		#region 이벤트처리

		private void txt_Code_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{

//				if ( (txt_Code.Text  == "")  && (txt_Name.Text=="") )
//				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsNotHaveData,this); return;}

				this.Cursor = Cursors.WaitCursor;

				if(e.KeyChar == (char)13)  Select_Data_List();

			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(), "txt_Code_KeyPress", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}


		private void txt_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			try
			{

				if ( (txt_Code.Text  == "")  && (txt_Name.Text=="") )
				{ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsNotHaveData,this); return;}


				this.Cursor = Cursors.WaitCursor;

				if(e.KeyChar == (char)13)  Select_Data_List();

			}
			catch(Exception ex)
			{

				ClassLib.ComFunction.User_Message(ex.ToString(), "txt_Code_KeyPress", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		
		private void fgrid_Part_DoubleClick(object sender, System.EventArgs e)
		{
			Display_Property();
			txt_Code.Clear();
			txt_Name.Clear();
		}



		private void fgrid_Material_DoubleClick(object sender, System.EventArgs e)
		{
		
			Display_Property();
			txt_Code.Clear();
			txt_Name.Clear();
		}

		private void fgrid_Specification_DoubleClick(object sender, System.EventArgs e)
		{
		
			Display_Property();
			txt_Code.Clear();
			txt_Name.Clear();
		}

		private void fgrid_Color_DoubleClick(object sender, System.EventArgs e)
		{
		
			Display_Property();
			txt_Code.Clear();
			txt_Name.Clear();
		}

		private void fgrid_Mcs_DoubleClick(object sender, System.EventArgs e)
		{
		
			Display_Property();
			txt_Code.Clear();
			txt_Name.Clear();
		}

	




		private void tab_Body_SelectedIndexChanged(object sender, System.EventArgs e)
		{

			return;

//			try
//			{
//				if (_Fisrstloadingfromtype  != ClassLib.ComVar.ConsCDC_LoadingFrom_Type) return;
//
//				
//				}
//
//			}
//			catch(Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.ToString(), "tab_Body_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
//
//			}


		}

		#endregion

		#region DB컨넥트

		
		private DataTable  Select_SRF_M_Part()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_PART";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_PART_SEQ";
			MyOraDB.Parameter_Name[a++] = "ARG_PART_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}



		
		private DataTable  Select_SRF_M_Material()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MAT";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_MAT_NAME";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}



	

		
		private DataTable  Select_SRF_M_Spec()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_SPEC";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_SPEC_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}



		
		private DataTable  Select_SRF_M_Color()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_COLOR";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_COLOR_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}



		private DataTable  Select_SRF_M_Mcs()
		{

			int vCount = 4, a=0, b=0;
			string  Proc_Name= "PKG_SXB_BASE_02.SELECT_SXD_SRF_M_MCS";

			MyOraDB.ReDim_Parameter(vCount);
			MyOraDB.Process_Name  = Proc_Name;

			MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[a++] = "ARG_MCS_CD";
			MyOraDB.Parameter_Name[a++] = "ARG_MCS_DESC";
			MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";


			for (int i =0 ; i< vCount-1 ; i++)
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  

			MyOraDB.Parameter_Type[vCount-1] = (int)OracleType.Cursor;
			
			

			MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Code," ");
			MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_TextBox(txt_Name," ");
			MyOraDB.Parameter_Values[b++] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];

		}




		#endregion

		private void Pop_Material_Infomation_Load(object sender, System.EventArgs e)
		{

			Init_Form();
		
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			
			COM.ComVar.This_Return =" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^";
			this.Close();
		
		}

		private void Pop_Material_Infomation_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (COM.ComVar.This_Return == "")
		  		COM.ComVar.This_Return= " "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^"+" "+"^";
			
			this.Close();
		}




		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.This_Return ="";


			//Part_seq  -0, Part_Type  - 1, Part_Desc -2, Mat_cd -3, Mat_Comment_Seq -4,Mat_Description - 5 
			//Mat_Name -6, Mat_Comment -7, Spec_cd  -8, Spec_desc -9, Color_cd -10, Color_desc - 11, Color_Commnet -12,
			//Mcs_cd -13, Mcs_name - 14;

			COM.ComVar.This_Return =ClassLib.ComFunction.Empty_TextBox(txt_Part_Seq," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Part_Type," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Part_Desc," ")+"^" + 			
						ClassLib.ComFunction.Empty_TextBox(txt_Mat_Cd," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Mat_Comment_Seq," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Mat_Name," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Mat_Comment," ")+"^" + 
					    ClassLib.ComFunction.Empty_TextBox(txt_Mat_Description," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Sepc_Cd," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Spec_Desc," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Color_Cd," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Color_Desc," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Color_Commnet," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Mcs_Cd," ")+"^" + 
						ClassLib.ComFunction.Empty_TextBox(txt_Mcs_Desc," ");




			this.Close();



		}

		

	}
}

