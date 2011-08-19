using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;
using FlexPurchase.Incoming;


namespace FlexPurchase.Purchase
{
	public class Form_BP_Purchase_Request : COM.PCHWinForm.Form_Top
	{


		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_reqYmd;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Panel pnl_low;

		private System.ComponentModel.IContainer components = null;

		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.DateTimePicker dpick_to;
		public System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_Out;
		private System.Windows.Forms.Label btn_Incoming;
		private System.Windows.Forms.Label btn_Purchase;
		private System.Windows.Forms.Label btn_PurchaseM;
		private System.Windows.Forms.Label btn_Receive;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_All;
		private System.Windows.Forms.ContextMenu cmenu_grid;
		private System.Windows.Forms.MenuItem menuItem_Vendor;
		private System.Windows.Forms.MenuItem menuItem_Incoming;
		private System.Windows.Forms.MenuItem menuItem_Outgoing;
		private System.Windows.Forms.MenuItem menuItem_Separator1;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.MenuItem menuItem_Status;
		private System.Windows.Forms.MenuItem menuItem_Separator2;
		private System.Windows.Forms.MenuItem menuItem_RunAll;
		private System.Windows.Forms.Label lblexcep_mark;

		#endregion 

		#region 생성자 / 소멸자

		public Form_BP_Purchase_Request()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_Purchase_Request));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.btn_All = new System.Windows.Forms.Label();
            this.btn_Receive = new System.Windows.Forms.Label();
            this.btn_PurchaseM = new System.Windows.Forms.Label();
            this.btn_Purchase = new System.Windows.Forms.Label();
            this.btn_Incoming = new System.Windows.Forms.Label();
            this.btn_Out = new System.Windows.Forms.Label();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_reqYmd = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_Status = new System.Windows.Forms.MenuItem();
            this.menuItem_Vendor = new System.Windows.Forms.MenuItem();
            this.menuItem_Incoming = new System.Windows.Forms.MenuItem();
            this.menuItem_Outgoing = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator2 = new System.Windows.Forms.MenuItem();
            this.menuItem_RunAll = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            this.pnl_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.pnl_main);
            this.c1Sizer1.GridDefinition = "17.3611111111111:False:True;75.1736111111111:False:False;6.07638888888889:False:T" +
                "rue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.btn_All);
            this.pnl_low.Controls.Add(this.btn_Receive);
            this.pnl_low.Controls.Add(this.btn_PurchaseM);
            this.pnl_low.Controls.Add(this.btn_Purchase);
            this.pnl_low.Controls.Add(this.btn_Incoming);
            this.pnl_low.Controls.Add(this.btn_Out);
            this.pnl_low.Location = new System.Drawing.Point(8, 541);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1000, 35);
            this.pnl_low.TabIndex = 3;
            // 
            // btn_All
            // 
            this.btn_All.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_All.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_All.ImageIndex = 0;
            this.btn_All.ImageList = this.img_Button;
            this.btn_All.Location = new System.Drawing.Point(920, 8);
            this.btn_All.Name = "btn_All";
            this.btn_All.Size = new System.Drawing.Size(80, 23);
            this.btn_All.TabIndex = 673;
            this.btn_All.Text = "All";
            this.btn_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_All.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_All.Click += new System.EventHandler(this.btn_All_Click);
            this.btn_All.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_All.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_All.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Receive
            // 
            this.btn_Receive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Receive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Receive.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Receive.ImageIndex = 0;
            this.btn_Receive.ImageList = this.img_Button;
            this.btn_Receive.Location = new System.Drawing.Point(515, 8);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(80, 23);
            this.btn_Receive.TabIndex = 672;
            this.btn_Receive.Text = "Receive";
            this.btn_Receive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Receive.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            this.btn_Receive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Receive.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Receive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_PurchaseM
            // 
            this.btn_PurchaseM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_PurchaseM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_PurchaseM.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_PurchaseM.ImageIndex = 0;
            this.btn_PurchaseM.ImageList = this.img_Button;
            this.btn_PurchaseM.Location = new System.Drawing.Point(596, 8);
            this.btn_PurchaseM.Name = "btn_PurchaseM";
            this.btn_PurchaseM.Size = new System.Drawing.Size(80, 23);
            this.btn_PurchaseM.TabIndex = 671;
            this.btn_PurchaseM.Text = "Purchase M";
            this.btn_PurchaseM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_PurchaseM.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_PurchaseM.Click += new System.EventHandler(this.btn_PurchaseM_Click);
            this.btn_PurchaseM.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_PurchaseM.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_PurchaseM.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Purchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Purchase.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Purchase.ImageIndex = 0;
            this.btn_Purchase.ImageList = this.img_Button;
            this.btn_Purchase.Location = new System.Drawing.Point(677, 8);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(80, 23);
            this.btn_Purchase.TabIndex = 670;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Purchase.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            this.btn_Purchase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Purchase.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Purchase.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Incoming
            // 
            this.btn_Incoming.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Incoming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Incoming.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Incoming.ImageIndex = 0;
            this.btn_Incoming.ImageList = this.img_Button;
            this.btn_Incoming.Location = new System.Drawing.Point(758, 8);
            this.btn_Incoming.Name = "btn_Incoming";
            this.btn_Incoming.Size = new System.Drawing.Size(80, 23);
            this.btn_Incoming.TabIndex = 669;
            this.btn_Incoming.Text = "Incoming";
            this.btn_Incoming.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Incoming.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Incoming.Click += new System.EventHandler(this.btn_Incoming_Click);
            this.btn_Incoming.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Incoming.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Incoming.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Out
            // 
            this.btn_Out.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Out.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Out.ImageIndex = 0;
            this.btn_Out.ImageList = this.img_Button;
            this.btn_Out.Location = new System.Drawing.Point(839, 8);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(80, 23);
            this.btn_Out.TabIndex = 668;
            this.btn_Out.Text = "Outgoing";
            this.btn_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Out.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Out.Click += new System.EventHandler(this.btn_Out_Click);
            this.btn_Out.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Out.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Out.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.dpick_from);
            this.pnl_head.Controls.Add(this.dpick_to);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_reqYmd);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_factory);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 100);
            this.pnl_head.TabIndex = 0;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(546, 40);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 428;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style1;
            this.cmb_itemGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_itemGroup.ColumnCaptionHeight = 18;
            this.cmb_itemGroup.ColumnFooterHeight = 18;
            this.cmb_itemGroup.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_itemGroup.ContentHeight = 16;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 16;
            this.cmb_itemGroup.EvenRowStyle = style2;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style3;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style4;
            this.cmb_itemGroup.HighLightRowStyle = style5;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(445, 40);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style6;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style7;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style8;
            this.cmb_itemGroup.TabIndex = 427;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(505, 62);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 429;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(445, 62);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 425;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(344, 40);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 423;
            this.lbl_itemgroup.Text = "Item Group";
            this.lbl_itemgroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_groupSearch
            // 
            this.btn_groupSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btn_groupSearch.Enabled = false;
            this.btn_groupSearch.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_groupSearch.ImageIndex = 27;
            this.btn_groupSearch.ImageList = this.img_SmallButton;
            this.btn_groupSearch.Location = new System.Drawing.Point(646, 40);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 426;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(344, 62);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 424;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(109, 62);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(95, 21);
            this.dpick_from.TabIndex = 179;
            this.dpick_from.ValueChanged += new System.EventHandler(this.dpick_from_ValueChanged);
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(226, 62);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(95, 21);
            this.dpick_to.TabIndex = 180;
            this.dpick_to.ValueChanged += new System.EventHandler(this.dpick_to_ValueChanged);
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(207, 65);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 181;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 84);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_reqYmd
            // 
            this.lbl_reqYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqYmd.ImageIndex = 0;
            this.lbl_reqYmd.ImageList = this.img_Label;
            this.lbl_reqYmd.Location = new System.Drawing.Point(8, 62);
            this.lbl_reqYmd.Name = "lbl_reqYmd";
            this.lbl_reqYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqYmd.TabIndex = 50;
            this.lbl_reqYmd.Text = "Request Date";
            this.lbl_reqYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 83);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
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
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 59);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(984, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "      Request";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(208, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(960, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 84);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 73);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.spd_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 104);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 433);
            this.pnl_main.TabIndex = 1;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.ContextMenu = this.cmenu_grid;
            this.spd_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spd_main.Location = new System.Drawing.Point(0, 0);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 433);
            this.spd_main.TabIndex = 0;
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_Status,
            this.menuItem_Vendor,
            this.menuItem_Incoming,
            this.menuItem_Outgoing,
            this.menuItem_Separator1,
            this.menuItem_ValueChange,
            this.menuItem_Separator2,
            this.menuItem_RunAll});
            this.cmenu_grid.Popup += new System.EventHandler(this.cmenu_grid_Popup);
            // 
            // menuItem_Status
            // 
            this.menuItem_Status.Index = 0;
            this.menuItem_Status.Text = "Status";
            this.menuItem_Status.Click += new System.EventHandler(this.menuItem_Status_Click);
            // 
            // menuItem_Vendor
            // 
            this.menuItem_Vendor.Index = 1;
            this.menuItem_Vendor.Text = "Vendor";
            this.menuItem_Vendor.Click += new System.EventHandler(this.menuItem_Vendor_Click);
            // 
            // menuItem_Incoming
            // 
            this.menuItem_Incoming.Index = 2;
            this.menuItem_Incoming.Text = "Incoming";
            this.menuItem_Incoming.Click += new System.EventHandler(this.menuItem_Incoming_Click);
            // 
            // menuItem_Outgoing
            // 
            this.menuItem_Outgoing.Index = 3;
            this.menuItem_Outgoing.Text = "Outgoing";
            this.menuItem_Outgoing.Click += new System.EventHandler(this.menuItem_Outgoing_Click);
            // 
            // menuItem_Separator1
            // 
            this.menuItem_Separator1.Index = 4;
            this.menuItem_Separator1.Text = "-";
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 5;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem_Separator2
            // 
            this.menuItem_Separator2.Index = 6;
            this.menuItem_Separator2.Text = "-";
            // 
            // menuItem_RunAll
            // 
            this.menuItem_RunAll.Index = 7;
            this.menuItem_RunAll.Text = "Run [All]";
            this.menuItem_RunAll.Click += new System.EventHandler(this.menuItem_RunAll_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // Form_BP_Purchase_Request
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BP_Purchase_Request";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_low.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            this.pnl_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();


		#endregion

		#region 멤버 메소드


		private DataTable _DT_GridHead = null;

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{

			try
			{

				// form initialize
				ClassLib.ComFunction.Init_Form_Control(this);

                lbl_MainTitle.Text = "Purchase Request Monitoring";
                this.Text = "Purchase Request Monitoring";
                ClassLib.ComFunction.SetLangDic(this);

				// grid set
				spd_main.Set_Spread_Comm("SBP_PURCHASE_REQUEST", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true); 
				// Farpoint Spread Header Merge
			    Mearge_GridHead();

				 

				// factory set
				DataTable dt_ret = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(dt_ret, cmb_factory, 0, 1, false, 40,125);
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

				//그룹타입 콤보쿼리 
				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  

				dt_ret.Dispose(); 


				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 

 
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = false;


				// 저장 권한 : 한국
				if(ClassLib.ComVar.This_Factory == ClassLib.ComVar.DSFactory)
				{
					tbtn_Save.Enabled = true;
				}
				else
				{
					tbtn_Save.Enabled = false;
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		/// <summary>
		/// Mearge_GridHead : Farpoint Spread Header Merge
		/// </summary>
		private void Mearge_GridHead()
		{
			
			try
			{

				for (int vCol = 0 ; vCol < spd_main.ActiveSheet.ColumnCount ; vCol++)
				{
					
					if (spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim().Equals(spd_main.ActiveSheet.ColumnHeader.Cells[2, vCol].Text.ToString().Trim()))
					{
						spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].RowSpan = 2;
					}
					else
					{
						int vCnt  = 0;
						
						for ( int j = vCol ; j < spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if( vCnt > 0 &&  spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() != spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								break;
							}
							else if ( spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].Text.ToString().Trim() == spd_main.ActiveSheet.ColumnHeader.Cells[1, j].Text.ToString().Trim() )	
							{
								vCnt++;
							}
						}

						vCol = vCol + vCnt-1;
					}
				}


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Mearge_GridHead", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}


		#endregion  

		#region 이벤트 처리

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 
 
				
				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";


				spd_main.ClearAll();  



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void dpick_from_ValueChanged(object sender, System.EventArgs e)
		{

			
			try
			{ 

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
 
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 
 

				
				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";


				spd_main.ClearAll();  



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_from_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		
		}

		private void dpick_to_ValueChanged(object sender, System.EventArgs e)
		{
		

			try
			{  

				spd_main.ClearAll();  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_from_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}



		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{

				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

				dpick_from.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_to.Text = MyComFunction.ConvertDate2Type(nowymd); 

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";


				spd_main.ClearAll();  


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}


		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _popWait = null;


		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			Thread temp_thread = null;
		
			try
			{

				this.Cursor = Cursors.WaitCursor;

				if(cmb_factory.SelectedIndex == -1) return;
 

//				temp_thread = new Thread(new ThreadStart(Search_Main));
//			
//
//				if (temp_thread != null)
//				{
//					 
//					temp_thread.Start();  //"[" + cmb_factory.SelectedValue.ToString() + " Request Data]"
//					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
//					_popWait.Processing();
//					_popWait.Start();
//				}
 

				Search_Main();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
				if (temp_thread != null) _popWait.Close();
			}
			finally
			{
				this.Cursor = Cursors.Default;  
				if (temp_thread != null) _popWait.Close();
				

			}
 

		}
 



		private string _itemGroupCode = " ";


		private void cmb_itemGroup_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try 
			{
				if ( cmb_itemGroup.SelectedIndex != -1 )
				{
					btn_groupSearch.Enabled = true;
					txt_itemGroup.Text = "";
					_itemGroupCode = cmb_itemGroup.SelectedValue.ToString();

				}
				else
				{
					
					btn_groupSearch.Enabled = false;
					txt_itemGroup.Text = "";
					_itemGroupCode = " ";
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}

		}


		private void btn_groupSearch_Click(object sender, System.EventArgs e)
		{
		
			try
			{

				string vTyep = cmb_itemGroup.SelectedValue.ToString();
				FlexBase.MaterialBase.Pop_GroupSearchAll vPopup = new FlexBase.MaterialBase.Pop_GroupSearchAll(vTyep);
				
				vPopup.ShowDialog();
			
				_itemGroupCode = COM.ComVar.Parameter_PopUp[3];
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_ETS();
		}


		private void Save_ETS()
		{

			try
			{ 
				
				this.Cursor = Cursors.WaitCursor;

				if(cmb_factory.SelectedIndex == -1) return;  
				if(spd_main.ActiveSheet.RowCount == 0) return;

				int sel_row = spd_main.ActiveSheet.ActiveRowIndex;

				if( spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Value.Equals("")
					|| spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_NO].Value.Equals("")
					|| spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_SEQ].Value.Equals("") ) return;
 

				bool save_flag = Update_SBP_PURCHASE_TAIL_ETSYMD();

				if(! save_flag)
				{

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;

				}
				else
				{

					spd_main.Refresh_Division();

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);


				} 

				 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_ETS", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{

				this.Cursor = Cursors.Default;

			}


		}



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


		private void btn_Receive_Click(object sender, System.EventArgs e)
		{ 

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				_AllClick_Flag = false;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;

				
				temp_thread = new Thread(new ThreadStart(Receive));
			

				if (temp_thread != null)
				{
					temp_thread.Start();  //"[DS Purchase Request Transfer Data]"
					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
					_popWait.Processing();
					_popWait.Start();
 
				}
				 


			}
			catch (Exception ex)
			{
				//if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}
 
		}

		private void btn_PurchaseM_Click(object sender, System.EventArgs e)
		{ 

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				_AllClick_Flag = false;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return; 

				
				temp_thread = new Thread(new ThreadStart(Purchase_Manager));
			

				if (temp_thread != null)
				{
					temp_thread.Start();  //"[DS Purchase Manager Data]"
					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
					_popWait.Processing();
					_popWait.Start();
 
				}
				 


			}
			catch (Exception ex)
			{
				//if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "Purchase Manager", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}

 
		}

		private void btn_Purchase_Click(object sender, System.EventArgs e)
		{ 

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				_AllClick_Flag = false;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;

				
				temp_thread = new Thread(new ThreadStart(Purchase));
			

				if (temp_thread != null)
				{
					temp_thread.Start();  //"[DS Purchase Data]"
					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
					_popWait.Processing();
					_popWait.Start(); 
				}
				 


			}
			catch (Exception ex)
			{
				//if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "Purchase", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}

		}

		private void btn_Incoming_Click(object sender, System.EventArgs e)
		{  

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				_AllClick_Flag = false;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;

				
				temp_thread = new Thread(new ThreadStart(Incoming));
			

				if (temp_thread != null)
				{
					temp_thread.Start();  //"[DS Incoming Data]"
					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
					_popWait.Processing();
					_popWait.Start(); 
				} 


			}
			catch (Exception ex)
			{
				//if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "Incoming", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}
			 
		}

		private void btn_Out_Click(object sender, System.EventArgs e)
		{ 

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor;

				_AllClick_Flag = false;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;

				
				temp_thread = new Thread(new ThreadStart(Outgoing));
			
				if (temp_thread != null)
				{
					temp_thread.Start();  //"[DS Outgoing Data]"
					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
					_popWait.Processing();
					_popWait.Start(); 
				} 
 


			}
			catch (Exception ex)
			{
				//if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "Outgoing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}
			   
			 
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Print(); 
		}

		
		private bool _AllClick_Flag = false;

		// 특정 아이템 선택해서 All 했을 경우
		private bool _AllClick_Item_Flag = false;

		private void btn_All_Click(object sender, System.EventArgs e)
		{

			Thread temp_thread = null;

			try
			{

				this.Cursor = Cursors.WaitCursor; 
				
				_AllClick_Flag = true;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;

				
//				temp_thread = new Thread(new ThreadStart(All));
//			
//				if (temp_thread != null)
//				{
//					temp_thread.Start();  
//					_popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
//					_popWait.Processing();
//					_popWait.Start(); 
//				} 
 

				All();


			}
			catch (Exception ex)
			{
				if (temp_thread != null) _popWait.Close();
				ClassLib.ComFunction.User_Message(ex.Message, "All", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
				_AllClick_Flag = false;
				if (temp_thread != null) _popWait.Close();
			}

			 
		}


		#region 버튼 이벤트 관련 메서드


		private string _ST_Empty = ".";

 
		private DataTable _DT_Main = null;

		private void Search_Main()
		{ 

			string factory = cmb_factory.SelectedValue.ToString();
			string req_ymd_from = MyComFunction.ConvertDate2DbType(dpick_from.Text);
			string req_ymd_to = MyComFunction.ConvertDate2DbType(dpick_to.Text);

			string item_group = _itemGroupCode;
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");

			string user_factory = ClassLib.ComVar.This_Factory; 


			DataTable dt_ret = Select_SBP_REQUEST(factory, req_ymd_from, req_ymd_to, item_group, item_cd, item_name, user_factory);

			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll();  

				//_popWait.Close();

				return;
			}
 
 			
			spd_main.Display_Grid(dt_ret); 
 

//			_DT_Main = dt_ret;
//			dt_ret.Dispose();
//
//			AddRowToSpreadDelegate add_new_row = new AddRowToSpreadDelegate(Display_Grid);
//			spd_main.Invoke(add_new_row);
 
 
			ClassLib.ComFunction.MergeCell(spd_main, new int[]{(int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ});
			
//			_popWait.Close();


 
		}


//		'delagate for adding rows
//		'prevents IndexOutOfRange Exception 
		public delegate void AddRowToSpreadDelegate();
		
		
		private void Display_Grid()
		{

			try 
			{					
 
				spd_main.Sheets[0].ClearRange(0,0,spd_main.Sheets[0].Rows.Count,spd_main.Sheets[0].Columns.Count,true);						
				spd_main.Sheets[0].ClearRange(0,0,spd_main.Sheets[0].Rows.Count,1,false); 
				spd_main.Sheets[0].RowCount = _DT_Main.Rows.Count; 
									 
				object[,] arr = new object[_DT_Main.Rows.Count, _DT_Main.Columns.Count];
				for(int i = 0; i < _DT_Main.Rows.Count; i++)
				{				
					for(int j = 0; j < _DT_Main.Columns.Count; j++)
					{											
						switch(Convert.ToString(spd_main.Sheets[0].GetCellType(i,j+1)))				// Cell Type
						{
							case "CheckBoxCellType":
								if(_DT_Main.Rows[i].ItemArray[j].ToString()  == "" || _DT_Main.Rows[i].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToBoolean(_DT_Main.Rows[i].ItemArray[j]);
								}								
								break;
							case "DateTimeCellType":
								if(_DT_Main.Rows[i].ItemArray[j].ToString()  == "" || _DT_Main.Rows[i].ItemArray[j] == null )
								{
									arr[i,j] = "";
								}
								else
								{
									arr[i,j] = Convert.ToDateTime(_DT_Main.Rows[i].ItemArray[j]);
								}																
								break;
							default:
								arr[i,j] = _DT_Main.Rows[i].ItemArray[j];
								break;
						}
				 
					}					
				}
				 
 
				spd_main.Sheets[0].SetArray(0,1,arr) ; 
				
				spd_main.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
				spd_main.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
			}			
			
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Display_Grid",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}



		}




		private void Receive()
		{

			string factory = "";
			string req_no = "";
			string req_seq = "";
			string user_factory = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = null;


			if(! _AllClick_Item_Flag)
			{
 

				for(int i = 0; i < spd_main.ActiveSheet.Rows.Count; i++)
				{

					factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString();


					dt_ret = Select_SBM_MRP_REQUEST(factory, req_no, req_seq, user_factory);

					if(dt_ret == null || dt_ret.Rows.Count == 0) 
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_MRP_REQUEST].Text = _ST_Empty;
					}
					else
					{ 
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_MRP_REQUEST].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_MRP_REQ.IxSTATUS].ToString(); 
					}
					

 

				} 


			}
			else
			{

				CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
				int start_row = 0; 
				int end_row = 0;

				for (int j = 0 ; j < selection_range.Length; j++)
				{

					start_row = selection_range[j].Row;
					end_row = selection_range[j].Row + selection_range[j].RowCount; 

				 
					for (int i = start_row ; i < end_row; i++)
					{
						factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
						req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
						req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString();


						dt_ret = Select_SBM_MRP_REQUEST(factory, req_no, req_seq, user_factory);

						if(dt_ret == null || dt_ret.Rows.Count == 0) 
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_MRP_REQUEST].Text = _ST_Empty;
						}
						else
						{ 
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_MRP_REQUEST].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_MRP_REQ.IxSTATUS].ToString(); 
						}
 

					}
 
				
				}	

 
			}  // end if(! _AllClick_Item_Flag)



			dt_ret.Dispose();

			if(!_AllClick_Flag) _popWait.Close(); 

		}


		private void Purchase_Manager()
		{

			string factory = "";
			string req_no = "";
			string req_seq = "";
			string item_cd = "";
			string spec_cd = "";
			string color_cd = "";
			string user_factory = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = null;


			if(! _AllClick_Item_Flag)
			{

				for(int i = 0; i < spd_main.ActiveSheet.Rows.Count; i++)
				{

					factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString();
					item_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxITEM_CD].Text.ToString();
					spec_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSPEC_CD].Text.ToString();
					color_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCOLOR_CD].Text.ToString();


					dt_ret = Select_SBP_PURCHASE_MANAGER(factory, req_no, req_seq, item_cd, spec_cd, color_cd, user_factory);

					if(dt_ret == null || dt_ret.Rows.Count == 0) 
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE_MANAGER].Text = _ST_Empty; 
					}
					else
					{ 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE_MANAGER].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxSTATUS].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_NO].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_NO].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_SEQ].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_SEQ].ToString();  
						

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_USER].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_USER].ToString(); 


					} 
 
					

				} 

				 


			}
			else
			{

				CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
				int start_row = 0; 
				int end_row = 0;

				for (int j = 0 ; j < selection_range.Length; j++)
				{

					start_row = selection_range[j].Row;
					end_row = selection_range[j].Row + selection_range[j].RowCount; 

				 
					for (int i = start_row ; i < end_row; i++)
					{
						
						factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
						req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
						req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString();
						item_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxITEM_CD].Text.ToString();
						spec_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSPEC_CD].Text.ToString();
						color_cd = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCOLOR_CD].Text.ToString();


						dt_ret = Select_SBP_PURCHASE_MANAGER(factory, req_no, req_seq, item_cd, spec_cd, color_cd, user_factory);

						if(dt_ret == null || dt_ret.Rows.Count == 0) 
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE_MANAGER].Text = _ST_Empty; 
						}
						else
						{ 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE_MANAGER].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxSTATUS].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_NO].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_NO].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_SEQ].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_SEQ].ToString();  
						

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPUR_USER].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR_MANAGER.IxPUR_USER].ToString(); 


						} 

						 

					}

					
 
				
				}	

 
			}  // end if(! _AllClick_Item_Flag)



			dt_ret.Dispose();

			if(!_AllClick_Flag) _popWait.Close();
 

		}


		private void Purchase()
		{

			string factory = "";
			string req_no = "";
			string req_seq = ""; 
			string user_factory = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = null;


			if(! _AllClick_Item_Flag)
			{

				for(int i = 0; i < spd_main.ActiveSheet.Rows.Count; i++)
				{

					factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


					dt_ret = Select_SBP_PURCHASE(factory, req_no, req_seq, user_factory);

					if(dt_ret == null || dt_ret.Rows.Count == 0) 
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE].Text = _ST_Empty;
					}
					else
					{ 
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxSTATUS].ToString(); 


						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCUST_CD].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxCUST_CD].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCUST_NAME].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxCUST_NAME].ToString(); 


						if( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD1] is DBNull)
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value  = "";
						}
						else
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value 
								=  Convert.ToDateTime( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD1] ); 
						}

						if( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD2] is DBNull)
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value  = "";
						}
						else
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value
								= Convert.ToDateTime( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD2] );
						}

						  

					} 


					 

				} 

				 


			}
			else
			{

				CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
				int start_row = 0; 
				int end_row = 0;

				for (int j = 0 ; j < selection_range.Length; j++)
				{

					start_row = selection_range[j].Row;
					end_row = selection_range[j].Row + selection_range[j].RowCount; 

				 
					for (int i = start_row ; i < end_row; i++)
					{
						
						factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
						req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
						req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


						dt_ret = Select_SBP_PURCHASE(factory, req_no, req_seq, user_factory);

						if(dt_ret == null || dt_ret.Rows.Count == 0) 
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE].Text = _ST_Empty;
						}
						else
						{ 
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_PURCHASE].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxSTATUS].ToString(); 


							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCUST_CD].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxCUST_CD].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCUST_NAME].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxCUST_NAME].ToString(); 


							if( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD1] is DBNull)
							{
								spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value  = "";
							}
							else
							{
								spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value 
									=  Convert.ToDateTime( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD1] ); 
							}

							if( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD2] is DBNull)
							{
								spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value  = "";
							}
							else
							{
								spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value
									= Convert.ToDateTime( dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_PUR.IxETS_YMD2] );
							}

						  

						} 

 

					}
 
				
				}	

 
			}  // end if(! _AllClick_Item_Flag)



			dt_ret.Dispose();

			if(!_AllClick_Flag) _popWait.Close();
 

		}


		private void Incoming()
		{

			string factory = "";
			string req_no = "";
			string req_seq = ""; 
			string user_factory = ClassLib.ComVar.This_Factory;
			string pk = "";

			DataTable dt_ret = null;


			if(! _AllClick_Item_Flag)
			{

				
				for(int i = 0; i < spd_main.ActiveSheet.Rows.Count; i++)
				{

					factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


					dt_ret = Select_SBI_IN(factory, req_no, req_seq, user_factory);
 

					if(dt_ret == null || dt_ret.Rows.Count == 0) 
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_IN].Text = _ST_Empty;
					}
					else
					{ 
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_IN].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxSCAN_IN_STATE].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxBAR_CODE_REP].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxBAR_CODE_REP].ToString(); 


						pk = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPACKING].ToString()
							+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPK_NO_FROM].ToString()
							+ "-"
							+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPACKING].ToString()
							+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPK_NO_TO].ToString();

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPK_NO].Text = pk; 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_IN_YMD].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxSCAN_IN_YMD].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxIN_LOCATION].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxLOCATION].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxIN_CONT_NO].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxCONT_NO].ToString(); 
 
					}
 

				} 


				 


			}
			else
			{

				CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
				int start_row = 0; 
				int end_row = 0;

				for (int j = 0 ; j < selection_range.Length; j++)
				{

					start_row = selection_range[j].Row;
					end_row = selection_range[j].Row + selection_range[j].RowCount; 

				 
					for (int i = start_row ; i < end_row; i++)
					{
						
						
						factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
						req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
						req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


						dt_ret = Select_SBI_IN(factory, req_no, req_seq, user_factory);
 

						if(dt_ret == null || dt_ret.Rows.Count == 0) 
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_IN].Text = _ST_Empty;
						}
						else
						{ 
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_IN].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxSCAN_IN_STATE].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxBAR_CODE_REP].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxBAR_CODE_REP].ToString(); 


							pk = dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPACKING].ToString()
								+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPK_NO_FROM].ToString()
								+ "-"
								+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPACKING].ToString()
								+ dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxPK_NO_TO].ToString();

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxPK_NO].Text = pk; 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_IN_YMD].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxSCAN_IN_YMD].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxIN_LOCATION].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxLOCATION].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxIN_CONT_NO].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_IN.IxCONT_NO].ToString(); 
 
						}


						 

					}
 
				
				}	

 
			}  // end if(! _AllClick_Item_Flag)



			dt_ret.Dispose();

			if(!_AllClick_Flag) _popWait.Close();
 


		}


		private void Outgoing()
		{

			string factory = "";
			string req_no = "";
			string req_seq = "";  
			string user_factory = ClassLib.ComVar.This_Factory;

			DataTable dt_ret = null;


			if(! _AllClick_Item_Flag)
			{

				
				for(int i = 0; i < spd_main.ActiveSheet.Rows.Count; i++)
				{

					factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


					dt_ret = Select_SBO_OUT(factory, req_no, req_seq, user_factory);
 

					if(dt_ret == null || dt_ret.Rows.Count == 0) 
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_OUT].Text = _ST_Empty;
					}
					else
					{ 
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_OUT].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxSCAN_OUT_STATE].ToString(); 
 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_OUT_YMD].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxSCAN_OUT_YMD].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_LOCATION].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxLOCATION].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_CONT_NO].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxCONT_NO].ToString(); 

						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_TRANSPORT].Text 
							= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxBAR_MOVE].ToString(); 

 
					}

					
					 
				} 

				 


			}
			else
			{

				CellRange[] selection_range = spd_main.ActiveSheet.GetSelections(); 
				int start_row = 0; 
				int end_row = 0;

				for (int j = 0 ; j < selection_range.Length; j++)
				{

					start_row = selection_range[j].Row;
					end_row = selection_range[j].Row + selection_range[j].RowCount; 

				 
					for (int i = start_row ; i < end_row; i++)
					{
						
						
						factory = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
						req_no = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
						req_seq = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString(); 


						dt_ret = Select_SBO_OUT(factory, req_no, req_seq, user_factory);
 

						if(dt_ret == null || dt_ret.Rows.Count == 0) 
						{
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_OUT].Text = _ST_Empty;
						}
						else
						{ 
							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_OUT].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxSCAN_OUT_STATE].ToString(); 
 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_OUT_YMD].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxSCAN_OUT_YMD].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_LOCATION].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxLOCATION].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_CONT_NO].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxCONT_NO].ToString(); 

							spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxOUT_TRANSPORT].Text 
								= dt_ret.Rows[0].ItemArray[(int)ClassLib.TBSBM_PURCHAES_REQUEST_STATUS_OUT.IxBAR_MOVE].ToString(); 

 
						}

						 

					}

					
				
				}	

 
			}  // end if(! _AllClick_Item_Flag)



			dt_ret.Dispose();

			if(!_AllClick_Flag) _popWait.Close(); 
 

		}
		 

		private void All()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;

				if(cmb_factory.SelectedIndex == -1) return;
				if(spd_main.ActiveSheet.RowCount == 0) return;


				Receive();
				Purchase_Manager();
				Purchase();
				Incoming();
				Outgoing();
 
 

			}
			catch (Exception ex)
			{ 
				ClassLib.ComFunction.User_Message(ex.Message, "All", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 
				//_popWait.Close();
			}


			 

		}


		private void Run_All()
		{
 
			_AllClick_Item_Flag = true;

			btn_All_Click(null, null); 

			_AllClick_Item_Flag = false;

		}



		#endregion

		#region 프린트

		private void Print()
		{

			try
			{


				if(cmb_factory.SelectedIndex == -1) return;


				string report_path = Application.StartupPath + @"\Report\Material\"; 

				string filename = "";  //report_path + this.Name + ".txt";
				string mrd_filename = "";

				FlexPurchase.Shipping.Pop_BS_Print_Type vPop = new FlexPurchase.Shipping.Pop_BS_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);   // sbp12


				filename = report_path + "Form_BP_Purchase_Request.txt";

				if (vPop.ShowDialog() == DialogResult.OK)
				{
					string vPrintType = COM.ComVar.Parameter_PopUp[0];

					switch (vPrintType)
					{
						case "10":
							//filename = report_path + "Form_BP_Purchase_Request.txt";
							mrd_filename = report_path + "Form_BP_Purchase_Request.mrd";
							break;

						case "20":
							//filename = report_path + "Form_BP_Purchase_Request_02.txt";
							mrd_filename = report_path + "Form_BP_Purchase_Request_02.mrd";
							break;

						default:
							break;
					}
				}


				System.IO.FileInfo file = new System.IO.FileInfo(filename);
				if(!file.Exists)
				{
					file.Create().Close();
				}

				file = null; 

				spd_main.ActiveSheet.SaveTextFileRange(0, 1, spd_main.ActiveSheet.RowCount, spd_main.ActiveSheet.ColumnCount, filename, true, FarPoint.Win.Spread.Model.IncludeHeaders.None, "\r\n", "^", "");


				string factory = cmb_factory.SelectedValue.ToString();
				string req_ymd_from = dpick_from.Text;
				string req_ymd_to = dpick_to.Text;

				string item_group = "";
				
				if(cmb_itemGroup.SelectedIndex != -1) 
				{
					item_group = cmb_itemGroup.Columns[1].Text + ", " + txt_itemGroup.Text;
				}

				string item_cd = txt_itemCode.Text;
				string item_name = txt_itemName.Text;
			 
 
				string para = "/rfn [" + report_path + this.Name + ".txt] "
					+ "/rp "
					+ "[" + factory + "] "
					+ "[" + req_ymd_from + "] "
					+ "[" + req_ymd_to + "] "
					+ "[" + item_group + "] "
					+ "[" + item_cd + "] "
					+ "[" + item_name + "]";


				COM.Com_Form.Form_Report report = new COM.Com_Form.Form_Report("Purchase Request Monitoring", mrd_filename, para);
				report.ShowDialog(); 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Print", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion


		private void cmenu_grid_Popup(object sender, System.EventArgs e)
		{

			int vRow = spd_main.ActiveSheet.ActiveRowIndex ;
			int vCol = spd_main.ActiveSheet.ActiveColumnIndex ;

			if(vCol == (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD
				|| vCol == (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD)
			{
				menuItem_ValueChange.Enabled = true;
			}
			else
			{
				menuItem_ValueChange.Enabled = false;
			}

		
		}

		private void menuItem_Status_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxST_REQUEST_QD, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void menuItem_Vendor_Click(object sender, System.EventArgs e)
		{ 
			spd_main.ShowColumn(0, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxCUST_CD, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void menuItem_Incoming_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_IN_YMD, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void menuItem_Outgoing_Click(object sender, System.EventArgs e)
		{
			spd_main.ShowColumn(0, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxSCAN_OUT_YMD, FarPoint.Win.Spread.HorizontalPosition.Left); 
		}

		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
		
			Value_Change(); 
		}


		private void menuItem_RunAll_Click(object sender, System.EventArgs e)
		{
			Run_All();
		}


		private void Value_Change()
		{

			
			try
			{ 
				int vRow = spd_main.ActiveSheet.ActiveRowIndex ;
				int vCol = spd_main.ActiveSheet.ActiveColumnIndex ;

				if(vCol != (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD
					&& vCol != (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD) return;

				if( spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Value.Equals("")
					|| spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Value.Equals("")
					|| spd_main.ActiveSheet.Cells[vRow, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Value.Equals("") ) return; 


				CellRange[] vSelectionRange = spd_main.ActiveSheet.GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.ActiveSheet.GetCellType(vRow, vCol).ToString();
					COM.ComVar.Parameter_PopUp[1]	= spd_main.ActiveSheet.ColumnHeader.Cells[2,vCol].Text;

					//					if (_cellTypes.ContainsKey(vCol))
					//					{
					//						COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.SSPComboBoxCell;
					//						ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellTypes[vCol]};
					//					}

					Pop_BP_Purchase_List_Changer pop_changer = new Pop_BP_Purchase_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								if ( spd_main.ActiveSheet.GetCellType(vRow, vCol).ToString() == "DateTimeCellType")
									spd_main.ActiveSheet.Cells[j, vCol].Value = DateTime.Parse(COM.ComVar.Parameter_PopUp[0]);
								else
									spd_main.ActiveSheet.Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[0];

								spd_main.Update_Row(j, img_Action);
							}
						}

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Value_Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		

		




		#endregion

		#region DB Connect
		 
 		
		/// <summary>
		/// Select_SBP_REQUEST : 긴급분 발주 데이터 조회
		/// </summary> 
		private DataTable Select_SBP_REQUEST(string arg_factory, string arg_req_ymd_from, string arg_req_ymd_to, 
			string arg_item_group, string arg_item_cd, string arg_item_name, string arg_user_factory)
		{


			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(arg_factory); 



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBP_REQUEST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_YMD_TO";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[6] = "ARG_USER_FACTORY";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_ymd_from;
			MyOraDB.Parameter_Values[2] = arg_req_ymd_to;
			MyOraDB.Parameter_Values[3] = arg_item_group;
			MyOraDB.Parameter_Values[4] = arg_item_cd;
			MyOraDB.Parameter_Values[5] = arg_item_name;
			MyOraDB.Parameter_Values[6] = arg_user_factory;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();


			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  


			if(vds_ret == null) return null;  
			return vds_ret.Tables[MyOraDB.Process_Name];

		}



		         
		/// <summary>
		/// Select_SBM_MRP_REQUEST : 긴급분 발주 데이터 조회
		/// </summary> 
		private DataTable Select_SBM_MRP_REQUEST(string arg_factory, string arg_req_no, string arg_req_seq, string arg_user_factory)
		{

			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory); 



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBM_MRP_REQUEST";
  
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_USER_FACTORY"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = arg_req_seq; 
			MyOraDB.Parameter_Values[3] = arg_user_factory;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();


			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);   

			
			if(vds_ret == null) return null; 
			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		  
		/// <summary>
		/// Select_SBP_PURCHASE_MANAGER : 
		/// </summary> 
		private DataTable Select_SBP_PURCHASE_MANAGER(string arg_factory, string arg_req_no, string arg_req_seq, 
			string arg_item_cd, string arg_spec_cd, string arg_color_cd, string arg_user_factory)
		{

			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBP_PURCHASE_MANAGER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD"; 
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[6] = "ARG_USER_FACTORY"; 
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR"; 

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = arg_req_seq; 
			MyOraDB.Parameter_Values[3] = arg_item_cd;
			MyOraDB.Parameter_Values[4] = arg_spec_cd;
			MyOraDB.Parameter_Values[5] = arg_color_cd; 
			MyOraDB.Parameter_Values[6] = arg_user_factory;
			MyOraDB.Parameter_Values[7] = "";


			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure(); 
			

			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  

			
			if(vds_ret == null) return null; 
			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// Select_SBP_PURCHASE : 
		/// </summary> 
		private DataTable Select_SBP_PURCHASE(string arg_factory, string arg_req_no, string arg_req_seq, string arg_user_factory)
		{

			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory);



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBP_PURCHASE";
 
			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_USER_FACTORY"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = arg_req_seq; 
			MyOraDB.Parameter_Values[3] = arg_user_factory;
			MyOraDB.Parameter_Values[4] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();


			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  


			if(vds_ret == null) return null;
			return vds_ret.Tables[MyOraDB.Process_Name];

		}


		/// <summary>
		/// Select_SBI_IN : 
		/// </summary> 
		private DataTable Select_SBI_IN(string arg_factory, string arg_req_no, string arg_req_seq, string arg_user_factory)
		{

			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory); 



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBI_IN";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_USER_FACTORY"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = arg_req_seq; 
			MyOraDB.Parameter_Values[3] = arg_user_factory;
			MyOraDB.Parameter_Values[4] = "";


			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();


			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  


			if(vds_ret == null) return null; 
			return vds_ret.Tables[MyOraDB.Process_Name];

		}



		/// <summary>
		/// Select_SBO_OUT : 
		/// </summary> 
		private DataTable Select_SBO_OUT(string arg_factory, string arg_req_no, string arg_req_seq, string arg_user_factory)
		{

			// job factory Webservice 로 변경 
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory); 



			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.SELECT_SBO_OUT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
			MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
			MyOraDB.Parameter_Name[3] = "ARG_USER_FACTORY"; 
			MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_req_no;
			MyOraDB.Parameter_Values[2] = arg_req_seq; 
			MyOraDB.Parameter_Values[3] = arg_user_factory;
			MyOraDB.Parameter_Values[4] = "";


			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();


			// user factory Webservice 로 변경
			ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  


			if(vds_ret == null) return null; 
			return vds_ret.Tables[MyOraDB.Process_Name];

		}


 

		/// <summary>
		/// Update_SBP_PURCHASE_TAIL_ETSYMD : sbp_purchase_tail ets1, ets2 update
		/// </summary> 
		/// <returns></returns>
		private bool Update_SBP_PURCHASE_TAIL_ETSYMD()
		{

			try
			{
				
				DataSet ds_ret; 

				int col_ct = 6; 
				int save_ct = 0;    
				int para_ct = 0;  
				 
				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBP_PURCHASE_REQUEST.UPDATE_SBP_PURCHASE_ETSYMD";

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";   
				MyOraDB.Parameter_Name[1] = "ARG_REQ_NO";
				MyOraDB.Parameter_Name[2] = "ARG_REQ_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_ETS1_YMD";
				MyOraDB.Parameter_Name[4] = "ARG_ETS2_YMD"; 
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";   


				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				}


				// 저장 행 수 구하기
				for(int i = 0 ; i < spd_main.ActiveSheet.Rows.Count; i++)
				{
					spd_main.ActiveSheet.Cells[i,0].Tag = (spd_main.ActiveSheet.Cells[i,0].Tag == null) ? "" : spd_main.ActiveSheet.Cells[i,0].Tag.ToString();
					
					if( spd_main.ActiveSheet.Cells[i,0].Tag.ToString().Trim() == "") continue;
					 
					save_ct ++;						
					 
				}
		


				// 파라미터 값에 저장할 배열 
				MyOraDB.Parameter_Values  = new string[col_ct *  save_ct ];  
				

				// 각 행의 변경값 Setting 
				for(int i = 0 ; i < spd_main.ActiveSheet.Rows.Count; i++)
				{
 
					spd_main.ActiveSheet.Cells[i,0].Tag = (spd_main.ActiveSheet.Cells[i,0].Tag == null) ? "" : spd_main.ActiveSheet.Cells[i,0].Tag.ToString();
					
					if( spd_main.ActiveSheet.Cells[i,0].Tag.ToString().Trim() == "") continue; 
					 

					MyOraDB.Parameter_Values[para_ct++] = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxFACTORY].Text.ToString();
					MyOraDB.Parameter_Values[para_ct++] = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_NO].Text.ToString();
					MyOraDB.Parameter_Values[para_ct++] = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxREQ_SEQ].Text.ToString();
					
					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value.Equals("") )
					{
						MyOraDB.Parameter_Values[para_ct++] = "";
					}
					else
					{
						MyOraDB.Parameter_Values[para_ct++] = DateTime.Parse(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS1_YMD].Value.ToString() ).ToString("yyyyMMdd"); 
					}

					if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value.Equals("") )
					{
						MyOraDB.Parameter_Values[para_ct++] = "";
					}
					else
					{
						MyOraDB.Parameter_Values[para_ct++] = DateTime.Parse(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBP_PURCHAES_REQUEST.IxETS2_YMD].Value.ToString() ).ToString("yyyyMMdd");
					}

					
					
					
					MyOraDB.Parameter_Values[para_ct++] = ClassLib.ComVar.This_User;

				}
				 
	

 
				MyOraDB.Add_Modify_Parameter(true); 
				ds_ret = MyOraDB.Exe_Modify_Procedure();

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

		
 




	}
}
