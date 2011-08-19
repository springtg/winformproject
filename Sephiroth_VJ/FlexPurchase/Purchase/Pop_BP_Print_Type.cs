using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;

namespace FlexPurchase.Purchase
{
	public class Pop_BP_Print_Type : COM.PCHWinForm.Pop_Small
	{
		#region 디자이너에서 사용한 변수 선언

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.RadioButton rad_printbyitem;
		private System.Windows.Forms.RadioButton rad_printbyTotal;
		private System.Windows.Forms.RadioButton rad_printbyTail;
		private System.Windows.Forms.RadioButton rad_printbystyle;
		private System.Windows.Forms.Label lbl_vendor;
		private System.Windows.Forms.TextBox txt_vendorCode;
		private C1.Win.C1List.C1Combo cmb_vendor;
        private RadioButton rad_printJJ;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		#endregion

		#region 생성자 / 소멸자

		public Pop_BP_Print_Type()
		{
			InitializeComponent();
		}

		public Pop_BP_Print_Type(DataTable TempDataTable)
		{
			InitializeComponent();
			cmb_vendor.DataSource = TempDataTable;

            if (ClassLib.ComVar.This_Factory == "JJ") { rad_printJJ.Checked = true; rad_printJJ.Visible = true; }
            else { rad_printbyTotal.Checked = true; rad_printJJ.Visible = false; }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BP_Print_Type));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_printJJ = new System.Windows.Forms.RadioButton();
            this.rad_printbyTail = new System.Windows.Forms.RadioButton();
            this.rad_printbyTotal = new System.Windows.Forms.RadioButton();
            this.rad_printbystyle = new System.Windows.Forms.RadioButton();
            this.rad_printbyitem = new System.Windows.Forms.RadioButton();
            this.btn_apply = new System.Windows.Forms.Label();
            this.lbl_vendor = new System.Windows.Forms.Label();
            this.txt_vendorCode = new System.Windows.Forms.TextBox();
            this.cmb_vendor = new C1.Win.C1List.C1Combo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(392, 23);
            this.lbl_MainTitle.Text = "Print";
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
            this.groupBox1.Controls.Add(this.rad_printJJ);
            this.groupBox1.Controls.Add(this.rad_printbyTail);
            this.groupBox1.Controls.Add(this.rad_printbyTotal);
            this.groupBox1.Controls.Add(this.rad_printbystyle);
            this.groupBox1.Controls.Add(this.rad_printbyitem);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 116);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Print Type";
            // 
            // rad_printJJ
            // 
            this.rad_printJJ.Location = new System.Drawing.Point(232, 15);
            this.rad_printJJ.Name = "rad_printJJ";
            this.rad_printJJ.Size = new System.Drawing.Size(147, 24);
            this.rad_printJJ.TabIndex = 3;
            this.rad_printJJ.Text = "Print By  Item(JJ)";
            this.rad_printJJ.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_printbyTail
            // 
            this.rad_printbyTail.Location = new System.Drawing.Point(24, 88);
            this.rad_printbyTail.Name = "rad_printbyTail";
            this.rad_printbyTail.Size = new System.Drawing.Size(200, 24);
            this.rad_printbyTail.TabIndex = 2;
            this.rad_printbyTail.Text = "Print By Standard(Tail)";
            // 
            // rad_printbyTotal
            // 
            this.rad_printbyTotal.Checked = true;
            this.rad_printbyTotal.Location = new System.Drawing.Point(24, 64);
            this.rad_printbyTotal.Name = "rad_printbyTotal";
            this.rad_printbyTotal.Size = new System.Drawing.Size(200, 24);
            this.rad_printbyTotal.TabIndex = 1;
            this.rad_printbyTotal.TabStop = true;
            this.rad_printbyTotal.Text = "Print By Standard(Total)";
            // 
            // rad_printbystyle
            // 
            this.rad_printbystyle.Location = new System.Drawing.Point(24, 16);
            this.rad_printbystyle.Name = "rad_printbystyle";
            this.rad_printbystyle.Size = new System.Drawing.Size(160, 24);
            this.rad_printbystyle.TabIndex = 0;
            this.rad_printbystyle.Text = "Print by Style";
            // 
            // rad_printbyitem
            // 
            this.rad_printbyitem.Location = new System.Drawing.Point(24, 40);
            this.rad_printbyitem.Name = "rad_printbyitem";
            this.rad_printbyitem.Size = new System.Drawing.Size(200, 24);
            this.rad_printbyitem.TabIndex = 0;
            this.rad_printbyitem.Text = "Print By Item";
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(348, 158);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 356;
            this.btn_apply.Text = "Print";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // lbl_vendor
            // 
            this.lbl_vendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_vendor.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vendor.ImageIndex = 0;
            this.lbl_vendor.ImageList = this.img_Label;
            this.lbl_vendor.Location = new System.Drawing.Point(8, 159);
            this.lbl_vendor.Name = "lbl_vendor";
            this.lbl_vendor.Size = new System.Drawing.Size(100, 21);
            this.lbl_vendor.TabIndex = 371;
            this.lbl_vendor.Text = "Vendor";
            this.lbl_vendor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_vendorCode
            // 
            this.txt_vendorCode.Location = new System.Drawing.Point(16, 135);
            this.txt_vendorCode.Name = "txt_vendorCode";
            this.txt_vendorCode.Size = new System.Drawing.Size(100, 21);
            this.txt_vendorCode.TabIndex = 357;
            // 
            // cmb_vendor
            // 
            this.cmb_vendor.AddItemSeparator = ';';
            this.cmb_vendor.Caption = "";
            this.cmb_vendor.CaptionHeight = 17;
            this.cmb_vendor.CaptionStyle = style1;
            this.cmb_vendor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_vendor.ColumnCaptionHeight = 18;
            this.cmb_vendor.ColumnFooterHeight = 18;
            this.cmb_vendor.ContentHeight = 16;
            this.cmb_vendor.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_vendor.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_vendor.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_vendor.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_vendor.EditorHeight = 16;
            this.cmb_vendor.EvenRowStyle = style2;
            this.cmb_vendor.FooterStyle = style3;
            this.cmb_vendor.HeadingStyle = style4;
            this.cmb_vendor.HighLightRowStyle = style5;
            this.cmb_vendor.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_vendor.Images"))));
            this.cmb_vendor.ItemHeight = 15;
            this.cmb_vendor.Location = new System.Drawing.Point(108, 158);
            this.cmb_vendor.MatchEntryTimeout = ((long)(2000));
            this.cmb_vendor.MaxDropDownItems = ((short)(5));
            this.cmb_vendor.MaxLength = 32767;
            this.cmb_vendor.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_vendor.Name = "cmb_vendor";
            this.cmb_vendor.OddRowStyle = style6;
            this.cmb_vendor.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_vendor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_vendor.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_vendor.SelectedStyle = style7;
            this.cmb_vendor.Size = new System.Drawing.Size(236, 22);
            this.cmb_vendor.Style = style8;
            this.cmb_vendor.TabIndex = 372;
            this.cmb_vendor.PropBag = resources.GetString("cmb_vendor.PropBag");
            // 
            // Pop_BP_Print_Type
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(426, 193);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_vendor);
            this.Controls.Add(this.cmb_vendor);
            this.Controls.Add(this.txt_vendorCode);
            this.Name = "Pop_BP_Print_Type";
            this.Text = "Print";
            this.Controls.SetChildIndex(this.txt_vendorCode, 0);
            this.Controls.SetChildIndex(this.cmb_vendor, 0);
            this.Controls.SetChildIndex(this.lbl_vendor, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_vendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		#region 버튼 이벤트 처리

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (rad_printbystyle.Checked)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[]{"1"};
				}
				else if (rad_printbyitem.Checked)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[]{"2"};
				}
				else if (rad_printbyTotal.Checked)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[]{"3", cmb_vendor.Text };
				
				}
				else if (rad_printbyTail.Checked)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[]{"4", cmb_vendor.Text, cmb_vendor.Columns[1].Value.ToString() };
				
				}
                else if (rad_printJJ.Checked)
				{
					ClassLib.ComVar.Parameter_PopUp = new string[]{"5", cmb_vendor.Text, cmb_vendor.Columns[1].Value.ToString() };
				
				}


               

				this.DialogResult = DialogResult.OK;
				this.Close();


			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		#endregion

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

	}
}

