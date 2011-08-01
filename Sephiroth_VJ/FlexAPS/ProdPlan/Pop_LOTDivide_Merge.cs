using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexAPS.ProdPlan
{
	public class Pop_LOTDivide_Merge : COM.APSWinForm.Pop_Large
	{
		
		#region 컨트롤 정의 및 리소스 정리

		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.TextBox textBox1;
		private C1.Win.C1Command.C1OutBar obar_main;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.ImageList img_LongButton;
		private C1.Win.C1Command.C1OutPage obarpg_Divide;
		private C1.Win.C1Command.C1OutPage obarpg_Merge;
		public System.Windows.Forms.Label btn_Apply;
		public COM.FSP fgrid_Main;
		private System.Windows.Forms.Panel pnl_Info;
		public System.Windows.Forms.Panel pnl_SearchLeftImage;
		private System.Windows.Forms.TextBox txt_Model;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_ObsType;
		private System.Windows.Forms.TextBox txt_ObsID;
		private System.Windows.Forms.TextBox txt_Gen;
		private System.Windows.Forms.Label lbl_Model;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_Factory;
		public System.Windows.Forms.PictureBox picb_LBR;
		public System.Windows.Forms.PictureBox picb_LBL;
		public System.Windows.Forms.PictureBox picb_LMR;
		public System.Windows.Forms.PictureBox picb_LTR;
		public System.Windows.Forms.PictureBox picb_LTM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_LBM;
		public System.Windows.Forms.PictureBox picb_LMM;
		public System.Windows.Forms.PictureBox picb_LML;
		private C1.Win.C1List.C1Combo cmb_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.Label lbl_MergeData;
		private C1.Win.C1List.C1Combo cmb_LOTSeq;
		private System.Windows.Forms.Label lbl_PlanYMD;
		public System.Windows.Forms.DateTimePicker dpick_NextPlanYMD;
		private System.Windows.Forms.Label lbl_LOTSeqData;
		private System.Windows.Forms.TextBox txt_LastPlan;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_LOTSeqData1;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자


		public Pop_LOTDivide_Merge()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

 

		// string[] pop_parameter = new string[] {factory, obs_id, obs_type, model, style, gender, lot_no, lot_seq, line};

		ClassLib.ComVar.MPS_LOT_Action _Action_Division;
		string _Factory;
		string _OBSID;
		string _OBSType;
		string _Model;
		string _Style;
		string _Gender;
		string _LOTNo;
		string _LOTSeq;
		string _Line;


		public Pop_LOTDivide_Merge(ClassLib.ComVar.MPS_LOT_Action arg_division, string[] arg_pop_parameter)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Action_Division = arg_division;

			_Factory = arg_pop_parameter[0];
			_OBSID   = arg_pop_parameter[1];
			_OBSType = arg_pop_parameter[2];
			_Model   = arg_pop_parameter[3];
			_Style   = arg_pop_parameter[4];
			_Gender  = arg_pop_parameter[5];
			_LOTNo   = arg_pop_parameter[6];
			_LOTSeq  = arg_pop_parameter[7];
			_Line    = arg_pop_parameter[8];


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_LOTDivide_Merge));
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.obar_main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_Divide = new C1.Win.C1Command.C1OutPage();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.obarpg_Merge = new C1.Win.C1Command.C1OutPage();
			this.lbl_LOTSeqData1 = new System.Windows.Forms.Label();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.txt_LastPlan = new System.Windows.Forms.TextBox();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.lbl_LOTSeqData = new System.Windows.Forms.Label();
			this.dpick_NextPlanYMD = new System.Windows.Forms.DateTimePicker();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.cmb_LOTSeq = new C1.Win.C1List.C1Combo();
			this.lbl_MergeData = new System.Windows.Forms.Label();
			this.fgrid_Main = new COM.FSP();
			this.pnl_Info = new System.Windows.Forms.Panel();
			this.pnl_SearchLeftImage = new System.Windows.Forms.Panel();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_Model = new System.Windows.Forms.TextBox();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.txt_ObsType = new System.Windows.Forms.TextBox();
			this.txt_ObsID = new System.Windows.Forms.TextBox();
			this.txt_Gen = new System.Windows.Forms.TextBox();
			this.lbl_Model = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.lbl_DPO = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.picb_LBR = new System.Windows.Forms.PictureBox();
			this.picb_LBL = new System.Windows.Forms.PictureBox();
			this.picb_LMR = new System.Windows.Forms.PictureBox();
			this.picb_LTR = new System.Windows.Forms.PictureBox();
			this.picb_LTM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_LBM = new System.Windows.Forms.PictureBox();
			this.picb_LMM = new System.Windows.Forms.PictureBox();
			this.picb_LML = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.obar_main)).BeginInit();
			this.obar_main.SuspendLayout();
			this.obarpg_Divide.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
			this.obarpg_Merge.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTSeq)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_Info.SuspendLayout();
			this.pnl_SearchLeftImage.SuspendLayout();
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
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(544, 439);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(72, 23);
			this.btn_Apply.TabIndex = 202;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(616, 439);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_LongButton
			// 
			this.img_LongButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_LongButton.ImageSize = new System.Drawing.Size(100, 23);
			this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
			this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(0, 0);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "";
			// 
			// obar_main
			// 
			this.obar_main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_main.Controls.Add(this.obarpg_Divide);
			this.obar_main.Controls.Add(this.obarpg_Merge);
			this.obar_main.Location = new System.Drawing.Point(248, 46);
			this.obar_main.Name = "obar_main";
			this.obar_main.Pages.Add(this.obarpg_Divide);
			this.obar_main.Pages.Add(this.obarpg_Merge);
			this.obar_main.SelectedIndex = 1;
			this.obar_main.Size = new System.Drawing.Size(438, 150);
			// 
			// obarpg_Divide
			// 
			this.obarpg_Divide.Controls.Add(this.cmb_LineCd);
			this.obarpg_Divide.Controls.Add(this.lbl_LineCd);
			this.obarpg_Divide.Location = new System.Drawing.Point(0, 0);
			this.obarpg_Divide.Name = "obarpg_Divide";
			this.obarpg_Divide.Size = new System.Drawing.Size(0, 0);
			this.obarpg_Divide.TabIndex = 1;
			this.obarpg_Divide.Text = "Divide (Target)";
			// 
			// cmb_LineCd
			// 
			this.cmb_LineCd.AddItemCols = 0;
			this.cmb_LineCd.AddItemSeparator = ';';
			this.cmb_LineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineCd.Caption = "";
			this.cmb_LineCd.CaptionHeight = 17;
			this.cmb_LineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineCd.ColumnCaptionHeight = 18;
			this.cmb_LineCd.ColumnFooterHeight = 18;
			this.cmb_LineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineCd.ContentHeight = 16;
			this.cmb_LineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineCd.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineCd.EditorHeight = 16;
			this.cmb_LineCd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.GapHeight = 2;
			this.cmb_LineCd.ItemHeight = 15;
			this.cmb_LineCd.Location = new System.Drawing.Point(111, 17);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor" +
				":Control;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style" +
				"8{}Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(117, 20);
			this.cmb_LineCd.TabIndex = 121;
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(10, 16);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 120;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// obarpg_Merge
			// 
			this.obarpg_Merge.Controls.Add(this.lbl_LOTSeqData1);
			this.obarpg_Merge.Controls.Add(this.txt_LineName);
			this.obarpg_Merge.Controls.Add(this.txt_LastPlan);
			this.obarpg_Merge.Controls.Add(this.txt_LineCd);
			this.obarpg_Merge.Controls.Add(this.lbl_LOTSeqData);
			this.obarpg_Merge.Controls.Add(this.dpick_NextPlanYMD);
			this.obarpg_Merge.Controls.Add(this.lbl_PlanYMD);
			this.obarpg_Merge.Controls.Add(this.cmb_LOTSeq);
			this.obarpg_Merge.Controls.Add(this.lbl_MergeData);
			this.obarpg_Merge.Location = new System.Drawing.Point(0, 40);
			this.obarpg_Merge.Name = "obarpg_Merge";
			this.obarpg_Merge.Size = new System.Drawing.Size(438, 90);
			this.obarpg_Merge.TabIndex = 2;
			this.obarpg_Merge.Text = "Merge (Target)";
			// 
			// lbl_LOTSeqData1
			// 
			this.lbl_LOTSeqData1.ImageIndex = 0;
			this.lbl_LOTSeqData1.ImageList = this.img_Label;
			this.lbl_LOTSeqData1.Location = new System.Drawing.Point(10, 47);
			this.lbl_LOTSeqData1.Name = "lbl_LOTSeqData1";
			this.lbl_LOTSeqData1.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOTSeqData1.TabIndex = 262;
			this.lbl_LOTSeqData1.Text = "Last Plan Date";
			this.lbl_LOTSeqData1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(148, 25);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(80, 21);
			this.txt_LineName.TabIndex = 261;
			this.txt_LineName.Text = "";
			// 
			// txt_LastPlan
			// 
			this.txt_LastPlan.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LastPlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LastPlan.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LastPlan.Location = new System.Drawing.Point(111, 47);
			this.txt_LastPlan.MaxLength = 60;
			this.txt_LastPlan.Name = "txt_LastPlan";
			this.txt_LastPlan.ReadOnly = true;
			this.txt_LastPlan.Size = new System.Drawing.Size(117, 21);
			this.txt_LastPlan.TabIndex = 259;
			this.txt_LastPlan.Text = "";
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(111, 25);
			this.txt_LineCd.MaxLength = 60;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(36, 21);
			this.txt_LineCd.TabIndex = 260;
			this.txt_LineCd.Text = "";
			// 
			// lbl_LOTSeqData
			// 
			this.lbl_LOTSeqData.ImageIndex = 0;
			this.lbl_LOTSeqData.ImageList = this.img_Label;
			this.lbl_LOTSeqData.Location = new System.Drawing.Point(10, 25);
			this.lbl_LOTSeqData.Name = "lbl_LOTSeqData";
			this.lbl_LOTSeqData.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOTSeqData.TabIndex = 258;
			this.lbl_LOTSeqData.Text = "Line";
			this.lbl_LOTSeqData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dpick_NextPlanYMD
			// 
			this.dpick_NextPlanYMD.CustomFormat = "yyyyMMdd";
			this.dpick_NextPlanYMD.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_NextPlanYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_NextPlanYMD.Location = new System.Drawing.Point(111, 69);
			this.dpick_NextPlanYMD.Name = "dpick_NextPlanYMD";
			this.dpick_NextPlanYMD.Size = new System.Drawing.Size(119, 21);
			this.dpick_NextPlanYMD.TabIndex = 257;
			this.dpick_NextPlanYMD.ValueChanged += new System.EventHandler(this.dpick_NextPlanYMD_ValueChanged);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(10, 69);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 256;
			this.lbl_PlanYMD.Text = "Next Plan Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_LOTSeq
			// 
			this.cmb_LOTSeq.AddItemCols = 0;
			this.cmb_LOTSeq.AddItemSeparator = ';';
			this.cmb_LOTSeq.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LOTSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LOTSeq.Caption = "";
			this.cmb_LOTSeq.CaptionHeight = 17;
			this.cmb_LOTSeq.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LOTSeq.ColumnCaptionHeight = 18;
			this.cmb_LOTSeq.ColumnFooterHeight = 18;
			this.cmb_LOTSeq.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LOTSeq.ContentHeight = 16;
			this.cmb_LOTSeq.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LOTSeq.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LOTSeq.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTSeq.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LOTSeq.EditorHeight = 16;
			this.cmb_LOTSeq.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LOTSeq.GapHeight = 2;
			this.cmb_LOTSeq.ItemHeight = 15;
			this.cmb_LOTSeq.Location = new System.Drawing.Point(111, 4);
			this.cmb_LOTSeq.MatchEntryTimeout = ((long)(2000));
			this.cmb_LOTSeq.MaxDropDownItems = ((short)(5));
			this.cmb_LOTSeq.MaxLength = 32767;
			this.cmb_LOTSeq.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LOTSeq.Name = "cmb_LOTSeq";
			this.cmb_LOTSeq.PartialRightColumn = false;
			this.cmb_LOTSeq.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"8.25pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highligh" +
				"t;}Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap" +
				":True;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor" +
				":Control;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1Li" +
				"st.ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHe" +
				"ight=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=" +
				"\"1\"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrol" +
				"lBar><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" m" +
				"e=\"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"F" +
				"ooter\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle par" +
				"ent=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\"" +
				" /><InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" m" +
				"e=\"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><Select" +
				"edStyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C" +
				"1.Win.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><S" +
				"tyle parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style" +
				" parent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style " +
				"parent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Styl" +
				"e parent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style par" +
				"ent=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></Named" +
				"Styles><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Lay" +
				"out><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_LOTSeq.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LOTSeq.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LOTSeq.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LOTSeq.Size = new System.Drawing.Size(117, 20);
			this.cmb_LOTSeq.TabIndex = 255;
			this.cmb_LOTSeq.SelectedValueChanged += new System.EventHandler(this.cmb_LOTSeq_SelectedValueChanged);
			// 
			// lbl_MergeData
			// 
			this.lbl_MergeData.ImageIndex = 0;
			this.lbl_MergeData.ImageList = this.img_Label;
			this.lbl_MergeData.Location = new System.Drawing.Point(10, 3);
			this.lbl_MergeData.Name = "lbl_MergeData";
			this.lbl_MergeData.Size = new System.Drawing.Size(100, 21);
			this.lbl_MergeData.TabIndex = 254;
			this.lbl_MergeData.Text = "Target Data";
			this.lbl_MergeData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(6, 202);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(680, 228);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 242;
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// pnl_Info
			// 
			this.pnl_Info.BackColor = System.Drawing.Color.Transparent;
			this.pnl_Info.Controls.Add(this.pnl_SearchLeftImage);
			this.pnl_Info.DockPadding.Bottom = 5;
			this.pnl_Info.Location = new System.Drawing.Point(6, 46);
			this.pnl_Info.Name = "pnl_Info";
			this.pnl_Info.Size = new System.Drawing.Size(240, 156);
			this.pnl_Info.TabIndex = 243;
			// 
			// pnl_SearchLeftImage
			// 
			this.pnl_SearchLeftImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchLeftImage.Controls.Add(this.txt_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_LOT);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_StyleCd);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsType);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_ObsID);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Gen);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Model);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Style);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_DPO);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.txt_Factory);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBL);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTR);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LTM);
			this.pnl_SearchLeftImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LBM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LMM);
			this.pnl_SearchLeftImage.Controls.Add(this.picb_LML);
			this.pnl_SearchLeftImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchLeftImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchLeftImage.Location = new System.Drawing.Point(0, 0);
			this.pnl_SearchLeftImage.Name = "pnl_SearchLeftImage";
			this.pnl_SearchLeftImage.Size = new System.Drawing.Size(240, 151);
			this.pnl_SearchLeftImage.TabIndex = 19;
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(111, 124);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(117, 21);
			this.txt_LOT.TabIndex = 253;
			this.txt_LOT.Text = "";
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(10, 124);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 122;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Model
			// 
			this.txt_Model.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Model.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Model.Location = new System.Drawing.Point(111, 80);
			this.txt_Model.MaxLength = 60;
			this.txt_Model.Name = "txt_Model";
			this.txt_Model.ReadOnly = true;
			this.txt_Model.Size = new System.Drawing.Size(117, 21);
			this.txt_Model.TabIndex = 251;
			this.txt_Model.Text = "";
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 102);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(80, 21);
			this.txt_StyleCd.TabIndex = 247;
			this.txt_StyleCd.Text = "";
			// 
			// txt_ObsType
			// 
			this.txt_ObsType.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsType.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsType.Location = new System.Drawing.Point(192, 58);
			this.txt_ObsType.MaxLength = 60;
			this.txt_ObsType.Name = "txt_ObsType";
			this.txt_ObsType.ReadOnly = true;
			this.txt_ObsType.Size = new System.Drawing.Size(36, 21);
			this.txt_ObsType.TabIndex = 246;
			this.txt_ObsType.Text = "";
			// 
			// txt_ObsID
			// 
			this.txt_ObsID.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ObsID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ObsID.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ObsID.Location = new System.Drawing.Point(111, 58);
			this.txt_ObsID.MaxLength = 60;
			this.txt_ObsID.Name = "txt_ObsID";
			this.txt_ObsID.ReadOnly = true;
			this.txt_ObsID.Size = new System.Drawing.Size(80, 21);
			this.txt_ObsID.TabIndex = 254;
			this.txt_ObsID.Text = "";
			// 
			// txt_Gen
			// 
			this.txt_Gen.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Gen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Gen.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Gen.Location = new System.Drawing.Point(192, 102);
			this.txt_Gen.MaxLength = 60;
			this.txt_Gen.Name = "txt_Gen";
			this.txt_Gen.ReadOnly = true;
			this.txt_Gen.Size = new System.Drawing.Size(36, 21);
			this.txt_Gen.TabIndex = 248;
			this.txt_Gen.Text = "";
			// 
			// lbl_Model
			// 
			this.lbl_Model.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Model.ImageIndex = 0;
			this.lbl_Model.ImageList = this.img_Label;
			this.lbl_Model.Location = new System.Drawing.Point(10, 80);
			this.lbl_Model.Name = "lbl_Model";
			this.lbl_Model.Size = new System.Drawing.Size(100, 21);
			this.lbl_Model.TabIndex = 233;
			this.lbl_Model.Text = "Model";
			this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 102);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 224;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_DPO
			// 
			this.lbl_DPO.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_DPO.ImageIndex = 0;
			this.lbl_DPO.ImageList = this.img_Label;
			this.lbl_DPO.Location = new System.Drawing.Point(10, 58);
			this.lbl_DPO.Name = "lbl_DPO";
			this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
			this.lbl_DPO.TabIndex = 229;
			this.lbl_DPO.Text = "DPO / Type";
			this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(10, 36);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 226;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(111, 36);
			this.txt_Factory.MaxLength = 60;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(117, 21);
			this.txt_Factory.TabIndex = 252;
			this.txt_Factory.Text = "";
			// 
			// picb_LBR
			// 
			this.picb_LBR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBR.Image")));
			this.picb_LBR.Location = new System.Drawing.Point(224, 135);
			this.picb_LBR.Name = "picb_LBR";
			this.picb_LBR.Size = new System.Drawing.Size(16, 16);
			this.picb_LBR.TabIndex = 23;
			this.picb_LBR.TabStop = false;
			// 
			// picb_LBL
			// 
			this.picb_LBL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LBL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBL.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBL.Image")));
			this.picb_LBL.Location = new System.Drawing.Point(0, 131);
			this.picb_LBL.Name = "picb_LBL";
			this.picb_LBL.Size = new System.Drawing.Size(168, 20);
			this.picb_LBL.TabIndex = 22;
			this.picb_LBL.TabStop = false;
			// 
			// picb_LMR
			// 
			this.picb_LMR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMR.Image")));
			this.picb_LMR.Location = new System.Drawing.Point(225, 24);
			this.picb_LMR.Name = "picb_LMR";
			this.picb_LMR.Size = new System.Drawing.Size(15, 151);
			this.picb_LMR.TabIndex = 26;
			this.picb_LMR.TabStop = false;
			// 
			// picb_LTR
			// 
			this.picb_LTR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTR.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTR.Image")));
			this.picb_LTR.Location = new System.Drawing.Point(224, 0);
			this.picb_LTR.Name = "picb_LTR";
			this.picb_LTR.Size = new System.Drawing.Size(16, 32);
			this.picb_LTR.TabIndex = 21;
			this.picb_LTR.TabStop = false;
			// 
			// picb_LTM
			// 
			this.picb_LTM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LTM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LTM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LTM.Image")));
			this.picb_LTM.Location = new System.Drawing.Point(224, 0);
			this.picb_LTM.Name = "picb_LTM";
			this.picb_LTM.Size = new System.Drawing.Size(40, 32);
			this.picb_LTM.TabIndex = 0;
			this.picb_LTM.TabStop = false;
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
			this.lbl_SubTitle1.TabIndex = 20;
			this.lbl_SubTitle1.Text = "       Seleted Info.";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_LBM
			// 
			this.picb_LBM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LBM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LBM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LBM.Image")));
			this.picb_LBM.Location = new System.Drawing.Point(131, 133);
			this.picb_LBM.Name = "picb_LBM";
			this.picb_LBM.Size = new System.Drawing.Size(93, 18);
			this.picb_LBM.TabIndex = 28;
			this.picb_LBM.TabStop = false;
			// 
			// picb_LMM
			// 
			this.picb_LMM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_LMM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LMM.Image = ((System.Drawing.Image)(resources.GetObject("picb_LMM.Image")));
			this.picb_LMM.Location = new System.Drawing.Point(160, 24);
			this.picb_LMM.Name = "picb_LMM";
			this.picb_LMM.Size = new System.Drawing.Size(72, 151);
			this.picb_LMM.TabIndex = 27;
			this.picb_LMM.TabStop = false;
			// 
			// picb_LML
			// 
			this.picb_LML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_LML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_LML.Image = ((System.Drawing.Image)(resources.GetObject("picb_LML.Image")));
			this.picb_LML.Location = new System.Drawing.Point(0, 24);
			this.picb_LML.Name = "picb_LML";
			this.picb_LML.Size = new System.Drawing.Size(168, 151);
			this.picb_LML.TabIndex = 25;
			this.picb_LML.TabStop = false;
			// 
			// Pop_LOTDivide_Merge
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(694, 471);
			this.Controls.Add(this.pnl_Info);
			this.Controls.Add(this.obar_main);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.fgrid_Main);
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Pop_LOTDivide_Merge";
			this.Text = "LOT Divide/ Merge";
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.obar_main, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_Info, 0);
			((System.ComponentModel.ISupportInitialize)(this.obar_main)).EndInit();
			this.obar_main.ResumeLayout(false);
			this.obarpg_Divide.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			this.obarpg_Merge.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LOTSeq)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_Info.ResumeLayout(false);
			this.pnl_SearchLeftImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		public bool _CloseSave = false;  
		public string _LineCdNew = "";

		#endregion 

		#region 멤버 메서드
 

		#region 초기화

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 

			try
			{
 			
				//Title 
				string title = "";

				switch(_Action_Division)
				{
					case ClassLib.ComVar.MPS_LOT_Action.Divide:
						title = "LOT Divide";
						break;

					case ClassLib.ComVar.MPS_LOT_Action.Merge:
						title = "LOT Merge";
						break;
				}

				this.Text = title;
				lbl_MainTitle.Text = title;
  


				ClassLib.ComFunction.SetLangDic(this);  
 
  
			    //grid setting
			    fgrid_Main.Set_Grid("SPO_LOT_DAILY", "2", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true);
				fgrid_Main.ExtendLastCol = false; 
 

				//Set Combo List
				Init_Control(); 


				Display_Recv_LOT();
 
 
				 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			 
		}



		/// <summary>
		/// Init_Control : 
		/// </summary>
		private void Init_Control()
		{
 
 
			txt_Factory.Text = _Factory;
			txt_ObsID.Text = _OBSID;
			txt_ObsType.Text = _OBSType;
			txt_Model.Text = _Model;
			txt_StyleCd.Text = _Style;
			txt_Gen.Text = _Gender; 

			switch(_Action_Division)
			{
				case ClassLib.ComVar.MPS_LOT_Action.Divide:
					txt_LOT.Text = _LOTNo + "-" + _LOTSeq;
					break;

				case ClassLib.ComVar.MPS_LOT_Action.Merge:
					txt_LOT.Text = _LOTNo;
					break;
			}

			


			// divide
			DataTable dt_ret = ProdBase.Form_PB_Line.Select_SPB_LINE(_Factory); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 1, 2, false, COM.ComVar.ComboList_Visible.Name);


			// merge
			dt_ret = Select_SPO_LOT_SEQ_MERGE_LIST(_Factory, _LOTNo, _LOTSeq);
			//0 : lot seq, 1 : line cd, 2 : line name, 3 : last plan date, 4 : next plan date
			ClassLib.ComCtl.Set_ComboList_Multi(dt_ret, cmb_LOTSeq, new int[]{0, 1, 2, 3, 4}, false);

			string[] cmb_titles = new string[] {"LOT Seq.", "Line Code", "Line Name", "Last Plan Date", "Next Plan Date"};
			int[] cmb_width = new int[] {60, 65, 70, 85, 85};
			bool[] cmb_visible = new bool[] {true, true, true, true, false}; 

			ClassLib.ComCtl.SetComboStyle(cmb_LOTSeq, cmb_titles, cmb_width, cmb_visible, "LOT Seq."); 


			dt_ret.Dispose();


			dpick_NextPlanYMD.CustomFormat = " "; 




			switch(_Action_Division)
			{
				case ClassLib.ComVar.MPS_LOT_Action.Divide:
					
					obar_main.SelectedPage = obarpg_Divide;
					obarpg_Merge.Visible = false;

					break;

				case ClassLib.ComVar.MPS_LOT_Action.Merge:
					
					obar_main.SelectedPage = obarpg_Merge;
					obarpg_Divide.Visible = false;
					
					break;
			}

			


 
		}  



 



		#endregion

		#region 조회


		/// <summary>
		/// Display_Recv_LOT : 
		/// </summary>
		private void Display_Recv_LOT()
		{
   
			DataSet ds_ret = Pop_SetLOTInformation.Select_SPO_LOT_INFO(_Factory, _LOTNo, _LOTSeq);
			DataTable dt_ret = ds_ret.Tables[1];

			fgrid_Main.Rows.Count = fgrid_Main.Rows.Fixed;

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_Main.AddItem(dt_ret.Rows[i].ItemArray, fgrid_Main.Rows.Count, 1);
				fgrid_Main[i + fgrid_Main.Rows.Fixed, 0] = ""; 

				// already released
				if(fgrid_Main[i + fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxRELEASE_FLAG].ToString() == "Y")
				{
					fgrid_Main.Rows[i + fgrid_Main.Rows.Fixed].AllowEditing = false;
					fgrid_Main.Rows[i + fgrid_Main.Rows.Fixed].StyleNew.BackColor = ClassLib.ComVar.ClrFinishY;
				}

			}
				


			
			Display_Subtotals();


			dt_ret.Dispose();

		}



		#region 컬럼 자동 소트 클래스
 
		/// <summary>
		/// MyComparer
		/// compares two grid rows using all columns
		/// </summary>
		public class MyComparer : IComparer
		{
			C1FlexGrid _flex;
			public MyComparer(C1FlexGrid flex)
			{
				_flex = flex;
			}
			int IComparer.Compare(object x, object y)
			{
				// get row indices
				int r1 = ((Row)x).Index;
				int r2 = ((Row)y).Index;

				// scan all columns looking for differences
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					// get display values
					string s1 = _flex.GetDataDisplay(r1, c);
					string s2 = _flex.GetDataDisplay(r2, c);

					// compare, done when a difference is found
					int cmp = string.Compare(s1, s2);
					if (cmp != 0) return cmp;
				}

				// all values are the same, use row indices
				// to keep sort stable
				return r1 - r2;
			}
		}


		#endregion 



		/// <summary>
		/// Display_Subtotals : 
		/// </summary>
		private void Display_Subtotals()
		{


			// 컬럼 자동 소트
			fgrid_Main.Sort(new MyComparer(fgrid_Main)); 


			// subtotal 
			fgrid_Main.Subtotal(AggregateEnum.Clear);
			fgrid_Main.SubtotalPosition = SubtotalPositionEnum.BelowData;  
			fgrid_Main.Styles[CellStyleEnum.Subtotal0].BackColor = ClassLib.ComVar.ClrSubTotal0;
			fgrid_Main.Styles[CellStyleEnum.Subtotal0].ForeColor = Color.Black;   
			fgrid_Main.Styles[CellStyleEnum.Subtotal1].BackColor = ClassLib.ComVar.ClrSubTotal1;
			fgrid_Main.Styles[CellStyleEnum.Subtotal1].ForeColor = Color.Black;   

			fgrid_Main.Subtotal(AggregateEnum.Sum, 1, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxCHECK_FLAG, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxTOT_QTY, "Check");
			fgrid_Main.Subtotal(AggregateEnum.Sum, 0, -1, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxTOT_QTY, "Total");

			
			fgrid_Main.AutoSizeCols((int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxCHECK_FLAG + 1, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxTOT_QTY, 1);


		}



		#endregion

		#region 버튼 및 기타 이벤트 메서드

		private void Event_Click_Apply()
		{

			// 1. spo_lot_daily_size
			// 2. spo_lot_daily
			// 3. spo_lot_size
			// 4. spo_lot
			// 5. spo_recv_lot


			bool save_check = Save_Check();

			if(! save_check) return; 


			bool save_flag = false;


			switch(_Action_Division)
			{
				case ClassLib.ComVar.MPS_LOT_Action.Divide:
					
					string d_factory = _Factory;
					string d_lot_no = _LOTNo;
					string d_lot_seq = _LOTSeq;
					string d_line_cd_new = cmb_LineCd.SelectedValue.ToString();
					string d_req_no_new = Get_Select_Req_No_String(); 
					
					_LineCdNew = d_line_cd_new;

					save_flag = RUN_LOT_DIVIDE(d_factory, d_lot_no, d_lot_seq, d_line_cd_new, d_req_no_new);
 

					break;

				case ClassLib.ComVar.MPS_LOT_Action.Merge:
					
					string m_factory = _Factory;
					string m_lot_no = _LOTNo;
					string m_lot_seq = _LOTSeq;
					string m_lot_seq_target = cmb_LOTSeq.SelectedValue.ToString(); 
					string m_line_cd_target = txt_LineCd.Text;
					string m_plan_ymd_new = MyComFunction.ConvertDate2DbType(dpick_NextPlanYMD.Text);
					string m_req_no_new = Get_Select_Req_No_String(); 
					
					_LineCdNew = m_line_cd_target;

					save_flag = RUN_LOT_MERGE(m_factory, m_lot_no, m_lot_seq, m_lot_seq_target, m_line_cd_target, m_plan_ymd_new, m_req_no_new);
  

					break;

			}


			if(! save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				_LineCdNew = "";
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
				_CloseSave = true;



				#region e-mail


//                //--------------------------------------------------------------------------------------------------
//				// e-mail
//				//--------------------------------------------------------------------------------------------------
//				System.Web.Mail.MailMessage mail = new System.Web.Mail.MailMessage();
//            
//				mail.From = COM.ComVar.This_User;
//				mail.To = "hwanjeong.jeong@dskorea.com";
//				mail.Subject = @"Shipping Schedule 'Yellow' 구간 생산계획(MPS) 변경";
//				mail.BodyFormat = System.Web.Mail.MailFormat.Html;
//				mail.Body = @"Shipping Schedule 'Yellow' 구간 생산계획(MPS) 변경되었습니다."
//					+ "\r\n\r\n" + @"Line : " + _LineCdNew
//				+ "\r\n" + @"LOT : " + _LotNo + "-" + _LotSeq;
//					 
//
//				System.Web.Mail.SmtpMail.SmtpServer = "203.228.108.7";
//				System.Web.Mail.SmtpMail.Send(mail);
//                //--------------------------------------------------------------------------------------------------


				#endregion



				this.Close();
			}

 
 
		}


		#region Save

		/// <summary>
		/// Save_Check : 
		/// </summary>
		/// <returns></returns>
		private bool Save_Check()
		{

			try
			{


				switch(_Action_Division)
				{
					case ClassLib.ComVar.MPS_LOT_Action.Divide:
						
						// 라인 미입력 체크
						if(cmb_LineCd.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select line.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}
 


						// 라인 중복 체크 
						bool exist_yn = Check_Duplicate_Line(_Factory, _LOTNo, cmb_LineCd.SelectedValue.ToString() );

						if(exist_yn)
						{
							ClassLib.ComFunction.User_Message("Select another line.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						} 

						break;

					case ClassLib.ComVar.MPS_LOT_Action.Merge:
						

						// Target 미입력 체크
						if(cmb_LOTSeq.SelectedIndex == -1)
						{
							ClassLib.ComFunction.User_Message("Select Target Data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}


						// next 선택 일자가 target 마지막 일자 이후인지 체크
						if(Convert.ToInt32(dpick_NextPlanYMD.Value.ToString("yyyyMMdd") ) <= Convert.ToInt32(txt_LastPlan.Text) )
						{
							ClassLib.ComFunction.User_Message("Select after last plan date.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}


						break;
				}

 

				
				// 선택된 req_no 없을 경우 저장 하지 않음
				int findrow = fgrid_Main.FindRow("TRUE", fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxCHECK_FLAG, false, true, false);
				if(findrow == -1)
				{
					ClassLib.ComFunction.User_Message("Select Target Request Data.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}


				


				return true;


			}
			catch
			{
				return false;
			}

		}



		/// <summary>
		/// Get_Select_Req_No_String : 선택한 req_no 리스트 조합 ("/" 이용)
		/// </summary>
		/// <returns></returns>
		private string Get_Select_Req_No_String()
		{
			 
			string req_no = "";
			string return_req_no = "";

			for(int i = fgrid_Main.Rows.Fixed; i < fgrid_Main.Rows.Count; i++)
			{

				if(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxCHECK_FLAG] == null
					|| ! Convert.ToBoolean(fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxCHECK_FLAG].ToString()) )
				{
					continue;
				} 


				req_no = fgrid_Main[i, (int)ClassLib.TBSPO_LOT_DETAIL_MPS_ACTION.IxREQ_NO].ToString();
				return_req_no += req_no + "/"; 

			}

			return return_req_no;


		}


		#endregion

		

		#endregion



		#endregion 

		#region 이벤트 처리


		#region 툴바 이벤트

		#endregion

		#region 그리드 이벤트

		
		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
		
			try
			{
				Display_Subtotals();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		#endregion

		#region 버튼 및 기타 이벤트


		#region 버튼 이미지 이벤트

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
		


		private void cmb_LOTSeq_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				if(cmb_LOTSeq.SelectedIndex == -1) return;

				//0 : lot seq, 1 : line cd, 2 : line name, 3 : last plan date, 4 : next plan date
				txt_LineCd.Text = cmb_LOTSeq.Columns[1].Text;
				txt_LineName.Text = cmb_LOTSeq.Columns[2].Text;
				txt_LastPlan.Text = cmb_LOTSeq.Columns[3].Text;
				dpick_NextPlanYMD.Text = MyComFunction.ConvertDate2Type(cmb_LOTSeq.Columns[4].Text); 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_LOTSeq_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		 

		private void dpick_NextPlanYMD_ValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{ 
				
			   dpick_NextPlanYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType; 

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_NextPlanYMD_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Event_Click_Apply();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Click_Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				
				if(!_CloseSave) 
				{
					_CloseSave = false;
				}

				this.Close();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}



		#endregion

		


		#endregion  
 
		#region 디비 연결
  

		/// <summary>
		/// Select_SPO_LOT_SEQ_MERGE_LIST : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_SEQ_MERGE_LIST(string arg_factory, string arg_lot_no, string arg_lot_seq)
		{
			try
			{ 
				
				DataSet ds_ret;  

			

				string process_name = "PKG_SPO_MPS_BSC.SELECT_SPO_LOT_SEQ_MERGE_LIST";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name; 

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no; 
				MyOraDB.Parameter_Values[2] = arg_lot_seq;  
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);  
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[0];  
			}
			catch
			{
				return null;
			}

		} 
		 
 

		/// <summary>
		/// Check_Duplicate_Line : 라인 중복 체크
		/// </summary>
		/// <returns></returns> 
		private bool Check_Duplicate_Line(string arg_factory, string arg_lot_no, string arg_line_cd)
		{
 
			try
			{
				 

				DataSet ds_ret;

				string process_name = "PKG_SPO_MPS_BSC.CHECK_DUPLICATE_LINE";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_NEW_LINE_CD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_lot_no;
				MyOraDB.Parameter_Values[2] = arg_line_cd;
				MyOraDB.Parameter_Values[3] = ""; 

				MyOraDB.Add_Select_Parameter(true);
 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				//데이터 없으면 분할 가능하도록 처리
				if(ds_ret == null) return false;
			
				string rtn_value = ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 

				if(rtn_value == "Y")
				{
					return true;
				}
				else
				{
					return false;

				}

			}
			catch
			{
				//에러 났을 경우 중복으로 간주해서 분할 할 수 없도록 처리
				return true;
			}


		}



		/// <summary>
		/// RUN_LOT_DIVIDE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_line_cd_new"></param>
		/// <param name="arg_req_no_new"></param> 
		/// <returns></returns>
		private bool RUN_LOT_DIVIDE(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_line_cd_new, string arg_req_no_new)
		{


			try
			{
				int col_ct = 6;

				MyOraDB.ReDim_Parameter(col_ct);  
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_LOT_DIVIDE";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_LINE_CD_NEW";
				MyOraDB.Parameter_Name[4] = "ARG_REQ_NO_NEW";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 

				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
  
				MyOraDB.Parameter_Values[0]  = arg_factory; 
				MyOraDB.Parameter_Values[1]  = arg_lot_no; 
				MyOraDB.Parameter_Values[2]  = arg_lot_seq; 
				MyOraDB.Parameter_Values[3]  = arg_line_cd_new; 
				MyOraDB.Parameter_Values[4]  = arg_req_no_new; 
				MyOraDB.Parameter_Values[5]  = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch
			{ 
				return false;
			}


		}
 


		/// <summary>
		/// RUN_LOT_MERGE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <param name="arg_lot_seq_target"></param>
		/// <param name="arg_line_cd_target"></param>
		/// <param name="arg_plan_ymd_new"></param>
		/// <param name="arg_req_no_new"></param>
		/// <returns></returns>
		private bool RUN_LOT_MERGE(string arg_factory, 
			string arg_lot_no, 
			string arg_lot_seq, 
			string arg_lot_seq_target, 
			string arg_line_cd_target, 
			string arg_plan_ymd_new, 
			string arg_req_no_new)
		{


			try
			{
				int col_ct = 8;

				MyOraDB.ReDim_Parameter(col_ct);  
				MyOraDB.Process_Name = "PKG_SPO_MPS_BSC.RUN_LOT_MERGE";
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_LOT_SEQ_TARGET";
				MyOraDB.Parameter_Name[4] = "ARG_LINE_CD_TARGET";
				MyOraDB.Parameter_Name[5] = "ARG_PLAN_YMD_NEW"; 
				MyOraDB.Parameter_Name[6] = "ARG_REQ_NO_NEW";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 
 
				for(int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}
  
				MyOraDB.Parameter_Values[0]  = arg_factory; 
				MyOraDB.Parameter_Values[1]  = arg_lot_no; 
				MyOraDB.Parameter_Values[2]  = arg_lot_seq; 
				MyOraDB.Parameter_Values[3]  = arg_lot_seq_target; 
				MyOraDB.Parameter_Values[4]  = arg_line_cd_target; 
				MyOraDB.Parameter_Values[5]  = arg_plan_ymd_new;  
				MyOraDB.Parameter_Values[6]  = arg_req_no_new; 
				MyOraDB.Parameter_Values[7]  = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Modify_Parameter(true);
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

				if(ds_ret == null)
				{
					return false;
				}
				else
				{
					return true;
				}

			}
			catch
			{ 
				return false;
			}


		}



		#endregion 

 
	}
}

