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
	public class  Pop_BW_Order_Analysis_GAC_Score_New : COM.PCHWinForm.Form_Top
	{

		#region 디자이너에서 생성한 멤버

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView sheetView1; 
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label lbl_OBSId;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private C1.Win.C1List.C1Combo cmb_OBSType;
		private System.Windows.Forms.Label lbl_OBSType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private C1.Win.C1List.C1Combo cmb_To;
		private C1.Win.C1List.C1Combo cmb_From;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_Ord;
		private System.Windows.Forms.DateTimePicker dpick_FromOrd; 
		private System.Windows.Forms.DateTimePicker dpick_ToOrd; 


		private System.ComponentModel.IContainer components = null;

		#endregion 
		
		#region 사용자 정의 멤버
 
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		#endregion

		#region 생성자 / 소멸자

		public  Pop_BW_Order_Analysis_GAC_Score_New()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다. 
		}



		private string _Factory;
		private string _OBSType;
		private string _OBSID; 


		public  Pop_BW_Order_Analysis_GAC_Score_New(string arg_factory, string arg_obs_type, string arg_obs_id)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_OBSType = arg_obs_type;
			_OBSID = arg_obs_id; 

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BW_Order_Analysis_GAC_Score_New));
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
            this.dpick_FromOrd = new System.Windows.Forms.DateTimePicker();
            this.dpick_ToOrd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Ord = new System.Windows.Forms.Label();
            this.cmb_To = new C1.Win.C1List.C1Combo();
            this.cmb_From = new C1.Win.C1List.C1Combo();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.lbl_OBSId = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.cmb_OBSType = new C1.Win.C1List.C1Combo();
            this.lbl_OBSType = new System.Windows.Forms.Label();
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
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).BeginInit();
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
            this.stbar.Location = new System.Drawing.Point(0, 487);
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
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "21.7183770883055:False:True;76.3723150357995:False:False;0:False:True;\t0.39370078" +
                "7401575:False:True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 419);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.dpick_FromOrd);
            this.pnl_head.Controls.Add(this.dpick_ToOrd);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.lbl_Ord);
            this.pnl_head.Controls.Add(this.cmb_To);
            this.pnl_head.Controls.Add(this.cmb_From);
            this.pnl_head.Controls.Add(this.lblexcep_mark);
            this.pnl_head.Controls.Add(this.lbl_OBSId);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.cmb_OBSType);
            this.pnl_head.Controls.Add(this.lbl_OBSType);
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
            this.pnl_head.Size = new System.Drawing.Size(1008, 91);
            this.pnl_head.TabIndex = 175;
            // 
            // dpick_FromOrd
            // 
            this.dpick_FromOrd.CustomFormat = "";
            this.dpick_FromOrd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_FromOrd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromOrd.Location = new System.Drawing.Point(437, 62);
            this.dpick_FromOrd.Name = "dpick_FromOrd";
            this.dpick_FromOrd.Size = new System.Drawing.Size(101, 21);
            this.dpick_FromOrd.TabIndex = 554;
            this.dpick_FromOrd.ValueChanged += new System.EventHandler(this.dpick_FromOrd_ValueChanged);
            // 
            // dpick_ToOrd
            // 
            this.dpick_ToOrd.CustomFormat = "";
            this.dpick_ToOrd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ToOrd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToOrd.Location = new System.Drawing.Point(550, 62);
            this.dpick_ToOrd.Name = "dpick_ToOrd";
            this.dpick_ToOrd.Size = new System.Drawing.Size(101, 21);
            this.dpick_ToOrd.TabIndex = 554;
            this.dpick_ToOrd.ValueChanged += new System.EventHandler(this.dpick_ToOrd_ValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(537, 63);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(12, 16);
            this.label1.TabIndex = 552;
            this.label1.Text = "~";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ord
            // 
            this.lbl_Ord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Ord.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ord.ImageIndex = 0;
            this.lbl_Ord.ImageList = this.img_Label;
            this.lbl_Ord.Location = new System.Drawing.Point(336, 62);
            this.lbl_Ord.Name = "lbl_Ord";
            this.lbl_Ord.Size = new System.Drawing.Size(100, 21);
            this.lbl_Ord.TabIndex = 551;
            this.lbl_Ord.Text = "ORD";
            this.lbl_Ord.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_To
            // 
            this.cmb_To.AddItemSeparator = ';';
            this.cmb_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_To.Caption = "";
            this.cmb_To.CaptionHeight = 17;
            this.cmb_To.CaptionStyle = style33;
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
            this.cmb_To.EvenRowStyle = style34;
            this.cmb_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_To.FooterStyle = style35;
            this.cmb_To.HeadingStyle = style36;
            this.cmb_To.HighLightRowStyle = style37;
            this.cmb_To.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_To.Images"))));
            this.cmb_To.ItemHeight = 15;
            this.cmb_To.Location = new System.Drawing.Point(550, 40);
            this.cmb_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_To.MaxDropDownItems = ((short)(5));
            this.cmb_To.MaxLength = 32767;
            this.cmb_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_To.Name = "cmb_To";
            this.cmb_To.OddRowStyle = style38;
            this.cmb_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_To.SelectedStyle = style39;
            this.cmb_To.Size = new System.Drawing.Size(99, 21);
            this.cmb_To.Style = style40;
            this.cmb_To.TabIndex = 550;
            this.cmb_To.SelectedValueChanged += new System.EventHandler(this.cmb_To_SelectedValueChanged);
            this.cmb_To.PropBag = resources.GetString("cmb_To.PropBag");
            // 
            // cmb_From
            // 
            this.cmb_From.AddItemSeparator = ';';
            this.cmb_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_From.Caption = "";
            this.cmb_From.CaptionHeight = 17;
            this.cmb_From.CaptionStyle = style41;
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
            this.cmb_From.EvenRowStyle = style42;
            this.cmb_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_From.FooterStyle = style43;
            this.cmb_From.HeadingStyle = style44;
            this.cmb_From.HighLightRowStyle = style45;
            this.cmb_From.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_From.Images"))));
            this.cmb_From.ItemHeight = 15;
            this.cmb_From.Location = new System.Drawing.Point(437, 40);
            this.cmb_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_From.MaxDropDownItems = ((short)(5));
            this.cmb_From.MaxLength = 32767;
            this.cmb_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_From.Name = "cmb_From";
            this.cmb_From.OddRowStyle = style46;
            this.cmb_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_From.SelectedStyle = style47;
            this.cmb_From.Size = new System.Drawing.Size(99, 21);
            this.cmb_From.Style = style48;
            this.cmb_From.TabIndex = 549;
            this.cmb_From.SelectedValueChanged += new System.EventHandler(this.cmb_From_SelectedValueChanged);
            this.cmb_From.PropBag = resources.GetString("cmb_From.PropBag");
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(537, 42);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(12, 16);
            this.lblexcep_mark.TabIndex = 548;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_OBSId
            // 
            this.lbl_OBSId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSId.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSId.ImageIndex = 0;
            this.lbl_OBSId.ImageList = this.img_Label;
            this.lbl_OBSId.Location = new System.Drawing.Point(336, 40);
            this.lbl_OBSId.Name = "lbl_OBSId";
            this.lbl_OBSId.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSId.TabIndex = 544;
            this.lbl_OBSId.Text = "DPO";
            this.lbl_OBSId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style49;
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
            this.cmb_Factory.EvenRowStyle = style50;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style51;
            this.cmb_Factory.HeadingStyle = style52;
            this.cmb_Factory.HighLightRowStyle = style53;
            this.cmb_Factory.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Factory.Images"))));
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 40);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style54;
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style55;
            this.cmb_Factory.Size = new System.Drawing.Size(210, 21);
            this.cmb_Factory.Style = style56;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            // 
            // cmb_OBSType
            // 
            this.cmb_OBSType.AddItemSeparator = ';';
            this.cmb_OBSType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OBSType.Caption = "";
            this.cmb_OBSType.CaptionHeight = 17;
            this.cmb_OBSType.CaptionStyle = style57;
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
            this.cmb_OBSType.EvenRowStyle = style58;
            this.cmb_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OBSType.FooterStyle = style59;
            this.cmb_OBSType.HeadingStyle = style60;
            this.cmb_OBSType.HighLightRowStyle = style61;
            this.cmb_OBSType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_OBSType.Images"))));
            this.cmb_OBSType.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_OBSType.ItemHeight = 15;
            this.cmb_OBSType.Location = new System.Drawing.Point(109, 62);
            this.cmb_OBSType.MatchEntryTimeout = ((long)(2000));
            this.cmb_OBSType.MaxDropDownItems = ((short)(5));
            this.cmb_OBSType.MaxLength = 32767;
            this.cmb_OBSType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OBSType.Name = "cmb_OBSType";
            this.cmb_OBSType.OddRowStyle = style62;
            this.cmb_OBSType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OBSType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OBSType.SelectedStyle = style63;
            this.cmb_OBSType.Size = new System.Drawing.Size(210, 21);
            this.cmb_OBSType.Style = style64;
            this.cmb_OBSType.TabIndex = 537;
            this.cmb_OBSType.SelectedValueChanged += new System.EventHandler(this.cmb_OBSType_SelectedValueChanged);
            this.cmb_OBSType.PropBag = resources.GetString("cmb_OBSType.PropBag");
            // 
            // lbl_OBSType
            // 
            this.lbl_OBSType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OBSType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OBSType.ImageIndex = 0;
            this.lbl_OBSType.ImageList = this.img_Label;
            this.lbl_OBSType.Location = new System.Drawing.Point(8, 62);
            this.lbl_OBSType.Name = "lbl_OBSType";
            this.lbl_OBSType.Size = new System.Drawing.Size(100, 21);
            this.lbl_OBSType.TabIndex = 538;
            this.lbl_OBSType.Text = "OBS Type";
            this.lbl_OBSType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label2.Text = "      Order Information";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(992, 75);
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
            this.pic_head4.Size = new System.Drawing.Size(968, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Factory.ImageIndex = 0;
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
            this.pic_head7.Location = new System.Drawing.Point(907, 30);
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
            this.pic_head2.Location = new System.Drawing.Point(992, 0);
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
            this.pic_head1.Size = new System.Drawing.Size(928, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.BackColor = System.Drawing.Color.Transparent;
            this.spd_main.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spd_main.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.spd_main.Location = new System.Drawing.Point(8, 95);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.sheetView1);
            this.spd_main.Size = new System.Drawing.Size(1000, 320);
            this.spd_main.TabIndex = 174;
            this.spd_main.EditModeOff += new System.EventHandler(this.spd_main_EditModeOff);
            this.spd_main.ButtonClicked += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_ButtonClicked);
            // 
            // sheetView1
            // 
            this.sheetView1.SheetName = "Sheet1";
            // 
            // Pop_BW_Order_Analysis_GAC_Score_New
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 509);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BW_Order_Analysis_GAC_Score_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_To)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OBSType)).EndInit();
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
				COM.ComCtl.Set_ComboList(dt_ret, cmb_From, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 
				COM.ComCtl.Set_ComboList(dt_ret, cmb_To, 0, 0, false, ClassLib.ComVar.ComboList_Visible.Name); 

				// obs type set
				dt_ret = ClassLib.ComVar.Select_ComCode(cmb_Factory.SelectedValue.ToString(), ClassLib.ComVar.CxOBSType);
				COM.ComCtl.Set_ComboList(dt_ret, cmb_OBSType, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 


				dt_ret.Dispose(); 
 

				cmb_Factory.SelectedValue = _Factory;
				cmb_OBSType.SelectedValue = _OBSType;
				cmb_From.SelectedValue = _OBSID;  


				spd_main.ClearAll();



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
 
				if(cmb_To.SelectedIndex == -1) return; 
				
 

				string dpo_to = "20" + cmb_To.SelectedValue.ToString();   // "20" + "070204"
				DateTime dpo_to_1 = new DateTime(Convert.ToInt32(dpo_to.Substring(0, 4)), Convert.ToInt32(dpo_to.Substring(6, 2)), System.DateTime.Now.Day);
 

				string from_date = MyComFunction.ConvertDate2Type(dpo_to.Substring(0, 4) + dpo_to_1.AddMonths(-1).Month.ToString().PadLeft(2, '0') + "01"); //dpo_to.Substring(6, 2)
				string to_date = MyComFunction.ConvertDate2Type(dpo_to.Substring(0, 4) + dpo_to_1.AddMonths(-1).Month.ToString().PadLeft(2, '0') + DateTime.DaysInMonth(dpo_to_1.Year, dpo_to_1.AddMonths(-1).Month).ToString() );
 
				dpick_FromOrd.CustomFormat = "yyyy-MM-dd";
				dpick_ToOrd.CustomFormat = "yyyy-MM-dd";

				dpick_FromOrd.Text = from_date;
				dpick_ToOrd.Text = to_date;


				spd_main.ClearAll();

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
				spd_main.ClearAll();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OBSType_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		private void spd_main_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{
		
			try
			{
				
				int sel_row = spd_main.ActiveSheet.ActiveRowIndex;

				if((bool)spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].Value)
				{  
					//spd_main.ActiveSheet.Rows[sel_row].Locked = false; 
				}
				else
				{ 
					//spd_main.ActiveSheet.Rows[sel_row].Locked = true;
  

					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value = "";
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Value = ""; 

					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value = "";
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value = "";
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value = "";


					Display_Score_Color_Again(sel_row);  


				}

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_ButtonClicked", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

 
	
		private void spd_main_EditModeOff(object sender, System.EventArgs e)
		{
			
			try
			{

				int sel_row = spd_main.ActiveSheet.ActiveRowIndex;
				int sel_col = spd_main.ActiveSheet.ActiveColumnIndex;
	
				if(sel_col == (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_TYPE) return; 
				 

				if(sel_col == (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY 
					|| sel_col == (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY) 
				{
					// launch data total% 계산
					if(spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value != null
						&& spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Value != null
						&& spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value.ToString() != ""
						&& spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Value.ToString() != ""
						&& spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value.ToString() != "0"
						&& spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Value.ToString() != "0") 
					{
						double org_qty = Convert.ToDouble(spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value.ToString() );
						double org_ontime_qty = Convert.ToDouble(spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Value.ToString() );

						double total_rate = (org_ontime_qty / org_qty) * 100;

						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value = total_rate;
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value = total_rate;
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value = total_rate;
 


						Display_Score_Color_Again(sel_row); 


					}
					else
					{
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value = "";
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value = "";
						spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value = "";
					}

				}
				else if(sel_col == (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE) 
				{ 
					  
					if(Convert.ToDouble(spd_main.ActiveSheet.Cells[sel_row, sel_col].Value) == 0.0)
					{
						spd_main.ActiveSheet.Cells[sel_row, sel_col].Value = "";
					}

					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value = spd_main.ActiveSheet.Cells[sel_row, sel_col].Value;
					spd_main.ActiveSheet.Cells[sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value = spd_main.ActiveSheet.Cells[sel_row, sel_col].Value;

					Display_Score_Color_Again(sel_row); 
				} // end daygac total
 
				


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "spd_main_EditChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}


		 
		

		private void dpick_FromOrd_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{

//				//date 초기화    
//				dpick_ToOrd.Text = dpick_FromOrd.Text;

				spd_main.ClearAll(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromOrd_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}	
		}

		private void dpick_ToOrd_ValueChanged(object sender, System.EventArgs e)
		{
			try
			{
 
				spd_main.ClearAll(); 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ToOrd_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
			this.Text = "GAC Score Process";
            lbl_MainTitle.Text = "GAC Score Process";
            ClassLib.ComFunction.SetLangDic(this);

			// grid set
			spd_main.Set_Spread_Comm("SBW_ORDER_SEARCH_GAC", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false); 
			
			// Farpoint Spread Header Merge
			Mearge_GridHead();

			// 콘트롤 세팅
			Init_Control(); 

			

			// 조회
			Search();

			

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
		/// Init_Control : 콘트롤 세팅
		/// </summary>
		private void Init_Control()
		{
			 
			// toolbar button disable setting 
			tbtn_Delete.Enabled = false; 
			tbtn_Confirm.Enabled = false; 
			tbtn_Save.Enabled = false; 
 

			// factory set  
			DataTable dt_ret = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name); 
			cmb_Factory.SelectedValue = _Factory;
			dt_ret.Dispose();
	


			//date 초기화  
//			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
//
//			dpick_FromOrd.Text = MyComFunction.ConvertDate2Type(nowymd);
//			dpick_ToOrd.Text = MyComFunction.ConvertDate2Type(nowymd);   

		}
 


		#endregion

		#region 툴바 메뉴 이벤트 처리 메서드
		
		/// <summary>
		/// Clear : 화면 초기화
		/// </summary>
		private void Clear()
		{ 

			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;  
			cmb_From.SelectedIndex = -1;
			cmb_To.SelectedIndex = -1;
			cmb_OBSType.SelectedIndex = -1;
			  
			//date 초기화  
			string nowymd = System.DateTime.Now.ToString("yyyyMMdd");

			dpick_FromOrd.Text = MyComFunction.ConvertDate2Type(nowymd);
			dpick_ToOrd.Text = MyComFunction.ConvertDate2Type(nowymd);  


			spd_main.ClearAll();

		}



		/// <summary>
		/// Search : 조회
		/// </summary>
		private void Search()
		{ 

			try
			{
				this.Cursor = Cursors.WaitCursor;

				
				spd_main.ClearAll();

 
				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_From, cmb_To, cmb_OBSType}; 
				bool essential_check = essential_check = ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;
  
				string factory = cmb_Factory.SelectedValue.ToString();
				string from = cmb_From.SelectedValue.ToString();
				string to = cmb_To.SelectedValue.ToString();
				string obs_type = cmb_OBSType.SelectedValue.ToString();
//				string from_ord = MyComFunction.ConvertDate2DbType(dpick_FromOrd.Text);
//				string to_ord = MyComFunction.ConvertDate2DbType(dpick_ToOrd.Text);
				string from_ord = dpick_FromOrd.Value.ToString("yyyyMMdd");
				string to_ord = dpick_ToOrd.Value.ToString("yyyyMMdd");
				 

			   


				DataTable dt_ret = SELECT_SBW_GAC_SCORE(factory, from, to, obs_type, from_ord, to_ord);

				if(dt_ret == null || dt_ret.Rows.Count == 0) return;
   



				int current_db_row = 0;
				int grid_start_row = 0;

				while(true)
				{
					
					current_db_row++;

					

					// order total qty 표시 row
					Display_OrderTotal_Qty(dt_ret, current_db_row);

					// launch 표시, sub total 표시 row
					Display_Launch_SubTotal(dt_ret, current_db_row);

					// total 색 표시
					Display_Score_Color(grid_start_row, spd_main.ActiveSheet.RowCount); 


					grid_start_row = spd_main.ActiveSheet.RowCount;


					if(current_db_row == dt_ret.Rows.Count) break;

				} 




				// column merge 
				ClassLib.ComFunction.MergeCell(spd_main, new int[]{ (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxFACTORY,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_ID,
																	  (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_TYPE } );


			


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 


		private void Display_OrderTotal_Qty(DataTable arg_dt_ret, int current_db_row)
		{

			// 컬럼 갯수
			int col_range = 11;
			int col_count = 0; 


			// order total qty 표시 row
			spd_main.ActiveSheet.AddRows(spd_main.ActiveSheet.RowCount, 1);

			for(int i = 0; i < (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START; i++)
			{
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, i + 1].Value
					= arg_dt_ret.Rows[current_db_row - 1].ItemArray[i].ToString();
			}
 
		
			NumberCellType nc = new NumberCellType();
			nc.DecimalPlaces = 0 ;
			nc.Separator = "," ;
			nc.ShowSeparator = true; 
			
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDEMAND + 1].CellType = nc;
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDEMAND + 1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;


			for(int i = (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START; i < arg_dt_ret.Columns.Count; i++)
			{
				if(col_count == 0)
				{
					spd_main.ActiveSheet.AddRows(spd_main.ActiveSheet.RowCount, 1);
				}



				for(int a = 0; a < (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDEMAND; a++)
				{ 
					spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, a + 1].Value
						= arg_dt_ret.Rows[current_db_row - 1].ItemArray[a].ToString();
				}

				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, col_count + (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START].Value
					= (arg_dt_ret.Rows[current_db_row - 1].ItemArray[i].ToString() == "-99999") ? "" : arg_dt_ret.Rows[current_db_row - 1].ItemArray[i].ToString();




				col_count++;
				
				if(col_count == col_range)
				{
					col_count = 0;
				}


			} // end for i


			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Locked = false; //14gac 
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Locked = false; //30gac 


		}


		private void Display_Launch_SubTotal(DataTable arg_dt_ret, int current_db_row)
		{

			spd_main.ActiveSheet.AddRows(spd_main.ActiveSheet.RowCount, 2);
 
				
			for(int i = 0; i < (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE; i++)
			{
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, i + 1].Value
					= arg_dt_ret.Rows[current_db_row - 1].ItemArray[i].ToString();

				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, i + 1].Value
					= arg_dt_ret.Rows[current_db_row - 1].ItemArray[i].ToString();
			}


			for(int i = (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1; i < spd_main.ActiveSheet.ColumnCount; i++)
			{
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, i].Value = ""; 
				spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, i].Value = "";
			}

			CheckBoxCellType cb = new CheckBoxCellType();
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].CellType = cb; 
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START].Value = "Launch";
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].Value = false;
			
			//spd_main.ActiveSheet.Rows[spd_main.ActiveSheet.RowCount - 2].Locked = false; 
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_TYPE].Locked = false;
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Locked = false;
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_ONTIME_QTY].Locked = false;  
			
				
			TextCellType tc = new TextCellType();
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].CellType = tc;
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START].Value = "S-Total";
			
			// subtotal backcolor
			spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDATA_START,
				spd_main.ActiveSheet.RowCount - 1, spd_main.ActiveSheet.ColumnCount - 1].BackColor = ClassLib.ComVar.ClrLevel_1st;
 


		}


		private void Display_Score_Color(int arg_grid_start_row, int arg_grid_end_row)
		{


			#region GAC Score Metrics 공통 코드 정의

			/*
			 
				* 'SBW04', 'GAC Score Metrics' 

				(컬럼인덱스)
				
				launch %
				(1) com_value1: (w launch) : 37
				(2) com_desc1: (w/o launch) : 40

				green from-to (>90)  ( value > green_from )
				(3) com_value2 : 90 
				(4) com_desc2 : 100

				yellow from-to (85-90)  ( value >= yellow_from && value <= yellow_to )
				(5) com_value3: 85
				(6) com_desc3: 90

				red from-to (<85)  ( value < red_to )
				(7) com_value4: 0
				(8) com_desc4: 85

				metrics description
				(9) remarks : OGAC F.F
				
				
				* seq
				1 : OGAC
				2 : RGAC
				3 : 14GAC
				4 : 30GAC
				5 : LAUNCH
				6 : W Launch TOTAL
				7 : W/0 Launch TOTAL

				 */

			DataTable dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxGACScoreMetrics);

			#endregion 
 
			#region set value

			int row_ogac = 0;
			int row_rgac = 1;
			int row_14gac = 2;
			int row_30gac = 3;
			int row_launch = 4;
			int row_w_total = 5;
			int row_wo_total = 6; 

			double green_from = 0; 
			double green_to = 0;
			double yellow_from = 0;
			double yellow_to = 0;
			double red_from = 0;
			double red_to = 0;


			string demand = "";
			double s_total_org_qty = 0;
			double s_total_in_qty = 0;
			double s_total_proj_qty = 0;  


			double launch_rgac =  0; 
			double launch_ogac =  0; 
			double launch_14gac =  0;
			double launch_30gac =  0;
			double launch_launch = 0;


			if( (bool)spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].Value )  // w launch
			{
				launch_rgac = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[1].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[1].ToString()) * 0.01;
				launch_ogac = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[1].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[1].ToString()) * 0.01;
				launch_14gac = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[1].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[1].ToString()) * 0.01;
				launch_30gac = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[1].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[1].ToString()) * 0.01;
				launch_launch = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[1].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[1].ToString()) * 0.01;
			}
			else  // w/o launch
			{
				launch_rgac = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[2].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[2].ToString()) * 0.01;
				launch_ogac = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[2].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[2].ToString()) * 0.01;
				launch_14gac = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[2].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[2].ToString()) * 0.01;
				launch_30gac = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[2].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[2].ToString()) * 0.01;
				launch_launch = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[2].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[2].ToString()) * 0.01;
			}
		
			#endregion

			#region set s-total

			for(int i = arg_grid_start_row + 1; i < arg_grid_end_row - 1; i++)
			{
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value.ToString() != "")
				{	
					s_total_org_qty += Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value.ToString() );
				}

				//				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_QTY].Value != null
				//					|| ! spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_QTY].Value.ToString().Equals(""))
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_QTY].Value.ToString() != "")
				{
					s_total_in_qty += Convert.ToDouble( spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_QTY].Value.ToString() );
				}

				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_QTY].Value.ToString() != "")
				{
					s_total_proj_qty += Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_QTY].Value.ToString() );
				}

			}

			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_QTY].Value = s_total_org_qty;
			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_QTY].Value = s_total_in_qty;
			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_QTY].Value = s_total_proj_qty;

			#endregion

			#region set total% rate
					
			int grid_row_rgac = arg_grid_start_row + 1;
			int grid_row_ogac = arg_grid_start_row + 2;
			int grid_row_14gac = arg_grid_start_row + 3;
			int grid_row_30gac = arg_grid_start_row + 4; 
			int grid_row_launch = arg_grid_start_row + 5;
			//int grid_row_stotal = arg_grid_start_row + 6;

			double total_rate_org = 0;
			double total_rate_in = 0;
			double total_rate_proj = 0;



			// origin reciept
			if(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_org += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() ) * launch_rgac;	
			}

			if(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_org += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() ) * launch_ogac;	
			}

