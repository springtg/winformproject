using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_Material_AutoCheck : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private COM.SSP spd_main;
		private System.Windows.Forms.RadioButton rad_allCheck;
		private System.Windows.Forms.RadioButton rad_allCheckByItem;
		private System.Windows.Forms.RadioButton rad_allCheckByModel;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;
		private System.Windows.Forms.Label btn_search;
		private System.Windows.Forms.Label lbl_style;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.SSP _ssp;
		private COM.FSP _fsp;
		private string _factory, _styleCd;
		private int _orignalHeight = 400, _newHeight = 260;
		private int _shipYnCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSHIP_YN;
		private const string _TypeSG = "S", _TypeCmp = "C", _TypeMat = "M", _TypeJoint = "J";
		private System.Windows.Forms.CheckBox chk_clear;
		private System.Windows.Forms.RadioButton rad_exceptOutside;
		private System.Windows.Forms.RadioButton rad_allClear;

		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자

		public Pop_BS_Shipping_Material_AutoCheck(Control arg_grid, string arg_factory, string arg_style)
		{
			InitializeComponent();
            
			_factory = arg_factory;
			_styleCd = arg_style.Replace("-", "").Trim();
			lbl_style.Text = "(" + arg_style + ")";
			Init_Form(arg_grid);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_Material_AutoCheck));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_allClear = new System.Windows.Forms.RadioButton();
            this.chk_clear = new System.Windows.Forms.CheckBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.rad_allCheck = new System.Windows.Forms.RadioButton();
            this.rad_allCheckByItem = new System.Windows.Forms.RadioButton();
            this.rad_allCheckByModel = new System.Windows.Forms.RadioButton();
            this.rad_exceptOutside = new System.Windows.Forms.RadioButton();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rad_allClear);
            this.groupBox1.Controls.Add(this.chk_clear);
            this.groupBox1.Controls.Add(this.lbl_style);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.spd_main);
            this.groupBox1.Controls.Add(this.rad_allCheck);
            this.groupBox1.Controls.Add(this.rad_allCheckByItem);
            this.groupBox1.Controls.Add(this.rad_allCheckByModel);
            this.groupBox1.Controls.Add(this.rad_exceptOutside);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 281);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Auto Check ";
            // 
            // rad_allClear
            // 
            this.rad_allClear.Location = new System.Drawing.Point(24, 24);
            this.rad_allClear.Name = "rad_allClear";
            this.rad_allClear.Size = new System.Drawing.Size(160, 24);
            this.rad_allClear.TabIndex = 58;
            this.rad_allClear.Text = "All Clear";
            this.rad_allClear.CheckedChanged += new System.EventHandler(this.rad_allClear_CheckedChanged);
            // 
            // chk_clear
            // 
            this.chk_clear.Location = new System.Drawing.Point(312, 24);
            this.chk_clear.Name = "chk_clear";
            this.chk_clear.Size = new System.Drawing.Size(56, 24);
            this.chk_clear.TabIndex = 57;
            this.chk_clear.Text = "Clear";
            // 
            // lbl_style
            // 
            this.lbl_style.Location = new System.Drawing.Point(192, 120);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(128, 24);
            this.lbl_style.TabIndex = 56;
            this.lbl_style.Text = "(309207-151)";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(337, 120);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(24, 21);
            this.btn_search.TabIndex = 55;
            this.btn_search.Tag = "HeadSearch";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Visible = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(24, 152);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(336, 120);
            this.spd_main.TabIndex = 1;
            this.spd_main.Visible = false;
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // rad_allCheck
            // 
            this.rad_allCheck.Location = new System.Drawing.Point(24, 48);
            this.rad_allCheck.Name = "rad_allCheck";
            this.rad_allCheck.Size = new System.Drawing.Size(160, 24);
            this.rad_allCheck.TabIndex = 0;
            this.rad_allCheck.Text = "All Row Material Check";
            this.rad_allCheck.CheckedChanged += new System.EventHandler(this.rad_allCheck_CheckedChanged);
            // 
            // rad_allCheckByItem
            // 
            this.rad_allCheckByItem.Location = new System.Drawing.Point(24, 72);
            this.rad_allCheckByItem.Name = "rad_allCheckByItem";
            this.rad_allCheckByItem.Size = new System.Drawing.Size(200, 24);
            this.rad_allCheckByItem.TabIndex = 0;
            this.rad_allCheckByItem.Text = "All Check By Item Master";
            this.rad_allCheckByItem.CheckedChanged += new System.EventHandler(this.rad_allCheckByItem_CheckedChanged);
            // 
            // rad_allCheckByModel
            // 
            this.rad_allCheckByModel.Location = new System.Drawing.Point(24, 120);
            this.rad_allCheckByModel.Name = "rad_allCheckByModel";
            this.rad_allCheckByModel.Size = new System.Drawing.Size(176, 24);
            this.rad_allCheckByModel.TabIndex = 0;
            this.rad_allCheckByModel.Text = "All Check By Other Model";
            this.rad_allCheckByModel.CheckedChanged += new System.EventHandler(this.rad_allCheckByModel_CheckedChanged);
            // 
            // rad_exceptOutside
            // 
            this.rad_exceptOutside.Location = new System.Drawing.Point(24, 96);
            this.rad_exceptOutside.Name = "rad_exceptOutside";
            this.rad_exceptOutside.Size = new System.Drawing.Size(200, 24);
            this.rad_exceptOutside.TabIndex = 0;
            this.rad_exceptOutside.Text = "Except Outside Process ";
            this.rad_exceptOutside.CheckedChanged += new System.EventHandler(this.rad_exceptOutside_CheckedChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(245, 321);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 356;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(316, 321);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel.TabIndex = 356;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // Pop_BS_Shipping_Material_AutoCheck
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 352);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Pop_BS_Shipping_Material_AutoCheck";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pop_BS_Shipping_Material_AutoCheck_Closed);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 버튼 이벤트 처리

		private void Pop_BS_Shipping_Material_AutoCheck_Closed(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Dispose();		
		}


		private void Btn_ApplyProcess_SSP(object sender, System.EventArgs e)
		{
			try
			{

			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_SSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.Btn_CancelProcess();
		}

		private void Btn_ApplyProcess_FSP(object sender, System.EventArgs e)
		{
			try
			{
				if (rad_allClear.Checked)
				{
					this.AllClear();
				}
				else if (rad_allCheck.Checked)
				{
					this.AllCheck();
				}
				else if (rad_allCheckByItem.Checked)
				{
					this.AllCheckByItem();
				}
				else if (rad_exceptOutside.Checked)
				{
					this.ExceptOutsideProcess();
				}
				else if (rad_allCheckByModel.Checked)
				{
					this.AllCheckByModel();
				}

				cancelProcess();
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_FSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Btn_CancelProcess();
		}

		private void rad_allClear_CheckedChanged(object sender, System.EventArgs e)
		{
			ControlVisible(false);
		}


		private void rad_allCheck_CheckedChanged(object sender, System.EventArgs e)
		{
			ControlVisible(false);
		}

		private void rad_allCheckByItem_CheckedChanged(object sender, System.EventArgs e)
		{
			ControlVisible(false);		
		}

		private void rad_exceptOutside_CheckedChanged(object sender, System.EventArgs e)
		{
			ControlVisible(false);		
		}

		private void rad_allCheckByModel_CheckedChanged(object sender, System.EventArgs e)
		{
			if (_styleCd.Length == 9)
				ControlVisible(true);
			else
				rad_allCheck.Checked = true;
		}

		private void ControlVisible(bool arg_visible)
		{
			spd_main.Visible = arg_visible;
			btn_search.Visible = arg_visible;
			if (arg_visible)
				this.Size = new Size(this.Width, _orignalHeight);
			else
				this.Size = new Size(this.Width, _newHeight);
				
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

		#region 이벤트 처리 메서드

		private void Init_Form(Control arg_grid)
		{
			rad_allCheckByItem.Checked = true;

			this.Text = "Auto Check Process";
            lbl_MainTitle.Text = "Auto Check Process";
            ClassLib.ComFunction.SetLangDic(this);

			spd_main.Set_Spread_Comm("SBS_SHIP_AUTOCHECK", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

			EventHandler vHandler;

			if (arg_grid is COM.SSP)
			{
				vHandler = new EventHandler(this.Btn_ApplyProcess_SSP);
				_ssp = (COM.SSP)arg_grid;
			}
			else
			{
				vHandler = new EventHandler(this.Btn_ApplyProcess_FSP);
				_fsp = (COM.FSP)arg_grid;
			}

			btn_apply.Click += vHandler;
		}

		private void Btn_CancelProcess()
		{
			this.Dispose(true);
		}

		private void cancelProcess()
		{
			this.DialogResult = DialogResult.OK;
			this.Close();
			this.Dispose(true);
		}

		private void AllClear()
		{
			for (int vRow = _fsp.Rows.Fixed ; vRow < _fsp.Rows.Count ; vRow++)
			{
				_fsp[vRow, _shipYnCol] = false;
				_fsp.Select(vRow, _shipYnCol);
				ShippingCheckBoxControl();
				this.Text = vRow + " / " + _fsp.Rows.Count + 1;
			}
		}

		private void AllCheck()
		{
			for (int vRow = _fsp.Rows.Fixed ; vRow < _fsp.Rows.Count ; vRow++)
			{
				string vType = ClassLib.ComFunction.NullToBlank(_fsp[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION]);

				if (vType.Equals(_TypeMat))
				{
					_fsp[vRow, _shipYnCol] = true;
					_fsp.Select(vRow, _shipYnCol);
					ShippingCheckBoxControl();
				}

				this.Text = vRow + " / " + _fsp.Rows.Count + 1;
			}
		}

		private void AllCheckByItem()
		{
			int[] vSel = _fsp.Selections;

			if (vSel.Length <= 1)
				_fsp.SelectAll();

			vSel = _fsp.Selections;

			//for (int vRow = _fsp.Rows.Fixed ; vRow < _fsp.Rows.Count ; vRow++)
			foreach (int vRow in vSel)
			{
				this._fsp.Select(vRow, _shipYnCol);
				string vType = ClassLib.ComFunction.NullToBlank(_fsp[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION]);

				if (vType.Equals(_TypeMat))
				{
					DataTable vDt = SHIPPING_MATERIAL_AUTO_CHECK("S", ClassLib.ComFunction.NullToBlank(_fsp[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM_CD]));

					if (vDt.Rows.Count > 0)
					{						 
						if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(vDt.Rows[0][0], "FALSE")))
						{
							_fsp[vRow, _shipYnCol] = true;
							ShippingCheckBoxControl();
						}
						else
						{
							if (chk_clear.Checked)
							{
								_fsp[vRow, _shipYnCol] = false;
								ShippingCheckBoxControl();
							}
						}
					}

					vDt.Dispose();
				}

				this.Text = vRow + " / " + _fsp.Rows.Count;
			}
		}

		private void ExceptOutsideProcess()
		{
			bool vJoint = false;
			int[] vSel = _fsp.Selections;

			if (vSel.Length <= 1)
				_fsp.SelectAll();

			vSel = _fsp.Selections;

			//for (int vRow = _fsp.Rows.Fixed ; vRow < _fsp.Rows.Count ; vRow++)
			foreach (int vRow in vSel)
			{
				_fsp.Select(vRow, _shipYnCol);
				string vType = ClassLib.ComFunction.NullToBlank(_fsp[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxTYPE_DIVISION]);

				if (vType.Equals(_TypeCmp))
					vJoint = true;

				if (vType.Equals(_TypeJoint))
					vJoint = false;

				if (vType.Equals(_TypeMat) && vJoint)
				{
					DataTable vDt = SHIPPING_MATERIAL_AUTO_CHECK("S", ClassLib.ComFunction.NullToBlank(_fsp[vRow, (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxITEM_CD]));

					if (vDt.Rows.Count > 0)
					{
						if (Convert.ToBoolean(ClassLib.ComFunction.NullCheck(vDt.Rows[0][0], "FALSE")))
						{
							_fsp[vRow, _shipYnCol] = true;
							ShippingCheckBoxControl();
						}
						else
						{
							if (chk_clear.Checked)
							{
								_fsp[vRow, _shipYnCol] = false;
								ShippingCheckBoxControl();
							}
						}
					}

					vDt.Dispose();
				}

				this.Text = vRow + " / " + _fsp.Rows.Count;
			}
		}
		
		private void AllCheckByModel()
		{

		}


		// 지정된 레벨까지 이동
		private int GridGetFirstParentIndex(int arg_row, int arg_level, bool arg_clear, int arg_clearRow1, int arg_clearRow2)
		{
			int vStartRow = arg_row;

			Node vStartNode = _fsp.Rows[arg_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);

			if (vStartNode != null)
				while (true)
				{
					vStartNode = _fsp.Rows[vStartRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.Parent);
					if (vStartNode == null || _fsp.Rows[vStartRow].Node.Level <= arg_level)
						break;					
						
					vStartRow = vStartNode.Row.Index;
					_fsp[vStartNode.Row.Index, arg_clearRow1]	= !arg_clear;
					_fsp[vStartNode.Row.Index, arg_clearRow2] = !arg_clear;
					_fsp.Update_Row(vStartRow);
				}

			return vStartRow;
		}

		// 최하위 레벨 이동
		private int GridGetLastChildIndex(int arg_row)
		{
			int vEndRow = arg_row;

			Node vEndNode = _fsp.Rows[arg_row].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.FirstChild);

			if (vEndNode != null)
				while (true)
				{
					vEndNode = _fsp.Rows[vEndRow].Node.GetNode(C1.Win.C1FlexGrid.NodeTypeEnum.LastChild);
					if (vEndNode == null)
						break;

					vEndRow = vEndNode.Row.Index;
				}

			return vEndRow;
		}

		// 체크박스 컨트롤 - shipping
		private void ShippingCheckBoxControl()
		{
			int vRow = _fsp.Selection.r1;
			int vCol = _fsp.Selection.c1;
			int vSCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxSHIP_YN;
			int vPCol = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPUR_SHIP_YN;
			int vOCol	  = (int)ClassLib.TBSBC_YIELD_INFO_SHIPPING.IxPROD_YN;
			int vStartRow = GridGetFirstParentIndex(vRow, 3, true, vSCol, vPCol);

			Node vNode = _fsp.Rows[vRow].Node.GetNode(NodeTypeEnum.FirstChild);
			if (vNode != null)
			{
				int vEndRow = GridGetLastChildIndex(vRow);

				_fsp[vRow, vPCol] = _fsp[vRow, vSCol];
				_fsp[vRow, vOCol] = _fsp[vRow, vSCol];
				_fsp[vRow, 0]	 = ClassLib.ComVar.Update;
				for (int i = vRow + 1 ; i <= vEndRow ; i++)
				{
					_fsp[i, vSCol] = false;
					_fsp[i, vPCol] = _fsp[vRow, vPCol];
					_fsp[i, vOCol] = false;
					_fsp[i, 0]	 = ClassLib.ComVar.Update;
				}
			}
			else
			{
				//_fsp[vRow, vPCol] = _fsp[vRow, vSCol];
				//_fsp[vRow, vOCol] = _fsp[vRow, vSCol];

				//int vEnd = GridGetLastChildIndex(vStartRow);
				int vEnd = vRow;

				if (vRow != vStartRow)
				{
					Node vEndNode = _fsp.Rows[vStartRow].Node.GetNode(NodeTypeEnum.LastChild);
					vEnd = ( vEndNode == null) ? _fsp.Rows.Count - 1 : GridGetLastChildIndex(vStartRow);
				}

				for (int i = vStartRow ; i <= vEnd ; i++)
				{
					_fsp[i, vPCol] = _fsp[i, vSCol];
					_fsp[i, vOCol] = _fsp[i, vSCol];
					_fsp[i, 0] = ClassLib.ComVar.Update;
				}
			}
		}

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBS_SHIPPING_MATERIAL : AUTO CHECK
		/// </summary>
		public DataTable SHIPPING_MATERIAL_AUTO_CHECK(string arg_division, string arg_item_cd)
		{

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_MATERIAL.SHIPPING_MATERIAL_AUTO_CHECK";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[2] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = _factory;
			MyOraDB.Parameter_Values[1] = arg_division;
			MyOraDB.Parameter_Values[2] = arg_item_cd;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			DataSet vds_ret = MyOraDB.Exe_Select_Procedure();

			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion






	}
}

