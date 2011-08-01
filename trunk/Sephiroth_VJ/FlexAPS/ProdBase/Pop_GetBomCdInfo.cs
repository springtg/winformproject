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
	public class Pop_GetBomCdInfo : COM.APSWinForm.Pop_Large
	{
		protected C1.Win.C1Command.C1OutBar obar_Main;


		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Commit;
		private C1.Win.C1Command.C1OutPage obarpg_Model;
		private C1.Win.C1Command.C1OutPage obarpg_Style;
		private C1.Win.C1Command.C1OutPage obarpg_Line;
		public System.Windows.Forms.Panel panel5;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		private C1.Win.C1List.C1Combo cmb_MFactory;
		private System.Windows.Forms.Label lbl_MFactory;
		private C1.Win.C1List.C1Combo cmb_MYear;
		private System.Windows.Forms.Label lbl_MYear;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		public System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.Panel pnl_Style;
		private C1.Win.C1List.C1Combo cmb_SFactory;
		private System.Windows.Forms.Label lbl_SFactory;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox25;
		public System.Windows.Forms.PictureBox pictureBox26;
		public System.Windows.Forms.PictureBox pictureBox27;
		private C1.Win.C1List.C1Combo cmb_LFactory;
		private System.Windows.Forms.Label lbl_LFactory;
		private System.Windows.Forms.Panel pnl_Line;
		public System.Windows.Forms.Panel pnl_ModelLeft;
		public System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.PictureBox pictureBox28;
		public System.Windows.Forms.PictureBox pictureBox29;
		public System.Windows.Forms.PictureBox pictureBox30;
		public System.Windows.Forms.PictureBox pictureBox31;
		public System.Windows.Forms.PictureBox pictureBox32;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.PictureBox pictureBox35;
		public COM.FSP fgrid_Model;
		public System.Windows.Forms.Label lbl_SubTitle3;
		public System.Windows.Forms.Label lbl_SubTitle4;
		public System.Windows.Forms.Label lbl_SubTitle2;
		private System.Windows.Forms.TextBox txt_ModelName;
		private System.Windows.Forms.Label lbl_ModelName;
		private System.Windows.Forms.TextBox txt_ModelCd;
		private System.Windows.Forms.Label lbl_ModelCd;
		public System.Windows.Forms.Panel pnl_ModelRight;
		public System.Windows.Forms.Panel pnl_StyleLeft;
		public System.Windows.Forms.Panel panel6;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.PictureBox pictureBox41;
		public System.Windows.Forms.PictureBox pictureBox42;
		public System.Windows.Forms.PictureBox pictureBox43;
		private System.Windows.Forms.TextBox txt_StyleName;
		private System.Windows.Forms.Label lbl_StyleName;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_StyleCd;
		public COM.FSP fgrid_Style;
		public System.Windows.Forms.Panel pnl_StyleRight;
		public System.Windows.Forms.Panel pnl_LineLeft;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox44;
		public System.Windows.Forms.PictureBox pictureBox45;
		public System.Windows.Forms.PictureBox pictureBox46;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.PictureBox pictureBox47;
		public System.Windows.Forms.PictureBox pictureBox48;
		public System.Windows.Forms.PictureBox pictureBox49;
		public System.Windows.Forms.PictureBox pictureBox50;
		public System.Windows.Forms.PictureBox pictureBox51;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_LineName;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.Label lbl_LineCd;
		public COM.FSP fgrid_Line;
		private System.Windows.Forms.Label lbl_SStyle1;
		private System.Windows.Forms.TextBox txt_SearchStyle;
		private System.ComponentModel.IContainer components = null;

		public Pop_GetBomCdInfo()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_GetBomCdInfo));
			this.obar_Main = new C1.Win.C1Command.C1OutBar();
			this.obarpg_Model = new C1.Win.C1Command.C1OutPage();
			this.fgrid_Model = new COM.FSP();
			this.pnl_ModelRight = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txt_ModelName = new System.Windows.Forms.TextBox();
			this.lbl_ModelName = new System.Windows.Forms.Label();
			this.txt_ModelCd = new System.Windows.Forms.TextBox();
			this.lbl_ModelCd = new System.Windows.Forms.Label();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle2 = new System.Windows.Forms.Label();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.pictureBox33 = new System.Windows.Forms.PictureBox();
			this.pictureBox34 = new System.Windows.Forms.PictureBox();
			this.pictureBox35 = new System.Windows.Forms.PictureBox();
			this.pnl_ModelLeft = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmb_MFactory = new C1.Win.C1List.C1Combo();
			this.lbl_MFactory = new System.Windows.Forms.Label();
			this.lbl_MYear = new System.Windows.Forms.Label();
			this.cmb_MYear = new C1.Win.C1List.C1Combo();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle1 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.obarpg_Style = new C1.Win.C1Command.C1OutPage();
			this.pnl_Style = new System.Windows.Forms.Panel();
			this.fgrid_Style = new COM.FSP();
			this.pnl_StyleRight = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txt_StyleName = new System.Windows.Forms.TextBox();
			this.lbl_StyleName = new System.Windows.Forms.Label();
			this.txt_StyleCd = new System.Windows.Forms.TextBox();
			this.lbl_StyleCd = new System.Windows.Forms.Label();
			this.pictureBox36 = new System.Windows.Forms.PictureBox();
			this.pictureBox37 = new System.Windows.Forms.PictureBox();
			this.pictureBox38 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox39 = new System.Windows.Forms.PictureBox();
			this.pictureBox40 = new System.Windows.Forms.PictureBox();
			this.pictureBox41 = new System.Windows.Forms.PictureBox();
			this.pictureBox42 = new System.Windows.Forms.PictureBox();
			this.pictureBox43 = new System.Windows.Forms.PictureBox();
			this.pnl_StyleLeft = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txt_SearchStyle = new System.Windows.Forms.TextBox();
			this.cmb_SFactory = new C1.Win.C1List.C1Combo();
			this.lbl_SFactory = new System.Windows.Forms.Label();
			this.lbl_SStyle1 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle3 = new System.Windows.Forms.Label();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.obarpg_Line = new C1.Win.C1Command.C1OutPage();
			this.pnl_Line = new System.Windows.Forms.Panel();
			this.fgrid_Line = new COM.FSP();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.lbl_LineName = new System.Windows.Forms.Label();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.pictureBox44 = new System.Windows.Forms.PictureBox();
			this.pictureBox45 = new System.Windows.Forms.PictureBox();
			this.pictureBox46 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox47 = new System.Windows.Forms.PictureBox();
			this.pictureBox48 = new System.Windows.Forms.PictureBox();
			this.pictureBox49 = new System.Windows.Forms.PictureBox();
			this.pictureBox50 = new System.Windows.Forms.PictureBox();
			this.pictureBox51 = new System.Windows.Forms.PictureBox();
			this.pnl_LineLeft = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cmb_LFactory = new C1.Win.C1List.C1Combo();
			this.lbl_LFactory = new System.Windows.Forms.Label();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.lbl_SubTitle4 = new System.Windows.Forms.Label();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.btn_Commit = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
			this.obar_Main.SuspendLayout();
			this.obarpg_Model.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Model)).BeginInit();
			this.pnl_ModelRight.SuspendLayout();
			this.panel7.SuspendLayout();
			this.pnl_ModelLeft.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MFactory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MYear)).BeginInit();
			this.obarpg_Style.SuspendLayout();
			this.pnl_Style.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).BeginInit();
			this.pnl_StyleRight.SuspendLayout();
			this.panel6.SuspendLayout();
			this.pnl_StyleLeft.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_SFactory)).BeginInit();
			this.obarpg_Line.SuspendLayout();
			this.pnl_Line.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Line)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnl_LineLeft.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).BeginInit();
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
			this.lbl_MainTitle.Text = "Get BOM Code Information";
			// 
			// obar_Main
			// 
			this.obar_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
			this.obar_Main.Controls.Add(this.obarpg_Model);
			this.obar_Main.Controls.Add(this.obarpg_Style);
			this.obar_Main.Controls.Add(this.obarpg_Line);
			this.obar_Main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.obar_Main.Location = new System.Drawing.Point(10, 48);
			this.obar_Main.Name = "obar_Main";
			this.obar_Main.Pages.Add(this.obarpg_Model);
			this.obar_Main.Pages.Add(this.obarpg_Style);
			this.obar_Main.Pages.Add(this.obarpg_Line);
			this.obar_Main.SelectedIndex = 1;
			this.obar_Main.Size = new System.Drawing.Size(672, 376);
			this.obar_Main.Text = "c1OutBar1";
			// 
			// obarpg_Model
			// 
			this.obarpg_Model.Controls.Add(this.fgrid_Model);
			this.obarpg_Model.Controls.Add(this.pnl_ModelRight);
			this.obarpg_Model.Controls.Add(this.pnl_ModelLeft);
			this.obarpg_Model.Location = new System.Drawing.Point(0, 0);
			this.obarpg_Model.Name = "obarpg_Model";
			this.obarpg_Model.Size = new System.Drawing.Size(0, 0);
			this.obarpg_Model.TabIndex = 0;
			this.obarpg_Model.Text = "Model Information";
			// 
			// fgrid_Model
			// 
			this.fgrid_Model.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Model.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Model.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Model.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Model.Location = new System.Drawing.Point(5, 100);
			this.fgrid_Model.Name = "fgrid_Model";
			this.fgrid_Model.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Model.Size = new System.Drawing.Size(659, 212);
			this.fgrid_Model.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Model.TabIndex = 49;
			this.fgrid_Model.DoubleClick += new System.EventHandler(this.fgrid_Model_DoubleClick);
			// 
			// pnl_ModelRight
			// 
			this.pnl_ModelRight.Controls.Add(this.panel7);
			this.pnl_ModelRight.DockPadding.Bottom = 5;
			this.pnl_ModelRight.Location = new System.Drawing.Point(336, 5);
			this.pnl_ModelRight.Name = "pnl_ModelRight";
			this.pnl_ModelRight.Size = new System.Drawing.Size(326, 94);
			this.pnl_ModelRight.TabIndex = 39;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.SystemColors.Window;
			this.panel7.Controls.Add(this.txt_ModelName);
			this.panel7.Controls.Add(this.lbl_ModelName);
			this.panel7.Controls.Add(this.txt_ModelCd);
			this.panel7.Controls.Add(this.lbl_ModelCd);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.lbl_SubTitle2);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Controls.Add(this.pictureBox33);
			this.panel7.Controls.Add(this.pictureBox34);
			this.panel7.Controls.Add(this.pictureBox35);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(326, 89);
			this.panel7.TabIndex = 20;
			// 
			// txt_ModelName
			// 
			this.txt_ModelName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ModelName.Location = new System.Drawing.Point(111, 58);
			this.txt_ModelName.MaxLength = 60;
			this.txt_ModelName.Name = "txt_ModelName";
			this.txt_ModelName.ReadOnly = true;
			this.txt_ModelName.Size = new System.Drawing.Size(210, 21);
			this.txt_ModelName.TabIndex = 102;
			this.txt_ModelName.Text = "";
			// 
			// lbl_ModelName
			// 
			this.lbl_ModelName.ImageIndex = 0;
			this.lbl_ModelName.ImageList = this.img_Label;
			this.lbl_ModelName.Location = new System.Drawing.Point(10, 58);
			this.lbl_ModelName.Name = "lbl_ModelName";
			this.lbl_ModelName.Size = new System.Drawing.Size(100, 21);
			this.lbl_ModelName.TabIndex = 101;
			this.lbl_ModelName.Text = "Model Name";
			this.lbl_ModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ModelCd
			// 
			this.txt_ModelCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_ModelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_ModelCd.Location = new System.Drawing.Point(111, 36);
			this.txt_ModelCd.MaxLength = 60;
			this.txt_ModelCd.Name = "txt_ModelCd";
			this.txt_ModelCd.ReadOnly = true;
			this.txt_ModelCd.Size = new System.Drawing.Size(210, 21);
			this.txt_ModelCd.TabIndex = 100;
			this.txt_ModelCd.Text = "";
			// 
			// lbl_ModelCd
			// 
			this.lbl_ModelCd.ImageIndex = 0;
			this.lbl_ModelCd.ImageList = this.img_Label;
			this.lbl_ModelCd.Location = new System.Drawing.Point(10, 36);
			this.lbl_ModelCd.Name = "lbl_ModelCd";
			this.lbl_ModelCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_ModelCd.TabIndex = 99;
			this.lbl_ModelCd.Text = "Model Code";
			this.lbl_ModelCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(311, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(15, 49);
			this.pictureBox28.TabIndex = 26;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(310, 0);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(16, 32);
			this.pictureBox29.TabIndex = 21;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(216, 0);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(328, 40);
			this.pictureBox30.TabIndex = 0;
			this.pictureBox30.TabStop = false;
			// 
			// lbl_SubTitle2
			// 
			this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
			this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle2.Name = "lbl_SubTitle2";
			this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle2.TabIndex = 20;
			this.lbl_SubTitle2.Text = "      Selected Model Code Info.";
			this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox31.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(160, 24);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(326, 49);
			this.pictureBox31.TabIndex = 27;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(310, 73);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(16, 16);
			this.pictureBox32.TabIndex = 23;
			this.pictureBox32.TabStop = false;
			// 
			// pictureBox33
			// 
			this.pictureBox33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox33.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
			this.pictureBox33.Location = new System.Drawing.Point(144, 71);
			this.pictureBox33.Name = "pictureBox33";
			this.pictureBox33.Size = new System.Drawing.Size(326, 18);
			this.pictureBox33.TabIndex = 24;
			this.pictureBox33.TabStop = false;
			// 
			// pictureBox34
			// 
			this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
			this.pictureBox34.Location = new System.Drawing.Point(0, 69);
			this.pictureBox34.Name = "pictureBox34";
			this.pictureBox34.Size = new System.Drawing.Size(168, 20);
			this.pictureBox34.TabIndex = 22;
			this.pictureBox34.TabStop = false;
			// 
			// pictureBox35
			// 
			this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
			this.pictureBox35.Location = new System.Drawing.Point(0, 24);
			this.pictureBox35.Name = "pictureBox35";
			this.pictureBox35.Size = new System.Drawing.Size(168, 49);
			this.pictureBox35.TabIndex = 25;
			this.pictureBox35.TabStop = false;
			// 
			// pnl_ModelLeft
			// 
			this.pnl_ModelLeft.Controls.Add(this.panel5);
			this.pnl_ModelLeft.DockPadding.Bottom = 5;
			this.pnl_ModelLeft.Location = new System.Drawing.Point(5, 5);
			this.pnl_ModelLeft.Name = "pnl_ModelLeft";
			this.pnl_ModelLeft.Size = new System.Drawing.Size(326, 94);
			this.pnl_ModelLeft.TabIndex = 38;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.SystemColors.Window;
			this.panel5.Controls.Add(this.cmb_MFactory);
			this.panel5.Controls.Add(this.lbl_MFactory);
			this.panel5.Controls.Add(this.lbl_MYear);
			this.panel5.Controls.Add(this.cmb_MYear);
			this.panel5.Controls.Add(this.pictureBox17);
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Controls.Add(this.pictureBox2);
			this.panel5.Controls.Add(this.pictureBox3);
			this.panel5.Controls.Add(this.pictureBox4);
			this.panel5.Controls.Add(this.pictureBox5);
			this.panel5.Controls.Add(this.pictureBox6);
			this.panel5.Controls.Add(this.lbl_SubTitle1);
			this.panel5.Controls.Add(this.pictureBox7);
			this.panel5.Controls.Add(this.pictureBox8);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(326, 89);
			this.panel5.TabIndex = 19;
			// 
			// cmb_MFactory
			// 
			this.cmb_MFactory.AddItemCols = 0;
			this.cmb_MFactory.AddItemSeparator = ';';
			this.cmb_MFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MFactory.Caption = "";
			this.cmb_MFactory.CaptionHeight = 17;
			this.cmb_MFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MFactory.ColumnCaptionHeight = 18;
			this.cmb_MFactory.ColumnFooterHeight = 18;
			this.cmb_MFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MFactory.ContentHeight = 17;
			this.cmb_MFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MFactory.EditorHeight = 17;
			this.cmb_MFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MFactory.GapHeight = 2;
			this.cmb_MFactory.ItemHeight = 15;
			this.cmb_MFactory.Location = new System.Drawing.Point(111, 36);
			this.cmb_MFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_MFactory.MaxDropDownItems = ((short)(5));
			this.cmb_MFactory.MaxLength = 32767;
			this.cmb_MFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MFactory.Name = "cmb_MFactory";
			this.cmb_MFactory.PartialRightColumn = false;
			this.cmb_MFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_MFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MFactory.Size = new System.Drawing.Size(210, 21);
			this.cmb_MFactory.TabIndex = 45;
			this.cmb_MFactory.TextChanged += new System.EventHandler(this.cmb_MFactory_TextChanged);
			// 
			// lbl_MFactory
			// 
			this.lbl_MFactory.ImageIndex = 0;
			this.lbl_MFactory.ImageList = this.img_Label;
			this.lbl_MFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_MFactory.Name = "lbl_MFactory";
			this.lbl_MFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_MFactory.TabIndex = 44;
			this.lbl_MFactory.Text = "Factory";
			this.lbl_MFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_MYear
			// 
			this.lbl_MYear.ImageIndex = 0;
			this.lbl_MYear.ImageList = this.img_Label;
			this.lbl_MYear.Location = new System.Drawing.Point(10, 58);
			this.lbl_MYear.Name = "lbl_MYear";
			this.lbl_MYear.Size = new System.Drawing.Size(100, 21);
			this.lbl_MYear.TabIndex = 46;
			this.lbl_MYear.Text = "Year";
			this.lbl_MYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_MYear
			// 
			this.cmb_MYear.AddItemCols = 0;
			this.cmb_MYear.AddItemSeparator = ';';
			this.cmb_MYear.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_MYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_MYear.Caption = "";
			this.cmb_MYear.CaptionHeight = 17;
			this.cmb_MYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_MYear.ColumnCaptionHeight = 18;
			this.cmb_MYear.ColumnFooterHeight = 18;
			this.cmb_MYear.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_MYear.ContentHeight = 17;
			this.cmb_MYear.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_MYear.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_MYear.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MYear.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_MYear.EditorHeight = 17;
			this.cmb_MYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_MYear.GapHeight = 2;
			this.cmb_MYear.ItemHeight = 15;
			this.cmb_MYear.Location = new System.Drawing.Point(111, 58);
			this.cmb_MYear.MatchEntryTimeout = ((long)(2000));
			this.cmb_MYear.MaxDropDownItems = ((short)(5));
			this.cmb_MYear.MaxLength = 32767;
			this.cmb_MYear.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_MYear.Name = "cmb_MYear";
			this.cmb_MYear.PartialRightColumn = false;
			this.cmb_MYear.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_MYear.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_MYear.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_MYear.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_MYear.Size = new System.Drawing.Size(210, 21);
			this.cmb_MYear.TabIndex = 47;
			this.cmb_MYear.TextChanged += new System.EventHandler(this.cmb_MYear_TextChanged);
			// 
			// pictureBox17
			// 
			this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(311, 32);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(20, 45);
			this.pictureBox17.TabIndex = 29;
			this.pictureBox17.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(311, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(20, 39);
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(310, 73);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(21, 16);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(131, 71);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(326, 18);
			this.pictureBox3.TabIndex = 28;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(310, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(21, 32);
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
			this.pictureBox5.Size = new System.Drawing.Size(326, 32);
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
			this.pictureBox6.Size = new System.Drawing.Size(326, 49);
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
			this.lbl_SubTitle1.Text = "      Model Code Info.";
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
			this.pictureBox7.Size = new System.Drawing.Size(168, 49);
			this.pictureBox7.TabIndex = 25;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(0, 69);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(168, 20);
			this.pictureBox8.TabIndex = 22;
			this.pictureBox8.TabStop = false;
			// 
			// obarpg_Style
			// 
			this.obarpg_Style.Controls.Add(this.pnl_Style);
			this.obarpg_Style.Location = new System.Drawing.Point(0, 40);
			this.obarpg_Style.Name = "obarpg_Style";
			this.obarpg_Style.Size = new System.Drawing.Size(672, 316);
			this.obarpg_Style.TabIndex = 1;
			this.obarpg_Style.Text = "Style Information";
			// 
			// pnl_Style
			// 
			this.pnl_Style.Controls.Add(this.fgrid_Style);
			this.pnl_Style.Controls.Add(this.pnl_StyleRight);
			this.pnl_Style.Controls.Add(this.pnl_StyleLeft);
			this.pnl_Style.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Style.DockPadding.All = 10;
			this.pnl_Style.Location = new System.Drawing.Point(0, 0);
			this.pnl_Style.Name = "pnl_Style";
			this.pnl_Style.Size = new System.Drawing.Size(672, 316);
			this.pnl_Style.TabIndex = 1;
			// 
			// fgrid_Style
			// 
			this.fgrid_Style.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Style.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Style.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Style.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Style.Location = new System.Drawing.Point(5, 100);
			this.fgrid_Style.Name = "fgrid_Style";
			this.fgrid_Style.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Style.Size = new System.Drawing.Size(659, 204);
			this.fgrid_Style.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Style.TabIndex = 50;
			this.fgrid_Style.DoubleClick += new System.EventHandler(this.fgrid_Style_DoubleClick);
			// 
			// pnl_StyleRight
			// 
			this.pnl_StyleRight.Controls.Add(this.panel6);
			this.pnl_StyleRight.DockPadding.Bottom = 5;
			this.pnl_StyleRight.Location = new System.Drawing.Point(336, 5);
			this.pnl_StyleRight.Name = "pnl_StyleRight";
			this.pnl_StyleRight.Size = new System.Drawing.Size(326, 94);
			this.pnl_StyleRight.TabIndex = 40;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.SystemColors.Window;
			this.panel6.Controls.Add(this.txt_StyleName);
			this.panel6.Controls.Add(this.lbl_StyleName);
			this.panel6.Controls.Add(this.txt_StyleCd);
			this.panel6.Controls.Add(this.lbl_StyleCd);
			this.panel6.Controls.Add(this.pictureBox36);
			this.panel6.Controls.Add(this.pictureBox37);
			this.panel6.Controls.Add(this.pictureBox38);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Controls.Add(this.pictureBox39);
			this.panel6.Controls.Add(this.pictureBox40);
			this.panel6.Controls.Add(this.pictureBox41);
			this.panel6.Controls.Add(this.pictureBox42);
			this.panel6.Controls.Add(this.pictureBox43);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(326, 89);
			this.panel6.TabIndex = 20;
			// 
			// txt_StyleName
			// 
			this.txt_StyleName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleName.Location = new System.Drawing.Point(111, 58);
			this.txt_StyleName.MaxLength = 60;
			this.txt_StyleName.Name = "txt_StyleName";
			this.txt_StyleName.ReadOnly = true;
			this.txt_StyleName.Size = new System.Drawing.Size(210, 21);
			this.txt_StyleName.TabIndex = 102;
			this.txt_StyleName.Text = "";
			// 
			// lbl_StyleName
			// 
			this.lbl_StyleName.ImageIndex = 0;
			this.lbl_StyleName.ImageList = this.img_Label;
			this.lbl_StyleName.Location = new System.Drawing.Point(10, 58);
			this.lbl_StyleName.Name = "lbl_StyleName";
			this.lbl_StyleName.Size = new System.Drawing.Size(100, 21);
			this.lbl_StyleName.TabIndex = 101;
			this.lbl_StyleName.Text = "Style Name";
			this.lbl_StyleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_StyleCd
			// 
			this.txt_StyleCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_StyleCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_StyleCd.Location = new System.Drawing.Point(111, 36);
			this.txt_StyleCd.MaxLength = 60;
			this.txt_StyleCd.Name = "txt_StyleCd";
			this.txt_StyleCd.ReadOnly = true;
			this.txt_StyleCd.Size = new System.Drawing.Size(210, 21);
			this.txt_StyleCd.TabIndex = 100;
			this.txt_StyleCd.Text = "";
			// 
			// lbl_StyleCd
			// 
			this.lbl_StyleCd.ImageIndex = 0;
			this.lbl_StyleCd.ImageList = this.img_Label;
			this.lbl_StyleCd.Location = new System.Drawing.Point(10, 36);
			this.lbl_StyleCd.Name = "lbl_StyleCd";
			this.lbl_StyleCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_StyleCd.TabIndex = 99;
			this.lbl_StyleCd.Text = "Style Code";
			this.lbl_StyleCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox36
			// 
			this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
			this.pictureBox36.Location = new System.Drawing.Point(311, 24);
			this.pictureBox36.Name = "pictureBox36";
			this.pictureBox36.Size = new System.Drawing.Size(15, 49);
			this.pictureBox36.TabIndex = 26;
			this.pictureBox36.TabStop = false;
			// 
			// pictureBox37
			// 
			this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
			this.pictureBox37.Location = new System.Drawing.Point(310, 0);
			this.pictureBox37.Name = "pictureBox37";
			this.pictureBox37.Size = new System.Drawing.Size(16, 32);
			this.pictureBox37.TabIndex = 21;
			this.pictureBox37.TabStop = false;
			// 
			// pictureBox38
			// 
			this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
			this.pictureBox38.Location = new System.Drawing.Point(216, 0);
			this.pictureBox38.Name = "pictureBox38";
			this.pictureBox38.Size = new System.Drawing.Size(328, 40);
			this.pictureBox38.TabIndex = 0;
			this.pictureBox38.TabStop = false;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.Window;
			this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Navy;
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(231, 30);
			this.label3.TabIndex = 20;
			this.label3.Text = "      Selected Style Code Info.";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox39
			// 
			this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
			this.pictureBox39.Location = new System.Drawing.Point(160, 24);
			this.pictureBox39.Name = "pictureBox39";
			this.pictureBox39.Size = new System.Drawing.Size(326, 49);
			this.pictureBox39.TabIndex = 27;
			this.pictureBox39.TabStop = false;
			// 
			// pictureBox40
			// 
			this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
			this.pictureBox40.Location = new System.Drawing.Point(310, 73);
			this.pictureBox40.Name = "pictureBox40";
			this.pictureBox40.Size = new System.Drawing.Size(16, 16);
			this.pictureBox40.TabIndex = 23;
			this.pictureBox40.TabStop = false;
			// 
			// pictureBox41
			// 
			this.pictureBox41.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox41.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
			this.pictureBox41.Location = new System.Drawing.Point(144, 71);
			this.pictureBox41.Name = "pictureBox41";
			this.pictureBox41.Size = new System.Drawing.Size(326, 18);
			this.pictureBox41.TabIndex = 24;
			this.pictureBox41.TabStop = false;
			// 
			// pictureBox42
			// 
			this.pictureBox42.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox42.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
			this.pictureBox42.Location = new System.Drawing.Point(0, 69);
			this.pictureBox42.Name = "pictureBox42";
			this.pictureBox42.Size = new System.Drawing.Size(168, 20);
			this.pictureBox42.TabIndex = 22;
			this.pictureBox42.TabStop = false;
			// 
			// pictureBox43
			// 
			this.pictureBox43.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox43.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
			this.pictureBox43.Location = new System.Drawing.Point(0, 24);
			this.pictureBox43.Name = "pictureBox43";
			this.pictureBox43.Size = new System.Drawing.Size(168, 49);
			this.pictureBox43.TabIndex = 25;
			this.pictureBox43.TabStop = false;
			// 
			// pnl_StyleLeft
			// 
			this.pnl_StyleLeft.Controls.Add(this.panel3);
			this.pnl_StyleLeft.DockPadding.Bottom = 5;
			this.pnl_StyleLeft.Location = new System.Drawing.Point(5, 5);
			this.pnl_StyleLeft.Name = "pnl_StyleLeft";
			this.pnl_StyleLeft.Size = new System.Drawing.Size(326, 94);
			this.pnl_StyleLeft.TabIndex = 38;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Window;
			this.panel3.Controls.Add(this.txt_SearchStyle);
			this.panel3.Controls.Add(this.cmb_SFactory);
			this.panel3.Controls.Add(this.lbl_SFactory);
			this.panel3.Controls.Add(this.lbl_SStyle1);
			this.panel3.Controls.Add(this.pictureBox9);
			this.panel3.Controls.Add(this.pictureBox10);
			this.panel3.Controls.Add(this.pictureBox11);
			this.panel3.Controls.Add(this.pictureBox12);
			this.panel3.Controls.Add(this.pictureBox13);
			this.panel3.Controls.Add(this.pictureBox14);
			this.panel3.Controls.Add(this.pictureBox15);
			this.panel3.Controls.Add(this.lbl_SubTitle3);
			this.panel3.Controls.Add(this.pictureBox16);
			this.panel3.Controls.Add(this.pictureBox18);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(326, 89);
			this.panel3.TabIndex = 19;
			// 
			// txt_SearchStyle
			// 
			this.txt_SearchStyle.BackColor = System.Drawing.SystemColors.Window;
			this.txt_SearchStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_SearchStyle.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_SearchStyle.Location = new System.Drawing.Point(111, 58);
			this.txt_SearchStyle.MaxLength = 60;
			this.txt_SearchStyle.Name = "txt_SearchStyle";
			this.txt_SearchStyle.Size = new System.Drawing.Size(210, 21);
			this.txt_SearchStyle.TabIndex = 101;
			this.txt_SearchStyle.Text = "";
			this.txt_SearchStyle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SearchStyle_KeyPress);
			// 
			// cmb_SFactory
			// 
			this.cmb_SFactory.AddItemCols = 0;
			this.cmb_SFactory.AddItemSeparator = ';';
			this.cmb_SFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_SFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_SFactory.Caption = "";
			this.cmb_SFactory.CaptionHeight = 17;
			this.cmb_SFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_SFactory.ColumnCaptionHeight = 18;
			this.cmb_SFactory.ColumnFooterHeight = 18;
			this.cmb_SFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_SFactory.ContentHeight = 17;
			this.cmb_SFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_SFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_SFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_SFactory.EditorHeight = 17;
			this.cmb_SFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_SFactory.GapHeight = 2;
			this.cmb_SFactory.ItemHeight = 15;
			this.cmb_SFactory.Location = new System.Drawing.Point(111, 36);
			this.cmb_SFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_SFactory.MaxDropDownItems = ((short)(5));
			this.cmb_SFactory.MaxLength = 32767;
			this.cmb_SFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_SFactory.Name = "cmb_SFactory";
			this.cmb_SFactory.PartialRightColumn = false;
			this.cmb_SFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_SFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_SFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_SFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_SFactory.Size = new System.Drawing.Size(210, 21);
			this.cmb_SFactory.TabIndex = 45;
			this.cmb_SFactory.TextChanged += new System.EventHandler(this.cmb_SFactory_TextChanged);
			// 
			// lbl_SFactory
			// 
			this.lbl_SFactory.ImageIndex = 0;
			this.lbl_SFactory.ImageList = this.img_Label;
			this.lbl_SFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_SFactory.Name = "lbl_SFactory";
			this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_SFactory.TabIndex = 44;
			this.lbl_SFactory.Text = "Factory";
			this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SStyle1
			// 
			this.lbl_SStyle1.ImageIndex = 0;
			this.lbl_SStyle1.ImageList = this.img_Label;
			this.lbl_SStyle1.Location = new System.Drawing.Point(10, 58);
			this.lbl_SStyle1.Name = "lbl_SStyle1";
			this.lbl_SStyle1.Size = new System.Drawing.Size(100, 21);
			this.lbl_SStyle1.TabIndex = 46;
			this.lbl_SStyle1.Text = "Style Code";
			this.lbl_SStyle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(311, 32);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(20, 45);
			this.pictureBox9.TabIndex = 29;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(311, 24);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(20, 39);
			this.pictureBox10.TabIndex = 26;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(310, 73);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(21, 16);
			this.pictureBox11.TabIndex = 23;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(131, 71);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(326, 18);
			this.pictureBox12.TabIndex = 28;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(310, 0);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(21, 32);
			this.pictureBox13.TabIndex = 21;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(224, 0);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(326, 32);
			this.pictureBox14.TabIndex = 0;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(160, 24);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(326, 49);
			this.pictureBox15.TabIndex = 27;
			this.pictureBox15.TabStop = false;
			// 
			// lbl_SubTitle3
			// 
			this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
			this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle3.Name = "lbl_SubTitle3";
			this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle3.TabIndex = 20;
			this.lbl_SubTitle3.Text = "      Style Code Info.";
			this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(0, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(168, 49);
			this.pictureBox16.TabIndex = 25;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(0, 69);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(168, 20);
			this.pictureBox18.TabIndex = 22;
			this.pictureBox18.TabStop = false;
			// 
			// obarpg_Line
			// 
			this.obarpg_Line.Controls.Add(this.pnl_Line);
			this.obarpg_Line.Location = new System.Drawing.Point(0, 0);
			this.obarpg_Line.Name = "obarpg_Line";
			this.obarpg_Line.Size = new System.Drawing.Size(0, 0);
			this.obarpg_Line.TabIndex = 3;
			this.obarpg_Line.Text = "Line Information";
			// 
			// pnl_Line
			// 
			this.pnl_Line.Controls.Add(this.fgrid_Line);
			this.pnl_Line.Controls.Add(this.panel1);
			this.pnl_Line.Controls.Add(this.pnl_LineLeft);
			this.pnl_Line.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnl_Line.DockPadding.All = 10;
			this.pnl_Line.Location = new System.Drawing.Point(0, 0);
			this.pnl_Line.Name = "pnl_Line";
			this.pnl_Line.Size = new System.Drawing.Size(0, 0);
			this.pnl_Line.TabIndex = 1;
			// 
			// fgrid_Line
			// 
			this.fgrid_Line.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Line.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Line.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Line.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Line.Location = new System.Drawing.Point(5, 100);
			this.fgrid_Line.Name = "fgrid_Line";
			this.fgrid_Line.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Line.Size = new System.Drawing.Size(659, 188);
			this.fgrid_Line.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Line.TabIndex = 51;
			this.fgrid_Line.DoubleClick += new System.EventHandler(this.fgrid_Line_DoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.DockPadding.Bottom = 5;
			this.panel1.Location = new System.Drawing.Point(336, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(326, 94);
			this.panel1.TabIndex = 40;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Controls.Add(this.txt_LineName);
			this.panel2.Controls.Add(this.lbl_LineName);
			this.panel2.Controls.Add(this.txt_LineCd);
			this.panel2.Controls.Add(this.lbl_LineCd);
			this.panel2.Controls.Add(this.pictureBox44);
			this.panel2.Controls.Add(this.pictureBox45);
			this.panel2.Controls.Add(this.pictureBox46);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox47);
			this.panel2.Controls.Add(this.pictureBox48);
			this.panel2.Controls.Add(this.pictureBox49);
			this.panel2.Controls.Add(this.pictureBox50);
			this.panel2.Controls.Add(this.pictureBox51);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(326, 89);
			this.panel2.TabIndex = 20;
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(111, 58);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(210, 21);
			this.txt_LineName.TabIndex = 102;
			this.txt_LineName.Text = "";
			// 
			// lbl_LineName
			// 
			this.lbl_LineName.ImageIndex = 0;
			this.lbl_LineName.ImageList = this.img_Label;
			this.lbl_LineName.Location = new System.Drawing.Point(10, 58);
			this.lbl_LineName.Name = "lbl_LineName";
			this.lbl_LineName.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineName.TabIndex = 101;
			this.lbl_LineName.Text = "Line Name";
			this.lbl_LineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(111, 36);
			this.txt_LineCd.MaxLength = 60;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(210, 21);
			this.txt_LineCd.TabIndex = 100;
			this.txt_LineCd.Text = "";
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(10, 36);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 99;
			this.lbl_LineCd.Text = "Line Code";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox44
			// 
			this.pictureBox44.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox44.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
			this.pictureBox44.Location = new System.Drawing.Point(311, 24);
			this.pictureBox44.Name = "pictureBox44";
			this.pictureBox44.Size = new System.Drawing.Size(15, 49);
			this.pictureBox44.TabIndex = 26;
			this.pictureBox44.TabStop = false;
			// 
			// pictureBox45
			// 
			this.pictureBox45.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox45.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
			this.pictureBox45.Location = new System.Drawing.Point(310, 0);
			this.pictureBox45.Name = "pictureBox45";
			this.pictureBox45.Size = new System.Drawing.Size(16, 32);
			this.pictureBox45.TabIndex = 21;
			this.pictureBox45.TabStop = false;
			// 
			// pictureBox46
			// 
			this.pictureBox46.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox46.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
			this.pictureBox46.Location = new System.Drawing.Point(216, 0);
			this.pictureBox46.Name = "pictureBox46";
			this.pictureBox46.Size = new System.Drawing.Size(328, 40);
			this.pictureBox46.TabIndex = 0;
			this.pictureBox46.TabStop = false;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.SystemColors.Window;
			this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.Color.Navy;
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(231, 30);
			this.label4.TabIndex = 20;
			this.label4.Text = "      Selected Line Code Info.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox47
			// 
			this.pictureBox47.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox47.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
			this.pictureBox47.Location = new System.Drawing.Point(160, 24);
			this.pictureBox47.Name = "pictureBox47";
			this.pictureBox47.Size = new System.Drawing.Size(326, 49);
			this.pictureBox47.TabIndex = 27;
			this.pictureBox47.TabStop = false;
			// 
			// pictureBox48
			// 
			this.pictureBox48.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox48.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
			this.pictureBox48.Location = new System.Drawing.Point(310, 73);
			this.pictureBox48.Name = "pictureBox48";
			this.pictureBox48.Size = new System.Drawing.Size(16, 16);
			this.pictureBox48.TabIndex = 23;
			this.pictureBox48.TabStop = false;
			// 
			// pictureBox49
			// 
			this.pictureBox49.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox49.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox49.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox49.Image")));
			this.pictureBox49.Location = new System.Drawing.Point(144, 71);
			this.pictureBox49.Name = "pictureBox49";
			this.pictureBox49.Size = new System.Drawing.Size(326, 18);
			this.pictureBox49.TabIndex = 24;
			this.pictureBox49.TabStop = false;
			// 
			// pictureBox50
			// 
			this.pictureBox50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox50.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox50.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox50.Image")));
			this.pictureBox50.Location = new System.Drawing.Point(0, 69);
			this.pictureBox50.Name = "pictureBox50";
			this.pictureBox50.Size = new System.Drawing.Size(168, 20);
			this.pictureBox50.TabIndex = 22;
			this.pictureBox50.TabStop = false;
			// 
			// pictureBox51
			// 
			this.pictureBox51.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox51.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox51.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox51.Image")));
			this.pictureBox51.Location = new System.Drawing.Point(0, 24);
			this.pictureBox51.Name = "pictureBox51";
			this.pictureBox51.Size = new System.Drawing.Size(168, 49);
			this.pictureBox51.TabIndex = 25;
			this.pictureBox51.TabStop = false;
			// 
			// pnl_LineLeft
			// 
			this.pnl_LineLeft.Controls.Add(this.panel4);
			this.pnl_LineLeft.DockPadding.Bottom = 5;
			this.pnl_LineLeft.Location = new System.Drawing.Point(5, 5);
			this.pnl_LineLeft.Name = "pnl_LineLeft";
			this.pnl_LineLeft.Size = new System.Drawing.Size(326, 94);
			this.pnl_LineLeft.TabIndex = 38;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.SystemColors.Window;
			this.panel4.Controls.Add(this.cmb_LFactory);
			this.panel4.Controls.Add(this.lbl_LFactory);
			this.panel4.Controls.Add(this.pictureBox19);
			this.panel4.Controls.Add(this.pictureBox20);
			this.panel4.Controls.Add(this.pictureBox21);
			this.panel4.Controls.Add(this.pictureBox22);
			this.panel4.Controls.Add(this.pictureBox23);
			this.panel4.Controls.Add(this.pictureBox24);
			this.panel4.Controls.Add(this.pictureBox25);
			this.panel4.Controls.Add(this.lbl_SubTitle4);
			this.panel4.Controls.Add(this.pictureBox26);
			this.panel4.Controls.Add(this.pictureBox27);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(326, 89);
			this.panel4.TabIndex = 19;
			// 
			// cmb_LFactory
			// 
			this.cmb_LFactory.AddItemCols = 0;
			this.cmb_LFactory.AddItemSeparator = ';';
			this.cmb_LFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LFactory.Caption = "";
			this.cmb_LFactory.CaptionHeight = 17;
			this.cmb_LFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LFactory.ColumnCaptionHeight = 18;
			this.cmb_LFactory.ColumnFooterHeight = 18;
			this.cmb_LFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LFactory.ContentHeight = 17;
			this.cmb_LFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LFactory.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LFactory.EditorHeight = 17;
			this.cmb_LFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LFactory.GapHeight = 2;
			this.cmb_LFactory.ItemHeight = 15;
			this.cmb_LFactory.Location = new System.Drawing.Point(111, 36);
			this.cmb_LFactory.MatchEntryTimeout = ((long)(2000));
			this.cmb_LFactory.MaxDropDownItems = ((short)(5));
			this.cmb_LFactory.MaxLength = 32767;
			this.cmb_LFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LFactory.Name = "cmb_LFactory";
			this.cmb_LFactory.PartialRightColumn = false;
			this.cmb_LFactory.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
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
			this.cmb_LFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LFactory.Size = new System.Drawing.Size(210, 21);
			this.cmb_LFactory.TabIndex = 45;
			this.cmb_LFactory.TextChanged += new System.EventHandler(this.cmb_LFactory_TextChanged);
			// 
			// lbl_LFactory
			// 
			this.lbl_LFactory.ImageIndex = 0;
			this.lbl_LFactory.ImageList = this.img_Label;
			this.lbl_LFactory.Location = new System.Drawing.Point(10, 36);
			this.lbl_LFactory.Name = "lbl_LFactory";
			this.lbl_LFactory.Size = new System.Drawing.Size(100, 21);
			this.lbl_LFactory.TabIndex = 44;
			this.lbl_LFactory.Text = "Factory";
			this.lbl_LFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(311, 32);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(20, 45);
			this.pictureBox19.TabIndex = 29;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(311, 24);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(20, 39);
			this.pictureBox20.TabIndex = 26;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(310, 73);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(21, 16);
			this.pictureBox21.TabIndex = 23;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(131, 71);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(326, 18);
			this.pictureBox22.TabIndex = 28;
			this.pictureBox22.TabStop = false;
			// 
			// pictureBox23
			// 
			this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(310, 0);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(21, 32);
			this.pictureBox23.TabIndex = 21;
			this.pictureBox23.TabStop = false;
			// 
			// pictureBox24
			// 
			this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(224, 0);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(326, 32);
			this.pictureBox24.TabIndex = 0;
			this.pictureBox24.TabStop = false;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(160, 24);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(326, 49);
			this.pictureBox25.TabIndex = 27;
			this.pictureBox25.TabStop = false;
			// 
			// lbl_SubTitle4
			// 
			this.lbl_SubTitle4.BackColor = System.Drawing.SystemColors.Window;
			this.lbl_SubTitle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_SubTitle4.ForeColor = System.Drawing.Color.Navy;
			this.lbl_SubTitle4.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle4.Image")));
			this.lbl_SubTitle4.Location = new System.Drawing.Point(0, 0);
			this.lbl_SubTitle4.Name = "lbl_SubTitle4";
			this.lbl_SubTitle4.Size = new System.Drawing.Size(231, 30);
			this.lbl_SubTitle4.TabIndex = 20;
			this.lbl_SubTitle4.Text = "      Line Code Info.";
			this.lbl_SubTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(0, 24);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(168, 49);
			this.pictureBox26.TabIndex = 25;
			this.pictureBox26.TabStop = false;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox27.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(0, 69);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(168, 20);
			this.pictureBox27.TabIndex = 22;
			this.pictureBox27.TabStop = false;
			// 
			// btn_Commit
			// 
			this.btn_Commit.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Commit.ImageIndex = 0;
			this.btn_Commit.ImageList = this.img_Button;
			this.btn_Commit.Location = new System.Drawing.Point(540, 432);
			this.btn_Commit.Name = "btn_Commit";
			this.btn_Commit.Size = new System.Drawing.Size(70, 23);
			this.btn_Commit.TabIndex = 48;
			this.btn_Commit.Text = "Apply";
			this.btn_Commit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Commit.Click += new System.EventHandler(this.btn_Commit_Click);
			this.btn_Commit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Commit_MouseUp);
			this.btn_Commit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Commit_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(611, 432);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 49;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// Pop_GetBomCdInfo
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Commit);
			this.Controls.Add(this.obar_Main);
			this.Name = "Pop_GetBomCdInfo";
			this.Text = "Get BOM Code Information";
			this.Load += new System.EventHandler(this.Pop_GetBomCdInfo_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.obar_Main, 0);
			this.Controls.SetChildIndex(this.btn_Commit, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
			this.obar_Main.ResumeLayout(false);
			this.obarpg_Model.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Model)).EndInit();
			this.pnl_ModelRight.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.pnl_ModelLeft.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_MFactory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cmb_MYear)).EndInit();
			this.obarpg_Style.ResumeLayout(false);
			this.pnl_Style.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Style)).EndInit();
			this.pnl_StyleRight.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.pnl_StyleLeft.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_SFactory)).EndInit();
			this.obarpg_Line.ResumeLayout(false);
			this.pnl_Line.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Line)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.pnl_LineLeft.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LFactory)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private string _Factory, _Div;

		//fgrid_Model index
		private int _ModelCd_ix = 2;
		private int _ModelName_ix = 3; 
		//fgrid_Style index
		private int _StyleCd_ix = 3;  
		private int _StyleName_ix = 4; 
		//fgrid_Line index
		private int _LineCd_ix = 2;
		private int _LineName_ix = 3; 

		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave;

		#endregion 

		#region 멤버 메서드


		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			DataTable dt_ret;

			//Title
			this.Text = "Get BOM Code Information";
			this.lbl_MainTitle.Text = "Get BOM Code Information"; 

			ClassLib.ComFunction.SetLangDic(this);


			


			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_Div = ClassLib.ComVar.Parameter_PopUp[1];

			dt_ret = ClassLib.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MFactory, 0, 1);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SFactory, 0, 1);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LFactory, 0, 1);
 
			fgrid_Model.Set_Grid("MODEL_CODE", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Style.Set_Grid("STYLE_CODE", "3", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			fgrid_Line.Set_Grid("LINE_CODE", "2", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
			 
			cmb_MFactory.SelectedValue = _Factory;
			cmb_SFactory.SelectedValue = _Factory;
			cmb_LFactory.SelectedValue = _Factory;
			
//			cmb_MFactory.Enabled = false;
//			cmb_SFactory.Enabled = false;
//			cmb_LFactory.Enabled = false;

			switch(_Div)
			{
				case "M":
					obar_Main.SelectedPage = obarpg_Model;
					obarpg_Style.Visible = false;
					obarpg_Line.Visible = false;
					break;
				case "S":
					obar_Main.SelectedPage = obarpg_Style;
					obarpg_Model.Visible = false;
					obarpg_Line.Visible = false;
					break;
				case "L":
					obar_Main.SelectedPage = obarpg_Line;
					obarpg_Model.Visible = false;
					obarpg_Style.Visible = false;
					break;
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
				} 

				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
 
		} 
		
 
		#endregion 

		#region 이벤트 처리 

		 

		private void cmb_MFactory_TextChanged(object sender, System.EventArgs e)
		{ 
			DataTable dt_ret;

			try
			{
				if(cmb_MFactory.SelectedIndex == -1) return;

				dt_ret = Select_Model_Year();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_MYear, 0, 0);
				cmb_MYear.Splits[0].DisplayColumns[1].Visible = false;
			}
			catch
			{
			}

		}


		private void cmb_MYear_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_MFactory.SelectedIndex == -1 || cmb_MYear.SelectedIndex == -1) return;

				dt_ret = Select_Model_List();
				Display_Grid(dt_ret, fgrid_Model);
			}
			catch
			{
			}
		}


		private void cmb_SFactory_TextChanged(object sender, System.EventArgs e)
		{
//			DataTable dt_ret;
//
//			try
//			{
//				if(cmb_SFactory.SelectedIndex == -1) return;
//
//				dt_ret = Select_Style_List();
//				Display_Grid(dt_ret, fgrid_Style);
//			}
//			catch
//			{
//			}

		}

 
		private void cmb_LFactory_TextChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_LFactory.SelectedIndex == -1) return;

				dt_ret = Select_Line_List();
				Display_Grid(dt_ret, fgrid_Line);
			}
			catch
			{
			}
		} 


		private void fgrid_Model_DoubleClick(object sender, System.EventArgs e)
		{
			txt_ModelCd.Text = fgrid_Model[fgrid_Model.Selection.r1, _ModelCd_ix].ToString();
			txt_ModelName.Text = fgrid_Model[fgrid_Model.Selection.r1, _ModelName_ix].ToString(); 
		}

		private void fgrid_Style_DoubleClick(object sender, System.EventArgs e)
		{
			txt_StyleCd.Text = fgrid_Style[fgrid_Style.Selection.r1, _StyleCd_ix].ToString(); 
			txt_StyleName.Text = fgrid_Style[fgrid_Style.Selection.r1, _StyleName_ix].ToString();
		}

		private void fgrid_Line_DoubleClick(object sender, System.EventArgs e)
		{
			txt_LineCd.Text = fgrid_Line[fgrid_Line.Selection.r1, _LineCd_ix].ToString();
			txt_LineName.Text = fgrid_Line[fgrid_Line.Selection.r1, _LineName_ix].ToString(); 
		}



		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CloseSave = false;
			this.Close();
		}

		private void btn_Cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 1;
		}

		private void btn_Cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 0;
		}


		private void btn_Commit_Click(object sender, System.EventArgs e)
		{ 
			//ClassLib.ComVar.Parameter_PopUp = new string[] {txt_ModelCd.Text, txt_StyleCd.Text, txt_LineCd.Text};

			switch(_Div)
			{
				case "M":
					ClassLib.ComVar.Parameter_PopUp = new string[] {txt_ModelCd.Text};
					obarpg_Line.Visible = false;
					break;
				case "S":
					string[] token = txt_StyleCd.Text.Split('-');
					ClassLib.ComVar.Parameter_PopUp = new string[] {token[0]};
					obarpg_Line.Visible = false;
					break;
				case "L":
					ClassLib.ComVar.Parameter_PopUp = new string[] {txt_LineCd.Text};
					obarpg_Style.Visible = false;
					break;
			}

			_CloseSave = true;
			this.Close();
		}

		private void btn_Commit_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Commit.ImageIndex = 1;
		}

		private void btn_Commit_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Commit.ImageIndex = 0;
		}

		private void txt_SearchStyle_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			DataTable dt_ret;
	
			//13 : enter
			if(e.KeyChar == (char)13) 
			{
				try
				{ 
					dt_ret = Select_Style_List();
					Display_Grid(dt_ret, fgrid_Style);
				}
				catch
				{
				}
			}
		}

		#endregion


		#region DB Connect 

		/// <summary>
		/// Select_Model_Year : 모델에 대한 연도 리스트 찾기
		/// </summary>
		private DataTable Select_Model_Year()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_YEAR";

				MyOraDB.ReDim_Parameter(1); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "OUT_CURSOR";  
				MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor; 
				MyOraDB.Parameter_Values[0] = ""; 

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
		/// Select_Model_List : 모델 리스트 가져오기
		/// </summary>
		private DataTable Select_Model_List()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_LIST";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_YEAR";
				MyOraDB.Parameter_Name[2] = "ARG_MODEL_NAME";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = cmb_MYear.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = " "; 
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
		/// Select_Model_CmbList : 모델 콤보 리스트 찾기 
		/// </summary>
		private DataTable Select_Model_CmbList()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_MODEL_BSC.SELECT_MODEL_CMBLIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_SFactory.SelectedValue.ToString();   
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
 

		/// <summary>
		/// Select_Style_List : 스타일 리스트 찾기
		/// </summary>
		private DataTable Select_Style_List()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_STYLE_BSC.SELECT_SPB_STYLE_LIKE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";  
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_SFactory.SelectedValue.ToString();   
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.Empty_TextBox(txt_SearchStyle, " "); 
				MyOraDB.Parameter_Values[2] = ""; 

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
		/// Select_Line_List : 라인 리스트 찾기
		/// </summary>
		private DataTable Select_Line_List()
		{
			DataSet ds_ret; 

			try
			{ 
				string process_name = "PKG_SPB_LINE.SELECT_LINE_LIST";

				MyOraDB.ReDim_Parameter(2); 
 
				MyOraDB.Process_Name = process_name;
   
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;   
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = cmb_LFactory.SelectedValue.ToString();  
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


		private void Pop_GetBomCdInfo_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

		
		 

	}
}

