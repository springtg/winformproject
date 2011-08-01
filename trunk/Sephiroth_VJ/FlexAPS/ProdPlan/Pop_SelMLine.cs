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
	public class Pop_SelMLine : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.Panel pnl_BB;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel pnl_BT;
		public System.Windows.Forms.Panel pnl_headerTitle1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.Panel pnl_headerTitle2;
		public System.Windows.Forms.Label lbl_SubTitle2;
		private COM.FSP fgrid_MLine;
		private COM.FSP fgrid_MLineOut;
		private System.ComponentModel.IContainer components = null;


		#endregion

		#region 생성자, 소멸자


		public Pop_SelMLine()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SelMLine));
			this.pnl_B = new System.Windows.Forms.Panel();
			this.pnl_BT = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.pnl_BB = new System.Windows.Forms.Panel();
			this.pnl_headerTitle1 = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pnl_headerTitle2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.fgrid_MLine = new COM.FSP();
			this.fgrid_MLineOut = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
			this.pnl_B.SuspendLayout();
			this.pnl_BT.SuspendLayout();
			this.pnl_BB.SuspendLayout();
			this.pnl_headerTitle1.SuspendLayout();
			this.pnl_headerTitle2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLine)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLineOut)).BeginInit();
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
			// c1CommandHolder1
			// 
			this.c1CommandHolder1.UIStrings.Content = new string[0];
			// 
			// tbtn_Search
			// 
			this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
			// 
			// tbtn_Save
			// 
			this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
			// 
			// stbar
			// 
			this.stbar.Location = new System.Drawing.Point(0, 451);
			this.stbar.Name = "stbar";
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// pnl_B
			// 
			this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_B.Controls.Add(this.pnl_BT);
			this.pnl_B.Controls.Add(this.splitter1);
			this.pnl_B.Controls.Add(this.pnl_BB);
			this.pnl_B.DockPadding.Left = 8;
			this.pnl_B.DockPadding.Right = 8;
			this.pnl_B.Location = new System.Drawing.Point(0, 64);
			this.pnl_B.Name = "pnl_B";
			this.pnl_B.Size = new System.Drawing.Size(1016, 380);
			this.pnl_B.TabIndex = 28;
			// 
			// pnl_BT
			// 
			this.pnl_BT.Controls.Add(this.fgrid_MLine);
			this.pnl_BT.Controls.Add(this.pnl_headerTitle1);
			this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_BT.DockPadding.Bottom = 5;
			this.pnl_BT.Location = new System.Drawing.Point(8, 0);
			this.pnl_BT.Name = "pnl_BT";
			this.pnl_BT.Size = new System.Drawing.Size(1000, 201);
			this.pnl_BT.TabIndex = 5;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(8, 201);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(1000, 3);
			this.splitter1.TabIndex = 4;
			this.splitter1.TabStop = false;
			// 
			// pnl_BB
			// 
			this.pnl_BB.Controls.Add(this.fgrid_MLineOut);
			this.pnl_BB.Controls.Add(this.pnl_headerTitle2);
			this.pnl_BB.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_BB.DockPadding.Bottom = 5;
			this.pnl_BB.Location = new System.Drawing.Point(8, 204);
			this.pnl_BB.Name = "pnl_BB";
			this.pnl_BB.Size = new System.Drawing.Size(1000, 176);
			this.pnl_BB.TabIndex = 3;
			// 
			// pnl_headerTitle1
			// 
			this.pnl_headerTitle1.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_headerTitle1.Controls.Add(this.pictureBox2);
			this.pnl_headerTitle1.Controls.Add(this.pictureBox3);
			this.pnl_headerTitle1.Controls.Add(this.lbl_SubTitle1);
			this.pnl_headerTitle1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_headerTitle1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_headerTitle1.Location = new System.Drawing.Point(0, 0);
			this.pnl_headerTitle1.Name = "pnl_headerTitle1";
			this.pnl_headerTitle1.Size = new System.Drawing.Size(1000, 30);
			this.pnl_headerTitle1.TabIndex = 46;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(984, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(16, 32);
			this.pictureBox2.TabIndex = 21;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(224, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(776, 32);
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Miniline List";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnl_headerTitle2
			// 
			this.pnl_headerTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_headerTitle2.Controls.Add(this.pictureBox1);
			this.pnl_headerTitle2.Controls.Add(this.pictureBox4);
			this.pnl_headerTitle2.Controls.Add(this.lbl_SubTitle2);
			this.pnl_headerTitle2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_headerTitle2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.pnl_headerTitle2.Location = new System.Drawing.Point(0, 0);
			this.pnl_headerTitle2.Name = "pnl_headerTitle2";
			this.pnl_headerTitle2.Size = new System.Drawing.Size(1000, 30);
			this.pnl_headerTitle2.TabIndex = 47;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(984, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 32);
			this.pictureBox1.TabIndex = 21;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(224, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(776, 32);
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 28;
			this.lbl_SubTitle2.Text = "      Out Miniline List";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_MLine
			// 
			this.fgrid_MLine.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MLine.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MLine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MLine.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MLine.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_MLine.Location = new System.Drawing.Point(0, 30);
			this.fgrid_MLine.Name = "fgrid_MLine";
			this.fgrid_MLine.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MLine.Size = new System.Drawing.Size(1000, 166);
			this.fgrid_MLine.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MLine.TabIndex = 47;
			// 
			// fgrid_MLineOut
			// 
			this.fgrid_MLineOut.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_MLineOut.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_MLineOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_MLineOut.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_MLineOut.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_MLineOut.Location = new System.Drawing.Point(0, 30);
			this.fgrid_MLineOut.Name = "fgrid_MLineOut";
			this.fgrid_MLineOut.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_MLineOut.Size = new System.Drawing.Size(1000, 141);
			this.fgrid_MLineOut.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_MLineOut.TabIndex = 48;
			// 
			// Pop_SelMLine
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(1016, 473);
			this.Controls.Add(this.pnl_B);
			this.Name = "Pop_SelMLine";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Select MiniLine";
			this.WindowState = System.Windows.Forms.FormWindowState.Normal;
			this.Load += new System.EventHandler(this.Pop_SelMLine_Load);
			this.Controls.SetChildIndex(this.pnl_B, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.c1ToolBar1, 0);
			this.Controls.SetChildIndex(this.stbar, 0);
			((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
			this.pnl_B.ResumeLayout(false);
			this.pnl_BT.ResumeLayout(false);
			this.pnl_BB.ResumeLayout(false);
			this.pnl_headerTitle1.ResumeLayout(false);
			this.pnl_headerTitle2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLine)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_MLineOut)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 
	
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		//한줄에 표시할 미니라인 수
		private int _StdColCount = 10;

		//한번 입력으로 생성될 Row수
		private int _StdRowCount = 5;
		
		//계산되어진 생성될 Row 세트 수
		private int _RowSetCount;

		private string _Factory, _OpCd, _LineCd;

		private string _SaveRowFlag = "SR", _SaveRowDesc = "Save Flag";
		private string _SelYNFlag = "SY", _SelYNDesc = "Sel YN";
		private string _MLineNameFlag = "MN", _MLineNameDesc = "MLine Name";
		private string _MLineCdFlag = "MC", _MLineCdDesc = "MLine Code";
		private string _CheckFlag = "CF", _CheckDesc = "Select";

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
				this.Text = "Select MiniLine";
				lbl_MainTitle.Text = "Select MiniLine"; 
 

				fgrid_MLine.Set_Grid("SPB_OPCD_LINE_MLINE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_MLine.Set_Action_Image(img_Action);
				fgrid_MLine.Font = new Font("Verdana", 7);
				fgrid_MLine.ExtendLastCol = false;

				fgrid_MLineOut.Set_Grid("SPB_OPCD_LINE_MLINE", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
				fgrid_MLineOut.Set_Action_Image(img_Action);
				fgrid_MLineOut.Font = new Font("Verdana", 7);
				fgrid_MLineOut.ExtendLastCol = false;




				Init_Control();


 
				DataTable dt_ret; 

				dt_ret = Select_SPB_OPCD_LINE_MLINE("N");
				Display_MLine(fgrid_MLine, dt_ret);
  
			
				//longthanh line
				dt_ret = Select_SPB_OPCD_LINE_MLINE("Y");
				Display_MLine(fgrid_MLineOut, dt_ret);


				dt_ret.Dispose();

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
			
			tbtn_New.Enabled = false;
			tbtn_Append.Enabled = false;
			tbtn_Insert.Enabled = false;
			tbtn_Delete.Enabled = false; 
			tbtn_Color.Enabled = false;  

			 
			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_OpCd = ClassLib.ComVar.Parameter_PopUp[1];
			_LineCd = ClassLib.ComVar.Parameter_PopUp[2];  



		} 



		#endregion

        #region 조회


		/// <summary>
		/// Display_MLine : 
		/// </summary>
		/// <param name="arg_dt"></param>
		private void Display_MLine(COM.FSP arg_fgrid, DataTable arg_dt)
		{
			
			int colcount = 0;
			int newrow = arg_fgrid.Rows.Fixed; 
			int save_row = 0, selyn_row = 0, mlinename_row = 0, mlinecd_row = 0, check_row = 0;
			int start_dtrow = 0;  
			 

	
			arg_fgrid.Cols.Fixed = 2;
			arg_fgrid.Cols.Count = arg_fgrid.Cols.Fixed;
			arg_fgrid.Cols[1].TextAlign = TextAlignEnum.RightCenter;
			arg_fgrid.Cols[0].Visible = false;

			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
			arg_fgrid.Rows[1].Visible = false;

			arg_fgrid.Cols.InsertRange(arg_fgrid.Cols.Fixed, _StdColCount);
			
			for(int i = arg_fgrid.Cols.Fixed; i < arg_fgrid.Cols.Count; i++)
			{
				arg_fgrid.Cols[i].TextAlign = TextAlignEnum.CenterCenter; 
				arg_fgrid.Cols[i].ImageAlign = ImageAlignEnum.CenterCenter; 
			}

			_RowSetCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(arg_dt.Rows.Count / _StdColCount)));

			for(int i = 0; i <= _RowSetCount; i++)
			{
				arg_fgrid.Rows.InsertRange(newrow, _StdRowCount);

				arg_fgrid[newrow, 0] = _SaveRowFlag;
				arg_fgrid[newrow, 1] = _SaveRowDesc;
				arg_fgrid[newrow + 1, 0] = _SelYNFlag;
				arg_fgrid[newrow + 1, 1] = _SelYNDesc;
				arg_fgrid[newrow + 2, 0] = _MLineNameFlag;
				arg_fgrid[newrow + 2, 1] = _MLineNameDesc;
				arg_fgrid[newrow + 3, 0] = _MLineCdFlag;
				arg_fgrid[newrow + 3, 1] = _MLineCdDesc;
				arg_fgrid[newrow + 4, 0] = _CheckFlag;
				arg_fgrid[newrow + 4, 1] = _CheckDesc; 

				save_row = newrow;
				selyn_row = newrow + 1;
				mlinename_row = newrow + 2;
				mlinecd_row = newrow + 3;
				check_row = newrow + 4;

				arg_fgrid.Rows[save_row].Visible = false;
				arg_fgrid.Rows[selyn_row].Visible = false;
				arg_fgrid.Rows[mlinecd_row].Visible = false;

				arg_fgrid.Rows[check_row].StyleNew.DataType = typeof(bool);

				for(int j = start_dtrow; j < arg_dt.Rows.Count; j++)
				{
					if(colcount == _StdColCount)
					{
						colcount = 0;
						start_dtrow = j;
						break;
					}

					arg_fgrid[save_row, colcount + fgrid_MLine.Cols.Fixed] = ""; 
					arg_fgrid[selyn_row, colcount + fgrid_MLine.Cols.Fixed] = arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBSEL_YN].ToString();
					arg_fgrid[mlinecd_row, colcount + fgrid_MLine.Cols.Fixed] = arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBMLINE_CD].ToString();
					arg_fgrid[mlinename_row, colcount + fgrid_MLine.Cols.Fixed] = arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBMLINE_NAME].ToString();

					if(arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBSEL_YN].ToString() == "Y" ) 
						arg_fgrid[check_row, colcount + fgrid_MLine.Cols.Fixed] = "TRUE";
					else
						arg_fgrid[check_row, colcount + fgrid_MLine.Cols.Fixed] = "FALSE";
				
					if(arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBLINE_COLOR].ToString() != "")
					{
						arg_fgrid.GetCellRange(save_row, colcount + fgrid_MLine.Cols.Fixed, check_row, colcount + fgrid_MLine.Cols.Fixed).StyleNew.BackColor
							= Color.FromArgb(Convert.ToInt32(arg_dt.Rows[j].ItemArray[(int)ClassLib.TBSPB_OPCD_LINE_MLINE.IxTBLINE_COLOR].ToString()));
					}

					colcount++; 
				} 

				newrow += _StdRowCount;
			} // end for i

			
		}


		#endregion

		#region 이벤트 처리 메서드
 

		/// <summary>
		/// Event_Tbtn_Search : 
		/// </summary>
		private void Event_Tbtn_Search()
		{
 
			DataTable dt_ret;

			fgrid_MLine.Rows.Count = fgrid_MLine.Rows.Fixed;
			dt_ret = Select_SPB_OPCD_LINE_MLINE("N");
			Display_MLine(fgrid_MLine, dt_ret);
  
			//longthanh line
			dt_ret = Select_SPB_OPCD_LINE_MLINE("Y");
			Display_MLine(fgrid_MLineOut, dt_ret);

			dt_ret.Dispose(); 

		}


		/// <summary>
		/// Event_Tbtn_Save : 
		/// </summary>
		private void Event_Tbtn_Save()
		{
   

			// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
			if(ClassLib.ComVar.This_PowerUser_YN == "Y")
			{

				Pop_Password pop_password = new Pop_Password();
				pop_password.ShowDialog();

				// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
				if(! pop_password._Apply_Flag) return;
				if(! pop_password._Password_OK_Flag) return;  

			}
			else
			{
				ClassLib.ComFunction.User_Message(@"Only 'poweruser' can change miniline.", "Select Miniline", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}





			Set_SaveFlag(fgrid_MLine);
			Set_SaveFlag(fgrid_MLineOut);


			bool save_flag = Save_MiniLine();

			if(!save_flag)
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
				return;
			}
			else
			{
				ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);

				Event_Tbtn_Search();

			}
				
			 

		}



		

		#region 저장

		/// <summary>
		/// Set_SaveFlag : 
		/// </summary>
		private void Set_SaveFlag(COM.FSP arg_fgrid)
		{
			
			int startrow = arg_fgrid.Rows.Fixed; 
			int save_row = 0, selyn_row = 0, mlinename_row = 0, mlinecd_row = 0, check_row = 0;

			 
			for(int i = 0; i <= _RowSetCount; i++)
			{ 

				save_row = startrow;
				selyn_row = startrow + 1;
				mlinename_row = startrow + 2;
				mlinecd_row = startrow + 3;
				check_row = startrow + 4;

				for(int j = arg_fgrid.Cols.Fixed; j < arg_fgrid.Cols.Count; j++)
				{

					if(arg_fgrid[selyn_row, j] == null) continue;

					switch(arg_fgrid[selyn_row, j].ToString())
					{
						case "Y":

							if(!Convert.ToBoolean(arg_fgrid[check_row, j].ToString())) 
								arg_fgrid[save_row, j] = "D";
							else
								arg_fgrid[save_row, j] = "";  //"U";

							break;

						case "N":

							if(!Convert.ToBoolean(arg_fgrid[check_row, j].ToString())) 
								arg_fgrid[save_row, j] = "";
							else
								arg_fgrid[save_row, j] = "I";

							break;
					}
				} //end for j

				startrow += _StdRowCount;

			} // end for i

			 
		}


		#endregion
 


		#endregion


		#endregion 

		#region 이벤트 처리
		
		
		private void Pop_SelMLine_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 

			try
			{
				Event_Tbtn_Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				Event_Tbtn_Save();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_Tbtn_Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 

		#endregion
 
		#region 디비 연결
 

		#region 조회


		/// <summary>
		/// Select_SPB_OPCD_LINE_MLINE : 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_OPCD_LINE_MLINE(string arg_outyn)
		{  
			DataSet ds_ret;

			try
			{ 
				string process_name = "PKG_SPD_DAILY_BSC.SELECT_SPB_OPCD_LINE_MLINE";

				MyOraDB.ReDim_Parameter(5);  
				MyOraDB.Process_Name = process_name;
	 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OP_CD";  
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YN";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
					
				MyOraDB.Parameter_Values[0] = _Factory; 
				MyOraDB.Parameter_Values[1] = _OpCd; 
				MyOraDB.Parameter_Values[2] = _LineCd;
				MyOraDB.Parameter_Values[3] = arg_outyn; 
				MyOraDB.Parameter_Values[4] = ""; 

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

		#region 저장

		/// <summary>
		/// Save_MiniLine : 
		/// </summary>
		/// <returns></returns>
		private bool Save_MiniLine()
		{ 
			
			try
			{ 

				int col_ct = 6; 
				int save_ct = 0;                      
				int para_ct =0;	 
				int startrow = fgrid_MLine.Rows.Fixed; 



				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPD_DAILY_BSC.SAVE_SPB_LINEOP_MINI_MLINE";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[4] = "ARG_MLINE_CD";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 
 
				for(int i = 0; i < col_ct ; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 

				//-------------------------------------------------
				for(int i = 0; i <= _RowSetCount; i++)
				{  
					for(int j = fgrid_MLine.Cols.Fixed; j < fgrid_MLine.Cols.Count; j++)
					{
						if(fgrid_MLine[startrow, j] == null) continue;
						if(fgrid_MLine[startrow, j].ToString() != "") save_ct++;
					}  

					startrow += _StdRowCount; 
				}   


				//-------------------------------------------------
				startrow = fgrid_MLine.Rows.Fixed;

				for(int i = 0; i <= _RowSetCount; i++)
				{  
					for(int j = fgrid_MLineOut.Cols.Fixed; j < fgrid_MLineOut.Cols.Count; j++)
					{
						if(fgrid_MLineOut[startrow, j] == null) continue;
						if(fgrid_MLineOut[startrow, j].ToString() != "") save_ct++;
					}  

					startrow += _StdRowCount; 
				}  
 

				MyOraDB.Parameter_Values  = new string[col_ct * save_ct]; 
 
				//-------------------------------------------------
				startrow = fgrid_MLine.Rows.Fixed; 

				for(int i = 0; i <= _RowSetCount; i++)
				{  
					for(int j = fgrid_MLine.Cols.Fixed; j < fgrid_MLine.Cols.Count; j++)
					{
						if(fgrid_MLine[startrow, j] == null) continue;
						if(fgrid_MLine[startrow, j].ToString() == "") continue;

						MyOraDB.Parameter_Values[para_ct] = fgrid_MLine[startrow, j].ToString(); //save_flag
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory; 
						MyOraDB.Parameter_Values[para_ct + 2] = _LineCd; 
						MyOraDB.Parameter_Values[para_ct + 3] = _OpCd;  
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_MLine[startrow + 3, j].ToString(); //mline_cd
						MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 
 
						para_ct += col_ct;
					}  

					startrow += _StdRowCount; 
				}   

				//-------------------------------------------------
				startrow = fgrid_MLine.Rows.Fixed; 

				for(int i = 0; i <= _RowSetCount; i++)
				{  
					for(int j = fgrid_MLineOut.Cols.Fixed; j < fgrid_MLineOut.Cols.Count; j++)
					{
						if(fgrid_MLineOut[startrow, j] == null) continue;
						if(fgrid_MLineOut[startrow, j].ToString() == "") continue;

						MyOraDB.Parameter_Values[para_ct] = fgrid_MLineOut[startrow, j].ToString(); //save_flag
						MyOraDB.Parameter_Values[para_ct + 1] = _Factory; 
						MyOraDB.Parameter_Values[para_ct + 2] = _LineCd; 
						MyOraDB.Parameter_Values[para_ct + 3] = _OpCd;  
						MyOraDB.Parameter_Values[para_ct + 4] = fgrid_MLineOut[startrow + 3, j].ToString(); //mline_cd
						MyOraDB.Parameter_Values[para_ct + 5] = ClassLib.ComVar.This_User; 
 
						para_ct += col_ct;
					}  

					startrow += _StdRowCount; 
				}   
 
				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가 
				
				DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
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


		#endregion 




	}
}

