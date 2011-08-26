using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Xml;
using System.Reflection;
using C1.Win.C1FlexGrid;
using System.Data.OleDb;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
namespace FlexSQM
{
    /// <summary>
    /// Summary description for Form_MPS_Comp_Out.
    /// </summary>
    public class Form_MPS_Comp_In : COM.SQMWinForm.Form_Top
    {
        public System.Windows.Forms.Panel pnl_Search;
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
        private C1.Win.C1List.C1Combo cmb_Vendor;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1List.C1Combo c1Combo1;
        private System.Windows.Forms.TabControl tab_Content;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Pag_Summary;
        private COM.FSP fgrid_Lot_Size_Mps;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private COM.FSP fgrid_Comp_In;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1List.C1Combo cmbComponent;
        private System.Windows.Forms.TextBox txtComponent;
        private Label label6;
        private C1.Win.C1List.C1Combo cmb_Process;
        private Label label8;
        private C1.Win.C1List.C1Combo cmb_In_Kind;
        private Button btn_Confirm;
        private Button btn_Cancel_Confirm;
        private TextBox txtPlan_Date;
        private TextBox txt_Lot_No;
        private Label label7;
        private C1.Win.C1List.C1Combo cmb_obsid_fr;
        private Label label4;
        private C1.Win.C1List.C1Combo cmb_Line;
        private Label label1;
        private Label lbl_PlanYMD;
        private Label label3;
        private C1.Win.C1List.C1Combo cmb_Style;
        private TextBox txt_Style;
        public C1.Win.C1List.C1Combo cmb_Factory;
        private Label lbl_Factory;
        private Label btn_PopProcess;
        private Button btn_CopyComp;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form_MPS_Comp_In()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            Init_Control();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }


        private const int G_VENDOR_CD = 1;
        private const int G_STYLE_CD = 2;
        private const int G_LOT_NO = 3;
        private const int G_IN_YMD = 4;
        private const int G_SIZE_1 = 5;
        private const int G_SIZE_2 = 6;
        private const int G_SIZE_3 = 7;
        private const int G_SIZE_4 = 8;
        private const int G_SIZE_5 = 9;
        private const int G_SIZE_6 = 10;
        private const int G_SIZE_7 = 11;
        private const int G_SIZE_8 = 12;
        private const int G_SIZE_9 = 13;
        private const int G_SIZE_10 = 14;
        private const int G_SIZE_11 = 15;
        private const int G_SIZE_12 = 16;
        private const int G_SIZE_13 = 17;
        private const int G_SIZE_14 = 18;
        private const int G_SIZE_15 = 19;
        private const int G_SIZE_16 = 20;
        private const int G_SIZE_17 = 21;
        private const int G_SIZE_18 = 22;
        private const int G_SIZE_19 = 23;
        private const int G_SIZE_20 = 24;
        private const int G_SIZE_21 = 25;
        private const int G_SIZE_22 = 26;
        private const int G_SIZE_23 = 27;
        private const int G_SIZE_24 = 28;
        private const int G_SIZE_25 = 29;
        private const int G_SIZE_26 = 30;
        private const int G_SIZE_27 = 31;
        private const int G_SIZE_28 = 32;
        private const int G_SIZE_29 = 33;
        private const int G_SIZE_30 = 34;
        private const int G_SIZE_31 = 35;
        private const int G_SIZE_32 = 36;
        private const int G_SIZE_33 = 37;
        private const int G_SIZE_34 = 38;
        private const int G_SIZE_35 = 39;
        private const int G_SIZE_36 = 40;
        private const int G_SIZE_37 = 41;
        private const int G_SIZE_38 = 42;
        private const int G_SIZE_39 = 43;
        private const int G_SIZE_40 = 44;
        private const int G_TOTAl = 45;
        private const int G_LINE = 46;
        private const int G_COMP = 47;
        private const int G_CONFIRM = 48;
        private const int G_PROCESS = 49;
        private const int G_KIND_IN = 50;
        private const int G_DPO = 51;
        private const int G_DAY_SEQ = 52;





