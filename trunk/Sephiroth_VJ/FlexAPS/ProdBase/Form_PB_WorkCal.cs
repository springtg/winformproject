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
	public class Form_PB_WorkCal : COM.APSWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.ImageList img_MiniButton;
		private C1.Win.C1Command.C1OutBar obar_Main;
		private C1.Win.C1Command.C1OutPage obarpg_Holiday;
		private C1.Win.C1Command.C1OutPage obarpg_Shift;
		private C1.Win.C1Command.C1OutPage obarpg_WorkCal;
		private System.Windows.Forms.Panel pnl_HB;
		public System.Windows.Forms.Panel panel3;
		public System.Windows.Forms.PictureBox pictureBox18;
		public System.Windows.Forms.PictureBox pictureBox24;
		public System.Windows.Forms.PictureBox pictureBox17;
		public System.Windows.Forms.PictureBox pictureBox19;
		public System.Windows.Forms.PictureBox pictureBox20;
		public System.Windows.Forms.PictureBox pictureBox21;
		public System.Windows.Forms.PictureBox pictureBox22;
		public System.Windows.Forms.PictureBox pictureBox23;
		public System.Windows.Forms.Panel pnl_HBT;
		private C1.Win.C1List.C1Combo cmb_HFactory;
		private System.Windows.Forms.Label lbl_HFactory;
		private C1.Win.C1List.C1Combo cmb_HCalType;
		private System.Windows.Forms.Label lbl_HCalType;
		private System.Windows.Forms.Label btn_PopCalType;
		private System.Windows.Forms.Label lbl_SubTitle1;
		private System.Windows.Forms.Panel pnl_SB;
		public System.Windows.Forms.Panel panel2;
		public System.Windows.Forms.PictureBox pictureBox1;
		public System.Windows.Forms.PictureBox pictureBox2;
		public System.Windows.Forms.PictureBox pictureBox3;
		public System.Windows.Forms.PictureBox pictureBox4;
		public System.Windows.Forms.PictureBox pictureBox5;
		public System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label lbl_SubTitle3;
		public System.Windows.Forms.PictureBox pictureBox7;
		public System.Windows.Forms.PictureBox pictureBox8;
		public System.Windows.Forms.Panel pnl_SBT;
		public System.Windows.Forms.Panel pnl_SBB;
		public System.Windows.Forms.Panel panel4;
		public System.Windows.Forms.PictureBox pictureBox9;
		public System.Windows.Forms.PictureBox pictureBox10;
		public System.Windows.Forms.Label lbl_SubTitle4;
		public System.Windows.Forms.PictureBox pictureBox11;
		public System.Windows.Forms.PictureBox pictureBox12;
		public System.Windows.Forms.PictureBox pictureBox13;
		public System.Windows.Forms.PictureBox pictureBox14;
		public System.Windows.Forms.PictureBox pictureBox15;
		public System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.Label btn_PopShiftType;
		private C1.Win.C1List.C1Combo cmb_SShiftType;
		private System.Windows.Forms.Label lbl_SShiftType;
		private C1.Win.C1List.C1Combo cmb_SFactory;
		private System.Windows.Forms.Label lbl_SFactory;
		public COM.FSP fgrid_Shift;
		private System.Windows.Forms.TextBox txt_SOverTime;
		private System.Windows.Forms.TextBox txt_SRemarks;
		private System.Windows.Forms.TextBox txt_STmEndWk;
		private System.Windows.Forms.TextBox txt_SWeekDay;
		private System.Windows.Forms.CheckBox chk_SOverTimeYN;
		private System.Windows.Forms.CheckBox chk_SShiftYN;
		private System.Windows.Forms.Label lbl_SRemarks;
		private System.Windows.Forms.Label lbl_SOverTime;
		private System.Windows.Forms.Label lbl_SShiftYN;
		private System.Windows.Forms.Label lbl_SUseYN;
		private System.Windows.Forms.Label lbl_STmEndWk;
		private System.Windows.Forms.Label lbl_SOverTimeYN;
		private System.Windows.Forms.CheckBox chk_SUseYN;
		private System.Windows.Forms.Label lbl_SEndWeekDay;
		private System.Windows.Forms.TextBox txt_SEndWeekDay;
		private System.Windows.Forms.Label lbl_STmStartWk;
		private System.Windows.Forms.TextBox txt_STmStartWk;
		private System.Windows.Forms.TextBox txt_SType;
		private System.Windows.Forms.TextBox txt_SShiftNo;
		private System.Windows.Forms.Label lbl_SShiftNo;
		private System.Windows.Forms.Label lbl_SWeekDay;
		private System.Windows.Forms.Label lbl_SType;
		private System.Windows.Forms.Label lbl_StWeekDay;
		private System.Windows.Forms.TextBox txt_StWeekDay;
		private System.Windows.Forms.TextBox txt_STypeName;
		private System.Windows.Forms.Panel pnl_WB;
		public System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label btn_CreateWorkCal;
		private System.Windows.Forms.DateTimePicker dpick_ToYMD;
		private System.Windows.Forms.DateTimePicker dpick_FromYMD;
		private System.Windows.Forms.Label lbl_WFromYMD;
		public System.Windows.Forms.PictureBox pictureBox33;
		public System.Windows.Forms.PictureBox pictureBox34;
		public System.Windows.Forms.PictureBox pictureBox35;
		public System.Windows.Forms.PictureBox pictureBox36;
		public System.Windows.Forms.PictureBox pictureBox37;
		public System.Windows.Forms.PictureBox pictureBox38;
		public System.Windows.Forms.PictureBox pictureBox39;
		public System.Windows.Forms.PictureBox pictureBox40;
		public System.Windows.Forms.Panel pnl_WBT;
		private System.Windows.Forms.Label lbl_WCalType;
		private C1.Win.C1List.C1Combo cmb_WCalType;
		private C1.Win.C1List.C1Combo cmb_WShiftType;
		private System.Windows.Forms.Label lbl_WShiftType;
		private C1.Win.C1List.C1Combo cmb_WFactory;
		private System.Windows.Forms.Label lbl_WFactory;
		public COM.FSP fgrid_WorkCal;
		private System.Windows.Forms.Label btn_CreateDate;
		private System.Windows.Forms.Label lbl_SubTitle5;
		private System.Windows.Forms.TextBox txt_HCalTypeName;
		private System.Windows.Forms.TextBox txt_HCalTypeCd;
		private System.Windows.Forms.TextBox txt_SShiftTypeName;
		private System.Windows.Forms.TextBox txt_SShiftType;
		private System.Windows.Forms.TextBox txt_WCalTypeName;
		private System.Windows.Forms.TextBox txt_WCalType;
		private System.Windows.Forms.TextBox txt_WShiftTypeName;
		private System.Windows.Forms.TextBox txt_WShiftType;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_CalToDate;
		private System.Windows.Forms.Label lbl_WCalToDate;
		private System.Windows.Forms.TextBox txt_WCalToDate;
		private System.Windows.Forms.TextBox txt_CalToDate;
		private System.Windows.Forms.TextBox txt_CalFromDate;
		private System.Windows.Forms.TextBox txt_WCalFromDate;
		public COM.FSP fgrid_Holiday;
		private System.Windows.Forms.Panel pnl_HBBL;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_HYear;
		private C1.Win.C1List.C1Combo cmb_HFromYear;
		private C1.Win.C1List.C1Combo cmb_HToYear;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components = null;

		public Form_PB_WorkCal()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PB_WorkCal));
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
            this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
            this.obar_Main = new C1.Win.C1Command.C1OutBar();
            this.obarpg_Holiday = new C1.Win.C1Command.C1OutPage();
            this.pnl_HB = new System.Windows.Forms.Panel();
            this.fgrid_Holiday = new COM.FSP();
            this.pnl_HBBL = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.pnl_HBT = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmb_HToYear = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_HFromYear = new C1.Win.C1List.C1Combo();
            this.lbl_HYear = new System.Windows.Forms.Label();
            this.txt_HCalTypeName = new System.Windows.Forms.TextBox();
            this.txt_HCalTypeCd = new System.Windows.Forms.TextBox();
            this.btn_PopCalType = new System.Windows.Forms.Label();
            this.cmb_HCalType = new C1.Win.C1List.C1Combo();
            this.lbl_HCalType = new System.Windows.Forms.Label();
            this.cmb_HFactory = new C1.Win.C1List.C1Combo();
            this.lbl_HFactory = new System.Windows.Forms.Label();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.obarpg_WorkCal = new C1.Win.C1Command.C1OutPage();
            this.pnl_WB = new System.Windows.Forms.Panel();
            this.txt_WCalTypeName = new System.Windows.Forms.TextBox();
            this.lbl_WCalType = new System.Windows.Forms.Label();
            this.txt_WShiftType = new System.Windows.Forms.TextBox();
            this.cmb_WCalType = new C1.Win.C1List.C1Combo();
            this.cmb_WShiftType = new C1.Win.C1List.C1Combo();
            this.lbl_WShiftType = new System.Windows.Forms.Label();
            this.txt_WShiftTypeName = new System.Windows.Forms.TextBox();
            this.txt_WCalType = new System.Windows.Forms.TextBox();
            this.fgrid_WorkCal = new COM.FSP();
            this.pnl_WBT = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_WCalToDate = new System.Windows.Forms.TextBox();
            this.txt_WCalFromDate = new System.Windows.Forms.TextBox();
            this.lbl_CalToDate = new System.Windows.Forms.Label();
            this.lbl_WCalToDate = new System.Windows.Forms.Label();
            this.txt_CalToDate = new System.Windows.Forms.TextBox();
            this.txt_CalFromDate = new System.Windows.Forms.TextBox();
            this.btn_CreateDate = new System.Windows.Forms.Label();
            this.btn_CreateWorkCal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dpick_ToYMD = new System.Windows.Forms.DateTimePicker();
            this.dpick_FromYMD = new System.Windows.Forms.DateTimePicker();
            this.lbl_WFromYMD = new System.Windows.Forms.Label();
            this.cmb_WFactory = new C1.Win.C1List.C1Combo();
            this.lbl_WFactory = new System.Windows.Forms.Label();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle5 = new System.Windows.Forms.Label();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.obarpg_Shift = new C1.Win.C1Command.C1OutPage();
            this.pnl_SB = new System.Windows.Forms.Panel();
            this.fgrid_Shift = new COM.FSP();
            this.pnl_SBB = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_STypeName = new System.Windows.Forms.TextBox();
            this.txt_SOverTime = new System.Windows.Forms.TextBox();
            this.txt_SRemarks = new System.Windows.Forms.TextBox();
            this.txt_STmEndWk = new System.Windows.Forms.TextBox();
            this.txt_SWeekDay = new System.Windows.Forms.TextBox();
            this.chk_SOverTimeYN = new System.Windows.Forms.CheckBox();
            this.chk_SShiftYN = new System.Windows.Forms.CheckBox();
            this.lbl_SRemarks = new System.Windows.Forms.Label();
            this.lbl_SOverTime = new System.Windows.Forms.Label();
            this.lbl_SShiftYN = new System.Windows.Forms.Label();
            this.lbl_SUseYN = new System.Windows.Forms.Label();
            this.lbl_STmEndWk = new System.Windows.Forms.Label();
            this.lbl_SOverTimeYN = new System.Windows.Forms.Label();
            this.chk_SUseYN = new System.Windows.Forms.CheckBox();
            this.lbl_SEndWeekDay = new System.Windows.Forms.Label();
            this.txt_SEndWeekDay = new System.Windows.Forms.TextBox();
            this.lbl_STmStartWk = new System.Windows.Forms.Label();
            this.txt_STmStartWk = new System.Windows.Forms.TextBox();
            this.txt_SType = new System.Windows.Forms.TextBox();
            this.txt_SShiftNo = new System.Windows.Forms.TextBox();
            this.lbl_SShiftNo = new System.Windows.Forms.Label();
            this.lbl_SWeekDay = new System.Windows.Forms.Label();
            this.lbl_SType = new System.Windows.Forms.Label();
            this.lbl_StWeekDay = new System.Windows.Forms.Label();
            this.txt_StWeekDay = new System.Windows.Forms.TextBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle4 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pnl_SBT = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_SShiftTypeName = new System.Windows.Forms.TextBox();
            this.txt_SShiftType = new System.Windows.Forms.TextBox();
            this.btn_PopShiftType = new System.Windows.Forms.Label();
            this.cmb_SShiftType = new C1.Win.C1List.C1Combo();
            this.lbl_SShiftType = new System.Windows.Forms.Label();
            this.cmb_SFactory = new C1.Win.C1List.C1Combo();
            this.lbl_SFactory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle3 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).BeginInit();
            this.obar_Main.SuspendLayout();
            this.obarpg_Holiday.SuspendLayout();
            this.pnl_HB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Holiday)).BeginInit();
            this.pnl_HBBL.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl_HBT.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HToYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HFromYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HCalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            this.obarpg_WorkCal.SuspendLayout();
            this.pnl_WB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WCalType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkCal)).BeginInit();
            this.pnl_WBT.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            this.obarpg_Shift.SuspendLayout();
            this.pnl_SB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Shift)).BeginInit();
            this.pnl_SBB.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            this.pnl_SBT.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SShiftType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.c1CommandLink8,
            this.c1CommandLink7});
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
            // tbtn_Append
            // 
            this.tbtn_Append.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Append_Click);
            // 
            // tbtn_Insert
            // 
            this.tbtn_Insert.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Insert_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // img_MiniButton
            // 
            this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
            this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_MiniButton.Images.SetKeyName(0, "");
            this.img_MiniButton.Images.SetKeyName(1, "");
            this.img_MiniButton.Images.SetKeyName(2, "");
            this.img_MiniButton.Images.SetKeyName(3, "");
            this.img_MiniButton.Images.SetKeyName(4, "");
            this.img_MiniButton.Images.SetKeyName(5, "");
            // 
            // obar_Main
            // 
            this.obar_Main.Animate = false;
            this.obar_Main.BackColor = System.Drawing.SystemColors.Window;
            this.obar_Main.Controls.Add(this.obarpg_Holiday);
            this.obar_Main.Controls.Add(this.obarpg_WorkCal);
            this.obar_Main.Controls.Add(this.obarpg_Shift);
            this.obar_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.obar_Main.Location = new System.Drawing.Point(8, 0);
            this.obar_Main.Name = "obar_Main";
            this.obar_Main.SelectedIndex = 0;
            this.obar_Main.Size = new System.Drawing.Size(998, 576);
            this.obar_Main.SelectedPageChanged += new System.EventHandler(this.obar_Main_SelectedPageChanged);
            // 
            // obarpg_Holiday
            // 
            this.obarpg_Holiday.Controls.Add(this.pnl_HB);
            this.obarpg_Holiday.Name = "obarpg_Holiday";
            this.obarpg_Holiday.Size = new System.Drawing.Size(998, 516);
            this.obarpg_Holiday.Text = "Holiday";
            // 
            // pnl_HB
            // 
            this.pnl_HB.Controls.Add(this.fgrid_Holiday);
            this.pnl_HB.Controls.Add(this.pnl_HBBL);
            this.pnl_HB.Controls.Add(this.pnl_HBT);
            this.pnl_HB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_HB.Location = new System.Drawing.Point(0, 0);
            this.pnl_HB.Name = "pnl_HB";
            this.pnl_HB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_HB.Size = new System.Drawing.Size(998, 516);
            this.pnl_HB.TabIndex = 0;
            // 
            // fgrid_Holiday
            // 
            this.fgrid_Holiday.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Holiday.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Holiday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Holiday.Location = new System.Drawing.Point(248, 80);
            this.fgrid_Holiday.Name = "fgrid_Holiday";
            this.fgrid_Holiday.Rows.DefaultSize = 19;
            this.fgrid_Holiday.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Holiday.Size = new System.Drawing.Size(742, 428);
            this.fgrid_Holiday.StyleInfo = resources.GetString("fgrid_Holiday.StyleInfo");
            this.fgrid_Holiday.TabIndex = 37;
            this.fgrid_Holiday.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_AfterEdit);
            this.fgrid_Holiday.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_BeforeEdit);
            // 
            // pnl_HBBL
            // 
            this.pnl_HBBL.Controls.Add(this.groupBox2);
            this.pnl_HBBL.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_HBBL.Location = new System.Drawing.Point(8, 80);
            this.pnl_HBBL.Name = "pnl_HBBL";
            this.pnl_HBBL.Size = new System.Drawing.Size(240, 428);
            this.pnl_HBBL.TabIndex = 36;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar);
            this.groupBox2.Location = new System.Drawing.Point(8, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 416);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.monthCalendar.Location = new System.Drawing.Point(8, 16);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(179)))), ((int)(((byte)(234)))));
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // pnl_HBT
            // 
            this.pnl_HBT.Controls.Add(this.panel3);
            this.pnl_HBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_HBT.Location = new System.Drawing.Point(8, 8);
            this.pnl_HBT.Name = "pnl_HBT";
            this.pnl_HBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_HBT.Size = new System.Drawing.Size(982, 72);
            this.pnl_HBT.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.cmb_HToYear);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cmb_HFromYear);
            this.panel3.Controls.Add(this.lbl_HYear);
            this.panel3.Controls.Add(this.txt_HCalTypeName);
            this.panel3.Controls.Add(this.txt_HCalTypeCd);
            this.panel3.Controls.Add(this.btn_PopCalType);
            this.panel3.Controls.Add(this.cmb_HCalType);
            this.panel3.Controls.Add(this.lbl_HCalType);
            this.panel3.Controls.Add(this.cmb_HFactory);
            this.panel3.Controls.Add(this.lbl_HFactory);
            this.panel3.Controls.Add(this.pictureBox18);
            this.panel3.Controls.Add(this.pictureBox24);
            this.panel3.Controls.Add(this.pictureBox17);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Controls.Add(this.pictureBox20);
            this.panel3.Controls.Add(this.pictureBox21);
            this.panel3.Controls.Add(this.lbl_SubTitle1);
            this.panel3.Controls.Add(this.pictureBox22);
            this.panel3.Controls.Add(this.pictureBox23);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 64);
            this.panel3.TabIndex = 19;
            // 
            // cmb_HToYear
            // 
            this.cmb_HToYear.AddItemSeparator = ';';
            this.cmb_HToYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_HToYear.Caption = "";
            this.cmb_HToYear.CaptionHeight = 17;
            this.cmb_HToYear.CaptionStyle = style73;
            this.cmb_HToYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_HToYear.ColumnCaptionHeight = 18;
            this.cmb_HToYear.ColumnFooterHeight = 18;
            this.cmb_HToYear.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_HToYear.ContentHeight = 17;
            this.cmb_HToYear.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_HToYear.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_HToYear.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HToYear.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_HToYear.EditorHeight = 17;
            this.cmb_HToYear.EvenRowStyle = style74;
            this.cmb_HToYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HToYear.FooterStyle = style75;
            this.cmb_HToYear.HeadingStyle = style76;
            this.cmb_HToYear.HighLightRowStyle = style77;
            this.cmb_HToYear.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_HToYear.Images"))));
            this.cmb_HToYear.ItemHeight = 15;
            this.cmb_HToYear.Location = new System.Drawing.Point(479, 36);
            this.cmb_HToYear.MatchEntryTimeout = ((long)(2000));
            this.cmb_HToYear.MaxDropDownItems = ((short)(5));
            this.cmb_HToYear.MaxLength = 32767;
            this.cmb_HToYear.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_HToYear.Name = "cmb_HToYear";
            this.cmb_HToYear.OddRowStyle = style78;
            this.cmb_HToYear.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_HToYear.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_HToYear.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_HToYear.SelectedStyle = style79;
            this.cmb_HToYear.Size = new System.Drawing.Size(120, 21);
            this.cmb_HToYear.Style = style80;
            this.cmb_HToYear.TabIndex = 185;
            this.cmb_HToYear.SelectedValueChanged += new System.EventHandler(this.cmb_HToYear_SelectedValueChanged);
            this.cmb_HToYear.PropBag = resources.GetString("cmb_HToYear.PropBag");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(463, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 21);
            this.label1.TabIndex = 184;
            this.label1.Text = "~";
            // 
            // cmb_HFromYear
            // 
            this.cmb_HFromYear.AddItemSeparator = ';';
            this.cmb_HFromYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_HFromYear.Caption = "";
            this.cmb_HFromYear.CaptionHeight = 17;
            this.cmb_HFromYear.CaptionStyle = style81;
            this.cmb_HFromYear.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_HFromYear.ColumnCaptionHeight = 18;
            this.cmb_HFromYear.ColumnFooterHeight = 18;
            this.cmb_HFromYear.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_HFromYear.ContentHeight = 17;
            this.cmb_HFromYear.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_HFromYear.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_HFromYear.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HFromYear.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_HFromYear.EditorHeight = 17;
            this.cmb_HFromYear.EvenRowStyle = style82;
            this.cmb_HFromYear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HFromYear.FooterStyle = style83;
            this.cmb_HFromYear.HeadingStyle = style84;
            this.cmb_HFromYear.HighLightRowStyle = style85;
            this.cmb_HFromYear.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_HFromYear.Images"))));
            this.cmb_HFromYear.ItemHeight = 15;
            this.cmb_HFromYear.Location = new System.Drawing.Point(343, 36);
            this.cmb_HFromYear.MatchEntryTimeout = ((long)(2000));
            this.cmb_HFromYear.MaxDropDownItems = ((short)(5));
            this.cmb_HFromYear.MaxLength = 32767;
            this.cmb_HFromYear.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_HFromYear.Name = "cmb_HFromYear";
            this.cmb_HFromYear.OddRowStyle = style86;
            this.cmb_HFromYear.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_HFromYear.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_HFromYear.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_HFromYear.SelectedStyle = style87;
            this.cmb_HFromYear.Size = new System.Drawing.Size(120, 21);
            this.cmb_HFromYear.Style = style88;
            this.cmb_HFromYear.TabIndex = 184;
            this.cmb_HFromYear.SelectedValueChanged += new System.EventHandler(this.cmb_HFromYear_SelectedValueChanged);
            this.cmb_HFromYear.PropBag = resources.GetString("cmb_HFromYear.PropBag");
            // 
            // lbl_HYear
            // 
            this.lbl_HYear.ImageIndex = 0;
            this.lbl_HYear.ImageList = this.img_Label;
            this.lbl_HYear.Location = new System.Drawing.Point(242, 36);
            this.lbl_HYear.Name = "lbl_HYear";
            this.lbl_HYear.Size = new System.Drawing.Size(100, 21);
            this.lbl_HYear.TabIndex = 183;
            this.lbl_HYear.Text = "Year";
            this.lbl_HYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_HCalTypeName
            // 
            this.txt_HCalTypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_HCalTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HCalTypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_HCalTypeName.Location = new System.Drawing.Point(832, 8);
            this.txt_HCalTypeName.MaxLength = 60;
            this.txt_HCalTypeName.Name = "txt_HCalTypeName";
            this.txt_HCalTypeName.ReadOnly = true;
            this.txt_HCalTypeName.Size = new System.Drawing.Size(120, 21);
            this.txt_HCalTypeName.TabIndex = 146;
            this.txt_HCalTypeName.Visible = false;
            // 
            // txt_HCalTypeCd
            // 
            this.txt_HCalTypeCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_HCalTypeCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HCalTypeCd.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_HCalTypeCd.Location = new System.Drawing.Point(744, 8);
            this.txt_HCalTypeCd.MaxLength = 100;
            this.txt_HCalTypeCd.Name = "txt_HCalTypeCd";
            this.txt_HCalTypeCd.ReadOnly = true;
            this.txt_HCalTypeCd.Size = new System.Drawing.Size(89, 21);
            this.txt_HCalTypeCd.TabIndex = 145;
            this.txt_HCalTypeCd.Visible = false;
            // 
            // btn_PopCalType
            // 
            this.btn_PopCalType.ImageIndex = 4;
            this.btn_PopCalType.ImageList = this.img_MiniButton;
            this.btn_PopCalType.Location = new System.Drawing.Point(888, 32);
            this.btn_PopCalType.Name = "btn_PopCalType";
            this.btn_PopCalType.Size = new System.Drawing.Size(21, 21);
            this.btn_PopCalType.TabIndex = 41;
            this.btn_PopCalType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PopCalType.Click += new System.EventHandler(this.btn_PopCalType_Click);
            this.btn_PopCalType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PopCalType_MouseDown);
            this.btn_PopCalType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PopCalType_MouseUp);
            // 
            // cmb_HCalType
            // 
            this.cmb_HCalType.AddItemSeparator = ';';
            this.cmb_HCalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_HCalType.Caption = "";
            this.cmb_HCalType.CaptionHeight = 17;
            this.cmb_HCalType.CaptionStyle = style89;
            this.cmb_HCalType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_HCalType.ColumnCaptionHeight = 18;
            this.cmb_HCalType.ColumnFooterHeight = 18;
            this.cmb_HCalType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_HCalType.ContentHeight = 17;
            this.cmb_HCalType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_HCalType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_HCalType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_HCalType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HCalType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_HCalType.EditorHeight = 17;
            this.cmb_HCalType.EvenRowStyle = style90;
            this.cmb_HCalType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HCalType.FooterStyle = style91;
            this.cmb_HCalType.HeadingStyle = style92;
            this.cmb_HCalType.HighLightRowStyle = style93;
            this.cmb_HCalType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_HCalType.Images"))));
            this.cmb_HCalType.ItemHeight = 15;
            this.cmb_HCalType.Location = new System.Drawing.Point(680, 32);
            this.cmb_HCalType.MatchEntryTimeout = ((long)(2000));
            this.cmb_HCalType.MaxDropDownItems = ((short)(5));
            this.cmb_HCalType.MaxLength = 32767;
            this.cmb_HCalType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_HCalType.Name = "cmb_HCalType";
            this.cmb_HCalType.OddRowStyle = style94;
            this.cmb_HCalType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_HCalType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_HCalType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_HCalType.SelectedStyle = style95;
            this.cmb_HCalType.Size = new System.Drawing.Size(210, 21);
            this.cmb_HCalType.Style = style96;
            this.cmb_HCalType.TabIndex = 40;
            this.cmb_HCalType.SelectedValueChanged += new System.EventHandler(this.cmb_HCalType_SelectedValueChanged);
            this.cmb_HCalType.PropBag = resources.GetString("cmb_HCalType.PropBag");
            // 
            // lbl_HCalType
            // 
            this.lbl_HCalType.ImageIndex = 0;
            this.lbl_HCalType.ImageList = this.img_Label;
            this.lbl_HCalType.Location = new System.Drawing.Point(640, 8);
            this.lbl_HCalType.Name = "lbl_HCalType";
            this.lbl_HCalType.Size = new System.Drawing.Size(100, 21);
            this.lbl_HCalType.TabIndex = 39;
            this.lbl_HCalType.Text = "Calendar Type";
            this.lbl_HCalType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_HCalType.Visible = false;
            // 
            // cmb_HFactory
            // 
            this.cmb_HFactory.AddItemSeparator = ';';
            this.cmb_HFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_HFactory.Caption = "";
            this.cmb_HFactory.CaptionHeight = 17;
            this.cmb_HFactory.CaptionStyle = style97;
            this.cmb_HFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_HFactory.ColumnCaptionHeight = 18;
            this.cmb_HFactory.ColumnFooterHeight = 18;
            this.cmb_HFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_HFactory.ContentHeight = 17;
            this.cmb_HFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_HFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_HFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_HFactory.EditorHeight = 17;
            this.cmb_HFactory.EvenRowStyle = style98;
            this.cmb_HFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_HFactory.FooterStyle = style99;
            this.cmb_HFactory.HeadingStyle = style100;
            this.cmb_HFactory.HighLightRowStyle = style101;
            this.cmb_HFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_HFactory.Images"))));
            this.cmb_HFactory.ItemHeight = 15;
            this.cmb_HFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_HFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_HFactory.MaxDropDownItems = ((short)(5));
            this.cmb_HFactory.MaxLength = 32767;
            this.cmb_HFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_HFactory.Name = "cmb_HFactory";
            this.cmb_HFactory.OddRowStyle = style102;
            this.cmb_HFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_HFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_HFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_HFactory.SelectedStyle = style103;
            this.cmb_HFactory.Size = new System.Drawing.Size(120, 21);
            this.cmb_HFactory.Style = style104;
            this.cmb_HFactory.TabIndex = 38;
            this.cmb_HFactory.SelectedValueChanged += new System.EventHandler(this.cmb_HFactory_SelectedValueChanged);
            this.cmb_HFactory.PropBag = resources.GetString("cmb_HFactory.PropBag");
            // 
            // lbl_HFactory
            // 
            this.lbl_HFactory.ImageIndex = 0;
            this.lbl_HFactory.ImageList = this.img_Label;
            this.lbl_HFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_HFactory.Name = "lbl_HFactory";
            this.lbl_HFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_HFactory.TabIndex = 37;
            this.lbl_HFactory.Text = "Factory";
            this.lbl_HFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox18.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(965, 32);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(17, 15);
            this.pictureBox18.TabIndex = 26;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox24.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(966, 49);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(16, 16);
            this.pictureBox24.TabIndex = 23;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox17.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(131, 48);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(982, 18);
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox19.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(966, 0);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 32);
            this.pictureBox19.TabIndex = 21;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox20.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(224, 0);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(982, 32);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox21.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(160, 32);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(982, 16);
            this.pictureBox21.TabIndex = 27;
            this.pictureBox21.TabStop = false;
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
            this.lbl_SubTitle1.TabIndex = 20;
            this.lbl_SubTitle1.Text = "      Holiday Code Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox22.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(0, 24);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(168, 31);
            this.pictureBox22.TabIndex = 25;
            this.pictureBox22.TabStop = false;
            // 
            // pictureBox23
            // 
            this.pictureBox23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox23.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(0, 49);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(168, 20);
            this.pictureBox23.TabIndex = 22;
            this.pictureBox23.TabStop = false;
            // 
            // obarpg_WorkCal
            // 
            this.obarpg_WorkCal.Controls.Add(this.pnl_WB);
            this.obarpg_WorkCal.Name = "obarpg_WorkCal";
            this.obarpg_WorkCal.Size = new System.Drawing.Size(998, 516);
            this.obarpg_WorkCal.Text = "Work Calendar";
            // 
            // pnl_WB
            // 
            this.pnl_WB.Controls.Add(this.txt_WCalTypeName);
            this.pnl_WB.Controls.Add(this.lbl_WCalType);
            this.pnl_WB.Controls.Add(this.txt_WShiftType);
            this.pnl_WB.Controls.Add(this.cmb_WCalType);
            this.pnl_WB.Controls.Add(this.cmb_WShiftType);
            this.pnl_WB.Controls.Add(this.lbl_WShiftType);
            this.pnl_WB.Controls.Add(this.txt_WShiftTypeName);
            this.pnl_WB.Controls.Add(this.txt_WCalType);
            this.pnl_WB.Controls.Add(this.fgrid_WorkCal);
            this.pnl_WB.Controls.Add(this.pnl_WBT);
            this.pnl_WB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_WB.Location = new System.Drawing.Point(0, 0);
            this.pnl_WB.Name = "pnl_WB";
            this.pnl_WB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_WB.Size = new System.Drawing.Size(998, 516);
            this.pnl_WB.TabIndex = 0;
            // 
            // txt_WCalTypeName
            // 
            this.txt_WCalTypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WCalTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WCalTypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WCalTypeName.Location = new System.Drawing.Point(816, 152);
            this.txt_WCalTypeName.MaxLength = 60;
            this.txt_WCalTypeName.Name = "txt_WCalTypeName";
            this.txt_WCalTypeName.ReadOnly = true;
            this.txt_WCalTypeName.Size = new System.Drawing.Size(140, 21);
            this.txt_WCalTypeName.TabIndex = 178;
            this.txt_WCalTypeName.Visible = false;
            // 
            // lbl_WCalType
            // 
            this.lbl_WCalType.ImageIndex = 0;
            this.lbl_WCalType.ImageList = this.img_Label;
            this.lbl_WCalType.Location = new System.Drawing.Point(640, 152);
            this.lbl_WCalType.Name = "lbl_WCalType";
            this.lbl_WCalType.Size = new System.Drawing.Size(100, 21);
            this.lbl_WCalType.TabIndex = 41;
            this.lbl_WCalType.Text = "Calendar Type";
            this.lbl_WCalType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_WCalType.Visible = false;
            // 
            // txt_WShiftType
            // 
            this.txt_WShiftType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WShiftType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WShiftType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WShiftType.Location = new System.Drawing.Point(744, 176);
            this.txt_WShiftType.MaxLength = 60;
            this.txt_WShiftType.Name = "txt_WShiftType";
            this.txt_WShiftType.ReadOnly = true;
            this.txt_WShiftType.Size = new System.Drawing.Size(69, 21);
            this.txt_WShiftType.TabIndex = 179;
            this.txt_WShiftType.Visible = false;
            // 
            // cmb_WCalType
            // 
            this.cmb_WCalType.AddItemSeparator = ';';
            this.cmb_WCalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_WCalType.Caption = "";
            this.cmb_WCalType.CaptionHeight = 17;
            this.cmb_WCalType.CaptionStyle = style105;
            this.cmb_WCalType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_WCalType.ColumnCaptionHeight = 18;
            this.cmb_WCalType.ColumnFooterHeight = 18;
            this.cmb_WCalType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_WCalType.ContentHeight = 17;
            this.cmb_WCalType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_WCalType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_WCalType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_WCalType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WCalType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_WCalType.EditorHeight = 17;
            this.cmb_WCalType.EvenRowStyle = style106;
            this.cmb_WCalType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WCalType.FooterStyle = style107;
            this.cmb_WCalType.HeadingStyle = style108;
            this.cmb_WCalType.HighLightRowStyle = style109;
            this.cmb_WCalType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_WCalType.Images"))));
            this.cmb_WCalType.ItemHeight = 15;
            this.cmb_WCalType.Location = new System.Drawing.Point(744, 128);
            this.cmb_WCalType.MatchEntryTimeout = ((long)(2000));
            this.cmb_WCalType.MaxDropDownItems = ((short)(5));
            this.cmb_WCalType.MaxLength = 32767;
            this.cmb_WCalType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_WCalType.Name = "cmb_WCalType";
            this.cmb_WCalType.OddRowStyle = style110;
            this.cmb_WCalType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_WCalType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_WCalType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_WCalType.SelectedStyle = style111;
            this.cmb_WCalType.Size = new System.Drawing.Size(80, 21);
            this.cmb_WCalType.Style = style112;
            this.cmb_WCalType.TabIndex = 42;
            this.cmb_WCalType.PropBag = resources.GetString("cmb_WCalType.PropBag");
            // 
            // cmb_WShiftType
            // 
            this.cmb_WShiftType.AddItemSeparator = ';';
            this.cmb_WShiftType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_WShiftType.Caption = "";
            this.cmb_WShiftType.CaptionHeight = 17;
            this.cmb_WShiftType.CaptionStyle = style113;
            this.cmb_WShiftType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_WShiftType.ColumnCaptionHeight = 18;
            this.cmb_WShiftType.ColumnFooterHeight = 18;
            this.cmb_WShiftType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_WShiftType.ContentHeight = 17;
            this.cmb_WShiftType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_WShiftType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_WShiftType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_WShiftType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WShiftType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_WShiftType.EditorHeight = 17;
            this.cmb_WShiftType.EvenRowStyle = style114;
            this.cmb_WShiftType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WShiftType.FooterStyle = style115;
            this.cmb_WShiftType.HeadingStyle = style116;
            this.cmb_WShiftType.HighLightRowStyle = style117;
            this.cmb_WShiftType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_WShiftType.Images"))));
            this.cmb_WShiftType.ItemHeight = 15;
            this.cmb_WShiftType.Location = new System.Drawing.Point(824, 128);
            this.cmb_WShiftType.MatchEntryTimeout = ((long)(2000));
            this.cmb_WShiftType.MaxDropDownItems = ((short)(5));
            this.cmb_WShiftType.MaxLength = 32767;
            this.cmb_WShiftType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_WShiftType.Name = "cmb_WShiftType";
            this.cmb_WShiftType.OddRowStyle = style118;
            this.cmb_WShiftType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_WShiftType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_WShiftType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_WShiftType.SelectedStyle = style119;
            this.cmb_WShiftType.Size = new System.Drawing.Size(80, 21);
            this.cmb_WShiftType.Style = style120;
            this.cmb_WShiftType.TabIndex = 40;
            this.cmb_WShiftType.PropBag = resources.GetString("cmb_WShiftType.PropBag");
            // 
            // lbl_WShiftType
            // 
            this.lbl_WShiftType.ImageIndex = 0;
            this.lbl_WShiftType.ImageList = this.img_Label;
            this.lbl_WShiftType.Location = new System.Drawing.Point(640, 176);
            this.lbl_WShiftType.Name = "lbl_WShiftType";
            this.lbl_WShiftType.Size = new System.Drawing.Size(100, 21);
            this.lbl_WShiftType.TabIndex = 39;
            this.lbl_WShiftType.Text = "Shift Type";
            this.lbl_WShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_WShiftType.Visible = false;
            // 
            // txt_WShiftTypeName
            // 
            this.txt_WShiftTypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WShiftTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WShiftTypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WShiftTypeName.Location = new System.Drawing.Point(816, 176);
            this.txt_WShiftTypeName.MaxLength = 60;
            this.txt_WShiftTypeName.Name = "txt_WShiftTypeName";
            this.txt_WShiftTypeName.ReadOnly = true;
            this.txt_WShiftTypeName.Size = new System.Drawing.Size(140, 21);
            this.txt_WShiftTypeName.TabIndex = 180;
            this.txt_WShiftTypeName.Visible = false;
            // 
            // txt_WCalType
            // 
            this.txt_WCalType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WCalType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WCalType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WCalType.Location = new System.Drawing.Point(744, 152);
            this.txt_WCalType.MaxLength = 60;
            this.txt_WCalType.Name = "txt_WCalType";
            this.txt_WCalType.ReadOnly = true;
            this.txt_WCalType.Size = new System.Drawing.Size(69, 21);
            this.txt_WCalType.TabIndex = 177;
            this.txt_WCalType.Visible = false;
            // 
            // fgrid_WorkCal
            // 
            this.fgrid_WorkCal.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_WorkCal.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_WorkCal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_WorkCal.Location = new System.Drawing.Point(8, 104);
            this.fgrid_WorkCal.Name = "fgrid_WorkCal";
            this.fgrid_WorkCal.Rows.DefaultSize = 19;
            this.fgrid_WorkCal.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_WorkCal.Size = new System.Drawing.Size(982, 404);
            this.fgrid_WorkCal.StyleInfo = resources.GetString("fgrid_WorkCal.StyleInfo");
            this.fgrid_WorkCal.TabIndex = 38;
            this.fgrid_WorkCal.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_WorkCal_AfterEdit);
            // 
            // pnl_WBT
            // 
            this.pnl_WBT.Controls.Add(this.panel7);
            this.pnl_WBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_WBT.Location = new System.Drawing.Point(8, 8);
            this.pnl_WBT.Name = "pnl_WBT";
            this.pnl_WBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_WBT.Size = new System.Drawing.Size(982, 96);
            this.pnl_WBT.TabIndex = 35;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.dpick_ToYMD);
            this.panel7.Controls.Add(this.dpick_FromYMD);
            this.panel7.Controls.Add(this.lbl_WFromYMD);
            this.panel7.Controls.Add(this.cmb_WFactory);
            this.panel7.Controls.Add(this.lbl_WFactory);
            this.panel7.Controls.Add(this.pictureBox33);
            this.panel7.Controls.Add(this.pictureBox34);
            this.panel7.Controls.Add(this.pictureBox35);
            this.panel7.Controls.Add(this.pictureBox36);
            this.panel7.Controls.Add(this.pictureBox37);
            this.panel7.Controls.Add(this.pictureBox38);
            this.panel7.Controls.Add(this.lbl_SubTitle5);
            this.panel7.Controls.Add(this.pictureBox39);
            this.panel7.Controls.Add(this.pictureBox40);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(982, 88);
            this.panel7.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_WCalToDate);
            this.groupBox1.Controls.Add(this.txt_WCalFromDate);
            this.groupBox1.Controls.Add(this.lbl_CalToDate);
            this.groupBox1.Controls.Add(this.lbl_WCalToDate);
            this.groupBox1.Controls.Add(this.txt_CalToDate);
            this.groupBox1.Controls.Add(this.txt_CalFromDate);
            this.groupBox1.Controls.Add(this.btn_CreateDate);
            this.groupBox1.Controls.Add(this.btn_CreateWorkCal);
            this.groupBox1.Location = new System.Drawing.Point(336, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 59);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(201, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 21);
            this.label5.TabIndex = 185;
            this.label5.Text = "~";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(201, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 21);
            this.label4.TabIndex = 184;
            this.label4.Text = "~";
            // 
            // txt_WCalToDate
            // 
            this.txt_WCalToDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WCalToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WCalToDate.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WCalToDate.Location = new System.Drawing.Point(217, 34);
            this.txt_WCalToDate.MaxLength = 60;
            this.txt_WCalToDate.Name = "txt_WCalToDate";
            this.txt_WCalToDate.ReadOnly = true;
            this.txt_WCalToDate.Size = new System.Drawing.Size(97, 21);
            this.txt_WCalToDate.TabIndex = 183;
            // 
            // txt_WCalFromDate
            // 
            this.txt_WCalFromDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_WCalFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_WCalFromDate.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_WCalFromDate.Location = new System.Drawing.Point(104, 34);
            this.txt_WCalFromDate.MaxLength = 60;
            this.txt_WCalFromDate.Name = "txt_WCalFromDate";
            this.txt_WCalFromDate.ReadOnly = true;
            this.txt_WCalFromDate.Size = new System.Drawing.Size(97, 21);
            this.txt_WCalFromDate.TabIndex = 182;
            // 
            // lbl_CalToDate
            // 
            this.lbl_CalToDate.ImageIndex = 0;
            this.lbl_CalToDate.ImageList = this.img_Label;
            this.lbl_CalToDate.Location = new System.Drawing.Point(3, 12);
            this.lbl_CalToDate.Name = "lbl_CalToDate";
            this.lbl_CalToDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_CalToDate.TabIndex = 181;
            this.lbl_CalToDate.Text = "Calendar";
            this.lbl_CalToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_WCalToDate
            // 
            this.lbl_WCalToDate.ImageIndex = 0;
            this.lbl_WCalToDate.ImageList = this.img_Label;
            this.lbl_WCalToDate.Location = new System.Drawing.Point(3, 34);
            this.lbl_WCalToDate.Name = "lbl_WCalToDate";
            this.lbl_WCalToDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_WCalToDate.TabIndex = 180;
            this.lbl_WCalToDate.Text = "Work Calendar";
            this.lbl_WCalToDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_CalToDate
            // 
            this.txt_CalToDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CalToDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CalToDate.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_CalToDate.Location = new System.Drawing.Point(217, 12);
            this.txt_CalToDate.MaxLength = 60;
            this.txt_CalToDate.Name = "txt_CalToDate";
            this.txt_CalToDate.ReadOnly = true;
            this.txt_CalToDate.Size = new System.Drawing.Size(97, 21);
            this.txt_CalToDate.TabIndex = 179;
            // 
            // txt_CalFromDate
            // 
            this.txt_CalFromDate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_CalFromDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CalFromDate.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_CalFromDate.Location = new System.Drawing.Point(104, 12);
            this.txt_CalFromDate.MaxLength = 60;
            this.txt_CalFromDate.Name = "txt_CalFromDate";
            this.txt_CalFromDate.ReadOnly = true;
            this.txt_CalFromDate.Size = new System.Drawing.Size(97, 21);
            this.txt_CalFromDate.TabIndex = 178;
            // 
            // btn_CreateDate
            // 
            this.btn_CreateDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CreateDate.ImageIndex = 0;
            this.btn_CreateDate.ImageList = this.img_Button;
            this.btn_CreateDate.Location = new System.Drawing.Point(316, 9);
            this.btn_CreateDate.Name = "btn_CreateDate";
            this.btn_CreateDate.Size = new System.Drawing.Size(80, 23);
            this.btn_CreateDate.TabIndex = 62;
            this.btn_CreateDate.Text = "Make";
            this.btn_CreateDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateDate.Click += new System.EventHandler(this.btn_CreateDate_Click);
            this.btn_CreateDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CreateDate_MouseDown);
            this.btn_CreateDate.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CreateDate_MouseUp);
            // 
            // btn_CreateWorkCal
            // 
            this.btn_CreateWorkCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CreateWorkCal.ImageIndex = 0;
            this.btn_CreateWorkCal.ImageList = this.img_Button;
            this.btn_CreateWorkCal.Location = new System.Drawing.Point(316, 33);
            this.btn_CreateWorkCal.Name = "btn_CreateWorkCal";
            this.btn_CreateWorkCal.Size = new System.Drawing.Size(80, 23);
            this.btn_CreateWorkCal.TabIndex = 54;
            this.btn_CreateWorkCal.Text = "Make";
            this.btn_CreateWorkCal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateWorkCal.Click += new System.EventHandler(this.btn_CreateWorkCal_Click);
            this.btn_CreateWorkCal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_CreateWorkCal_MouseDown);
            this.btn_CreateWorkCal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_CreateWorkCal_MouseUp);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(208, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 182;
            this.label3.Text = "~";
            // 
            // dpick_ToYMD
            // 
            this.dpick_ToYMD.CustomFormat = "yyyyMMdd";
            this.dpick_ToYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToYMD.Location = new System.Drawing.Point(224, 58);
            this.dpick_ToYMD.Name = "dpick_ToYMD";
            this.dpick_ToYMD.Size = new System.Drawing.Size(97, 22);
            this.dpick_ToYMD.TabIndex = 61;
            this.dpick_ToYMD.ValueChanged += new System.EventHandler(this.dpick_ToYMD_ValueChanged);
            // 
            // dpick_FromYMD
            // 
            this.dpick_FromYMD.CustomFormat = "yyyyMMdd";
            this.dpick_FromYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromYMD.Location = new System.Drawing.Point(111, 58);
            this.dpick_FromYMD.Name = "dpick_FromYMD";
            this.dpick_FromYMD.Size = new System.Drawing.Size(97, 22);
            this.dpick_FromYMD.TabIndex = 60;
            this.dpick_FromYMD.ValueChanged += new System.EventHandler(this.dpick_FromYMD_ValueChanged);
            // 
            // lbl_WFromYMD
            // 
            this.lbl_WFromYMD.ImageIndex = 0;
            this.lbl_WFromYMD.ImageList = this.img_Label;
            this.lbl_WFromYMD.Location = new System.Drawing.Point(10, 58);
            this.lbl_WFromYMD.Name = "lbl_WFromYMD";
            this.lbl_WFromYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_WFromYMD.TabIndex = 58;
            this.lbl_WFromYMD.Text = "Date";
            this.lbl_WFromYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_WFactory
            // 
            this.cmb_WFactory.AddItemSeparator = ';';
            this.cmb_WFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_WFactory.Caption = "";
            this.cmb_WFactory.CaptionHeight = 17;
            this.cmb_WFactory.CaptionStyle = style121;
            this.cmb_WFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_WFactory.ColumnCaptionHeight = 18;
            this.cmb_WFactory.ColumnFooterHeight = 18;
            this.cmb_WFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_WFactory.ContentHeight = 17;
            this.cmb_WFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_WFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_WFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_WFactory.EditorHeight = 17;
            this.cmb_WFactory.EvenRowStyle = style122;
            this.cmb_WFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_WFactory.FooterStyle = style123;
            this.cmb_WFactory.HeadingStyle = style124;
            this.cmb_WFactory.HighLightRowStyle = style125;
            this.cmb_WFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_WFactory.Images"))));
            this.cmb_WFactory.ItemHeight = 15;
            this.cmb_WFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_WFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_WFactory.MaxDropDownItems = ((short)(5));
            this.cmb_WFactory.MaxLength = 32767;
            this.cmb_WFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_WFactory.Name = "cmb_WFactory";
            this.cmb_WFactory.OddRowStyle = style126;
            this.cmb_WFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_WFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_WFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_WFactory.SelectedStyle = style127;
            this.cmb_WFactory.Size = new System.Drawing.Size(209, 21);
            this.cmb_WFactory.Style = style128;
            this.cmb_WFactory.TabIndex = 38;
            this.cmb_WFactory.SelectedValueChanged += new System.EventHandler(this.cmb_WFactory_SelectedValueChanged);
            this.cmb_WFactory.PropBag = resources.GetString("cmb_WFactory.PropBag");
            // 
            // lbl_WFactory
            // 
            this.lbl_WFactory.ImageIndex = 0;
            this.lbl_WFactory.ImageList = this.img_Label;
            this.lbl_WFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_WFactory.Name = "lbl_WFactory";
            this.lbl_WFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_WFactory.TabIndex = 37;
            this.lbl_WFactory.Text = "Factory";
            this.lbl_WFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox33.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(965, 32);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(17, 39);
            this.pictureBox33.TabIndex = 26;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox34.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(966, 73);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(16, 16);
            this.pictureBox34.TabIndex = 23;
            this.pictureBox34.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox35.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(131, 72);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(982, 18);
            this.pictureBox35.TabIndex = 28;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox36.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(966, 0);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(16, 32);
            this.pictureBox36.TabIndex = 21;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox37.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(224, 0);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(982, 32);
            this.pictureBox37.TabIndex = 0;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox38.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(160, 24);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(982, 48);
            this.pictureBox38.TabIndex = 27;
            this.pictureBox38.TabStop = false;
            // 
            // lbl_SubTitle5
            // 
            this.lbl_SubTitle5.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle5.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle5.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle5.Image")));
            this.lbl_SubTitle5.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle5.Name = "lbl_SubTitle5";
            this.lbl_SubTitle5.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle5.TabIndex = 20;
            this.lbl_SubTitle5.Text = "      Work Calendar Info.";
            this.lbl_SubTitle5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox39.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(0, 24);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(168, 55);
            this.pictureBox39.TabIndex = 25;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox40.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(0, 73);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(168, 20);
            this.pictureBox40.TabIndex = 22;
            this.pictureBox40.TabStop = false;
            // 
            // obarpg_Shift
            // 
            this.obarpg_Shift.Controls.Add(this.pnl_SB);
            this.obarpg_Shift.Name = "obarpg_Shift";
            this.obarpg_Shift.PageVisible = false;
            this.obarpg_Shift.Size = new System.Drawing.Size(998, 496);
            this.obarpg_Shift.Text = "Work Time";
            // 
            // pnl_SB
            // 
            this.pnl_SB.Controls.Add(this.fgrid_Shift);
            this.pnl_SB.Controls.Add(this.pnl_SBB);
            this.pnl_SB.Controls.Add(this.pnl_SBT);
            this.pnl_SB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SB.Location = new System.Drawing.Point(0, 0);
            this.pnl_SB.Name = "pnl_SB";
            this.pnl_SB.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_SB.Size = new System.Drawing.Size(998, 496);
            this.pnl_SB.TabIndex = 0;
            // 
            // fgrid_Shift
            // 
            this.fgrid_Shift.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Shift.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Shift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Shift.Location = new System.Drawing.Point(8, 103);
            this.fgrid_Shift.Name = "fgrid_Shift";
            this.fgrid_Shift.Rows.DefaultSize = 19;
            this.fgrid_Shift.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Shift.Size = new System.Drawing.Size(982, 206);
            this.fgrid_Shift.StyleInfo = resources.GetString("fgrid_Shift.StyleInfo");
            this.fgrid_Shift.TabIndex = 37;
            this.fgrid_Shift.Click += new System.EventHandler(this.fgrid_Shift_Click);
            this.fgrid_Shift.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_AfterEdit);
            this.fgrid_Shift.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_BeforeEdit);
            // 
            // pnl_SBB
            // 
            this.pnl_SBB.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SBB.Controls.Add(this.panel4);
            this.pnl_SBB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_SBB.Location = new System.Drawing.Point(8, 309);
            this.pnl_SBB.Name = "pnl_SBB";
            this.pnl_SBB.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnl_SBB.Size = new System.Drawing.Size(982, 179);
            this.pnl_SBB.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Controls.Add(this.txt_STypeName);
            this.panel4.Controls.Add(this.txt_SOverTime);
            this.panel4.Controls.Add(this.txt_SRemarks);
            this.panel4.Controls.Add(this.txt_STmEndWk);
            this.panel4.Controls.Add(this.txt_SWeekDay);
            this.panel4.Controls.Add(this.chk_SOverTimeYN);
            this.panel4.Controls.Add(this.chk_SShiftYN);
            this.panel4.Controls.Add(this.lbl_SRemarks);
            this.panel4.Controls.Add(this.lbl_SOverTime);
            this.panel4.Controls.Add(this.lbl_SShiftYN);
            this.panel4.Controls.Add(this.lbl_SUseYN);
            this.panel4.Controls.Add(this.lbl_STmEndWk);
            this.panel4.Controls.Add(this.lbl_SOverTimeYN);
            this.panel4.Controls.Add(this.chk_SUseYN);
            this.panel4.Controls.Add(this.lbl_SEndWeekDay);
            this.panel4.Controls.Add(this.txt_SEndWeekDay);
            this.panel4.Controls.Add(this.lbl_STmStartWk);
            this.panel4.Controls.Add(this.txt_STmStartWk);
            this.panel4.Controls.Add(this.txt_SType);
            this.panel4.Controls.Add(this.txt_SShiftNo);
            this.panel4.Controls.Add(this.lbl_SShiftNo);
            this.panel4.Controls.Add(this.lbl_SWeekDay);
            this.panel4.Controls.Add(this.lbl_SType);
            this.panel4.Controls.Add(this.lbl_StWeekDay);
            this.panel4.Controls.Add(this.txt_StWeekDay);
            this.panel4.Controls.Add(this.pictureBox9);
            this.panel4.Controls.Add(this.pictureBox10);
            this.panel4.Controls.Add(this.lbl_SubTitle4);
            this.panel4.Controls.Add(this.pictureBox11);
            this.panel4.Controls.Add(this.pictureBox12);
            this.panel4.Controls.Add(this.pictureBox13);
            this.panel4.Controls.Add(this.pictureBox14);
            this.panel4.Controls.Add(this.pictureBox15);
            this.panel4.Controls.Add(this.pictureBox16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(0, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(982, 171);
            this.panel4.TabIndex = 0;
            // 
            // txt_STypeName
            // 
            this.txt_STypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_STypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_STypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_STypeName.Location = new System.Drawing.Point(181, 36);
            this.txt_STypeName.MaxLength = 60;
            this.txt_STypeName.Name = "txt_STypeName";
            this.txt_STypeName.ReadOnly = true;
            this.txt_STypeName.Size = new System.Drawing.Size(140, 21);
            this.txt_STypeName.TabIndex = 174;
            // 
            // txt_SOverTime
            // 
            this.txt_SOverTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SOverTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SOverTime.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SOverTime.Location = new System.Drawing.Point(765, 102);
            this.txt_SOverTime.MaxLength = 60;
            this.txt_SOverTime.Name = "txt_SOverTime";
            this.txt_SOverTime.ReadOnly = true;
            this.txt_SOverTime.Size = new System.Drawing.Size(192, 21);
            this.txt_SOverTime.TabIndex = 173;
            // 
            // txt_SRemarks
            // 
            this.txt_SRemarks.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SRemarks.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SRemarks.Location = new System.Drawing.Point(111, 102);
            this.txt_SRemarks.MaxLength = 60;
            this.txt_SRemarks.Name = "txt_SRemarks";
            this.txt_SRemarks.ReadOnly = true;
            this.txt_SRemarks.Size = new System.Drawing.Size(210, 21);
            this.txt_SRemarks.TabIndex = 172;
            // 
            // txt_STmEndWk
            // 
            this.txt_STmEndWk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_STmEndWk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_STmEndWk.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_STmEndWk.Location = new System.Drawing.Point(437, 102);
            this.txt_STmEndWk.MaxLength = 100;
            this.txt_STmEndWk.Name = "txt_STmEndWk";
            this.txt_STmEndWk.ReadOnly = true;
            this.txt_STmEndWk.Size = new System.Drawing.Size(192, 21);
            this.txt_STmEndWk.TabIndex = 171;
            // 
            // txt_SWeekDay
            // 
            this.txt_SWeekDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SWeekDay.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SWeekDay.Location = new System.Drawing.Point(111, 58);
            this.txt_SWeekDay.MaxLength = 60;
            this.txt_SWeekDay.Name = "txt_SWeekDay";
            this.txt_SWeekDay.ReadOnly = true;
            this.txt_SWeekDay.Size = new System.Drawing.Size(210, 21);
            this.txt_SWeekDay.TabIndex = 170;
            // 
            // chk_SOverTimeYN
            // 
            this.chk_SOverTimeYN.Enabled = false;
            this.chk_SOverTimeYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_SOverTimeYN.Location = new System.Drawing.Point(765, 80);
            this.chk_SOverTimeYN.Name = "chk_SOverTimeYN";
            this.chk_SOverTimeYN.Size = new System.Drawing.Size(16, 21);
            this.chk_SOverTimeYN.TabIndex = 169;
            // 
            // chk_SShiftYN
            // 
            this.chk_SShiftYN.Enabled = false;
            this.chk_SShiftYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_SShiftYN.Location = new System.Drawing.Point(765, 58);
            this.chk_SShiftYN.Name = "chk_SShiftYN";
            this.chk_SShiftYN.Size = new System.Drawing.Size(16, 21);
            this.chk_SShiftYN.TabIndex = 168;
            // 
            // lbl_SRemarks
            // 
            this.lbl_SRemarks.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SRemarks.ImageIndex = 0;
            this.lbl_SRemarks.ImageList = this.img_Label;
            this.lbl_SRemarks.Location = new System.Drawing.Point(10, 102);
            this.lbl_SRemarks.Name = "lbl_SRemarks";
            this.lbl_SRemarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_SRemarks.TabIndex = 167;
            this.lbl_SRemarks.Text = "Remarks";
            this.lbl_SRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SOverTime
            // 
            this.lbl_SOverTime.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SOverTime.ImageIndex = 0;
            this.lbl_SOverTime.ImageList = this.img_Label;
            this.lbl_SOverTime.Location = new System.Drawing.Point(664, 102);
            this.lbl_SOverTime.Name = "lbl_SOverTime";
            this.lbl_SOverTime.Size = new System.Drawing.Size(100, 21);
            this.lbl_SOverTime.TabIndex = 166;
            this.lbl_SOverTime.Text = "OverTime";
            this.lbl_SOverTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SShiftYN
            // 
            this.lbl_SShiftYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SShiftYN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SShiftYN.ImageIndex = 0;
            this.lbl_SShiftYN.ImageList = this.img_Label;
            this.lbl_SShiftYN.Location = new System.Drawing.Point(664, 58);
            this.lbl_SShiftYN.Name = "lbl_SShiftYN";
            this.lbl_SShiftYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_SShiftYN.TabIndex = 164;
            this.lbl_SShiftYN.Text = "Shift Y/N";
            this.lbl_SShiftYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SUseYN
            // 
            this.lbl_SUseYN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SUseYN.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SUseYN.ImageIndex = 0;
            this.lbl_SUseYN.ImageList = this.img_Label;
            this.lbl_SUseYN.Location = new System.Drawing.Point(664, 36);
            this.lbl_SUseYN.Name = "lbl_SUseYN";
            this.lbl_SUseYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_SUseYN.TabIndex = 163;
            this.lbl_SUseYN.Text = "Use Y/N";
            this.lbl_SUseYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_STmEndWk
            // 
            this.lbl_STmEndWk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_STmEndWk.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_STmEndWk.ImageIndex = 0;
            this.lbl_STmEndWk.ImageList = this.img_Label;
            this.lbl_STmEndWk.Location = new System.Drawing.Point(336, 102);
            this.lbl_STmEndWk.Name = "lbl_STmEndWk";
            this.lbl_STmEndWk.Size = new System.Drawing.Size(100, 21);
            this.lbl_STmEndWk.TabIndex = 162;
            this.lbl_STmEndWk.Text = "End Time";
            this.lbl_STmEndWk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SOverTimeYN
            // 
            this.lbl_SOverTimeYN.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SOverTimeYN.ImageIndex = 0;
            this.lbl_SOverTimeYN.ImageList = this.img_Label;
            this.lbl_SOverTimeYN.Location = new System.Drawing.Point(664, 80);
            this.lbl_SOverTimeYN.Name = "lbl_SOverTimeYN";
            this.lbl_SOverTimeYN.Size = new System.Drawing.Size(100, 21);
            this.lbl_SOverTimeYN.TabIndex = 165;
            this.lbl_SOverTimeYN.Text = "OverTime Y/N";
            this.lbl_SOverTimeYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chk_SUseYN
            // 
            this.chk_SUseYN.Enabled = false;
            this.chk_SUseYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_SUseYN.Location = new System.Drawing.Point(765, 36);
            this.chk_SUseYN.Name = "chk_SUseYN";
            this.chk_SUseYN.Size = new System.Drawing.Size(12, 21);
            this.chk_SUseYN.TabIndex = 161;
            // 
            // lbl_SEndWeekDay
            // 
            this.lbl_SEndWeekDay.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_SEndWeekDay.ImageIndex = 0;
            this.lbl_SEndWeekDay.ImageList = this.img_Label;
            this.lbl_SEndWeekDay.Location = new System.Drawing.Point(336, 80);
            this.lbl_SEndWeekDay.Name = "lbl_SEndWeekDay";
            this.lbl_SEndWeekDay.Size = new System.Drawing.Size(100, 21);
            this.lbl_SEndWeekDay.TabIndex = 159;
            this.lbl_SEndWeekDay.Text = "End WeekDay";
            this.lbl_SEndWeekDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_SEndWeekDay
            // 
            this.txt_SEndWeekDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SEndWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SEndWeekDay.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SEndWeekDay.Location = new System.Drawing.Point(437, 80);
            this.txt_SEndWeekDay.MaxLength = 100;
            this.txt_SEndWeekDay.Name = "txt_SEndWeekDay";
            this.txt_SEndWeekDay.ReadOnly = true;
            this.txt_SEndWeekDay.Size = new System.Drawing.Size(192, 21);
            this.txt_SEndWeekDay.TabIndex = 160;
            // 
            // lbl_STmStartWk
            // 
            this.lbl_STmStartWk.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_STmStartWk.ImageIndex = 0;
            this.lbl_STmStartWk.ImageList = this.img_Label;
            this.lbl_STmStartWk.Location = new System.Drawing.Point(336, 58);
            this.lbl_STmStartWk.Name = "lbl_STmStartWk";
            this.lbl_STmStartWk.Size = new System.Drawing.Size(100, 21);
            this.lbl_STmStartWk.TabIndex = 157;
            this.lbl_STmStartWk.Text = "Start Time";
            this.lbl_STmStartWk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_STmStartWk
            // 
            this.txt_STmStartWk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_STmStartWk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_STmStartWk.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_STmStartWk.Location = new System.Drawing.Point(437, 58);
            this.txt_STmStartWk.MaxLength = 100;
            this.txt_STmStartWk.Name = "txt_STmStartWk";
            this.txt_STmStartWk.ReadOnly = true;
            this.txt_STmStartWk.Size = new System.Drawing.Size(192, 21);
            this.txt_STmStartWk.TabIndex = 158;
            // 
            // txt_SType
            // 
            this.txt_SType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SType.Location = new System.Drawing.Point(111, 36);
            this.txt_SType.MaxLength = 60;
            this.txt_SType.Name = "txt_SType";
            this.txt_SType.ReadOnly = true;
            this.txt_SType.Size = new System.Drawing.Size(69, 21);
            this.txt_SType.TabIndex = 156;
            // 
            // txt_SShiftNo
            // 
            this.txt_SShiftNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SShiftNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SShiftNo.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SShiftNo.Location = new System.Drawing.Point(111, 80);
            this.txt_SShiftNo.MaxLength = 60;
            this.txt_SShiftNo.Name = "txt_SShiftNo";
            this.txt_SShiftNo.ReadOnly = true;
            this.txt_SShiftNo.Size = new System.Drawing.Size(210, 21);
            this.txt_SShiftNo.TabIndex = 155;
            // 
            // lbl_SShiftNo
            // 
            this.lbl_SShiftNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SShiftNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SShiftNo.ImageIndex = 0;
            this.lbl_SShiftNo.ImageList = this.img_Label;
            this.lbl_SShiftNo.Location = new System.Drawing.Point(10, 80);
            this.lbl_SShiftNo.Name = "lbl_SShiftNo";
            this.lbl_SShiftNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_SShiftNo.TabIndex = 152;
            this.lbl_SShiftNo.Text = "Shift No";
            this.lbl_SShiftNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SWeekDay
            // 
            this.lbl_SWeekDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SWeekDay.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SWeekDay.ImageIndex = 0;
            this.lbl_SWeekDay.ImageList = this.img_Label;
            this.lbl_SWeekDay.Location = new System.Drawing.Point(10, 58);
            this.lbl_SWeekDay.Name = "lbl_SWeekDay";
            this.lbl_SWeekDay.Size = new System.Drawing.Size(100, 21);
            this.lbl_SWeekDay.TabIndex = 151;
            this.lbl_SWeekDay.Text = "WeekDay";
            this.lbl_SWeekDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SType
            // 
            this.lbl_SType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_SType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SType.ImageIndex = 0;
            this.lbl_SType.ImageList = this.img_Label;
            this.lbl_SType.Location = new System.Drawing.Point(10, 36);
            this.lbl_SType.Name = "lbl_SType";
            this.lbl_SType.Size = new System.Drawing.Size(100, 21);
            this.lbl_SType.TabIndex = 150;
            this.lbl_SType.Text = "Shift Type";
            this.lbl_SType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_StWeekDay
            // 
            this.lbl_StWeekDay.Font = new System.Drawing.Font("Verdana", 9F);
            this.lbl_StWeekDay.ImageIndex = 0;
            this.lbl_StWeekDay.ImageList = this.img_Label;
            this.lbl_StWeekDay.Location = new System.Drawing.Point(336, 36);
            this.lbl_StWeekDay.Name = "lbl_StWeekDay";
            this.lbl_StWeekDay.Size = new System.Drawing.Size(100, 21);
            this.lbl_StWeekDay.TabIndex = 153;
            this.lbl_StWeekDay.Text = "Start WeekDay";
            this.lbl_StWeekDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_StWeekDay
            // 
            this.txt_StWeekDay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_StWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StWeekDay.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_StWeekDay.Location = new System.Drawing.Point(437, 36);
            this.txt_StWeekDay.MaxLength = 100;
            this.txt_StWeekDay.Name = "txt_StWeekDay";
            this.txt_StWeekDay.ReadOnly = true;
            this.txt_StWeekDay.Size = new System.Drawing.Size(192, 21);
            this.txt_StWeekDay.TabIndex = 154;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(966, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(16, 32);
            this.pictureBox9.TabIndex = 21;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(224, 0);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(982, 39);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            // 
            // lbl_SubTitle4
            // 
            this.lbl_SubTitle4.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_SubTitle4.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle4.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle4.Image")));
            this.lbl_SubTitle4.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle4.Name = "lbl_SubTitle4";
            this.lbl_SubTitle4.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle4.TabIndex = 28;
            this.lbl_SubTitle4.Text = "      Display Shift Type Info.";
            this.lbl_SubTitle4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(967, 24);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(15, 127);
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(160, 24);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(982, 131);
            this.pictureBox12.TabIndex = 27;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox13.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(966, 155);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(16, 16);
            this.pictureBox13.TabIndex = 23;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox14.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(144, 153);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(982, 18);
            this.pictureBox14.TabIndex = 24;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox15.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(0, 151);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(168, 20);
            this.pictureBox15.TabIndex = 22;
            this.pictureBox15.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox16.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(0, 24);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(168, 131);
            this.pictureBox16.TabIndex = 25;
            this.pictureBox16.TabStop = false;
            // 
            // pnl_SBT
            // 
            this.pnl_SBT.Controls.Add(this.panel2);
            this.pnl_SBT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_SBT.Location = new System.Drawing.Point(8, 8);
            this.pnl_SBT.Name = "pnl_SBT";
            this.pnl_SBT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.pnl_SBT.Size = new System.Drawing.Size(982, 95);
            this.pnl_SBT.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.txt_SShiftTypeName);
            this.panel2.Controls.Add(this.txt_SShiftType);
            this.panel2.Controls.Add(this.btn_PopShiftType);
            this.panel2.Controls.Add(this.cmb_SShiftType);
            this.panel2.Controls.Add(this.lbl_SShiftType);
            this.panel2.Controls.Add(this.cmb_SFactory);
            this.panel2.Controls.Add(this.lbl_SFactory);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.lbl_SubTitle3);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 87);
            this.panel2.TabIndex = 19;
            // 
            // txt_SShiftTypeName
            // 
            this.txt_SShiftTypeName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SShiftTypeName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SShiftTypeName.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SShiftTypeName.Location = new System.Drawing.Point(181, 58);
            this.txt_SShiftTypeName.MaxLength = 60;
            this.txt_SShiftTypeName.Name = "txt_SShiftTypeName";
            this.txt_SShiftTypeName.ReadOnly = true;
            this.txt_SShiftTypeName.Size = new System.Drawing.Size(140, 21);
            this.txt_SShiftTypeName.TabIndex = 176;
            // 
            // txt_SShiftType
            // 
            this.txt_SShiftType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_SShiftType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_SShiftType.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.txt_SShiftType.Location = new System.Drawing.Point(111, 58);
            this.txt_SShiftType.MaxLength = 60;
            this.txt_SShiftType.Name = "txt_SShiftType";
            this.txt_SShiftType.ReadOnly = true;
            this.txt_SShiftType.Size = new System.Drawing.Size(69, 21);
            this.txt_SShiftType.TabIndex = 175;
            // 
            // btn_PopShiftType
            // 
            this.btn_PopShiftType.ImageIndex = 4;
            this.btn_PopShiftType.ImageList = this.img_MiniButton;
            this.btn_PopShiftType.Location = new System.Drawing.Point(555, 56);
            this.btn_PopShiftType.Name = "btn_PopShiftType";
            this.btn_PopShiftType.Size = new System.Drawing.Size(21, 21);
            this.btn_PopShiftType.TabIndex = 41;
            this.btn_PopShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PopShiftType.Click += new System.EventHandler(this.btn_PopShiftType_Click);
            this.btn_PopShiftType.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_PopShiftType_MouseDown);
            this.btn_PopShiftType.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_PopShiftType_MouseUp);
            // 
            // cmb_SShiftType
            // 
            this.cmb_SShiftType.AddItemSeparator = ';';
            this.cmb_SShiftType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SShiftType.Caption = "";
            this.cmb_SShiftType.CaptionHeight = 17;
            this.cmb_SShiftType.CaptionStyle = style129;
            this.cmb_SShiftType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SShiftType.ColumnCaptionHeight = 18;
            this.cmb_SShiftType.ColumnFooterHeight = 18;
            this.cmb_SShiftType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SShiftType.ContentHeight = 17;
            this.cmb_SShiftType.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_SShiftType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SShiftType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SShiftType.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SShiftType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SShiftType.EditorHeight = 17;
            this.cmb_SShiftType.EvenRowStyle = style130;
            this.cmb_SShiftType.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SShiftType.FooterStyle = style131;
            this.cmb_SShiftType.HeadingStyle = style132;
            this.cmb_SShiftType.HighLightRowStyle = style133;
            this.cmb_SShiftType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SShiftType.Images"))));
            this.cmb_SShiftType.ItemHeight = 15;
            this.cmb_SShiftType.Location = new System.Drawing.Point(344, 56);
            this.cmb_SShiftType.MatchEntryTimeout = ((long)(2000));
            this.cmb_SShiftType.MaxDropDownItems = ((short)(5));
            this.cmb_SShiftType.MaxLength = 32767;
            this.cmb_SShiftType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SShiftType.Name = "cmb_SShiftType";
            this.cmb_SShiftType.OddRowStyle = style134;
            this.cmb_SShiftType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SShiftType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SShiftType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SShiftType.SelectedStyle = style135;
            this.cmb_SShiftType.Size = new System.Drawing.Size(210, 21);
            this.cmb_SShiftType.Style = style136;
            this.cmb_SShiftType.TabIndex = 40;
            this.cmb_SShiftType.SelectedValueChanged += new System.EventHandler(this.cmb_SShiftType_SelectedValueChanged);
            this.cmb_SShiftType.PropBag = resources.GetString("cmb_SShiftType.PropBag");
            // 
            // lbl_SShiftType
            // 
            this.lbl_SShiftType.ImageIndex = 0;
            this.lbl_SShiftType.ImageList = this.img_Label;
            this.lbl_SShiftType.Location = new System.Drawing.Point(10, 58);
            this.lbl_SShiftType.Name = "lbl_SShiftType";
            this.lbl_SShiftType.Size = new System.Drawing.Size(100, 21);
            this.lbl_SShiftType.TabIndex = 39;
            this.lbl_SShiftType.Text = "Shift Type";
            this.lbl_SShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SFactory
            // 
            this.cmb_SFactory.AddItemSeparator = ';';
            this.cmb_SFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SFactory.Caption = "";
            this.cmb_SFactory.CaptionHeight = 17;
            this.cmb_SFactory.CaptionStyle = style137;
            this.cmb_SFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SFactory.ColumnCaptionHeight = 18;
            this.cmb_SFactory.ColumnFooterHeight = 18;
            this.cmb_SFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SFactory.ContentHeight = 17;
            this.cmb_SFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SFactory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SFactory.EditorHeight = 17;
            this.cmb_SFactory.EvenRowStyle = style138;
            this.cmb_SFactory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SFactory.FooterStyle = style139;
            this.cmb_SFactory.HeadingStyle = style140;
            this.cmb_SFactory.HighLightRowStyle = style141;
            this.cmb_SFactory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SFactory.Images"))));
            this.cmb_SFactory.ItemHeight = 15;
            this.cmb_SFactory.Location = new System.Drawing.Point(111, 36);
            this.cmb_SFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_SFactory.MaxDropDownItems = ((short)(5));
            this.cmb_SFactory.MaxLength = 32767;
            this.cmb_SFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SFactory.Name = "cmb_SFactory";
            this.cmb_SFactory.OddRowStyle = style142;
            this.cmb_SFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SFactory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SFactory.SelectedStyle = style143;
            this.cmb_SFactory.Size = new System.Drawing.Size(210, 21);
            this.cmb_SFactory.Style = style144;
            this.cmb_SFactory.TabIndex = 38;
            this.cmb_SFactory.SelectedValueChanged += new System.EventHandler(this.cmb_SFactory_SelectedValueChanged);
            this.cmb_SFactory.PropBag = resources.GetString("cmb_SFactory.PropBag");
            // 
            // lbl_SFactory
            // 
            this.lbl_SFactory.ImageIndex = 0;
            this.lbl_SFactory.ImageList = this.img_Label;
            this.lbl_SFactory.Location = new System.Drawing.Point(10, 36);
            this.lbl_SFactory.Name = "lbl_SFactory";
            this.lbl_SFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_SFactory.TabIndex = 37;
            this.lbl_SFactory.Text = "Factory";
            this.lbl_SFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(965, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 38);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(966, 72);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
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
            this.pictureBox3.Size = new System.Drawing.Size(982, 18);
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(966, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 32);
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
            this.pictureBox5.Size = new System.Drawing.Size(982, 32);
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
            this.pictureBox6.Size = new System.Drawing.Size(982, 47);
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_SubTitle3
            // 
            this.lbl_SubTitle3.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_SubTitle3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitle3.ForeColor = System.Drawing.Color.Navy;
            this.lbl_SubTitle3.Image = ((System.Drawing.Image)(resources.GetObject("lbl_SubTitle3.Image")));
            this.lbl_SubTitle3.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitle3.Name = "lbl_SubTitle3";
            this.lbl_SubTitle3.Size = new System.Drawing.Size(231, 30);
            this.lbl_SubTitle3.TabIndex = 20;
            this.lbl_SubTitle3.Text = "      Work Shift Type Info.";
            this.lbl_SubTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(0, 24);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(168, 54);
            this.pictureBox7.TabIndex = 25;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 72);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(168, 20);
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.obar_Main);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.panel1.Size = new System.Drawing.Size(1014, 576);
            this.panel1.TabIndex = 29;
            // 
            // Form_PB_WorkCal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.panel1);
            this.Name = "Form_PB_WorkCal";
            this.Text = "Work Calendar";
            this.Load += new System.EventHandler(this.Form_PB_WorkCal_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obar_Main)).EndInit();
            this.obar_Main.ResumeLayout(false);
            this.obarpg_Holiday.ResumeLayout(false);
            this.pnl_HB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Holiday)).EndInit();
            this.pnl_HBBL.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.pnl_HBT.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HToYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HFromYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HCalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_HFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            this.obarpg_WorkCal.ResumeLayout(false);
            this.pnl_WB.ResumeLayout(false);
            this.pnl_WB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WCalType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_WorkCal)).EndInit();
            this.pnl_WBT.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_WFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            this.obarpg_Shift.ResumeLayout(false);
            this.pnl_SB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Shift)).EndInit();
            this.pnl_SBB.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            this.pnl_SBT.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SShiftType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의

  
		private COM.OraDB MyOraDB = new COM.OraDB();


		/// <summary>
		/// 그리드 스타일
		/// </summary>
		private enum PopLoadFlag : int
		{	
			FromHoliday =0,				
			FromShift= 1,				
		}


		//private string _TheDate;

		//기본 ShiftNo, ShiftYN
		private string _CommonShiftNo = "1";
		private string _CommonShiftYN = "N"; 
		//기본 Shift 시작, 종료시간
		private string _CommonShiftStartTM = "07:30";
		private string _CommonShiftEndTM = "16:30";

		


		#endregion 

		#region 멤버 메서드

 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			
			CellStyle cellst; 
			DataTable dt_ret;


			//Title
			this.Text = "Work Calendar";
			this.lbl_MainTitle.Text = "Work Calendar";  
  
			ClassLib.ComFunction.SetLangDic(this);

			#region 버튼 권한

