using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_SetCmpInfo : COM.APSWinForm.Pop_Small
	{
		
		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label btn_Cancel;
		private C1.Win.C1List.C1Combo cmb_CmpCd;
		private System.Windows.Forms.Label lbl_CmpCd;
		private System.Windows.Forms.Label lbl_CmpName;
		private System.Windows.Forms.Label lbl_UpCmpCd;
		private System.Windows.Forms.Label btn_Commit;
		private System.Windows.Forms.Label lbl_CmpType;
		private System.Windows.Forms.Label lbl_CmpLevel;
		private System.Windows.Forms.Label lbl_CmpNo;
		private System.Windows.Forms.Label lbl_LeafCmpLevel;
		private System.Windows.Forms.Label lbl_AvailYMD;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.TextBox txt_CmpName;
		private System.Windows.Forms.TextBox txt_UpCmpCd;
		private System.Windows.Forms.TextBox txt_CmpLevel;
		private System.Windows.Forms.TextBox txt_CmpNo;
		private System.Windows.Forms.TextBox txt_LeafCmpLevel;
		private System.Windows.Forms.TextBox txt_AvailYMD;
		private System.Windows.Forms.TextBox txt_Remarks;
		private C1.Win.C1List.C1Combo cmb_CmpType;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_CreateCMP;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetCmpInfo()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetCmpInfo));
			this.cmb_CmpCd = new C1.Win.C1List.C1Combo();
			this.lbl_CmpCd = new System.Windows.Forms.Label();
			this.lbl_CmpName = new System.Windows.Forms.Label();
			this.lbl_UpCmpCd = new System.Windows.Forms.Label();
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.lbl_CmpType = new System.Windows.Forms.Label();
			this.lbl_CmpLevel = new System.Windows.Forms.Label();
			this.lbl_CmpNo = new System.Windows.Forms.Label();
			this.lbl_LeafCmpLevel = new System.Windows.Forms.Label();
			this.lbl_AvailYMD = new System.Windows.Forms.Label();
			this.lbl_Remarks = new System.Windows.Forms.Label();
			this.txt_CmpName = new System.Windows.Forms.TextBox();
			this.txt_UpCmpCd = new System.Windows.Forms.TextBox();
			this.txt_CmpLevel = new System.Windows.Forms.TextBox();
			this.txt_CmpNo = new System.Windows.Forms.TextBox();
			this.txt_LeafCmpLevel = new System.Windows.Forms.TextBox();
			this.txt_AvailYMD = new System.Windows.Forms.TextBox();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.cmb_CmpType = new C1.Win.C1List.C1Combo();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_CreateCMP = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpType)).BeginInit();
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
			this.lbl_MainTitle.Text = "Select Component";
			// 
			// cmb_CmpCd
			// 
			this.cmb_CmpCd.AddItemCols = 0;
			this.cmb_CmpCd.AddItemSeparator = ';';
			this.cmb_CmpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_CmpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_CmpCd.Caption = "";
			this.cmb_CmpCd.CaptionHeight = 17;
			this.cmb_CmpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_CmpCd.ColumnCaptionHeight = 18;
			this.cmb_CmpCd.ColumnFooterHeight = 18;
			this.cmb_CmpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_CmpCd.ContentHeight = 17;
			this.cmb_CmpCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_CmpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CmpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_CmpCd.EditorHeight = 17;
			this.cmb_CmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpCd.GapHeight = 2;
			this.cmb_CmpCd.ItemHeight = 15;
			this.cmb_CmpCd.Location = new System.Drawing.Point(141, 55);
			this.cmb_CmpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_CmpCd.MaxDropDownItems = ((short)(5));
			this.cmb_CmpCd.MaxLength = 32767;
			this.cmb_CmpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_CmpCd.Name = "cmb_CmpCd";
			this.cmb_CmpCd.PartialRightColumn = false;
			this.cmb_CmpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_CmpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CmpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CmpCd.Size = new System.Drawing.Size(192, 21);
			this.cmb_CmpCd.TabIndex = 71;
			this.cmb_CmpCd.TextChanged += new System.EventHandler(this.cmb_CmpCd_TextChanged);
			// 
			// lbl_CmpCd
			// 
			this.lbl_CmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpCd.ImageIndex = 0;
			this.lbl_CmpCd.ImageList = this.img_Label;
			this.lbl_CmpCd.Location = new System.Drawing.Point(40, 55);
			this.lbl_CmpCd.Name = "lbl_CmpCd";
			this.lbl_CmpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpCd.TabIndex = 70;
			this.lbl_CmpCd.Text = "Code";
			this.lbl_CmpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_CmpName
			// 
			this.lbl_CmpName.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpName.ImageIndex = 0;
			this.lbl_CmpName.ImageList = this.img_Label;
			this.lbl_CmpName.Location = new System.Drawing.Point(40, 77);
			this.lbl_CmpName.Name = "lbl_CmpName";
			this.lbl_CmpName.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpName.TabIndex = 67;
			this.lbl_CmpName.Text = "Cmp Name";
			this.lbl_CmpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_UpCmpCd
			// 
			this.lbl_UpCmpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_UpCmpCd.ImageIndex = 0;
			this.lbl_UpCmpCd.ImageList = this.img_Label;
			this.lbl_UpCmpCd.Location = new System.Drawing.Point(40, 99);
			this.lbl_UpCmpCd.Name = "lbl_UpCmpCd";
			this.lbl_UpCmpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_UpCmpCd.TabIndex = 66;
			this.lbl_UpCmpCd.Text = "Up Code";
			this.lbl_UpCmpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Commit
			// 
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(241, 200);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(70, 23);
			this.btn_Commit.TabIndex = 65;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 200);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 64;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// lbl_CmpType
			// 
			this.lbl_CmpType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpType.ImageIndex = 0;
			this.lbl_CmpType.ImageList = this.img_Label;
			this.lbl_CmpType.Location = new System.Drawing.Point(40, 121);
			this.lbl_CmpType.Name = "lbl_CmpType";
			this.lbl_CmpType.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpType.TabIndex = 72;
			this.lbl_CmpType.Text = "Type";
			this.lbl_CmpType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_CmpLevel
			// 
			this.lbl_CmpLevel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpLevel.ImageIndex = 0;
			this.lbl_CmpLevel.ImageList = this.img_Label;
			this.lbl_CmpLevel.Location = new System.Drawing.Point(40, 143);
			this.lbl_CmpLevel.Name = "lbl_CmpLevel";
			this.lbl_CmpLevel.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpLevel.TabIndex = 73;
			this.lbl_CmpLevel.Text = "Level";
			this.lbl_CmpLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_CmpNo
			// 
			this.lbl_CmpNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_CmpNo.ImageIndex = 0;
			this.lbl_CmpNo.ImageList = this.img_Label;
			this.lbl_CmpNo.Location = new System.Drawing.Point(50, 312);
			this.lbl_CmpNo.Name = "lbl_CmpNo";
			this.lbl_CmpNo.Size = new System.Drawing.Size(100, 21);
			this.lbl_CmpNo.TabIndex = 74;
			this.lbl_CmpNo.Text = "순번";
			this.lbl_CmpNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_CmpNo.Visible = false;
			// 
			// lbl_LeafCmpLevel
			// 
			this.lbl_LeafCmpLevel.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.lbl_LeafCmpLevel.ImageIndex = 0;
			this.lbl_LeafCmpLevel.ImageList = this.img_Label;
			this.lbl_LeafCmpLevel.Location = new System.Drawing.Point(50, 333);
			this.lbl_LeafCmpLevel.Name = "lbl_LeafCmpLevel";
			this.lbl_LeafCmpLevel.Size = new System.Drawing.Size(100, 21);
			this.lbl_LeafCmpLevel.TabIndex = 75;
			this.lbl_LeafCmpLevel.Text = "최하위 품목레벨";
			this.lbl_LeafCmpLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_LeafCmpLevel.Visible = false;
			// 
			// lbl_AvailYMD
			// 
			this.lbl_AvailYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_AvailYMD.ImageIndex = 0;
			this.lbl_AvailYMD.ImageList = this.img_Label;
			this.lbl_AvailYMD.Location = new System.Drawing.Point(50, 354);
			this.lbl_AvailYMD.Name = "lbl_AvailYMD";
			this.lbl_AvailYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_AvailYMD.TabIndex = 76;
			this.lbl_AvailYMD.Text = "유효기간";
			this.lbl_AvailYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_AvailYMD.Visible = false;
			// 
			// lbl_Remarks
			// 
			this.lbl_Remarks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Remarks.ImageIndex = 0;
			this.lbl_Remarks.ImageList = this.img_Label;
			this.lbl_Remarks.Location = new System.Drawing.Point(40, 165);
			this.lbl_Remarks.Name = "lbl_Remarks";
			this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
			this.lbl_Remarks.TabIndex = 77;
			this.lbl_Remarks.Text = "Remarks";
			this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_CmpName
			// 
			this.txt_CmpName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_CmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CmpName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_CmpName.Location = new System.Drawing.Point(141, 77);
			this.txt_CmpName.MaxLength = 20;
			this.txt_CmpName.Name = "txt_CmpName";
			this.txt_CmpName.ReadOnly = true;
			this.txt_CmpName.Size = new System.Drawing.Size(192, 21);
			this.txt_CmpName.TabIndex = 78;
			this.txt_CmpName.Text = "";
			// 
			// txt_UpCmpCd
			// 
			this.txt_UpCmpCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_UpCmpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_UpCmpCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_UpCmpCd.Location = new System.Drawing.Point(141, 99);
			this.txt_UpCmpCd.MaxLength = 20;
			this.txt_UpCmpCd.Name = "txt_UpCmpCd";
			this.txt_UpCmpCd.ReadOnly = true;
			this.txt_UpCmpCd.Size = new System.Drawing.Size(192, 21);
			this.txt_UpCmpCd.TabIndex = 79;
			this.txt_UpCmpCd.Text = "";
			// 
			// txt_CmpLevel
			// 
			this.txt_CmpLevel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_CmpLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CmpLevel.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_CmpLevel.Location = new System.Drawing.Point(141, 143);
			this.txt_CmpLevel.MaxLength = 20;
			this.txt_CmpLevel.Name = "txt_CmpLevel";
			this.txt_CmpLevel.ReadOnly = true;
			this.txt_CmpLevel.Size = new System.Drawing.Size(192, 21);
			this.txt_CmpLevel.TabIndex = 80;
			this.txt_CmpLevel.Text = "";
			// 
			// txt_CmpNo
			// 
			this.txt_CmpNo.BackColor = System.Drawing.SystemColors.Window;
			this.txt_CmpNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_CmpNo.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_CmpNo.Location = new System.Drawing.Point(151, 312);
			this.txt_CmpNo.MaxLength = 20;
			this.txt_CmpNo.Name = "txt_CmpNo";
			this.txt_CmpNo.Size = new System.Drawing.Size(192, 21);
			this.txt_CmpNo.TabIndex = 81;
			this.txt_CmpNo.Text = "";
			this.txt_CmpNo.Visible = false;
			// 
			// txt_LeafCmpLevel
			// 
			this.txt_LeafCmpLevel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LeafCmpLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LeafCmpLevel.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LeafCmpLevel.Location = new System.Drawing.Point(151, 333);
			this.txt_LeafCmpLevel.MaxLength = 20;
			this.txt_LeafCmpLevel.Name = "txt_LeafCmpLevel";
			this.txt_LeafCmpLevel.ReadOnly = true;
			this.txt_LeafCmpLevel.Size = new System.Drawing.Size(192, 21);
			this.txt_LeafCmpLevel.TabIndex = 82;
			this.txt_LeafCmpLevel.Text = "";
			this.txt_LeafCmpLevel.Visible = false;
			// 
			// txt_AvailYMD
			// 
			this.txt_AvailYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_AvailYMD.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_AvailYMD.Location = new System.Drawing.Point(151, 354);
			this.txt_AvailYMD.MaxLength = 20;
			this.txt_AvailYMD.Name = "txt_AvailYMD";
			this.txt_AvailYMD.Size = new System.Drawing.Size(192, 21);
			this.txt_AvailYMD.TabIndex = 83;
			this.txt_AvailYMD.Text = "";
			this.txt_AvailYMD.Visible = false;
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks.Location = new System.Drawing.Point(141, 165);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.Size = new System.Drawing.Size(192, 21);
			this.txt_Remarks.TabIndex = 84;
			this.txt_Remarks.Text = "";
			// 
			// cmb_CmpType
			// 
			this.cmb_CmpType.AddItemCols = 0;
			this.cmb_CmpType.AddItemSeparator = ';';
			this.cmb_CmpType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_CmpType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_CmpType.Caption = "";
			this.cmb_CmpType.CaptionHeight = 17;
			this.cmb_CmpType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_CmpType.ColumnCaptionHeight = 18;
			this.cmb_CmpType.ColumnFooterHeight = 18;
			this.cmb_CmpType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_CmpType.ContentHeight = 17;
			this.cmb_CmpType.DeadAreaBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CmpType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_CmpType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_CmpType.EditorHeight = 17;
			this.cmb_CmpType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_CmpType.GapHeight = 2;
			this.cmb_CmpType.ItemHeight = 15;
			this.cmb_CmpType.Location = new System.Drawing.Point(141, 121);
			this.cmb_CmpType.MatchEntryTimeout = ((long)(2000));
			this.cmb_CmpType.MaxDropDownItems = ((short)(5));
			this.cmb_CmpType.MaxLength = 32767;
			this.cmb_CmpType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_CmpType.Name = "cmb_CmpType";
			this.cmb_CmpType.PartialRightColumn = false;
			this.cmb_CmpType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:WhiteSmoke;}HighlightRow{ForeColor:HighlightText;BackColor:Highlig" +
				"ht;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColo" +
				"r:Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Styl" +
				"e8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1L" +
				"ist.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionH" +
				"eight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup" +
				"=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScro" +
				"llBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" " +
				"me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"" +
				"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle pa" +
				"rent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6" +
				"\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" " +
				"me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Selec" +
				"tedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></" +
				"C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><" +
				"Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Styl" +
				"e parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style" +
				" parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Sty" +
				"le parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style pa" +
				"rent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Name" +
				"dStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</La" +
				"yout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_CmpType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_CmpType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_CmpType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_CmpType.Size = new System.Drawing.Size(192, 21);
			this.cmb_CmpType.TabIndex = 85;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// btn_CreateCMP
			// 
			this.btn_CreateCMP.BackColor = System.Drawing.SystemColors.Control;
			this.btn_CreateCMP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_CreateCMP.ImageIndex = 0;
			this.btn_CreateCMP.ImageList = this.img_MiniButton;
			this.btn_CreateCMP.Location = new System.Drawing.Point(334, 55);
			this.btn_CreateCMP.Name = "btn_CreateCMP";
			this.btn_CreateCMP.Size = new System.Drawing.Size(21, 21);
			this.btn_CreateCMP.TabIndex = 214;
			this.btn_CreateCMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CreateCMP.Click += new System.EventHandler(this.btn_CreateCMP_Click);
			this.btn_CreateCMP.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CreateCMP.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_SetCmpInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 232);
			this.Controls.Add(this.btn_CreateCMP);
			this.Controls.Add(this.cmb_CmpType);
			this.Controls.Add(this.txt_Remarks);
			this.Controls.Add(this.txt_AvailYMD);
			this.Controls.Add(this.txt_LeafCmpLevel);
			this.Controls.Add(this.txt_CmpNo);
			this.Controls.Add(this.txt_CmpLevel);
			this.Controls.Add(this.txt_UpCmpCd);
			this.Controls.Add(this.txt_CmpName);
			this.Controls.Add(this.lbl_Remarks);
			this.Controls.Add(this.lbl_AvailYMD);
			this.Controls.Add(this.lbl_LeafCmpLevel);
			this.Controls.Add(this.lbl_CmpNo);
			this.Controls.Add(this.lbl_CmpLevel);
			this.Controls.Add(this.lbl_CmpType);
			this.Controls.Add(this.cmb_CmpCd);
			this.Controls.Add(this.lbl_CmpCd);
			this.Controls.Add(this.lbl_CmpName);
			this.Controls.Add(this.lbl_UpCmpCd);
			this.Controls.Add(this.btn_Commit);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_SetCmpInfo";
			this.Text = "Select Component";
			this.Load += new System.EventHandler(this.Pop_SetCmpInfo_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Commit, 0);
			this.Controls.SetChildIndex(this.lbl_UpCmpCd, 0);
			this.Controls.SetChildIndex(this.lbl_CmpName, 0);
			this.Controls.SetChildIndex(this.lbl_CmpCd, 0);
			this.Controls.SetChildIndex(this.cmb_CmpCd, 0);
			this.Controls.SetChildIndex(this.lbl_CmpType, 0);
			this.Controls.SetChildIndex(this.lbl_CmpLevel, 0);
			this.Controls.SetChildIndex(this.lbl_CmpNo, 0);
			this.Controls.SetChildIndex(this.lbl_LeafCmpLevel, 0);
			this.Controls.SetChildIndex(this.lbl_AvailYMD, 0);
			this.Controls.SetChildIndex(this.lbl_Remarks, 0);
			this.Controls.SetChildIndex(this.txt_CmpName, 0);
			this.Controls.SetChildIndex(this.txt_UpCmpCd, 0);
			this.Controls.SetChildIndex(this.txt_CmpLevel, 0);
			this.Controls.SetChildIndex(this.txt_CmpNo, 0);
			this.Controls.SetChildIndex(this.txt_LeafCmpLevel, 0);
			this.Controls.SetChildIndex(this.txt_AvailYMD, 0);
			this.Controls.SetChildIndex(this.txt_Remarks, 0);
			this.Controls.SetChildIndex(this.cmb_CmpType, 0);
			this.Controls.SetChildIndex(this.btn_CreateCMP, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpCd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_CmpType)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
 
		#region 변수 정의
  

		private COM.OraDB MyOraDB = new COM.OraDB();

		private string _Factory;

		//폼 닫힐때 일어난 이벤트 (apply : true, close : false)
		public bool _CloseSave;

		#endregion 

		#region 멤버 메서드
 
		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_list;
 
			//Title
			this.Text = "Component Information";
			this.lbl_MainTitle.Text = "Component Information";

			ClassLib.ComFunction.SetLangDic(this);

			

			
			switch(ClassLib.ComVar.Parameter_PopUp[0])
			{ 
				case "Insert":

					_Factory = ClassLib.ComVar.Parameter_PopUp[1];

					dt_list = Select_Cmp_CmbList();
					ClassLib.ComCtl.Set_ComboList(dt_list, cmb_CmpCd, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);  


					dt_list = Select_CmpType_CmbList();
					ClassLib.ComCtl.Set_ComboList(dt_list, cmb_CmpType, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);   
			
					txt_UpCmpCd.Text = ClassLib.ComVar.Parameter_PopUp[2];
					cmb_CmpType.SelectedValue = ClassLib.ComVar.Parameter_PopUp[3];
					txt_CmpLevel.Text = ClassLib.ComVar.Parameter_PopUp[4];
					txt_CmpNo.Text = ClassLib.ComVar.Parameter_PopUp[5];

					break;

				case "Update":

					_Factory = ClassLib.ComVar.Parameter_PopUp[1];

					dt_list = Select_Cmp_CmbList();
					ClassLib.ComCtl.Set_ComboList(dt_list, cmb_CmpCd, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);  


					dt_list = Select_CmpType_CmbList();
					ClassLib.ComCtl.Set_ComboList(dt_list, cmb_CmpType, 1, 2, false, COM.ComVar.ComboList_Visible.Code_Name);   
			
					cmb_CmpType.SelectedValue = ClassLib.ComVar.Parameter_PopUp[2]; 
					cmb_CmpCd.SelectedValue = ClassLib.ComVar.Parameter_PopUp[3];
					txt_UpCmpCd.Text = ClassLib.ComVar.Parameter_PopUp[4];
					txt_CmpName.Text = ClassLib.ComVar.Parameter_PopUp[5]; 
					txt_CmpLevel.Text = ClassLib.ComVar.Parameter_PopUp[6];
					txt_CmpNo.Text = ClassLib.ComVar.Parameter_PopUp[7];
				    txt_LeafCmpLevel.Text = ClassLib.ComVar.Parameter_PopUp[8];
					txt_AvailYMD.Text = ClassLib.ComVar.Parameter_PopUp[9];
					txt_Remarks.Text = ClassLib.ComVar.Parameter_PopUp[10];
 
					cmb_CmpCd.Enabled = false;


					break;
			}

			

		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{

			if(_CloseSave)
			{
				 
				ClassLib.ComVar.Parameter_PopUp = new string[] {"Y",
																   cmb_CmpType.SelectedValue.ToString(),
																   cmb_CmpCd.SelectedValue.ToString(),
																   txt_UpCmpCd.Text, 
																   txt_CmpName.Text, 
																   txt_CmpLevel.Text,
																   txt_CmpNo.Text,
																   txt_LeafCmpLevel.Text,
																   txt_AvailYMD.Text,
																   txt_Remarks.Text};
			}
			else
			{
				 
					ClassLib.ComVar.Parameter_PopUp = new string[] {"N",
																	"",
																	"",
																	"", 
																	"", 
																	"",
																	"",
																	"",
																	"",
																	""};
				 
			}
			
			

			this.Close();
		}
 


		/// <summary>
		/// Select_Cmp_CmbList : 품목코드 콤보리스트 찾기
		/// </summary>
		private DataTable Select_Cmp_CmbList()
		{
 
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = "PKG_SPB_RSC.SELECT_CMP_LIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}

		} 


		/// <summary>
		/// Select_CmpType_CmbList : 품목타입코드 콤보리스트 찾기
		/// </summary>
		/// <returns></returns>
		private DataTable Select_CmpType_CmbList()
		{ 
			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = "PKG_SPB_BOM.SELECT_CMPTYPE_LIST";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = "";

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
			}
			catch
			{
				return null;
			}

		}


		#endregion 

		#region 이벤트 처리 

		
 
		private void cmb_CmpCd_TextChanged(object sender, System.EventArgs e)
		{ 
			cmb_CmpCd.Text = cmb_CmpCd.SelectedValue.ToString();
			txt_CmpName.Text = cmb_CmpCd.Columns[1].Text;
		}


		private void btn_Commit_Click(object sender, System.EventArgs e)
		{
			
			if(cmb_CmpType.SelectedIndex == -1)
			{
				//MessageBox.Show("타입 입력");
				ClassLib.ComFunction.Data_Message("BOM Compnent Type", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}

			if(cmb_CmpCd.SelectedIndex == -1)
			{
				//MessageBox.Show("품목코드 입력");
				ClassLib.ComFunction.Data_Message("BOM Component Code", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}

			_CloseSave = true; 
			Close_Form();

		}

		 
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CloseSave = false; 
			Close_Form();
		} 
 

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		private void btn_CreateCMP_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] {_Factory}; 

				ClassLib.ComVar.FormClick_Flag = true;
				Pop_CreateCmpCd pop_form = new Pop_CreateCmpCd();
				pop_form.ShowDialog();
				ClassLib.ComVar.FormClick_Flag = false;

				//Cmp List Update
				dt_ret = Select_Cmp_CmbList();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_CmpCd, 1, 2);  

			}
			catch
			{
			}
		}


		#endregion 

		
		private void Pop_SetCmpInfo_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 




	}
}

