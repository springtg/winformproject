using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexMRP.MRP
{
	public class Pop_BM_MRP_Usage_Local_Purchase : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DateTimePicker dpick_value;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private C1.Win.C1List.C1Combo cmb_purUser;
		private System.Windows.Forms.Label lbl_purUser;
		private System.Windows.Forms.Label label2;

		private COM.OraDB MyOraDB = new COM.OraDB(); 

		public Pop_BM_MRP_Usage_Local_Purchase()
		{
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

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BM_MRP_Usage_Local_Purchase));
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
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_purUser = new C1.Win.C1List.C1Combo();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.dpick_value = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_purUser = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
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
            this.btn_apply.Location = new System.Drawing.Point(205, 144);
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
            this.btn_cancel.Location = new System.Drawing.Point(277, 144);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageIndex = 1;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 218;
            this.label1.Text = "Purchase Date";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_purUser);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.dpick_value);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 96);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cmb_purUser
            // 
            this.cmb_purUser.AddItemCols = 0;
            this.cmb_purUser.AddItemSeparator = ';';
            this.cmb_purUser.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_purUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_purUser.Caption = "";
            this.cmb_purUser.CaptionHeight = 17;
            this.cmb_purUser.CaptionStyle = style1;
            this.cmb_purUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_purUser.ColumnCaptionHeight = 18;
            this.cmb_purUser.ColumnFooterHeight = 18;
            this.cmb_purUser.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_purUser.ContentHeight = 16;
            this.cmb_purUser.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_purUser.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_purUser.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_purUser.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_purUser.EditorHeight = 16;
            this.cmb_purUser.EvenRowStyle = style2;
            this.cmb_purUser.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_purUser.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_purUser.FooterStyle = style3;
            this.cmb_purUser.GapHeight = 2;
            this.cmb_purUser.HeadingStyle = style4;
            this.cmb_purUser.HighLightRowStyle = style5;
            this.cmb_purUser.ItemHeight = 15;
            this.cmb_purUser.Location = new System.Drawing.Point(109, 60);
            this.cmb_purUser.MatchEntryTimeout = ((long)(2000));
            this.cmb_purUser.MaxDropDownItems = ((short)(5));
            this.cmb_purUser.MaxLength = 32767;
            this.cmb_purUser.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_purUser.Name = "cmb_purUser";
            this.cmb_purUser.OddRowStyle = style6;
            this.cmb_purUser.PartialRightColumn = false;
            this.cmb_purUser.PropBag = resources.GetString("cmb_purUser.PropBag");
            this.cmb_purUser.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_purUser.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_purUser.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_purUser.SelectedStyle = style7;
            this.cmb_purUser.Size = new System.Drawing.Size(220, 20);
            this.cmb_purUser.Style = style8;
            this.cmb_purUser.TabIndex = 397;
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
            this.cmb_factory.EvenRowStyle = style10;
            this.cmb_factory.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style11;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style12;
            this.cmb_factory.HighLightRowStyle = style13;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
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
            this.cmb_factory.Size = new System.Drawing.Size(220, 20);
            this.cmb_factory.Style = style16;
            this.cmb_factory.TabIndex = 221;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 222;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_value
            // 
            this.dpick_value.CustomFormat = "";
            this.dpick_value.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_value.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_value.Location = new System.Drawing.Point(109, 38);
            this.dpick_value.Name = "dpick_value";
            this.dpick_value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_value.Size = new System.Drawing.Size(221, 21);
            this.dpick_value.TabIndex = 220;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageIndex = 1;
            this.label2.ImageList = this.img_Label;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 218;
            this.label2.Text = "User";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_purUser
            // 
            this.lbl_purUser.Location = new System.Drawing.Point(0, 0);
            this.lbl_purUser.Name = "lbl_purUser";
            this.lbl_purUser.Size = new System.Drawing.Size(100, 23);
            this.lbl_purUser.TabIndex = 0;
            // 
            // Pop_BM_MRP_Usage_Local_Purchase
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 176);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BM_MRP_Usage_Local_Purchase";
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_purUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		private string _mrpDate; 

		#region 컨트롤 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				COM.ComVar.Parameter_PopUp = new string[] { COM.ComFunction.Empty_Combo(cmb_factory, ""),   dpick_value.Value.ToString("yyyyMMdd"), COM.ComFunction.Empty_Combo(cmb_purUser, "") };
				this.Btn_ApplyProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.Btn_CancelProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}		
		}

		#endregion

		#region 이벤트 처리 메서드
		
		/// <summary>
		/// Init_Form : Form Initialize
		/// </summary>
		private void Init_Form()
		{						
			// Form Setting
			this.Text = "Purchase Date";
			lbl_MainTitle.Text = "Purchase Date";

            ClassLib.ComFunction.SetLangDic(this);


			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			//cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			cmb_factory.SelectedValue = COM.ComVar.Parameter_PopUp[0];
			vDt.Dispose() ;

			
			// cmb_purUser
			vDt = ClassLib.ComFunction.Select_Man_Charge(COM.ComVar.This_Factory,"");
			ClassLib.ComCtl.Set_ComboList(vDt,cmb_purUser, 1, 1, true, 0, 210);
			//cmb_purUser.ValueMember = "Name";
			cmb_purUser.SelectedValue = COM.ComVar.This_User;

		}

		private void Btn_ApplyProcess()
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_CancelProcess()
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		public string mrpDate
		{
			get
			{
				return _mrpDate;
			}
		}

		#endregion

		#region 데이터베이스
		
		/// <summary>
		/// SELECT_MRP_SHIP_NO : MRP_SHIP_NO 중복 체크
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_MRP_SHIP_NO()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_MRP_USAGE_LOCAL.SELECT_MRP_SHIP_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";
			MyOraDB.Parameter_Name[2] = "ARG_MRP_SHIP_NO";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			string factory = COM.ComVar.Parameter_PopUp[0];
			string shipType = COM.ComVar.Parameter_PopUp[1];
			string mrpDate = dpick_value.Value.ToString("yyyyMMdd");

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = factory;
			MyOraDB.Parameter_Values[1] = shipType;
			MyOraDB.Parameter_Values[2] = factory + shipType + mrpDate;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion


	}
}
