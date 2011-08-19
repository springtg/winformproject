using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;

namespace FlexBase.MaterialBase
{
	public class Form_BC_Spec : COM.PCHWinForm.Pop_Large
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.StatusBar stbar;
		private System.Windows.Forms.StatusBarPanel statusBarPanel1;
		private System.Windows.Forms.StatusBarPanel statusBarPanel2;
		private System.Windows.Forms.Panel pnl_B;
		private System.Windows.Forms.Panel pnl_BR;
		private System.Windows.Forms.Splitter splitter1;
		public System.Windows.Forms.Panel pnl_SearchImage;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		private C1.Win.C1List.C1Combo cmb_Division;
		private System.Windows.Forms.Panel pnl_BL;
		public System.Windows.Forms.Panel pnl_BLT;
		private System.Windows.Forms.Label lbl_Division;
		private COM.SSP fgrid_Main;
		private FarPoint.Win.Spread.SheetView fgrid_Main_Sheet1;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.Label lbl_SubTitle2;
		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_Size;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txt_SizeF;
		private System.Windows.Forms.TextBox txt_SizeT;
		private C1.Win.C1List.C1Combo cmb_SizeF;
		private C1.Win.C1List.C1Combo cmb_SizeT;
		private System.Windows.Forms.Label lbl_SizeT;
		private System.Windows.Forms.Label lbl_SizeF;
		private System.Windows.Forms.GroupBox gb_Size_Result;
		private System.Windows.Forms.TextBox txt_SizeF_Rtn;
		private System.Windows.Forms.TextBox txt_SizeT_Rtn;
		private C1.Win.C1Command.C1OutPage obarpg_Unit;
		private System.Windows.Forms.GroupBox groupBox2;
		private C1.Win.C1List.C1Combo cmb_Unit_Unit;
		private System.Windows.Forms.Label lbl_Unit_From;
		private System.Windows.Forms.Label lbl_Unit_Unit;
		private System.Windows.Forms.TextBox txt_Unit_Value;
		private System.Windows.Forms.GroupBox gb_Unit_Result;
		private System.Windows.Forms.TextBox txt_Unit_Result1;
		private C1.Win.C1Command.C1OutPage obarpg_Formula1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lbl_Formula_Width;
		private System.Windows.Forms.TextBox txt_Formula_Width;
		private C1.Win.C1List.C1Combo cmb_Formula_Height;
		private System.Windows.Forms.TextBox txt_Formula_Height;
		private C1.Win.C1List.C1Combo cmb_Formula_Thick;
		private System.Windows.Forms.Label lbl_Formula_Thick;
		private System.Windows.Forms.Label lbl_Formula_Height;
		private System.Windows.Forms.TextBox txt_Formula_Thick;
		private C1.Win.C1List.C1Combo cmb_Formula_Width;
		private System.Windows.Forms.GroupBox gb_Formula_Result;
		private System.Windows.Forms.TextBox txt_Formula_Result1;
		private System.Windows.Forms.TextBox txt_Formula_Result3;
		private System.Windows.Forms.TextBox txt_Formula_Result2;
		private C1.Win.C1Command.C1OutPage obarpg_Formula2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txt_Formula2_Inch;
		private System.Windows.Forms.TextBox txt_Formula2_Thick;
		private C1.Win.C1List.C1Combo cmb_Formula2_Thick;
		private C1.Win.C1List.C1Combo cmb_Formula2_Inch;
		private System.Windows.Forms.Label lbl_Formula2_Inch;
		private System.Windows.Forms.Label lbl_Formula2_Thick;
		private System.Windows.Forms.GroupBox gb_Formula2_Result;
		private System.Windows.Forms.TextBox txt_Formula2_Result1;
		private System.Windows.Forms.TextBox txt_Formula2_Result2;
		private C1.Win.C1Command.C1OutPage obarpg_Etc;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.RadioButton rad_Etc_Etc;
		private System.Windows.Forms.RadioButton rad_Etc_Number;
		private System.Windows.Forms.TextBox txt_Etc_Value;
		private System.Windows.Forms.Label lbl_Etc_Value;
		private System.Windows.Forms.GroupBox gb_Etc_Result;
		private System.Windows.Forms.TextBox txt_Etc_Result1;
		private System.Windows.Forms.Label lbl_Symbol_Size;
		private System.Windows.Forms.Label lbl_Symbol_Formula2;
		private System.Windows.Forms.Label lbl_Symbol_Formula1;
		private System.Windows.Forms.Label lbl_Symbol_Formula3;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.Label btn_Clear;
		private System.Windows.Forms.Label lbl_Conv;
		private System.Windows.Forms.TextBox txt_Conversion;
		private System.ComponentModel.IContainer components = null;

