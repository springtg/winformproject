using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BC_CBD_Information : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.CheckBox chk_1;
		private System.Windows.Forms.CheckBox chk_2;
		private System.Windows.Forms.CheckBox chk_3;
		private System.Windows.Forms.CheckBox chk_4;
		private System.Windows.Forms.CheckBox chk_5;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.SSP _ssp;
		private COM.FSP _fsp;
		public string _job = "";
		private int _factoryCol, _styleCol, _itemCol, _specCol, _colorCol;
		public int _level;
		public string _factory, _style, _item, _spec, _color;
		private int[] _values;
		private Control _grid;
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion

		#region 생성자 / 소멸자

		public Pop_BC_CBD_Information(Control arg_grid, int[] arg_keys, int[] arg_values)
		{
			InitializeComponent();
			_grid = arg_grid;
			_factoryCol	= arg_keys[0];
			_styleCol	= arg_keys[1];
			_itemCol	= arg_keys[2];
			_specCol	= arg_keys[3];
			_colorCol	= arg_keys[4];
			_values		= arg_values;

			//Init_Form(arg_grid);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BC_CBD_Information));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_1 = new System.Windows.Forms.CheckBox();
            this.chk_2 = new System.Windows.Forms.CheckBox();
            this.chk_3 = new System.Windows.Forms.CheckBox();
            this.chk_4 = new System.Windows.Forms.CheckBox();
            this.chk_5 = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk_1);
            this.groupBox1.Controls.Add(this.chk_2);
            this.groupBox1.Controls.Add(this.chk_3);
            this.groupBox1.Controls.Add(this.chk_4);
            this.groupBox1.Controls.Add(this.chk_5);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 160);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Select Proviso ";
            // 
            // chk_1
            // 
            this.chk_1.Checked = true;
            this.chk_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_1.Location = new System.Drawing.Point(24, 24);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(304, 24);
            this.chk_1.TabIndex = 0;
            this.chk_1.Tag = "";
            this.chk_1.Text = "1. Factory, Style, Item, Spec, Color";
            // 
            // chk_2
            // 
            this.chk_2.Checked = true;
            this.chk_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_2.Location = new System.Drawing.Point(24, 48);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(304, 24);
            this.chk_2.TabIndex = 0;
            this.chk_2.Tag = "";
            this.chk_2.Text = "2. Style, Item, Spec, Color";
            // 
            // chk_3
            // 
            this.chk_3.Checked = true;
            this.chk_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_3.Location = new System.Drawing.Point(24, 72);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(304, 24);
            this.chk_3.TabIndex = 0;
            this.chk_3.Tag = "";
            this.chk_3.Text = "3. Item, Spec, Color";
            // 
            // chk_4
            // 
            this.chk_4.Checked = true;
            this.chk_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_4.Location = new System.Drawing.Point(24, 96);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(304, 24);
            this.chk_4.TabIndex = 0;
            this.chk_4.Tag = "";
            this.chk_4.Text = "4. Item ( From Item Master )";
            // 
            // chk_5
            // 
            this.chk_5.Location = new System.Drawing.Point(24, 120);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(304, 24);
            this.chk_5.TabIndex = 0;
            this.chk_5.Tag = "";
            this.chk_5.Text = "5. Item ( From Item Group Master )";
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(245, 201);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 356;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(316, 201);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel.TabIndex = 356;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // Pop_BC_CBD_Information
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 231);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Pop_BC_CBD_Information";
            this.Load += new System.EventHandler(this.Pop_BC_CBD_Information_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pop_BC_CBD_Information_KeyUp);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 버튼 이벤트 처리

		private void Pop_BC_CBD_Information_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
				this.Dispose();		
		}

		/*****************************************
		0 : FACTORY,	  		1 : PUR_USER,
		2 : CUST_CD,			3 : CUST_NAME,
		4 :	PK_UNIT_QTY,		5 : PUR_PRICE,
		6 :	PUR_CURRENCY, 		7 : OUTSIDE_PRICE,
		8 :	OUTSIDE_CURRENCY, 	9 : CBD_PRICE,
		10 : CBD_CURRENCY,		11 : SHIP_PRICE,
		12 : SHIP_CURRENCY, 	13 : CBM,
		14 : WEIGHT
		*****************************************/
		private void Btn_ApplyProcess_SSP(object sender, System.EventArgs e)
		{
			try
			{
				string vDivision = Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("00000"))	return;
			
				FarPoint.Win.Spread.Model.CellRange[] vRanges = _ssp.ActiveSheet.GetSelections();

				for (int vIdx1 = 0 ; vIdx1 < vRanges.Length ; vIdx1++)
				{
					for (int vIdx2 = vRanges[vIdx1].Row ; vIdx2 < vRanges[vIdx1].Row + vRanges[vIdx1].RowCount ; vIdx2++)
					{
						this.Text = "Processing... " + (vIdx2 + 1) + " Row";

						string vFactory = COM.ComVar.This_Factory;
						string vStyle	= (_styleCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _styleCol].Text : _style;
						vStyle = vStyle.Replace("-", "");
						string vItem	= (_itemCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _itemCol].Text : _item;
						string vSpec	= (_specCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _specCol].Text : _spec;
						string vColor	= (_colorCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _colorCol].Text : _color;

						DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vStyle, vItem, vSpec, vColor);
						if (vDt.Rows.Count > 0)
						{
							for (int i = 0 ; i < _values.Length ; i++)
							{
								if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals(""))
									_ssp.ActiveSheet.Cells[vIdx2, _values[i]].Text = vDt.Rows[0].ItemArray[i].ToString();
							}
                            
							_ssp.Update_Row(vIdx2, img_Action);
						}
					}
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_SSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		private void Btn_ApplyProcess_FSP(object sender, System.EventArgs e)
		{
			try
			{
				string vDivision = Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("00000"))	return;

				foreach (int vRow in _fsp.Selections)
				{
					if (_level != 0)
						if (_fsp.Rows[vRow].Node.Level != _level)
							continue;

					this.Text = "Processing... " + vRow + " Row";

					string vFactory = COM.ComVar.This_Factory;
					string vStyle	= (_styleCol != -1) ? _fsp[vRow, _styleCol].ToString() : _style;
					vStyle = vStyle.Replace("-", "");
					string vItem	= (_itemCol != -1) ? _fsp[vRow, _itemCol].ToString() : _item;
					string vSpec	= (_specCol != -1) ? _fsp[vRow, _specCol].ToString() : _spec;
					string vColor	= (_colorCol != -1) ? _fsp[vRow, _colorCol].ToString() : _color;

					DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vStyle, vItem, vSpec, vColor);
					if (vDt.Rows.Count > 0)
					{
						for (int i = 0 ; i < _values.Length ; i++)
						{
							if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals(""))
								_fsp[vRow, _values[i]] = vDt.Rows[0].ItemArray[i];
						}
					}

					_fsp.Update_Row(vRow);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_FSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			Btn_CancelProcess();
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

		#region 개별 추가 함수들

		private void Btn_ApplyProcess_PurchaseOrder(object sender, System.EventArgs e)
		{
			try
			{
				string vDivision = Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("00000"))	return;

				foreach (int vRow in _fsp.Selections)
				{
					if (_level != 0)
						if (_fsp.Rows[vRow].Node.Level != _level)
							continue;

					this.Text = "Processing... " + vRow + " Row";

					string vFactory = COM.ComVar.This_Factory;
					string vStyle	= _fsp[vRow + 1, _styleCol].ToString();
					vStyle = vStyle.Replace("-", "");
					string vItem	= (_itemCol != -1) ? _fsp[vRow, _itemCol].ToString() : _item;
					string vSpec	= (_specCol != -1) ? _fsp[vRow, _specCol].ToString() : _spec;
					string vColor	= (_colorCol != -1) ? _fsp[vRow, _colorCol].ToString() : _color;

					DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vStyle, vItem, vSpec, vColor);
					if (vDt.Rows.Count > 0)
					{
						for (int i = 0 ; i < _values.Length ; i++)
						{
							if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals(""))
								_fsp[vRow, _values[i]] = vDt.Rows[0].ItemArray[i];
						}
					}

					_fsp.Update_Row(vRow);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_FSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form(Control arg_grid)
        {
			this.Text = "CBD Information";
            lbl_MainTitle.Text = "CBD Information";
            ClassLib.ComFunction.SetLangDic(this);

			EventHandler vHandler;

			switch (_job)
			{
				case "Purchase":
					vHandler = new EventHandler(this.Btn_ApplyProcess_PurchaseOrder);
					_fsp = (COM.FSP)arg_grid;
					break;
				default :
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
					break;
			}

			btn_apply.Click += vHandler;
		}

		private void Btn_CancelProcess()
		{
			this.DialogResult = DialogResult.Abort;
			this.Dispose(true);
		}

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_CBD_INFORMATION(string arg_division, string arg_factory, string arg_style_cd, string arg_item_cd, string arg_spec_cd, string arg_color_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFORMATION";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[4] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[5] = "ARG_COLOR_CD";
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
			MyOraDB.Parameter_Values[0] = arg_division;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_style_cd;
			MyOraDB.Parameter_Values[3] = arg_item_cd;
			MyOraDB.Parameter_Values[4] = arg_spec_cd;
			MyOraDB.Parameter_Values[5] = arg_color_cd;
			MyOraDB.Parameter_Values[6] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		#endregion

		private void Pop_BC_CBD_Information_Load(object sender, System.EventArgs e)
		{
			this.Init_Form(_grid);
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}

