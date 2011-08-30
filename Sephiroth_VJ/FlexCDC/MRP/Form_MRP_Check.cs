using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.Threading;

namespace FlexCDC.MRP
{
    public class Form_MRP_Check : COM.PCHWinForm.Form_Top
    {
        #region 컨트롤정의 및 리소스 정의
        public System.Windows.Forms.Panel pnl_Search;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabPage tab_Error;
        private System.Windows.Forms.TabPage tab_Usage;
        private System.Windows.Forms.TabPage tab_OA;
        private System.Windows.Forms.TabControl tab_Sheet;
        public COM.FSP fgrid_OA;
        public System.Windows.Forms.Panel pnl_SearchImage;
        private System.Windows.Forms.DateTimePicker dtp_Mrp_date;
        private System.Windows.Forms.Label lbl_Dash;
        private System.Windows.Forms.Label lbl_Prod_Ymd;
        private System.Windows.Forms.DateTimePicker dtp_From_Date;
        private System.Windows.Forms.DateTimePicker dtp_To_Date;
        private System.Windows.Forms.Label lbl_MRP_No;
        private C1.Win.C1List.C1Combo cmb_Factory;
        private System.Windows.Forms.Label lbl_Factory;
        public System.Windows.Forms.PictureBox picb_MR;
        public System.Windows.Forms.PictureBox picb_TR;
        public System.Windows.Forms.PictureBox picb_TM;
        public System.Windows.Forms.PictureBox picb_BR;
        public System.Windows.Forms.PictureBox picb_BM;
        public System.Windows.Forms.PictureBox picb_BL;
        public System.Windows.Forms.PictureBox picb_ML;
        public System.Windows.Forms.PictureBox picb_MM;
        public COM.FSP fgrid_Error;
        public COM.FSP fgrid_MRP;
        private System.Windows.Forms.ContextMenu ctm_OA;
        private System.Windows.Forms.MenuItem mnt_Mrp_Div;
        private System.Windows.Forms.MenuItem mnt_Bom;
        private System.Windows.Forms.MenuItem mnt_Material;
        private System.Windows.Forms.MenuItem mnt_Mrp_Sel_Change;
        private System.Windows.Forms.MenuItem mnt_Material_New;
        private System.Windows.Forms.MenuItem mnt_Material_Old;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.CheckBox chk_Close;
        private System.Windows.Forms.Label lbl_Close;
        private System.Windows.Forms.TabPage tab_Lot;
        private System.Windows.Forms.Panel pnl_grid;
        private System.Windows.Forms.ContextMenu ctm_Menu;
        private System.Windows.Forms.MenuItem mnt_IncludingMrp;
        private System.Windows.Forms.MenuItem mnt_NotIncludingMrp;
        private System.Windows.Forms.MenuItem mnt_Bar1;
        private System.Windows.Forms.MenuItem mnt_Ready;
        private System.Windows.Forms.MenuItem mnt_Editing;
        private System.Windows.Forms.MenuItem mnt_Confirmed;
        private System.Windows.Forms.MenuItem mnt_Canceled;
        private System.Windows.Forms.MenuItem mnt_Closed;
        private System.Windows.Forms.MenuItem mnt_Bar2;
        private System.Windows.Forms.MenuItem mnt_Mrp;
        public COM.FSP fgrid_Lot;
        private System.Windows.Forms.ContextMenu ctm_Status;
        private System.Windows.Forms.MenuItem mnt_Editing_Item;
        private System.Windows.Forms.MenuItem mnt_Confirmed_Item;
        private System.Windows.Forms.ContextMenu ctm_Base;
        private System.Windows.Forms.MenuItem mnt_Spec;


        #region 사전정의 변수
        private FlexCDC.BaseInfo.Pop_BS_Shipping_List_Wait _pop = null;
        private System.Windows.Forms.MenuItem mnt_OA_Check;
        private System.Windows.Forms.MenuItem mnt_OA_Uncheck;
        private System.Windows.Forms.MenuItem mnt_Text_Change;
        private System.Windows.Forms.MenuItem mnt_MRP_Check;
        private System.Windows.Forms.MenuItem mnt_Bar3;
        private System.Windows.Forms.MenuItem mnt_MRP_UnCheck;
        public System.Windows.Forms.Label lbl_title;
        private string _MoveSheet = "";

        #endregion



        public Form_MRP_Check()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }


