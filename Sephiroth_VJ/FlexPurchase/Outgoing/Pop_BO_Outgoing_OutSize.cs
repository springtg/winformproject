using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Outgoing
{
	public class Pop_BO_Outgoing_OutSize : COM.PCHWinForm.Pop_Medium
	{
		

		#region 생성자 / 소멸자

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DateTimePicker dpick_outYmd;
		private C1.Win.C1List.C1Combo cmb_outNo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl_menu;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;


		public Pop_BO_Outgoing_OutSize()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private string _Factory;
		private string _OutNo;

		public Pop_BO_Outgoing_OutSize(string arg_factory, string arg_outno)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_Factory = arg_factory;
			_OutNo = arg_outno;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BO_Outgoing_OutSize));
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
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_outNo = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.dpick_outYmd = new System.Windows.Forms.DateTimePicker();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
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
            this.c1Sizer1.Controls.Add(this.pnl_menu);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "25:False:True;37.5:False:True;18.75:False:True;\t0.568181818181818:False:True;96.0" +
                "227272727273:False:False;1.13636363636364:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(704, 160);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // pnl_menu
            // 
            this.pnl_menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_menu.BackColor = System.Drawing.Color.Transparent;
            this.pnl_menu.Controls.Add(this.btn_close);
            this.pnl_menu.Controls.Add(this.btn_apply);
            this.pnl_menu.Location = new System.Drawing.Point(12, 112);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(676, 30);
            this.pnl_menu.TabIndex = 174;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(588, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 24);
            this.btn_close.TabIndex = 547;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseUp);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(516, 3);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 546;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_apply_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 40);
            this.panel1.TabIndex = 169;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_outNo);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.dpick_outYmd);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 40);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            // 
            // cmb_outNo
            // 
            this.cmb_outNo.AddItemCols = 0;
            this.cmb_outNo.AddItemSeparator = ';';
            this.cmb_outNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outNo.Caption = "";
            this.cmb_outNo.CaptionHeight = 17;
            this.cmb_outNo.CaptionStyle = style1;
            this.cmb_outNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outNo.ColumnCaptionHeight = 18;
            this.cmb_outNo.ColumnFooterHeight = 18;
            this.cmb_outNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outNo.ContentHeight = 16;
            this.cmb_outNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outNo.EditorHeight = 16;
            this.cmb_outNo.Enabled = false;
            this.cmb_outNo.EvenRowStyle = style2;
            this.cmb_outNo.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outNo.FooterStyle = style3;
            this.cmb_outNo.GapHeight = 2;
            this.cmb_outNo.HeadingStyle = style4;
            this.cmb_outNo.HighLightRowStyle = style5;
            this.cmb_outNo.ItemHeight = 15;
            this.cmb_outNo.Location = new System.Drawing.Point(728, 12);
            this.cmb_outNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_outNo.MaxDropDownItems = ((short)(5));
            this.cmb_outNo.MaxLength = 32767;
            this.cmb_outNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outNo.Name = "cmb_outNo";
            this.cmb_outNo.OddRowStyle = style6;
            this.cmb_outNo.PartialRightColumn = false;
            this.cmb_outNo.PropBag = resources.GetString("cmb_outNo.PropBag");
            this.cmb_outNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outNo.SelectedStyle = style7;
            this.cmb_outNo.Size = new System.Drawing.Size(32, 20);
            this.cmb_outNo.Style = style8;
            this.cmb_outNo.TabIndex = 51;
            this.cmb_outNo.Visible = false;
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style9;
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
            this.cmb_factory.Enabled = false;
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(696, 12);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style14;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style15;
            this.cmb_factory.Size = new System.Drawing.Size(28, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 1;
            this.cmb_factory.Visible = false;
            // 
            // dpick_outYmd
            // 
            this.dpick_outYmd.CustomFormat = "";
            this.dpick_outYmd.Enabled = false;
            this.dpick_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_outYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_outYmd.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.dpick_outYmd.Location = new System.Drawing.Point(680, 12);
            this.dpick_outYmd.Name = "dpick_outYmd";
            this.dpick_outYmd.Size = new System.Drawing.Size(24, 21);
            this.dpick_outYmd.TabIndex = 4;
            this.dpick_outYmd.Value = new System.DateTime(2006, 3, 29, 19, 52, 34, 414);
            this.dpick_outYmd.Visible = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 48);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(676, 60);
            this.spd_main.TabIndex = 167;
            this.spd_main.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.Never;
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BO_Outgoing_OutSize
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(698, 188);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BO_Outgoing_OutSize";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 

		#endregion 

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			//this.Grid_EditModeOnProcess(spd_main) ;
		}

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			 
//			spd_main.Buffer_CellData = "000" ;
//			this.spd_main.Update_Row(img_Action);
			 
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}		

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			Tbtn_SaveProcess();
		}

		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
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

		#endregion

		#region 롤오버 이미지 처리
		private void btn_apply_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 1;
		}

		private void btn_apply_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_apply.ImageIndex = 0;
		}

		private void btn_close_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_close.ImageIndex = 1;
		}

		private void btn_close_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.btn_close.ImageIndex = 0;
		}
		#endregion

		#endregion

		#region 공통 메서드

		 
		

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{
            // Form Setting 
			lbl_MainTitle.Text = "Outgoing Out Size";
            this.Text = "Outgoing Out Size";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBO_OUT_SIZE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);
  
			Tbtn_SearchProcess();

		}

		 
		private int _Cs_Size_Display = 2;
		private int _Cs_Size_Start = 3;

		private void Tbtn_SearchProcess()
		{
 

			bool vExistData  = false;
 	
			spd_main.Display_Size_ColHead(_Factory, "", 40, _Cs_Size_Start);
			spd_main.ActiveSheet.Rows.Count = 1;
			

			DataTable dt_ret = null;

			if(_OutNo.Trim().Equals("") )
			{
				dt_ret = ClassLib.ComVar.Parameter_PopUpTable2;
			}
			else
			{
				dt_ret = SELECT_SBO_OUT_SIZE(_Factory, _OutNo);

	
				
				for(int i = 0; i < dt_ret.Rows.Count; i++)
				{
					if(dt_ret.Rows[i].ItemArray[_Cs_Size_Display] != null && dt_ret.Rows[i].ItemArray[_Cs_Size_Display].ToString() != "")
					{
						vExistData = true;
						break;
					}
				}


				if(dt_ret == null || ! vExistData)
				{
					dt_ret = ClassLib.ComVar.Parameter_PopUpTable2;
				}

			}
			

			if(dt_ret == null || dt_ret.Rows.Count == 0) return;

			 
			spd_main.Display_CrossTab(dt_ret, 0, 0, 1, _Cs_Size_Display, false);

//			// view point move 
//			vExistData  = false;
//			for (int col = _Cs_Size_Start ; col < spd_main.ActiveSheet.Columns.Count ; col++)
//			{
//				for (int row = 0 ; row < spd_main.ActiveSheet.Rows.Count ; row++)
//					if (! spd_main.ActiveSheet.Cells[row, col].Text.Trim().Equals(""))
//						vExistData = true;
//				
//				if (vExistData)
//				{
//					spd_main.ShowColumn(0, col, FarPoint.Win.Spread.HorizontalPosition.Left);
//					break;
//				}
//			}
 


			// total 계산
			int total = 0;

			for(int i = _Cs_Size_Start; i < spd_main.ActiveSheet.ColumnCount; i++)
			{
				if(spd_main.ActiveSheet.Cells[0, i].Value == null || spd_main.ActiveSheet.Cells[0, i].Value.ToString() == "") continue;

				total += Convert.ToInt32(spd_main.ActiveSheet.Cells[0, i].Value);
			}

			spd_main.ActiveSheet.Cells[0, 1].Value = total;

			 	
		}

		private void Tbtn_SaveProcess()
		{

			try
			{
				 

				ClassLib.ComVar.Parameter_PopUpTable2.Reset();

				//'1' AS KEY, ROWNUM AS COL_NUM, B.cs_QTY AS QTY, a.cs_size

				DataColumn[] dc= new DataColumn[4];

				dc[0] = new DataColumn("KEY",Type.GetType("System.String"));
				dc[1] = new DataColumn("COL_NUM",Type.GetType("System.String"));
				dc[2] = new DataColumn("CS_QTY",Type.GetType("System.String"));
				dc[3] = new DataColumn("CS_SIZE",Type.GetType("System.String"));

				ClassLib.ComVar.Parameter_PopUpTable2.Columns.AddRange(dc);

 
				for(int i = _Cs_Size_Start ; i < spd_main.ActiveSheet.Columns.Count ; i++)
				{
					
					DataRow newRow = ClassLib.ComVar.Parameter_PopUpTable2.NewRow();
 
					newRow[0] = "1";  // key
					newRow[1] = Convert.ToString(i - _Cs_Size_Start + 1);
					newRow[2] = spd_main.ActiveSheet.Cells[0, i].Value;
					newRow[3] = spd_main.ActiveSheet.ColumnHeader.Cells[0, i].Text;

					ClassLib.ComVar.Parameter_PopUpTable2.Rows.Add(newRow);

				}

				this.Close();

				 


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
			}		
		}


	 

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			 
//			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
//			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
//		
//			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
//				return;
//		
//			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
//			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
//			if (vTemp == "CheckBoxCellType" )
//			{
//				arg_grid.Buffer_CellData = "000" ;
//				arg_grid.Update_Row(img_Action) ;
//			}
			 
		}

		#endregion

		#region DB Connect
 		
		

		/// <summary>
		/// SELECT_SBO_OUT_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_out_no"></param>
		/// <returns></returns>
		public static DataTable SELECT_SBO_OUT_SIZE(string arg_factory, string arg_out_no)
		{
			
			COM.OraDB MyOraDB = new COM.OraDB(); 

			DataSet vDt;


			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_OTHER.SELECT_SBO_OUT_SIZE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_NO";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;


			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_out_no;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		 
		#endregion


	}
}

