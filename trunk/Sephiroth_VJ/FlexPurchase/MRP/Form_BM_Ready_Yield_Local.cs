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
	/**
	 * 주석 삭제 요망 - 주석 처리된 블럭 삭제 해 주세요.
	 */

	public class Form_BM_Ready_Yield_Local : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_Option;
		private System.Windows.Forms.Label lbl_DP_DPO;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Division;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.Label lbl_reqUser;
		private System.Windows.Forms.TextBox txt_itemGroup;
		private System.Windows.Forms.TextBox txt_itemName;
		private System.Windows.Forms.TextBox txt_itemCode;
		private System.Windows.Forms.Label lbl_itemgroup;
		private System.Windows.Forms.Label btn_groupSearch;
		private System.Windows.Forms.Label lbl_item;
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private C1.Win.C1List.C1Combo cmb_SearchOption;
		private C1.Win.C1List.C1Combo cmb_LocalDivision;
		private C1.Win.C1List.C1Combo cmb_itemGroup;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private FarPoint.Win.Spread.SheetView sheetView1;  

		private COM.SSP spd_main;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자 / 소멸자

		public Form_BM_Ready_Yield_Local()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Ready_Yield_Local));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_itemGroup = new System.Windows.Forms.TextBox();
            this.cmb_itemGroup = new C1.Win.C1List.C1Combo();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_itemCode = new System.Windows.Forms.TextBox();
            this.lbl_itemgroup = new System.Windows.Forms.Label();
            this.btn_groupSearch = new System.Windows.Forms.Label();
            this.lbl_item = new System.Windows.Forms.Label();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.lbl_reqUser = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.cmb_LocalDivision = new C1.Win.C1List.C1Combo();
            this.lbl_Division = new System.Windows.Forms.Label();
            this.cmb_To = new C1.Win.C1List.C1Combo();
            this.cmb_From = new C1.Win.C1List.C1Combo();
            this.lbl_DP_DPO = new System.Windows.Forms.Label();
            this.cmb_SearchOption = new C1.Win.C1List.C1Combo();
            this.lbl_Option = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
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
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LocalDivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            // tbtn_New
            // 
            this.tbtn_New.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_New_Click);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "19.7916666666667:False:True;78.125:False:False;0.694444444444444:False:True;\t0.39" +
                "3700787401575:False:True;98.4251968503937:False:False;0.393700787401575:False:Tr" +
                "ue;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
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
            this.pnl_head.Controls.Add(this.cmb_purUser);
            this.pnl_head.Controls.Add(this.lbl_reqUser);
            this.pnl_head.Controls.Add(this.txt_vendorCode);
            this.pnl_head.Controls.Add(this.cmb_vendor);
            this.pnl_head.Controls.Add(this.lbl_vendor);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.cmb_LocalDivision);
            this.pnl_head.Controls.Add(this.lbl_Division);
            this.pnl_head.Controls.Add(this.cmb_To);
            this.pnl_head.Controls.Add(this.cmb_From);
            this.pnl_head.Controls.Add(this.lbl_DP_DPO);
            this.pnl_head.Controls.Add(this.cmb_SearchOption);
            this.pnl_head.Controls.Add(this.lbl_Option);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.lbl_Style);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.lbl_Factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 114);
            this.pnl_head.TabIndex = 2;
            // 
            // txt_itemGroup
            // 
            this.txt_itemGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemGroup.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemGroup.Location = new System.Drawing.Point(872, 62);
            this.txt_itemGroup.MaxLength = 10;
            this.txt_itemGroup.Name = "txt_itemGroup";
            this.txt_itemGroup.ReadOnly = true;
            this.txt_itemGroup.Size = new System.Drawing.Size(96, 21);
            this.txt_itemGroup.TabIndex = 547;
            // 
            // cmb_itemGroup
            // 
            this.cmb_itemGroup.AddItemCols = 0;
            this.cmb_itemGroup.AddItemSeparator = ';';
            this.cmb_itemGroup.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_itemGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_itemGroup.Caption = "";
            this.cmb_itemGroup.CaptionHeight = 17;
            this.cmb_itemGroup.CaptionStyle = style73;
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
            this.cmb_itemGroup.EvenRowStyle = style74;
            this.cmb_itemGroup.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_itemGroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_itemGroup.FooterStyle = style75;
            this.cmb_itemGroup.GapHeight = 2;
            this.cmb_itemGroup.HeadingStyle = style76;
            this.cmb_itemGroup.HighLightRowStyle = style77;
            this.cmb_itemGroup.ItemHeight = 15;
            this.cmb_itemGroup.Location = new System.Drawing.Point(781, 62);
            this.cmb_itemGroup.MatchEntryTimeout = ((long)(2000));
            this.cmb_itemGroup.MaxDropDownItems = ((short)(5));
            this.cmb_itemGroup.MaxLength = 32767;
            this.cmb_itemGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_itemGroup.Name = "cmb_itemGroup";
            this.cmb_itemGroup.OddRowStyle = style78;
            this.cmb_itemGroup.PartialRightColumn = false;
            this.cmb_itemGroup.PropBag = resources.GetString("cmb_itemGroup.PropBag");
            this.cmb_itemGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_itemGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_itemGroup.SelectedStyle = style79;
            this.cmb_itemGroup.Size = new System.Drawing.Size(90, 21);
            this.cmb_itemGroup.Style = style80;
            this.cmb_itemGroup.TabIndex = 546;
            this.cmb_itemGroup.SelectedValueChanged += new System.EventHandler(this.cmb_itemGroup_SelectedValueChanged);
            // 
            // txt_itemName
            // 
            this.txt_itemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemName.Location = new System.Drawing.Point(841, 84);
            this.txt_itemName.MaxLength = 10;
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.Size = new System.Drawing.Size(150, 21);
            this.txt_itemName.TabIndex = 548;
            // 
            // txt_itemCode
            // 
            this.txt_itemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_itemCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_itemCode.Location = new System.Drawing.Point(781, 84);
            this.txt_itemCode.MaxLength = 10;
            this.txt_itemCode.Name = "txt_itemCode";
            this.txt_itemCode.Size = new System.Drawing.Size(59, 21);
            this.txt_itemCode.TabIndex = 544;
            // 
            // lbl_itemgroup
            // 
            this.lbl_itemgroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_itemgroup.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemgroup.ImageIndex = 0;
            this.lbl_itemgroup.ImageList = this.img_Label;
            this.lbl_itemgroup.Location = new System.Drawing.Point(680, 62);
            this.lbl_itemgroup.Name = "lbl_itemgroup";
            this.lbl_itemgroup.Size = new System.Drawing.Size(100, 21);
            this.lbl_itemgroup.TabIndex = 542;
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
            this.btn_groupSearch.Location = new System.Drawing.Point(969, 62);
            this.btn_groupSearch.Name = "btn_groupSearch";
            this.btn_groupSearch.Size = new System.Drawing.Size(24, 21);
            this.btn_groupSearch.TabIndex = 545;
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
            this.lbl_item.Location = new System.Drawing.Point(680, 84);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 543;
            this.lbl_item.Text = "Item";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style81;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 17;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 17;
            this.cmb_purUser.EvenRowStyle = style82;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style83;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style84;
            this.cmb_purUser.HighLightRowStyle = style85;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(781, 40);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style86;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style87;
            this.cmb_purUser.Size = new System.Drawing.Size(210, 21);
            this.cmb_purUser.Style = style88;
            this.cmb_purUser.TabIndex = 541;
            // 
            // lbl_reqUser
            // 
            this.lbl_reqUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reqUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqUser.ImageIndex = 0;
            this.lbl_reqUser.ImageList = this.img_Label;
            this.lbl_reqUser.Location = new System.Drawing.Point(680, 40);
            this.lbl_reqUser.Name = "lbl_reqUser";
            this.lbl_reqUser.Size = new System.Drawing.Size(100, 21);
            this.lbl_reqUser.TabIndex = 540;
            this.lbl_reqUser.Text = "Purchase User";
            this.lbl_reqUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_vendorCode.Location = new System.Drawing.Point(445, 84);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(75, 21);
            this.txt_vendorCode.TabIndex = 537;
            this.txt_vendorCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_vendorCode_KeyUp);
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemCols = 0;
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_vendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style89;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 17;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 17;
            this.cmb_vendor.EvenRowStyle = style90;
            this.cmb_vendor.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style91;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style92;
            this.cmb_vendor.HighLightRowStyle = style93;
            this.cmb_vendor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(521, 84);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style94;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style95;
            this.cmb_vendor.Size = new System.Drawing.Size(134, 21);
            this.cmb_vendor.Style = style96;
            this.cmb_vendor.TabIndex = 538;
            this.cmb_vendor.SelectedValueChanged += new System.EventHandler(this.cmb_vendor_SelectedValueChanged);
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(344, 84);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 539;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style97;
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
            this.cmb_StyleCd.EvenRowStyle = style98;
            this.cmb_StyleCd.FooterStyle = style99;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style100;
            this.cmb_StyleCd.HighLightRowStyle = style101;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(445, 62);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style102;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style103;
            this.cmb_StyleCd.Size = new System.Drawing.Size(210, 21);
            this.cmb_StyleCd.Style = style104;
            this.cmb_StyleCd.TabIndex = 535;
            // 
            // cmb_LocalDivision
            // 
            this.cmb_LocalDivision.AddItemCols = 0;
            this.cmb_LocalDivision.AddItemSeparator = ';';
            this.cmb_LocalDivision.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_LocalDivision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_LocalDivision.Caption = "";
            this.cmb_LocalDivision.CaptionHeight = 17;
            this.cmb_LocalDivision.CaptionStyle = style105;
            this.cmb_LocalDivision.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_LocalDivision.ColumnCaptionHeight = 18;
            this.cmb_LocalDivision.ColumnFooterHeight = 18;
            this.cmb_LocalDivision.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_LocalDivision.ContentHeight = 17;
            this.cmb_LocalDivision.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_LocalDivision.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_LocalDivision.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_LocalDivision.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_LocalDivision.EditorHeight = 17;
            this.cmb_LocalDivision.EvenRowStyle = style106;
            this.cmb_LocalDivision.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_LocalDivision.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_LocalDivision.FooterStyle = style107;
            this.cmb_LocalDivision.GapHeight = 2;
            this.cmb_LocalDivision.HeadingStyle = style108;
            this.cmb_LocalDivision.HighLightRowStyle = style109;
            this.cmb_LocalDivision.ItemHeight = 15;
            this.cmb_LocalDivision.Location = new System.Drawing.Point(445, 40);
            this.cmb_LocalDivision.MatchEntryTimeout = ((long)(2000));
            this.cmb_LocalDivision.MaxDropDownItems = ((short)(5));
            this.cmb_LocalDivision.MaxLength = 32767;
            this.cmb_LocalDivision.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_LocalDivision.Name = "cmb_LocalDivision";
            this.cmb_LocalDivision.OddRowStyle = style110;
            this.cmb_LocalDivision.PartialRightColumn = false;
            this.cmb_LocalDivision.PropBag = resources.GetString("cmb_LocalDivision.PropBag");
            this.cmb_LocalDivision.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_LocalDivision.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_LocalDivision.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_LocalDivision.SelectedStyle = style111;
            this.cmb_LocalDivision.Size = new System.Drawing.Size(210, 21);
            this.cmb_LocalDivision.Style = style112;
            this.cmb_LocalDivision.TabIndex = 418;
            // 
            // lbl_Division
            // 
            this.lbl_Division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Division.ImageIndex = 1;
            this.lbl_Division.ImageList = this.img_Label;
            this.lbl_Division.Location = new System.Drawing.Point(344, 40);
            this.lbl_Division.Name = "lbl_Division";
            this.lbl_Division.Size = new System.Drawing.Size(100, 21);
            this.lbl_Division.TabIndex = 417;
            this.lbl_Division.Text = "Division";
            this.lbl_Division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_To
            // 
            this.cmb_To.AddItemCols = 0;
            this.cmb_To.AddItemSeparator = ';';
            this.cmb_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_To.Caption = "";
            this.cmb_To.CaptionHeight = 17;
            this.cmb_To.CaptionStyle = style113;
            this.cmb_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_To.ColumnCaptionHeight = 18;
            this.cmb_To.ColumnFooterHeight = 18;
            this.cmb_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_To.ContentHeight = 17;
            this.cmb_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_To.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_To.EditorHeight = 17;
            this.cmb_To.EvenRowStyle = style114;
            this.cmb_To.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_To.FooterStyle = style115;
            this.cmb_To.GapHeight = 2;
            this.cmb_To.HeadingStyle = style116;
            this.cmb_To.HighLightRowStyle = style117;
            this.cmb_To.ItemHeight = 15;
            this.cmb_To.Location = new System.Drawing.Point(220, 84);
            this.cmb_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_To.MaxDropDownItems = ((short)(5));
            this.cmb_To.MaxLength = 32767;
            this.cmb_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.OddRowStyle = style118;
            this.cmb_To.PartialRightColumn = false;
            this.cmb_To.PropBag = resources.GetString("cmb_To.PropBag");
            this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_To.SelectedStyle = style119;
            this.cmb_To.Size = new System.Drawing.Size(99, 21);
            this.cmb_To.Style = style120;
            this.cmb_To.TabIndex = 416;
            this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            // 
            // cmb_From
            // 
            this.cmb_From.AddItemCols = 0;
            this.cmb_From.AddItemSeparator = ';';
            this.cmb_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_From.Caption = "";
            this.cmb_From.CaptionHeight = 17;
            this.cmb_From.CaptionStyle = style121;
            this.cmb_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_From.ColumnCaptionHeight = 18;
            this.cmb_From.ColumnFooterHeight = 18;
            this.cmb_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_From.ContentHeight = 17;
            this.cmb_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_From.EditorHeight = 17;
            this.cmb_From.EvenRowStyle = style122;
            this.cmb_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_From.FooterStyle = style123;
            this.cmb_From.GapHeight = 2;
            this.cmb_From.HeadingStyle = style124;
            this.cmb_From.HighLightRowStyle = style125;
            this.cmb_From.ItemHeight = 15;
            this.cmb_From.Location = new System.Drawing.Point(109, 84);
            this.cmb_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_From.MaxDropDownItems = ((short)(5));
            this.cmb_From.MaxLength = 32767;
            this.cmb_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.OddRowStyle = style126;
            this.cmb_From.PartialRightColumn = false;
            this.cmb_From.PropBag = resources.GetString("cmb_From.PropBag");
            this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_From.SelectedStyle = style127;
            this.cmb_From.Size = new System.Drawing.Size(99, 21);
            this.cmb_From.Style = style128;
            this.cmb_From.TabIndex = 415;
            this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            // 
            // lbl_DP_DPO
            // 
            this.lbl_DP_DPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DP_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DP_DPO.ImageIndex = 1;
            this.lbl_DP_DPO.ImageList = this.img_Label;
            this.lbl_DP_DPO.Location = new System.Drawing.Point(8, 84);
            this.lbl_DP_DPO.Name = "lbl_DP_DPO";
            this.lbl_DP_DPO.Size = new System.Drawing.Size(100, 21);
            this.lbl_DP_DPO.TabIndex = 414;
            this.lbl_DP_DPO.Text = "DP/ DPO";
            this.lbl_DP_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SearchOption
            // 
            this.cmb_SearchOption.AddItemCols = 0;
            this.cmb_SearchOption.AddItemSeparator = ';';
            this.cmb_SearchOption.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_SearchOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SearchOption.Caption = "";
            this.cmb_SearchOption.CaptionHeight = 17;
            this.cmb_SearchOption.CaptionStyle = style129;
            this.cmb_SearchOption.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_SearchOption.ColumnCaptionHeight = 18;
            this.cmb_SearchOption.ColumnFooterHeight = 18;
            this.cmb_SearchOption.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_SearchOption.ContentHeight = 17;
            this.cmb_SearchOption.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_SearchOption.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_SearchOption.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_SearchOption.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_SearchOption.EditorHeight = 17;
            this.cmb_SearchOption.EvenRowStyle = style130;
            this.cmb_SearchOption.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_SearchOption.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchOption.FooterStyle = style131;
            this.cmb_SearchOption.GapHeight = 2;
            this.cmb_SearchOption.HeadingStyle = style132;
            this.cmb_SearchOption.HighLightRowStyle = style133;
            this.cmb_SearchOption.ItemHeight = 15;
            this.cmb_SearchOption.Location = new System.Drawing.Point(109, 62);
            this.cmb_SearchOption.MatchEntryTimeout = ((long)(2000));
            this.cmb_SearchOption.MaxDropDownItems = ((short)(5));
            this.cmb_SearchOption.MaxLength = 32767;
            this.cmb_SearchOption.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SearchOption.Name = "cmb_SearchOption";
            this.cmb_SearchOption.OddRowStyle = style134;
            this.cmb_SearchOption.PartialRightColumn = false;
            this.cmb_SearchOption.PropBag = resources.GetString("cmb_SearchOption.PropBag");
            this.cmb_SearchOption.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SearchOption.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SearchOption.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SearchOption.SelectedStyle = style135;
            this.cmb_SearchOption.Size = new System.Drawing.Size(210, 21);
            this.cmb_SearchOption.Style = style136;
            this.cmb_SearchOption.TabIndex = 413;
            this.cmb_SearchOption.SelectedValueChanged += new System.EventHandler(this.cmb_SearchOption_SelectedValueChanged);
            // 
            // lbl_Option
            // 
            this.lbl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Option.ImageIndex = 1;
            this.lbl_Option.ImageList = this.img_Label;
            this.lbl_Option.Location = new System.Drawing.Point(8, 62);
            this.lbl_Option.Name = "lbl_Option";
            this.lbl_Option.Size = new System.Drawing.Size(100, 21);
            this.lbl_Option.TabIndex = 412;
            this.lbl_Option.Text = "Search Option";
            this.lbl_Option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(208, 86);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 411;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Style
            // 
            this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(344, 62);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 405;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      Search Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 98);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 97);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style137;
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
            this.cmb_Factory.EvenRowStyle = style138;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style139;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style140;
            this.cmb_Factory.HighLightRowStyle = style141;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style142;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style143;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
            this.cmb_Factory.Style = style144;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 73);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 98);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 96);
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
            this.spd_main.Location = new System.Drawing.Point(8, 118);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 450);
            this.spd_main.TabIndex = 174;
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Form_BM_Ready_Yield_Local
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Ready_Yield_Local";
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_itemGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_LocalDivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
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

		#region 전역변수
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 
 
		// search option value
		private const int _Search_DP = 1;
		private const int _Search_DPO = 2;
		private string _itemGroupCode = " ";
		
		public DataSet _dsSet;

		public delegate void addData(DataTable arg_dt);
		public addData addFunc;
		public delegate void displayData();
		public displayData displayFunc;

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
			if(cmb_Factory.SelectedIndex == -1) return;

			Change_SearchOption();

			DataTable dt_ret;

			// Local/ LLT Division
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalLLTDivision); //"SBP13"
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_LocalDivision, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_LocalDivision.SelectedIndex = 0;

			dt_ret.Dispose(); 
		}

		/*
	 
		private void txt_StyleCd_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				Set_StyleCode(e); 
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
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 

				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		*/


		private void cmb_SearchOption_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				Change_SearchOption(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_SearchOption_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_From_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_From.SelectedIndex == -1) return;
				cmb_To.SelectedValue = cmb_From.SelectedValue.ToString();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_From_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_To_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				setStyleList();
				spd_main.ClearAll(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
				txt_itemGroup.Text	= COM.ComVar.Parameter_PopUp[4];

				vPopup.Dispose(); 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_groupSearch_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				DataTable vDt;
				vDt = ClassLib.ComFunction.SELECT_SCM_CUST_LIST(COM.ComVar.This_Factory, txt_vendorCode.Text);
				COM.ComCtl.Set_ComboList(vDt, cmb_vendor, 0, 1, true, 79, 141);
				vDt.Dispose();

				cmb_vendor.SelectedValue = txt_vendorCode.Text;
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		private void cmb_vendor_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (cmb_vendor.SelectedIndex != -1)
					txt_vendorCode.Text		 = cmb_vendor.SelectedValue.ToString();
			}
			catch //(Exception ex)
			{
				//MessageBox.Show(ex.Message);
			}
		}

		#endregion 

		#region 이벤트 처리 메서드

		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// form set
			this.Text = "Local/LLT Yield Check";
			lbl_MainTitle.Text = "Local/LLT Yield Check";

            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBM_READY_YIELD_LOCAL", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			
			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			//displayFunc = new displayData(this.displayGrid);
			//addFunc = new addData(this.addDataTable);
			_dsSet = new DataSet();
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
			DataTable dt_ret;

			// 공장
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// Search Option
			dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalSearchOption); //"SBM18"
			ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_SearchOption, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_SearchOption.SelectedIndex = 0;

			// 발주자
			dt_ret = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_purUser, 1, 1, true, 0, 200);
			cmb_purUser.SelectedValue = COM.ComVar.This_User;
		  
			//그룹타입 콤보쿼리 
			dt_ret = ClassLib.ComFunction.Select_GroupTypeCode();  
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_itemGroup, 0, 1, false,  0, 130);  

			dt_ret.Dispose(); 

			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 
			tbtn_Print.Enabled = false; 
		}

		/*
		/// <summary>
		/// Set_StyleCode : 스타일 콤보 세팅
		/// </summary>
		private void Set_StyleCode(System.Windows.Forms.KeyEventArgs e)
		{

			if(e.KeyCode != Keys.Enter) return; 

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
		*/


		private int _Default_ColumnCount = 0;


		/// <summary>
		/// Change_SearchOption : 
		/// </summary>
		private void Change_SearchOption()
		{
			
			if(cmb_Factory.SelectedIndex == -1 || cmb_SearchOption.SelectedIndex == -1) return;
 
			// 그리드 헤더, from~to 세팅
			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					// grid set
					spd_main.ActiveSheet.ColumnHeader.Cells[1, (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxDEL_MONTH].Text = "Delevery Month";
					lbl_DP_DPO.Text = "DP"; 
					break;

				case _Search_DPO :

					// grid set
					spd_main.ActiveSheet.ColumnHeader.Cells[1, (int)ClassLib.TBM_READY_YIELD_LOCAL_DPO.IxOBS_ID].Text = "DPO";
					lbl_DP_DPO.Text = "DPO";
					break;
			}

			_Default_ColumnCount = spd_main.ActiveSheet.ColumnCount;
			
			DataTable dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), cmb_SearchOption.SelectedValue.ToString() );
			COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			cmb_StyleCd.ClearItems();
		}

		private void setStyleList()
		{
			if (cmb_From.SelectedIndex == -1 || cmb_To.SelectedIndex == -1)
				return;

			string[] args = new string[5];
			
			args[0] = COM.ComFunction.Empty_Combo(cmb_Factory, "");
			args[1] = COM.ComFunction.Empty_Combo(cmb_From, "");
			args[2] = COM.ComFunction.Empty_Combo(cmb_To, "");
			args[3] = COM.ComFunction.Empty_Combo(cmb_SearchOption, "");

			DataTable dt_ret = this.SELECT_STYLE_LIST_DPDPO(args);
			if (dt_ret.Rows.Count > 0)
			{
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_StyleCd, 0, 1, true, 80, 130);
				//ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_StyleCd, 0, 1, 2, 3, 4, true, 80, 200);
			}
			dt_ret.Dispose();
		}



		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_SearchOption.SelectedIndex = -1;
			lbl_DP_DPO.Text = "DP/DPO";
			cmb_From.SelectedIndex = -1; 
			cmb_To.SelectedIndex = -1;
			cmb_StyleCd.SelectedIndex = -1;
			cmb_LocalDivision.SelectedIndex = -1;
			cmb_purUser.SelectedIndex = -1;
			cmb_vendor.SelectedIndex = -1;
			txt_vendorCode.Text = "";
			txt_itemCode.Text = "";
			txt_itemName.Text = "";
			 
			spd_main.ClearAll();  
		}

		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};

			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);

			if(! essential_check) return;

			spd_main.ClearAll();
			searchStyle();
		}