        private void Init_Control()
        {
            DataTable dt_ret;

            // factory
            dt_ret = COM.ComFunction.Select_Factory_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

            dt_ret.Dispose();

            dt_ret = Select_Vendor_List();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Vendor, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Vendor.SelectedValue = " ";

            fgrid_Lot_Size_Mps.Set_Grid("SQM_LOT_SIZE_MPS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Lot_Size_Mps.Set_Action_Image(img_Action);

            fgrid_Comp_In.Set_Grid("SQM_COMP_IN", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
            fgrid_Comp_In.Cols[G_IN_YMD].Style.Format = "yyyy-MM-dd";
            fgrid_Comp_In.Set_Action_Image(img_Action);

            fgrid_Comp_In.Cols[G_SIZE_1].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_2].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_3].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_4].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_5].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_6].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_7].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_8].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_9].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_10].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_11].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_12].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_13].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_14].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_15].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_16].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_17].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_18].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_19].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_20].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_21].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_22].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_23].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_24].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_25].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_26].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_27].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_28].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_29].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_30].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_31].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_32].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_33].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_34].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_35].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_36].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_37].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_38].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_39].Style.Format = "###,###,##0.#";
            fgrid_Comp_In.Cols[G_SIZE_40].Style.Format = "###,###,##0.#";

            dt_ret = SELECT_LINE_INFO();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Line.SelectedIndex = 0;

            dt_ret = ClassLib.ComVar.Select_ComFilterCode(COM.ComVar.This_Factory, "SQM_IN");
            COM.ComCtl.Set_ComboList(dt_ret, cmb_In_Kind, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_In_Kind.SelectedIndex = 0;

            dt_ret = SELECT_PROCESS();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Process, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Process.SelectedIndex = 0;

        }



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MPS_Comp_In));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style65 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style66 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style67 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style68 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style69 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style70 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style71 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style72 = new C1.Win.C1List.Style();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.txtPlan_Date = new System.Windows.Forms.TextBox();
            this.txt_Lot_No = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_obsid_fr = new C1.Win.C1List.C1Combo();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_PlanYMD = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Style = new C1.Win.C1List.C1Combo();
            this.txt_Style = new System.Windows.Forms.TextBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.c1Combo1 = new C1.Win.C1List.C1Combo();
            this.tab_Content = new System.Windows.Forms.TabControl();
            this.Pag_Summary = new System.Windows.Forms.TabPage();
            this.fgrid_Lot_Size_Mps = new COM.FSP();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.fgrid_Comp_In = new COM.FSP();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbComponent = new C1.Win.C1List.C1Combo();
            this.txtComponent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_In_Kind = new C1.Win.C1List.C1Combo();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel_Confirm = new System.Windows.Forms.Button();
            this.btn_PopProcess = new System.Windows.Forms.Label();
            this.btn_CopyComp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            this.tab_Content.SuspendLayout();
            this.Pag_Summary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot_Size_Mps)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp_In)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_In_Kind)).BeginInit();
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
            this.c1CommandHolder1.Commands.Add(this.tbtn_Confirm);
            // 
            // tbtn_New
            // 
            this.tbtn_New.ImageIndex = 5;
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
            // 
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 685);
            this.stbar.Size = new System.Drawing.Size(1024, 24);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(962, 23);
            this.lbl_MainTitle.Text = "Component Incoming";
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
            // c1CommandLink1
            // 
            this.c1CommandLink1.Text = "Add New";
            this.c1CommandLink1.ToolTipText = "Add New";
            // 
            // pnl_Search
            // 
            this.pnl_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Location = new System.Drawing.Point(-2, 86);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1012, 94);
            this.pnl_Search.TabIndex = 36;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.txtPlan_Date);
            this.pnl_SearchImage.Controls.Add(this.txt_Lot_No);
            this.pnl_SearchImage.Controls.Add(this.label7);
            this.pnl_SearchImage.Controls.Add(this.cmb_obsid_fr);
            this.pnl_SearchImage.Controls.Add(this.label4);
            this.pnl_SearchImage.Controls.Add(this.cmb_Line);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_PlanYMD);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style);
            this.pnl_SearchImage.Controls.Add(this.txt_Style);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(996, 78);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // txtPlan_Date
            // 
            this.txtPlan_Date.BackColor = System.Drawing.Color.White;
            this.txtPlan_Date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlan_Date.Enabled = false;
            this.txtPlan_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPlan_Date.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtPlan_Date.Location = new System.Drawing.Point(799, 32);
            this.txtPlan_Date.MaxLength = 100;
            this.txtPlan_Date.Name = "txtPlan_Date";
            this.txtPlan_Date.Size = new System.Drawing.Size(100, 21);
            this.txtPlan_Date.TabIndex = 603;
            // 
            // txt_Lot_No
            // 
            this.txt_Lot_No.BackColor = System.Drawing.Color.White;
            this.txt_Lot_No.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Lot_No.Enabled = false;
            this.txt_Lot_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Lot_No.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Lot_No.Location = new System.Drawing.Point(799, 57);
            this.txt_Lot_No.MaxLength = 100;
            this.txt_Lot_No.Name = "txt_Lot_No";
            this.txt_Lot_No.Size = new System.Drawing.Size(150, 21);
            this.txt_Lot_No.TabIndex = 602;
            this.txt_Lot_No.TextChanged += new System.EventHandler(this.txt_Lot_No_TextChanged);
            // 
            // label7
            // 
            this.label7.ImageIndex = 1;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(3, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 601;
            this.label7.Text = "DPO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_obsid_fr
            // 
            this.cmb_obsid_fr.AddItemSeparator = ';';
            this.cmb_obsid_fr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_obsid_fr.Caption = "";
            this.cmb_obsid_fr.CaptionHeight = 17;
            this.cmb_obsid_fr.CaptionStyle = style1;
            this.cmb_obsid_fr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_obsid_fr.ColumnCaptionHeight = 18;
            this.cmb_obsid_fr.ColumnFooterHeight = 18;
            this.cmb_obsid_fr.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_obsid_fr.ContentHeight = 16;
            this.cmb_obsid_fr.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_obsid_fr.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_obsid_fr.EditorFont = new System.Drawing.Font("Gulim", 9F);
            this.cmb_obsid_fr.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_obsid_fr.EditorHeight = 16;
            this.cmb_obsid_fr.EvenRowStyle = style2;
            this.cmb_obsid_fr.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_obsid_fr.FooterStyle = style3;
            this.cmb_obsid_fr.HeadingStyle = style4;
            this.cmb_obsid_fr.HighLightRowStyle = style5;
            this.cmb_obsid_fr.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_obsid_fr.Images"))));
            this.cmb_obsid_fr.ItemHeight = 15;
            this.cmb_obsid_fr.Location = new System.Drawing.Point(107, 58);
            this.cmb_obsid_fr.MatchEntryTimeout = ((long)(2000));
            this.cmb_obsid_fr.MaxDropDownItems = ((short)(5));
            this.cmb_obsid_fr.MaxLength = 32767;
            this.cmb_obsid_fr.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_obsid_fr.Name = "cmb_obsid_fr";
            this.cmb_obsid_fr.OddRowStyle = style6;
            this.cmb_obsid_fr.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_obsid_fr.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_obsid_fr.SelectedStyle = style7;
            this.cmb_obsid_fr.Size = new System.Drawing.Size(100, 20);
            this.cmb_obsid_fr.Style = style8;
            this.cmb_obsid_fr.TabIndex = 600;
            this.cmb_obsid_fr.SelectedValueChanged += new System.EventHandler(this.cmb_obsid_fr_SelectedValueChanged);
            this.cmb_obsid_fr.PropBag = resources.GetString("cmb_obsid_fr.PropBag");
            // 
            // label4
            // 
            this.label4.ImageIndex = 1;
            this.label4.ImageList = this.img_Label;
            this.label4.Location = new System.Drawing.Point(322, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 599;
            this.label4.Text = "Line";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style9;
            this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Line.ColumnCaptionHeight = 18;
            this.cmb_Line.ColumnFooterHeight = 18;
            this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Line.ContentHeight = 16;
            this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Line.EditorFont = new System.Drawing.Font("Gulim", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.Enabled = false;
            this.cmb_Line.EvenRowStyle = style10;
            this.cmb_Line.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style11;
            this.cmb_Line.HeadingStyle = style12;
            this.cmb_Line.HighLightRowStyle = style13;
            this.cmb_Line.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Line.Images"))));
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(426, 58);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style14;
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style15;
            this.cmb_Line.Size = new System.Drawing.Size(252, 20);
            this.cmb_Line.Style = style16;
            this.cmb_Line.TabIndex = 598;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            // 
            // label1
            // 
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(693, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 597;
            this.label1.Text = "LOT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_PlanYMD
            // 
            this.lbl_PlanYMD.ImageIndex = 1;
            this.lbl_PlanYMD.ImageList = this.img_Label;
            this.lbl_PlanYMD.Location = new System.Drawing.Point(693, 32);
            this.lbl_PlanYMD.Name = "lbl_PlanYMD";
            this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
            this.lbl_PlanYMD.TabIndex = 593;
            this.lbl_PlanYMD.Text = "Plan Date";
            this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.ImageIndex = 1;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(322, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 596;
            this.label3.Text = "Style Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style
            // 
            this.cmb_Style.AccessibleDescription = "";
            this.cmb_Style.AccessibleName = "";
            this.cmb_Style.AddItemSeparator = ';';
            this.cmb_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style.Caption = "";
            this.cmb_Style.CaptionHeight = 17;
            this.cmb_Style.CaptionStyle = style17;
            this.cmb_Style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style.ColumnCaptionHeight = 18;
            this.cmb_Style.ColumnFooterHeight = 18;
            this.cmb_Style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style.ContentHeight = 17;
            this.cmb_Style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style.EditorHeight = 17;
            this.cmb_Style.EvenRowStyle = style18;
            this.cmb_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style.FooterStyle = style19;
            this.cmb_Style.HeadingStyle = style20;
            this.cmb_Style.HighLightRowStyle = style21;
            this.cmb_Style.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Style.Images"))));
            this.cmb_Style.ItemHeight = 15;
            this.cmb_Style.Location = new System.Drawing.Point(498, 32);
            this.cmb_Style.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style.MaxDropDownItems = ((short)(5));
            this.cmb_Style.MaxLength = 32767;
            this.cmb_Style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style.Name = "cmb_Style";
            this.cmb_Style.OddRowStyle = style22;
            this.cmb_Style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style.SelectedStyle = style23;
            this.cmb_Style.Size = new System.Drawing.Size(180, 21);
            this.cmb_Style.Style = style24;
            this.cmb_Style.TabIndex = 595;
            this.cmb_Style.SelectedValueChanged += new System.EventHandler(this.cmb_Style_SelectedValueChanged);
            this.cmb_Style.PropBag = resources.GetString("cmb_Style.PropBag");
            // 
            // txt_Style
            // 
            this.txt_Style.BackColor = System.Drawing.Color.White;
            this.txt_Style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Style.Location = new System.Drawing.Point(426, 32);
            this.txt_Style.MaxLength = 100;
            this.txt_Style.Name = "txt_Style";
            this.txt_Style.Size = new System.Drawing.Size(72, 21);
            this.txt_Style.TabIndex = 594;
            this.txt_Style.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Style_KeyUp);
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(107, 32);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(195, 21);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 592;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(3, 32);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 591;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(979, 24);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(17, 38);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(980, 0);
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
            this.picb_TM.Size = new System.Drawing.Size(772, 32);
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
            this.lbl_SubTitle1.Text = "      LOT Information";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(980, 63);
            this.picb_BR.Name = "picb_BR";
            this.picb_BR.Size = new System.Drawing.Size(16, 16);
            this.picb_BR.TabIndex = 23;
            this.picb_BR.TabStop = false;
            // 
            // picb_BM
            // 
            this.picb_BM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BM.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BM.Image = ((System.Drawing.Image)(resources.GetObject("picb_BM.Image")));
            this.picb_BM.Location = new System.Drawing.Point(144, 62);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(836, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 63);
            this.picb_BL.Name = "picb_BL";
            this.picb_BL.Size = new System.Drawing.Size(168, 20);
            this.picb_BL.TabIndex = 22;
            this.picb_BL.TabStop = false;
            // 
            // picb_ML
            // 
            this.picb_ML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_ML.BackColor = System.Drawing.SystemColors.Window;
            this.picb_ML.Image = ((System.Drawing.Image)(resources.GetObject("picb_ML.Image")));
            this.picb_ML.Location = new System.Drawing.Point(0, 24);
            this.picb_ML.Name = "picb_ML";
            this.picb_ML.Size = new System.Drawing.Size(168, 41);
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
            this.picb_MM.Location = new System.Drawing.Point(160, 24);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(828, 38);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // label2
            // 
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(6, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 536;
            this.label2.Text = "Vendor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style33;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 16;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style34;
            this.cmb_Vendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style35;
            this.cmb_Vendor.HeadingStyle = style36;
            this.cmb_Vendor.HighLightRowStyle = style37;
            this.cmb_Vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Vendor.Images"))));
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(110, 410);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style38;
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style39;
            this.cmb_Vendor.Size = new System.Drawing.Size(224, 20);
            this.cmb_Vendor.Style = style40;
            this.cmb_Vendor.TabIndex = 397;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            // 
            // c1Combo1
            // 
            this.c1Combo1.AddItemSeparator = ';';
            this.c1Combo1.Caption = "";
            this.c1Combo1.CaptionHeight = 17;
            this.c1Combo1.CaptionStyle = style41;
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.ColumnCaptionHeight = 17;
            this.c1Combo1.ColumnFooterHeight = 17;
            this.c1Combo1.ContentHeight = 15;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.c1Combo1.EditorBackColor = System.Drawing.SystemColors.Window;
            this.c1Combo1.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Combo1.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.c1Combo1.EditorHeight = 15;
            this.c1Combo1.EvenRowStyle = style42;
            this.c1Combo1.FooterStyle = style43;
            this.c1Combo1.HeadingStyle = style44;
            this.c1Combo1.HighLightRowStyle = style45;
            this.c1Combo1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1Combo1.Images"))));
            this.c1Combo1.ItemHeight = 15;
            this.c1Combo1.Location = new System.Drawing.Point(0, 0);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.OddRowStyle = style46;
            this.c1Combo1.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.c1Combo1.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.SelectedStyle = style47;
            this.c1Combo1.Size = new System.Drawing.Size(121, 21);
            this.c1Combo1.Style = style48;
            this.c1Combo1.TabIndex = 0;
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            // 
            // tab_Content
            // 
            this.tab_Content.Controls.Add(this.Pag_Summary);
            this.tab_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Content.Location = new System.Drawing.Point(0, 0);
            this.tab_Content.Name = "tab_Content";
            this.tab_Content.SelectedIndex = 0;
            this.tab_Content.Size = new System.Drawing.Size(1016, 224);
            this.tab_Content.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tab_Content.TabIndex = 190;
            // 
            // Pag_Summary
            // 
            this.Pag_Summary.Controls.Add(this.fgrid_Lot_Size_Mps);
            this.Pag_Summary.Location = new System.Drawing.Point(4, 23);
            this.Pag_Summary.Name = "Pag_Summary";
            this.Pag_Summary.Size = new System.Drawing.Size(1008, 197);
            this.Pag_Summary.TabIndex = 0;
            this.Pag_Summary.Text = "MPS Size Daily";
            // 
            // fgrid_Lot_Size_Mps
            // 
            this.fgrid_Lot_Size_Mps.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Lot_Size_Mps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Lot_Size_Mps.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Lot_Size_Mps.Name = "fgrid_Lot_Size_Mps";
            this.fgrid_Lot_Size_Mps.Rows.DefaultSize = 19;
            this.fgrid_Lot_Size_Mps.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Lot_Size_Mps.Size = new System.Drawing.Size(1008, 197);
            this.fgrid_Lot_Size_Mps.StyleInfo = resources.GetString("fgrid_Lot_Size_Mps.StyleInfo");
            this.fgrid_Lot_Size_Mps.TabIndex = 180;
            this.fgrid_Lot_Size_Mps.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Lot_Size_Mps_AfterScroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tab_Content);
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 224);
            this.panel2.TabIndex = 182;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1008, 237);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MPS Lot Size Daily";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Location = new System.Drawing.Point(0, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 216);
            this.panel3.TabIndex = 183;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 216);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 180;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1008, 189);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Incoming Component";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.fgrid_Comp_In);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1008, 189);
            this.panel4.TabIndex = 182;
            // 
            // fgrid_Comp_In
            // 
            this.fgrid_Comp_In.ColumnInfo = "7,1,0,0,0,95,Columns:";
            this.fgrid_Comp_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Comp_In.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_Comp_In.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgrid_Comp_In.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Comp_In.Name = "fgrid_Comp_In";
            this.fgrid_Comp_In.Rows.DefaultSize = 19;
            this.fgrid_Comp_In.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgrid_Comp_In.Size = new System.Drawing.Size(1008, 189);
            this.fgrid_Comp_In.StyleInfo = resources.GetString("fgrid_Comp_In.StyleInfo");
            this.fgrid_Comp_In.TabIndex = 181;
            this.fgrid_Comp_In.Click += new System.EventHandler(this.fgrid_Comp_In_Click);
            this.fgrid_Comp_In.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Comp_Out_AfterEdit);
            this.fgrid_Comp_In.AfterScroll += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgrid_Comp_Out_AfterScroll);
            // 
            // label5
            // 
            this.label5.ImageIndex = 1;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(366, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 588;
            this.label5.Text = "Component";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbComponent
            // 
            this.cmbComponent.AccessibleDescription = "";
            this.cmbComponent.AccessibleName = "";
            this.cmbComponent.AddItemSeparator = ';';
            this.cmbComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmbComponent.Caption = "";
            this.cmbComponent.CaptionHeight = 17;
            this.cmbComponent.CaptionStyle = style49;
            this.cmbComponent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbComponent.ColumnCaptionHeight = 18;
            this.cmbComponent.ColumnFooterHeight = 18;
            this.cmbComponent.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbComponent.ContentHeight = 17;
            this.cmbComponent.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbComponent.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbComponent.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbComponent.EditorHeight = 17;
            this.cmbComponent.EvenRowStyle = style50;
            this.cmbComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbComponent.FooterStyle = style51;
            this.cmbComponent.HeadingStyle = style52;
            this.cmbComponent.HighLightRowStyle = style53;
            this.cmbComponent.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbComponent.Images"))));
            this.cmbComponent.ItemHeight = 15;
            this.cmbComponent.Location = new System.Drawing.Point(570, 411);
            this.cmbComponent.MatchEntryTimeout = ((long)(2000));
            this.cmbComponent.MaxDropDownItems = ((short)(5));
            this.cmbComponent.MaxLength = 32767;
            this.cmbComponent.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbComponent.Name = "cmbComponent";
            this.cmbComponent.OddRowStyle = style54;
            this.cmbComponent.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmbComponent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmbComponent.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbComponent.SelectedStyle = style55;
            this.cmbComponent.Size = new System.Drawing.Size(200, 21);
            this.cmbComponent.Style = style56;
            this.cmbComponent.TabIndex = 587;
            this.cmbComponent.PropBag = resources.GetString("cmbComponent.PropBag");
            // 
            // txtComponent
            // 
            this.txtComponent.BackColor = System.Drawing.Color.White;
            this.txtComponent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComponent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComponent.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtComponent.Location = new System.Drawing.Point(471, 411);
            this.txtComponent.MaxLength = 100;
            this.txtComponent.Name = "txtComponent";
            this.txtComponent.Size = new System.Drawing.Size(100, 21);
            this.txtComponent.TabIndex = 589;
            this.txtComponent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtComponent_KeyUp);
            // 
            // label6
            // 
            this.label6.ImageIndex = 1;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(366, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 586;
            this.label6.Text = "Process";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style57;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style58;
            this.cmb_Process.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style59;
            this.cmb_Process.HeadingStyle = style60;
            this.cmb_Process.HighLightRowStyle = style61;
            this.cmb_Process.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Process.Images"))));
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(471, 438);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style62;
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style63;
            this.cmb_Process.Size = new System.Drawing.Size(224, 20);
            this.cmb_Process.Style = style64;
            this.cmb_Process.TabIndex = 397;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            // 
            // label8
            // 
            this.label8.ImageIndex = 1;
            this.label8.ImageList = this.img_Label;
            this.label8.Location = new System.Drawing.Point(6, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 592;
            this.label8.Text = "In Kind";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_In_Kind
            // 
            this.cmb_In_Kind.AddItemSeparator = ';';
            this.cmb_In_Kind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_In_Kind.Caption = "";
            this.cmb_In_Kind.CaptionHeight = 17;
            this.cmb_In_Kind.CaptionStyle = style65;
            this.cmb_In_Kind.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_In_Kind.ColumnCaptionHeight = 18;
            this.cmb_In_Kind.ColumnFooterHeight = 18;
            this.cmb_In_Kind.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_In_Kind.ContentHeight = 16;
            this.cmb_In_Kind.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_In_Kind.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_In_Kind.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmb_In_Kind.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_In_Kind.EditorHeight = 16;
            this.cmb_In_Kind.EvenRowStyle = style66;
            this.cmb_In_Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_In_Kind.FooterStyle = style67;
            this.cmb_In_Kind.HeadingStyle = style68;
            this.cmb_In_Kind.HighLightRowStyle = style69;
            this.cmb_In_Kind.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_In_Kind.Images"))));
            this.cmb_In_Kind.ItemHeight = 15;
            this.cmb_In_Kind.Location = new System.Drawing.Point(110, 437);
            this.cmb_In_Kind.MatchEntryTimeout = ((long)(2000));
            this.cmb_In_Kind.MaxDropDownItems = ((short)(5));
            this.cmb_In_Kind.MaxLength = 32767;
            this.cmb_In_Kind.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_In_Kind.Name = "cmb_In_Kind";
            this.cmb_In_Kind.OddRowStyle = style70;
            this.cmb_In_Kind.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_In_Kind.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_In_Kind.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_In_Kind.SelectedStyle = style71;
            this.cmb_In_Kind.Size = new System.Drawing.Size(224, 20);
            this.cmb_In_Kind.Style = style72;
            this.cmb_In_Kind.TabIndex = 397;
            this.cmb_In_Kind.PropBag = resources.GetString("cmb_In_Kind.PropBag");
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Confirm.Enabled = false;
            this.btn_Confirm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Confirm.ImageIndex = 4;
            this.btn_Confirm.Location = new System.Drawing.Point(802, 410);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 594;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel_Confirm
            // 
            this.btn_Cancel_Confirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Cancel_Confirm.Enabled = false;
            this.btn_Cancel_Confirm.Location = new System.Drawing.Point(884, 409);
            this.btn_Cancel_Confirm.Name = "btn_Cancel_Confirm";
            this.btn_Cancel_Confirm.Size = new System.Drawing.Size(118, 23);
            this.btn_Cancel_Confirm.TabIndex = 594;
            this.btn_Cancel_Confirm.Text = "Cancel Confirm";
            this.btn_Cancel_Confirm.UseVisualStyleBackColor = false;
            this.btn_Cancel_Confirm.Click += new System.EventHandler(this.btn_Cancel_Confirm_Click);
            // 
            // btn_PopProcess
            // 
            this.btn_PopProcess.ImageIndex = 6;
            this.btn_PopProcess.ImageList = this.img_SmallButton;
            this.btn_PopProcess.Location = new System.Drawing.Point(698, 437);
            this.btn_PopProcess.Name = "btn_PopProcess";
            this.btn_PopProcess.Size = new System.Drawing.Size(21, 21);
            this.btn_PopProcess.TabIndex = 596;
            this.btn_PopProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PopProcess.Click += new System.EventHandler(this.btn_PopProcess_Click);
            // 
            // btn_CopyComp
            // 
            this.btn_CopyComp.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_CopyComp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_CopyComp.ImageIndex = 4;
            this.btn_CopyComp.Location = new System.Drawing.Point(884, 437);
            this.btn_CopyComp.Name = "btn_CopyComp";
            this.btn_CopyComp.Size = new System.Drawing.Size(118, 23);
            this.btn_CopyComp.TabIndex = 671;
            this.btn_CopyComp.Text = "Copy Comp";
            this.btn_CopyComp.UseVisualStyleBackColor = false;
            this.btn_CopyComp.Click += new System.EventHandler(this.btn_CopyComp_Click);
            // 
            // Form_MPS_Comp_In
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1024, 709);
            this.Controls.Add(this.btn_CopyComp);
            this.Controls.Add(this.btn_PopProcess);
            this.Controls.Add(this.btn_Cancel_Confirm);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnl_Search);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_Vendor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComponent);
            this.Controls.Add(this.cmb_In_Kind);
            this.Controls.Add(this.cmb_Process);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbComponent);
            this.Name = "Form_MPS_Comp_In";
            this.Text = "MPS Component Incoming";
            this.Controls.SetChildIndex(this.cmbComponent, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.cmb_Process, 0);
            this.Controls.SetChildIndex(this.cmb_In_Kind, 0);
            this.Controls.SetChildIndex(this.txtComponent, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.cmb_Vendor, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.btn_Confirm, 0);
            this.Controls.SetChildIndex(this.btn_Cancel_Confirm, 0);
            this.Controls.SetChildIndex(this.btn_PopProcess, 0);
            this.Controls.SetChildIndex(this.btn_CopyComp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_obsid_fr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            this.tab_Content.ResumeLayout(false);
            this.Pag_Summary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot_Size_Mps)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Comp_In)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbComponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_In_Kind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private void setDPO()
        {
            DataTable dt_ret = Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2");

            COM.ComCtl.Set_ComboList(dt_ret, cmb_obsid_fr, 0, 0, true, ClassLib.ComVar.ComboList_Visible.Name);
            cmb_obsid_fr.SelectedIndex = 0;
        }

        public DataTable Select_DP_DPO_List(string arg_factory, string arg_division)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SBM_LLT_PLAN_TRACKING_VJ.SELECT_SBM_DP_DPO_LIST";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_factory;
                MyOraDB.Parameter_Values[1] = arg_division;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }

        }

        private void cmb_Factory_SelectedValueChanged(object sender, EventArgs e)
        {
            setDPO();
        }

        public static DataTable Select_Vendor_List()
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_sqm_cust";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";
                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;
                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        public DataTable Select_Style_From_DPO()
        {

            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "pkg_sqm_cust.select_sqm_style_from_dpo";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_item";
                MyOraDB.Parameter_Name[1] = "arg_dpo";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = txt_Style.Text;
                MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_obsid_fr.SelectedValue);
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void txt_Style_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;

                DataTable dt_ret;
                dt_ret = Select_Style_From_DPO();

                ClassLib.ComFunction.Set_ComboList(dt_ret, cmb_Style, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_Style_SelectedValueChanged(object sender, EventArgs e)
        {
            fgrid_Lot_Size_Mps.ClearAll();
            fgrid_Comp_In.ClearAll();
            cmb_Vendor.Text = "ALL";
            txtComponent.Text = "";
            cmbComponent.SelectedValue = "";
            cmb_Process.Text = "ALL";
            if (Convert.ToString(cmb_Style.SelectedValue) != "")
            {
                txt_Style.Text = Convert.ToString(cmb_Style.SelectedValue);
            }
            Search_Lot_No();
        }

        private void Search_Lot_No()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            string process_name = "pkg_sqm_cust.select_lot_no";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = process_name;

            MyOraDB.Parameter_Name[0] = "arg_style_cd";
            MyOraDB.Parameter_Name[1] = "arg_dpo";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue).Replace("-", "");
            MyOraDB.Parameter_Values[1] = Convert.ToString(cmb_obsid_fr.SelectedValue);
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();

            DataTable a = ds_ret.Tables[0];
            if (a.Rows.Count > 0)
            {
                txt_Lot_No.Text = Convert.ToString(a.Rows[0][0]);
                cmb_Line.SelectedValue = Convert.ToString(a.Rows[0][1]);
                txtPlan_Date.Text = Convert.ToString(a.Rows[0][2]);
            }
            else
            {
                txt_Lot_No.Text = "";
                cmb_Line.SelectedValue = "";
                txtPlan_Date.Text = "";
            }
        }

        private void Clear_FlexGrid()
        {
            if (fgrid_Lot_Size_Mps.Rows.Fixed != fgrid_Lot_Size_Mps.Rows.Count)
            {
                fgrid_Lot_Size_Mps.Clear(ClearFlags.UserData, fgrid_Lot_Size_Mps.Rows.Fixed, 1, fgrid_Lot_Size_Mps.Rows.Count - 1, fgrid_Lot_Size_Mps.Cols.Count - 1);

                fgrid_Lot_Size_Mps.Rows.Count = fgrid_Lot_Size_Mps.Rows.Fixed;

            }
        }
        private void Clear_FlexGrid1()
        {
            if (fgrid_Comp_In.Rows.Fixed != fgrid_Comp_In.Rows.Count)
            {
                fgrid_Comp_In.Clear(ClearFlags.UserData, fgrid_Comp_In.Rows.Fixed, 1, fgrid_Comp_In.Rows.Count - 1, fgrid_Comp_In.Cols.Count - 1);

                fgrid_Comp_In.Rows.Count = fgrid_Comp_In.Rows.Fixed;

            }
        }
        private void Display_FlexGrid(DataTable arg_dt)
        {
            int iCount = arg_dt.Rows.Count;

            for (int iRow = 0; iRow < iCount; iRow++)
            {
                C1.Win.C1FlexGrid.Node newRow = fgrid_Lot_Size_Mps.Rows.InsertNode(fgrid_Lot_Size_Mps.Rows.Fixed + iRow, 1);
                fgrid_Lot_Size_Mps[newRow.Row.Index, 0] = "";

                for (int iCol = 1; iCol <= arg_dt.Columns.Count; iCol++)
                {
                    fgrid_Lot_Size_Mps[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol - 1];
                }
            }
        }

        private void Display_FlexGrid1(DataTable arg_dt)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                string p_vendor_cd = Convert.ToString(arg_dt.Rows[i][0]);
                string p_style_cd = Convert.ToString(arg_dt.Rows[i][1]);
                string p_lot_no = Convert.ToString(arg_dt.Rows[i][2]);
                string p_in_ymd = Convert.ToString(arg_dt.Rows[i][3]);
                string p_size_nm = Convert.ToString(arg_dt.Rows[i][4]);
                string p_line_cd = Convert.ToString(arg_dt.Rows[i][6]);
                string p_comp_cd = Convert.ToString(arg_dt.Rows[i][7]);
                string p_process = Convert.ToString(arg_dt.Rows[i][8]);
                string p_kind_in = Convert.ToString(arg_dt.Rows[i][9]);
                string p_dpo = Convert.ToString(arg_dt.Rows[i][10]);
                string p_day_seq = Convert.ToString(arg_dt.Rows[i][11]);
                int p_qty = Convert.ToInt32(arg_dt.Rows[i][5]);
                if (p_qty != 0)
                {
                    for (int j = fgrid_Comp_In.Rows.Fixed; j < fgrid_Comp_In.Rows.Count; j++)
                    {
                        for (int z = 5; z < fgrid_Comp_In.Cols.Count - 3; z++)
                        {
                            string f_vendor_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_VENDOR_CD]);
                            string f_style_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_STYLE_CD]);
                            string f_lot_no = Convert.ToString(fgrid_Comp_In.Rows[j][G_LOT_NO]);
                            string f_in_ymd = Convert.ToString(fgrid_Comp_In.Rows[j][G_IN_YMD]).Substring(0, 10);
                            string f_size_nm = Convert.ToString(fgrid_Comp_In.Rows[1][z]);
                            string f_line_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_LINE]);
                            string f_comp_cd = Convert.ToString(fgrid_Comp_In.Rows[j][G_COMP]);
                            string f_process = Convert.ToString(fgrid_Comp_In.Rows[j][G_PROCESS]);
                            string f_kind_in = Convert.ToString(fgrid_Comp_In.Rows[j][G_KIND_IN]);
                            string f_dpo = Convert.ToString(fgrid_Comp_In.Rows[j][G_DPO]);
                            string f_day_seq = Convert.ToString(fgrid_Comp_In.Rows[j][G_DAY_SEQ]);
                            if (f_vendor_cd == p_vendor_cd && f_style_cd == p_style_cd && f_lot_no == p_lot_no && f_in_ymd == p_in_ymd
                                && f_size_nm == p_size_nm && f_line_cd == p_line_cd && f_comp_cd == p_comp_cd && f_process == p_process && f_kind_in == p_kind_in && f_dpo == p_dpo && f_day_seq == p_day_seq)
                            {
                                fgrid_Comp_In.Rows[j][z] = p_qty;
                            }
                        }

                    }
                }
            }

        }

        private DataTable SearchData(string p_factory, string p_lot_no, string p_lot_seq)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_mps_lot_daily_size";

                MyOraDB.ReDim_Parameter(4);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_lot_no";
                MyOraDB.Parameter_Name[2] = "arg_lot_seq";
                MyOraDB.Parameter_Name[3] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_lot_no;
                MyOraDB.Parameter_Values[2] = p_lot_seq;
                MyOraDB.Parameter_Values[3] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable SearchData1(string p_style_cd, string p_vendor_cd, string p_lot_no, string p_comp_cd, string p_factory, string p_process, string p_kind_in, string p_dpo)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_incomming_daily_size";

                MyOraDB.ReDim_Parameter(9);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_factory";
                MyOraDB.Parameter_Name[1] = "arg_style_cd";
                MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[3] = "arg_lot_no";
                MyOraDB.Parameter_Name[4] = "arg_comp_cd";
                MyOraDB.Parameter_Name[5] = "arg_process";
                MyOraDB.Parameter_Name[6] = "arg_kind_in";
                MyOraDB.Parameter_Name[7] = "arg_dpo";
                MyOraDB.Parameter_Name[8] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_factory;
                MyOraDB.Parameter_Values[1] = p_style_cd;
                MyOraDB.Parameter_Values[2] = p_vendor_cd;
                MyOraDB.Parameter_Values[3] = p_lot_no;
                MyOraDB.Parameter_Values[4] = p_comp_cd;
                MyOraDB.Parameter_Values[5] = p_process;
                MyOraDB.Parameter_Values[6] = p_kind_in;
                MyOraDB.Parameter_Values[7] = p_dpo;
                MyOraDB.Parameter_Values[8] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }
        private void DISPLAY_OUT_DAILY_HEAD(string p_style_cd, string p_vendor_cd, string p_lot_no, string p_comp_cd, string p_factory, string p_kind_in, string p_process, string p_dpo)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            string process_name = "pkg_sqm_cust.select_in_daily_size_head";

            MyOraDB.ReDim_Parameter(9);
            MyOraDB.Process_Name = process_name;

            MyOraDB.Parameter_Name[0] = "arg_factory";
            MyOraDB.Parameter_Name[1] = "arg_style_cd";
            MyOraDB.Parameter_Name[2] = "arg_vendor_cd";
            MyOraDB.Parameter_Name[3] = "arg_lot_no";
            MyOraDB.Parameter_Name[4] = "arg_comp_cd";
            MyOraDB.Parameter_Name[5] = "arg_kind_in";
            MyOraDB.Parameter_Name[6] = "arg_process";
            MyOraDB.Parameter_Name[7] = "arg_dpo";
            MyOraDB.Parameter_Name[8] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = p_factory;
            MyOraDB.Parameter_Values[1] = p_style_cd;
            MyOraDB.Parameter_Values[2] = p_vendor_cd;
            MyOraDB.Parameter_Values[3] = p_lot_no;
            MyOraDB.Parameter_Values[4] = p_comp_cd;
            MyOraDB.Parameter_Values[5] = p_kind_in;
            MyOraDB.Parameter_Values[6] = p_process;
            MyOraDB.Parameter_Values[7] = p_dpo;
            MyOraDB.Parameter_Values[8] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (ds_ret != null)
            {
                DataTable dt = ds_ret.Tables[0];

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    C1.Win.C1FlexGrid.Node newRow = fgrid_Comp_In.Rows.InsertNode(fgrid_Comp_In.Rows.Fixed + i, 1);
                    fgrid_Comp_In[newRow.Row.Index, 0] = "";
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_VENDOR_CD] = dt.Rows[i][0];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_STYLE_CD] = dt.Rows[i][1];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LOT_NO] = dt.Rows[i][2];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_IN_YMD] = dt.Rows[i][3];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LINE] = dt.Rows[i][4];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_COMP] = dt.Rows[i][5];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_CONFIRM] = dt.Rows[i][6];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_PROCESS] = dt.Rows[i][7];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_KIND_IN] = dt.Rows[i][8];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_DPO] = dt.Rows[i][9];
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_DAY_SEQ] = dt.Rows[i][10];
                }
            }
        }
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            Search_Process();
        }

        private void Search_Process()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                Clear_FlexGrid();
                Clear_FlexGrid1();
                if (Convert.ToString(txt_Lot_No.Text) != "" || Convert.ToString(cmbComponent.SelectedValue) != "")
                {
                    Display_FlexGrid(SearchData(Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(txt_Lot_No.Text).Substring(0, 9), Convert.ToString(txt_Lot_No.Text).Substring(10, 2)));
                    Cal_row_sum();
                    fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1].StyleNew.BackColor = Color.LightGray;
                    fgrid_Lot_Size_Mps.Cols[fgrid_Lot_Size_Mps.Cols.Count - 1].StyleNew.BackColor = Color.LightGray;

                    DISPLAY_OUT_DAILY_HEAD(Convert.ToString(cmb_Style.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue), Convert.ToString(txt_Lot_No.Text), Convert.ToString(cmbComponent.SelectedValue), Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(cmb_In_Kind.SelectedValue), Convert.ToString(cmb_Process.SelectedValue), Convert.ToString(cmb_obsid_fr.SelectedValue));
                    Display_FlexGrid1(SearchData1(Convert.ToString(cmb_Style.SelectedValue), Convert.ToString(cmb_Vendor.SelectedValue), Convert.ToString(txt_Lot_No.Text), Convert.ToString(cmbComponent.SelectedValue), Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(cmb_Process.SelectedValue), Convert.ToString(cmb_In_Kind.SelectedValue), Convert.ToString(cmb_obsid_fr.SelectedValue)));
                    Cal_row_sum1();
                    Cal_col_sum();
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1].StyleNew.BackColor = Color.LightGray;
                    fgrid_Comp_In.Cols[fgrid_Comp_In.Cols.Count - 8].StyleNew.BackColor = Color.LightGray;
                    if (fgrid_Comp_In.Rows.Count - 1 > fgrid_Comp_In.Rows.Fixed)
                        btn_CopyComp.Enabled = true;
                    else
                        btn_CopyComp.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please Select Condition to Search");
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SearchData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;

            }
        }
        private void Cal_row_sum()
        {
            fgrid_Lot_Size_Mps.Rows.Add();
            fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1][2] = "Total";
            int total = 0;
            for (int j = 3; j < fgrid_Lot_Size_Mps.Cols.Count; j++)
            {
                total = 0;
                for (int i = 2; i < fgrid_Lot_Size_Mps.Rows.Count - 1; i++)
                {
                    total = total + Convert.ToInt32(fgrid_Lot_Size_Mps.Rows[i][j]);
                }
                if (total != 0)
                {
                    fgrid_Lot_Size_Mps.Rows[fgrid_Lot_Size_Mps.Rows.Count - 1][j] = total;
                }
            }

        }
        private void Cal_col_sum()
        {
            for (int i = fgrid_Comp_In.Rows.Fixed; i < fgrid_Comp_In.Rows.Count; i++)
            {
                int total = 0;
                for (int j = 5; j < fgrid_Comp_In.Cols.Count - 8; j++)
                {
                    total = total + Convert.ToInt32(fgrid_Comp_In.Rows[i][j]);
                }
                fgrid_Comp_In.Rows[i][G_TOTAl] = total;
            }
        }

        private void Cal_row_sum1()
        {
            fgrid_Comp_In.Rows.Add();
            fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_IN_YMD] = "Total";
            fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1].AllowEditing = false;
            int total = 0;
            for (int j = 5; j < fgrid_Comp_In.Cols.Count - 8; j++)
            {
                total = 0;
                for (int i = 2; i < fgrid_Comp_In.Rows.Count - 1; i++)
                {
                    total = total + Convert.ToInt32(fgrid_Comp_In.Rows[i][j]);
                }
                if (total != 0)
                {
                    fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][j] = total;
                }
            }

        }

        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            int l_count = 0;
            for (int i = fgrid_Comp_In.Rows.Fixed; i < fgrid_Comp_In.Rows.Count; i++)
            {
                if (Convert.ToString(fgrid_Comp_In.Rows[i][0]) == "I")
                {
                    l_count = l_count + 1;
                }
            }
            if (l_count == 0)
            {
                if (Convert.ToString(cmb_Vendor.SelectedValue) != " " && Convert.ToString(txt_Lot_No.Text) != "" && Convert.ToString(cmb_Style.SelectedValue) != "" && Convert.ToString(cmbComponent.SelectedValue) != ""
                    && Convert.ToString(cmb_In_Kind.SelectedValue) != " " && Convert.ToString(cmb_Process.SelectedValue) != " ")
                {
                    if (fgrid_Comp_In.Rows.Count > 2)
                    {
                        fgrid_Comp_In.Add_Row(fgrid_Comp_In.Rows.Count - 2);
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_IN_YMD] = DateTime.Now.ToString("yyyy-MM-dd");
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_VENDOR_CD] = cmb_Vendor.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_LOT_NO] = txt_Lot_No.Text;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_STYLE_CD] = cmb_Style.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_LINE] = cmb_Line.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_COMP] = cmbComponent.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_CONFIRM] = "False";
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_PROCESS] = cmb_Process.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_KIND_IN] = cmb_In_Kind.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 2][G_DPO] = cmb_obsid_fr.SelectedValue;
                    }
                    else
                    {
                        fgrid_Comp_In.Add_Row(fgrid_Comp_In.Rows.Count - 1);
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_IN_YMD] = DateTime.Now.ToString("yyyy-MM-dd");
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_VENDOR_CD] = cmb_Vendor.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LOT_NO] = txt_Lot_No.Text;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_STYLE_CD] = cmb_Style.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_LINE] = cmb_Line.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_COMP] = cmbComponent.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_CONFIRM] = "False";
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_PROCESS] = cmb_Process.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_KIND_IN] = cmb_In_Kind.SelectedValue;
                        fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][G_DPO] = cmb_obsid_fr.SelectedValue;
                    }

                }
                else
                {
                    MessageBox.Show("Please Select Condition To Add New");
                }
            }
            else
            {
                MessageBox.Show("you just insert day by day");
            }
            btn_CopyComp.Enabled = false;
        }

        private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = fgrid_Comp_In.Selections.Length - 1; i >= 0; i--)
                {
                    if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Selections[i]][0]) != "I")
                    {
                        //MessageBox.Show(Convert.ToString(fgrid_Item_Price.Rows[fgrid_Item_Price.Selections[i]][G_SEQ]));
                        fgrid_Comp_In.Delete_Row(fgrid_Comp_In.Selections[i]);
                    }
                    else
                    {
                        fgrid_Comp_In.Rows.Remove(fgrid_Comp_In.Selections[i]);
                    }
                    btn_CopyComp.Enabled = false;
                }
            }
            catch (System.Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (Savedata(true))
            {
                tbtn_Search_Click(tbtn_Search, null);
                ClassLib.ComFunction.User_Message("Upload Data Sucess!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_CopyComp.Enabled = true;
            }
        }

        private bool Savedata(bool doExecute)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int para_ct = 0;
                int iCount = 16;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_ins_incomming_daily";

                //02.ARGURMENT OF PROC
                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_vendor_cd";
                oraDB.Parameter_Name[2] = "arg_style_cd";
                oraDB.Parameter_Name[3] = "arg_lot_no";
                oraDB.Parameter_Name[4] = "arg_in_ymd";
                oraDB.Parameter_Name[5] = "arg_size_nm";
                oraDB.Parameter_Name[6] = "arg_qty";
                oraDB.Parameter_Name[7] = "arg_line_cd";
                oraDB.Parameter_Name[8] = "arg_comp_cd";
                oraDB.Parameter_Name[9] = "arg_user_upd";
                oraDB.Parameter_Name[10] = "arg_factory";
                oraDB.Parameter_Name[11] = "arg_confirm";
                oraDB.Parameter_Name[12] = "arg_process";
                oraDB.Parameter_Name[13] = "arg_kind_in";
                oraDB.Parameter_Name[14] = "arg_dpo";
                oraDB.Parameter_Name[15] = "arg_day_seq";

                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                oraDB.Parameter_Type[7] = (int)OracleType.Number;

                ArrayList temp = new ArrayList();

                //oraDB.Parameter_Values  = new string[iCount * (fgrid_Comp_Out.Rows.Count - fgrid_Comp_Out.Rows.Fixed)*40 ];

                for (int iRow = fgrid_Comp_In.Rows.Fixed; iRow < fgrid_Comp_In.Rows.Count; iRow++)
                {
                    if (fgrid_Comp_In.Rows[iRow][0] == null)
                    {
                        continue;
                    }
                    for (int iCol = 5; iCol < fgrid_Comp_In.Cols.Count - 8; iCol++)
                    {
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, 0]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]));
                        temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_IN_YMD]).Replace("-", "").Substring(0, 8));
                        temp.Add(Convert.ToString(fgrid_Comp_In[1, iCol]));
                        temp.Add(Convert.ToInt32(fgrid_Comp_In[iRow, iCol]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_COMP]));
                        temp.Add(COM.ComVar.This_User);
                        temp.Add(Convert.ToString(cmb_Factory.SelectedValue));
                        if (Convert.ToString(fgrid_Comp_In.Rows[iRow][G_CONFIRM]) == "True")
                        {
                            temp.Add("Y");
                        }
                        else
                        {
                            temp.Add("N");
                        }

                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_PROCESS]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_KIND_IN]));
                        temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DPO]));

                        if (Convert.ToString(fgrid_Comp_In[iRow, 0]) == "I")
                        {
                            DataTable dtd = SELECT_MAX_SEQ(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]), Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]), Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]),
                                Convert.ToString(fgrid_Comp_In[iRow, G_IN_YMD]).Replace("-", "").Substring(0, 8), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE]), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_COMP]),
                                Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_PROCESS]), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_KIND_IN]), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DPO]));
                            temp.Add(Convert.ToString(dtd.Rows[0][0]));
                        }
                        else
                        {
                            temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DAY_SEQ]));
                        }

                    }
                }
                oraDB.Parameter_Values = new string[temp.Count];
                for (int j = 0; j < temp.Count; j++)
                {
                    oraDB.Parameter_Values[j] = temp[j].ToString();
                }
                oraDB.Add_Modify_Parameter(true);

                if (doExecute)
                {
                    if (oraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;

            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private DataTable SELECT_MAX_SEQ(string p_vendor_cd, string p_style_cd, string p_lot_no, string p_in_ymd, string p_line_cd, string p_comp_cd, string p_factory, string p_process_cd, string p_kind_in, string p_dpo)
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            try
            {
                string process_name = "pkg_sqm_cust.select_max_day_seq_in";

                MyOraDB.ReDim_Parameter(11);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_vendor_cd";
                MyOraDB.Parameter_Name[1] = "arg_style_cd";
                MyOraDB.Parameter_Name[2] = "arg_lot_no";
                MyOraDB.Parameter_Name[3] = "arg_in_ymd";
                MyOraDB.Parameter_Name[4] = "arg_line_cd";
                MyOraDB.Parameter_Name[5] = "arg_comp_cd";
                MyOraDB.Parameter_Name[6] = "arg_factory";
                MyOraDB.Parameter_Name[7] = "arg_process_cd";
                MyOraDB.Parameter_Name[8] = "arg_kind_in";
                MyOraDB.Parameter_Name[9] = "arg_dpo";
                MyOraDB.Parameter_Name[10] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = p_vendor_cd;
                MyOraDB.Parameter_Values[1] = p_style_cd;
                MyOraDB.Parameter_Values[2] = p_lot_no;
                MyOraDB.Parameter_Values[3] = p_in_ymd;
                MyOraDB.Parameter_Values[4] = p_line_cd;
                MyOraDB.Parameter_Values[5] = p_comp_cd;
                MyOraDB.Parameter_Values[6] = p_factory;
                MyOraDB.Parameter_Values[7] = p_process_cd;
                MyOraDB.Parameter_Values[8] = p_kind_in;
                MyOraDB.Parameter_Values[9] = p_dpo;
                MyOraDB.Parameter_Values[10] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void fgrid_Comp_Out_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM]) == "True")
            {
                MessageBox.Show("This date has confirmed, please Cancel Confirm to Update");
                fgrid_Comp_In.Rows[fgrid_Comp_In.Row][fgrid_Comp_In.Col] = qty;
            }
            else
            {
                if (fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1].AllowEditing == false)
                {
                    int total = 0;
                    for (int j = 5; j < fgrid_Comp_In.Cols.Count - 8; j++)
                    {
                        total = 0;
                        for (int i = 2; i < fgrid_Comp_In.Rows.Count - 1; i++)
                        {
                            total = total + Convert.ToInt32(fgrid_Comp_In.Rows[i][j]);
                        }
                        if (total != 0)
                        {
                            fgrid_Comp_In.Rows[fgrid_Comp_In.Rows.Count - 1][j] = total;
                        }
                    }
                }
                fgrid_Comp_In.Update_Row(e.Row);
                btn_CopyComp.Enabled = false;
            }
        }

        private void cmb_Lot_No_SelectedValueChanged(object sender, System.EventArgs e)
        {

        }
        private void Check_vendor()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;

            string process_name = "pkg_sqm_cust.select_check_exist_vendor";

            MyOraDB.ReDim_Parameter(3);
            MyOraDB.Process_Name = process_name;

            MyOraDB.Parameter_Name[0] = "arg_style_cd";
            MyOraDB.Parameter_Name[1] = "arg_lot_no";
            MyOraDB.Parameter_Name[2] = "out_cursor";

            MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue);
            MyOraDB.Parameter_Values[1] = Convert.ToString(txt_Lot_No.Text);
            MyOraDB.Parameter_Values[2] = "";

            MyOraDB.Add_Select_Parameter(true);
            ds_ret = MyOraDB.Exe_Select_Procedure();
            if (Convert.ToString(ds_ret.Tables[0].Rows[0][0]) != "")
            {
                cmb_Vendor.SelectedValue = Convert.ToString(ds_ret.Tables[0].Rows[0][0]);
                //cmb_Vendor.DisplayMember=Convert.ToString(ds_ret.Tables[0].Rows[0][0]);
            }
            else
            {
                cmb_Vendor.SelectedValue = " ";
            }
            ds_ret.Dispose();
        }


        private void cmb_Lot_No_Change(object sender, System.EventArgs e)
        {
            Check_vendor();
        }

        private DataTable SELECT_LINE_INFO()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SBM_LLT_PLAN_TRACKING.SELECT_LINE_INFO";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = process_name;


                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private DataTable SELECT_PROCESS()
        {
            COM.OraDB MyOraDB = new COM.OraDB();
            DataSet ds_ret;
            try
            {
                string process_name = "PKG_SQM_CUST.select_process";

                MyOraDB.ReDim_Parameter(1);
                MyOraDB.Process_Name = process_name;
                MyOraDB.Parameter_Name[0] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[process_name];
            }
            catch
            {
                return null;
            }
        }

        private void cmb_Line_SelectedValueChanged(object sender, System.EventArgs e)
        {
            Search_Lot_No();
        }

        private void txtComponent_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Enter) return;
                DataTable dt_ret = Search_Component();
                COM.ComCtl.Set_ComboList(dt_ret, cmbComponent, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);
                dt_ret.Dispose();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "txt_Component_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private DataTable Search_Component()
        {
            try
            {
                COM.OraDB MyOraDB = new COM.OraDB();
                DataSet ds_ret;

                string process_name = "pkg_sqm_cust.select_component";

                MyOraDB.ReDim_Parameter(3);
                MyOraDB.Process_Name = process_name;

                MyOraDB.Parameter_Name[0] = "arg_style_cd";
                MyOraDB.Parameter_Name[1] = "arg_comp_nm";
                MyOraDB.Parameter_Name[2] = "out_cursor";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = Convert.ToString(cmb_Style.SelectedValue);
                MyOraDB.Parameter_Values[1] = Convert.ToString(txtComponent.Text);
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                ds_ret = MyOraDB.Exe_Select_Procedure();

                DataTable a = ds_ret.Tables[0];
                return a;
            }
            catch
            {
                return null;
            }
        }

        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            string p_factory = Convert.ToString(cmb_Factory.SelectedValue);
            string p_style_cd = Convert.ToString(cmb_Style.SelectedValue);
            string p_vendor_cd = Convert.ToString(cmb_Vendor.SelectedValue);
            string p_lot_no = Convert.ToString(txt_Lot_No.Text);
            string p_comp_cd = Convert.ToString(cmbComponent.SelectedValue);

            string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_MPS_Comp_Out");
            string Para = " ";


            int iCnt = 6;
            string[] aHead = new string[iCnt];

            aHead[0] = p_factory;
            aHead[1] = p_style_cd;
            aHead[2] = p_vendor_cd;
            aHead[3] = p_lot_no;
            aHead[4] = p_comp_cd;
            aHead[5] = "";
            Para = " /rp ";
            for (int i = 1; i <= iCnt; i++)
            {
                Para = Para + "[" + aHead[i - 1] + "] ";
            }
            FlexSQM.Report.Form_RdViewer report = new FlexSQM.Report.Form_RdViewer(mrd_Filename, Para);
            //FlexTraining.Report.Form_RdViewer report = new FlexTraining.Report.Form_RdViewer(mrd_Filename, Para);

            report.Show();

        }

        private void fgrid_Lot_Size_Mps_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Comp_In.ScrollPosition = new Point(fgrid_Lot_Size_Mps.ScrollPosition.X, fgrid_Comp_In.ScrollPosition.Y);
        }

        private void fgrid_Comp_Out_AfterScroll(object sender, RangeEventArgs e)
        {
            fgrid_Lot_Size_Mps.ScrollPosition = new Point(fgrid_Comp_In.ScrollPosition.X, fgrid_Lot_Size_Mps.ScrollPosition.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (ClassLib.ComFunction.User_Message("Do you want to Confirm ?", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM] = "True";
                fgrid_Comp_In.Rows[fgrid_Comp_In.Row][0] = "U";
                if (Savedata(true))
                {
                    tbtn_Search_Click(tbtn_Search, null);
                    //ClassLib.ComFunction.User_Message("Upload Data Sucess!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btn_Confirm.Enabled = false;
                btn_Cancel_Confirm.Enabled = false;
            }
            //if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][0]) != "I" && Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM]) == "False")
            //{
            //    btn_Confirm.Enabled = true;
            //}
            //else
            //{
            //    btn_Confirm.Enabled = false;
            //}

        }
        private int qty = 0;
        private void fgrid_Comp_In_Click(object sender, EventArgs e)
        {
            if (fgrid_Comp_In.Rows.Count >= 3)
            {
                if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][0]) != "I" && Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM]) == "False")
                {
                    btn_Confirm.Enabled = true;
                }
                else
                {
                    btn_Confirm.Enabled = false;
                }
                if (COM.ComVar.This_InsaCd == "Y" && Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM]) == "True")
                {
                    btn_Cancel_Confirm.Enabled = true;
                }
                else
                {
                    btn_Cancel_Confirm.Enabled = false;
                }
                if (fgrid_Comp_In.Rows.Count - 1 > fgrid_Comp_In.Row && fgrid_Comp_In.Row >= fgrid_Comp_In.Rows.Fixed
                    && fgrid_Comp_In.Cols.Count - 6 > fgrid_Comp_In.Col && fgrid_Comp_In.Col > 4)
                {
                    qty = Convert.ToInt32(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][fgrid_Comp_In.Col]);
                }
                else
                {
                    qty = 0;
                }
            }
        }

        private void btn_Cancel_Confirm_Click(object sender, EventArgs e)
        {
            if (ClassLib.ComFunction.User_Message("Are you sure to Cancel Confirm ?", "save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Cancel_Confirm(true))
                {
                    tbtn_Search_Click(tbtn_Search, null);
                    //ClassLib.ComFunction.User_Message("Upload Data Sucess!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btn_Confirm.Enabled = false;
                btn_Cancel_Confirm.Enabled = false;
            }
            //if (Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][0]) != "I" && Convert.ToString(fgrid_Comp_In.Rows[fgrid_Comp_In.Row][G_CONFIRM]) == "True")
            //{
            //    btn_Cancel_Confirm.Enabled = true;
            //}
            //else
            //{
            //    btn_Cancel_Confirm.Enabled = false;
            //}
        }


        private bool Cancel_Confirm(bool doExecute)
        {
            try
            {
                COM.OraDB oraDB = new COM.OraDB();
                int para_ct = 0;
                int iCount = 15;
                oraDB.ReDim_Parameter(iCount);

                //01.PROCEDURE NAME
                oraDB.Process_Name = "pkg_sqm_cust.sp_cancel_confirm_in";

                //02.ARGURMENT OF PROC
                oraDB.Parameter_Name[0] = "arg_division";
                oraDB.Parameter_Name[1] = "arg_vendor_cd";
                oraDB.Parameter_Name[2] = "arg_style_cd";
                oraDB.Parameter_Name[3] = "arg_lot_no";
                oraDB.Parameter_Name[4] = "arg_in_ymd";
                oraDB.Parameter_Name[5] = "arg_size_nm";
                oraDB.Parameter_Name[6] = "arg_qty";
                oraDB.Parameter_Name[7] = "arg_line_cd";
                oraDB.Parameter_Name[8] = "arg_comp_cd";
                oraDB.Parameter_Name[9] = "arg_user_upd";
                oraDB.Parameter_Name[10] = "arg_factory";
                oraDB.Parameter_Name[11] = "arg_confirm";
                oraDB.Parameter_Name[12] = "arg_process";
                oraDB.Parameter_Name[13] = "arg_kind_in";
                oraDB.Parameter_Name[14] = "arg_dpo";

                for (int iCol = 0; iCol < iCount; iCol++)
                {
                    oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
                }
                oraDB.Parameter_Type[7] = (int)OracleType.Number;

                ArrayList temp = new ArrayList();


                int iRow = fgrid_Comp_In.Row;
                for (int iCol = 5; iCol < fgrid_Comp_In.Cols.Count - 6; iCol++)
                {
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, 0]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_IN_YMD]).Replace("-", "").Substring(0, 8));
                    temp.Add(Convert.ToString(fgrid_Comp_In[1, iCol]));
                    temp.Add(Convert.ToInt32(fgrid_Comp_In[iRow, iCol]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_COMP]));
                    temp.Add(COM.ComVar.This_User);
                    temp.Add(Convert.ToString(cmb_Factory.SelectedValue));
                    temp.Add("N");
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_PROCESS]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_KIND_IN]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DPO]));
                }
                oraDB.Parameter_Values = new string[temp.Count];
                for (int j = 0; j < temp.Count; j++)
                {
                    oraDB.Parameter_Values[j] = temp[j].ToString();
                }
                oraDB.Add_Modify_Parameter(true);

                if (doExecute)
                {
                    if (oraDB.Exe_Modify_Procedure() == null)
                        return false;
                    else
                        return true;
                }

                return true;

            }
            catch (System.Exception ex)
            {
                return false;
            }
        }

        private void cmb_obsid_fr_SelectedValueChanged(object sender, EventArgs e)
        {
            txt_Style.Text = "";
            txtPlan_Date.Text = "";
            cmb_Line.SelectedValue = "";
            txt_Lot_No.Text = "";
            fgrid_Lot_Size_Mps.ClearAll();
            fgrid_Comp_In.ClearAll();
            cmb_Vendor.Text = "ALL";
            txtComponent.Text = "";
            cmbComponent.SelectedValue = "";
            cmb_Process.Text = "ALL";
            cmb_Style.ClearFields();
            cmb_Style.ClearSelected();
            cmb_Style.Text = "";
        }

        private void txt_Lot_No_TextChanged(object sender, EventArgs e)
        {
            Search_Process();
            Check_vendor();
        }

        private void btn_PopProcess_Click(object sender, EventArgs e)
        {
            Pop_New_Process pop_form = new Pop_New_Process(Convert.ToString(cmb_Process.SelectedValue));
            pop_form.ShowDialog();
            DataTable dt_ret;
            dt_ret = SELECT_PROCESS();
            COM.ComCtl.Set_ComboList(dt_ret, cmb_Process, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Process.SelectedIndex = 0;
        }

        private void btn_CopyComp_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Select_Comp fComp = new Form_Select_Comp(cmbComponent, txt_Style.Text, cmb_Style.SelectedText, fgrid_Comp_In[fgrid_Comp_In.RowSel, G_IN_YMD], Convert.ToString(fgrid_Comp_In[fgrid_Comp_In.RowSel, G_DAY_SEQ]));
                if (fComp.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    if (fComp.Tag != null)
                    {
                        ArrayList l_arr = (ArrayList)fComp.Tag;
                        //if (!fComp.Tag.ToString().Equals(string.Empty))
                        //{
                        if (CopyComp(l_arr))
                        {
                            cmbComponent.SelectedValue = l_arr[2];
                            tbtn_Search_Click(tbtn_Search, C1.Win.C1Command.ClickEventArgs.Empty);
                            ClassLib.ComFunction.User_Message("Upload Data Sucess!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
                        }
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                COM.ComFunction.User_Message(ex.Message, "btn_CopyComp_Click", MessageBoxButtons.OK);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Copy data out comp to another comp
        /// </summary>
        /// <param name="arg_Compvalue"></param>
        /// <returns></returns>
        private bool CopyComp(ArrayList arg_ArrNewValue)
        {
            COM.OraDB oraDB = new COM.OraDB();
            int para_ct = 0;
            int iCount = 16;
            oraDB.ReDim_Parameter(iCount);

            //01.PROCEDURE NAME
            oraDB.Process_Name = "pkg_sqm_cust.sp_ins_incomming_daily";

            //02.ARGURMENT OF PROC
            oraDB.Parameter_Name[0] = "arg_division";
            oraDB.Parameter_Name[1] = "arg_vendor_cd";
            oraDB.Parameter_Name[2] = "arg_style_cd";
            oraDB.Parameter_Name[3] = "arg_lot_no";
            oraDB.Parameter_Name[4] = "arg_in_ymd";
            oraDB.Parameter_Name[5] = "arg_size_nm";
            oraDB.Parameter_Name[6] = "arg_qty";
            oraDB.Parameter_Name[7] = "arg_line_cd";
            oraDB.Parameter_Name[8] = "arg_comp_cd";
            oraDB.Parameter_Name[9] = "arg_user_upd";
            oraDB.Parameter_Name[10] = "arg_factory";
            oraDB.Parameter_Name[11] = "arg_confirm";
            oraDB.Parameter_Name[12] = "arg_process";
            oraDB.Parameter_Name[13] = "arg_kind_in";
            oraDB.Parameter_Name[14] = "arg_dpo";
            oraDB.Parameter_Name[15] = "arg_day_seq";

            for (int iCol = 0; iCol < iCount; iCol++)
            {
                oraDB.Parameter_Type[iCol] = (int)OracleType.VarChar;
            }
            oraDB.Parameter_Type[7] = (int)OracleType.Number;

            ArrayList temp = new ArrayList();
            int iRow = fgrid_Comp_In.RowSel;
            //for (int iRow = fgrid_Comp_In.Rows.Fixed; iRow < fgrid_Comp_In.Rows.Count; iRow++)
            //{
            //    if (fgrid_Comp_In.Rows[iRow][0] == null)
            //    {
            //        continue;
            //    }
                for (int iCol = 5; iCol < fgrid_Comp_In.Cols.Count - 8; iCol++)
                {
                    temp.Add("I");
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]));
                    temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]));
                    temp.Add(Convert.ToString(arg_ArrNewValue[1]));
                    //temp.Add(Convert.ToString(fgrid_Comp_In[iRow, G_IN_YMD]).Replace("-", "").Substring(0, 8));
                    temp.Add(Convert.ToString(fgrid_Comp_In[1, iCol]));
                    temp.Add(Convert.ToInt32(fgrid_Comp_In[iRow, iCol]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE]));
                    temp.Add(Convert.ToString(arg_ArrNewValue[2]));
                    //temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_COMP]));
                    temp.Add(COM.ComVar.This_User);
                    temp.Add(Convert.ToString(cmb_Factory.SelectedValue));
                    if (Convert.ToString(fgrid_Comp_In.Rows[iRow][G_CONFIRM]) == "True")
                    {
                        temp.Add("Y");
                    }
                    else
                    {
                        temp.Add("N");
                    }

                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_PROCESS]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_KIND_IN]));
                    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DPO]));

                    //if (Convert.ToString(fgrid_Comp_In[iRow, 0]) == "I")
                    //{
                        DataTable dtd = SELECT_MAX_SEQ(Convert.ToString(fgrid_Comp_In[iRow, G_VENDOR_CD]), Convert.ToString(fgrid_Comp_In[iRow, G_STYLE_CD]), Convert.ToString(fgrid_Comp_In[iRow, G_LOT_NO]),
                            arg_ArrNewValue[1].ToString(), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_LINE]), arg_ArrNewValue[2].ToString(),
                            Convert.ToString(cmb_Factory.SelectedValue), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_PROCESS]), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_KIND_IN]), Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DPO]));
                        temp.Add(Convert.ToString(dtd.Rows[0][0]));
                    //}
                    //else
                    //{
                    //    temp.Add(Convert.ToString(fgrid_Comp_In.Rows[iRow][G_DAY_SEQ]));
                    //}

                }
            //}
            oraDB.Parameter_Values = new string[temp.Count];
            for (int j = 0; j < temp.Count; j++)
            {
                oraDB.Parameter_Values[j] = temp[j].ToString();
            }
            oraDB.Add_Modify_Parameter(true);


            if (oraDB.Exe_Modify_Procedure() == null)
                return false;
            else
                return true;
        }


    }
}
