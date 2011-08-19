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


namespace FlexMRP.MRP
{
	public class Form_BM_MRP_Monitoring : COM.PCHWinForm.Form_Top
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
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Panel pnl_low;

		private System.ComponentModel.IContainer components = null;
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
		private System.Windows.Forms.MenuItem menuItem_Status;
		private System.Windows.Forms.Label lbl_mrpno;
		private C1.Win.C1List.C1Combo cmb_mrpno;
		private C1.Win.C1List.C1Combo cmb_shipType;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.Label lbl_stylecd;
		private System.Windows.Forms.TextBox txt_styleCd;
		private C1.Win.C1List.C1Combo cmb_style;
		private System.Windows.Forms.Label btn_shipping;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.MenuItem menuItem_AllSelect;
		private System.Windows.Forms.MenuItem menuItem2;
		private C1.Win.C1List.C1Combo cmb_ubDivision;
		private System.Windows.Forms.Label lbl_UB;
		private System.Windows.Forms.MenuItem menuItem_Purchase;
		private System.Windows.Forms.MenuItem menuItem_Shipping;
		private System.Windows.Forms.MenuItem menuItem_RunAll;

		#endregion 

		#region 생성자 / 소멸자

		public Form_BM_MRP_Monitoring()
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
			Thread_Check(_d_dispose);

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_MRP_Monitoring));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.btn_All = new System.Windows.Forms.Label();
            this.btn_Receive = new System.Windows.Forms.Label();
            this.btn_PurchaseM = new System.Windows.Forms.Label();
            this.btn_Purchase = new System.Windows.Forms.Label();
            this.btn_Incoming = new System.Windows.Forms.Label();
            this.btn_Out = new System.Windows.Forms.Label();
            this.btn_shipping = new System.Windows.Forms.Label();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_ubDivision = new C1.Win.C1List.C1Combo();
            this.lbl_UB = new System.Windows.Forms.Label();
            this.lbl_stylecd = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.cmb_style = new C1.Win.C1List.C1Combo();
            this.cmb_shipType = new C1.Win.C1List.C1Combo();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.cmb_mrpno = new C1.Win.C1List.C1Combo();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_mrpno = new System.Windows.Forms.Label();
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
            this.fgrid_main = new COM.FSP();
            this.cmenu_grid = new System.Windows.Forms.ContextMenu();
            this.menuItem_AllSelect = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem_Status = new System.Windows.Forms.MenuItem();
            this.menuItem_Vendor = new System.Windows.Forms.MenuItem();
            this.menuItem_Purchase = new System.Windows.Forms.MenuItem();
            this.menuItem_Shipping = new System.Windows.Forms.MenuItem();
            this.menuItem_Incoming = new System.Windows.Forms.MenuItem();
            this.menuItem_Outgoing = new System.Windows.Forms.MenuItem();
            this.menuItem_Separator1 = new System.Windows.Forms.MenuItem();
            this.menuItem_RunAll = new System.Windows.Forms.MenuItem();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ubDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
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
            this.c1Sizer1.GridDefinition = "19.9652777777778:False:True;73.4375:False:False;5.20833333333333:False:True;\t0.39" +
                "3700787401575:False:True;98.4251968503937:False:False;0.393700787401575:False:Tr" +
                "ue;";
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
            this.pnl_low.Controls.Add(this.btn_shipping);
            this.pnl_low.Location = new System.Drawing.Point(8, 546);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1000, 30);
            this.pnl_low.TabIndex = 3;
            // 
            // btn_All
            // 
            this.btn_All.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_All.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_All.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_All.ImageIndex = 0;
            this.btn_All.ImageList = this.img_Button;
            this.btn_All.Location = new System.Drawing.Point(919, 4);
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
            this.btn_Receive.Location = new System.Drawing.Point(433, 4);
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
            this.btn_PurchaseM.Location = new System.Drawing.Point(514, 4);
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
            this.btn_Purchase.Location = new System.Drawing.Point(595, 4);
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
            this.btn_Incoming.Location = new System.Drawing.Point(757, 4);
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
            this.btn_Out.Location = new System.Drawing.Point(838, 4);
            this.btn_Out.Name = "btn_Out";
            this.btn_Out.Size = new System.Drawing.Size(80, 23);
            this.btn_Out.TabIndex = 668;
            this.btn_Out.Text = "Outgoing";
            this.btn_Out.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Out.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Out.Click += new System.EventHandler(this.btn_Outgoing_Click);
            this.btn_Out.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Out.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Out.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_shipping
            // 
            this.btn_shipping.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_shipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_shipping.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_shipping.ImageIndex = 0;
            this.btn_shipping.ImageList = this.img_Button;
            this.btn_shipping.Location = new System.Drawing.Point(676, 4);
            this.btn_shipping.Name = "btn_shipping";
            this.btn_shipping.Size = new System.Drawing.Size(80, 23);
            this.btn_shipping.TabIndex = 670;
            this.btn_shipping.Text = "Shipping";
            this.btn_shipping.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_shipping.Click += new System.EventHandler(this.btn_shipping_Click);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_ubDivision);
            this.pnl_head.Controls.Add(this.lbl_UB);
            this.pnl_head.Controls.Add(this.lbl_stylecd);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.cmb_style);
            this.pnl_head.Controls.Add(this.cmb_shipType);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.cmb_mrpno);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_mrpno);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 115);
            this.pnl_head.TabIndex = 0;
            // 
            // cmb_ubDivision
            // 
            this.cmb_ubDivision.AddItemCols = 0;
            this.cmb_ubDivision.AddItemSeparator = ';';
            this.cmb_ubDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_ubDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ubDivision.Caption = "";
            this.cmb_ubDivision.CaptionHeight = 17;
            this.cmb_ubDivision.CaptionStyle = style49;
            this.cmb_ubDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ubDivision.ColumnCaptionHeight = 18;
            this.cmb_ubDivision.ColumnFooterHeight = 18;
            this.cmb_ubDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ubDivision.ContentHeight = 16;
            this.cmb_ubDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ubDivision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ubDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ubDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ubDivision.EditorHeight = 16;
            this.cmb_ubDivision.EvenRowStyle = style50;
            this.cmb_ubDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_ubDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ubDivision.FooterStyle = style51;
            this.cmb_ubDivision.GapHeight = 2;
            this.cmb_ubDivision.HeadingStyle = style52;
            this.cmb_ubDivision.HighLightRowStyle = style53;
            this.cmb_ubDivision.ItemHeight = 15;
            this.cmb_ubDivision.Location = new System.Drawing.Point(767, 40);
            this.cmb_ubDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_ubDivision.MaxDropDownItems = ((short)(5));
            this.cmb_ubDivision.MaxLength = 32767;
            this.cmb_ubDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ubDivision.Name = "cmb_ubDivision";
            this.cmb_ubDivision.OddRowStyle = style54;
            this.cmb_ubDivision.PartialRightColumn = false;
            this.cmb_ubDivision.PropBag = resources.GetString("cmb_ubDivision.PropBag");
            this.cmb_ubDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ubDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ubDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ubDivision.SelectedStyle = style55;
            this.cmb_ubDivision.Size = new System.Drawing.Size(220, 20);
            this.cmb_ubDivision.Style = style56;
            this.cmb_ubDivision.TabIndex = 436;
            // 
            // lbl_UB
            // 
            this.lbl_UB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_UB.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UB.ImageIndex = 0;
            this.lbl_UB.ImageList = this.img_Label;
            this.lbl_UB.Location = new System.Drawing.Point(666, 40);
            this.lbl_UB.Name = "lbl_UB";
            this.lbl_UB.Size = new System.Drawing.Size(100, 21);
            this.lbl_UB.TabIndex = 437;
            this.lbl_UB.Text = "U/B Division";
            this.lbl_UB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_stylecd
            // 
            this.lbl_stylecd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_stylecd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stylecd.ImageIndex = 0;
            this.lbl_stylecd.ImageList = this.img_Label;
            this.lbl_stylecd.Location = new System.Drawing.Point(337, 40);
            this.lbl_stylecd.Name = "lbl_stylecd";
            this.lbl_stylecd.Size = new System.Drawing.Size(100, 21);
            this.lbl_stylecd.TabIndex = 433;
            this.lbl_stylecd.Text = "Style";
            this.lbl_stylecd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(438, 40);
            this.txt_styleCd.MaxLength = 10;
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.Size = new System.Drawing.Size(73, 21);
            this.txt_styleCd.TabIndex = 434;
            this.txt_styleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // cmb_style
            // 
            this.cmb_style.AddItemCols = 0;
            this.cmb_style.AddItemSeparator = ';';
            this.cmb_style.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_style.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_style.Caption = "";
            this.cmb_style.CaptionHeight = 17;
            this.cmb_style.CaptionStyle = style57;
            this.cmb_style.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_style.ColumnCaptionHeight = 18;
            this.cmb_style.ColumnFooterHeight = 18;
            this.cmb_style.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_style.ContentHeight = 16;
            this.cmb_style.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_style.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_style.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_style.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_style.EditorHeight = 16;
            this.cmb_style.EvenRowStyle = style58;
            this.cmb_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_style.FooterStyle = style59;
            this.cmb_style.GapHeight = 2;
            this.cmb_style.HeadingStyle = style60;
            this.cmb_style.HighLightRowStyle = style61;
            this.cmb_style.ItemHeight = 15;
            this.cmb_style.Location = new System.Drawing.Point(512, 40);
            this.cmb_style.MatchEntryTimeout = ((long)(2000));
            this.cmb_style.MaxDropDownItems = ((short)(5));
            this.cmb_style.MaxLength = 32767;
            this.cmb_style.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_style.Name = "cmb_style";
            this.cmb_style.OddRowStyle = style62;
            this.cmb_style.PartialRightColumn = false;
            this.cmb_style.PropBag = resources.GetString("cmb_style.PropBag");
            this.cmb_style.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_style.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_style.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_style.SelectedStyle = style63;
            this.cmb_style.Size = new System.Drawing.Size(146, 20);
            this.cmb_style.Style = style64;
            this.cmb_style.TabIndex = 435;
            this.cmb_style.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            // 
            // cmb_shipType
            // 
            this.cmb_shipType.AddItemCols = 0;
            this.cmb_shipType.AddItemSeparator = ';';
            this.cmb_shipType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipType.Caption = "";
            this.cmb_shipType.CaptionHeight = 17;
            this.cmb_shipType.CaptionStyle = style65;
            this.cmb_shipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipType.ColumnCaptionHeight = 18;
            this.cmb_shipType.ColumnFooterHeight = 18;
            this.cmb_shipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipType.ContentHeight = 16;
            this.cmb_shipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipType.EditorHeight = 16;
            this.cmb_shipType.EvenRowStyle = style66;
            this.cmb_shipType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipType.FooterStyle = style67;
            this.cmb_shipType.GapHeight = 2;
            this.cmb_shipType.HeadingStyle = style68;
            this.cmb_shipType.HighLightRowStyle = style69;
            this.cmb_shipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_shipType.ItemHeight = 15;
            this.cmb_shipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_shipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipType.MaxDropDownItems = ((short)(5));
            this.cmb_shipType.MaxLength = 32767;
            this.cmb_shipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipType.Name = "cmb_shipType";
            this.cmb_shipType.OddRowStyle = style70;
            this.cmb_shipType.PartialRightColumn = false;
            this.cmb_shipType.PropBag = resources.GetString("cmb_shipType.PropBag");
            this.cmb_shipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_shipType.SelectedStyle = style71;
            this.cmb_shipType.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipType.Style = style72;
            this.cmb_shipType.TabIndex = 431;
            this.cmb_shipType.SelectedValueChanged += new System.EventHandler(this.cmb_shipType_SelectedValueChanged);
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 1;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(8, 62);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 432;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_mrpno
            // 
            this.cmb_mrpno.AddItemCols = 0;
            this.cmb_mrpno.AddItemSeparator = ';';
            this.cmb_mrpno.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_mrpno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_mrpno.Caption = "";
            this.cmb_mrpno.CaptionHeight = 17;
            this.cmb_mrpno.CaptionStyle = style73;
            this.cmb_mrpno.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_mrpno.ColumnCaptionHeight = 18;
            this.cmb_mrpno.ColumnFooterHeight = 18;
            this.cmb_mrpno.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_mrpno.ContentHeight = 16;
            this.cmb_mrpno.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_mrpno.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_mrpno.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_mrpno.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_mrpno.EditorHeight = 16;
            this.cmb_mrpno.EvenRowStyle = style74;
            this.cmb_mrpno.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mrpno.FooterStyle = style75;
            this.cmb_mrpno.GapHeight = 2;
            this.cmb_mrpno.HeadingStyle = style76;
            this.cmb_mrpno.HighLightRowStyle = style77;
            this.cmb_mrpno.ItemHeight = 15;
            this.cmb_mrpno.Location = new System.Drawing.Point(109, 84);
            this.cmb_mrpno.MatchEntryTimeout = ((long)(2000));
            this.cmb_mrpno.MaxDropDownItems = ((short)(5));
            this.cmb_mrpno.MaxLength = 32767;
            this.cmb_mrpno.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_mrpno.Name = "cmb_mrpno";
            this.cmb_mrpno.OddRowStyle = style78;
            this.cmb_mrpno.PartialRightColumn = false;
            this.cmb_mrpno.PropBag = resources.GetString("cmb_mrpno.PropBag");
            this.cmb_mrpno.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_mrpno.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_mrpno.SelectedStyle = style79;
            this.cmb_mrpno.Size = new System.Drawing.Size(220, 20);
            this.cmb_mrpno.Style = style80;
            this.cmb_mrpno.TabIndex = 430;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(539, 62);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(97, 21);
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
            this.cmb_itemGroup.CaptionStyle = style81;
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
            this.cmb_itemGroup.EvenRowStyle = style82;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style83;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style84;
            this.cmb_itemGroup.HighLightRowStyle = style85;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(438, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style86;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style87;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style88;
            this.cmb_itemGroup.TabIndex = 427;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(498, 84);
            this.txt_itemName.MaxLength = 100;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(160, 21);
            this.txt_itemName.TabIndex = 429;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(438, 84);
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
            this.lbl_itemgroup.Location = new System.Drawing.Point(337, 62);
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
            this.btn_groupSearch.Location = new System.Drawing.Point(636, 62);
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
            this.lbl_item.Location = new System.Drawing.Point(337, 84);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 424;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 99);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_mrpno
            // 
            this.lbl_mrpno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_mrpno.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mrpno.ImageIndex = 0;
            this.lbl_mrpno.ImageList = this.img_Label;
            this.lbl_mrpno.Location = new System.Drawing.Point(8, 84);
            this.lbl_mrpno.Name = "lbl_mrpno";
            this.lbl_mrpno.Size = new System.Drawing.Size(100, 21);
            this.lbl_mrpno.TabIndex = 50;
            this.lbl_mrpno.Text = "MRP Ship No";
            this.lbl_mrpno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 98);
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
            this.cmb_factory.CaptionStyle = style89;
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
            this.cmb_factory.EvenRowStyle = style90;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style91;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style92;
            this.cmb_factory.HighLightRowStyle = style93;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style94;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style95;
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style96;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.SelectedValueChanged += new System.EventHandler(this.cmb_factory_SelectedValueChanged);
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
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
            this.pic_head7.Size = new System.Drawing.Size(101, 74);
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
            this.label2.Text = "      MRP Information";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 99);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 88);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.White;
            this.pnl_main.Controls.Add(this.fgrid_main);
            this.pnl_main.Location = new System.Drawing.Point(8, 119);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(1000, 423);
            this.pnl_main.TabIndex = 1;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_grid;
            this.fgrid_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(0, 0);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 423);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 0;
            // 
            // cmenu_grid
            // 
            this.cmenu_grid.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_AllSelect,
            this.menuItem2,
            this.menuItem_Status,
            this.menuItem_Vendor,
            this.menuItem_Purchase,
            this.menuItem_Shipping,
            this.menuItem_Incoming,
            this.menuItem_Outgoing,
            this.menuItem_Separator1,
            this.menuItem_RunAll});
            // 
            // menuItem_AllSelect
            // 
            this.menuItem_AllSelect.Index = 0;
            this.menuItem_AllSelect.Text = "All Select";
            this.menuItem_AllSelect.Click += new System.EventHandler(this.menuItem_AllSelect_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuItem_Status
            // 
            this.menuItem_Status.Index = 2;
            this.menuItem_Status.Text = "Status";
            this.menuItem_Status.Click += new System.EventHandler(this.menuItem_Status_Click);
            // 
            // menuItem_Vendor
            // 
            this.menuItem_Vendor.Index = 3;
            this.menuItem_Vendor.Text = "Vendor";
            this.menuItem_Vendor.Click += new System.EventHandler(this.menuItem_Vendor_Click);
            // 
            // menuItem_Purchase
            // 
            this.menuItem_Purchase.Index = 4;
            this.menuItem_Purchase.Text = "Purchase";
            this.menuItem_Purchase.Click += new System.EventHandler(this.menuItem_Purchase_Click);
            // 
            // menuItem_Shipping
            // 
            this.menuItem_Shipping.Index = 5;
            this.menuItem_Shipping.Text = "Shipping";
            this.menuItem_Shipping.Click += new System.EventHandler(this.menuItem_Shipping_Click);
            // 
            // menuItem_Incoming
            // 
            this.menuItem_Incoming.Index = 6;
            this.menuItem_Incoming.Text = "Incoming";
            this.menuItem_Incoming.Click += new System.EventHandler(this.menuItem_Incoming_Click);
            // 
            // menuItem_Outgoing
            // 
            this.menuItem_Outgoing.Index = 7;
            this.menuItem_Outgoing.Text = "Outgoing";
            this.menuItem_Outgoing.Click += new System.EventHandler(this.menuItem_Outgoing_Click);
            // 
            // menuItem_Separator1
            // 
            this.menuItem_Separator1.Index = 8;
            this.menuItem_Separator1.Text = "-";
            // 
            // menuItem_RunAll
            // 
            this.menuItem_RunAll.Index = 9;
            this.menuItem_RunAll.Text = "Run [All]";
            this.menuItem_RunAll.Click += new System.EventHandler(this.menuItem_RunAll_Click);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // Form_BM_MRP_Monitoring
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_MRP_Monitoring";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ubDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_style)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_mrpno)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private Pop_BM_Shipping_Wait _popWait = null;

		private string _itemGroupCode = " ";

		private const string _d_receive		= "SBM_MRP_REQUEST_DS"; 
		private const string _d_purchaseM	= "SBP_PURCHASE_MANAGER";
		private const string _d_purchase	= "SBP_PURCHASE_ORDER";
		private const string _d_shipping	= "SBS_SHIPPING_LIST";
		private const string _d_incoming	= "SBS_BAR_IN";
		private const string _d_outgoing	= "SBS_BAR_OUT";
		private const string _d_all			= "ALL";
		private const string _d_dispose		= "ALL THREAD DISPOSE";

		private const string _d_shipping_type_DS = "11";


		private string[] _shipNoTitles;
		private int[] _shipNoWidth;
		private bool[] _shipNoVisible;

		private Thread temp_thread = null;
		private Thread _t_receive, _t_purchaseM, _t_purchase, _t_shipping, _t_incoming, _t_outgoing;
		
		#endregion

		#region 초기화


		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
			try
			{

				// form initialize
				//ClassLib.ComFunction.Init_Form_Control(this);

				lbl_MainTitle.Text = "MRP Monitoring By Item";
				this.Text = "MRP Monitoring By Item";


                ClassLib.ComFunction.SetLangDic(this);


				// grid set
				fgrid_main.Set_Grid("SBM_MRP_MONITORING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
				fgrid_main.Rows[1].AllowMerging = true;
				fgrid_main.Set_Action_Image(img_Action);

				_shipNoTitles			= new string[]{"MRP Ship No", "Request Reason"};
				_shipNoWidth			= new int[]{	150,			60};
				_shipNoVisible			= new bool[]{true, true};

				// factory set
				DataTable vDt = COM.ComFunction.Select_Factory_List();
				COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false, 40,125);
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
				vDt.Dispose();

				// ship type set
				vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
				COM.ComCtl.Set_ComboList(vDt, cmb_shipType, 1, 2, false);
				cmb_shipType.SelectedIndex = 0;
				vDt.Dispose();

				// group type
				vDt = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false,  0, 130);  
				vDt.Dispose();

				// upper, bottom division
				vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM10");
				COM.ComCtl.Set_ComboList(vDt, cmb_ubDivision, 1, 2, true);
				cmb_ubDivision.SelectedIndex = 1;
				vDt.Dispose(); 

				tbtn_Save.Enabled = false;
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = false;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		#endregion  

		#region 이벤트

		#region 툴바 메뉴

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

				cmb_shipType.SelectedIndex = 0;

				cmb_mrpno.SelectedIndex = -1;

				cmb_itemGroup.SelectedIndex = -1;
				txt_itemGroup.Text = "";
				txt_itemCode.Text = "";
				txt_itemName.Text = "";


				fgrid_main.ClearAll();  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			try
			{
				_popWait = new Pop_BM_Shipping_Wait();

				this.Cursor = Cursors.WaitCursor;
 
				temp_thread = new Thread(new ThreadStart(_popWait.Start));

				if (temp_thread != null)
				{
					temp_thread.Start();
					Search_Main();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			finally
			{
				this.Cursor = Cursors.Default;
				if (temp_thread != null)
					temp_thread.Abort();
			}
		}

		#endregion

		#region 검색 조건

		private void cmb_factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{ 
				fgrid_main.ClearAll(); 
				Cmb_MrpShipNoSetting();
				fgrid_main[2, (int)ClassLib.TBSBM_MRP_MONITORING.IxST_MRP_REQUEST_FOREIGN] = COM.ComFunction.Empty_Combo(cmb_factory, "Foreign");
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void cmb_shipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			//fgrid_main.ClearAll();
			
			if(cmb_shipType.SelectedIndex == -1) return;

			if(cmb_shipType.SelectedValue.ToString().Trim() == _d_shipping_type_DS)
			{
				fgrid_main.Set_Grid("SBM_MRP_MONITORING", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}
			else
			{
				fgrid_main.Set_Grid("SBM_MRP_MONITORING", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
			}


			Cmb_MrpShipNoSetting();
		}

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
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_itemGroup_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}

		}

		/// <summary>
		/// 스타일 콤보박스 세팅
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return;

				cmb_style.SelectedIndex = -1;

				DataTable dt_ret;
				
				dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_styleCd, " ") ); 
				 
				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_style, 0, 1, 2, 3, 4, false, 80, 200); 

				string stylecd = "";
				int exist_index = -1;

				stylecd = txt_styleCd.Text.Trim();

				exist_index = txt_styleCd.Text.IndexOf("-", 0);

				if(exist_index == -1 && stylecd.Length == 9)
				{
					stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
				}
 
				cmb_style.SelectedValue = stylecd;

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_factory.SelectedIndex == -1 || cmb_style.SelectedIndex == -1) return;

				//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
				txt_styleCd.Text = cmb_style.SelectedValue.ToString();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_MrpShipNoSetting()
		{
			try
			{
				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vShipType = COM.ComFunction.Empty_Combo(cmb_shipType, "");

				DataTable vDt = ClassLib.ComFunction.SELECT_MRP_SHIP_NO_LIST(vFactory, vShipType);
				if (vDt.Rows.Count > 1)
				{
					COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 1, false, 210, 100);
				}
				else
				{
					COM.ComCtl.Set_ComboList(vDt, cmb_mrpno, 0, 0, false, 210, 100);
				}
				ClassLib.ComFunction.SetComboStyle(cmb_mrpno, _shipNoTitles, _shipNoWidth, _shipNoVisible, "MRP Ship No");
				cmb_mrpno.SelectedIndex = -1;
			}
			catch {}
		}

		#endregion

		#region 컨텍스트 메뉴

		private void menuItem_Status_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxST_MRP_REQUEST_FOREIGN;		
		}

		private void menuItem_Vendor_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxCUST_CD;		
		}

		private void menuItem_Purchase_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxPUR_NO;
		}

		private void menuItem_Shipping_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_NO;
		}

		private void menuItem_Incoming_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxSCAN_IN_YMD;
		}

		private void menuItem_Outgoing_Click(object sender, System.EventArgs e)
		{
			fgrid_main.LeftCol = (int)ClassLib.TBSBM_MRP_MONITORING.IxSCAN_OUT_YMD;
		}

		private void menuItem_AllSelect_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();
		}

		private void menuItem_RunAll_Click(object sender, System.EventArgs e)
		{
			btn_Receive_Click(sender, e);
			btn_PurchaseM_Click(sender, e);
			btn_Purchase_Click(sender, e);
			btn_shipping_Click(sender, e);
			btn_Incoming_Click(sender, e);
			btn_Outgoing_Click(sender, e);
		}

		#endregion

		#region 하단 버튼

		private void btn_Receive_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_MRP_REQUEST_DS,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOBS_ID,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOBS_TYPE,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxCONFIRM_QTY_DS};

			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_receive = Search_DS_Info(_d_receive, vCols);
			}
			else
			{
				_t_receive = Search_Local_Info(_d_receive, vCols);
			}


		}

		private void btn_PurchaseM_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_PURCHASE_MANAGER};

			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_purchaseM = Search_DS_Info(_d_purchaseM, vCols);
			}
			else
			{
				_t_purchaseM = Search_Local_Info(_d_purchaseM, vCols);
			}

		}

		private void btn_Purchase_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_PURCHASE,
								    (int)ClassLib.TBSBM_MRP_MONITORING.IxCUST_CD,
								    (int)ClassLib.TBSBM_MRP_MONITORING.IxCUST_NAME,
								    (int)ClassLib.TBSBM_MRP_MONITORING.IxPUR_USER,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxPUR_NO,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxPUR_SEQ,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxPUR_QTY};
			
			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_purchase = Search_DS_Info(_d_purchase, vCols);
			}
			else
			{
				_t_purchase = Search_Local_Info(_d_purchase, vCols);
			}

		}

		private void btn_shipping_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_SHIPPING_LIST,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_NO,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_SEQ,
								    (int)ClassLib.TBSBM_MRP_MONITORING.IxPK_NO,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_QTY};

			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_shipping = Search_DS_Info(_d_shipping, vCols);
			}
			else
			{
				_t_shipping = Search_Local_Info(_d_shipping, vCols);
			}

		}
		
		private void btn_Incoming_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_IN,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxBAR_CODE_REP,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxSCAN_IN_YMD,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxIN_LOCATION,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxIN_CONT_NO,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxIN_SCAN_QTY};

			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_incoming = Search_DS_Info(_d_incoming, vCols);
			}
			else
			{
				_t_incoming = Search_Local_Info(_d_incoming, vCols);
			}

		}

		private void btn_Outgoing_Click(object sender, System.EventArgs e)
		{
			int[] vCols = new int[]{(int)ClassLib.TBSBM_MRP_MONITORING.IxST_OUT,
								    (int)ClassLib.TBSBM_MRP_MONITORING.IxSCAN_OUT_YMD,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOUT_LOCATION,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOUT_CONT_NO,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOUT_TRANSPORT,
									(int)ClassLib.TBSBM_MRP_MONITORING.IxOUT_SCAN_QTY};

			if(cmb_shipType.SelectedValue.ToString() == _d_shipping_type_DS)
			{
				_t_outgoing = Search_DS_Info(_d_outgoing, vCols);
			}
			else
			{
				_t_outgoing = Search_Local_Info(_d_outgoing, vCols);
			}

		}

		private void btn_All_Click(object sender, System.EventArgs e)
		{
			fgrid_main.SelectAll();

			btn_Receive_Click(sender, e);
			btn_PurchaseM_Click(sender, e);
			btn_Purchase_Click(sender, e);
			btn_shipping_Click(sender, e);
			btn_Incoming_Click(sender, e);
			btn_Outgoing_Click(sender, e);
		}

		#endregion

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

		#endregion

		#region 이벤트 처리

		#region 툴바 메뉴

		private void Search_Main()
		{
			try
			{
				ClassLib.ComFunction.Change_WebService_URL(cmb_factory.SelectedValue.ToString());  

				Thread_Check(_d_dispose);

				DataTable vDt = SELECT_SBM_MRP_REQUEST_FOREIGN();

				if (vDt.Rows.Count > 0)
				{
					ClassLib.ComFunction.Display_FlexGrid_Tree(fgrid_main, vDt, 0);
					Grid_SetColor();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);

					fgrid_main.Tree.Column = (int)ClassLib.TBSBM_MRP_MONITORING.IxITEM_NAME;
					fgrid_main.Tree.Show(2);

					//CreateExcel(fgrid_main, "test.xls");
				}
				else
				{
					fgrid_main.ClearAll();
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				}

				ClassLib.ComFunction.Change_WebService_URL(COM.ComVar.This_Factory);

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSearch, this);
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				if (temp_thread != null)
					temp_thread.Abort();
			}
		}

		public int CreateExcel(COM.FSP arg_grid, string arg_file)
		{
			System.Xml.XmlDocument vDoc = new System.Xml.XmlDocument();
			string vDocString = "<Monitoring></Monitoring>";
            vDoc.Load(new System.IO.StringReader(vDocString));

			for (int i = arg_grid.Rows.Fixed ; i < arg_grid.Rows.Count ; i++)
			{
				System.Xml.XmlElement vElement = vDoc.CreateElement(arg_grid[0, 3].ToString());
				vElement.InnerText = arg_grid[i, 3].ToString();
				vDoc.DocumentElement.AppendChild(vElement);
			}

			System.Xml.XmlWriter vWriter = new System.Xml.XmlTextWriter("testxml.xml", System.Text.Encoding.Unicode);
			vDoc.WriteTo(vWriter);
			vWriter.Flush();
			vWriter.Close();

			C1.Win.C1Report.C1Report vReport = new C1.Win.C1Report.C1Report();
			vReport.Load(vDoc, "Monitoring");
			vReport.RenderToFile("test2.xls", C1.Win.C1Report.FileFormatEnum.Excel);

			return 0;
		}

		private void Grid_SetColor()
		{
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{
				switch (fgrid_main.Rows[vRow].Node.Level)
				{
					case 1:
						fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
						break;
					case 2:
						if(fgrid_main[vRow,(int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_YN].ToString().StartsWith(ClassLib.ComVar.Yes))
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.RightBlue;
						else if(fgrid_main[vRow,(int)ClassLib.TBSBM_MRP_MONITORING.IxOUTSIDE_YN].ToString().StartsWith(ClassLib.ComVar.Yes))
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.RightYellow;
						else
							fgrid_main.Rows[vRow].StyleNew.BackColor = ClassLib.ComVar.RightPink2;

						if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxCONFIRM_QTY]).Equals("0"))
						{
							fgrid_main.Rows[vRow].StyleNew.ForeColor = Color.Red;
						}
						else
						{
							fgrid_main.Rows[vRow].StyleNew.ForeColor = Color.Black;
						}
						break;
				}
			}
		}

		#endregion

		#region 하단 버튼

		private Thread Search_DS_Info(string arg_division, int[] arg_col)
		{
			try
			{
				ClassLib.ComFunction.Change_WebService_URL("DS");  

				// Thread 실행 중인지 여부 체크
				Thread vCurThread = Thread_Check(arg_division);
				if (vCurThread != null)
					return vCurThread;

				Search_DS_Information vSearcher = new Search_DS_Information(fgrid_main, arg_division, arg_col);

				Thread vProcessThread = new Thread(new ThreadStart(vSearcher.DoSearch));
				vProcessThread.Start();

				return vProcessThread;

				ClassLib.ComFunction.Change_WebService_URL(COM.ComVar.This_Factory);  
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search DS Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}



		private Thread Search_Local_Info(string arg_division, int[] arg_col)
		{
			try
			{
				ClassLib.ComFunction.Change_WebService_URL(COM.ComVar.This_Factory);  

				// Thread 실행 중인지 여부 체크
				Thread vCurThread = Thread_Check(arg_division);
				if (vCurThread != null)
					return vCurThread;

				Search_DS_Information vSearcher = new Search_DS_Information(fgrid_main, arg_division, arg_col, false);

				Thread vProcessThread = new Thread(new ThreadStart(vSearcher.DoSearch));
				vProcessThread.Start();

				return vProcessThread;

				ClassLib.ComFunction.Change_WebService_URL(COM.ComVar.This_Factory);  
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search DS Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}



		#endregion

		#region Thread Check

		private Thread Thread_Check(string arg_type)
		{
			Thread vCurThread = null;
			string vErrMsg = null;

			switch (arg_type)
			{
				case _d_receive:
					if (_t_receive != null)
					{
						vErrMsg = " Receive ";
						vCurThread = (_t_receive.IsAlive) ? _t_receive : null;
					}
					break;
				case _d_purchaseM:
					if (_t_purchaseM != null)
					{
						vErrMsg = " Purchase Manager ";
						vCurThread = (_t_purchaseM.IsAlive) ? _t_purchaseM : null;
					}
					break;
				case _d_purchase:
					if (_t_purchase != null)
					{
						vErrMsg = " Purchase Order ";
						vCurThread = (_t_purchase.IsAlive) ? _t_purchase : null;
					}
					break;
				case _d_shipping:
					if (_t_shipping != null)
					{
						vErrMsg = " Shipping ";
						vCurThread = (_t_shipping.IsAlive) ? _t_shipping : null;
					}
					break;
				case _d_incoming:
					if (_t_incoming != null)
					{
						vErrMsg = " Incoming ";
						vCurThread = (_t_incoming.IsAlive) ? _t_incoming : null;
					}
					break;
				case _d_outgoing:
					if (_t_outgoing != null)
					{
						vErrMsg = " Outgoing ";
						vCurThread = (_t_outgoing.IsAlive) ? _t_outgoing : null;
					}
					break;
				case _d_dispose:
					if (_t_receive != null)
						_t_receive.Abort();
					if (_t_purchaseM != null)
						_t_purchaseM.Abort();
					if (_t_purchase != null)
						_t_purchase.Abort();
					if (_t_shipping != null)
						_t_shipping.Abort();
					if (_t_incoming != null)
						_t_incoming.Abort();
					if (_t_outgoing != null)
						_t_outgoing.Abort();
                    break;
				default:
					return null;
			}

			if (vCurThread != null)
			{
				vErrMsg = "An instance of " + vErrMsg + " process is already running";
				ClassLib.ComFunction.User_Message(vErrMsg, "Processing", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return vCurThread;
			}

			return null;
		}

		#endregion


		
		#endregion

		#region DB Connect
		 
 		
		/// <summary>
		/// PKG_SBM_MRP_MONITORING : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBM_MRP_REQUEST_FOREIGN()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING.SELECT_SBM_MRP_REQUEST_FOREIGN";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_GROUP";
			MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[6] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[7] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[8] = "ARG_USER_FACTORY";
			MyOraDB.Parameter_Name[9] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_shipType, "");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_mrpno, "");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_style, "").Replace("-", "");
			MyOraDB.Parameter_Values[4] = _itemGroupCode;
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_itemCode, "");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_TextBox(txt_itemName, "");
			MyOraDB.Parameter_Values[7] = COM.ComFunction.Empty_Combo(cmb_ubDivision, "");
			MyOraDB.Parameter_Values[8] = COM.ComVar.This_Factory;
			MyOraDB.Parameter_Values[9] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		#endregion 


		#region DS Information Search Class

		class Search_DS_Information
		{
			private COM.OraDB MyOraDB = new COM.OraDB();
			private COM.FSP fgrid_main = null;
			private string _division;
			private int[] _column;
			private bool _shipping_ds_flag = true;

			public Search_DS_Information(COM.FSP arg_fgrid, string arg_division, int[] arg_col)
			{
				fgrid_main = arg_fgrid;
				_division = arg_division;
				_column = arg_col;
			}

			public Search_DS_Information(COM.FSP arg_fgrid, string arg_division, int[] arg_col, bool arg_shipping_ds_flag)
			{
				fgrid_main = arg_fgrid;
				_division = arg_division;
				_column = arg_col;
				_shipping_ds_flag = arg_shipping_ds_flag;
			}


			public void DoSearch()
			{
				try
				{
					int[] vCols = _column;

					int[] vRows = fgrid_main.Selections;

					foreach (int vRow in vRows)
					{
						if (fgrid_main.Rows[vRow].Node.Level == 1)
							continue;

						fgrid_main[vRow, vCols[0]] = "...";

						DataTable vDt = SELECT_SBM_MRP_REQUEST_DS(_division, vRow);

						if (vDt.Rows.Count > 0)
						{
							if (vDt.Rows[0].ItemArray[0] is System.DBNull)
								fgrid_main[vRow, vCols[0]] = ".";
							else
							{
								for (int vIdx = 0 ; vIdx < vDt.Rows[0].ItemArray.Length ; vIdx++)
								{
									fgrid_main[vRow, vCols[vIdx]] = vDt.Rows[0].ItemArray[vIdx];
								}
							}
						}
						else
						{
							fgrid_main[vRow, vCols[0]] = ".";
						}
					}
				}
				catch (ThreadAbortException)
				{
					return;
				}
				catch (Exception ex)
				{
					ClassLib.ComFunction.User_Message(ex.Message, "Search DS Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}

			/// <summary>
			/// PKG_SBM_MRP_MONITORING : 
			/// </summary>
			/// <returns>DataTable</returns>
			public DataTable SELECT_SBM_MRP_REQUEST_DS(string arg_division, int arg_row)
			{
				DataSet vds_ret;

				MyOraDB.ReDim_Parameter(12);

				//01.PROCEDURE명 
				if(_shipping_ds_flag)
				{
					MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING.SELECT_SBM_MRP_REQUEST_DS"; 
				}
				else
				{
					MyOraDB.Process_Name = "PKG_SBM_MRP_MONITORING.SELECT_SBM_MRP_REQUEST_LOCAL"; 
				}

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[3] = "ARG_MRP_SHIP_NO";
				MyOraDB.Parameter_Name[4] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[5] = "ARG_LOT_SEQ";
				MyOraDB.Parameter_Name[6] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[7] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[8] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[9] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[10] = "ARG_STYLE_ITEM_DIV";
				MyOraDB.Parameter_Name[11] = "OUT_CURSOR";

				//03.DATA TYPE 정의
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
				MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11] = (int)OracleType.Cursor;

				int vRow = arg_row;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_division;
				MyOraDB.Parameter_Values[1] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxFACTORY]);
				MyOraDB.Parameter_Values[2] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxSHIP_TYPE]);
				MyOraDB.Parameter_Values[3] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxMRP_SHIP_NO]);
				MyOraDB.Parameter_Values[4] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxLOT_NO]);
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxLOT_SEQ]);
				MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxSTYLE_CODE]).Replace("-", "");
				MyOraDB.Parameter_Values[7] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxITEM_CD]);
				MyOraDB.Parameter_Values[8] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxSPEC_CD]);
				MyOraDB.Parameter_Values[9] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxCOLOR_CD]);
				MyOraDB.Parameter_Values[10] = ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBM_MRP_MONITORING.IxSTYLE_ITEM_DIV]);
				MyOraDB.Parameter_Values[11] = "";

				MyOraDB.Add_Select_Parameter(true);
				vds_ret = MyOraDB.Exe_Select_Procedure();
				if(vds_ret == null) return null ;

				return vds_ret.Tables[MyOraDB.Process_Name];
			}
		}
 


		#endregion 

	}
}
