using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Request_Offer : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_offerNo;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_offerNo;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label lbl_category;
		private System.Windows.Forms.TextBox txt_lcNo;
		private System.Windows.Forms.TextBox txt_devCode;
		private System.Windows.Forms.TextBox txt_prodCode;
		private System.Windows.Forms.TextBox txt_season;
		private System.Windows.Forms.TextBox txt_purpose;
		private System.Windows.Forms.TextBox txt_invoiceNo;
		private System.Windows.Forms.TextBox txt_dhlAccount;
		private System.Windows.Forms.TextBox txt_via;
		private System.Windows.Forms.TextBox txt_seDiv;
		private System.Windows.Forms.TextBox txt_nikeDiv;
		private System.Windows.Forms.TextBox txt_amountCd;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.TextBox txt_splDdd;
		private System.Windows.Forms.TextBox txt_rtaBusan;
		private System.Windows.Forms.TextBox txt_historyNo;
		private C1.Win.C1List.C1Combo cmb_category;
		private System.Windows.Forms.TextBox txt_modelCd;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private System.Windows.Forms.Panel panel2;

		//return 또는 cancel 이벤트 체크
		private bool _CancelFlag = false;
		private bool _SaveFlag   = false;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.TextBox txt_impCountry;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Return;
		
		private int _reqNoCol      = (int)ClassLib.TBSBP_IMPORT.IxOFFER_NO;

		#endregion

		public Pop_BP_Request_Offer()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Request_Offer));
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_offerNo = new System.Windows.Forms.TextBox();
            this.lbl_offerNo = new System.Windows.Forms.Label();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.txt_modelCd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_category = new System.Windows.Forms.Label();
            this.txt_purpose = new System.Windows.Forms.TextBox();
            this.txt_season = new System.Windows.Forms.TextBox();
            this.txt_prodCode = new System.Windows.Forms.TextBox();
            this.txt_devCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_lcNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_impCountry = new System.Windows.Forms.TextBox();
            this.txt_nikeDiv = new System.Windows.Forms.TextBox();
            this.txt_invoiceNo = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_via = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_seDiv = new System.Windows.Forms.TextBox();
            this.txt_dhlAccount = new System.Windows.Forms.TextBox();
            this.txt_amountCd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_splDdd = new System.Windows.Forms.TextBox();
            this.txt_rtaBusan = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_historyNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
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
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.GridDefinition = "80.655737704918:False:True;14.0983606557377:False:True;1.31147540983607:False:Tru" +
                "e;\t0.505050505050505:False:True;97.979797979798:False:False;0.505050505050505:Fa" +
                "lse:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 55);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 305);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.btn_Return);
            this.panel2.Location = new System.Drawing.Point(8, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 43);
            this.panel2.TabIndex = 168;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(565, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 24);
            this.btn_Cancel.TabIndex = 360;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_Return
            // 
            this.btn_Return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Return.ImageIndex = 0;
            this.btn_Return.ImageList = this.img_Button;
            this.btn_Return.Location = new System.Drawing.Point(484, 9);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(80, 24);
            this.btn_Return.TabIndex = 359;
            this.btn_Return.Text = "Apply";
            this.btn_Return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            this.btn_Return.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_Return.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 246);
            this.panel1.TabIndex = 167;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.txt_offerNo);
            this.groupBox1.Controls.Add(this.lbl_offerNo);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.cmb_category);
            this.groupBox1.Controls.Add(this.txt_modelCd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_category);
            this.groupBox1.Controls.Add(this.txt_purpose);
            this.groupBox1.Controls.Add(this.txt_season);
            this.groupBox1.Controls.Add(this.txt_prodCode);
            this.groupBox1.Controls.Add(this.txt_devCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label99);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txt_lcNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_impCountry);
            this.groupBox1.Controls.Add(this.txt_nikeDiv);
            this.groupBox1.Controls.Add(this.txt_invoiceNo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txt_via);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt_seDiv);
            this.groupBox1.Controls.Add(this.txt_dhlAccount);
            this.groupBox1.Controls.Add(this.txt_amountCd);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_splDdd);
            this.groupBox1.Controls.Add(this.txt_rtaBusan);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txt_remarks);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_historyNo);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 247);
            this.groupBox1.TabIndex = 222;
            this.groupBox1.TabStop = false;
            // 
            // txt_offerNo
            // 
            this.txt_offerNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_offerNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_offerNo.Enabled = false;
            this.txt_offerNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_offerNo.Location = new System.Drawing.Point(437, 16);
            this.txt_offerNo.Name = "txt_offerNo";
            this.txt_offerNo.ReadOnly = true;
            this.txt_offerNo.Size = new System.Drawing.Size(211, 21);
            this.txt_offerNo.TabIndex = 27;
            // 
            // lbl_offerNo
            // 
            this.lbl_offerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_offerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_offerNo.ImageIndex = 0;
            this.lbl_offerNo.ImageList = this.img_Label;
            this.lbl_offerNo.Location = new System.Drawing.Point(336, 16);
            this.lbl_offerNo.Name = "lbl_offerNo";
            this.lbl_offerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_offerNo.TabIndex = 52;
            this.lbl_offerNo.Text = "Offer No";
            this.lbl_offerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(10, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style1;
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
            this.cmb_factory.EvenRowStyle = style2;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style3;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style4;
            this.cmb_factory.HighLightRowStyle = style5;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(111, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style6;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style7;
            this.cmb_factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 1;
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemCols = 0;
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style9;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_category.ContentHeight = 16;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 16;
            this.cmb_category.EvenRowStyle = style10;
            this.cmb_category.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_category.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style11;
            this.cmb_category.GapHeight = 2;
            this.cmb_category.HeadingStyle = style12;
            this.cmb_category.HighLightRowStyle = style13;
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(111, 38);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style14;
            this.cmb_category.PartialRightColumn = false;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style15;
            this.cmb_category.Size = new System.Drawing.Size(211, 20);
            this.cmb_category.Style = style16;
            this.cmb_category.TabIndex = 220;
            // 
            // txt_modelCd
            // 
            this.txt_modelCd.BackColor = System.Drawing.Color.White;
            this.txt_modelCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_modelCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_modelCd.Location = new System.Drawing.Point(437, 38);
            this.txt_modelCd.Name = "txt_modelCd";
            this.txt_modelCd.Size = new System.Drawing.Size(211, 21);
            this.txt_modelCd.TabIndex = 221;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageIndex = 0;
            this.label3.ImageList = this.img_Label;
            this.label3.Location = new System.Drawing.Point(336, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 185;
            this.label3.Text = "Model Code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_category
            // 
            this.lbl_category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_category.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_category.ImageIndex = 0;
            this.lbl_category.ImageList = this.img_Label;
            this.lbl_category.Location = new System.Drawing.Point(10, 38);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(100, 21);
            this.lbl_category.TabIndex = 186;
            this.lbl_category.Text = "Catetory";
            this.lbl_category.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_purpose
            // 
            this.txt_purpose.BackColor = System.Drawing.Color.White;
            this.txt_purpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_purpose.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_purpose.Location = new System.Drawing.Point(437, 82);
            this.txt_purpose.Name = "txt_purpose";
            this.txt_purpose.Size = new System.Drawing.Size(211, 21);
            this.txt_purpose.TabIndex = 208;
            // 
            // txt_season
            // 
            this.txt_season.BackColor = System.Drawing.Color.White;
            this.txt_season.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_season.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_season.Location = new System.Drawing.Point(111, 82);
            this.txt_season.Name = "txt_season";
            this.txt_season.Size = new System.Drawing.Size(211, 21);
            this.txt_season.TabIndex = 207;
            // 
            // txt_prodCode
            // 
            this.txt_prodCode.BackColor = System.Drawing.Color.White;
            this.txt_prodCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_prodCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_prodCode.Location = new System.Drawing.Point(437, 60);
            this.txt_prodCode.Name = "txt_prodCode";
            this.txt_prodCode.Size = new System.Drawing.Size(211, 21);
            this.txt_prodCode.TabIndex = 206;
            // 
            // txt_devCode
            // 
            this.txt_devCode.BackColor = System.Drawing.Color.White;
            this.txt_devCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_devCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_devCode.Location = new System.Drawing.Point(111, 60);
            this.txt_devCode.Name = "txt_devCode";
            this.txt_devCode.Size = new System.Drawing.Size(211, 21);
            this.txt_devCode.TabIndex = 205;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImageIndex = 0;
            this.label5.ImageList = this.img_Label;
            this.label5.Location = new System.Drawing.Point(336, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 187;
            this.label5.Text = "Prod Code";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageIndex = 0;
            this.label6.ImageList = this.img_Label;
            this.label6.Location = new System.Drawing.Point(10, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 190;
            this.label6.Text = "Season";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Label;
            this.label7.Location = new System.Drawing.Point(336, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 189;
            this.label7.Text = "Purpose";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label99
            // 
            this.label99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label99.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ImageIndex = 0;
            this.label99.ImageList = this.img_Label;
            this.label99.Location = new System.Drawing.Point(10, 60);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(100, 21);
            this.label99.TabIndex = 188;
            this.label99.Text = "Dev Code";
            this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImageIndex = 0;
            this.label10.ImageList = this.img_Label;
            this.label10.Location = new System.Drawing.Point(10, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 21);
            this.label10.TabIndex = 194;
            this.label10.Text = "Import Country";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImageIndex = 0;
            this.label11.ImageList = this.img_Label;
            this.label11.Location = new System.Drawing.Point(336, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 193;
            this.label11.Text = "Nike dev";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImageIndex = 0;
            this.label12.ImageList = this.img_Label;
            this.label12.Location = new System.Drawing.Point(10, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 192;
            this.label12.Text = "LC No";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lcNo
            // 
            this.txt_lcNo.BackColor = System.Drawing.Color.White;
            this.txt_lcNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lcNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lcNo.Location = new System.Drawing.Point(111, 104);
            this.txt_lcNo.Name = "txt_lcNo";
            this.txt_lcNo.Size = new System.Drawing.Size(211, 21);
            this.txt_lcNo.TabIndex = 204;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ImageIndex = 0;
            this.label13.ImageList = this.img_Label;
            this.label13.Location = new System.Drawing.Point(336, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 21);
            this.label13.TabIndex = 191;
            this.label13.Text = "Invoice No";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_impCountry
            // 
            this.txt_impCountry.BackColor = System.Drawing.Color.White;
            this.txt_impCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_impCountry.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_impCountry.Location = new System.Drawing.Point(111, 126);
            this.txt_impCountry.Name = "txt_impCountry";
            this.txt_impCountry.Size = new System.Drawing.Size(211, 21);
            this.txt_impCountry.TabIndex = 211;
            // 
            // txt_nikeDiv
            // 
            this.txt_nikeDiv.BackColor = System.Drawing.Color.White;
            this.txt_nikeDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_nikeDiv.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_nikeDiv.Location = new System.Drawing.Point(437, 126);
            this.txt_nikeDiv.Name = "txt_nikeDiv";
            this.txt_nikeDiv.Size = new System.Drawing.Size(211, 21);
            this.txt_nikeDiv.TabIndex = 212;
            // 
            // txt_invoiceNo
            // 
            this.txt_invoiceNo.BackColor = System.Drawing.Color.White;
            this.txt_invoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_invoiceNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_invoiceNo.Location = new System.Drawing.Point(437, 104);
            this.txt_invoiceNo.Name = "txt_invoiceNo";
            this.txt_invoiceNo.Size = new System.Drawing.Size(211, 21);
            this.txt_invoiceNo.TabIndex = 209;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label19.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImageIndex = 0;
            this.label19.ImageList = this.img_Label;
            this.label19.Location = new System.Drawing.Point(336, 170);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 21);
            this.label19.TabIndex = 197;
            this.label19.Text = "DHL Account";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_via
            // 
            this.txt_via.BackColor = System.Drawing.Color.White;
            this.txt_via.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_via.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_via.Location = new System.Drawing.Point(437, 148);
            this.txt_via.Name = "txt_via";
            this.txt_via.Size = new System.Drawing.Size(211, 21);
            this.txt_via.TabIndex = 214;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImageIndex = 0;
            this.label8.ImageList = this.img_Label;
            this.label8.Location = new System.Drawing.Point(10, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 21);
            this.label8.TabIndex = 196;
            this.label8.Text = "Se Div";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageIndex = 0;
            this.label9.ImageList = this.img_Label;
            this.label9.Location = new System.Drawing.Point(336, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 21);
            this.label9.TabIndex = 195;
            this.label9.Text = "Via";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_seDiv
            // 
            this.txt_seDiv.BackColor = System.Drawing.Color.White;
            this.txt_seDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_seDiv.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_seDiv.Location = new System.Drawing.Point(111, 148);
            this.txt_seDiv.Name = "txt_seDiv";
            this.txt_seDiv.Size = new System.Drawing.Size(211, 21);
            this.txt_seDiv.TabIndex = 213;
            // 
            // txt_dhlAccount
            // 
            this.txt_dhlAccount.BackColor = System.Drawing.Color.White;
            this.txt_dhlAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dhlAccount.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_dhlAccount.Location = new System.Drawing.Point(437, 170);
            this.txt_dhlAccount.Name = "txt_dhlAccount";
            this.txt_dhlAccount.Size = new System.Drawing.Size(211, 21);
            this.txt_dhlAccount.TabIndex = 215;
            // 
            // txt_amountCd
            // 
            this.txt_amountCd.BackColor = System.Drawing.Color.White;
            this.txt_amountCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_amountCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_amountCd.Location = new System.Drawing.Point(111, 170);
            this.txt_amountCd.Name = "txt_amountCd";
            this.txt_amountCd.Size = new System.Drawing.Size(211, 21);
            this.txt_amountCd.TabIndex = 210;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label18.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ImageIndex = 0;
            this.label18.ImageList = this.img_Label;
            this.label18.Location = new System.Drawing.Point(10, 170);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 21);
            this.label18.TabIndex = 198;
            this.label18.Text = "Amount Code";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_splDdd
            // 
            this.txt_splDdd.BackColor = System.Drawing.Color.White;
            this.txt_splDdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_splDdd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_splDdd.Location = new System.Drawing.Point(437, 192);
            this.txt_splDdd.Name = "txt_splDdd";
            this.txt_splDdd.Size = new System.Drawing.Size(211, 21);
            this.txt_splDdd.TabIndex = 218;
            // 
            // txt_rtaBusan
            // 
            this.txt_rtaBusan.BackColor = System.Drawing.Color.White;
            this.txt_rtaBusan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_rtaBusan.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_rtaBusan.Location = new System.Drawing.Point(111, 192);
            this.txt_rtaBusan.Name = "txt_rtaBusan";
            this.txt_rtaBusan.Size = new System.Drawing.Size(211, 21);
            this.txt_rtaBusan.TabIndex = 217;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ImageIndex = 0;
            this.label14.ImageList = this.img_Label;
            this.label14.Location = new System.Drawing.Point(10, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 21);
            this.label14.TabIndex = 202;
            this.label14.Text = "History No";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_remarks
            // 
            this.txt_remarks.BackColor = System.Drawing.Color.White;
            this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_remarks.Location = new System.Drawing.Point(437, 214);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(211, 21);
            this.txt_remarks.TabIndex = 219;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label15.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ImageIndex = 0;
            this.label15.ImageList = this.img_Label;
            this.label15.Location = new System.Drawing.Point(336, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 21);
            this.label15.TabIndex = 201;
            this.label15.Text = "Remarks";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label16.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ImageIndex = 0;
            this.label16.ImageList = this.img_Label;
            this.label16.Location = new System.Drawing.Point(10, 192);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(100, 21);
            this.label16.TabIndex = 200;
            this.label16.Text = "RTA Busan";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label17.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImageIndex = 0;
            this.label17.ImageList = this.img_Label;
            this.label17.Location = new System.Drawing.Point(336, 192);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(100, 21);
            this.label17.TabIndex = 199;
            this.label17.Text = "Spl ddd";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_historyNo
            // 
            this.txt_historyNo.BackColor = System.Drawing.Color.White;
            this.txt_historyNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_historyNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_historyNo.Location = new System.Drawing.Point(111, 214);
            this.txt_historyNo.Name = "txt_historyNo";
            this.txt_historyNo.Size = new System.Drawing.Size(211, 21);
            this.txt_historyNo.TabIndex = 216;
            // 
            // Pop_BP_Request_Offer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 358);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BP_Request_Offer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리


		private void spd_main_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				this.Grid_CellClickProcess(e.Row, e.Column);
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				this.Grid_DoubleClickProcess(e.Row);
		}

		#endregion

		#region 툴바 메뉴 이벤트 처리

		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_NewProcess();
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Btn_SearchClickProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_SaveProcess();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Tbtn_DeleteProcess();
		}
		#endregion
		
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.Btn_SearchClickProcess();		
		}

		#region 버튼효과

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		private void btn_shipping_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		private void btn_shipping_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}

		#endregion

		#endregion

		#region 공통 메서드

		private void SetHeadInfo(DataTable arg_dt)
		{
//			this.cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;
			cmb_factory.SelectedValue		= arg_dt.Rows[0].ItemArray[0];
			txt_offerNo.Text				= arg_dt.Rows[0].ItemArray[1].ToString();
			cmb_category.SelectedValue		= arg_dt.Rows[0].ItemArray[2];
			txt_modelCd.Text				= arg_dt.Rows[0].ItemArray[3].ToString();
			txt_devCode.Text				= arg_dt.Rows[0].ItemArray[4].ToString();
			txt_prodCode.Text				= arg_dt.Rows[0].ItemArray[5].ToString();
			txt_season.Text					= arg_dt.Rows[0].ItemArray[6].ToString();
			txt_purpose.Text				= arg_dt.Rows[0].ItemArray[7].ToString();
			txt_lcNo.Text					= arg_dt.Rows[0].ItemArray[8].ToString();
			txt_invoiceNo.Text				= arg_dt.Rows[0].ItemArray[9].ToString();
			txt_impCountry.Text				= arg_dt.Rows[0].ItemArray[10].ToString();
			txt_nikeDiv.Text				= arg_dt.Rows[0].ItemArray[11].ToString();
			txt_seDiv.Text					= arg_dt.Rows[0].ItemArray[12].ToString();
			txt_via.Text					= arg_dt.Rows[0].ItemArray[13].ToString();
			txt_amountCd.Text				= arg_dt.Rows[0].ItemArray[14].ToString();
			txt_dhlAccount.Text				= arg_dt.Rows[0].ItemArray[15].ToString();
			txt_rtaBusan.Text				= arg_dt.Rows[0].ItemArray[16].ToString();
			txt_splDdd.Text					= arg_dt.Rows[0].ItemArray[17].ToString();
			txt_historyNo.Text				= arg_dt.Rows[0].ItemArray[18].ToString();
			txt_remarks.Text				= arg_dt.Rows[0].ItemArray[19].ToString();
//			this.cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
		}

		private void ClearHeadInfo()
		{
//			this.cmb_reqNo.SelectedValueChanged -= _cmbReqNoEventHandler;
			cmb_factory.SelectedIndex		= 0;
			txt_offerNo.Text				= "";
			cmb_category.SelectedIndex		= 0;
			txt_modelCd.Text				= "";
			txt_devCode.Text				= "";
			txt_prodCode.Text				= "";
			txt_season.Text					= "";
			txt_purpose.Text				= "";
			txt_lcNo.Text					= "";
			txt_invoiceNo.Text				= "";
			txt_impCountry.Text				= "";
			txt_nikeDiv.Text				= "";
			txt_seDiv.Text					= "";
			txt_via.Text					= "";
			txt_amountCd.Text				= "";
			txt_dhlAccount.Text				= "";
			txt_rtaBusan.Text				= "";
			txt_splDdd.Text					= "";
			txt_historyNo.Text				= "";
			txt_remarks.Text				= "";
//			this.cmb_reqNo.SelectedValueChanged += _cmbReqNoEventHandler;
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // Form Setting
			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Request Offer";
            this.Text = "Request Offer";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
//			spd_main.Set_Spread_Comm("SBP_IMPORT", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			DataTable vDt = null;

			// Factory Combobox Setting
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);

			// Category Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, COM.ComVar.CxCategory);
			COM.ComCtl.Set_ComboList(vDt, cmb_category, 3, 2, false);
			vDt.Dispose();

			// default search proviso
			cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];
			txt_offerNo.Text            = COM.ComVar.Parameter_PopUp[1];

			if(COM.ComVar.Parameter_PopUp[0] != null && COM.ComVar.Parameter_PopUp[1] != null)
				this.Btn_SearchClickProcess();

			// user define variable setting
//			_mainSheet = spd_main.Sheets[0];

			tbtn_Search.Enabled  = false;
			tbtn_Conform.Enabled = false;
			tbtn_Print.Enabled   = false;
		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory			= cmb_factory.SelectedValue.ToString();
				string vOfferNo         = this.txt_offerNo.Text;
							
				DataTable vDt = this.SELECT_SBP_IMPORT(vFactory, vOfferNo);

				if (vDt.Rows.Count > 0 && vDt.Rows.Count < 2)
				{
					this._SaveFlag = true;
					this.SetHeadInfo(vDt);
				}
//				else
//					this.ClearHeadInfo();
				
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Grid_CellClickProcess(int arg_row, int arg_col)
		{
			//			if (arg_col == _styleCol || arg_col == _lotNoCol || arg_col == _shippingYNCol)
			//			{
			//				string vMatType = cmb_materialType.SelectedValue.ToString();
			//
			//				if (vMatType.Equals(ClassLib.ComVar.Upper))
			//					this.GridSetSelectCorrection(_mainSheet.GetSpanCell(arg_row, _styleCdCol));
			//				else
			//					this.GridSetSelectCorrection(_mainSheet.GetSpanCell(arg_row, _shipNoCol));
			//			}
		}

		private void Grid_DoubleClickProcess(int arg_row)
		{
			int vRow			= arg_row;
			int vOfferNo		= (int)ClassLib.TBSBP_IMPORT.IxOFFER_NO;

			COM.ComVar.Parameter_PopUp		= new string[2];

			COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[vRow, vOfferNo].Text;

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		
		private void Tbtn_NewProcess()
		{
			try
			{
				this.ClearHeadInfo();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void Tbtn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				String vOfferNo =  SAVE_SBP_IMPORT(""); 

				_SaveFlag = true;
				this.txt_offerNo.Text = vOfferNo.ToString();
				this.Btn_SearchClickProcess();
//					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			
			}
			catch (Exception ex)
			{			
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Tbtn_DeleteProcess()
		{
			try
			{
				if(this.cmb_factory.SelectedIndex < 1)
				{
					ClassLib.ComFunction.User_Message("Select Factory", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else if(this.txt_offerNo.Text == "")
				{
					ClassLib.ComFunction.User_Message("Select Offer No", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				else
				{
					if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Delete?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
					{
						SAVE_SBP_IMPORT("D"); 

						this.ClearHeadInfo();
					}
					else
					{
						return;
					}
						
				}

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBP_IMPORT
		/// </summary>
		/// <param name="arg_factory">공장</param>
		/// <param name="arg_offerNo">요구일</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_IMPORT(string arg_factory, string arg_offerNo)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_IMPORT.SELECT_SBP_IMPORT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OFFER_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_offerNo;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		/// <summary>
		/// SAVE_SBP_IMPORT : IMPORT 정보 저장
		/// </summary>
		/// <param name="arg_division">구분</param>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_offer_no">요청번호</param>
		/// <param name="arg_category">카테고리</param>
		/// <param name="arg_model_cd">모델코드</param>
		/// <param name="arg_dev_code">DEV 코드</param>
		/// <param name="arg_prod_code">PROD 코드</param>
		/// <param name="arg_season">SEASON</param>
		/// <param name="arg_purpose">용도</param>
		/// <param name="arg_lc_no">LC NO</param>
		/// <param name="arg_invoice_no">INVOICE NO</param>
		/// <param name="arg_imp_county">IMPORT COUNTRY</param>
		/// <param name="arg_nike_div">NIKE DIV</param>
		/// <param name="arg_se_div">SE DIV</param>
		/// <param name="arg_via">VIA</param>
		/// <param name="arg_amount_cd">AMOUNT CD</param>
		/// <param name="arg_dhl_account">DHL ACCOUNT</param>
		/// <param name="arg_rta_busan">RTA BUSAN</param>
		/// <param name="arg_spl_ddd">SPL DDD</param>
		/// <param name="arg_history_no">HISTORY NO</param>
		/// <param name="arg_remarks">비고</param>
		/// <param name="arg_upd_user">사용자</param>
		public string SAVE_SBP_IMPORT(string arg_division)
		{
			
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(23);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBP_IMPORT.SAVE_SBP_IMPORT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0]  = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2]  = "ARG_OFFER_NO";
			MyOraDB.Parameter_Name[3]  = "ARG_CATEGORY";
			MyOraDB.Parameter_Name[4]  = "ARG_MODEL_CD";
			MyOraDB.Parameter_Name[5]  = "ARG_DEV_CODE";
			MyOraDB.Parameter_Name[6]  = "ARG_PROD_CODE";
			MyOraDB.Parameter_Name[7]  = "ARG_SEASON";
			MyOraDB.Parameter_Name[8]  = "ARG_PURPOSE";
			MyOraDB.Parameter_Name[9]  = "ARG_LC_NO";
			MyOraDB.Parameter_Name[10] = "ARG_INVOICE_NO";
			MyOraDB.Parameter_Name[11] = "ARG_IMP_COUNTRY";
			MyOraDB.Parameter_Name[12] = "ARG_NIKE_DEV";
			MyOraDB.Parameter_Name[13] = "ARG_SE_DIV";
			MyOraDB.Parameter_Name[14] = "ARG_VIA";
			MyOraDB.Parameter_Name[15] = "ARG_AMOUNT_CD";
			MyOraDB.Parameter_Name[16] = "ARG_DHL_ACCOUNT";
			MyOraDB.Parameter_Name[17] = "ARG_RTA_BUSAN";
			MyOraDB.Parameter_Name[18] = "ARG_SPL_DDD";
			MyOraDB.Parameter_Name[19] = "ARG_HISTORY_NO";
			MyOraDB.Parameter_Name[20] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[21] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[22] = "OUT_CURSOR";

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
			MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[18] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[19] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[20] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[21] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[22] = (int)OracleType.Cursor;

			//04.DATA 정의
			if(arg_division == "D")
				MyOraDB.Parameter_Values[0]  = "D";
			else
			{
				if(this.txt_offerNo.Text == "") 
					MyOraDB.Parameter_Values[0]  = "I";
				else
					MyOraDB.Parameter_Values[0]  = "U";
			}
			MyOraDB.Parameter_Values[1]   = COM.ComFunction.Empty_Combo(cmb_factory, "");
			MyOraDB.Parameter_Values[2]   = COM.ComFunction.Empty_TextBox(txt_offerNo, "S");
			MyOraDB.Parameter_Values[3]   = COM.ComFunction.Empty_Combo(cmb_category, "");
			MyOraDB.Parameter_Values[4]   = COM.ComFunction.Empty_TextBox(txt_modelCd, "");
			MyOraDB.Parameter_Values[5]   = COM.ComFunction.Empty_TextBox(txt_devCode, "");
			MyOraDB.Parameter_Values[6]   = COM.ComFunction.Empty_TextBox(txt_prodCode, "");
			MyOraDB.Parameter_Values[7]   = COM.ComFunction.Empty_TextBox(txt_season, "");
			MyOraDB.Parameter_Values[8]   = COM.ComFunction.Empty_TextBox(txt_purpose, "");
			MyOraDB.Parameter_Values[9]   = COM.ComFunction.Empty_TextBox(txt_lcNo, "");
			MyOraDB.Parameter_Values[10]  = COM.ComFunction.Empty_TextBox(txt_invoiceNo, "");
			MyOraDB.Parameter_Values[11]  = COM.ComFunction.Empty_TextBox(txt_impCountry, "");
			MyOraDB.Parameter_Values[12]  = COM.ComFunction.Empty_TextBox(txt_nikeDiv, "");
			MyOraDB.Parameter_Values[13]  = COM.ComFunction.Empty_TextBox(txt_seDiv, "");
			MyOraDB.Parameter_Values[14]  = COM.ComFunction.Empty_TextBox(txt_via, "");
			MyOraDB.Parameter_Values[15]  = COM.ComFunction.Empty_TextBox(txt_amountCd, "");
			MyOraDB.Parameter_Values[16]  = COM.ComFunction.Empty_TextBox(txt_dhlAccount, "");
			MyOraDB.Parameter_Values[17]  = COM.ComFunction.Empty_TextBox(txt_rtaBusan, "");
			MyOraDB.Parameter_Values[18]  = COM.ComFunction.Empty_TextBox(txt_splDdd, "");
			MyOraDB.Parameter_Values[19]  = COM.ComFunction.Empty_TextBox(txt_historyNo, "");
			MyOraDB.Parameter_Values[20]  = COM.ComFunction.Empty_TextBox(txt_remarks, "");
			MyOraDB.Parameter_Values[21]  = COM.ComVar.This_User;
			MyOraDB.Parameter_Values[22] = "";
		
			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null ;

			if(MyOraDB.Parameter_Values[0] == "D")
				return "D";
			else
			{
				string division = ds_ret.Tables[0].Rows[0].ItemArray[0].ToString();
				return ds_ret.Tables[0].Rows[0].ItemArray[0].ToString();
			}

			
		}

		#endregion

		private void btn_Return_Click(object sender, System.EventArgs e)
		{
			if( _SaveFlag == true )
			{
				_CancelFlag = false;

				COM.ComVar.Parameter_PopUp		= new string[2];

				COM.ComVar.Parameter_PopUp[0]	= cmb_factory.SelectedValue.ToString();
				COM.ComVar.Parameter_PopUp[1]	= this.txt_offerNo.Text;

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				ClassLib.ComFunction.User_Message("No Value Saved", "Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CancelFlag = true;
			this.Close();
		}

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

	}
}

