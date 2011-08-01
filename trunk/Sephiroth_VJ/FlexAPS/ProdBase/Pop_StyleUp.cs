using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexAPS.ProdBase
{
	public class Pop_StyleUp : COM.APSWinForm.Pop_Large
	{
		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Panel pnl_T;
		public System.Windows.Forms.Panel pnl_CSearchSplitLeft;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Close;
		private System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.TextBox txt_StyleCd;
		public COM.FSP fgrid_Main;
		private System.ComponentModel.IContainer components = null;

		public Pop_StyleUp()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_StyleUp));
			this.fgrid_Main = new COM.FSP();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Close = new System.Windows.Forms.Label();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.pnl_T = new System.Windows.Forms.Panel();
			this.pnl_CSearchSplitLeft = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.btn_Search = new System.Windows.Forms.Label();
			this.lbl_Style = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
			this.pnl_T.SuspendLayout();
			this.pnl_CSearchSplitLeft.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.lbl_MainTitle.Text = "Upper Component By Style";
			// 
			// fgrid_Main
			// 
			this.fgrid_Main.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Main.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Main.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Main.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Main.Location = new System.Drawing.Point(8, 114);
			this.fgrid_Main.Name = "fgrid_Main";
			this.fgrid_Main.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Main.Size = new System.Drawing.Size(678, 302);
			this.fgrid_Main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Main.TabIndex = 32;
			this.fgrid_Main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_BeforeEdit);
			this.fgrid_Main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Main_AfterEdit);
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(545, 427);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 23);
			this.btn_Apply.TabIndex = 67;
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
			this.btn_Close.Location = new System.Drawing.Point(616, 427);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(70, 23);
			this.btn_Close.TabIndex = 66;
			this.btn_Close.Text = "Close";
			this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			this.btn_Close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(163)), ((System.Byte)(192)), ((System.Byte)(234)));
			// 
			// pnl_T
			// 
			this.pnl_T.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_T.Controls.Add(this.pnl_CSearchSplitLeft);
			this.pnl_T.DockPadding.Bottom = 5;
			this.pnl_T.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_T.Location = new System.Drawing.Point(8, 46);
			this.pnl_T.Name = "pnl_T";
			this.pnl_T.Size = new System.Drawing.Size(678, 68);
			this.pnl_T.TabIndex = 34;
			// 
			// pnl_CSearchSplitLeft
			// 
			this.pnl_CSearchSplitLeft.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_CSearchSplitLeft.Controls.Add(this.panel1);
			this.pnl_CSearchSplitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_CSearchSplitLeft.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_CSearchSplitLeft.Location = new System.Drawing.Point(0, 0);
			this.pnl_CSearchSplitLeft.Name = "pnl_CSearchSplitLeft";
			this.pnl_CSearchSplitLeft.Size = new System.Drawing.Size(678, 63);
			this.pnl_CSearchSplitLeft.TabIndex = 26;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.txt_StyleCd);
			this.panel1.Controls.Add(this.btn_Search);
			this.panel1.Controls.Add(this.lbl_Style);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.lbl_SubTitle1);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(678, 63);
			this.panel1.TabIndex = 19;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 36);
			this.txt_StyleCd.MaxLength = 10;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.Size = new System.Drawing.Size(219, 21);
			this.txt_StyleCd.TabIndex = 214;
			this.txt_StyleCd.Text = "";
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.SystemColors.Control;
			this.btn_Search.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_MiniButton;
			this.btn_Search.Location = new System.Drawing.Point(331, 36);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(21, 21);
			this.btn_Search.TabIndex = 213;
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_Style
			// 
			this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Style.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Style.ImageIndex = 0;
			this.lbl_Style.ImageList = this.img_Label;
			this.lbl_Style.Location = new System.Drawing.Point(10, 36);
			this.lbl_Style.Name = "lbl_Style";
			this.lbl_Style.Size = new System.Drawing.Size(100, 21);
			this.lbl_Style.TabIndex = 13;
			this.lbl_Style.Text = "Style";
			this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 43);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 20);
			this.pictureBox8.TabIndex = 22;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(662, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 16);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(663, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(23, 63);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(131, 45);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(678, 18);
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(662, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 32);
			this.pictureBox4.TabIndex = 21;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(224, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(678, 32);
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(160, 24);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(678, 63);
			this.pictureBox6.TabIndex = 27;
			this.pictureBox6.TabStop = false;
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
			this.lbl_SubTitle1.Text = "      Define Style";
			this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 24);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 63);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_StyleUp
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 464);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.pnl_T);
			this.Controls.Add(this.fgrid_Main);
			this.Name = "Pop_StyleUp";
			this.Text = "Upper Component By Style";
			this.Load += new System.EventHandler(this.Pop_StyleUp_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Main, 0);
			this.Controls.SetChildIndex(this.pnl_T, 0);
			this.Controls.SetChildIndex(this.btn_Close, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
			this.pnl_T.ResumeLayout(false);
			this.pnl_CSearchSplitLeft.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
 
		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			 
			try
			{
				//Title
				this.Text = "Upper Component By Style";
				this.lbl_MainTitle.Text = "Upper Component By Style";

				ClassLib.ComFunction.SetLangDic(this);

				fgrid_Main.Set_Grid("SPB_STYLE_UP", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
				fgrid_Main.Set_Action_Image(img_Action);
    
			}
			catch
			{
			} 

		}

		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
		{
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed; 
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1; 
 
			try
			{
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
					arg_fgrid[i + arg_fgrid.Rows.Fixed, 0] = ""; 

					// 없는 데이터 일 때, 글자색 표시
					if(! Convert.ToBoolean(arg_fgrid[i + arg_fgrid.Rows.Fixed, (int)ClassLib.TBSPB_STYLE_UP.IxEXIST_YN]) )
					{
						arg_fgrid.Rows[i + arg_fgrid.Rows.Fixed].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning;
					}

				} 

				//arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
		} 

		#endregion 

		#region 이벤트 처리

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

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				dt_ret = Select_SPB_STYLE_UP(txt_StyleCd.Text.Trim().Replace("-", "") );
				Display_Grid(dt_ret, fgrid_Main);
			}
			catch
			{
			}
		}  

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				//행 수정 상태 해제
				fgrid_Main.Select(fgrid_Main.Selection.r1, 0, fgrid_Main.Selection.r1, fgrid_Main.Cols.Count - 1, false);
  
				string style_cd = fgrid_Main[fgrid_Main.Selection.r1, (int)ClassLib.TBSPB_STYLE_UP.IxSTYLE_CD].ToString();

				bool save_flag = MyOraDB.Save_FlexGird("PKG_SPB_RSC.SAVE_SPB_STYLE_UP", fgrid_Main); 

				if(save_flag)
				{

					dt_ret = Select_SPB_STYLE_UP(txt_StyleCd.Text.Trim().Replace("-", "") );
					Display_Grid(dt_ret, fgrid_Main);
					fgrid_Main.TopRow = fgrid_Main.FindRow(style_cd, fgrid_Main.Rows.Fixed, (int)ClassLib.TBSPB_STYLE_UP.IxSTYLE_CD, false, true, false);


				}


			}
			catch
			{
			}
		}

		private void btn_Close_Click(object sender, System.EventArgs e)
		{
			try
			{ 
				this.Close();
			}
			catch
			{
			}
		}

		private void fgrid_Main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			if ((fgrid_Main.Rows.Fixed > 0) && (fgrid_Main.Row >= fgrid_Main.Rows.Fixed))
			{
				if(fgrid_Main.Cols[fgrid_Main.Col].DataType == typeof(bool))
				{
					fgrid_Main.Buffer_CellData = "";
				}
				else
				{
					fgrid_Main.Buffer_CellData = (fgrid_Main[fgrid_Main.Row, fgrid_Main.Col] == null) ? "" : fgrid_Main[fgrid_Main.Row, fgrid_Main.Col].ToString();
				}
			} // end if
		}

		
		private void fgrid_Main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			// 없는 데이터 일 때
			if(! Convert.ToBoolean(fgrid_Main[e.Row, (int)ClassLib.TBSPB_STYLE_UP.IxEXIST_YN]) )
			{
				fgrid_Main[e.Row, 0] = "I";
			}
			else
			{
				fgrid_Main.Update_Row();  
			}
  
		}


		#endregion
 
		#region DB Connect
 
		/// <summary>
		/// Select_SPB_STYLE_UP : Component 코드 리스트 찾기
		/// </summary>
		private DataTable Select_SPB_STYLE_UP(string arg_style_cd)
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_RSC.SELECT_SPB_STYLE_UP";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
  
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
				MyOraDB.Parameter_Values[0] = arg_style_cd; 
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
 

		private void Pop_StyleUp_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		
		

	}
}