//		private void searchAllStyle()
//		{
//			DataTable dt = (DataTable)cmb_StyleCd.DataSource;
//
//			string factory = cmb_Factory.SelectedValue.ToString();
//			string style_cd = "";
//			string from = cmb_From.SelectedValue.ToString();
//			string to = cmb_To.SelectedValue.ToString();
//			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, "A"); 
//
//			// 추가
//			string vendor = ClassLib.ComFunction.Empty_Combo(cmb_vendor, " ");
//			string pur_user = ClassLib.ComFunction.Empty_Combo(cmb_purUser, " "); 
//			string group_cd = _itemGroupCode.Replace("00", " "); 
//			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " "); 
//			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " "); 
//
//			string[] parameter = new string[] {factory, style_cd, from, to, import, vendor, pur_user, group_cd, item_cd, item_name};
//
//			_dsSet.Tables.Clear();
//			prog_search.Maximum = dt.Rows.Count - 1;
//			prog_search.Step = 1;
//			prog_search.Value = 0;
//			controlLock(false);
//
//			DataThread dThread = new DataThread(this, parameter, dt);
//			Thread thread = new Thread(new ThreadStart(dThread.search));
//			thread.Start();
//		}

//		private void addDataTable(DataTable arg_dt)
//		{
//			_dsSet.Tables.Add(arg_dt.Copy());
//			prog_search.PerformStep();
//		}
//
//		private void displayGrid()
//		{
//			try
//			{
//				for (int idx = 0 ; idx < _dsSet.Tables.Count ; idx++)
//				{
//					spd_main.Display_Grid_Add(_dsSet.Tables[idx]);
//				}
//
//				setGridDesign();
//				controlLock(true);
//			}
//			catch (Exception ex)
//			{
//				ClassLib.ComFunction.User_Message(ex.Message, "display", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//		}

		private void searchStyle()
		{
			string factory = cmb_Factory.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();
			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, "A"); 

			// 추가
			string vendor = ClassLib.ComFunction.Empty_Combo(cmb_vendor, " ");
			string pur_user = ClassLib.ComFunction.Empty_Combo(cmb_purUser, " "); 
			string group_cd = _itemGroupCode.Replace("00", " "); 
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " "); 
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " "); 

			string[] parameter = new string[] {factory, style_cd, from, to, import, vendor, pur_user, group_cd, item_cd, item_name};

			DataTable dt_ret = SELECT_SBM_DP_DPO_LIST(parameter); 

			spd_main.Display_Grid(dt_ret); 
			setGridDesign();
		}

		private void setGridDesign()
		{
			int dStart = (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxYIELD_COUNT;
			int dEnd = spd_main.ActiveSheet.ColumnCount - 1;

			// column merge 
			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxDEL_MONTH,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxOBS_TYPE,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxSTYLE_CD,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxSTYLE_NAME } );



					break;

				case _Search_DPO :

					ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBM_READY_YIELD_LOCAL_DPO.IxOBS_ID,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DPO.IxOBS_TYPE,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DPO.IxSTYLE_CD,
																		  (int)ClassLib.TBM_READY_YIELD_LOCAL_DPO.IxSTYLE_NAME } ); 

					break;
			}

			spd_main.ActiveSheet.Columns[1, (int)ClassLib.TBM_READY_YIELD_LOCAL_DP.IxCOLOR_NAME].BackColor = ClassLib.ComVar.RightYellow;

			for (int row = 0 ; row < spd_main.ActiveSheet.Rows.Count ; row++)
			{
				spd_main.ActiveSheet.Cells[row, dStart, row, dEnd].BackColor = ClassLib.ComVar.RightBlue;
			}
		}

