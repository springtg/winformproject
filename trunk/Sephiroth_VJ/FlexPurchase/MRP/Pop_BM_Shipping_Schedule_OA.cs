using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexMRP.MRP
{
	public class Pop_BM_Shipping_Schedule_OA : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_shipType;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pic_head2;
		private System.Windows.Forms.PictureBox pic_head5;
		private System.Windows.Forms.PictureBox pic_head6;
		private System.Windows.Forms.PictureBox pic_head1;
		private System.Windows.Forms.Label lbl_lotNo;
		private System.Windows.Forms.Label lbl_lotSeq;
		private System.Windows.Forms.Label lbl_style;
		private System.Windows.Forms.Label lbl_line;
		private System.Windows.Forms.TextBox txt_lotNo;
		private System.Windows.Forms.TextBox txt_lotSeq;
		private System.Windows.Forms.TextBox txt_styleName;
		private System.Windows.Forms.TextBox txt_styleCd;
		private System.Windows.Forms.TextBox txt_factory;
		private System.Windows.Forms.TextBox txt_shipType;
		private System.Windows.Forms.TextBox txt_line;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label lbl_gender;
		private System.Windows.Forms.TextBox txt_gender;
		private System.Windows.Forms.Label lbl_newStyle;
		private System.Windows.Forms.Label lbl_silhouette;
		private System.Windows.Forms.TextBox txt_newStyle;
		private System.Windows.Forms.TextBox txt_division;
		private System.Windows.Forms.Label lbl_destDate;
		private System.Windows.Forms.Label lbl_shipDate;
		private C1.Win.C1List.C1Combo cmb_destDate;
		private System.Windows.Forms.Label lbl_reason;
		private C1.Win.C1List.C1Combo cmb_reason;
		private System.Windows.Forms.Label lbl_qty;
		private System.Windows.Forms.DateTimePicker dpick_shipDate;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.TextBox txt_input;
		private System.Windows.Forms.TextBox txt_qty;
		private System.Windows.Forms.Label label1;

		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.FSP _grid = null;

		#endregion

		#region 생성자 / 소멸자
        
		public Pop_BM_Shipping_Schedule_OA(COM.FSP arg_grid)
		{
			InitializeComponent();

			_grid = arg_grid;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BM_Shipping_Schedule_OA));
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.pnl_head = new System.Windows.Forms.Panel();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dpick_shipDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.cmb_reason = new C1.Win.C1List.C1Combo();
            this.cmb_destDate = new C1.Win.C1List.C1Combo();
            this.lbl_shipDate = new System.Windows.Forms.Label();
            this.lbl_destDate = new System.Windows.Forms.Label();
            this.txt_division = new System.Windows.Forms.TextBox();
            this.txt_newStyle = new System.Windows.Forms.TextBox();
            this.lbl_newStyle = new System.Windows.Forms.Label();
            this.lbl_silhouette = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.txt_shipType = new System.Windows.Forms.TextBox();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.lbl_line = new System.Windows.Forms.Label();
            this.txt_styleName = new System.Windows.Forms.TextBox();
            this.lbl_style = new System.Windows.Forms.Label();
            this.txt_styleCd = new System.Windows.Forms.TextBox();
            this.txt_lotSeq = new System.Windows.Forms.TextBox();
            this.txt_lotNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_shipType = new System.Windows.Forms.Label();
            this.pic_head3 = new System.Windows.Forms.PictureBox();
            this.lbl_lotNo = new System.Windows.Forms.Label();
            this.pic_head4 = new System.Windows.Forms.PictureBox();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.pic_head7 = new System.Windows.Forms.PictureBox();
            this.pic_head2 = new System.Windows.Forms.PictureBox();
            this.pic_head5 = new System.Windows.Forms.PictureBox();
            this.pic_head6 = new System.Windows.Forms.PictureBox();
            this.pic_head1 = new System.Windows.Forms.PictureBox();
            this.lbl_lotSeq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_destDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).BeginInit();
            this.SuspendLayout();
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
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
            // c1Sizer1
            // 
            this.c1Sizer1.AllowDrop = true;
            this.c1Sizer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Sizer1.BackColor = System.Drawing.Color.Transparent;
            this.c1Sizer1.Controls.Add(this.txt_remarks);
            this.c1Sizer1.Controls.Add(this.panel1);
            this.c1Sizer1.Controls.Add(this.pnl_head);
            this.c1Sizer1.GridDefinition = resources.GetString("c1Sizer1.GridDefinition");
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(696, 331);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(12, 213);
            this.txt_remarks.Multiline = true;
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(672, 74);
            this.txt_remarks.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_cancel);
            this.panel1.Controls.Add(this.btn_apply);
            this.panel1.Location = new System.Drawing.Point(12, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 28);
            this.panel1.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(602, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 376;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.Font = new System.Drawing.Font("굴림", 9F);
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(531, 2);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 23);
            this.btn_apply.TabIndex = 376;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            this.btn_apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Down);
            this.btn_apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_click_Effect_Up);
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
            this.pnl_head.Controls.Add(this.txt_qty);
            this.pnl_head.Controls.Add(this.txt_input);
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.dpick_shipDate);
            this.pnl_head.Controls.Add(this.lbl_qty);
            this.pnl_head.Controls.Add(this.lbl_reason);
            this.pnl_head.Controls.Add(this.cmb_reason);
            this.pnl_head.Controls.Add(this.cmb_destDate);
            this.pnl_head.Controls.Add(this.lbl_shipDate);
            this.pnl_head.Controls.Add(this.lbl_destDate);
            this.pnl_head.Controls.Add(this.txt_division);
            this.pnl_head.Controls.Add(this.txt_newStyle);
            this.pnl_head.Controls.Add(this.lbl_newStyle);
            this.pnl_head.Controls.Add(this.lbl_silhouette);
            this.pnl_head.Controls.Add(this.lbl_gender);
            this.pnl_head.Controls.Add(this.txt_gender);
            this.pnl_head.Controls.Add(this.txt_line);
            this.pnl_head.Controls.Add(this.txt_shipType);
            this.pnl_head.Controls.Add(this.txt_factory);
            this.pnl_head.Controls.Add(this.lbl_line);
            this.pnl_head.Controls.Add(this.txt_styleName);
            this.pnl_head.Controls.Add(this.lbl_style);
            this.pnl_head.Controls.Add(this.txt_styleCd);
            this.pnl_head.Controls.Add(this.txt_lotSeq);
            this.pnl_head.Controls.Add(this.txt_lotNo);
            this.pnl_head.Controls.Add(this.label2);
            this.pnl_head.Controls.Add(this.lbl_shipType);
            this.pnl_head.Controls.Add(this.pic_head3);
            this.pnl_head.Controls.Add(this.lbl_lotNo);
            this.pnl_head.Controls.Add(this.pic_head4);
            this.pnl_head.Controls.Add(this.lbl_factory);
            this.pnl_head.Controls.Add(this.pic_head7);
            this.pnl_head.Controls.Add(this.pic_head2);
            this.pnl_head.Controls.Add(this.pic_head5);
            this.pnl_head.Controls.Add(this.pic_head6);
            this.pnl_head.Controls.Add(this.pic_head1);
            this.pnl_head.Controls.Add(this.lbl_lotSeq);
            this.pnl_head.Location = new System.Drawing.Point(12, 4);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(672, 205);
            this.pnl_head.TabIndex = 3;
            // 
            // txt_qty
            // 
            this.txt_qty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_qty.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_qty.Location = new System.Drawing.Point(224, 172);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.ReadOnly = true;
            this.txt_qty.Size = new System.Drawing.Size(95, 21);
            this.txt_qty.TabIndex = 397;
            this.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_input
            // 
            this.txt_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_input.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_input.Location = new System.Drawing.Point(109, 172);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(95, 21);
            this.txt_input.TabIndex = 397;
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_input.TextChanged += new System.EventHandler(this.txt_input_TextChanged);
            this.txt_input.Leave += new System.EventHandler(this.txt_input_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(206, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 402;
            this.label1.Text = "/";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dpick_shipDate
            // 
            this.dpick_shipDate.CustomFormat = "";
            this.dpick_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_shipDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_shipDate.Location = new System.Drawing.Point(431, 150);
            this.dpick_shipDate.Name = "dpick_shipDate";
            this.dpick_shipDate.Size = new System.Drawing.Size(212, 21);
            this.dpick_shipDate.TabIndex = 401;
            // 
            // lbl_qty
            // 
            this.lbl_qty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_qty.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.ImageIndex = 0;
            this.lbl_qty.ImageList = this.img_Label;
            this.lbl_qty.Location = new System.Drawing.Point(8, 172);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(100, 21);
            this.lbl_qty.TabIndex = 398;
            this.lbl_qty.Text = "Qty";
            this.lbl_qty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reason
            // 
            this.lbl_reason.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.ImageIndex = 0;
            this.lbl_reason.ImageList = this.img_Label;
            this.lbl_reason.Location = new System.Drawing.Point(330, 172);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(100, 21);
            this.lbl_reason.TabIndex = 400;
            this.lbl_reason.Text = "Reason";
            this.lbl_reason.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_reason
            // 
            this.cmb_reason.AddItemCols = 0;
            this.cmb_reason.AddItemSeparator = ';';
            this.cmb_reason.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_reason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_reason.Caption = "";
            this.cmb_reason.CaptionHeight = 17;
            this.cmb_reason.CaptionStyle = style17;
            this.cmb_reason.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_reason.ColumnCaptionHeight = 18;
            this.cmb_reason.ColumnFooterHeight = 18;
            this.cmb_reason.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_reason.ContentHeight = 16;
            this.cmb_reason.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_reason.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_reason.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_reason.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_reason.EditorHeight = 16;
            this.cmb_reason.EvenRowStyle = style18;
            this.cmb_reason.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_reason.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_reason.FooterStyle = style19;
            this.cmb_reason.GapHeight = 2;
            this.cmb_reason.HeadingStyle = style20;
            this.cmb_reason.HighLightRowStyle = style21;
            this.cmb_reason.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_reason.ItemHeight = 15;
            this.cmb_reason.Location = new System.Drawing.Point(431, 172);
            this.cmb_reason.MatchEntryTimeout = ((long)(2000));
            this.cmb_reason.MaxDropDownItems = ((short)(5));
            this.cmb_reason.MaxLength = 32767;
            this.cmb_reason.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_reason.Name = "cmb_reason";
            this.cmb_reason.OddRowStyle = style22;
            this.cmb_reason.PartialRightColumn = false;
            this.cmb_reason.PropBag = resources.GetString("cmb_reason.PropBag");
            this.cmb_reason.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_reason.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_reason.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_reason.SelectedStyle = style23;
            this.cmb_reason.Size = new System.Drawing.Size(210, 20);
            this.cmb_reason.Style = style24;
            this.cmb_reason.TabIndex = 399;
            // 
            // cmb_destDate
            // 
            this.cmb_destDate.AddItemCols = 0;
            this.cmb_destDate.AddItemSeparator = ';';
            this.cmb_destDate.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_destDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_destDate.Caption = "";
            this.cmb_destDate.CaptionHeight = 17;
            this.cmb_destDate.CaptionStyle = style25;
            this.cmb_destDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_destDate.ColumnCaptionHeight = 18;
            this.cmb_destDate.ColumnFooterHeight = 18;
            this.cmb_destDate.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_destDate.ContentHeight = 16;
            this.cmb_destDate.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_destDate.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_destDate.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_destDate.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_destDate.EditorHeight = 16;
            this.cmb_destDate.EvenRowStyle = style26;
            this.cmb_destDate.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_destDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_destDate.FooterStyle = style27;
            this.cmb_destDate.GapHeight = 2;
            this.cmb_destDate.HeadingStyle = style28;
            this.cmb_destDate.HighLightRowStyle = style29;
            this.cmb_destDate.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_destDate.ItemHeight = 15;
            this.cmb_destDate.Location = new System.Drawing.Point(109, 150);
            this.cmb_destDate.MatchEntryTimeout = ((long)(2000));
            this.cmb_destDate.MaxDropDownItems = ((short)(5));
            this.cmb_destDate.MaxLength = 32767;
            this.cmb_destDate.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_destDate.Name = "cmb_destDate";
            this.cmb_destDate.OddRowStyle = style30;
            this.cmb_destDate.PartialRightColumn = false;
            this.cmb_destDate.PropBag = resources.GetString("cmb_destDate.PropBag");
            this.cmb_destDate.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_destDate.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_destDate.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_destDate.SelectedStyle = style31;
            this.cmb_destDate.Size = new System.Drawing.Size(210, 20);
            this.cmb_destDate.Style = style32;
            this.cmb_destDate.TabIndex = 399;
            // 
            // lbl_shipDate
            // 
            this.lbl_shipDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipDate.ImageIndex = 0;
            this.lbl_shipDate.ImageList = this.img_Label;
            this.lbl_shipDate.Location = new System.Drawing.Point(330, 150);
            this.lbl_shipDate.Name = "lbl_shipDate";
            this.lbl_shipDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipDate.TabIndex = 400;
            this.lbl_shipDate.Text = "Ship Date";
            this.lbl_shipDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_destDate
            // 
            this.lbl_destDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_destDate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_destDate.ImageIndex = 0;
            this.lbl_destDate.ImageList = this.img_Label;
            this.lbl_destDate.Location = new System.Drawing.Point(8, 150);
            this.lbl_destDate.Name = "lbl_destDate";
            this.lbl_destDate.Size = new System.Drawing.Size(100, 21);
            this.lbl_destDate.TabIndex = 398;
            this.lbl_destDate.Text = "Destination";
            this.lbl_destDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_division
            // 
            this.txt_division.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_division.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_division.Location = new System.Drawing.Point(431, 128);
            this.txt_division.Name = "txt_division";
            this.txt_division.ReadOnly = true;
            this.txt_division.Size = new System.Drawing.Size(210, 21);
            this.txt_division.TabIndex = 397;
            // 
            // txt_newStyle
            // 
            this.txt_newStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_newStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_newStyle.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_newStyle.Location = new System.Drawing.Point(109, 128);
            this.txt_newStyle.Name = "txt_newStyle";
            this.txt_newStyle.ReadOnly = true;
            this.txt_newStyle.Size = new System.Drawing.Size(210, 21);
            this.txt_newStyle.TabIndex = 397;
            // 
            // lbl_newStyle
            // 
            this.lbl_newStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_newStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newStyle.ImageIndex = 0;
            this.lbl_newStyle.ImageList = this.img_Label;
            this.lbl_newStyle.Location = new System.Drawing.Point(8, 128);
            this.lbl_newStyle.Name = "lbl_newStyle";
            this.lbl_newStyle.Size = new System.Drawing.Size(100, 21);
            this.lbl_newStyle.TabIndex = 50;
            this.lbl_newStyle.Text = "New Style";
            this.lbl_newStyle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_silhouette
            // 
            this.lbl_silhouette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_silhouette.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_silhouette.ImageIndex = 0;
            this.lbl_silhouette.ImageList = this.img_Label;
            this.lbl_silhouette.Location = new System.Drawing.Point(330, 128);
            this.lbl_silhouette.Name = "lbl_silhouette";
            this.lbl_silhouette.Size = new System.Drawing.Size(100, 21);
            this.lbl_silhouette.TabIndex = 50;
            this.lbl_silhouette.Text = "Division";
            this.lbl_silhouette.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gender
            // 
            this.lbl_gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_gender.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(8, 106);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 50;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gender.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_gender.Location = new System.Drawing.Point(109, 106);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(210, 21);
            this.txt_gender.TabIndex = 397;
            // 
            // txt_line
            // 
            this.txt_line.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_line.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_line.Location = new System.Drawing.Point(431, 106);
            this.txt_line.Name = "txt_line";
            this.txt_line.ReadOnly = true;
            this.txt_line.Size = new System.Drawing.Size(210, 21);
            this.txt_line.TabIndex = 397;
            // 
            // txt_shipType
            // 
            this.txt_shipType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_shipType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_shipType.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_shipType.Location = new System.Drawing.Point(431, 40);
            this.txt_shipType.Name = "txt_shipType";
            this.txt_shipType.ReadOnly = true;
            this.txt_shipType.Size = new System.Drawing.Size(210, 21);
            this.txt_shipType.TabIndex = 397;
            // 
            // txt_factory
            // 
            this.txt_factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_factory.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_factory.Location = new System.Drawing.Point(109, 40);
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.ReadOnly = true;
            this.txt_factory.Size = new System.Drawing.Size(210, 21);
            this.txt_factory.TabIndex = 397;
            // 
            // lbl_line
            // 
            this.lbl_line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_line.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_line.ImageIndex = 0;
            this.lbl_line.ImageList = this.img_Label;
            this.lbl_line.Location = new System.Drawing.Point(330, 106);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(100, 21);
            this.lbl_line.TabIndex = 50;
            this.lbl_line.Text = "Line";
            this.lbl_line.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleName
            // 
            this.txt_styleName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleName.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleName.Location = new System.Drawing.Point(330, 84);
            this.txt_styleName.Name = "txt_styleName";
            this.txt_styleName.ReadOnly = true;
            this.txt_styleName.Size = new System.Drawing.Size(311, 21);
            this.txt_styleName.TabIndex = 397;
            // 
            // lbl_style
            // 
            this.lbl_style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_style.ImageIndex = 0;
            this.lbl_style.ImageList = this.img_Label;
            this.lbl_style.Location = new System.Drawing.Point(8, 84);
            this.lbl_style.Name = "lbl_style";
            this.lbl_style.Size = new System.Drawing.Size(100, 21);
            this.lbl_style.TabIndex = 50;
            this.lbl_style.Text = "Style";
            this.lbl_style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_styleCd
            // 
            this.txt_styleCd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_styleCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_styleCd.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_styleCd.Location = new System.Drawing.Point(109, 84);
            this.txt_styleCd.Name = "txt_styleCd";
            this.txt_styleCd.ReadOnly = true;
            this.txt_styleCd.Size = new System.Drawing.Size(210, 21);
            this.txt_styleCd.TabIndex = 397;
            // 
            // txt_lotSeq
            // 
            this.txt_lotSeq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lotSeq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotSeq.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lotSeq.Location = new System.Drawing.Point(431, 62);
            this.txt_lotSeq.Name = "txt_lotSeq";
            this.txt_lotSeq.ReadOnly = true;
            this.txt_lotSeq.Size = new System.Drawing.Size(210, 21);
            this.txt_lotSeq.TabIndex = 397;
            // 
            // txt_lotNo
            // 
            this.txt_lotNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lotNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lotNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_lotNo.Location = new System.Drawing.Point(109, 62);
            this.txt_lotNo.Name = "txt_lotNo";
            this.txt_lotNo.ReadOnly = true;
            this.txt_lotNo.Size = new System.Drawing.Size(210, 21);
            this.txt_lotNo.TabIndex = 397;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 30);
            this.label2.TabIndex = 393;
            this.label2.Text = "      Shipping Schedule Info";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipType
            // 
            this.lbl_shipType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipType.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipType.ImageIndex = 0;
            this.lbl_shipType.ImageList = this.img_Label;
            this.lbl_shipType.Location = new System.Drawing.Point(330, 40);
            this.lbl_shipType.Name = "lbl_shipType";
            this.lbl_shipType.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipType.TabIndex = 50;
            this.lbl_shipType.Text = "Ship Type";
            this.lbl_shipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head3
            // 
            this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
            this.pic_head3.Location = new System.Drawing.Point(656, 189);
            this.pic_head3.Name = "pic_head3";
            this.pic_head3.Size = new System.Drawing.Size(16, 16);
            this.pic_head3.TabIndex = 45;
            this.pic_head3.TabStop = false;
            // 
            // lbl_lotNo
            // 
            this.lbl_lotNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lotNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lotNo.ImageIndex = 0;
            this.lbl_lotNo.ImageList = this.img_Label;
            this.lbl_lotNo.Location = new System.Drawing.Point(8, 62);
            this.lbl_lotNo.Name = "lbl_lotNo";
            this.lbl_lotNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_lotNo.TabIndex = 50;
            this.lbl_lotNo.Text = "Lot No";
            this.lbl_lotNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head4
            // 
            this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
            this.pic_head4.Location = new System.Drawing.Point(136, 188);
            this.pic_head4.Name = "pic_head4";
            this.pic_head4.Size = new System.Drawing.Size(632, 18);
            this.pic_head4.TabIndex = 40;
            this.pic_head4.TabStop = false;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 40);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 50;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pic_head7
            // 
            this.pic_head7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pic_head7.Image = ((System.Drawing.Image)(resources.GetObject("pic_head7.Image")));
            this.pic_head7.Location = new System.Drawing.Point(571, 30);
            this.pic_head7.Name = "pic_head7";
            this.pic_head7.Size = new System.Drawing.Size(101, 164);
            this.pic_head7.TabIndex = 46;
            this.pic_head7.TabStop = false;
            // 
            // pic_head2
            // 
            this.pic_head2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head2.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head2.Image = ((System.Drawing.Image)(resources.GetObject("pic_head2.Image")));
            this.pic_head2.Location = new System.Drawing.Point(656, 0);
            this.pic_head2.Name = "pic_head2";
            this.pic_head2.Size = new System.Drawing.Size(16, 32);
            this.pic_head2.TabIndex = 44;
            this.pic_head2.TabStop = false;
            // 
            // pic_head5
            // 
            this.pic_head5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head5.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head5.Image = ((System.Drawing.Image)(resources.GetObject("pic_head5.Image")));
            this.pic_head5.Location = new System.Drawing.Point(0, 189);
            this.pic_head5.Name = "pic_head5";
            this.pic_head5.Size = new System.Drawing.Size(168, 20);
            this.pic_head5.TabIndex = 43;
            this.pic_head5.TabStop = false;
            // 
            // pic_head6
            // 
            this.pic_head6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pic_head6.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head6.Image = ((System.Drawing.Image)(resources.GetObject("pic_head6.Image")));
            this.pic_head6.Location = new System.Drawing.Point(0, 0);
            this.pic_head6.Name = "pic_head6";
            this.pic_head6.Size = new System.Drawing.Size(168, 187);
            this.pic_head6.TabIndex = 41;
            this.pic_head6.TabStop = false;
            // 
            // pic_head1
            // 
            this.pic_head1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_head1.BackColor = System.Drawing.SystemColors.Window;
            this.pic_head1.Image = ((System.Drawing.Image)(resources.GetObject("pic_head1.Image")));
            this.pic_head1.Location = new System.Drawing.Point(160, 0);
            this.pic_head1.Name = "pic_head1";
            this.pic_head1.Size = new System.Drawing.Size(592, 32);
            this.pic_head1.TabIndex = 39;
            this.pic_head1.TabStop = false;
            // 
            // lbl_lotSeq
            // 
            this.lbl_lotSeq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_lotSeq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lotSeq.ImageIndex = 0;
            this.lbl_lotSeq.ImageList = this.img_Label;
            this.lbl_lotSeq.Location = new System.Drawing.Point(330, 62);
            this.lbl_lotSeq.Name = "lbl_lotSeq";
            this.lbl_lotSeq.Size = new System.Drawing.Size(100, 21);
            this.lbl_lotSeq.TabIndex = 50;
            this.lbl_lotSeq.Text = "Lot Seq";
            this.lbl_lotSeq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_BM_Shipping_Schedule_OA
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 367);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Pop_BM_Shipping_Schedule_OA";
            this.Load += new System.EventHandler(this.Pop_BM_Shipping_Schedule_Size_Load);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            this.c1Sizer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_reason)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_destDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_head1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Pop_BM_Shipping_Schedule_Size_Load(object sender, System.EventArgs e)
		{
			this.Init_Form();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			Apply_Process();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void txt_input_Leave(object sender, System.EventArgs e)
		{
			if (txt_input.ForeColor.ToArgb() == Color.Red.ToArgb())
			{
				txt_input.Focus();
				txt_input.ForeColor = Color.Red;
				ClassLib.ComFunction.User_Message("Over Quantity", "Input Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void txt_input_TextChanged(object sender, System.EventArgs e)
		{
			int vInputQty = Convert.ToInt32(COM.ComFunction.Empty_TextBox(txt_input, "0"));
			int vQty = Convert.ToInt32(COM.ComFunction.Empty_TextBox(txt_qty, "0"));

			if (vInputQty > vQty)
			{
				txt_input.ForeColor = Color.Red;
			}
			else
			{
				txt_input.ForeColor = Color.Black;
			}
		}

		#region 버튼효과

		private void btn_click_Effect_Up(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 0;
		}

		private void btn_click_Effect_Down(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			((Label)sender).ImageIndex = 1;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
		{
			this.Text = "OA Process";
            lbl_MainTitle.Text = "OA Process";


            ClassLib.ComFunction.SetLangDic(this);


			// new style
			DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, ClassLib.ComVar.CxYesNo);
			DataRow[] vRows = vDt.Select("COM_VALUE1='" + COM.ComVar.Parameter_PopUp[9] + "'");
			txt_newStyle.Text = ( vRows.Length == 0 ) ? "" : vRows[0][2].ToString();
			vDt.Dispose();

			// division
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM13");
			vRows = vDt.Select("COM_VALUE1='" + COM.ComVar.Parameter_PopUp[12] + "'");
			txt_division.Text = ( vRows.Length == 0 ) ? "" : vRows[0][2].ToString();
			vDt.Dispose();

			// reason
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory, "SBM15");
			COM.ComCtl.Set_ComboList(vDt, cmb_reason, 1, 2, false);
			cmb_reason.SelectedValue = ClassLib.ComFunction.NullToBlank(COM.ComVar.Parameter_PopUp[11]);
			vDt.Dispose();

			// destination
			string vShipNo = COM.ComVar.Parameter_PopUp[14];
			string vShipNoIndex = COM.ComVar.Parameter_PopUp[15];
			string[] vShipNoList = vShipNo.Split(' ');
			string[] vShipNoIndexList = vShipNoIndex.Split(' ');
			ClassLib.ComFunction.CreateComboBox(cmb_destDate, vShipNoIndexList, vShipNoList);
			ClassLib.ComFunction.SetComboStyle(cmb_destDate, new string[]{"Code", "Shipping No"}, new int[]{0, 190}, new bool[]{false, true}, "Shipping No");

			// shipping schedule data set
			bool doEditable = Convert.ToBoolean(COM.ComVar.Parameter_PopUp[17]);	// true : Remark 메뉴, false : Air Flight 메뉴
			
			txt_factory.Text	= COM.ComVar.Parameter_PopUp[0];
			txt_shipType.Text	= COM.ComVar.Parameter_PopUp[2];
			txt_lotNo.Text		= COM.ComVar.Parameter_PopUp[3];
			txt_lotSeq.Text		= COM.ComVar.Parameter_PopUp[4];
			txt_styleCd.Text	= COM.ComVar.Parameter_PopUp[5];
			txt_styleName.Text	= COM.ComVar.Parameter_PopUp[6];
			txt_line.Text		= COM.ComVar.Parameter_PopUp[7];
			txt_gender.Text		= COM.ComVar.Parameter_PopUp[8];
			if (COM.ComVar.Parameter_PopUp[12].ToUpper().Equals("A") || !doEditable)
				txt_division.Text	= "Air Flight ( After MRP Process )";
			else if (COM.ComVar.Parameter_PopUp[12].ToUpper().Equals("a") || !doEditable)
				txt_division.Text	= "Air Flight ( Before MRP Process )";

			// 초기값으로 선택한 날짜를 선택해준다.
			dpick_shipDate.Value = ClassLib.ComFunction.StringToDateTime(COM.ComVar.Parameter_PopUp[13]);

			if (doEditable)
			{
				txt_remarks.Text = COM.ComVar.Parameter_PopUp[10];
			}

			txt_qty.Text = COM.ComVar.Parameter_PopUp[16];
            
			cmb_destDate.ReadOnly	= doEditable;
			dpick_shipDate.Enabled	= !doEditable;
			txt_input.ReadOnly		= doEditable;
            cmb_reason.ReadOnly		= doEditable;

			cmb_destDate.Focus();
		}

		#endregion

		#region 컨트롤 이벤트 처리 메서드

		private void Apply_Process()
		{
			try
			{
				if (txt_input.ForeColor.ToArgb() == Color.Red.ToArgb())
				{
					txt_input.Focus();
					ClassLib.ComFunction.User_Message("Over Quantity", "Input Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int vRow = _grid.Row;
				int vCol = _grid.Col;

				if (!Convert.ToBoolean(COM.ComVar.Parameter_PopUp[17]))
				{
					// 입력 체크
					if (!ClassLib.ComFunction.Essentiality_check(new C1.Win.C1List.C1Combo[]{cmb_destDate, cmb_reason}, new TextBox[]{txt_input}))
						return;

					int vIdx = Convert.ToInt32(cmb_destDate.SelectedValue);

					if (!ClassLib.ComFunction.NullToBlank(_grid[vRow, vIdx]).Equals(""))
					{
						cmb_destDate.Focus();
						ClassLib.ComFunction.User_Message("Exist Already Shipping Data", "Input Qty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					else
					{
						CellRange vSelRange = _grid.Selection;
						int vInQty = Convert.ToInt32(txt_input.Text);

						_grid[vRow, vIdx] = vInQty;

						for (int vCol2 = vSelRange.c1 ; vCol2 <= vSelRange.c2 ; vCol2++)
						{
							int vCurQty = NullToZero(vRow, vCol2);

							if (vCurQty == 0)
								continue;

							if (vCurQty - vInQty < 0) 
							{
								_grid[vRow, vCol2] = 0;
								vInQty -= vCurQty;
							}
							else
							{
								_grid[vRow, vCol2] = vCurQty - vInQty;
								break;
							}
						}

						string vNewStyle = "N";

						if (_grid.Rows[vRow].StyleNew.ForeColor.ToArgb() == Color.Violet.ToArgb())
							vNewStyle = "Y";

						CellRange vRange = _grid.GetCellRange(vRow, vIdx, vRow, vIdx);
						vRange.UserData = new string[]{vNewStyle, txt_remarks.Text, COM.ComFunction.Empty_Combo(cmb_reason, ""), 
														  "a", dpick_shipDate.Text.Replace("-", "")};
						_grid.Select(vRow, vIdx);
						_grid.LeftCol = vIdx - 1;
					}
				}
				else
				{
					CellRange vCurRange = _grid.GetCellRange(vRow, vCol, vRow, vCol);
					string[] vCurData = (string[])vCurRange.UserData;
					vCurData[1] = txt_remarks.Text;
					vCurRange.UserData = vCurData;
				}

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private int NullToZero(int arg_row, int arg_col)
		{
			int vResult = 0;

			if (_grid[arg_row, arg_col] != null)
			{
				if (!_grid[arg_row, arg_col].ToString().Equals(""))
				{					
					vResult = Convert.ToInt32(_grid[arg_row, arg_col]);
				}
			}

			return vResult;
		}

		#endregion

		#endregion

	}
}