//			try
//			{
//				COM.OraDB btn_control = new COM.OraDB();
//				DataTable dt_btn = btn_control.Select_Button(ClassLib.ComVar.This_Factory,ClassLib.ComVar.This_User, this.Name);
//				tbtn_Search.Enabled = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSearch].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Save.Enabled   = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColSave].ToString().ToUpper() == "Y")?true:false;
//				tbtn_Print.Enabled  = (dt_btn.Rows[0].ItemArray[(int)ClassLib.ComVar.Btn_Control.ColPrint].ToString().ToUpper() == "Y")?true:false;
//				btn_control = null;
//			}
//			catch
//			{
//			}

			#endregion


			tbtn_Color.Enabled = false;
			tbtn_Print.Enabled = false;

//			cmb_HFactory.Enabled = false;
//			cmb_WFactory.Enabled = false;


			//달력 크기 설정
			monthCalendar.Size = new Size(178, 185);

			//휴일 코드
			fgrid_Holiday.Set_Grid("SPB_HOLIDAY", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Holiday.Set_Action_Image(img_Action); 
  
			cellst = fgrid_Holiday.Styles.Add("TIME_MASK");
			cellst.DataType = typeof(string);		 
			cellst.EditMask = "00:00";
 
			fgrid_Holiday.Cols[(int)ClassLib.TBSPB_HOLIDAY.IxTM_START_HOLI].Style = fgrid_Holiday.Styles["TIME_MASK"];
			fgrid_Holiday.Cols[(int)ClassLib.TBSPB_HOLIDAY.IxTM_END_HOLI].Style = fgrid_Holiday.Styles["TIME_MASK"];

			cmb_HCalType.Visible = false;
			btn_PopCalType.Visible = false;


			//교대 타입
			fgrid_Shift.Set_Grid("SPB_SHIFT", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
			fgrid_Shift.Set_Action_Image(img_Action); 
  
			cellst = fgrid_Shift.Styles.Add("TIME_MASK");
			cellst.DataType = typeof(string);		 
			cellst.EditMask = "00:00";
 
 
			fgrid_Shift.Cols[(int)ClassLib.TBSPB_SHIFT.IxTM_START_WK].Style = fgrid_Shift.Styles["TIME_MASK"];
			fgrid_Shift.Cols[(int)ClassLib.TBSPB_SHIFT.IxTM_END_WK].Style = fgrid_Shift.Styles["TIME_MASK"]; 

			cmb_SShiftType.Visible = false;
			btn_PopShiftType.Visible = false;
 


			//월력 생성
			fgrid_WorkCal.Set_Grid("SPB_WORK_CAL", "1", 1, ClassLib.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true); 
			fgrid_WorkCal.Set_Action_Image(img_Action); 

			dpick_FromYMD.CustomFormat = " ";
			dpick_ToYMD.CustomFormat = " ";

			cmb_WCalType.Visible = false;
			cmb_WShiftType.Visible = false;
  

			dt_ret = COM.ComFunction.Select_Factory_List();
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_HFactory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SFactory, 0, 1, false,COM.ComVar.ComboList_Visible.Code);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_WFactory, 0, 1, false,COM.ComVar.ComboList_Visible.Code); 


			cmb_HFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_SFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_WFactory.SelectedValue = ClassLib.ComVar.This_Factory; 


			obar_Main.SelectedPage = obarpg_Holiday;  

		}

 
  
		/// <summary>
		/// Display_Grid : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
			
			arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;  
			arg_fgrid.Cols.Count = arg_dt.Columns.Count + 1;
 
			if(arg_dt.Rows.Count == 0) return;

			// Set List
			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 1);
				arg_fgrid[arg_fgrid.Rows.Count - 1, 0] = "";

				if(arg_fgrid.Equals(fgrid_WorkCal) )
				{
					// 휴일 경우 색깔 표시

//					if(Convert.ToBoolean(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_WORK_CAL.IxHOLI_YN].ToString()) == true
//						&& arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_WORK_CAL.IxWEEK_IX].ToString() == "1")

					if(Convert.ToBoolean(arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSPB_WORK_CAL.IxHOLI_YN].ToString()) == true ) 
						arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].StyleNew.ForeColor = ClassLib.ComVar.ClrWarning; 

				}

			} 

			

			arg_fgrid.AutoSizeCols();
		}



		/// <summary>
		/// Display_Grid_Change : 데이터 테이블 리스트를 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid_Change(DataTable arg_dt, C1FlexGrid arg_fgrid)
		{
		
			try
			{
				arg_fgrid.Cols.Count = arg_dt.Rows.Count + 2;
 
				// Set List
				for(int i = 0; i < arg_dt.Rows.Count; i++)
				{
					arg_fgrid[0, i + 2] = " ";
					for(int j = 1; j < arg_fgrid.Rows.Count; j++)
					{ 
						arg_fgrid[j, i + 2] = arg_dt.Rows[i].ItemArray[j - 1].ToString();
						arg_fgrid.Rows[j].TextAlign = TextAlignEnum.LeftCenter;
					}	
				}


				arg_fgrid.AutoSizeCols();
			}
			catch
			{
			}
	
		}



		/// <summary>
		/// Set_Grid_Change : Row, Col Change
		/// </summary>
		private void Set_Grid_Change(COM.FSP arg_fgrid)
		{
			DataTable dt_ret;
			CellStyle cellst;

			try
			{
				////// DB에서 그리드 정보 추출 
				dt_ret = MyOraDB.Select_GridHead("SPB_WORK_CAL", "2");
				if (dt_ret== null) return ;
	
				if(dt_ret.Rows.Count > 0)
				{
					arg_fgrid.Clear(C1.Win.C1FlexGrid.ClearFlags.All); 
					arg_fgrid.Rows.Count = dt_ret.Rows.Count + 1; 
					arg_fgrid.Rows.Fixed = 0;
					arg_fgrid.Cols.Count = 2;
					arg_fgrid.Cols.Fixed = 2;
					arg_fgrid.Cols[0].Visible = false;
					//arg_fgrid.Rows[0].Visible = false;
				
					arg_fgrid.Font = new Font("Verdana", 9);

					////////////////////////////////////////////////////
					///그리드 색 세팅
					//////////////////////////////////////////////////// 
 
					arg_fgrid.Styles.EmptyArea.BackColor = COM.ComVar.GridEmptyColor;
					arg_fgrid.Styles.Alternate.BackColor = COM.ComVar.GridAlternate_Color;
					arg_fgrid.Styles.Highlight.BackColor = COM.ComVar.GridHigh_Color;
					arg_fgrid.Styles.Focus.BackColor = COM.ComVar.GridHigh_Color;
					arg_fgrid.Styles.Fixed.ForeColor = COM.ComVar.GridForeColor;
					arg_fgrid.Styles.Fixed.BackColor = COM.ComVar.GridDarkFixed_Color;  
					arg_fgrid.Rows[0].StyleNew.BackColor = COM.ComVar.GridCol0_Color; 
 
 
					//-------------------------------------------------
					//Column 속성 설정
					//TEXT
					cellst = arg_fgrid.Styles.Add("TEXT");
					cellst.DataType = typeof(string);		 
 
					//CHECKBOX
					cellst = arg_fgrid.Styles.Add("CHECKBOX");
					cellst.DataType = typeof(bool);	 
					
		 			cellst = arg_fgrid.Styles.Add("TIME_MASK");
					cellst.DataType = typeof(string);		 
					cellst.EditMask = "00:00";
		
					cellst = arg_fgrid.Styles.Add("TIME_MASK_1");
					cellst.DataType = typeof(string);		 
					cellst.EditMask = "00D00H00M";
		 
					//-------------------------------------------------
 
					for(int i = 1; i < dt_ret.Rows.Count + 1; i++)
					{

 
						switch(dt_ret.Rows[i - 1].ItemArray[(int)COM.TBSCM_TABLE.IxCELLTYPE].ToString())				// Cell Type
						{
							case "TEXT":
								arg_fgrid.Rows[i].Style = arg_fgrid.Styles["TEXT"];
								break; 
						 
							case "CHECKBOX":
								arg_fgrid.Rows[i].Style = arg_fgrid.Styles["CHECKBOX"];
								break;

							 

						}

						arg_fgrid.Rows[(int)ClassLib.TBSPB_WORK_CAL.IxTM_START_WK].Style = arg_fgrid.Styles["TIME_MASK"];
						arg_fgrid.Rows[(int)ClassLib.TBSPB_WORK_CAL.IxTM_END_WK].Style = arg_fgrid.Styles["TIME_MASK"];
						arg_fgrid.Rows[(int)ClassLib.TBSPB_WORK_CAL.IxOVERTIME].Style = arg_fgrid.Styles["TIME_MASK_1"];
 
						arg_fgrid.AllowSorting = AllowSortingEnum.None;

						arg_fgrid.Rows[i].AllowEditing = Convert.ToBoolean(dt_ret.Rows[i - 1].ItemArray[(int)COM.TBSCM_TABLE.IxLOCK_YN]);    // 칼럼 에디터 가능 여부
						arg_fgrid.Rows[i].Visible = Convert.ToBoolean(dt_ret.Rows[i - 1].ItemArray[(int)COM.TBSCM_TABLE.IxVISIBLE_YN]);			// 칼럼 visible 
 
						
						arg_fgrid[i, 0] = dt_ret.Rows[i - 1].ItemArray[(int)COM.TBSCM_TABLE.IxCOL_NAME].ToString();					// 테이블 칼럼명
						arg_fgrid[i, 1] = dt_ret.Rows[i - 1].ItemArray[(int)COM.TBSCM_TABLE.IxHEAD_DESC1].ToString();					// 상단
 
 

						

					} //end for


					
					arg_fgrid.AutoSizeCols();
					//arg_fgrid.ExtendLastCol = true;		// 그리드 끝에 빈공간없이 last column에 맞춤

					arg_fgrid.SelectionMode = SelectionModeEnum.ListBox;  // 비연속 멀티 행 선택 가능
						 
				} //end if	
 
 

				Hashtable Imgmap = new Hashtable(); 
				Imgmap.Clear();

				Imgmap.Add("I", img_Action.Images[0]); 
				Imgmap.Add("D", img_Action.Images[1]);
				Imgmap.Add("U", img_Action.Images[2]);

				arg_fgrid.Rows[0].ImageMap = Imgmap;
				arg_fgrid.Rows[0].ImageAndText = false;
				 

			} //end try 
			 	
			catch (Exception ex)
			{
				MessageBox.Show( ex.Message.ToString(),"Set_Grid_Change",MessageBoxButtons.OK,MessageBoxIcon.Error);
				
			}


		}




		/// <summary>
		/// Save_FlexGrid_Change : 그리드에 있는 내용을 저장
		/// </summary>
		/// <param name="arg_proc_name">프로세스 이름</param>
		/// <param name="arg_fgrid">대상 그리드</param>
		/// <returns>정상 : true , 오류 : false </returns>
		private bool Save_FlexGrid_Change(string arg_proc_name, C1FlexGrid arg_fgrid)
		{
			int row_ct = arg_fgrid.Rows.Count - 1;		// 칼럼의 수
			int col_fixed = arg_fgrid.Cols.Fixed;		// 그리드 고정행 값
			int save_ct =0 ;							// 저장 행 수

			int i;
			int para_ct =0;								// 파라미터 값의 저장 배열의 수
			int row,col;

			try
			{
				MyOraDB.ReDim_Parameter(row_ct);
				MyOraDB.Process_Name = arg_proc_name;

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < row_ct; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + arg_fgrid[i, 0].ToString(); 
				}

				// 파라미터의 데이터 Type
				for(i = 0; i < row_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar  ; 
				}
	
				// 저장 행 수 구하기
				for(i = col_fixed ; i < arg_fgrid.Cols.Count; i++)
				{
					if(arg_fgrid[0, i].ToString() != "")
					{
						save_ct += 1;
					}
				}
			
				// 파라미터 값에 저장할 배열
				MyOraDB.Parameter_Values  = new string[row_ct * save_ct ];


				// 각 행의 변경값 Setting
				for(col = col_fixed; col < arg_fgrid.Cols.Count ; col++)
				{
					if(arg_fgrid[0, col].ToString() != "")
					{ 
						MyOraDB.Parameter_Values[para_ct] = "U";
                        para_ct ++;

						for(row = 1; row < row_ct ; row++)	// 각 열의 값 Setting
						{
						
							// 데이터값 설정
							if(arg_fgrid.Rows[row].Style.DataType != null
								&& arg_fgrid.Rows[row].DataType.Equals(typeof(bool)) )
							{
								if(arg_fgrid[row, col] == null) arg_fgrid[row, col] = false ;
								MyOraDB.Parameter_Values[para_ct] = (arg_fgrid[row, col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							} 
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (arg_fgrid[row, col] == null) ? "" : arg_fgrid[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
				MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_FlexGird_Change",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
  
		}



 



		#endregion 

		#region 이벤트 처리


		#region 공통이벤트


		private void obar_Main_SelectedPageChanged(object sender, System.EventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
					 
				    tbtn_New.Enabled = true;
					tbtn_Search.Enabled = true;
					tbtn_Save.Enabled = true;
					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Delete.Enabled = true; 

					break;

				case "obarpg_Shift": 
					 
					tbtn_New.Enabled = true;
					tbtn_Search.Enabled = true;
					tbtn_Save.Enabled = true;
					tbtn_Append.Enabled = true;
					tbtn_Insert.Enabled = true;
					tbtn_Delete.Enabled = true; 

					break; 

				case "obarpg_WorkCal": 
					    
					tbtn_New.Enabled = true;
					tbtn_Search.Enabled = true;
					tbtn_Save.Enabled = true;
					tbtn_Append.Enabled = false;
					tbtn_Insert.Enabled = false;
					tbtn_Delete.Enabled = false;
 
					break;
 
			}


		}


	
	

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
					  
					//cmb_HCalType.SelectedIndex = -1;

					fgrid_Holiday.Rows.Count = fgrid_Holiday.Rows.Fixed;
 
					break;

				case "obarpg_Shift": 
					  
					//cmb_SShiftType.SelectedIndex = -1;

					fgrid_Shift.Rows.Count = fgrid_Shift.Rows.Fixed;

					txt_SType.Text = "";
					txt_STypeName.Text = "";
					txt_SWeekDay.Text = "";
					txt_SShiftNo.Text = "";
					txt_StWeekDay.Text = "";
					txt_STmStartWk.Text = "";
					txt_SEndWeekDay.Text = "";
					txt_STmEndWk.Text = "";
					chk_SUseYN.Checked = false;
					chk_SShiftYN.Checked = false;
					chk_SOverTimeYN.Checked = false;
					txt_SOverTime.Text = "";
					txt_SRemarks.Text = "";

					break; 

				case "obarpg_WorkCal": 
					     
					//cmb_WCalType.SelectedIndex = -1;
					//cmb_WShiftType.SelectedIndex = -1; 

					//dpick_FromYMD.Text = "";
					//dpick_ToYMD.Text = "";
					
					fgrid_WorkCal.Rows.Count = fgrid_WorkCal.Rows.Fixed;

					break;
 
			}

		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			DataTable dt_ret;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
					 
					if(cmb_HFactory.SelectedIndex == -1 || cmb_HCalType.SelectedIndex == -1
						|| cmb_HFromYear.SelectedIndex == -1 || cmb_HToYear.SelectedIndex == -1 ) return; 

					dt_ret = Select_SPB_HOLIDAY();
					Display_Grid(dt_ret, fgrid_Holiday);

					break;

				case "obarpg_Shift": 
					 
					if(cmb_SFactory.SelectedIndex == -1 || cmb_SShiftType.SelectedIndex == -1) return;

					dt_ret = Select_SPB_SHIFT();
					Display_Grid(dt_ret, fgrid_Shift);

					break; 

				case "obarpg_WorkCal": 
					   
					if(cmb_WFactory.SelectedIndex == -1 || cmb_WCalType.SelectedIndex == -1  || cmb_WShiftType.SelectedIndex == -1) return;

					dt_ret = Select_SPB_WORK_CAL();
					Display_Grid(dt_ret, fgrid_WorkCal);

					break; 
			}

		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
					
			DataTable dt_ret; 
			DialogResult message_result;
			int iu_count = 0;
			bool delay_mps_yn = false; 
			bool save_flag = false;

			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
 

					//행 수정 상태 해제
					fgrid_Holiday.Select(fgrid_Holiday.Selection.r1, 0, fgrid_Holiday.Selection.r1, fgrid_Holiday.Cols.Count-1, false);
 

					for(int i = fgrid_Holiday.Rows.Fixed; i < fgrid_Holiday.Rows.Count; i++)
					{
						if(fgrid_Holiday[i, 0] == null || fgrid_Holiday[i, 0].ToString() == "" || fgrid_Holiday[i, 0].ToString() == "U") continue;
						iu_count++;
					}

					if(iu_count == 0)
					{
						delay_mps_yn = false;
					}
					else
					{
						message_result = MessageBox.Show("Do you want to delay on MPS ?", "", MessageBoxButtons.YesNo);

						if(message_result == DialogResult.No)
						{
							MessageBox.Show("Holiday save only");
							delay_mps_yn = false;
						}
						else
						{
							delay_mps_yn = true;
						}

					}
					 
					save_flag = Save_SPB_HOLIDAY(delay_mps_yn);

					if(!save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						break;
					}
					else
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 
						dt_ret = Select_SPB_HOLIDAY();
						Display_Grid(dt_ret, fgrid_Holiday); 
						
					}
 

					break;

				case "obarpg_Shift": 
					 
					//행 수정 상태 해제
					fgrid_Shift.Select(fgrid_Shift.Selection.r1, 0, fgrid_Shift.Selection.r1, fgrid_Shift.Cols.Count-1, false);
   
					MyOraDB.Save_FlexGird("PKG_SPB_WORKCAL.SAVE_SPB_SHIFT", fgrid_Shift);
 
					dt_ret = Select_SPB_SHIFT();
					Display_Grid(dt_ret, fgrid_Shift);


//					///////////////////////////////////////////////////////////////////
//					//수정 사항이 한건이라도 있으면 월력 반영 여부 확인
//
//					if(cmb_SFactory.SelectedIndex == -1 || cmb_SShiftType.SelectedIndex == -1) return;
//
////					if(save_data_row > 0)
////					{
//					message_result = MessageBox.Show("Do you want to reset work calendar ?", "", MessageBoxButtons.YesNo);
//
//					if(message_result == DialogResult.Yes)
//					{
//						Pop_SetWorkCal pop_form = new Pop_SetWorkCal(); 
//						ClassLib.ComVar.Parameter_PopUp = new string[] {((int)PopLoadFlag.FromShift).ToString(),
//																		   cmb_SFactory.SelectedValue.ToString(), 
//																		   cmb_SShiftType.SelectedValue.ToString()};
//						pop_form.ShowDialog();  
//					}
//
////					}


					break; 

				case "obarpg_WorkCal": 
					 
					//행 수정 상태 해제
					fgrid_WorkCal.Select(fgrid_WorkCal.Selection.r1, 0, fgrid_WorkCal.Selection.r1, fgrid_WorkCal.Cols.Count-1, false);
    
					for(int i = fgrid_WorkCal.Rows.Fixed; i < fgrid_WorkCal.Rows.Count; i++)
					{
						if(fgrid_WorkCal[i, 0] == null || fgrid_WorkCal[i, 0].ToString() == "") continue;  // || fgrid_WorkCal[i, 0].ToString() == "U") continue;
						iu_count++;
					}

					if(iu_count == 0)
					{
						delay_mps_yn = false;
					}
					else
					{
						message_result = MessageBox.Show("Do you want to delay on MPS ?", "", MessageBoxButtons.YesNo);

						if(message_result == DialogResult.No)
						{
							MessageBox.Show("Holiday save only");
							delay_mps_yn = false;
						}
						else
						{
							delay_mps_yn = true;
						}

					}
					 
					save_flag = Save_SPB_WORK_CAL(delay_mps_yn);

					if(!save_flag)
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
						break;
					}
					else
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this); 
						dt_ret = Select_SPB_WORK_CAL();
						Display_Grid(dt_ret, fgrid_WorkCal); 
						
					}

					

					break; 
			}


		}

		private void tbtn_Append_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":

					fgrid_Holiday.Add_Row(fgrid_Holiday.Rows.Count - 1);

					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxFACTORY] = cmb_HFactory.SelectedValue.ToString();
					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_TYPE] = cmb_HCalType.SelectedValue.ToString();
					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_NAME] = cmb_HCalType.Columns[1].Text;
					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_YN] = "TRUE";
					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_START_HOLI] = "00:00";
					fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_END_HOLI] = "00:00";

					break;

				case "obarpg_Shift": 

					fgrid_Shift.Add_Row(fgrid_Shift.Rows.Count - 1); 

					fgrid_Shift[fgrid_Shift.Rows.Count - 1, (int)ClassLib.TBSPB_SHIFT.IxFACTORY] = cmb_SFactory.SelectedValue.ToString();
					fgrid_Shift[fgrid_Shift.Rows.Count - 1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_TYPE] = cmb_SShiftType.SelectedValue.ToString();
					fgrid_Shift[fgrid_Shift.Rows.Count - 1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_DESC] = cmb_SShiftType.Columns[1].Text;
					fgrid_Shift[fgrid_Shift.Rows.Count - 1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_NO] = _CommonShiftNo;
					fgrid_Shift[fgrid_Shift.Rows.Count - 1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_YN] = _CommonShiftYN;

					break; 

				case "obarpg_WorkCal": 
					    
					break; 
			}

		}

		private void tbtn_Insert_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
					 
					fgrid_Holiday.Add_Row(fgrid_Holiday.Selection.r1);

					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxFACTORY] = cmb_HFactory.SelectedValue.ToString();
					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_TYPE] = cmb_HCalType.SelectedValue.ToString();
					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_NAME] = cmb_HCalType.Columns[1].Text;
					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_YN] = "TRUE";
					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_START_HOLI] = "00:00";
					fgrid_Holiday[fgrid_Holiday.Selection.r1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_END_HOLI] = "00:00";

					break;

				case "obarpg_Shift": 
					 
					fgrid_Shift.Add_Row(fgrid_Shift.Selection.r1); 

					fgrid_Shift[fgrid_Shift.Selection.r1, (int)ClassLib.TBSPB_SHIFT.IxFACTORY] = cmb_SFactory.SelectedValue.ToString();
					fgrid_Shift[fgrid_Shift.Selection.r1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_TYPE] = cmb_SShiftType.SelectedValue.ToString();
					fgrid_Shift[fgrid_Shift.Selection.r1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_DESC] = cmb_SShiftType.Text;
					fgrid_Shift[fgrid_Shift.Selection.r1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_NO] = _CommonShiftNo;
					fgrid_Shift[fgrid_Shift.Selection.r1, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_YN] = _CommonShiftYN; 

					break; 

				case "obarpg_WorkCal": 
					    
					break;
 
			}

		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			switch(obar_Main.SelectedPage.Name)
			{
				case "obarpg_Holiday":
					 
					fgrid_Holiday.Delete_Row(); 

					int sel_r1 = fgrid_Holiday.Selection.r1;
					int sel_r2 = fgrid_Holiday.Selection.r2;
			
					int start_row, end_row; 

					start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
					end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

					for(int i = start_row; i <= end_row; i++)
					{
						if (fgrid_Holiday[i, 0].ToString() == "D") fgrid_Holiday[i, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_YN] = "FALSE";	 
					} 

					break;

				case "obarpg_Shift": 
					 
					fgrid_Shift.Delete_Row(); 

					break; 

				case "obarpg_WorkCal": 
					    
					break; 
			}

		}


		private void fgrid_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			COM.FSP src = sender as COM.FSP; 
 
			if ((src.Rows.Fixed > 0) && (src.Row >= src.Rows.Fixed))
			{
				if(src.Cols[src.Col].DataType == typeof(bool))
				{
					src.Buffer_CellData = "";
				}
				else
				{
					src.Buffer_CellData = (src[src.Row, src.Col] == null) ? "" : src[src.Row, src.Col].ToString();
				}
			}
		}


		private void fgrid_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			try
			{
				COM.FSP src = sender as COM.FSP; 

				src.Update_Row();


				if(src.Equals(fgrid_Shift) )
				{
					CellStyle cellst; 
					int selrow = src.Selection.r1; 

					//overtime_yn = 'Y' 면 overtime cell type 주기
					if(Convert.ToBoolean(src[selrow, (int)ClassLib.TBSPB_SHIFT.IxOVERTIME_YN].ToString()) )
					{
						cellst = src.Styles.Add("TIME_MASK_1");
						cellst.DataType = typeof(string);		 
						cellst.EditMask = "00D00H00M";
 
						src.Cols[(int)ClassLib.TBSPB_SHIFT.IxOVERTIME].Style = src.Styles["TIME_MASK_1"];

					}
					else
					{
						src.Cols[(int)ClassLib.TBSPB_SHIFT.IxOVERTIME].Style.Clear();
						src[selrow, (int)ClassLib.TBSPB_SHIFT.IxOVERTIME] = "";
					}
				}

			}
			catch
			{
			}

		}

		 
	

		#endregion
 
		#region 휴일등록


		private void cmb_HFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_HFactory.SelectedIndex == -1) return;
		
			// cal_type
			dt_ret = Select_SPB_CAL_TYPE_CMB(cmb_HFactory.SelectedValue.ToString()); 
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_HCalType, 0, 1);

			if(cmb_HCalType.ListCount == 0) 
			{
				txt_HCalTypeCd.Text = "";
				txt_HCalTypeName.Text = "";

				fgrid_Holiday.Rows.Count = fgrid_Shift.Rows.Fixed;

				return;
			}

			cmb_HCalType.SelectedValue = ClassLib.ComVar.CalType;

			txt_HCalTypeCd.Text = cmb_HCalType.SelectedValue.ToString();
			txt_HCalTypeName.Text = cmb_HCalType.Columns[1].Text;

				
			// year
			Set_Year(); 


		}


		private void cmb_HFromYear_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				cmb_HToYear.SelectedValue = cmb_HFromYear.SelectedValue.ToString();
			}
			catch
			{
			}
		}

		private void cmb_HToYear_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt_ret;
	
				if(cmb_HFactory.SelectedIndex == -1 || cmb_HCalType.SelectedIndex == -1
					|| cmb_HFromYear.SelectedIndex == -1 || cmb_HToYear.SelectedIndex == -1 ) return;
	
