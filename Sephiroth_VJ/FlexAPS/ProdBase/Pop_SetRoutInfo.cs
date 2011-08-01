using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient; 

namespace FlexAPS.ProdBase
{
	public class Pop_SetRoutInfo : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.CheckBox chk_CompYN;
		private C1.Win.C1List.C1Combo cmb_OverType;
		private System.Windows.Forms.TextBox txt_OpName;
		private System.Windows.Forms.TextBox txt_RoutSeq;
		private C1.Win.C1List.C1Combo cmb_OpCd;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.TextBox txt_OverTime;
		private System.Windows.Forms.TextBox txt_SetTime;
		private System.Windows.Forms.TextBox txt_OpLevel;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.Label lbl_OverTime;
		private System.Windows.Forms.Label lbl_OverType;
		private System.Windows.Forms.Label lbl_SetTime;
		private System.Windows.Forms.Label lbl_CompYN;
		private System.Windows.Forms.Label lbl_OpName;
		private System.Windows.Forms.Label lbl_RoutSeq;
		private System.Windows.Forms.Label lbl_OpLevel;
		private System.Windows.Forms.Label lbl_OpCd;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Close;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetRoutInfo()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetRoutInfo));
			this.chk_CompYN = new System.Windows.Forms.CheckBox();
			this.cmb_OverType = new C1.Win.C1List.C1Combo();
			this.txt_OpName = new System.Windows.Forms.TextBox();
			this.txt_RoutSeq = new System.Windows.Forms.TextBox();
			this.cmb_OpCd = new C1.Win.C1List.C1Combo();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.txt_OverTime = new System.Windows.Forms.TextBox();
			this.txt_SetTime = new System.Windows.Forms.TextBox();
			this.txt_OpLevel = new System.Windows.Forms.TextBox();
			this.lbl_Remarks = new System.Windows.Forms.Label();
			this.lbl_OverTime = new System.Windows.Forms.Label();
			this.lbl_OverType = new System.Windows.Forms.Label();
			this.lbl_SetTime = new System.Windows.Forms.Label();
			this.lbl_CompYN = new System.Windows.Forms.Label();
			this.lbl_OpName = new System.Windows.Forms.Label();
			this.lbl_RoutSeq = new System.Windows.Forms.Label();
			this.lbl_OpLevel = new System.Windows.Forms.Label();
			this.lbl_OpCd = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OverType)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).BeginInit();
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
			this.lbl_MainTitle.Text = "Standard Routing";
			// 
			// chk_CompYN
			// 
			this.chk_CompYN.BackColor = System.Drawing.Color.Transparent;
			this.chk_CompYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_CompYN.Location = new System.Drawing.Point(160, 208);
			this.chk_CompYN.Name = "chk_CompYN";
			this.chk_CompYN.Size = new System.Drawing.Size(16, 21);
			this.chk_CompYN.TabIndex = 136;
			this.chk_CompYN.Visible = false;
			// 
			// cmb_OverType
			// 
			this.cmb_OverType.AddItemCols = 0;
			this.cmb_OverType.AddItemSeparator = ';';
			this.cmb_OverType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OverType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OverType.Caption = "";
			this.cmb_OverType.CaptionHeight = 17;
			this.cmb_OverType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OverType.ColumnCaptionHeight = 18;
			this.cmb_OverType.ColumnFooterHeight = 18;
			this.cmb_OverType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OverType.ContentHeight = 17;
			this.cmb_OverType.DeadAreaBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OverType.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OverType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OverType.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OverType.EditorHeight = 17;
			this.cmb_OverType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OverType.GapHeight = 2;
			this.cmb_OverType.ItemHeight = 15;
			this.cmb_OverType.Location = new System.Drawing.Point(160, 256);
			this.cmb_OverType.MatchEntryTimeout = ((long)(2000));
			this.cmb_OverType.MaxDropDownItems = ((short)(5));
			this.cmb_OverType.MaxLength = 32767;
			this.cmb_OverType.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OverType.Name = "cmb_OverType";
			this.cmb_OverType.PartialRightColumn = false;
			this.cmb_OverType.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_OverType.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OverType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OverType.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OverType.Size = new System.Drawing.Size(192, 21);
			this.cmb_OverType.TabIndex = 135;
			this.cmb_OverType.Visible = false;
			// 
			// txt_OpName
			// 
			this.txt_OpName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OpName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OpName.Location = new System.Drawing.Point(168, 160);
			this.txt_OpName.MaxLength = 20;
			this.txt_OpName.Name = "txt_OpName";
			this.txt_OpName.ReadOnly = true;
			this.txt_OpName.Size = new System.Drawing.Size(192, 21);
			this.txt_OpName.TabIndex = 134;
			this.txt_OpName.Text = "";
			this.txt_OpName.Visible = false;
			// 
			// txt_RoutSeq
			// 
			this.txt_RoutSeq.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_RoutSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_RoutSeq.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_RoutSeq.Location = new System.Drawing.Point(151, 55);
			this.txt_RoutSeq.MaxLength = 20;
			this.txt_RoutSeq.Name = "txt_RoutSeq";
			this.txt_RoutSeq.ReadOnly = true;
			this.txt_RoutSeq.Size = new System.Drawing.Size(192, 21);
			this.txt_RoutSeq.TabIndex = 133;
			this.txt_RoutSeq.Text = "";
			this.txt_RoutSeq.Leave += new System.EventHandler(this.txt_RoutSeq_Leave);
			// 
			// cmb_OpCd
			// 
			this.cmb_OpCd.AddItemCols = 0;
			this.cmb_OpCd.AddItemSeparator = ';';
			this.cmb_OpCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_OpCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_OpCd.Caption = "";
			this.cmb_OpCd.CaptionHeight = 17;
			this.cmb_OpCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_OpCd.ColumnCaptionHeight = 18;
			this.cmb_OpCd.ColumnFooterHeight = 18;
			this.cmb_OpCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_OpCd.ContentHeight = 17;
			this.cmb_OpCd.DeadAreaBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OpCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_OpCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_OpCd.EditorHeight = 17;
			this.cmb_OpCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_OpCd.GapHeight = 2;
			this.cmb_OpCd.ItemHeight = 15;
			this.cmb_OpCd.Location = new System.Drawing.Point(151, 77);
			this.cmb_OpCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_OpCd.MaxDropDownItems = ((short)(5));
			this.cmb_OpCd.MaxLength = 32767;
			this.cmb_OpCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_OpCd.Name = "cmb_OpCd";
			this.cmb_OpCd.PartialRightColumn = false;
			this.cmb_OpCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:WhiteSmoke;}HighlightRow{ForeColor:HighlightText;BackColor:Highlig" +
				"ht;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wra" +
				"p:True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColo" +
				"r:Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1L" +
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
			this.cmb_OpCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_OpCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_OpCd.Size = new System.Drawing.Size(192, 21);
			this.cmb_OpCd.TabIndex = 132;
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks.Location = new System.Drawing.Point(160, 296);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.Size = new System.Drawing.Size(192, 21);
			this.txt_Remarks.TabIndex = 131;
			this.txt_Remarks.Text = "";
			this.txt_Remarks.Visible = false;
			// 
			// txt_OverTime
			// 
			this.txt_OverTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OverTime.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OverTime.Location = new System.Drawing.Point(160, 272);
			this.txt_OverTime.MaxLength = 20;
			this.txt_OverTime.Name = "txt_OverTime";
			this.txt_OverTime.Size = new System.Drawing.Size(192, 21);
			this.txt_OverTime.TabIndex = 130;
			this.txt_OverTime.Text = "";
			this.txt_OverTime.Visible = false;
			// 
			// txt_SetTime
			// 
			this.txt_SetTime.BackColor = System.Drawing.SystemColors.Window;
			this.txt_SetTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SetTime.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_SetTime.Location = new System.Drawing.Point(160, 232);
			this.txt_SetTime.MaxLength = 20;
			this.txt_SetTime.Name = "txt_SetTime";
			this.txt_SetTime.Size = new System.Drawing.Size(192, 21);
			this.txt_SetTime.TabIndex = 129;
			this.txt_SetTime.Text = "";
			this.txt_SetTime.Visible = false;
			// 
			// txt_OpLevel
			// 
			this.txt_OpLevel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_OpLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_OpLevel.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_OpLevel.Location = new System.Drawing.Point(168, 184);
			this.txt_OpLevel.MaxLength = 20;
			this.txt_OpLevel.Name = "txt_OpLevel";
			this.txt_OpLevel.ReadOnly = true;
			this.txt_OpLevel.Size = new System.Drawing.Size(192, 21);
			this.txt_OpLevel.TabIndex = 128;
			this.txt_OpLevel.Text = "";
			this.txt_OpLevel.Visible = false;
			// 
			// lbl_Remarks
			// 
			this.lbl_Remarks.ImageIndex = 0;
			this.lbl_Remarks.ImageList = this.img_Label;
			this.lbl_Remarks.Location = new System.Drawing.Point(64, 296);
			this.lbl_Remarks.Name = "lbl_Remarks";
			this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
			this.lbl_Remarks.TabIndex = 127;
			this.lbl_Remarks.Text = "비고";
			this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_Remarks.Visible = false;
			// 
			// lbl_OverTime
			// 
			this.lbl_OverTime.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_OverTime.ImageIndex = 0;
			this.lbl_OverTime.ImageList = this.img_Label;
			this.lbl_OverTime.Location = new System.Drawing.Point(64, 272);
			this.lbl_OverTime.Name = "lbl_OverTime";
			this.lbl_OverTime.Size = new System.Drawing.Size(100, 21);
			this.lbl_OverTime.TabIndex = 126;
			this.lbl_OverTime.Text = "오버랩타임";
			this.lbl_OverTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_OverTime.Visible = false;
			// 
			// lbl_OverType
			// 
			this.lbl_OverType.ImageIndex = 0;
			this.lbl_OverType.ImageList = this.img_Label;
			this.lbl_OverType.Location = new System.Drawing.Point(64, 256);
			this.lbl_OverType.Name = "lbl_OverType";
			this.lbl_OverType.Size = new System.Drawing.Size(100, 21);
			this.lbl_OverType.TabIndex = 125;
			this.lbl_OverType.Text = "오버랩타입";
			this.lbl_OverType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_OverType.Visible = false;
			// 
			// lbl_SetTime
			// 
			this.lbl_SetTime.ImageIndex = 0;
			this.lbl_SetTime.ImageList = this.img_Label;
			this.lbl_SetTime.Location = new System.Drawing.Point(64, 232);
			this.lbl_SetTime.Name = "lbl_SetTime";
			this.lbl_SetTime.Size = new System.Drawing.Size(100, 21);
			this.lbl_SetTime.TabIndex = 124;
			this.lbl_SetTime.Text = "준비시간";
			this.lbl_SetTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SetTime.Visible = false;
			// 
			// lbl_CompYN
			// 
			this.lbl_CompYN.ImageIndex = 0;
			this.lbl_CompYN.ImageList = this.img_Label;
			this.lbl_CompYN.Location = new System.Drawing.Point(64, 208);
			this.lbl_CompYN.Name = "lbl_CompYN";
			this.lbl_CompYN.Size = new System.Drawing.Size(100, 21);
			this.lbl_CompYN.TabIndex = 123;
			this.lbl_CompYN.Text = "일부생산공정";
			this.lbl_CompYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_CompYN.Visible = false;
			// 
			// lbl_OpName
			// 
			this.lbl_OpName.ImageIndex = 0;
			this.lbl_OpName.ImageList = this.img_Label;
			this.lbl_OpName.Location = new System.Drawing.Point(64, 160);
			this.lbl_OpName.Name = "lbl_OpName";
			this.lbl_OpName.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpName.TabIndex = 122;
			this.lbl_OpName.Text = "공정명";
			this.lbl_OpName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_OpName.Visible = false;
			// 
			// lbl_RoutSeq
			// 
			this.lbl_RoutSeq.ImageIndex = 0;
			this.lbl_RoutSeq.ImageList = this.img_Label;
			this.lbl_RoutSeq.Location = new System.Drawing.Point(50, 55);
			this.lbl_RoutSeq.Name = "lbl_RoutSeq";
			this.lbl_RoutSeq.Size = new System.Drawing.Size(100, 21);
			this.lbl_RoutSeq.TabIndex = 121;
			this.lbl_RoutSeq.Text = "Sequence";
			this.lbl_RoutSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_OpLevel
			// 
			this.lbl_OpLevel.ImageIndex = 0;
			this.lbl_OpLevel.ImageList = this.img_Label;
			this.lbl_OpLevel.Location = new System.Drawing.Point(64, 184);
			this.lbl_OpLevel.Name = "lbl_OpLevel";
			this.lbl_OpLevel.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpLevel.TabIndex = 120;
			this.lbl_OpLevel.Text = "레벨";
			this.lbl_OpLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_OpLevel.Visible = false;
			// 
			// lbl_OpCd
			// 
			this.lbl_OpCd.ImageIndex = 0;
			this.lbl_OpCd.ImageList = this.img_Label;
			this.lbl_OpCd.Location = new System.Drawing.Point(50, 77);
			this.lbl_OpCd.Name = "lbl_OpCd";
			this.lbl_OpCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_OpCd.TabIndex = 119;
			this.lbl_OpCd.Text = "Proc.";
			this.lbl_OpCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(233, 112);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 118;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Close
			// 
			this.btn_Close.ImageIndex = 0;
			this.btn_Close.ImageList = this.img_Button;
			this.btn_Close.Location = new System.Drawing.Point(304, 112);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 117;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// Pop_SetRoutInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 144);
			this.Controls.Add(this.chk_CompYN);
			this.Controls.Add(this.cmb_OverType);
			this.Controls.Add(this.txt_OpName);
			this.Controls.Add(this.txt_RoutSeq);
			this.Controls.Add(this.cmb_OpCd);
			this.Controls.Add(this.txt_Remarks);
			this.Controls.Add(this.txt_OverTime);
			this.Controls.Add(this.txt_SetTime);
			this.Controls.Add(this.txt_OpLevel);
			this.Controls.Add(this.lbl_Remarks);
			this.Controls.Add(this.lbl_OverTime);
			this.Controls.Add(this.lbl_OverType);
			this.Controls.Add(this.lbl_SetTime);
			this.Controls.Add(this.lbl_CompYN);
			this.Controls.Add(this.lbl_OpName);
			this.Controls.Add(this.lbl_RoutSeq);
			this.Controls.Add(this.lbl_OpLevel);
			this.Controls.Add(this.lbl_OpCd);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Close);
			this.Name = "Pop_SetRoutInfo";
			this.Text = "Standard Routing ";
			this.Load += new System.EventHandler(this.Pop_SetRoutInfo_Load);
			this.Activated += new System.EventHandler(this.Pop_SetRoutInfo_Activated);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.lbl_OpCd, 0);
			this.Controls.SetChildIndex(this.lbl_OpLevel, 0);
			this.Controls.SetChildIndex(this.lbl_RoutSeq, 0);
			this.Controls.SetChildIndex(this.lbl_OpName, 0);
			this.Controls.SetChildIndex(this.lbl_CompYN, 0);
			this.Controls.SetChildIndex(this.lbl_SetTime, 0);
			this.Controls.SetChildIndex(this.lbl_OverType, 0);
			this.Controls.SetChildIndex(this.lbl_OverTime, 0);
			this.Controls.SetChildIndex(this.lbl_Remarks, 0);
			this.Controls.SetChildIndex(this.txt_OpLevel, 0);
			this.Controls.SetChildIndex(this.txt_SetTime, 0);
			this.Controls.SetChildIndex(this.txt_OverTime, 0);
			this.Controls.SetChildIndex(this.txt_Remarks, 0);
			this.Controls.SetChildIndex(this.cmb_OpCd, 0);
			this.Controls.SetChildIndex(this.txt_RoutSeq, 0);
			this.Controls.SetChildIndex(this.txt_OpName, 0);
			this.Controls.SetChildIndex(this.cmb_OverType, 0);
			this.Controls.SetChildIndex(this.chk_CompYN, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_OverType)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_OpCd)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의  
		
		private COM.OraDB MyOraDB = new COM.OraDB(); 
		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave;

		private string _Factory, _RoutSeq, _OpCd;

		#endregion 

		#region 멤버 메서드


		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_ret;
 
			//Title
			this.Text = "Standard Routing";
			this.lbl_MainTitle.Text = "Standard Routing"; 
	
			ClassLib.ComFunction.SetLangDic(this);


		


			_Factory = ClassLib.ComVar.Parameter_PopUp[0]; 
			_RoutSeq = ClassLib.ComVar.Parameter_PopUp[1]; 
			_OpCd = ClassLib.ComVar.Parameter_PopUp[2]; 

			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxOverType); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OverType, 1, 2, false, COM.ComVar.ComboList_Visible.Code); 


			dt_ret = Select_OpCd_CmbList();
			ClassLib.ComCtl.Set_ComboList_3(dt_ret, cmb_OpCd, 0, 1, 2);
			cmb_OpCd.DisplayMember = "Code";
			cmb_OpCd.Splits[0].DisplayColumns[1].Visible = false;
			cmb_OpCd.Splits[0].DisplayColumns[2].Visible = false;

 
			txt_RoutSeq.Text = _RoutSeq;
			if(_OpCd != "") cmb_OpCd.SelectedValue = _OpCd;


			

		}

		#endregion  
		
		#region 이벤트 처리

		private void txt_RoutSeq_Leave(object sender, System.EventArgs e)
		{
			ClassLib.ComFunction.Set_NumberTextBox(txt_RoutSeq, 3);
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

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			if(txt_RoutSeq.Text == "") 
			{
				ClassLib.ComFunction.Data_Message("Routing Sequence", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}

			if(cmb_OpCd.SelectedIndex == -1)
			{
				ClassLib.ComFunction.Data_Message("Production Code", ClassLib.ComVar.MgsWrongInput, this);
				return;
			}


			_CloseSave = true;
			//routseq, opcd, optype, opname
			ClassLib.ComVar.Parameter_PopUp = new string[] {txt_RoutSeq.Text.PadLeft(3, '0'), 
															   cmb_OpCd.SelectedValue.ToString(),
														       cmb_OpCd.Columns[2].Text,
															   cmb_OpCd.Columns[1].Text };
			this.Close();
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			_CloseSave = false;
			this.Close();
		}


		#endregion
 
		#region DB Connect
  
		/// <summary>
		/// Select_OpCd_CmbList : 공정코드 콤보리스트 찾기
		/// </summary>
		private DataTable Select_OpCd_CmbList()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_OPCD.SELECT_SPB_OPCD_CMB";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null; 
			} 
		}

		#endregion


		private void Pop_SetRoutInfo_Activated(object sender, System.EventArgs e)
		{
			cmb_OpCd.Focus();
		}

		
		private void Pop_SetRoutInfo_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		 


	}
}