        public Form_MRP_Check(Form_MRP_Manager arg_frm, string arg_movesheet)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            _MoveSheet = arg_movesheet;
            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }


        //
        //		public Form_MRP_Check(Form_MRP_Item_Manager arg_frm, string arg_movesheet)
        //		{
        //			// 이 호출은 Windows Form 디자이너에 필요합니다.
        //			InitializeComponent();
        //
        //
        //			_MoveSheet  = arg_movesheet;
        //
        //			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        //		}


        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
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

        #endregion

        #region 디자이너에서 생성한 코드
        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MRP_Check));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.pnl_Search = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.chk_Close = new System.Windows.Forms.CheckBox();
            this.lbl_Close = new System.Windows.Forms.Label();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.dtp_Mrp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Dash = new System.Windows.Forms.Label();
            this.lbl_Prod_Ymd = new System.Windows.Forms.Label();
            this.dtp_From_Date = new System.Windows.Forms.DateTimePicker();
            this.dtp_To_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_MRP_No = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.tab_Sheet = new System.Windows.Forms.TabControl();
            this.tab_Lot = new System.Windows.Forms.TabPage();
            this.pnl_grid = new System.Windows.Forms.Panel();
            this.fgrid_Lot = new COM.FSP();
            this.ctm_Menu = new System.Windows.Forms.ContextMenu();
            this.mnt_IncludingMrp = new System.Windows.Forms.MenuItem();
            this.mnt_NotIncludingMrp = new System.Windows.Forms.MenuItem();
            this.mnt_Bar1 = new System.Windows.Forms.MenuItem();
            this.mnt_Ready = new System.Windows.Forms.MenuItem();
            this.mnt_Editing = new System.Windows.Forms.MenuItem();
            this.mnt_Confirmed = new System.Windows.Forms.MenuItem();
            this.mnt_Canceled = new System.Windows.Forms.MenuItem();
            this.mnt_Closed = new System.Windows.Forms.MenuItem();
            this.mnt_Bar2 = new System.Windows.Forms.MenuItem();
            this.mnt_Mrp = new System.Windows.Forms.MenuItem();
            this.mnt_Bar3 = new System.Windows.Forms.MenuItem();
            this.mnt_MRP_Check = new System.Windows.Forms.MenuItem();
            this.mnt_MRP_UnCheck = new System.Windows.Forms.MenuItem();
            this.tab_Error = new System.Windows.Forms.TabPage();
            this.fgrid_Error = new COM.FSP();
            this.ctm_Base = new System.Windows.Forms.ContextMenu();
            this.mnt_Spec = new System.Windows.Forms.MenuItem();
            this.tab_Usage = new System.Windows.Forms.TabPage();
            this.fgrid_MRP = new COM.FSP();
            this.tab_OA = new System.Windows.Forms.TabPage();
            this.fgrid_OA = new COM.FSP();
            this.ctm_OA = new System.Windows.Forms.ContextMenu();
            this.mnt_Mrp_Div = new System.Windows.Forms.MenuItem();
            this.mnt_Mrp_Sel_Change = new System.Windows.Forms.MenuItem();
            this.mnt_Bom = new System.Windows.Forms.MenuItem();
            this.mnt_Material = new System.Windows.Forms.MenuItem();
            this.mnt_Material_New = new System.Windows.Forms.MenuItem();
            this.mnt_Material_Old = new System.Windows.Forms.MenuItem();
            this.mnt_OA_Check = new System.Windows.Forms.MenuItem();
            this.mnt_OA_Uncheck = new System.Windows.Forms.MenuItem();
            this.mnt_Text_Change = new System.Windows.Forms.MenuItem();
            this.ctm_Status = new System.Windows.Forms.ContextMenu();
            this.mnt_Editing_Item = new System.Windows.Forms.MenuItem();
            this.mnt_Confirmed_Item = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_Search.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            this.tab_Sheet.SuspendLayout();
            this.tab_Lot.SuspendLayout();
            this.pnl_grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot)).BeginInit();
            this.tab_Error.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Error)).BeginInit();
            this.tab_Usage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MRP)).BeginInit();
            this.tab_OA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OA)).BeginInit();
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
            this.lbl_MainTitle.Text = "MRP Manager";
            // 
            // tbtn_Create
            // 
            this.tbtn_Create.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Create_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
            // 
            // pnl_Search
            // 
            this.pnl_Search.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_Search.Controls.Add(this.pnl_SearchImage);
            this.pnl_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Search.Location = new System.Drawing.Point(0, 80);
            this.pnl_Search.Name = "pnl_Search";
            this.pnl_Search.Padding = new System.Windows.Forms.Padding(8);
            this.pnl_Search.Size = new System.Drawing.Size(1016, 112);
            this.pnl_Search.TabIndex = 36;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.chk_Close);
            this.pnl_SearchImage.Controls.Add(this.lbl_Close);
            this.pnl_SearchImage.Controls.Add(this.btn_Previous);
            this.pnl_SearchImage.Controls.Add(this.btn_Next);
            this.pnl_SearchImage.Controls.Add(this.dtp_Mrp_date);
            this.pnl_SearchImage.Controls.Add(this.lbl_Dash);
            this.pnl_SearchImage.Controls.Add(this.lbl_Prod_Ymd);
            this.pnl_SearchImage.Controls.Add(this.dtp_From_Date);
            this.pnl_SearchImage.Controls.Add(this.dtp_To_Date);
            this.pnl_SearchImage.Controls.Add(this.lbl_MRP_No);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_Factory);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_title);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(8, 8);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1000, 96);
            this.pnl_SearchImage.TabIndex = 19;
            // 
            // chk_Close
            // 
            this.chk_Close.Location = new System.Drawing.Point(112, 64);
            this.chk_Close.Name = "chk_Close";
            this.chk_Close.Size = new System.Drawing.Size(16, 24);
            this.chk_Close.TabIndex = 498;
            this.chk_Close.Visible = false;
            // 
            // lbl_Close
            // 
            this.lbl_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Close.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Close.ImageIndex = 0;
            this.lbl_Close.ImageList = this.img_Label;
            this.lbl_Close.Location = new System.Drawing.Point(11, 64);
            this.lbl_Close.Name = "lbl_Close";
            this.lbl_Close.Size = new System.Drawing.Size(100, 21);
            this.lbl_Close.TabIndex = 497;
            this.lbl_Close.Text = "Close";
            this.lbl_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Close.Visible = false;
            // 
            // btn_Previous
            // 
            this.btn_Previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Previous.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Previous.Location = new System.Drawing.Point(784, 64);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(95, 23);
            this.btn_Previous.TabIndex = 496;
            this.btn_Previous.Text = "Previous";
            this.btn_Previous.UseVisualStyleBackColor = false;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Next.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(895, 64);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(95, 23);
            this.btn_Next.TabIndex = 495;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // dtp_Mrp_date
            // 
            this.dtp_Mrp_date.CustomFormat = "yyyyMMdd";
            this.dtp_Mrp_date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Mrp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Mrp_date.Location = new System.Drawing.Point(445, 41);
            this.dtp_Mrp_date.Name = "dtp_Mrp_date";
            this.dtp_Mrp_date.Size = new System.Drawing.Size(211, 21);
            this.dtp_Mrp_date.TabIndex = 491;
            // 
            // lbl_Dash
            // 
            this.lbl_Dash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Dash.Location = new System.Drawing.Point(878, 42);
            this.lbl_Dash.Name = "lbl_Dash";
            this.lbl_Dash.Size = new System.Drawing.Size(14, 20);
            this.lbl_Dash.TabIndex = 487;
            this.lbl_Dash.Text = "~";
            // 
            // lbl_Prod_Ymd
            // 
            this.lbl_Prod_Ymd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Prod_Ymd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prod_Ymd.ImageIndex = 0;
            this.lbl_Prod_Ymd.ImageList = this.img_Label;
            this.lbl_Prod_Ymd.Location = new System.Drawing.Point(683, 40);
            this.lbl_Prod_Ymd.Name = "lbl_Prod_Ymd";
            this.lbl_Prod_Ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Prod_Ymd.TabIndex = 486;
            this.lbl_Prod_Ymd.Text = "Prod Date";
            this.lbl_Prod_Ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_From_Date
            // 
            this.dtp_From_Date.CustomFormat = "yyyyMMdd";
            this.dtp_From_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_From_Date.Location = new System.Drawing.Point(784, 41);
            this.dtp_From_Date.Name = "dtp_From_Date";
            this.dtp_From_Date.Size = new System.Drawing.Size(95, 21);
            this.dtp_From_Date.TabIndex = 485;
            // 
            // dtp_To_Date
            // 
            this.dtp_To_Date.CustomFormat = "yyyyMMdd";
            this.dtp_To_Date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_To_Date.Location = new System.Drawing.Point(895, 41);
            this.dtp_To_Date.Name = "dtp_To_Date";
            this.dtp_To_Date.Size = new System.Drawing.Size(95, 21);
            this.dtp_To_Date.TabIndex = 484;
            // 
            // lbl_MRP_No
            // 
            this.lbl_MRP_No.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_MRP_No.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MRP_No.ImageIndex = 0;
            this.lbl_MRP_No.ImageList = this.img_Label;
            this.lbl_MRP_No.Location = new System.Drawing.Point(344, 40);
            this.lbl_MRP_No.Name = "lbl_MRP_No";
            this.lbl_MRP_No.Size = new System.Drawing.Size(100, 21);
            this.lbl_MRP_No.TabIndex = 40;
            this.lbl_MRP_No.Text = "MRP No";
            this.lbl_MRP_No.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style1;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(112, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 35;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(11, 39);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 36;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(899, 25);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 56);
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
            this.picb_TM.Size = new System.Drawing.Size(776, 32);
            this.picb_TM.TabIndex = 0;
            this.picb_TM.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_title.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Navy;
            this.lbl_title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_title.Image")));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(231, 30);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "      MRP Manager";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(984, 81);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 80);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(840, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 81);
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
            this.picb_ML.Size = new System.Drawing.Size(211, 63);
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
            this.picb_MM.Size = new System.Drawing.Size(832, 56);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // tab_Sheet
            // 
            this.tab_Sheet.Controls.Add(this.tab_Lot);
            this.tab_Sheet.Controls.Add(this.tab_Error);
            this.tab_Sheet.Controls.Add(this.tab_Usage);
            this.tab_Sheet.Controls.Add(this.tab_OA);
            this.tab_Sheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Sheet.Location = new System.Drawing.Point(0, 192);
            this.tab_Sheet.Name = "tab_Sheet";
            this.tab_Sheet.SelectedIndex = 0;
            this.tab_Sheet.Size = new System.Drawing.Size(1016, 452);
            this.tab_Sheet.TabIndex = 0;            
            this.tab_Sheet.TabIndexChanged += new System.EventHandler(this.tab_Sheet_SelectedIndexChanged);
            this.tab_Sheet.SelectedIndexChanged += new System.EventHandler(this.tab_Sheet_SelectedIndexChanged);
            // 
            // tab_Lot
            // 
            this.tab_Lot.Controls.Add(this.pnl_grid);
            this.tab_Lot.Location = new System.Drawing.Point(4, 23);
            this.tab_Lot.Name = "tab_Lot";
            this.tab_Lot.Size = new System.Drawing.Size(1008, 425);
            this.tab_Lot.TabIndex = 4;
            this.tab_Lot.Text = "1 - Lot";
            this.tab_Lot.UseVisualStyleBackColor = true;
            // 
            // pnl_grid
            // 
            this.pnl_grid.Controls.Add(this.fgrid_Lot);
            this.pnl_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_grid.Location = new System.Drawing.Point(0, 0);
            this.pnl_grid.Name = "pnl_grid";
            this.pnl_grid.Size = new System.Drawing.Size(1008, 425);
            this.pnl_grid.TabIndex = 107;
            // 
            // fgrid_Lot
            // 
            this.fgrid_Lot.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Lot.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Lot.ContextMenu = this.ctm_Menu;
            this.fgrid_Lot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Lot.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Lot.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Lot.Name = "fgrid_Lot";
            this.fgrid_Lot.Rows.DefaultSize = 18;
            this.fgrid_Lot.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Lot.Size = new System.Drawing.Size(1008, 425);
            this.fgrid_Lot.StyleInfo = resources.GetString("fgrid_Lot.StyleInfo");
            this.fgrid_Lot.TabIndex = 106;
            this.fgrid_Lot.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Lot_AfterEdit);
            this.fgrid_Lot.Click += new System.EventHandler(this.fgrid_Lot_Click);
            this.fgrid_Lot.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Lot_BeforeEdit);
            this.fgrid_Lot.EnterCell += new System.EventHandler(this.fgrid_Lot_EnterCell);
            // 
            // ctm_Menu
            // 
            this.ctm_Menu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_IncludingMrp,
            this.mnt_NotIncludingMrp,
            this.mnt_Bar1,
            this.mnt_Ready,
            this.mnt_Editing,
            this.mnt_Confirmed,
            this.mnt_Canceled,
            this.mnt_Closed,
            this.mnt_Bar2,
            this.mnt_Mrp,
            this.mnt_Bar3,
            this.mnt_MRP_Check,
            this.mnt_MRP_UnCheck});
            // 
            // mnt_IncludingMrp
            // 
            this.mnt_IncludingMrp.Index = 0;
            this.mnt_IncludingMrp.Text = "Including";
            // 
            // mnt_NotIncludingMrp
            // 
            this.mnt_NotIncludingMrp.Index = 1;
            this.mnt_NotIncludingMrp.Text = "Not Including";
            // 
            // mnt_Bar1
            // 
            this.mnt_Bar1.Index = 2;
            this.mnt_Bar1.Text = "-";
            // 
            // mnt_Ready
            // 
            this.mnt_Ready.Index = 3;
            this.mnt_Ready.Text = "Ready";
            // 
            // mnt_Editing
            // 
            this.mnt_Editing.Index = 4;
            this.mnt_Editing.Text = "Editing";
            this.mnt_Editing.Click += new System.EventHandler(this.mnt_Editing_Click);
            // 
            // mnt_Confirmed
            // 
            this.mnt_Confirmed.Index = 5;
            this.mnt_Confirmed.Text = "Confirmed";
            this.mnt_Confirmed.Click += new System.EventHandler(this.mnt_Confirmed_Click);
            // 
            // mnt_Canceled
            // 
            this.mnt_Canceled.Index = 6;
            this.mnt_Canceled.Text = "Canceled";
            // 
            // mnt_Closed
            // 
            this.mnt_Closed.Index = 7;
            this.mnt_Closed.Text = "Closed";
            // 
            // mnt_Bar2
            // 
            this.mnt_Bar2.Index = 8;
            this.mnt_Bar2.Text = "-";
            // 
            // mnt_Mrp
            // 
            this.mnt_Mrp.Index = 9;
            this.mnt_Mrp.Text = "Mrp Division";
            // 
            // mnt_Bar3
            // 
            this.mnt_Bar3.Index = 10;
            this.mnt_Bar3.Text = "-";
            // 
            // mnt_MRP_Check
            // 
            this.mnt_MRP_Check.Index = 11;
            this.mnt_MRP_Check.Text = "Check";
            this.mnt_MRP_Check.Click += new System.EventHandler(this.mnt_MRP_Check_Click);
            // 
            // mnt_MRP_UnCheck
            // 
            this.mnt_MRP_UnCheck.Index = 12;
            this.mnt_MRP_UnCheck.Text = "UnCheck";
            this.mnt_MRP_UnCheck.Click += new System.EventHandler(this.mnt_MRP_UnCheck_Click);
            // 
            // tab_Error
            // 
            this.tab_Error.Controls.Add(this.fgrid_Error);
            this.tab_Error.Location = new System.Drawing.Point(4, 23);
            this.tab_Error.Name = "tab_Error";
            this.tab_Error.Size = new System.Drawing.Size(1008, 425);
            this.tab_Error.TabIndex = 0;
            this.tab_Error.Text = "2.1 - Error";
            this.tab_Error.UseVisualStyleBackColor = true;
            // 
            // fgrid_Error
            // 
            this.fgrid_Error.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Error.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_Error.ContextMenu = this.ctm_Base;
            this.fgrid_Error.Cursor = System.Windows.Forms.Cursors.Default;
            this.fgrid_Error.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_Error.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_Error.Location = new System.Drawing.Point(0, 0);
            this.fgrid_Error.Name = "fgrid_Error";
            this.fgrid_Error.Rows.DefaultSize = 18;
            this.fgrid_Error.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_Error.Size = new System.Drawing.Size(1008, 425);
            this.fgrid_Error.StyleInfo = resources.GetString("fgrid_Error.StyleInfo");
            this.fgrid_Error.TabIndex = 105;
            this.fgrid_Error.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Error_AfterEdit);
            this.fgrid_Error.Click += new System.EventHandler(this.fgrid_Error_Click);
            this.fgrid_Error.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_Error_BeforeEdit);
            this.fgrid_Error.DoubleClick += new System.EventHandler(this.fgrid_Error_DoubleClick);
            // 
            // ctm_Base
            // 
            this.ctm_Base.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Spec});
            // 
            // mnt_Spec
            // 
            this.mnt_Spec.Index = 0;
            this.mnt_Spec.Text = "Value Change";
            this.mnt_Spec.Click += new System.EventHandler(this.mnt_Spec_Click);
            // 
            // tab_Usage
            // 
            this.tab_Usage.Controls.Add(this.fgrid_MRP);
            this.tab_Usage.Location = new System.Drawing.Point(4, 23);
            this.tab_Usage.Name = "tab_Usage";
            this.tab_Usage.Size = new System.Drawing.Size(1008, 425);
            this.tab_Usage.TabIndex = 1;
            this.tab_Usage.Text = "2.2 - MRP Use";
            this.tab_Usage.UseVisualStyleBackColor = true;
            this.tab_Usage.Visible = false;
            // 
            // fgrid_MRP
            // 
            this.fgrid_MRP.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_MRP.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_MRP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_MRP.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_MRP.Location = new System.Drawing.Point(0, 0);
            this.fgrid_MRP.Name = "fgrid_MRP";
            this.fgrid_MRP.Rows.DefaultSize = 18;
            this.fgrid_MRP.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_MRP.Size = new System.Drawing.Size(1008, 425);
            this.fgrid_MRP.StyleInfo = resources.GetString("fgrid_MRP.StyleInfo");
            this.fgrid_MRP.TabIndex = 105;
            this.fgrid_MRP.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MRP_AfterEdit);
            this.fgrid_MRP.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_MRP_BeforeEdit);
            // 
            // tab_OA
            // 
            this.tab_OA.BackColor = System.Drawing.Color.White;
            this.tab_OA.Controls.Add(this.fgrid_OA);
            this.tab_OA.ForeColor = System.Drawing.Color.Black;
            this.tab_OA.Location = new System.Drawing.Point(4, 23);
            this.tab_OA.Name = "tab_OA";
            this.tab_OA.Size = new System.Drawing.Size(1008, 425);
            this.tab_OA.TabIndex = 3;
            this.tab_OA.Text = "3.1 - Bom Change";
            this.tab_OA.UseVisualStyleBackColor = true;
            this.tab_OA.Visible = false;
            // 
            // fgrid_OA
            // 
            this.fgrid_OA.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_OA.ColumnInfo = "10,1,0,0,0,90,Columns:";
            this.fgrid_OA.ContextMenu = this.ctm_OA;
            this.fgrid_OA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_OA.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgrid_OA.Location = new System.Drawing.Point(0, 0);
            this.fgrid_OA.Name = "fgrid_OA";
            this.fgrid_OA.Rows.DefaultSize = 18;
            this.fgrid_OA.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgrid_OA.Size = new System.Drawing.Size(1008, 425);
            this.fgrid_OA.StyleInfo = resources.GetString("fgrid_OA.StyleInfo");
            this.fgrid_OA.TabIndex = 105;
            this.fgrid_OA.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OA_AfterEdit);
            this.fgrid_OA.Click += new System.EventHandler(this.fgrid_OA_Click);
            this.fgrid_OA.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_OA_BeforeEdit);
            this.fgrid_OA.EnterCell += new System.EventHandler(this.fgrid_OA_EnterCell);
            // 
            // ctm_OA
            // 
            this.ctm_OA.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Mrp_Div,
            this.mnt_Mrp_Sel_Change,
            this.mnt_Bom,
            this.mnt_Material,
            this.mnt_OA_Check,
            this.mnt_OA_Uncheck,
            this.mnt_Text_Change});
            // 
            // mnt_Mrp_Div
            // 
            this.mnt_Mrp_Div.Index = 0;
            this.mnt_Mrp_Div.Text = "Mrp Division";
            this.mnt_Mrp_Div.Click += new System.EventHandler(this.mnt_Mrp_Div_Click);
            // 
            // mnt_Mrp_Sel_Change
            // 
            this.mnt_Mrp_Sel_Change.Index = 1;
            this.mnt_Mrp_Sel_Change.Text = "Mrp Selected/Change";
            this.mnt_Mrp_Sel_Change.Click += new System.EventHandler(this.mnt_Mrp_Sel_Change_Click);
            // 
            // mnt_Bom
            // 
            this.mnt_Bom.Index = 2;
            this.mnt_Bom.Text = "Bom";
            this.mnt_Bom.Click += new System.EventHandler(this.mnt_Bom_Click);
            // 
            // mnt_Material
            // 
            this.mnt_Material.Index = 3;
            this.mnt_Material.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Material_New,
            this.mnt_Material_Old});
            this.mnt_Material.Text = "Material";
            // 
            // mnt_Material_New
            // 
            this.mnt_Material_New.Index = 0;
            this.mnt_Material_New.Text = "New Material";
            this.mnt_Material_New.Click += new System.EventHandler(this.mnt_Material_New_Click);
            // 
            // mnt_Material_Old
            // 
            this.mnt_Material_Old.Index = 1;
            this.mnt_Material_Old.Text = "Old Material";
            this.mnt_Material_Old.Click += new System.EventHandler(this.mnt_Material_Old_Click);
            // 
            // mnt_OA_Check
            // 
            this.mnt_OA_Check.Index = 4;
            this.mnt_OA_Check.Text = "Check";
            this.mnt_OA_Check.Click += new System.EventHandler(this.mnt_OA_Check_Click);
            // 
            // mnt_OA_Uncheck
            // 
            this.mnt_OA_Uncheck.Index = 5;
            this.mnt_OA_Uncheck.Text = "UnCheck";
            this.mnt_OA_Uncheck.Click += new System.EventHandler(this.mnt_OA_Uncheck_Click);
            // 
            // mnt_Text_Change
            // 
            this.mnt_Text_Change.Index = 6;
            this.mnt_Text_Change.Text = "Value Change";
            this.mnt_Text_Change.Click += new System.EventHandler(this.mnt_Text_Change_Click);
            // 
            // ctm_Status
            // 
            this.ctm_Status.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnt_Editing_Item,
            this.mnt_Confirmed_Item});
            // 
            // mnt_Editing_Item
            // 
            this.mnt_Editing_Item.Index = 0;
            this.mnt_Editing_Item.Text = "Editing";
            // 
            // mnt_Confirmed_Item
            // 
            this.mnt_Confirmed_Item.Index = 1;
            this.mnt_Confirmed_Item.Text = "Confirmed";
            // 
            // Form_MRP_Check
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.tab_Sheet);
            this.Controls.Add(this.pnl_Search);
            this.Name = "Form_MRP_Check";
            this.Text = "Pcc_MRP Manager";
            this.Load += new System.EventHandler(this.Form_MRP_Check_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.pnl_Search, 0);
            this.Controls.SetChildIndex(this.tab_Sheet, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_Search.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            this.tab_Sheet.ResumeLayout(false);
            this.tab_Lot.ResumeLayout(false);
            this.pnl_grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Lot)).EndInit();
            this.tab_Error.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Error)).EndInit();
            this.tab_Usage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_MRP)).EndInit();
            this.tab_OA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_OA)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region 사용자정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        private COM.ComFunction MyComFunction = new COM.ComFunction();

        private string _Level1 = "1", _Level2 = "2", _Level3 = "3", _Level4 = "4", _Level5 = "5";
        private string _Create = ClassLib.ComVar.ConsCDC_Y;
        private DataTable _dt_list;

        private string _ByBom = "B";
        private string _ByMat = "M";
        private string _MatLevel = "4";
        private string _Error = "N";

        private int _col1 = 0, _col2 = 0, _row1 = 0, _row2 = 0;
        #endregion

        #region Form Loading
        private void Form_MRP_Check_Load(object sender, System.EventArgs e)
        {
            DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List_CDC();
            ClassLib.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code);
            cmb_Factory.SelectedValue = ClassLib.ComVar.This_CDC_Factory;            
        }
        private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
        {
            ClassLib.ComVar.This_CDC_Factory = cmb_Factory.SelectedValue.ToString();
            Init_Form();
        }

        private void Init_Form()
        {
            try
            {
                this.Text = "PCC_MRP";
                this.lbl_MainTitle.Text = "PCC_MRP";
                this.lbl_title.Text = "      MRP Information";

                ClassLib.ComFunction.SetLangDic(this);

                #region 버튼 권한
                tbtn_New.Enabled     = true;
                tbtn_Save.Enabled    = true;
                tbtn_Search.Enabled  = true;
                tbtn_Create.Enabled  = true;
                tbtn_Append.Enabled  = false;
                tbtn_Color.Enabled   = false;
                tbtn_Confirm.Enabled = false;
                tbtn_Delete.Enabled  = false;
                tbtn_Insert.Enabled  = false;
                tbtn_Print.Enabled   = false;

                tbtn_Create.ToolTipText  = "Create";
                tbtn_Confirm.ToolTipText = "Confirm";
                #endregion

                #region 첫 Sheet Setting
                tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_0);

                //TBSXD_MRP_MANAGER
                fgrid_Lot.Set_Grid_CDC("SXD_MRP_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                fgrid_Lot.Set_Action_Image(img_Action);
                fgrid_Lot.Font = new Font("Verdana", 8);

                btn_Next.ForeColor = Color.Red;
                btn_Previous.Enabled = false;

                tbtn_Print.Enabled = true;
                #endregion

                #region 속성 설정

                DataTable dt_list;

                tbtn_Create_Click(null, null);

                dt_list = ClassLib.ComFunction.Select_MRP_Date(cmb_Factory.SelectedValue.ToString());

                if (dt_list.Rows[0].ItemArray[0].ToString() != "")
                {
                    dtp_Mrp_date.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[0].ToString()));
                    dtp_Mrp_date.Enabled = false;
                }

                dt_list = ClassLib.ComFunction.Select_MRP_Prod_Date(cmb_Factory.SelectedValue.ToString(), dtp_From_Date.Value.ToString("yyyyMMdd"));

                if (dt_list.Rows[0].ItemArray[0].ToString() != "")
                {
                    dtp_From_Date.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[0].ToString()));
                    dtp_To_Date.Value = Convert.ToDateTime(MyComFunction.ConvertDate2Type(dt_list.Rows[0].ItemArray[1].ToString()));
                }

                chk_Close.Checked = true;
                #endregion
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.ToString(), "Init_Form()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion

        #region Tab Sheet Event
        private void tab_Sheet_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();

                switch (vTabPosition)
                {                    
                    case ClassLib.ComVar.ConsCDC_MoveSheet_0: 
                    {
                        #region 1st Tab
                        fgrid_Lot.Set_Grid_CDC("SXD_MRP_MANAGER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        fgrid_Lot.Set_Action_Image(img_Action);
                        fgrid_Lot.Font = new Font("Verdana", 8);

                        cmb_Factory.Enabled   = true;
                        dtp_Mrp_date.Enabled  = true;
                        dtp_From_Date.Enabled = true;
                        dtp_To_Date.Enabled   = true;

                        tbtn_Create_Click(null, null);
                        btn_Next.ForeColor   = Color.Red;
                        btn_Next.Enabled     = true;
                        btn_Previous.Enabled = false;
                        tbtn_Confirm.Enabled = false;

                        chk_Close.Visible = false;
                        chk_Close.Checked = false;
                        lbl_Close.Visible = false;
                        lbl_Close.Text = "MRP Flag";

                        tbtn_Create.ToolTipText = "Create";
                        btn_Previous.Enabled = false;

                        tbtn_Print.Enabled = true;

                        break;
                        #endregion
                    }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_1:
                    {
                        #region 2nd Tab
                        fgrid_Error.Set_Grid_CDC("SXD_ERR_CHECK_ERROR", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        fgrid_Error.Set_Action_Image(img_Action);
                        fgrid_Error.Font = new Font("Verdana", 8);
                        fgrid_Error.Rows.Count = fgrid_Error.Rows.Fixed;

                        cmb_Factory.Enabled = false;
                        dtp_Mrp_date.Enabled = false;
                        dtp_From_Date.Enabled = false;
                        dtp_To_Date.Enabled = false;

                        tbtn_Create_Click(null, null);
                        btn_Next.ForeColor = Color.Red;
                        btn_Next.Enabled = true;
                        btn_Previous.Enabled = true;
                        tbtn_Confirm.Enabled = false;

                        chk_Close.Visible = false;
                        chk_Close.Checked = false;
                        lbl_Close.Visible = false;
                        lbl_Close.Text = "MRP Flag";

                        tbtn_Create.ToolTipText = "Create";
                        _Error = ClassLib.ComVar.ConsCDC_Y;

                        if (fgrid_Error.Rows.Count > fgrid_Error.Rows.Fixed)
                        {
                            btn_Next.Enabled = false;
                            tab_Sheet.SelectedIndex = 1;
                        }
                        else btn_Next.Enabled = true;
                        btn_Previous.Enabled = true;

                        tbtn_Print.Enabled = false;
                        break;
                        #endregion
                    }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_2:
                    {
                        #region 3rd Tab
                        if ((fgrid_Error.Rows.Count > fgrid_Error.Rows.Fixed) || (_Error != ClassLib.ComVar.ConsCDC_Y))
                        {
                            btn_Next.Enabled = false;
                            tab_Sheet.SelectedIndex = 1;

                            return;
                        }
                        btn_Next.Enabled = true;

                        //TBSXD_ERR_CHECK_MRP
                        fgrid_MRP.Set_Grid_CDC("SXD_ERR_CHECK_MRP", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        fgrid_MRP.Set_Action_Image(img_Action);
                        fgrid_MRP.Font = new Font("Verdana", 8);

                        cmb_Factory.Enabled = false;
                        dtp_Mrp_date.Enabled = false;
                        dtp_From_Date.Enabled = false;
                        dtp_To_Date.Enabled = false;

                        tbtn_Search_Click(null, null);
                        btn_Next.ForeColor = Color.Red;
                        btn_Next.Enabled = true;
                        btn_Previous.Enabled = true;
                        tbtn_Confirm.Enabled = false;

                        chk_Close.Visible = true;
                        chk_Close.Checked = true;
                        lbl_Close.Visible = true;
                        lbl_Close.Text = "MRP Flag";

                        tbtn_Create.ToolTipText = "Create";
                        btn_Previous.Enabled = true;

                        tbtn_Print.Enabled = false;
                        break;
                        #endregion
                    }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                    {
                        #region 4th Tab
                        if ((fgrid_Error.Rows.Count > fgrid_Error.Rows.Fixed) || (_Error != ClassLib.ComVar.ConsCDC_Y))
                        {
                            btn_Next.Enabled = false;
                            tab_Sheet.SelectedIndex = 1;
                            return;
                        }
                        btn_Next.Enabled = true;

                        //TBSXD_ERR_CHECK_MRP
                        fgrid_OA.Set_Grid_CDC("SXD_ERR_CHECK_OA", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
                        fgrid_OA.Set_Action_Image(img_Action);
                        fgrid_OA.Font = new Font("Verdana", 8);

                        cmb_Factory.Enabled = false;
                        dtp_Mrp_date.Enabled = false;
                        dtp_From_Date.Enabled = false;
                        dtp_To_Date.Enabled = false;

                        //MessageBox.Show("초기작업");
                        tbtn_Create_Click(null, null);
                        btn_Next.ForeColor = Color.Black;
                        btn_Next.Enabled = true;
                        btn_Previous.Enabled = true;
                        tbtn_Confirm.Enabled = true;

                        chk_Close.Visible = true;
                        chk_Close.Checked = true;
                        lbl_Close.Visible = true;
                        lbl_Close.Text = "MRP Flag";

                        _MatLevel = "4";

                        btn_Previous.Enabled = true;

                        tbtn_Print.Enabled = false;
                        break;
                        #endregion
                    }                    
                    default:
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.ToString(), "tab_Sheet_SelectedIndexChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }            
        }        
        #endregion
        
        #region 공통 메쏘드
        #region Create Button Click Event
        private void Do_Lot()
        {
            if (Save_MRP_Plan_Lot(cmb_Factory.SelectedValue.ToString(),
                ClassLib.ComFunction.Empty_String(dtp_From_Date.Text.Replace("-", ""), " "),
                ClassLib.ComFunction.Empty_String(dtp_From_Date.Text.Replace("-", ""), " ")) != true)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.User_Message("Making MRP Lot", "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }            
        }
        private bool Save_MRP_Plan_Lot(string arg_factory, string arg_from, string arg_to)
        {
            string Proc_Name = "PKG_SXM_MRP_01.SAVE_SXM_MRP_REQ_LOT";

            int vCount = 4, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[b++] = arg_factory;
            MyOraDB.Parameter_Values[b++] = (_Create == ClassLib.ComVar.ConsCDC_N) ? MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8)) : " ";
            MyOraDB.Parameter_Values[b++] = (_Create == ClassLib.ComVar.ConsCDC_N) ? MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8)) : " ";
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            MyOraDB.Exe_Modify_Procedure();

            return true;
        }

        private void Do_Error()
        {
            if (Insert_Mrp_Error() != true)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.User_Message("Making MRP Error", "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private bool Insert_Mrp_Error()
        {
            string Proc_Name = "PKG_SXM_MRP_02.INSERT_SXM_MRP_REQ_ERR";

            int vCount = 2, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

            return true;
        }

        private void Do_OA()
        {
            if (Save_Mrp_Item() != true)    //Mrp Item Make....
            {
                ClassLib.ComFunction.User_Message("Making MRP Usage", "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //try
            //{
            //    _dt_list = null;
            //    // Threading //
            //    _pop = new FlexCDC.BaseInfo.Pop_MaterialXML_Wait();
            //    Thread vCreate = new Thread(new ThreadStart(Save_Mrp_Item()));
            //    vCreate.Start();
            //    _pop.Start();
            //}
            //catch (Exception ex)
            //{
            //    ClassLib.ComFunction.User_Message(ex.ToString(), "Search_OA_Threading()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    _pop.Close();
            //}
            

        }
        private bool Save_Mrp_Item()
        {
            string Proc_Name = "PKG_SXM_MRP_02.SAVE_SXM_MRP_REQ_ITEM";

            int vCount = 4, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

            return true;
        }

        private void Do_Material_Stock()
        {
            if (Save_MRP_Req_Item() != true)
            {
                ClassLib.ComFunction.User_Message("Confirm MRP Usage", "Confirm Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool Save_MRP_Req_Item()
        {
            string Proc_Name = "PKG_SXM_MRP_03.SAVE_SXM_MRP_REQ_ITEM";

            int vCount = 2, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

            return true;
        }
        #endregion

        #region Search Button Click Event
        private void Set_Lot()
        {
            DataTable dt_list = Select_MRP_Plan_Lot();
            DisPlay_Grid_Lot(dt_list, fgrid_Lot);
        }
        private void DisPlay_Grid_Lot(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_fgrid.Rows.Count = arg_fgrid.Rows.Count + 1;

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    if (arg_fgrid.Cols[j + 1].DataType.Equals(typeof(bool)))
                    {
                        if (arg_dt.Rows[i].ItemArray[j].ToString() == "") continue;

                        CellStyle cs = arg_fgrid.Styles.Add("bool");
                        cs.DataType = typeof(bool);
                        cs.ImageAlign = ImageAlignEnum.CenterCenter;


                        CellRange rg = arg_fgrid.GetCellRange(arg_fgrid.Rows.Fixed + i, j + 1);
                        rg.Style = arg_fgrid.Styles["bool"];

                        arg_fgrid[arg_fgrid.Rows.Fixed + i, j + 1] = (arg_dt.Rows[i].ItemArray[j].ToString() == ClassLib.ComVar.ConsCDC_Y) ? "True" : "False";
                    }
                    else
                    {
                        arg_fgrid[arg_fgrid.Rows.Count - 1, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                    }
                    arg_fgrid[arg_fgrid.Rows.Fixed + i, 0] = "";
                }
            }
        }

        private void Set_Error()
        {
            DataTable dt_list = Select_Error();
            DisPlay_Grid_Error(dt_list, fgrid_Error);
        }
        private void DisPlay_Grid_Error(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
            int vTreeLevelCol = (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxITEM_01, vTreeLevel = 1;
            arg_fgrid.Tree.Column = vTreeLevelCol;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                vTreeLevel = Convert.ToInt16(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString());
                arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Count, vTreeLevel);

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[arg_fgrid.Rows.Fixed + i, j] = arg_dt.Rows[i].ItemArray[j].ToString();
                }

                arg_fgrid[arg_fgrid.Rows.Fixed + i, 0] = "";
                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() == _Level1)
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;
                    arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = false;
                }
                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() == _Level2)
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Black;
                    arg_fgrid.Rows[arg_fgrid.Rows.Count - 1].AllowEditing = true;
                }
            }
        }

        private void Set_MRP()
        {
            DataTable dt_list = Select_MRP();
            DisPlay_Grid(dt_list, fgrid_MRP);
        }
        private void DisPlay_Grid(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                arg_fgrid.AddItem(arg_dt.Rows[i].ItemArray, arg_fgrid.Rows.Count, 0);
                arg_fgrid[i, 0] = "";
            }
        }

        private void Set_OA()
        {
            _dt_list = Select_OA();            
        }
        private void DisPlay_Grid_OA(DataTable arg_dt, COM.FSP arg_fgrid)
        {
            arg_fgrid.Rows.Count = arg_fgrid.Rows.Fixed;
            int vTreeLevelCol = (int)ClassLib.TBSXD_ERR_CHECK_OA.lxITEM_01, vTreeLevel = 1;
            arg_fgrid.Tree.Column = vTreeLevelCol;

            for (int i = 0; i < arg_dt.Rows.Count; i++)
            {
                vTreeLevel = Convert.ToInt16(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL - 1].ToString());
                arg_fgrid.Rows.InsertNode(arg_fgrid.Rows.Count, vTreeLevel);

                for (int j = 0; j < arg_dt.Columns.Count; j++)
                {
                    arg_fgrid[arg_fgrid.Rows.Fixed + i, j + 1] = arg_dt.Rows[i].ItemArray[j].ToString();
                }
                arg_fgrid[arg_fgrid.Rows.Fixed + i, 0] = "";

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level1)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Red;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level2)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Blue;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level3)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Violet;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level4)
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Black;

                if (arg_fgrid[arg_fgrid.Rows.Count - 1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level5)
                {
                    arg_fgrid.GetCellRange(arg_fgrid.Rows.Count - 1, 0, arg_fgrid.Rows.Count - 1, arg_fgrid.Cols.Count - 1).StyleNew.ForeColor = Color.Gray;
                    arg_fgrid.Rows[i].AllowEditing = false;
                }
            }
        }        
        #endregion

        #region Save Button Click Event
        private void Set_Flag_Clear(COM.FSP arg_fgrid)
        {
            for (int i = arg_fgrid.Rows.Fixed; i < arg_fgrid.Rows.Count; i++)
                arg_fgrid[i, 0] = "";
        }

        private bool Save_Lot()
        {
            fgrid_MRP.Select(fgrid_MRP.Selection.r1, fgrid_MRP.Selection.c1);

            if (Save_Mrp_Close_Change() != true)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return false;
            }
            return true;
        }
        private bool Save_Mrp_Close_Change()
        {
            DataSet ds_ret;
            bool vSaveFlag = false;
            //vSaveFlag =  Save_Mrp_Close();
            vSaveFlag = true;

            if (!vSaveFlag)
            {
                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return false;
            }
            else
            {
                vSaveFlag = Save_Mrp_Change();

                if (!vSaveFlag)
                {
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                    return false;
                }
                else
                {
                    ds_ret = MyOraDB.Exe_Modify_Procedure();

                    if (ds_ret == null)
                    {
                        ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private bool Save_Err_Code()
        {
            fgrid_Error.Select(fgrid_Error.Selection.r1, fgrid_Error.Selection.c1);

            if (Save_Err_Code_Mat() != true)
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave, this);
                return false;
            }
            return true;
        }
        //private bool Save_Err_Code()
        //{
        //    DataSet ds_ret;
        //    bool vSaveFlag = false;
        //    vSaveFlag =  Save_Err_Code_Mat();
        //    if(!vSaveFlag)
        //    {
        //        ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
        //        return false;
        //    }
        //    else
        //    {
        //        vSaveFlag = Save_Err_Code_SRF(); 
        //        if(!vSaveFlag)
        //        {
        //            ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
        //            return false;
        //        }
        //        else
        //        {
        //            ds_ret = MyOraDB.Exe_Modify_Procedure();	
        //            if(ds_ret == null)
        //            {
        //                ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
        //                return false;
        //            }
        //            else
        //            {						
        //                return true;
        //            } 
        //        }
        //    }
        //}
        #endregion

        #region Confirm Button Click Event
        private void Set_Mrp_key()
        {
            ClassLib.ComVar.ConsCDC_MRP_Factory = cmb_Factory.SelectedValue.ToString();
            ClassLib.ComVar.ConsCDC_MRP_MatDiv = "";
            ClassLib.ComVar.ConsCDC_MRP_No = MyComFunction.ConvertDate2DbType(dtp_Mrp_date.Value.ToString()).Substring(0, 8);
            ClassLib.ComVar.ConsCDC_MRP_ProdFrom = MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString()).Substring(0, 8);
            ClassLib.ComVar.ConsCDC_MRP_ProdTo = MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString()).Substring(0, 8);
        }
        #endregion
        #endregion

        #region 이벤트 처리

        #region Button Event
        private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();

                switch (vTabPosition)
                {
                    case ClassLib.ComVar.ConsCDC_MoveSheet_0:
                        {
                            fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed;
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_1:
                        {
                            fgrid_Error.Rows.Count = fgrid_Error.Rows.Fixed;
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_2:
                        {
                            fgrid_MRP.Rows.Count = fgrid_MRP.Rows.Fixed;
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                        {
                            fgrid_OA.Rows.Count = fgrid_OA.Rows.Fixed;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotClear, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_Create_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();
                
                switch (vTabPosition)
                {
                    case ClassLib.ComVar.ConsCDC_MoveSheet_0:
                        {
                            Do_Lot();
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_1:
                        {
                            Do_Error();
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_2:
                        {
                            //Do_M
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                        {
                            Do_OA();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                tbtn_Search_Click(null, null);
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.ToString(), "tbtn_Create_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();

                switch (vTabPosition)
                {
                    case ClassLib.ComVar.ConsCDC_MoveSheet_0:
                        {
                            fgrid_Lot.Rows.Count = fgrid_Lot.Rows.Fixed;
                            Set_Lot();
                            _Create = ClassLib.ComVar.ConsCDC_N;
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_1:
                        {
                            fgrid_Error.Rows.Count = fgrid_Error.Rows.Fixed;
                            Set_Error();
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_2:
                        {
                            fgrid_MRP.Rows.Count = fgrid_MRP.Rows.Fixed;
                            Set_MRP();
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                        {
                            fgrid_OA.Rows.Count = fgrid_OA.Rows.Fixed;
                            //MessageBox.Show("Select Query");
                            Set_OA();   //Thread....			
                            DisPlay_Grid_OA(_dt_list, fgrid_OA);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSearch, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();

                switch (vTabPosition)
                {
                    case ClassLib.ComVar.ConsCDC_MoveSheet_0:
                        {
                            Save_Lot();
                            Set_Flag_Clear(fgrid_Lot);
                            fgrid_Lot.Select(fgrid_Lot.Selection.r1, 0, fgrid_Lot.Selection.r1, fgrid_Lot.Cols.Count - 1);
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_1:
                        {
                            Save_Err_Code();
                            Do_Error();

                            tbtn_Search_Click(null, null);

                            if (fgrid_Error.Rows.Count > fgrid_Error.Rows.Fixed) btn_Next.Enabled = false;
                            else btn_Next.Enabled = true;
                            btn_Next.Enabled = true;

                            fgrid_Error.Select(fgrid_Error.Selection.r1, 0, fgrid_Error.Selection.r1, fgrid_Error.Cols.Count - 1);
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_2:
                        {
                            Save_MRP_Usage();
                            Set_Flag_Clear(fgrid_MRP);
                            fgrid_MRP.Select(fgrid_MRP.Selection.r1, 0, fgrid_MRP.Selection.r1, fgrid_MRP.Cols.Count - 1);
                            break;
                        }
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                        {
                            Save_OA();
                            Set_Flag_Clear(fgrid_OA);
                            fgrid_OA.Select(fgrid_OA.Selection.r1, fgrid_OA.Selection.c1, fgrid_OA.Selection.r1, fgrid_OA.Selection.c2);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string vTabPosition = tab_Sheet.SelectedIndex.ToString();

                switch (vTabPosition)
                {
                    case ClassLib.ComVar.ConsCDC_MoveSheet_3:
                        {
                            Save_OA();
                            Do_Material_Stock();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

                Set_Mrp_key();   //전역변수 Setting (mrp key)

                Form_MRP_Adjust vForm = new Form_MRP_Adjust();
                vForm.MdiParent = COM.ComVar.MDI_Parent;
                vForm.Show();

                this.Close();
                return;
            }
            catch
            {
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotRun, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string mrd_Filename = "";
                string sPara = "";


                string factory  = cmb_Factory.SelectedValue.ToString();
                string fromdate = MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8));
                string todate   = MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8));
                string close    = " ";

                mrd_Filename = Application.StartupPath + @"\MRP_Error_List" + ".mrd";
                sPara = " /rp " + "[" + factory + "]"
                                + " [" + fromdate + "]"
                                + " [" + todate + "]"
                                + " [" + close + "]";

                FlexCDC.Report.Form_RdViewer report = new FlexCDC.Report.Form_RdViewer(mrd_Filename, sPara);
                report.ShowDialog();
            }
            catch
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.Data_Message(COM.ComVar.MgsNotPrint, this);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private void btn_Previous_Click(object sender, System.EventArgs e)
        {
            tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_0);
        }
        private void btn_Next_Click(object sender, System.EventArgs e)
        {
            //			//변경 flag가 있는지 check
            //			if ((ClassLib.ComFunction.Check_Flag_FlexGird(fgrid_Lot)	 == false)  ||
            //				(ClassLib.ComFunction.Check_Flag_FlexGird(fgrid_Error)	 == false)  ||
            //				(ClassLib.ComFunction.Check_Flag_FlexGird(fgrid_MRP)	 == false)  ||
            //				(ClassLib.ComFunction.Check_Flag_FlexGird(fgrid_OA)		 == false)  ||
            //				(ClassLib.ComFunction.Check_Flag_FlexGird(fgrid_Lot)	 == false) )
            //			{
            //				DialogResult vDR =MessageBox.Show("Some data is modifed.. Do you ignore?", "Question",	MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //				if (vDR == DialogResult.No)
            //				{
            //					return;
            //				}
            //			}			
            if (tab_Sheet.SelectedIndex == Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_0))
            {
                for (int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
                {
                    if (fgrid_Lot[i, 0] == null) continue;

                    if (fgrid_Lot[i, 0].ToString() == "U")
                    { tbtn_Save_Click(null, null); break; }
                }

                tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_1);
                return;
            }
            if (tab_Sheet.SelectedIndex == Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_1))
            {
                tbtn_Save_Click(null, null);

                if (fgrid_Error.Rows.Count <= fgrid_Error.Rows.Fixed)
                {
                    tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_2);
                    return;
                }
                else
                {
                    return;
                }
            }
            if (tab_Sheet.SelectedIndex == Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_2))
            {
                tbtn_Save_Click(null, null);

                tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_3);
                return;
            }
            if (tab_Sheet.SelectedIndex == Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_3))
            {
                //tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_4);
                tbtn_Confirm_Click(null, null);
            }
            else
            {
                tab_Sheet.SelectedIndex = Convert.ToInt16(ClassLib.ComVar.ConsCDC_MoveSheet_3);
            }


        }
        #endregion

        #region Error Grid

         private void fgrid_Error_Click(object sender, EventArgs e)
        {
            int vcol = fgrid_Error.Selection.c1;

            ctm_Base.MenuItems[0].Visible = false;

            if ((vcol == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_UNIT) ||
                (vcol == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC_NAME)||
                (vcol == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC))
            {

                if (fgrid_Error[fgrid_Error.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString().Equals("1"))
                    ctm_Base.MenuItems[0].Visible = false;
                else
                    ctm_Base.MenuItems[0].Visible = true;
            }

        }

        private void fgrid_Error_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (fgrid_Error[fgrid_Error.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() != "2") return;

            if (fgrid_Error.Selection.c1 == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_DIV_DESC)
            {
                string vMat = fgrid_Error[fgrid_Error.Selection.r1, fgrid_Error.Selection.c1].ToString();

                for (int i = fgrid_Error.Selection.r1; i <= fgrid_Error.Selection.r2; i++)
                {
                    if (fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() == _Level1) continue;

                    if (fgrid_Error.Selection.c1 == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_DIV_DESC)
                    {
                        if ((fgrid_Error[fgrid_Error.Selection.r1, fgrid_Error.Selection.c1] == null)
                            || (fgrid_Error[fgrid_Error.Selection.r1, fgrid_Error.Selection.c1].ToString() == ""))
                        {
                            ClassLib.ComFunction.User_Message("Input Error", "fgrid_Error_AfterEdit()", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }

                        string[] vMatCol = vMat.Split('-');
                        fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_DIV] = vMatCol[0];
                        fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_DIV_DESC] = vMatCol[1];
                    }
                    fgrid_Error.Update_Row(i);
                }
            }
            else
            {
                string vValue = fgrid_Error[fgrid_Error.Selection.r1, fgrid_Error.Selection.c1].ToString();

                for (int i = fgrid_Error.Selection.r1; i <= fgrid_Error.Selection.r2; i++)
                {
                    if (fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() == _Level1) continue;

                    fgrid_Error[i, fgrid_Error.Selection.c1] = vValue;
                    fgrid_Error.Update_Row(i);
                }
            }
            fgrid_Error.Select(fgrid_Error.Selection.r1, 0, fgrid_Error.Selection.r2, fgrid_Error.Cols.Count - 1);
        }
        private void fgrid_Error_DoubleClick(object sender, System.EventArgs e)
        {

            if (fgrid_Error[fgrid_Error.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() != "2") return;

            #region 공통 코드 팝업
            int vCount = 17;
            int vRow1 = fgrid_Error.Selection.r1, vRow2 = fgrid_Error.Selection.r2;
            int vCol1 = fgrid_Error.Selection.c1;
            fgrid_Error.Select(vRow1, 0, vRow2, fgrid_Error.Cols.Count - 1);

            string vEdit_Type = "";

            if (vCol1 == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_UNIT) vEdit_Type = "U";
            else if (vCol1 == (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC_NAME) vEdit_Type = "U";
            else return;

            if (fgrid_Error[fgrid_Error.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLEVELS].ToString() == _Level1) return;

            COM.ComVar.Parameter_PopUp = new string[vCount];
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1] = fgrid_Error[vRow1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxFACTORY].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxCOLOR_DESC - 1] = fgrid_Error[vRow1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxITEM_05].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1] = fgrid_Error[vRow1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_UNIT].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1] = fgrid_Error[vRow1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1] = fgrid_Error[vRow1, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC_NAME].ToString();
            COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxPART_QTY - 1] = "";
            #endregion

            BaseInfo.Pop_Material_Master codeMaster = new FlexCDC.BaseInfo.Pop_Material_Master(vEdit_Type);
            codeMaster.ShowDialog();

            #region 공통 코드 팝업 다운
            for (int i = vRow1; i <= vRow2; i++)
            {
                fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxFACTORY] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxFACTORY - 1].ToString();

                fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_UNIT] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxUNIT_CD - 1].ToString();

                fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_CD - 1].ToString();
                fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC_NAME] = COM.ComVar.Parameter_PopUp[(int)ClassLib.SXD_MATERIAL_POP.lxSPEC_NAME - 1].ToString();

                fgrid_Error[i, 0] = "U";
            }
            #endregion
        }
        private void fgrid_Error_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                if ((fgrid_Error.Rows.Fixed > 0) && (fgrid_Error.Row >= fgrid_Error.Rows.Fixed))
                {
                    if (fgrid_Error.Cols[fgrid_Error.Col].DataType == typeof(bool))
                        fgrid_Error.Buffer_CellData = "";
                    else
                        fgrid_Error.Buffer_CellData = (fgrid_Error[fgrid_Error.Row, fgrid_Error.Col] == null) ? "" : fgrid_Error[fgrid_Error.Row, fgrid_Error.Col].ToString();
                }
            }
            catch
            {
            }
        }
        #endregion

        #region Lot Grid
        private void fgrid_Lot_Click(object sender, EventArgs e)
        {

        }
        private void fgrid_Lot_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            //			if (fgrid_Lot.Selection.r1< fgrid_Lot.Rows.Fixed) return;
            //			
            //			if ((fgrid_Lot[fgrid_Lot.Selection.r1,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS ]==null) ||
            //				(fgrid_Lot[fgrid_Lot.Selection.r1,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS ].ToString()=="" )) return;
            //
            //
            //			int vRow1 =fgrid_Lot.Selection.r1   ,  vRow2  = fgrid_Lot.Selection.r2,  vCol1  = fgrid_Lot.Selection.c1;
            //			for (int i=vRow1; i<= vRow2; i++)
            //			{
            //
            //
            //				//U Setting
            //				if ((fgrid_Lot[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS] ==null) ||  (fgrid_Lot[i,(int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() =="")) continue;
            //
            //				fgrid_Lot.Update_Row(i);		
            //				fgrid_Lot[i,vCol1] =  fgrid_Lot[vRow1, vCol1].ToString();
            //
            //
            //
            //				//음수 check
            //				if  ((vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR) &&
            //					(Convert.ToSingle(fgrid_Lot[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR].ToString()) <= 0))
            //				{
            //					fgrid_Lot[i,vCol1]  = fgrid_Lot.Buffer_CellData;
            //					fgrid_Lot[i,0]      ="";
            //					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput,this);
            //					return;
            //
            //				}
            //
            //				//수량변경시 mrp자동 check
            //
            //				if (vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR)  fgrid_Lot[i,(int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG] ="True";
            //
            //				
            //			}
        }
        private void fgrid_Lot_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if ((fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS] == null) ||
                (fgrid_Lot[fgrid_Lot.Selection.r1, (int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS].ToString() == "")) return;

            int vRow1 = fgrid_Lot.Selection.r1, vRow2 = fgrid_Lot.Selection.r2, vCol1 = fgrid_Lot.Selection.c1;
            for (int i = vRow1; i <= vRow2; i++)
            {
                //U Setting
                if ((fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS] == null) || (fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() == "")) continue;

                fgrid_Lot.Update_Row(i);
                fgrid_Lot[i, vCol1] = fgrid_Lot[vRow1, vCol1].ToString();

                //음수 check
                if ((vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR) &&
                    (Convert.ToSingle(fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR].ToString()) <= 0))
                {
                    fgrid_Lot[i, vCol1] = fgrid_Lot.Buffer_CellData;
                    fgrid_Lot[i, 0] = "";
                    ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsWrongInput, this);
                    return;
                }

                //수량변경시 mrp자동 check
                if (vCol1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR) fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG] = "True";
            }
        }
        private void fgrid_Lot_EnterCell(object sender, System.EventArgs e)
        {
            //if (e.Button != MouseButtons.Right) return;
            mnt_IncludingMrp.Visible = false;
            mnt_NotIncludingMrp.Visible = false;

            mnt_Bar1.Visible = false;

            mnt_Canceled.Visible = false;
            mnt_Closed.Visible = false;
            mnt_Confirmed.Visible = false;
            mnt_Editing.Visible = false;
            mnt_Ready.Visible = false;

            mnt_Mrp.Visible = false;
            mnt_Bom.Visible = false;

            mnt_Bar1.Visible = false;
            mnt_Bar2.Visible = false;
            mnt_Bar3.Visible = false;

            mnt_MRP_Check.Visible = false;
            mnt_MRP_UnCheck.Visible = false;

            if (fgrid_Lot.Selection.c1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS_DESC)
            {
                mnt_Canceled.Visible = false;
                mnt_Closed.Visible = true;
                mnt_Confirmed.Visible = false;
                mnt_Editing.Visible = false;
                mnt_Ready.Visible = true;
            }

            if (fgrid_Lot.Selection.c1 == (int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG)
            {
                mnt_MRP_Check.Visible = true;
                mnt_MRP_UnCheck.Visible = true;
            }
            //			if (fgrid_Lot.Selection.c1  == (int)ClassLib.TBSXD_MRP_MANAGER.lxITEM_01)
            //			{
            //				mnt_Mrp.Visible  = true;
            //				mnt_Bom.Visible  = true;
            //			}						
        }
        #endregion

        #region Order Grid
        private void fgrid_OA_EnterCell(object sender, System.EventArgs e)
        {
            if (fgrid_OA.Selection.r1 <= fgrid_OA.Rows.Fixed) return;

            mnt_Bom.Visible = false;
            mnt_Material.Visible = false;
            mnt_Mrp_Div.Visible = false;
            mnt_Mrp_Sel_Change.Visible = false;
            mnt_Material_New.Visible = false;
            mnt_Material_Old.Visible = false;
            mnt_OA_Check.Visible = false;
            mnt_OA_Uncheck.Visible = false;
            mnt_Text_Change.Visible = false;

            if ((fgrid_OA.Selection.c1 >= (int)ClassLib.TBSXD_ERR_CHECK_OA.lxITEM_01) &&
                (fgrid_OA.Selection.c1 <= (int)ClassLib.TBSXD_ERR_CHECK_OA.lxITEM_05))
            {
                mnt_Bom.Visible = true;
                mnt_Material.Visible = true;
                mnt_Mrp_Div.Visible = true;
                mnt_Mrp_Sel_Change.Visible = true;
                mnt_Material_New.Visible = true;
                mnt_Material_Old.Visible = true;
            }

            if ((fgrid_OA.Selection.c1 == (int)ClassLib.TBSXD_ERR_CHECK_OA.lxQTY_CURR_PUR) &&
                (fgrid_OA[fgrid_OA.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() != _Level3))
            {
                ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsWrongInput, this);
                fgrid_OA.Select(fgrid_OA.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxQTY_CURR_PUR - 1);
                return;
            }
            //			if (fgrid_OA.Selection.c1  ==  (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG)
            //			{
            //				if ( Convert.ToInt16(fgrid_OA[fgrid_OA.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString()) < Convert.ToInt16(_Level3))
            //				{
            //					ClassLib.ComFunction.User_Message("Wrong Level", "Level Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //
            //					return;
            //				}
            //				mnt_OA_Check.Visible  = true;
            //				mnt_OA_Uncheck.Visible = true;
            //			}	
            //			if (fgrid_OA.Selection.c1  ==  (int)ClassLib.TBSXD_ERR_CHECK_OA.lxQTY_CURR_PUR)
            //			{
            //				if ( Convert.ToInt16(fgrid_OA[fgrid_OA.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString()) < Convert.ToInt16(_Level3))
            //				{
            //					ClassLib.ComFunction.User_Message("Wrong Level", "Level Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //
            //					return;
            //				}
            //				mnt_Text_Change.Visible  = true;
            //			}
        }
        private void fgrid_OA_Click(object sender, System.EventArgs e)
        {
            //			#region mrp check						
            //			if (fgrid_OA.Selection.c1    == (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG) 
            //			{
            //										
            //				for (int i = fgrid_OA.Selection.r1; i<= fgrid_OA.Selection.r2; i++)
            //				{
            //				
            //					fgrid_OA[i,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG]  =  fgrid_OA[fgrid_OA.Selection.r1,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG].ToString();
            //					fgrid_OA.Update_Row(i);
            //					
            //				}
            //			}
            //
            //			#endregion
            //			//상단 Level Check하면 하단 Level다 적용
            //
            //			if (fgrid_OA.Selection.c1    == (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG) 
            //			{
            //				int  vMyLevel  =  Convert.ToInt16(fgrid_OA[fgrid_OA.Selection.r1,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString());
            //
            //				
            //				for (int i = fgrid_OA.Selection.r1+1; i< fgrid_OA.Rows.Count; i++)
            //				{
            //		 
            //					if (Convert.ToInt16(fgrid_OA[i,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString())  <= vMyLevel) break;
            //
            //					fgrid_OA[i,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG]  = (fgrid_OA[fgrid_OA.Selection.r1,(int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG].ToString() =="True")? "True":"False";
            //					fgrid_OA.Update_Row(i);
            //				
            //				}
            //			}
        }
        //		private void mnt_OA_Check_Click(object sender, System.EventArgs e)
        //		{
        //		
        //			_col1 = fgrid_OA.Selection.c1;  _col2 = fgrid_OA.Selection.c2; _row1 = fgrid_OA.Selection.r1;  _row2 = fgrid_OA.Selection.r2; 
        //
        //			Find_OA_Level_One(fgrid_OA);
        //			for (int i = _row1; i<=_row2; i++)
        //			{  
        //				fgrid_OA[i,_col1] ="True";fgrid_OA.Update_Row(i);
        //			}
        //
        //		}
        //		private void mnt_OA_Uncheck_Click(object sender, System.EventArgs e)
        //		{
        //			_col1 = fgrid_OA.Selection.c1;  _col2 = fgrid_OA.Selection.c2; _row1 = fgrid_OA.Selection.r1;  _row2 = fgrid_OA.Selection.r2; 
        //			Find_OA_Level_One(fgrid_OA);
        //			for (int i = _row1; i<=_row2; i++)
        //			{			
        //				fgrid_OA[i,_col1] ="False";	fgrid_OA.Update_Row(i);
        //			}
        //		}
        private void fgrid_OA_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if ((fgrid_OA.Selection.c1 == (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG) || (fgrid_OA.Selection.c1 == (int)ClassLib.TBSXD_ERR_CHECK_OA.lxQTY_CURR_PUR))
            {
                _col1 = fgrid_OA.Selection.c1; _col2 = fgrid_OA.Selection.c2; _row1 = fgrid_OA.Selection.r1; _row2 = fgrid_OA.Selection.r2;

                Find_OA_Level_One(fgrid_OA);
                for (int i = _row1; i <= _row2; i++)
                {
                    fgrid_OA[i, _col1] = fgrid_OA[_row1, _col1].ToString();
                    fgrid_OA.Update_Row(i);
                }
            }
        }
        private void fgrid_OA_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                if ((fgrid_OA.Rows.Fixed > 0) && (fgrid_OA.Row >= fgrid_OA.Rows.Fixed))
                {
                    if (fgrid_OA.Cols[fgrid_OA.Col].DataType == typeof(bool))
                        fgrid_OA.Buffer_CellData = "";
                    else
                        fgrid_OA.Buffer_CellData = (fgrid_OA[fgrid_OA.Row, fgrid_OA.Col] == null) ? "" : fgrid_OA[fgrid_OA.Row, fgrid_OA.Col].ToString();
                }
            }
            catch
            {
            }
        }
        #endregion

        #region MRP(Use) Grid
        private void fgrid_MRP_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            try
            {
                if ((fgrid_MRP.Rows.Fixed > 0) && (fgrid_MRP.Row >= fgrid_MRP.Rows.Fixed))
                {
                    if (fgrid_MRP.Cols[fgrid_MRP.Col].DataType == typeof(bool))
                        fgrid_MRP.Buffer_CellData = "";
                    else
                        fgrid_MRP.Buffer_CellData = (fgrid_MRP[fgrid_MRP.Row, fgrid_MRP.Col] == null) ? "" : fgrid_MRP[fgrid_MRP.Row, fgrid_MRP.Col].ToString();
                }
            }
            catch
            {
            }
        }
        private void fgrid_MRP_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            for (int i = fgrid_MRP.Selection.r1; i <= fgrid_MRP.Selection.r2; i++)
            {
                fgrid_MRP.Update_Row(i);
            }
            //하단 Level Check하면 상단 Level다 적용
        }
        #endregion

        #region Material-Stock
        private void fgrid_Item_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            //			if (fgrid_Item.Selection.c1 != (int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR) 
            //			{						
            //				fgrid_Item[fgrid_Item.Selection.r1,(int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR] = fgrid_Item.Buffer_CellData;			
            //				ClassLib.ComFunction.User_Message("Please ..Select Adjust Purchase",  "fgrid_Item_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //				return;			
            //			}			
            //			if ( fgrid_Item[fgrid_Item.Selection.r1,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() != _MatLevel)
            //			{
            //				fgrid_Item[fgrid_Item.Selection.r1,(int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR] = fgrid_Item.Buffer_CellData;
            //
            //				ClassLib.ComFunction.User_Message("Please ..Select material level",  "fgrid_Item_AfterEdit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //				return;
            //			} 			
            //			//Rollback
            //			string vAdjustPur  = fgrid_Item[fgrid_Item.Selection.r1,  (int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR].ToString();			
            //			for (int i = fgrid_Item.Selection.r1; i<= fgrid_Item.Selection.r2; i++)
            //			{			
            //				if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _MatLevel)
            //				{
            //					fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxVALUE_ADJ_PUR] = vAdjustPur;
            //					fgrid_Item.Update_Row(i);
            //				}					
            //			}
        }
        #endregion

        #region 콘텍스트 메뉴
        private void mnt_Editing_Click(object sender, System.EventArgs e)
        {
            string vDesc = ClassLib.ComVar.ConsCDC_Editing;
            string vValue = ClassLib.ComVar.ConsCDC_Y;

            int vRow1 = fgrid_Lot.Selection.r1, vRow2 = fgrid_Lot.Selection.r2;
            int vCol1 = fgrid_Lot.Selection.c1;

            for (int i = vRow1; i <= vRow2; i++)
            {
                if ((fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS] == null) || (fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() == "")) continue;
                fgrid_Lot[i, vCol1] = vValue;
                fgrid_Lot[i, vCol1 - 1] = vDesc;
                fgrid_Lot[i, 0] = "U";
            }
        }
        private void mnt_Confirmed_Click(object sender, System.EventArgs e)
        {
            string vDesc = ClassLib.ComVar.ConsCDC_Comfirmed;
            string vValue = ClassLib.ComVar.ConsCDC_C;

            int vRow1 = fgrid_Lot.Selection.r1, vRow2 = fgrid_Lot.Selection.r2;
            int vCol1 = fgrid_Lot.Selection.c1;

            for (int i = vRow1; i <= vRow2; i++)
            {
                if ((fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS] == null) || (fgrid_Lot[i, (int)ClassLib.SXB_SRF_MANAGER.lxSTATUS].ToString() == "")) continue;
                fgrid_Lot[i, vCol1] = vValue;
                fgrid_Lot[i, vCol1 - 1] = vDesc;
                fgrid_Lot[i, 0] = "U";
            }
        }
        private void mnt_MRP_Check_Click(object sender, System.EventArgs e)
        {
            for (int i = fgrid_Lot.Selection.r1; i <= fgrid_Lot.Selection.r2; i++)
            { fgrid_Lot[i, fgrid_Lot.Selection.c1] = "True"; fgrid_Lot.Update_Row(i); }
        }
        private void mnt_MRP_UnCheck_Click(object sender, System.EventArgs e)
        {
            for (int i = fgrid_Lot.Selection.r1; i <= fgrid_Lot.Selection.r2; i++)
            { fgrid_Lot[i, fgrid_Lot.Selection.c1] = "False"; fgrid_Lot.Update_Row(i); }
        }
        //		private void mnt_Check_Click(object sender, System.EventArgs e)
        //		{
        //			_MatLevel = (rad_Mat.Checked  == true)? _Level2:_Level3;		
        //			int  vCol  = fgrid_Item.Selection.c1 ;		
        //			for (int i = fgrid_Item.Selection.r1 ;  i<= fgrid_Item.Selection.r2 ; i++)
        //			{		
        //				if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _MatLevel)
        //				{
        //					fgrid_Item[i,vCol] ="True";
        //					fgrid_Item.Update_Row(i);		
        //				}		
        //			}			
        //		}		
        //		private void mnt_UnCheck_Click(object sender, System.EventArgs e)
        //		{				
        //			_MatLevel = (rad_Mat.Checked  == true)? _Level2:_Level3;		
        //			int  vCol  = fgrid_Item.Selection.c1 ;		
        //			for (int i = fgrid_Item.Selection.r1 ;  i<= fgrid_Item.Selection.r2 ; i++)
        //			{		
        //				if (fgrid_Item[i,(int)ClassLib.TBSXD_MRP_ITEM_01.lxLEVEL].ToString() == _MatLevel)
        //				{
        //					fgrid_Item[i,vCol] = "False";
        //					fgrid_Item.Update_Row(i);		
        //				}		
        //			}		
        //		}		
        private void mnt_Spec_Click(object sender, System.EventArgs e)
        {
            fgrid_Error_DoubleClick(null, null);

        }
        private void mnt_Color_Click(object sender, System.EventArgs e)
        {
            fgrid_Error_DoubleClick(null, null);

        }
        private void mnt_Mrp_Div_Click(object sender, System.EventArgs e)
        {
            fgrid_OA.Tree.Show(1);
        }
        private void mnt_Mrp_Sel_Change_Click(object sender, System.EventArgs e)
        {
            fgrid_OA.Tree.Show(2);
        }
        private void mnt_Bom_Click(object sender, System.EventArgs e)
        {
            fgrid_OA.Tree.Show(3);
        }
        private void mnt_Material_New_Click(object sender, System.EventArgs e)
        {
            fgrid_OA.Tree.Show(4);
        }
        private void mnt_Material_Old_Click(object sender, System.EventArgs e)
        {
            fgrid_OA.Tree.Show(5);
        }
        private void mnt_Text_Change_Click(object sender, System.EventArgs e)
        {
            if (fgrid_OA[fgrid_OA.Selection.r1, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() != _Level3)
            {
                ClassLib.ComFunction.User_Message("Wrong Level", "Level Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FlexCDC.BaseInfo.Pop_Common_Text vEditor = new FlexCDC.BaseInfo.Pop_Common_Text(" ");
            vEditor.ShowDialog();

            int vCol = fgrid_OA.Selection.c1, vRow1 = fgrid_OA.Selection.r1, vRow2 = fgrid_OA.Selection.r2;
            string vValue = COM.ComVar.This_Return;

            if ((vValue == null) || (vValue == "")) return;

            //leve4까지 설정처리 -----------------------------------------------------------------------------
            for (int i = fgrid_OA.Selection.r2 + 1; i < fgrid_OA.Rows.Count; i++)
                if (fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level4) vRow2 = i;
                else break;
            //--------------------------------------------------------------------------------------------------------

            for (int i = vRow1; i <= vRow2; i++)
            {
                fgrid_OA[i, vCol] = vValue;
                fgrid_OA.Update_Row(i);
            }
        }
        private void mnt_OA_Check_Click(object sender, System.EventArgs e)
        {
            _col1 = fgrid_OA.Selection.c1; _col2 = fgrid_OA.Selection.c2; _row1 = fgrid_OA.Selection.r1; _row2 = fgrid_OA.Selection.r2;

            Find_OA_Level_One(fgrid_OA);
            for (int i = _row1; i <= _row2; i++)
            {
                fgrid_OA[i, _col1] = "True"; fgrid_OA.Update_Row(i);
            }
        }
        private void mnt_OA_Uncheck_Click(object sender, System.EventArgs e)
        {
            _col1 = fgrid_OA.Selection.c1; _col2 = fgrid_OA.Selection.c2; _row1 = fgrid_OA.Selection.r1; _row2 = fgrid_OA.Selection.r2;

            Find_OA_Level_One(fgrid_OA);

            for (int i = _row1; i <= _row2; i++)
            {
                fgrid_OA[i, _col1] = "False"; fgrid_OA.Update_Row(i);
            }
        }
        //level4  각자 반영 처리 + Level3일시 Level 4까지 설정 처리
        private void Find_OA_Level_One(COM.FSP arg_fgrid)
        {
            if (arg_fgrid[arg_fgrid.Selection.r2, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level3)
                for (int i = arg_fgrid.Selection.r2 + 1; i < arg_fgrid.Rows.Count; i++)
                    if (arg_fgrid[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level4)
                        _row2 = i;
                    else break;
            else
                _row2 = arg_fgrid.Selection.r2;
        }
        #endregion
        #endregion

        #region DB Connect
        #region Save
        private bool Save_Mrp_Close()
        {
            string Proc_Name = "PKG_SXM_MRP_01.SAVE_SXE_LOT_CLOSE";

            int vSaveCount = 0, vCount = 5, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_STATUS";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
                if (fgrid_Lot[i, 0].ToString() == "U") vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];
            for (int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
            {
                if (fgrid_Lot[i, 0].ToString() != "U") continue;

                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxFACTORY].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxSTATUS].ToString();
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            return true;
        }
        private bool Save_Mrp_Change()
        {
            string Proc_Name = "PKG_SXM_MRP_01.UPDATE_SXM_MRP_REQ_LOT_SIZE";

            int vSaveCount = 0, vCount = 7, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_SIZE_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_FLG";
            MyOraDB.Parameter_Name[a++] = "ARG_QTY_CURR_PUR";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
                if (fgrid_Lot[i, 0].ToString() == "U") vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];
            for (int i = fgrid_Lot.Rows.Fixed; i < fgrid_Lot.Rows.Count; i++)
            {
                if (fgrid_Lot[i, 0].ToString() != "U") continue;

                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxFACTORY].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxLOT_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxCS_SIZE].ToString();

                MyOraDB.Parameter_Values[b++] = ((fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG] == null) || (fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxMRP_FLG].ToString() == "False")) ? "N" : "Y";

                MyOraDB.Parameter_Values[b++] = fgrid_Lot[i, (int)ClassLib.TBSXD_MRP_MANAGER.lxQTY_CURR_PUR].ToString();
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }
            //MyOraDB.Add_Modify_Parameter(false); 
            //return true;

            MyOraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

            return true;
        }
        private bool Save_Err_Code_Mat()
        {
            string Proc_Name = "PKG_SXM_MRP_02.SAVE_SXD_SRF_TAIL";

            int vCount = 14, a = 0, b = 0, vSaveCount = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_SRF_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_PART_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PCC_SPEC_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PCC_UNIT_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_YIELD_VALUE";
            MyOraDB.Parameter_Name[a++] = "ARG_LOSS_VALUE";
            MyOraDB.Parameter_Name[a++] = "ARG_COMMON_YN";
            MyOraDB.Parameter_Name[a++] = "ARG_CBD_PRICE";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_Error.Rows.Fixed; i < fgrid_Error.Rows.Count; i++)
                if (fgrid_Error[i, 0].ToString() == "U") vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];

            for (int i = fgrid_Error.Rows.Fixed; i < fgrid_Error.Rows.Count; i++)
            {
                if (fgrid_Error[i, 0].ToString() != "U") continue;

                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxFACTORY].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLOT_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLOT_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxSRF_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPART_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_CD].ToString();
                MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_String(fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_SPEC].ToString(), " ");
                MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_String(fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxPCC_UNIT].ToString(), " ");
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxYIELD_VALUE].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxLOSS_VALUE].ToString();
                MyOraDB.Parameter_Values[b++] = ((fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxCOMMON_YN] == null) || (fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxCOMMON_YN].ToString() == "False")) ? "N" : "Y";
                MyOraDB.Parameter_Values[b++] = ClassLib.ComFunction.Empty_String(fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxCBD_PRICE].ToString(), "0");
                MyOraDB.Parameter_Values[b++] = fgrid_Error[i, (int)ClassLib.TBSXD_ERR_CHECK_ERROR_LEVEL.lxMAT_DIV].ToString();
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Modify_Procedure();

            return true;
        }
        private bool Save_MRP_Usage()
        {
            string Proc_Name = "PKG_SXM_MRP_02.UPDATE_SXD_SRF_M_MAT_MRP_YN";

            int vCount = 4, a = 0, b = 0, vSaveCount = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MAT_NAME";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_YN";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_MRP.Rows.Fixed; i < fgrid_MRP.Rows.Count; i++)
                if (fgrid_MRP[i, 0].ToString() == "U") vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];

            for (int i = fgrid_MRP.Rows.Fixed; i < fgrid_MRP.Rows.Count; i++)
            {
                if (fgrid_MRP[i, 0].ToString() != "U") continue;

                MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_MRP[i, (int)ClassLib.TBSXD_ERR_CHECK_MRP.lxMAT_NAME].ToString();
                MyOraDB.Parameter_Values[b++] = ((fgrid_MRP[i, (int)ClassLib.TBSXD_ERR_CHECK_MRP.lxMRP_YN] == null) || (fgrid_MRP[i, (int)ClassLib.TBSXD_ERR_CHECK_MRP.lxMRP_YN].ToString() == "False")) ? "N" : "Y";
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

            return true;
        }
        private bool Save_OA()
        {
            string Proc_Name = "PKG_SXM_MRP_02.UPDATE_SXM_MRP_REQ_ITEM";

            int vCount = 13, a = 0, b = 0, vSaveCount = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_LOT_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_SRF_SEQ";
            MyOraDB.Parameter_Name[a++] = "ARG_PART_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_PCC_SPEC_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_COLOR_CD";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_FLG";
            MyOraDB.Parameter_Name[a++] = "ARG_QTY_CURR_PUR";
            MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";

            for (int i = 0; i < vCount; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            //save할 count
            for (int i = fgrid_OA.Rows.Fixed; i < fgrid_OA.Rows.Count; i++)
                if ((fgrid_OA[i, 0].ToString() == "U") && (fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() == _Level4)) vSaveCount++;

            MyOraDB.Parameter_Values = new string[vCount * vSaveCount];

            for (int i = fgrid_OA.Rows.Fixed; i < fgrid_OA.Rows.Count; i++)
            {
                if (fgrid_OA[i, 0].ToString() != "U") continue;
                if (fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLEVEL].ToString() != _Level4) continue;

                MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxPUR_DIV].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLOT_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxLOT_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxSRF_SEQ].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxPART_NO].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMAT_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxPCC_SPEC_CD].ToString();
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxCOLOR_CD].ToString();
                MyOraDB.Parameter_Values[b++] = ((fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG] == null) || (fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxMRP_FLG].ToString() == "False")) ? "N" : "Y";
                MyOraDB.Parameter_Values[b++] = fgrid_OA[i, (int)ClassLib.TBSXD_ERR_CHECK_OA.lxQTY_CURR_PUR].ToString();
                MyOraDB.Parameter_Values[b++] = ClassLib.ComVar.This_User;
            }

            MyOraDB.Add_Modify_Parameter(true);		// 파라미터 데이터를 DataSet에 추가
            MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행

            return true;
        }
        #endregion

        #region Select
        private DataTable Select_MRP_Plan_Lot()
        {
            string Proc_Name = "PKG_SXM_MRP_01_SELECT.SELECT_SXM_MRP_REQ_LOT";

            int vCount = 5, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_STATUS";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = (_Create == ClassLib.ComVar.ConsCDC_N) ? MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8)) : " ";
            MyOraDB.Parameter_Values[b++] = (_Create == ClassLib.ComVar.ConsCDC_N) ? MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8)) : " ";
            //string  vStatus  =  (chk_Close.Checked  == true)?ClassLib.ComVar.ConsCDC_X:" ";
            string vStatus = " ";
            MyOraDB.Parameter_Values[b++] = (_Create == ClassLib.ComVar.ConsCDC_N) ? vStatus : " ";
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_Error()
        {
            string Proc_Name = "PKG_SXM_MRP_02_SELECT.SELECT_SXM_MRP_ERR";

            int vCount = 2, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            //MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_Combo(cmb_MatDiv," ");
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_MRP()
        {
            string Proc_Name = "PKG_SXM_MRP_02_SELECT.SELECT_SXM_MRP_USEYN";

            int vCount = 5, a = 0, b = 0;

            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_CHECK";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = (chk_Close.Checked == true) ? "true" : " ";
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Select_OA()
        {
            string Proc_Name = "PKG_SXM_MRP_02_SELECT.SELECT_SXM_MRP_REQ_ITEM";

            int vCount = 6, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "ARG_MRP_NO";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_F_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_GET_T_YMD";
            MyOraDB.Parameter_Name[a++] = "ARG_CHECK";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_Mrp_date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_From_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = MyComFunction.ConvertDate2DbType(dtp_To_Date.Value.ToString().Substring(0, 8));
            MyOraDB.Parameter_Values[b++] = (chk_Close.Checked == true) ? "Y" : " ";
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[Proc_Name];
        }
        private DataTable Count_MRP_Err()
        {
            string Proc_Name = "PKG_SXM_MRP_02_SELECT.COUNT_SXM_MRP_ERR";

            int vCount = 2, a = 0, b = 0;
            MyOraDB.ReDim_Parameter(vCount);
            MyOraDB.Process_Name = Proc_Name;

            MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";
            MyOraDB.Parameter_Name[a++] = "OUT_CURSOR";

            for (int i = 0; i < vCount - 1; i++)
                MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;

            MyOraDB.Parameter_Type[vCount - 1] = (int)OracleType.Cursor;

            MyOraDB.Parameter_Values[b++] = cmb_Factory.SelectedValue.ToString();
            MyOraDB.Parameter_Values[b++] = "";

            MyOraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;
            return DS_Ret.Tables[Proc_Name];
        }
        #endregion

        #region 주석
        //private  bool Save_Err_Code_Mat()
        //{        
        //    string Proc_Name = "PKG_SXM_MRP_02.UPDATE_SXD_SRF_M_MAT";
        //    int vCount = 10, a=0, b=0, vSaveCount  = 0;
        //    MyOraDB.ReDim_Parameter(vCount);
        //    MyOraDB.Process_Name = Proc_Name ;
        //    MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_MAT_CD";						
        //    MyOraDB.Parameter_Name[a++] = "ARG_PCC_SPEC_CD";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_PCC_UNIT_CD";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_YIELD_VALUE";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_LOSS_VALUE";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_COMMON_YN";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_CBD_PRICE";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_PUR_DIV";		
        //    MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";
        //    for (int i =0 ; i< vCount ; i++)
        //        MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
        //    //save할 count
        //    for (int i =fgrid_Error.Rows.Fixed ; i< fgrid_Error.Rows.Count; i++)
        //        if (fgrid_Error[i,0].ToString() =="U") vSaveCount++;
        //    MyOraDB.Parameter_Values = new string[vCount * vSaveCount ];
        //    for (int i  = fgrid_Error.Rows.Fixed  ; i< fgrid_Error.Rows.Count   ; i++)
        //    {
        //        if (fgrid_Error[i,0].ToString() !="U") continue;
        //        MyOraDB.Parameter_Values[b++] =  fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxFACTORY].ToString();
        //        MyOraDB.Parameter_Values[b++] =  fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxMAT_CD].ToString();
        //        MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_String(fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxPCC_SPEC].ToString()," ");
        //        MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_String( fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxPCC_UNIT].ToString()," ");
        //        MyOraDB.Parameter_Values[b++] =  fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxYIELD_VALUE].ToString();
        //        MyOraDB.Parameter_Values[b++] =  fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxLOSS_VALUE].ToString();
        //        MyOraDB.Parameter_Values[b++] =  ((fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxCOMMON_YN] == null)  || ( fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxCOMMON_YN].ToString() =="False"))?"N" : "Y";
        //        MyOraDB.Parameter_Values[b++] =  ClassLib.ComFunction.Empty_String(fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxCBD_PRICE].ToString(),"0");
        //        MyOraDB.Parameter_Values[b++] =  fgrid_Error[i,(int)ClassLib.TBSXD_ERR_CHECK_ERROR.lxPUR_DIV].ToString();			
        //        MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;
        //    }									 
        //    MyOraDB.Add_Modify_Parameter(true); 
        //    return true;
        //}		
        //private  bool Save_Err_Code_SRF ()
        //{
        //    string Proc_Name = "PKG_SXM_MRP_02.UPDATE_SXD_SRF_TAIL";
        //    int vCount = 2, a=0, b=0;
        //    MyOraDB.ReDim_Parameter(vCount);
        //    MyOraDB.Process_Name = Proc_Name ;
        //    MyOraDB.Parameter_Name[a++] = "ARG_FACTORY";			
        //    MyOraDB.Parameter_Name[a++] = "ARG_UPD_USER";
        //    for (int i =0 ; i< vCount ; i++)
        //        MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;  
        //    MyOraDB.Parameter_Values[b++] =  cmb_Factory.SelectedValue.ToString();
        //    MyOraDB.Parameter_Values[b++] =  ClassLib.ComVar.This_User;
        //    MyOraDB.Add_Modify_Parameter(false); 
        //    return true;        
        //}	
        #endregion

        #endregion

        
    }
}



