using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing; 
using System.Windows.Forms; 
using Lassalle.Flow;

namespace FlexPurchase.Search
{
	public class Form_BW_Style_LifeCycle : COM.PCHWinForm.Form_Top
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
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_Factory; 
		private System.Windows.Forms.Panel pnl_low; 
		private System.Windows.Forms.GroupBox gb_Result;
		private System.Windows.Forms.TextBox txt_Result; 
		private C1.Win.C1List.C1Combo cmb_StyleCd;
		private System.Windows.Forms.TextBox txt_Presto;
		private System.Windows.Forms.TextBox txt_StyleCd;
		private System.Windows.Forms.TextBox txt_Gender;
		private System.Windows.Forms.Label lbl_Gender;
		private System.Windows.Forms.Label lbl_Style;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private System.Windows.Forms.Label lbl_DP_DPO;
		private C1.Win.C1List.C1Combo cmb_SearchOption;
		private System.Windows.Forms.Label lbl_Option;
		private System.Windows.Forms.Label lblexcep_mark;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private System.Windows.Forms.Label lbl_OBSType;
		private Lassalle.Flow.AddFlow addflow_Main; 

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB(); 

		private const int _Search_DP = 1;
		private const int _Search_DPO = 2;  


		#endregion

		#region 생성자 / 소멸자


		private string _Factory = "";
		private string _StyleCd = "";
		private string _OBSID = "";
		private string _OBSType = "";

