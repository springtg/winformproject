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


namespace FlexBase.MaterialBase
{
	public class Form_BC_Item : COM.PCHWinForm.Form_Top
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Panel pnl_B;
		public System.Windows.Forms.Panel pnl_SearchImage;
		private C1.Win.C1List.C1Combo cmb_Group_M;
		private C1.Win.C1List.C1Combo cmb_Group_L;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Group_L;
		private System.Windows.Forms.Label lbl_Group_Type;
		private System.Windows.Forms.TextBox txt_Item_Name;
		private System.Windows.Forms.Label lbl_Item_Name;
		public System.Windows.Forms.PictureBox picb_MR;
		public System.Windows.Forms.PictureBox picb_TR;
		public System.Windows.Forms.PictureBox picb_TM;
		public System.Windows.Forms.Label lbl_SubTitle1;
		public System.Windows.Forms.PictureBox picb_BR;
		public System.Windows.Forms.PictureBox picb_BM;
		public System.Windows.Forms.PictureBox picb_BL;
		public System.Windows.Forms.PictureBox picb_ML;
		public System.Windows.Forms.PictureBox picb_MM;
		public System.Windows.Forms.Panel pnl_BT;
		private System.Windows.Forms.Panel pnl_BB;
		private System.Windows.Forms.Label btn_Insert;
		private System.Windows.Forms.Label btn_recover;
		private System.Windows.Forms.Label btn_Delete;
		private COM.SSP sgrid_Item;
		private FarPoint.Win.Spread.SheetView sgrid_Item_Sheet1;
		private C1.Win.C1List.C1Combo cmb_Group_Type;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.TextBox txt_Cust_Cd;
		private C1.Win.C1List.C1Combo cmb_Cust;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private System.Windows.Forms.Label lbl_User;
		private System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_USE;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.PictureBox pictureBox1;
		private C1.Win.C1List.C1Combo cmb_Style_Item_Div;
		private System.Windows.Forms.Label lbl_LocalLLT;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_LocalLLT;
		private System.ComponentModel.IContainer components = null;

