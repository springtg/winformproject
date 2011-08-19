using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexBase.Yield
{
	public class Pop_Yield_Copy : COM.PCHWinForm.Pop_Medium
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Factory_Source;
		private System.Windows.Forms.Label lbl_Style_Soruce;
		private System.Windows.Forms.Label lbl_SG_Soruce;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lbl_Style_Target;
		private System.Windows.Forms.Label lbl_SG_Target;
		private System.Windows.Forms.Label lbl_Factory_Target;
		private System.Windows.Forms.TextBox txt_Gen_S;
		private C1.Win.C1List.C1Combo cmb_StyleName_T;
		private C1.Win.C1List.C1Combo cmb_Factory_T;
		private System.Windows.Forms.TextBox txt_Style_T;
		private C1.Win.C1List.C1Combo cmb_SG_T;
		private System.Windows.Forms.TextBox txt_Gen_T;
		private COM.FSP fgrid_Component;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.Label lbl_Gen_S;
		private System.Windows.Forms.TextBox txt_Presto_S;
		private System.Windows.Forms.TextBox txt_Presto_T;
		private System.Windows.Forms.Label lbl_Gen_T;
		private C1.Win.C1List.C1Combo cmb_SG_S;
		private C1.Win.C1List.C1Combo cmb_StyleName_S;
		private System.Windows.Forms.TextBox txt_Style_S;
		private C1.Win.C1List.C1Combo cmb_Factory_S;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton rad_All;
		private System.Windows.Forms.RadioButton rad_Comp;
		private System.Windows.Forms.RadioButton rad_SG;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rad_All_S;
		private System.Windows.Forms.RadioButton rad_Comp_S;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		private System.ComponentModel.IContainer components = null;

		public Pop_Yield_Copy()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}
 

		//string[] pop_parameter = new string[] { factory, factory_name, style_cd, style_name, gender, presto, sg_cd, component_cd };

		private string _Factory = "", _FactoryName;
		private string _StyleCd = "", _StyleName = "", _Gen = "", _Presto = "";
		private string _SGCd = "", _ComponentCd = ""; 

		public Pop_Yield_Copy(string[] arg_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
 
			_Factory = arg_parameter[0];
			_FactoryName = arg_parameter[1];
			_StyleCd = arg_parameter[2];
			_StyleName = arg_parameter[3];
			_Gen = arg_parameter[4];
			_Presto = arg_parameter[5];
			_SGCd = arg_parameter[6];
			_ComponentCd = arg_parameter[7]; 


			Init_Form(); 

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Yield_Copy));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmb_SG_S = new C1.Win.C1List.C1Combo();
			this.cmb_StyleName_S = new C1.Win.C1List.C1Combo();
			this.txt_Style_S = new System.Windows.Forms.TextBox();
			this.cmb_Factory_S = new C1.Win.C1List.C1Combo();
			this.txt_Presto_S = new System.Windows.Forms.TextBox();
			this.lbl_Gen_S = new System.Windows.Forms.Label();
			this.lbl_Style_Soruce = new System.Windows.Forms.Label();
			this.lbl_SG_Soruce = new System.Windows.Forms.Label();
			this.lbl_Factory_Source = new System.Windows.Forms.Label();
			this.txt_Gen_S = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rad_SG = new System.Windows.Forms.RadioButton();
			this.rad_All = new System.Windows.Forms.RadioButton();
			this.rad_Comp = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_Presto_T = new System.Windows.Forms.TextBox();
			this.lbl_Gen_T = new System.Windows.Forms.Label();
			this.txt_Gen_T = new System.Windows.Forms.TextBox();
			this.cmb_SG_T = new C1.Win.C1List.C1Combo();
			this.cmb_StyleName_T = new C1.Win.C1List.C1Combo();
			this.txt_Style_T = new System.Windows.Forms.TextBox();
			this.lbl_Style_Target = new System.Windows.Forms.Label();
			this.lbl_SG_Target = new System.Windows.Forms.Label();
			this.lbl_Factory_Target = new System.Windows.Forms.Label();
			this.cmb_Factory_T = new C1.Win.C1List.C1Combo();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.fgrid_Component = new COM.FSP();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rad_All_S = new System.Windows.Forms.RadioButton();
			this.rad_Comp_S = new System.Windows.Forms.RadioButton();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SG_S)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleName_S)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_S)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SG_T)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleName_T)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_T)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Component)).BeginInit();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
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
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox1.Controls.Add(this.cmb_SG_S);
			this.groupBox1.Controls.Add(this.cmb_StyleName_S);
			this.groupBox1.Controls.Add(this.txt_Style_S);
			this.groupBox1.Controls.Add(this.cmb_Factory_S);
			this.groupBox1.Controls.Add(this.txt_Presto_S);
			this.groupBox1.Controls.Add(this.lbl_Gen_S);
			this.groupBox1.Controls.Add(this.lbl_Style_Soruce);
			this.groupBox1.Controls.Add(this.lbl_SG_Soruce);
			this.groupBox1.Controls.Add(this.lbl_Factory_Source);
			this.groupBox1.Controls.Add(this.txt_Gen_S);
			this.groupBox1.Location = new System.Drawing.Point(5, 39);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(685, 89);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Source";
			// 
			// cmb_SG_S
			// 
			this.cmb_SG_S.AccessibleDescription = "";
			this.cmb_SG_S.AccessibleName = "";
			this.cmb_SG_S.AddItemCols = 0;
			this.cmb_SG_S.AddItemSeparator = ';';
			this.cmb_SG_S.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_SG_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_SG_S.Caption = "";
			this.cmb_SG_S.CaptionHeight = 17;
			this.cmb_SG_S.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_SG_S.ColumnCaptionHeight = 18;
			this.cmb_SG_S.ColumnFooterHeight = 18;
			this.cmb_SG_S.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_SG_S.ContentHeight = 17;
			this.cmb_SG_S.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_SG_S.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_SG_S.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SG_S.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_SG_S.EditorHeight = 17;
			this.cmb_SG_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SG_S.GapHeight = 2;
			this.cmb_SG_S.ItemHeight = 15;
			this.cmb_SG_S.Location = new System.Drawing.Point(108, 61);
			this.cmb_SG_S.MatchEntryTimeout = ((long)(2000));
			this.cmb_SG_S.MaxDropDownItems = ((short)(5));
			this.cmb_SG_S.MaxLength = 32767;
			this.cmb_SG_S.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_SG_S.Name = "cmb_SG_S";
			this.cmb_SG_S.PartialRightColumn = false;
			this.cmb_SG_S.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_SG_S.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_SG_S.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_SG_S.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_SG_S.Size = new System.Drawing.Size(283, 21);
			this.cmb_SG_S.TabIndex = 627;
			this.cmb_SG_S.SelectedValueChanged += new System.EventHandler(this.cmb_SG_S_SelectedValueChanged);
			// 
			// cmb_StyleName_S
			// 
			this.cmb_StyleName_S.AccessibleDescription = "";
			this.cmb_StyleName_S.AccessibleName = "";
			this.cmb_StyleName_S.AddItemCols = 0;
			this.cmb_StyleName_S.AddItemSeparator = ';';
			this.cmb_StyleName_S.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_StyleName_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleName_S.Caption = "";
			this.cmb_StyleName_S.CaptionHeight = 17;
			this.cmb_StyleName_S.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleName_S.ColumnCaptionHeight = 18;
			this.cmb_StyleName_S.ColumnFooterHeight = 18;
			this.cmb_StyleName_S.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleName_S.ContentHeight = 17;
			this.cmb_StyleName_S.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleName_S.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleName_S.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleName_S.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleName_S.EditorHeight = 17;
			this.cmb_StyleName_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleName_S.GapHeight = 2;
			this.cmb_StyleName_S.ItemHeight = 15;
			this.cmb_StyleName_S.Location = new System.Drawing.Point(204, 39);
			this.cmb_StyleName_S.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleName_S.MaxDropDownItems = ((short)(5));
			this.cmb_StyleName_S.MaxLength = 32767;
			this.cmb_StyleName_S.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleName_S.Name = "cmb_StyleName_S";
			this.cmb_StyleName_S.PartialRightColumn = false;
			this.cmb_StyleName_S.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_StyleName_S.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleName_S.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleName_S.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleName_S.Size = new System.Drawing.Size(187, 21);
			this.cmb_StyleName_S.TabIndex = 626;
			this.cmb_StyleName_S.SelectedValueChanged += new System.EventHandler(this.cmb_StyleName_S_SelectedValueChanged);
			// 
			// txt_Style_S
			// 
			this.txt_Style_S.BackColor = System.Drawing.Color.White;
			this.txt_Style_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Style_S.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Style_S.Location = new System.Drawing.Point(108, 39);
			this.txt_Style_S.MaxLength = 10;
			this.txt_Style_S.Name = "txt_Style_S";
			this.txt_Style_S.Size = new System.Drawing.Size(95, 21);
			this.txt_Style_S.TabIndex = 625;
			this.txt_Style_S.Text = "";
			this.txt_Style_S.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_S_KeyUp);
			// 
			// cmb_Factory_S
			// 
			this.cmb_Factory_S.AccessibleDescription = "";
			this.cmb_Factory_S.AccessibleName = "";
			this.cmb_Factory_S.AddItemCols = 0;
			this.cmb_Factory_S.AddItemSeparator = ';';
			this.cmb_Factory_S.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_Factory_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_S.Caption = "";
			this.cmb_Factory_S.CaptionHeight = 17;
			this.cmb_Factory_S.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_S.ColumnCaptionHeight = 18;
			this.cmb_Factory_S.ColumnFooterHeight = 18;
			this.cmb_Factory_S.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_S.ContentHeight = 17;
			this.cmb_Factory_S.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_S.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory_S.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_S.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_S.EditorHeight = 17;
			this.cmb_Factory_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_S.GapHeight = 2;
			this.cmb_Factory_S.ItemHeight = 15;
			this.cmb_Factory_S.Location = new System.Drawing.Point(108, 17);
			this.cmb_Factory_S.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_S.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_S.MaxLength = 32767;
			this.cmb_Factory_S.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_S.Name = "cmb_Factory_S";
			this.cmb_Factory_S.PartialRightColumn = false;
			this.cmb_Factory_S.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory_S.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_S.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_S.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_S.Size = new System.Drawing.Size(283, 21);
			this.cmb_Factory_S.TabIndex = 624;
			// 
			// txt_Presto_S
			// 
			this.txt_Presto_S.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Presto_S.Location = new System.Drawing.Point(582, 39);
			this.txt_Presto_S.MaxLength = 100;
			this.txt_Presto_S.Name = "txt_Presto_S";
			this.txt_Presto_S.ReadOnly = true;
			this.txt_Presto_S.Size = new System.Drawing.Size(80, 21);
			this.txt_Presto_S.TabIndex = 623;
			this.txt_Presto_S.Text = "";
			// 
			// lbl_Gen_S
			// 
			this.lbl_Gen_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Gen_S.ImageIndex = 0;
			this.lbl_Gen_S.ImageList = this.img_Label;
			this.lbl_Gen_S.Location = new System.Drawing.Point(400, 39);
			this.lbl_Gen_S.Name = "lbl_Gen_S";
			this.lbl_Gen_S.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gen_S.TabIndex = 622;
			this.lbl_Gen_S.Text = "Gender/ Presto";
			this.lbl_Gen_S.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style_Soruce
			// 
			this.lbl_Style_Soruce.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Style_Soruce.ImageIndex = 0;
			this.lbl_Style_Soruce.ImageList = this.img_Label;
			this.lbl_Style_Soruce.Location = new System.Drawing.Point(7, 39);
			this.lbl_Style_Soruce.Name = "lbl_Style_Soruce";
			this.lbl_Style_Soruce.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_Soruce.TabIndex = 542;
			this.lbl_Style_Soruce.Text = "Style";
			this.lbl_Style_Soruce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SG_Soruce
			// 
			this.lbl_SG_Soruce.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_SG_Soruce.ImageIndex = 0;
			this.lbl_SG_Soruce.ImageList = this.img_Label;
			this.lbl_SG_Soruce.Location = new System.Drawing.Point(7, 61);
			this.lbl_SG_Soruce.Name = "lbl_SG_Soruce";
			this.lbl_SG_Soruce.Size = new System.Drawing.Size(100, 21);
			this.lbl_SG_Soruce.TabIndex = 541;
			this.lbl_SG_Soruce.Text = "Semigood";
			this.lbl_SG_Soruce.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory_Source
			// 
			this.lbl_Factory_Source.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Factory_Source.ImageIndex = 0;
			this.lbl_Factory_Source.ImageList = this.img_Label;
			this.lbl_Factory_Source.Location = new System.Drawing.Point(7, 17);
			this.lbl_Factory_Source.Name = "lbl_Factory_Source";
			this.lbl_Factory_Source.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_Source.TabIndex = 540;
			this.lbl_Factory_Source.Text = "Factory";
			this.lbl_Factory_Source.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Gen_S
			// 
			this.txt_Gen_S.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen_S.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen_S.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Gen_S.Location = new System.Drawing.Point(501, 39);
			this.txt_Gen_S.MaxLength = 100;
			this.txt_Gen_S.Name = "txt_Gen_S";
			this.txt_Gen_S.ReadOnly = true;
			this.txt_Gen_S.Size = new System.Drawing.Size(80, 21);
			this.txt_Gen_S.TabIndex = 546;
			this.txt_Gen_S.Text = "";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.rad_SG);
			this.groupBox4.Controls.Add(this.rad_All);
			this.groupBox4.Controls.Add(this.rad_Comp);
			this.groupBox4.Font = new System.Drawing.Font("Verdana", 9F);
			this.groupBox4.Location = new System.Drawing.Point(529, 105);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(155, 39);
			this.groupBox4.TabIndex = 628;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Tree View Option";
			// 
			// rad_SG
			// 
			this.rad_SG.Location = new System.Drawing.Point(4, 19);
			this.rad_SG.Name = "rad_SG";
			this.rad_SG.Size = new System.Drawing.Size(52, 16);
			this.rad_SG.TabIndex = 37;
			this.rad_SG.Tag = "1";
			this.rad_SG.Text = "Semi";
			this.rad_SG.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_All
			// 
			this.rad_All.Checked = true;
			this.rad_All.Location = new System.Drawing.Point(111, 19);
			this.rad_All.Name = "rad_All";
			this.rad_All.Size = new System.Drawing.Size(41, 16);
			this.rad_All.TabIndex = 36;
			this.rad_All.TabStop = true;
			this.rad_All.Tag = "-1";
			this.rad_All.Text = "All";
			this.rad_All.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// rad_Comp
			// 
			this.rad_Comp.Location = new System.Drawing.Point(56, 19);
			this.rad_Comp.Name = "rad_Comp";
			this.rad_Comp.Size = new System.Drawing.Size(57, 16);
			this.rad_Comp.TabIndex = 35;
			this.rad_Comp.Tag = "2";
			this.rad_Comp.Text = "Comp";
			this.rad_Comp.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox2.Controls.Add(this.txt_Presto_T);
			this.groupBox2.Controls.Add(this.lbl_Gen_T);
			this.groupBox2.Controls.Add(this.txt_Gen_T);
			this.groupBox2.Controls.Add(this.cmb_SG_T);
			this.groupBox2.Controls.Add(this.cmb_StyleName_T);
			this.groupBox2.Controls.Add(this.txt_Style_T);
			this.groupBox2.Controls.Add(this.lbl_Style_Target);
			this.groupBox2.Controls.Add(this.lbl_SG_Target);
			this.groupBox2.Controls.Add(this.lbl_Factory_Target);
			this.groupBox2.Controls.Add(this.cmb_Factory_T);
			this.groupBox2.Location = new System.Drawing.Point(5, 368);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(685, 89);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Target";
			// 
			// txt_Presto_T
			// 
			this.txt_Presto_T.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Presto_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Presto_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Presto_T.Location = new System.Drawing.Point(582, 39);
			this.txt_Presto_T.MaxLength = 100;
			this.txt_Presto_T.Name = "txt_Presto_T";
			this.txt_Presto_T.ReadOnly = true;
			this.txt_Presto_T.Size = new System.Drawing.Size(80, 21);
			this.txt_Presto_T.TabIndex = 626;
			this.txt_Presto_T.Text = "";
			// 
			// lbl_Gen_T
			// 
			this.lbl_Gen_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Gen_T.ImageIndex = 0;
			this.lbl_Gen_T.ImageList = this.img_Label;
			this.lbl_Gen_T.Location = new System.Drawing.Point(400, 39);
			this.lbl_Gen_T.Name = "lbl_Gen_T";
			this.lbl_Gen_T.Size = new System.Drawing.Size(100, 21);
			this.lbl_Gen_T.TabIndex = 625;
			this.lbl_Gen_T.Text = "Gender/ Presto";
			this.lbl_Gen_T.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Gen_T
			// 
			this.txt_Gen_T.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Gen_T.Location = new System.Drawing.Point(501, 39);
			this.txt_Gen_T.MaxLength = 100;
			this.txt_Gen_T.Name = "txt_Gen_T";
			this.txt_Gen_T.ReadOnly = true;
			this.txt_Gen_T.Size = new System.Drawing.Size(80, 21);
			this.txt_Gen_T.TabIndex = 547;
			this.txt_Gen_T.Text = "";
			// 
			// cmb_SG_T
			// 
			this.cmb_SG_T.AccessibleDescription = "";
			this.cmb_SG_T.AccessibleName = "";
			this.cmb_SG_T.AddItemCols = 0;
			this.cmb_SG_T.AddItemSeparator = ';';
			this.cmb_SG_T.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_SG_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_SG_T.Caption = "";
			this.cmb_SG_T.CaptionHeight = 17;
			this.cmb_SG_T.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_SG_T.ColumnCaptionHeight = 18;
			this.cmb_SG_T.ColumnFooterHeight = 18;
			this.cmb_SG_T.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_SG_T.ContentHeight = 17;
			this.cmb_SG_T.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_SG_T.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_SG_T.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SG_T.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_SG_T.EditorHeight = 17;
			this.cmb_SG_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SG_T.GapHeight = 2;
			this.cmb_SG_T.ItemHeight = 15;
			this.cmb_SG_T.Location = new System.Drawing.Point(108, 61);
			this.cmb_SG_T.MatchEntryTimeout = ((long)(2000));
			this.cmb_SG_T.MaxDropDownItems = ((short)(5));
			this.cmb_SG_T.MaxLength = 32767;
			this.cmb_SG_T.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_SG_T.Name = "cmb_SG_T";
			this.cmb_SG_T.PartialRightColumn = false;
			this.cmb_SG_T.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;Al" +
				"ignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Control" +
				";}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_SG_T.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_SG_T.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_SG_T.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_SG_T.Size = new System.Drawing.Size(283, 21);
			this.cmb_SG_T.TabIndex = 543;
			// 
			// cmb_StyleName_T
			// 
			this.cmb_StyleName_T.AccessibleDescription = "";
			this.cmb_StyleName_T.AccessibleName = "";
			this.cmb_StyleName_T.AddItemCols = 0;
			this.cmb_StyleName_T.AddItemSeparator = ';';
			this.cmb_StyleName_T.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_StyleName_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_StyleName_T.Caption = "";
			this.cmb_StyleName_T.CaptionHeight = 17;
			this.cmb_StyleName_T.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_StyleName_T.ColumnCaptionHeight = 18;
			this.cmb_StyleName_T.ColumnFooterHeight = 18;
			this.cmb_StyleName_T.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_StyleName_T.ContentHeight = 17;
			this.cmb_StyleName_T.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_StyleName_T.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_StyleName_T.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleName_T.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_StyleName_T.EditorHeight = 17;
			this.cmb_StyleName_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_StyleName_T.GapHeight = 2;
			this.cmb_StyleName_T.ItemHeight = 15;
			this.cmb_StyleName_T.Location = new System.Drawing.Point(204, 39);
			this.cmb_StyleName_T.MatchEntryTimeout = ((long)(2000));
			this.cmb_StyleName_T.MaxDropDownItems = ((short)(5));
			this.cmb_StyleName_T.MaxLength = 32767;
			this.cmb_StyleName_T.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_StyleName_T.Name = "cmb_StyleName_T";
			this.cmb_StyleName_T.PartialRightColumn = false;
			this.cmb_StyleName_T.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_StyleName_T.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_StyleName_T.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_StyleName_T.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_StyleName_T.Size = new System.Drawing.Size(187, 21);
			this.cmb_StyleName_T.TabIndex = 535;
			this.cmb_StyleName_T.SelectedValueChanged += new System.EventHandler(this.cmb_StyleName_T_SelectedValueChanged);
			// 
			// txt_Style_T
			// 
			this.txt_Style_T.BackColor = System.Drawing.Color.White;
			this.txt_Style_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_Style_T.ImeMode = System.Windows.Forms.ImeMode.Hangul;
			this.txt_Style_T.Location = new System.Drawing.Point(108, 39);
			this.txt_Style_T.MaxLength = 10;
			this.txt_Style_T.Name = "txt_Style_T";
			this.txt_Style_T.Size = new System.Drawing.Size(95, 21);
			this.txt_Style_T.TabIndex = 534;
			this.txt_Style_T.Text = "";
			this.txt_Style_T.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_T_KeyUp);
			// 
			// lbl_Style_Target
			// 
			this.lbl_Style_Target.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Style_Target.ImageIndex = 0;
			this.lbl_Style_Target.ImageList = this.img_Label;
			this.lbl_Style_Target.Location = new System.Drawing.Point(7, 39);
			this.lbl_Style_Target.Name = "lbl_Style_Target";
			this.lbl_Style_Target.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style_Target.TabIndex = 542;
			this.lbl_Style_Target.Text = "Style";
			this.lbl_Style_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SG_Target
			// 
			this.lbl_SG_Target.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_SG_Target.ImageIndex = 0;
			this.lbl_SG_Target.ImageList = this.img_Label;
			this.lbl_SG_Target.Location = new System.Drawing.Point(7, 61);
			this.lbl_SG_Target.Name = "lbl_SG_Target";
			this.lbl_SG_Target.Size = new System.Drawing.Size(100, 21);
			this.lbl_SG_Target.TabIndex = 541;
			this.lbl_SG_Target.Text = "Semigood";
			this.lbl_SG_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory_Target
			// 
			this.lbl_Factory_Target.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_Factory_Target.ImageIndex = 0;
			this.lbl_Factory_Target.ImageList = this.img_Label;
			this.lbl_Factory_Target.Location = new System.Drawing.Point(7, 17);
			this.lbl_Factory_Target.Name = "lbl_Factory_Target";
			this.lbl_Factory_Target.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory_Target.TabIndex = 540;
			this.lbl_Factory_Target.Text = "Factory";
			this.lbl_Factory_Target.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_Factory_T
			// 
			this.cmb_Factory_T.AccessibleDescription = "";
			this.cmb_Factory_T.AccessibleName = "";
			this.cmb_Factory_T.AddItemCols = 0;
			this.cmb_Factory_T.AddItemSeparator = ';';
			this.cmb_Factory_T.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
			this.cmb_Factory_T.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_Factory_T.Caption = "";
			this.cmb_Factory_T.CaptionHeight = 17;
			this.cmb_Factory_T.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_Factory_T.ColumnCaptionHeight = 18;
			this.cmb_Factory_T.ColumnFooterHeight = 18;
			this.cmb_Factory_T.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_Factory_T.ContentHeight = 17;
			this.cmb_Factory_T.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_Factory_T.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_Factory_T.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_T.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_Factory_T.EditorHeight = 17;
			this.cmb_Factory_T.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_Factory_T.GapHeight = 2;
			this.cmb_Factory_T.ItemHeight = 15;
			this.cmb_Factory_T.Location = new System.Drawing.Point(108, 17);
			this.cmb_Factory_T.MatchEntryTimeout = ((long)(2000));
			this.cmb_Factory_T.MaxDropDownItems = ((short)(5));
			this.cmb_Factory_T.MaxLength = 32767;
			this.cmb_Factory_T.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_Factory_T.Name = "cmb_Factory_T";
			this.cmb_Factory_T.PartialRightColumn = false;
			this.cmb_Factory_T.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:굴림, 9pt;B" +
				"ackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}Style" +
				"1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Control" +
				";Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}Style" +
				"10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List.ListB" +
				"oxView AllowColSelect=\"False\" Name=\"\" AllowRowSizing=\"None\" CaptionHeight=\"18\" C" +
				"olumnCaptionHeight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" Horizont" +
				"alScrollGroup=\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</" +
				"Width></VScrollBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle par" +
				"ent=\"Style2\" me=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterS" +
				"tyle parent=\"Footer\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><He" +
				"adingStyle parent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRo" +
				"w\" me=\"Style6\" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle par" +
				"ent=\"OddRow\" me=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Styl" +
				"e10\" /><SelectedStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=" +
				"\"Style1\" /></C1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me" +
				"=\"Normal\" /><Style parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Fo" +
				"oter\" /><Style parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inact" +
				"ive\" /><Style parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"Highlig" +
				"htRow\" /><Style parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow" +
				"\" /><Style parent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Gr" +
				"oup\" /></NamedStyles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout" +
				">Modified</Layout><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_Factory_T.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_Factory_T.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_Factory_T.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_Factory_T.Size = new System.Drawing.Size(283, 21);
			this.cmb_Factory_T.TabIndex = 533;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
			this.groupBox3.Controls.Add(this.fgrid_Component);
			this.groupBox3.Location = new System.Drawing.Point(5, 136);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(685, 224);
			this.groupBox3.TabIndex = 30;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Source - Component";
			// 
			// fgrid_Component
			// 
			this.fgrid_Component.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Component.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.fgrid_Component.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Component.Location = new System.Drawing.Point(7, 16);
			this.fgrid_Component.Name = "fgrid_Component";
			this.fgrid_Component.Size = new System.Drawing.Size(673, 200);
			this.fgrid_Component.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Component.TabIndex = 661;
			this.fgrid_Component.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Component_AfterEdit);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.rad_All_S);
			this.groupBox5.Controls.Add(this.rad_Comp_S);
			this.groupBox5.Font = new System.Drawing.Font("Verdana", 9F);
			this.groupBox5.Location = new System.Drawing.Point(424, 105);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(105, 39);
			this.groupBox5.TabIndex = 629;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Select Option";
			// 
			// rad_All_S
			// 
			this.rad_All_S.Location = new System.Drawing.Point(58, 19);
			this.rad_All_S.Name = "rad_All_S";
			this.rad_All_S.Size = new System.Drawing.Size(38, 16);
			this.rad_All_S.TabIndex = 36;
			this.rad_All_S.Tag = "-1";
			this.rad_All_S.Text = "All";
			this.rad_All_S.CheckedChanged += new System.EventHandler(this.rad_All_S_CheckedChanged);
			// 
			// rad_Comp_S
			// 
			this.rad_Comp_S.Checked = true;
			this.rad_Comp_S.Location = new System.Drawing.Point(6, 19);
			this.rad_Comp_S.Name = "rad_Comp_S";
			this.rad_Comp_S.Size = new System.Drawing.Size(57, 16);
			this.rad_Comp_S.TabIndex = 35;
			this.rad_Comp_S.TabStop = true;
			this.rad_Comp_S.Tag = "2";
			this.rad_Comp_S.Text = "Comp";
			this.rad_Comp_S.CheckedChanged += new System.EventHandler(this.rad_Comp_S_CheckedChanged);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Cancel.ImageIndex = 2;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(608, 466);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
			this.btn_Cancel.TabIndex = 631;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
			this.btn_Apply.ImageIndex = 2;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(527, 466);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(80, 23);
			this.btn_Apply.TabIndex = 630;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_Yield_Copy
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 496);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Name = "Pop_Yield_Copy";
			this.Text = "Copy Yield";
			this.Controls.SetChildIndex(this.groupBox3, 0);
			this.Controls.SetChildIndex(this.groupBox2, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.groupBox4, 0);
			this.Controls.SetChildIndex(this.groupBox5, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_SG_S)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleName_S)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_S)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_SG_T)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_StyleName_T)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_T)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Component)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();  
 
		// sg cd, component cd level
		private const int _SGLevel = 1;
		private const int _CmpLevel = 2;
 
		// type division
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";
 

		// 사이즈 자재인 경우 Specification 처리
		private string _SizeSpecCd = "", _SizeSpecName = "Size";


		// 채산 복사 실행할때, save 문 구성하는 조건
		// template level = 1 인것만 구성
		private int _HeadTemplateLevel = 1;


		// checkin/out
		private bool _CheckInFail = false;
		private bool _CheckOutFail = false;
		private string _CheckInSeq = "1";


		#endregion	  

		#region 멤버 메서드

		/// <summary>
		/// Init_Form : 
		/// </summary>
		private void Init_Form()
		{
			try
			{
				this.Text = "Copy Yield";
				lbl_MainTitle.Text = "Copy Yield";  


//				// 영문변환 사용
//				ClassLib.ComFunction.SetLangDic(this); 

				// 그리드 설정
				fgrid_Component.Set_Grid("SBC_YIELD", "5", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
				 
				fgrid_Component.Styles.Alternate.BackColor = Color.Empty;
				fgrid_Component.Styles.Frozen.BackColor = Color.Empty; 

				fgrid_Component.SelectionMode = SelectionModeEnum.Row;
				fgrid_Component.AllowDragging = AllowDraggingEnum.None;
  

				// control setting
				Init_Control();

				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
 
		}


		/// <summary>
		/// Init_Control : control setting
		/// </summary>
		private void Init_Control()
		{
			 

			DataTable dt_ret;
			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_S, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory_T, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			dt_ret.Dispose();
 


			Set_Source_Value();
 


			cmb_SG_S.Enabled = false;

     		txt_Gen_T.Enabled = false;
			cmb_SG_T.Enabled = false;
 
			if(! _SGCd.Equals("")) 
			{
				cmb_SG_S.Enabled = true;

				cmb_SG_T.Enabled = true;

//				// component 조회
//				Display_Component();
			}
 


		} 

 

		/// <summary>
		/// 
		/// </summary>
		private void Set_Source_Value()
		{

			DataTable dt_ret;
 


			cmb_Factory_S.SelectedValue = _Factory; 


			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_String(_StyleCd, " ") );  
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleName_S, 0, 1, 2, 3, 4, false, 80, 200);  
			cmb_StyleName_S.SelectedValue = _StyleCd;
			txt_Style_S.Text = _StyleCd;

		}





		/// <summary>
		/// Display_Component : 
		/// </summary>
		private void Display_Component()
		{
			try
			{
				 
				this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			
				//-----------------------------------------------------------------------------------------------
				//데이터 리스트 추출
				DataTable dt_ret;
//				dt_ret = Select_Component(txt_Factory_S.Text, 
//										  txt_Style_S.Text.Replace("-", ""),
//					                      txt_SG_S.Text );

				dt_ret = Select_Component(ClassLib.ComFunction.Empty_Combo(cmb_Factory_S, " "), 
										  ClassLib.ComFunction.Empty_Combo(cmb_StyleName_S, " ").Replace("-", ""),
									      ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " "));

				//-----------------------------------------------------------------------------------------------
				
				//-----------------------------------------------------------------------------------------------
				//데이터 그리드로 표시

				fgrid_Component.Rows.Count = fgrid_Component.Rows.Fixed;

				if(dt_ret.Rows.Count == 0) 
				{ 
					return;
				}

				fgrid_Component.Tree.Column = (int)ClassLib.TBSBC_YIELD_INFO.IxTREE; 

				ClassLib.ComFunction.Display_FlexGrid(fgrid_Component, dt_ret);  
				//-----------------------------------------------------------------------------------------------

				//-----------------------------------------------------------------------------------------------
				 
				for(int i = fgrid_Component.Rows.Fixed; i < fgrid_Component.Rows.Count; i++)
				{
					// 사이즈 자재 표시
					Display_Size_Material(i); 
 
					// component 색깔 표시
					Display_Component(i);


					// 체크표시  

					// Semigood 단까지 복사 -> 모든 component 복사
					if(_ComponentCd.Equals("") )
					{
						fgrid_Component.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, CheckEnum.Checked);
					}
					else
					{ 
						// component 행 
						if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) >= _CmpLevel)
						{
//							if(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString() == _ComponentCd)
//							{
//								Check_Child(i, true);
//							}
//							else
//							{
//								Check_Child(i, false);
//							}



							Check_Child(i, true); 




						} // end if (_CmpLevel)

					} // end if(_ComponentCd.Equals("") )



				} // end for i
   
				//-----------------------------------------------------------------------------------------------
				 
				dt_ret.Dispose();


				rad_Comp.Checked = true;
				fgrid_Component.Tree.Show(_CmpLevel);

				rad_Comp_S.Checked = true;
				rad_Comp_S_CheckedChanged(null, null);



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
			}
		}


		/// <summary>
		/// Display_Size_Material : 사이즈 자재 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Size_Material(int arg_row)
		{  
			if(fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN] != null
				&& fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSIZE_YN].ToString() == "Y")
			{

				// spec 세팅
				fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_CD] = _SizeSpecCd;
				fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxSPEC_NAME] = _SizeSpecName;  
				
				fgrid_Component.Rows[arg_row].StyleNew.ForeColor = ClassLib.ComVar.ClrYield_SizeY;
				 
			
			} // end if(size_yn)

 

		}
 

		/// <summary>
		/// Display_Component : Component 표시
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Component(int arg_row)
		{

			if(Convert.ToInt32(fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _SGLevel)
			{ 
				fgrid_Component.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
			} 
			else if(Convert.ToInt32(fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel)
			{ 
				fgrid_Component.Rows[arg_row].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_2nd;
			}

		}



		/// <summary>
		/// Check_Child : 체크표시
		/// </summary>
		/// <param name="arg_row">component row</param>
		private void Check_Child(int arg_row, bool arg_check)
		{  
			int start_row = -1, end_row = -1; 

			C1.Win.C1FlexGrid.Node node = null;

			start_row = arg_row;

			node = fgrid_Component.Rows[arg_row].Node;

			if(node.Children == 0)
			{ 
				end_row = arg_row;
			}
			else
			{  
				end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

				while(true)
				{
					node = fgrid_Component.Rows[end_row].Node;
					
					if(node.Children == 0) break;

					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

				} // end while 

			} // end if 





			for(int i = end_row; i >= start_row; i--)
			{
				fgrid_Component.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, (arg_check) ? CheckEnum.Checked : CheckEnum.Unchecked);

			} // end for i

 


		}


		/// <summary>
		/// Check_Parent : 상위 체크
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_check"></param>
		private void Check_Parent(int arg_row, bool arg_check)
		{
			int parent_row = -1;  
			C1.Win.C1FlexGrid.Node node = null; 

			parent_row = arg_row;

			while(true)
			{ 
				node = fgrid_Component.Rows[parent_row].Node;
				
				if(arg_check)
				{
					fgrid_Component.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, CheckEnum.Checked);
				}
				else
				{
					//다른 하위 노드에 check 있으면 check 상태 유지  

					// true : 다른 하위 노드 체크 되어 있는 경우 -> 상위는 체크 해제하지 않음
					bool other_check = Check_Other_Item(parent_row);

					if(other_check) break;

					fgrid_Component.SetCellCheck(parent_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, CheckEnum.Unchecked);

				}
 
				if(node.Level == _CmpLevel) break; 

				parent_row = node.GetNode(NodeTypeEnum.Parent).Row.Index;

			} // end while  
		}



		/// <summary>
		/// Check_Other_Item : 다른 하위 노드 체크 여부
		/// </summary>
		/// <param name="arg_row"></param>
		/// <returns>true : 다른 하위 노드 체크 되어 있는 경우</returns>
		private bool Check_Other_Item(int arg_row)
		{
			int start_row = -1, end_row = -1;
			int check_count = 0;

			C1.Win.C1FlexGrid.Node node = null;

			start_row = arg_row;

			node = fgrid_Component.Rows[arg_row].Node;

			if(node.Children == 0)
			{ 
				end_row = arg_row;
			}
			else
			{  
				end_row = node.GetNode(NodeTypeEnum.LastChild).Row.SafeIndex;

				while(true)
				{
					node = fgrid_Component.Rows[end_row].Node;
					
					if(node.Children == 0) break;

					end_row = node.GetNode(NodeTypeEnum.LastChild).Row.Index;

				} // end while 

			} // end if


			for(int i = start_row; i <= end_row; i++)
			{
				// template_level = 1 이고, 현재 선택 반영했던 행 제외하고, 체크된 노드가 있을 경우
				// 상위 체크는 해제 할 수 없도록 처리
				if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() ) == _HeadTemplateLevel
					&& i != arg_row
					&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
				{
					check_count++;
				}

			} // end for i


			if(check_count == 0)
				return false;
			else
				return true;

		}



		/// <summary>
		/// Display_Check : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Display_Check(int arg_row)
		{ 

			bool check = (fgrid_Component.GetCellCheck(arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE) == CheckEnum.Checked) ? true : false;

			Check_Child(arg_row, check);

			if(Convert.ToInt32(fgrid_Component[arg_row, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) > _CmpLevel)
			{
				Check_Parent(arg_row, check);
			}

		}


		
		 

		/// <summary>
		/// Copy_Yield : 채산값 복사
		/// </summary>
		private void Copy_Yield()
		{ 
			 

			try
			{

				DialogResult dr;
				bool check_flag = false;
				bool save_flag = false;
 
 
				//------------------------------------------------------------------------------------------------------------------------
				//1. check copy condition
				//------------------------------------------------------------------------------------------------------------------------
				check_flag = Check_Copy_Condition();  
				if(!check_flag) return;

 
				//------------------------------------------------------------------------------------------------------------------------
				//2. check duplicate data
				//------------------------------------------------------------------------------------------------------------------------
				check_flag = Check_Duplicate();  
				if(!check_flag) 
				{
					dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseRun, this); 
				}
				else
				{
					string msg = "Would you remove old yield data" + "\r\n\r\n" + "and insert new yield data ?"; 
					dr = ClassLib.ComFunction.User_Message(msg, "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				} 

			
				if(dr == DialogResult.No) return;  

				//------------------------------------------------------------------------------------------------------------------------
				// 3. style의 check in/out 상태 조회
				//------------------------------------------------------------------------------------------------------------------------
				string division = "I"; // In
				string factory = cmb_Factory_T.SelectedValue.ToString();
				string stylecd = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				string checkuser = ClassLib.ComVar.This_User; 

				string remarks = "yield copy"; 

				if(_SGCd.Trim().Equals("") )
				{
					remarks += " by style";
				}
				else
				{
					remarks += " by component";
				}




				#region Check in 1)


				//			// 1) job factory Webservice 로 변경
				//			// 2) job factory Checkin table insert 처리
				//			// 3) user factory Webservice 로 변경
				//			// 4) 2) 성공 시 user factory Checkin table insert 처리
				//			// 5) 4) 성공 시 최종 Checkin 성공
				//
				//
				//			// 1) job factory Webservice 로 변경  
				//			string websvc_factory = "";
				//
				//			
				//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				//			{
				//				websvc_factory = factory;
				//			}
				//			else
				//			{
				//				websvc_factory = ClassLib.ComVar.DSFactory;
				//			}
				//
				//			
				//			
				//
				//			// 2) job factory Checkin table insert 처리
				//			string checkin_user = Form_BC_Yield_withExcel.Check_InOut_1(division, factory, stylecd, checkuser, websvc_factory);
				//
				//
				//			// 3) user factory Webservice 로 변경 
				//			websvc_factory = ClassLib.ComVar.This_Factory;
				//
				//
				//			// 4) 2) 성공 시 user factory Checkin table insert 처리
				//			if(checkin_user.Trim() != ClassLib.ComVar.This_User.Trim() )
				//			{
				//   
				//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user.Trim(); 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//				return;
				//
				//			} 
				//
				//
				//
				//			// 5) 4) 성공 시 최종 Checkin 성공
				//			checkin_user = Form_BC_Yield_withExcel.Check_InOut_1(division, factory, stylecd, checkuser, websvc_factory);
				//
				//			if(checkin_user.Trim() != ClassLib.ComVar.This_User.Trim() )
				//			{   
				//
				//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user.Trim(); 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//				return;
				//
				//
				//			}
 

				#endregion 

				#region Check in 2)
 
	
				// 1) job factory Webservice 로 변경
				// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
				// 3) user factory Webservice 로 변경
				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				// 11) 10) 성공 시 최종 Checkin 성공
	
	
				//			// 1) job factory Webservice 로 변경
				//			string websvc_factory = ""; 
				//			
				//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				//			{
				//				websvc_factory = factory;
				//			}
				//			else
				//			{
				//				websvc_factory = ClassLib.ComVar.DSFactory;
				//			} 
				//				
				//			// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				//			// 3) user factory Webservice 로 변경
				//			DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);
				//			websvc_factory = ClassLib.ComVar.This_Factory;
				//			
				//
				//			string job_checkin_seq = "";
				//			string job_checkin_user = "";
				//
				//			if(dt_job == null)
				//			{ 
				//				 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//
				//			}
				//			else
				//			{
				//				job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
				//				job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				//			}
				//
				//			
				//
				//			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				//			DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
				//
				//			string user_checkin_seq = "";
				//			string user_checkin_user = "";
				//
				//			if(dt_user == null)
				//			{
				// 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//
				//			}
				//			else
				//			{
				//				user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
				//				user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				//			}
				//
				//
				//
				//			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
				//
				//			//**********************************************//
				//			//* 예기치 않은 경우의 checkin out 안되는 문제 *// 
				//			//**********************************************//
				// 
				//			if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				//			{ 
				//			 
				//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//			} 
				//
				//
				//			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				//			string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				//		 
				//
				//			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
				//			if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				//			{
				//				websvc_factory = factory;
				//			}
				//			else
				//			{
				//				websvc_factory = ClassLib.ComVar.DSFactory;
				//			} 
				//
				//			
				//			// 8) job factory Checkin table insert 처리
				//			// 9) user factory Webservice 로 변경
				//			DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
				//			websvc_factory = ClassLib.ComVar.This_Factory; 
				//
				//
				//			if(ds_job == null)
				//			{
				//  
				//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus(); 
				//	
				//				return;
				//
				//			}
				//			
				//
				//			
				//			// 10) 8) 성공 시 user factory Checkin table insert 처리 
				//			DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
				//
				//			if(ds_user == null)
				//			{
				// 
				//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//			}
				//
				//
				//			// 11) 10) 성공 시 최종 Checkin 성공  


				#endregion

				#region Check in : Line 이상있는 경우, Checkin Local만 시도
 
	
				// 1) job factory Webservice 로 변경
				// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
				// 3) user factory Webservice 로 변경
				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				// 11) 10) 성공 시 최종 Checkin 성공
	
	 
				
			
				//			// 3) user factory Webservice 로 변경 
				//			string websvc_factory = ""; 
				//			websvc_factory = ClassLib.ComVar.This_Factory;
				//			
				//
				//			string job_checkin_seq = "0";
				//			string job_checkin_user = ClassLib.ComVar.This_User.Trim();
				//
				//			
				//			 
				//
				//			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				//			DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(factory, stylecd, checkuser, websvc_factory);  
				//
				//			string user_checkin_seq = "";
				//			string user_checkin_user = "";
				//
				//			if(dt_user == null)
				//			{
				//  
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//
				//			}
				//			else
				//			{
				//				user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
				//				user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				//			}
				//
				//
				//
				//
				//			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  
				//
				//			job_checkin_user = user_checkin_user;
				// 
				//			if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				//			{ 
				//				 
				//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//			} 
				//
				//
				//			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				//			string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq; 
				//
				// 
				//		 
				//			// 9) user factory Webservice 로 변경 
				//			websvc_factory = ClassLib.ComVar.This_Factory;  
				//
				//			
				//			// 10) 8) 성공 시 user factory Checkin table insert 처리 
				//			DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(division, factory, stylecd, checkinseq, checkuser, websvc_factory);
				//
				//			if(ds_user == null)
				//			{ 
				//	
				//				string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
				//				string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
				//				ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
				//				txt_Style_T.Focus();
				//	
				//				return;
				//
				//			}
				//
				//
				//			// 11) 10) 성공 시 최종 Checkin 성공 

 


				#endregion 

				#region Check in : 메세지 박스 출력 없는 경우

				if( _CheckOutFail ) return;


				// check in/out cancel 
				bool checkin_cancel = false;

				DataTable dt_ret = ClassLib.ComVar.Select_ComCode(factory, ClassLib.ComVar.CxYieldCheckinCancel);
	
				if(dt_ret != null && dt_ret.Rows.Count > 0)
				{
					checkin_cancel = (dt_ret.Rows[0].ItemArray[1].ToString().Trim().ToUpper().Equals("Y") ) ? true : false;
				}
				else
				{
					checkin_cancel = false;
				}



				bool checkin_ok = false;

				if(checkin_cancel)   // local 만 체크
				{
					checkin_ok = Run_Check_In_Local(division, factory, stylecd, checkuser, remarks);
				}
				else  // remote, local 모두 체크
				{
					checkin_ok = Run_Check_In_RemoteLocal(division, factory, stylecd, checkuser, remarks);
				}


				if(! checkin_ok) 
				{
					_CheckInFail = true;
					return;
				}
				else
				{
					_CheckInFail = false;
				}


				#endregion
 

				//4. save sbc_yield_value, sbc_yield_info
				//if(_ComponentCd.Trim().Equals("") )

				/*
				int component_count = 0;

			
				for(int i = fgrid_Component.Rows.Fixed; i < fgrid_Component.Rows.Count; i++)
				{
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{
						component_count++;
						break;
					}
				}
				*/


				if(_SGCd.Trim().Equals("") )
				{
					save_flag = Copy_Yield_DB();
				}
				else
				{
					save_flag = Copy_Yield_DB_Component();
				}
 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);

					// checkout
					Run_Check_Out();

					return;
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);
				} 


			}
			catch
			{

				// checkout
				Run_Check_Out();

			}


		}




		/// <summary>
		/// Run_Check_Out : 
		/// </summary>
		private void Run_Check_Out()
		{
			

			if( _CheckInFail ) return;

			 

			string division = "O"; // Out
			string factory = cmb_Factory_T.SelectedValue.ToString();
			string stylecd = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
			string checkuser = ClassLib.ComVar.This_User;
			string remarks = "check out";
 

			string job_factory = ClassLib.ComVar.This_Factory; 
			DataSet ds_ret = Form_BC_Yield_withExcel. Save_Check_InOut(division, factory, stylecd, _CheckInSeq, checkuser, remarks, job_factory);


			if(ds_ret == null)
			{
				_CheckOutFail = true;
				ClassLib.ComFunction.User_Message("Check Out Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			else
			{
				_CheckOutFail = false;
				//ClassLib.ComFunction.User_Message("Check Out Success.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
			}



		}




		/// <summary>
		/// Run_Check_In_RemoteLocal : 정상적인 Checkin (remote, local 모두 체크)
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_RemoteLocal(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
  
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	
			try
			{

				// 1) job factory Webservice 로 변경
				string websvc_factory = ""; 
			
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 
				
				// 2) job factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				// 3) user factory Webservice 로 변경
				DataTable dt_job = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "";
				string job_checkin_user = "";

				if(dt_job == null)
				{ 
					
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;


				}
				else
				{
					job_checkin_seq = dt_job.Rows[0].ItemArray[0].ToString();
					job_checkin_user = dt_job.Rows[0].ItemArray[1].ToString(); 
				}

			

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}



				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
 
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + job_checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;

				} 


				if( ! user_checkin_user.Trim().Equals("") &&  ! user_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
				
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + user_checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;

				} 



				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq;
				_CheckInSeq = checkinseq;

				// 7) 5) 가 아닌 경우,job factory Webservice 로 변경
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					websvc_factory = arg_factory;
				}
				else
				{
					websvc_factory = ClassLib.ComVar.DSFactory;
				} 

			
				// 8) job factory Checkin table insert 처리
				// 9) user factory Webservice 로 변경
				DataSet ds_job = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);
				websvc_factory = ClassLib.ComVar.This_Factory; 


				if(ds_job == null)
				{
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error (Remote)"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus(); 
	
					return false;

				}
			

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공  
				return true;

			}
			catch
			{
				return false;
			}

  
		}



		/// <summary>
		/// Run_Check_In_Local : Line 이상있는 경우, Checkin Local만 시도
		/// </summary>
		/// <param name="arg_division"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_checkuser"></param>
		private bool Run_Check_In_Local(string arg_division, string arg_factory, string arg_stylecd, string arg_checkuser, string arg_remarks)
		{
 
	
			// 1) job factory Webservice 로 변경
			// 2) job factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 3) user factory Webservice 로 변경
			// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : next_checkin_seq, checkin_user return
			// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패
			// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출
			// 7) 5) 가 아닌 경우,job factory Webservice 로 변경  
			// 8) job factory Checkin table insert 처리
			// 9) user factory Webservice 로 변경
			// 10) 8) 성공 시 user factory Checkin table insert 처리 
			// 11) 10) 성공 시 최종 Checkin 성공
	
	  
			try
			{
				// 3) user factory Webservice 로 변경 
				string websvc_factory = ""; 
				websvc_factory = ClassLib.ComVar.This_Factory;
			

				string job_checkin_seq = "0";
				string job_checkin_user = ClassLib.ComVar.This_User.Trim();

			
				

				// 4) 2) 성공 시 user factory Checkin Table Checkin 여부 Scan : max(checkin_seq), checkin_user return
				DataTable dt_user = Form_BC_Yield_withExcel.Scan_Check_InOut(arg_factory, arg_stylecd, arg_checkuser, websvc_factory);  

				string user_checkin_seq = "";
				string user_checkin_user = "";

				if(dt_user == null)
				{
	
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Scan Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;


				}
				else
				{
					user_checkin_seq = dt_user.Rows[0].ItemArray[0].ToString();
					user_checkin_user = dt_user.Rows[0].ItemArray[1].ToString(); 
				}




				// 5) 2), 4) 둘 중 하나라도 Checkin 되어 있으면 Checkin 실패  

				job_checkin_user = user_checkin_user;
	
				if( ! job_checkin_user.Trim().Equals("") &&  ! job_checkin_user.Trim().Equals(ClassLib.ComVar.This_User.Trim()) ) 
				{ 
					
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Check In User : " + checkin_user; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;

				} 


				// 6) 5) 가 아닐 경우, 2), 4) 결과 중 next_checkin_seq max 값 산출 
				string checkinseq = (Convert.ToInt32(job_checkin_seq) > Convert.ToInt32(user_checkin_seq) ) ? job_checkin_seq : user_checkin_seq; 
				_CheckInSeq = checkinseq;
	
			
				// 9) user factory Webservice 로 변경 
				websvc_factory = ClassLib.ComVar.This_Factory;  

			
				// 10) 8) 성공 시 user factory Checkin table insert 처리 
				DataSet ds_user = Form_BC_Yield_withExcel.Save_Check_InOut(arg_division, arg_factory, arg_stylecd, checkinseq, arg_checkuser, arg_remarks, websvc_factory);

				if(ds_user == null)
				{ 
	
					string checkin_user = (job_checkin_user.Trim().Equals("")) ? user_checkin_user.Trim() : job_checkin_user.Trim(); 
					string message = "Check In Fail." + "\r\n\r\n" + "Checkin Save Error"; 
					ClassLib.ComFunction.User_Message(message, "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information); 
					txt_Style_T.Focus();
	
					return false;

				}


				// 11) 10) 성공 시 최종 Checkin 성공  
				return true;

			}
			catch
			{
				return false;
			}


		}





		/// <summary>
		/// Check_Copy_Condition : 복사 조건 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_Copy_Condition()
		{  

			if(cmb_Factory_T.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Factory Should be selected.");
				return false; 
			}

			if(cmb_StyleName_T.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Style Should be selected.");
				return false; 
			}

			if(! _SGCd.Trim().Equals("") && cmb_SG_T.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Semigood Should be selected.");
				return false; 
			}


			if(cmb_Factory_S.SelectedValue.ToString() == cmb_Factory_T.SelectedValue.ToString()
				&& cmb_StyleName_S.SelectedValue.ToString().Replace("-", "") == cmb_StyleName_T.SelectedValue.ToString().Replace("-", "") 
				&& ClassLib.ComFunction.Empty_Combo(cmb_SG_S, "") == ClassLib.ComFunction.Empty_Combo(cmb_SG_T, "") )
			{
				ClassLib.ComFunction.User_Message("Same data");
				return false; 
			}
 


			return true;


		}



		/// <summary>
		/// Check_Duplicate : 채산 복사 하기 전, target 데이터에 기존 데이터 중복 여부 체크
		/// </summary>
		/// <returns></returns>
		private bool Check_Duplicate()
		{
			// 1. style 복사 : factory, style 중복 체크
			// 2. semigood 복사 : factory, style, semigood 중복 체크
			// 3. 복수 component : semigood 복사로 체크
			// 4. 단일 component : factory, style, semigood, component 중복 체크

			string factory = "", style_cd = "";
			string semigood = "", component = ""; 

			// 체크된 component 수 
			int component_count = 0; 
			string sel_component = "";

			factory = cmb_Factory_T.SelectedValue.ToString();
			style_cd = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
			semigood = ClassLib.ComFunction.Empty_Combo(cmb_SG_T, " ");
 
					 
			// 체크된 component 수  
			for(int i = fgrid_Component.Rows.Fixed; i < fgrid_Component.Rows.Count; i++)
			{
				if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) != _CmpLevel) continue;
				if(fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Unchecked) ) continue;

				component_count++;
				sel_component = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();

			} // end for i 

				
			if(component_count == 1)   // 단일 component 
			{
				component = sel_component;
			} 
 

			// db 접속 체크
			bool duplicate_flag = Check_Duplicate(factory, style_cd, semigood, component);


			return duplicate_flag;

		}



		#endregion   

		#region 이벤트 처리
  

		private void txt_Style_S_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleName_S.SelectedIndex = -1;
				txt_Gen_S.Text = "";  
				cmb_SG_S.SelectedIndex = -1;


				Init_Combo_Style(txt_Style_S, cmb_StyleName_S);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_S_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void txt_Style_T_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				//-------------------------------------------------------------------------
				// 기타 콘트롤 초기화 
				cmb_StyleName_T.SelectedIndex = -1;
				txt_Gen_T.Text = ""; 
				cmb_SG_T.SelectedIndex = -1;



				Init_Combo_Style(txt_Style_T, cmb_StyleName_T);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_T_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		/// <summary>
		/// Init_Combo_Style : 
		/// </summary>
		/// <param name="arg_textbox"></param>
		/// <param name="arg_combobox"></param>
		private void Init_Combo_Style(TextBox arg_textbox, C1.Win.C1List.C1Combo arg_combobox)
		{
			
  
			DataTable dt_ret;
				
			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(arg_textbox, " ") ); 
				 
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, arg_combobox, 0, 1, 2, 3, 4, false, 80, 200);  


			//arg_combobox.SelectedValue = arg_textbox.Text;

			string stylecd = "";
			int exist_index = -1;

			stylecd = arg_textbox.Text.Trim();

			exist_index = arg_textbox.Text.IndexOf("-", 0);

			if(exist_index == -1 && stylecd.Length == 9)
			{
				stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
			}

			arg_combobox.SelectedValue = stylecd;





			dt_ret.Dispose();
		}



		private void cmb_StyleName_S_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				if(cmb_Factory_S.SelectedIndex == -1 || cmb_StyleName_S.SelectedIndex == -1) return;

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name  
				txt_Style_S.Text = cmb_StyleName_S.SelectedValue.ToString();
				txt_Gen_S.Text = cmb_StyleName_S.Columns[2].Text;
				txt_Presto_S.Text = cmb_StyleName_S.Columns[3].Text;


				Init_Combo_SG(ClassLib.ComFunction.Empty_Combo(cmb_Factory_S, " "),
						  	  ClassLib.ComFunction.Empty_Combo(cmb_StyleName_S, " "),
							  cmb_SG_S);



				if(! _SGCd.Trim().Equals("") )
				{
					cmb_SG_S.SelectedValue = _SGCd;
				}

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleName_S_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 
		


		private void cmb_StyleName_T_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				
				if(cmb_Factory_T.SelectedIndex == -1 || cmb_StyleName_T.SelectedIndex == -1) return;




