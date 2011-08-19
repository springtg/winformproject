using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BP_Purchase_Order_SearchType : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components = null;

		private COM.FSP arg_fgrid;
		private int _startcol, _endcol;
		private System.Windows.Forms.Label lbl_searchType;
		private System.Windows.Forms.Label btn_cancel;
		private C1.Win.C1List.C1Combo cmb_searchType;
		private System.Windows.Forms.Label btn_apply;

		public Pop_BP_Purchase_Order_SearchType()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Purchase_Order_SearchType));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_searchType = new C1.Win.C1List.C1Combo();
            this.lbl_searchType = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).BeginInit();
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
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_searchType);
            this.groupBox1.Controls.Add(this.lbl_searchType);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 56);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select search type";
            // 
            // cmb_searchType
            // 
            this.cmb_searchType.AddItemCols = 0;
            this.cmb_searchType.AddItemSeparator = ';';
            this.cmb_searchType.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_searchType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_searchType.Caption = "";
            this.cmb_searchType.CaptionHeight = 17;
            this.cmb_searchType.CaptionStyle = style1;
            this.cmb_searchType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_searchType.ColumnCaptionHeight = 18;
            this.cmb_searchType.ColumnFooterHeight = 18;
            this.cmb_searchType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_searchType.ContentHeight = 16;
            this.cmb_searchType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_searchType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_searchType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_searchType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_searchType.EditorHeight = 16;
            this.cmb_searchType.EvenRowStyle = style2;
            this.cmb_searchType.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_searchType.FooterStyle = style3;
            this.cmb_searchType.GapHeight = 2;
            this.cmb_searchType.HeadingStyle = style4;
            this.cmb_searchType.HighLightRowStyle = style5;
            this.cmb_searchType.ItemHeight = 15;
            this.cmb_searchType.Location = new System.Drawing.Point(117, 23);
            this.cmb_searchType.MatchEntryTimeout = ((long)(2000));
            this.cmb_searchType.MaxDropDownItems = ((short)(5));
            this.cmb_searchType.MaxLength = 32767;
            this.cmb_searchType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_searchType.Name = "cmb_searchType";
            this.cmb_searchType.OddRowStyle = style6;
            this.cmb_searchType.PartialRightColumn = false;
            this.cmb_searchType.PropBag = resources.GetString("cmb_searchType.PropBag");
            this.cmb_searchType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_searchType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_searchType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_searchType.SelectedStyle = style7;
            this.cmb_searchType.Size = new System.Drawing.Size(200, 20);
            this.cmb_searchType.Style = style8;
            this.cmb_searchType.TabIndex = 194;
            // 
            // lbl_searchType
            // 
            this.lbl_searchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_searchType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_searchType.ImageIndex = 1;
            this.lbl_searchType.ImageList = this.img_Label;
            this.lbl_searchType.Location = new System.Drawing.Point(16, 23);
            this.lbl_searchType.Name = "lbl_searchType";
            this.lbl_searchType.Size = new System.Drawing.Size(100, 21);
            this.lbl_searchType.TabIndex = 193;
            this.lbl_searchType.Text = "Search Type";
            this.lbl_searchType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(264, 96);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(71, 24);
            this.btn_cancel.TabIndex = 356;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(193, 96);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(71, 24);
            this.btn_apply.TabIndex = 355;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Pop_BP_Purchase_Order_SearchType
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(346, 127);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_BP_Purchase_Order_SearchType";
            this.TopMost = true;
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_searchType)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 이벤트 핸들러

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			COM.ComVar.Parameter_PopUp = new string[] { cmb_searchType.SelectedValue.ToString() };
			this.DialogResult = DialogResult.OK;
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
            this.DialogResult = DialogResult.Cancel;
		}	

		#endregion

		#region 이번트 처리

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			this.Text = "Search";
            lbl_MainTitle.Text = "Search";
            ClassLib.ComFunction.SetLangDic(this);

			DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBP17");
			COM.ComCtl.Set_ComboList(vDt, cmb_searchType, 1, 2, false);
			cmb_searchType.SelectedIndex = 0;
			vDt.Dispose();
		}

		#endregion


	}
}

