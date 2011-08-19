using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;


namespace ERP.SysBase
{
	public class Pop_PS_Schedule_List : COM.APSWinForm.Form_Top
	{
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.Panel pnl_Semlpe;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_ML;
		private C1.Win.C1Command.C1ToolBar c1ToolBar2;
		public System.Windows.Forms.PictureBox picb_MM;
		public COM.FSP fgrid_cal;
		private System.Windows.Forms.Label lbl_month;
		private C1.Win.C1List.C1Combo cmb_date; 


		#region 사용자 변수
	
		private Class_PS_Schedule schedule = null;
		
		private string caldate = null;

		#endregion

		public Pop_PS_Schedule_List()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Schedule_List));
			this.fgrid_cal = new COM.FSP();
			this.pnl_Semlpe = new System.Windows.Forms.Panel();
			this.cmb_date = new C1.Win.C1List.C1Combo();
			this.lbl_month = new System.Windows.Forms.Label();
			this.picb_BR = new System.Windows.Forms.PictureBox();
			this.picb_BL = new System.Windows.Forms.PictureBox();
			this.pnl_SearchImage = new System.Windows.Forms.Panel();
			this.picb_MR = new System.Windows.Forms.PictureBox();
			this.picb_TR = new System.Windows.Forms.PictureBox();
			this.picb_TM = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.picb_BM = new System.Windows.Forms.PictureBox();
			this.picb_ML = new System.Windows.Forms.PictureBox();
			this.c1ToolBar2 = new C1.Win.C1Command.C1ToolBar();
			this.picb_MM = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_cal)).BeginInit();
			this.pnl_Semlpe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_date)).BeginInit();
			this.pnl_SearchImage.SuspendLayout();
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
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// stbar
			// 
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// fgrid_cal
			// 
			this.fgrid_cal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_cal.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_cal.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_cal.ColumnInfo = "10,1,0,0,0,90,Columns:";
			this.fgrid_cal.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_cal.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_cal.Location = new System.Drawing.Point(8, 136);
			this.fgrid_cal.Name = "fgrid_cal";
			this.fgrid_cal.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.fgrid_cal.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_cal.Size = new System.Drawing.Size(1000, 496);
			this.fgrid_cal.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_cal.TabIndex = 98;
			this.fgrid_cal.DoubleClick += new System.EventHandler(this.fgrid_cal_DoubleClick);
			// 
			// pnl_Semlpe
			// 
			this.pnl_Semlpe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_Semlpe.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Semlpe.Controls.Add(this.cmb_date);
			this.pnl_Semlpe.Controls.Add(this.lbl_month);
			this.pnl_Semlpe.Controls.Add(this.picb_BR);
			this.pnl_Semlpe.Controls.Add(this.picb_BL);
			this.pnl_Semlpe.Controls.Add(this.pnl_SearchImage);
			this.pnl_Semlpe.DockPadding.All = 8;
			this.pnl_Semlpe.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_Semlpe.Location = new System.Drawing.Point(0, 64);
			this.pnl_Semlpe.Name = "pnl_Semlpe";
			this.pnl_Semlpe.Size = new System.Drawing.Size(1016, 72);
			this.pnl_Semlpe.TabIndex = 99;
			// 
			// cmb_date
			// 
			this.cmb_date.AddItemCols = 0;
			this.cmb_date.AddItemSeparator = ';';
			this.cmb_date.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_date.Caption = "";
			this.cmb_date.CaptionHeight = 17;
			this.cmb_date.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_date.ColumnCaptionHeight = 18;
			this.cmb_date.ColumnFooterHeight = 18;
			this.cmb_date.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_date.ContentHeight = 17;
			this.cmb_date.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_date.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_date.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_date.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_date.EditorHeight = 17;
			this.cmb_date.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_date.GapHeight = 2;
			this.cmb_date.ItemHeight = 15;
			this.cmb_date.Location = new System.Drawing.Point(119, 36);
			this.cmb_date.MatchEntryTimeout = ((long)(2000));
			this.cmb_date.MaxDropDownItems = ((short)(5));
			this.cmb_date.MaxLength = 32767;
			this.cmb_date.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_date.Name = "cmb_date";
			this.cmb_date.PartialRightColumn = false;
			this.cmb_date.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_date.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_date.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_date.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_date.Size = new System.Drawing.Size(180, 21);
			this.cmb_date.TabIndex = 97;
			this.cmb_date.SelectedValueChanged += new System.EventHandler(this.cmb_date_SelectedValueChanged);
			// 
			// lbl_month
			// 
			this.lbl_month.ImageIndex = 0;
			this.lbl_month.ImageList = this.img_Label;
			this.lbl_month.Location = new System.Drawing.Point(18, 36);
			this.lbl_month.Name = "lbl_month";
			this.lbl_month.Size = new System.Drawing.Size(100, 21);
			this.lbl_month.TabIndex = 96;
			this.lbl_month.Text = "날짜 설정";
			this.lbl_month.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BR
			// 
			this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
			this.picb_BR.Location = new System.Drawing.Point(992, 48);
			this.picb_BR.Name = "picb_BR";
			this.picb_BR.Size = new System.Drawing.Size(16, 16);
			this.picb_BR.TabIndex = 95;
			this.picb_BR.TabStop = false;
			// 
			// picb_BL
			// 
			this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
			this.picb_BL.Location = new System.Drawing.Point(8, 44);
			this.picb_BL.Name = "picb_BL";
			this.picb_BL.Size = new System.Drawing.Size(32, 20);
			this.picb_BL.TabIndex = 94;
			this.picb_BL.TabStop = false;
			// 
			// pnl_SearchImage
			// 
			this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_SearchImage.Controls.Add(this.picb_MR);
			this.pnl_SearchImage.Controls.Add(this.picb_TR);
			this.pnl_SearchImage.Controls.Add(this.picb_TM);
			this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
			this.pnl_SearchImage.Controls.Add(this.picb_BM);
			this.pnl_SearchImage.Controls.Add(this.picb_ML);
			this.pnl_SearchImage.Controls.Add(this.c1ToolBar2);
			this.pnl_SearchImage.Controls.Add(this.picb_MM);
			this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_SearchImage.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
			this.pnl_SearchImage.Name = "pnl_SearchImage";
			this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 56);
			this.pnl_SearchImage.TabIndex = 18;
			// 
			// picb_MR
			// 
			this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
			this.picb_MR.Location = new System.Drawing.Point(985, 26);
			this.picb_MR.Name = "picb_MR";
			this.picb_MR.Size = new System.Drawing.Size(15, 15);
			this.picb_MR.TabIndex = 26;
			this.picb_MR.TabStop = false;
			// 
			// picb_TR
			// 
			this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
			this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
			this.picb_TR.Location = new System.Drawing.Point(984, 0);
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
			this.picb_TM.Size = new System.Drawing.Size(1984, 32);
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
			this.lbl_SubTitle1.Text = "      일정 관리";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// picb_BM
			// 
			this.picb_BM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
			this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
			this.picb_BM.Location = new System.Drawing.Point(32, 38);
			this.picb_BM.Name = "picb_BM";
			this.picb_BM.Size = new System.Drawing.Size(952, 18);
			this.picb_BM.TabIndex = 24;
			this.picb_BM.TabStop = false;
			// 
			// picb_ML
			// 
			this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
			this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
			this.picb_ML.Location = new System.Drawing.Point(0, 24);
			this.picb_ML.Name = "picb_ML";
			this.picb_ML.Size = new System.Drawing.Size(168, 608);
			this.picb_ML.TabIndex = 25;
			this.picb_ML.TabStop = false;
			// 
			// c1ToolBar2
			// 
			this.c1ToolBar2.AutoSize = false;
			this.c1ToolBar2.BackColor = System.Drawing.SystemColors.Window;
			this.c1ToolBar2.ButtonLookVert = C1.Win.C1Command.ButtonLookFlags.TextAndImage;
			this.c1ToolBar2.CommandHolder = null;
			this.c1ToolBar2.CustomizeOptions = C1.Win.C1Command.CustomizeOptionsFlags.AllowAll;
			this.c1ToolBar2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1ToolBar2.Horizontal = false;
			this.c1ToolBar2.Location = new System.Drawing.Point(0, 0);
			this.c1ToolBar2.Movable = false;
			this.c1ToolBar2.Name = "c1ToolBar2";
			this.c1ToolBar2.Size = new System.Drawing.Size(1000, 56);
			this.c1ToolBar2.Text = "Page 1";
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
			this.picb_MM.Size = new System.Drawing.Size(2040, 608);
			this.picb_MM.TabIndex = 27;
			this.picb_MM.TabStop = false;
			// 
			// Pop_PS_Schedule_List
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 666);
			this.Controls.Add(this.pnl_Semlpe);
			this.Controls.Add(this.fgrid_cal);
			this.Name = "Pop_PS_Schedule_List";
			this.Text = "User Schedule";
			this.Load += new System.EventHandler(this.Form_PS_Schedule_List_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			this.Controls.SetChildIndex(this.fgrid_cal, 0);
			this.Controls.SetChildIndex(this.pnl_Semlpe, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_cal)).EndInit();
			this.pnl_Semlpe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_date)).EndInit();
			this.pnl_SearchImage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Form_PS_Schedule_List_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
			this.lbl_MainTitle.Text = "Schedule Calendar";


			schedule = new Class_PS_Schedule();
			
			DataTable dt = schedule.Select_SPS_Month(ClassLib.ComVar.This_Factory);
			ClassLib.ComCtl.Set_ComboList(dt, cmb_date, 0, 0);
			string Select_Month = DateTime.Now.Year.ToString() + schedule.Add_Zero(DateTime.Now.Month.ToString());
			cmb_date.SelectedValue = Select_Month;
			caldate = Select_Month;

			fgrid_cal.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Default;
			schedule.Set_Calendar_Head(fgrid_cal);
			schedule.Set_Calendar_Number(fgrid_cal, cmb_date.SelectedValue.ToString());

			
		}

		private void Open_Schedule_Write(string arg_date)
		{
			SysBase.Pop_PS_Schedule_Write write = new Pop_PS_Schedule_Write(arg_date);
			write.ShowDialog();
		}

		private void Open_Schedule_View(string arg_date)
		{
			SysBase.Pop_PS_Schedule_View view = new Pop_PS_Schedule_View(arg_date);
			view.ShowDialog();
		}

		#region 이벤트

		private void fgrid_cal_DoubleClick(object sender, System.EventArgs e)
		{
			int rownum = fgrid_cal.Selection.r1;
			int colnum = fgrid_cal.Selection.c1;
			string arg_caldate;

			if(rownum%2 == 1)
			{
				if(fgrid_cal[rownum, colnum].ToString() == "")
				{
					return;
				}
				arg_caldate = caldate + schedule.Add_Zero(fgrid_cal[rownum, colnum].ToString()); 
			
				if(fgrid_cal[rownum+1,colnum].ToString().Length == 0)//일정이 쓰여지지 않았다.
				{

					if(ClassLib.ComVar.This_Admin_YN == "Y")
					{
						Open_Schedule_Write(arg_caldate);
					}
				}
				else
				{
					Open_Schedule_View(arg_caldate);
				}
			
				schedule.Set_Calendar_Number(fgrid_cal, caldate);
			}
			else
			{
				if(fgrid_cal[rownum-1, colnum].ToString() == "")
				{
					return;
				}

				arg_caldate = caldate + schedule.Add_Zero(fgrid_cal[rownum-1, colnum].ToString()); 
			
				if(fgrid_cal[rownum,colnum].ToString().Length == 0)//일정이 쓰여지지 않았다.
				{
					if(ClassLib.ComVar.This_Admin_YN == "Y")
					{
						Open_Schedule_Write(arg_caldate);
					}
				}
				else //일정이 잡혀졌다.
				{
					Open_Schedule_View(arg_caldate);
				}

				schedule.Set_Calendar_Number(fgrid_cal, caldate);
			}
		}

		#endregion

		private void cmb_date_SelectedValueChanged(object sender, System.EventArgs e)
		{
			schedule.Set_Calendar_Number(fgrid_cal, cmb_date.SelectedValue.ToString());
			caldate = cmb_date.SelectedValue.ToString();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			schedule.Set_Calendar_Number(fgrid_cal, cmb_date.SelectedValue.ToString());
		}
	}
}