//				monthCalendar.SelectionStart.Year = cmb_HToYear.SelectedValue.ToString(); 
//				monthCalendar.SelectionStart.Month = System.DateTime.Now.Month.ToString();
//				monthCalendar.SelectionStart.Day = System.DateTime.Now.Day.ToString(); 


				dt_ret = Select_SPB_HOLIDAY();
				Display_Grid(dt_ret, fgrid_Holiday);
			}
			catch
			{
			}
		}


		/// <summary>
		/// Set_Year : Year 설정 (현재 Year +- 5)
		/// </summary>
		private void Set_Year()
		{
			try
			{
				string year = System.DateTime.Now.Year.ToString();
			
				cmb_HFromYear.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 
				cmb_HToYear.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
				cmb_HFromYear.AddItemTitles("Code"); 
				cmb_HToYear.AddItemTitles("Code"); 
				cmb_HFromYear.ClearItems(); 
				cmb_HToYear.ClearItems(); 

				cmb_HFromYear.ValueMember = "Code";
				cmb_HToYear.ValueMember = "Code";
			 
				for(int i = 5; i >= 0; i--) 
				{
					cmb_HFromYear.AddItem(Convert.ToString((Convert.ToInt32(year) + i)) ); 
					cmb_HToYear.AddItem(Convert.ToString((Convert.ToInt32(year) + i)) ); 
				} 
 
				for(int i = 1; i < 5; i++) 
				{
					cmb_HFromYear.AddItem(Convert.ToString((Convert.ToInt32(year) - i)) ); 
					cmb_HToYear.AddItem(Convert.ToString((Convert.ToInt32(year) - i)) ); 
				}

				
				cmb_HFromYear.SelectedValue = year;
				 
			}
			catch
			{
			}
		}



		private void cmb_HCalType_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			DataTable dt_ret;
