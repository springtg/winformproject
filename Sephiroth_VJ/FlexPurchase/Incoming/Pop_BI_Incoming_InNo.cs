using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Incoming
{
	public class Pop_BI_Incoming_InNo : COM.PCHWinForm.Pop_Large
	{
		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Label lblexcep_mark;
		private System.Windows.Forms.DateTimePicker dpick_to;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_inDate;
		private System.ComponentModel.IContainer components = null;
		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		//		private FarPoint.Win.Spread.SheetView _mainSheet = null;
		//		private int _inNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxIn_NO;
		//		private int _shippingYNCol = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIPPING_YN;
		//		private int _lotNoCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxLOT_NO;
		//		private int _styleCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_NAME;
		//		private int _styleCdCol	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSTYLE_CD;
		//		private int _styleQtyCol   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxTOT_SHIP_QTY_STYLE;
		//		private System.Windows.Forms.Label lbl_obsType;
		//		private C1.Win.C1List.C1Combo cmb_obsType;
		//		private int _shipType	   = (int)ClassLib.TBSBM_SHIP_REQ_ITEM.IxSHIP_TYPE;

		#endregion

		#region 생성자 / 소멸자
		public Pop_BI_Incoming_InNo()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BI_Incoming_InNo));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.lbl_inDate = new System.Windows.Forms.Label();
            this.lblexcep_mark = new System.Windows.Forms.Label();
            this.dpick_to = new System.Windows.Forms.DateTimePicker();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            // c1ToolBar1
            // 
            this.c1ToolBar1.Location = new System.Drawing.Point(496, 8);
            // 
            // tbtn_Search
            // 
            this.tbtn_Search.Click += new C1.Win.C1Command.ClickEventHandler(this.tbtn_Search_Click);
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
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.GridDefinition = "8.6:False:True;89:False:False;\t0.505050505050505:False:True;96.4646464646465:Fals" +
                "e:False;1.01010101010101:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 60);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(792, 500);
            this.c1Sizer1.TabIndex = 25;
            this.c1Sizer1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cmb_factory);
            this.panel1.Controls.Add(this.lbl_factory);
            this.panel1.Controls.Add(this.lbl_inDate);
            this.panel1.Controls.Add(this.lblexcep_mark);
            this.panel1.Controls.Add(this.dpick_to);
            this.panel1.Controls.Add(this.dpick_from);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 43);
            this.panel1.TabIndex = 168;
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
            this.cmb_factory.Location = new System.Drawing.Point(109, 14);
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
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style8;
            this.cmb_factory.TabIndex = 1;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 14);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_inDate
            // 
            this.lbl_inDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inDate.ImageIndex = 1;
            this.lbl_inDate.ImageList = this.img_Label;
            this.lbl_inDate.Location = new System.Drawing.Point(352, 14);
            this.lbl_inDate.Name = "lbl_inDate";
            this.lbl_inDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_inDate.TabIndex = 52;
            this.lbl_inDate.Text = "Incoming Date";
            this.lbl_inDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblexcep_mark
            // 
            this.lblexcep_mark.Location = new System.Drawing.Point(554, 14);
            this.lblexcep_mark.Name = "lblexcep_mark";
            this.lblexcep_mark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblexcep_mark.Size = new System.Drawing.Size(16, 16);
            this.lblexcep_mark.TabIndex = 178;
            this.lblexcep_mark.Text = "~";
            this.lblexcep_mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_to
            // 
            this.dpick_to.CustomFormat = "";
            this.dpick_to.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_to.Location = new System.Drawing.Point(573, 14);
            this.dpick_to.Name = "dpick_to";
            this.dpick_to.Size = new System.Drawing.Size(100, 21);
            this.dpick_to.TabIndex = 5;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(453, 14);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(100, 21);
            this.dpick_from.TabIndex = 4;
            this.dpick_from.CloseUp += new System.EventHandler(this.dpick_from_CloseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 43);
            this.groupBox1.TabIndex = 181;
            this.groupBox1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 51);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(764, 445);
            this.spd_main.TabIndex = 167;
            this.spd_main.CellDoubleClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spd_main_CellDoubleClick);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // Pop_BI_Incoming_InNo
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(792, 566);
            this.Controls.Add(this.c1Sizer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pop_BI_Incoming_InNo";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.c1ToolBar1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트 처리

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{
			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			this.spd_main.Update_Row(img_Action);
		}

		private void spd_main_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
		{
			if (!e.ColumnHeader)
				this.Grid_DoubleClickProcess(e.Row);
		}

		#endregion
	
		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		private void tbtn_Search_Click(object sender, C1.Win.C1Command.ClickEventArgs e)
		{
			this.Btn_SearchClickProcess();							
		}

		private void dpick_from_CloseUp(object sender, System.EventArgs e)
		{
			dpick_to.Value = dpick_from.Value; 
		}

		#region 입력이동

		#endregion

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
            //			ClassLib.ComFunction.Init_Form_Control(this);
			lbl_MainTitle.Text = "Incoming No List";
            this.Text = "Incoming No List";
            ClassLib.ComFunction.SetLangDic(this);

			// Grid Setting
			spd_main.Set_Spread_Comm("SBI_INCOMING_NO", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			vDt.Dispose();
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;

			// default search proviso
			if (COM.ComVar.Parameter_PopUp[0].ToString() != "")
				cmb_factory.SelectedValue	= COM.ComVar.Parameter_PopUp[0];

			// user define variable setting
			_mainSheet = spd_main.Sheets[0];

			// Disabled tbutton
			tbtn_Save.Enabled		= false;
			tbtn_Delete.Enabled		= false;
			tbtn_Conform.Enabled	= false;
			tbtn_Print.Enabled		= false;
			tbtn_Create.Enabled		= false;

		}

		private void Btn_SearchClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				string vFactory		= cmb_factory.SelectedValue.ToString();
				string vInYmdFr		= dpick_from.Text.Replace("-", "");
				string vInYmdTo		= dpick_to.Text.Replace("-", "");

				DataTable vDt = this.SELECT_SBI_IN_NO_LIST(vFactory, vInYmdFr, vInYmdTo);
				spd_main.Display_Grid(vDt);
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

		private void Grid_DoubleClickProcess(int arg_row)
		{
			int vFactory		= (int)ClassLib.TBSBI_INCOMING_NO.IxFACTORY;
			int vInYmd			= (int)ClassLib.TBSBI_INCOMING_NO.IxIN_YMD;
			int vInNo		    = (int)ClassLib.TBSBI_INCOMING_NO.IxIN_NO;

			COM.ComVar.Parameter_PopUp		= new string[3];
			COM.ComVar.Parameter_PopUp[0]	= _mainSheet.Cells[arg_row, vFactory].Text;
			COM.ComVar.Parameter_PopUp[1]	= _mainSheet.Cells[arg_row, vInYmd].Text;
			COM.ComVar.Parameter_PopUp[2]	= _mainSheet.Cells[arg_row, vInNo].Text;

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

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// PKG_SBS_SHIPPING_HEAD : 
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_ship_ymd_from">선적일(From)</param>
		/// <param name="arg_ship_ymd_to">선적일(To)</param>
		/// <param name="arg_size">Size Item</param>
		/// <param name="arg_ship_type">선적구분</param>
		/// <param name="arg_obs_type">OBS Type</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBI_IN_NO_LIST(string arg_factory, string arg_in_ymd_from, string arg_in_ymd_to)
		{
			DataSet vDt;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBI_IN_NO.SELECT_SBI_IN_NO_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_IN_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_IN_YMD_TO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;


			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_in_ymd_from;
			MyOraDB.Parameter_Values[2] = arg_in_ymd_to;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDt = MyOraDB.Exe_Select_Procedure();
			if(vDt == null) return null ;

			return vDt.Tables[MyOraDB.Process_Name];
		}

		#endregion


	}
}

