using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Outgoing
{
	public class Form_BO_Outgoing : COM.PCHWinForm.Form_Top
	{ 
 
		#region 컨트롤 정의 및 리소스

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label lbl_contNo;
		private System.Windows.Forms.Label lbl_outStatus;
		private System.Windows.Forms.Label lbl_outSize;
		private System.Windows.Forms.Label lbl_outType;
		private System.Windows.Forms.Label lbl_outNo;
		private System.Windows.Forms.Label lbl_outYmd;
		private System.Windows.Forms.Label lbl_outDiv;
		private System.Windows.Forms.Label lbl_headInfo;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.Label lbl_cont;
		private System.Windows.Forms.Label lbl_workLine;
		private C1.Win.C1List.C1Combo cmb_SizeYN;
		private C1.Win.C1List.C1Combo cmb_Line;
		private System.Windows.Forms.TextBox txt_OutStatus;
		private C1.Win.C1List.C1Combo cmb_Process;
		private System.Windows.Forms.TextBox txt_Vendor;
		private C1.Win.C1List.C1Combo cmb_Vendor;
		private System.Windows.Forms.DateTimePicker dpick_OutDate;
		private System.Windows.Forms.TextBox txt_ContNo;
		private System.Windows.Forms.TextBox txt_Remarks;
		private C1.Win.C1List.C1Combo cmb_OutDiv;
		private C1.Win.C1List.C1Combo cmb_OutType;
		private C1.Win.C1List.C1Combo cmb_OutNo;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label btn_SearchSize;
		private System.Windows.Forms.Label btn_SearchOutNo;
		private System.Windows.Forms.Label btn_Request;
		private System.Windows.Forms.Label btn_Container;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Yield;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_purchase;
		private System.Windows.Forms.Label btn_Copy; 

		#endregion

		#region 생성자 / 소멸자

		public Form_BO_Outgoing()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Outgoing));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.fgrid_main = new COM.FSP();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_purchase = new System.Windows.Forms.Label();
            this.cmb_SizeYN = new C1.Win.C1List.C1Combo();
            this.btn_Copy = new System.Windows.Forms.Label();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.btn_Request = new System.Windows.Forms.Label();
            this.txt_OutStatus = new System.Windows.Forms.TextBox();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.txt_Vendor = new System.Windows.Forms.TextBox();
            this.cmb_Vendor = new C1.Win.C1List.C1Combo();
            this.lbl_cont = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.btn_Container = new System.Windows.Forms.Label();
            this.dpick_OutDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_outStatus = new System.Windows.Forms.Label();
            this.txt_ContNo = new System.Windows.Forms.TextBox();
            this.lbl_contNo = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.lbl_outSize = new System.Windows.Forms.Label();
            this.btn_SearchSize = new System.Windows.Forms.Label();
            this.cmb_OutDiv = new C1.Win.C1List.C1Combo();
            this.lbl_outDiv = new System.Windows.Forms.Label();
            this.cmb_OutType = new C1.Win.C1List.C1Combo();
            this.lbl_outType = new System.Windows.Forms.Label();
            this.cmb_OutNo = new C1.Win.C1List.C1Combo();
            this.lbl_outNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.btn_SearchOutNo = new System.Windows.Forms.Label();
            this.lbl_outYmd = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Yield = new System.Windows.Forms.Label();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeYN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            this.pnl_menu.SuspendLayout();
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
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.GridDefinition = "21.5753424657534:False:True;70.5479452054795:False:False;5.13698630136986:False:T" +
                "rue;\t0.393700787401575:False:True;97.6377952755905:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 584);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(12, 134);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(992, 412);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 171;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.fgrid_main_MouseUp);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_purchase);
            this.pnl_head.Controls.Add(this.cmb_SizeYN);
            this.pnl_head.Controls.Add(this.btn_Copy);
            this.pnl_head.Controls.Add(this.cmb_Line);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.btn_Request);
            this.pnl_head.Controls.Add(this.txt_OutStatus);
            this.pnl_head.Controls.Add(this.cmb_Process);
            this.pnl_head.Controls.Add(this.txt_Vendor);
            this.pnl_head.Controls.Add(this.cmb_Vendor);
            this.pnl_head.Controls.Add(this.lbl_cont);
            this.pnl_head.Controls.Add(this.lbl_headInfo);
            this.pnl_head.Controls.Add(this.btn_Container);
            this.pnl_head.Controls.Add(this.dpick_OutDate);
            this.pnl_head.Controls.Add(this.lbl_outStatus);
            this.pnl_head.Controls.Add(this.txt_ContNo);
            this.pnl_head.Controls.Add(this.lbl_contNo);
            this.pnl_head.Controls.Add(this.txt_Remarks);
            this.pnl_head.Controls.Add(this.lbl_outSize);
            this.pnl_head.Controls.Add(this.btn_SearchSize);
            this.pnl_head.Controls.Add(this.cmb_OutDiv);
            this.pnl_head.Controls.Add(this.lbl_outDiv);
            this.pnl_head.Controls.Add(this.cmb_OutType);
            this.pnl_head.Controls.Add(this.lbl_outType);
            this.pnl_head.Controls.Add(this.cmb_OutNo);
            this.pnl_head.Controls.Add(this.lbl_outNo);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.btn_SearchOutNo);
            this.pnl_head.Controls.Add(this.lbl_outYmd);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 126);
            this.pnl_head.TabIndex = 1;
            // 
            // btn_purchase
            // 
            this.btn_purchase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_purchase.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_purchase.ImageIndex = 0;
            this.btn_purchase.ImageList = this.img_Button;
            this.btn_purchase.Location = new System.Drawing.Point(824, 99);
            this.btn_purchase.Name = "btn_purchase";
            this.btn_purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_purchase.TabIndex = 403;
            this.btn_purchase.Text = "Purchase";
            this.btn_purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_purchase.Click += new System.EventHandler(this.btn_purchase_Click);
            // 
            // cmb_SizeYN
            // 
            this.cmb_SizeYN.AddItemCols = 0;
            this.cmb_SizeYN.AddItemSeparator = ';';
            this.cmb_SizeYN.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SizeYN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SizeYN.Caption = "";
            this.cmb_SizeYN.CaptionHeight = 17;
            this.cmb_SizeYN.CaptionStyle = style1;
            this.cmb_SizeYN.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SizeYN.ColumnCaptionHeight = 18;
            this.cmb_SizeYN.ColumnFooterHeight = 18;
            this.cmb_SizeYN.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SizeYN.ContentHeight = 16;
            this.cmb_SizeYN.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SizeYN.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SizeYN.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_SizeYN.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SizeYN.EditorHeight = 16;
            this.cmb_SizeYN.EvenRowStyle = style2;
            this.cmb_SizeYN.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_SizeYN.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SizeYN.FooterStyle = style3;
            this.cmb_SizeYN.GapHeight = 2;
            this.cmb_SizeYN.HeadingStyle = style4;
            this.cmb_SizeYN.HighLightRowStyle = style5;
            this.cmb_SizeYN.ItemHeight = 15;
            this.cmb_SizeYN.Location = new System.Drawing.Point(437, 99);
            this.cmb_SizeYN.MatchEntryTimeout = ((long)(2000));
            this.cmb_SizeYN.MaxDropDownItems = ((short)(5));
            this.cmb_SizeYN.MaxLength = 32767;
            this.cmb_SizeYN.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SizeYN.Name = "cmb_SizeYN";
            this.cmb_SizeYN.OddRowStyle = style6;
            this.cmb_SizeYN.PartialRightColumn = false;
            this.cmb_SizeYN.PropBag = resources.GetString("cmb_SizeYN.PropBag");
            this.cmb_SizeYN.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SizeYN.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SizeYN.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SizeYN.SelectedStyle = style7;
            this.cmb_SizeYN.Size = new System.Drawing.Size(187, 20);
            this.cmb_SizeYN.Style = style8;
            this.cmb_SizeYN.TabIndex = 363;
            this.cmb_SizeYN.SelectedValueChanged += new System.EventHandler(this.cmb_SizeYN_SelectedValueChanged);
            // 
            // btn_Copy
            // 
            this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Copy.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Copy.ImageIndex = 0;
            this.btn_Copy.ImageList = this.img_Button;
            this.btn_Copy.Location = new System.Drawing.Point(664, 99);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(80, 23);
            this.btn_Copy.TabIndex = 402;
            this.btn_Copy.Text = "Copy";
            this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Copy.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            this.btn_Copy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Copy.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Copy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemCols = 0;
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
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
            this.cmb_Line.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.EvenRowStyle = style10;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style11;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style12;
            this.cmb_Line.HighLightRowStyle = style13;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(437, 55);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style14;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style15;
            this.cmb_Line.Size = new System.Drawing.Size(210, 20);
            this.cmb_Line.Style = style16;
            this.cmb_Line.TabIndex = 400;
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 0;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(336, 55);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 401;
            this.lbl_workLine.Text = "Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Request
            // 
            this.btn_Request.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Request.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Request.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Request.ImageIndex = 0;
            this.btn_Request.ImageList = this.img_Button;
            this.btn_Request.Location = new System.Drawing.Point(744, 99);
            this.btn_Request.Name = "btn_Request";
            this.btn_Request.Size = new System.Drawing.Size(80, 23);
            this.btn_Request.TabIndex = 399;
            this.btn_Request.Text = "Request";
            this.btn_Request.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Request.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Request.Click += new System.EventHandler(this.btn_Request_Click);
            this.btn_Request.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Request.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Request.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_OutStatus
            // 
            this.txt_OutStatus.BackColor = System.Drawing.Color.White;
            this.txt_OutStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutStatus.Enabled = false;
            this.txt_OutStatus.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_OutStatus.Location = new System.Drawing.Point(765, 33);
            this.txt_OutStatus.MaxLength = 20;
            this.txt_OutStatus.Name = "txt_OutStatus";
            this.txt_OutStatus.Size = new System.Drawing.Size(210, 21);
            this.txt_OutStatus.TabIndex = 398;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemCols = 0;
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style17;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style18;
            this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style19;
            this.cmb_Process.GapHeight = 2;
            this.cmb_Process.HeadingStyle = style20;
            this.cmb_Process.HighLightRowStyle = style21;
            this.cmb_Process.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(437, 77);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style22;
            this.cmb_Process.PartialRightColumn = false;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style23;
            this.cmb_Process.Size = new System.Drawing.Size(210, 20);
            this.cmb_Process.Style = style24;
            this.cmb_Process.TabIndex = 397;
            // 
            // txt_Vendor
            // 
            this.txt_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Vendor.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Vendor.Location = new System.Drawing.Point(437, 77);
            this.txt_Vendor.MaxLength = 10;
            this.txt_Vendor.Name = "txt_Vendor";
            this.txt_Vendor.Size = new System.Drawing.Size(79, 21);
            this.txt_Vendor.TabIndex = 396;
            this.txt_Vendor.Visible = false;
            // 
            // cmb_Vendor
            // 
            this.cmb_Vendor.AddItemCols = 0;
            this.cmb_Vendor.AddItemSeparator = ';';
            this.cmb_Vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Vendor.Caption = "";
            this.cmb_Vendor.CaptionHeight = 17;
            this.cmb_Vendor.CaptionStyle = style25;
            this.cmb_Vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Vendor.ColumnCaptionHeight = 18;
            this.cmb_Vendor.ColumnFooterHeight = 18;
            this.cmb_Vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Vendor.ContentHeight = 16;
            this.cmb_Vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Vendor.EditorHeight = 16;
            this.cmb_Vendor.EvenRowStyle = style26;
            this.cmb_Vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Vendor.FooterStyle = style27;
            this.cmb_Vendor.GapHeight = 2;
            this.cmb_Vendor.HeadingStyle = style28;
            this.cmb_Vendor.HighLightRowStyle = style29;
            this.cmb_Vendor.ItemHeight = 15;
            this.cmb_Vendor.Location = new System.Drawing.Point(517, 77);
            this.cmb_Vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_Vendor.MaxDropDownItems = ((short)(5));
            this.cmb_Vendor.MaxLength = 32767;
            this.cmb_Vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Vendor.Name = "cmb_Vendor";
            this.cmb_Vendor.OddRowStyle = style30;
            this.cmb_Vendor.PartialRightColumn = false;
            this.cmb_Vendor.PropBag = resources.GetString("cmb_Vendor.PropBag");
            this.cmb_Vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Vendor.SelectedStyle = style31;
            this.cmb_Vendor.Size = new System.Drawing.Size(125, 20);
            this.cmb_Vendor.Style = style32;
            this.cmb_Vendor.TabIndex = 395;
            this.cmb_Vendor.Visible = false;
            // 
            // lbl_cont
            // 
            this.lbl_cont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_cont.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cont.ImageIndex = 0;
            this.lbl_cont.ImageList = this.img_Label;
            this.lbl_cont.Location = new System.Drawing.Point(336, 77);
            this.lbl_cont.Name = "lbl_cont";
            this.lbl_cont.Size = new System.Drawing.Size(100, 21);
            this.lbl_cont.TabIndex = 394;
            this.lbl_cont.Text = "Process";
            this.lbl_cont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_headInfo
            // 
            this.lbl_headInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lbl_headInfo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_headInfo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_headInfo.Image = ((System.Drawing.Image)(resources.GetObject("lbl_headInfo.Image")));
            this.lbl_headInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_headInfo.Name = "lbl_headInfo";
            this.lbl_headInfo.Size = new System.Drawing.Size(231, 30);
            this.lbl_headInfo.TabIndex = 392;
            this.lbl_headInfo.Text = "      Outgoing Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Container
            // 
            this.btn_Container.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Container.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Container.ImageIndex = 0;
            this.btn_Container.ImageList = this.img_Button;
            this.btn_Container.Location = new System.Drawing.Point(904, 99);
            this.btn_Container.Name = "btn_Container";
            this.btn_Container.Size = new System.Drawing.Size(80, 23);
            this.btn_Container.TabIndex = 391;
            this.btn_Container.Text = "Container";
            this.btn_Container.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Container.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Container.Click += new System.EventHandler(this.btn_Container_Click);
            this.btn_Container.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Container.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Container.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // dpick_OutDate
            // 
            this.dpick_OutDate.CustomFormat = "";
            this.dpick_OutDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_OutDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_OutDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_OutDate.Location = new System.Drawing.Point(109, 55);
            this.dpick_OutDate.Name = "dpick_OutDate";
            this.dpick_OutDate.Size = new System.Drawing.Size(211, 21);
            this.dpick_OutDate.TabIndex = 381;
            this.dpick_OutDate.CloseUp += new System.EventHandler(this.dpick_OutDate_CloseUp);
            // 
            // lbl_outStatus
            // 
            this.lbl_outStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outStatus.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outStatus.ImageIndex = 0;
            this.lbl_outStatus.ImageList = this.img_Label;
            this.lbl_outStatus.Location = new System.Drawing.Point(664, 33);
            this.lbl_outStatus.Name = "lbl_outStatus";
            this.lbl_outStatus.Size = new System.Drawing.Size(100, 21);
            this.lbl_outStatus.TabIndex = 379;
            this.lbl_outStatus.Text = "Outgoing Status";
            this.lbl_outStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ContNo
            // 
            this.txt_ContNo.BackColor = System.Drawing.Color.White;
            this.txt_ContNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ContNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_ContNo.Location = new System.Drawing.Point(765, 55);
            this.txt_ContNo.MaxLength = 20;
            this.txt_ContNo.Name = "txt_ContNo";
            this.txt_ContNo.Size = new System.Drawing.Size(210, 21);
            this.txt_ContNo.TabIndex = 377;
            // 
            // lbl_contNo
            // 
            this.lbl_contNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contNo.ImageIndex = 0;
            this.lbl_contNo.ImageList = this.img_Label;
            this.lbl_contNo.Location = new System.Drawing.Point(664, 55);
            this.lbl_contNo.Name = "lbl_contNo";
            this.lbl_contNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_contNo.TabIndex = 375;
            this.lbl_contNo.Text = "Container No";
            this.lbl_contNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.Color.White;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Remarks.Location = new System.Drawing.Point(765, 77);
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(210, 21);
            this.txt_Remarks.TabIndex = 374;
            // 
            // lbl_outSize
            // 
            this.lbl_outSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outSize.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outSize.ImageIndex = 0;
            this.lbl_outSize.ImageList = this.img_Label;
            this.lbl_outSize.Location = new System.Drawing.Point(336, 99);
            this.lbl_outSize.Name = "lbl_outSize";
            this.lbl_outSize.Size = new System.Drawing.Size(100, 21);
            this.lbl_outSize.TabIndex = 364;
            this.lbl_outSize.Text = "Size Y/N";
            this.lbl_outSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_SearchSize
            // 
            this.btn_SearchSize.BackColor = System.Drawing.SystemColors.Window;
            this.btn_SearchSize.Enabled = false;
            this.btn_SearchSize.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchSize.ImageIndex = 27;
            this.btn_SearchSize.ImageList = this.img_SmallButton;
            this.btn_SearchSize.Location = new System.Drawing.Point(625, 99);
            this.btn_SearchSize.Name = "btn_SearchSize";
            this.btn_SearchSize.Size = new System.Drawing.Size(24, 21);
            this.btn_SearchSize.TabIndex = 365;
            this.btn_SearchSize.Tag = "Search";
            this.btn_SearchSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchSize.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchSize.Click += new System.EventHandler(this.btn_SearchSize_Click);
            this.btn_SearchSize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_SearchSize.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchSize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // cmb_OutDiv
            // 
            this.cmb_OutDiv.AddItemCols = 0;
            this.cmb_OutDiv.AddItemSeparator = ';';
            this.cmb_OutDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutDiv.Caption = "";
            this.cmb_OutDiv.CaptionHeight = 17;
            this.cmb_OutDiv.CaptionStyle = style33;
            this.cmb_OutDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutDiv.ColumnCaptionHeight = 18;
            this.cmb_OutDiv.ColumnFooterHeight = 18;
            this.cmb_OutDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutDiv.ContentHeight = 16;
            this.cmb_OutDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutDiv.EditorHeight = 16;
            this.cmb_OutDiv.EvenRowStyle = style34;
            this.cmb_OutDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutDiv.FooterStyle = style35;
            this.cmb_OutDiv.GapHeight = 2;
            this.cmb_OutDiv.HeadingStyle = style36;
            this.cmb_OutDiv.HighLightRowStyle = style37;
            this.cmb_OutDiv.ItemHeight = 15;
            this.cmb_OutDiv.Location = new System.Drawing.Point(437, 33);
            this.cmb_OutDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutDiv.MaxDropDownItems = ((short)(5));
            this.cmb_OutDiv.MaxLength = 32767;
            this.cmb_OutDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OutDiv.Name = "cmb_OutDiv";
            this.cmb_OutDiv.OddRowStyle = style38;
            this.cmb_OutDiv.PartialRightColumn = false;
            this.cmb_OutDiv.PropBag = resources.GetString("cmb_OutDiv.PropBag");
            this.cmb_OutDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.SelectedStyle = style39;
            this.cmb_OutDiv.Size = new System.Drawing.Size(210, 20);
            this.cmb_OutDiv.Style = style40;
            this.cmb_OutDiv.TabIndex = 361;
            // 
            // lbl_outDiv
            // 
            this.lbl_outDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outDiv.ImageIndex = 0;
            this.lbl_outDiv.ImageList = this.img_Label;
            this.lbl_outDiv.Location = new System.Drawing.Point(336, 33);
            this.lbl_outDiv.Name = "lbl_outDiv";
            this.lbl_outDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_outDiv.TabIndex = 360;
            this.lbl_outDiv.Text = "Outgoing Div";
            this.lbl_outDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OutType
            // 
            this.cmb_OutType.AddItemCols = 0;
            this.cmb_OutType.AddItemSeparator = ';';
            this.cmb_OutType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutType.Caption = "";
            this.cmb_OutType.CaptionHeight = 17;
            this.cmb_OutType.CaptionStyle = style41;
            this.cmb_OutType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutType.ColumnCaptionHeight = 18;
            this.cmb_OutType.ColumnFooterHeight = 18;
            this.cmb_OutType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutType.ContentHeight = 16;
            this.cmb_OutType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutType.EditorHeight = 16;
            this.cmb_OutType.EvenRowStyle = style42;
            this.cmb_OutType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutType.FooterStyle = style43;
            this.cmb_OutType.GapHeight = 2;
            this.cmb_OutType.HeadingStyle = style44;
            this.cmb_OutType.HighLightRowStyle = style45;
            this.cmb_OutType.ItemHeight = 15;
            this.cmb_OutType.Location = new System.Drawing.Point(109, 99);
            this.cmb_OutType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutType.MaxDropDownItems = ((short)(5));
            this.cmb_OutType.MaxLength = 32767;
            this.cmb_OutType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OutType.Name = "cmb_OutType";
            this.cmb_OutType.OddRowStyle = style46;
            this.cmb_OutType.PartialRightColumn = false;
            this.cmb_OutType.PropBag = resources.GetString("cmb_OutType.PropBag");
            this.cmb_OutType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutType.SelectedStyle = style47;
            this.cmb_OutType.Size = new System.Drawing.Size(210, 20);
            this.cmb_OutType.Style = style48;
            this.cmb_OutType.TabIndex = 358;
            // 
            // lbl_outType
            // 
            this.lbl_outType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outType.ImageIndex = 0;
            this.lbl_outType.ImageList = this.img_Label;
            this.lbl_outType.Location = new System.Drawing.Point(8, 99);
            this.lbl_outType.Name = "lbl_outType";
            this.lbl_outType.Size = new System.Drawing.Size(100, 21);
            this.lbl_outType.TabIndex = 357;
            this.lbl_outType.Text = "Outgoing Type";
            this.lbl_outType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OutNo
            // 
            this.cmb_OutNo.AddItemCols = 0;
            this.cmb_OutNo.AddItemSeparator = ';';
            this.cmb_OutNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutNo.Caption = "";
            this.cmb_OutNo.CaptionHeight = 17;
            this.cmb_OutNo.CaptionStyle = style49;
            this.cmb_OutNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutNo.ColumnCaptionHeight = 18;
            this.cmb_OutNo.ColumnFooterHeight = 18;
            this.cmb_OutNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutNo.ContentHeight = 16;
            this.cmb_OutNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutNo.EditorHeight = 16;
            this.cmb_OutNo.EvenRowStyle = style50;
            this.cmb_OutNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutNo.FooterStyle = style51;
            this.cmb_OutNo.GapHeight = 2;
            this.cmb_OutNo.HeadingStyle = style52;
            this.cmb_OutNo.HighLightRowStyle = style53;
            this.cmb_OutNo.ItemHeight = 15;
            this.cmb_OutNo.Location = new System.Drawing.Point(109, 77);
            this.cmb_OutNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutNo.MaxDropDownItems = ((short)(5));
            this.cmb_OutNo.MaxLength = 32767;
            this.cmb_OutNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OutNo.Name = "cmb_OutNo";
            this.cmb_OutNo.OddRowStyle = style54;
            this.cmb_OutNo.PartialRightColumn = false;
            this.cmb_OutNo.PropBag = resources.GetString("cmb_OutNo.PropBag");
            this.cmb_OutNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutNo.SelectedStyle = style55;
            this.cmb_OutNo.Size = new System.Drawing.Size(187, 20);
            this.cmb_OutNo.Style = style56;
            this.cmb_OutNo.TabIndex = 5;
            this.cmb_OutNo.SelectedValueChanged += new System.EventHandler(this.cmb_OutNo_SelectedValueChanged);
            // 
            // lbl_outNo
            // 
            this.lbl_outNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outNo.ImageIndex = 1;
            this.lbl_outNo.ImageList = this.img_Label;
            this.lbl_outNo.Location = new System.Drawing.Point(8, 77);
            this.lbl_outNo.Name = "lbl_outNo";
            this.lbl_outNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_outNo.TabIndex = 50;
            this.lbl_outNo.Text = "Outgoing No";
            this.lbl_outNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(664, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 356;
            this.label1.Text = "Remark";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 110);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // btn_SearchOutNo
            // 
            this.btn_SearchOutNo.BackColor = System.Drawing.SystemColors.Window;
            this.btn_SearchOutNo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchOutNo.ImageIndex = 27;
            this.btn_SearchOutNo.ImageList = this.img_SmallButton;
            this.btn_SearchOutNo.Location = new System.Drawing.Point(296, 77);
            this.btn_SearchOutNo.Name = "btn_SearchOutNo";
            this.btn_SearchOutNo.Size = new System.Drawing.Size(24, 21);
            this.btn_SearchOutNo.TabIndex = 54;
            this.btn_SearchOutNo.Tag = "Search";
            this.btn_SearchOutNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchOutNo.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchOutNo.Click += new System.EventHandler(this.btn_SearchOutNo_Click);
            this.btn_SearchOutNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_SearchOutNo.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchOutNo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // lbl_outYmd
            // 
            this.lbl_outYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outYmd.ImageIndex = 1;
            this.lbl_outYmd.ImageList = this.img_Label;
            this.lbl_outYmd.Location = new System.Drawing.Point(8, 55);
            this.lbl_outYmd.Name = "lbl_outYmd";
            this.lbl_outYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_outYmd.TabIndex = 50;
            this.lbl_outYmd.Text = "Outgoing Date";
            this.lbl_outYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style57;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 16;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 16;
            this.cmb_Factory.EvenRowStyle = style58;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style59;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style60;
            this.cmb_Factory.HighLightRowStyle = style61;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 33);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style62;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style63;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory.Style = style64;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 33);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(891, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 85);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(976, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 110);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 99);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(112, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 109);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(952, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_Cancel);
            this.pnl_menu.Controls.Add(this.btn_Yield);
            this.pnl_menu.Controls.Add(this.btn_Insert);
            this.pnl_menu.Controls.Add(this.btn_Delete);
            this.pnl_menu.Location = new System.Drawing.Point(12, 550);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(992, 30);
            this.pnl_menu.TabIndex = 170;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ImageIndex = 1;
            this.btn_Cancel.ImageList = this.image_List;
            this.btn_Cancel.Location = new System.Drawing.Point(909, 3);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 24);
            this.btn_Cancel.TabIndex = 366;
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn_Yield
            // 
            this.btn_Yield.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Yield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Yield.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Yield.ImageIndex = 13;
            this.btn_Yield.ImageList = this.image_List;
            this.btn_Yield.Location = new System.Drawing.Point(666, 3);
            this.btn_Yield.Name = "btn_Yield";
            this.btn_Yield.Size = new System.Drawing.Size(80, 24);
            this.btn_Yield.TabIndex = 365;
            this.btn_Yield.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Yield.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_Yield.Click += new System.EventHandler(this.btn_Yield_Click);
            this.btn_Yield.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_Yield.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Yield.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(747, 3);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 360;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_Insert.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 5;
            this.btn_Delete.ImageList = this.image_List;
            this.btn_Delete.Location = new System.Drawing.Point(828, 3);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 359;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.MouseLeave += new System.EventHandler(this.btn_MouseHover);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.btn_Delete.MouseHover += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            // 
            // Form_BO_Outgoing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Outgoing";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BO_Outgoing_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SizeYN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion 

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 


		private Hashtable _cellCombo = null;
		private Hashtable _cellData  = null;


		private string _OutStatus = "";
		private string _OutStatus_Confirm = "C"; 
		private string _OutStatus_Save = "S"; 
		



		#endregion

		#region 그리드 이벤트 처리

		 
		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed))
				fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
		
		}
		
		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			fgrid_main.Update_Row();

		}


		private void fgrid_main_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
			{
				int vCol = fgrid_main.Cols[fgrid_main.Col].Index; 
				if (fgrid_main.AllowEditing && fgrid_main.Cols[fgrid_main.Col].AllowEditing)
					ValueExchangeProcessing(vCol);
			}
		}



		private void ValueExchangeProcessing(int vCol)
		{
			try
			{ 
				ClassLib.ComVar.Parameter_PopUp_Object  = null;
				ClassLib.ComVar.Parameter_PopUp_Object2 = null;
				ClassLib.ComVar.Parameter_PopUpTable	= null; 

				int[] vSelectionRange = fgrid_main.Selections;

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[1];
					COM.ComVar.Parameter_PopUp[0]	= fgrid_main[1, vCol].ToString();
				
					if (_cellCombo.ContainsKey(vCol))  
					{
						ClassLib.ComVar.Parameter_PopUp_Object  = new object[]{_cellData[vCol]};
						ClassLib.ComVar.Parameter_PopUp_Object2 = new object[]{_cellCombo[vCol]};
					}
					FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer pop_changer = new FlexPurchase.Incoming.Pop_BI_Incoming_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						foreach (int i in vSelectionRange)
						{
							fgrid_main[i, vCol] = COM.ComVar.Parameter_PopUp[0];
							if( vCol.Equals((int)ClassLib.TBSBO_OUTGOING_OTHER.IxCUST_CD) )
							{
								fgrid_main[i, vCol +1]	= COM.ComVar.Parameter_PopUp[0];    // Set Vendor Name Text
							
								if (COM.ComVar.Parameter_PopUp.Length > 1)
									fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];// Set Vendor Code Value
							}
							else
							{
								fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[0];    // Set TextBox Text
							
								if (COM.ComVar.Parameter_PopUp.Length > 1)
									fgrid_main[i, vCol]		= COM.ComVar.Parameter_PopUp[1];	// Set SSPComboBox Value
							}


							fgrid_main.Update_Row(i);
						}
					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValueExchangeProcessing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}



		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_NewProcess();
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{ 
			Tbtn_SearchProcess();

		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SaveProcess();
		}	 

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_DeleteProcess();
		}

		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_ConfirmProcess();
		}

		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_PrintProcess();
		}





		private void Tbtn_NewProcess()
		{

			try
			{
				
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
				dpick_OutDate.Text = MyComFunction.ConvertDate2Type(nowymd);

				cmb_OutNo.SelectedIndex = -1;
				cmb_OutType.SelectedIndex = -1;
				cmb_OutDiv.SelectedIndex = -1;
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;
				cmb_SizeYN.SelectedIndex = -1;
				cmb_Vendor.SelectedIndex = -1;
				txt_OutStatus.Text = "";
				txt_ContNo.Text = "";
				txt_Vendor.Text = "";
				txt_Remarks.Text = "";

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

				_OutStatus = _OutStatus_Save;  
				EnableControlCheckProcess();

				


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}




		private void Tbtn_SearchProcess()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;
 

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutNo};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;
 

				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_no = cmb_OutNo.SelectedValue.ToString();  

				DataTable dt_ret = Select_SBO_OUT_TAIL(factory, out_no);
				
				DataTable dt_size = Pop_BO_Outgoing_OutSize.SELECT_SBO_OUT_SIZE(factory, out_no);
				ClassLib.ComVar.Parameter_PopUpTable2 = dt_size;



				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed; 
				

				if(dt_ret.Rows.Count == 0) 
				{  
					_OutStatus = _OutStatus_Save;
					EnableControlCheckProcess(); 

					return;  
				}

				Display_Grid(dt_ret); 


				



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SearchProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}

		}



		private void Tbtn_SaveProcess()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;
 

				if (ClassLib.ComVar.This_Factory != ClassLib.ComVar.DSFactory)
				{
					C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutType, cmb_Line , cmb_Process, cmb_SizeYN};   
					bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
					if(! essential_check) return;
				}
				else
				{
					C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutType, cmb_OutDiv};   
					bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
					if(! essential_check) return;
				}


				if(fgrid_main.Rows.Count < fgrid_main.Rows.Fixed) return;

				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);

				if(result == DialogResult.No) return;


				fgrid_main.Select(fgrid_main.Selection.r1, fgrid_main.Selection.c1); 


				// 1. outno 추출
				string factory = cmb_Factory.SelectedValue.ToString();
				string doc_division = ClassLib.ComVar.OUTGOING;
				string doc_type = ClassLib.ComFunction.Empty_Combo(cmb_OutType, " ");
				string date = System.DateTime.Today.ToString().Substring(0,10).Replace("-","");
				string user = ClassLib.ComVar.This_User;
						 
				string out_no = "";
				string save_division = "";

				if(cmb_OutNo.SelectedIndex == -1 || cmb_OutNo.SelectedValue.ToString() == "")
				{
					DataTable dt_ret = ClassLib.ComFunction.SELECT_DOCUMENT_NO(factory, doc_division, doc_type, date, user);
					out_no = dt_ret.Rows[0].ItemArray[0].ToString();
					save_division = "I";
				}
				else
				{
					out_no = cmb_OutNo.SelectedValue.ToString();
					save_division = "U";
				}
 

				bool make_flag = false;

				// 2. head 
				make_flag = Save_SBO_OUT_HEAD(out_no, save_division, true);

				if(!make_flag)
				{
					ClassLib.ComFunction.User_Message("Save head error.", "Save Head", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					// 3. tail
					make_flag = Save_SBO_OUT_TAIL(out_no, false);

					if(!make_flag)
					{
						ClassLib.ComFunction.User_Message("Save tail error.", "Save Tail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					else
					{
						// 4. size
						if(cmb_SizeYN.SelectedValue.ToString() == "Y")
						{
							make_flag = Save_SBO_OUT_SIZE(out_no, false);
						}
						else
						{
							make_flag = true;
						}


						if(!make_flag)
						{
							ClassLib.ComFunction.User_Message("Save size error.", "Save Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						else
						{

							
							DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

							if(ds_ret == null)
							{
								ClassLib.ComFunction.User_Message("Save error.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
								return;
							}
							else
							{

								Init_OutgoingNo();
								cmb_OutNo.SelectedValue = out_no;

							}  // end // 5. db 적용

						}  // end // 4. size
 

					} // end // 3. tail


				} // end // 2. head 
 
				 



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}

		}



		

		private void Tbtn_DeleteProcess()
		{

			
			try
			{

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutNo};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;
 

				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
				if(result == DialogResult.No) return; 

				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_no = cmb_OutNo.SelectedValue.ToString();  
				string upd_user = ClassLib.ComVar.This_User;
				 

				bool save_flag = Delete_SBO_OUT(factory, out_no, upd_user);
 

				if(save_flag)
				{

					Tbtn_NewProcess();
					Init_OutgoingNo();

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete , this);

				}
				else
				{
					
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete , this);

				}

				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_DeleteProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 


		}



		private void Tbtn_ConfirmProcess()
		{

			try
			{


				if(fgrid_main.Rows.Count < fgrid_main.Rows.Fixed) return;


				

				if (ClassLib.ComVar.This_Factory != ClassLib.ComVar.DSFactory)
				{
					C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutType, cmb_Line , cmb_Process, cmb_SizeYN};   
					bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
					if(! essential_check) return;

				}
				else
				{


					C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutType, cmb_OutDiv};   
					bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
					if(! essential_check) return;


				}


				

				int[] int_array = {(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxWH_CD}; 
				bool empty_check = ClassLib.ComFunction.EmptyCellCheck(fgrid_main, int_array);
				if(empty_check) return;


				if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
				{
					string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

					if (vTemp.Length > 0)
					{
						ClassLib.ComFunction.User_Message("Exist modify data. You need save.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
							 
				}



				DialogResult result;

				if(_OutStatus == _OutStatus_Confirm)
				{
					result = ClassLib.ComFunction.User_Message("Do you want to Confirm Cancel ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					result = ClassLib.ComFunction.User_Message("Do you want to Confirm ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}

				
				if(result == DialogResult.No) return;


				this.Cursor = Cursors.WaitCursor;
				 

				string real_out_ymd = "";
				string wh_cd = "";

				if(_OutStatus != _OutStatus_Confirm)
				{ 
					
					Pop_BO_Outgoing_RealYmd_Exchanger pop_form = new Pop_BO_Outgoing_RealYmd_Exchanger();
 

					ClassLib.ComVar.Parameter_PopUp = null;
					ClassLib.ComVar.Parameter_PopUp = new string[4]; 
					ClassLib.ComVar.Parameter_PopUp[0] = "Select Real Outgoing Date, Warehouse"; 
					ClassLib.ComVar.Parameter_PopUp[1] = "Select Real Outgoing Date, Warehouse";
					ClassLib.ComVar.Parameter_PopUp[2] = cmb_Factory.SelectedValue.ToString();
					ClassLib.ComVar.Parameter_PopUp[3] = fgrid_main[fgrid_main.Rows.Fixed, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxWH_CD].ToString(); // 대표 wh 코드
			
					pop_form.ShowDialog();

					if(ClassLib.ComVar.Parameter_PopUp == null) 
					{
						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
						return;
					}

					real_out_ymd = ClassLib.ComVar.Parameter_PopUp[0];  

				}
				else
				{
					real_out_ymd = System.DateTime.Now.ToString("yyyyMMdd"); 
				}
  
				
				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_no = cmb_OutNo.SelectedValue.ToString();  
				string out_status = (_OutStatus == _OutStatus_Confirm) ? "R" : "C"; 
				string confirm_yn = (_OutStatus == _OutStatus_Confirm) ? "N" : "Y"; 
				string upd_user = ClassLib.ComVar.This_User;
  

				string[] save_parameter = new string[] { factory,
														   out_no,
														   real_out_ymd,
														   wh_cd,
														   out_status, 
														   confirm_yn, 
														   upd_user};


				bool save_flag = Update_SBO_OUT_STATUS(save_parameter);

				if(save_flag)
				{

					if(_OutStatus == _OutStatus_Confirm)
					{
						_OutStatus = _OutStatus_Save;
					}
					else
					{
						_OutStatus = _OutStatus_Confirm;
					}

					for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
					{
						fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS] = _OutStatus;
						txt_OutStatus.Text = (_OutStatus == _OutStatus_Save) ? ClassLib.ComVar.Status_SAVE : ClassLib.ComVar.Status_CONFIRM;
					}

					EnableControlCheckProcess();


					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun , this);

					
				

				}
				else
				{
					
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun , this);

				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_ConfirmProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}




		private void Tbtn_PrintProcess()
		{


			try
			{


				C1.Win.C1List.C1Combo[] cmb_array		 = {cmb_Factory, cmb_OutNo}; 
				System.Windows.Forms.TextBox[] txt_array = {}; 

				if (! FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array) ) return;
				 
 

				FlexPurchase.Shipping.Pop_BS_Print_Type vPop = new FlexPurchase.Shipping.Pop_BS_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);   // sbp12

				string sDir = "";

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					string vPrintType = COM.ComVar.Parameter_PopUp[0];
					
					switch (vPrintType)
					{
						case "10": 
							sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_A4");
							break;

						case "20": 
							sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_A4_2");
							break;

						default:
							break;
					}

				}  // end if (vPop.ShowDialog() == DialogResult.OK)



				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Factory, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_OutNo, "") +		"' ";
				sPara += "'" + dpick_OutDate.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_TextBox(txt_ContNo, "%") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Process, " ") +		"' ";
				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);



				MyReport.Text = "Outgoing sheet";
				MyReport.Show();	 
					

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		private void Display_Grid(DataTable arg_dt)
		{

			fgrid_main.ClearAll(); 

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_main.AddItem(arg_dt.Rows[i].ItemArray, fgrid_main.Rows.Fixed + i, 1);

				fgrid_main[fgrid_main.Rows.Fixed + i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ] = Convert.ToString(i + 1);
			} 


			// 헤더 정보 세팅
			cmb_OutType.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_TYPE - 1].ToString();
			cmb_OutDiv.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_DIVISION - 1].ToString();
			cmb_Line.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_LINE - 1].ToString();
			cmb_Process.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_PROCESS - 1].ToString();
			cmb_SizeYN.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SIZE - 1].ToString();
			
			_OutStatus = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS - 1].ToString();
			txt_OutStatus.Text = (_OutStatus == _OutStatus_Save) ? ClassLib.ComVar.Status_SAVE : ClassLib.ComVar.Status_CONFIRM;
 
			txt_Remarks.Text = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBO_OUTGOING_OTHER.IxREMARKS_HEAD - 1].ToString(); 


			EnableControlCheckProcess();
			

			

		}


		



		/// <summary>
		/// EnableControlCheckProcess : 버튼 권한 재 설정
		/// </summary>
		private void EnableControlCheckProcess()
		{

			// 재고마감 여부 
			 

			if(_OutStatus == _OutStatus_Confirm)
			{
 
				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = true; 

				
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = false;
					btn_Request.Enabled = false;
				}
				else
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = false;
					btn_Request.Enabled = false;
				}

				btn_Yield.Enabled = false;
				btn_Insert.Enabled = false;
				btn_Delete.Enabled = false;
				btn_Cancel.Enabled = false;

				fgrid_main.AllowEditing = false; 


			}
			else if(_OutStatus == _OutStatus_Save)
			{
  
				tbtn_Save.Enabled = true;

				if(ClassLib.ComVar.This_InsaCd == "Y")
				{
					
					tbtn_Delete.Enabled = true;
					tbtn_Confirm.Enabled = true; 
				}
				else
				{ 
					tbtn_Delete.Enabled = false;
					tbtn_Confirm.Enabled = false; 
				}


				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = true;
					btn_Request.Enabled = true;
				}
				else
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = false;
					btn_Request.Enabled = true;
				}
				 

				btn_Yield.Enabled = true;
				btn_Insert.Enabled = true;
				btn_Delete.Enabled = true;
				btn_Cancel.Enabled = true;

				fgrid_main.AllowEditing = true;  


			} 


			//Container출고일경우 ,하단 버턴 무조건 false처리
 			bool vBool = false;
			if (fgrid_main.Rows.Count <= fgrid_main.Rows.Fixed)  return;

			/* 1. 수불팀 요청에 의해 임시로 삭제 기능을 활성화 합니다.
			 * 2008. 07. 29 :: 이재민 
			 */
			if( (fgrid_main[fgrid_main.Rows.Fixed ,(int)ClassLib.TBSBO_OUTGOING_OTHER.IxBAR_CODE] == null)  ||
				(fgrid_main[fgrid_main.Rows.Fixed ,(int)ClassLib.TBSBO_OUTGOING_OTHER.IxBAR_CODE].ToString().Length<24))
				 vBool = true;
			
			btn_Yield.Enabled  = false;
			//btn_Cancel.Enabled = false;
			//btn_Delete.Enabled = false;
			btn_Insert.Enabled = false;

			if  (vBool  == true)
			{
				btn_Yield.Enabled  = true;
				//btn_Cancel.Enabled = true;
				//btn_Delete.Enabled = true;
				btn_Insert.Enabled = true;
			}

			// 2. 삭제 기능 활성화
			btn_Delete.Enabled = true;
			btn_Cancel.Enabled = true;
	
  
			btn_Copy.Enabled = true;


		}



		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void Form_Closed(object sender, System.EventArgs e)
		{
			
		}

		private void Form_BO_Outgoing_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}

		 



		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Init_Control();
				Init_OutgoingNo();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	



		}
 

		private void dpick_OutDate_CloseUp(object sender, System.EventArgs e)
		{
		
			try
			{
				Init_OutgoingNo();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_OutDate_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}


		
		private void cmb_OutNo_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				
				if(cmb_Factory.SelectedIndex == -1 || cmb_OutNo.SelectedIndex == -1) return;


				Tbtn_SearchProcess();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_OutDate_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		
		}



		private void cmb_SizeYN_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				
				if(cmb_SizeYN.SelectedIndex == -1) return;

				btn_SearchSize.Enabled = (cmb_SizeYN.SelectedValue.ToString() == "Y") ? true : false;


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SizeYN_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	



		}
 


		#endregion

		#region 버튼 이벤트 처리
 
		#region 버튼클릭시 이미지변경
 

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



		private void btn_SearchOutNo_Click(object sender, System.EventArgs e)
		{

			try
			{
				
				if(cmb_Factory.SelectedIndex == -1) return; 


				Pop_BO_Outgoing_OutNo vPopup = new Pop_BO_Outgoing_OutNo();
				COM.ComVar.Parameter_PopUp = new string[1];
				COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");

				if (vPopup.ShowDialog() == DialogResult.OK)
				{  
					cmb_Factory.SelectedValue = COM.ComVar.Parameter_PopUp[0];
					dpick_OutDate.Value = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[1]); 
					Init_OutgoingNo();
					cmb_OutNo.SelectedValue = COM.ComVar.Parameter_PopUp[2];
				}

				vPopup.Dispose();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SearchOutNo_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}




		private void btn_SearchSize_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				
				if(cmb_Factory.SelectedIndex == -1) return; 


				string factory = cmb_Factory.SelectedValue.ToString();
				string out_no = ClassLib.ComFunction.Empty_Combo(cmb_OutNo, "");

				Pop_BO_Outgoing_OutSize pop_size = new Pop_BO_Outgoing_OutSize(factory, out_no); 

				pop_size.ShowDialog();
				pop_size.Dispose();

				if(cmb_OutNo.SelectedIndex != -1)
				{
					Save_SBO_OUT_SIZE(cmb_OutNo.SelectedValue.ToString(), true);
					MyOraDB.Exe_Modify_Procedure();
				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_SearchSize_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	



		}






		private void btn_Copy_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				
				Btn_CopyClickProcess(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Copy_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btn_Request_Click(object sender, System.EventArgs e)
		{
		

			try
			{
				
				Btn_requestClickProcess(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Request_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btn_purchase_Click(object sender, System.EventArgs e)
		{
			try
			{
				Btn_purchaseClickProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_purchase_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void btn_Container_Click(object sender, System.EventArgs e)
		{

			try
			{
				
				Btn_contClickProcess(); 



				EnableControlCheckProcess();



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Container_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		
		}







		private void btn_Yield_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				
				if(cmb_Factory.SelectedIndex == -1) return; 


				// 사이즈 여부 확인 후, 사이즈 런 입력 하고, 채산 표시 팝업창 열기
				Show_Pop_Yield();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Yield_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}

		private void btn_Insert_Click(object sender, System.EventArgs e)
		{

			try
			{
				
				if(cmb_Factory.SelectedIndex == -1) return;


				Show_Pop_Item();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Yield_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		
		}

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
		
			try
			{
  
				Delete_Selection();
 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Delete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
 

		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
		
			fgrid_main.Recover_Row(); 

		}





		private void Btn_contClickProcess()
		{
			fgrid_main.Rows.Count   = fgrid_main.Rows.Fixed;
			cmb_SizeYN.SelectedValue = ClassLib.ComVar.ConsN;

			int[] vChecks = new int[] { (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD,
										  (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD,
										  (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD,
										  (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD,
										  (int)ClassLib.TBSBO_OUTGOING_OTHER.IxBAR_CODE };
			Pop_BO_Outgoing_Cont vPopup = new Pop_BO_Outgoing_Cont(fgrid_main, vChecks);

			COM.ComVar.Parameter_PopUp = new string[2];
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			COM.ComVar.Parameter_PopUp[1] = dpick_OutDate.Text.Replace("-","");
			
			vPopup.ShowDialog();
						
			DataTable dt_cont = vPopup._DT;
			
			if (dt_cont != null && dt_cont.Rows.Count > 0 && vPopup.DialogResult == DialogResult.OK)
			{
				// 그리드에 Container 정보 추가
				Apply_Grid(dt_cont); 
			}
		}

		private void Btn_requestClickProcess()
		{
			int[] vChecks = new int[]{ (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_NO };
			Pop_BO_Outgoing_Req vPopup = new Pop_BO_Outgoing_Req(fgrid_main, vChecks);

			COM.ComVar.Parameter_PopUp = new string[2];
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			COM.ComVar.Parameter_PopUp[1] = dpick_OutDate.Text.Replace("-","");
			
			vPopup.ShowDialog();
						
			DataTable dt_req = vPopup._DT;
			
			if (dt_req != null && dt_req.Rows.Count > 0 && vPopup.DialogResult == DialogResult.OK)
			{
				// 그리드에 Container 정보 추가
				Apply_Grid(dt_req); 
			}

			if(cmb_Process.SelectedIndex == -1)
			{
				cmb_Process.SelectedValue = ClassLib.ComVar.Job_Process;
			}

			if(cmb_Line.SelectedIndex == -1)
			{
				cmb_Line.SelectedValue = ClassLib.ComVar.Job_Line;
			}

		    EnableControlCheckProcess();


		}

		private void Btn_purchaseClickProcess()
		{
			int[] vChecks = new int[]{ (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD,
										 (int)ClassLib.TBSBO_OUTGOING_OTHER.IxREQ_NO };

			Pop_BO_Outgoing_From_Incoming vPopup = new Pop_BO_Outgoing_From_Incoming(fgrid_main, vChecks);

			COM.ComVar.Parameter_PopUp = new string[2];
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			COM.ComVar.Parameter_PopUp[1] = dpick_OutDate.Text.Replace("-","");
			
			vPopup.ShowDialog();
						
			DataTable dt_req = vPopup._DT;
			
			if (dt_req != null && dt_req.Rows.Count > 0 && vPopup.DialogResult == DialogResult.OK)
			{
				// 그리드에 Container 정보 추가
				Apply_Grid(dt_req); 
			}

			if(cmb_Process.SelectedIndex == -1)
			{
				cmb_Process.SelectedValue = ClassLib.ComVar.Job_Process;
			}

			if(cmb_Line.SelectedIndex == -1)
			{
				cmb_Line.SelectedValue = ClassLib.ComVar.Job_Line;
			}

			EnableControlCheckProcess();


		}

		private void Btn_CopyClickProcess()
		{
			
			POP_BO_Outgoing_Copy vPopup = new POP_BO_Outgoing_Copy();

			COM.ComVar.Parameter_PopUp = new string[2];
			COM.ComVar.Parameter_PopUp[0] = ClassLib.ComFunction.Empty_Combo(cmb_Factory, "");
			COM.ComVar.Parameter_PopUp[1] = dpick_OutDate.Text.Replace("-","");
			
			vPopup.ShowDialog(); 

			//No 재조회 
			Init_OutgoingNo();		

			cmb_Process.SelectedValue = ClassLib.ComVar.Job_Process;
			cmb_Line.SelectedValue = ClassLib.ComVar.Job_Line;
			cmb_OutNo.SelectedValue = ClassLib.ComVar.Job_No;

		


		}



		/// <summary>
		/// Apply_Grid : 그리드에 추가된 행 표시, 채산값 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_dt_tail"></param> 
		/// <param name="arg_row"></param>
		private void Apply_Grid(DataTable arg_dt)
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;


				int now_seq = 0;
				int max_seq = -1;
				int now_out_seq = 0;
				int max_out_seq = -1;

				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
				{

					now_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ].ToString() ); 
					max_seq = (max_seq > now_seq) ? max_seq : now_seq;
 
					now_out_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ].ToString() ); 
					max_out_seq = (max_out_seq > now_out_seq) ? max_out_seq : now_out_seq;

				}

				now_seq = 0;
				now_out_seq = 0; 
			
				max_seq = (max_seq == -1) ? now_seq : max_seq;
				max_out_seq = (max_out_seq == -1) ? now_out_seq : max_out_seq;


				fgrid_main.Display_Grid_Add(arg_dt, false); 

				if (fgrid_main.Rows.Count > 0 && fgrid_main.Rows.Count > fgrid_main.Rows.Fixed)
				{
					// head Setting 			
					// cmb_Factory.SelectedValue = fgrid_main[fgrid_main.Rows.Fixed, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxFACTORY].ToString().Trim(); 
			
					int vRow   = fgrid_main.Rows.Count - arg_dt.Rows.Count; 
//					int vOutSeq = 0;
//
//					if (!vRow.Equals(fgrid_main.Rows.Fixed))
//						vOutSeq = int.Parse(fgrid_main[vRow -1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ].ToString());


					


					for (int i= vRow; i < fgrid_main.Rows.Count; i++)
					{
						 
						fgrid_main[i, 0] = ClassLib.ComVar.Insert;	
						fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ]	 = ++max_seq;
						fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ] = ++max_out_seq;

						for ( int row = fgrid_main.Rows.Fixed; row < fgrid_main.Rows.Count; row++ )
						{
							
							fgrid_main[row, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxMOD_QTY] = fgrid_main[row, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY];
							fgrid_main[row, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS] = _OutStatus; 

							for (int vCol = 1 ; vCol < fgrid_main.Cols.Count; vCol++)
							{
								if ( fgrid_main.Cols[vCol].AllowEditing )
									fgrid_main.GetCellRange(vRow, vCol).StyleNew.ForeColor = COM.ComVar.ClrImportant;
							}
						}
					}
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}
				else
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsNotHaveData, this);
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Apply_Grid", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}







		private void Show_Pop_Yield()
		{ 



			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SizeYN};   
			bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;


			if(cmb_SizeYN.SelectedValue.ToString() == "Y")
			{
				DialogResult result = ClassLib.ComFunction.User_Message("Do you want size ?", "Size informaion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


				// size input
				if(result == DialogResult.Yes) 
				{

					string factory = cmb_Factory.SelectedValue.ToString();
					string out_no = ClassLib.ComFunction.Empty_Combo(cmb_OutNo, "");

					Pop_BO_Outgoing_OutSize pop_size = new Pop_BO_Outgoing_OutSize(factory, out_no); 

					pop_size.ShowDialog();
					pop_size.Dispose();
				} 


			}




			ClassLib.ComVar.Parameter_PopUp = null;
			ClassLib.ComVar.Parameter_PopUpTable = new DataTable();

			int[] checks = new int[]{ (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD, 
										(int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD,
										(int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD,
										(int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD };
			FlexPurchase.Purchase.Pop_BC_Yield_Info pop_form = new FlexPurchase.Purchase.Pop_BC_Yield_Info(fgrid_main, checks);
			pop_form.ShowDialog(); 


			if(ClassLib.ComVar.Parameter_PopUpTable.Rows.Count <= 0 || pop_form.DialogResult != DialogResult.OK) 
			{
				pop_form.Dispose();
				return;
			} 

			pop_form.Dispose();



			if(ClassLib.ComVar.Parameter_PopUpTable.Rows.Count == 0) return; 


			bool make_flag = false;

			make_flag = SAVE_SBT_TEMP_ITEM();

			if(!make_flag)
			{
				ClassLib.ComFunction.User_Message("Save item error.", "Save Temp Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			else
			{
				make_flag = SAVE_SBT_TEMP_SIZE();

				if(!make_flag)
				{
					ClassLib.ComFunction.User_Message("Save size error.", "Save Temp Size", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					DataSet ds_ret = MyOraDB.Exe_Modify_Procedure();

					if(ds_ret == null)
					{
						ClassLib.ComFunction.User_Message("Save error.", "Save Temp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					} 

				}

			}




			// 소요량 계산 
			DataTable dt_ret = SELECT_SBT_TEMP_ITEM(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.This_User);

			if(dt_ret == null || dt_ret.Rows.Count == 0) return;

   

			int now_seq = 0;
			int max_seq = -1;
			int now_out_seq = 0;
			int max_out_seq = -1;

			for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
			{

				now_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ].ToString() ); 
				max_seq = (max_seq > now_seq) ? max_seq : now_seq;
 
				now_out_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ].ToString() ); 
				max_out_seq = (max_out_seq > now_out_seq) ? max_out_seq : now_out_seq;

			}

			now_seq = 0;
			now_out_seq = 0; 
			
			max_seq = (max_seq == -1) ? now_seq : max_seq;
		    max_out_seq = (max_out_seq == -1) ? now_out_seq : max_out_seq;

 

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{

				fgrid_main.Add_Row(fgrid_main.Rows.Count - 1);

				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxFACTORY] = cmb_Factory.SelectedValue;
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ]	= ++max_out_seq;
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ] = ++max_seq;
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD]	 = dt_ret.Rows[i][0];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_NAME] = dt_ret.Rows[i][1];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD]= dt_ret.Rows[i][2];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_NAME] = dt_ret.Rows[i][3];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD] = dt_ret.Rows[i][4];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_NAME] = dt_ret.Rows[i][5];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY] = dt_ret.Rows[i][6];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_CD] = dt_ret.Rows[i][7]; 
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxUNIT] = dt_ret.Rows[i][9];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSTYLE_NAME] = dt_ret.Rows[i][10];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxPK_UNIT_QTY] = dt_ret.Rows[i][11];
				fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS] = _OutStatus;


			} 

 
 
		}



		private void Show_Pop_Item()
		{

			FlexBase.MaterialBase.Pop_Item_List pop_form = new FlexBase.MaterialBase.Pop_Item_List();
			pop_form.ShowDialog(); 
			
			if (COM.ComVar.Parameter_PopUp[0] == "") return; 
			  

			int now_seq = 0;
			int max_seq = -1;
			int now_out_seq = 0;
			int max_out_seq = -1;

			for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
			{

				now_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ].ToString() ); 
				max_seq = (max_seq > now_seq) ? max_seq : now_seq;
 
				now_out_seq = Convert.ToInt32(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ].ToString() ); 
				max_out_seq = (max_out_seq > now_out_seq) ? max_out_seq : now_out_seq;

			}

			now_seq = 0;
			now_out_seq = 0; 
			
			max_seq = (max_seq == -1) ? now_seq : max_seq;
			max_out_seq = (max_out_seq == -1) ? now_out_seq : max_out_seq;




			fgrid_main.Add_Row(fgrid_main.Rows.Count - 1); 
 
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxFACTORY] = cmb_Factory.SelectedValue;
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_SEQ]	= ++max_out_seq;
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSEQ] = ++max_seq;
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_CD]	 = ClassLib.ComVar.Parameter_PopUp[0];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxITEM_NAME] = ClassLib.ComVar.Parameter_PopUp[1];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_CD]= ClassLib.ComVar.Parameter_PopUp[2];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxSPEC_NAME] = ClassLib.ComVar.Parameter_PopUp[3];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_CD] = ClassLib.ComVar.Parameter_PopUp[4];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxCOLOR_NAME] = ClassLib.ComVar.Parameter_PopUp[5];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxUNIT] = ClassLib.ComVar.Parameter_PopUp[6];
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_QTY] = "0";
			fgrid_main[fgrid_main.Rows.Count - 1, (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_STATUS] = _OutStatus;
						 

		}


		private void Delete_Selection()
		{

			int sel_r1 = fgrid_main.Selection.r1;
			int sel_r2 = fgrid_main.Selection.r2;
			 
			 
			int start_row = (sel_r1 < sel_r2) ? sel_r1 : sel_r2;
			int end_row = (sel_r1 < sel_r2) ? sel_r2 : sel_r1;

			for(int i = end_row; i >= start_row ; i--)
			{
				if(fgrid_main[i, 0] == null)
				{
					fgrid_main[i, 0] = "D";
				}
				if(fgrid_main[i, 0].ToString() != "I")
				{
					fgrid_main[i, 0] = "D";
				}
				if(fgrid_main[i, 0].ToString() == "I")
				{
					fgrid_main.Rows.Remove(i);
				}
			}


		}


		#endregion

		#region 공통 메서드

		 

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{			
			

			try
			{


                // Form Setting  
                lbl_MainTitle.Text = "Outgoing";
                this.Text = "Outgoing";
                ClassLib.ComFunction.SetLangDic(this);
 
 

				// Grid Setting
				fgrid_main.Set_Grid("SBO_OUTGOING_OTHER", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

				fgrid_main.Rows[0].AllowMerging = true;
				fgrid_main.Rows[1].AllowMerging = true;
				fgrid_main.Set_Action_Image(img_Action); 



				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = true;
					btn_Request.Enabled = true;
				}
				else
				{
					btn_Copy.Enabled = false;
					btn_Container.Enabled = false;
					btn_Request.Enabled = true;
				}


				
				btn_Copy.Enabled = true;


				// Set grid cell type
				Set_Grid_CellType();

			
			 

				// Factory Combobox Setting
				DataTable dt_ret = COM.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
				dt_ret.Dispose();

				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;  


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	



			 
		}
		


		private void Set_Grid_CellType()
		{


			_cellData  = new Hashtable(fgrid_main.Cols.Count);
			_cellCombo = new Hashtable(fgrid_main.Cols.Count);
			IDictionary vDic = null;
			IEnumerator vEnum  = null;
			IEnumerator vEnum2 = null;
			string[] vTemp = null;
			string[] vData = null;

			for (int vCol = 1, vCnt = 0 ; vCol < fgrid_main.Cols.Count ; vCol++)
			{

				if(vCol != (int)ClassLib.TBSBO_OUT_TAIL.IxSEQ && fgrid_main.Cols[vCol].DataType.Equals(typeof(double) ) )
				{
					fgrid_main.Cols[vCol].Format = "#,##0.00";
				}


				if (fgrid_main.Cols[vCol].AllowEditing)
				{
					if (fgrid_main.Cols[vCol].DataMap != null)
					{
						vDic = fgrid_main.Cols[vCol].DataMap;
						vTemp = new string[vDic.Count];
						vData = new string[vDic.Count];
						vEnum  = vDic.Values.GetEnumerator();
						vEnum2 = vDic.Keys.GetEnumerator();
						while (vEnum.MoveNext())
							vTemp[vCnt++] = vEnum.Current.ToString();

						vCnt = 0;
						_cellCombo.Add(vCol, vTemp);

						while (vEnum2.MoveNext())
							vData[vCnt++] = vEnum2.Current.ToString();

						vCnt = 0;
						_cellData.Add(vCol, vData);
					}
				}
			}


		}




		private void Init_Control()
		{

			if(cmb_Factory.SelectedIndex == -1) return;   
			

		 
			cmb_OutNo.SelectedIndex = -1;
			cmb_OutType.SelectedIndex = -1;
			cmb_OutDiv.SelectedIndex = -1;
			cmb_Process.SelectedIndex = -1;
			cmb_Line.SelectedIndex = -1;
			cmb_SizeYN.SelectedIndex = -1;
			cmb_Vendor.SelectedIndex = -1;
			txt_OutStatus.Text = "";
			txt_ContNo.Text = "";
			txt_Vendor.Text = "";
			txt_Remarks.Text = "";

			fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

 			_OutStatus = _OutStatus_Save;  
 			EnableControlCheckProcess();



			DataTable dt_ret;
 
			
			//outgoing type 
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOutType);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OutType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);   

			//outgoint division
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOutDivision);  //ClassLib.ComVar.CxReqReason;
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_OutDiv, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);   
			
			//line setting 
			dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(cmb_Factory.SelectedValue.ToString() );
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  
  
			//process setting 
			dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(cmb_Factory.SelectedValue.ToString() );
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Process, 1, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 

			//size yn
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxUseYN);
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_SizeYN, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  



			dt_ret.Dispose();




		}




		private void Init_OutgoingNo()
		{

			if(cmb_Factory.SelectedIndex == -1) return;   
 
			cmb_OutType.SelectedIndex = -1;
			cmb_OutDiv.SelectedIndex = -1;
			cmb_Process.SelectedIndex = -1;
			cmb_Line.SelectedIndex = -1;
			cmb_SizeYN.SelectedIndex = -1;
			cmb_Vendor.SelectedIndex = -1;
			txt_OutStatus.Text = "";
			txt_ContNo.Text = "";
			txt_Vendor.Text = "";
			txt_Remarks.Text = "";

			fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;




			string factory = cmb_Factory.SelectedValue.ToString();
			string out_ymd = MyComFunction.ConvertDate2DbType(dpick_OutDate.Text);

			DataTable dt_ret = Select_SBO_OUT_NO(factory, out_ymd);
  
			ClassLib.ComCtl.Set_ComboList_AddItem(dt_ret, cmb_OutNo, 0, 1, 2);
			cmb_OutNo.Splits[0].DisplayColumns[0].Width = 120;
			cmb_OutNo.Splits[0].DisplayColumns[1].Width = 80;
			cmb_OutNo.Splits[0].DisplayColumns[2].Width = 80;
			cmb_OutNo.DropDownWidth = 280;

			cmb_OutNo.ValueMember = "Code";
			cmb_OutNo.DisplayMember = "Code";

			cmb_OutNo.InsertItem(";;", 0);

			dt_ret.Dispose();


		}
		
	
		

		#endregion   
		
		#region DB Connect
 		

		/// <summary>
		/// Select_SBO_OUT_NO : 기타 출고 번호 리스트 조회
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_ymd"></param>
		/// <returns></returns>
		private DataTable Select_SBO_OUT_NO(string arg_factory, string arg_out_ymd)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SELECT_SBO_OUT_NO";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD";
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_ymd;
				MyOraDB.Parameter_Values[2] = "";

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



		private DataTable Select_SBO_OUT_TAIL(string arg_factory, string arg_out_no)
		{


			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(3);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SELECT_SBO_OUT_TAIL";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_NO"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_no; 
				MyOraDB.Parameter_Values[2] = "";  

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


		 


		#region btn_yield event : Usage 계산



		/// <summary>
		/// SAVE_SBT_TEMP_ITEM : 채산 팝업에서 선택한 아이템 저장
		/// </summary>
		/// <returns></returns>
		private bool SAVE_SBT_TEMP_ITEM()
		{
			try
			{
				int col_ct  = 8; 

				MyOraDB.ReDim_Parameter(col_ct);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SAVE_SBT_TEMP_ITEM";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_COMPONENT_CD";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
 

				//04.DATA 정의
				ArrayList vList = new ArrayList(); 


				vList.Add(cmb_Factory.SelectedValue.ToString()); 
				vList.Add(ClassLib.ComVar.This_User);
				vList.Add("D");
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");

				for(int i = 0 ; i < ClassLib.ComVar.Parameter_PopUpTable.Rows.Count ; i++)
				{ 
  
 
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][7].ToString() );  // factory
					vList.Add(ClassLib.ComVar.This_User);                                    // action_user
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][8].ToString() );  // style
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][9].ToString() );  // component
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][0].ToString() );  // item_cd
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][2].ToString() );  // spec_cd
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[i][4].ToString() );  // color_cd
					vList.Add(ClassLib.ComVar.This_User);
 
					 

				}

				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));  

				MyOraDB.Add_Modify_Parameter(true); 
				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"SAVE_SBT_TEMP_ITEM",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}
 
		/// <summary>
		/// SAVE_SBT_TEMP_SIZE : 
		/// </summary>
		/// <returns>DataTable</returns>
		private bool SAVE_SBT_TEMP_SIZE()
		{
			try
			{
				 
				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBT_TEMP_SIZE.SAVE_SBT_TEMP_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[2] = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[3] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[4] = "ARG_ACTION_USER";
				MyOraDB.Parameter_Name[5] = "ARG_STYLE_CD";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의 
				ArrayList vList = new ArrayList(); 


				vList.Add("D"); 
				vList.Add("");
				vList.Add("");
				vList.Add(cmb_Factory.SelectedValue.ToString() );
				vList.Add(ClassLib.ComVar.This_User);
				vList.Add("");

				// ClassLib.ComVar.Parameter_PopUpTable2 : 임시 사이즈 수량 테이블
				// ClassLib.ComVar.Parameter_PopUpTable : 임시 채산 선택 아이템 테이블

				if(cmb_SizeYN.SelectedValue.ToString() == "Y")
				{
					for(int i = 0 ; i < ClassLib.ComVar.Parameter_PopUpTable2.Rows.Count ; i++)
					{ 
 
						if(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString() == ""
							|| ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString() == "0") continue; 
					
 

						vList.Add("I"); 
						vList.Add(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[3].ToString() );
						vList.Add(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString() );
						vList.Add(cmb_Factory.SelectedValue.ToString() );
						vList.Add(ClassLib.ComVar.This_User);
						vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString() ); 



					}
				}
				else
				{

					// usage 계산값 0 으로 나타내 주기 위해서 임시 사이즈 테이블에 0 으로 세팅
					vList.Add("E"); 
					vList.Add("");
					vList.Add("");
					vList.Add(cmb_Factory.SelectedValue.ToString() );
					vList.Add(ClassLib.ComVar.This_User);
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable.Rows[0][8].ToString() ); 


				}


				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 

				MyOraDB.Add_Modify_Parameter(false); 

				return true;
			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"SAVE_SBT_TEMP_SIZE",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			}
		}
		
		/// <summary>
		/// SELECT_SBT_TEMP_ITEM
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_req_no">청구번호</param>
		/// <returns>DataTable</returns>
		private DataTable SELECT_SBT_TEMP_ITEM(string arg_factory, string arg_action_user)
		{
			// SELECT_SBS_SHIPPING_SIZE_LIST 참고
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBT_TEMP_ITEM.SELECT_SBT_TEMP_ITEM";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_ACTION_USER";
			MyOraDB.Parameter_Name[2]  = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_action_user;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion


		#region Save



		/// <summary>
		/// Save_SBO_OUT_HEAD : SBO_OUT_HEAD 리스트 저장
		/// </summary>
		/// <param name="arg_out_no"></param>
		/// <param name="arg_save_division"></param>
		/// <returns></returns>
		private bool Save_SBO_OUT_HEAD(string arg_out_no, string arg_save_division, bool arg_clear_flag)
		{

			try
			{

				MyOraDB.ReDim_Parameter(14);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SAVE_SBO_OUT_HEAD";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_OUT_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_OUT_YMD";
				MyOraDB.Parameter_Name[4]  = "ARG_OUT_TYPE";
				MyOraDB.Parameter_Name[5]  = "ARG_OUT_SIZE";
				MyOraDB.Parameter_Name[6]  = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[7]  = "ARG_OUT_LINE";
				MyOraDB.Parameter_Name[8]  = "ARG_OUT_DIVISION";
				MyOraDB.Parameter_Name[9]  = "ARG_REAL_OUT_YMD";
				MyOraDB.Parameter_Name[10] = "ARG_OUT_STATUS";
				MyOraDB.Parameter_Name[11] = "ARG_CONFIRM_YN";
				MyOraDB.Parameter_Name[12] = "ARG_REMARKS";
				MyOraDB.Parameter_Name[13] = "ARG_UPD_USER";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[9]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;

				//04.DATA 정의  
				MyOraDB.Parameter_Values[0]  = arg_save_division;
				MyOraDB.Parameter_Values[1]  = cmb_Factory.SelectedValue.ToString();
				MyOraDB.Parameter_Values[2]  = arg_out_no;
				MyOraDB.Parameter_Values[3]  = MyComFunction.ConvertDate2DbType(dpick_OutDate.Text);
				MyOraDB.Parameter_Values[4]  = cmb_OutType.SelectedValue.ToString();
				MyOraDB.Parameter_Values[5]  = ClassLib.ComFunction.Empty_Combo(cmb_SizeYN, " ");
				MyOraDB.Parameter_Values[6]  = ClassLib.ComFunction.Empty_Combo(cmb_Process," ");
				MyOraDB.Parameter_Values[7]  = ClassLib.ComFunction.Empty_Combo(cmb_Line, " ");
				MyOraDB.Parameter_Values[8]  = cmb_OutDiv.SelectedValue.ToString();
				MyOraDB.Parameter_Values[9]  = "";
				MyOraDB.Parameter_Values[10] = _OutStatus;
				MyOraDB.Parameter_Values[11] = (_OutStatus == _OutStatus_Confirm) ? "Y" : "N";
				MyOraDB.Parameter_Values[12] = txt_Remarks.Text;
				MyOraDB.Parameter_Values[13] = ClassLib.ComVar.This_User;
			
				MyOraDB.Add_Modify_Parameter(arg_clear_flag);
				return true;


			}
			catch
			{
				return false;
			}

		}



		private bool Save_SBO_OUT_TAIL(string arg_out_no, bool arg_clear_flag)
		{

			try
			{
 
				int col_ct = fgrid_main.Cols.Count + 1;	  


				MyOraDB.ReDim_Parameter(col_ct);

				// PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SAVE_SBO_OUT_TAIL";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				for(int i = 1; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Name[i] = "ARG_" + fgrid_main[0, i].ToString(); 
				}
				MyOraDB.Parameter_Name[col_ct - 1] = "ARG_UPD_USER";

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct - 1; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 
				 

				// DATA 정의   
				ArrayList vList = new ArrayList(); 

				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count ; i++)
				{
					if(fgrid_main[i, 0] == null) continue;
					if(fgrid_main[i, 0].ToString() == "") continue;
					  
					for(int j = 0; j < col_ct - 1; j++)	 
					{  
					
						if(j == (int)ClassLib.TBSBO_OUTGOING_OTHER.IxOUT_NO)
						{
							vList.Add(arg_out_no);
						}
						else
						{
							vList.Add( (fgrid_main[i, j] == null) ? "" : fgrid_main[i, j].ToString() );  
						}
							
					}  
					
					vList.Add(ClassLib.ComVar.This_User);  

					 
				} // end for i
			
				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(arg_clear_flag);
				return true;



			}
			catch
			{
				return false;
			}

		}



		private bool Save_SBO_OUT_SIZE(string arg_out_no, bool arg_clear_flag)
		{

			try
			{
				MyOraDB.ReDim_Parameter(8);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SAVE_SBO_OUT_SIZE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2]  = "ARG_OUT_NO";
				MyOraDB.Parameter_Name[3]  = "ARG_CS_SIZE";
				MyOraDB.Parameter_Name[4]  = "ARG_CS_QTY";
				MyOraDB.Parameter_Name[5]  = "ARG_REMARKS";
				MyOraDB.Parameter_Name[6]  = "ARG_STATUS";
				MyOraDB.Parameter_Name[7]  = "ARG_UPD_USER";   

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7]  = (int)OracleType.VarChar; 

				//04.DATA 정의  
				ArrayList vList = new ArrayList(); 


				vList.Add("D"); 
				vList.Add(cmb_Factory.SelectedValue.ToString() );
				vList.Add(arg_out_no);
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");
				vList.Add("");
 
				 
				for(int i = 0 ; i < ClassLib.ComVar.Parameter_PopUpTable2.Rows.Count ; i++)
				{ 

					if(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString() == ""
						|| ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString() == "0") continue; 
				


					vList.Add("I"); 
					vList.Add(cmb_Factory.SelectedValue.ToString() );
					vList.Add(arg_out_no);
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[3].ToString());
					vList.Add(ClassLib.ComVar.Parameter_PopUpTable2.Rows[i].ItemArray[2].ToString());
					vList.Add("");  //remarks
					vList.Add(_OutStatus);
					vList.Add(ClassLib.ComVar.This_User);



				}
				 


				MyOraDB.Parameter_Values = (string[])vList.ToArray(Type.GetType("System.String")); 
			
				MyOraDB.Add_Modify_Parameter(arg_clear_flag);
				return true;

			}
			catch
			{
				return false;
			}


		}




		#endregion


	
		/// <summary>
		/// Delete_SBO_OUT : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_no"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns></returns>
		private bool Delete_SBO_OUT(string arg_factory, string arg_out_no, string arg_upd_user)
		{

			try
			{
  

				MyOraDB.ReDim_Parameter(3);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.DELETE_SBO_OUT"; 
 

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_no;
				MyOraDB.Parameter_Values[2] = arg_upd_user; 

				MyOraDB.Add_Modify_Parameter(true);						 
				DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_Set == null) return false;
				
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}




		 
		private bool Update_SBO_OUT_STATUS(string[] arg_save_parameter)
		{

			try
			{
 

				MyOraDB.ReDim_Parameter(7);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.UPDATE_SBO_OUT"; 
 

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_NO"; 
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD"; 
				MyOraDB.Parameter_Name[3] = "ARG_WH_CD"; 
				MyOraDB.Parameter_Name[4] = "ARG_OUT_STATUS";
				MyOraDB.Parameter_Name[5] = "ARG_CONFIRM_YN";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER"; 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 

				//04.DATA 정의 
				MyOraDB.Parameter_Values[0] = arg_save_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_save_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_save_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_save_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_save_parameter[4];
				MyOraDB.Parameter_Values[5] = arg_save_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_save_parameter[6]; 

				MyOraDB.Add_Modify_Parameter(true);						 
				DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_Set == null) return false;
				
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}




		
		#endregion

	}
}

