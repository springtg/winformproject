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
	public class Pop_BS_Scan_Changer : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label lbl_container;
		private C1.Win.C1List.C1Combo cmb_container;
		private System.Windows.Forms.DateTimePicker dpick_scanYmd;
		private System.Windows.Forms.Label lbl_scanYmd;
		private System.Windows.Forms.Label btn_changeScanYmd;
		private System.Windows.Forms.Label btn_changeContainer;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;

		#region 사용자 정의 변수

		C1FlexGrid fgrid_bar = null;
		ArrayList _selectionRows = null;
		private int _checkCol	  = (int)ClassLib.TBSBS_BAR_1.IxCHK;
		private int _scanYmdCol	  = (int)ClassLib.TBSBS_BAR_1.IxSCAN_YMD;
		private int _containerCol = (int)ClassLib.TBSBS_BAR_1.IxCONTAINER;
		private System.Windows.Forms.GroupBox groupBox1;
		private int _stateCol	  = (int)ClassLib.TBSBS_BAR_1.IxIN_STATE;

		#endregion

		#region 생성자 / 소멸자

		public Pop_BS_Scan_Changer()
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Scan_Changer));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.btn_changeScanYmd = new System.Windows.Forms.Label();
            this.btn_changeContainer = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.dpick_scanYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_container = new C1.Win.C1List.C1Combo();
            this.lbl_container = new System.Windows.Forms.Label();
            this.lbl_scanYmd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).BeginInit();
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
            // btn_changeScanYmd
            // 
            this.btn_changeScanYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_changeScanYmd.ImageIndex = 0;
            this.btn_changeScanYmd.ImageList = this.img_Button;
            this.btn_changeScanYmd.Location = new System.Drawing.Point(64, 112);
            this.btn_changeScanYmd.Name = "btn_changeScanYmd";
            this.btn_changeScanYmd.Size = new System.Drawing.Size(70, 23);
            this.btn_changeScanYmd.TabIndex = 3;
            this.btn_changeScanYmd.Text = "Scan Date";
            this.btn_changeScanYmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_changeScanYmd.Click += new System.EventHandler(this.btn_changeScanDate_Click);
            this.btn_changeScanYmd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_changeScanYmd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_changeContainer
            // 
            this.btn_changeContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_changeContainer.ImageIndex = 0;
            this.btn_changeContainer.ImageList = this.img_Button;
            this.btn_changeContainer.Location = new System.Drawing.Point(135, 112);
            this.btn_changeContainer.Name = "btn_changeContainer";
            this.btn_changeContainer.Size = new System.Drawing.Size(70, 23);
            this.btn_changeContainer.TabIndex = 4;
            this.btn_changeContainer.Text = "Container";
            this.btn_changeContainer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_changeContainer.Click += new System.EventHandler(this.btn_changeContainer_Click);
            this.btn_changeContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_changeContainer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(206, 112);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(277, 112);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // dpick_scanYmd
            // 
            this.dpick_scanYmd.Checked = false;
            this.dpick_scanYmd.CustomFormat = "";
            this.dpick_scanYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_scanYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_scanYmd.Location = new System.Drawing.Point(109, 16);
            this.dpick_scanYmd.Name = "dpick_scanYmd";
            this.dpick_scanYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_scanYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_scanYmd.TabIndex = 1;
            this.dpick_scanYmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.dpick_scanYmd.CloseUp += new System.EventHandler(this.dpick_scanYmd_CloseUp);
            // 
            // cmb_container
            // 
            this.cmb_container.AddItemCols = 0;
            this.cmb_container.AddItemSeparator = ';';
            this.cmb_container.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_container.Caption = "";
            this.cmb_container.CaptionHeight = 17;
            this.cmb_container.CaptionStyle = style1;
            this.cmb_container.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_container.ColumnCaptionHeight = 18;
            this.cmb_container.ColumnFooterHeight = 18;
            this.cmb_container.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_container.ContentHeight = 16;
            this.cmb_container.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_container.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_container.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_container.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_container.EditorHeight = 16;
            this.cmb_container.EvenRowStyle = style2;
            this.cmb_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_container.FooterStyle = style3;
            this.cmb_container.GapHeight = 2;
            this.cmb_container.HeadingStyle = style4;
            this.cmb_container.HighLightRowStyle = style5;
            this.cmb_container.ItemHeight = 15;
            this.cmb_container.Location = new System.Drawing.Point(109, 38);
            this.cmb_container.MatchEntryTimeout = ((long)(2000));
            this.cmb_container.MaxDropDownItems = ((short)(5));
            this.cmb_container.MaxLength = 32767;
            this.cmb_container.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_container.Name = "cmb_container";
            this.cmb_container.OddRowStyle = style6;
            this.cmb_container.PartialRightColumn = false;
            this.cmb_container.PropBag = resources.GetString("cmb_container.PropBag");
            this.cmb_container.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_container.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_container.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_container.SelectedStyle = style7;
            this.cmb_container.Size = new System.Drawing.Size(220, 20);
            this.cmb_container.Style = style8;
            this.cmb_container.TabIndex = 2;
            this.cmb_container.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // lbl_container
            // 
            this.lbl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_container.ImageIndex = 0;
            this.lbl_container.ImageList = this.img_Label;
            this.lbl_container.Location = new System.Drawing.Point(8, 38);
            this.lbl_container.Name = "lbl_container";
            this.lbl_container.Size = new System.Drawing.Size(100, 21);
            this.lbl_container.TabIndex = 202;
            this.lbl_container.Text = "Container#";
            this.lbl_container.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_scanYmd
            // 
            this.lbl_scanYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_scanYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scanYmd.ImageIndex = 0;
            this.lbl_scanYmd.ImageList = this.img_Label;
            this.lbl_scanYmd.Location = new System.Drawing.Point(8, 16);
            this.lbl_scanYmd.Name = "lbl_scanYmd";
            this.lbl_scanYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_scanYmd.TabIndex = 202;
            this.lbl_scanYmd.Text = "Scan Date";
            this.lbl_scanYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dpick_scanYmd);
            this.groupBox1.Controls.Add(this.lbl_scanYmd);
            this.groupBox1.Controls.Add(this.cmb_container);
            this.groupBox1.Controls.Add(this.lbl_container);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 72);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BS_Scan_Changer
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 143);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_changeContainer);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_changeScanYmd);
            this.Name = "Pop_BS_Scan_Changer";
            this.TopMost = true;
            this.Controls.SetChildIndex(this.btn_changeScanYmd, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_changeContainer, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트

		private void btn_changeScanDate_Click(object sender, System.EventArgs e)
		{
			Btn_ScanDateChangeProcess();
		}

		private void btn_changeContainer_Click(object sender, System.EventArgs e)
		{
			this.Btn_ContainerChangeProcess();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_exit_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Dispose();
		}

		private void dpick_scanYmd_CloseUp(object sender, System.EventArgs e)
		{
			this.Dpick_ScanYmdCloseUpProcess();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
        {
			this.Text			= "Scan Info Change";
            lbl_MainTitle.Text = "Scan Info Change";
            ClassLib.ComFunction.SetLangDic(this);

			this.fgrid_bar = (C1FlexGrid)ClassLib.ComVar.Parameter_PopUp_Object[0];
			this._selectionRows = (ArrayList)ClassLib.ComVar.Parameter_PopUp_Object[1];
		}

		private void Btn_ScanDateChangeProcess()
		{
			DateTime vDate  = dpick_scanYmd.Value;

			IEnumerator vEnum = _selectionRows.GetEnumerator();
			while (vEnum.MoveNext())
			{
				if (!fgrid_bar[(int)vEnum.Current, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				{
					fgrid_bar.Select((int)vEnum.Current, _stateCol);
					ClassLib.ComFunction.User_Message("Included not pre scan", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			vEnum = _selectionRows.GetEnumerator();
			while (vEnum.MoveNext())
			{
				if (fgrid_bar[(int)vEnum.Current, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				{
					fgrid_bar[(int)vEnum.Current, _scanYmdCol] = vDate;
					fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Update;
				}
			}
		}

		private void Btn_ContainerChangeProcess()
		{
			if (cmb_container.SelectedIndex == -1)
				return;

			IEnumerator vEnum = _selectionRows.GetEnumerator();
			while (vEnum.MoveNext())
			{
				if (!fgrid_bar[(int)vEnum.Current, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				{
					fgrid_bar.Select((int)vEnum.Current, _stateCol);
					ClassLib.ComFunction.User_Message("Included not pre scan", "Invalidate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
			}

			string vContainer  = cmb_container.GetItemText(cmb_container.SelectedIndex, 2);

			vEnum = _selectionRows.GetEnumerator();
			while (vEnum.MoveNext())
			{
				if (fgrid_bar[(int)vEnum.Current, _stateCol].ToString().Equals(ClassLib.ComVar.PreScan))
				{
					fgrid_bar[(int)vEnum.Current, _containerCol] = vContainer;
					fgrid_bar[(int)vEnum.Current, 0] = ClassLib.ComVar.Update;
				}
			}
		}
		
		private void Btn_ApplyClickProcess()
		{
			Btn_ScanDateChangeProcess();
			Btn_ContainerChangeProcess();
			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		private void Dpick_ScanYmdCloseUpProcess()
		{
			try
			{
				string vShipFactory = ClassLib.ComVar.Parameter_PopUp_Object[2].ToString();
				DataTable vDt = ClassLib.ComFunction.SELECT_SBS_SHIP_CONT_NO_LIST(vShipFactory, dpick_scanYmd.Text.Replace("-", ""));
				COM.ComCtl.Set_ComboList_3(vDt, cmb_container, 0, 1, 2);
				ClassLib.ComFunction.SetComboStyle(cmb_container, new string[]{"Date", "Container", ""}, new int[]{80, 120, 0}, new bool[]{true, true, false});
			}
			catch
			{
			}
		}

		#region 입력이동

		private void Control_MoveNextByFocus(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.Control_MoveNextByFocus(sender, e.KeyChar);
		}

		#endregion

		#region 버튼효과

		private void btn_click_Effect_Plus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		private void btn_click_Effect_Minus(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;		
		}

		#endregion

		#endregion

	}
}

