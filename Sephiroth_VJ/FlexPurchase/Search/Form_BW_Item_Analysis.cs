using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing; 
using System.Windows.Forms;
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
using FarPoint.Win.Spread.CellType;

namespace FlexPurchase.Search
{
	public class Form_BW_Item_Analysis : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1;  
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory; 
		private System.Windows.Forms.Panel pnl_low;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_ToDate;
		private System.Windows.Forms.DateTimePicker dpick_FromDate;
		private System.Windows.Forms.Label lbl_ShipDate; 
		private System.Windows.Forms.GroupBox gb_Result;
		private System.Windows.Forms.TextBox txt_Result; 
		private C1.Win.C1List.C1Combo cmb_ShipType;
		private System.Windows.Forms.Label lbl_ShipType;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1List.C1Combo cmb_ItemDiv;
		private System.Windows.Forms.Label lbl_ItemDiv; 

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private C1.Win.C1List.C1Combo cmb_OBSId;
		private System.Windows.Forms.Label lbl_OBSId;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private System.Windows.Forms.Label lbl_OBSType;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style; 
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		#endregion

		#region 생성자 / 소멸자

		public Form_BW_Item_Analysis()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();
		}

		public Form_BW_Item_Analysis(string factory, string ship_type, string obs_id, string obs_type, string item_group, string item_gcode, string division, string item_code, string item_name, string style_cd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();
			
			cmb_Factory.SelectedValue = factory;
			cmb_ShipType.SelectedValue = ship_type;
			cmb_OBSId.SelectedValue   = obs_id;
			cmb_OBSType.SelectedValue = obs_type;
			
			cmb_ItemDiv.SelectedValue   = division;
			cmb_itemGroup.SelectedValue = item_group;
			_itemGroupCode				= item_gcode;
			txt_itemCode.Text			= item_code;
			txt_itemName.Text			= item_name;
			txt_StyleCd.Text			= style_cd;
			Set_StyleCode(); 

			string[] parameter = new string[] {factory, style_cd.Replace("-", ""), obs_id, obs_type }; 
			DataTable dt_ret = SELECT_SHIPPING_AREA(parameter); 
			 
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd"); 
				dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);  
			}
			else
			{
				dpick_FromDate.Value  = Convert.ToDateTime(dt_ret.Rows[0].ItemArray[0]);
				dpick_ToDate.Value    = Convert.ToDateTime(dt_ret.Rows[0].ItemArray[1]);
			}
 
			Search();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BW_Item_Analysis));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.gb_Result = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_OBSId = new C1.Win.C1List.C1Combo();
            this.lbl_OBSId = new System.Windows.Forms.Label();
            this.cmb_OBSType = new C1.Win.C1List.C1Combo();
            this.lbl_OBSType = new System.Windows.Forms.Label();
            this.cmb_ItemDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ItemDiv = new System.Windows.Forms.Label();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_ToDate = new System.Windows.Forms.DateTimePicker();
            this.dpick_FromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_ShipDate = new System.Windows.Forms.Label();
            this.cmb_ShipType = new C1.Win.C1List.C1Combo();
            this.lbl_ShipType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.spd_main = new COM.SSP();
            this.sheetView1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            this.gb_Result.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).BeginInit();
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
            this.c1Sizer1.BorderWidth = 0;
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "19.9652777777778:False:True;66.3194444444444:False:False;12.3263888888889:False:T" +
                "rue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.gb_Result);
            this.pnl_low.Location = new System.Drawing.Point(8, 505);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1008, 71);
            this.pnl_low.TabIndex = 175;
            // 
            // gb_Result
            // 
            this.gb_Result.Controls.Add(this.txt_Result);
            this.gb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Result.Location = new System.Drawing.Point(0, 0);
            this.gb_Result.Name = "gb_Result";
            this.gb_Result.Size = new System.Drawing.Size(1008, 71);
            this.gb_Result.TabIndex = 0;
            this.gb_Result.TabStop = false;
            this.gb_Result.Text = "Result";
            // 
            // txt_Result
            // 
            this.txt_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Result.Location = new System.Drawing.Point(8, 18);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.Size = new System.Drawing.Size(984, 48);
            this.txt_Result.TabIndex = 0;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.txt_StyleCd);
            this.pnl_head.Controls.Add(this.lbl_Style);
            this.pnl_head.Controls.Add(this.cmb_OBSId);
            this.pnl_head.Controls.Add(this.lbl_OBSId);
            this.pnl_head.Controls.Add(this.cmb_OBSType);
            this.pnl_head.Controls.Add(this.lbl_OBSType);
            this.pnl_head.Controls.Add(this.cmb_ItemDiv);
            this.pnl_head.Controls.Add(this.lbl_ItemDiv);
            this.pnl_head.Controls.Add(this.txt_itemGroup);
            this.pnl_head.Controls.Add(this.cmb_itemGroup);
            this.pnl_head.Controls.Add(this.txt_itemName);
            this.pnl_head.Controls.Add(this.txt_itemCode);
            this.pnl_head.Controls.Add(this.lbl_itemgroup);
            this.pnl_head.Controls.Add(this.btn_groupSearch);
            this.pnl_head.Controls.Add(this.lbl_item);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.dpick_ToDate);
            this.pnl_head.Controls.Add(this.dpick_FromDate);
            this.pnl_head.Controls.Add(this.lbl_ShipDate);
            this.pnl_head.Controls.Add(this.cmb_ShipType);
            this.pnl_head.Controls.Add(this.lbl_ShipType);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_Factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 115);
            this.pnl_head.TabIndex = 2;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style1;
            this.cmb_StyleCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_StyleCd.ColumnCaptionHeight = 18;
            this.cmb_StyleCd.ColumnFooterHeight = 18;
            this.cmb_StyleCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_StyleCd.ContentHeight = 17;
            this.cmb_StyleCd.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_StyleCd.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_StyleCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StyleCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_StyleCd.EditorHeight = 17;
            this.cmb_StyleCd.EvenRowStyle = style2;
            this.cmb_StyleCd.FooterStyle = style3;
            this.cmb_StyleCd.HeadingStyle = style4;
            this.cmb_StyleCd.HighLightRowStyle = style5;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(836, 84);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style6;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style7;
            this.cmb_StyleCd.Size = new System.Drawing.Size(148, 21);
            this.cmb_StyleCd.Style = style8;
            this.cmb_StyleCd.TabIndex = 557;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(760, 84);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
            this.txt_StyleCd.TabIndex = 558;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // lbl_Style
            // 
            this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(662, 84);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 556;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OBSId
            // 
            this.cmb_OBSId.AddItemSeparator = ';';
            this.cmb_OBSId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSId.Caption = "";
            this.cmb_OBSId.CaptionHeight = 17;
            this.cmb_OBSId.CaptionStyle = style9;
            this.cmb_OBSId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSId.ColumnCaptionHeight = 18;
            this.cmb_OBSId.ColumnFooterHeight = 18;
            this.cmb_OBSId.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSId.ContentHeight = 17;
            this.cmb_OBSId.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSId.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSId.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OBSId.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSId.EditorHeight = 17;
            this.cmb_OBSId.EvenRowStyle = style10;
            this.cmb_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSId.FooterStyle = style11;
            this.cmb_OBSId.HeadingStyle = style12;
            this.cmb_OBSId.HighLightRowStyle = style13;
            this.cmb_OBSId.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSId.Images"))));
            this.cmb_OBSId.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSId.ItemHeight = 15;
            this.cmb_OBSId.Location = new System.Drawing.Point(109, 84);
            this.cmb_OBSId.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSId.MaxDropDownItems = ((short)(5));
            this.cmb_OBSId.MaxLength = 32767;
            this.cmb_OBSId.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSId.Name = "cmb_OBSId";
            this.cmb_OBSId.OddRowStyle = style14;
            this.cmb_OBSId.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSId.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSId.SelectedStyle = style15;
            this.cmb_OBSId.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSId.Style = style16;
            this.cmb_OBSId.TabIndex = 554;
            this.cmb_OBSId.PropBag = resources.GetString("cmb_OBSId.PropBag");
            // 
            // lbl_OBSId
            // 
            this.lbl_OBSId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSId.ImageIndex = 0;
            this.lbl_OBSId.ImageList = this.img_Label;
            this.lbl_OBSId.Location = new System.Drawing.Point(8, 84);
            this.lbl_OBSId.Name = "lbl_OBSId";
            this.lbl_OBSId.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSId.TabIndex = 555;
            this.lbl_OBSId.Text = "DPO";
            this.lbl_OBSId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OBSType
            // 
            this.cmb_OBSType.AddItemSeparator = ';';
            this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSType.Caption = "";
            this.cmb_OBSType.CaptionHeight = 17;
            this.cmb_OBSType.CaptionStyle = style17;
            this.cmb_OBSType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OBSType.ColumnCaptionHeight = 18;
            this.cmb_OBSType.ColumnFooterHeight = 18;
            this.cmb_OBSType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OBSType.ContentHeight = 17;
            this.cmb_OBSType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OBSType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OBSType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OBSType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OBSType.EditorHeight = 17;
            this.cmb_OBSType.EvenRowStyle = style18;
            this.cmb_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.FooterStyle = style19;
            this.cmb_OBSType.HeadingStyle = style20;
            this.cmb_OBSType.HighLightRowStyle = style21;
            this.cmb_OBSType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSType.Images"))));
            this.cmb_OBSType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSType.ItemHeight = 15;
            this.cmb_OBSType.Location = new System.Drawing.Point(437, 84);
            this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSType.MaxDropDownItems = ((short)(5));
            this.cmb_OBSType.MaxLength = 32767;
            this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSType.Name = "cmb_OBSType";
            this.cmb_OBSType.OddRowStyle = style22;
            this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.SelectedStyle = style23;
            this.cmb_OBSType.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSType.Style = style24;
            this.cmb_OBSType.TabIndex = 552;
            this.cmb_OBSType.PropBag = resources.GetString("cmb_OBSType.PropBag");
            // 
            // lbl_OBSType
            // 
            this.lbl_OBSType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSType.ImageIndex = 0;
            this.lbl_OBSType.ImageList = this.img_Label;
            this.lbl_OBSType.Location = new System.Drawing.Point(336, 84);
            this.lbl_OBSType.Name = "lbl_OBSType";
            this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSType.TabIndex = 553;
            this.lbl_OBSType.Text = "OBS Type";
            this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ItemDiv
            // 
            this.cmb_ItemDiv.AddItemSeparator = ';';
            this.cmb_ItemDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ItemDiv.Caption = "";
            this.cmb_ItemDiv.CaptionHeight = 17;
            this.cmb_ItemDiv.CaptionStyle = style25;
            this.cmb_ItemDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ItemDiv.ColumnCaptionHeight = 18;
            this.cmb_ItemDiv.ColumnFooterHeight = 18;
            this.cmb_ItemDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ItemDiv.ContentHeight = 17;
            this.cmb_ItemDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ItemDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ItemDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ItemDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ItemDiv.EditorHeight = 17;
            this.cmb_ItemDiv.EvenRowStyle = style26;
            this.cmb_ItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ItemDiv.FooterStyle = style27;
            this.cmb_ItemDiv.HeadingStyle = style28;
            this.cmb_ItemDiv.HighLightRowStyle = style29;
            this.cmb_ItemDiv.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ItemDiv.Images"))));
            this.cmb_ItemDiv.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_ItemDiv.ItemHeight = 15;
            this.cmb_ItemDiv.Location = new System.Drawing.Point(437, 62);
            this.cmb_ItemDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_ItemDiv.MaxDropDownItems = ((short)(5));
            this.cmb_ItemDiv.MaxLength = 32767;
            this.cmb_ItemDiv.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ItemDiv.Name = "cmb_ItemDiv";
            this.cmb_ItemDiv.OddRowStyle = style30;
            this.cmb_ItemDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ItemDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ItemDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ItemDiv.SelectedStyle = style31;
            this.cmb_ItemDiv.Size = new System.Drawing.Size(210, 21);
            this.cmb_ItemDiv.Style = style32;
            this.cmb_ItemDiv.TabIndex = 550;
            this.cmb_ItemDiv.SelectedValueChanged += new System.EventHandler(this.cmb_ItemDiv_SelectedValueChanged);
            this.cmb_ItemDiv.PropBag = resources.GetString("cmb_ItemDiv.PropBag");
            // 
            // lbl_ItemDiv
            // 
            this.lbl_ItemDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ItemDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ItemDiv.ImageIndex = 0;
            this.lbl_ItemDiv.ImageList = this.img_Label;
            this.lbl_ItemDiv.Location = new System.Drawing.Point(336, 62);
            this.lbl_ItemDiv.Name = "lbl_ItemDiv";
            this.lbl_ItemDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_ItemDiv.TabIndex = 551;
            this.lbl_ItemDiv.Text = "Item Division";
            this.lbl_ItemDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(861, 40);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.txt_itemGroup.TabIndex = 548;
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
            this.cmb_itemGroup.ContentHeight = 17;
            this.cmb_itemGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_itemGroup.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_itemGroup.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_itemGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_itemGroup.EditorHeight = 17;
            this.cmb_itemGroup.EvenRowStyle = style34;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style35;
            this.cmb_itemGroup.HeadingStyle = style36;
            this.cmb_itemGroup.HighLightRowStyle = style37;
            this.cmb_itemGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_itemGroup.Images"))));
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(760, 40);
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
            this.cmb_itemGroup.Size = new System.Drawing.Size(100, 21);
            this.cmb_itemGroup.Style = style40;
            this.cmb_itemGroup.TabIndex = 547;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(820, 62);
            this.txt_itemName.MaxLength = 500;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(163, 21);
            this.txt_itemName.TabIndex = 549;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(760, 62);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 545;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(662, 40);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 543;
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
            this.btn_groupSearch.Location = new System.Drawing.Point(961, 40);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 546;
            this.btn_groupSearch.Tag = "Search";
            this.btn_groupSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_groupSearch.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_groupSearch.Click += new System.EventHandler(this.btn_groupSearch_Click);
            this.btn_groupSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_groupSearch.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_groupSearch.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.ImageIndex = 0;
            this.lbl_item.ImageList = this.img_Label;
            this.lbl_item.Location = new System.Drawing.Point(662, 62);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 544;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style41;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style42;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style43;
            this.cmb_Factory.HeadingStyle = style44;
            this.cmb_Factory.HighLightRowStyle = style45;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style46;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style47;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
            this.cmb_Factory.Style = style48;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(536, 42);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 542;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_ToDate
            // 
            this.dpick_ToDate.CustomFormat = "";
            this.dpick_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToDate.Location = new System.Drawing.Point(549, 40);
            this.dpick_ToDate.Name = "dpick_ToDate";
            this.dpick_ToDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_ToDate.TabIndex = 541;
            // 
            // dpick_FromDate
            // 
            this.dpick_FromDate.CustomFormat = "";
            this.dpick_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromDate.Location = new System.Drawing.Point(437, 40);
            this.dpick_FromDate.Name = "dpick_FromDate";
            this.dpick_FromDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_FromDate.TabIndex = 540;
            // 
            // lbl_ShipDate
            // 
            this.lbl_ShipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ShipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipDate.ImageIndex = 1;
            this.lbl_ShipDate.ImageList = this.img_Label;
            this.lbl_ShipDate.Location = new System.Drawing.Point(336, 40);
            this.lbl_ShipDate.Name = "lbl_ShipDate";
            this.lbl_ShipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_ShipDate.TabIndex = 539;
            this.lbl_ShipDate.Text = "Ship Date";
            this.lbl_ShipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_ShipType
            // 
            this.cmb_ShipType.AddItemSeparator = ';';
            this.cmb_ShipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_ShipType.Caption = "";
            this.cmb_ShipType.CaptionHeight = 17;
            this.cmb_ShipType.CaptionStyle = style49;
            this.cmb_ShipType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_ShipType.ColumnCaptionHeight = 18;
            this.cmb_ShipType.ColumnFooterHeight = 18;
            this.cmb_ShipType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_ShipType.ContentHeight = 17;
            this.cmb_ShipType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_ShipType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_ShipType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_ShipType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_ShipType.EditorHeight = 17;
            this.cmb_ShipType.EvenRowStyle = style50;
            this.cmb_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ShipType.FooterStyle = style51;
            this.cmb_ShipType.HeadingStyle = style52;
            this.cmb_ShipType.HighLightRowStyle = style53;
            this.cmb_ShipType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_ShipType.Images"))));
            this.cmb_ShipType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_ShipType.ItemHeight = 15;
            this.cmb_ShipType.Location = new System.Drawing.Point(109, 62);
            this.cmb_ShipType.MatchEntryTimeout = ((long)(2000));
            this.cmb_ShipType.MaxDropDownItems = ((short)(5));
            this.cmb_ShipType.MaxLength = 32767;
            this.cmb_ShipType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_ShipType.Name = "cmb_ShipType";
            this.cmb_ShipType.OddRowStyle = style54;
            this.cmb_ShipType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_ShipType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_ShipType.SelectedStyle = style55;
            this.cmb_ShipType.Size = new System.Drawing.Size(210, 21);
            this.cmb_ShipType.Style = style56;
            this.cmb_ShipType.TabIndex = 537;
            this.cmb_ShipType.SelectedValueChanged += new System.EventHandler(this.cmb_ShipType_SelectedValueChanged);
            this.cmb_ShipType.PropBag = resources.GetString("cmb_ShipType.PropBag");
            // 
            // lbl_ShipType
            // 
            this.lbl_ShipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ShipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ShipType.ImageIndex = 1;
            this.lbl_ShipType.ImageList = this.img_Label;
            this.lbl_ShipType.Location = new System.Drawing.Point(8, 62);
            this.lbl_ShipType.Name = "lbl_ShipType";
            this.lbl_ShipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_ShipType.TabIndex = 538;
            this.lbl_ShipType.Text = "Ship Type";
            this.lbl_ShipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.TabIndex = 393;
            this.label2.Text = "      Shipping Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 1;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 50;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 97);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(920, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(8, 119);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 382);
            this.spd_main.TabIndex = 174;
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Form_BW_Item_Analysis
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BW_Item_Analysis";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_low.ResumeLayout(false);
            this.gb_Result.ResumeLayout(false);
            this.gb_Result.PerformLayout();
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ItemDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ShipType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheetView1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 툴바 메뉴 이벤트 처리
		
		 
 
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{

			try
			{ 
				Clear(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_New_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		
		}

		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
		
			try
			{ 
				this.Cursor = Cursors.WaitCursor;

				Search();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Search_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				Print();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "tbtn_Print_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#endregion

		#region 컨트롤 이벤트 처리

		   
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			
			try
			{
				if(cmb_Factory.SelectedIndex == -1) return;

				DataTable dt_ret; 
				
				// dpo set
				// division = 1 : dp, division = 2 : dpo
				dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), "2");
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSId, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

				// obs type set
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBSType);
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 

				dt_ret.Dispose(); 

				spd_main.ClearAll();
				txt_Result.Text = "";

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	


//			try
//			{
//
//				if(cmb_Factory.SelectedIndex == -1) return;
//
//				DataTable dt_ret;
//
//				// ship type set
//				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxMRPShipType);
//				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ShipType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
//				cmb_ShipType.SelectedValue = "11";
// 
//				//그룹타입 콤보쿼리 
//				dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
//				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  
//
//				// style item division set
//				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxMRPItemDivision);
//				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_ItemDiv, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
//
//
//				dt_ret.Dispose(); 
//
//
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//			}	

		}

		private void cmb_ShipType_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd"); 
				dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);

				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ShipType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	



		}

		private void cmb_ItemDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{

				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_ItemDiv_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

				spd_main.ClearAll();


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

				spd_main.ClearAll();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
			
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		
 

		#endregion  

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Item Analysis";
            lbl_MainTitle.Text = "Item Analysis";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBW_ITEM_SEARCH", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			
			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			

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
						
						for ( int j = vCol ; j <= spd_main.ActiveSheet.ColumnCount ; j++)
						{
							if(j == spd_main.ActiveSheet.ColumnCount)
							{
								spd_main.ActiveSheet.ColumnHeader.Cells[1, vCol].ColumnSpan = vCnt;
								vCol = j + 1;
								break;
							}
							else
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
							} // end if(j == spd_main.ActiveSheet.ColumnCount - 1)

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

 

		/// <summary>
		/// Init_Control : combobox setting
		/// </summary>
		private void Init_Control()
		{
			DataTable vDt;


			// toolbar button disable setting
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 


			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);  

			// factory set  
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
		  
			// Item Group
			vDt = ClassLib.ComFunction.Select_GroupTypeCode();
			COM.ComCtl.Set_ComboList(vDt, cmb_itemGroup, 0, 1, false, 45, 80);
			cmb_itemGroup.SelectedIndex = 0;
			vDt.Dispose();

			// ship type set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPShipType);
			COM.ComCtl.Set_ComboList(vDt, cmb_ShipType, 1, 2, true);
			cmb_ShipType.SelectedValue = (cmb_ShipType.Tag == null) ? "11" : cmb_ShipType.Tag;
			vDt.Dispose();

			// item division set
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxMRPItemDivision);
			COM.ComCtl.Set_ComboList(vDt, cmb_ItemDiv, 1, 2, true, 45, 70);
			cmb_ItemDiv.SelectedIndex = 1;
			vDt.Dispose();

			vDt.Dispose();  


		}

 
		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			//cmb_ShipType.SelectedIndex = -1;
			cmb_ShipType.SelectedValue = "11";
			cmb_ItemDiv.SelectedIndex = -1;
			 
			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);  

			cmb_itemGroup.SelectedIndex = -1;
			txt_itemGroup.Text = "";
			txt_itemCode.Text = "";
			txt_itemName.Text = "";


			spd_main.ClearAll();  

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_ShipType};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;


			string factory        = cmb_Factory.SelectedValue.ToString();
			string ship_type      = cmb_ShipType.SelectedValue.ToString();
			string from_date      = dpick_FromDate.Value.ToString("yyyyMMdd") ;
			string to_date        = dpick_ToDate.Value.ToString("yyyyMMdd") ;
			string item_group     = _itemGroupCode;
			string item_cd        = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " ");
			string item_name      = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " ");
			string style_item_div = ClassLib.ComFunction.Empty_Combo(cmb_ItemDiv, " ");  
			string obs_id		  = ClassLib.ComFunction.Empty_Combo(cmb_OBSId, " ");  
			string obs_type       = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " ");  
			string style_cd       = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");  

			string[] parameter = new string[] {factory, ship_type, from_date, to_date, item_group, item_cd, item_name, style_item_div, obs_id, obs_type, style_cd}; 

			DataTable dt_ret = SELECT_ITEM_ANALYSIS(parameter); 
			 
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll();   
			}
 

			spd_main.Display_Grid(dt_ret);  


			// column merge 
			ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBW_ITEM_SEARCH.IxSHIP_YMD,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxSTYLE_CD,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxSTYLE_NAME,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxOBS_TYPE,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxITEM_NAME,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxSPEC_NAME,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxCOLOR_NAME,
																  (int)ClassLib.TBSBW_ITEM_SEARCH.IxITEM_UNIT } );


   

		}  


		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{


//			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};   
//			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
//			if(! essential_check) return; 
//
//			string factory = cmb_Factory.SelectedValue.ToString();
//			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");
//			string from = cmb_From.SelectedValue.ToString();
//			string to = cmb_To.SelectedValue.ToString();
//			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, " ");  
//
//
//
//			Pop_BM_Print_Type vPop = new Pop_BM_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);
//
//			string sPara = "";
//
//			sPara  = " /rp ";
//			sPara += "'" + factory  + "' ";
//			sPara += "'" + style_cd + "' ";
//			sPara += "'" + from     + "' ";
//			sPara += "'" + to		+ "' ";
//			sPara += "'" + import   + "' ";  
//
//
//
//			string sDir = "";
//			string report_text = ""; 
//
//			sDir = Application.StartupPath + @"\Report\MRP\Form_BW_Item_Analysis_DP.mrd";
//			report_text = "Local/LLT Monitoring By Style (DP)"; 
//
//			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
//			MyReport.Text = report_text;
//			MyReport.Show();

			 


			  

		}



		#endregion  
		
		#endregion

		#region DB Connect

		
		/// <summary>
		/// SELECT_ITEM_ANALYSIS : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_ITEM_ANALYSIS(string[] arg_parameter)
		{

			try 
			{

				// job factory Webservice 로 변경 
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.DSFactory); 
				

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(12);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_MONITORING.SELECT_ITEM_ANALYSIS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_ITEM_GROUP";
				MyOraDB.Parameter_Name[5] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[6] = "ARG_ITEM_NAME";
				MyOraDB.Parameter_Name[7] = "ARG_ITEM_DIVISION";
				MyOraDB.Parameter_Name[8] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[9] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[10]= "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[11]= "OUT_CURSOR";  

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
				MyOraDB.Parameter_Type[10]= (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[11]= (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = arg_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_parameter[6];
				MyOraDB.Parameter_Values[7] = arg_parameter[7];
				MyOraDB.Parameter_Values[8] = arg_parameter[8];
				MyOraDB.Parameter_Values[9] = arg_parameter[9];
				MyOraDB.Parameter_Values[10]= arg_parameter[10];
				MyOraDB.Parameter_Values[11]= "";

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				
				// user factory Webservice 로 변경
				ClassLib.ComFunction.Change_WebService_URL(ClassLib.ComVar.This_Factory);  
				
				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_ITEM_ANALYSIS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}

 
		/// <summary>
		/// SELECT_SHIPPING_AREA : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_SHIPPING_AREA(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_MONITORING.SELECT_SBW_SHIPPING_AREA";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
				MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[4] = "OUT_CURSOR";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = "";

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SHIPPING_AREA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		#endregion	 

		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				if(e.KeyCode != Keys.Enter) return; 
				Set_StyleCode(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "txt_StyleCd_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Set_StyleCode : 스타일 콤보 세팅
		/// </summary>
		private void Set_StyleCode()
		{
			//-------------------------------------------------------------------------
			// 기타 콘트롤 초기화 
			cmb_StyleCd.SelectedIndex = -1;  
			//-------------------------------------------------------------------------

			DataTable dt_ret;
			
			if(txt_StyleCd.Text.Trim().Equals("") ) 
			{
				cmb_StyleCd.SelectedIndex = -1;
				cmb_StyleCd.DataSource = null;
				return;
			}

			dt_ret = ClassLib.ComFunction.Select_SDC_STYLE(ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ") ); 
				 
			//0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name
			ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, false, 80, 200); 

			string stylecd = "";
			int exist_index = -1;

			stylecd = txt_StyleCd.Text.Trim();

			exist_index = txt_StyleCd.Text.IndexOf("-", 0);

			if(exist_index == -1 && stylecd.Length == 9)
			{
				stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
			}
 
			cmb_StyleCd.SelectedValue = stylecd;

			dt_ret.Dispose();

		}

	
		

		
 


	}
}

