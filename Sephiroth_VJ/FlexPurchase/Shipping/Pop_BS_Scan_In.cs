using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Scan_In : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label lbl_inType;
		private System.Windows.Forms.Label lbl_container;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.DateTimePicker dpick_scanYmd;
		private System.Windows.Forms.Label lbl_scanYmd;
		private C1.Win.C1List.C1Combo cmb_container;
		private C1.Win.C1List.C1Combo cmb_inType;
		private C1.Win.C1List.C1Combo cmb_location;
		private System.Windows.Forms.Label lbl_location;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.DateTimePicker dpick_shipYmd;
		private System.ComponentModel.IContainer components = null;

		#region 생성자 / 소멸자

		public Pop_BS_Scan_In()
		{
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Scan_In));
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
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.dpick_scanYmd = new System.Windows.Forms.DateTimePicker();
            this.cmb_inType = new C1.Win.C1List.C1Combo();
            this.cmb_container = new C1.Win.C1List.C1Combo();
            this.cmb_location = new C1.Win.C1List.C1Combo();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_container = new System.Windows.Forms.Label();
            this.lbl_scanYmd = new System.Windows.Forms.Label();
            this.lbl_inType = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.dpick_shipYmd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_location)).BeginInit();
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
            this.btn_apply.Location = new System.Drawing.Point(206, 176);
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
            this.btn_cancel.Location = new System.Drawing.Point(277, 176);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
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
            // cmb_inType
            // 
            this.cmb_inType.AddItemSeparator = ';';
            this.cmb_inType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_inType.Caption = "";
            this.cmb_inType.CaptionHeight = 17;
            this.cmb_inType.CaptionStyle = style1;
            this.cmb_inType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_inType.ColumnCaptionHeight = 18;
            this.cmb_inType.ColumnFooterHeight = 18;
            this.cmb_inType.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_inType.ContentHeight = 16;
            this.cmb_inType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_inType.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_inType.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_inType.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_inType.EditorHeight = 16;
            this.cmb_inType.EvenRowStyle = style2;
            this.cmb_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_inType.FooterStyle = style3;
            this.cmb_inType.HeadingStyle = style4;
            this.cmb_inType.HighLightRowStyle = style5;
            this.cmb_inType.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_inType.Images"))));
            this.cmb_inType.ItemHeight = 15;
            this.cmb_inType.Location = new System.Drawing.Point(109, 38);
            this.cmb_inType.MatchEntryTimeout = ((long)(2000));
            this.cmb_inType.MaxDropDownItems = ((short)(5));
            this.cmb_inType.MaxLength = 32767;
            this.cmb_inType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_inType.Name = "cmb_inType";
            this.cmb_inType.OddRowStyle = style6;
            this.cmb_inType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_inType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_inType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_inType.SelectedStyle = style7;
            this.cmb_inType.Size = new System.Drawing.Size(220, 20);
            this.cmb_inType.Style = style8;
            this.cmb_inType.TabIndex = 2;
            this.cmb_inType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.cmb_inType.SelectedValueChanged += new System.EventHandler(this.cmb_inType_SelectedValueChanged);
            this.cmb_inType.PropBag = resources.GetString("cmb_inType.PropBag");
            // 
            // cmb_container
            // 
            this.cmb_container.AddItemSeparator = ';';
            this.cmb_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_container.Caption = "";
            this.cmb_container.CaptionHeight = 17;
            this.cmb_container.CaptionStyle = style9;
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
            this.cmb_container.EvenRowStyle = style10;
            this.cmb_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_container.FooterStyle = style11;
            this.cmb_container.HeadingStyle = style12;
            this.cmb_container.HighLightRowStyle = style13;
            this.cmb_container.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_container.Images"))));
            this.cmb_container.ItemHeight = 15;
            this.cmb_container.Location = new System.Drawing.Point(109, 82);
            this.cmb_container.MatchEntryTimeout = ((long)(2000));
            this.cmb_container.MaxDropDownItems = ((short)(5));
            this.cmb_container.MaxLength = 32767;
            this.cmb_container.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_container.Name = "cmb_container";
            this.cmb_container.OddRowStyle = style14;
            this.cmb_container.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_container.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_container.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_container.SelectedStyle = style15;
            this.cmb_container.Size = new System.Drawing.Size(220, 20);
            this.cmb_container.Style = style16;
            this.cmb_container.TabIndex = 3;
            this.cmb_container.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.cmb_container.PropBag = resources.GetString("cmb_container.PropBag");
            // 
            // cmb_location
            // 
            this.cmb_location.AddItemSeparator = ';';
            this.cmb_location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_location.Caption = "";
            this.cmb_location.CaptionHeight = 17;
            this.cmb_location.CaptionStyle = style17;
            this.cmb_location.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_location.ColumnCaptionHeight = 18;
            this.cmb_location.ColumnFooterHeight = 18;
            this.cmb_location.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_location.ContentHeight = 16;
            this.cmb_location.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_location.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_location.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_location.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_location.EditorHeight = 16;
            this.cmb_location.EvenRowStyle = style18;
            this.cmb_location.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_location.FooterStyle = style19;
            this.cmb_location.HeadingStyle = style20;
            this.cmb_location.HighLightRowStyle = style21;
            this.cmb_location.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_location.Images"))));
            this.cmb_location.ItemHeight = 15;
            this.cmb_location.Location = new System.Drawing.Point(109, 104);
            this.cmb_location.MatchEntryTimeout = ((long)(2000));
            this.cmb_location.MaxDropDownItems = ((short)(5));
            this.cmb_location.MaxLength = 32767;
            this.cmb_location.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_location.Name = "cmb_location";
            this.cmb_location.OddRowStyle = style22;
            this.cmb_location.ReadOnly = true;
            this.cmb_location.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_location.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_location.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_location.SelectedStyle = style23;
            this.cmb_location.Size = new System.Drawing.Size(220, 20);
            this.cmb_location.Style = style24;
            this.cmb_location.TabIndex = 4;
            this.cmb_location.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Control_MoveNextByFocus);
            this.cmb_location.PropBag = resources.GetString("cmb_location.PropBag");
            // 
            // lbl_location
            // 
            this.lbl_location.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_location.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.ImageIndex = 0;
            this.lbl_location.ImageList = this.img_Label;
            this.lbl_location.Location = new System.Drawing.Point(8, 104);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(100, 21);
            this.lbl_location.TabIndex = 202;
            this.lbl_location.Text = "Location";
            this.lbl_location.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_container
            // 
            this.lbl_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_container.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_container.ImageIndex = 0;
            this.lbl_container.ImageList = this.img_Label;
            this.lbl_container.Location = new System.Drawing.Point(8, 82);
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
            // lbl_inType
            // 
            this.lbl_inType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_inType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inType.ImageIndex = 0;
            this.lbl_inType.ImageList = this.img_Label;
            this.lbl_inType.Location = new System.Drawing.Point(8, 38);
            this.lbl_inType.Name = "lbl_inType";
            this.lbl_inType.Size = new System.Drawing.Size(100, 21);
            this.lbl_inType.TabIndex = 202;
            this.lbl_inType.Text = "In Type";
            this.lbl_inType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_inType);
            this.groupBox1.Controls.Add(this.dpick_scanYmd);
            this.groupBox1.Controls.Add(this.lbl_location);
            this.groupBox1.Controls.Add(this.cmb_inType);
            this.groupBox1.Controls.Add(this.cmb_location);
            this.groupBox1.Controls.Add(this.cmb_container);
            this.groupBox1.Controls.Add(this.lbl_container);
            this.groupBox1.Controls.Add(this.lbl_scanYmd);
            this.groupBox1.Controls.Add(this.lbl_shipYmd);
            this.groupBox1.Controls.Add(this.dpick_shipYmd);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 136);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // lbl_shipYmd
            // 
            this.lbl_shipYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipYmd.ImageIndex = 0;
            this.lbl_shipYmd.ImageList = this.img_Label;
            this.lbl_shipYmd.Location = new System.Drawing.Point(8, 60);
            this.lbl_shipYmd.Name = "lbl_shipYmd";
            this.lbl_shipYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipYmd.TabIndex = 202;
            this.lbl_shipYmd.Text = "Shipping";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_shipYmd
            // 
            this.dpick_shipYmd.Checked = false;
            this.dpick_shipYmd.CustomFormat = "";
            this.dpick_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipYmd.Location = new System.Drawing.Point(109, 60);
            this.dpick_shipYmd.Name = "dpick_shipYmd";
            this.dpick_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dpick_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dpick_shipYmd.TabIndex = 1;
            this.dpick_shipYmd.CloseUp += new System.EventHandler(this.dpick_shipYmd_CloseUp);
            // 
            // Pop_BS_Scan_In
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(354, 207);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BS_Scan_In";
            this.Load += new System.EventHandler(this.Pop_BS_Scan_In_Load);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_inType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_container)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_location)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트

        private void Pop_BS_Scan_In_Load(object sender, EventArgs e)
        {
            Init_Form();
        }

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Btn_CancelClickProcess();
		}

		private void dpick_scanYmd_CloseUp(object sender, System.EventArgs e)
		{
			//this.Dpick_ScanYmdCloseUpProcess();
		}

		private void cmb_inType_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_InTypeSelectedValueChangedProcess();
		}

		private void dpick_shipYmd_CloseUp(object sender, System.EventArgs e)
		{
			this.Dpick_ScanYmdCloseUpProcess();
		}

		#endregion

		#region 이벤트 처리 메서드

		private void Init_Form()
        {
			this.Text			= "Incoming Scan";
            lbl_MainTitle.Text = "Incoming Scan";
            ClassLib.ComFunction.SetLangDic(this);

			DataTable vDt = null;

			// ship type
			vDt = COM.ComVar.Select_ComCode(ClassLib.ComVar.Parameter_PopUp_Object[0].ToString(), ClassLib.ComVar.CxIncomingType);
			COM.ComCtl.Set_ComboList(vDt, cmb_inType, 1, 2, false);
			vDt.Dispose();

			vDt = ClassLib.ComFunction.SELECT_WAREHOUSE_LIST_USING(COM.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_location, 1, 2, false);
			vDt.Dispose();

			dpick_scanYmd.Value = ClassLib.ComFunction.StringToDateTime(ClassLib.ComVar.Parameter_PopUp_Object[1].ToString());
			cmb_inType.SelectedValue = ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[2]);
			cmb_inType.SelectedIndex = (cmb_inType.SelectedIndex == -1) ? 0 : cmb_inType.SelectedIndex;

			dpick_shipYmd.Value = ClassLib.ComFunction.StringToDateTime(ClassLib.ComVar.Parameter_PopUp_Object[8].ToString());
			
			Dpick_ScanYmdCloseUpProcess();

			string vCont = ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[3]);
			if (!vCont.Equals(""))
				vCont = vCont.Substring(vCont.IndexOf("-") + 2);

			cmb_container.SelectedValue = vCont;
			cmb_location.SelectedValue = ClassLib.ComFunction.NullToBlank(ClassLib.ComVar.Parameter_PopUp_Object[4]);
		}

		private void Btn_ApplyClickProcess()
		{
			COM.ComVar.Parameter_PopUp = new string[5];
			COM.ComVar.Parameter_PopUp[0] = dpick_scanYmd.Text.Replace("-", "");
            COM.ComVar.Parameter_PopUp[1] = COM.ComFunction.Empty_Combo(cmb_inType, "");
			COM.ComVar.Parameter_PopUp[2] = cmb_container.GetItemText(cmb_container.SelectedIndex, 0);
			COM.ComVar.Parameter_PopUp[3] = cmb_container.GetItemText(cmb_container.SelectedIndex, 2);
			COM.ComVar.Parameter_PopUp[4] = COM.ComFunction.Empty_Combo(cmb_location, "None");

			if (COM.ComVar.Parameter_PopUp[1].Equals("1") || COM.ComVar.Parameter_PopUp[1].Equals("2"))
			{
				if (COM.ComVar.Parameter_PopUp[3].Equals(""))
				{
					MessageBox.Show(this, "Select Container", "Scan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					cmb_container.Focus();
                    return;
				}
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void Btn_CancelClickProcess()
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void Dpick_ScanYmdCloseUpProcess()
		{
			try
			{
				DataTable vDt = ClassLib.ComFunction.SELECT_SBS_SHIP_CONT_NO_LIST(ClassLib.ComVar.Parameter_PopUp_Object[0].ToString(), dpick_shipYmd.Value.ToString("yyyyMMdd"));
				COM.ComCtl.Set_ComboList_3(vDt, cmb_container, 2, 0, 1);
				ClassLib.ComFunction.SetComboStyle(cmb_container, new string[]{"", "Date", "Container"}, new int[]{0, 80, 120}, new bool[]{false, true, true}, "Container");
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Dpick_ScanYmdCloseUpProcess", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Cmb_InTypeSelectedValueChangedProcess()
		{
			if (cmb_inType.SelectedIndex == 2)
			{
				cmb_location.ReadOnly  = false;
				dpick_shipYmd.Enabled = false;
				cmb_container.ReadOnly = true;
				cmb_container.SelectedIndex = -1;
				cmb_location.SelectedIndex = 0;
			}
			else
			{
				cmb_location.ReadOnly  = true;
				dpick_shipYmd.Enabled = true;
				cmb_container.ReadOnly = false;
				cmb_location.SelectedIndex = 1;
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

