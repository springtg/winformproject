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


namespace FlexPurchase.Purchase
{
	public class Form_BP_CFM_Report : COM.PCHWinForm.Form_Top
	{
		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel panel2;
		private COM.SSP spd_main;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label btn_RunProcess;
		private System.Windows.Forms.Label btn_ErrorCheck;
		private System.Windows.Forms.Label lbl_DPdate;
		private System.Windows.Forms.TextBox txt_DPdate;
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.ComponentModel.IContainer components = null; 
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbl_DPO;
		private System.Windows.Forms.Label lbl_DP;
		private C1.Win.C1List.C1Combo cmb_DP_To;
		private C1.Win.C1List.C1Combo cmb_DP_From;

		#endregion

		#region 사용자 정의 맴버

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		private Hashtable _cellTypes = null;

		// search option value
		private const string _Search_DP  = "1";
		private const string _Search_DPO = "2"; 
		private Pop_BP_Purchase_Wait _pop;
		private System.Windows.Forms.ContextMenu ctx_tail;
		private System.Windows.Forms.MenuItem mnu_Data;
		private C1.Win.C1List.C1Combo cmb_PA_From;
		private C1.Win.C1List.C1Combo cmb_PA_To;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private C1.Win.C1List.C1Combo cmb_DPO_From;
		private C1.Win.C1List.C1Combo cmb_DPO_To;
		private System.Windows.Forms.Label label5;
		private const int _validate_process = 40;

		
		#endregion


