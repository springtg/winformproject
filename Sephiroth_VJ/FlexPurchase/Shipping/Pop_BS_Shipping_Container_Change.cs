using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_Container_Change : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.TextBox txt_contNo;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private System.EventHandler _cmbContNoEvent = null;
		private C1.Win.C1List.C1Combo cmb_contNo;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_OldcontainerNo;
		private System.Windows.Forms.Label lbl_NewcontainerNo;
		private System.Windows.Forms.TextBox txt_contNoOld;
		private System.Windows.Forms.Label label1;


		#endregion

		public Pop_BS_Shipping_Container_Change()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_Container_Change));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.lbl_OldcontainerNo = new System.Windows.Forms.Label();
            this.lbl_NewcontainerNo = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.txt_contNo = new System.Windows.Forms.TextBox();
            this.cmb_contNo = new C1.Win.C1List.C1Combo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_contNoOld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).BeginInit();
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
            // lbl_OldcontainerNo
            // 
            this.lbl_OldcontainerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OldcontainerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OldcontainerNo.ImageIndex = 0;
            this.lbl_OldcontainerNo.ImageList = this.img_Label;
            this.lbl_OldcontainerNo.Location = new System.Drawing.Point(8, 16);
            this.lbl_OldcontainerNo.Name = "lbl_OldcontainerNo";
            this.lbl_OldcontainerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_OldcontainerNo.TabIndex = 202;
            this.lbl_OldcontainerNo.Text = "Container No";
            this.lbl_OldcontainerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_NewcontainerNo
            // 
            this.lbl_NewcontainerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_NewcontainerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewcontainerNo.ImageIndex = 0;
            this.lbl_NewcontainerNo.ImageList = this.img_Label;
            this.lbl_NewcontainerNo.Location = new System.Drawing.Point(8, 77);
            this.lbl_NewcontainerNo.Name = "lbl_NewcontainerNo";
            this.lbl_NewcontainerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_NewcontainerNo.TabIndex = 202;
            this.lbl_NewcontainerNo.Text = "New Container";
            this.lbl_NewcontainerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(232, 160);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 12;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_cancel
            // 
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(304, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // txt_contNo
            // 
            this.txt_contNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_contNo.Location = new System.Drawing.Point(109, 77);
            this.txt_contNo.MaxLength = 11;
            this.txt_contNo.Name = "txt_contNo";
            this.txt_contNo.Size = new System.Drawing.Size(89, 21);
            this.txt_contNo.TabIndex = 1;
            this.txt_contNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contNo_KeyPress);
            // 
            // cmb_contNo
            // 
            this.cmb_contNo.AddItemCols = 0;
            this.cmb_contNo.AddItemSeparator = ';';
            this.cmb_contNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contNo.Caption = "";
            this.cmb_contNo.CaptionHeight = 17;
            this.cmb_contNo.CaptionStyle = style1;
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
            this.cmb_contNo.EvenRowStyle = style2;
            this.cmb_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contNo.FooterStyle = style3;
            this.cmb_contNo.GapHeight = 2;
            this.cmb_contNo.HeadingStyle = style4;
            this.cmb_contNo.HighLightRowStyle = style5;
            this.cmb_contNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_contNo.ItemHeight = 15;
            this.cmb_contNo.Location = new System.Drawing.Point(199, 77);
            this.cmb_contNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_contNo.MaxDropDownItems = ((short)(5));
            this.cmb_contNo.MaxLength = 32767;
            this.cmb_contNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contNo.Name = "cmb_contNo";
            this.cmb_contNo.OddRowStyle = style6;
            this.cmb_contNo.PartialRightColumn = false;
            this.cmb_contNo.PropBag = resources.GetString("cmb_contNo.PropBag");
            this.cmb_contNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contNo.SelectedStyle = style7;
            this.cmb_contNo.Size = new System.Drawing.Size(130, 20);
            this.cmb_contNo.Style = style8;
            this.cmb_contNo.TabIndex = 215;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_contNoOld);
            this.groupBox1.Controls.Add(this.lbl_NewcontainerNo);
            this.groupBox1.Controls.Add(this.cmb_contNo);
            this.groupBox1.Controls.Add(this.lbl_OldcontainerNo);
            this.groupBox1.Controls.Add(this.txt_contNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 112);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            // 
            // txt_contNoOld
            // 
            this.txt_contNoOld.AcceptsReturn = true;
            this.txt_contNoOld.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contNoOld.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contNoOld.Enabled = false;
            this.txt_contNoOld.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_contNoOld.Location = new System.Drawing.Point(109, 16);
            this.txt_contNoOld.MaxLength = 11;
            this.txt_contNoOld.Name = "txt_contNoOld";
            this.txt_contNoOld.Size = new System.Drawing.Size(219, 21);
            this.txt_contNoOld.TabIndex = 216;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(192, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 35);
            this.label1.TabIndex = 218;
            this.label1.Text = "▼";
            // 
            // Pop_BS_Shipping_Container_Change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(384, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BS_Shipping_Container_Change";
            this.Load += new System.EventHandler(this.Pop_BS_New_Ship_Container_Load);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		
		#region 정합성 체크

		private bool Etc_ProvisoValidateCheck(int arg_type)
		{
			// 공통 체크
 

			// 부분별 체크 (Search, Save, Delete, Confirm..)
			switch (arg_type)
			{
				case ClassLib.ComVar.Validate_Search:

					break;
				case ClassLib.ComVar.Validate_Save:
				    if (txt_contNoOld.Text.Equals("") ) 
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					if (ClassLib.ComFunction.Empty_Combo(cmb_contNo, "").Equals("") ) 
					{
						ClassLib.ComFunction.User_Message("Data not found", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}


					break;
				case ClassLib.ComVar.Validate_Delete:

					break;
				case ClassLib.ComVar.Validate_Confirm:

					break;
			}

			return true;
		}

		#endregion 


		#region 컨트롤 이벤트 처리

		private void Pop_BS_New_Ship_Container_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			if (Etc_ProvisoValidateCheck(ClassLib.ComVar.Validate_Save))
			{
				this.Btn_ApplyClickProcess();			
			}  
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		
		private void txt_contNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				cmb_contNo.Focus();
				this.Txt_ContNoTextChangedProcess();
			}
		}

		
		private void Txt_ContNoTextChangedProcess()
		{
			try
			{
				this.cmb_contNo.SelectedValueChanged -= _cmbContNoEvent;

				DataTable vDt = this.SELECT_SBC_CONTAINER_LIST(txt_contNo.Text, "", "Y");
				COM.ComCtl.Set_ComboList(vDt, cmb_contNo, 0, 1, false);
				ClassLib.ComFunction.SetComboStyle(cmb_contNo, new string[]{"Container", "Unit"}, new int[]{130, 70}, new bool[]{true, true}, "Container");
				cmb_contNo.DropDownWidth = 220;
				vDt.Dispose();

				cmb_contNo.SelectedValue = txt_contNo.Text;

				this.cmb_contNo.SelectedValueChanged += _cmbContNoEvent;
		
			}
			catch (StackOverflowException sofe)
			{
				ClassLib.ComFunction.User_Message(sofe.StackTrace, "ContNoTextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch //(Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "ContNoTextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        #endregion

		#region 버튼효과

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex++;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex--;
		}

		#endregion
 
		#region 공통 메서드

		private void Btn_ApplyClickProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				
				if (this.SAVE_CONTAINER_CHANGE(COM.ComVar.Parameter_PopUp[0], COM.ComVar.Parameter_PopUp[1].Replace("-", ""), COM.ComVar.Parameter_PopUp[2], ClassLib.ComFunction.Empty_Combo(cmb_contNo, "")) )
				{
					this.Close();
				}
				else
				{
					ClassLib.ComFunction.User_Message("Save Error !!!");
				}


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
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
            // ClassLib.ComFunction.Init_Form_Control(this);
			this.Text = "Container No Change";
            lbl_MainTitle.Text = "Container No Change";
            ClassLib.ComFunction.SetLangDic(this);

				
			txt_contNoOld.Text = COM.ComVar.Parameter_PopUp[2];
			
		}
 
		#endregion

		#region DB Connect

		/// <summary>
		/// PKG_SBC_CONTAINER : 
		/// </summary>
		/// <param name="arg_ship_ymd"></param>
		/// <param name="arg_ship_fact"></param>
		/// <param name="arg_ship_seq"></param>
		/// <returns>DataTable : 결과테이블</returns>
		public bool SAVE_CONTAINER_CHANGE(string arg_ship_fact, string arg_ship_ymd,  string arg_old_cont_no, string arg_new_cont_no)
		{

			try
			{
				MyOraDB.ReDim_Parameter(4);

				//01.PROCEDURE명
				MyOraDB.Process_Name = "PKG_SBS_SHIP_CONTAINER.RUN_CONTAINER_CHANGE";

				//02.ARGURMENT 명
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_SHIP_YMD";
				MyOraDB.Parameter_Name[2] = "ARG_OLD_CONT_NO";
				MyOraDB.Parameter_Name[3] = "ARG_NEW_CONT_NO";

				//03.DATA TYPE 정의
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;

				//04.DATA 정의
				MyOraDB.Parameter_Values[0] = arg_ship_fact;
				MyOraDB.Parameter_Values[1] = arg_ship_ymd;
				MyOraDB.Parameter_Values[2] = arg_old_cont_no;
				MyOraDB.Parameter_Values[3] = arg_new_cont_no;


				MyOraDB.Add_Modify_Parameter(true);

				if (MyOraDB.Exe_Modify_Procedure() == null)
					return false;
				else
					return true;
			}
				catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "MAKE_BARCODE", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

		}

		
		/// <summary>
		/// PKG_SBC_CONTAINER : 
		/// </summary>
		/// <param name="arg_cont_no">컨테이너번호</param>
		/// <param name="arg_cont_unit">컨테이너유닛</param>
		/// <param name="arg_use_yn">사용여부</param>
		/// <returns>DataTable : 결과테이블</returns>
		public DataTable SELECT_SBC_CONTAINER_LIST(string arg_cont_no, string arg_cont_unit, string arg_use_yn)
		{
			DataSet vDs;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBC_CONTAINER.SELECT_SBC_CONTAINER_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_CONT_NO";
			MyOraDB.Parameter_Name[1] = "ARG_CONT_UNIT";
			MyOraDB.Parameter_Name[2] = "ARG_USE_YN";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_cont_no;
			MyOraDB.Parameter_Values[1] = arg_cont_unit;
			MyOraDB.Parameter_Values[2] = arg_use_yn;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vDs = MyOraDB.Exe_Select_Procedure();
			if(vDs == null) return null ;

			return vDs.Tables[MyOraDB.Process_Name];
		}

		#endregion


 

	}
}
