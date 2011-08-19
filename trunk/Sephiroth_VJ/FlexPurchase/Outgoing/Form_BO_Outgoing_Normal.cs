using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Outgoing
{
	public class Form_BO_Outgoing_Normal : COM.PCHWinForm.Form_Top
	{
		 

		#region 생성자 / 소멸자


		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.Label lbl_factory;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_workProcess;
		private System.Windows.Forms.Label lbl_workLine;
		private System.Windows.Forms.Label lbl_workYmd;
		private COM.FSP fgrid_main;
		private System.Windows.Forms.ContextMenu cmenu_Outgoing;
		private System.Windows.Forms.Label lbl_ProcessDiv;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_between;
		private System.Windows.Forms.DateTimePicker dpick_ToDate;
		private C1.Win.C1List.C1Combo cmb_OutDiv;
		private System.Windows.Forms.DateTimePicker dpick_FromDate;
		private C1.Win.C1List.C1Combo cmb_Process;
		private C1.Win.C1List.C1Combo cmb_Line;
		private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label btn_CreateDefective;
		private System.Windows.Forms.RadioButton rad_Detail;
		private System.Windows.Forms.RadioButton rad_Header;
		private System.Windows.Forms.MenuItem menuitem_RemainderReport;
		private System.Windows.Forms.Label btn_Outside;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem_ValueChange;
		private System.Windows.Forms.Label btn_Usage;


		public Form_BO_Outgoing_Normal()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BO_Outgoing_Normal));
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
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.btn_Outside = new System.Windows.Forms.Label();
            this.btn_CreateDefective = new System.Windows.Forms.Label();
            this.lbl_between = new System.Windows.Forms.Label();
            this.dpick_ToDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_Detail = new System.Windows.Forms.RadioButton();
            this.rad_Header = new System.Windows.Forms.RadioButton();
            this.cmb_OutDiv = new C1.Win.C1List.C1Combo();
            this.lbl_ProcessDiv = new System.Windows.Forms.Label();
            this.dpick_FromDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_workYmd = new System.Windows.Forms.Label();
            this.btn_Usage = new System.Windows.Forms.Label();
            this.lbl_workProcess = new System.Windows.Forms.Label();
            this.cmb_Process = new C1.Win.C1List.C1Combo();
            this.cmb_Line = new C1.Win.C1List.C1Combo();
            this.lbl_workLine = new System.Windows.Forms.Label();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.fgrid_main = new COM.FSP();
            this.cmenu_Outgoing = new System.Windows.Forms.ContextMenu();
            this.menuItem_ValueChange = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuitem_RemainderReport = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
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
            // tbtn_Save
            // 
            this.tbtn_Save.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Save_Click);
            // 
            // tbtn_Delete
            // 
            this.tbtn_Delete.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Delete_Click);
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
            // tbtn_Confirm
            // 
            this.tbtn_Confirm.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Confirm_Click);
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
            this.c1Sizer1.Controls.Add(this.fgrid_main);
            this.c1Sizer1.GridDefinition = "17.9310344827586:False:True;81.3793103448276:False:False;\t0.393700787401575:False" +
                ":True;98.4251968503937:False:False;0.393700787401575:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 64);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(1016, 580);
            this.c1Sizer1.TabIndex = 28;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.btn_Outside);
            this.pnl_head.Controls.Add(this.btn_CreateDefective);
            this.pnl_head.Controls.Add(this.lbl_between);
            this.pnl_head.Controls.Add(this.dpick_ToDate);
            this.pnl_head.Controls.Add(this.groupBox1);
            this.pnl_head.Controls.Add(this.cmb_OutDiv);
            this.pnl_head.Controls.Add(this.lbl_ProcessDiv);
            this.pnl_head.Controls.Add(this.dpick_FromDate);
            this.pnl_head.Controls.Add(this.lbl_workYmd);
            this.pnl_head.Controls.Add(this.btn_Usage);
            this.pnl_head.Controls.Add(this.lbl_workProcess);
            this.pnl_head.Controls.Add(this.cmb_Process);
            this.pnl_head.Controls.Add(this.cmb_Line);
            this.pnl_head.Controls.Add(this.lbl_workLine);
            this.pnl_head.Controls.Add(this.cmb_Factory);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Location = new System.Drawing.Point(8, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1000, 104);
            this.pnl_head.TabIndex = 1;
            // 
            // btn_Outside
            // 
            this.btn_Outside.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Outside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Outside.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Outside.ImageIndex = 0;
            this.btn_Outside.ImageList = this.img_Button;
            this.btn_Outside.Location = new System.Drawing.Point(914, 75);
            this.btn_Outside.Name = "btn_Outside";
            this.btn_Outside.Size = new System.Drawing.Size(80, 23);
            this.btn_Outside.TabIndex = 407;
            this.btn_Outside.Text = "Outside";
            this.btn_Outside.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Outside.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Outside.Click += new System.EventHandler(this.btn_Outside_Click);
            this.btn_Outside.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Outside.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Outside.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_CreateDefective
            // 
            this.btn_CreateDefective.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CreateDefective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_CreateDefective.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_CreateDefective.ImageIndex = 0;
            this.btn_CreateDefective.ImageList = this.img_Button;
            this.btn_CreateDefective.Location = new System.Drawing.Point(754, 75);
            this.btn_CreateDefective.Name = "btn_CreateDefective";
            this.btn_CreateDefective.Size = new System.Drawing.Size(80, 23);
            this.btn_CreateDefective.TabIndex = 406;
            this.btn_CreateDefective.Text = "Defective";
            this.btn_CreateDefective.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CreateDefective.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_CreateDefective.Click += new System.EventHandler(this.btn_CreateDefective_Click);
            this.btn_CreateDefective.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_CreateDefective.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_CreateDefective.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_between
            // 
            this.lbl_between.Location = new System.Drawing.Point(211, 78);
            this.lbl_between.Name = "lbl_between";
            this.lbl_between.Size = new System.Drawing.Size(16, 16);
            this.lbl_between.TabIndex = 405;
            this.lbl_between.Text = "~";
            // 
            // dpick_ToDate
            // 
            this.dpick_ToDate.CustomFormat = "";
            this.dpick_ToDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_ToDate.Location = new System.Drawing.Point(231, 78);
            this.dpick_ToDate.Name = "dpick_ToDate";
            this.dpick_ToDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_ToDate.TabIndex = 6;
            this.dpick_ToDate.ValueChanged += new System.EventHandler(this.dpick_ToDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rad_Detail);
            this.groupBox1.Controls.Add(this.rad_Header);
            this.groupBox1.Location = new System.Drawing.Point(832, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 40);
            this.groupBox1.TabIndex = 401;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree View Option";
            // 
            // rad_Detail
            // 
            this.rad_Detail.Location = new System.Drawing.Point(87, 20);
            this.rad_Detail.Name = "rad_Detail";
            this.rad_Detail.Size = new System.Drawing.Size(72, 16);
            this.rad_Detail.TabIndex = 396;
            this.rad_Detail.Tag = "2";
            this.rad_Detail.Text = "Detaile";
            this.rad_Detail.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // rad_Header
            // 
            this.rad_Header.Checked = true;
            this.rad_Header.Location = new System.Drawing.Point(8, 20);
            this.rad_Header.Name = "rad_Header";
            this.rad_Header.Size = new System.Drawing.Size(72, 16);
            this.rad_Header.TabIndex = 395;
            this.rad_Header.TabStop = true;
            this.rad_Header.Tag = "1";
            this.rad_Header.Text = "Header";
            this.rad_Header.CheckedChanged += new System.EventHandler(this.rad_CheckedChanged);
            // 
            // cmb_OutDiv
            // 
            this.cmb_OutDiv.AddItemCols = 0;
            this.cmb_OutDiv.AddItemSeparator = ';';
            this.cmb_OutDiv.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutDiv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutDiv.Caption = "";
            this.cmb_OutDiv.CaptionHeight = 17;
            this.cmb_OutDiv.CaptionStyle = style1;
            this.cmb_OutDiv.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutDiv.ColumnCaptionHeight = 18;
            this.cmb_OutDiv.ColumnFooterHeight = 18;
            this.cmb_OutDiv.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutDiv.ContentHeight = 16;
            this.cmb_OutDiv.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutDiv.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutDiv.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutDiv.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutDiv.EditorHeight = 16;
            this.cmb_OutDiv.EvenRowStyle = style2;
            this.cmb_OutDiv.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutDiv.FooterStyle = style3;
            this.cmb_OutDiv.GapHeight = 2;
            this.cmb_OutDiv.HeadingStyle = style4;
            this.cmb_OutDiv.HighLightRowStyle = style5;
            this.cmb_OutDiv.ItemHeight = 15;
            this.cmb_OutDiv.Location = new System.Drawing.Point(109, 56);
            this.cmb_OutDiv.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutDiv.MaxDropDownItems = ((short)(5));
            this.cmb_OutDiv.MaxLength = 32767;
            this.cmb_OutDiv.MouseCursor = System.Windows.Forms.Cursors.IBeam;
            this.cmb_OutDiv.Name = "cmb_OutDiv";
            this.cmb_OutDiv.OddRowStyle = style6;
            this.cmb_OutDiv.PartialRightColumn = false;
            this.cmb_OutDiv.PropBag = resources.GetString("cmb_OutDiv.PropBag");
            this.cmb_OutDiv.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutDiv.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutDiv.SelectedStyle = style7;
            this.cmb_OutDiv.Size = new System.Drawing.Size(220, 20);
            this.cmb_OutDiv.Style = style8;
            this.cmb_OutDiv.TabIndex = 397;
            this.cmb_OutDiv.SelectedValueChanged += new System.EventHandler(this.cmb_OutDiv_SelectedValueChanged);
            // 
            // lbl_ProcessDiv
            // 
            this.lbl_ProcessDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_ProcessDiv.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ProcessDiv.ImageIndex = 0;
            this.lbl_ProcessDiv.ImageList = this.img_Label;
            this.lbl_ProcessDiv.Location = new System.Drawing.Point(8, 56);
            this.lbl_ProcessDiv.Name = "lbl_ProcessDiv";
            this.lbl_ProcessDiv.Size = new System.Drawing.Size(100, 21);
            this.lbl_ProcessDiv.TabIndex = 398;
            this.lbl_ProcessDiv.Text = "Out Division";
            this.lbl_ProcessDiv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_FromDate
            // 
            this.dpick_FromDate.CustomFormat = "";
            this.dpick_FromDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_FromDate.Location = new System.Drawing.Point(109, 78);
            this.dpick_FromDate.Name = "dpick_FromDate";
            this.dpick_FromDate.Size = new System.Drawing.Size(99, 21);
            this.dpick_FromDate.TabIndex = 5;
            this.dpick_FromDate.ValueChanged += new System.EventHandler(this.dpick_FromDate_ValueChanged);
            // 
            // lbl_workYmd
            // 
            this.lbl_workYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workYmd.ImageIndex = 0;
            this.lbl_workYmd.ImageList = this.img_Label;
            this.lbl_workYmd.Location = new System.Drawing.Point(8, 78);
            this.lbl_workYmd.Name = "lbl_workYmd";
            this.lbl_workYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_workYmd.TabIndex = 50;
            this.lbl_workYmd.Text = "Work Date";
            this.lbl_workYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Usage
            // 
            this.btn_Usage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Usage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Usage.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_Usage.ImageIndex = 0;
            this.btn_Usage.ImageList = this.img_Button;
            this.btn_Usage.Location = new System.Drawing.Point(834, 75);
            this.btn_Usage.Name = "btn_Usage";
            this.btn_Usage.Size = new System.Drawing.Size(80, 23);
            this.btn_Usage.TabIndex = 355;
            this.btn_Usage.Text = "Usage";
            this.btn_Usage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Usage.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Usage.Click += new System.EventHandler(this.btn_Usage_Click);
            this.btn_Usage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Usage.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Usage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // lbl_workProcess
            // 
            this.lbl_workProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workProcess.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workProcess.ImageIndex = 0;
            this.lbl_workProcess.ImageList = this.img_Label;
            this.lbl_workProcess.Location = new System.Drawing.Point(344, 34);
            this.lbl_workProcess.Name = "lbl_workProcess";
            this.lbl_workProcess.Size = new System.Drawing.Size(100, 21);
            this.lbl_workProcess.TabIndex = 379;
            this.lbl_workProcess.Text = "Process";
            this.lbl_workProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Process
            // 
            this.cmb_Process.AddItemCols = 0;
            this.cmb_Process.AddItemSeparator = ';';
            this.cmb_Process.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Process.Caption = "";
            this.cmb_Process.CaptionHeight = 17;
            this.cmb_Process.CaptionStyle = style9;
            this.cmb_Process.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Process.ColumnCaptionHeight = 18;
            this.cmb_Process.ColumnFooterHeight = 18;
            this.cmb_Process.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Process.ContentHeight = 16;
            this.cmb_Process.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Process.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Process.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Process.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Process.EditorHeight = 16;
            this.cmb_Process.EvenRowStyle = style10;
            this.cmb_Process.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Process.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Process.FooterStyle = style11;
            this.cmb_Process.GapHeight = 2;
            this.cmb_Process.HeadingStyle = style12;
            this.cmb_Process.HighLightRowStyle = style13;
            this.cmb_Process.ItemHeight = 15;
            this.cmb_Process.Location = new System.Drawing.Point(445, 34);
            this.cmb_Process.MatchEntryTimeout = ((long)(2000));
            this.cmb_Process.MaxDropDownItems = ((short)(5));
            this.cmb_Process.MaxLength = 32767;
            this.cmb_Process.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Process.Name = "cmb_Process";
            this.cmb_Process.OddRowStyle = style14;
            this.cmb_Process.PartialRightColumn = false;
            this.cmb_Process.PropBag = resources.GetString("cmb_Process.PropBag");
            this.cmb_Process.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Process.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Process.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Process.SelectedStyle = style15;
            this.cmb_Process.Size = new System.Drawing.Size(220, 20);
            this.cmb_Process.Style = style16;
            this.cmb_Process.TabIndex = 0;
            this.cmb_Process.SelectedValueChanged += new System.EventHandler(this.cmb_Process_SelectedValueChanged);
            // 
            // cmb_Line
            // 
            this.cmb_Line.AddItemCols = 0;
            this.cmb_Line.AddItemSeparator = ';';
            this.cmb_Line.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Line.Caption = "";
            this.cmb_Line.CaptionHeight = 17;
            this.cmb_Line.CaptionStyle = style17;
            this.cmb_Line.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Line.ColumnCaptionHeight = 18;
            this.cmb_Line.ColumnFooterHeight = 18;
            this.cmb_Line.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Line.ContentHeight = 16;
            this.cmb_Line.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Line.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Line.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Line.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Line.EditorHeight = 16;
            this.cmb_Line.EvenRowStyle = style18;
            this.cmb_Line.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Line.FooterStyle = style19;
            this.cmb_Line.GapHeight = 2;
            this.cmb_Line.HeadingStyle = style20;
            this.cmb_Line.HighLightRowStyle = style21;
            this.cmb_Line.ItemHeight = 15;
            this.cmb_Line.Location = new System.Drawing.Point(445, 56);
            this.cmb_Line.MatchEntryTimeout = ((long)(2000));
            this.cmb_Line.MaxDropDownItems = ((short)(5));
            this.cmb_Line.MaxLength = 32767;
            this.cmb_Line.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Line.Name = "cmb_Line";
            this.cmb_Line.OddRowStyle = style22;
            this.cmb_Line.PartialRightColumn = false;
            this.cmb_Line.PropBag = resources.GetString("cmb_Line.PropBag");
            this.cmb_Line.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Line.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Line.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Line.SelectedStyle = style23;
            this.cmb_Line.Size = new System.Drawing.Size(220, 20);
            this.cmb_Line.Style = style24;
            this.cmb_Line.TabIndex = 8;
            this.cmb_Line.SelectedValueChanged += new System.EventHandler(this.cmb_Line_SelectedValueChanged);
            // 
            // lbl_workLine
            // 
            this.lbl_workLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine.ImageIndex = 0;
            this.lbl_workLine.ImageList = this.img_Label;
            this.lbl_workLine.Location = new System.Drawing.Point(344, 56);
            this.lbl_workLine.Name = "lbl_workLine";
            this.lbl_workLine.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine.TabIndex = 375;
            this.lbl_workLine.Text = "Line";
            this.lbl_workLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style25;
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
            this.cmb_Factory.EvenRowStyle = style26;
            this.cmb_Factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style27;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style28;
            this.cmb_Factory.HighLightRowStyle = style29;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 34);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style30;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style31;
            this.cmb_Factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_Factory.Style = style32;
            this.cmb_Factory.TabIndex = 1;
            this.cmb_Factory.SelectedValueChanged += new System.EventHandler(this.cmb_Factory_SelectedValueChanged);
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(984, 88);
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
            this.pic_head4.Location = new System.Drawing.Point(136, 87);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(960, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 34);
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
            this.pic_head7.Size = new System.Drawing.Size(101, 63);
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
            this.label2.Text = "      Outgoing Production Info";
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
            this.pic_head5.Location = new System.Drawing.Point(0, 88);
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
            this.pic_head6.Size = new System.Drawing.Size(168, 77);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // fgrid_main
            // 
            this.fgrid_main.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_main.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_main.ContextMenu = this.cmenu_Outgoing;
            this.fgrid_main.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_main.Location = new System.Drawing.Point(8, 108);
            this.fgrid_main.Name = "fgrid_main";
            this.fgrid_main.Size = new System.Drawing.Size(1000, 472);
            this.fgrid_main.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_main.Styles"));
            this.fgrid_main.TabIndex = 13;
            this.fgrid_main.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_AfterEdit);
            this.fgrid_main.BeforeEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgrid_main_BeforeEdit);
            // 
            // cmenu_Outgoing
            // 
            this.cmenu_Outgoing.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem_ValueChange,
            this.menuItem2,
            this.menuitem_RemainderReport});
            this.cmenu_Outgoing.Popup += new System.EventHandler(this.cmenu_Outgoing_Popup);
            // 
            // menuItem_ValueChange
            // 
            this.menuItem_ValueChange.Index = 0;
            this.menuItem_ValueChange.Text = "Value Change";
            this.menuItem_ValueChange.Click += new System.EventHandler(this.menuItem_ValueChange_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // menuitem_RemainderReport
            // 
            this.menuitem_RemainderReport.Index = 2;
            this.menuitem_RemainderReport.Text = "Daily Outgoing, Remainer Report";
            this.menuitem_RemainderReport.Click += new System.EventHandler(this.menuitem_RemainderReport_Click);
            // 
            // Form_BO_Outgoing_Normal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BO_Outgoing_Normal";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form_BO_Outgoing_Normal_Closing);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            this.Controls.SetChildIndex(this.stbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Process)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_main)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction(); 

		private FlexPurchase.Purchase.Pop_BP_Purchase_Wait _popWait = null;

		private string _OutDiv_Normal = "1";
		//private string _OutDiv_Defective = "2";

		private int _Level_Total = 1;

		private string _OutStatus = "";
		private string _OutStatus_Confirm = "C"; 
		private string _OutStatus_Save = "S"; 
		private int _LevelDetail = 1;


        private Thread tRun = null;
        delegate void DelegateSetn(); // 대리자 선언    


		#endregion 

		#region 그리드 이벤트 처리 
		 

		#endregion
		
		#region 툴바 메뉴 이벤트 처리
		
		private void tbtn_New_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{  
			Tbtn_NewProcess();		
		}
				
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SearchProcess();
		}

		private void tbtn_Save_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_SaveProcess();
		}						
	
		private void tbtn_Confirm_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_ConfirmProcess();
		}

		private void tbtn_Delete_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_DeleteProcess();
		}
		
		private void tbtn_Print_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			Tbtn_PrintProcess();
		}
		
		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void Form_BO_Outgoing_Normal_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (fgrid_main.Rows.Fixed < fgrid_main.Rows.Count)
			{
				string vTemp = fgrid_main.GetCellRange(fgrid_main.Rows.Fixed, 0, fgrid_main.Rows.Count - 1, 0).Clip.Replace("\r", "");

				if (vTemp.Length > 0)
					if (MessageBox.Show(this, "Exist modify data. Do you want close?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
						e.Cancel = true;
			}
		}
    




		
		private void cmb_Factory_SelectedValueChanged(object sender, System.EventArgs e)
		{

			try
			{
				 
				if(cmb_Factory.SelectedIndex == -1) return;  
				 

				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				_OutStatus = _OutStatus_Save; 
				rad_Header.Checked = true;

				EnableControlCheckProcess();



				DataTable dt_ret;

				//process setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Opcd_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Process, 1, 1, false, ClassLib.ComVar.ComboList_Visible.Code); 


				//line setting 
				dt_ret = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(cmb_Factory.SelectedValue.ToString() );
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Line, 0, 1, false, ClassLib.ComVar.ComboList_Visible.Code_Name);  
  

				dt_ret.Dispose();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Factory_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	


		}



		private void cmb_OutDiv_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				 
				if(cmb_Factory.SelectedIndex == -1 || cmb_OutDiv.SelectedIndex == -1) return; 

 
				if(cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
				{
					dpick_ToDate.Text = dpick_FromDate.Text;
					dpick_ToDate.Enabled = false;

					//btn_CreateDefective.Enabled = false;

				}
				else
				{
					dpick_ToDate.Enabled = true;

//					// 현장 부서의 조회만을 위한 Role 일 경우, tbtn_Save.Enabled 여부로 기타 버튼 권한 재 설정
//					if(tbtn_Save.Enabled)
//					{
//						btn_CreateDefective.Enabled = true;
//					}

				}
 
 
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed; 
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true;

				EnableControlCheckProcess();

 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_OutDiv_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	


		}



		private void dpick_FromDate_ValueChanged(object sender, System.EventArgs e)
		{
				
			try
			{
				 
				dpick_ToDate.Text = dpick_FromDate.Text; 
 
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true;

 
				EnableControlCheckProcess();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_FromDate_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}


		
		private void dpick_ToDate_ValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				 
				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true;

				
				EnableControlCheckProcess();


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "dpick_ToDate_ValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}


		private void cmb_Process_SelectedValueChanged(object sender, System.EventArgs e)
		{
		 
			try
			{
				 
				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true;

				Tbtn_SearchProcess();

				//EnableControlCheckProcess();

				

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Process_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}

		private void cmb_Line_SelectedValueChanged(object sender, System.EventArgs e)
		{
		
			try
			{ 

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true; 

				Tbtn_SearchProcess();

				//EnableControlCheckProcess();

				

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmb_Line_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}



		private void rad_CheckedChanged(object sender, System.EventArgs e)
		{
		
			try
			{
				 
				// src.Tag 에 트리 레벨 디자이너에서 설정해 놓음

				RadioButton src = sender as RadioButton;

				fgrid_main.Tree.Show( Convert.ToInt32(src.Tag.ToString() ) ); 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "rad_CheckedChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

		}



 
		#endregion

		#region 공통 메서드
  

		#endregion

		#region 컨텍스트(팝업) 메뉴 이벤트 

		private void cmenu_Outgoing_Popup(object sender, System.EventArgs e)
		{
			
			try
			{

				if(fgrid_main.Rows.Count < fgrid_main.Rows.Fixed) 
				{
					menuitem_RemainderReport.Visible = false;
				}
				else
				{
					int sel_level = Convert.ToInt32(fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL].ToString());
					
					if(sel_level == _Level_Total)
					{
						menuitem_RemainderReport.Visible = true;
					}
					else
					{
						menuitem_RemainderReport.Visible = false;
					}
				}



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "cmenu_Outgoing_Popup", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
				 
		}

		private void menuitem_RemainderReport_Click(object sender, System.EventArgs e)
		{
			Print_DailyRemainder();	
		}



		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting

            lbl_MainTitle.Text = "Outgoing Production";
            this.Text = "Outgoing Production";
            ClassLib.ComFunction.SetLangDic(this); 

			
			// Grid Setting
			fgrid_main.Set_Grid("SBO_OUTGOING_PRODUCTION", "1", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			fgrid_main.Rows[0].AllowMerging = true;
			fgrid_main.Rows[1].AllowMerging = true;
			fgrid_main.Set_Action_Image(img_Action);
 

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory, 0, 1, false);
			vDt.Dispose();
			cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
 

			// Process Outgoing division set    cmb_outDiv
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Out_Division_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_OutDiv, 1, 2, false, 56, 0);
			cmb_OutDiv.SelectedIndex = 0; 
			
 


			for (int vCol = 1; vCol < fgrid_main.Cols.Count ; vCol++)
			{

				if(fgrid_main.Cols[vCol].DataType.Equals(typeof(double) ) )
				{

//					if(vCol == (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxREMAINDER_QTY
//						|| vCol == (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxORG_REMAINDER_QTY) continue;

					fgrid_main.Cols[vCol].Format = "#,##0.00";

				} // end if
 
			} // end for vCol





			// 초기 버튼 권한 설정 : 조회만을 위함
			//tbtn_Save.Enabled = false;
			tbtn_Delete.Enabled = false;
			tbtn_Confirm.Enabled = false;
		    btn_CreateDefective.Enabled = false;
			btn_Usage.Enabled = false; 
			fgrid_main.AllowEditing = false; 

 
		}



		private void Display_Grid(DataTable arg_dt)
		{

			int row_fixed = fgrid_main.Rows.Fixed;
			int level = 0; 

			for (int i = 0 ; i < arg_dt.Rows.Count ; i++)
			{

				level = Convert.ToInt32(arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL - 1].ToString() );
				C1.Win.C1FlexGrid.Node newRow = fgrid_main.Rows.InsertNode(row_fixed + i, level);

				// data setting
				fgrid_main[newRow.Row.Index, 0] = "";
				for (int j = 0 ; j < arg_dt.Columns.Count ; j++)
				{
					fgrid_main[newRow.Row.Index, j + 1] = arg_dt.Rows[i].ItemArray[j];
				}
 

				// design setting
				if (level == _Level_Total)  // SubTotal 
				{

					newRow.Row.StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
					newRow.Row.AllowEditing = true; 

				}
				else
				{
					newRow.Row.AllowEditing = false;
					newRow.Row.StyleNew.BackColor = Color.White;
				}


				// 현재 출고 데이터 상태값
//				if(_OutStatus.Trim().Equals("") )
//				{
//					_OutStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_STATUS - 1].ToString();
//				}


				_OutStatus = arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_STATUS - 1].ToString();


			}


			fgrid_main.Tree.Column = (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOL_ITEM_NAME; 
			rad_Header.Checked = true;
			fgrid_main.Tree.Show(_Level_Total);



			EnableControlCheckProcess();



		}




		/// <summary>
		/// EnableControlCheckProcess : 버튼 권한 재 설정
		/// </summary>
		private void EnableControlCheckProcess()
		{

			// 재고마감 여부 
			

			// 1. btn_CreateDefective 권한은 cmb_outdiv 에 의해 변경되어짐
			// 2. 현장 부서의 조회만을 위한 Role 일 경우, tbtn_Save.Enabled 여부로 기타 버튼 권한 재 설정
			//    -> tbtn_Delete, tbtn_Confirm 버튼은 tbtn_Save 와 동일 권한으로 이루어 지므로 대상에서 제외

			if(_OutStatus == _OutStatus_Confirm)
			{
 
				tbtn_Delete.Enabled = false;
				tbtn_Confirm.Enabled = true;
				 
				btn_CreateDefective.Enabled = false;
				btn_Usage.Enabled = false;

				fgrid_main.AllowEditing = false; 

			}
			else if(_OutStatus == _OutStatus_Save)
			{
 
				if(! tbtn_Save.Enabled) 
				{
					 
					tbtn_Delete.Enabled = false;
					tbtn_Confirm.Enabled = false;
					btn_CreateDefective.Enabled = false;
					btn_Usage.Enabled = false; 
					fgrid_main.AllowEditing = false; 

					return;
				}


				 
				if(ClassLib.ComVar.This_InsaCd == "Y")
				{
					tbtn_Delete.Enabled = true;
					tbtn_Confirm.Enabled = true; 
				}
				else
				{
					tbtn_Delete.Enabled = false;
					tbtn_Confirm.Enabled = false; 
				}

				if(cmb_OutDiv.SelectedIndex == -1)
				{
					btn_CreateDefective.Enabled = false;
				}
				else
				{
					if(cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
					{
						btn_CreateDefective.Enabled = false;
					}
					else
					{
						btn_CreateDefective.Enabled = true;
					}
				}


				btn_Usage.Enabled = true;

				fgrid_main.AllowEditing = true;  


			} 
 



		}






		#region 툴바 메뉴 이벤트 처리

		private void Tbtn_NewProcess()
		{
			
			try
			{ 
				
				cmb_Factory.SelectedValue = ClassLib.ComVar.This_Factory;
				cmb_OutDiv.SelectedIndex = 0; 
				
				//date 초기화  
				string nowymd = System.DateTime.Now.ToString("yyyyMMdd");
				dpick_FromDate.Text = MyComFunction.ConvertDate2Type(nowymd);
				dpick_ToDate.Text = MyComFunction.ConvertDate2Type(nowymd);  

				cmb_Process.SelectedIndex = -1;
				cmb_Line.SelectedIndex = -1;


				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed; 
				_OutStatus = _OutStatus_Save;
				rad_Header.Checked = true; 
				

				EnableControlCheckProcess();

				 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				

		}

		private void Tbtn_SearchProcess()
		{
			try
			{

				this.Cursor = Cursors.WaitCursor;


				if(cmb_Process.SelectedIndex == -1 || cmb_Line.SelectedIndex == -1) return;

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;
 

				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString(); 
				string line = cmb_Line.SelectedValue.ToString(); 
				 

				DataTable dt_ret = Select_SBO_OUT_TAIL(factory, out_division, out_ymd_from, out_ymd_to, process, line);

				fgrid_main.Rows.Count = fgrid_main.Rows.Fixed; 
				

				if(dt_ret.Rows.Count == 0) 
				{  
					_OutStatus = _OutStatus_Save;
					EnableControlCheckProcess(); 

					return;  
				}

				Display_Grid(dt_ret); 



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_NewProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
		}

		private void Tbtn_PrintProcess()
		{ 

			try
			{
 

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				  
				string sDir = "";
				string report_text = "";

				if (cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
				{


					FlexPurchase.Shipping.Pop_BS_Print_Type vPop = new FlexPurchase.Shipping.Pop_BS_Print_Type(ClassLib.ComVar.CxPurchaseTracking_PrintType);   // sbp12

					

					if (vPop.ShowDialog() == DialogResult.OK)
					{
						string vPrintType = COM.ComVar.Parameter_PopUp[0];
						
						switch (vPrintType)
						{
							case "10": 
								sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Normal_1");
								break;

							case "20": 
								sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Normal_2");
								break;

							case "30": 
								sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Normal_3");
								break;

							case "40": 
								ClassLib.ComVar.Parameter_PopUp_Object = new object[6];
								
								ClassLib.ComVar.Parameter_PopUp_Object[0] = cmb_Factory.SelectedValue;
								ClassLib.ComVar.Parameter_PopUp_Object[1] = cmb_OutDiv.SelectedValue;
								ClassLib.ComVar.Parameter_PopUp_Object[2] = dpick_FromDate.Value;
								ClassLib.ComVar.Parameter_PopUp_Object[3] = dpick_ToDate.Value;
								ClassLib.ComVar.Parameter_PopUp_Object[4] = cmb_Process.SelectedValue;
								ClassLib.ComVar.Parameter_PopUp_Object[5] = cmb_Line.SelectedValue;

								Form_BO_Outside_Normal_Print pop_print = new Form_BO_Outside_Normal_Print();
								pop_print.ShowDialog();
								//sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Normal_5");
								break;

							case "50": 
								sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Normal_4");
								break;

							default:
								break;
						}
					}

					report_text = "Outgoing Process Normal sheet";

				}
				else
				{
					sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Difective_1"); 
					report_text = "Outgoing Process Difective sheet";
				}
				 


				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Factory, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_OutDiv, "") +	"' ";
				sPara += "'" + dpick_FromDate.Text.Replace("-","") +		"' ";
				sPara += "'" + dpick_ToDate.Text.Replace("-","") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Process, "") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Line, "") +	"' ";
						

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara); 
				MyReport.Text = report_text;
				MyReport.Show();	


					

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_PrintProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}

		private void Tbtn_SaveProcess()
		{

			//if ( (fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY ) && ( fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD ) ) return;
			
			for (int vRow = fgrid_main.Rows.Fixed ; vRow < fgrid_main.Rows.Count ; vRow++)
			{		
				if (ClassLib.ComFunction.NullToBlank(fgrid_main[vRow, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD]).Equals(""))
				{
					ClassLib.ComFunction.User_Message("Exist Empty Data : " + "Warehouse Code", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					fgrid_main.Select(vRow, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD);
					return ;
				}
			}

			try
			{

				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseSave, this);
				if(result == DialogResult.No) return;


				this.Cursor = Cursors.WaitCursor;
				 

				bool save_flag = Save_SBO_OUT_TAIL();

				if(save_flag)
				{

					//fgrid_main.Refresh_Division();


					for(int i = fgrid_main.Rows.Count - 1; i >= fgrid_main.Rows.Fixed; i--)
					{
						if(fgrid_main[i, 0] == null || fgrid_main[i, 0].ToString() == "") continue;

						if(fgrid_main[i, 0].ToString() == "D")
						{
							fgrid_main.Rows.Remove(i);
						}
						else
						{
							fgrid_main[i, 0] = "";

							fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxORG_REMAINDER_QTY]
								= fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxREMAINDER_QTY].ToString();

						}

					} // end for i



					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndSave, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave , this);

				}
				else
				{
					
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotSave, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotSave , this);

				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_SaveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 
			finally
			{
				this.Cursor = Cursors.Default;
			}


		}

		private void Tbtn_ConfirmProcess()
		{
			try
			{


				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return; 


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString(); 
				string line = cmb_Line.SelectedValue.ToString(); 
				string out_status = (_OutStatus == _OutStatus_Confirm) ? "R" : "C"; 
				string confirm_yn = (_OutStatus == _OutStatus_Confirm) ? "N" : "Y"; 
				string upd_user = ClassLib.ComVar.This_User;
 


				

				DialogResult result;
				DataTable dt_ret;
				bool confirm_check = false; 
				string message = "";
 


				if(_OutStatus == _OutStatus_Confirm)
				{
					// confirm cancel 조건 체크 : 마지막 out_ymd 일때만 cancel 가능

					if(cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
					{
						dt_ret = Check_Confirm_Condition(_OutStatus_Save, factory, out_division, out_ymd_from, process, line);

						if(dt_ret.Rows[0].ItemArray[0].ToString().Trim().Equals("N") )
						{
							 
							message = "Can't confirm cancel." + "\r\n\r\n" + "Not yet confirm cancel [" + dt_ret.Rows[0].ItemArray[1].ToString() + "] outgoing production.";
							ClassLib.ComFunction.User_Message(message, "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
							 	   		
						}  

					}


					result = ClassLib.ComFunction.User_Message("Do you want to Confirm Cancel ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}
				else
				{
					// confirm 조건 체크 : 바로 이전 out_ymd 가 confirm 이어야만 confirm 가능 
					if(cmb_OutDiv.SelectedValue.ToString() == _OutDiv_Normal)
					{
						dt_ret = Check_Confirm_Condition(_OutStatus_Confirm, factory, out_division, out_ymd_from, process, line);

						if(dt_ret.Rows[0].ItemArray[0].ToString().Trim().Equals("N") )
						{
							 
							message = "Can't confirm." + "\r\n\r\n" + "Not yet confirm [" + dt_ret.Rows[0].ItemArray[1].ToString() + "] outgoing production.";
							ClassLib.ComFunction.User_Message("Can't confirm cancel.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return;
							 	   		
						}  

					}

					result = ClassLib.ComFunction.User_Message("Do you want to Confirm ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				}

				
				if(result == DialogResult.No) return;


				this.Cursor = Cursors.WaitCursor;
				 

				string real_out_ymd = "";
				string wh_cd = "";

//				if(_OutStatus != _OutStatus_Confirm)
//				{ 
//					
//					Pop_BO_Outgoing_RealYmd_Exchanger pop_form = new Pop_BO_Outgoing_RealYmd_Exchanger();
// 
//
//					ClassLib.ComVar.Parameter_PopUp = null;
//					ClassLib.ComVar.Parameter_PopUp = new string[3]; 
//					ClassLib.ComVar.Parameter_PopUp[0] = "Select Real Outgoing Date, Warehouse"; 
//					ClassLib.ComVar.Parameter_PopUp[1] = "Select Real Outgoing Date, Warehouse";
//					ClassLib.ComVar.Parameter_PopUp[2] = cmb_Factory.SelectedValue.ToString();
//			
//					pop_form.ShowDialog();
//
//					if(ClassLib.ComVar.Parameter_PopUp == null) 
//					{
//						ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
//						return;
//					}
//
//					real_out_ymd = ClassLib.ComVar.Parameter_PopUp[0]; 
//					wh_cd = ClassLib.ComVar.Parameter_PopUp[1];
//
//				}
//				else
//				{
//					real_out_ymd = System.DateTime.Now.ToString("yyyyMMdd");
//				}
   

				Pop_BO_Outgoing_RealYmd_Exchanger pop_form = new Pop_BO_Outgoing_RealYmd_Exchanger();
 

				ClassLib.ComVar.Parameter_PopUp = null;
				ClassLib.ComVar.Parameter_PopUp = new string[3]; 
				ClassLib.ComVar.Parameter_PopUp[0] = "Select Real Outgoing Date, Warehouse"; 
				ClassLib.ComVar.Parameter_PopUp[1] = "Select Real Outgoing Date, Warehouse";
				ClassLib.ComVar.Parameter_PopUp[2] = cmb_Factory.SelectedValue.ToString();
			
				if(_OutStatus != _OutStatus_Confirm)
				{ 
					pop_form.dpick_Ymd.Enabled = true;
				}
				else
				{
					pop_form.dpick_Ymd.Enabled = false;
				}

				pop_form.ShowDialog();

				if(ClassLib.ComVar.Parameter_PopUp == null) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					return;
				}

				real_out_ymd = ClassLib.ComVar.Parameter_PopUp[0]; 
				wh_cd = ClassLib.ComVar.Parameter_PopUp[1];
				

				string[] save_parameter = new string[] { factory,
				                                         out_division, 
														 out_ymd_from, 
														 out_ymd_to, 
														 process, 
														 line, 
														 real_out_ymd,
                                                         wh_cd,
														 out_status, 
														 confirm_yn, 
														 upd_user};

				bool save_flag = Update_SBO_OUT_STATUS(save_parameter);

				if(save_flag)
				{

					if(_OutStatus == _OutStatus_Confirm)
					{
						_OutStatus = _OutStatus_Save;
					}
					else
					{
						_OutStatus = _OutStatus_Confirm;
					}

					for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count; i++)
					{
						fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_STATUS] = _OutStatus;
					}

					EnableControlCheckProcess();


					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun , this);

					

				}
				else
				{
					
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsDoNotRun , this);

				}


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_ConfirmProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;
 

				DialogResult result = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete, this);
				if(result == DialogResult.No) return; 

				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString(); 
				string line = cmb_Line.SelectedValue.ToString(); 
				string upd_user = ClassLib.ComVar.This_User;
				 

				bool save_flag = Delete_SBO_OUT(factory, out_division, out_ymd_from, out_ymd_to, process, line, upd_user);
 

				if(save_flag)
				{

					fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete , this);

				}
				else
				{
					
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsEndDelete, this);
					ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndDelete , this);

				}



			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Tbtn_DeleteProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 

		}

 
		private void Print_DailyRemainder()
		{ 

			try
			{
 

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process, cmb_Line};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;

				if(fgrid_main.Rows.Count < fgrid_main.Rows.Fixed) return;
  

				 
				string sDir = FlexPurchase.ClassLib.ComFunction.Set_RD_Directory("Form_BO_Outgoing_Daily_Remainder"); 
				string report_text = "Daily Outgoing, Remainder Quantity";  
  

				string sPara  = " /rp ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Factory, "") +		"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_OutDiv, "") +	"' ";
				sPara += "'" + dpick_FromDate.Text.Replace("-","") +		"' "; 
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Process, "") +	"' ";
				sPara += "'" + COM.ComFunction.Empty_Combo(cmb_Line, "") +	"' ";
				sPara += "'" + fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxITEM_CD].ToString() + "' "; 
				sPara += "'" + fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxSPEC_CD].ToString() +	"' ";
				sPara += "'" + fgrid_main[fgrid_main.Selection.r1, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOLOR_CD].ToString() +	"' ";
						

				FlexBase.Report.Form_RdViewer MyReport = new FlexBase.Report.Form_RdViewer(sDir, sPara); 
				MyReport.Text = report_text;
				MyReport.Show();	


					

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Print_DailyRemainder", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}



		#endregion

		#region 그리드 이벤트 처리
		
		 
		private void fgrid_main_BeforeEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{

			Grid_BeforeEditProcess();

		}

		private void fgrid_main_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
		{
			Grid_AfterEditProcess();
		}

			
		private void Grid_BeforeEditProcess()
		{

			try
			{
 
				if ((fgrid_main.Rows.Fixed > 0) && (fgrid_main.Row >= fgrid_main.Rows.Fixed) )
				{
					fgrid_main.Buffer_CellData = (fgrid_main[fgrid_main.Row, fgrid_main.Col] == null) ? "" : fgrid_main[fgrid_main.Row, fgrid_main.Col].ToString();
				}
		 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_BeforeEditProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void Grid_AfterEditProcess()
		{

			try
			{
  

				if ( (fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY ) && ( fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD ) ) return;
				  
				Calculation_OutQty(cmb_OutDiv.SelectedValue.ToString(), fgrid_main.Row);  
				 

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Grid_AfterEditProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


			

		}

	 

		private void Calculation_OutQty(string arg_out_div, int arg_row)
		{

			double sel_out_qty  = double.Parse(fgrid_main[arg_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY].ToString() ); 
			double sel_dir_qty  = double.Parse(fgrid_main[arg_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxDIR_QTY].ToString() );  
			string sel_WH_CD    = fgrid_main[arg_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD].ToString();  


			if(sel_dir_qty < 0) return; 
	
			C1.Win.C1FlexGrid.Node node = fgrid_main.Rows[arg_row].Node;

			int from_row = node.GetNode(NodeTypeEnum.FirstChild).Row.Index;
			int to_row   = node.GetNode(NodeTypeEnum.LastChild).Row.Index;



			double out_qty = 0;
			double sum_out_qty = 0;
			double last_out_qty = 0;
			double org_remainder_qty = 0; 


			
			// 스타일별로 비율에 따라서 출고 수량 배분
			for(int i = from_row; i < to_row; i++)
			{

				if(double.Parse(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxDIR_QTY].ToString() ) == 0.0)
				{
					out_qty = 0;
				}
				else
				{
					out_qty = double.Parse(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxDIR_QTY].ToString() ) / sel_dir_qty * sel_out_qty;
				}

				out_qty = Math.Round(out_qty, 0);
				sum_out_qty += out_qty;

				fgrid_main[i, 0] = ClassLib.ComVar.Update;
				fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY] = out_qty; 
				fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD]   = sel_WH_CD; 

			} 

			// 정수화된 출고수량과 데이터 맞춰 주기 위해서 마지막 스타일에 나머지 수량 추가
			last_out_qty = sel_out_qty - sum_out_qty;

			fgrid_main[to_row, 0] = ClassLib.ComVar.Update;
			fgrid_main[to_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY] = last_out_qty;
			fgrid_main[to_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD]   = sel_WH_CD; 


			// out_div = normal 일 때, remainder 계산
			// out_div = defective 일 때, remainder 관리 하지 않음

			if(arg_out_div == _OutDiv_Normal)
			{
				// remainder_qty = before_remainder_qty + (dir_qty - out_qty)
				org_remainder_qty = double.Parse(fgrid_main[arg_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxORG_REMAINDER_QTY].ToString() );
				fgrid_main[arg_row, 0] = ClassLib.ComVar.Update;
				fgrid_main[arg_row, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxREMAINDER_QTY] = org_remainder_qty + (sel_dir_qty - sel_out_qty);
			}
		}
		 
 



		#endregion

		#region 버튼이벤트

		 
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


		private void btn_CreateDefective_Click(object sender, System.EventArgs e)
		{
			Btn_CreateDefectiveProcess();
		}

		private void btn_Usage_Click(object sender, System.EventArgs e)
		{
			Btn_UsageProcess();
		}



		private void Btn_CreateDefectiveProcess()
		{ 


			try
			{

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;


				DialogResult result = ClassLib.ComFunction.Data_Message("Create Defective", ClassLib.ComVar.MgsChooseRun, this);
				if(result == DialogResult.No) return;




                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunDefective));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }



                tRun.Abort();

			
 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_CreateDefectiveProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 
			
			 
		}






        public void RunDefective()
        {
            Invoke(new DelegateSetn(Create_Defective)); // 폼 스레드에 작업 넘김

        }


		private void Create_Defective()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString();  
				string upd_user = ClassLib.ComVar.This_User;

				bool run_flag = Create_DAILY_WORKSHEET(factory, out_division, out_ymd_from, out_ymd_to, process, upd_user);

				if(run_flag)
				{
					ClassLib.ComFunction.Data_Message("Create Defective", ClassLib.ComVar.MgsEndRun, this);
				}
				else
				{
					ClassLib.ComFunction.Data_Message("Create Defective", ClassLib.ComVar.MgsDoNotRun, this);
				}

 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Create_Defective", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun, this);

				if(_popWait != null) _popWait.Close();
			} 

 

		}



		private void Btn_UsageProcess()
		{
			 


			try
			{

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;


				DialogResult result = ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsChooseRun, this);
				if(result == DialogResult.No) return;





                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunUsage));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = new   FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }

                tRun.Abort();
 


			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_UsageProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 


			
			 
		}



        public void RunUsage()
        {
            Invoke(new DelegateSetn(Run_Usage)); // 폼 스레드에 작업 넘김

        }



		
		private void Btn_OutsideProcess()
		{
			 


			try
			{

				C1.Win.C1List.C1Combo[] cmb_array = {cmb_Factory, cmb_OutDiv, cmb_Process};   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null);  
				if(! essential_check) return;


				DialogResult result = ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsChooseRun, this);
				if(result == DialogResult.No) return;


          
                Thread tRun = null;
                tRun = new Thread(new ThreadStart(RunOutside));

                if (tRun != null)
                {
                    tRun.Start();
                    _popWait = _popWait = new FlexPurchase.Purchase.Pop_BP_Purchase_Wait();
                    _popWait.Start();


                }

                tRun.Abort();

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_UsageProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	 


			
			 
		}




        public void RunOutside()
        {
            Invoke(new DelegateSetn(Run_Outside)); // 폼 스레드에 작업 넘김

        }


		private void Run_Usage()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString();  
				string upd_user = ClassLib.ComVar.This_User;

				bool run_flag = Run_OUT_USAGE(factory, out_division, out_ymd_from, out_ymd_to, process, upd_user);
 
				if(run_flag)
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsEndRun, this);
					Tbtn_SearchProcess();

					//fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

				}
				else
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsDoNotRun, this);
				}

 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Usage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun , this);

				if(_popWait != null) _popWait.Close();
			} 

 

		}




		private void Run_Outside()
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;


				string factory = cmb_Factory.SelectedValue.ToString(); 
				string out_division = cmb_OutDiv.SelectedValue.ToString(); 
				string out_ymd_from = MyComFunction.ConvertDate2DbType(dpick_FromDate.Text);
				string out_ymd_to = MyComFunction.ConvertDate2DbType(dpick_ToDate.Text); 
				string process = cmb_Process.SelectedValue.ToString();  
				string upd_user = ClassLib.ComVar.This_User;

				bool run_flag = Run_OUT_USAGE_Outside(factory, out_division, out_ymd_from, out_ymd_to, process, upd_user);
 
				if(run_flag)
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsEndRun, this);
					Tbtn_SearchProcess();

					//fgrid_main.Rows.Count = fgrid_main.Rows.Fixed;

				}
				else
				{
					ClassLib.ComFunction.Data_Message("Run Usage", ClassLib.ComVar.MgsDoNotRun, this);
				}

 
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Run Usage", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
			finally
			{
				this.Cursor = Cursors.Default;
				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndRun , this);

				if(_popWait != null) _popWait.Close();
			} 

 

		}

		#endregion		

		#endregion
	
		#region DB Connect
 		
		 
		/// <summary>
		/// Select_SBO_OUT_TAIL : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private DataTable Select_SBO_OUT_TAIL(string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line)
		{

			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.SELECT_SBO_OUT_TAIL";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
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
			MyOraDB.Parameter_Values[1] = arg_out_division;
			MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
			MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
			MyOraDB.Parameter_Values[4] = arg_process;
			MyOraDB.Parameter_Values[5] = arg_line;
			MyOraDB.Parameter_Values[6] = "";  

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();
			if(ds_ret == null) return null; 

			return ds_ret.Tables[MyOraDB.Process_Name];


		}



		/// <summary>
		/// Create_DAILY_WORKSHEET : 불량에 대한 작업지시서 발행
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns></returns>
		private bool Create_DAILY_WORKSHEET(string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_upd_user)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.CREATE_DAILY_WORKSHEET";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_division;
				MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
				MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
				MyOraDB.Parameter_Values[4] = arg_process;
				MyOraDB.Parameter_Values[5] = arg_upd_user;

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

 

		 
		/// <summary>
		/// Run_OUT_USAGE : 공정 불출 소요량 계산
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns></returns>
		private bool Run_OUT_USAGE(string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_upd_user)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "";
 
				if(arg_out_division == _OutDiv_Normal)
				{
					MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.RUN_OUT_USAGE_NORMAL";
				}
				else
				{
					MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.RUN_OUT_USAGE_DEFECTIVE";
				}

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_division;
				MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
				MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
				MyOraDB.Parameter_Values[4] = arg_process;
				MyOraDB.Parameter_Values[5] = arg_upd_user;

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


		 
		/// <summary>
		/// Run_OUT_USAGE_Outside : 공정 불출 소요량 계산
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_upd_user"></param>
		/// <returns></returns>
		private bool Run_OUT_USAGE_Outside(string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_upd_user)
		{

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "";
 
				string _Factory = ClassLib.ComVar.This_Factory;

				if(_Factory == "VJ")
				{
					MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.RUN_OUT_USAGE_OUTSIDE";
				}
				else
				{
					MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.RUN_OUT_USAGE_EXPEND";
				}

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_division;
				MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
				MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
				MyOraDB.Parameter_Values[4] = arg_process;
				MyOraDB.Parameter_Values[5] = arg_upd_user;

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



		/// <summary>
		/// Save_SBO_OUT_TAIL : 
		/// </summary>
		/// <returns></returns>
		private bool Save_SBO_OUT_TAIL()
		{

			
			try
			{


				int col_ct = 16; 

				MyOraDB.ReDim_Parameter(col_ct);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.SAVE_SBO_OUT_TAIL_REMAINDER"; 
 

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[1] = "ARG_LEVEL"; 
				MyOraDB.Parameter_Name[2] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[3] = "ARG_WORK_MONTH";
				MyOraDB.Parameter_Name[4] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[5] = "ARG_OP_CD";
				MyOraDB.Parameter_Name[6] = "ARG_ITEM_CD";
				MyOraDB.Parameter_Name[7] = "ARG_SPEC_CD";
				MyOraDB.Parameter_Name[8] = "ARG_COLOR_CD";
				MyOraDB.Parameter_Name[9] = "ARG_REMAINDER_QTY"; 
				MyOraDB.Parameter_Name[10] = "ARG_OUT_NO";
				MyOraDB.Parameter_Name[11] = "ARG_OUT_SEQ";
				MyOraDB.Parameter_Name[12] = "ARG_DIR_QTY";
				MyOraDB.Parameter_Name[13] = "ARG_OUT_QTY";
				MyOraDB.Parameter_Name[14] = "ARG_WH_CD";
				MyOraDB.Parameter_Name[15] = "ARG_UPD_USER";

				// 파라미터의 데이터 Type
				for(int i = 0; i < col_ct ; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar; 
				} 

				// 각 행의 변경값 Setting
				ArrayList list = new ArrayList(); 

				for(int i = fgrid_main.Rows.Fixed; i < fgrid_main.Rows.Count ; i++)
				{

					if(fgrid_main[i, 0] == null || fgrid_main[i, 0].ToString() == "") continue;

					  
					list.Add(fgrid_main[i, 0].ToString() );  
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxTREE_LEVEL].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxFACTORY].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_NO].ToString() ); // 레벨1 일때는 출고 yyyymm 데이터임
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_LINE].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_PROCESS].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxITEM_CD].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxSPEC_CD].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxCOLOR_CD].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxREMAINDER_QTY].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_NO].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_SEQ].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxDIR_QTY].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY].ToString() );
					list.Add(fgrid_main[i, (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD].ToString() );
					list.Add(ClassLib.ComVar.This_User); 
						  
					 
				}
 				
				MyOraDB.Parameter_Values = (string[])list.ToArray(Type.GetType("System.String"));

				MyOraDB.Add_Modify_Parameter(true);						 
				DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_Set == null) return false;
				
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}



		/// <summary>
		/// Delete_SBO_OUT : 출고 데이터 삭제
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_out_ymd_to"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private bool Delete_SBO_OUT(string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_out_ymd_to, 
			string arg_process, 
			string arg_line,
			string arg_upd_user)
		{

			try
			{
 

				MyOraDB.ReDim_Parameter(7);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.DELETE_SBO_OUT"; 
 

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_out_division;
				MyOraDB.Parameter_Values[2] = arg_out_ymd_from;
				MyOraDB.Parameter_Values[3] = arg_out_ymd_to;
				MyOraDB.Parameter_Values[4] = arg_process;
				MyOraDB.Parameter_Values[5] = arg_line;
				MyOraDB.Parameter_Values[6] = arg_upd_user;

				MyOraDB.Add_Modify_Parameter(true);						 
				DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_Set == null) return false;
				
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}




		/// <summary>
		/// Update_SBO_OUT_STATUS : 출고 데이터 status 변경
		/// </summary>
		/// <param name="arg_save_parameter"></param>
		/// <returns></returns>
		private bool Update_SBO_OUT_STATUS(string[] arg_save_parameter)
		{

			try
			{
 

				MyOraDB.ReDim_Parameter(11);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.UPDATE_SBO_OUT"; 
 

				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_TO";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
				MyOraDB.Parameter_Name[6] = "ARG_OUT_YMD";  
				MyOraDB.Parameter_Name[7] = "ARG_WH_CD";
				MyOraDB.Parameter_Name[8] = "ARG_OUT_STATUS";
				MyOraDB.Parameter_Name[9] = "ARG_CONFIRM_YN";
				MyOraDB.Parameter_Name[10] = "ARG_UPD_USER"; 

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

				//04.DATA 정의

//				string save_parameter = new string[] { factory,
//														 out_division, 
//														 out_ymd_from, 
//														 out_ymd_to, 
//														 process, 
//														 line, 
//														 real_out_ymd, 
//				                                         wh_cd,
//														 out_status, 
//														 confirm_yn, 
//														 upd_user};
  


				MyOraDB.Parameter_Values[0] = arg_save_parameter[0];
				MyOraDB.Parameter_Values[1] = arg_save_parameter[1];
				MyOraDB.Parameter_Values[2] = arg_save_parameter[2];
				MyOraDB.Parameter_Values[3] = arg_save_parameter[3];
				MyOraDB.Parameter_Values[4] = arg_save_parameter[4];
				MyOraDB.Parameter_Values[5] = arg_save_parameter[5];
				MyOraDB.Parameter_Values[6] = arg_save_parameter[6];
				MyOraDB.Parameter_Values[7] = arg_save_parameter[7];
				MyOraDB.Parameter_Values[8] = arg_save_parameter[8];
				MyOraDB.Parameter_Values[9] = arg_save_parameter[9];
				MyOraDB.Parameter_Values[10] = arg_save_parameter[10];

				MyOraDB.Add_Modify_Parameter(true);						 
				DataSet ds_Set = MyOraDB.Exe_Modify_Procedure();			 
				
				if (ds_Set == null) return false;
				
				return true;   		
				
			}
			catch 
			{  
				return false;
			}


		}



		/// <summary>
		/// Check_Confirm_Condition : 
		/// </summary>
		/// <param name="arg_divsion"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_division"></param>
		/// <param name="arg_out_ymd_from"></param>
		/// <param name="arg_process"></param>
		/// <param name="arg_line"></param>
		/// <returns></returns>
		private DataTable Check_Confirm_Condition(string arg_divsion, 
			string arg_factory, 
			string arg_out_division, 
			string arg_out_ymd_from, 
			string arg_process, 
			string arg_line)
		{

			try
			{
     
				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(7);
				MyOraDB.Process_Name = "PKG_SBO_OUTGOING_PRODUCTION.CHECK_CONFIRM_CONDITION"; 
               
				// 파라미터 이름 설정
				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[2] = "ARG_OUT_DIV";
				MyOraDB.Parameter_Name[3] = "ARG_OUT_YMD_FROM";
				MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS";
				MyOraDB.Parameter_Name[5] = "ARG_OUT_LINE";
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
				MyOraDB.Parameter_Values[0] = arg_divsion;
				MyOraDB.Parameter_Values[1] = arg_factory; 
				MyOraDB.Parameter_Values[2] = arg_out_division; 
				MyOraDB.Parameter_Values[3] = arg_out_ymd_from; 
				MyOraDB.Parameter_Values[4] = arg_process; 
				MyOraDB.Parameter_Values[5] = arg_line;
				MyOraDB.Parameter_Values[6] = ""; 
 
				MyOraDB.Add_Select_Parameter(true);
				ds_ret = MyOraDB.Exe_Select_Procedure();
				if(ds_ret == null) return null; 

				return ds_ret.Tables[MyOraDB.Process_Name];
				
				
			}
			catch 
			{  
				return null;
			}


		}


		

		#endregion

		private void btn_Outside_Click(object sender, System.EventArgs e)
		{
			Btn_OutsideProcess();
		}

		private void menuItem_ValueChange_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				Event_menuItem_ValueChange(); 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Event_menuItem_ValueChange", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}


		private void Event_menuItem_ValueChange()
		{

			if ( (fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxOUT_QTY ) && ( fgrid_main.Col != (int)ClassLib.TBSBO_OUTGOING_PRODUCTION.IxWH_CD ) ) return;


			int sel_row = fgrid_main.Rows[fgrid_main.Row].Index;  
			int sel_col = fgrid_main.Cols[fgrid_main.Col].Index;  
							
			C1.Win.C1FlexGrid.CellRange cell = fgrid_main.GetCellRange(sel_row, sel_col); 
			string column_desc = fgrid_main[1, sel_col].ToString(); 
			FlexBase.MaterialBase.Pop_SelectionChange_FSP pop_form = new FlexBase.MaterialBase.Pop_SelectionChange_FSP(fgrid_main, cell, column_desc, false);
			pop_form.ShowDialog();

			if (ClassLib.ComVar.Parameter_PopUp == null) return; 
				

			foreach (int i in fgrid_main.Selections)
			{
				if (fgrid_main.Rows[i].AllowEditing && fgrid_main.Rows[i].Node.Level == _LevelDetail)
				{
					
					fgrid_main[i, fgrid_main.Col] = ClassLib.ComVar.Parameter_PopUp[0];

					Calculation_OutQty(cmb_OutDiv.SelectedValue.ToString(), i);  
					//fgrid_main.Update_Row(i);
				}
			} 
			// 아이템별 표시 레벨 데이터 자동 처리
			//Event_fgrid_main_AfterEdit();
		}
	

		
		 
		 


	}
}