		#region 생성자 / 소멸자
		public Form_BP_CFM_Report()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BP_CFM_Report));
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_DPO_To = new C1.Win.C1List.C1Combo();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_PA_From = new C1.Win.C1List.C1Combo();
            this.cmb_PA_To = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_DP_From = new C1.Win.C1List.C1Combo();
            this.cmb_DP_To = new C1.Win.C1List.C1Combo();
            this.lbl_DP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.btn_RunProcess = new System.Windows.Forms.Label();
            this.btn_ErrorCheck = new System.Windows.Forms.Label();
            this.lbl_DPdate = new System.Windows.Forms.Label();
            this.txt_DPdate = new System.Windows.Forms.TextBox();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.cmb_DPO_From = new C1.Win.C1List.C1Combo();
            this.lbl_DPO = new System.Windows.Forms.Label();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.spd_main = new COM.SSP();
            this.ctx_tail = new System.Windows.Forms.ContextMenu();
            this.mnu_Data = new System.Windows.Forms.MenuItem();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PA_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PA_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DP_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DP_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.panel2);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "20.6597222222222:False:True;71.3541666666667:False:False;6.59722222222222:False:T" +
                "rue;\t0.393700787401575:False:True;98.4251968503937:False:False;0.393700787401575" +
                ":False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 30;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.cmb_DPO_To);
            this.pnl_head.Controls.Add(this.label5);
            this.pnl_head.Controls.Add(this.cmb_PA_From);
            this.pnl_head.Controls.Add(this.cmb_PA_To);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.label4);
            this.pnl_head.Controls.Add(this.cmb_DP_From);
            this.pnl_head.Controls.Add(this.cmb_DP_To);
            this.pnl_head.Controls.Add(this.lbl_DP);
            this.pnl_head.Controls.Add(this.label3);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.btn_RunProcess);
            this.pnl_head.Controls.Add(this.btn_ErrorCheck);
            this.pnl_head.Controls.Add(this.lbl_DPdate);
            this.pnl_head.Controls.Add(this.txt_DPdate);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.txt_StyleCd);
            this.pnl_head.Controls.Add(this.cmb_DPO_From);
            this.pnl_head.Controls.Add(this.lbl_DPO);
            this.pnl_head.Controls.Add(this.lbl_Style);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.lbl_Factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 119);
            this.pnl_head.TabIndex = 2;
            // 
            // cmb_DPO_To
            // 
            this.cmb_DPO_To.AddItemCols = 0;
            this.cmb_DPO_To.AddItemSeparator = ';';
            this.cmb_DPO_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_DPO_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DPO_To.Caption = "";
            this.cmb_DPO_To.CaptionHeight = 17;
            this.cmb_DPO_To.CaptionStyle = style1;
            this.cmb_DPO_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DPO_To.ColumnCaptionHeight = 18;
            this.cmb_DPO_To.ColumnFooterHeight = 18;
            this.cmb_DPO_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DPO_To.ContentHeight = 16;
            this.cmb_DPO_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DPO_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DPO_To.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_DPO_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DPO_To.EditorHeight = 16;
            this.cmb_DPO_To.EvenRowStyle = style2;
            this.cmb_DPO_To.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_DPO_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DPO_To.FooterStyle = style3;
            this.cmb_DPO_To.GapHeight = 2;
            this.cmb_DPO_To.HeadingStyle = style4;
            this.cmb_DPO_To.HighLightRowStyle = style5;
            this.cmb_DPO_To.ItemHeight = 15;
            this.cmb_DPO_To.Location = new System.Drawing.Point(221, 62);
            this.cmb_DPO_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_DPO_To.MaxDropDownItems = ((short)(5));
            this.cmb_DPO_To.MaxLength = 32767;
            this.cmb_DPO_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DPO_To.Name = "cmb_DPO_To";
            this.cmb_DPO_To.OddRowStyle = style6;
            this.cmb_DPO_To.PartialRightColumn = false;
            this.cmb_DPO_To.PropBag = resources.GetString("cmb_DPO_To.PropBag");
            this.cmb_DPO_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DPO_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DPO_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DPO_To.SelectedStyle = style7;
            this.cmb_DPO_To.Size = new System.Drawing.Size(99, 20);
            this.cmb_DPO_To.Style = style8;
            this.cmb_DPO_To.TabIndex = 548;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(208, 64);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(12, 16);
            this.label5.TabIndex = 547;
            this.label5.Text = "~";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_PA_From
            // 
            this.cmb_PA_From.AddItemCols = 0;
            this.cmb_PA_From.AddItemSeparator = ';';
            this.cmb_PA_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_PA_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PA_From.Caption = "";
            this.cmb_PA_From.CaptionHeight = 17;
            this.cmb_PA_From.CaptionStyle = style9;
            this.cmb_PA_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PA_From.ColumnCaptionHeight = 18;
            this.cmb_PA_From.ColumnFooterHeight = 18;
            this.cmb_PA_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PA_From.ContentHeight = 16;
            this.cmb_PA_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PA_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PA_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_PA_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PA_From.EditorHeight = 16;
            this.cmb_PA_From.EvenRowStyle = style10;
            this.cmb_PA_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_PA_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PA_From.FooterStyle = style11;
            this.cmb_PA_From.GapHeight = 2;
            this.cmb_PA_From.HeadingStyle = style12;
            this.cmb_PA_From.HighLightRowStyle = style13;
            this.cmb_PA_From.ItemHeight = 15;
            this.cmb_PA_From.Location = new System.Drawing.Point(445, 62);
            this.cmb_PA_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_PA_From.MaxDropDownItems = ((short)(5));
            this.cmb_PA_From.MaxLength = 32767;
            this.cmb_PA_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PA_From.Name = "cmb_PA_From";
            this.cmb_PA_From.OddRowStyle = style14;
            this.cmb_PA_From.PartialRightColumn = false;
            this.cmb_PA_From.PropBag = resources.GetString("cmb_PA_From.PropBag");
            this.cmb_PA_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PA_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PA_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PA_From.SelectedStyle = style15;
            this.cmb_PA_From.Size = new System.Drawing.Size(99, 20);
            this.cmb_PA_From.Style = style16;
            this.cmb_PA_From.TabIndex = 546;
            // 
            // cmb_PA_To
            // 
            this.cmb_PA_To.AddItemCols = 0;
            this.cmb_PA_To.AddItemSeparator = ';';
            this.cmb_PA_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_PA_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_PA_To.Caption = "";
            this.cmb_PA_To.CaptionHeight = 17;
            this.cmb_PA_To.CaptionStyle = style17;
            this.cmb_PA_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_PA_To.ColumnCaptionHeight = 18;
            this.cmb_PA_To.ColumnFooterHeight = 18;
            this.cmb_PA_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_PA_To.ContentHeight = 16;
            this.cmb_PA_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_PA_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_PA_To.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_PA_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_PA_To.EditorHeight = 16;
            this.cmb_PA_To.EvenRowStyle = style18;
            this.cmb_PA_To.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_PA_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_PA_To.FooterStyle = style19;
            this.cmb_PA_To.GapHeight = 2;
            this.cmb_PA_To.HeadingStyle = style20;
            this.cmb_PA_To.HighLightRowStyle = style21;
            this.cmb_PA_To.ItemHeight = 15;
            this.cmb_PA_To.Location = new System.Drawing.Point(557, 62);
            this.cmb_PA_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_PA_To.MaxDropDownItems = ((short)(5));
            this.cmb_PA_To.MaxLength = 32767;
            this.cmb_PA_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_PA_To.Name = "cmb_PA_To";
            this.cmb_PA_To.OddRowStyle = style22;
            this.cmb_PA_To.PartialRightColumn = false;
            this.cmb_PA_To.PropBag = resources.GetString("cmb_PA_To.PropBag");
            this.cmb_PA_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_PA_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_PA_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_PA_To.SelectedStyle = style23;
            this.cmb_PA_To.Size = new System.Drawing.Size(99, 20);
            this.cmb_PA_To.Style = style24;
            this.cmb_PA_To.TabIndex = 545;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(344, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 544;
            this.label1.Text = "PA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(544, 64);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(12, 16);
            this.label4.TabIndex = 543;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_DP_From
            // 
            this.cmb_DP_From.AddItemCols = 0;
            this.cmb_DP_From.AddItemSeparator = ';';
            this.cmb_DP_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_DP_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DP_From.Caption = "";
            this.cmb_DP_From.CaptionHeight = 17;
            this.cmb_DP_From.CaptionStyle = style25;
            this.cmb_DP_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DP_From.ColumnCaptionHeight = 18;
            this.cmb_DP_From.ColumnFooterHeight = 18;
            this.cmb_DP_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DP_From.ContentHeight = 16;
            this.cmb_DP_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DP_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DP_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_DP_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DP_From.EditorHeight = 16;
            this.cmb_DP_From.EvenRowStyle = style26;
            this.cmb_DP_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_DP_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DP_From.FooterStyle = style27;
            this.cmb_DP_From.GapHeight = 2;
            this.cmb_DP_From.HeadingStyle = style28;
            this.cmb_DP_From.HighLightRowStyle = style29;
            this.cmb_DP_From.ItemHeight = 15;
            this.cmb_DP_From.Location = new System.Drawing.Point(109, 84);
            this.cmb_DP_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_DP_From.MaxDropDownItems = ((short)(5));
            this.cmb_DP_From.MaxLength = 32767;
            this.cmb_DP_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DP_From.Name = "cmb_DP_From";
            this.cmb_DP_From.OddRowStyle = style30;
            this.cmb_DP_From.PartialRightColumn = false;
            this.cmb_DP_From.PropBag = resources.GetString("cmb_DP_From.PropBag");
            this.cmb_DP_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DP_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DP_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DP_From.SelectedStyle = style31;
            this.cmb_DP_From.Size = new System.Drawing.Size(99, 20);
            this.cmb_DP_From.Style = style32;
            this.cmb_DP_From.TabIndex = 542;
            // 
            // cmb_DP_To
            // 
            this.cmb_DP_To.AddItemCols = 0;
            this.cmb_DP_To.AddItemSeparator = ';';
            this.cmb_DP_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_DP_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DP_To.Caption = "";
            this.cmb_DP_To.CaptionHeight = 17;
            this.cmb_DP_To.CaptionStyle = style33;
            this.cmb_DP_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DP_To.ColumnCaptionHeight = 18;
            this.cmb_DP_To.ColumnFooterHeight = 18;
            this.cmb_DP_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DP_To.ContentHeight = 16;
            this.cmb_DP_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DP_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DP_To.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_DP_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DP_To.EditorHeight = 16;
            this.cmb_DP_To.EvenRowStyle = style34;
            this.cmb_DP_To.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_DP_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DP_To.FooterStyle = style35;
            this.cmb_DP_To.GapHeight = 2;
            this.cmb_DP_To.HeadingStyle = style36;
            this.cmb_DP_To.HighLightRowStyle = style37;
            this.cmb_DP_To.ItemHeight = 15;
            this.cmb_DP_To.Location = new System.Drawing.Point(221, 84);
            this.cmb_DP_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_DP_To.MaxDropDownItems = ((short)(5));
            this.cmb_DP_To.MaxLength = 32767;
            this.cmb_DP_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DP_To.Name = "cmb_DP_To";
            this.cmb_DP_To.OddRowStyle = style38;
            this.cmb_DP_To.PartialRightColumn = false;
            this.cmb_DP_To.PropBag = resources.GetString("cmb_DP_To.PropBag");
            this.cmb_DP_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DP_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DP_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DP_To.SelectedStyle = style39;
            this.cmb_DP_To.Size = new System.Drawing.Size(99, 20);
            this.cmb_DP_To.Style = style40;
            this.cmb_DP_To.TabIndex = 541;
            // 
            // lbl_DP
            // 
            this.lbl_DP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DP.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DP.ImageIndex = 1;
            this.lbl_DP.ImageList = this.img_Label;
            this.lbl_DP.Location = new System.Drawing.Point(8, 84);
            this.lbl_DP.Name = "lbl_DP";
            this.lbl_DP.Size = new System.Drawing.Size(100, 21);
            this.lbl_DP.TabIndex = 539;
            this.lbl_DP.Text = "DP";
            this.lbl_DP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(208, 86);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 538;
            this.label3.Text = "~";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.Text = "      MRP Shipping Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btn_RunProcess
            // 
            this.btn_RunProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RunProcess.ImageIndex = 0;
            this.btn_RunProcess.ImageList = this.img_Button;
            this.btn_RunProcess.Location = new System.Drawing.Point(822, 84);
            this.btn_RunProcess.Name = "btn_RunProcess";
            this.btn_RunProcess.Size = new System.Drawing.Size(80, 23);
            this.btn_RunProcess.TabIndex = 537;
            this.btn_RunProcess.Text = "Run";
            this.btn_RunProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_RunProcess.Click += new System.EventHandler(this.btn_RunProcess_Click);
            // 
            // btn_ErrorCheck
            // 
            this.btn_ErrorCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ErrorCheck.ImageIndex = 0;
            this.btn_ErrorCheck.ImageList = this.img_Button;
            this.btn_ErrorCheck.Location = new System.Drawing.Point(903, 84);
            this.btn_ErrorCheck.Name = "btn_ErrorCheck";
            this.btn_ErrorCheck.Size = new System.Drawing.Size(80, 23);
            this.btn_ErrorCheck.TabIndex = 537;
            this.btn_ErrorCheck.Text = "Checking";
            this.btn_ErrorCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ErrorCheck.Click += new System.EventHandler(this.btn_ErrorCheck_Click);
            // 
            // lbl_DPdate
            // 
            this.lbl_DPdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DPdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DPdate.ImageIndex = 0;
            this.lbl_DPdate.ImageList = this.img_Label;
            this.lbl_DPdate.Location = new System.Drawing.Point(344, 84);
            this.lbl_DPdate.Name = "lbl_DPdate";
            this.lbl_DPdate.Size = new System.Drawing.Size(100, 21);
            this.lbl_DPdate.TabIndex = 405;
            this.lbl_DPdate.Text = "Last Update";
            this.lbl_DPdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_DPdate
            // 
            this.txt_DPdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DPdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DPdate.Enabled = false;
            this.txt_DPdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_DPdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_DPdate.Location = new System.Drawing.Point(445, 84);
            this.txt_DPdate.MaxLength = 10;
            this.txt_DPdate.Name = "txt_DPdate";
            this.txt_DPdate.Size = new System.Drawing.Size(211, 21);
            this.txt_DPdate.TabIndex = 536;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemCols = 0;
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style41;
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
            this.cmb_StyleCd.EvenRowStyle = style42;
            this.cmb_StyleCd.FooterStyle = style43;
            this.cmb_StyleCd.GapHeight = 2;
            this.cmb_StyleCd.HeadingStyle = style44;
            this.cmb_StyleCd.HighLightRowStyle = style45;
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(521, 40);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style46;
            this.cmb_StyleCd.PartialRightColumn = false;
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style47;
            this.cmb_StyleCd.Size = new System.Drawing.Size(134, 21);
            this.cmb_StyleCd.Style = style48;
            this.cmb_StyleCd.TabIndex = 535;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(445, 40);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
            this.txt_StyleCd.TabIndex = 536;
            // 
            // cmb_DPO_From
            // 
            this.cmb_DPO_From.AddItemCols = 0;
            this.cmb_DPO_From.AddItemSeparator = ';';
            this.cmb_DPO_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_DPO_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_DPO_From.Caption = "";
            this.cmb_DPO_From.CaptionHeight = 17;
            this.cmb_DPO_From.CaptionStyle = style49;
            this.cmb_DPO_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_DPO_From.ColumnCaptionHeight = 18;
            this.cmb_DPO_From.ColumnFooterHeight = 18;
            this.cmb_DPO_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_DPO_From.ContentHeight = 16;
            this.cmb_DPO_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_DPO_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_DPO_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_DPO_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_DPO_From.EditorHeight = 16;
            this.cmb_DPO_From.EvenRowStyle = style50;
            this.cmb_DPO_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_DPO_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DPO_From.FooterStyle = style51;
            this.cmb_DPO_From.GapHeight = 2;
            this.cmb_DPO_From.HeadingStyle = style52;
            this.cmb_DPO_From.HighLightRowStyle = style53;
            this.cmb_DPO_From.ItemHeight = 15;
            this.cmb_DPO_From.Location = new System.Drawing.Point(109, 62);
            this.cmb_DPO_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_DPO_From.MaxDropDownItems = ((short)(5));
            this.cmb_DPO_From.MaxLength = 32767;
            this.cmb_DPO_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_DPO_From.Name = "cmb_DPO_From";
            this.cmb_DPO_From.OddRowStyle = style54;
            this.cmb_DPO_From.PartialRightColumn = false;
            this.cmb_DPO_From.PropBag = resources.GetString("cmb_DPO_From.PropBag");
            this.cmb_DPO_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_DPO_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_DPO_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_DPO_From.SelectedStyle = style55;
            this.cmb_DPO_From.Size = new System.Drawing.Size(99, 20);
            this.cmb_DPO_From.Style = style56;
            this.cmb_DPO_From.TabIndex = 415;
            this.cmb_DPO_From.SelectedValueChanged += new System.EventHandler(this.cmb_DPO_SelectedValueChanged);
            // 
            // lbl_DPO
            // 
            this.lbl_DPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DPO.ImageIndex = 1;
            this.lbl_DPO.ImageList = this.img_Label;
            this.lbl_DPO.Location = new System.Drawing.Point(8, 62);
            this.lbl_DPO.Name = "lbl_DPO";
            this.lbl_DPO.Size = new System.Drawing.Size(100, 21);
            this.lbl_DPO.TabIndex = 414;
            this.lbl_DPO.Text = "DPO";
            this.lbl_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Style
            // 
            this.lbl_Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(344, 40);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 405;
            this.lbl_Style.Text = "Style";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 103);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 102);
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
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
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
            this.cmb_Factory.Size = new System.Drawing.Size(211, 20);
            this.cmb_Factory.Style = style64;
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
            this.pic_head7.Size = new System.Drawing.Size(101, 78);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 103);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 101);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(8, 538);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 38);
            this.panel2.TabIndex = 4;
            // 
            // spd_main
            // 
            this.spd_main.ContextMenu = this.ctx_tail;
            this.spd_main.Location = new System.Drawing.Point(8, 123);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(1000, 411);
            this.spd_main.TabIndex = 3;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // ctx_tail
            // 
            this.ctx_tail.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnu_Data});
            // 
            // mnu_Data
            // 
            this.mnu_Data.Index = 0;
            this.mnu_Data.Text = "Value Change";
            this.mnu_Data.Click += new System.EventHandler(this.mnu_Data_Click);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Form_BP_CFM_Report
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BP_CFM_Report";
            this.Controls.SetChildIndex(this.stbar, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PA_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_PA_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DP_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DP_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_DPO_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region 초기화

		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // form set
            this.Text = "S-Book / CFM Sample Check List";
            lbl_MainTitle.Text = "S-Book / CFM Sample Check List";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBP_CONFIRM_REPORT", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false); 
			

			// Farpoint Spread Header Merge
			Mearge_GridHead();

			//combobox setting
			Init_Control(); 

			_mainSheet = spd_main.ActiveSheet;
			_cellTypes = new Hashtable();

			for (int vCount = 1 ; vCount < _mainSheet.Columns.Count ; vCount++)
				if (_mainSheet.Columns[vCount].CellType.ToString().Equals(ClassLib.ComVar.SSPComboBoxCell))
				{
					COM.SSPComboBoxCellType sspBox = (COM.SSPComboBoxCellType)_mainSheet.Columns[vCount].CellType; 
					_cellTypes.Add(vCount, sspBox.DataSourceWithCode);
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

			// toolbar button disable setting
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;  
			//tbtn_Print.Enabled = false; 

			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;

			dt_ret.Dispose(); 

			init_DP_Change();


		}

		private void init_DP_Change()
		{
			DataTable dt_ret;

			dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), _Search_DPO);
			COM.ComCtl.Set_ComboList(dt_ret, cmb_DPO_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_DPO_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_DP_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_DP_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name);  
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PA_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			COM.ComCtl.Set_ComboList(dt_ret, cmb_PA_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			dt_ret.Dispose();

		}


		#endregion

 
		#region 컨트롤 이벤트


		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{
			spd_main.ClearAll();
			init_DP_Change();
		}

		private void cmb_DPO_SelectedValueChanged(object sender, System.EventArgs e)
		{
//			cmb_DP_From.SelectedValue = cmb_DPO.SelectedValue.ToString();
//			cmb_DP_To.SelectedValue   = cmb_DPO.SelectedValue.ToString();
		}


		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if(ClassLib.ComFunction.User_Message("Do you want to save?","Save", MessageBoxButtons.YesNo ,MessageBoxIcon.Question) == DialogResult.Yes )
					this.Tbtn_SaveProcess();
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
			string mrd_Filename = ClassLib.ComFunction.Set_RD_Directory("Form_BP_CFM_Report") ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 8;
			string [] aHead =  new string[iCnt];	
			


			aHead[0]    = cmb_Factory.SelectedValue.ToString(); 
			aHead[1]    = cmb_DPO_From.SelectedValue.ToString();
			aHead[2]    = cmb_DPO_To.SelectedValue.ToString(); 
			aHead[3]    = cmb_DP_From.SelectedValue.ToString();
			aHead[4]    = cmb_DP_To.SelectedValue.ToString();
			aHead[5]    = cmb_PA_From.SelectedValue.ToString();
			aHead[6]    = cmb_PA_To.SelectedValue.ToString();
			aHead[7]    = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

			#endregion
			
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
			
			FlexBase.Report.Form_RdViewer report = new FlexBase.Report.Form_RdViewer (mrd_Filename, Para);
			report.Show();		
		}

		private void btn_RunProcess_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to run Run process?", "New Style", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_process))
				{
					RunProcess_New();
				}
			}
		}
		

		private void btn_ErrorCheck_Click(object sender, System.EventArgs e)
		{
			if (MessageBox.Show(this, "Do you want to run Run process?", "Style Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (Etc_ProvisoValidateCheck(_validate_process))
				{
					RunProcess_Info();
				}
			} 
		}

		
		private void mnu_Data_Click(object sender, System.EventArgs e)
		{
			this.Grid_CellClickProcess();
		}


		#endregion

		#region 그리드 이벤트

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
			try
			{
				spd_main.Update_Row(img_Action);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "fgrid_Color_EditChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			try
			{
				int ir = spd_main.Sheets[0].ActiveRowIndex ;
				int ic = spd_main.Sheets[0].ActiveColumnIndex ;

				spd_main.Buffer_CellData = (spd_main.Sheets[0].Cells[ir,ic].Value == null) ? "" : spd_main.Sheets[0].Cells[ir,ic].Value.ToString() ;
				
				string s = spd_main.Sheets[0].Columns[ic].CellType.ToString();
				if(s == "CheckBoxCellType" || s == "SSPComboBoxCellType")
				{
					spd_main.Buffer_CellData = "000";
					spd_main.Update_Row(img_Action);
				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditModeOn", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		private void Grid_CellClickProcess()//FarPoint.Win.Spread.CellClickEventArgs e)
		{
			try
			{ 
				int vRow = spd_main.Sheets[0].ActiveRowIndex ;
				int vCol = spd_main.Sheets[0].ActiveColumnIndex ;

				
				CellRange[] vSelectionRange = spd_main.Sheets[0].GetSelections(); 

				if (vSelectionRange != null)
				{
					COM.ComVar.Parameter_PopUp		= new string[2];
					COM.ComVar.Parameter_PopUp[0]	= spd_main.Sheets[0].GetCellType(vRow, vCol).ToString();
					COM.ComVar.Parameter_PopUp[1]	= spd_main.Sheets[0].ColumnHeader.Cells[1,vCol].Text;

					if (_cellTypes.ContainsKey(vCol))
					{
						COM.ComVar.Parameter_PopUp[0]	= ClassLib.ComVar.SSPComboBoxCell;
						ClassLib.ComVar.Parameter_PopUp_Object = new object[]{_cellTypes[vCol]};
					}

					Pop_BP_Purchase_List_Changer pop_changer = new Pop_BP_Purchase_List_Changer();
					pop_changer.ShowDialog();

					if (COM.ComVar.Parameter_PopUp != null)
						for (int i = 0 ; i < vSelectionRange.Length; i++)
						{
							int start_row = vSelectionRange[i].Row;
							int end_row   = vSelectionRange[i].Row + vSelectionRange[i].RowCount;

							for (int j = start_row ; j < end_row; j++)
							{
								if ( spd_main.Sheets[0].GetCellType(vRow, vCol).ToString() == "DateTimeCellType")
									spd_main.Sheets[0].Cells[j, vCol].Value = DateTime.Parse(COM.ComVar.Parameter_PopUp[0]);
								else
									spd_main.Sheets[0].Cells[j, vCol].Value = COM.ComVar.Parameter_PopUp[0];

								spd_main.Update_Row(j, img_Action);
							}
						}

					pop_changer.Dispose();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "menuitem_ValueExchange_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion


		#region Validate Check

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_Factory.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Factory", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_Factory.Focus();
				return false;
			}  
			return true;
		}

		#endregion

		#region 툴바 메뉴 이벤트 메서드

		
		private void Tbtn_SaveProcess()
		{
			try
			{ 
				bool save_flag = false;

				save_flag = MyOraDB.Save_Spread("PKG_SBP_CONFIRM_REPORT.SAVE_SBP_CONFIRM_REPORT", spd_main); 

				if(!save_flag)
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					return;
				}
				else
				{ 
					Search();
					MessageBox.Show(this, "Save Complete!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
				}
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Item", MessageBoxButtons.OK, MessageBoxIcon.Error); 
			}
		}


		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{
  
			//C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_DPO_From, cmb_DPO_To, cmb_DP_From, cmb_DP_To, cmb_PA_From, cmb_PA_To};   
			C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_DPO_From, cmb_DPO_To};   
			bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
			if(! essential_check) return;

			string factory  = cmb_Factory.SelectedValue.ToString(); 
			string dpo_from = cmb_DPO_From.SelectedValue.ToString();
			string dpo_to   = cmb_DPO_To.SelectedValue.ToString();
			string dp_from  = ClassLib.ComFunction.Empty_Combo(cmb_DP_From, "X");
			string dp_to    = ClassLib.ComFunction.Empty_Combo(cmb_DP_To, "X");
			string pa_from  = ClassLib.ComFunction.Empty_Combo(cmb_PA_From, "X");
			string pa_to    = ClassLib.ComFunction.Empty_Combo(cmb_PA_To, "X");
			string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

			
			string[] parameter = new string[] {factory, dpo_from, dpo_to, dp_from, dp_to, pa_from, pa_to, style_cd};

			DataTable dt_ret = SELECT_SBP_CFM_REPORT(parameter); 
			 
			
			if(dt_ret == null || dt_ret.Rows.Count == 0) 
			{
				spd_main.ClearAll();   
			}
 
			spd_main.ClearAll();   
			spd_main.Display_Grid(dt_ret); 

		}



		private void RunProcess_New()
		{
			System.Threading.Thread tRun = new System.Threading.Thread(new System.Threading.ThreadStart(Run_NewStyle));
			tRun.Start();

			_pop = new Pop_BP_Purchase_Wait();
			_pop.Processing();
			_pop.Start();
		}

		
		private void Run_NewStyle()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_DPO_From, cmb_DPO_To, cmb_DP_From, cmb_DP_To, cmb_PA_From, cmb_PA_To};   
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				string factory  = cmb_Factory.SelectedValue.ToString(); 
				string dpo_from = cmb_DPO_From.SelectedValue.ToString();
				string dpo_to    = cmb_DPO_To.SelectedValue.ToString();
				string dp_from  = cmb_DP_From.SelectedValue.ToString();
				string dp_to    = cmb_DP_To.SelectedValue.ToString();
				string pa_from  = cmb_PA_From.SelectedValue.ToString();
				string pa_to    = cmb_PA_To.SelectedValue.ToString();
				string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

				string[] parameter = new string[] {factory, dpo_from, dpo_to, dp_from, dp_to, pa_from, pa_to, COM.ComVar.This_User};


				if (RUN_NEW_STYLE(parameter))
				{
					ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_pop.Close();
				this.Cursor = Cursors.Default;
			}
		}



		private void RunProcess_Info()
		{
			System.Threading.Thread tRun = new System.Threading.Thread(new System.Threading.ThreadStart(Run_StyleInfo));
			tRun.Start();

			_pop = new Pop_BP_Purchase_Wait();
			_pop.Processing();
			_pop.Start();
		}

		
		private void Run_StyleInfo()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_DPO_From, cmb_DPO_To, cmb_DP_From, cmb_DP_To, cmb_PA_From, cmb_PA_To};   
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				string factory  = cmb_Factory.SelectedValue.ToString(); 
				string dpo_from = cmb_DPO_From.SelectedValue.ToString();
				string dpo_to   = cmb_DPO_To.SelectedValue.ToString();
				string dp_from  = cmb_DP_From.SelectedValue.ToString();
				string dp_to    = cmb_DP_To.SelectedValue.ToString();
				string pa_from  = cmb_PA_From.SelectedValue.ToString();
				string pa_to    = cmb_PA_To.SelectedValue.ToString();
				string style_cd = ClassLib.ComFunction.Empty_TextBox(txt_StyleCd, " ").Replace("-", "");

				string[] parameter = new string[] {factory, dpo_from, dpo_to, dp_from, dp_to, pa_from, pa_to, COM.ComVar.This_User};


				if (RUN_STYLE_INFO(parameter))
				{
					ClassLib.ComFunction.User_Message("Processing Complete.", "Processing", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_pop.Close();
				this.Cursor = Cursors.Default;
			}
		}


		#endregion 


		#region DB Connect

		 
		/// <summary>
		/// RUN_NEW_STYLE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private bool RUN_NEW_STYLE(string[] arg_parameter)
		{

			try 
			{
				MyOraDB.ReDim_Parameter(8);  

				//01.PROCEDURE명 

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBP_CONFIRM_REPORT.RUN_NEW_STYLE"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DPO_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_DPO_TO";
				MyOraDB.Parameter_Name[3] = "ARG_DP_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_DP_TO"; 
				MyOraDB.Parameter_Name[5] = "ARG_PA_FROM";
				MyOraDB.Parameter_Name[6] = "ARG_PA_TO"; 
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4];
				MyOraDB.Parameter_Values[5] = arg_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_parameter[6];
				MyOraDB.Parameter_Values[7] = arg_parameter[7];
				
				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_NEW_STYLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		
		 
		/// <summary>
		/// RUN_STYLE_INFO : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private bool RUN_STYLE_INFO(string[] arg_parameter)
		{

			try 
			{
				MyOraDB.ReDim_Parameter(8);  

				//01.PROCEDURE명 

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBP_CONFIRM_REPORT.RUN_STYLE_INFO"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DPO_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_DPO_TO";
				MyOraDB.Parameter_Name[3] = "ARG_DP_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_DP_TO"; 
				MyOraDB.Parameter_Name[5] = "ARG_PA_FROM";
				MyOraDB.Parameter_Name[6] = "ARG_PA_TO"; 
				MyOraDB.Parameter_Name[7] = "ARG_UPD_USER"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4];
				MyOraDB.Parameter_Values[5] = arg_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_parameter[6];
				MyOraDB.Parameter_Values[7] = arg_parameter[7];

				MyOraDB.Add_Modify_Parameter(true);
				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "RUN_STYLE_INFO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
		}

		/// <summary>
		/// SELECT_SBP_CFM_REPORT : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_SBP_CFM_REPORT(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(9);  

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBP_CONFIRM_REPORT.SELECT_STYLE_LIST"; 

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_DPO_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_DPO_TO";
				MyOraDB.Parameter_Name[3] = "ARG_DP_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_DP_TO";
				MyOraDB.Parameter_Name[5] = "ARG_PA_FROM";
				MyOraDB.Parameter_Name[6] = "ARG_PA_TO";
				MyOraDB.Parameter_Name[7] = "ARG_STYLE_CD"; 
				MyOraDB.Parameter_Name[8] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2]; 
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4];
				MyOraDB.Parameter_Values[5] = arg_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_parameter[6];
				MyOraDB.Parameter_Values[7] = arg_parameter[7];
				MyOraDB.Parameter_Values[8] = ""; 

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBP_CFM_REPORT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}
		#endregion;

	



	}
}

