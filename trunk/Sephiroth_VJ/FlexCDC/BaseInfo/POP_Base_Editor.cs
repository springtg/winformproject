using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;

namespace FlexCDC.BaseInfo
{
	public class Pop_Base_Editor : COM.PCHWinForm.Pop_Medium
	{
		public System.Windows.Forms.Panel pnl_Search;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.TextBox txt_Name;
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
		private System.Windows.Forms.Panel panel1;



		#region 로딩변수

		private  string _loadingfromtype ="";


		#endregion 


		private COM.FSP fgrid_Base;


		#region 컨트롤정의 및 리소스 관리
		private System.ComponentModel.IContainer components = null;

		public Pop_Base_Editor()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		
		public Pop_Base_Editor( string arg_edit_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_loadingfromtype  = arg_edit_type;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Base_Editor));
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.fgrid_Base = new COM.FSP();
			this.pnl_Search.SuspendLayout();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Base)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(472, 23);
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pnl_Search
			// 
			this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Search.Controls.Add(this.pnl_SearchImage);
			this.pnl_Search.DockPadding.All = 8;
			this.pnl_Search.Location = new System.Drawing.Point(8, 32);
			this.pnl_Search.Name = "pnl_Search";
			this.pnl_Search.Size = new System.Drawing.Size(488, 88);
			this.pnl_Search.TabIndex = 79;
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
			this.pnl_SearchImage.Size = new System.Drawing.Size(472, 72);
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
			this.txt_Name.Size = new System.Drawing.Size(219, 21);
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
			this.picb_TR.Location = new System.Drawing.Point(456, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(248, 32);
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
			this.picb_BR.Location = new System.Drawing.Point(456, 57);
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
			this.picb_BM.Size = new System.Drawing.Size(312, 18);
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
			this.picb_MM.Size = new System.Drawing.Size(304, 32);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.fgrid_Base);
			this.panel1.Location = new System.Drawing.Point(8, 120);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(488, 304);
			this.panel1.TabIndex = 80;
			// 
			// fgrid_Base
			// 
			this.fgrid_Base.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Base.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Base.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Base.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Base.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Base.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Base.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Base.Name = "fgrid_Base";
			this.fgrid_Base.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Base.Size = new System.Drawing.Size(488, 304);
			this.fgrid_Base.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Base.TabIndex = 107;
			this.fgrid_Base.DoubleClick += new System.EventHandler(this.fgrid_Base_DoubleClick);
			// 
			// Pop_Base_Editor
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(506, 440);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnl_Search);
			this.Name = "Pop_Base_Editor";
			this.Load += new System.EventHandler(this.Pop_Base_Editor_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Search, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.pnl_Search.ResumeLayout(false);
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Base)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 상용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		int _PartIndex  =0, _MaterialIndex =1, _SpecIndex= 2, _ColorIndex = 3, _McsIndex = 4;

		public static string  _ReturnData="";
		
		#endregion




		#region 공통메쏘드
		private void Init_Form()
		{
			try
			{
				
				DataTable  dt_list;
			
				// Factory Combobox Add Items
				dt_list = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(dt_list, cmb_Factory, 0, 1, false);
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
				cmb_Factory.Enabled  = false;
				
				
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

			
			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
					
					fgrid_Base.Set_Grid("SXD_SRF_M_PART", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Part.Set_Action_Image(img_Action);
					fgrid_Base.Font = new Font("Verdana", 8);
	
					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
					
					fgrid_Base.Set_Grid("SXD_SRF_M_MAT", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Material.Set_Action_Image(img_Action);
					fgrid_Base.Font = new Font("Verdana", 8);
	

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
					
					fgrid_Base.Set_Grid("SXD_SRF_M_SPEC", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Specification.Set_Action_Image(img_Action);
					fgrid_Base.Font = new Font("Verdana", 8);

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
					
					fgrid_Base.Set_Grid("SXD_SRF_M_COLOR", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Color.Set_Action_Image(img_Action);
					fgrid_Base.Font = new Font("Verdana", 8);

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
					
					fgrid_Base.Set_Grid("SXD_SRF_M_MCS", "2", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
					//fgrid_Mcs.Set_Action_Image(img_Action);
					fgrid_Base.Font = new Font("Verdana", 8);


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





		
		private void Select_Data_List()
		{
			DataTable dt_list ; 

			fgrid_Base.Rows.Count =fgrid_Base.Rows.Fixed;


			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
				
					dt_list = Select_SRF_M_Part();
					Display_Grid(dt_list, fgrid_Base); 

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
				
					dt_list = Select_SRF_M_Material();
					Display_Grid(dt_list, fgrid_Base) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
				
					dt_list = Select_SRF_M_Spec();
					Display_Grid(dt_list, fgrid_Base) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
				
					dt_list = Select_SRF_M_Color();
					Display_Grid(dt_list, fgrid_Base) ;

					return;
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
				
					dt_list = Select_SRF_M_Mcs();
					Display_Grid(dt_list, fgrid_Base) ;

					return;
				}
				default:
				{

					
					return;
				}

			}
		

		}




		#endregion 

		#region 이벤트처리

		private void fgrid_Base_DoubleClick(object sender, System.EventArgs e)
		{

		


			switch(_loadingfromtype)
			{

				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Part :
				{
					

					COM.ComVar.This_Return ="";
					
					break;
				  
					
				

				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Material :
				{
				
					
					COM.ComVar.This_Return ="";
					
					break;
				
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Spec :
				{
				
					COM.ComVar.This_Return =fgrid_Base[fgrid_Base.Selection.r1,(int)ClassLib.SXD_SRF_M_SPEC_POP.lxSPEC_CD].ToString() + "^"+ 
						fgrid_Base[fgrid_Base.Selection.r1,(int)ClassLib.SXD_SRF_M_SPEC_POP.lxSPEC_DESC].ToString();

					
					break;

					
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Color :
				{
				
					
					COM.ComVar.This_Return =fgrid_Base[fgrid_Base.Selection.r1,(int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_CD].ToString() + "^"+ 
						fgrid_Base[fgrid_Base.Selection.r1,(int)ClassLib.SXD_SRF_M_COLOR_POP.lxCOLOR_DESC].ToString();


					
					break;

			
				}
				case ClassLib.ComVar.ConsCDC_MatInfo_Type_Mcs :
				{
				
					COM.ComVar.This_Return ="";
					
					break;
					
				}
				default:
				{

					
					break;


				}

			

			}


			this.Close();

		

		}



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



		#endregion 

		#region  DB컨트롤
		
		
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



		private void Pop_Base_Editor_Load(object sender, System.EventArgs e)
		{
			Init_Form();

		}


		




	}
}

