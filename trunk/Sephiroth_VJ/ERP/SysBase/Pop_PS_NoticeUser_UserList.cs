using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_NoticeUser_UserList : COM.APSWinForm.Pop_Small
	{
		public System.Windows.Forms.Panel pnl_Semlpe;
		private C1.Win.C1List.C1Combo cmb_Grp_Set;
		private System.Windows.Forms.Label lbl_Grp_Set;
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
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Grp_Set;
		private System.Windows.Forms.Label btn_insert;
		private System.Windows.Forms.Label btn_save;
		public System.Windows.Forms.ImageList img_Action;
		private System.ComponentModel.IContainer components = null;
		public COM.FSP fgrid_FrdList;



		#region 사용자 변수
		private bool creategroup = false;
		private int _RowFixed = 3;
		private COM.OraDB oraDB = null;
		private System.Windows.Forms.Label btn_delete;
		private string selectText = "";
		private System.Windows.Forms.Form frm = null;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.TextBox  txt = null;
		#endregion

		public Pop_PS_NoticeUser_UserList(System.Windows.Forms.Form arg_frm, System.Windows.Forms.TextBox arg_txt)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			frm = arg_frm;
			txt = arg_txt;
		}

		public Pop_PS_NoticeUser_UserList()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_NoticeUser_UserList));
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.txt_Grp_Set = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.cmb_Grp_Set = new C1.Win.C1List.C1Combo();
			this.lbl_Grp_Set = new System.Windows.Forms.Label();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
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
			this.fgrid_FrdList = new COM.FSP();
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_insert = new System.Windows.Forms.Label();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.btn_delete = new System.Windows.Forms.Label();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Grp_Set)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_FrdList)).BeginInit();
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
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.txt_Grp_Set);
			this.pnl_Semlpe.Controls.Add(this.label3);
			this.pnl_Semlpe.Controls.Add(this.cmb_Grp_Set);
			this.pnl_Semlpe.Controls.Add(this.lbl_Grp_Set);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.DockPadding.All = 8;
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(0, 64);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(392, 72);
			this.pnl_Semlpe.TabIndex = 34;
			// 
			// txt_Grp_Set
			// 
			this.txt_Grp_Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Grp_Set.Location = new System.Drawing.Point(119, 15);
			this.txt_Grp_Set.Name = "txt_Grp_Set";
			this.txt_Grp_Set.Size = new System.Drawing.Size(210, 21);
			this.txt_Grp_Set.TabIndex = 219;
			this.txt_Grp_Set.Text = "";
			this.txt_Grp_Set.Visible = false;
			// 
			// label3
			// 
			this.label3.ImageIndex = 2;
			this.label3.ImageList = this.img_MiniButton;
			this.label3.Location = new System.Drawing.Point(330, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 21);
			this.label3.TabIndex = 218;
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// cmb_Grp_Set
			// 
			this.cmb_Grp_Set.AddItemCols = 0;
			this.cmb_Grp_Set.AddItemSeparator = ';';
			this.cmb_Grp_Set.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_Grp_Set.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Grp_Set.Caption = "";
			this.cmb_Grp_Set.CaptionHeight = 17;
			this.cmb_Grp_Set.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Grp_Set.ColumnCaptionHeight = 18;
			this.cmb_Grp_Set.ColumnFooterHeight = 18;
			this.cmb_Grp_Set.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Grp_Set.ContentHeight = 17;
			this.cmb_Grp_Set.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Grp_Set.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Grp_Set.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Grp_Set.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Grp_Set.EditorHeight = 17;
			this.cmb_Grp_Set.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Grp_Set.GapHeight = 2;
			this.cmb_Grp_Set.ItemHeight = 15;
			this.cmb_Grp_Set.Location = new System.Drawing.Point(119, 36);
			this.cmb_Grp_Set.MatchEntryTimeout = ((long)(2000));
			this.cmb_Grp_Set.MaxDropDownItems = ((short)(5));
			this.cmb_Grp_Set.MaxLength = 32767;
			this.cmb_Grp_Set.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Grp_Set.Name = "cmb_Grp_Set";
			this.cmb_Grp_Set.PartialRightColumn = false;
			this.cmb_Grp_Set.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_Grp_Set.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Grp_Set.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Grp_Set.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Grp_Set.Size = new System.Drawing.Size(210, 21);
			this.cmb_Grp_Set.TabIndex = 74;
			this.cmb_Grp_Set.SelectedValueChanged += new System.EventHandler(this.cmb_Grp_Set_SelectedValueChanged);
			// 
			// lbl_Grp_Set
			// 
			this.lbl_Grp_Set.ImageIndex = 0;
			this.lbl_Grp_Set.ImageList = this.img_Label;
			this.lbl_Grp_Set.Location = new System.Drawing.Point(18, 36);
			this.lbl_Grp_Set.Name = "lbl_Grp_Set";
			this.lbl_Grp_Set.Size = new System.Drawing.Size(100, 21);
			this.lbl_Grp_Set.TabIndex = 70;
			this.lbl_Grp_Set.Text = "그룹설정";
			this.lbl_Grp_Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
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
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(376, 56);
			this.pnl_SearchImage.TabIndex = 18;
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
			this.picb_MR.Size = new System.Drawing.Size(15, 16);
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
			this.lbl_SubTitle1.Text = "      Select Sender";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(360, 40);
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
			this.picb_BM.Location = new System.Drawing.Point(144, 38);
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
			this.picb_BL.Location = new System.Drawing.Point(0, 36);
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
			this.picb_ML.Size = new System.Drawing.Size(168, 16);
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
			this.picb_MM.Size = new System.Drawing.Size(208, 16);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// fgrid_FrdList
			// 
			this.fgrid_FrdList.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_FrdList.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_FrdList.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_FrdList.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_FrdList.Location = new System.Drawing.Point(8, 136);
			this.fgrid_FrdList.Name = "fgrid_FrdList";
			this.fgrid_FrdList.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_FrdList.Size = new System.Drawing.Size(376, 272);
			this.fgrid_FrdList.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_FrdList.TabIndex = 97;
			this.fgrid_FrdList.DoubleClick += new System.EventHandler(this.fgrid_FrdList_DoubleClick);
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 8;
			this.btn_save.ImageList = this.img_MiniButton;
			this.btn_save.Location = new System.Drawing.Point(363, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(21, 21);
			this.btn_save.TabIndex = 215;
			this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_insert
			// 
			this.btn_insert.ImageIndex = 12;
			this.btn_insert.ImageList = this.img_MiniButton;
			this.btn_insert.Location = new System.Drawing.Point(341, 416);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(21, 21);
			this.btn_insert.TabIndex = 216;
			this.btn_insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 14;
			this.btn_delete.ImageList = this.img_MiniButton;
			this.btn_delete.Location = new System.Drawing.Point(319, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(21, 21);
			this.btn_delete.TabIndex = 218;
			this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// Pop_PS_NoticeUser_UserList
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 448);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.fgrid_FrdList);
			this.Controls.Add(this.pnl_Semlpe);
			this.Name = "Pop_PS_NoticeUser_UserList";
			this.Text = "Friend Regist";
			this.Load += new System.EventHandler(this.Pop_PS_NoticeUser_UserList_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			this.Controls.SetChildIndex(this.fgrid_FrdList, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.btn_insert, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_Grp_Set)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_FrdList)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
		
		private void Pop_PS_NoticeUser_UserList_Load(object sender, System.EventArgs e)
		{
		
			Init_Form();
		}

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			lbl_MainTitle.Text = "Friend Regist";
			oraDB = new COM.OraDB(); 

			DataTable dt =  Save_SPS_Notice_UserGroup();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Grp_Set, 0, 0, true);
			try
			{
				cmb_Grp_Set.SelectedValue = dt.Rows[0].ItemArray[0].ToString();


				//Friend List 그리드 설정
				fgrid_FrdList.Set_Grid_Comm("SPS_NOTICE_USERLIST", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_FrdList.Set_Action_Image(img_Action);
				Set_Grid_Root();
				fgrid_FrdList.Rows.Count = _RowFixed;
				Get_Grid_List(cmb_Grp_Set.SelectedValue.ToString());
			}
			catch
			{
				//Friend List 그리드 설정
				fgrid_FrdList.Set_Grid_Comm("SPS_NOTICE_USERLIST", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
				fgrid_FrdList.Set_Action_Image(img_Action);
				Set_Grid_Root();
				fgrid_FrdList.Rows.Count = _RowFixed;
			}
		}

		private void Set_Grid_Root()
		{
			fgrid_FrdList.Tree.Column = (int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_LIST;
			fgrid_FrdList.Rows.InsertNode(2, 0);
			fgrid_FrdList[2,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxDIVISION] = "";
			fgrid_FrdList[2,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxFACTORY] = ClassLib.ComVar.This_Factory;
			fgrid_FrdList[2,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUPD_USER] = ClassLib.ComVar.This_User;

			fgrid_FrdList[2,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_GRP] = "GROUP";

			fgrid_FrdList[2,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_LIST] = "FRIEND LIST";



		}


		private void Get_Grid_List(string arg_user_grp)
		{
			fgrid_FrdList.Rows.Count = _RowFixed;
			DataTable dt = Save_SPS_Notice_UserList(arg_user_grp);

			int rowcount = dt.Rows.Count;
			int colcount = dt.Columns.Count;

			for(int i=0; i<rowcount; i++)
			{
				fgrid_FrdList.Rows.InsertNode(fgrid_FrdList.Rows.Count,1);
 
				fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxDIVISION] = "";
				
				for(int j=0; j<colcount-1; j++)
				{
					fgrid_FrdList[fgrid_FrdList.Rows.Count-1,j+1] = dt.Rows[i].ItemArray[j].ToString();
				}


			}
		}

		private void Com_List_Set(string arg_value)
		{
			DataTable dt =  Save_SPS_Notice_UserGroup();
			ClassLib.ComCtl.Set_ComboList(dt, cmb_Grp_Set, 0, 0, false);
			cmb_Grp_Set.SelectedValue = arg_value;
		}

		private void Com_List_Set()
		{
			DataTable dt =  Save_SPS_Notice_UserGroup();
			string aa = dt.Rows[0].ItemArray[0].ToString();
			cmb_Grp_Set.SelectedValue = aa;
		}




		#region 이벤트
		private void label3_Click(object sender, System.EventArgs e)
		{
			if(!creategroup)
			{
				cmb_Grp_Set.Visible = false;
				txt_Grp_Set.Visible = true;
				txt_Grp_Set.Location = new Point(119, 36);
				fgrid_FrdList.Rows.Count = _RowFixed;
				
				creategroup = true;
			}
			else
			{
				creategroup = false;
				cmb_Grp_Set.Visible = true;
				txt_Grp_Set.Visible = false;
				cmb_Grp_Set.Location = new Point(119, 36);
				Com_List_Set();

				
			}
		}

		private void btn_insert_Click(object sender, System.EventArgs e)
		{


			fgrid_FrdList.Rows.InsertNode(fgrid_FrdList.Rows.Count,1);
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxDIVISION] = "I";
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxFACTORY] = ClassLib.ComVar.This_Factory;
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_ID] = ClassLib.ComVar.This_User;

			if(cmb_Grp_Set.Visible)
				fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_GRP] = cmb_Grp_Set.SelectedValue.ToString();
			else
				fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_GRP] = txt_Grp_Set.Text;
			
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_LIST] = "";
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxREMARKS] = "";
			fgrid_FrdList[fgrid_FrdList.Rows.Count-1,(int)ClassLib.TBSPS_NOTICE_USERLIST.IxUPD_USER] = ClassLib.ComVar.This_User;
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			if(cmb_Grp_Set.SelectedIndex == 0)
			{
				MessageBox.Show("그룹을 먼저 설정 정하셔야 합니다.");
				return;
			}

			if(txt_Grp_Set.Visible)
				selectText = txt_Grp_Set.Text;
			else
				selectText = cmb_Grp_Set.SelectedValue.ToString();


			if(fgrid_FrdList.Rows.Count > _RowFixed)
			{
				//행 수정 상태 해제
				fgrid_FrdList.Select(fgrid_FrdList.Selection.r1, 0, fgrid_FrdList.Selection.r1, fgrid_FrdList.Cols.Count-1, false);
				
				if(oraDB.Save_FlexGird("PKG_SPS_HOME.SAVE_SPS_NOTICE_USERLIST", fgrid_FrdList))
				{


					MessageBox.Show("저장이 완료 되었습니다.");

					if(!cmb_Grp_Set.Visible)
					{
						cmb_Grp_Set.Visible = true;
						txt_Grp_Set.Visible = false;

						creategroup = false;
					}

					Com_List_Set(selectText);

					selectText = "";



				}
				else
					MessageBox.Show("저장이 바르게 되지 않았습니다.");
			}
			else
			{
				MessageBox.Show("친구 목록이 없습니다.");
			}
		}


		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			int startdelpoint = fgrid_FrdList.Selection.r1;
			int stoptdelpoint = fgrid_FrdList.Selection.r2;
			for(int i=startdelpoint; i<stoptdelpoint+1; i++)
			{
				fgrid_FrdList.Delete_Row(i);
			}
		}

		private void cmb_Grp_Set_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(selectText.Length != 0)
				Get_Grid_List(selectText);
			else
			{
				string aa = cmb_Grp_Set.SelectedValue.ToString();
				Get_Grid_List(aa);
			}
		}

		private void fgrid_FrdList_DoubleClick(object sender, System.EventArgs e)
		{
			if(frm != null)
			{
				int rownum = fgrid_FrdList.Selection.r1;
				string frd_id = fgrid_FrdList[rownum, (int)ClassLib.TBSPS_NOTICE_USERLIST.IxUSER_LIST].ToString();

				if(txt.Text.Length == 0)
				{
					txt.Text = frd_id;
				}
				else
				{
					txt.Text += "," + frd_id;
				}
			}
		}

		#endregion

		#region DB 접속

		private DataTable Save_SPS_Notice_UserGroup()
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_USERGROUP";

			
			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private DataTable Save_SPS_Notice_UserList(string arg_user_grp)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_SPS_NOTICE_USERLIST";

			
			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_USER_ID";
			oraDB.Parameter_Name[2] = "ARG_USER_GRP";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[2] = arg_user_grp;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		#endregion


		

		

		

		
	}
}