//				//-----------------------------------------------------------------------------------
//				// style의 check in/out 상태 조회 -- DB 저장 할 때 처리
//				//-----------------------------------------------------------------------------------
//				string division = "I"; // In
//				string factory = cmb_Factory_T.SelectedValue.ToString();
//				string stylecd = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
//				string checkuser = ClassLib.ComVar.This_User; 
//
//				bool checkin_yn = Form_BC_Yield_withExcel.Check_InOut(division, factory, stylecd, checkuser);
//
//
//				if(checkin_yn)  // target 가능
//				{  
//					
//				}
//				else
//				{ 
//					ClassLib.ComFunction.User_Message("Check In Fail.", "Check In/Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
//					cmb_StyleName_T.SelectedIndex = -1;
//
//					return;
//				}
//
//
//				//-----------------------------------------------------------------------------------


				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name  
				txt_Style_T.Text = cmb_StyleName_T.SelectedValue.ToString();
				txt_Gen_T.Text = cmb_StyleName_T.Columns[2].Text;
				txt_Presto_T.Text = cmb_StyleName_T.Columns[3].Text; 


				Init_Combo_SG(ClassLib.ComFunction.Empty_Combo(cmb_Factory_T, " "),
					          ClassLib.ComFunction.Empty_Combo(cmb_StyleName_T, " "),
					          cmb_SG_T);

				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleName_T_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		/// <summary>
		/// Init_Combo_SG : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_combobox"></param>
		private void Init_Combo_SG(string arg_factory, string arg_stylecd, C1.Win.C1List.C1Combo arg_combobox)
		{
			
  
			DataTable dt_ret;

			dt_ret = ClassLib.ComFunction.Select_SBC_YIELD_SEMIGOOD(arg_factory, arg_stylecd); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, arg_combobox, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code); 

			dt_ret.Dispose();

		}


		private void cmb_SG_S_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_SG_S.SelectedIndex == -1) return;

				// component 조회
				Display_Component();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SG_S_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}



		private void fgrid_Component_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if(fgrid_Component.Rows.Count <= fgrid_Component.Rows.Fixed) return;
 
			Display_Check(e.Row);
		}



		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				Copy_Yield();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// tree view depth 설정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				RadioButton src = sender as RadioButton; 

				//라디오 버튼 태그값에 레벨값 세팅 
				//rad_cmp.tag = '1'
				//rad_all.tag = '-1'

				fgrid_Component.Tree.Show(Convert.ToInt32(src.Tag.ToString() ) ); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}






		/// <summary>
		/// 모든 데이터 체크 해제
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rad_Comp_S_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = fgrid_Component.Rows.Fixed; i < fgrid_Component.Rows.Count; i++)
				{
					fgrid_Component.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, CheckEnum.Unchecked);
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_Comp_S_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		/// <summary>
		/// 모든 데이터 체크
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rad_All_S_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{
				for(int i = fgrid_Component.Rows.Fixed; i < fgrid_Component.Rows.Count; i++)
				{
					fgrid_Component.SetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE, CheckEnum.Checked);
				}
 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_All_S_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  

		#endregion

		#region DB Connect


		/// <summary>
		/// Select_Component :  
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_sgcd"></param>
		/// <returns></returns>
		private DataTable Select_Component(string arg_factory, string arg_stylecd, string arg_sgcd)
		{
			DataSet ds_ret; 

			MyOraDB.ReDim_Parameter(4); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_COPY";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_stylecd;
			MyOraDB.Parameter_Values[2] = arg_sgcd; 
			MyOraDB.Parameter_Values[3] = ""; 


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}




		/// <summary>
		/// Copy_Yield_DB : factory, style_cd 또는 semigood 까지 복사
		/// </summary>
		/// <returns></returns>
		private bool Copy_Yield_DB()
		{
 

			try
			{
				DataSet ds_ret;

				//행 수정 상태 해제
				fgrid_Component.Select(fgrid_Component.Selection.r1, 0, fgrid_Component.Selection.r1, fgrid_Component.Cols.Count - 1, false);

				int col_ct = 18;  
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.COPY_SBC_YIELD";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY_S"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD_S"; 
				MyOraDB.Parameter_Name[2] = "ARG_GENDER_S"; 
				MyOraDB.Parameter_Name[3] = "ARG_PRESTO_YN_S"; 
				MyOraDB.Parameter_Name[4] = "ARG_SEMI_GOOD_CD_S";
				MyOraDB.Parameter_Name[5] = "ARG_COMPONENT_CD_S";
				MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_SEQ_S";
				MyOraDB.Parameter_Name[7] = "ARG_TEMPLATE_LEVEL_S";
				MyOraDB.Parameter_Name[8] = "ARG_FACTORY_T";
				MyOraDB.Parameter_Name[9]  = "ARG_STYLE_CD_T";
				MyOraDB.Parameter_Name[10] = "ARG_GENDER_T";
				MyOraDB.Parameter_Name[11] = "ARG_PRESTO_YN_T";
				MyOraDB.Parameter_Name[12] = "ARG_SEMI_GOOD_CD_T";  
				MyOraDB.Parameter_Name[13] = "ARG_UPD_FACTORY"; 
				MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";  
				MyOraDB.Parameter_Name[15] = "ARG_DIVISION";  
				MyOraDB.Parameter_Name[16] = "ARG_STYLE_CD_CHECKIN"; 
				MyOraDB.Parameter_Name[17] = "ARG_STYLE_CD_CHECKINSEQ"; 
			
 



				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
 
				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct * 4];  


				#region Set Parameter_Values

				  
				// delete
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_T, " ");  
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "D";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";


				// insert
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_T, " ");  
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "I";
				MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;


				// history
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_T, " ");  
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "H";
				MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;


				// check out
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = " ";
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComFunction.Empty_Combo(cmb_SG_T, " ");  
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "C";
				MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;




				#endregion


				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Copy_Yield_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


		}


		/// <summary>
		/// Copy_Yield_DB_Component : component 하위 까지 복사
		/// </summary>
		/// <returns></returns>
		private bool Copy_Yield_DB_Component()
		{
 
			try
			{
				DataSet ds_ret;

				//행 수정 상태 해제
				fgrid_Component.Select(fgrid_Component.Selection.r1, 0, fgrid_Component.Selection.r1, fgrid_Component.Cols.Count - 1, false);

				int col_ct = 18; 
				int save_ct = 0;
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBC_YIELD.COPY_SBC_YIELD";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY_S"; 
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD_S"; 
				MyOraDB.Parameter_Name[2] = "ARG_GENDER_S"; 
				MyOraDB.Parameter_Name[3] = "ARG_PRESTO_YN_S"; 
				MyOraDB.Parameter_Name[4] = "ARG_SEMI_GOOD_CD_S";
				MyOraDB.Parameter_Name[5] = "ARG_COMPONENT_CD_S";
				MyOraDB.Parameter_Name[6] = "ARG_TEMPLATE_SEQ_S";
				MyOraDB.Parameter_Name[7] = "ARG_TEMPLATE_LEVEL_S";
				MyOraDB.Parameter_Name[8] = "ARG_FACTORY_T";
				MyOraDB.Parameter_Name[9]  = "ARG_STYLE_CD_T";
				MyOraDB.Parameter_Name[10] = "ARG_GENDER_T";
				MyOraDB.Parameter_Name[11] = "ARG_PRESTO_YN_T";
				MyOraDB.Parameter_Name[12] = "ARG_SEMI_GOOD_CD_T";  
				MyOraDB.Parameter_Name[13] = "ARG_UPD_FACTORY"; 
				MyOraDB.Parameter_Name[14] = "ARG_UPD_USER";  
				MyOraDB.Parameter_Name[15] = "ARG_DIVISION";  
				MyOraDB.Parameter_Name[16] = "ARG_STYLE_CD_CHECKIN"; 
				MyOraDB.Parameter_Name[17] = "ARG_STYLE_CD_CHECKINSEQ"; 
				   

				


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}


				#region 저장 행 수 구하기


				for(int i = fgrid_Component.Rows.Fixed ; i < fgrid_Component.Rows.Count; i++)
				{  
 
					// delete
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{
						save_ct++;
					}


					// data
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() ) == _HeadTemplateLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{
						save_ct++;
					} 



				} // end for i
		

				for(int i = fgrid_Component.Rows.Fixed ; i < fgrid_Component.Rows.Count; i++)
				{  
 
					// history
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{
						save_ct++;
					} 

				} // end for i
		


				#endregion


				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct * (save_ct + 1)];  
				

				#region Set Parameter_Values


				// 각 행의 변경값 Setting 
				for(int i = fgrid_Component.Rows.Fixed ; i < fgrid_Component.Rows.Count; i++)
				{    
 
					
					// delete 
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{

						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();//ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
						
						if(cmb_SG_S.SelectedValue.ToString().Trim().Equals("") )
						{
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct++] = cmb_SG_T.SelectedValue.ToString(); 
						}

						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory; 
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;
						MyOraDB.Parameter_Values[para_ct++] = "D"; 
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";

					}


					// insert
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString() ) == _HeadTemplateLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{   

						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();//ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_SEQ].ToString();
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxTEMPLATE_LEVEL].ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;

						if(cmb_SG_S.SelectedValue.ToString().Trim().Equals("") )
						{
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct++] = cmb_SG_T.SelectedValue.ToString(); 
						}

						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
						MyOraDB.Parameter_Values[para_ct++] = "I"; 
						MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;
 
					}
 
				} // end for i 



				for(int i = fgrid_Component.Rows.Fixed ; i < fgrid_Component.Rows.Count; i++)
				{  
 
					// history
					if(Convert.ToInt32(fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxLEVEL1].ToString() ) == _CmpLevel
						&& fgrid_Component.GetCellCheck(i, (int)ClassLib.TBSBC_YIELD_INFO.IxTREE).Equals(CheckEnum.Checked) )
					{

						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();//ClassLib.ComFunction.Empty_Combo(cmb_SG_S, " ");
						MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxCOMPONENT_CD].ToString();
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = "";
						MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
						MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
						MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
						
						if(cmb_SG_S.SelectedValue.ToString().Trim().Equals("") )
						{
							MyOraDB.Parameter_Values[para_ct++] = fgrid_Component[i, (int)ClassLib.TBSBC_YIELD_INFO.IxSEMI_GOOD_CD].ToString();
						}
						else
						{
							MyOraDB.Parameter_Values[para_ct++] = cmb_SG_T.SelectedValue.ToString(); 
						}


						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
						MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
						MyOraDB.Parameter_Values[para_ct++] = "H"; 
						MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
						MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;

					} 

				} // end for i


				// check out
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_S.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_S.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_S.Text;
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = "";
				MyOraDB.Parameter_Values[para_ct++] = cmb_Factory_T.SelectedValue.ToString();
				MyOraDB.Parameter_Values[para_ct++] = cmb_StyleName_T.SelectedValue.ToString().Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = txt_Gen_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = txt_Presto_T.Text;
				MyOraDB.Parameter_Values[para_ct++] = cmb_SG_T.SelectedValue.ToString();   
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_Factory;
				MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User; 
				MyOraDB.Parameter_Values[para_ct++] = "C"; 
				MyOraDB.Parameter_Values[para_ct++] = _StyleCd.Replace("-", "");
				MyOraDB.Parameter_Values[para_ct++] = _CheckInSeq;



				#endregion


				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)  // error
				{ 
					return false;
				}
			
				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Copy_Yield_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}


		}

 

		/// <summary>
		/// Check_Duplicate : 채산 복사 하기 전, target 데이터에 기존 데이터 중복 여부 체크
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_stylecd"></param>
		/// <param name="arg_sgcd"></param>
		/// <param name="arg_component"></param>
		/// <returns>true : 중복임, false : 중복아님</returns>
		private bool Check_Duplicate(string arg_factory, string arg_stylecd, string arg_sgcd, string arg_component)
		{
			DataSet ds_ret; 
			string return_value = "";

			MyOraDB.ReDim_Parameter(5); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.CHECK_EXIST_TARGET_YIELD";
  
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "ARG_SEMI_GOOD_CD";
			MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			  
			MyOraDB.Parameter_Values[0] = ClassLib.ComFunction.Empty_String(arg_factory, " ");
			MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_String(arg_stylecd, " ");
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_String(arg_sgcd, " "); 
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_String(arg_component, " "); 
			MyOraDB.Parameter_Values[4] = "";


			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return false; 
			return_value = ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

			return (return_value == "Y") ? true : false;

		}
		

		#endregion 
 




	}
}

