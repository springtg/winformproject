using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Vendor_Change : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
		private System.Windows.Forms.Label lbl_item;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_oVandorCode;
		private System.Windows.Forms.TextBox txt_oVandorName;
		private System.Windows.Forms.CheckBox chk_Action1;
		private System.Windows.Forms.CheckBox chk_Action2;
		private System.Windows.Forms.CheckBox chk_Action5;
		private System.Windows.Forms.CheckBox chk_Action3;
		private System.Windows.Forms.CheckBox chk_Action4;
		private System.ComponentModel.IContainer components = null;

		public Pop_BS_Vendor_Change()
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Vendor_Change));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_oVandorCode = new System.Windows.Forms.TextBox();
            this.txt_oVandorName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_Action1 = new System.Windows.Forms.CheckBox();
            this.chk_Action2 = new System.Windows.Forms.CheckBox();
            this.chk_Action3 = new System.Windows.Forms.CheckBox();
            this.chk_Action5 = new System.Windows.Forms.CheckBox();
            this.chk_Action4 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // txt_vendorCode
            // 
            this.txt_vendorCode.BackColor = System.Drawing.SystemColors.Window;
            this.txt_vendorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_vendorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_vendorCode.Location = new System.Drawing.Point(108, 46);
            this.txt_vendorCode.MaxLength = 10;
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(90, 21);
            this.txt_vendorCode.TabIndex = 4;
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
            this.cmb_vendor.CaptionStyle = style9;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style10;
            this.cmb_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.FooterStyle = style11;
            this.cmb_vendor.GapHeight = 2;
            this.cmb_vendor.HeadingStyle = style12;
            this.cmb_vendor.HighLightRowStyle = style13;
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(199, 46);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(10));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style14;
            this.cmb_vendor.PartialRightColumn = false;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style15;
            this.cmb_vendor.Size = new System.Drawing.Size(169, 20);
            this.cmb_vendor.Style = style16;
            this.cmb_vendor.TabIndex = 5;
            // 
            // lbl_item
            // 
            this.lbl_item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
            this.lbl_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(8, 46);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(100, 21);
            this.lbl_item.TabIndex = 251;
            this.lbl_item.Text = "New Vendor";
            this.lbl_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(296, 72);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 250;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(224, 72);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 249;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(218)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 251;
            this.label1.Text = "Old Vendor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_oVandorCode
            // 
            this.txt_oVandorCode.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_oVandorCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_oVandorCode.Enabled = false;
            this.txt_oVandorCode.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_oVandorCode.ForeColor = System.Drawing.Color.Black;
            this.txt_oVandorCode.Location = new System.Drawing.Point(108, 24);
            this.txt_oVandorCode.MaxLength = 10;
            this.txt_oVandorCode.Name = "txt_oVandorCode";
            this.txt_oVandorCode.Size = new System.Drawing.Size(90, 21);
            this.txt_oVandorCode.TabIndex = 252;
            // 
            // txt_oVandorName
            // 
            this.txt_oVandorName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_oVandorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_oVandorName.Enabled = false;
            this.txt_oVandorName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_oVandorName.ForeColor = System.Drawing.Color.Black;
            this.txt_oVandorName.Location = new System.Drawing.Point(199, 24);
            this.txt_oVandorName.MaxLength = 10;
            this.txt_oVandorName.Name = "txt_oVandorName";
            this.txt_oVandorName.Size = new System.Drawing.Size(169, 21);
            this.txt_oVandorName.TabIndex = 252;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk_Action1);
            this.groupBox1.Controls.Add(this.chk_Action2);
            this.groupBox1.Controls.Add(this.chk_Action3);
            this.groupBox1.Controls.Add(this.chk_Action5);
            this.groupBox1.Controls.Add(this.chk_Action4);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 112);
            this.groupBox1.TabIndex = 253;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // chk_Action1
            // 
            this.chk_Action1.Checked = true;
            this.chk_Action1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Action1.Location = new System.Drawing.Point(24, 24);
            this.chk_Action1.Name = "chk_Action1";
            this.chk_Action1.Size = new System.Drawing.Size(160, 24);
            this.chk_Action1.TabIndex = 0;
            this.chk_Action1.Text = "Purchase Order";
            // 
            // chk_Action2
            // 
            this.chk_Action2.Checked = true;
            this.chk_Action2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Action2.Location = new System.Drawing.Point(24, 48);
            this.chk_Action2.Name = "chk_Action2";
            this.chk_Action2.Size = new System.Drawing.Size(160, 24);
            this.chk_Action2.TabIndex = 0;
            this.chk_Action2.Text = "Shipping List";
            // 
            // chk_Action3
            // 
            this.chk_Action3.Checked = true;
            this.chk_Action3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Action3.Location = new System.Drawing.Point(208, 24);
            this.chk_Action3.Name = "chk_Action3";
            this.chk_Action3.Size = new System.Drawing.Size(160, 24);
            this.chk_Action3.TabIndex = 0;
            this.chk_Action3.Text = "Bar Code List";
            // 
            // chk_Action5
            // 
            this.chk_Action5.Checked = true;
            this.chk_Action5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Action5.Location = new System.Drawing.Point(208, 48);
            this.chk_Action5.Name = "chk_Action5";
            this.chk_Action5.Size = new System.Drawing.Size(160, 24);
            this.chk_Action5.TabIndex = 0;
            this.chk_Action5.Text = "CBD Master";
            // 
            // chk_Action4
            // 
            this.chk_Action4.Checked = true;
            this.chk_Action4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Action4.Location = new System.Drawing.Point(24, 72);
            this.chk_Action4.Name = "chk_Action4";
            this.chk_Action4.Size = new System.Drawing.Size(160, 24);
            this.chk_Action4.TabIndex = 0;
            this.chk_Action4.Text = "Invoice List";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.cmb_vendor);
            this.groupBox2.Controls.Add(this.btn_apply);
            this.groupBox2.Controls.Add(this.lbl_item);
            this.groupBox2.Controls.Add(this.txt_oVandorName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txt_oVandorCode);
            this.groupBox2.Controls.Add(this.btn_cancel);
            this.groupBox2.Controls.Add(this.txt_vendorCode);
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 104);
            this.groupBox2.TabIndex = 254;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendor Change";
            // 
            // Pop_BS_Vendor_Change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 272);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Pop_BS_Vendor_Change";
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private string _Factory;
		private string _Ship_No;
		private string _Ship_Seq;
		private string _Flag;



		#endregion


		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
        {
			this.Text = "Vendor Change";
            lbl_MainTitle.Text = "Vendor Change";
            ClassLib.ComFunction.SetLangDic(this);

			_Factory			 = COM.ComVar.Parameter_PopUp[0];
			_Ship_No			 = COM.ComVar.Parameter_PopUp[1];
			_Ship_Seq			 = COM.ComVar.Parameter_PopUp[2]; 
			txt_oVandorCode.Text = COM.ComVar.Parameter_PopUp[3];
			txt_oVandorName.Text = COM.ComVar.Parameter_PopUp[4];

		}

		private void Txt_VendorCodeKeyUpProcess()
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

		#endregion


		#region 컨트롤 이벤트 처리 메서드

		private void txt_vendorCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
		
			if (e.KeyCode == Keys.Enter)
			{
				this.Txt_VendorCodeKeyUpProcess();
				cmb_vendor.Focus();
			}
		}

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}



		#endregion

		private void btn_apply_Click(object sender, System.EventArgs e)
		{

			if (this.Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				if (MessageBox.Show(this, "Do you want to Vendor change?", "Run", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					if(Run_Vendor_Change())
					{
						
						COM.ComVar.Parameter_PopUp		= new string[2];
						COM.ComVar.Parameter_PopUp[0]	= cmb_vendor.SelectedValue.ToString();
						COM.ComVar.Parameter_PopUp[1]	= cmb_vendor.Text.ToString();
						
						this.Dispose();

					}
					else
					{
						ClassLib.ComFunction.Data_Message("Vendor Change", ClassLib.ComVar.MgsDoNotRun, this);
					} 
			} 
		}


		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Dispose();
		}


		private bool Run_Vendor_Change()
		{

			this.Cursor = Cursors.WaitCursor;

			_Flag = ""; 
			if (chk_Action1.Checked) {_Flag = _Flag + "1";} else {_Flag = _Flag + "0";} 
			if (chk_Action2.Checked) {_Flag = _Flag + "1";} else {_Flag = _Flag + "0";}
			if (chk_Action3.Checked) {_Flag = _Flag + "1";} else {_Flag = _Flag + "0";}
			if (chk_Action4.Checked) {_Flag = _Flag + "1";} else {_Flag = _Flag + "0";}
			if (chk_Action5.Checked) {_Flag = _Flag + "1";} else {_Flag = _Flag + "0";}

			try
			{

				DataSet ds_ret;

				MyOraDB.ReDim_Parameter(6);

				//01.PROCEDURE명 
				MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.RUN_VENDOR_CHANGE";
 
				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_NO";
				MyOraDB.Parameter_Name[2] = "ARG_SHIP_SEQ";
				MyOraDB.Parameter_Name[3] = "ARG_CUST_CD";
				MyOraDB.Parameter_Name[4] = "ARG_FLAG";
				MyOraDB.Parameter_Name[5] = "ARG_UPD_USER";  

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar; 

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _Ship_No;
				MyOraDB.Parameter_Values[2] = _Ship_Seq;
				MyOraDB.Parameter_Values[3] = cmb_vendor.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = _Flag;
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;

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
			finally
			{
				this.Cursor = Cursors.Default;
			} 

			 

		}


		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
			if (cmb_vendor.SelectedIndex == -1)
			{
				ClassLib.ComFunction.User_Message("Select Vendor", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				cmb_vendor.Focus();
				return false;
			}

			return true;
		}

		#endregion


	}
}