//		private void controlLock(bool arg_enabled)
//		{
//			cmb_Factory.Enabled = arg_enabled;
//			cmb_SearchOption.Enabled = arg_enabled;
//			cmb_From.Enabled = arg_enabled;
//			cmb_To.Enabled = arg_enabled;
//			cmb_LocalDivision.Enabled = arg_enabled;
//			cmb_StyleCd.Enabled = arg_enabled;
//			txt_vendorCode.Enabled = arg_enabled;
//			cmb_vendor.Enabled = arg_enabled;
//			cmb_purUser.Enabled = arg_enabled;
//			cmb_itemGroup.Enabled = arg_enabled;
//			txt_itemName.Enabled = arg_enabled;
//			txt_itemCode.Enabled = arg_enabled;
//
//			tbtn_New.Enabled = arg_enabled;
//			tbtn_Search.Enabled = arg_enabled;
//
//		}

		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_SearchOption, cmb_From, cmb_To, cmb_LocalDivision};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return; 

			string factory = cmb_Factory.SelectedValue.ToString();
			string style_cd = ClassLib.ComFunction.Empty_Combo(cmb_StyleCd, " ").Replace("-", "");
			string from = cmb_From.SelectedValue.ToString();
			string to = cmb_To.SelectedValue.ToString();
			string import = ClassLib.ComFunction.Empty_Combo(cmb_LocalDivision, " ");  

			// 추가
			string vendor = ClassLib.ComFunction.Empty_Combo(cmb_vendor, " ");
			string pur_user = ClassLib.ComFunction.Empty_Combo(cmb_purUser, " "); 
			string group_cd = _itemGroupCode; 
			string item_cd = ClassLib.ComFunction.Empty_TextBox(txt_itemCode, " "); 
			string item_name = ClassLib.ComFunction.Empty_TextBox(txt_itemName, " "); 

			Pop_BM_Print_Type vPop = new Pop_BM_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);

			string sPara = "";
			string sDir = "";
			string report_text = ""; 

			if (vPop.ShowDialog() != DialogResult.OK) return;

			 
			string vPrintType = COM.ComVar.Parameter_PopUp[0];
			
			sPara  = " /rp ";
			sPara += "'" + factory  + "' ";
			sPara += "'" + style_cd + "' ";
			sPara += "'" + from     + "' ";
			sPara += "'" + to		+ "' ";
			sPara += "'" + import   + "' ";  			

			switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
			{
				case _Search_DP :

					switch (vPrintType)
					{
						case "10" : // DB   
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Forecast_DP.mrd"; 
							break;

						case "20" : // Text 
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Forecast_DP_2.mrd";
							break;

						default:
							break;
					}


					report_text = "Local/LLT Monitoring By Style (DP)"; 

					break;

				case _Search_DPO :

					
					switch (vPrintType)
					{
						case "10" : // DB   
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Forecast_DPO.mrd";
							break;

						case "20" : // Text 
							sDir = Application.StartupPath + @"\Report\MRP\Form_BM_Shipping_Local_Forecast_DPO_2.mrd";
							break;

						default:
							break;
					}
					report_text = "Local/LLT Monitoring By Style (DPO)";

					break;
			}


			FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara);
			MyReport.Text = report_text;
			MyReport.Show();
		}



		#endregion 

		#endregion

		#region DB Connect

		/// <summary>
		/// SELECT_SBM_DP_DPO_LIST : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		public DataTable SELECT_SBM_DP_DPO_LIST(string[] arg_parameter)
		{
			try 
			{
				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, import};

				MyOraDB.ReDim_Parameter(12);  

				//01.PROCEDURE명
				MyOraDB.Process_Name = "";

				switch( Convert.ToInt32(cmb_SearchOption.SelectedValue.ToString()) )
				{
					case _Search_DP :

						MyOraDB.Process_Name = "PKG_SBM_READY_LOCAL.SELECT_DP_USAGE"; 
						break;

					case _Search_DPO :

						MyOraDB.Process_Name = "PKG_SBM_READY_LOCAL.SELECT_DPO_USAGE"; 
						break;
				}

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_THIS_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[4] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[5] = "ARG_IMPORT"; 
				MyOraDB.Parameter_Name[6] = "ARG_VENDOR"; 
				MyOraDB.Parameter_Name[7] = "ARG_PUR_USER"; 
				MyOraDB.Parameter_Name[8] = "ARG_GROUP_CD"; 
				MyOraDB.Parameter_Name[9] = "ARG_ITEM_CD"; 
				MyOraDB.Parameter_Name[10] = "ARG_ITEM_NAME"; 
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
				MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
				MyOraDB.Parameter_Values[1] = arg_parameter[0];
				MyOraDB.Parameter_Values[2] = arg_parameter[1];
				MyOraDB.Parameter_Values[3] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[4] = arg_parameter[3];
				MyOraDB.Parameter_Values[5] = arg_parameter[4];
				MyOraDB.Parameter_Values[6] = arg_parameter[5];
				MyOraDB.Parameter_Values[7] = arg_parameter[6];
				MyOraDB.Parameter_Values[8] = arg_parameter[7];
				MyOraDB.Parameter_Values[9] = arg_parameter[8];
				MyOraDB.Parameter_Values[10] = arg_parameter[9];
				MyOraDB.Parameter_Values[11] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBM_DP_DPO_LIST", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		/// <summary>
		/// SELECT_STYLE_LIST_DPDPO : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_STYLE_LIST_DPDPO(string[] arg_parameter)
		{
			try 
			{
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(5); 

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBM_READY_LOCAL.SELECT_STYLE_LIST_DPDPO"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_FROM_DATE";
				MyOraDB.Parameter_Name[2] = "ARG_TO_DATE";
				MyOraDB.Parameter_Name[3] = "ARG_SEARCH_TYPE";
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
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIST_DPDPO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
		}

		#endregion	


//		#region 멀티 스레드를 위한 내부 클래스
//
//		public class DataThread
//		{
//			private COM.OraDB MyOraDB = new COM.OraDB(); 
//
//			private Form_BM_Ready_Yield_Local _main;
//			private DataTable _dt;
//			private string[] _param;
//
//			public DataThread(Form_BM_Ready_Yield_Local arg_main, string[] arg_param, DataTable arg_dt)
//			{
//				_main = arg_main;
//				_dt = arg_dt;
//				_param = arg_param;
//			}
//
//			public void search()
//			{
//				try
//				{
//					for (int idx = 1 ; idx < _dt.Rows.Count - 1 ; idx++)
//					{
//						string style_cd = _dt.Rows[idx][0].ToString().Replace("-", "");
//						_param[1] = style_cd;
//						DataTable vDt = _main.SELECT_SBM_DP_DPO_LIST(_param);
//						vDt.TableName = vDt.TableName + "_" + idx;
//						_main.addDataTable(vDt.Copy());
//					}
//
//					_main.displayGrid();
//				}
//				catch (Exception ex)
//				{
//					ClassLib.ComFunction.User_Message(ex.Message, "search thread", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//				}
//			}
//		}
//
//		#endregion

	}
}