		public Form_BC_Item()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BC_Item));
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
            this.sgrid_Item = new COM.SSP();
            this.sgrid_Item_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pnl_BB = new System.Windows.Forms.Panel();
            this.btn_Insert = new System.Windows.Forms.Label();
            this.btn_recover = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Label();
            this.pnl_BT = new System.Windows.Forms.Panel();
            this.pnl_SearchImage = new System.Windows.Forms.Panel();
            this.cmb_LocalLLT = new C1.Win.C1List.C1Combo();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_LocalLLT = new System.Windows.Forms.Label();
            this.cmb_Style_Item_Div = new C1.Win.C1List.C1Combo();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_USE = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_Cust_Cd = new System.Windows.Forms.TextBox();
            this.cmb_Cust = new C1.Win.C1List.C1Combo();
            this.lbl_style = new System.Windows.Forms.Label();
            this.cmb_Group_Type = new C1.Win.C1List.C1Combo();
            this.cmb_Group_M = new C1.Win.C1List.C1Combo();
            this.cmb_Group_L = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Group_L = new System.Windows.Forms.Label();
            this.lbl_Group_Type = new System.Windows.Forms.Label();
            this.txt_Item_Name = new System.Windows.Forms.TextBox();
            this.lbl_Item_Name = new System.Windows.Forms.Label();
            this.picb_MR = new System.Windows.Forms.PictureBox();
            this.picb_TR = new System.Windows.Forms.PictureBox();
            this.picb_TM = new System.Windows.Forms.PictureBox();
            this.lbl_SubTitle1 = new System.Windows.Forms.Label();
            this.picb_BR = new System.Windows.Forms.PictureBox();
            this.picb_BM = new System.Windows.Forms.PictureBox();
            this.picb_BL = new System.Windows.Forms.PictureBox();
            this.picb_ML = new System.Windows.Forms.PictureBox();
            this.picb_MM = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.pnl_B.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Item_Sheet1)).BeginInit();
            this.pnl_BB.SuspendLayout();
            this.pnl_BT.SuspendLayout();
            this.pnl_SearchImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LocalLLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Item_Div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_USE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cust)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_M)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // pnl_B
            // 
            this.pnl_B.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_B.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_B.Controls.Add(this.sgrid_Item);
            this.pnl_B.Controls.Add(this.pnl_BB);
            this.pnl_B.Controls.Add(this.pnl_BT);
            this.pnl_B.Location = new System.Drawing.Point(0, 64);
            this.pnl_B.Name = "pnl_B";
            this.pnl_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.pnl_B.Size = new System.Drawing.Size(1016, 576);
            this.pnl_B.TabIndex = 28;
            // 
            // sgrid_Item
            // 
            this.sgrid_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sgrid_Item.Location = new System.Drawing.Point(5, 112);
            this.sgrid_Item.Name = "sgrid_Item";
            this.sgrid_Item.Sheets.Add(this.sgrid_Item_Sheet1);
            this.sgrid_Item.Size = new System.Drawing.Size(1006, 427);
            this.sgrid_Item.TabIndex = 46;
            this.sgrid_Item.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sgrid_Item_MouseUp);
            this.sgrid_Item.EditModeOn += new System.EventHandler(this.sgrid_Item_EditModeOn);
            this.sgrid_Item.EditModeOff += new System.EventHandler(this.sgrid_Item_EditModeOff);
            this.sgrid_Item.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.sgrid_Item_EditChange);
            this.sgrid_Item.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.sgrid_Item_CellDoubleClick);
            // 
            // sgrid_Item_Sheet1
            // 
            this.sgrid_Item_Sheet1.SheetName = "Sheet1";
            // 
            // pnl_BB
            // 
            this.pnl_BB.Controls.Add(this.btn_Insert);
            this.pnl_BB.Controls.Add(this.btn_recover);
            this.pnl_BB.Controls.Add(this.btn_Delete);
            this.pnl_BB.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_BB.Location = new System.Drawing.Point(5, 539);
            this.pnl_BB.Name = "pnl_BB";
            this.pnl_BB.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.pnl_BB.Size = new System.Drawing.Size(1006, 32);
            this.pnl_BB.TabIndex = 45;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Insert.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.ImageIndex = 9;
            this.btn_Insert.ImageList = this.image_List;
            this.btn_Insert.Location = new System.Drawing.Point(764, 4);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 23);
            this.btn_Insert.TabIndex = 535;
            this.btn_Insert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseDown);
            this.btn_Insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Insert_MouseUp);
            // 
            // btn_recover
            // 
            this.btn_recover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_recover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_recover.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recover.ImageIndex = 1;
            this.btn_recover.ImageList = this.image_List;
            this.btn_recover.Location = new System.Drawing.Point(926, 4);
            this.btn_recover.Name = "btn_recover";
            this.btn_recover.Size = new System.Drawing.Size(80, 23);
            this.btn_recover.TabIndex = 534;
            this.btn_recover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_recover.Click += new System.EventHandler(this.btn_recover_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ImageIndex = 5;
            this.btn_Delete.ImageList = this.image_List;
            this.btn_Delete.Location = new System.Drawing.Point(845, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 23);
            this.btn_Delete.TabIndex = 533;
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pnl_BT
            // 
            this.pnl_BT.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_BT.Controls.Add(this.pnl_SearchImage);
            this.pnl_BT.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_BT.Location = new System.Drawing.Point(5, 0);
            this.pnl_BT.Name = "pnl_BT";
            this.pnl_BT.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.pnl_BT.Size = new System.Drawing.Size(1006, 112);
            this.pnl_BT.TabIndex = 44;
            // 
            // pnl_SearchImage
            // 
            this.pnl_SearchImage.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_SearchImage.Controls.Add(this.cmb_LocalLLT);
            this.pnl_SearchImage.Controls.Add(this.cmb_Factory);
            this.pnl_SearchImage.Controls.Add(this.lbl_LocalLLT);
            this.pnl_SearchImage.Controls.Add(this.cmb_Style_Item_Div);
            this.pnl_SearchImage.Controls.Add(this.label3);
            this.pnl_SearchImage.Controls.Add(this.cmb_USE);
            this.pnl_SearchImage.Controls.Add(this.label2);
            this.pnl_SearchImage.Controls.Add(this.cmb_purUser);
            this.pnl_SearchImage.Controls.Add(this.lbl_User);
            this.pnl_SearchImage.Controls.Add(this.txt_Cust_Cd);
            this.pnl_SearchImage.Controls.Add(this.cmb_Cust);
            this.pnl_SearchImage.Controls.Add(this.lbl_style);
            this.pnl_SearchImage.Controls.Add(this.cmb_Group_Type);
            this.pnl_SearchImage.Controls.Add(this.cmb_Group_M);
            this.pnl_SearchImage.Controls.Add(this.cmb_Group_L);
            this.pnl_SearchImage.Controls.Add(this.label1);
            this.pnl_SearchImage.Controls.Add(this.lbl_Group_L);
            this.pnl_SearchImage.Controls.Add(this.lbl_Group_Type);
            this.pnl_SearchImage.Controls.Add(this.txt_Item_Name);
            this.pnl_SearchImage.Controls.Add(this.lbl_Item_Name);
            this.pnl_SearchImage.Controls.Add(this.picb_MR);
            this.pnl_SearchImage.Controls.Add(this.picb_TR);
            this.pnl_SearchImage.Controls.Add(this.picb_TM);
            this.pnl_SearchImage.Controls.Add(this.lbl_SubTitle1);
            this.pnl_SearchImage.Controls.Add(this.picb_BR);
            this.pnl_SearchImage.Controls.Add(this.picb_BM);
            this.pnl_SearchImage.Controls.Add(this.picb_BL);
            this.pnl_SearchImage.Controls.Add(this.picb_ML);
            this.pnl_SearchImage.Controls.Add(this.picb_MM);
            this.pnl_SearchImage.Controls.Add(this.pictureBox1);
            this.pnl_SearchImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_SearchImage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_SearchImage.Location = new System.Drawing.Point(0, 0);
            this.pnl_SearchImage.Name = "pnl_SearchImage";
            this.pnl_SearchImage.Size = new System.Drawing.Size(1006, 107);
            this.pnl_SearchImage.TabIndex = 18;
            // 
            // cmb_LocalLLT
            // 
            this.cmb_LocalLLT.AddItemCols = 0;
            this.cmb_LocalLLT.AddItemSeparator = ';';
            this.cmb_LocalLLT.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_LocalLLT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LocalLLT.Caption = "";
            this.cmb_LocalLLT.CaptionHeight = 17;
            this.cmb_LocalLLT.CaptionStyle = style73;
            this.cmb_LocalLLT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LocalLLT.ColumnCaptionHeight = 18;
            this.cmb_LocalLLT.ColumnFooterHeight = 18;
            this.cmb_LocalLLT.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LocalLLT.ContentHeight = 16;
            this.cmb_LocalLLT.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LocalLLT.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LocalLLT.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_LocalLLT.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LocalLLT.EditorHeight = 16;
            this.cmb_LocalLLT.EvenRowStyle = style74;
            this.cmb_LocalLLT.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_LocalLLT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LocalLLT.FooterStyle = style75;
            this.cmb_LocalLLT.GapHeight = 2;
            this.cmb_LocalLLT.HeadingStyle = style76;
            this.cmb_LocalLLT.HighLightRowStyle = style77;
            this.cmb_LocalLLT.ItemHeight = 15;
            this.cmb_LocalLLT.Location = new System.Drawing.Point(881, 76);
            this.cmb_LocalLLT.MatchEntryTimeout = ((long)(2000));
            this.cmb_LocalLLT.MaxDropDownItems = ((short)(5));
            this.cmb_LocalLLT.MaxLength = 32767;
            this.cmb_LocalLLT.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LocalLLT.Name = "cmb_LocalLLT";
            this.cmb_LocalLLT.OddRowStyle = style78;
            this.cmb_LocalLLT.PartialRightColumn = false;
            this.cmb_LocalLLT.PropBag = resources.GetString("cmb_LocalLLT.PropBag");
            this.cmb_LocalLLT.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LocalLLT.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LocalLLT.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LocalLLT.SelectedStyle = style79;
            this.cmb_LocalLLT.Size = new System.Drawing.Size(100, 20);
            this.cmb_LocalLLT.Style = style80;
            this.cmb_LocalLLT.TabIndex = 540;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style81;
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
            this.cmb_Factory.EvenRowStyle = style82;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style83;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style84;
            this.cmb_Factory.HighLightRowStyle = style85;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(781, 76);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style86;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style87;
            this.cmb_Factory.Size = new System.Drawing.Size(99, 20);
            this.cmb_Factory.Style = style88;
            this.cmb_Factory.TabIndex = 539;
            // 
            // lbl_LocalLLT
            // 
            this.lbl_LocalLLT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_LocalLLT.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LocalLLT.ImageIndex = 0;
            this.lbl_LocalLLT.ImageList = this.img_Label;
            this.lbl_LocalLLT.Location = new System.Drawing.Point(680, 76);
            this.lbl_LocalLLT.Name = "lbl_LocalLLT";
            this.lbl_LocalLLT.Size = new System.Drawing.Size(100, 21);
            this.lbl_LocalLLT.TabIndex = 538;
            this.lbl_LocalLLT.Text = "Local/ LLT";
            this.lbl_LocalLLT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Style_Item_Div
            // 
            this.cmb_Style_Item_Div.AddItemCols = 0;
            this.cmb_Style_Item_Div.AddItemSeparator = ';';
            this.cmb_Style_Item_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Style_Item_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Style_Item_Div.Caption = "";
            this.cmb_Style_Item_Div.CaptionHeight = 17;
            this.cmb_Style_Item_Div.CaptionStyle = style89;
            this.cmb_Style_Item_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Style_Item_Div.ColumnCaptionHeight = 18;
            this.cmb_Style_Item_Div.ColumnFooterHeight = 18;
            this.cmb_Style_Item_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Style_Item_Div.ContentHeight = 16;
            this.cmb_Style_Item_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Style_Item_Div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Style_Item_Div.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Style_Item_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Style_Item_Div.EditorHeight = 16;
            this.cmb_Style_Item_Div.EvenRowStyle = style90;
            this.cmb_Style_Item_Div.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Style_Item_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Style_Item_Div.FooterStyle = style91;
            this.cmb_Style_Item_Div.GapHeight = 2;
            this.cmb_Style_Item_Div.HeadingStyle = style92;
            this.cmb_Style_Item_Div.HighLightRowStyle = style93;
            this.cmb_Style_Item_Div.ItemHeight = 15;
            this.cmb_Style_Item_Div.Location = new System.Drawing.Point(781, 32);
            this.cmb_Style_Item_Div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Style_Item_Div.MaxDropDownItems = ((short)(5));
            this.cmb_Style_Item_Div.MaxLength = 32767;
            this.cmb_Style_Item_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Style_Item_Div.Name = "cmb_Style_Item_Div";
            this.cmb_Style_Item_Div.OddRowStyle = style94;
            this.cmb_Style_Item_Div.PartialRightColumn = false;
            this.cmb_Style_Item_Div.PropBag = resources.GetString("cmb_Style_Item_Div.PropBag");
            this.cmb_Style_Item_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Style_Item_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Style_Item_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Style_Item_Div.SelectedStyle = style95;
            this.cmb_Style_Item_Div.Size = new System.Drawing.Size(200, 20);
            this.cmb_Style_Item_Div.Style = style96;
            this.cmb_Style_Item_Div.TabIndex = 537;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(680, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 536;
            this.label3.Text = "Item Division";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_USE
            // 
            this.cmb_USE.AddItemCols = 0;
            this.cmb_USE.AddItemSeparator = ';';
            this.cmb_USE.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_USE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_USE.Caption = "";
            this.cmb_USE.CaptionHeight = 17;
            this.cmb_USE.CaptionStyle = style97;
            this.cmb_USE.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_USE.ColumnCaptionHeight = 18;
            this.cmb_USE.ColumnFooterHeight = 18;
            this.cmb_USE.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_USE.ContentHeight = 16;
            this.cmb_USE.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_USE.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_USE.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_USE.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_USE.EditorHeight = 16;
            this.cmb_USE.EvenRowStyle = style98;
            this.cmb_USE.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_USE.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_USE.FooterStyle = style99;
            this.cmb_USE.GapHeight = 2;
            this.cmb_USE.HeadingStyle = style100;
            this.cmb_USE.HighLightRowStyle = style101;
            this.cmb_USE.ItemHeight = 15;
            this.cmb_USE.Location = new System.Drawing.Point(781, 54);
            this.cmb_USE.MatchEntryTimeout = ((long)(2000));
            this.cmb_USE.MaxDropDownItems = ((short)(5));
            this.cmb_USE.MaxLength = 32767;
            this.cmb_USE.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_USE.Name = "cmb_USE";
            this.cmb_USE.OddRowStyle = style102;
            this.cmb_USE.PartialRightColumn = false;
            this.cmb_USE.PropBag = resources.GetString("cmb_USE.PropBag");
            this.cmb_USE.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_USE.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_USE.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_USE.SelectedStyle = style103;
            this.cmb_USE.Size = new System.Drawing.Size(200, 20);
            this.cmb_USE.Style = style104;
            this.cmb_USE.TabIndex = 535;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 0;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(680, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 534;
            this.label2.Text = "Use Y/N";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style105;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 16;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 16;
            this.cmb_purUser.EvenRowStyle = style106;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style107;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style108;
            this.cmb_purUser.HighLightRowStyle = style109;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(445, 76);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style110;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style111;
            this.cmb_purUser.Size = new System.Drawing.Size(200, 20);
            this.cmb_purUser.Style = style112;
            this.cmb_purUser.TabIndex = 533;
            // 
            // lbl_User
            // 
            this.lbl_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_User.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User.ImageIndex = 0;
            this.lbl_User.ImageList = this.img_Label;
            this.lbl_User.Location = new System.Drawing.Point(344, 76);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(100, 21);
            this.lbl_User.TabIndex = 532;
            this.lbl_User.Text = "User";
            this.lbl_User.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Cust_Cd
            // 
            this.txt_Cust_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Cust_Cd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Cust_Cd.Location = new System.Drawing.Point(445, 54);
            this.txt_Cust_Cd.MaxLength = 10;
            this.txt_Cust_Cd.Name = "txt_Cust_Cd";
            this.txt_Cust_Cd.Size = new System.Drawing.Size(79, 21);
            this.txt_Cust_Cd.TabIndex = 529;
            this.txt_Cust_Cd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Cust_Cd_KeyUp);
            // 
            // cmb_Cust
            // 
            this.cmb_Cust.AddItemCols = 0;
            this.cmb_Cust.AddItemSeparator = ';';
            this.cmb_Cust.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Cust.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Cust.Caption = "";
            this.cmb_Cust.CaptionHeight = 17;
            this.cmb_Cust.CaptionStyle = style113;
            this.cmb_Cust.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Cust.ColumnCaptionHeight = 18;
            this.cmb_Cust.ColumnFooterHeight = 18;
            this.cmb_Cust.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Cust.ContentHeight = 16;
            this.cmb_Cust.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Cust.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Cust.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Cust.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Cust.EditorHeight = 16;
            this.cmb_Cust.EvenRowStyle = style114;
            this.cmb_Cust.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Cust.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Cust.FooterStyle = style115;
            this.cmb_Cust.GapHeight = 2;
            this.cmb_Cust.HeadingStyle = style116;
            this.cmb_Cust.HighLightRowStyle = style117;
            this.cmb_Cust.ItemHeight = 15;
            this.cmb_Cust.Location = new System.Drawing.Point(525, 54);
            this.cmb_Cust.MatchEntryTimeout = ((long)(2000));
            this.cmb_Cust.MaxDropDownItems = ((short)(5));
            this.cmb_Cust.MaxLength = 32767;
            this.cmb_Cust.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Cust.Name = "cmb_Cust";
            this.cmb_Cust.OddRowStyle = style118;
            this.cmb_Cust.PartialRightColumn = false;
            this.cmb_Cust.PropBag = resources.GetString("cmb_Cust.PropBag");
            this.cmb_Cust.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Cust.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Cust.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Cust.SelectedStyle = style119;
            this.cmb_Cust.Size = new System.Drawing.Size(120, 20);
            this.cmb_Cust.Style = style120;
            this.cmb_Cust.TabIndex = 530;
            this.cmb_Cust.Change += new C1.Win.C1List.ChangeEventHandler(this.cmb_Cust_Change);
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(344, 54);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 531;
            this.lbl_style.Text = "Customer";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Group_Type
            // 
            this.cmb_Group_Type.AddItemCols = 0;
            this.cmb_Group_Type.AddItemSeparator = ';';
            this.cmb_Group_Type.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_Type.Caption = "";
            this.cmb_Group_Type.CaptionHeight = 17;
            this.cmb_Group_Type.CaptionStyle = style121;
            this.cmb_Group_Type.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_Type.ColumnCaptionHeight = 18;
            this.cmb_Group_Type.ColumnFooterHeight = 18;
            this.cmb_Group_Type.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_Type.ContentHeight = 17;
            this.cmb_Group_Type.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_Type.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_Type.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_Type.EditorHeight = 17;
            this.cmb_Group_Type.EvenRowStyle = style122;
            this.cmb_Group_Type.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_Type.FooterStyle = style123;
            this.cmb_Group_Type.GapHeight = 2;
            this.cmb_Group_Type.HeadingStyle = style124;
            this.cmb_Group_Type.HighLightRowStyle = style125;
            this.cmb_Group_Type.ItemHeight = 15;
            this.cmb_Group_Type.Location = new System.Drawing.Point(117, 32);
            this.cmb_Group_Type.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_Type.MaxDropDownItems = ((short)(5));
            this.cmb_Group_Type.MaxLength = 32767;
            this.cmb_Group_Type.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_Type.Name = "cmb_Group_Type";
            this.cmb_Group_Type.OddRowStyle = style126;
            this.cmb_Group_Type.PartialRightColumn = false;
            this.cmb_Group_Type.PropBag = resources.GetString("cmb_Group_Type.PropBag");
            this.cmb_Group_Type.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_Type.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_Type.SelectedStyle = style127;
            this.cmb_Group_Type.Size = new System.Drawing.Size(200, 21);
            this.cmb_Group_Type.Style = style128;
            this.cmb_Group_Type.TabIndex = 1;
            this.cmb_Group_Type.Tag = "";
            this.cmb_Group_Type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_Type_KeyPress);
            this.cmb_Group_Type.SelectedValueChanged += new System.EventHandler(this.cmb_Group_Type_SelectedValueChanged);
            // 
            // cmb_Group_M
            // 
            this.cmb_Group_M.AccessibleDescription = "";
            this.cmb_Group_M.AccessibleName = "";
            this.cmb_Group_M.AddItemCols = 0;
            this.cmb_Group_M.AddItemSeparator = ';';
            this.cmb_Group_M.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_M.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_M.Caption = "";
            this.cmb_Group_M.CaptionHeight = 17;
            this.cmb_Group_M.CaptionStyle = style129;
            this.cmb_Group_M.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_M.ColumnCaptionHeight = 18;
            this.cmb_Group_M.ColumnFooterHeight = 18;
            this.cmb_Group_M.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_M.ContentHeight = 16;
            this.cmb_Group_M.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_M.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_M.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_M.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_M.EditorHeight = 16;
            this.cmb_Group_M.EvenRowStyle = style130;
            this.cmb_Group_M.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmb_Group_M.FooterStyle = style131;
            this.cmb_Group_M.GapHeight = 2;
            this.cmb_Group_M.HeadingStyle = style132;
            this.cmb_Group_M.HighLightRowStyle = style133;
            this.cmb_Group_M.ItemHeight = 15;
            this.cmb_Group_M.Location = new System.Drawing.Point(117, 75);
            this.cmb_Group_M.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_M.MaxDropDownItems = ((short)(5));
            this.cmb_Group_M.MaxLength = 32767;
            this.cmb_Group_M.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_M.Name = "cmb_Group_M";
            this.cmb_Group_M.OddRowStyle = style134;
            this.cmb_Group_M.PartialRightColumn = false;
            this.cmb_Group_M.PropBag = resources.GetString("cmb_Group_M.PropBag");
            this.cmb_Group_M.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_M.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_M.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_M.SelectedStyle = style135;
            this.cmb_Group_M.Size = new System.Drawing.Size(200, 20);
            this.cmb_Group_M.Style = style136;
            this.cmb_Group_M.TabIndex = 3;
            this.cmb_Group_M.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_M_KeyPress);
            this.cmb_Group_M.SelectedValueChanged += new System.EventHandler(this.cmb_Group_M_SelectedValueChanged);
            // 
            // cmb_Group_L
            // 
            this.cmb_Group_L.AccessibleDescription = "";
            this.cmb_Group_L.AccessibleName = "";
            this.cmb_Group_L.AddItemCols = 0;
            this.cmb_Group_L.AddItemSeparator = ';';
            this.cmb_Group_L.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Group_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Group_L.Caption = "";
            this.cmb_Group_L.CaptionHeight = 17;
            this.cmb_Group_L.CaptionStyle = style137;
            this.cmb_Group_L.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Group_L.ColumnCaptionHeight = 18;
            this.cmb_Group_L.ColumnFooterHeight = 18;
            this.cmb_Group_L.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Group_L.ContentHeight = 16;
            this.cmb_Group_L.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Group_L.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Group_L.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Group_L.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Group_L.EditorHeight = 16;
            this.cmb_Group_L.EvenRowStyle = style138;
            this.cmb_Group_L.Font = new System.Drawing.Font("Verdana", 9F);
            this.cmb_Group_L.FooterStyle = style139;
            this.cmb_Group_L.GapHeight = 2;
            this.cmb_Group_L.HeadingStyle = style140;
            this.cmb_Group_L.HighLightRowStyle = style141;
            this.cmb_Group_L.ItemHeight = 15;
            this.cmb_Group_L.Location = new System.Drawing.Point(117, 54);
            this.cmb_Group_L.MatchEntryTimeout = ((long)(2000));
            this.cmb_Group_L.MaxDropDownItems = ((short)(5));
            this.cmb_Group_L.MaxLength = 32767;
            this.cmb_Group_L.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Group_L.Name = "cmb_Group_L";
            this.cmb_Group_L.OddRowStyle = style142;
            this.cmb_Group_L.PartialRightColumn = false;
            this.cmb_Group_L.PropBag = resources.GetString("cmb_Group_L.PropBag");
            this.cmb_Group_L.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Group_L.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Group_L.SelectedStyle = style143;
            this.cmb_Group_L.Size = new System.Drawing.Size(200, 20);
            this.cmb_Group_L.Style = style144;
            this.cmb_Group_L.TabIndex = 2;
            this.cmb_Group_L.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Group_L_KeyPress);
            this.cmb_Group_L.SelectedValueChanged += new System.EventHandler(this.cmb_Group_L_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 528;
            this.label1.Text = "Class (Second)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_L
            // 
            this.lbl_Group_L.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Group_L.ImageIndex = 0;
            this.lbl_Group_L.ImageList = this.img_Label;
            this.lbl_Group_L.Location = new System.Drawing.Point(16, 54);
            this.lbl_Group_L.Name = "lbl_Group_L";
            this.lbl_Group_L.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_L.TabIndex = 527;
            this.lbl_Group_L.Text = "Class (First)";
            this.lbl_Group_L.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Group_Type
            // 
            this.lbl_Group_Type.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Group_Type.ImageIndex = 0;
            this.lbl_Group_Type.ImageList = this.img_Label;
            this.lbl_Group_Type.Location = new System.Drawing.Point(16, 32);
            this.lbl_Group_Type.Name = "lbl_Group_Type";
            this.lbl_Group_Type.Size = new System.Drawing.Size(100, 21);
            this.lbl_Group_Type.TabIndex = 526;
            this.lbl_Group_Type.Text = "Group Type";
            this.lbl_Group_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Item_Name
            // 
            this.txt_Item_Name.BackColor = System.Drawing.Color.White;
            this.txt_Item_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Item_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Item_Name.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txt_Item_Name.Location = new System.Drawing.Point(445, 32);
            this.txt_Item_Name.MaxLength = 100;
            this.txt_Item_Name.Name = "txt_Item_Name";
            this.txt_Item_Name.Size = new System.Drawing.Size(200, 21);
            this.txt_Item_Name.TabIndex = 6;
            this.txt_Item_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Item_Name_KeyPress);
            // 
            // lbl_Item_Name
            // 
            this.lbl_Item_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Item_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Item_Name.ImageIndex = 0;
            this.lbl_Item_Name.ImageList = this.img_Label;
            this.lbl_Item_Name.Location = new System.Drawing.Point(344, 32);
            this.lbl_Item_Name.Name = "lbl_Item_Name";
            this.lbl_Item_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Item_Name.TabIndex = 36;
            this.lbl_Item_Name.Text = "Item Name";
            this.lbl_Item_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_MR
            // 
            this.picb_MR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_MR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.picb_MR.Image = ((System.Drawing.Image)(resources.GetObject("picb_MR.Image")));
            this.picb_MR.Location = new System.Drawing.Point(905, 30);
            this.picb_MR.Name = "picb_MR";
            this.picb_MR.Size = new System.Drawing.Size(101, 67);
            this.picb_MR.TabIndex = 26;
            this.picb_MR.TabStop = false;
            // 
            // picb_TR
            // 
            this.picb_TR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_TR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_TR.Image = ((System.Drawing.Image)(resources.GetObject("picb_TR.Image")));
            this.picb_TR.Location = new System.Drawing.Point(990, 0);
            this.picb_TR.Name = "picb_TR";
            this.picb_TR.Size = new System.Drawing.Size(16, 40);
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
            this.picb_TM.Size = new System.Drawing.Size(782, 40);
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
            this.lbl_SubTitle1.Text = "      Item Code Info.";
            this.lbl_SubTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picb_BR
            // 
            this.picb_BR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picb_BR.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BR.Image = ((System.Drawing.Image)(resources.GetObject("picb_BR.Image")));
            this.picb_BR.Location = new System.Drawing.Point(990, 92);
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
            this.picb_BM.Location = new System.Drawing.Point(144, 91);
            this.picb_BM.Name = "picb_BM";
            this.picb_BM.Size = new System.Drawing.Size(846, 18);
            this.picb_BM.TabIndex = 24;
            this.picb_BM.TabStop = false;
            // 
            // picb_BL
            // 
            this.picb_BL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picb_BL.BackColor = System.Drawing.SystemColors.Window;
            this.picb_BL.Image = ((System.Drawing.Image)(resources.GetObject("picb_BL.Image")));
            this.picb_BL.Location = new System.Drawing.Point(0, 92);
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
            this.picb_ML.Size = new System.Drawing.Size(168, 74);
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
            this.picb_MM.Location = new System.Drawing.Point(136, 32);
            this.picb_MM.Name = "picb_MM";
            this.picb_MM.Size = new System.Drawing.Size(838, 75);
            this.picb_MM.TabIndex = 27;
            this.picb_MM.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-72, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(838, 75);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // Form_BC_Item
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.pnl_B);
            this.Name = "Form_BC_Item";
            this.Controls.SetChildIndex(this.pnl_B, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.pnl_B.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sgrid_Item_Sheet1)).EndInit();
            this.pnl_BB.ResumeLayout(false);
            this.pnl_BT.ResumeLayout(false);
            this.pnl_SearchImage.ResumeLayout(false);
            this.pnl_SearchImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LocalLLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Style_Item_Div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_USE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Cust)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_Type)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_M)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Group_L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_TM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_BL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_ML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_MM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		//private string _Group_Type,_Group_L, _Group_M, _Group_CD, _Group_Name;

		#endregion  

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
				//Title
				this.Text = "Item Master";
				lbl_MainTitle.Text = "Item Master";

				//영문변환 사용
				ClassLib.ComFunction.SetLangDic(this);

				//컨트롤 대문자로
				ClassLib.ComFunction.Init_Form_Control(this);

				tbtn_Delete.Enabled  = false;

				//그룹타입 콤보쿼리
				DataTable dt_ret;
				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_Group_Type, 0, 1, false, 40, 130);  
				dt_ret.Dispose();

				// cmb_purUser
				dt_ret = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_purUser, 1, 1, true, 0, 210);
				//cmb_purUser.ValueMember = "Name";
				cmb_purUser.SelectedValue = COM.ComVar.This_User;

				// cmb_Style_Item_Div SBM10
				dt_ret = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM10");
				COM.ComCtl.Set_ComboList(dt_ret, cmb_Style_Item_Div, 1, 2, true, 56,0);
				cmb_Style_Item_Div.SelectedIndex = 0;

				//Use Y/N				
				cmb_USE.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
				cmb_USE.ClearItems();
				cmb_USE.ExtendRightColumn = true;
				cmb_USE.ColumnHeaders = false;			

				cmb_USE.AddItem(" ");			
				cmb_USE.AddItem("Y");			
				cmb_USE.AddItem("N");		
	
				cmb_USE.SelectedIndex = -1;



				// local/ LLT 선택 위한 공장, local/LLT 리스트 콤보
				// 공장코드
				dt_ret = COM.ComFunction.Select_Factory_List();
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
				cmb_Factory.SelectedIndex = -1;

				// local/LLT 리스트 콤보
				dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxLocalLLTDivision);
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_LocalLLT, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Name);
				cmb_LocalLLT.SelectedIndex = -1;
	   






				//-------------------------------------------------------------------------------------------------------------------
				// 그리드 설정  
                // 업무코드에 따라서 그리드 헤더 설정 
				//-------------------------------------------------------------------------------------------------------------------
				switch( ClassLib.ComVar.This_JobCdoe )
				{
                    //case ClassLib.ComVar.CxJobCd_Material:
						
                    //    sgrid_Item.Set_Spread_Comm("SBC_ITEM_B", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
						
                    //    btn_Insert.Enabled = true;
                    //    btn_Delete.Enabled = true;  


                    //    // 그리드에 공장별 담당자 리스트 세팅
                    //    Set_ManCharge_ComboList();

                    //    break;

					case ClassLib.ComVar.CxJobCd_Cost:
						
						sgrid_Item.Set_Spread_Comm("SBC_ITEM_J", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
						
						btn_Insert.Enabled = false;
						btn_Delete.Enabled = false; 

						break;

					case ClassLib.ComVar.CxJobCd_Trade:
						
						sgrid_Item.Set_Spread_Comm("SBC_ITEM_T", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 

						btn_Insert.Enabled = false;
						btn_Delete.Enabled = false;  

						break; 


                    default :

                        sgrid_Item.Set_Spread_Comm("SBC_ITEM_B", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

                        btn_Insert.Enabled = true;
                        btn_Delete.Enabled = true;


                        // 그리드에 공장별 담당자 리스트 세팅
                        Set_ManCharge_ComboList();

                        break;


				} // end switch

				//-------------------------------------------------------------------------------------------------------------------
				 

				//-------------------------------------------------------------------------------------------------------------------
				// 공장에 따라 자재 마스터 수정 가능 여부를 지정
				//-------------------------------------------------------------------------------------------------------------------
				Set_Editable();
			   

				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

		private void Set_Editable()
		{
			bool editable = false;

			if (!COM.ComVar.This_Factory.Equals(COM.ComVar.DSFactory))
			{
				sgrid_Item.ActiveSheet.Columns[0, sgrid_Item.ActiveSheet.ColumnCount - 1].Locked = !editable;
				tbtn_Save.Enabled	= editable;
				btn_Insert.Enabled	= editable;
				btn_Delete.Enabled	= editable;
				btn_recover.Enabled = editable;
			}
		}



		/// <summary>
		/// Set_ManCharge_ComboList : 그리드에 공장별 담당자 리스트 세팅
		/// </summary>
		private void Set_ManCharge_ComboList()
		{

			DataTable dt_ret = ClassLib.ComFunction.Select_Man_Charge(ClassLib.ComVar.This_Factory ); 





			DataTable rtn_dt = new DataTable();
			DataRow dr;


			rtn_dt.Columns.Add("CODE", typeof(string) );
			rtn_dt.Columns.Add("NAME", typeof(string) ); 

			dr = rtn_dt.NewRow();
			dr["CODE"] = "";
			dr["NAME"] = "";
			rtn_dt.Rows.Add(dr);

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				dr = rtn_dt.NewRow();
				dr["CODE"] = dt_ret.Rows[i].ItemArray[1].ToString();

				//dr["NAME"] = dt_ret.Rows[i].ItemArray[2].ToString();
				dr["NAME"] = dt_ret.Rows[i].ItemArray[1].ToString();

				rtn_dt.Rows.Add(dr);

			}



								
			COM.SSPComboBoxCellType cell_combo = new COM.SSPComboBoxCellType(rtn_dt, "NAME", "CODE", false);  



			sgrid_Item.ActiveSheet.Columns[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_DS].CellType = cell_combo;
			sgrid_Item.ActiveSheet.Columns[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_QD].CellType = cell_combo;
			sgrid_Item.ActiveSheet.Columns[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_VJ].CellType = cell_combo;
            sgrid_Item.ActiveSheet.Columns[(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxMAN_CHARGE_JJ].CellType = cell_combo;



			dt_ret.Dispose();

		}


		private void Txt_Cust_CdKeyUpProcess()
		{
			DataTable vDt = null;

			try
			{
				vDt = Select_SCM_CUST(txt_Cust_Cd.Text);

				COM.ComCtl.Set_ComboList(vDt, cmb_Cust, 0, 1, true, 80, 140); 

				/*
				if (txt_Cust_Cd.Text.Length == 9)
				{
					string vStyle = txt_styleCode.Text.Substring(0, 5) + txt_styleCode.Text.Substring(6);
					cmb_style.SelectedValue = vStyle;
				}
				*/
			}
			catch 
			{
				//
			}
			finally
			{
				if (vDt != null) vDt.Dispose();
			}
		}


		/// <summary>
		/// 그리드 조회
		/// </summary>
		public void Item_Search()
		{
			try
			{

				if(cmb_Group_Type.SelectedIndex == -1) return;  // || cmb_Group_L.SelectedIndex == -1) return;

				//if(cmb_Group_L.ListCount != 0 && cmb_Group_L.SelectedIndex == -1) return;


				DataTable dt_ret;

				this.Cursor = Cursors.WaitCursor;


				dt_ret = SELECT_SBC_ITEM();

				Display_Grid(dt_ret, sgrid_Item); 

				sgrid_Item.Set_FontColor_Row((int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxUSE_YN, "N", System.Drawing.Color.Red); 
				sgrid_Item.Set_FontColor_Row((int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxUSE_YN, "Y", System.Drawing.Color.Empty);


				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
				dt_ret.Dispose();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Item_Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// SELECT_SBC_ITEM : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBC_ITEM()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(12);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_ITEM.SELECT_SBC_ITEM";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_GROUP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_GROUP_L";
			MyOraDB.Parameter_Name[3] = "ARG_GROUP_M";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_NAME";
			MyOraDB.Parameter_Name[5] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[6] = "ARG_MAN_CHARGE_DS";
			MyOraDB.Parameter_Name[7] = "ARG_STYLE_ITEM_DIV";
			MyOraDB.Parameter_Name[8] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[9] = "ARG_IMPORT_FACTORY";
			MyOraDB.Parameter_Name[10] = "ARG_IMPORT_YN";
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

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Group_Type, " ");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_Group_L, " ");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_Group_M, " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_TextBox(txt_Item_Name, " ");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_TextBox(txt_Cust_Cd, " ");
			MyOraDB.Parameter_Values[6] = COM.ComFunction.Empty_Combo(cmb_purUser, " ");
			MyOraDB.Parameter_Values[7] = cmb_Style_Item_Div.SelectedValue.ToString();
			MyOraDB.Parameter_Values[8] = COM.ComFunction.Empty_String(cmb_USE.Text, " ");


			string import_factory = COM.ComFunction.Empty_Combo(cmb_Factory, "-1").Trim();

			if(import_factory == "-1" || import_factory == "")
			{
				MyOraDB.Parameter_Values[9] = "-1";
			}
			else
			{
				MyOraDB.Parameter_Values[9] = cmb_Factory.SelectedValue.ToString();
			}

			

			string import_yn = COM.ComFunction.Empty_Combo(cmb_LocalLLT, "-1").Trim();

			if(import_factory == "-1" || import_factory == "")
			{

				if(import_factory == "-1" || import_factory == "")
				{
					MyOraDB.Parameter_Values[10] = "-1";
				}
				else
				{
					MyOraDB.Parameter_Values[10] = cmb_LocalLLT.SelectedValue.ToString(); 
				} 
				
			}
			else
			{
				MyOraDB.Parameter_Values[10] = COM.ComFunction.Empty_Combo(cmb_LocalLLT, "-1");
			}

			MyOraDB.Parameter_Values[11] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}



		/// <summary>
		/// Display_Grid : 그리드에 표시
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_fgrid"></param>
		private void Display_Grid(DataTable arg_dt, COM.SSP arg_fgrid)
		{
			arg_fgrid.Display_Grid(arg_dt) ;
		}

		

		#endregion  

		#region 이벤트 처리


		#region 이벤트_그리드관련
		

		private void sgrid_Item_EditModeOn(object sender, System.EventArgs e)
		{
			int ir = sgrid_Item.ActiveSheet.ActiveRowIndex ;
			int ic = sgrid_Item.ActiveSheet.ActiveColumnIndex ;

			sgrid_Item.Buffer_CellData = (sgrid_Item.ActiveSheet.Cells[ir,ic].Value == null) 
				? "" : sgrid_Item.ActiveSheet.Cells[ir,ic].Value.ToString();

			string s = sgrid_Item.ActiveSheet.Columns[ic].CellType.ToString();
			if( s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
			{
				sgrid_Item.Buffer_CellData = "000";
				sgrid_Item.Update_Row(img_Action);


				Change_Import_Division(ir, ic);



			}		
		}


		private void sgrid_Item_EditModeOff(object sender, System.EventArgs e)
		{
			int ir = sgrid_Item.ActiveSheet.ActiveRowIndex ;
			int ic = sgrid_Item.ActiveSheet.ActiveColumnIndex ;

			Change_Import_Division(ir, ic);
		}


		/// <summary>
		/// Change_Import_Division : buy_div에 따라서, import ds/qd/vj 데이터 수정
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_col"></param>
		private void Change_Import_Division(int arg_row, int arg_col)
		{

			 
			string import_div = "";

			if(arg_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxBUY_DIV)
			{
							
				if(sgrid_Item.ActiveSheet.Cells[arg_row, arg_col].Value.ToString() == "1") // local
				{
					import_div = "L"; 
				}
				else if(sgrid_Item.ActiveSheet.Cells[arg_row, arg_col].Value.ToString() == "3") // import
				{
					import_div = "T"; 
				}
				else if(sgrid_Item.ActiveSheet.Cells[arg_row, arg_col].Value.ToString() == "5") // ds shipping
				{
					import_div = "S"; 
				}
				else // L/C, outside processed, other
				{
					import_div = "N"; 
				}

							
				sgrid_Item.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_DS].Value = import_div;
				sgrid_Item.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_QD].Value = import_div;
				sgrid_Item.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_VJ].Value = import_div;
                sgrid_Item.ActiveSheet.Cells[arg_row, (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxIMPORT_JJ].Value = import_div;

			} // end if (arg_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxBUY_DIV)


		}



		private void sgrid_Item_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			sgrid_Item.Update_Row(img_Action);
		}



		/// <summary>
		/// 그리드 더블클릭시 상세정보 팝업
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sgrid_Item_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{

				//------------------------------------------------------------------------------------------------------------------- 
				// 업무코드에 따라서 팝업 실행 여부 설정
				//-------------------------------------------------------------------------------------------------------------------
				if( ClassLib.ComVar.This_JobCdoe !=  ClassLib.ComVar.CxJobCd_Material) return;
				//-------------------------------------------------------------------------------------------------------------------
				 


				if(cmb_Group_Type.SelectedIndex != -1 && e.Column == (int) ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME1)
				{


//					ClassLib.ComVar.Parameter_PopUp  = new string[4];
//					ClassLib.ComVar.Parameter_PopUp[0] = "U";
//					ClassLib.ComVar.Parameter_PopUp[1] = sgrid_Item.ActiveSheet.Cells[sgrid_Item.ActiveSheet.ActiveRowIndex,(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_CD].Value.ToString();
//					ClassLib.ComVar.Parameter_PopUp[2] = cmb_Group_Type.SelectedValue.ToString();
//					ClassLib.ComVar.Parameter_PopUp[3] = ClassLib.ComFunction.Empty_Combo(cmb_Group_L, "");
//					
//					Pop_Item popup = new Pop_Item();
//					popup.ShowDialog();
//
//					if(popup._Close_Save) 
//					{
//						//Item_Search(); 
//
//						Apply_Row_Item(sgrid_Item.ActiveSheet.ActiveRowIndex);
//		
//						ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//					} // end if


					string division =  "U";
					string item_cd = sgrid_Item.ActiveSheet.Cells[sgrid_Item.ActiveSheet.ActiveRowIndex,(int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_CD].Value.ToString();
					string group_type = cmb_Group_Type.SelectedValue.ToString();
					string group_l = ClassLib.ComFunction.Empty_Combo(cmb_Group_L, "");

					Show_Pop_Item_Show(division, item_cd, group_type, group_l);




				} // end if



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sgrid_Item_CellDoubleClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}








		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void sgrid_Item_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			try
			{
				Set_Update_SelectionRow(e);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "sgrid_Item_MouseUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}

	

		/// <summary>
		/// 여러 행 선택 후 데이터 일괄 수정 
		/// </summary>
		/// <param name="e"></param>
		private void Set_Update_SelectionRow(System.Windows.Forms.MouseEventArgs e)
		{

			// 마우스 오른쪽 이벤트에만 팝업창 실행
			if(! e.Button.Equals(MouseButtons.Right) ) return;

			if(sgrid_Item.ActiveSheet.Rows.Count == 0) return;

			int sel_row = sgrid_Item.ActiveSheet.ActiveRowIndex;
			int sel_col = sgrid_Item.ActiveSheet.ActiveColumnIndex;


			if(sgrid_Item.ActiveSheet.Columns[sel_col].Locked) return;

			  

			if(sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_DS
				|| sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_QD
                || sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_VJ
                || sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_JJ)
			{


				COM.ComVar.Parameter_PopUp = new string[] { ClassLib.ComVar.Vendor }; 
				FlexBase.MaterialBase.Pop_SelectionChange_Box pop_form = new FlexBase.MaterialBase.Pop_SelectionChange_Box();
				pop_form.ShowDialog();
 
				if(COM.ComVar.Parameter_PopUp == null) return;


				// 0: name
				// 1: code
 

			}
			else
			{
				FarPoint.Win.Spread.Cell cell = sgrid_Item.ActiveSheet.Cells[sel_row, sel_col];
			
				// 헤더 Description
				string column_desc = sgrid_Item.ActiveSheet.ColumnHeader.Cells[1, sel_col].Text;


				Pop_SelectionChange_SSP pop_form = new Pop_SelectionChange_SSP(cell, column_desc);
				pop_form.ShowDialog();

				if(! pop_form._Close_Save) return;  

			}
 

			
			//--------------------------------------------------------------------------------------
			// set update list
			//--------------------------------------------------------------------------------------
			CellRange[] selection_range = sgrid_Item.ActiveSheet.GetSelections(); 
			int start_row = 0; 
			int end_row = 0;

			for (int i = 0 ; i < selection_range.Length; i++)
			{

				start_row = selection_range[i].Row;
				end_row = selection_range[i].Row + selection_range[i].RowCount;


				if(sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_DS
					|| sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_QD
                    || sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_VJ
                    || sel_col == (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxCUS_NAME_JJ)
				{

					for (int j = start_row ; j < end_row; j++)
					{
						sgrid_Item.ActiveSheet.Cells[j, sel_col].Text = COM.ComVar.Parameter_PopUp[0];  //name 
						sgrid_Item.ActiveSheet.Cells[j, sel_col - 4].Text = COM.ComVar.Parameter_PopUp[1];  //code

						sgrid_Item.Update_Row(j, img_Action);
					}


				}
				else
				{

					for (int j = start_row ; j < end_row; j++)
					{
						sgrid_Item.ActiveSheet.Cells[j, sel_col].Text = COM.ComVar.Parameter_PopUp[0];
						sgrid_Item.Update_Row(j, img_Action);


						// buy_div에 따라서, import ds/qd/vj 데이터 수정
						Change_Import_Division(j, sel_col);



					} // end for j


				} // end for i (sel_col == cust_ds, qd, vj)


				
			}	
	  
			//--------------------------------------------------------------------------------------



 


		}


		





		#endregion  

		#region 이벤트_조회조건(콤보)


		private void txt_Cust_Cd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
				this.Txt_Cust_CdKeyUpProcess();		
		}


		/// <summary>
		/// 그룹타입선택시 선택한 그룹타입에 해당하는 대분류쿼리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Group_Type_SelectedValueChanged(object sender, System.EventArgs e)
		{ 
			try
			{
				DataTable dt_ret;

				if(cmb_Group_Type.SelectedIndex == -1) return; 

				dt_ret = ClassLib.ComFunction.Select_GroupLCode(cmb_Group_Type.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Group_L, 0, 1, true, 20, 150); 
 
				cmb_Group_L.SelectedIndex = -1;
				cmb_Group_M.SelectedIndex = -1;

				sgrid_Item.ClearAll();

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_Type_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}


		/// <summary>
		/// 대그룹선택시 선택한 대그룹에 해당하는 중분류쿼리
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Group_L_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				DataTable dt_ret;

				if(cmb_Group_Type.SelectedIndex == -1 || cmb_Group_L.SelectedIndex == -1) return;

				dt_ret = ClassLib.ComFunction.Select_GroupMCode(cmb_Group_Type.SelectedValue.ToString(), cmb_Group_L.SelectedValue.ToString());    
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Group_M, 0, 1, true, 40, 130); 
 
				cmb_Group_M.SelectedIndex = -1;
				sgrid_Item.ClearAll();

				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_L_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}


		/// <summary>
		/// 중분류석콤보 선택
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmb_Group_M_SelectedValueChanged(object sender, System.EventArgs e)
		{
			DataTable dt_ret;

			try
			{
				if(cmb_Group_Type.SelectedIndex == -1 || cmb_Group_L.SelectedIndex == -1 || cmb_Group_M.SelectedIndex == -1) return;

				dt_ret = ClassLib.ComFunction.Select_GroupSCode(cmb_Group_Type.SelectedValue.ToString(), cmb_Group_L.SelectedValue.ToString(), cmb_Group_M.SelectedValue.ToString());    
				
				sgrid_Item.ClearAll();
				
				dt_ret.Dispose();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Group_M_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}

		private void cmb_Cust_Change(object sender, System.EventArgs e)
		{
			txt_Cust_Cd.Text = cmb_Cust.SelectedValue.ToString();
		}

		#endregion 

		#region 이벤트_상속버튼 클릭시

		/// <summary>
		/// Clear버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Item_Clear();
		}


		/// <summary>
		/// Item_Clear : Form Control 초기화
		/// </summary>
		private void Item_Clear()
		{
			try
			{
				cmb_Group_Type.SelectedIndex = -1;
				cmb_Group_L.SelectedIndex = -1;
				cmb_Group_M.SelectedIndex = -1;
				txt_Item_Name.Text = "";

				cmb_Factory.SelectedIndex = -1;
				cmb_LocalLLT.SelectedIndex = -1;

				sgrid_Item.ClearAll();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Item_Clear", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}


		/// <summary>
		/// 조회버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Item_Search(); 
		}


		/// <summary>
		/// Save 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Save_Item();
		}



		/// <summary>
		/// Save_Item : 
		/// </summary>
		private void Save_Item()
		{ 	
			try
			{ 
				bool save_flag = false;

				save_flag = MyOraDB.Save_Spread("PKG_SBC_ITEM.SAVE_SBC_ITEM", sgrid_Item); 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{
					Item_Search();
					MessageBox.Show(this, "Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Item", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}


		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			SetPrint();
		}

		private void  SetPrint()
		{
			try
			{   
	
						 
				string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BC_Item") ;
				string Para         = " ";
//				string arg_Group;

				#region 출력조건

//				int  iCnt  = 3;
//				string [] aHead =  new string[iCnt];	
//
//				arg_Group = COM.ComFunction.Empty_Combo(cmb_Group_Type, " ") + COM.ComFunction.Empty_Combo(cmb_Group_L, " ") + COM.ComFunction.Empty_Combo(cmb_Group_M, " ");
//
//				aHead[0]    = arg_Group;
//				aHead[1]    = ClassLib.ComFunction.Empty_TextBox(txt_Item_Name, " ");
//				aHead[2]    = ClassLib.ComVar.This_Factory;


				int  iCnt  = 11;
				string [] aHead =  new string[iCnt];	
  
				aHead[0]    = ClassLib.ComVar.This_Factory;
				aHead[1]    = COM.ComFunction.Empty_Combo(cmb_Group_Type, " ");
				aHead[2]    = COM.ComFunction.Empty_Combo(cmb_Group_L, " ");
				aHead[3]    = COM.ComFunction.Empty_Combo(cmb_Group_M, " ");
				aHead[4]    = COM.ComFunction.Empty_TextBox(txt_Item_Name, " ");
				aHead[5]    = COM.ComFunction.Empty_TextBox(txt_Cust_Cd, " ");
				aHead[6]    = COM.ComFunction.Empty_Combo(cmb_purUser, " ");
				aHead[7]    = COM.ComFunction.Empty_Combo(cmb_Style_Item_Div, " ");
				aHead[8]    = COM.ComFunction.Empty_String(cmb_USE.Text, " ");

				string import_factory = COM.ComFunction.Empty_Combo(cmb_Factory, "-1").Trim();

				if(import_factory == "-1" || import_factory == "")
				{
					aHead[9] = "-1";
				}
				else
				{
					aHead[9] = cmb_Factory.SelectedValue.ToString();
				}

			

				if(import_factory == "-1" || import_factory == "")
				{
					aHead[10] = COM.ComFunction.Empty_Combo(cmb_LocalLLT, "-1");
				}
				else
				{
					aHead[10] = COM.ComFunction.Empty_Combo(cmb_LocalLLT, " ");
				}
				    
			
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
				ClassLib.ComFunction.User_Message(ex.Message, "Print Item Master", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}								
		}


		#endregion 

		#region 이벤트_하단버튼 클릭시

		 


		private void btn_Insert_Click(object sender, System.EventArgs e)
		{ 
			try
			{
				 
//				ClassLib.ComVar.Parameter_PopUp  = new string[4];
//				ClassLib.ComVar.Parameter_PopUp[0] = "I";
//				ClassLib.ComVar.Parameter_PopUp[1] = "";
//				ClassLib.ComVar.Parameter_PopUp[2] = cmb_Group_Type.SelectedValue.ToString();
//				ClassLib.ComVar.Parameter_PopUp[3] = ClassLib.ComFunction.Empty_Combo(cmb_Group_L, "");
//
//
//				Pop_Item popup = new Pop_Item();
//				popup.ShowDialog(); 
// 
//
//				if(popup._Close_Save) 
//				{ 
//					int addrow = sgrid_Item.Add_Row(img_Action, false);  
//					Apply_Row_Item(addrow);
//
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
//				}

				string division = "I";
				string item_cd = "";
				string group_type = cmb_Group_Type.SelectedValue.ToString();
				string group_l = ClassLib.ComFunction.Empty_Combo(cmb_Group_L, "");

				Show_Pop_Item_Show(division, item_cd, group_type, group_l);


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Insert_Click", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}




		private FlexBase.MaterialBase.Pop_Item_Show pop_form = null;



		private void Show_Pop_Item_Show(string arg_division, string arg_item_cd, string arg_group_type, string arg_group_l)
		{

 
			if(pop_form == null)
			{

				pop_form = new FlexBase.MaterialBase.Pop_Item_Show(arg_division, arg_item_cd, arg_group_type, arg_group_l );
				 
			}
			else
			{
   
				pop_form._Division = arg_division;
				pop_form._ItemCD = arg_item_cd;
				pop_form._Group_Type = arg_group_type;
				pop_form._Group_L = arg_group_l;


				pop_form.Init_Form(); 

			}



			pop_form.ShowDialog(); 


			if(pop_form._Close_Save) 
			{ 

				if(arg_division == "I")
				{
					Apply_Row_Item(sgrid_Item.Add_Row(img_Action, false));
				}
				else if(arg_division == "U")
				{
					Apply_Row_Item(sgrid_Item.ActiveSheet.ActiveRowIndex);
				}


				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);

			}



			pop_form.Clear_All();




		}







		/// <summary>
		/// Apply_Row_Item : 
		/// </summary>
		/// <param name="arg_row"></param>
		private void Apply_Row_Item(int arg_row)
		{
 
			
			for(int i = 0; i < sgrid_Item.ActiveSheet.Columns.Count - 1; i++)
			{
				sgrid_Item.ActiveSheet.Cells[arg_row, i].Text = ClassLib.ComVar.Parameter_PopUp[i];
			}
  
			//top row 기능
			sgrid_Item.Set_CellPosition(arg_row, (int)ClassLib.TBSBC_ITEM_WITH_CUSTNAME.IxITEM_NAME1);


		}



		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			sgrid_Item.Delete_Row(img_Action);	
		}


		private void btn_recover_Click(object sender, System.EventArgs e)
		{
			sgrid_Item.Recovery();
		}


		#endregion 

		#region 이벤트_ Enter키 이동

		private void cmb_Group_Type_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Group_L_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void cmb_Group_M_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Group_CD_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Group_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void txt_Item_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar == (char)13) Item_Search();
		}

		#endregion

		#region 이벤트_버튼 이미지 변경
 
 
		private void btn_Insert_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Insert.ImageIndex = 9;
		}

		private void btn_Insert_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Insert.ImageIndex = 8;
		}

		private void btn_Delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 5;
		}

		private void btn_Delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 4;
		}

		private void btn_recover_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 1;
		}

		private void btn_recover_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 0;
		}

		#endregion 


		#endregion  
		
		#region DB Connect

		/// <summary>
		/// Select_SCM_CUST
		/// </summary>
		/// <param name="arg_stylecd"></param>
		/// <returns></returns>
		public static DataTable Select_SCM_CUST(string arg_cust_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(4); 

			MyOraDB.Process_Name = "PKG_SCM_CUST.SELECT_SCM_CUST_COMBO";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_CUST_CD";
			MyOraDB.Parameter_Name[2] = "ARG_CUST_NAME";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			MyOraDB.Parameter_Values[1] = arg_cust_cd;
			MyOraDB.Parameter_Values[2] = arg_cust_cd;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
			
		}
		 

		#endregion   
		

	}
}

