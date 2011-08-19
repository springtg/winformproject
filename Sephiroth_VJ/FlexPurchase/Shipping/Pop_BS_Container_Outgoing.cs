using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Container_Outgoing : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_shipFactory;
		private C1.Win.C1List.C1Combo cmb_shipFactory;
		private System.Windows.Forms.Label lbl_containerNo;
		private C1.Win.C1List.C1Combo cmb_contNo;
		private System.Windows.Forms.DateTimePicker dt_shipYmd;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_apply;
		private System.ComponentModel.IContainer components = null;

		public Pop_BS_Container_Outgoing()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Container_Outgoing));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_shipFactory = new System.Windows.Forms.Label();
            this.cmb_shipFactory = new C1.Win.C1List.C1Combo();
            this.lbl_containerNo = new System.Windows.Forms.Label();
            this.cmb_contNo = new C1.Win.C1List.C1Combo();
            this.dt_shipYmd = new System.Windows.Forms.DateTimePicker();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(320, 23);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_shipFactory);
            this.groupBox1.Controls.Add(this.cmb_shipFactory);
            this.groupBox1.Controls.Add(this.lbl_containerNo);
            this.groupBox1.Controls.Add(this.cmb_contNo);
            this.groupBox1.Controls.Add(this.dt_shipYmd);
            this.groupBox1.Controls.Add(this.lbl_shipYmd);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 95);
            this.groupBox1.TabIndex = 218;
            this.groupBox1.TabStop = false;
            // 
            // lbl_shipFactory
            // 
            this.lbl_shipFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipFactory.ImageIndex = 0;
            this.lbl_shipFactory.ImageList = this.img_Label;
            this.lbl_shipFactory.Location = new System.Drawing.Point(8, 16);
            this.lbl_shipFactory.Name = "lbl_shipFactory";
            this.lbl_shipFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipFactory.TabIndex = 202;
            this.lbl_shipFactory.Text = "Factory";
            this.lbl_shipFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipFactory
            // 
            this.cmb_shipFactory.AddItemCols = 0;
            this.cmb_shipFactory.AddItemSeparator = ';';
            this.cmb_shipFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipFactory.Caption = "";
            this.cmb_shipFactory.CaptionHeight = 17;
            this.cmb_shipFactory.CaptionStyle = style1;
            this.cmb_shipFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipFactory.ColumnCaptionHeight = 18;
            this.cmb_shipFactory.ColumnFooterHeight = 18;
            this.cmb_shipFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipFactory.ContentHeight = 16;
            this.cmb_shipFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipFactory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_shipFactory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipFactory.EditorHeight = 16;
            this.cmb_shipFactory.EvenRowStyle = style2;
            this.cmb_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipFactory.FooterStyle = style3;
            this.cmb_shipFactory.GapHeight = 2;
            this.cmb_shipFactory.HeadingStyle = style4;
            this.cmb_shipFactory.HighLightRowStyle = style5;
            this.cmb_shipFactory.ItemHeight = 15;
            this.cmb_shipFactory.Location = new System.Drawing.Point(109, 16);
            this.cmb_shipFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipFactory.MaxDropDownItems = ((short)(5));
            this.cmb_shipFactory.MaxLength = 32767;
            this.cmb_shipFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipFactory.Name = "cmb_shipFactory";
            this.cmb_shipFactory.OddRowStyle = style6;
            this.cmb_shipFactory.PartialRightColumn = false;
            this.cmb_shipFactory.PropBag = resources.GetString("cmb_shipFactory.PropBag");
            this.cmb_shipFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipFactory.RowSubDividerColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_shipFactory.SelectedStyle = style7;
            this.cmb_shipFactory.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipFactory.Style = style8;
            this.cmb_shipFactory.TabIndex = 10;
            this.cmb_shipFactory.SelectedValueChanged += new System.EventHandler(this.cmb_shipFactory_SelectedValueChanged);
            // 
            // lbl_containerNo
            // 
            this.lbl_containerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_containerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_containerNo.ImageIndex = 0;
            this.lbl_containerNo.ImageList = this.img_Label;
            this.lbl_containerNo.Location = new System.Drawing.Point(8, 60);
            this.lbl_containerNo.Name = "lbl_containerNo";
            this.lbl_containerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_containerNo.TabIndex = 202;
            this.lbl_containerNo.Text = "Container No";
            this.lbl_containerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_contNo
            // 
            this.cmb_contNo.AddItemCols = 0;
            this.cmb_contNo.AddItemSeparator = ';';
            this.cmb_contNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contNo.Caption = "";
            this.cmb_contNo.CaptionHeight = 17;
            this.cmb_contNo.CaptionStyle = style9;
            this.cmb_contNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_contNo.ColumnCaptionHeight = 18;
            this.cmb_contNo.ColumnFooterHeight = 18;
            this.cmb_contNo.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_contNo.ContentHeight = 16;
            this.cmb_contNo.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_contNo.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_contNo.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_contNo.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_contNo.EditorHeight = 16;
            this.cmb_contNo.EvenRowStyle = style10;
            this.cmb_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contNo.FooterStyle = style11;
            this.cmb_contNo.GapHeight = 2;
            this.cmb_contNo.HeadingStyle = style12;
            this.cmb_contNo.HighLightRowStyle = style13;
            this.cmb_contNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_contNo.ItemHeight = 15;
            this.cmb_contNo.Location = new System.Drawing.Point(109, 60);
            this.cmb_contNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_contNo.MaxDropDownItems = ((short)(5));
            this.cmb_contNo.MaxLength = 32767;
            this.cmb_contNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contNo.Name = "cmb_contNo";
            this.cmb_contNo.OddRowStyle = style14;
            this.cmb_contNo.PartialRightColumn = false;
            this.cmb_contNo.PropBag = resources.GetString("cmb_contNo.PropBag");
            this.cmb_contNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contNo.SelectedStyle = style15;
            this.cmb_contNo.Size = new System.Drawing.Size(222, 20);
            this.cmb_contNo.Style = style16;
            this.cmb_contNo.TabIndex = 215;
            this.cmb_contNo.SelectedValueChanged += new System.EventHandler(this.cmb_contNo_SelectedValueChanged);
            // 
            // dt_shipYmd
            // 
            this.dt_shipYmd.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dt_shipYmd.Checked = false;
            this.dt_shipYmd.CustomFormat = "";
            this.dt_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_shipYmd.Location = new System.Drawing.Point(109, 38);
            this.dt_shipYmd.Name = "dt_shipYmd";
            this.dt_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dt_shipYmd.TabIndex = 9;
            this.dt_shipYmd.CloseUp += new System.EventHandler(this.dt_shipYmd_CloseUp);
            // 
            // lbl_shipYmd
            // 
            this.lbl_shipYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipYmd.ImageIndex = 0;
            this.lbl_shipYmd.ImageList = this.img_Label;
            this.lbl_shipYmd.Location = new System.Drawing.Point(8, 38);
            this.lbl_shipYmd.Name = "lbl_shipYmd";
            this.lbl_shipYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipYmd.TabIndex = 202;
            this.lbl_shipYmd.Text = "Ship Date";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(278, 135);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 217;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(208, 135);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 216;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Pop_BS_Container_Outgoing
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 170);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BS_Container_Outgoing";
            this.Load += new System.EventHandler(this.Pop_BS_Container_Outgoing_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion


		#region 사용자 정의 변수
		
		private COM.OraDB MyOraDB                          = new COM.OraDB();
		private COM.ComFunction MyComFunction              = new COM.ComFunction();		
		private System.EventHandler _cmbContNoEventHandler = null;
		
		//Init_Form()
		private string[] _contNoTitles;
		private int[]    _contNoWidth;
		private bool[]   _contNoVisible;
		private double   vPriceRate;
		
		//Tbtn_SaveProcess() 
		private string _subprogram   = "OV";
		private string _cont_no            ;
		private string _bar_move     = ""  ;
		private string _scan_confirm = "S" ;
		private string _user         = ClassLib.ComVar.This_User;

		#endregion


		#region 이벤트 처리 메서드

		private void Init_Form()
		{
            // Form Setting			
            this.Text = "Outgoing Container";
            lbl_MainTitle.Text = "Outgoing Container";
            ClassLib.ComFunction.SetLangDic(this);
			
			DataTable vDt = null;
			
			_contNoTitles			= new string[]{     "SEQ", "CONT_NO", "CONT_UNIT", "CONT_DESC", "REMARKS"};
			_contNoWidth			= new int[]   {	      50 ,      125 ,	     80 ,	      80 ,        80 };
			_contNoVisible			= new bool[]  {      true,     true ,       true ,       true ,     true };			
			
			// Shipping Factory Setting
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt,  cmb_shipFactory,  0,  1,  false);
			cmb_shipFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();		

			//date 초기화  
			string nowymd   = System.DateTime.Now.ToString("yyyyMMdd");
			dt_shipYmd.Text = MyComFunction.ConvertDate2Type(nowymd);

			// user define variable set
			vDt = ClassLib.ComVar.Select_ComCode("DS", "SBS12");
			vDt.Dispose();

			vPriceRate = Convert.ToDouble(vDt.Rows[0][2]);
			
			Cmb_ContNoSettingProcess();
			
		}


		private void Cmb_ContNo_SelectedValueChangedProcess()
		{
			try
			{
				if( cmb_contNo.SelectedIndex == -1 )  return;

				cmb_contNo.Text = cmb_contNo.GetItemText(cmb_contNo.SelectedIndex, 0);				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ContNoSelected", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		
		private void Cmb_ContNoSettingProcess()
		{			
				try
				{
					cmb_contNo.SelectedValueChanged -= _cmbContNoEventHandler;

					string[] vProviso = GetSearchProviso();
					DataTable vDt = SELECT_CONTAINER_LIST(vProviso[0], vProviso[1]);

					ClassLib.ComFunction.Set_ComboList_Multi(vDt,  cmb_contNo,  new int[]{0, 1, 2, 3, 4},  false);
					ClassLib.ComFunction.SetComboStyle(cmb_contNo,  _contNoTitles,  _contNoWidth,  _contNoVisible,  "CONT_NO");

					vDt.Dispose();

					cmb_contNo.SelectedValueChanged += _cmbContNoEventHandler;
				
				}
				catch (Exception ex)
				{
					ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}			
		}	


		private string[] GetSearchProviso()
		{
			string[] vProviso = new string[2];

			vProviso[0] = COM.ComFunction.Empty_Combo(cmb_shipFactory, "");
			vProviso[1] = dt_shipYmd.Text.Replace("-", "");					

			return vProviso;
		}
		
		
		private void Tbtn_SaveProcess()
		{
			try
			{			
				this.Cursor = Cursors.WaitCursor;

				C1.Win.C1List.C1Combo[] cmb_array = { cmb_shipFactory, cmb_contNo };   
				bool essential_check = FlexPurchase.ClassLib.ComFunction.Essentiality_check(cmb_array, null); 

				if(! essential_check) return;

				if (DialogResult.Yes == ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
				{
					_cont_no = cmb_contNo.Text.Trim();

					SAVE_SBS_BAR_OUT(_subprogram,  _cont_no,  _bar_move,  _scan_confirm, _user);						
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default;				
			}
		}
		
		
		#endregion


		#region 컨트롤 이벤트 

		private void Pop_BS_Container_Outgoing_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}		


		private void cmb_shipFactory_SelectedValueChanged(object sender, System.EventArgs e)
		{			
			this.Cmb_ContNoSettingProcess();			
		}


		private void dt_shipYmd_CloseUp(object sender, System.EventArgs e)
		{				
			this.Cmb_ContNoSettingProcess();	
		}	


		private void cmb_contNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ContNo_SelectedValueChangedProcess();
		}


		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Tbtn_SaveProcess();		
		}


		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		#endregion


		#region DB Connect
		
		private DataTable SELECT_CONTAINER_LIST(string arg_factory, string arg_ship_ymd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_CONTAINER_OUTGOING.SELECT_CONTAINER_LIST";


			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";			
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_ymd;			
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}


		private DataTable SAVE_SBS_BAR_OUT(string arg_subprogram,   string arg_cont_no, string arg_bar_move, 
			                               string arg_scan_confirm, string arg_user)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(5);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_PDA_OUT.SAVE_SBS_BAR_OUT"; 

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_SUBPROGRAM";
			MyOraDB.Parameter_Name[1] = "ARG_CONT_NO";
			MyOraDB.Parameter_Name[2] = "ARG_BAR_MOVE";
			MyOraDB.Parameter_Name[3] = "ARG_SCAN_CONFIRM";
			MyOraDB.Parameter_Name[4] = "ARG_USER";
			
			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			
			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_subprogram;
			MyOraDB.Parameter_Values[1] = arg_cont_no;
			MyOraDB.Parameter_Values[2] = arg_bar_move;
			MyOraDB.Parameter_Values[3] = arg_scan_confirm;
			MyOraDB.Parameter_Values[4] = arg_user;			

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}
        		
		#endregion


		#region Validate Check
		
		#endregion

		

		

		

	
		

	

		












	}
}