		public Form_BW_Style_LifeCycle()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			Init_Form();
		}
 
		

		public Form_BW_Style_LifeCycle(string arg_factory, string arg_style_cd, string arg_obs_id, string arg_obs_type)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.


			_Factory = arg_factory;
			_StyleCd = arg_style_cd;
			_OBSID = arg_obs_id;
			_OBSType = arg_obs_type;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BW_Style_LifeCycle));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.addflow_Main = new Lassalle.Flow.AddFlow();
            this.pnl_low = new System.Windows.Forms.Panel();
            this.gb_Result = new System.Windows.Forms.GroupBox();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.cmb_OBSType = new C1.Win.C1List.C1Combo();
            this.lbl_OBSType = new System.Windows.Forms.Label();
            this.cmb_To = new C1.Win.C1List.C1Combo();
            this.cmb_From = new C1.Win.C1List.C1Combo();
            this.lbl_DP_DPO = new System.Windows.Forms.Label();
            this.cmb_SearchOption = new C1.Win.C1List.C1Combo();
            this.lbl_Option = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.cmb_StyleCd = new C1.Win.C1List.C1Combo();
            this.txt_Presto = new System.Windows.Forms.TextBox();
            this.txt_StyleCd = new System.Windows.Forms.TextBox();
            this.txt_Gender = new System.Windows.Forms.TextBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_low.SuspendLayout();
            this.gb_Result.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.addflow_Main);
            this.c1Sizer1.Controls.Add(this.pnl_low);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = "15.7986111111111:False:True;82.8125:False:False;0:False:True;\t0.393700787401575:F" +
                "alse:True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 576);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // addflow_Main
            // 
            this.addflow_Main.AutoScroll = true;
            this.addflow_Main.AutoScrollMinSize = new System.Drawing.Size(1156, 607);
            this.addflow_Main.BackColor = System.Drawing.SystemColors.Window;
            this.addflow_Main.CanChangeDst = false;
            this.addflow_Main.CanChangeOrg = false;
            this.addflow_Main.CanDrawLink = false;
            this.addflow_Main.CanDrawNode = false;
            this.addflow_Main.CanLabelEdit = false;
            this.addflow_Main.CanMoveNode = false;
            this.addflow_Main.CanSizeNode = false;
            this.addflow_Main.Location = new System.Drawing.Point(8, 95);
            this.addflow_Main.Name = "addflow_Main";
            this.addflow_Main.Size = new System.Drawing.Size(1000, 477);
            this.addflow_Main.TabIndex = 176;
            this.addflow_Main.Click += new System.EventHandler(this.addflow_Main_Click);
            // 
            // pnl_low
            // 
            this.pnl_low.BackColor = System.Drawing.Color.Transparent;
            this.pnl_low.Controls.Add(this.gb_Result);
            this.pnl_low.Location = new System.Drawing.Point(8, 576);
            this.pnl_low.Name = "pnl_low";
            this.pnl_low.Size = new System.Drawing.Size(1008, 0);
            this.pnl_low.TabIndex = 175;
            // 
            // gb_Result
            // 
            this.gb_Result.Controls.Add(this.txt_Result);
            this.gb_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Result.Location = new System.Drawing.Point(0, 0);
            this.gb_Result.Name = "gb_Result";
            this.gb_Result.Size = new System.Drawing.Size(1008, 0);
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
            this.pnl_head.Controls.Add(this.cmb_OBSType);
            this.pnl_head.Controls.Add(this.lbl_OBSType);
            this.pnl_head.Controls.Add(this.cmb_To);
            this.pnl_head.Controls.Add(this.cmb_From);
            this.pnl_head.Controls.Add(this.lbl_DP_DPO);
            this.pnl_head.Controls.Add(this.cmb_SearchOption);
            this.pnl_head.Controls.Add(this.lbl_Option);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.cmb_StyleCd);
            this.pnl_head.Controls.Add(this.txt_Presto);
            this.pnl_head.Controls.Add(this.txt_StyleCd);
            this.pnl_head.Controls.Add(this.txt_Gender);
            this.pnl_head.Controls.Add(this.lbl_Gender);
            this.pnl_head.Controls.Add(this.lbl_Style);
            this.pnl_head.Controls.Add(this.cmb_Factory);
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
            this.pnl_head.Size = new System.Drawing.Size(1000, 91);
            this.pnl_head.TabIndex = 2;
            // 
            // cmb_OBSType
            // 
            this.cmb_OBSType.AddItemSeparator = ';';
            this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSType.Caption = "";
            this.cmb_OBSType.CaptionHeight = 17;
            this.cmb_OBSType.CaptionStyle = style1;
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
            this.cmb_OBSType.EvenRowStyle = style2;
            this.cmb_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.FooterStyle = style3;
            this.cmb_OBSType.HeadingStyle = style4;
            this.cmb_OBSType.HighLightRowStyle = style5;
            this.cmb_OBSType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSType.Images"))));
            this.cmb_OBSType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSType.ItemHeight = 15;
            this.cmb_OBSType.Location = new System.Drawing.Point(765, 62);
            this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSType.MaxDropDownItems = ((short)(5));
            this.cmb_OBSType.MaxLength = 32767;
            this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSType.Name = "cmb_OBSType";
            this.cmb_OBSType.OddRowStyle = style6;
            this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.SelectedStyle = style7;
            this.cmb_OBSType.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSType.Style = style8;
            this.cmb_OBSType.TabIndex = 548;
            this.cmb_OBSType.SelectedValueChanged += new System.EventHandler(this.cmb_OBSType_SelectedValueChanged);
            this.cmb_OBSType.PropBag = resources.GetString("cmb_OBSType.PropBag");
            // 
            // lbl_OBSType
            // 
            this.lbl_OBSType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSType.ImageIndex = 0;
            this.lbl_OBSType.ImageList = this.img_Label;
            this.lbl_OBSType.Location = new System.Drawing.Point(664, 62);
            this.lbl_OBSType.Name = "lbl_OBSType";
            this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSType.TabIndex = 549;
            this.lbl_OBSType.Text = "OBS Type";
            this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_To
            // 
            this.cmb_To.AddItemSeparator = ';';
            this.cmb_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_To.Caption = "";
            this.cmb_To.CaptionHeight = 17;
            this.cmb_To.CaptionStyle = style9;
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
            this.cmb_To.EvenRowStyle = style10;
            this.cmb_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_To.FooterStyle = style11;
            this.cmb_To.HeadingStyle = style12;
            this.cmb_To.HighLightRowStyle = style13;
            this.cmb_To.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_To.Images"))));
            this.cmb_To.ItemHeight = 15;
            this.cmb_To.Location = new System.Drawing.Point(548, 62);
            this.cmb_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_To.MaxDropDownItems = ((short)(5));
            this.cmb_To.MaxLength = 32767;
            this.cmb_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.OddRowStyle = style14;
            this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_To.SelectedStyle = style15;
            this.cmb_To.Size = new System.Drawing.Size(99, 21);
            this.cmb_To.Style = style16;
            this.cmb_To.TabIndex = 547;
            this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            this.cmb_To.PropBag = resources.GetString("cmb_To.PropBag");
            // 
            // cmb_From
            // 
            this.cmb_From.AddItemSeparator = ';';
            this.cmb_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_From.Caption = "";
            this.cmb_From.CaptionHeight = 17;
            this.cmb_From.CaptionStyle = style17;
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
            this.cmb_From.EvenRowStyle = style18;
            this.cmb_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_From.FooterStyle = style19;
            this.cmb_From.HeadingStyle = style20;
            this.cmb_From.HighLightRowStyle = style21;
            this.cmb_From.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_From.Images"))));
            this.cmb_From.ItemHeight = 15;
            this.cmb_From.Location = new System.Drawing.Point(437, 62);
            this.cmb_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_From.MaxDropDownItems = ((short)(5));
            this.cmb_From.MaxLength = 32767;
            this.cmb_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.OddRowStyle = style22;
            this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_From.SelectedStyle = style23;
            this.cmb_From.Size = new System.Drawing.Size(99, 21);
            this.cmb_From.Style = style24;
            this.cmb_From.TabIndex = 546;
            this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            this.cmb_From.PropBag = resources.GetString("cmb_From.PropBag");
            // 
            // lbl_DP_DPO
            // 
            this.lbl_DP_DPO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_DP_DPO.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DP_DPO.ImageIndex = 0;
            this.lbl_DP_DPO.ImageList = this.img_Label;
            this.lbl_DP_DPO.Location = new System.Drawing.Point(336, 62);
            this.lbl_DP_DPO.Name = "lbl_DP_DPO";
            this.lbl_DP_DPO.Size = new System.Drawing.Size(100, 21);
            this.lbl_DP_DPO.TabIndex = 545;
            this.lbl_DP_DPO.Text = "DP/ DPO";
            this.lbl_DP_DPO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_SearchOption
            // 
            this.cmb_SearchOption.AddItemSeparator = ';';
            this.cmb_SearchOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_SearchOption.Caption = "";
            this.cmb_SearchOption.CaptionHeight = 17;
            this.cmb_SearchOption.CaptionStyle = style25;
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
            this.cmb_SearchOption.EvenRowStyle = style26;
            this.cmb_SearchOption.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SearchOption.FooterStyle = style27;
            this.cmb_SearchOption.HeadingStyle = style28;
            this.cmb_SearchOption.HighLightRowStyle = style29;
            this.cmb_SearchOption.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_SearchOption.Images"))));
            this.cmb_SearchOption.ItemHeight = 15;
            this.cmb_SearchOption.Location = new System.Drawing.Point(109, 62);
            this.cmb_SearchOption.MatchEntryTimeout = ((long)(2000));
            this.cmb_SearchOption.MaxDropDownItems = ((short)(5));
            this.cmb_SearchOption.MaxLength = 32767;
            this.cmb_SearchOption.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_SearchOption.Name = "cmb_SearchOption";
            this.cmb_SearchOption.OddRowStyle = style30;
            this.cmb_SearchOption.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_SearchOption.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_SearchOption.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_SearchOption.SelectedStyle = style31;
            this.cmb_SearchOption.Size = new System.Drawing.Size(210, 21);
            this.cmb_SearchOption.Style = style32;
            this.cmb_SearchOption.TabIndex = 544;
            this.cmb_SearchOption.SelectedValueChanged += new System.EventHandler(this.cmb_SearchOption_SelectedValueChanged);
            this.cmb_SearchOption.PropBag = resources.GetString("cmb_SearchOption.PropBag");
            // 
            // lbl_Option
            // 
            this.lbl_Option.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Option.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Option.ImageIndex = 0;
            this.lbl_Option.ImageList = this.img_Label;
            this.lbl_Option.Location = new System.Drawing.Point(8, 62);
            this.lbl_Option.Name = "lbl_Option";
            this.lbl_Option.Size = new System.Drawing.Size(100, 21);
            this.lbl_Option.TabIndex = 543;
            this.lbl_Option.Text = "Search Option";
            this.lbl_Option.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(536, 64);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 542;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_StyleCd
            // 
            this.cmb_StyleCd.AddItemSeparator = ';';
            this.cmb_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_StyleCd.Caption = "";
            this.cmb_StyleCd.CaptionHeight = 17;
            this.cmb_StyleCd.CaptionStyle = style33;
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
            this.cmb_StyleCd.EvenRowStyle = style34;
            this.cmb_StyleCd.FooterStyle = style35;
            this.cmb_StyleCd.HeadingStyle = style36;
            this.cmb_StyleCd.HighLightRowStyle = style37;
            this.cmb_StyleCd.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_StyleCd.Images"))));
            this.cmb_StyleCd.ItemHeight = 15;
            this.cmb_StyleCd.Location = new System.Drawing.Point(513, 40);
            this.cmb_StyleCd.MatchEntryTimeout = ((long)(2000));
            this.cmb_StyleCd.MaxDropDownItems = ((short)(5));
            this.cmb_StyleCd.MaxLength = 32767;
            this.cmb_StyleCd.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_StyleCd.Name = "cmb_StyleCd";
            this.cmb_StyleCd.OddRowStyle = style38;
            this.cmb_StyleCd.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_StyleCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_StyleCd.SelectedStyle = style39;
            this.cmb_StyleCd.Size = new System.Drawing.Size(134, 21);
            this.cmb_StyleCd.Style = style40;
            this.cmb_StyleCd.TabIndex = 537;
            this.cmb_StyleCd.SelectedValueChanged += new System.EventHandler(this.cmb_StyleCd_SelectedValueChanged);
            this.cmb_StyleCd.PropBag = resources.GetString("cmb_StyleCd.PropBag");
            // 
            // txt_Presto
            // 
            this.txt_Presto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Presto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Presto.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Presto.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Presto.Location = new System.Drawing.Point(870, 40);
            this.txt_Presto.MaxLength = 100;
            this.txt_Presto.Name = "txt_Presto";
            this.txt_Presto.ReadOnly = true;
            this.txt_Presto.Size = new System.Drawing.Size(105, 21);
            this.txt_Presto.TabIndex = 541;
            // 
            // txt_StyleCd
            // 
            this.txt_StyleCd.BackColor = System.Drawing.Color.White;
            this.txt_StyleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_StyleCd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_StyleCd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_StyleCd.Location = new System.Drawing.Point(437, 40);
            this.txt_StyleCd.MaxLength = 10;
            this.txt_StyleCd.Name = "txt_StyleCd";
            this.txt_StyleCd.Size = new System.Drawing.Size(75, 21);
            this.txt_StyleCd.TabIndex = 540;
            this.txt_StyleCd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_StyleCd_KeyUp);
            // 
            // txt_Gender
            // 
            this.txt_Gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Gender.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_Gender.Location = new System.Drawing.Point(765, 40);
            this.txt_Gender.MaxLength = 100;
            this.txt_Gender.Name = "txt_Gender";
            this.txt_Gender.ReadOnly = true;
            this.txt_Gender.Size = new System.Drawing.Size(104, 21);
            this.txt_Gender.TabIndex = 536;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Gender.ImageIndex = 0;
            this.lbl_Gender.ImageList = this.img_Label;
            this.lbl_Gender.Location = new System.Drawing.Point(664, 40);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_Gender.TabIndex = 539;
            this.lbl_Gender.Text = "Gender/ Presto";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Style.ImageIndex = 1;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(336, 40);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 538;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      Style Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 75);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 74);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 50);
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
            this.pic_head5.Location = new System.Drawing.Point(0, 75);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 73);
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
            // Form_BW_Style_LifeCycle
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BW_Style_LifeCycle";
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
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_SearchOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_StyleCd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
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

				// Search Option
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxLocalSearchOption); //"SBM18"
				ClassLib.ComCtl.Set_ComboList(dt_ret,cmb_SearchOption, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 

				// obs type set
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBSType);
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, true, ClassLib.ComVar.ComboList_Visible.Code_Name); 


				dt_ret.Dispose(); 


				ClassLib.ComFunction.Clear_AddFlow(addflow_Main);


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	

		}

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


		private void cmb_StyleCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
			try
			{
				if(cmb_Factory.SelectedIndex == -1 || cmb_StyleCd.SelectedIndex == -1) return; 

				txt_Gender.Text = ""; 
				txt_Presto.Text = ""; 
				ClassLib.ComFunction.Clear_AddFlow(addflow_Main);


				txt_StyleCd.Text = cmb_StyleCd.SelectedValue.ToString();  
				txt_Gender.Text = cmb_StyleCd.Columns[2].Text; 
				txt_Presto.Text = cmb_StyleCd.Columns[3].Text;




			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_StyleCd_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


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
				//ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
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
				ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_To_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cmb_OBSType_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				ClassLib.ComFunction.Clear_AddFlow(addflow_Main);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}



		
		private void addflow_Main_Click(object sender, System.EventArgs e)
		{
		
			try
			{
				Draw_Link_Select();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "addflow_Main_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			this.Text = "Order Life Cycle (2)";
			lbl_MainTitle.Text = "Order Life Cycle (2)";
            ClassLib.ComFunction.SetLangDic(this);

			ClassLib.ComFunction.Clear_AddFlow(addflow_Main);


			//combobox setting
			Init_Control(); 

			

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
			tbtn_Save.Enabled = false; 
			tbtn_Print.Enabled = false;


			// factory set  
			dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			

			if(_Factory == "")
			{
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
			}
			else
			{
				cmb_Factory.SelectedValue = _Factory;
			}
		  

			if(_StyleCd != "")
			{
				txt_StyleCd.Text = _StyleCd;
				Set_StyleCode(); 
			}


			cmb_SearchOption.SelectedValue = _Search_DPO.ToString();
			
			if(_OBSID != "")
			{
				cmb_From.SelectedValue = _OBSID;
				//cmb_To.SelectedValue = _OBSID;

				Search();
			}

			

			dt_ret.Dispose(); 

  

		}


		/// <summary>
		/// Set_StyleCode : 스타일 콤보 세팅
		/// </summary>
		private void Set_StyleCode()
		{
 
			//-------------------------------------------------------------------------
			// 기타 콘트롤 초기화 
			cmb_StyleCd.SelectedIndex = -1;  

			txt_Gender.Text = ""; 
			txt_Presto.Text = "";
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


		/// <summary>
		/// Change_SearchOption : 
		/// </summary>
		private void Change_SearchOption()
		{
			
			if(cmb_Factory.SelectedIndex == -1 || cmb_SearchOption.SelectedIndex == -1) return;

			 
 
			// 그리드 헤더, from~to 세팅
			string search_option = ClassLib.ComFunction.Empty_Combo(cmb_SearchOption, "0");

			if(cmb_SearchOption.SelectedValue.ToString().Trim().Equals("") )
			{
				search_option = "0";
			}

			switch( Convert.ToInt32(search_option) )
			{
				case _Search_DP : 
					lbl_DP_DPO.Text = "DP";  
					break;

				case _Search_DPO : 
					lbl_DP_DPO.Text = "DPO"; 
					break;

				default:
					cmb_From.DataSource = null;
					cmb_To.DataSource = null;

					cmb_From.SelectedIndex = -1;
					cmb_To.SelectedIndex = -1;   
					break;
			} 

			
			if(Convert.ToInt32(search_option) != 0)
			{
				DataTable dt_ret = ClassLib.ComVar.Select_DP_DPO_List(cmb_Factory.SelectedValue.ToString(), cmb_SearchOption.SelectedValue.ToString() );
				COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
				COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
			}


			ClassLib.ComFunction.Clear_AddFlow(addflow_Main);


		}



 
		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{
			
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory; 
			txt_StyleCd.Text = "";
			cmb_StyleCd.SelectedIndex = -1;
			txt_Gender.Text = "";
			txt_Presto.Text = "";
			cmb_SearchOption.SelectedIndex = -1;
			cmb_From.SelectedIndex = -1;
			cmb_To.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1;
			  
			ClassLib.ComFunction.Clear_AddFlow(addflow_Main);

		}





		DataTable _DT_BP;
		DataTable _DT_OBS;
		DataTable _DT_REQ;
		DataTable _DT_LOT;
		DataTable _DT_SS;

		ClassLib.Class_PERT_Detail[] _DP_BP;
		ClassLib.Class_PERT_Detail[] _DP_OBS;
		ClassLib.Class_PERT_Detail[] _DP_REQ;
		ClassLib.Class_PERT_Detail[] _DP_LOT;
		ClassLib.Class_PERT_Detail[] _DP_SS;


		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{  

 
			try
			{

				this.Cursor = Cursors.WaitCursor;


				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory};   
				System.Windows.Forms.TextBox[] txt_array = {txt_StyleCd};  
				bool essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, txt_array);  
				if(! essential_check) return;


				ClassLib.ComFunction.Clear_AddFlow(addflow_Main); 



		 			 
				string factory = cmb_Factory.SelectedValue.ToString();
				string style_cd = txt_StyleCd.Text.Trim().Replace("-", "");
				string from = ClassLib.ComFunction.Empty_Combo(cmb_From, "-1");
				string to = ClassLib.ComFunction.Empty_Combo(cmb_To, "-1");
				string obs_type = ClassLib.ComFunction.Empty_Combo(cmb_OBSType, " ");   

				string[] parameter = new string[] {factory, style_cd, from, to, obs_type}; 
  




				string search_option = ClassLib.ComFunction.Empty_Combo(cmb_SearchOption, "0");

				if(cmb_SearchOption.SelectedIndex == -1 ||  cmb_SearchOption.SelectedValue.ToString().Trim().Equals("") )
				{
					search_option = "0";
				}

				switch( Convert.ToInt32(search_option) )
				{
					case _Search_DP: 

						int left_point_bp = 10;

						_DT_BP = SELECT_STYLE_LIFE_CYCLE_BP(parameter);

						Draw_Node("BP", _DT_BP, _DP_BP, left_point_bp, 4);

						break;

					case _Search_DPO: 

						DataSet ds_ret = SELECT_STYLE_LIFE_CYCLE(parameter);

						_DT_OBS = ds_ret.Tables["PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_OBS"];
						_DT_REQ = ds_ret.Tables["PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_REQ"];
						_DT_LOT = ds_ret.Tables["PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SPO_LOT"];
						_DT_SS = ds_ret.Tables["PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SBM_SHIPPING_SCHEDULE"]; 
 

						

						// 1. sem_obs
						// 2. sem_req
						// 3. spo_lot
						// 4. sbm_shipping_sechdule

						int left_point_obs = 10; 

						int next_left_point = Draw_Node("OBS", _DT_OBS, _DP_OBS, left_point_obs, 6);


						if(next_left_point != -1)
						{ 
							next_left_point = Draw_Node("REQ", _DT_REQ, _DP_REQ, next_left_point, 6); 

							if(next_left_point != -1)
							{ 
								Draw_Link(_DP_OBS, _DP_REQ);

								next_left_point = Draw_Node("LOT", _DT_LOT, _DP_LOT, next_left_point, 10);

								if(next_left_point != -1)
								{
									Draw_Link(_DP_REQ, _DP_LOT);

									next_left_point = Draw_Node("SS", _DT_SS, _DP_SS, next_left_point, 6);


									if(next_left_point != -1)
									{

										Draw_Link(_DP_LOT, _DP_SS);

									} // end if Draw_Node(_DT_SS

								} // end if Draw_Node(_DT_LOT


							} // end if Draw_Node(_DT_REQ

						} // end if Draw_Node(_DT_OBS


						break;

					default: 
						break;
				}




				




			}
			catch
			{
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
				
			
		}  



		private int Draw_Node(string arg_division, DataTable arg_dt, ClassLib.Class_PERT_Detail[] arg_dp, int arg_left_point, int arg_display_col_count)
		{

			try
			{


				int start_row = 0;
				int count_group1 = 0;
				int count_group2 = 0;
				int count_group3 = 0;
				int division = 0;
				int top = 10;
				int now_draw_count = 0;


				// group 1 count
				count_group1 = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxGROUP1_COUNT].ToString() );
				arg_dp = new ClassLib.Class_PERT_Detail[count_group1];




				while(true)
				{
				 
					division = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxDIVISION].ToString());
 
					if(division == 2) 
					{
						Draw_Node_Key2(arg_dt, arg_dp, start_row);
						break;
					} 

					count_group2 = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxGROUP2_COUNT].ToString());
					
					if(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxGROUP3_COUNT].ToString() == "")
					{
						count_group3 = 0;
					}
					else
					{
						count_group3 = Convert.ToInt32(arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxGROUP3_COUNT].ToString());
					}


					DataRow[] dr = new DataRow[count_group2];

					for(int i = start_row; i < count_group2 + start_row; i++)
					{
						dr[i - start_row] = arg_dt.Rows[i];
					}


					// group 1
					arg_dp[now_draw_count] = new ClassLib.Class_PERT_Detail(); 


					//(DataRow[], addflow, left, top, width, height)
					//return :top : 다음 그릴 셋트의 시작점 

					arg_dp[now_draw_count].ParaList.arg_row = dr;
					arg_dp[now_draw_count].ParaList.arg_addflow = addflow_Main;
					arg_dp[now_draw_count].ParaList.arg_left = arg_left_point;
					arg_dp[now_draw_count].ParaList.arg_top = top + 5;
					arg_dp[now_draw_count].ParaList.arg_width = 120;
					arg_dp[now_draw_count].ParaList.arg_height = 10;
					arg_dp[now_draw_count].ParaList.arg_type = 0;
					arg_dp[now_draw_count].ParaList.arg_colcount = arg_display_col_count;
					arg_dp[now_draw_count].ParaList.arg_rowcount = dr.Length + 1;
					arg_dp[now_draw_count].ParaList.arg_detailyn = false; 

					top = arg_dp[now_draw_count].DOrder();

					top += (count_group3 * arg_dp[now_draw_count].ParaList.arg_height);

					//-----------------------------------------------------------------------------
					//text, tag, tooltip 속성 적용

					
					string[] token_text = dr[0].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxKEY1].ToString().Split('^');
					arg_dp[now_draw_count].HeaderCd.Text = token_text[0];
					arg_dp[now_draw_count].HeaderCd.Tag = dr[0].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxKEY1].ToString();
					arg_dp[now_draw_count].HeaderCd.Tooltip = ""; 
				
 


					int start_col = 0; 
					int node_count = 0;

					for(int j = 0; j < arg_dt.Columns.Count; j++)
					{
						
						arg_dp[now_draw_count].DayQty[start_col].Text = arg_dt.Columns[j + (int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxDATA_START].ColumnName.ToString();
						arg_dp[now_draw_count].DayQty[start_col].Tag = arg_dp[now_draw_count].DayQty[start_col].Text; 

						start_col = start_col + count_group2 + 1;
						node_count++;

						if(node_count == arg_display_col_count) break;
							
					}

 
					

					for(int i = 0; i < dr.Length; i++)
					{ 
    
						start_col = i + 1;
						node_count = 0;


						for(int j = 0; j < arg_dt.Columns.Count; j++)
						{
 
							arg_dp[now_draw_count].DayQty[start_col].Text = dr[i].ItemArray[j + (int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxDATA_START].ToString();
							arg_dp[now_draw_count].DayQty[start_col].Tag = arg_dp[now_draw_count].DayQty[start_col].Text; 

							start_col = start_col + count_group2 + 1;
							node_count++;

							if(node_count == arg_display_col_count) break;
							
						} 

						
						

					}

					//-----------------------------------------------------------------------------
 

					if(now_draw_count > count_group1) 
					{
						now_draw_count = 0;
						top = 10;

					} 

					if(count_group2 + start_row > arg_dt.Rows.Count - 1) break;


					start_row = count_group2 + start_row;
					now_draw_count++;


				} // end while

 


 
				if(arg_division == "OBS")
				{
					_DP_OBS = arg_dp;
				}
				else if(arg_division == "REQ")
				{
					_DP_REQ = arg_dp;
				}
				else if(arg_division == "LOT")
				{
					_DP_LOT = arg_dp;
				}
				else if(arg_division == "SS")
				{
					_DP_SS = arg_dp;
				}


				now_draw_count = (now_draw_count == 0) ? 0 : now_draw_count - 1;

				return Convert.ToInt32(arg_dp[now_draw_count].DayQty[arg_dp[now_draw_count].DayQty.Length - 1].Location.X 
					+ arg_dp[now_draw_count].DayQty[arg_dp[now_draw_count].DayQty.Length - 1].Size.Width + 100);


			}
			catch
			{
				return -1;
			}


		}


		 
 
		/// <summary>
		/// Draw_Node_Key2 : 
		/// </summary>
		/// <param name="arg_dt"></param>
		/// <param name="arg_dp"></param>
		/// <param name="arg_start_row"></param>
		private void Draw_Node_Key2(DataTable arg_dt, ClassLib.Class_PERT_Detail[] arg_dp, int arg_start_row)
		{

 

			string before_key1 = "";
			string now_key1 = "";

			int start_row = arg_start_row; 

			while(true)
			{

				now_key1 = arg_dt.Rows[start_row].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxKEY1].ToString();

				if(before_key1 == now_key1)
				{
					start_row++;
					continue;
				}


				

				// 추가
				string condition = "KEY1 = '" + now_key1 + "'" + "AND DIVISION = '2'"; 
				DataRow[] dr = arg_dt.Select(condition); 
			
 
				for(int i = 0; i < arg_dp.Length; i++)
				{ 
					if(arg_dp[i].HeaderCd.Tag.ToString() == now_key1)
					{ 
						arg_dp[i].Draw_Head_Add(dr);

						for(int j = 0; j < dr.Length; j++)
						{
					
							arg_dp[i].DetailCd[j].Text = dr[j].ItemArray[(int)ClassLib.TBSBW_STYLE_LIFECYCLE_COMMON.IxKEY2].ToString();
							arg_dp[i].DetailCd[j].Tag = arg_dp[i].DetailCd[j].Text + "^" + now_key1; 


						} // end for j

						break;
					}

				} // end for i



				


				before_key1 = now_key1;

				if(start_row + dr.Length == arg_dt.Rows.Count) break;

			} 


		}
 


		/// <summary>
		/// Draw_Link : 
		/// </summary>
		/// <param name="arg_dp_1st"></param>
		/// <param name="arg_dp_2nd"></param>
		private void Draw_Link(ClassLib.Class_PERT_Detail[] arg_dp_1st, ClassLib.Class_PERT_Detail[] arg_dp_2nd)
		{ 
			int org_index, dst_index;

			Lassalle.Flow.Link link;

			 
			string[] first_token = null;
			string[] second_token = null;

			for(int i = 0; i < arg_dp_1st.Length; i++)
			{ 

				if(arg_dp_1st[i].DetailCd == null) continue;

				for(int j = 0; j < arg_dp_1st[i].DetailCd.Length; j++)
				{   
 	 
					for(int k = 0; k < arg_dp_2nd.Length; k++)
					{
						first_token = arg_dp_1st[i].DetailCd[j].Tag.ToString().Split('^');
						second_token = arg_dp_2nd[k].HeaderCd.Tag.ToString().Split('^');

						if(first_token[0] == second_token[0])
						{
							org_index = arg_dp_1st[i].DetailCd[j].Index;
							dst_index = arg_dp_2nd[k].HeaderCd.Index;

							link = addflow_Main.Nodes[org_index].OutLinks.Add(addflow_Main.Nodes[dst_index]); 
							Set_Link_Prop(link);

							break;
						}

						 
					} // end for(k, arg_dp_2nd.Length)
				} // end for(j, arg_dp_1st[i].DetailCd.Length) 
			} // end for(i, arg_dp_1st.Length) 


 

		}



		private void Draw_Link_Select()
		{

			Item item = addflow_Main.PointedItem;
			
			Lassalle.Flow.Node node;    
			Lassalle.Flow.Node now_node;    
			Lassalle.Flow.Link link; 

			// 초기화 ------------------------------------------
			foreach(Item item_link in addflow_Main.Items)
			{
				if(item_link is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item_link;

					Set_Link_Prop(link);

				} // end if
			} // end foreadch
			//--------------------------------------------------
   

			if (item is Lassalle.Flow.Node)
			{
				node = (Lassalle.Flow.Node)item;  

				if(node.Tag == null) return; 
				 

				foreach(Item item_node in addflow_Main.Items)
				{
					if(item_node is Lassalle.Flow.Node)
					{
						now_node = (Lassalle.Flow.Node)item_node;

						if(now_node.Tag == null || now_node.Tag.ToString() == "") continue;
						
						Display_Link_Select_Color_1(node, now_node.Index, true); 
						 

					} // end if
				} // end foreadch 

 
				
				
			} // end if (item is Lassalle.Flow.Node)

 
		}


		private void Display_Link_Select_Color_1(Lassalle.Flow.Node arg_sel_node, int arg_node_index, bool arg_first_time)
		{

			 			
			if(addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').GetValue(0).ToString()
				== arg_sel_node.Tag.ToString().Split('^').GetValue(0).ToString() )
			{
				Display_Link_Select_Color_2(arg_sel_node, arg_node_index, arg_first_time);
			}

			if( addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').Length == 2
				&& addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').GetValue(1).ToString()
				== arg_sel_node.Tag.ToString().Split('^').GetValue(0).ToString() )
			{
				Display_Link_Select_Color_2(arg_sel_node, arg_node_index, arg_first_time);
			}

			if( arg_sel_node.Tag.ToString().Split('^').Length == 2
				&& addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').GetValue(0).ToString()
				== arg_sel_node.Tag.ToString().Split('^').GetValue(1).ToString() )
			{
				Display_Link_Select_Color_2(arg_sel_node, arg_node_index, arg_first_time);
			}

			if(addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').Length == 2
				&& arg_sel_node.Tag.ToString().Split('^').Length == 2
				&& addflow_Main.Nodes[arg_node_index].Tag.ToString().Split('^').GetValue(1).ToString()
				== arg_sel_node.Tag.ToString().Split('^').GetValue(1).ToString() )
			{
				Display_Link_Select_Color_2(arg_sel_node, arg_node_index, arg_first_time);
			}

					 


		}

		private void Display_Link_Select_Color_2(Lassalle.Flow.Node arg_sel_node, int arg_node_index, bool arg_first_time)
		{

			Lassalle.Flow.Node now_node;
			Lassalle.Flow.Link link; 

			foreach(Item item_link in addflow_Main.Items)
			{
				if(item_link is Lassalle.Flow.Link)
				{
					link = (Lassalle.Flow.Link)item_link;

					if(link.Org.Index == arg_node_index || link.Dst.Index == arg_node_index)  
					{
						link.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
						link.DrawWidth = 2;
						link.DrawColor = Color.Red; 
 
					}
 


				} // end if
			} // end foreadch 

 
			if(arg_first_time)
			{

				foreach(Item item_node in addflow_Main.Items)
				{
					if(item_node is Lassalle.Flow.Node)
					{
						now_node = (Lassalle.Flow.Node)item_node;

						if(now_node.Tag == null || now_node.Tag.ToString() == "") continue;
						
						Display_Link_Select_Color_1(addflow_Main.Nodes[arg_node_index], now_node.Index, false); 
						 

					} // end if
				} // end foreadch 


			}



		}




		/// <summary>
		/// Set_Link_Prop : 
		/// </summary>
		/// <param name="arg_link"></param>
		private void Set_Link_Prop(Lassalle.Flow.Link arg_link)
		{
				
			arg_link.ArrowDst.Style = Lassalle.Flow.ArrowStyle.Arrow;  
			arg_link.ArrowDst.Size = Lassalle.Flow.ArrowSize.Small; 
			//arg_link.ArrowDst.Angle = Lassalle.Flow.ArrowAngle.deg45; 
			arg_link.ArrowDst.Filled = true;  
			arg_link.ArrowOrg.Style = Lassalle.Flow.ArrowStyle.None;  
			arg_link.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;  
			arg_link.DrawColor = Color.Black; 
			arg_link.DrawWidth = 1; 
			arg_link.Line.Style = LineStyle.HVH; 
			//arg_link.Line.RoundedCorner = true;
  
		}




		



		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{ 

		}



		#endregion  
		
		#endregion

		#region DB Connect

		 

		/// <summary>
		/// SELECT_STYLE_LIFE_CYCLE : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataSet SELECT_STYLE_LIFE_CYCLE(string[] arg_parameter)
		{

			try 
			{

 
				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, obs_type};  

				#region "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_OBS"

				MyOraDB.ReDim_Parameter(6);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_OBS";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = "";  

				MyOraDB.Add_Select_Parameter(true); 

				#endregion

				#region "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_REQ"

				MyOraDB.ReDim_Parameter(6);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_REQ";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = "";  

				MyOraDB.Add_Select_Parameter(false); 

				#endregion

				#region "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SPO_LOT"

				MyOraDB.ReDim_Parameter(6);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SPO_LOT";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = "";  

				MyOraDB.Add_Select_Parameter(false); 

				#endregion

				#region "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SBM_SHIPPING_SCHEDULE"

				MyOraDB.ReDim_Parameter(6);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SBM_SHIPPING_SCHEDULE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = "";  

				MyOraDB.Add_Select_Parameter(false); 

				#endregion 


				ds_ret = MyOraDB.Exe_Select_Procedure();
 
				if(ds_ret == null) return null;
				return ds_ret;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIFE_CYCLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		/// <summary>
		/// SELECT_STYLE_LIFE_CYCLE_BP : 
		/// </summary>
		/// <param name="arg_parameter"></param>
		/// <returns></returns>
		private DataTable SELECT_STYLE_LIFE_CYCLE_BP(string[] arg_parameter)
		{

			try 
			{


				DataSet ds_ret;

				//string[] parameter = new string[] {factory, style_cd, from, to, obs_type};  

				#region "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_BP"

				MyOraDB.ReDim_Parameter(6);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_STYLE_LIFE_CYCLE.SELECT_SEM_BP";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OBS_TYPE";
				MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 
 

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_parameter[4]; 
				MyOraDB.Parameter_Values[5] = "";  

				MyOraDB.Add_Select_Parameter(true); 

				#endregion 


				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[0];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_STYLE_LIFE_CYCLE_BP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}
	

		#endregion	  
		
 


	}
}