		public Form_BC_Spec()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();


		}



		private bool _ReturnYN = false;

		public Form_BC_Spec(bool arg_returnyn)
		{ 


			InitializeComponent(); 

			_ReturnYN = arg_returnyn; 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Spec));
            C1.Win.C1List.Style style73 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style74 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style75 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style76 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style77 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style78 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style79 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style80 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style81 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style82 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style83 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style84 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style85 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style86 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style87 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style88 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style89 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style90 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style91 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style92 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style93 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style94 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style95 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style96 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style97 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style98 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style99 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style100 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style101 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style102 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style103 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style104 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style105 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style106 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style107 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style108 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style109 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style110 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style111 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style112 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style113 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style114 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style115 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style116 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style117 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style118 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style119 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style120 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style121 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style122 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style123 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style124 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style125 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style126 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style127 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style128 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style129 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style130 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style131 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style132 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style133 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style134 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style135 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style136 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style137 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style138 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style139 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style140 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style141 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style142 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style143 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style144 = new C1.Win.C1List.Style();
            this.pnl_B = new System.Windows.Forms.Panel();
            this.pnl_BL = new System.Windows.Forms.Panel();
            this.fgrid_Main = new COM.SSP();
            this.fgrid_Main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_BLT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.cmb_Division = new C1.Win.C1List.C1Combo();
            this.lbl_Division = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_BR = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Label();
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_Size = new C1.Win.C1Command.C1OutPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SizeF = new System.Windows.Forms.TextBox();
            this.txt_SizeT = new System.Windows.Forms.TextBox();
            this.cmb_SizeF = new C1.Win.C1List.C1Combo();
            this.cmb_SizeT = new C1.Win.C1List.C1Combo();
            this.lbl_SizeT = new System.Windows.Forms.Label();
            this.lbl_SizeF = new System.Windows.Forms.Label();
            this.gb_Size_Result = new System.Windows.Forms.GroupBox();
            this.lbl_Symbol_Size = new System.Windows.Forms.Label();
            this.txt_SizeF_Rtn = new System.Windows.Forms.TextBox();
            this.txt_SizeT_Rtn = new System.Windows.Forms.TextBox();
            this.obarpg_Unit = new C1.Win.C1Command.C1OutPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_Unit_Unit = new C1.Win.C1List.C1Combo();
            this.lbl_Unit_From = new System.Windows.Forms.Label();
            this.lbl_Unit_Unit = new System.Windows.Forms.Label();
            this.txt_Unit_Value = new System.Windows.Forms.TextBox();
            this.gb_Unit_Result = new System.Windows.Forms.GroupBox();
            this.txt_Unit_Result1 = new System.Windows.Forms.TextBox();
            this.obarpg_Formula1 = new C1.Win.C1Command.C1OutPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_Formula_Width = new System.Windows.Forms.Label();
            this.txt_Formula_Width = new System.Windows.Forms.TextBox();
            this.cmb_Formula_Height = new C1.Win.C1List.C1Combo();
            this.txt_Formula_Height = new System.Windows.Forms.TextBox();
            this.cmb_Formula_Thick = new C1.Win.C1List.C1Combo();
            this.lbl_Formula_Thick = new System.Windows.Forms.Label();
            this.lbl_Formula_Height = new System.Windows.Forms.Label();
            this.txt_Formula_Thick = new System.Windows.Forms.TextBox();
            this.cmb_Formula_Width = new C1.Win.C1List.C1Combo();
            this.gb_Formula_Result = new System.Windows.Forms.GroupBox();
            this.lbl_Symbol_Formula2 = new System.Windows.Forms.Label();
            this.lbl_Symbol_Formula1 = new System.Windows.Forms.Label();
            this.txt_Formula_Result1 = new System.Windows.Forms.TextBox();
            this.txt_Formula_Result3 = new System.Windows.Forms.TextBox();
            this.txt_Formula_Result2 = new System.Windows.Forms.TextBox();
            this.obarpg_Formula2 = new C1.Win.C1Command.C1OutPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_Formula2_Inch = new System.Windows.Forms.TextBox();
            this.txt_Formula2_Thick = new System.Windows.Forms.TextBox();
            this.cmb_Formula2_Thick = new C1.Win.C1List.C1Combo();
            this.cmb_Formula2_Inch = new C1.Win.C1List.C1Combo();
            this.lbl_Formula2_Inch = new System.Windows.Forms.Label();
            this.lbl_Formula2_Thick = new System.Windows.Forms.Label();
            this.gb_Formula2_Result = new System.Windows.Forms.GroupBox();
            this.lbl_Symbol_Formula3 = new System.Windows.Forms.Label();
            this.txt_Formula2_Result1 = new System.Windows.Forms.TextBox();
            this.txt_Formula2_Result2 = new System.Windows.Forms.TextBox();
            this.obarpg_Etc = new C1.Win.C1Command.C1OutPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txt_Conversion = new System.Windows.Forms.TextBox();
            this.lbl_Conv = new System.Windows.Forms.Label();
            this.rad_Etc_Etc = new System.Windows.Forms.RadioButton();
            this.rad_Etc_Number = new System.Windows.Forms.RadioButton();
            this.txt_Etc_Value = new System.Windows.Forms.TextBox();
            this.lbl_Etc_Value = new System.Windows.Forms.Label();
            this.gb_Etc_Result = new System.Windows.Forms.GroupBox();
            this.txt_Etc_Result1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle2 = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.stbar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.statusBarPanel2 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            this.pnl_BL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main_Sheet1)).BeginInit();
            this.pnl_BLT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.pnl_BR.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_Size.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeT)).BeginInit();
            this.gb_Size_Result.SuspendLayout();
            this.obarpg_Unit.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Unit_Unit)).BeginInit();
            this.gb_Unit_Result.SuspendLayout();
            this.obarpg_Formula1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Thick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Width)).BeginInit();
            this.gb_Formula_Result.SuspendLayout();
            this.obarpg_Formula2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula2_Thick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula2_Inch)).BeginInit();
            this.gb_Formula2_Result.SuspendLayout();
            this.obarpg_Etc.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gb_Etc_Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Menu
            // 
            this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
            this.img_Menu.Images.SetKeyName(0, "");
            this.img_Menu.Images.SetKeyName(1, "");
            this.img_Menu.Images.SetKeyName(2, "");
            this.img_Menu.Images.SetKeyName(3, "");
            this.img_Menu.Images.SetKeyName(4, "");
            this.img_Menu.Images.SetKeyName(5, "");
            this.img_Menu.Images.SetKeyName(6, "");
            this.img_Menu.Images.SetKeyName(7, "");
            this.img_Menu.Images.SetKeyName(8, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7});
            this.c1ToolBar1.Location = new System.Drawing.Point(505, 5);
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.tbtn_New);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Search);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Save);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Append);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Insert);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Delete);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Create);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Color);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Print);
            this.c1CommandHolder1.Commands.Add(this.tbtn_Conform);
            // 
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
            // 
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Location = new System.Drawing.Point(55, 24);
            this.lbl_MainTitle.Size = new System.Drawing.Size(449, 22);
            // 
            // tbtn_Print
            // 
            this.tbtn_Print.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Print_Click);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.pnl_BL);
            this.pnl_B.Controls.Add(this.splitter1);
            this.pnl_B.Controls.Add(this.pnl_BR);
            this.pnl_B.Location = new System.Drawing.Point(0, 60);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pnl_B.Size = new System.Drawing.Size(791, 479);
            this.pnl_B.TabIndex = 25;
            // 
            // pnl_BL
            // 
            this.pnl_BL.Controls.Add(this.fgrid_Main);
            this.pnl_BL.Controls.Add(this.pnl_BLT);
            this.pnl_BL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BL.Location = new System.Drawing.Point(4, 0);
            this.pnl_BL.Name = "pnl_BL";
            this.pnl_BL.Padding = new System.Windows.Forms.Padding(2, 0, 4, 4);
            this.pnl_BL.Size = new System.Drawing.Size(405, 479);
            this.pnl_BL.TabIndex = 2;
            // 
            // fgrid_Main
            // 
            this.fgrid_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Main.Location = new System.Drawing.Point(2, 60);
            this.fgrid_Main.Name = "fgrid_Main";
            this.fgrid_Main.Sheets.Add(this.fgrid_Main_Sheet1);
            this.fgrid_Main.Size = new System.Drawing.Size(399, 415);
            this.fgrid_Main.TabIndex = 44;
            this.fgrid_Main.EditModeOn += new System.EventHandler(this.fgrid_Main_EditModeOn);
            this.fgrid_Main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.fgrid_Main_EditChange);
            this.fgrid_Main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.fgrid_Main_CellDoubleClick);
            // 
            // fgrid_Main_Sheet1
            // 
            this.fgrid_Main_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_BLT
            // 
            this.pnl_BLT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BLT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BLT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BLT.Location = new System.Drawing.Point(2, 0);
            this.pnl_BLT.Name = "pnl_BLT";
            this.pnl_BLT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.pnl_BLT.Size = new System.Drawing.Size(399, 60);
            this.pnl_BLT.TabIndex = 42;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.cmb_Division);
            this.pnl_SearchImage.Controls.Add(this.lbl_Division);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(399, 56);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // picb_TM
            // 
            this.picb_TM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TM.Image = ((System.Drawing.Image)(resources.GetObject("picb_TM.Image")));
            this.picb_TM.Location = new System.Drawing.Point(224, 0);
            this.picb_TM.Name = "picb_TM";
            this.picb_TM.Size = new System.Drawing.Size(170, 30);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_SubTitle1
            // 
            this.lbl_SubTitle1.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle1.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle1.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle1.Image")));
            this.lbl_SubTitle1.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle1.Name = "lbl_SubTitle1";
            this.lbl_SubTitle1.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle1.TabIndex = 28;
            this.lbl_SubTitle1.Text = "      Search Specification";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Division
            // 
            this.cmb_Division.AddItemSeparator = ';';
            this.cmb_Division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Division.Caption = "";
            this.cmb_Division.CaptionHeight = 17;
            this.cmb_Division.CaptionStyle = style73;
            this.cmb_Division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Division.ColumnCaptionHeight = 18;
            this.cmb_Division.ColumnFooterHeight = 18;
            this.cmb_Division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Division.ContentHeight = 17;
            this.cmb_Division.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Division.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Division.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Division.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Division.EditorHeight = 17;
            this.cmb_Division.EvenRowStyle = style74;
            this.cmb_Division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Division.FooterStyle = style75;
            this.cmb_Division.HeadingStyle = style76;
            this.cmb_Division.HighLightRowStyle = style77;
            this.cmb_Division.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Division.Images"))));
            this.cmb_Division.ItemHeight = 15;
            this.cmb_Division.Location = new System.Drawing.Point(108, 30);
            this.cmb_Division.MatchEntryTimeout = ((long)(2000));
            this.cmb_Division.MaxDropDownItems = ((short)(5));
            this.cmb_Division.MaxLength = 32767;
            this.cmb_Division.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Division.Name = "cmb_Division";
            this.cmb_Division.OddRowStyle = style78;
            this.cmb_Division.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Division.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Division.SelectedStyle = style79;
            this.cmb_Division.Size = new System.Drawing.Size(210, 21);
            this.cmb_Division.Style = style80;
            this.cmb_Division.TabIndex = 149;
            this.cmb_Division.Tag = "PK";
            this.cmb_Division.SelectedValueChanged += new System.EventHandler(this.cmb_Division_SelectedValueChanged);
            this.cmb_Division.PropBag = resources.GetString("cmb_Division.PropBag");
            // 
            // lbl_Division
            // 
            this.lbl_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Division.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Division.ImageIndex = 0;
            this.lbl_Division.ImageList = this.img_Label;
            this.lbl_Division.Location = new System.Drawing.Point(7, 30);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(100, 21);
            this.lbl_Division.TabIndex = 36;
            this.lbl_Division.Text = "Division";
            this.lbl_Division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(312, 28);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(87, 21);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(385, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(21, 28);
            this.picb_TR.TabIndex = 21;
            this.picb_TR.TabStop = false;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(385, 42);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(14, 15);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(123, 41);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(262, 17);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 42);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(144, 19);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 22);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(144, 26);
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
            this.picb_MM.Location = new System.Drawing.Point(137, 22);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(255, 19);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(409, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 479);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnl_BR
            // 
            this.pnl_BR.Controls.Add(this.panel1);
            this.pnl_BR.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_BR.Location = new System.Drawing.Point(411, 0);
            this.pnl_BR.Name = "pnl_BR";
            this.pnl_BR.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.pnl_BR.Size = new System.Drawing.Size(376, 479);
            this.pnl_BR.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.panel1.Size = new System.Drawing.Size(372, 479);
            this.panel1.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.btn_Clear);
            this.panel2.Controls.Add(this.obar_Main);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.lbl_SubTitle2);
            this.panel2.Controls.Add(this.txt_Code);
            this.panel2.Controls.Add(this.lbl_Code);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 475);
            this.panel2.TabIndex = 18;
            // 
            // btn_Clear
            // 
            this.btn_Clear.ImageIndex = 13;
            this.btn_Clear.ImageList = this.img_SmallButton;
            this.btn_Clear.Location = new System.Drawing.Point(209, 30);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(21, 21);
            this.btn_Clear.TabIndex = 170;
            this.btn_Clear.Tag = "Clear";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Clear.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            this.btn_Clear.MouseHover += new System.EventHandler(this.btn_MouseHover);
            // 
            // obar_Main
            // 
            this.obar_Main.Animate = false;
            this.obar_Main.Controls.Add(this.obarpg_Size);
            this.obar_Main.Controls.Add(this.obarpg_Unit);
            this.obar_Main.Controls.Add(this.obarpg_Formula1);
            this.obar_Main.Controls.Add(this.obarpg_Formula2);
            this.obar_Main.Controls.Add(this.obarpg_Etc);
            this.obar_Main.Location = new System.Drawing.Point(7, 60);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 0;
            this.obar_Main.Size = new System.Drawing.Size(353, 404);
            // 
            // obarpg_Size
            // 
            this.obarpg_Size.Controls.Add(this.groupBox1);
            this.obarpg_Size.Controls.Add(this.gb_Size_Result);
            this.obarpg_Size.Name = "obarpg_Size";
            this.obarpg_Size.Size = new System.Drawing.Size(353, 319);
            this.obarpg_Size.Text = "Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SizeF);
            this.groupBox1.Controls.Add(this.txt_SizeT);
            this.groupBox1.Controls.Add(this.cmb_SizeF);
            this.groupBox1.Controls.Add(this.cmb_SizeT);
            this.groupBox1.Controls.Add(this.lbl_SizeT);
            this.groupBox1.Controls.Add(this.lbl_SizeF);
            this.groupBox1.Location = new System.Drawing.Point(7, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 62);
            this.groupBox1.TabIndex = 160;
            this.groupBox1.TabStop = false;
            // 
            // txt_SizeF
            // 
            this.txt_SizeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeF.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SizeF.Location = new System.Drawing.Point(108, 13);
            this.txt_SizeF.Name = "txt_SizeF";
            this.txt_SizeF.ReadOnly = true;
            this.txt_SizeF.Size = new System.Drawing.Size(100, 21);
            this.txt_SizeF.TabIndex = 157;
            this.txt_SizeF.Tag = "reset";
            // 
            // txt_SizeT
            // 
            this.txt_SizeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeT.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SizeT.Location = new System.Drawing.Point(108, 35);
            this.txt_SizeT.Name = "txt_SizeT";
            this.txt_SizeT.ReadOnly = true;
            this.txt_SizeT.Size = new System.Drawing.Size(100, 21);
            this.txt_SizeT.TabIndex = 158;
            this.txt_SizeT.Tag = "reset";
            // 
            // cmb_SizeF
            // 
            this.cmb_SizeF.AddItemSeparator = ';';
            this.cmb_SizeF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SizeF.Caption = "";
            this.cmb_SizeF.CaptionHeight = 17;
            this.cmb_SizeF.CaptionStyle = style81;
            this.cmb_SizeF.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SizeF.ColumnCaptionHeight = 18;
            this.cmb_SizeF.ColumnFooterHeight = 18;
            this.cmb_SizeF.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SizeF.ContentHeight = 17;
            this.cmb_SizeF.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SizeF.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SizeF.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SizeF.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SizeF.EditorHeight = 17;
            this.cmb_SizeF.EvenRowStyle = style82;
            this.cmb_SizeF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SizeF.FooterStyle = style83;
            this.cmb_SizeF.HeadingStyle = style84;
            this.cmb_SizeF.HighLightRowStyle = style85;
            this.cmb_SizeF.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SizeF.Images"))));
            this.cmb_SizeF.ItemHeight = 15;
            this.cmb_SizeF.Location = new System.Drawing.Point(209, 13);
            this.cmb_SizeF.MatchEntryTimeout = ((long)(2000));
            this.cmb_SizeF.MaxDropDownItems = ((short)(5));
            this.cmb_SizeF.MaxLength = 32767;
            this.cmb_SizeF.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SizeF.Name = "cmb_SizeF";
            this.cmb_SizeF.OddRowStyle = style86;
            this.cmb_SizeF.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SizeF.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SizeF.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SizeF.SelectedStyle = style87;
            this.cmb_SizeF.Size = new System.Drawing.Size(100, 21);
            this.cmb_SizeF.Style = style88;
            this.cmb_SizeF.TabIndex = 156;
            this.cmb_SizeF.Tag = "reset";
            this.cmb_SizeF.SelectedValueChanged += new System.EventHandler(this.cmb_SizeF_SelectedValueChanged);
            this.cmb_SizeF.PropBag = resources.GetString("cmb_SizeF.PropBag");
            // 
            // cmb_SizeT
            // 
            this.cmb_SizeT.AddItemSeparator = ';';
            this.cmb_SizeT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SizeT.Caption = "";
            this.cmb_SizeT.CaptionHeight = 17;
            this.cmb_SizeT.CaptionStyle = style89;
            this.cmb_SizeT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SizeT.ColumnCaptionHeight = 18;
            this.cmb_SizeT.ColumnFooterHeight = 18;
            this.cmb_SizeT.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SizeT.ContentHeight = 17;
            this.cmb_SizeT.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SizeT.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SizeT.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SizeT.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SizeT.EditorHeight = 17;
            this.cmb_SizeT.EvenRowStyle = style90;
            this.cmb_SizeT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SizeT.FooterStyle = style91;
            this.cmb_SizeT.HeadingStyle = style92;
            this.cmb_SizeT.HighLightRowStyle = style93;
            this.cmb_SizeT.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SizeT.Images"))));
            this.cmb_SizeT.ItemHeight = 15;
            this.cmb_SizeT.Location = new System.Drawing.Point(209, 35);
            this.cmb_SizeT.MatchEntryTimeout = ((long)(2000));
            this.cmb_SizeT.MaxDropDownItems = ((short)(5));
            this.cmb_SizeT.MaxLength = 32767;
            this.cmb_SizeT.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SizeT.Name = "cmb_SizeT";
            this.cmb_SizeT.OddRowStyle = style94;
            this.cmb_SizeT.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SizeT.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SizeT.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SizeT.SelectedStyle = style95;
            this.cmb_SizeT.Size = new System.Drawing.Size(100, 21);
            this.cmb_SizeT.Style = style96;
            this.cmb_SizeT.TabIndex = 155;
            this.cmb_SizeT.Tag = "reset";
            this.cmb_SizeT.SelectedValueChanged += new System.EventHandler(this.cmb_SizeT_SelectedValueChanged);
            this.cmb_SizeT.PropBag = resources.GetString("cmb_SizeT.PropBag");
            // 
            // lbl_SizeT
            // 
            this.lbl_SizeT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SizeT.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeT.ImageIndex = 0;
            this.lbl_SizeT.ImageList = this.img_Label;
            this.lbl_SizeT.Location = new System.Drawing.Point(7, 35);
            this.lbl_SizeT.Name = "lbl_SizeT";
            this.lbl_SizeT.Size = new System.Drawing.Size(100, 21);
            this.lbl_SizeT.TabIndex = 153;
            this.lbl_SizeT.Text = "To";
            this.lbl_SizeT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SizeF
            // 
            this.lbl_SizeF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SizeF.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SizeF.ImageIndex = 0;
            this.lbl_SizeF.ImageList = this.img_Label;
            this.lbl_SizeF.Location = new System.Drawing.Point(7, 13);
            this.lbl_SizeF.Name = "lbl_SizeF";
            this.lbl_SizeF.Size = new System.Drawing.Size(100, 21);
            this.lbl_SizeF.TabIndex = 154;
            this.lbl_SizeF.Text = "From";
            this.lbl_SizeF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Size_Result
            // 
            this.gb_Size_Result.Controls.Add(this.lbl_Symbol_Size);
            this.gb_Size_Result.Controls.Add(this.txt_SizeF_Rtn);
            this.gb_Size_Result.Controls.Add(this.txt_SizeT_Rtn);
            this.gb_Size_Result.Location = new System.Drawing.Point(7, 232);
            this.gb_Size_Result.Name = "gb_Size_Result";
            this.gb_Size_Result.Size = new System.Drawing.Size(320, 53);
            this.gb_Size_Result.TabIndex = 159;
            this.gb_Size_Result.TabStop = false;
            this.gb_Size_Result.Text = "Result";
            // 
            // lbl_Symbol_Size
            // 
            this.lbl_Symbol_Size.Location = new System.Drawing.Point(107, 22);
            this.lbl_Symbol_Size.Name = "lbl_Symbol_Size";
            this.lbl_Symbol_Size.Size = new System.Drawing.Size(15, 21);
            this.lbl_Symbol_Size.TabIndex = 155;
            this.lbl_Symbol_Size.Text = "-";
            this.lbl_Symbol_Size.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_SizeF_Rtn
            // 
            this.txt_SizeF_Rtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeF_Rtn.Location = new System.Drawing.Point(7, 22);
            this.txt_SizeF_Rtn.Name = "txt_SizeF_Rtn";
            this.txt_SizeF_Rtn.ReadOnly = true;
            this.txt_SizeF_Rtn.Size = new System.Drawing.Size(100, 21);
            this.txt_SizeF_Rtn.TabIndex = 154;
            // 
            // txt_SizeT_Rtn
            // 
            this.txt_SizeT_Rtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SizeT_Rtn.Location = new System.Drawing.Point(122, 22);
            this.txt_SizeT_Rtn.Name = "txt_SizeT_Rtn";
            this.txt_SizeT_Rtn.ReadOnly = true;
            this.txt_SizeT_Rtn.Size = new System.Drawing.Size(100, 21);
            this.txt_SizeT_Rtn.TabIndex = 153;
            // 
            // obarpg_Unit
            // 
            this.obarpg_Unit.Controls.Add(this.groupBox2);
            this.obarpg_Unit.Controls.Add(this.gb_Unit_Result);
            this.obarpg_Unit.Name = "obarpg_Unit";
            this.obarpg_Unit.Size = new System.Drawing.Size(353, 319);
            this.obarpg_Unit.Text = "Unit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_Unit_Unit);
            this.groupBox2.Controls.Add(this.lbl_Unit_From);
            this.groupBox2.Controls.Add(this.lbl_Unit_Unit);
            this.groupBox2.Controls.Add(this.txt_Unit_Value);
            this.groupBox2.Location = new System.Drawing.Point(7, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 62);
            this.groupBox2.TabIndex = 161;
            this.groupBox2.TabStop = false;
            // 
            // cmb_Unit_Unit
            // 
            this.cmb_Unit_Unit.AddItemSeparator = ';';
            this.cmb_Unit_Unit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Unit_Unit.Caption = "";
            this.cmb_Unit_Unit.CaptionHeight = 17;
            this.cmb_Unit_Unit.CaptionStyle = style97;
            this.cmb_Unit_Unit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Unit_Unit.ColumnCaptionHeight = 18;
            this.cmb_Unit_Unit.ColumnFooterHeight = 18;
            this.cmb_Unit_Unit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Unit_Unit.ContentHeight = 17;
            this.cmb_Unit_Unit.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Unit_Unit.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Unit_Unit.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit_Unit.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Unit_Unit.EditorHeight = 17;
            this.cmb_Unit_Unit.EvenRowStyle = style98;
            this.cmb_Unit_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Unit_Unit.FooterStyle = style99;
            this.cmb_Unit_Unit.HeadingStyle = style100;
            this.cmb_Unit_Unit.HighLightRowStyle = style101;
            this.cmb_Unit_Unit.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Unit_Unit.Images"))));
            this.cmb_Unit_Unit.ItemHeight = 15;
            this.cmb_Unit_Unit.Location = new System.Drawing.Point(108, 35);
            this.cmb_Unit_Unit.MatchEntryTimeout = ((long)(2000));
            this.cmb_Unit_Unit.MaxDropDownItems = ((short)(5));
            this.cmb_Unit_Unit.MaxLength = 32767;
            this.cmb_Unit_Unit.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Unit_Unit.Name = "cmb_Unit_Unit";
            this.cmb_Unit_Unit.OddRowStyle = style102;
            this.cmb_Unit_Unit.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Unit_Unit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Unit_Unit.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Unit_Unit.SelectedStyle = style103;
            this.cmb_Unit_Unit.Size = new System.Drawing.Size(100, 21);
            this.cmb_Unit_Unit.Style = style104;
            this.cmb_Unit_Unit.TabIndex = 158;
            this.cmb_Unit_Unit.SelectedValueChanged += new System.EventHandler(this.cmb_Unit_Unit_SelectedValueChanged);
            this.cmb_Unit_Unit.PropBag = resources.GetString("cmb_Unit_Unit.PropBag");
            // 
            // lbl_Unit_From
            // 
            this.lbl_Unit_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Unit_From.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_From.ImageIndex = 0;
            this.lbl_Unit_From.ImageList = this.img_Label;
            this.lbl_Unit_From.Location = new System.Drawing.Point(7, 13);
            this.lbl_Unit_From.Name = "lbl_Unit_From";
            this.lbl_Unit_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_Unit_From.TabIndex = 157;
            this.lbl_Unit_From.Text = "Value";
            this.lbl_Unit_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Unit_Unit
            // 
            this.lbl_Unit_Unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Unit_Unit.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Unit_Unit.ImageIndex = 0;
            this.lbl_Unit_Unit.ImageList = this.img_Label;
            this.lbl_Unit_Unit.Location = new System.Drawing.Point(7, 35);
            this.lbl_Unit_Unit.Name = "lbl_Unit_Unit";
            this.lbl_Unit_Unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_Unit_Unit.TabIndex = 156;
            this.lbl_Unit_Unit.Text = "Unit";
            this.lbl_Unit_Unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Unit_Value
            // 
            this.txt_Unit_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Unit_Value.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Unit_Value.Location = new System.Drawing.Point(108, 13);
            this.txt_Unit_Value.Name = "txt_Unit_Value";
            this.txt_Unit_Value.Size = new System.Drawing.Size(100, 21);
            this.txt_Unit_Value.TabIndex = 159;
            this.txt_Unit_Value.TextChanged += new System.EventHandler(this.txt_Unit_Value_TextChanged);
            // 
            // gb_Unit_Result
            // 
            this.gb_Unit_Result.Controls.Add(this.txt_Unit_Result1);
            this.gb_Unit_Result.Location = new System.Drawing.Point(7, 232);
            this.gb_Unit_Result.Name = "gb_Unit_Result";
            this.gb_Unit_Result.Size = new System.Drawing.Size(320, 53);
            this.gb_Unit_Result.TabIndex = 160;
            this.gb_Unit_Result.TabStop = false;
            this.gb_Unit_Result.Text = "Result";
            // 
            // txt_Unit_Result1
            // 
            this.txt_Unit_Result1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Unit_Result1.Location = new System.Drawing.Point(7, 22);
            this.txt_Unit_Result1.Name = "txt_Unit_Result1";
            this.txt_Unit_Result1.ReadOnly = true;
            this.txt_Unit_Result1.Size = new System.Drawing.Size(210, 21);
            this.txt_Unit_Result1.TabIndex = 154;
            // 
            // obarpg_Formula1
            // 
            this.obarpg_Formula1.Controls.Add(this.groupBox3);
            this.obarpg_Formula1.Controls.Add(this.gb_Formula_Result);
            this.obarpg_Formula1.Name = "obarpg_Formula1";
            this.obarpg_Formula1.Size = new System.Drawing.Size(353, 319);
            this.obarpg_Formula1.Text = "Formula (Width * Height * Thick)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_Formula_Width);
            this.groupBox3.Controls.Add(this.txt_Formula_Width);
            this.groupBox3.Controls.Add(this.cmb_Formula_Height);
            this.groupBox3.Controls.Add(this.txt_Formula_Height);
            this.groupBox3.Controls.Add(this.cmb_Formula_Thick);
            this.groupBox3.Controls.Add(this.lbl_Formula_Thick);
            this.groupBox3.Controls.Add(this.lbl_Formula_Height);
            this.groupBox3.Controls.Add(this.txt_Formula_Thick);
            this.groupBox3.Controls.Add(this.cmb_Formula_Width);
            this.groupBox3.Location = new System.Drawing.Point(7, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 85);
            this.groupBox3.TabIndex = 173;
            this.groupBox3.TabStop = false;
            // 
            // lbl_Formula_Width
            // 
            this.lbl_Formula_Width.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Formula_Width.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Formula_Width.ImageIndex = 0;
            this.lbl_Formula_Width.ImageList = this.img_Label;
            this.lbl_Formula_Width.Location = new System.Drawing.Point(7, 13);
            this.lbl_Formula_Width.Name = "lbl_Formula_Width";
            this.lbl_Formula_Width.Size = new System.Drawing.Size(100, 21);
            this.lbl_Formula_Width.TabIndex = 164;
            this.lbl_Formula_Width.Text = "Width";
            this.lbl_Formula_Width.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Formula_Width
            // 
            this.txt_Formula_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Width.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Formula_Width.Location = new System.Drawing.Point(108, 13);
            this.txt_Formula_Width.Name = "txt_Formula_Width";
            this.txt_Formula_Width.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula_Width.TabIndex = 166;
            this.txt_Formula_Width.TextChanged += new System.EventHandler(this.txt_Formula_TextChanged);
            // 
            // cmb_Formula_Height
            // 
            this.cmb_Formula_Height.AddItemSeparator = ';';
            this.cmb_Formula_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Formula_Height.Caption = "";
            this.cmb_Formula_Height.CaptionHeight = 17;
            this.cmb_Formula_Height.CaptionStyle = style105;
            this.cmb_Formula_Height.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Formula_Height.ColumnCaptionHeight = 18;
            this.cmb_Formula_Height.ColumnFooterHeight = 18;
            this.cmb_Formula_Height.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Formula_Height.ContentHeight = 17;
            this.cmb_Formula_Height.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Formula_Height.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Formula_Height.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Height.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Formula_Height.EditorHeight = 17;
            this.cmb_Formula_Height.EvenRowStyle = style106;
            this.cmb_Formula_Height.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Height.FooterStyle = style107;
            this.cmb_Formula_Height.HeadingStyle = style108;
            this.cmb_Formula_Height.HighLightRowStyle = style109;
            this.cmb_Formula_Height.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Formula_Height.Images"))));
            this.cmb_Formula_Height.ItemHeight = 15;
            this.cmb_Formula_Height.Location = new System.Drawing.Point(209, 35);
            this.cmb_Formula_Height.MatchEntryTimeout = ((long)(2000));
            this.cmb_Formula_Height.MaxDropDownItems = ((short)(5));
            this.cmb_Formula_Height.MaxLength = 32767;
            this.cmb_Formula_Height.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Formula_Height.Name = "cmb_Formula_Height";
            this.cmb_Formula_Height.OddRowStyle = style110;
            this.cmb_Formula_Height.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Height.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Formula_Height.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Height.SelectedStyle = style111;
            this.cmb_Formula_Height.Size = new System.Drawing.Size(100, 21);
            this.cmb_Formula_Height.Style = style112;
            this.cmb_Formula_Height.TabIndex = 171;
            this.cmb_Formula_Height.SelectedValueChanged += new System.EventHandler(this.cmb_Formula_SelectedValueChanged);
            this.cmb_Formula_Height.PropBag = resources.GetString("cmb_Formula_Height.PropBag");
            // 
            // txt_Formula_Height
            // 
            this.txt_Formula_Height.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Height.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Formula_Height.Location = new System.Drawing.Point(108, 35);
            this.txt_Formula_Height.Name = "txt_Formula_Height";
            this.txt_Formula_Height.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula_Height.TabIndex = 169;
            this.txt_Formula_Height.TextChanged += new System.EventHandler(this.txt_Formula_TextChanged);
            // 
            // cmb_Formula_Thick
            // 
            this.cmb_Formula_Thick.AddItemSeparator = ';';
            this.cmb_Formula_Thick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Formula_Thick.Caption = "";
            this.cmb_Formula_Thick.CaptionHeight = 17;
            this.cmb_Formula_Thick.CaptionStyle = style113;
            this.cmb_Formula_Thick.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Formula_Thick.ColumnCaptionHeight = 18;
            this.cmb_Formula_Thick.ColumnFooterHeight = 18;
            this.cmb_Formula_Thick.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Formula_Thick.ContentHeight = 17;
            this.cmb_Formula_Thick.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Formula_Thick.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Formula_Thick.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Thick.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Formula_Thick.EditorHeight = 17;
            this.cmb_Formula_Thick.EvenRowStyle = style114;
            this.cmb_Formula_Thick.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Thick.FooterStyle = style115;
            this.cmb_Formula_Thick.HeadingStyle = style116;
            this.cmb_Formula_Thick.HighLightRowStyle = style117;
            this.cmb_Formula_Thick.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Formula_Thick.Images"))));
            this.cmb_Formula_Thick.ItemHeight = 15;
            this.cmb_Formula_Thick.Location = new System.Drawing.Point(209, 57);
            this.cmb_Formula_Thick.MatchEntryTimeout = ((long)(2000));
            this.cmb_Formula_Thick.MaxDropDownItems = ((short)(5));
            this.cmb_Formula_Thick.MaxLength = 32767;
            this.cmb_Formula_Thick.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Formula_Thick.Name = "cmb_Formula_Thick";
            this.cmb_Formula_Thick.OddRowStyle = style118;
            this.cmb_Formula_Thick.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Thick.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Formula_Thick.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Thick.SelectedStyle = style119;
            this.cmb_Formula_Thick.Size = new System.Drawing.Size(100, 21);
            this.cmb_Formula_Thick.Style = style120;
            this.cmb_Formula_Thick.TabIndex = 172;
            this.cmb_Formula_Thick.SelectedValueChanged += new System.EventHandler(this.cmb_Formula_SelectedValueChanged);
            this.cmb_Formula_Thick.PropBag = resources.GetString("cmb_Formula_Thick.PropBag");
            // 
            // lbl_Formula_Thick
            // 
            this.lbl_Formula_Thick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Formula_Thick.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Formula_Thick.ImageIndex = 0;
            this.lbl_Formula_Thick.ImageList = this.img_Label;
            this.lbl_Formula_Thick.Location = new System.Drawing.Point(7, 57);
            this.lbl_Formula_Thick.Name = "lbl_Formula_Thick";
            this.lbl_Formula_Thick.Size = new System.Drawing.Size(100, 21);
            this.lbl_Formula_Thick.TabIndex = 168;
            this.lbl_Formula_Thick.Text = "Thick";
            this.lbl_Formula_Thick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Formula_Height
            // 
            this.lbl_Formula_Height.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Formula_Height.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Formula_Height.ImageIndex = 0;
            this.lbl_Formula_Height.ImageList = this.img_Label;
            this.lbl_Formula_Height.Location = new System.Drawing.Point(7, 35);
            this.lbl_Formula_Height.Name = "lbl_Formula_Height";
            this.lbl_Formula_Height.Size = new System.Drawing.Size(100, 21);
            this.lbl_Formula_Height.TabIndex = 163;
            this.lbl_Formula_Height.Text = "Height";
            this.lbl_Formula_Height.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Formula_Thick
            // 
            this.txt_Formula_Thick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Thick.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Formula_Thick.Location = new System.Drawing.Point(108, 57);
            this.txt_Formula_Thick.Name = "txt_Formula_Thick";
            this.txt_Formula_Thick.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula_Thick.TabIndex = 170;
            this.txt_Formula_Thick.TextChanged += new System.EventHandler(this.txt_Formula_TextChanged);
            // 
            // cmb_Formula_Width
            // 
            this.cmb_Formula_Width.AddItemSeparator = ';';
            this.cmb_Formula_Width.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Formula_Width.Caption = "";
            this.cmb_Formula_Width.CaptionHeight = 17;
            this.cmb_Formula_Width.CaptionStyle = style121;
            this.cmb_Formula_Width.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Formula_Width.ColumnCaptionHeight = 18;
            this.cmb_Formula_Width.ColumnFooterHeight = 18;
            this.cmb_Formula_Width.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Formula_Width.ContentHeight = 17;
            this.cmb_Formula_Width.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Formula_Width.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Formula_Width.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Width.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Formula_Width.EditorHeight = 17;
            this.cmb_Formula_Width.EvenRowStyle = style122;
            this.cmb_Formula_Width.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula_Width.FooterStyle = style123;
            this.cmb_Formula_Width.HeadingStyle = style124;
            this.cmb_Formula_Width.HighLightRowStyle = style125;
            this.cmb_Formula_Width.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Formula_Width.Images"))));
            this.cmb_Formula_Width.ItemHeight = 15;
            this.cmb_Formula_Width.Location = new System.Drawing.Point(209, 13);
            this.cmb_Formula_Width.MatchEntryTimeout = ((long)(2000));
            this.cmb_Formula_Width.MaxDropDownItems = ((short)(5));
            this.cmb_Formula_Width.MaxLength = 32767;
            this.cmb_Formula_Width.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Formula_Width.Name = "cmb_Formula_Width";
            this.cmb_Formula_Width.OddRowStyle = style126;
            this.cmb_Formula_Width.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Width.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Formula_Width.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Formula_Width.SelectedStyle = style127;
            this.cmb_Formula_Width.Size = new System.Drawing.Size(100, 21);
            this.cmb_Formula_Width.Style = style128;
            this.cmb_Formula_Width.TabIndex = 165;
            this.cmb_Formula_Width.SelectedValueChanged += new System.EventHandler(this.cmb_Formula_SelectedValueChanged);
            this.cmb_Formula_Width.PropBag = resources.GetString("cmb_Formula_Width.PropBag");
            // 
            // gb_Formula_Result
            // 
            this.gb_Formula_Result.Controls.Add(this.lbl_Symbol_Formula2);
            this.gb_Formula_Result.Controls.Add(this.lbl_Symbol_Formula1);
            this.gb_Formula_Result.Controls.Add(this.txt_Formula_Result1);
            this.gb_Formula_Result.Controls.Add(this.txt_Formula_Result3);
            this.gb_Formula_Result.Controls.Add(this.txt_Formula_Result2);
            this.gb_Formula_Result.Location = new System.Drawing.Point(7, 232);
            this.gb_Formula_Result.Name = "gb_Formula_Result";
            this.gb_Formula_Result.Size = new System.Drawing.Size(320, 53);
            this.gb_Formula_Result.TabIndex = 167;
            this.gb_Formula_Result.TabStop = false;
            this.gb_Formula_Result.Text = "Result";
            // 
            // lbl_Symbol_Formula2
            // 
            this.lbl_Symbol_Formula2.Location = new System.Drawing.Point(182, 22);
            this.lbl_Symbol_Formula2.Name = "lbl_Symbol_Formula2";
            this.lbl_Symbol_Formula2.Size = new System.Drawing.Size(15, 21);
            this.lbl_Symbol_Formula2.TabIndex = 162;
            this.lbl_Symbol_Formula2.Text = "*";
            this.lbl_Symbol_Formula2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Symbol_Formula1
            // 
            this.lbl_Symbol_Formula1.Location = new System.Drawing.Point(87, 22);
            this.lbl_Symbol_Formula1.Name = "lbl_Symbol_Formula1";
            this.lbl_Symbol_Formula1.Size = new System.Drawing.Size(15, 21);
            this.lbl_Symbol_Formula1.TabIndex = 161;
            this.lbl_Symbol_Formula1.Text = "*";
            this.lbl_Symbol_Formula1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Formula_Result1
            // 
            this.txt_Formula_Result1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Result1.Location = new System.Drawing.Point(7, 22);
            this.txt_Formula_Result1.Name = "txt_Formula_Result1";
            this.txt_Formula_Result1.ReadOnly = true;
            this.txt_Formula_Result1.Size = new System.Drawing.Size(80, 21);
            this.txt_Formula_Result1.TabIndex = 154;
            // 
            // txt_Formula_Result3
            // 
            this.txt_Formula_Result3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Result3.Location = new System.Drawing.Point(197, 22);
            this.txt_Formula_Result3.Name = "txt_Formula_Result3";
            this.txt_Formula_Result3.ReadOnly = true;
            this.txt_Formula_Result3.Size = new System.Drawing.Size(80, 21);
            this.txt_Formula_Result3.TabIndex = 160;
            // 
            // txt_Formula_Result2
            // 
            this.txt_Formula_Result2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula_Result2.Location = new System.Drawing.Point(102, 22);
            this.txt_Formula_Result2.Name = "txt_Formula_Result2";
            this.txt_Formula_Result2.ReadOnly = true;
            this.txt_Formula_Result2.Size = new System.Drawing.Size(80, 21);
            this.txt_Formula_Result2.TabIndex = 159;
            // 
            // obarpg_Formula2
            // 
            this.obarpg_Formula2.Controls.Add(this.groupBox4);
            this.obarpg_Formula2.Controls.Add(this.gb_Formula2_Result);
            this.obarpg_Formula2.Name = "obarpg_Formula2";
            this.obarpg_Formula2.Size = new System.Drawing.Size(353, 319);
            this.obarpg_Formula2.Text = "Formula (Thick , Inch(\"))";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_Formula2_Inch);
            this.groupBox4.Controls.Add(this.txt_Formula2_Thick);
            this.groupBox4.Controls.Add(this.cmb_Formula2_Thick);
            this.groupBox4.Controls.Add(this.cmb_Formula2_Inch);
            this.groupBox4.Controls.Add(this.lbl_Formula2_Inch);
            this.groupBox4.Controls.Add(this.lbl_Formula2_Thick);
            this.groupBox4.Location = new System.Drawing.Point(7, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 62);
            this.groupBox4.TabIndex = 169;
            this.groupBox4.TabStop = false;
            // 
            // txt_Formula2_Inch
            // 
            this.txt_Formula2_Inch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula2_Inch.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Formula2_Inch.Location = new System.Drawing.Point(108, 35);
            this.txt_Formula2_Inch.Name = "txt_Formula2_Inch";
            this.txt_Formula2_Inch.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula2_Inch.TabIndex = 167;
            this.txt_Formula2_Inch.TextChanged += new System.EventHandler(this.txt_Formula2_TextChanged);
            // 
            // txt_Formula2_Thick
            // 
            this.txt_Formula2_Thick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula2_Thick.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Formula2_Thick.Location = new System.Drawing.Point(108, 13);
            this.txt_Formula2_Thick.Name = "txt_Formula2_Thick";
            this.txt_Formula2_Thick.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula2_Thick.TabIndex = 165;
            this.txt_Formula2_Thick.TextChanged += new System.EventHandler(this.txt_Formula2_TextChanged);
            // 
            // cmb_Formula2_Thick
            // 
            this.cmb_Formula2_Thick.AddItemSeparator = ';';
            this.cmb_Formula2_Thick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Formula2_Thick.Caption = "";
            this.cmb_Formula2_Thick.CaptionHeight = 17;
            this.cmb_Formula2_Thick.CaptionStyle = style129;
            this.cmb_Formula2_Thick.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Formula2_Thick.ColumnCaptionHeight = 18;
            this.cmb_Formula2_Thick.ColumnFooterHeight = 18;
            this.cmb_Formula2_Thick.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Formula2_Thick.ContentHeight = 17;
            this.cmb_Formula2_Thick.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Formula2_Thick.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Formula2_Thick.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula2_Thick.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Formula2_Thick.EditorHeight = 17;
            this.cmb_Formula2_Thick.EvenRowStyle = style130;
            this.cmb_Formula2_Thick.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula2_Thick.FooterStyle = style131;
            this.cmb_Formula2_Thick.HeadingStyle = style132;
            this.cmb_Formula2_Thick.HighLightRowStyle = style133;
            this.cmb_Formula2_Thick.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Formula2_Thick.Images"))));
            this.cmb_Formula2_Thick.ItemHeight = 15;
            this.cmb_Formula2_Thick.Location = new System.Drawing.Point(209, 13);
            this.cmb_Formula2_Thick.MatchEntryTimeout = ((long)(2000));
            this.cmb_Formula2_Thick.MaxDropDownItems = ((short)(5));
            this.cmb_Formula2_Thick.MaxLength = 32767;
            this.cmb_Formula2_Thick.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Formula2_Thick.Name = "cmb_Formula2_Thick";
            this.cmb_Formula2_Thick.OddRowStyle = style134;
            this.cmb_Formula2_Thick.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Formula2_Thick.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Formula2_Thick.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Formula2_Thick.SelectedStyle = style135;
            this.cmb_Formula2_Thick.Size = new System.Drawing.Size(100, 21);
            this.cmb_Formula2_Thick.Style = style136;
            this.cmb_Formula2_Thick.TabIndex = 164;
            this.cmb_Formula2_Thick.SelectedValueChanged += new System.EventHandler(this.cmb_Formula2_SelectedValueChanged);
            this.cmb_Formula2_Thick.PropBag = resources.GetString("cmb_Formula2_Thick.PropBag");
            // 
            // cmb_Formula2_Inch
            // 
            this.cmb_Formula2_Inch.AddItemSeparator = ';';
            this.cmb_Formula2_Inch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Formula2_Inch.Caption = "";
            this.cmb_Formula2_Inch.CaptionHeight = 17;
            this.cmb_Formula2_Inch.CaptionStyle = style137;
            this.cmb_Formula2_Inch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Formula2_Inch.ColumnCaptionHeight = 18;
            this.cmb_Formula2_Inch.ColumnFooterHeight = 18;
            this.cmb_Formula2_Inch.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Formula2_Inch.ContentHeight = 17;
            this.cmb_Formula2_Inch.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Formula2_Inch.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_Formula2_Inch.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula2_Inch.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Formula2_Inch.EditorHeight = 17;
            this.cmb_Formula2_Inch.Enabled = false;
            this.cmb_Formula2_Inch.EvenRowStyle = style138;
            this.cmb_Formula2_Inch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Formula2_Inch.FooterStyle = style139;
            this.cmb_Formula2_Inch.HeadingStyle = style140;
            this.cmb_Formula2_Inch.HighLightRowStyle = style141;
            this.cmb_Formula2_Inch.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Formula2_Inch.Images"))));
            this.cmb_Formula2_Inch.ItemHeight = 15;
            this.cmb_Formula2_Inch.Location = new System.Drawing.Point(209, 35);
            this.cmb_Formula2_Inch.MatchEntryTimeout = ((long)(2000));
            this.cmb_Formula2_Inch.MaxDropDownItems = ((short)(5));
            this.cmb_Formula2_Inch.MaxLength = 32767;
            this.cmb_Formula2_Inch.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Formula2_Inch.Name = "cmb_Formula2_Inch";
            this.cmb_Formula2_Inch.OddRowStyle = style142;
            this.cmb_Formula2_Inch.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Formula2_Inch.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Formula2_Inch.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Formula2_Inch.SelectedStyle = style143;
            this.cmb_Formula2_Inch.Size = new System.Drawing.Size(100, 21);
            this.cmb_Formula2_Inch.Style = style144;
            this.cmb_Formula2_Inch.TabIndex = 168;
            this.cmb_Formula2_Inch.PropBag = resources.GetString("cmb_Formula2_Inch.PropBag");
            // 
            // lbl_Formula2_Inch
            // 
            this.lbl_Formula2_Inch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Formula2_Inch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Formula2_Inch.ImageIndex = 0;
            this.lbl_Formula2_Inch.ImageList = this.img_Label;
            this.lbl_Formula2_Inch.Location = new System.Drawing.Point(7, 35);
            this.lbl_Formula2_Inch.Name = "lbl_Formula2_Inch";
            this.lbl_Formula2_Inch.Size = new System.Drawing.Size(100, 21);
            this.lbl_Formula2_Inch.TabIndex = 162;
            this.lbl_Formula2_Inch.Text = "Inch";
            this.lbl_Formula2_Inch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Formula2_Thick
            // 
            this.lbl_Formula2_Thick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Formula2_Thick.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Formula2_Thick.ImageIndex = 0;
            this.lbl_Formula2_Thick.ImageList = this.img_Label;
            this.lbl_Formula2_Thick.Location = new System.Drawing.Point(7, 13);
            this.lbl_Formula2_Thick.Name = "lbl_Formula2_Thick";
            this.lbl_Formula2_Thick.Size = new System.Drawing.Size(100, 21);
            this.lbl_Formula2_Thick.TabIndex = 163;
            this.lbl_Formula2_Thick.Text = "Thick";
            this.lbl_Formula2_Thick.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Formula2_Result
            // 
            this.gb_Formula2_Result.Controls.Add(this.lbl_Symbol_Formula3);
            this.gb_Formula2_Result.Controls.Add(this.txt_Formula2_Result1);
            this.gb_Formula2_Result.Controls.Add(this.txt_Formula2_Result2);
            this.gb_Formula2_Result.Location = new System.Drawing.Point(7, 232);
            this.gb_Formula2_Result.Name = "gb_Formula2_Result";
            this.gb_Formula2_Result.Size = new System.Drawing.Size(320, 53);
            this.gb_Formula2_Result.TabIndex = 166;
            this.gb_Formula2_Result.TabStop = false;
            this.gb_Formula2_Result.Text = "Result";
            // 
            // lbl_Symbol_Formula3
            // 
            this.lbl_Symbol_Formula3.Location = new System.Drawing.Point(107, 22);
            this.lbl_Symbol_Formula3.Name = "lbl_Symbol_Formula3";
            this.lbl_Symbol_Formula3.Size = new System.Drawing.Size(15, 21);
            this.lbl_Symbol_Formula3.TabIndex = 161;
            this.lbl_Symbol_Formula3.Text = ",";
            this.lbl_Symbol_Formula3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Formula2_Result1
            // 
            this.txt_Formula2_Result1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula2_Result1.Location = new System.Drawing.Point(7, 22);
            this.txt_Formula2_Result1.Name = "txt_Formula2_Result1";
            this.txt_Formula2_Result1.ReadOnly = true;
            this.txt_Formula2_Result1.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula2_Result1.TabIndex = 154;
            // 
            // txt_Formula2_Result2
            // 
            this.txt_Formula2_Result2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Formula2_Result2.Location = new System.Drawing.Point(122, 22);
            this.txt_Formula2_Result2.Name = "txt_Formula2_Result2";
            this.txt_Formula2_Result2.ReadOnly = true;
            this.txt_Formula2_Result2.Size = new System.Drawing.Size(100, 21);
            this.txt_Formula2_Result2.TabIndex = 159;
            // 
            // obarpg_Etc
            // 
            this.obarpg_Etc.Controls.Add(this.groupBox5);
            this.obarpg_Etc.Controls.Add(this.gb_Etc_Result);
            this.obarpg_Etc.Name = "obarpg_Etc";
            this.obarpg_Etc.Size = new System.Drawing.Size(353, 302);
            this.obarpg_Etc.Text = "Etc. String";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_Conversion);
            this.groupBox5.Controls.Add(this.lbl_Conv);
            this.groupBox5.Controls.Add(this.rad_Etc_Etc);
            this.groupBox5.Controls.Add(this.rad_Etc_Number);
            this.groupBox5.Controls.Add(this.txt_Etc_Value);
            this.groupBox5.Controls.Add(this.lbl_Etc_Value);
            this.groupBox5.Location = new System.Drawing.Point(7, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 94);
            this.groupBox5.TabIndex = 165;
            this.groupBox5.TabStop = false;
            // 
            // txt_Conversion
            // 
            this.txt_Conversion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Conversion.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Conversion.Location = new System.Drawing.Point(108, 67);
            this.txt_Conversion.Name = "txt_Conversion";
            this.txt_Conversion.Size = new System.Drawing.Size(200, 21);
            this.txt_Conversion.TabIndex = 596;
            this.txt_Conversion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Conversion_KeyPress);
            // 
            // lbl_Conv
            // 
            this.lbl_Conv.ImageIndex = 0;
            this.lbl_Conv.ImageList = this.img_Label;
            this.lbl_Conv.Location = new System.Drawing.Point(7, 67);
            this.lbl_Conv.Name = "lbl_Conv";
            this.lbl_Conv.Size = new System.Drawing.Size(100, 21);
            this.lbl_Conv.TabIndex = 595;
            this.lbl_Conv.Text = "Conversion";
            this.lbl_Conv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rad_Etc_Etc
            // 
            this.rad_Etc_Etc.Checked = true;
            this.rad_Etc_Etc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Etc_Etc.Location = new System.Drawing.Point(110, 13);
            this.rad_Etc_Etc.Name = "rad_Etc_Etc";
            this.rad_Etc_Etc.Size = new System.Drawing.Size(103, 21);
            this.rad_Etc_Etc.TabIndex = 164;
            this.rad_Etc_Etc.TabStop = true;
            this.rad_Etc_Etc.Text = "Etc.";
            // 
            // rad_Etc_Number
            // 
            this.rad_Etc_Number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rad_Etc_Number.Location = new System.Drawing.Point(7, 13);
            this.rad_Etc_Number.Name = "rad_Etc_Number";
            this.rad_Etc_Number.Size = new System.Drawing.Size(103, 21);
            this.rad_Etc_Number.TabIndex = 163;
            this.rad_Etc_Number.Text = "Number Type";
            this.rad_Etc_Number.CheckedChanged += new System.EventHandler(this.rad_Etc_CheckedChanged);
            // 
            // txt_Etc_Value
            // 
            this.txt_Etc_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Etc_Value.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_Etc_Value.Location = new System.Drawing.Point(108, 45);
            this.txt_Etc_Value.Name = "txt_Etc_Value";
            this.txt_Etc_Value.Size = new System.Drawing.Size(200, 21);
            this.txt_Etc_Value.TabIndex = 162;
            this.txt_Etc_Value.TextChanged += new System.EventHandler(this.txt_Etc_Value_TextChanged);
            // 
            // lbl_Etc_Value
            // 
            this.lbl_Etc_Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Etc_Value.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Etc_Value.ImageIndex = 0;
            this.lbl_Etc_Value.ImageList = this.img_Label;
            this.lbl_Etc_Value.Location = new System.Drawing.Point(7, 45);
            this.lbl_Etc_Value.Name = "lbl_Etc_Value";
            this.lbl_Etc_Value.Size = new System.Drawing.Size(100, 21);
            this.lbl_Etc_Value.TabIndex = 160;
            this.lbl_Etc_Value.Text = "Value";
            this.lbl_Etc_Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Etc_Result
            // 
            this.gb_Etc_Result.Controls.Add(this.txt_Etc_Result1);
            this.gb_Etc_Result.Location = new System.Drawing.Point(7, 216);
            this.gb_Etc_Result.Name = "gb_Etc_Result";
            this.gb_Etc_Result.Size = new System.Drawing.Size(320, 52);
            this.gb_Etc_Result.TabIndex = 161;
            this.gb_Etc_Result.TabStop = false;
            this.gb_Etc_Result.Text = "Result";
            // 
            // txt_Etc_Result1
            // 
            this.txt_Etc_Result1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Etc_Result1.Location = new System.Drawing.Point(7, 22);
            this.txt_Etc_Result1.Name = "txt_Etc_Result1";
            this.txt_Etc_Result1.ReadOnly = true;
            this.txt_Etc_Result1.Size = new System.Drawing.Size(210, 21);
            this.txt_Etc_Result1.TabIndex = 154;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(271, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 444);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(224, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(144, 32);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_SubTitle2
            // 
            this.lbl_SubTitle2.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle2.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle2.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle2.Image")));
            this.lbl_SubTitle2.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle2.Name = "lbl_SubTitle2";
            this.lbl_SubTitle2.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle2.TabIndex = 28;
            this.lbl_SubTitle2.Text = "      Display Specification";
            this.lbl_SubTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Code
            // 
            this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Code.Location = new System.Drawing.Point(108, 30);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.ReadOnly = true;
            this.txt_Code.Size = new System.Drawing.Size(100, 21);
            this.txt_Code.TabIndex = 162;
            // 
            // lbl_Code
            // 
            this.lbl_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Code.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.ImageIndex = 1;
            this.lbl_Code.ImageList = this.img_Label;
            this.lbl_Code.Location = new System.Drawing.Point(7, 30);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(100, 21);
            this.lbl_Code.TabIndex = 161;
            this.lbl_Code.Text = "Code";
            this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(358, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 28);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(358, 460);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(14, 15);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(123, 459);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(235, 17);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 460);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(144, 18);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 22);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(144, 444);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(137, 22);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(228, 438);
            this.pictureBox8.TabIndex = 27;
            this.pictureBox8.TabStop = false;
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 544);
            this.stbar.Name = "stbar";
            this.stbar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1,
            this.statusBarPanel2});
            this.stbar.Size = new System.Drawing.Size(790, 20);
            this.stbar.TabIndex = 47;
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            // 
            // statusBarPanel2
            // 
            this.statusBarPanel2.Name = "statusBarPanel2";
            // 
            // Form_BC_Spec
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(790, 564);
            this.Controls.Add(this.stbar);
            this.Controls.Add(this.pnl_B);
            this.Name = "Form_BC_Spec";
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            this.pnl_BL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Main_Sheet1)).EndInit();
            this.pnl_BLT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.pnl_BR.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_Size.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeT)).EndInit();
            this.gb_Size_Result.ResumeLayout(false);
            this.gb_Size_Result.PerformLayout();
            this.obarpg_Unit.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Unit_Unit)).EndInit();
            this.gb_Unit_Result.ResumeLayout(false);
            this.gb_Unit_Result.PerformLayout();
            this.obarpg_Formula1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Thick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula_Width)).EndInit();
            this.gb_Formula_Result.ResumeLayout(false);
            this.gb_Formula_Result.PerformLayout();
            this.obarpg_Formula2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula2_Thick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Formula2_Inch)).EndInit();
            this.gb_Formula2_Result.ResumeLayout(false);
            this.gb_Formula2_Result.PerformLayout();
            this.obarpg_Etc.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gb_Etc_Result.ResumeLayout(false);
            this.gb_Etc_Result.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel2)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 
 
		#region 사용자 변수 
		 
		private COM.OraDB MyOraDB = new COM.OraDB();

		// use_yn check 수정 Count
		private int _UpdateCt = 0;

		// 수정 선택한 코드의 use yn 정보
		private string _UseYN;


		// 기타 String 형 스펙 구분자
		private string _Division_Etc = "7";

 
		#endregion

		#region 멤버 메서드
 

		private void Init_Form()
		{
			try
			{ 
				//Title
                this.Text = "Spec. Master";
                lbl_MainTitle.Text = "Spec. Master";
				ClassLib.ComFunction.SetLangDic(this);
 
				//ToolBar 초기화 
				tbtn_Delete.Enabled = false; 
				tbtn_Conform.Enabled = false;

				// 그리드 설정
				fgrid_Main.Set_Spread_Comm("SBC_SPEC", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false); 
  
				// 콤보 리스트 설정
				Set_Combo_Data(); 
 
				ClassLib.ComFunction.Init_Form_Control(this);
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this); 


				obar_Main.SelectedPage = obarpg_Size;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		 

		/// <summary>
		/// Set_Combo_Data : 
		/// </summary>
		private void Set_Combo_Data()
		{
			DataTable dt_ret;

			//자재코드 ComboBox 설정
			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Division, 1, 4, false, ClassLib.ComVar.ComboList_Visible.Name); 

			dt_ret = Select_SEM_REQ_SIZE("-1"); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeF, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeT, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code); 
			dt_ret.Dispose();

			Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecUnit);
			Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecWeight);
			Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecEtc);

			Set_ComboBox(cmb_Formula_Height, ClassLib.ComVar.CxSpecUnit);
			Set_ComboBox(cmb_Formula_Width, ClassLib.ComVar.CxSpecUnit);
			Set_ComboBox(cmb_Formula_Thick, ClassLib.ComVar.CxSpecUnit);
 
			Set_ComboBox(cmb_Formula2_Thick, ClassLib.ComVar.CxSpecUnit);
			Set_ComboBox(cmb_Formula2_Inch, ClassLib.ComVar.CxSpecUnit);
			cmb_Formula2_Inch.SelectedValue = "\"";


		}


		/// <summary>
		/// Search_SBC_SPEC : 
		/// </summary>
		private void Search_SBC_SPEC()
		{
			try
			{
				DataTable dt_ret;
				string division = ""; 

				if(cmb_Division.SelectedIndex == -1) return;

				this.Cursor = Cursors.WaitCursor;

				division = cmb_Division.SelectedValue.ToString();

				
				dt_ret = Select_SBC_SPEC(division);
				fgrid_Main.Display_Grid(dt_ret);
				dt_ret.Dispose();

				fgrid_Main.Set_FontColor_Row((int)ClassLib.TBSBC_SPEC.IxUSE_YN,"False",System.Drawing.Color.Red);
				fgrid_Main.Set_FontColor_Row((int)ClassLib.TBSBC_SPEC.IxUSE_YN,"True",System.Drawing.Color.Empty); 

			} 
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_SBC_SPEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt">데이터 테이블</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		private void Display_Grid(DataTable arg_dt, COM.SSP arg_fgrid)
		{
			arg_fgrid.Display_Grid(arg_dt) ;
		}


		/// <summary>
		/// Select_Outbar_Page : 
		/// </summary>
		private void Select_Outbar_Page()
		{
			try
			{ 
				// 초기화
				ReSet_Control(); 

				if(cmb_Division.SelectedIndex == -1) return;

				string division = cmb_Division.SelectedValue.ToString();

				switch(division)
				{
					case "1": 

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Size; 

						obarpg_Size.Enabled = true;
						obarpg_Unit.Enabled = false;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = false; 
 

						DataTable dt_ret;
						dt_ret = Select_SEM_REQ_SIZE("-1"); 
						ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeF, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code); 
						ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeT, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code); 
						dt_ret.Dispose();

						break;

					case "2": 

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Unit;
 
						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = true;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = false;


						Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecUnit);

						break;
					
					case "3": 

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Unit;
						
						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = true;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = false;


						Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecWeight);

						break;
					
					case "4":

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Unit;
						
						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = true;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = false;


						Set_ComboBox(cmb_Unit_Unit, ClassLib.ComVar.CxSpecEtc);

						break;

					case "5":

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Formula1; 

						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = false;
						obarpg_Formula1.Enabled = true;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = false;


						Set_ComboBox(cmb_Formula_Height, ClassLib.ComVar.CxSpecUnit);
						Set_ComboBox(cmb_Formula_Width, ClassLib.ComVar.CxSpecUnit);
						Set_ComboBox(cmb_Formula_Thick, ClassLib.ComVar.CxSpecUnit);
 
						break;

					case "6":

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						obar_Main.SelectedPage = obarpg_Formula2;
						
						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = false;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = true;
						obarpg_Etc.Enabled = false; 


						Set_ComboBox(cmb_Formula2_Thick, ClassLib.ComVar.CxSpecUnit);
						Set_ComboBox(cmb_Formula2_Inch, ClassLib.ComVar.CxSpecUnit);
						cmb_Formula2_Inch.SelectedValue = "\"";

						break; 

					case "7":

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = true;


						obar_Main.SelectedPage = obarpg_Etc;

						obarpg_Size.Enabled = false;
						obarpg_Unit.Enabled = false;
						obarpg_Formula1.Enabled = false;
						obarpg_Formula2.Enabled = false;
						obarpg_Etc.Enabled = true; 


						break; 

					default:

						fgrid_Main.ActiveSheet.Columns[(int)ClassLib.TBSBC_SPEC.IxCONVERSION].Visible = false;


						break;
 

				}


			} 
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Select_Outbar_Page", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		
    
		/// <summary>
		/// ReSet_Control : 초기화
		/// </summary>
		private void ReSet_Control()
		{
			try
			{
				txt_Code.Text = "";

				cmb_SizeF.SelectedIndex = -1;
				cmb_SizeT.SelectedIndex = -1;
				txt_SizeF.Text = "";
				txt_SizeT.Text = "";
				txt_SizeF_Rtn.Text = "";
				txt_SizeT_Rtn.Text = "";


				cmb_Unit_Unit.SelectedIndex = -1;
				txt_Unit_Value.Text = "";
				txt_Unit_Result1.Text = ""; 


				cmb_Formula_Height.SelectedIndex = -1;
				cmb_Formula_Width.SelectedIndex	= -1;
				cmb_Formula_Thick.SelectedIndex	= -1; 
				txt_Formula_Height.Text	= "";
				txt_Formula_Width.Text = "";
				txt_Formula_Thick.Text = "";
				txt_Formula_Result1.Text = "";
				txt_Formula_Result2.Text = "";
				txt_Formula_Result3.Text = "";  
			

				cmb_Formula2_Thick.SelectedIndex = -1; 
				txt_Formula2_Thick.Text	= "";
				txt_Formula2_Inch.Text = "";
				txt_Formula2_Result1.Text = "";
				txt_Formula2_Result2.Text = "";  
			

				txt_Etc_Value.Text = "";
				txt_Etc_Result1.Text = "";
				txt_Conversion.Text = "";

			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ReSet_Control", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
  
		private void  SetPrintYield()
		{
			try
			{   
	
						 
				string mrd_Filename = "Report/Material/Form_BC_Spec_Master.mrd" ;
				string Para         = " ";

				#region 출력조건

				int  iCnt  = 1;
				string [] aHead =  new string[iCnt];	


				aHead[0]    = COM.ComFunction.Empty_Combo(cmb_Division, "");
		
			
				#endregion
	
				Para = 	" /rp ";
				for (int i  = 1 ; i<= iCnt ; i++)
				{				
					Para = Para + "[" + aHead[i-1] + "] ";
				}
	
				FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
				report.Show();	

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetPrintYield", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}

		/// <summary>
		/// Set_ComboBox : 
		/// </summary>
		/// <param name="code"></param>
		/// <param name="combo"></param>
		private void Set_ComboBox(C1.Win.C1List.C1Combo arg_cmb, string arg_code)
		{   
			DataTable dt_ret; 
			 
			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, arg_code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, arg_cmb, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code); 
			dt_ret.Dispose();
		}


		#region Return 값 조합


		#region Spec Div = 1 (size)

		private void cmb_SizeF_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				// Size From 보다 큰 Size To 데이터 다시 세팅 - 제약조건 해제 (2006-06-06)
				ReSet_Combo_SizeTo();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SizeF_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		/// <summary>
		/// ReSet_Combo_SizeTo : Size From 보다 큰 Size To 데이터 다시 세팅
		/// </summary>
		private void ReSet_Combo_SizeTo()
		{ 
			if(cmb_SizeF.SelectedIndex == -1) return;

//			DataTable dt_ret; 
//			dt_ret = Select_SEM_REQ_SIZE(cmb_SizeF.SelectedValue.ToString() );  
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeT, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
//			dt_ret.Dispose(); 

			Set_SizeRtn("F"); 
		}


		private void cmb_SizeT_SelectedValueChanged(object sender, System.EventArgs e)
		{
			if(cmb_SizeT.SelectedIndex == -1) return;

			Set_SizeRtn("T");  
		}


		/// <summary>
		/// Set_SizeRtn :  
		/// </summary>
		/// <param name="arg_division"></param>
		private void Set_SizeRtn(string arg_division)
		{ 
//			double size_from = -1, size_to = -1;

			switch(arg_division)
			{
				case "F":

					txt_SizeF.Text = cmb_SizeF.SelectedValue.ToString();
					txt_SizeF_Rtn.Text = cmb_SizeF.SelectedValue.ToString(); 
			 
//					// 항상 From < To 이어야 함 - 제약조건 해제 (2006-06-06)
//					if(txt_SizeT_Rtn.Text.Trim() != "")
//					{
//						size_from = Convert.ToDouble(txt_SizeF.Text.Replace("T", ".5") );
//						size_to = Convert.ToDouble(txt_SizeT_Rtn.Text.Replace("T", ".5") );
//
//						if(size_from >= size_to)
//						{
//							txt_SizeT.Text = "";
//							txt_SizeT_Rtn.Text = "";
//						}
//						else
//						{
//							cmb_SizeT.SelectedValue = txt_SizeT.Text;
//						}  
//					} 

					break;

				case "T":
					txt_SizeT.Text = cmb_SizeT.SelectedValue.ToString();
					txt_SizeT_Rtn.Text = cmb_SizeT.SelectedValue.ToString();

					break;

			} 

		}

		
		#endregion  

		#region Spec Div = 2, 3, 4 (unit)

		private void txt_Unit_Value_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_UnitRtn();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Unit_Value_Leave", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}
 

		private void cmb_Unit_Unit_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_UnitRtn(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Unit_Unit_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
			
		}
		 

		/// <summary>
		/// Set_UnitRtn : 
		/// </summary>
		private void Set_UnitRtn()
		{ 
			if(txt_Unit_Value.Text.Trim() == "" || cmb_Unit_Unit.SelectedIndex == -1) return;
 
			txt_Unit_Result1.Text = txt_Unit_Value.Text.Trim() + cmb_Unit_Unit.SelectedValue.ToString();  
		}


		#endregion  
		
		#region Spec Div = 5 (formula : Width * Height * Thick)

		private void txt_Formula_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_Formula_1_Rtn(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Formula_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}


		private void cmb_Formula_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_Formula_1_Rtn(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Formula_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}
 


		/// <summary>
		/// Set_Formula_1_Rtn : 
		/// </summary>
		private void Set_Formula_1_Rtn()
		{  
			if(txt_Formula_Width.Text.Trim() != "" && cmb_Formula_Width.SelectedIndex != -1) 
			{
				txt_Formula_Result1.Text = txt_Formula_Width.Text.Trim() + cmb_Formula_Width.SelectedValue.ToString();
			}

			if(txt_Formula_Height.Text.Trim() != "" && cmb_Formula_Height.SelectedIndex != -1) 
			{
				txt_Formula_Result2.Text = txt_Formula_Height.Text.Trim() + cmb_Formula_Height.SelectedValue.ToString();
			}

			if(txt_Formula_Thick.Text.Trim() != "" && cmb_Formula_Thick.SelectedIndex != -1) 
			{
				txt_Formula_Result3.Text = txt_Formula_Thick.Text.Trim() + cmb_Formula_Thick.SelectedValue.ToString();
			}

		}


		#endregion  
		
		#region Spec Div = 6 (formula : Thick , Inch("))

		private void txt_Formula2_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_Formula_2_Rtn(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Formula2_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		private void cmb_Formula2_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				Set_Formula_2_Rtn(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Formula2_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}  
		}

		/// <summary>
		/// Set_Formula_2_Rtn : 
		/// </summary>
		private void Set_Formula_2_Rtn()
		{   
			if(txt_Formula2_Thick.Text.Trim() != "" && cmb_Formula2_Thick.SelectedIndex != -1) 
			{
				txt_Formula2_Result1.Text = txt_Formula2_Thick.Text.Trim() + cmb_Formula2_Thick.SelectedValue.ToString();
			}

			if(txt_Formula2_Inch.Text.Trim() != "") 
			{
				txt_Formula2_Result2.Text = txt_Formula2_Inch.Text.Trim() + cmb_Formula2_Inch.SelectedValue.ToString();
			}

		}


		#endregion  

		#region Spec Div = 7 (Etc. String)

		 
		private void rad_Etc_CheckedChanged(object sender, System.EventArgs e)
		{
			try
			{  
				if(rad_Etc_Etc.Checked)
				{
					txt_Etc_Value.Text = "";
				}
				else
				{
					txt_Etc_Value.Text = "#";
				}

				txt_Etc_Result1.Text = "";

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_Etc_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

			
		}

		private void txt_Etc_Value_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(rad_Etc_Etc.Checked)
				{
					if(txt_Etc_Value.Text.Trim() == "") return;
				}
				else
				{
					if(txt_Etc_Value.Text.Trim() == "") return;
				} 

				txt_Etc_Result1.Text = txt_Etc_Value.Text;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_Etc_Value_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion
 

		#endregion
		


		#endregion 

		#region 이벤트 처리
 
		#region 그리드 이벤트 처리	
		
		private void fgrid_Main_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int sel_row = fgrid_Main.ActiveSheet.ActiveRowIndex ;
				int sel_col = fgrid_Main.ActiveSheet.ActiveColumnIndex ;

				fgrid_Main.Buffer_CellData = (fgrid_Main.ActiveSheet.Cells[sel_row, sel_col].Value == null) ? "" : fgrid_Main.ActiveSheet.Cells[sel_row, sel_col].Value.ToString() ;
				
				string s = fgrid_Main.ActiveSheet.Columns[sel_col].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					fgrid_Main.Buffer_CellData  = "000";
					fgrid_Main.Update_Row(img_Action);

					// use_yn check 수정 Count
					_UpdateCt++;
				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			
		}
 

		private void fgrid_Main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			fgrid_Main.Update_Row(img_Action);
			_UpdateCt++;
		}

	

		private void fgrid_Main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{
				if(fgrid_Main.ActiveSheet.RowCount == 0) return;

				int sel_row = fgrid_Main.ActiveSheet.ActiveRowIndex; 


				if(_ReturnYN)
				{

					ClassLib.ComVar.Parameter_PopUp  = new string[] { fgrid_Main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_SPEC.IxSPEC_CD].Text.ToString(), 
					                                                  fgrid_Main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBC_SPEC.IxSPEC_NAME].Text.ToString() };

					this.Close();

				}
				else
				{

					//콤보박스 초기화
					Select_Outbar_Page();

					//수정할 spec. 데이터 텍스트박스에 표시
					Set_Update_Spec(sel_row); 

					//top row 기능
					fgrid_Main.Set_CellPosition(sel_row, (int)ClassLib.TBSBC_SPEC.IxSPEC_NAME);

				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Main_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Set_Update_Spec : 수정할 spec. 데이터 텍스트박스에 표시
		/// </summary>
		/// <param name="arg_selrow"></param>
		private void Set_Update_Spec(int arg_selrow)
		{
			int length = 0;
			int pos = -1, pos1 = -1, temp_pos = -1;
			
			string division = cmb_Division.SelectedValue.ToString();
			string sepc_cd = fgrid_Main.ActiveSheet.Cells[arg_selrow, (int)ClassLib.TBSBC_SPEC.IxSPEC_CD].Text.ToString().Trim();
			string spec_name = fgrid_Main.ActiveSheet.Cells[arg_selrow, (int)ClassLib.TBSBC_SPEC.IxSPEC_NAME].Text.ToString().Trim();
			string useyn = (fgrid_Main.ActiveSheet.Cells[arg_selrow, (int)ClassLib.TBSBC_SPEC.IxUSE_YN].Value.ToString() == "True") ? "Y" : "N"; 

			// 수정 선택한 코드의 use yn 정보
			_UseYN = useyn; 

			txt_Code.Text = sepc_cd; 

			switch(division)
			{
				case "1": 
  
					length = spec_name.Trim().Length;

					pos = spec_name.IndexOf(lbl_Symbol_Size.Text);

					if(pos == -1)
					{
						txt_SizeF.Text = spec_name;
						cmb_SizeF.SelectedValue = txt_SizeF.Text;
						txt_SizeF_Rtn.Text = txt_SizeF.Text;
					}
					else
					{
						txt_SizeF.Text = spec_name.Substring(0, pos);
						cmb_SizeF.SelectedValue = txt_SizeF.Text;
						txt_SizeF_Rtn.Text = txt_SizeF.Text;

						txt_SizeT.Text = spec_name.Substring(pos + 1, length - pos - 1);
						cmb_SizeT.SelectedValue = txt_SizeT.Text;
						txt_SizeT_Rtn.Text = txt_SizeT.Text;
					}
					 

					break;

				case "2": case "3": case "4": 

					txt_Unit_Result1.Text = spec_name; 
					length = spec_name.Trim().Length;

					temp_pos = Formula_Divide(spec_name, cmb_Unit_Unit);

					if(temp_pos > length)
					{
						txt_Unit_Value.Text = spec_name;
						cmb_Unit_Unit.SelectedIndex = -1;
					}
					else
					{
						txt_Unit_Value.Text = spec_name.Substring(0, temp_pos);
						cmb_Unit_Unit.SelectedValue = spec_name.Substring(temp_pos, length - temp_pos);
					}
					 

					break;

				case "5":
					
					length = spec_name.Trim().Length;

					pos = spec_name.IndexOf(lbl_Symbol_Formula1.Text);
  
					txt_Formula_Result1.Text = spec_name.Substring(0, pos); 

					pos1 = spec_name.IndexOf(lbl_Symbol_Formula2.Text, pos + 1);

					if(pos1 == -1)
					{
						txt_Formula_Result2.Text = spec_name.Substring(pos + 1, length - pos - 1);
						txt_Formula_Result3.Text = "";    
					}
					else
					{  
						txt_Formula_Result2.Text = spec_name.Substring(pos + 1, pos1 - pos - 1);
						txt_Formula_Result3.Text = spec_name.Substring(pos1 + 1, length - pos1 - 1);   
					}
 

					// Width
					temp_pos = Formula_Divide(txt_Formula_Result1.Text, cmb_Formula_Width);   //숫자/ 문자 나누기 
					length = txt_Formula_Result1.Text.Trim().Length;
					
					if(length != 0)
					{ 
						txt_Formula_Width.Text = txt_Formula_Result1.Text.Substring(0, temp_pos);
						cmb_Formula_Width.SelectedValue = txt_Formula_Result1.Text.Substring(temp_pos, length - temp_pos);
					}


					// Height 
					temp_pos = Formula_Divide(txt_Formula_Result2.Text, cmb_Formula_Height);    
					length = txt_Formula_Result2.Text.Trim().Length;
					
					if(length != 0)
					{  
						txt_Formula_Height.Text = txt_Formula_Result2.Text.Substring(0, temp_pos);
						cmb_Formula_Height.SelectedValue = txt_Formula_Result2.Text.Substring(temp_pos, length - temp_pos);
					}

					  
					// Thick
					temp_pos = Formula_Divide(txt_Formula_Result3.Text, cmb_Formula_Thick);    
					length = txt_Formula_Result3.Text.Trim().Length;

					if(length != 0)
					{ 
						txt_Formula_Thick.Text = txt_Formula_Result3.Text.Substring(0, temp_pos);
						cmb_Formula_Thick.SelectedValue = txt_Formula_Result3.Text.Substring(temp_pos, length - temp_pos); 
					}

					break;

				case "6":
					 
					length = spec_name.Trim().Length;
					pos = spec_name.IndexOf(lbl_Symbol_Formula3.Text);

					txt_Formula2_Result1.Text = spec_name.Substring(0, pos);
					txt_Formula2_Result2.Text = spec_name.Substring(pos + 1, length - pos - 1);

					// Thick
					temp_pos = Formula_Divide(txt_Formula2_Result1.Text, cmb_Formula2_Thick);

					length = txt_Formula2_Result1.Text.Length;
					txt_Formula2_Thick.Text = txt_Formula2_Result1.Text.Substring(0, temp_pos);
					cmb_Formula2_Thick.SelectedValue = txt_Formula2_Result1.Text.Substring(temp_pos, length - temp_pos);

					// Inch
					temp_pos = Formula_Divide(txt_Formula2_Result2.Text, cmb_Formula2_Inch);

					length = txt_Formula2_Result2.Text.Length;
					txt_Formula2_Inch.Text = txt_Formula2_Result2.Text.Substring(0, temp_pos); 

					break; 

				case "7": 

					if(spec_name.Substring(0, 1) == "#")
					{
						rad_Etc_Number.Checked = true;
					}
					else
					{
						rad_Etc_Etc.Checked = true;
					}  

					txt_Etc_Result1.Text = spec_name;
					txt_Etc_Value.Text = spec_name;

					string conversion = fgrid_Main.ActiveSheet.Cells[arg_selrow, (int)ClassLib.TBSBC_SPEC.IxCONVERSION].Text.ToString().Trim();
					txt_Conversion.Text = conversion.Replace(",", "");


					break;
			} // end switch



		}




		private int Formula_Divide(string arg_name, C1.Win.C1List.C1Combo arg_cmb)
		{  
			int length = arg_name.Trim().Length;
			int[] temp_pos = new int[arg_cmb.ListCount];
			int min_pos = length + 1;

			for(int i = 0; i < arg_cmb.ListCount; i++)
			{
				temp_pos[i] = arg_name.IndexOf(arg_cmb.GetItemText(i, 0).Substring(0, 1) );
			}

			for(int i = 0; i < temp_pos.Length; i++)
			{
				if (temp_pos[i] == -1) continue;

				if(temp_pos[i] <= min_pos) min_pos = temp_pos[i];
			}

			return min_pos;

		}

		#endregion
		
		#region 툴바 메뉴 이벤트 처리

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			try
			{ 
				fgrid_Main.ClearAll();
				cmb_Division.SelectedIndex = -1;
				ReSet_Control();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			 
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{  
			Search_SBC_SPEC(); 
			Select_Outbar_Page();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_SBC_SPEC(); 
		}



		/// <summary>
		/// Save_SBC_SPEC :
		/// </summary>
		private void Save_SBC_SPEC()
		{
			//1. Spec. Name 문자열 구성
			//2. Save 처리

			try
			{
				string spec_name = "";
				bool save_flag = false;

				this.Cursor = Cursors.WaitCursor;

				// insert, spec_name update
				if(_UpdateCt == 0)
				{
					spec_name = Set_Return_SpecName(); 

					// 필수요소 체크, 중복 체크
					// false : 저장 불가, true : 저장 가능
					save_flag = Save_Check(spec_name); 

					if(!save_flag)
					{
						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this); 

					}
					else
					{
						save_flag = Save_Spec_Data(spec_name); 

						if(!save_flag)
						{
							ClassLib.ComFunction.Data_Message("Save", ClassLib.ComVar.MgsDoNotSave, this);
							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
						}
						else
						{
							int current_row = 0;

							if(txt_Code.Text.Trim().Equals("") )  // 신규 저장
							{
								current_row = fgrid_Main.ActiveSheet.RowCount - 1;
							}
							else                                  // 기존 업데이트
							{
								current_row = fgrid_Main.ActiveSheet.ActiveRowIndex;
							}

							Search_SBC_SPEC(); 
							Select_Outbar_Page();

							//top row 처리
							fgrid_Main.Set_CellPosition(current_row, 0);

							ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
						} 
					} 

					
				   
				}
				//use_yn update
				else if(_UpdateCt > 0)
				{
					MyOraDB.Save_Spread("PKG_SBC_SPEC.SAVE_SBC_SPEC", fgrid_Main); 
				
					Search_SBC_SPEC(); 
					Select_Outbar_Page();

					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
					_UpdateCt = 0;
				} 
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SBC_SPEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}



		/// <summary>
		/// Save_Check : 
		/// </summary>
		/// <returns></returns>
		private bool Save_Check(string arg_spec_name) 
		{
			bool exist_flag = false;

			// 필수요소 체크
			if(cmb_Division.SelectedIndex == -1)
			{
				ClassLib.ComFunction.Data_Message("[Specification Division]", ClassLib.ComVar.MgsWrongInput, this);
				return false;
			}

			if(arg_spec_name.Trim() == "") 
			{
				ClassLib.ComFunction.Data_Message("[Specification Name]", ClassLib.ComVar.MgsWrongInput, this);
				return false;
			}

			// 중복 체크
			// y : 중복, 저장 불가, n : 저장 가능 
			if(! txt_Code.Text.Trim().Equals("") )
			{
				exist_flag = false;
			}
			else
			{
				exist_flag = Check_Exist(arg_spec_name.Trim() );
			}

			if(exist_flag)
			{
				ClassLib.ComFunction.User_Message("Duplicate Specification Name");
				

				//----------------------------------------------------------------------------------------------------------------------
				// 중복 스펙 행 top row 처리
				int duplicate_row = 0;

				for(int i = 0; i < fgrid_Main.ActiveSheet.Rows.Count; i++)
				{
					if(fgrid_Main.ActiveSheet.Cells[i, (int)ClassLib.TBSBC_SPEC.IxSPEC_NAME].Text.ToString().Trim() == arg_spec_name.Trim() )
					{
						duplicate_row = i;
						break;
					}

				}

				//top row 기능
				fgrid_Main.Set_CellPosition(duplicate_row, 0); 
				
				 

				//----------------------------------------------------------------------------------------------------------------------


				return false;
			}
			else
			{
				return true;
			}

		}


 
		/// <summary>
		/// Check_Exist : 중복 체크
		/// </summary>
		/// <param name="arg_spec_name"></param>
		/// <returns></returns>
		private bool Check_Exist(string arg_spec_name)
		{
			DataSet ds_ret;
			string exist_yn = "";

			MyOraDB.ReDim_Parameter(3); 
 
			MyOraDB.Process_Name = "PKG_SBC_SPEC.CHECK_SPEC_EXIST";
  
			MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
			MyOraDB.Parameter_Name[1] = "ARG_SPEC_NAME";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			   
			MyOraDB.Parameter_Values[0] = cmb_Division.SelectedValue.ToString(); 
			MyOraDB.Parameter_Values[1] = arg_spec_name; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return false; 
			exist_yn = ds_ret.Tables[MyOraDB.Process_Name].Rows[0].ItemArray[0].ToString(); 

			if(exist_yn == "Y")
				return true;
			else
				return false;
		}






 


		 
		/// <summary>
		/// Save_Spec_Data :
		/// </summary>
		/// <param name="arg_spec_name"></param>
		/// <returns></returns>
		private bool Save_Spec_Data(string arg_spec_name)
		{ 
			try
			{ 
				string division = "", code = "", useyn = "";
 
				MyOraDB.ReDim_Parameter(9); 
 
				MyOraDB.Process_Name = "PKG_SBC_SPEC.SAVE_SBC_SPEC";
  
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_SPEC_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[3] = "ARG_SPEC_NAME";
				MyOraDB.Parameter_Name[4] = "ARG_USE_YN";
				MyOraDB.Parameter_Name[5] = "ARG_CONVERSION";
				MyOraDB.Parameter_Name[6] = "ARG_SEND_CHK";
				MyOraDB.Parameter_Name[7] = "ARG_SEND_YMD";
				MyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
   
				if(txt_Code.Text.Trim() == "")
				{
					division = "I";
					code = ""; 
					useyn = "Y";
				}
				else
				{
					division = "U";
					code = txt_Code.Text.Trim(); 
					useyn = _UseYN;
				}

				MyOraDB.Parameter_Values[0] = division;
				MyOraDB.Parameter_Values[1] = cmb_Division.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = code;
				MyOraDB.Parameter_Values[3] = arg_spec_name;
				MyOraDB.Parameter_Values[4] = useyn;

				if(cmb_Division.SelectedValue.ToString() == _Division_Etc)
				{
					MyOraDB.Parameter_Values[5] = txt_Conversion.Text.Trim();
				}
				else 
				{
					MyOraDB.Parameter_Values[5] = "";
				}
				

				MyOraDB.Parameter_Values[6] = "";
				MyOraDB.Parameter_Values[7] = "";
				MyOraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;



				MyOraDB.Add_Modify_Parameter(true); 
				MyOraDB.Exe_Modify_Procedure();

				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Spec_Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} 

		}


		/// <summary>
		/// Set_Return_SpecName : Spec. Name 문자열 구성
		/// </summary>
		/// <returns></returns>
		private string Set_Return_SpecName()
		{
			string spec_name = "";
			string division = cmb_Division.SelectedValue.ToString();

			switch(division)
			{
				case "1": 

					spec_name = txt_SizeF_Rtn.Text;
					spec_name += txt_SizeT_Rtn.Text.Equals("") ? "" : lbl_Symbol_Size.Text.Trim() + txt_SizeT_Rtn.Text;

					break;

				case "2": case "3": case "4":
					 
					spec_name = txt_Unit_Result1.Text;

					break;

				case "5":
					 
					spec_name =  txt_Formula_Result1.Text;
					spec_name += txt_Formula_Result2.Text.Equals("") ? "" : lbl_Symbol_Formula1.Text.Trim() + txt_Formula_Result2.Text;
					spec_name += txt_Formula_Result3.Text.Equals("") ? "" : lbl_Symbol_Formula2.Text.Trim() + txt_Formula_Result3.Text;

					break;

				case "6":
					 
					spec_name =  txt_Formula2_Result1.Text;
					spec_name += txt_Formula2_Result2.Text.Equals("") ? "" : lbl_Symbol_Formula3.Text.Trim() + txt_Formula2_Result2.Text;

					break; 

				case "7":
					
					spec_name = txt_Etc_Result1.Text;

					break;
			} // end switch

			return spec_name;

		}

		 	
	
		#endregion		

		#region 컨트롤 이벤트 처리

		private void cmb_Division_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_SBC_SPEC(); 
			Select_Outbar_Page();
		}
 

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

		private void btn_Clear_Click(object sender, System.EventArgs e)
		{
			ReSet_Control();
		}

	
		private void txt_Conversion_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.numeric_Type(e);
		}
 
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrintYield();
		}


		#endregion 

 

		#endregion

		#region DB Connect


		/// <summary>
		/// Select_SEM_REQ_SIZE :  
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SEM_REQ_SIZE(string arg_cs_size_f)
		{ 
			DataSet ds_ret;
			
			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SEM_SIZE";
  
			MyOraDB.Parameter_Name[0] = "ARG_CS_SIZE_F";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
			MyOraDB.Parameter_Values[0] = arg_cs_size_f; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

 

		/// <summary>
		/// Select_SBC_SPEC :  
		/// </summary>
		/// <returns></returns>
		public DataTable Select_SBC_SPEC(string arg_value)
		{
  
			DataSet ds_ret;
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SBC_SPEC";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_SPEC_DIV";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_value;
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

 
		/// <summary>
		/// Select_SBC_SPEC : Spec 조회
		/// </summary>
		/// <returns></returns>
		public DataTable Select_Spec_Name(string sCode, string sName)
		{
			
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_SPEC.SELECT_SPEC_LIST";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = sCode;
			MyOraDB.Parameter_Values[1] = sName;
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}

		 
		
		#endregion																									 

	}
}