//
//			if(cmb_HFactory.SelectedIndex == -1 || cmb_HCalType.SelectedIndex == -1
//				|| cmb_HFromYear.SelectedIndex == -1 || cmb_HToYear.SelectedIndex == -1 ) return;
//
//			dt_ret = Select_SPB_HOLIDAY();
//			Display_Grid(dt_ret, fgrid_Holiday);
		}
 

			
		private void btn_PopCalType_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopCalType.ImageIndex = 5;
		}


		private void btn_PopCalType_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopCalType.ImageIndex = 4;
		}


		private void btn_PopCalType_Click(object sender, System.EventArgs e)
		{
		
			DataTable dt_ret;

			Pop_SetType pop_form = new Pop_SetType();
  
			if(cmb_HFactory.SelectedIndex == -1) return;

			if(cmb_HCalType.SelectedIndex == -1)
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] {((int)PopLoadFlag.FromHoliday).ToString(), 
																   cmb_HFactory.SelectedValue.ToString(), 
																   "", ""};
			}
			else
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] {((int)PopLoadFlag.FromHoliday).ToString(),
																   cmb_HFactory.SelectedValue.ToString(), 
																   cmb_HCalType.Columns[0].Text, cmb_HCalType.Columns[1].Text};
			}
 
			
			pop_form.ShowDialog(); 


			//ClassLib.ComVar.Parameter_PopUp[] = {타입, 설명, 팝업창 클로즈 이벤트(확인, 삭제, 취소)}
 	 
			switch(ClassLib.ComVar.Parameter_PopUp[2])
			{
				case "Save": 

//							for(int i = 0; i <= cmb_HCalType.ListCount; i++)
//							{
//								if(cmb_HCalType.Columns[0].CellText(i) == ClassLib.ComVar.Parameter_PopUp[0]) 
//								{
//									return;
//								}
//								else
//								{
////									//cmb_HCalType 새로고침
////									cmb_HFactory_SelectedValueChanged(null, null);
////
////									cmb_HCalType.AddItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" + ClassLib.ComVar.Parameter_PopUp[1]);
////									cmb_HCalType.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];
//								}
//
//							}

//							//cmb_HCalType 새로고침
//							cmb_HFactory_SelectedValueChanged(null, null);

					dt_ret = Select_SPB_CAL_TYPE_CMB(cmb_HFactory.SelectedValue.ToString()); 
					ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_HCalType, 0, 1);

					cmb_HCalType.AddItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" + ClassLib.ComVar.Parameter_PopUp[1]);
					cmb_HCalType.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];

					

					break;

				case "Delete":
					fgrid_Holiday.Rows.Count = fgrid_Holiday.Rows.Fixed; 

					//cmb_SShift 새로고침
					cmb_HFactory_SelectedValueChanged(null, null);
					
					break;

				case "Cancel":
					break;

			} // end switch 
 

		 


		}



		private void monthCalendar_DateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
		{
			string seldate = "";
			int findrow = 0;

			try
			{
				//seldate = e.Start.Month.ToString().PadLeft(2, '0') + e.Start.Day.ToString().PadLeft(2, '0');
				seldate = e.Start.Date.ToString("yyyyMMdd");
	
				findrow = fgrid_Holiday.FindRow(seldate, fgrid_Holiday.Rows.Fixed, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_CD, false, true, false);
				
				//중복데이터 있음
				if(findrow != -1)
				{
					//ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSelect, this);
					MessageBox.Show("Duplicate Data");
					return;
				}

				fgrid_Holiday.Add_Row(fgrid_Holiday.Rows.Count - 1);

				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxFACTORY] = cmb_HFactory.SelectedValue.ToString();
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_TYPE] = cmb_HCalType.SelectedValue.ToString();
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxCAL_NAME] = cmb_HCalType.Columns[1].Text;
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_YN] = "TRUE";
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_START_HOLI] = "00:00";
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxTM_END_HOLI] = "00:00";
				fgrid_Holiday[fgrid_Holiday.Rows.Count - 1, (int)ClassLib.TBSPB_HOLIDAY.IxHOLI_CD] = seldate; 
					 
			}
			catch
			{
			}
		}
		

		#endregion 

		#region 교대등록

		private void cmb_SFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_SFactory.SelectedIndex == -1) return;
			
				dt_ret = Select_SPB_SHIFT_CMB(cmb_SFactory.SelectedValue.ToString()); 
				ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_SShiftType, 0, 1);

				if(cmb_SShiftType.ListCount == 0) 
				{
					txt_SShiftType.Text = "";
					txt_SShiftTypeName.Text = "";

					fgrid_Shift.Rows.Count = fgrid_Shift.Rows.Fixed;

					return;
				}

				cmb_SShiftType.SelectedValue = ClassLib.ComVar.ShiftType;

				txt_SShiftType.Text = cmb_SShiftType.SelectedValue.ToString();
				txt_SShiftTypeName.Text = cmb_SShiftType.Columns[1].Text;
			}
			catch
			{
			}

		}


		
		private void cmb_SShiftType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_SFactory.SelectedIndex == -1 || cmb_SShiftType.SelectedIndex == -1) return;

				dt_ret = Select_SPB_SHIFT();
				Display_Grid(dt_ret, fgrid_Shift);
			}
			catch
			{
			}
		}

		

		private void fgrid_Shift_Click(object sender, System.EventArgs e)
		{
		
			int sel_row = fgrid_Shift.Selection.r1;

			try
			{
				
				if(sel_row >= fgrid_Shift.Rows.Fixed)
				{
					txt_SType.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_TYPE].ToString();
					txt_STypeName.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_DESC].ToString();
					txt_SWeekDay.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxWEEKDAY].ToString();
					txt_SShiftNo.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_NO].ToString();
					txt_StWeekDay.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxST_WEEKDAY].ToString();
					txt_STmStartWk.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxTM_START_WK].ToString();
					txt_SEndWeekDay.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxEND_WEEKDAY].ToString();
					txt_STmEndWk.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxTM_END_WK].ToString(); 
					chk_SUseYN.Checked = Convert.ToBoolean(fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxUSE_YN]);
					chk_SShiftYN.Checked = Convert.ToBoolean(fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxSHIFT_YN]);
					chk_SOverTimeYN.Checked = Convert.ToBoolean(fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxOVERTIME_YN]);
					txt_SOverTime.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxOVERTIME].ToString(); 
					txt_SRemarks.Text = fgrid_Shift[sel_row, (int)ClassLib.TBSPB_SHIFT.IxREMARKS].ToString();
 
				}


			}
			catch 
			{
				//MessageBox.Show(ex.Message.ToString(),"fgrid_Shift_Click",MessageBoxButtons.OK,MessageBoxIcon.Error);
				return;
			}

			

		}

		private void btn_PopShiftType_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopShiftType.ImageIndex = 5;
		}

		private void btn_PopShiftType_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_PopShiftType.ImageIndex = 4;
		}

		private void btn_PopShiftType_Click(object sender, System.EventArgs e)
		{
			 

			DataTable dt_ret;

			Pop_SetType pop_form = new Pop_SetType();
  
			if(cmb_SFactory.SelectedIndex == -1) return;

			if(cmb_SShiftType.SelectedIndex == -1)
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] {((int)PopLoadFlag.FromShift).ToString(), 
																   cmb_SFactory.SelectedValue.ToString(), 
																   "", ""};
			}
			else
			{
				ClassLib.ComVar.Parameter_PopUp = new string[] {((int)PopLoadFlag.FromShift).ToString(),
																   cmb_SFactory.SelectedValue.ToString(), 
																   cmb_SShiftType.Columns[0].Text, cmb_SShiftType.Columns[1].Text};
			}
 
			
			pop_form.ShowDialog(); 


			//ClassLib.ComVar.Parameter_PopUp[] = {타입, 설명, 팝업창 클로즈 이벤트(확인, 삭제, 취소)}
 	 
			switch(ClassLib.ComVar.Parameter_PopUp[2])
			{
				case "Save": 
 
					dt_ret = Select_SPB_SHIFT_CMB(cmb_SFactory.SelectedValue.ToString()); 
					ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_SShiftType, 0, 1); 

					cmb_SShiftType.AddItem(ClassLib.ComVar.Parameter_PopUp[0] + ";" + ClassLib.ComVar.Parameter_PopUp[1]);
					cmb_SShiftType.SelectedValue = ClassLib.ComVar.Parameter_PopUp[0];

					

					break;

				case "Delete":
					fgrid_Shift.Rows.Count = fgrid_Shift.Rows.Fixed; 

					//cmb_SShift 새로고침
					cmb_SFactory_SelectedValueChanged(null, null);
					
					break;

				case "Cancel":
					break;

			} // end switch 
 


		}



		#endregion 

		#region 월력생성

		private void cmb_WFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			if(cmb_WFactory.SelectedIndex == -1) return;
			 
			dt_ret = Select_SPB_CAL_TYPE_CMB(cmb_WFactory.SelectedValue.ToString()); 
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_WCalType, 0, 1);


			dt_ret = Select_SPB_SHIFT_CMB(cmb_WFactory.SelectedValue.ToString()); 
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_WShiftType, 0, 1);


			cmb_WCalType.SelectedValue = ClassLib.ComVar.CalType;
			cmb_WShiftType.SelectedValue = ClassLib.ComVar.ShiftType;

			txt_WCalType.Text = cmb_WCalType.SelectedValue.ToString();
			txt_WCalTypeName.Text = cmb_WCalType.Columns[1].Text;
			txt_WShiftType.Text = cmb_WShiftType.SelectedValue.ToString();
			txt_WShiftTypeName.Text = cmb_WShiftType.Columns[1].Text;

			//---------------------------------------------------
			dt_ret = Select_SPB_CAL_DATE();
			txt_CalFromDate.Text = dt_ret.Rows[0].ItemArray[0].ToString();
			txt_CalToDate.Text = dt_ret.Rows[0].ItemArray[1].ToString(); 
			txt_WCalFromDate.Text = dt_ret.Rows[0].ItemArray[2].ToString();
			txt_WCalToDate.Text = dt_ret.Rows[0].ItemArray[3].ToString();

		}

		private void btn_CreateWorkCal_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateWorkCal.ImageIndex = 1;
		}

		private void btn_CreateWorkCal_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateWorkCal.ImageIndex = 0;
		} 
		

		private void btn_CreateWorkCal_Click(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				Save_CreateWorkCal();

				//---------------------------------------------------
				dt_ret = Select_SPB_CAL_DATE();
				txt_CalFromDate.Text = dt_ret.Rows[0].ItemArray[0].ToString();
				txt_CalToDate.Text = dt_ret.Rows[0].ItemArray[1].ToString(); 
				txt_WCalFromDate.Text = dt_ret.Rows[0].ItemArray[2].ToString();
				txt_WCalToDate.Text = dt_ret.Rows[0].ItemArray[3].ToString();
			}
			catch
			{
			}
		}


		private void dpick_FromYMD_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_FromYMD.CustomFormat = "yyyyMMdd"; 
		}

		private void dpick_ToYMD_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_ToYMD.CustomFormat = "yyyyMMdd"; 
		}

		private void btn_CreateDate_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_CreateDate.ImageIndex = 1;
		}


		private void btn_CreateDate_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{	
			btn_CreateDate.ImageIndex = 0;
		}

		private void btn_CreateDate_Click(object sender, System.EventArgs e)
		{
			Pop_CreateDate pop_form = new Pop_CreateDate(); 
			pop_form.ShowDialog(); 

		}


		private void fgrid_WorkCal_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			int sel_row = fgrid_WorkCal.Selection.r1;

			try
			{
				fgrid_WorkCal.Update_Row();

				//휴일이면
				if(Convert.ToBoolean(fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxHOLI_YN].ToString()) ) 
				{
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxSHIFT_NO] = "0";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxSHIFT_YN] = "FALSE";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxTM_START_WK] = "00:00";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxTM_END_WK] = "00:00";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxOVERTIME_YN] = "N";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxOVERTIME] = "";
					
				}
					//휴일이 아니면 무조건 1교대로 세팅
				else
				{
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxSHIFT_NO] = "1";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxSHIFT_YN] = "TRUE";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxTM_START_WK] = _CommonShiftStartTM;
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxTM_END_WK] = _CommonShiftEndTM;
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxOVERTIME_YN] = "N";
					fgrid_WorkCal[sel_row, (int)ClassLib.TBSPB_WORK_CAL.IxOVERTIME] = "";
				}
			}
			catch
			{
			}
		}



		#endregion

 
  

		#endregion
 
		#region DB Connect
 
	 

		/// <summary>
		/// Select_SPB_CAL_TYPE_CMB : Calendar Type 콤보 리스트 
		/// </summary>
		/// <param name="arg_factory"></param>
		private DataTable Select_SPB_CAL_TYPE_CMB(string arg_factory)
		{
		 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_CAL_TYPE_CMB";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
 
		}



		/// <summary>
		/// Select_SPB_HOLIDAY : 휴일코드 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_HOLIDAY()
		{
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_HOLIDAY";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_CAL_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_FROM_YEAR";
			MyOraDB.Parameter_Name[3] = "ARG_TO_YEAR";
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_HFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_HCalType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.Empty_Combo(cmb_HFromYear, " ");
			MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.Empty_Combo(cmb_HToYear, " ");
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}

 

		
		/// <summary>
		/// Select_SPB_SHIFT_CMB : Shift Type 콤보 리스트 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <returns></returns>
		private DataTable Select_SPB_SHIFT_CMB(string arg_factory)
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_SHIFT_CMB";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}


		
		/// <summary>
		/// Select_SPB_SHIFT : 교대타입 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_SHIFT()
		{

			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_SHIFT";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIFT_TYPE";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_SFactory.SelectedValue.ToString();
			MyOraDB.Parameter_Values[1] = cmb_SShiftType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}

  
		/// <summary>
		/// Select_SPB_CAL_DATE : 기본 카렌더 테이블, 월력 테이블에서 Min, Max Date 추출
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_CAL_DATE()
		{

			DataSet ds_ret; 
 
			try
			{
				MyOraDB.ReDim_Parameter(4); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_CAL_DATE";
 
				//02.ARGURMENT명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_CAL_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_SHIFT_TYPE";
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				//03.DATA TYPE
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_WFactory.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[1] = cmb_WCalType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[2] = cmb_WShiftType.SelectedValue.ToString(); 
				MyOraDB.Parameter_Values[3] = "";

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
		/// Save_CreateWorkCal : 월력 생성
		/// </summary>
		private void Save_CreateWorkCal()
		{  

			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(6); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SPB_WORKCAL.INSERT_WORK_CAL";
 
				//02.ARGURMENT명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_CAL_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_SHIFT_TYPE"; 
				MyOraDB.Parameter_Name[3] = "ARG_FROMYMD"; 
				MyOraDB.Parameter_Name[4] = "ARG_TOYMD"; 
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER"; 

				//03.DATA TYPE
				for (int i = 0; i <= 5; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

			
				//04.DATA 정의  
				MyOraDB.Parameter_Values[0] = cmb_WFactory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[1] = cmb_WCalType.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2] = cmb_WShiftType.SelectedValue.ToString();
				MyOraDB.Parameter_Values[3] = dpick_FromYMD.Text;
				MyOraDB.Parameter_Values[4] = dpick_ToYMD.Text;
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Modify_Parameter(true);  
				ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
				//Error 처리
				if(ds_ret == null) 
				{
					MessageBox.Show("Error") ; 
				}
				else
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this); 
				}

			}
			catch
			{
			}
		}



		/// <summary>
		/// Select_SPB_WORK_CAL : 월력 리스트
		/// </summary>
		/// <returns></returns>
		private DataTable Select_SPB_WORK_CAL()
		{

 
			DataSet ds_ret; 
 
			MyOraDB.ReDim_Parameter(6); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SELECT_SPB_WORK_CAL";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_CAL_TYPE"; 
			MyOraDB.Parameter_Name[2] = "ARG_SHIFT_TYPE"; 
			MyOraDB.Parameter_Name[3] = "ARG_FROMYMD"; 
			MyOraDB.Parameter_Name[4] = "ARG_TOYMD"; 
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = cmb_WFactory.SelectedValue.ToString(); 
			MyOraDB.Parameter_Values[1] = cmb_WCalType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[2] = cmb_WShiftType.SelectedValue.ToString();
			MyOraDB.Parameter_Values[3] = dpick_FromYMD.Text;
			MyOraDB.Parameter_Values[4] = dpick_ToYMD.Text;
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 


		}

 

		/// <summary>
		/// Save_SPB_HOLIDAY :
		/// </summary>
		/// <param name="arg_delay_mps_yn"></param>
		/// <returns></returns>
		private bool Save_SPB_HOLIDAY(bool arg_delay_mps_yn)
		{
			int col_ct = fgrid_Holiday.Cols.Count;		 
			int row_fixed = fgrid_Holiday.Rows.Fixed;		 
			int save_ct =0 ;							 

			int i;
			int para_ct =0;								 
			int row,col;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_WORKCAL.SAVE_SPB_HOLIDAY";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_Holiday[0, i].ToString(); 
				} 
				MyOraDB.Parameter_Name[col_ct - 1] = "ARG_DELAY_MPS_YN";

 
				for(i = 0; i < col_ct - 1; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
	 
				for(i = row_fixed ; i < fgrid_Holiday.Rows.Count; i++)
				{
					if(fgrid_Holiday[i, 0].ToString() != "") save_ct += 1; 
				}
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct];

 
				for(row = row_fixed; row < fgrid_Holiday.Rows.Count ; row++)
				{
					if(fgrid_Holiday[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct - 1; col++)	 
						{   
							if(fgrid_Holiday.Cols[col].Style.DataType != null && fgrid_Holiday.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								fgrid_Holiday[row, col] = (fgrid_Holiday[row, col] == null) ? "False" : fgrid_Holiday[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Holiday[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}  
							else if(fgrid_Holiday.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								token = fgrid_Holiday[row,col].ToString().Split(delimiter); 
								MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
							else if(col == (int)ClassLib.TBSPB_HOLIDAY.IxUPD_USER)
							{
								MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;
								para_ct ++;
								MyOraDB.Parameter_Values[para_ct] = (arg_delay_mps_yn ? "Y" : "N");
								para_ct ++;
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_Holiday[row, col] == null) ? "" : fgrid_Holiday[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);		 
				MyOraDB.Exe_Modify_Procedure();			 
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_HOLIDAY",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}

		/// <summary>
		/// Save_SPB_WORK_CAL :
		/// </summary>
		/// <param name="arg_delay_mps_yn"></param>
		/// <returns></returns>
		private bool Save_SPB_WORK_CAL(bool arg_delay_mps_yn)
		{
			int col_ct = fgrid_WorkCal.Cols.Count;		 
			int row_fixed = fgrid_WorkCal.Rows.Fixed;		 
			int save_ct =0 ;							 

			int i;
			int para_ct =0;								 
			int row,col;

			try
			{
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SPB_WORKCAL.UPDATE_SPB_WORK_CAL";
 
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(i = 1; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_WorkCal[0, i].ToString(); 
				} 
				MyOraDB.Parameter_Name[col_ct - 1] = "ARG_DELAY_MPS_YN";

 
				for(i = 0; i < col_ct - 1; i++) MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
	 
				for(i = row_fixed ; i < fgrid_WorkCal.Rows.Count; i++)
				{
					if(fgrid_WorkCal[i, 0].ToString() != "") save_ct += 1; 
				}
			 
				MyOraDB.Parameter_Values  = new string[col_ct * save_ct];

 
				for(row = row_fixed; row < fgrid_WorkCal.Rows.Count ; row++)
				{
					if(fgrid_WorkCal[row, 0].ToString() != "")
					{ 
						for(col = 0; col < col_ct - 1; col++)	 
						{   
							if(fgrid_WorkCal.Cols[col].Style.DataType != null && fgrid_WorkCal.Cols[col].DataType.Equals(typeof(bool)) )
							{ 
								fgrid_WorkCal[row, col] = (fgrid_WorkCal[row, col] == null) ? "False" : fgrid_WorkCal[row, col].ToString();
								MyOraDB.Parameter_Values[para_ct] = (fgrid_WorkCal[row,col].ToString() == "True") ? "Y" : "N"; 

								para_ct ++;
							}  
							else if(fgrid_WorkCal.Cols[col].ComboList.Length != 0)
							{
								char[] delimiter = ":".ToCharArray();
								string[] token = null; 

								token = fgrid_WorkCal[row,col].ToString().Split(delimiter); 
								MyOraDB.Parameter_Values[para_ct] = (token[0] == null) ? "" : token[0].Trim();
 
								para_ct ++;
							}
							else if(col == (int)ClassLib.TBSPB_WORK_CAL.IxUPD_USER)
							{
								MyOraDB.Parameter_Values[para_ct] = ClassLib.ComVar.This_User;
								para_ct ++;
								MyOraDB.Parameter_Values[para_ct] = (arg_delay_mps_yn ? "Y" : "N");
								para_ct ++;
							}
							else
							{
								MyOraDB.Parameter_Values[para_ct] = (fgrid_WorkCal[row, col] == null) ? "" : fgrid_WorkCal[row,col].ToString();
								para_ct ++;
							}			
						} 
					}
				}

				MyOraDB.Add_Modify_Parameter(true);		 
				MyOraDB.Exe_Modify_Procedure();			 
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Save_SPB_WORK_CAL",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}
 
		#endregion
 


		private void Form_PB_WorkCal_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}

		
		

 


	}
}