//			if(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
//			{
//				total_rate_org += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() ) * launch_14gac;	
//			}


			if( Convert.ToInt32(_OBSID) >= Convert.ToInt32("070305") )
			{
				if(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
				{
					total_rate_org += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() ) * launch_30gac;	
				}
			}

			if(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_org += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() ) * launch_launch;	
			}


			// in process
			if(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_in += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() ) * launch_rgac;	
			}

			if(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_in += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() ) * launch_ogac;	
			}

//			if(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
//			{
//				total_rate_in += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() ) * launch_14gac;	
//			}

			if( Convert.ToInt32(_OBSID) >= Convert.ToInt32("070305") )
			{
				if(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
				{
					total_rate_in += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() ) * launch_30gac;	
				}
			}

			if(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_in += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() ) * launch_launch;	
			}


			// projected score card
			if(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_proj += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_rgac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() ) * launch_rgac;	
			}

			if(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_proj += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_ogac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() ) * launch_ogac;	
			}

//			if(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
//			{
//				total_rate_proj += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_14gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() ) * launch_14gac;	
//			}

			if( Convert.ToInt32(_OBSID) >= Convert.ToInt32("070305") )
			{
				if(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
				{
					total_rate_proj += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_30gac, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() ) * launch_30gac;	
				}
			}

			if(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
			{
				total_rate_proj += Convert.ToDouble(spd_main.ActiveSheet.Cells[grid_row_launch, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() ) * launch_launch;	
			}



			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value = total_rate_org;
			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value = total_rate_in;

			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value = total_rate_proj;
			
			// result total %
			spd_main.ActiveSheet.Cells[arg_grid_end_row - 1, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Font = new Font("Verdana", 9, System.Drawing.FontStyle.Bold);



			#endregion 


			for(int i = arg_grid_start_row + 1; i < arg_grid_end_row; i++)
			{

				#region get gac scroe range

				demand = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxDEMAND + 1].Value.ToString().Trim();

				if(demand == "RGAC (+3days)")
				{
					green_from = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[3].ToString() );
					green_to = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[4].ToString() );
					yellow_from = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[5].ToString() );
					yellow_to = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[6].ToString() );
					red_from = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[7].ToString() );
					red_to = Convert.ToDouble( (dt_ret.Rows[row_rgac].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_rgac].ItemArray[8].ToString() );

				}
				else if(demand == "OGAC (+-5days)")
				{
					green_from = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[3].ToString() );
					green_to = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[4].ToString() );
					yellow_from = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[5].ToString() );
					yellow_to = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[6].ToString() );
					red_from = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[7].ToString() );
					red_to = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_ogac].ItemArray[8].ToString() );

				}
				else if(demand == "14 GAC")
				{
					green_from = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[3].ToString() );
					green_to = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[4].ToString() );
					yellow_from = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[5].ToString() );
					yellow_to = Convert.ToDouble( (dt_ret.Rows[row_ogac].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[6].ToString() );
					red_from = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[7].ToString() );
					red_to = Convert.ToDouble( (dt_ret.Rows[row_14gac].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_14gac].ItemArray[8].ToString() );

				}
				else if(demand == "30 GAC")
				{
					green_from = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[3].ToString() );
					green_to = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[4].ToString() );
					yellow_from = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[5].ToString() );
					yellow_to = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[6].ToString() );
					red_from = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[7].ToString() );
					red_to = Convert.ToDouble( (dt_ret.Rows[row_30gac].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_30gac].ItemArray[8].ToString() );

				}
				else if(demand == "Launch")
				{
					green_from = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[3].ToString() );
					green_to = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[4].ToString() );
					yellow_from = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[5].ToString() );
					yellow_to = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[6].ToString() );
					red_from = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[7].ToString() );
					red_to = Convert.ToDouble( (dt_ret.Rows[row_launch].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_launch].ItemArray[8].ToString() );

				}
				else if(demand == "S-Total")
				{
					
					if( (bool)spd_main.ActiveSheet.Cells[spd_main.ActiveSheet.RowCount - 2, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC_HEAD.IxOBS_TYPE + 1].Value )  // w launch
					{
						green_from = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[3].ToString() );
						green_to = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[4].ToString() );
						yellow_from = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[5].ToString() );
						yellow_to = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[6].ToString() );
						red_from = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[7].ToString() );
						red_to = Convert.ToDouble( (dt_ret.Rows[row_w_total].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_w_total].ItemArray[8].ToString() );

					}
					else  // w/o launch
					{
						green_from = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[3].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[3].ToString() );
						green_to = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[4].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[4].ToString() );
						yellow_from = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[5].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[5].ToString() );
						yellow_to = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[6].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[6].ToString() );
						red_from = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[7].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[7].ToString() );
						red_to = Convert.ToDouble( (dt_ret.Rows[row_wo_total].ItemArray[8].ToString() == "") ? "0" : dt_ret.Rows[row_wo_total].ItemArray[8].ToString() );

					}

 
				}


				#endregion

				#region set color


				// origin reciept
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value.ToString() != "")
				{
					if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value) > green_from )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].BackColor = Color.LawnGreen;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value) >= yellow_from 
						&& Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value) <= yellow_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].BackColor = Color.Yellow;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].Value) < red_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].BackColor = Color.OrangeRed;
					}
				} 
				else
				{
					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxORG_TOTAL_RATE].BackColor = Color.Empty;
				}


				// in process
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value.ToString() != "")
				{
					if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value) > green_from )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].BackColor = Color.LawnGreen;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value) >= yellow_from 
						&& Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value) <= yellow_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].BackColor = Color.Yellow;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].Value) < red_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].BackColor = Color.OrangeRed;
					}
				} 
				else
				{
					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxIN_TOTAL_RATE].BackColor = Color.Empty;
				}


				// projected score card
				if(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value.ToString() != "")
				{
					if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value) > green_from )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].BackColor = Color.LawnGreen;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value) >= yellow_from 
						&& Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value) <= yellow_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].BackColor = Color.Yellow;
					}
					else if( Convert.ToDouble(spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].Value) < red_to )
					{
						spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].BackColor = Color.OrangeRed;
					}
				} 
				else
				{
					spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxPROJ_TOTAL_RATE].BackColor = Color.Empty;
				}


				#endregion
 

			} // end for i 


		}

	
		private void Display_Score_Color_Again(int arg_sel_row)
		{

			

			int start_row = -1;
			int end_row = -1;

			string current_key = spd_main.ActiveSheet.Cells[arg_sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxFACTORY].Value.ToString()
				+ spd_main.ActiveSheet.Cells[arg_sel_row, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_ID].Value.ToString();

			string now_key = "";

			for(int i = arg_sel_row; i >= 0; i--)
			{
				now_key = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxFACTORY].Value.ToString()
					+ spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_ID].Value.ToString();

				if(current_key != now_key)
				{
					start_row = i + 1;
					break;
				}

			}

			start_row = (start_row == -1) ? 0 : start_row;



			for(int i = arg_sel_row; i < spd_main.ActiveSheet.RowCount; i++)
			{
				now_key = spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxFACTORY].Value.ToString()
					+ spd_main.ActiveSheet.Cells[i, (int)ClassLib.TBSBW_ORDER_SEARCH_GAC.IxOBS_ID].Value.ToString();

				if(current_key != now_key)
				{
					end_row = i;
					break;
				}

			}
 
			end_row = (end_row == -1) ? spd_main.ActiveSheet.RowCount : end_row;



			// score 표시
			Display_Score_Color(start_row, end_row);


		}
  


		/// <summary>
		/// Print : 프린트
		/// </summary>
		private void Print()
		{ 
 
			string file_name = @"DeliveryRiskManagement(" + cmb_Factory.SelectedValue.ToString() + cmb_From.SelectedValue.ToString() + ")_" + System.DateTime.Now.ToString("yyyyMMdd_hhmmss") + @".xls";
			spd_main.SaveExcel(@"C:\" + file_name, FarPoint.Win.Spread.Model.IncludeHeaders.ColumnHeadersCustomOnly);
			ClassLib.ComFunction.User_Message("Complete Save to Excel file." , "Gac Score Save to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

		}



		#endregion  

		

		
		#endregion

		#region DB Connect
 

		 

		/// <summary>
		/// SELECT_SBW_GAC_SCORE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_from"></param>
		/// <param name="arg_to"></param>
		/// <param name="arg_obs_type"></param>
		/// <param name="arg_from_ord"></param>
		/// <param name="arg_to_ord"></param>
		/// <returns></returns>
		private DataTable SELECT_SBW_GAC_SCORE(string arg_factory, 
			string arg_from, 
			string arg_to, 
			string arg_obs_type, 
			string arg_from_ord, 
			string arg_to_ord)
		{

			try 
			{


				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(7);   

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBW_GAC.SELECT_SBW_GAC_QTY";

				//02.ARGURMENT 명 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OBS_ID_FROM";
				MyOraDB.Parameter_Name[2] = "ARG_OBS_ID_TO";
				MyOraDB.Parameter_Name[3] = "ARG_OBS_TYPE"; 
				MyOraDB.Parameter_Name[4] = "ARG_ORD_FROM"; 
				MyOraDB.Parameter_Name[5] = "ARG_ORD_TO"; 
				MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_from;
				MyOraDB.Parameter_Values[2] = arg_to; 
				MyOraDB.Parameter_Values[3] = arg_obs_type;  
				MyOraDB.Parameter_Values[4] = arg_from_ord;  
				MyOraDB.Parameter_Values[5] = arg_to_ord;  
				MyOraDB.Parameter_Values[6] = "";  

				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[MyOraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SELECT_SBW_GAC_SCORE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}


		}


		#endregion	  
		

 


	}
}

