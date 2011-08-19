using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Reflection;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PC_Date_Set : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리 

		public System.Windows.Forms.Panel pnl_SearchImage;
		private System.Windows.Forms.Label btn_PopPgId;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private System.Windows.Forms.Label btn_cel;
		private System.Windows.Forms.Label btn_ok;
		public System.Windows.Forms.Panel pnl_Semlpe;
		private System.Windows.Forms.Label lbl_sdate_view;
		private System.Windows.Forms.Label lbl_sdate_sign;
		private System.Windows.Forms.Label lbl_sdate_type;
		private System.Windows.Forms.TextBox txt_sdate_view;
		private C1.Win.C1List.C1Combo cmb_sdate_sign;
		private C1.Win.C1List.C1Combo cmb_sdate_type;

		#region 변수
		
		private string factory = "VJ";//임시 공장 변수
		private DataTable dt_list;


		private int _cmbdatecode = 1;
		private int _cmbdatename = 2;


		//공통코드 컬럼 index
		private int _tablevalue = 1;
		private int _tabletext = 2;



		#endregion
		
		
		
		private System.ComponentModel.IContainer components = null;

		public Pop_PC_Date_Set()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PC_Date_Set));
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.txt_sdate_view = new System.Windows.Forms.TextBox();
			this.btn_PopPgId = new System.Windows.Forms.Label();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.lbl_sdate_view = new System.Windows.Forms.Label();
			this.cmb_sdate_sign = new C1.Win.C1List.C1Combo();
			this.cmb_sdate_type = new C1.Win.C1List.C1Combo();
			this.lbl_sdate_sign = new System.Windows.Forms.Label();
			this.lbl_sdate_type = new System.Windows.Forms.Label();
			this.btn_cel = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Label();
			this.pnl_SearchImage.SuspendLayout();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sdate_sign)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sdate_type)).BeginInit();
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
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.txt_sdate_view);
			this.pnl_SearchImage.Controls.Add(this.btn_PopPgId);
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BR);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_BL);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(376, 144);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// txt_sdate_view
			// 
			this.txt_sdate_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sdate_view.Location = new System.Drawing.Point(111, 112);
			this.txt_sdate_view.Name = "txt_sdate_view";
			this.txt_sdate_view.Size = new System.Drawing.Size(255, 21);
			this.txt_sdate_view.TabIndex = 35;
			this.txt_sdate_view.Text = "";
			// 
			// btn_PopPgId
			// 
			this.btn_PopPgId.Location = new System.Drawing.Point(412, 36);
			this.btn_PopPgId.Name = "btn_PopPgId";
			this.btn_PopPgId.Size = new System.Drawing.Size(21, 21);
			this.btn_PopPgId.TabIndex = 34;
			this.btn_PopPgId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(361, 24);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 104);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(360, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(152, 32);
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
			this.lbl_SubTitle1.Text = "      Date Type";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(360, 128);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 126);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(216, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(0, 124);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 104);
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
			this.picb_MM.Size = new System.Drawing.Size(208, 104);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.lbl_sdate_view);
			this.pnl_Semlpe.Controls.Add(this.cmb_sdate_sign);
			this.pnl_Semlpe.Controls.Add(this.cmb_sdate_type);
			this.pnl_Semlpe.Controls.Add(this.lbl_sdate_sign);
			this.pnl_Semlpe.Controls.Add(this.lbl_sdate_type);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(8, 40);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(376, 144);
			this.pnl_Semlpe.TabIndex = 33;
			// 
			// lbl_sdate_view
			// 
			this.lbl_sdate_view.ImageIndex = 0;
			this.lbl_sdate_view.ImageList = this.img_Label;
			this.lbl_sdate_view.Location = new System.Drawing.Point(10, 112);
			this.lbl_sdate_view.Name = "lbl_sdate_view";
			this.lbl_sdate_view.Size = new System.Drawing.Size(100, 21);
			this.lbl_sdate_view.TabIndex = 76;
			this.lbl_sdate_view.Text = "보기";
			this.lbl_sdate_view.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_sdate_sign
			// 
			this.cmb_sdate_sign.AddItemCols = 0;
			this.cmb_sdate_sign.AddItemSeparator = ';';
			this.cmb_sdate_sign.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_sdate_sign.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_sdate_sign.Caption = "";
			this.cmb_sdate_sign.CaptionHeight = 17;
			this.cmb_sdate_sign.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_sdate_sign.ColumnCaptionHeight = 18;
			this.cmb_sdate_sign.ColumnFooterHeight = 18;
			this.cmb_sdate_sign.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_sdate_sign.ContentHeight = 17;
			this.cmb_sdate_sign.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_sdate_sign.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_sdate_sign.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sdate_sign.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_sdate_sign.EditorHeight = 17;
			this.cmb_sdate_sign.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sdate_sign.GapHeight = 2;
			this.cmb_sdate_sign.ItemHeight = 15;
			this.cmb_sdate_sign.Location = new System.Drawing.Point(111, 58);
			this.cmb_sdate_sign.MatchEntryTimeout = ((long)(2000));
			this.cmb_sdate_sign.MaxDropDownItems = ((short)(5));
			this.cmb_sdate_sign.MaxLength = 32767;
			this.cmb_sdate_sign.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_sdate_sign.Name = "cmb_sdate_sign";
			this.cmb_sdate_sign.PartialRightColumn = false;
			this.cmb_sdate_sign.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_sdate_sign.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_sdate_sign.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_sdate_sign.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_sdate_sign.Size = new System.Drawing.Size(255, 21);
			this.cmb_sdate_sign.TabIndex = 75;
			// 
			// cmb_sdate_type
			// 
			this.cmb_sdate_type.AddItemCols = 0;
			this.cmb_sdate_type.AddItemSeparator = ';';
			this.cmb_sdate_type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_sdate_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_sdate_type.Caption = "";
			this.cmb_sdate_type.CaptionHeight = 17;
			this.cmb_sdate_type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_sdate_type.ColumnCaptionHeight = 18;
			this.cmb_sdate_type.ColumnFooterHeight = 18;
			this.cmb_sdate_type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_sdate_type.ContentHeight = 17;
			this.cmb_sdate_type.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_sdate_type.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_sdate_type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sdate_type.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_sdate_type.EditorHeight = 17;
			this.cmb_sdate_type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_sdate_type.GapHeight = 2;
			this.cmb_sdate_type.ItemHeight = 15;
			this.cmb_sdate_type.Location = new System.Drawing.Point(111, 36);
			this.cmb_sdate_type.MatchEntryTimeout = ((long)(2000));
			this.cmb_sdate_type.MaxDropDownItems = ((short)(5));
			this.cmb_sdate_type.MaxLength = 32767;
			this.cmb_sdate_type.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_sdate_type.Name = "cmb_sdate_type";
			this.cmb_sdate_type.PartialRightColumn = false;
			this.cmb_sdate_type.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_sdate_type.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_sdate_type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_sdate_type.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_sdate_type.Size = new System.Drawing.Size(255, 21);
			this.cmb_sdate_type.TabIndex = 74;
			// 
			// lbl_sdate_sign
			// 
			this.lbl_sdate_sign.ImageIndex = 0;
			this.lbl_sdate_sign.ImageList = this.img_Label;
			this.lbl_sdate_sign.Location = new System.Drawing.Point(10, 58);
			this.lbl_sdate_sign.Name = "lbl_sdate_sign";
			this.lbl_sdate_sign.Size = new System.Drawing.Size(100, 21);
			this.lbl_sdate_sign.TabIndex = 71;
			this.lbl_sdate_sign.Text = "날짜 구분 기호";
			this.lbl_sdate_sign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_sdate_type
			// 
			this.lbl_sdate_type.ImageIndex = 0;
			this.lbl_sdate_type.ImageList = this.img_Label;
			this.lbl_sdate_type.Location = new System.Drawing.Point(10, 36);
			this.lbl_sdate_type.Name = "lbl_sdate_type";
			this.lbl_sdate_type.Size = new System.Drawing.Size(100, 21);
			this.lbl_sdate_type.TabIndex = 70;
			this.lbl_sdate_type.Text = "간단한 날짜형";
			this.lbl_sdate_type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_cel
			// 
			this.btn_cel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_cel.ImageIndex = 0;
			this.btn_cel.ImageList = this.img_Button;
			this.btn_cel.Location = new System.Drawing.Point(314, 192);
			this.btn_cel.Name = "btn_cel";
			this.btn_cel.Size = new System.Drawing.Size(70, 23);
			this.btn_cel.TabIndex = 67;
			this.btn_cel.Text = "취소";
			this.btn_cel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_cel.Click += new System.EventHandler(this.btn_cel_Click);
			// 
			// btn_ok
			// 
			this.btn_ok.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_ok.ImageIndex = 0;
			this.btn_ok.ImageList = this.img_Button;
			this.btn_ok.Location = new System.Drawing.Point(239, 192);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(70, 23);
			this.btn_ok.TabIndex = 68;
			this.btn_ok.Text = "확인";
			this.btn_ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
			// 
			// Pop_PC_Date_Set
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 222);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.btn_cel);
			this.Controls.Add(this.pnl_Semlpe);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
			this.Name = "Pop_PC_Date_Set";
			this.Text = "Set Data Type";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Date_Set_Closing);
			this.Load += new System.EventHandler(this.Pop_Date_Set_Load);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			this.Controls.SetChildIndex(this.btn_cel, 0);
			this.Controls.SetChildIndex(this.btn_ok, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.pnl_SearchImage.ResumeLayout(false);
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_sdate_sign)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_sdate_type)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion	



		#region 변수

		private COM.OraDB oraDB = null;

		#endregion

		#region 멤버 정의
		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			this.Text = "Set Date Type";
			this.lbl_MainTitle.Text = "Set DateType";

			ClassLib.ComFunction.SetLangDic(this);


			oraDB = new COM.OraDB();


			//간단한 날짜 형식 불러오기
			dt_list = ClassLib.ComVar.Select_ComCode(factory,ClassLib.ComVar.CxSDateType);

			//사용자가 조합한 date타입을 dt_list에 임시 저장
			DataRow dw = dt_list.NewRow();
			dw[1] = "SET_DATE_TYPE";
			dw[2] = COM.ComVar.This_SetedDateType;
			dt_list.Rows.Add(dw);

			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_sdate_type, _cmbdatecode, _cmbdatename);
			this.cmb_sdate_type.Splits[0].DisplayColumns[0].Visible=false;
			this.cmb_sdate_type.SelectedValue = "SET_DATE_TYPE";



			//날짜 구분 기호 불러오기
			dt_list = ClassLib.ComVar.Select_ComCode(factory,ClassLib.ComVar.CxSDateSign);
			ClassLib.ComCtl.Set_ComboList(dt_list, cmb_sdate_sign, _cmbdatecode, _cmbdatename);
			this.cmb_sdate_sign.Splits[0].DisplayColumns[0].Visible=false;
			this.cmb_sdate_sign.SelectedValue = ShowSingCode(COM.ComVar.This_SetedDateSign);



			// 날짜 형식 보기 설정
			SetData(COM.ComVar.This_SetedDateType, false);

			dt_list = null;

		}

		//설정된 date타입에 따라 각각의 필드에 표시
		private void SetData(string arg_date, bool arg_set)
		{
			string sdatetype = arg_date;
			string sdatesign = sdatetype.Replace("y","").Replace("M","").Replace("d","").Substring(0,1);
			int firstsign = sdatetype.IndexOf(sdatesign);
			int secondsign = sdatetype.LastIndexOf(sdatesign);

			string ftype = sdatetype.Substring(0,firstsign);
			string stype = sdatetype.Substring(firstsign+1,secondsign-firstsign-1);
			string ttype = sdatetype.Substring(secondsign+1);

			cmb_sdate_type.Text = ftype + cmb_sdate_sign.Columns[1].Text + stype + cmb_sdate_sign.Columns[1].Text + ttype;
			txt_sdate_view.Text = SetDatevalue(ftype) + cmb_sdate_sign.Columns[1].Text + SetDatevalue(stype) + cmb_sdate_sign.Columns[1].Text + SetDatevalue(ttype);
			
			//if(arg_set)
			//{
				COM.ComVar.This_SetedDateType = cmb_sdate_type.Text;
				COM.ComVar.This_SetedDateSign = cmb_sdate_sign.Text;
				Save_Spc_Date_Form(ClassLib.ComVar.inandup, factory, ClassLib.ComVar.This_SetedDateType, ClassLib.ComVar.This_SetedDateSign,ClassLib.ComVar.remark,ClassLib.ComVar.This_User);
			//}
		}

		//기호 값으로 기호 코드 알아 오기
		private string ShowSingCode(string arg_sign)
		{
			dt_list = ClassLib.ComVar.Select_ComCode(factory,ClassLib.ComVar.CxSDateSign);
			string signcode = dt_list.Rows[0].ItemArray[_tabletext].ToString();
			int rowcount = dt_list.Rows.Count;

			for(int i=0; i<rowcount; i++)
			{
				if(dt_list.Rows[i].ItemArray[_tabletext].ToString() == arg_sign)
				{
					signcode = dt_list.Rows[i].ItemArray[_tablevalue].ToString();
					break;
				}
			}
			return signcode;
		}


		#region 년, 월, 일 알아 오기 기본
		public static string SetDatevalue(string arg_datetyep)
		{
			string styep;

			if(arg_datetyep == "yyyy")
				styep = DateTime.Now.Year.ToString();

			else if(arg_datetyep == "yy")
				styep = DateTime.Now.Year.ToString().Substring(2,2);

			else if(arg_datetyep == "MM")
			{
				styep = DateTime.Now.Month.ToString();
				if(styep.Length == 1)
					styep = "0" + styep;
			}

			else if(arg_datetyep == "M")
				styep = DateTime.Now.Month.ToString();

			else if(arg_datetyep == "dd")
			{
				styep = DateTime.Now.Day.ToString();
				if(styep.Length == 1)
					styep = "0" + styep;
			}
			else
			{
				styep = DateTime.Now.Day.ToString();
			}
			return styep;
		}
		#endregion

		/// <summary>
		/// Insert or Update(SPC_DATE_FROM) : date 형식을 데잍터베이스에 저장
		/// </summary>
		private void Save_Spc_Date_Form(string arg_div, string arg_fact, string dtype, string arg_ddeli, string arg_remks, string arg_user)
		{
			string Proc_Name = "PKG_SPC_DATETYPE.SAVE_SPC_DATE_FROM";

			oraDB.ReDim_Parameter(6);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_DATETYPE";
			oraDB.Parameter_Name[3] = "ARG_DATEDELI";
			oraDB.Parameter_Name[4] = "ARG_REMARKS";
			oraDB.Parameter_Name[5] = "ARG_UPD_USER";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[5] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = arg_div;
			oraDB.Parameter_Values[1] = arg_fact;
			oraDB.Parameter_Values[2] = dtype;
			oraDB.Parameter_Values[3] = arg_ddeli;
			oraDB.Parameter_Values[4] = arg_remks;
			oraDB.Parameter_Values[5] = arg_user;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();

		}

		#endregion

		#region 이벤트 처리

		//폼 로드시 발생 이벤트
		private void Pop_Date_Set_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		

		//적용 버튼 클릭 이벤트
		private void btn_app_Click(object sender, System.EventArgs e)
		{
			SetData(cmb_sdate_type.Text, true);
		}


		//확인 버튼 클릭 이벤트
		private void btn_ok_Click(object sender, System.EventArgs e)
		{
			SetData(cmb_sdate_type.Text, true);
			this.Close();
		}


		//취소 버튼 클릭 이벤트
		private void btn_cel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
			this.Close();
		}


		//창을 닫을때 발생 이벤트
		private void Pop_Date_Set_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			this.Dispose();
		}

		#endregion
	}
}

