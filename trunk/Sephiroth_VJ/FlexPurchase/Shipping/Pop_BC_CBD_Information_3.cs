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
	public class Pop_BC_CBD_Information_3 : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label btn_cancel2;
		private System.Windows.Forms.Label btn_apply2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chk_0;
		private System.Windows.Forms.CheckBox chk_1;
		private System.Windows.Forms.CheckBox chk_2;
		private System.Windows.Forms.CheckBox chk_3;
		private System.Windows.Forms.CheckBox chk_4;
		private System.Windows.Forms.CheckBox chk_5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label btn_apply1;
		private System.Windows.Forms.Label btn_cancel1;
		private System.Windows.Forms.CheckBox CBD_PRICE;
		private System.Windows.Forms.CheckBox OUTSIDE_CURRENCY;
		private System.Windows.Forms.CheckBox OUTSIDE_PRICE;
		private System.Windows.Forms.CheckBox SHIP_CURRENCY;
		private System.Windows.Forms.CheckBox SHIP_PRICE;
		private System.Windows.Forms.CheckBox PUR_CURRENCY;
		private System.Windows.Forms.CheckBox PUR_PRICE;
		private System.Windows.Forms.CheckBox WEIGHT;
		private System.Windows.Forms.CheckBox PK_UNIT_QTY;
		private System.Windows.Forms.CheckBox PUR_USER;
		private System.Windows.Forms.CheckBox CBD_CURRENCY;
		private System.Windows.Forms.CheckBox CUST_CD;
		private System.Windows.Forms.CheckBox CBM;
		private System.Windows.Forms.CheckBox chk_all;
		private System.Windows.Forms.CheckBox CUST_NAME;
		private System.Windows.Forms.CheckBox chk_pur_qty;
		private System.Windows.Forms.CheckBox chk_zero;
		private System.ComponentModel.IContainer components = null;

		public Pop_BC_CBD_Information_3(Control arg_grid, int[] arg_keys, int[] arg_values)
		{
			InitializeComponent();

			_grid = arg_grid;
			_factoryCol	= arg_keys[0];
			_obsIdCol	= arg_keys[1];
			_styleCol	= arg_keys[2];
			_itemCol	= arg_keys[3];
			_specCol	= arg_keys[4];
			_colorCol	= arg_keys[5];
			_values		= arg_values;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BC_CBD_Information_3));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel2 = new System.Windows.Forms.Label();
            this.btn_apply2 = new System.Windows.Forms.Label();
            this.chk_zero = new System.Windows.Forms.CheckBox();
            this.chk_pur_qty = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_0 = new System.Windows.Forms.CheckBox();
            this.chk_1 = new System.Windows.Forms.CheckBox();
            this.chk_2 = new System.Windows.Forms.CheckBox();
            this.chk_3 = new System.Windows.Forms.CheckBox();
            this.chk_4 = new System.Windows.Forms.CheckBox();
            this.chk_5 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CUST_NAME = new System.Windows.Forms.CheckBox();
            this.PUR_CURRENCY = new System.Windows.Forms.CheckBox();
            this.PUR_PRICE = new System.Windows.Forms.CheckBox();
            this.btn_apply1 = new System.Windows.Forms.Label();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.WEIGHT = new System.Windows.Forms.CheckBox();
            this.CBM = new System.Windows.Forms.CheckBox();
            this.PK_UNIT_QTY = new System.Windows.Forms.CheckBox();
            this.CUST_CD = new System.Windows.Forms.CheckBox();
            this.PUR_USER = new System.Windows.Forms.CheckBox();
            this.CBD_CURRENCY = new System.Windows.Forms.CheckBox();
            this.CBD_PRICE = new System.Windows.Forms.CheckBox();
            this.OUTSIDE_CURRENCY = new System.Windows.Forms.CheckBox();
            this.OUTSIDE_PRICE = new System.Windows.Forms.CheckBox();
            this.SHIP_CURRENCY = new System.Windows.Forms.CheckBox();
            this.SHIP_PRICE = new System.Windows.Forms.CheckBox();
            this.btn_cancel1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btn_cancel2);
            this.groupBox3.Controls.Add(this.btn_apply2);
            this.groupBox3.Controls.Add(this.chk_zero);
            this.groupBox3.Controls.Add(this.chk_pur_qty);
            this.groupBox3.Location = new System.Drawing.Point(8, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(380, 56);
            this.groupBox3.TabIndex = 361;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Apply Proviso 2";
            // 
            // btn_cancel2
            // 
            this.btn_cancel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel2.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel2.ImageIndex = 0;
            this.btn_cancel2.ImageList = this.img_Button;
            this.btn_cancel2.Location = new System.Drawing.Point(296, 24);
            this.btn_cancel2.Name = "btn_cancel2";
            this.btn_cancel2.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel2.TabIndex = 356;
            this.btn_cancel2.Text = "Cancel";
            this.btn_cancel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel2.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // btn_apply2
            // 
            this.btn_apply2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply2.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply2.ImageIndex = 0;
            this.btn_apply2.ImageList = this.img_Button;
            this.btn_apply2.Location = new System.Drawing.Point(224, 24);
            this.btn_apply2.Name = "btn_apply2";
            this.btn_apply2.Size = new System.Drawing.Size(72, 23);
            this.btn_apply2.TabIndex = 356;
            this.btn_apply2.Text = "Apply";
            this.btn_apply2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            this.btn_apply2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // chk_zero
            // 
            this.chk_zero.Checked = true;
            this.chk_zero.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_zero.Location = new System.Drawing.Point(120, 24);
            this.chk_zero.Name = "chk_zero";
            this.chk_zero.Size = new System.Drawing.Size(128, 24);
            this.chk_zero.TabIndex = 358;
            this.chk_zero.Text = "Zero";
            // 
            // chk_pur_qty
            // 
            this.chk_pur_qty.Location = new System.Drawing.Point(24, 24);
            this.chk_pur_qty.Name = "chk_pur_qty";
            this.chk_pur_qty.Size = new System.Drawing.Size(128, 24);
            this.chk_pur_qty.TabIndex = 357;
            this.chk_pur_qty.Text = "Pur Qty";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk_0);
            this.groupBox1.Controls.Add(this.chk_1);
            this.groupBox1.Controls.Add(this.chk_2);
            this.groupBox1.Controls.Add(this.chk_3);
            this.groupBox1.Controls.Add(this.chk_4);
            this.groupBox1.Controls.Add(this.chk_5);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 176);
            this.groupBox1.TabIndex = 359;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Select Proviso ";
            // 
            // chk_0
            // 
            this.chk_0.Checked = true;
            this.chk_0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_0.Location = new System.Drawing.Point(24, 24);
            this.chk_0.Name = "chk_0";
            this.chk_0.Size = new System.Drawing.Size(304, 24);
            this.chk_0.TabIndex = 1;
            this.chk_0.Tag = "";
            this.chk_0.Text = "1. Factory, DPO, Style, Item, Spec, Color";
            // 
            // chk_1
            // 
            this.chk_1.Checked = true;
            this.chk_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_1.Location = new System.Drawing.Point(24, 48);
            this.chk_1.Name = "chk_1";
            this.chk_1.Size = new System.Drawing.Size(304, 24);
            this.chk_1.TabIndex = 0;
            this.chk_1.Tag = "";
            this.chk_1.Text = "2. DPO, Style, Item, Spec, Color";
            // 
            // chk_2
            // 
            this.chk_2.Checked = true;
            this.chk_2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_2.Location = new System.Drawing.Point(24, 72);
            this.chk_2.Name = "chk_2";
            this.chk_2.Size = new System.Drawing.Size(304, 24);
            this.chk_2.TabIndex = 0;
            this.chk_2.Tag = "";
            this.chk_2.Text = "3. Style, Item, Spec, Color";
            // 
            // chk_3
            // 
            this.chk_3.Checked = true;
            this.chk_3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_3.Location = new System.Drawing.Point(24, 96);
            this.chk_3.Name = "chk_3";
            this.chk_3.Size = new System.Drawing.Size(304, 24);
            this.chk_3.TabIndex = 0;
            this.chk_3.Tag = "";
            this.chk_3.Text = "4. Item, Spec, Color";
            // 
            // chk_4
            // 
            this.chk_4.Checked = true;
            this.chk_4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_4.Location = new System.Drawing.Point(24, 120);
            this.chk_4.Name = "chk_4";
            this.chk_4.Size = new System.Drawing.Size(304, 24);
            this.chk_4.TabIndex = 0;
            this.chk_4.Tag = "";
            this.chk_4.Text = "5. Item ( From Item Master )";
            // 
            // chk_5
            // 
            this.chk_5.Location = new System.Drawing.Point(24, 144);
            this.chk_5.Name = "chk_5";
            this.chk_5.Size = new System.Drawing.Size(304, 24);
            this.chk_5.TabIndex = 0;
            this.chk_5.Tag = "";
            this.chk_5.Text = "6. Item ( From Item Group Master )";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.CUST_NAME);
            this.groupBox2.Controls.Add(this.PUR_CURRENCY);
            this.groupBox2.Controls.Add(this.PUR_PRICE);
            this.groupBox2.Controls.Add(this.btn_apply1);
            this.groupBox2.Controls.Add(this.chk_all);
            this.groupBox2.Controls.Add(this.WEIGHT);
            this.groupBox2.Controls.Add(this.CBM);
            this.groupBox2.Controls.Add(this.PK_UNIT_QTY);
            this.groupBox2.Controls.Add(this.CUST_CD);
            this.groupBox2.Controls.Add(this.PUR_USER);
            this.groupBox2.Controls.Add(this.CBD_CURRENCY);
            this.groupBox2.Controls.Add(this.CBD_PRICE);
            this.groupBox2.Controls.Add(this.OUTSIDE_CURRENCY);
            this.groupBox2.Controls.Add(this.OUTSIDE_PRICE);
            this.groupBox2.Controls.Add(this.SHIP_CURRENCY);
            this.groupBox2.Controls.Add(this.SHIP_PRICE);
            this.groupBox2.Controls.Add(this.btn_cancel1);
            this.groupBox2.Location = new System.Drawing.Point(8, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 208);
            this.groupBox2.TabIndex = 360;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apply Proviso 1";
            // 
            // CUST_NAME
            // 
            this.CUST_NAME.Checked = true;
            this.CUST_NAME.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CUST_NAME.Enabled = false;
            this.CUST_NAME.Location = new System.Drawing.Point(288, 96);
            this.CUST_NAME.Name = "CUST_NAME";
            this.CUST_NAME.Size = new System.Drawing.Size(128, 24);
            this.CUST_NAME.TabIndex = 362;
            this.CUST_NAME.Text = "Vendor";
            this.CUST_NAME.Visible = false;
            // 
            // PUR_CURRENCY
            // 
            this.PUR_CURRENCY.Checked = true;
            this.PUR_CURRENCY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PUR_CURRENCY.Location = new System.Drawing.Point(160, 24);
            this.PUR_CURRENCY.Name = "PUR_CURRENCY";
            this.PUR_CURRENCY.Size = new System.Drawing.Size(128, 24);
            this.PUR_CURRENCY.TabIndex = 361;
            this.PUR_CURRENCY.Text = "Pur Currency";
            // 
            // PUR_PRICE
            // 
            this.PUR_PRICE.Checked = true;
            this.PUR_PRICE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PUR_PRICE.Location = new System.Drawing.Point(24, 24);
            this.PUR_PRICE.Name = "PUR_PRICE";
            this.PUR_PRICE.Size = new System.Drawing.Size(128, 24);
            this.PUR_PRICE.TabIndex = 360;
            this.PUR_PRICE.Text = "Pur Price";
            // 
            // btn_apply1
            // 
            this.btn_apply1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply1.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply1.ImageIndex = 0;
            this.btn_apply1.ImageList = this.img_Button;
            this.btn_apply1.Location = new System.Drawing.Point(224, 176);
            this.btn_apply1.Name = "btn_apply1";
            this.btn_apply1.Size = new System.Drawing.Size(72, 23);
            this.btn_apply1.TabIndex = 359;
            this.btn_apply1.Text = "Apply";
            this.btn_apply1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            this.btn_apply1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_apply1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // chk_all
            // 
            this.chk_all.Checked = true;
            this.chk_all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_all.Location = new System.Drawing.Point(288, 144);
            this.chk_all.Name = "chk_all";
            this.chk_all.Size = new System.Drawing.Size(128, 24);
            this.chk_all.TabIndex = 13;
            this.chk_all.Text = "All";
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // WEIGHT
            // 
            this.WEIGHT.Checked = true;
            this.WEIGHT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WEIGHT.Location = new System.Drawing.Point(288, 120);
            this.WEIGHT.Name = "WEIGHT";
            this.WEIGHT.Size = new System.Drawing.Size(128, 24);
            this.WEIGHT.TabIndex = 12;
            this.WEIGHT.Text = "Weight";
            // 
            // CBM
            // 
            this.CBM.Checked = true;
            this.CBM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBM.Location = new System.Drawing.Point(160, 144);
            this.CBM.Name = "CBM";
            this.CBM.Size = new System.Drawing.Size(128, 24);
            this.CBM.TabIndex = 11;
            this.CBM.Text = "CBM";
            // 
            // PK_UNIT_QTY
            // 
            this.PK_UNIT_QTY.Checked = true;
            this.PK_UNIT_QTY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PK_UNIT_QTY.Location = new System.Drawing.Point(24, 144);
            this.PK_UNIT_QTY.Name = "PK_UNIT_QTY";
            this.PK_UNIT_QTY.Size = new System.Drawing.Size(128, 24);
            this.PK_UNIT_QTY.TabIndex = 10;
            this.PK_UNIT_QTY.Text = "P/K Qty";
            // 
            // CUST_CD
            // 
            this.CUST_CD.Checked = true;
            this.CUST_CD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CUST_CD.Location = new System.Drawing.Point(160, 120);
            this.CUST_CD.Name = "CUST_CD";
            this.CUST_CD.Size = new System.Drawing.Size(128, 24);
            this.CUST_CD.TabIndex = 9;
            this.CUST_CD.Text = "Vendor";
            this.CUST_CD.CheckedChanged += new System.EventHandler(this.CUST_CD_CheckedChanged);
            // 
            // PUR_USER
            // 
            this.PUR_USER.Checked = true;
            this.PUR_USER.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PUR_USER.Location = new System.Drawing.Point(24, 120);
            this.PUR_USER.Name = "PUR_USER";
            this.PUR_USER.Size = new System.Drawing.Size(128, 24);
            this.PUR_USER.TabIndex = 8;
            this.PUR_USER.Text = "Pur User";
            // 
            // CBD_CURRENCY
            // 
            this.CBD_CURRENCY.Checked = true;
            this.CBD_CURRENCY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBD_CURRENCY.Location = new System.Drawing.Point(160, 96);
            this.CBD_CURRENCY.Name = "CBD_CURRENCY";
            this.CBD_CURRENCY.Size = new System.Drawing.Size(128, 24);
            this.CBD_CURRENCY.TabIndex = 7;
            this.CBD_CURRENCY.Text = "CBD Currency";
            // 
            // CBD_PRICE
            // 
            this.CBD_PRICE.Checked = true;
            this.CBD_PRICE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBD_PRICE.Location = new System.Drawing.Point(24, 96);
            this.CBD_PRICE.Name = "CBD_PRICE";
            this.CBD_PRICE.Size = new System.Drawing.Size(128, 24);
            this.CBD_PRICE.TabIndex = 6;
            this.CBD_PRICE.Text = "CBD Price";
            // 
            // OUTSIDE_CURRENCY
            // 
            this.OUTSIDE_CURRENCY.Checked = true;
            this.OUTSIDE_CURRENCY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OUTSIDE_CURRENCY.Location = new System.Drawing.Point(160, 72);
            this.OUTSIDE_CURRENCY.Name = "OUTSIDE_CURRENCY";
            this.OUTSIDE_CURRENCY.Size = new System.Drawing.Size(128, 24);
            this.OUTSIDE_CURRENCY.TabIndex = 5;
            this.OUTSIDE_CURRENCY.Text = "Outside Currency";
            // 
            // OUTSIDE_PRICE
            // 
            this.OUTSIDE_PRICE.Checked = true;
            this.OUTSIDE_PRICE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OUTSIDE_PRICE.Location = new System.Drawing.Point(24, 72);
            this.OUTSIDE_PRICE.Name = "OUTSIDE_PRICE";
            this.OUTSIDE_PRICE.Size = new System.Drawing.Size(128, 24);
            this.OUTSIDE_PRICE.TabIndex = 4;
            this.OUTSIDE_PRICE.Text = "Outside Price";
            // 
            // SHIP_CURRENCY
            // 
            this.SHIP_CURRENCY.Checked = true;
            this.SHIP_CURRENCY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHIP_CURRENCY.Location = new System.Drawing.Point(160, 48);
            this.SHIP_CURRENCY.Name = "SHIP_CURRENCY";
            this.SHIP_CURRENCY.Size = new System.Drawing.Size(128, 24);
            this.SHIP_CURRENCY.TabIndex = 3;
            this.SHIP_CURRENCY.Text = "Ship Currency";
            // 
            // SHIP_PRICE
            // 
            this.SHIP_PRICE.Checked = true;
            this.SHIP_PRICE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SHIP_PRICE.Location = new System.Drawing.Point(24, 48);
            this.SHIP_PRICE.Name = "SHIP_PRICE";
            this.SHIP_PRICE.Size = new System.Drawing.Size(128, 24);
            this.SHIP_PRICE.TabIndex = 2;
            this.SHIP_PRICE.Text = "Ship Price";
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel1.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel1.ImageIndex = 0;
            this.btn_cancel1.ImageList = this.img_Button;
            this.btn_cancel1.Location = new System.Drawing.Point(296, 176);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(72, 23);
            this.btn_cancel1.TabIndex = 358;
            this.btn_cancel1.Text = "Cancel";
            this.btn_cancel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Plus);
            this.btn_cancel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Minus);
            // 
            // Pop_BC_CBD_Information_3
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 511);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Pop_BC_CBD_Information_3";
            this.Load += new System.EventHandler(this.Pop_BC_CBD_Information_Load);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.SSP _ssp;
		private COM.FSP _fsp;
		public string _job = "";
		private int _factoryCol, _obsIdCol, _styleCol, _itemCol, _specCol, _colorCol;
		public int _level, _purQty;
		public string _factory, _obsId, _style, _item, _spec, _color, _mrpShipNo;
		private int[] _values;
		private Control _grid;
		private Hashtable chks = new Hashtable();
		private COM.OraDB MyOraDB = new COM.OraDB();

		#endregion        

		#region 컨트롤 이벤트 처리

		private void Pop_BC_CBD_Information_Load(object sender, System.EventArgs e)
		{
			this.Init_Form(_grid);
		}

		private void CUST_CD_CheckedChanged(object sender, System.EventArgs e)
		{
			CUST_NAME.Checked = CUST_CD.Checked;
		}

		private void chk_all_CheckedChanged(object sender, System.EventArgs e)
		{
			System.Collections.IEnumerator vEnum = chks.Values.GetEnumerator();

			while (vEnum.MoveNext())
			{
				CheckBox chk = (CheckBox)vEnum.Current;
				chk.Checked = chk_all.Checked;
			}
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
				string vDivision = Convert.ToInt32(chk_0.Checked).ToString()
					+ Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("000000"))	return;
			
				FarPoint.Win.Spread.Model.CellRange[] vRanges = _ssp.ActiveSheet.GetSelections();

				for (int vIdx1 = 0 ; vIdx1 < vRanges.Length ; vIdx1++)
				{
					for (int vIdx2 = vRanges[vIdx1].Row ; vIdx2 < vRanges[vIdx1].Row + vRanges[vIdx1].RowCount ; vIdx2++)
					{
						this.Text = "Processing... " + (vIdx2 + 1) + " Row";

						//string vFactory = COM.ComVar.This_Factory;
						string vFactory = (_factoryCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _factoryCol].Text : _factory;
						string vObsId	= (_obsIdCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _obsIdCol].Text : _obsId;
						string vStyle	= (_styleCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _styleCol].Text : _style;
						vStyle = vStyle.Replace("-", "");
						string vItem	= (_itemCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _itemCol].Text : _item;
						string vSpec	= (_specCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _specCol].Text : _spec;
						string vColor	= (_colorCol != -1) ? _ssp.ActiveSheet.Cells[vIdx2, _colorCol].Text : _color;

						DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vObsId, vStyle, vItem, vSpec, vColor);
						if (vDt.Rows.Count > 0)
						{
							for (int i = 0 ; i < _values.Length ; i++)
							{
								object obj = chks[vDt.Columns[i].ColumnName];
								if (obj == null)
									continue;

								if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals("") && ((CheckBox)obj).Checked)
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
				string vDivision = Convert.ToInt32(chk_0.Checked).ToString()
					+ Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("000000"))	return;

				int[] selRows = _fsp.Selections;

				foreach (int vRow in selRows)
				{
					if (_level != 0)
						if (_fsp.Rows[vRow].Node.Level != _level)
							continue;

					this.Text = "Processing... " + vRow + " Row";

					//string vFactory = COM.ComVar.This_Factory;
					string vFactory = (_factoryCol != -1) ? _fsp[vRow, _factoryCol].ToString() : _factory;
					string vObsId	= (_obsIdCol != -1) ? _fsp[vRow, _obsIdCol].ToString() : _obsId;
					string vStyle	= (_styleCol != -1) ? _fsp[vRow, _styleCol].ToString() : _style;
					vStyle = vStyle.Replace("-", "");
					string vItem	= (_itemCol != -1) ? _fsp[vRow, _itemCol].ToString() : _item;
					string vSpec	= (_specCol != -1) ? _fsp[vRow, _specCol].ToString() : _spec;
					string vColor	= (_colorCol != -1) ? _fsp[vRow, _colorCol].ToString() : _color;

					DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vObsId, vStyle, vItem, vSpec, vColor);
					if (vDt.Rows.Count > 0)
					{
						for (int i = 0 ; i < _values.Length ; i++)
						{
							object obj = chks[vDt.Columns[i].ColumnName];
							if (obj == null)
								continue;

							if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals("") && ((CheckBox)obj).Checked)
								_fsp[vRow, _values[i]] = vDt.Rows[0].ItemArray[i];
						}
					}

					_fsp.Update_Row(vRow);
				}

				_fsp.TopRow = selRows[0];
				_fsp.Select(selRows[0], 1);
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_ApplyProcess_FSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			this.DialogResult = DialogResult.OK;
			this.Dispose();
		}

		private void Btn_Apply2Process_FSP(object sender, System.EventArgs e)
		{
			try
			{
				if (chk_pur_qty.Checked)
				{
					int[] selRows = _fsp.Selections;

					foreach (int vRow in selRows)
					{
						this.Text = "Processing... " + vRow + " Row";

						string vFactory = (_factoryCol != -1) ? _fsp[vRow, _factoryCol].ToString() : _factory;
						string vMRPShipNo	= _mrpShipNo;
						string vStyle	= (_styleCol != -1) ? _fsp[vRow, _styleCol].ToString() : _style;
						vStyle = vStyle.Replace("-", "");
						string vItem	= (_itemCol != -1) ? _fsp[vRow, _itemCol].ToString() : _item;
						string vSpec	= (_specCol != -1) ? _fsp[vRow, _specCol].ToString() : _spec;
						string vColor	= (_colorCol != -1) ? _fsp[vRow, _colorCol].ToString() : _color;

						DataTable vDt = SELECT_SBP_PURCHASE_ORDER_QTY(vFactory, vMRPShipNo, vStyle, vItem, vSpec, vColor);

						if (vDt.Rows.Count > 0)
						{
							_fsp[vRow, _purQty] = vDt.Rows[0].ItemArray[0];
						}
						else
						{
							if (chk_zero.Checked)
							{
								_fsp[vRow, _purQty] = 0;
							}
						}

						_fsp.Update_Row(vRow);
					}

					_fsp.TopRow = selRows[0];
					_fsp.Select(selRows[0], 1);
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Btn_Apply2Process_FSP", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				string vDivision = Convert.ToInt32(chk_0.Checked).ToString()
					+ Convert.ToInt32(chk_1.Checked).ToString()
					+ Convert.ToInt32(chk_2.Checked).ToString()
					+ Convert.ToInt32(chk_3.Checked).ToString()
					+ Convert.ToInt32(chk_4.Checked).ToString()
					+ Convert.ToInt32(chk_5.Checked).ToString();

				if (vDivision.Equals("000000"))	return;

				int[] vSels = _fsp.Selections;
				
				foreach (int vRow1 in vSels)
				{
					if ( _fsp.Rows[vRow1].Node.Level == 1 )
					{
						int vsIdx = _fsp.Rows[vRow1].Index;
						int veIdx = _fsp.Rows[vRow1].Node.GetNode(NodeTypeEnum.LastChild).Row.Index;

						for (int idx = vsIdx ; idx <= veIdx ; idx++)
						{
							_fsp.Rows[idx].Selected = true;
						}
					}
				}

				foreach (int vRow in _fsp.Selections)
				{
					//if (_fsp.Rows[vRow].Node.Level != _level)
					//{
					//	_fsp.Update_Row(vRow);
					//	continue;
					//}

					this.Text = "Processing... " + vRow + " Row";

					//string vFactory = COM.ComVar.This_Factory;
					string vFactory = (_factoryCol != -1) ? _fsp[vRow, _factoryCol].ToString() : _factory;
					string vObsId	= (_obsIdCol != -1) ? _fsp[vRow, _obsIdCol].ToString() : _obsId;
					string vStyle	= (_styleCol != -1) ? _fsp[vRow, _styleCol].ToString() : _style;
					vStyle = vStyle.Replace("-", "");
					string vItem	= (_itemCol != -1) ? _fsp[vRow, _itemCol].ToString() : _item;
					string vSpec	= (_specCol != -1) ? _fsp[vRow, _specCol].ToString() : _spec;
					string vColor	= (_colorCol != -1) ? _fsp[vRow, _colorCol].ToString() : _color;

					DataTable vDt = SELECT_CBD_INFORMATION (vDivision, vFactory, vObsId, vStyle, vItem, vSpec, vColor);
					if (vDt.Rows.Count > 0)
					{
						//Node en = _fsp.Rows[vRow].Node.GetNode(NodeTypeEnum.LastChild);

						//for (int pc = vRow ; pc <= en.Row.Index ; pc++)
						//{
							for (int i = 0 ; i < _values.Length ; i++)
							{
								object obj = chks[vDt.Columns[i].ColumnName];
								if (obj == null)
									continue;

								if (_values[i] != -1 && !vDt.Rows[0].ItemArray[i].ToString().Equals("") && ((CheckBox)obj).Checked)
									_fsp[vRow, _values[i]] = vDt.Rows[0].ItemArray[i];
							}

							_fsp.Update_Row(vRow);
						//}
					}					
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

			EventHandler vHandler = null;
			EventHandler vHandler2 = null;

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

			if (_level != 0)
			{
				chk_pur_qty.Enabled = false;
				btn_apply2.Enabled = false;
			}
			else
			{
				vHandler2 = new EventHandler(this.Btn_Apply2Process_FSP);
			}
				

			btn_apply1.Click += vHandler;
			btn_apply2.Click += vHandler2;

			System.Collections.IEnumerator vEnum = groupBox2.Controls.GetEnumerator();

			while (vEnum.MoveNext())
			{
				if (vEnum.Current.GetType().Name.Equals("CheckBox"))
				{
					CheckBox chk = (CheckBox)vEnum.Current;
					chks.Add(chk.Name, chk);
				}

				chks.Remove("chk_all");
			}
		}

		private void Init_CheckBox()
		{
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
		public DataTable SELECT_CBD_INFORMATION(
			string arg_division, 
			string arg_factory, 
			string arg_obs_id, 
			string arg_style_cd, 
			string arg_item_cd, 
			string arg_spec_cd, 
			string arg_color_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(8);

			//01.PROCEDURE명
			//MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFORMATION";
			MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[3] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[4] = "ARG_ITEM_CD";
			MyOraDB.Parameter_Name[5] = "ARG_SPEC_CD";
			MyOraDB.Parameter_Name[6] = "ARG_COLOR_CD";
			MyOraDB.Parameter_Name[7] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_division;
			MyOraDB.Parameter_Values[1] = arg_factory;
			MyOraDB.Parameter_Values[2] = arg_obs_id;
			MyOraDB.Parameter_Values[3] = arg_style_cd;
			MyOraDB.Parameter_Values[4] = arg_item_cd;
			MyOraDB.Parameter_Values[5] = arg_spec_cd;
			MyOraDB.Parameter_Values[6] = arg_color_cd;
			MyOraDB.Parameter_Values[7] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBS_SHIPPING_LIST : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBP_PURCHASE_ORDER_QTY(
			string arg_factory, 
			string arg_mrp_ship_no, 
			string arg_style_cd, 
			string arg_item_cd, 
			string arg_spec_cd, 
			string arg_color_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(7);

			//01.PROCEDURE명
			//MyOraDB.Process_Name = "PKG_SBS_SHIPPING_LIST.SELECT_CBD_INFORMATION";
			MyOraDB.Process_Name = "PKG_SBP_PURCHASE_ORDER_EXTEND.SELECT_SBP_PURCHASE_ORDER_QTY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_MRP_SHIP_NO";
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
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_mrp_ship_no;
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

       

	}
}

