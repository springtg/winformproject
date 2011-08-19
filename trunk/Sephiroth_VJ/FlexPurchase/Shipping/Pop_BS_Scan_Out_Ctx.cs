using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Scan_Out_Ctx : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label lbl_outType;
		private System.Windows.Forms.DateTimePicker dpick_scanYmd;
		private System.Windows.Forms.Label lbl_scanYmd;
		private C1.Win.C1List.C1Combo cmb_outType;
		private System.Windows.Forms.TextBox txt_info;
		private System.Windows.Forms.Label lbl_info;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;

		private string _container;

		#region 생성자 / 소멸자

		public Pop_BS_Scan_Out_Ctx()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Scan_Out_Ctx));
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
            this.txt_info = new System.Windows.Forms.TextBox();
            this.dpick_scanYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_outType = new C1.Win.C1List.C1Combo();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_scanYmd = new System.Windows.Forms.Label();
            this.lbl_outType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outType)).BeginInit();
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
            this.btn_apply.Location = new System.Drawing.Point(206, 132);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 4;
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
            this.btn_cancel.Location = new System.Drawing.Point(277, 132);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // txt_info
            // 
            this.txt_info.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_info.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_info.Location = new System.Drawing.Point(109, 60);
            this.txt_info.MaxLength = 10;
            this.txt_info.Name = "txt_info";
            this.txt_info.ReadOnly = true;
            this.txt_info.Size = new System.Drawing.Size(220, 21);
            this.txt_info.TabIndex = 248;
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
            // 
            // cmb_outType
            // 
            this.cmb_outType.AddItemCols = 0;
            this.cmb_outType.AddItemSeparator = ';';
            this.cmb_outType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outType.Caption = "";
            this.cmb_outType.CaptionHeight = 17;
            this.cmb_outType.CaptionStyle = style1;
            this.cmb_outType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outType.ColumnCaptionHeight = 18;
            this.cmb_outType.ColumnFooterHeight = 18;
            this.cmb_outType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outType.ContentHeight = 16;
            this.cmb_outType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outType.EditorHeight = 16;
            this.cmb_outType.EvenRowStyle = style2;
            this.cmb_outType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outType.FooterStyle = style3;
            this.cmb_outType.GapHeight = 2;
            this.cmb_outType.HeadingStyle = style4;
            this.cmb_outType.HighLightRowStyle = style5;
            this.cmb_outType.ItemHeight = 15;
            this.cmb_outType.Location = new System.Drawing.Point(109, 38);
            this.cmb_outType.MatchEntryTimeout = ((long)(2000));
            this.cmb_outType.MaxDropDownItems = ((short)(5));
            this.cmb_outType.MaxLength = 32767;
            this.cmb_outType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outType.Name = "cmb_outType";
            this.cmb_outType.OddRowStyle = style6;
            this.cmb_outType.PartialRightColumn = false;
            this.cmb_outType.PropBag = resources.GetString("cmb_outType.PropBag");
            this.cmb_outType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outType.SelectedStyle = style7;
            this.cmb_outType.Size = new System.Drawing.Size(220, 20);
            this.cmb_outType.Style = style8;
            this.cmb_outType.TabIndex = 2;
            this.cmb_outType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            // 
            // lbl_info
            // 
            this.lbl_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_info.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.ImageIndex = 0;
            this.lbl_info.ImageList = this.img_Label;
            this.lbl_info.Location = new System.Drawing.Point(8, 60);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(100, 21);
            this.lbl_info.TabIndex = 202;
            this.lbl_info.Text = "Container#";
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lbl_outType
            // 
            this.lbl_outType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outType.ImageIndex = 0;
            this.lbl_outType.ImageList = this.img_Label;
            this.lbl_outType.Location = new System.Drawing.Point(8, 38);
            this.lbl_outType.Name = "lbl_outType";
            this.lbl_outType.Size = new System.Drawing.Size(100, 21);
            this.lbl_outType.TabIndex = 202;
            this.lbl_outType.Text = "Out Type";
            this.lbl_outType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_info);
            this.groupBox1.Controls.Add(this.dpick_scanYmd);
            this.groupBox1.Controls.Add(this.cmb_outType);
            this.groupBox1.Controls.Add(this.lbl_info);
            this.groupBox1.Controls.Add(this.lbl_scanYmd);
            this.groupBox1.Controls.Add(this.lbl_outType);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 92);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BS_Scan_Out_Ctx
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 165);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.btn_cancel);
            this.Name = "Pop_BS_Scan_Out_Ctx";
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outType)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelClickProcess();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
        {
			this.Text			= "Outgoing Scan";
            lbl_MainTitle.Text = "Outgoing Scan";
            ClassLib.ComFunction.SetLangDic(this);

			DataTable vDt = null;

			// ship type
			vDt = COM.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxOutgoingType);
			COM.ComCtl.Set_ComboList(vDt, cmb_outType, 1, 2, false);
			vDt.Dispose();

			dpick_scanYmd.Value = ClassLib.ComFunction.StringToDateTime(ClassLib.ComVar.Parameter_PopUp_Object[1].ToString());
			cmb_outType.SelectedValue = ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[5]);
			_container = ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[3]);

			if (Convert.ToInt32(ClassLib.ComVar.Parameter_PopUp_Object[5]) <= 20)
			{
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(6);
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(5);
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(4);
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(3);
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(2);
				txt_info.Text = _container;
			}
			else
			{
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(1);
				((DataTable)cmb_outType.DataSource).Rows.RemoveAt(0);
				lbl_info.Text		= "Weight";
				txt_info.ReadOnly	= false;
				txt_info.BackColor  = Color.White;
				txt_info.TextAlign  = HorizontalAlignment.Right;
				txt_info.Text		= ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[7]);
				txt_info.MaxLength	= 9;
			}
		}

		private void Btn_ApplyClickProcess()
		{
			COM.ComVar.Parameter_PopUp = new string[4];
			COM.ComVar.Parameter_PopUp[0] = dpick_scanYmd.Text.Replace("-", "");
			COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_outType, "");

			if (_container.Length > 11)
			{
				_container = _container.Remove(0, 6);
			}

			COM.ComVar.Parameter_PopUp[2] = _container;
			COM.ComVar.Parameter_PopUp[3] = COM.ComFunction.Empty_TextBox(txt_info, "");

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_CancelClickProcess()
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
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

