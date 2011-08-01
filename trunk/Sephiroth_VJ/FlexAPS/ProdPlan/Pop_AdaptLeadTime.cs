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
	public class Pop_AdaptLeadTime : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Label lbl_ApplyYMD;
		private System.Windows.Forms.Label lbl_LTCd;
		private C1.Win.C1List.C1Combo cmb_ApplyYMD;
		private System.Windows.Forms.TextBox txt_LTCd;
		public COM.FSP fgrid_DaySeq;
		public System.Windows.Forms.Label btn_Apply;
		public System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_LOT;
		private System.Windows.Forms.TextBox txt_LOT;
		private System.Windows.Forms.TextBox txt_Line;
		private System.Windows.Forms.Label lbl_Line;
		private System.Windows.Forms.TextBox txt_Style;
		private System.Windows.Forms.Label lbl_Style;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자

		public Pop_AdaptLeadTime()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}





		private string _Factory;
		private string _LOTNo;
		private string _LOTSeq;
		private string _StyleCd;
		private string _LineCd;
		private string _LTCd;
		private string _ApplyYMD;



		public Pop_AdaptLeadTime(string arg_factory, 
			string arg_lot, 
			string arg_style_cd,
			string arg_line_cd,
			string arg_leadtime_cd,
			string arg_apply_ymd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


 
			_Factory = arg_factory; 
			_StyleCd = arg_style_cd;

			string[] token = arg_lot.Split('-');
			_LOTNo = token[0];
			_LOTSeq = token[1];

			_LineCd = arg_line_cd; 
			_LTCd = arg_leadtime_cd; 
			_ApplyYMD = arg_apply_ymd;



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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_AdaptLeadTime));
			this.cmb_ApplyYMD = new C1.Win.C1List.C1Combo();
			this.txt_LTCd = new System.Windows.Forms.TextBox();
			this.lbl_ApplyYMD = new System.Windows.Forms.Label();
			this.lbl_LTCd = new System.Windows.Forms.Label();
			this.fgrid_DaySeq = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.txt_LOT = new System.Windows.Forms.TextBox();
			this.lbl_LOT = new System.Windows.Forms.Label();
			this.txt_Line = new System.Windows.Forms.TextBox();
			this.lbl_Line = new System.Windows.Forms.Label();
			this.txt_Style = new System.Windows.Forms.TextBox();
			this.lbl_Style = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMD)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DaySeq)).BeginInit();
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
			this.lbl_MainTitle.Text = "Adapt LeadTime";
			// 
			// cmb_ApplyYMD
			// 
			this.cmb_ApplyYMD.AddItemCols = 0;
			this.cmb_ApplyYMD.AddItemSeparator = ';';
			this.cmb_ApplyYMD.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_ApplyYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_ApplyYMD.Caption = "";
			this.cmb_ApplyYMD.CaptionHeight = 17;
			this.cmb_ApplyYMD.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_ApplyYMD.ColumnCaptionHeight = 18;
			this.cmb_ApplyYMD.ColumnFooterHeight = 18;
			this.cmb_ApplyYMD.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_ApplyYMD.ContentHeight = 17;
			this.cmb_ApplyYMD.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_ApplyYMD.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_ApplyYMD.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ApplyYMD.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_ApplyYMD.EditorHeight = 17;
			this.cmb_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_ApplyYMD.GapHeight = 2;
			this.cmb_ApplyYMD.ItemHeight = 15;
			this.cmb_ApplyYMD.Location = new System.Drawing.Point(109, 104);
			this.cmb_ApplyYMD.MatchEntryTimeout = ((long)(2000));
			this.cmb_ApplyYMD.MaxDropDownItems = ((short)(5));
			this.cmb_ApplyYMD.MaxLength = 32767;
			this.cmb_ApplyYMD.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_ApplyYMD.Name = "cmb_ApplyYMD";
			this.cmb_ApplyYMD.PartialRightColumn = false;
			this.cmb_ApplyYMD.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_ApplyYMD.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_ApplyYMD.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_ApplyYMD.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_ApplyYMD.Size = new System.Drawing.Size(89, 21);
			this.cmb_ApplyYMD.TabIndex = 278;
			// 
			// txt_LTCd
			// 
			this.txt_LTCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LTCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LTCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LTCd.Location = new System.Drawing.Point(299, 68);
			this.txt_LTCd.MaxLength = 60;
			this.txt_LTCd.Name = "txt_LTCd";
			this.txt_LTCd.ReadOnly = true;
			this.txt_LTCd.Size = new System.Drawing.Size(88, 21);
			this.txt_LTCd.TabIndex = 277;
			this.txt_LTCd.Text = "";
			// 
			// lbl_ApplyYMD
			// 
			this.lbl_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_ApplyYMD.ImageIndex = 0;
			this.lbl_ApplyYMD.ImageList = this.img_Label;
			this.lbl_ApplyYMD.Location = new System.Drawing.Point(8, 104);
			this.lbl_ApplyYMD.Name = "lbl_ApplyYMD";
			this.lbl_ApplyYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_ApplyYMD.TabIndex = 276;
			this.lbl_ApplyYMD.Text = "Apply Date";
			this.lbl_ApplyYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LTCd
			// 
			this.lbl_LTCd.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LTCd.ImageIndex = 0;
			this.lbl_LTCd.ImageList = this.img_Label;
			this.lbl_LTCd.Location = new System.Drawing.Point(198, 68);
			this.lbl_LTCd.Name = "lbl_LTCd";
			this.lbl_LTCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LTCd.TabIndex = 275;
			this.lbl_LTCd.Text = "L/T Code";
			this.lbl_LTCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_DaySeq
			// 
			this.fgrid_DaySeq.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_DaySeq.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_DaySeq.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_DaySeq.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_DaySeq.Location = new System.Drawing.Point(8, 128);
			this.fgrid_DaySeq.Name = "fgrid_DaySeq";
			this.fgrid_DaySeq.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_DaySeq.Size = new System.Drawing.Size(376, 152);
			this.fgrid_DaySeq.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Fixed{BackColor:Control;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_DaySeq.TabIndex = 279;
			this.fgrid_DaySeq.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_DaySeq_AfterEdit);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(243, 288);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 282;
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
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(314, 288);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 283;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_LOT
			// 
			this.txt_LOT.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LOT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LOT.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LOT.Location = new System.Drawing.Point(109, 46);
			this.txt_LOT.MaxLength = 60;
			this.txt_LOT.Name = "txt_LOT";
			this.txt_LOT.ReadOnly = true;
			this.txt_LOT.Size = new System.Drawing.Size(88, 21);
			this.txt_LOT.TabIndex = 285;
			this.txt_LOT.Text = "";
			// 
			// lbl_LOT
			// 
			this.lbl_LOT.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_LOT.ImageIndex = 0;
			this.lbl_LOT.ImageList = this.img_Label;
			this.lbl_LOT.Location = new System.Drawing.Point(8, 46);
			this.lbl_LOT.Name = "lbl_LOT";
			this.lbl_LOT.Size = new System.Drawing.Size(100, 21);
			this.lbl_LOT.TabIndex = 284;
			this.lbl_LOT.Text = "LOT";
			this.lbl_LOT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Line
			// 
			this.txt_Line.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Line.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Line.Location = new System.Drawing.Point(109, 68);
			this.txt_Line.MaxLength = 60;
			this.txt_Line.Name = "txt_Line";
			this.txt_Line.ReadOnly = true;
			this.txt_Line.Size = new System.Drawing.Size(88, 21);
			this.txt_Line.TabIndex = 287;
			this.txt_Line.Text = "";
			// 
			// lbl_Line
			// 
			this.lbl_Line.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Line.ImageIndex = 0;
			this.lbl_Line.ImageList = this.img_Label;
			this.lbl_Line.Location = new System.Drawing.Point(8, 68);
			this.lbl_Line.Name = "lbl_Line";
			this.lbl_Line.Size = new System.Drawing.Size(100, 21);
			this.lbl_Line.TabIndex = 286;
			this.lbl_Line.Text = "Line";
			this.lbl_Line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Style
			// 
			this.txt_Style.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Style.Location = new System.Drawing.Point(299, 46);
			this.txt_Style.MaxLength = 60;
			this.txt_Style.Name = "txt_Style";
			this.txt_Style.ReadOnly = true;
			this.txt_Style.Size = new System.Drawing.Size(88, 21);
			this.txt_Style.TabIndex = 289;
			this.txt_Style.Text = "";
			// 
			// lbl_Style
			// 
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(198, 46);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 288;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_AdaptLeadTime
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 320);
			this.Controls.Add(this.txt_Style);
			this.Controls.Add(this.lbl_Style);
			this.Controls.Add(this.txt_Line);
			this.Controls.Add(this.lbl_Line);
			this.Controls.Add(this.txt_LOT);
			this.Controls.Add(this.lbl_LOT);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.fgrid_DaySeq);
			this.Controls.Add(this.cmb_ApplyYMD);
			this.Controls.Add(this.txt_LTCd);
			this.Controls.Add(this.lbl_ApplyYMD);
			this.Controls.Add(this.lbl_LTCd);
			this.Name = "Pop_AdaptLeadTime";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adapt LeadTime";
			this.Load += new System.EventHandler(this.Pop_AdaptLeadTime_Load);
			this.Activated += new System.EventHandler(this.Pop_AdaptLeadTime_Activated);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_LTCd, 0);
			this.Controls.SetChildIndex(this.lbl_ApplyYMD, 0);
			this.Controls.SetChildIndex(this.txt_LTCd, 0);
			this.Controls.SetChildIndex(this.cmb_ApplyYMD, 0);
			this.Controls.SetChildIndex(this.fgrid_DaySeq, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.lbl_LOT, 0);
			this.Controls.SetChildIndex(this.txt_LOT, 0);
			this.Controls.SetChildIndex(this.lbl_Line, 0);
			this.Controls.SetChildIndex(this.txt_Line, 0);
			this.Controls.SetChildIndex(this.lbl_Style, 0);
			this.Controls.SetChildIndex(this.txt_Style, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_ApplyYMD)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_DaySeq)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의
 

		private COM.OraDB MyOraDB = new COM.OraDB(); 


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
				this.Text = "Adapt LeadTime";
				lbl_MainTitle.Text = "Adapt LeadTime";
   


				fgrid_DaySeq.Set_Grid("SPO_LOT_DAILY_ADT_LT", "1", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, true);
  


				//Set Combo List
				Init_Control(); 





			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}


			 
		}



		/// <summary>
		/// 
		/// </summary>
		private void Init_Control()
		{

 

			DataTable dt_ret = Select_SPB_LINEOP_APPLY_YMD(_Factory, _LineCd, _LTCd);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ApplyYMD, 0, 0, false, COM.ComVar.ComboList_Visible.Code);  


			txt_LOT.Text = _LOTNo + "-" + _LOTSeq;		
			txt_Style.Text = _StyleCd;
			txt_Line.Text = _LineCd;
			txt_LTCd.Text = _LTCd;
			cmb_ApplyYMD.SelectedValue = _ApplyYMD; 

 

			// search day seq list
			dt_ret = Select_SPO_LOT_DAILY_DAYSEQ(_Factory, _LOTNo, _LOTSeq);
			Display_Grid(dt_ret, fgrid_DaySeq);
			dt_ret.Dispose();


			  
			 
		} 


		/// <summary>
		/// Display_Grid : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			 
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;


			//All Select Row
			arg_fgrid.Rows.Add(); 
			arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.BackColor = ClassLib.ComVar.ClrDarkSel;



			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[i + arg_fgrid.Rows.Fixed + 1, 0] = ""; 

				//작업지시 이미 나간것에 대해서 색깔처리
				if(arg_fgrid[i + arg_fgrid.Rows.Fixed + 1, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxPLAN_STATUS] == null) continue;

				if(arg_fgrid[i + arg_fgrid.Rows.Fixed + 1, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxPLAN_STATUS].ToString() == "D")
				{
					//arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed + 1].AllowEditing = false;
					arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed + 1].StyleNew.BackColor = ClassLib.ComVar.ClrRelease;
				}
			}  
				

			 
			arg_fgrid.AutoSizeCols();

 
			 
		}


		 


		#endregion 

		#region 툴바 이벤트 메서드

		#endregion

		#region 그리드 이벤트 메서드

		#endregion

		#region 버튼 및 기타 이벤트 메서드

 
		/// <summary>
		/// Adapt_LeadTime : 
		/// </summary>
		private void Adapt_LeadTime()
		{
			
			string day_seq = "";
			bool run_flag = false;

			string apply_ymd = cmb_ApplyYMD.SelectedValue.ToString();
			 
			for(int i = fgrid_DaySeq.Rows.Fixed + 1; i < fgrid_DaySeq.Rows.Count; i++)
			{
				if(fgrid_DaySeq[i, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxCHECK_FLAG] == null) continue;

				if(!Convert.ToBoolean(fgrid_DaySeq[i, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxCHECK_FLAG].ToString()) ) continue;

				day_seq = fgrid_DaySeq[i, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxDAY_SEQ].ToString();

				this.Cursor = Cursors.WaitCursor;

				//ARG_FACTORY VARCHAR2, ARG_LOT_NO VARCHAR2, ARG_LOT_SEQ VARCHAR2, ARG_DAY_SEQ VARCHAR2,ARG_UPD_USER VARCHAR2
				
				//string arg_factory, string arg_lotno, string arg_lotseq, string arg_dayseq, string arg_applyymd) 
				run_flag = Run_SP_SPD_DAILY_OPSIZE(_Factory, _LOTNo, _LOTSeq, day_seq, apply_ymd);

				this.Cursor = Cursors.Default;

				if(run_flag)
				{
					fgrid_DaySeq[i, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxING_STATUS] = "Completed";
				} 

				fgrid_DaySeq.TopRow = i;
				System.Windows.Forms.Application.DoEvents();

			}

			 

		}



		#endregion
 

		#endregion 

		#region 이벤트 처리


		#region 툴바 이벤트

		#endregion

		#region 그리드 이벤트


		private void fgrid_DaySeq_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			
			try
			{
				if(e.Col != (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxCHECK_FLAG) return;
 
				if(e.Row != fgrid_DaySeq.Rows.Fixed) return;
 
				for(int i = e.Row + 1; i < fgrid_DaySeq.Rows.Count; i++) 
				{
					//if(fgrid_DaySeq[i, (int)ClassLib.TBSPD_LOT_DAILY_ADAPT_LT.IxPLAN_STATUS].ToString() == "D") continue;
					fgrid_DaySeq[i, e.Col] = fgrid_DaySeq[e.Row, e.Col].ToString();
				}
			 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_DaySeq_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

 

		private void Pop_AdaptLeadTime_Activated(object sender, System.EventArgs e)
		{
		
			cmb_ApplyYMD.Focus();

		}

		private void Pop_AdaptLeadTime_Load(object sender, System.EventArgs e)
		{
		
			Init_Form();

		}




		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			
			try
			{

				if(cmb_ApplyYMD.SelectedIndex == -1) return;
				if(fgrid_DaySeq.Rows.Count <= fgrid_DaySeq.Rows.Fixed) return;

				Adapt_LeadTime();

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
 

		#endregion

		


		#endregion  
 
		#region 디비 연결
  
		/// <summary>
		/// Select_SPB_LINEOP_APPLY_YMD : 배치된 라인의 리드타임 코드에 대한 적용일자 리스트 추출
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_linecd"></param>
		/// <param name="arg_leadtime"></param>
		/// <returns></returns>
		private DataTable Select_SPB_LINEOP_APPLY_YMD(string arg_factory, string arg_linecd, string arg_leadtime)
		{
		
			try
			{

				DataSet ds_ret;


				string process_name = "PKG_SPO_MPS_BSC.SELECT_SPB_LINEOP_APPLY_YMD";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD"; 
				MyOraDB.Parameter_Name[2] = "ARG_LEADTIME_CD";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_linecd;
				MyOraDB.Parameter_Values[2] = arg_leadtime;
				MyOraDB.Parameter_Values[3] = "";   

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

		

		/// <summary>
		/// Select_SPO_LOT_DAILY_DAYSEQ : LOT DaySeq List
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <returns></returns>
		private DataTable Select_SPO_LOT_DAILY_DAYSEQ(string arg_factory, string arg_lotno, string arg_lotseq)
		{
			
			try
			{

				DataSet ds_ret;

				string process_name = "PKG_SPO_MPS_BSC.SELECT_SPO_LOT_DAILY_DAYSEQ";

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
				MyOraDB.Parameter_Values[1] = arg_lotno;
				MyOraDB.Parameter_Values[2] = arg_lotseq;
				MyOraDB.Parameter_Values[3] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
		}




		/// <summary>
		/// Run_SP_SPD_DAILY_OPSIZE : LOT 의 공정 사이즈 생성
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_lotno"></param>
		/// <param name="arg_lotseq"></param>
		/// <param name="arg_dayseq"></param>
		/// <param name="arg_applyymd"></param>
		/// <returns></returns>
		private bool Run_SP_SPD_DAILY_OPSIZE(string arg_factory, string arg_lotno, string arg_lotseq, string arg_dayseq, string arg_applyymd) 
		{


			try
			{

				  
				DataSet ds_ret;

				int col_ct = 6;

				MyOraDB.ReDim_Parameter(col_ct);  

				MyOraDB.Process_Name = "SP_SPD_DAILY_OPSIZE";  
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_LT_APPLY_YMD"; 
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  
  
				for (int i = 0; i < col_ct; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_lotno; 
				MyOraDB.Parameter_Values[2] = arg_lotseq;
				MyOraDB.Parameter_Values[3] = arg_dayseq; 
				MyOraDB.Parameter_Values[4] = arg_applyymd;
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User; 

				MyOraDB.Add_Run_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Run_Procedure();	 
			 
				if(ds_ret == null) 
				{
					return false; 
				}
				else
				{
					return true;
				}

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Run_SP_SPD_DAILY_OPSIZE",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			} 
		}




		#endregion

		
	


 
	}
}

