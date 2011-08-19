using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Stock
{
	public class Form_BK_Stock_Subul : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pic_head4;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_headInfo;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private C1.Win.C1List.C1Combo cmb_dest_factory;
        private System.Windows.Forms.Label lbl_DestFactory;
		private System.Windows.Forms.Label lbl_StockYm;
		private C1.Win.C1List.C1Combo cmb_factory;
        private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.TextBox txt_Rate;
		private System.Windows.Forms.Label lbl_Rate;
		private C1.Win.C1List.C1Combo cmb_Print;
		private System.Windows.Forms.Label lbl_Print;
		private C1.Win.C1List.C1Combo cmb_Factory_Group;
		private System.Windows.Forms.Label lbl_Factory_Group;
		private System.Windows.Forms.CheckBox chk_Half;
		private System.Windows.Forms.TextBox txt_From;
		private System.Windows.Forms.TextBox txt_To;
        private C1.Win.C1List.C1Combo cmb_stockMM;
        private C1.Win.C1List.C1Combo cmb_stockYY;
		private System.ComponentModel.IContainer components = null;

		#endregion 

		#region 생성자 / 소멸자

		public Form_BK_Stock_Subul()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BK_Stock_Subul));
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
            this.fgrid_main = new COM.FSP();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.chk_Half = new System.Windows.Forms.CheckBox();
            this.cmb_Factory_Group = new C1.Win.C1List.C1Combo();
            this.lbl_Factory_Group = new System.Windows.Forms.Label();
            this.cmb_Print = new C1.Win.C1List.C1Combo();
            this.lbl_Print = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.lbl_Rate = new System.Windows.Forms.Label();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_item = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.cmb_dest_factory = new C1.Win.C1List.C1Combo();
            this.lbl_DestFactory = new System.Windows.Forms.Label();
            this.lbl_StockYm = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_headInfo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cmb_stockMM = new C1.Win.C1List.C1Combo();
            this.cmb_stockYY = new C1.Win.C1List.C1Combo();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).BeginInit();
            this.pnl_head.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_Group)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dest_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).BeginInit();
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
            // stbar
            // 
            this.stbar.Location = new System.Drawing.Point(0, 644);
            this.stbar.Size = new System.Drawing.Size(1016, 22);
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(952, 23);
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "18.9655172413793:False:True;78.2758620689655:False:False;0:False:True;\t0.39370078" +
                "7401575:False:False;97.6377952755905:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 29;
            this.c1Sizer1.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.Location = new System.Drawing.Point(12, 118);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Rows.DefaultSize = 19;
            this.fgrid_main.Size = new System.Drawing.Size(992, 454);
            this.fgrid_main.StyleInfo = resources.GetString("fgrid_main.StyleInfo");
            this.fgrid_main.TabIndex = 174;
            // 
            // pnl_low
            // 
            this.pnl_low.Location = new System.Drawing.Point(12, 576);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1000, 0);
            this.pnl_low.TabIndex = 173;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.panel2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pictureBox1);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(992, 110);
            this.pnl_head.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.cmb_stockMM);
            this.panel2.Controls.Add(this.cmb_stockYY);
            this.panel2.Controls.Add(this.txt_From);
            this.panel2.Controls.Add(this.txt_To);
            this.panel2.Controls.Add(this.chk_Half);
            this.panel2.Controls.Add(this.cmb_Factory_Group);
            this.panel2.Controls.Add(this.lbl_Factory_Group);
            this.panel2.Controls.Add(this.cmb_Print);
            this.panel2.Controls.Add(this.lbl_Print);
            this.panel2.Controls.Add(this.txt_Rate);
            this.panel2.Controls.Add(this.lbl_Rate);
            this.panel2.Controls.Add(this.txt_itemName);
            this.panel2.Controls.Add(this.txt_itemCode);
            this.panel2.Controls.Add(this.lbl_item);
            this.panel2.Controls.Add(this.txt_itemGroup);
            this.panel2.Controls.Add(this.cmb_itemGroup);
            this.panel2.Controls.Add(this.lbl_itemgroup);
            this.panel2.Controls.Add(this.btn_groupSearch);
            this.panel2.Controls.Add(this.cmb_dest_factory);
            this.panel2.Controls.Add(this.lbl_DestFactory);
            this.panel2.Controls.Add(this.lbl_StockYm);
            this.panel2.Controls.Add(this.cmb_factory);
            this.panel2.Controls.Add(this.lbl_factory);
            this.panel2.Controls.Add(this.lbl_headInfo);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pic_head7);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pic_head6);
            this.panel2.Controls.Add(this.pic_head1);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 104);
            this.panel2.TabIndex = 408;
            // 
            // txt_From
            // 
            this.txt_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_From.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_From.Location = new System.Drawing.Point(765, 70);
            this.txt_From.MaxLength = 10;
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(105, 21);
            this.txt_From.TabIndex = 483;
            this.txt_From.Text = "20070101";
            // 
            // txt_To
            // 
            this.txt_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_To.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_To.Location = new System.Drawing.Point(870, 70);
            this.txt_To.MaxLength = 10;
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(105, 21);
            this.txt_To.TabIndex = 484;
            this.txt_To.Text = "20070631";
            // 
            // chk_Half
            // 
            this.chk_Half.Location = new System.Drawing.Point(664, 70);
            this.chk_Half.Name = "chk_Half";
            this.chk_Half.Size = new System.Drawing.Size(80, 24);
            this.chk_Half.TabIndex = 488;
            this.chk_Half.Text = "By Term";
            // 
            // cmb_Factory_Group
            // 
            this.cmb_Factory_Group.AddItemSeparator = ';';
            this.cmb_Factory_Group.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory_Group.Caption = "";
            this.cmb_Factory_Group.CaptionHeight = 17;
            this.cmb_Factory_Group.CaptionStyle = style17;
            this.cmb_Factory_Group.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory_Group.ColumnCaptionHeight = 18;
            this.cmb_Factory_Group.ColumnFooterHeight = 18;
            this.cmb_Factory_Group.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory_Group.ContentHeight = 16;
            this.cmb_Factory_Group.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory_Group.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory_Group.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory_Group.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory_Group.EditorHeight = 16;
            this.cmb_Factory_Group.EvenRowStyle = style18;
            this.cmb_Factory_Group.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory_Group.FooterStyle = style19;
            this.cmb_Factory_Group.HeadingStyle = style20;
            this.cmb_Factory_Group.HighLightRowStyle = style21;
            this.cmb_Factory_Group.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory_Group.Images"))));
            this.cmb_Factory_Group.ItemHeight = 15;
            this.cmb_Factory_Group.Location = new System.Drawing.Point(120, 25);
            this.cmb_Factory_Group.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory_Group.MaxDropDownItems = ((short)(5));
            this.cmb_Factory_Group.MaxLength = 32767;
            this.cmb_Factory_Group.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory_Group.Name = "cmb_Factory_Group";
            this.cmb_Factory_Group.OddRowStyle = style22;
            this.cmb_Factory_Group.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory_Group.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory_Group.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory_Group.SelectedStyle = style23;
            this.cmb_Factory_Group.Size = new System.Drawing.Size(210, 20);
            this.cmb_Factory_Group.Style = style24;
            this.cmb_Factory_Group.TabIndex = 472;
            this.cmb_Factory_Group.PropBag = resources.GetString("cmb_Factory_Group.PropBag");
            // 
            // lbl_Factory_Group
            // 
            this.lbl_Factory_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory_Group.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory_Group.ImageIndex = 1;
            this.lbl_Factory_Group.ImageList = this.img_Label;
            this.lbl_Factory_Group.Location = new System.Drawing.Point(16, 25);
            this.lbl_Factory_Group.Name = "lbl_Factory_Group";
            this.lbl_Factory_Group.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory_Group.TabIndex = 473;
            this.lbl_Factory_Group.Text = "Factory Group";
            this.lbl_Factory_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Print
            // 
            this.cmb_Print.AddItemSeparator = ';';
            this.cmb_Print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Print.Caption = "";
            this.cmb_Print.CaptionHeight = 17;
            this.cmb_Print.CaptionStyle = style25;
            this.cmb_Print.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Print.ColumnCaptionHeight = 18;
            this.cmb_Print.ColumnFooterHeight = 18;
            this.cmb_Print.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Print.ContentHeight = 16;
            this.cmb_Print.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Print.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Print.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Print.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Print.EditorHeight = 16;
            this.cmb_Print.EvenRowStyle = style26;
            this.cmb_Print.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Print.FooterStyle = style27;
            this.cmb_Print.HeadingStyle = style28;
            this.cmb_Print.HighLightRowStyle = style29;
            this.cmb_Print.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Print.Images"))));
            this.cmb_Print.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_Print.ItemHeight = 15;
            this.cmb_Print.Location = new System.Drawing.Point(120, 70);
            this.cmb_Print.MatchEntryTimeout = ((long)(2000));
            this.cmb_Print.MaxDropDownItems = ((short)(5));
            this.cmb_Print.MaxLength = 32767;
            this.cmb_Print.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Print.Name = "cmb_Print";
            this.cmb_Print.OddRowStyle = style30;
            this.cmb_Print.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Print.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Print.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Print.SelectedStyle = style31;
            this.cmb_Print.Size = new System.Drawing.Size(210, 20);
            this.cmb_Print.Style = style32;
            this.cmb_Print.TabIndex = 481;
            this.cmb_Print.PropBag = resources.GetString("cmb_Print.PropBag");
            // 
            // lbl_Print
            // 
            this.lbl_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Print.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Print.ImageIndex = 1;
            this.lbl_Print.ImageList = this.img_Label;
            this.lbl_Print.Location = new System.Drawing.Point(16, 70);
            this.lbl_Print.Name = "lbl_Print";
            this.lbl_Print.Size = new System.Drawing.Size(100, 21);
            this.lbl_Print.TabIndex = 482;
            this.lbl_Print.Text = "Print Option";
            this.lbl_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Rate
            // 
            this.txt_Rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Rate.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Rate.Location = new System.Drawing.Point(437, 72);
            this.txt_Rate.MaxLength = 10;
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.Size = new System.Drawing.Size(211, 21);
            this.txt_Rate.TabIndex = 484;
            this.txt_Rate.Text = "0.00";
            // 
            // lbl_Rate
            // 
            this.lbl_Rate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Rate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Rate.ImageIndex = 0;
            this.lbl_Rate.ImageList = this.img_Label;
            this.lbl_Rate.Location = new System.Drawing.Point(336, 72);
            this.lbl_Rate.Name = "lbl_Rate";
            this.lbl_Rate.Size = new System.Drawing.Size(100, 21);
            this.lbl_Rate.TabIndex = 483;
            this.lbl_Rate.Text = "Rate";
            this.lbl_Rate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(831, 48);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(144, 21);
            this.txt_itemName.TabIndex = 483;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(765, 48);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(65, 21);
            this.txt_itemCode.TabIndex = 482;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(664, 48);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 481;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(537, 48);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(89, 21);
            this.txt_itemGroup.TabIndex = 478;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style33;
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
            this.cmb_itemGroup.EvenRowStyle = style34;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style35;
            this.cmb_itemGroup.HeadingStyle = style36;
            this.cmb_itemGroup.HighLightRowStyle = style37;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(437, 48);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style38;
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style39;
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 20);
            this.cmb_itemGroup.Style = style40;
            this.cmb_itemGroup.TabIndex = 477;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(336, 48);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 475;
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
            this.btn_groupSearch.Location = new System.Drawing.Point(626, 48);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 476;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            // 
            // cmb_dest_factory
            // 
            this.cmb_dest_factory.AddItemSeparator = ';';
            this.cmb_dest_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_dest_factory.Caption = "";
            this.cmb_dest_factory.CaptionHeight = 17;
            this.cmb_dest_factory.CaptionStyle = style41;
            this.cmb_dest_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_dest_factory.ColumnCaptionHeight = 18;
            this.cmb_dest_factory.ColumnFooterHeight = 18;
            this.cmb_dest_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_dest_factory.ContentHeight = 16;
            this.cmb_dest_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_dest_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_dest_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_dest_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_dest_factory.EditorHeight = 16;
            this.cmb_dest_factory.EvenRowStyle = style42;
            this.cmb_dest_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_dest_factory.FooterStyle = style43;
            this.cmb_dest_factory.HeadingStyle = style44;
            this.cmb_dest_factory.HighLightRowStyle = style45;
            this.cmb_dest_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_dest_factory.Images"))));
            this.cmb_dest_factory.ItemHeight = 15;
            this.cmb_dest_factory.Location = new System.Drawing.Point(765, 26);
            this.cmb_dest_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_dest_factory.MaxDropDownItems = ((short)(5));
            this.cmb_dest_factory.MaxLength = 32767;
            this.cmb_dest_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_dest_factory.Name = "cmb_dest_factory";
            this.cmb_dest_factory.OddRowStyle = style46;
            this.cmb_dest_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_dest_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_dest_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_dest_factory.SelectedStyle = style47;
            this.cmb_dest_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_dest_factory.Style = style48;
            this.cmb_dest_factory.TabIndex = 473;
            this.cmb_dest_factory.PropBag = resources.GetString("cmb_dest_factory.PropBag");
            // 
            // lbl_DestFactory
            // 
            this.lbl_DestFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DestFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DestFactory.ImageIndex = 1;
            this.lbl_DestFactory.ImageList = this.img_Label;
            this.lbl_DestFactory.Location = new System.Drawing.Point(664, 26);
            this.lbl_DestFactory.Name = "lbl_DestFactory";
            this.lbl_DestFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_DestFactory.TabIndex = 474;
            this.lbl_DestFactory.Text = "Dest Factory ";
            this.lbl_DestFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_StockYm
            // 
            this.lbl_StockYm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_StockYm.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockYm.ImageIndex = 1;
            this.lbl_StockYm.ImageList = this.img_Label;
            this.lbl_StockYm.Location = new System.Drawing.Point(16, 48);
            this.lbl_StockYm.Name = "lbl_StockYm";
            this.lbl_StockYm.Size = new System.Drawing.Size(100, 21);
            this.lbl_StockYm.TabIndex = 470;
            this.lbl_StockYm.Text = "Stock Date";
            this.lbl_StockYm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style49;
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
            this.cmb_factory.EvenRowStyle = style50;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style51;
            this.cmb_factory.HeadingStyle = style52;
            this.cmb_factory.HighLightRowStyle = style53;
            this.cmb_factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_factory.Images"))));
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(437, 26);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style54;
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style55;
            this.cmb_factory.Size = new System.Drawing.Size(210, 20);
            this.cmb_factory.Style = style56;
            this.cmb_factory.TabIndex = 469;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(336, 26);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 471;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.lbl_headInfo.TabIndex = 416;
            this.lbl_headInfo.Text = "       Stock Management  Info";
            this.lbl_headInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(984, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 45;
            this.pictureBox2.TabStop = false;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(899, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 63);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(984, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 32);
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox4.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 80);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 20);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 16);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 77);
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
            this.pic_head1.Size = new System.Drawing.Size(968, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(168, 87);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(816, 18);
            this.pictureBox5.TabIndex = 407;
            this.pictureBox5.TabStop = false;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(976, 199);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
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
            this.pic_head5.Location = new System.Drawing.Point(0, 199);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(168, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(808, 18);
            this.pictureBox1.TabIndex = 407;
            this.pictureBox1.TabStop = false;
            // 
            // pic_head4
            // 
            this.pic_head4.Location = new System.Drawing.Point(0, 0);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(100, 50);
            this.pic_head4.TabIndex = 0;
            this.pic_head4.TabStop = false;
            // 
            // cmb_stockMM
            // 
            this.cmb_stockMM.AddItemSeparator = ';';
            this.cmb_stockMM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockMM.Caption = "";
            this.cmb_stockMM.CaptionHeight = 17;
            this.cmb_stockMM.CaptionStyle = style1;
            this.cmb_stockMM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockMM.ColumnCaptionHeight = 18;
            this.cmb_stockMM.ColumnFooterHeight = 18;
            this.cmb_stockMM.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockMM.ContentHeight = 16;
            this.cmb_stockMM.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockMM.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockMM.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockMM.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockMM.EditorHeight = 16;
            this.cmb_stockMM.EvenRowStyle = style2;
            this.cmb_stockMM.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockMM.FooterStyle = style3;
            this.cmb_stockMM.HeadingStyle = style4;
            this.cmb_stockMM.HighLightRowStyle = style5;
            this.cmb_stockMM.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockMM.Images"))));
            this.cmb_stockMM.ItemHeight = 15;
            this.cmb_stockMM.Location = new System.Drawing.Point(225, 48);
            this.cmb_stockMM.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockMM.MaxDropDownItems = ((short)(5));
            this.cmb_stockMM.MaxLength = 32767;
            this.cmb_stockMM.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockMM.Name = "cmb_stockMM";
            this.cmb_stockMM.OddRowStyle = style6;
            this.cmb_stockMM.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockMM.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockMM.SelectedStyle = style7;
            this.cmb_stockMM.Size = new System.Drawing.Size(104, 20);
            this.cmb_stockMM.Style = style8;
            this.cmb_stockMM.TabIndex = 670;
            this.cmb_stockMM.SelectedValueChanged += new System.EventHandler(this.cmb_stockMM_TextChanged);
            this.cmb_stockMM.PropBag = resources.GetString("cmb_stockMM.PropBag");
            // 
            // cmb_stockYY
            // 
            this.cmb_stockYY.AddItemSeparator = ';';
            this.cmb_stockYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_stockYY.Caption = "";
            this.cmb_stockYY.CaptionHeight = 17;
            this.cmb_stockYY.CaptionStyle = style9;
            this.cmb_stockYY.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_stockYY.ColumnCaptionHeight = 18;
            this.cmb_stockYY.ColumnFooterHeight = 18;
            this.cmb_stockYY.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_stockYY.ContentHeight = 16;
            this.cmb_stockYY.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_stockYY.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_stockYY.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_stockYY.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_stockYY.EditorHeight = 16;
            this.cmb_stockYY.EvenRowStyle = style10;
            this.cmb_stockYY.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockYY.FooterStyle = style11;
            this.cmb_stockYY.HeadingStyle = style12;
            this.cmb_stockYY.HighLightRowStyle = style13;
            this.cmb_stockYY.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_stockYY.Images"))));
            this.cmb_stockYY.ItemHeight = 15;
            this.cmb_stockYY.Location = new System.Drawing.Point(120, 48);
            this.cmb_stockYY.MatchEntryTimeout = ((long)(2000));
            this.cmb_stockYY.MaxDropDownItems = ((short)(5));
            this.cmb_stockYY.MaxLength = 32767;
            this.cmb_stockYY.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_stockYY.Name = "cmb_stockYY";
            this.cmb_stockYY.OddRowStyle = style14;
            this.cmb_stockYY.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_stockYY.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_stockYY.SelectedStyle = style15;
            this.cmb_stockYY.Size = new System.Drawing.Size(104, 20);
            this.cmb_stockYY.Style = style16;
            this.cmb_stockYY.TabIndex = 669;
            this.cmb_stockYY.PropBag = resources.GetString("cmb_stockYY.PropBag");
            // 
            // Form_BK_Stock_Subul
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BK_Stock_Subul";
            this.Load += new System.EventHandler(this.Form_BK_Stock_Subul_Load);
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.pnl_head.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_Group)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_dest_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_stockYY)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

       	private string     _itemGroupCode ="";
		

		#endregion 

		#region 이벤트처리
		/// <summary> 
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form init
			//			ClassLib.ComFunction.Init_Form_Control(this);
			//			ClassLib.ComFunction.Init_MenuRole(this,lbl_MainTitle,new C1.Win.C1Command.C1Command[]{tbtn_Search, tbtn_Save, tbtn_Delete, tbtn_Print, tbtn_New, tbtn_Confirm}) ;
			
            lbl_MainTitle.Text = "Stock By Manual";
			this.Text		   = lbl_MainTitle.Text;
            ClassLib.ComFunction.SetLangDic(this);


			// Grid setting (Uploading할때 작업하기 ...) 
			fgrid_main.Set_Grid("SBK_STOCK_SUBUL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
//			fgrid_main.Rows[0].AllowMerging = true;
//			fgrid_main.Rows[1].AllowMerging = true;
//			fgrid_main.Set_Action_Image(img_Action);

		    

			
			// Pur  Factory Combobox Setting
			DataTable vDt;
			vDt = ClassLib.ComFunction.Select_Data_List(ClassLib.ComVar.This_Factory, "SBI04");
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory_Group, 5, 6, true);
			vDt.Dispose();
			cmb_Factory_Group.SelectedIndex  = 1;



			// Factory combobox add items
			
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue		= ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_factory.Enabled   = false;
 

			// Factory combobox add items
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_dest_factory, 0, 1, false);
			cmb_dest_factory.SelectedValue		= ClassLib.ComVar.This_Factory;
			vDt.Dispose();
			cmb_dest_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			
 

			 
			// Year ComboBox Add Items 
			vDt = ClassLib.ComVar.Select_ComCode(cmb_factory.SelectedValue.ToString(), ClassLib.ComVar.CxYear);
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_stockYY, 2, 2, false, ClassLib.ComVar.ComboList_Visible.Code);  
			cmb_stockYY.SelectedValue = System.DateTime.Today.Year.ToString();
	
			// Print Option 
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBK04");
			COM.ComCtl.Set_ComboList(vDt, cmb_Print, 1, 2, false, 56,0);
			cmb_Print.SelectedIndex = -1;


        //    // StockMM add Items
        //    cmb_stockMM.AddItemTitles("Code");
        //    cmb_stockMM.ValueMember = "Code"; 

        //    for (int i = 1; i <= 12; i++)
        //    {
        //        cmb_stockMM.AddItem(i.ToString().PadLeft(2,'0'));
        //    }

        //    cmb_stockMM.MaxDropDownItems = 10;
        ////	cmb_stockMM.SelectedValue = System.DateTime.Today.Month.ToString().PadLeft(2,'0');


            DataTable month = new DataTable();
            month.Columns.Add(new DataColumn("Code", typeof(string)));
            month.Columns[0].ColumnName = "Code";

            DataRow month_row = null;

            for (int i = 1; i <= 12; i++)
            {
                month_row = month.NewRow();
                month_row[0] = i.ToString().PadLeft(2, '0');
                month.Rows.Add(month_row);
            }
            ClassLib.ComCtl.Set_ComboList(month, cmb_stockMM, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Code);



			//그룹타입 콤보쿼리 
			vDt = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false,  0, 130);  


			// Disabled tbutton
			tbtn_Delete.Enabled  = false;
			tbtn_Confirm.Enabled = false; 
 			 

		}


		private void cmb_stockMM_TextChanged(object sender, System.EventArgs e)
		{
		     DataTable vDt = Select_Currency_Rate();  
			 
			 txt_Rate.Text   = vDt.Rows[0].ItemArray[0].ToString();
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
				txt_itemGroup.Text	= _itemGroupCode;

				vPopup.Dispose(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{  
			cmb_Factory_Group.SelectedValue  = 1;
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_dest_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_Print.SelectedIndex   = 1;			
			txt_itemCode.Text  = "";
			txt_itemName.Text ="";
			txt_itemGroup.Text  ="";
		
		}




		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			
			if (chk_Half.Checked  == true)
			{
				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory_Group,cmb_factory ,cmb_dest_factory , cmb_stockYY, cmb_stockMM, cmb_Print};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;

			}
			else
			{
				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory_Group,cmb_factory ,cmb_dest_factory ,cmb_Print};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;

			}


			int  iCnt  = 7;
			string [] aHead =  new string[iCnt];	
			string Para         = "";
			string mrd_Filename = "";





			switch (cmb_Print.SelectedValue.ToString())
			{
				case "01":

					#region By Material Group  - Sephiroth

					mrd_Filename = @"Report/Material/Form_BK_Subul_By_Option_01.mrd";				

					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;		
                    

					break;
					#endregion

				case "02":

					#region By Destination  - Sephiroth

					mrd_Filename  = @"Report/Material/Form_BK_Subul_By_Option_02.mrd";
					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;	
 
					break;

					#endregion

				case "03":

					#region By Item  - Sephiroth

					mrd_Filename  = @"Report/Material/Form_BK_Subul_By_Option_03.mrd";

					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;	

					break;

					#endregion

				case "04":

					#region By Material Group - Neomics

					mrd_Filename  = @"Report/Material/Form_BK_Subul_By_Option_04.mrd";

					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;	

					break;

					#endregion

				case "05":

					#region By Material Group - Neomics

					mrd_Filename  = @"Report/Material/Form_BK_Subul_By_Option_05.mrd";

					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;	

					break;

					#endregion

				case "06":

					#region By Item  - Neomics

					mrd_Filename  = @"Report/Material/Form_BK_Subul_By_Option_06.mrd";

					aHead[0]    = cmb_Factory_Group.SelectedValue.ToString();
					aHead[1]    = cmb_factory.SelectedValue.ToString();
					aHead[2]    = cmb_dest_factory.SelectedValue.ToString();
					aHead[3]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "01";
					aHead[4]    = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString() + "31";
					aHead[5]    = ClassLib.ComFunction.Empty_TextBox(txt_itemCode," ");	
					aHead[6]    = txt_Rate.Text;	
					break;

					#endregion

		
			}


			if (chk_Half.Checked  == true)
			{

				if ((txt_From.Text  == null) || (txt_To.Text  == null) )
				{

					MessageBox.Show ("No Terms");

				}

				aHead[3]    = txt_From.Text ;
				aHead[4]    = txt_To.Text ;

			}


			
			Para = 	" /rp ";
		  
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();


		}


		#endregion


		#region DB컨넥트
		/// <summary>
		/// Select_Month_Rate : 
		/// </summary>
		public  DataTable Select_Currency_Rate()
		{
			DataSet ds_ret;
			COM.OraDB oraDB = new COM.OraDB();

			string process_name = "PKG_SBK_SUBUL.SELECT_CURRENCY_RATE";

			oraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			oraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_STOCK_YMD";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			oraDB.Parameter_Values[0] = cmb_factory.SelectedValue.ToString();
			oraDB.Parameter_Values[1] = cmb_stockYY.SelectedValue.ToString() + cmb_stockMM.SelectedValue.ToString();
			oraDB.Parameter_Values[2] = ""; 

			oraDB.Add_Select_Parameter(true);
 
			ds_ret = oraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
  

		}

		#endregion 


		private void Form_BK_Stock_Subul_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	}
}

