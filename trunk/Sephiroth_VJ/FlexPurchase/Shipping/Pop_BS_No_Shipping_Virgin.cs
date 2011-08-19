using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_No_Shipping_Virgin : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private C1.Win.C1List.C1Combo cmb_Reason;
		private System.Windows.Forms.Label lbl_Remark;
		private System.Windows.Forms.Label lbl_Reason;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.GroupBox groupBox1;

		private COM.OraDB MyOraDB = new COM.OraDB();

		public Pop_BS_No_Shipping_Virgin()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_No_Shipping_Virgin));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.cmb_Reason = new C1.Win.C1List.C1Combo();
            this.lbl_Remark = new System.Windows.Forms.Label();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.lbl_Reason = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Reason)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(188, 60);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(259, 60);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_Reason
            // 
            this.cmb_Reason.AddItemCols = 0;
            this.cmb_Reason.AddItemSeparator = ';';
            this.cmb_Reason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Reason.Caption = "";
            this.cmb_Reason.CaptionHeight = 17;
            this.cmb_Reason.CaptionStyle = style1;
            this.cmb_Reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Reason.ColumnCaptionHeight = 18;
            this.cmb_Reason.ColumnFooterHeight = 18;
            this.cmb_Reason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Reason.ContentHeight = 16;
            this.cmb_Reason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Reason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Reason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Reason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Reason.EditorHeight = 16;
            this.cmb_Reason.EvenRowStyle = style2;
            this.cmb_Reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Reason.FooterStyle = style3;
            this.cmb_Reason.GapHeight = 2;
            this.cmb_Reason.HeadingStyle = style4;
            this.cmb_Reason.HighLightRowStyle = style5;
            this.cmb_Reason.ItemHeight = 15;
            this.cmb_Reason.Location = new System.Drawing.Point(109, 16);
            this.cmb_Reason.MatchEntryTimeout = ((long)(2000));
            this.cmb_Reason.MaxDropDownItems = ((short)(5));
            this.cmb_Reason.MaxLength = 32767;
            this.cmb_Reason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Reason.Name = "cmb_Reason";
            this.cmb_Reason.OddRowStyle = style6;
            this.cmb_Reason.PartialRightColumn = false;
            this.cmb_Reason.PropBag = resources.GetString("cmb_Reason.PropBag");
            this.cmb_Reason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Reason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Reason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Reason.SelectedStyle = style7;
            this.cmb_Reason.Size = new System.Drawing.Size(220, 20);
            this.cmb_Reason.Style = style8;
            this.cmb_Reason.TabIndex = 1;
            this.cmb_Reason.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_process_KeyPress);
            // 
            // lbl_Remark
            // 
            this.lbl_Remark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Remark.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remark.ImageIndex = 0;
            this.lbl_Remark.ImageList = this.img_Label;
            this.lbl_Remark.Location = new System.Drawing.Point(8, 38);
            this.lbl_Remark.Name = "lbl_Remark";
            this.lbl_Remark.Size = new System.Drawing.Size(100, 21);
            this.lbl_Remark.TabIndex = 218;
            this.lbl_Remark.Text = "Remarks";
            this.lbl_Remark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Remarks.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Remarks.Location = new System.Drawing.Point(109, 38);
            this.txt_Remarks.MaxLength = 10;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(220, 21);
            this.txt_Remarks.TabIndex = 2;
            this.txt_Remarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loss_KeyPress);
            // 
            // lbl_Reason
            // 
            this.lbl_Reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_Reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reason.ImageIndex = 0;
            this.lbl_Reason.ImageList = this.img_Label;
            this.lbl_Reason.Location = new System.Drawing.Point(8, 16);
            this.lbl_Reason.Name = "lbl_Reason";
            this.lbl_Reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_Reason.TabIndex = 218;
            this.lbl_Reason.Text = "Reason";
            this.lbl_Reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_Remarks);
            this.groupBox1.Controls.Add(this.cmb_Reason);
            this.groupBox1.Controls.Add(this.lbl_Reason);
            this.groupBox1.Controls.Add(this.lbl_Remark);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.btn_apply);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 94);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BS_No_Shipping_Virgin
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 141);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_BS_No_Shipping_Virgin";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Reason)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelProcess();
		}
	
		#region 입력이동
		
		private void cmb_process_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				txt_Remarks.Focus();
		}

		private void txt_loss_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Btn_ApplyProcess();
		}
		
		#endregion

		#region 버튼효과

		#endregion

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
            // ClassLib.ComFunction.Init_Form_Control(this);
			this.Text = "Virgin Info";
            lbl_MainTitle.Text = "Virgin Info";
            ClassLib.ComFunction.SetLangDic(this);

			//string vFactory = COM.ComVar.Parameter_PopUp[0];
            ClassLib.ComFunction.SetComboData(cmb_Reason, ClassLib.ComVar.CxVirginReason, false, 1);
		}

		private void Btn_ApplyProcess()
		{
			string vReasonCode  = COM.ComFunction.Empty_Combo(cmb_Reason, "");
			string vReason		= ClassLib.ComFunction.NullToBlank(cmb_Reason.GetItemText(cmb_Reason.SelectedIndex, 1));
			string vRemarks		= txt_Remarks.Text;

			COM.ComVar.Parameter_PopUp = new string[]{vReasonCode, vReason, vRemarks};
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_CancelProcess()
		{
			this.Close();
		}

		#endregion

		#region DB Connect
 		
		/// <summary>
		/// SELECT_SPB_ROUT_BOM_LIST
		/// </summary>
		/// <param name="arg_factory">공장코드</param>
		/// <param name="arg_style_cd">스타일코드</param>
		/// <returns>DataTable</returns>
		public DataTable SELECT_OUTGOING_PROCESS_LIST(string arg_factory, string arg_style_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_YIELD_INFO.SELECT_OUTGOING_PROCESS_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_style_cd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion																								

	}
}

