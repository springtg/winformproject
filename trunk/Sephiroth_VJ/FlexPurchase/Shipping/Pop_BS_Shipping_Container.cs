using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;

namespace FlexPurchase.Shipping
{
	public class Pop_BS_Shipping_Container : COM.PCHWinForm.Pop_Small
	{
		private System.Windows.Forms.Label lbl_shipYmd;
		private System.Windows.Forms.Label lbl_shipFactory;
		private C1.Win.C1List.C1Combo cmb_shipFactory;
		private System.Windows.Forms.Label lbl_seq;
		private System.Windows.Forms.Label lbl_containerNo;
		private C1.Win.C1List.C1Combo cmb_contUnit;
		private System.Windows.Forms.Label lbl_unit;
		private System.Windows.Forms.Label lbl_description;
		private System.Windows.Forms.Label lbl_sealNo;
		private System.Windows.Forms.Label lbl_outYmd;
		private System.Windows.Forms.Label lbl_rtaYmd;
		private C1.Win.C1List.C1Combo cmb_division;
		private System.Windows.Forms.Label lbl_division;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.Label btn_cancel;
		private System.Windows.Forms.DateTimePicker dt_shipYmd;
		private System.Windows.Forms.TextBox txt_seq;
		private System.Windows.Forms.TextBox txt_description;
		private System.Windows.Forms.TextBox txt_sealNo;
		private System.Windows.Forms.DateTimePicker dt_rtaYmd;
		private System.Windows.Forms.DateTimePicker dt_outYmd;
		private System.Windows.Forms.TextBox txt_contNo;
		private System.Windows.Forms.Label btn_virtual;
		private System.ComponentModel.IContainer components = null;

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB = new COM.OraDB();
		private string[] _data = new string[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxMaxCt + 1];
		private System.EventHandler _txtContNoEvent = null;
		private System.EventHandler _cmbContNoEvent = null;
		private C1.Win.C1List.C1Combo cmb_contNo;
		private System.Windows.Forms.GroupBox groupBox1;
		private bool isRun = true;

		#endregion

		public Pop_BS_Shipping_Container()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_BS_Shipping_Container));
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
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.lbl_shipYmd = new System.Windows.Forms.Label();
            this.lbl_shipFactory = new System.Windows.Forms.Label();
            this.cmb_shipFactory = new C1.Win.C1List.C1Combo();
            this.lbl_seq = new System.Windows.Forms.Label();
            this.lbl_containerNo = new System.Windows.Forms.Label();
            this.cmb_contUnit = new C1.Win.C1List.C1Combo();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_sealNo = new System.Windows.Forms.Label();
            this.lbl_outYmd = new System.Windows.Forms.Label();
            this.lbl_rtaYmd = new System.Windows.Forms.Label();
            this.cmb_division = new C1.Win.C1List.C1Combo();
            this.lbl_division = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.dt_shipYmd = new System.Windows.Forms.DateTimePicker();
            this.txt_seq = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.txt_sealNo = new System.Windows.Forms.TextBox();
            this.dt_rtaYmd = new System.Windows.Forms.DateTimePicker();
            this.dt_outYmd = new System.Windows.Forms.DateTimePicker();
            this.txt_contNo = new System.Windows.Forms.TextBox();
            this.btn_virtual = new System.Windows.Forms.Label();
            this.cmb_contNo = new C1.Win.C1List.C1Combo();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).BeginInit();
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
            // lbl_shipYmd
            // 
            this.lbl_shipYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipYmd.ImageIndex = 0;
            this.lbl_shipYmd.ImageList = this.img_Label;
            this.lbl_shipYmd.Location = new System.Drawing.Point(8, 16);
            this.lbl_shipYmd.Name = "lbl_shipYmd";
            this.lbl_shipYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipYmd.TabIndex = 202;
            this.lbl_shipYmd.Text = "Ship Date";
            this.lbl_shipYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_shipFactory
            // 
            this.lbl_shipFactory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_shipFactory.ImageIndex = 0;
            this.lbl_shipFactory.ImageList = this.img_Label;
            this.lbl_shipFactory.Location = new System.Drawing.Point(8, 38);
            this.lbl_shipFactory.Name = "lbl_shipFactory";
            this.lbl_shipFactory.Size = new System.Drawing.Size(100, 21);
            this.lbl_shipFactory.TabIndex = 202;
            this.lbl_shipFactory.Text = "Factory";
            this.lbl_shipFactory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_shipFactory
            // 
            this.cmb_shipFactory.AddItemCols = 0;
            this.cmb_shipFactory.AddItemSeparator = ';';
            this.cmb_shipFactory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_shipFactory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_shipFactory.Caption = "";
            this.cmb_shipFactory.CaptionHeight = 17;
            this.cmb_shipFactory.CaptionStyle = style1;
            this.cmb_shipFactory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_shipFactory.ColumnCaptionHeight = 18;
            this.cmb_shipFactory.ColumnFooterHeight = 18;
            this.cmb_shipFactory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_shipFactory.ContentHeight = 16;
            this.cmb_shipFactory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_shipFactory.EditorBackColor = System.Drawing.SystemColors.Control;
            this.cmb_shipFactory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_shipFactory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_shipFactory.EditorHeight = 16;
            this.cmb_shipFactory.EvenRowStyle = style2;
            this.cmb_shipFactory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_shipFactory.FooterStyle = style3;
            this.cmb_shipFactory.GapHeight = 2;
            this.cmb_shipFactory.HeadingStyle = style4;
            this.cmb_shipFactory.HighLightRowStyle = style5;
            this.cmb_shipFactory.ItemHeight = 15;
            this.cmb_shipFactory.Location = new System.Drawing.Point(109, 38);
            this.cmb_shipFactory.MatchEntryTimeout = ((long)(2000));
            this.cmb_shipFactory.MaxDropDownItems = ((short)(5));
            this.cmb_shipFactory.MaxLength = 32767;
            this.cmb_shipFactory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_shipFactory.Name = "cmb_shipFactory";
            this.cmb_shipFactory.OddRowStyle = style6;
            this.cmb_shipFactory.PartialRightColumn = false;
            this.cmb_shipFactory.PropBag = resources.GetString("cmb_shipFactory.PropBag");
            this.cmb_shipFactory.ReadOnly = true;
            this.cmb_shipFactory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_shipFactory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_shipFactory.RowSubDividerColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_shipFactory.SelectedStyle = style7;
            this.cmb_shipFactory.Size = new System.Drawing.Size(220, 20);
            this.cmb_shipFactory.Style = style8;
            this.cmb_shipFactory.TabIndex = 10;
            // 
            // lbl_seq
            // 
            this.lbl_seq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_seq.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seq.ImageIndex = 0;
            this.lbl_seq.ImageList = this.img_Label;
            this.lbl_seq.Location = new System.Drawing.Point(8, 60);
            this.lbl_seq.Name = "lbl_seq";
            this.lbl_seq.Size = new System.Drawing.Size(100, 21);
            this.lbl_seq.TabIndex = 202;
            this.lbl_seq.Text = "Seq";
            this.lbl_seq.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_containerNo
            // 
            this.lbl_containerNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_containerNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_containerNo.ImageIndex = 0;
            this.lbl_containerNo.ImageList = this.img_Label;
            this.lbl_containerNo.Location = new System.Drawing.Point(8, 82);
            this.lbl_containerNo.Name = "lbl_containerNo";
            this.lbl_containerNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_containerNo.TabIndex = 202;
            this.lbl_containerNo.Text = "Container No";
            this.lbl_containerNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_contUnit
            // 
            this.cmb_contUnit.AddItemCols = 0;
            this.cmb_contUnit.AddItemSeparator = ';';
            this.cmb_contUnit.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contUnit.Caption = "";
            this.cmb_contUnit.CaptionHeight = 17;
            this.cmb_contUnit.CaptionStyle = style9;
            this.cmb_contUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_contUnit.ColumnCaptionHeight = 18;
            this.cmb_contUnit.ColumnFooterHeight = 18;
            this.cmb_contUnit.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_contUnit.ContentHeight = 16;
            this.cmb_contUnit.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_contUnit.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_contUnit.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_contUnit.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_contUnit.EditorHeight = 16;
            this.cmb_contUnit.EvenRowStyle = style10;
            this.cmb_contUnit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contUnit.FooterStyle = style11;
            this.cmb_contUnit.GapHeight = 2;
            this.cmb_contUnit.HeadingStyle = style12;
            this.cmb_contUnit.HighLightRowStyle = style13;
            this.cmb_contUnit.ItemHeight = 15;
            this.cmb_contUnit.Location = new System.Drawing.Point(109, 104);
            this.cmb_contUnit.MatchEntryTimeout = ((long)(2000));
            this.cmb_contUnit.MaxDropDownItems = ((short)(5));
            this.cmb_contUnit.MaxLength = 32767;
            this.cmb_contUnit.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contUnit.Name = "cmb_contUnit";
            this.cmb_contUnit.OddRowStyle = style14;
            this.cmb_contUnit.PartialRightColumn = false;
            this.cmb_contUnit.PropBag = resources.GetString("cmb_contUnit.PropBag");
            this.cmb_contUnit.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contUnit.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contUnit.SelectedStyle = style15;
            this.cmb_contUnit.Size = new System.Drawing.Size(220, 20);
            this.cmb_contUnit.Style = style16;
            this.cmb_contUnit.TabIndex = 3;
            this.cmb_contUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_contUnit_KeyPress);
            // 
            // lbl_unit
            // 
            this.lbl_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_unit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unit.ImageIndex = 0;
            this.lbl_unit.ImageList = this.img_Label;
            this.lbl_unit.Location = new System.Drawing.Point(8, 104);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(100, 21);
            this.lbl_unit.TabIndex = 202;
            this.lbl_unit.Text = "Unit";
            this.lbl_unit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_description
            // 
            this.lbl_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_description.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ImageIndex = 0;
            this.lbl_description.ImageList = this.img_Label;
            this.lbl_description.Location = new System.Drawing.Point(8, 214);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(100, 21);
            this.lbl_description.TabIndex = 202;
            this.lbl_description.Text = "Description";
            this.lbl_description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_sealNo
            // 
            this.lbl_sealNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_sealNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sealNo.ImageIndex = 0;
            this.lbl_sealNo.ImageList = this.img_Label;
            this.lbl_sealNo.Location = new System.Drawing.Point(8, 126);
            this.lbl_sealNo.Name = "lbl_sealNo";
            this.lbl_sealNo.Size = new System.Drawing.Size(100, 21);
            this.lbl_sealNo.TabIndex = 202;
            this.lbl_sealNo.Text = "Seal No";
            this.lbl_sealNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_outYmd
            // 
            this.lbl_outYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outYmd.ImageIndex = 0;
            this.lbl_outYmd.ImageList = this.img_Label;
            this.lbl_outYmd.Location = new System.Drawing.Point(8, 148);
            this.lbl_outYmd.Name = "lbl_outYmd";
            this.lbl_outYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_outYmd.TabIndex = 202;
            this.lbl_outYmd.Text = "Onboard Date";
            this.lbl_outYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_rtaYmd
            // 
            this.lbl_rtaYmd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_rtaYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rtaYmd.ImageIndex = 0;
            this.lbl_rtaYmd.ImageList = this.img_Label;
            this.lbl_rtaYmd.Location = new System.Drawing.Point(8, 170);
            this.lbl_rtaYmd.Name = "lbl_rtaYmd";
            this.lbl_rtaYmd.Size = new System.Drawing.Size(100, 21);
            this.lbl_rtaYmd.TabIndex = 202;
            this.lbl_rtaYmd.Text = "R.T.A";
            this.lbl_rtaYmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_division
            // 
            this.cmb_division.AddItemCols = 0;
            this.cmb_division.AddItemSeparator = ';';
            this.cmb_division.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_division.Caption = "";
            this.cmb_division.CaptionHeight = 17;
            this.cmb_division.CaptionStyle = style17;
            this.cmb_division.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_division.ColumnCaptionHeight = 18;
            this.cmb_division.ColumnFooterHeight = 18;
            this.cmb_division.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_division.ContentHeight = 16;
            this.cmb_division.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_division.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_division.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_division.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_division.EditorHeight = 16;
            this.cmb_division.EvenRowStyle = style18;
            this.cmb_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_division.FooterStyle = style19;
            this.cmb_division.GapHeight = 2;
            this.cmb_division.HeadingStyle = style20;
            this.cmb_division.HighLightRowStyle = style21;
            this.cmb_division.ItemHeight = 15;
            this.cmb_division.Location = new System.Drawing.Point(109, 192);
            this.cmb_division.MatchEntryTimeout = ((long)(2000));
            this.cmb_division.MaxDropDownItems = ((short)(5));
            this.cmb_division.MaxLength = 32767;
            this.cmb_division.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_division.Name = "cmb_division";
            this.cmb_division.OddRowStyle = style22;
            this.cmb_division.PartialRightColumn = false;
            this.cmb_division.PropBag = resources.GetString("cmb_division.PropBag");
            this.cmb_division.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_division.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_division.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_division.SelectedStyle = style23;
            this.cmb_division.Size = new System.Drawing.Size(220, 20);
            this.cmb_division.Style = style24;
            this.cmb_division.TabIndex = 7;
            this.cmb_division.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_division_KeyPress);
            // 
            // lbl_division
            // 
            this.lbl_division.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_division.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_division.ImageIndex = 0;
            this.lbl_division.ImageList = this.img_Label;
            this.lbl_division.Location = new System.Drawing.Point(8, 192);
            this.lbl_division.Name = "lbl_division";
            this.lbl_division.Size = new System.Drawing.Size(100, 21);
            this.lbl_division.TabIndex = 202;
            this.lbl_division.Text = "Division";
            this.lbl_division.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_apply
            // 
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(234, 288);
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
            this.btn_cancel.Location = new System.Drawing.Point(305, 288);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            this.btn_cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // dt_shipYmd
            // 
            this.dt_shipYmd.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dt_shipYmd.Checked = false;
            this.dt_shipYmd.CustomFormat = "";
            this.dt_shipYmd.Enabled = false;
            this.dt_shipYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_shipYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_shipYmd.Location = new System.Drawing.Point(109, 16);
            this.dt_shipYmd.Name = "dt_shipYmd";
            this.dt_shipYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_shipYmd.Size = new System.Drawing.Size(222, 21);
            this.dt_shipYmd.TabIndex = 9;
            // 
            // txt_seq
            // 
            this.txt_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_seq.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_seq.Location = new System.Drawing.Point(109, 60);
            this.txt_seq.MaxLength = 20;
            this.txt_seq.Name = "txt_seq";
            this.txt_seq.Size = new System.Drawing.Size(220, 21);
            this.txt_seq.TabIndex = 11;
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.SystemColors.Window;
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_description.Location = new System.Drawing.Point(109, 214);
            this.txt_description.MaxLength = 60;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(220, 21);
            this.txt_description.TabIndex = 8;
            this.txt_description.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_description_KeyPress);
            // 
            // txt_sealNo
            // 
            this.txt_sealNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_sealNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sealNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_sealNo.Location = new System.Drawing.Point(109, 126);
            this.txt_sealNo.MaxLength = 10;
            this.txt_sealNo.Name = "txt_sealNo";
            this.txt_sealNo.Size = new System.Drawing.Size(220, 21);
            this.txt_sealNo.TabIndex = 4;
            this.txt_sealNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sealNo_KeyPress);
            // 
            // dt_rtaYmd
            // 
            this.dt_rtaYmd.Checked = false;
            this.dt_rtaYmd.CustomFormat = "";
            this.dt_rtaYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_rtaYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_rtaYmd.Location = new System.Drawing.Point(109, 170);
            this.dt_rtaYmd.Name = "dt_rtaYmd";
            this.dt_rtaYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_rtaYmd.Size = new System.Drawing.Size(222, 21);
            this.dt_rtaYmd.TabIndex = 6;
            this.dt_rtaYmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dt_rtaYmd_KeyPress);
            // 
            // dt_outYmd
            // 
            this.dt_outYmd.Checked = false;
            this.dt_outYmd.CustomFormat = "";
            this.dt_outYmd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_outYmd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_outYmd.Location = new System.Drawing.Point(109, 148);
            this.dt_outYmd.Name = "dt_outYmd";
            this.dt_outYmd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dt_outYmd.Size = new System.Drawing.Size(222, 21);
            this.dt_outYmd.TabIndex = 5;
            this.dt_outYmd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dt_outYmd_KeyPress);
            // 
            // txt_contNo
            // 
            this.txt_contNo.BackColor = System.Drawing.SystemColors.Window;
            this.txt_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_contNo.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_contNo.Location = new System.Drawing.Point(109, 82);
            this.txt_contNo.MaxLength = 11;
            this.txt_contNo.Name = "txt_contNo";
            this.txt_contNo.Size = new System.Drawing.Size(89, 21);
            this.txt_contNo.TabIndex = 1;
            this.txt_contNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contNo_KeyPress);
            // 
            // btn_virtual
            // 
            this.btn_virtual.BackColor = System.Drawing.Color.Transparent;
            this.btn_virtual.ImageIndex = 0;
            this.btn_virtual.ImageList = this.img_Action;
            this.btn_virtual.Location = new System.Drawing.Point(334, 83);
            this.btn_virtual.Name = "btn_virtual";
            this.btn_virtual.Size = new System.Drawing.Size(21, 21);
            this.btn_virtual.TabIndex = 208;
            this.btn_virtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_virtual.Click += new System.EventHandler(this.btn_virtual_Click);
            // 
            // cmb_contNo
            // 
            this.cmb_contNo.AddItemCols = 0;
            this.cmb_contNo.AddItemSeparator = ';';
            this.cmb_contNo.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_contNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_contNo.Caption = "";
            this.cmb_contNo.CaptionHeight = 17;
            this.cmb_contNo.CaptionStyle = style25;
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
            this.cmb_contNo.EvenRowStyle = style26;
            this.cmb_contNo.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contNo.FooterStyle = style27;
            this.cmb_contNo.GapHeight = 2;
            this.cmb_contNo.HeadingStyle = style28;
            this.cmb_contNo.HighLightRowStyle = style29;
            this.cmb_contNo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmb_contNo.ItemHeight = 15;
            this.cmb_contNo.Location = new System.Drawing.Point(199, 82);
            this.cmb_contNo.MatchEntryTimeout = ((long)(2000));
            this.cmb_contNo.MaxDropDownItems = ((short)(5));
            this.cmb_contNo.MaxLength = 32767;
            this.cmb_contNo.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_contNo.Name = "cmb_contNo";
            this.cmb_contNo.OddRowStyle = style30;
            this.cmb_contNo.PartialRightColumn = false;
            this.cmb_contNo.PropBag = resources.GetString("cmb_contNo.PropBag");
            this.cmb_contNo.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_contNo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_contNo.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_contNo.SelectedStyle = style31;
            this.cmb_contNo.Size = new System.Drawing.Size(130, 20);
            this.cmb_contNo.Style = style32;
            this.cmb_contNo.TabIndex = 215;
            this.cmb_contNo.SelectedValueChanged += new System.EventHandler(this.cmb_contNo_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_virtual);
            this.groupBox1.Controls.Add(this.lbl_sealNo);
            this.groupBox1.Controls.Add(this.lbl_unit);
            this.groupBox1.Controls.Add(this.lbl_shipFactory);
            this.groupBox1.Controls.Add(this.lbl_outYmd);
            this.groupBox1.Controls.Add(this.cmb_shipFactory);
            this.groupBox1.Controls.Add(this.lbl_containerNo);
            this.groupBox1.Controls.Add(this.cmb_contNo);
            this.groupBox1.Controls.Add(this.cmb_contUnit);
            this.groupBox1.Controls.Add(this.lbl_description);
            this.groupBox1.Controls.Add(this.dt_shipYmd);
            this.groupBox1.Controls.Add(this.txt_description);
            this.groupBox1.Controls.Add(this.lbl_rtaYmd);
            this.groupBox1.Controls.Add(this.txt_seq);
            this.groupBox1.Controls.Add(this.lbl_seq);
            this.groupBox1.Controls.Add(this.cmb_division);
            this.groupBox1.Controls.Add(this.txt_sealNo);
            this.groupBox1.Controls.Add(this.dt_rtaYmd);
            this.groupBox1.Controls.Add(this.lbl_division);
            this.groupBox1.Controls.Add(this.dt_outYmd);
            this.groupBox1.Controls.Add(this.lbl_shipYmd);
            this.groupBox1.Controls.Add(this.txt_contNo);
            this.groupBox1.Location = new System.Drawing.Point(8, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 248);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            // 
            // Pop_BS_Shipping_Container
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(384, 323);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_apply);
            this.Name = "Pop_BS_Shipping_Container";
            this.Load += new System.EventHandler(this.Pop_BS_New_Ship_Container_Load);
            this.Closed += new System.EventHandler(this.Pop_BS_New_Ship_Container_Closed);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_shipFactory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_contNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 컨트롤 이벤트 처리

		private void Pop_BS_New_Ship_Container_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Pop_BS_New_Ship_Container_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);		
		}

		private void cmb_contNo_SelectedValueChanged(object sender, System.EventArgs e)
		{
			this.Cmb_ContNoSelectedValueChangedProcess();
		}

		private void btn_virtual_Click(object sender, System.EventArgs e)
		{
            this.Btn_VirtualContainerClickProcess();
		}

		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Btn_ApplyClickProcess();
		}

		private void btn_cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#region 입력이동

		private void txt_contNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				cmb_contNo.Focus();
				this.Txt_ContNoTextChangedProcess();
			}
		}

		private void cmb_contNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				cmb_contUnit.Focus();
		}

		private void cmb_contUnit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				txt_sealNo.Focus();
		}

		private void txt_sealNo_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void dt_outYmd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);
		}

		private void dt_rtaYmd_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			ClassLib.ComFunction.KeyEnter_Tab(e);		
		}

		private void cmb_division_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				txt_description.Focus();
		}

		private void txt_description_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
				Btn_ApplyClickProcess();
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

		#endregion

		#region 공통 메서드

		// Get data from control
		private string[] GetData(string arg_div)
		{
			_data[0]												= arg_div;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD]	= dt_shipYmd.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT]	= COM.ComFunction.Empty_Combo(cmb_shipFactory, "");
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ]	= txt_seq.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO]		= txt_contNo.Text;
            _data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT]	= COM.ComFunction.Empty_Combo(cmb_contUnit, "");
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC]	= txt_description.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO]		= txt_sealNo.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD]		= dt_outYmd.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD]		= dt_rtaYmd.Text;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS]		= COM.ComFunction.Empty_Combo(cmb_division, "");//.GetItemText(cmb_division.SelectedIndex, 1).Replace("All", "");
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEND_CHK]	= "";
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEND_YMD]	= "";
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxUPD_USER]	= COM.ComVar.This_User;
			_data[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxUPD_YMD]		= "";

			return _data;
		}

		// Set data to control from datatable
		private void SetDataFromDataTable(DataTable arg_dt)
		{
			try
			{
				if (arg_dt.Rows.Count > 0)
				{
					dt_shipYmd.Value				= StringToDateTime(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD - 1].ToString());
					cmb_shipFactory.SelectedValue	= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT - 1].ToString();
					txt_seq.Text					= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ - 1].ToString();
					txt_contNo.Text					= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO - 1].ToString();
					this.Txt_ContNoTextChangedProcess();
					cmb_contNo.SelectedValue = arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO - 1].ToString();
					cmb_contUnit.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT - 1].ToString();
					txt_description.Text			= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC - 1].ToString();
					txt_sealNo.Text					= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO - 1].ToString();
					dt_outYmd.Value					= StringToDateTime(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD - 1].ToString());
					dt_rtaYmd.Value					= StringToDateTime(arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD - 1].ToString());
					cmb_division.SelectedValue		= arg_dt.Rows[0].ItemArray[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS - 1].ToString();
				}
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Set data to control from parameter_popup
		private void SetDataFromParameter()
		{
			try
			{
				dt_shipYmd.Value				= StringToDateTime(COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD]);
				cmb_shipFactory.SelectedValue	= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_FACT];
				txt_seq.Text					= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_SEQ];
				txt_contNo.Text					= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO];
				this.Txt_ContNoTextChangedProcess();
				cmb_contUnit.SelectedValue		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_UNIT];
				txt_description.Text			= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_DESC];
				txt_sealNo.Text					= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxSEAL_NO];
				dt_outYmd.Value					= StringToDateTime(COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxOUT_YMD]);
				dt_rtaYmd.Value					= StringToDateTime(COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxRTA_YMD]);
				cmb_division.SelectedValue		= COM.ComVar.Parameter_PopUp[(int)ClassLib.TBSBS_SHIP_CONTAINER.IxREMARKS];
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Etc_Mcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// string(yyyy-mm-dd) to DateTime
		private DateTime StringToDateTime(string strDate)
		{
			if (strDate != null || !strDate.Equals(""))
				return new DateTime(Convert.ToInt32(strDate.Substring(0, 4)), Convert.ToInt32(strDate.Substring(5, 2)), Convert.ToInt32(strDate.Substring(8, 2)));
			else
				return System.DateTime.Now;
		}

        // create combo
		public void CreateComboBox(C1.Win.C1List.C1Combo arg_cmb, string[] code, string[] name)
		{
			int i;
			
			try
			{
				//arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.Normal; 
				arg_cmb.ClearItems();
				arg_cmb.DataMode = C1.Win.C1List.DataModeEnum.AddItem; 

				//arg_cmb.AddItemTitles("Container;Unit"); 
				arg_cmb.Columns[0].Caption = "Container";
				arg_cmb.Columns[1].Caption = "Unit";
			
				arg_cmb.ValueMember = "Container";
				arg_cmb.DisplayMember = "Container";
			
				for(i = 0 ; i < code.Length ; i++) 
					arg_cmb.AddItem(code[i] + ";" + name[i]);
		
				arg_cmb.SelectedIndex = -1;

				arg_cmb.MaxDropDownItems = 10;
				arg_cmb.Splits[0].DisplayColumns[0].Width = 130;
				arg_cmb.Splits[0].DisplayColumns[1].Width = 70;
				cmb_contNo.DropDownWidth = 220;

				arg_cmb.ExtendRightColumn = true;
				arg_cmb.CellTips = C1.Win.C1List.CellTipEnum.Anchored;
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message.ToString(),"Set_ComboList_AddItem",MessageBoxButtons.OK,MessageBoxIcon.Error );
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
			this.Text = "Shipping Container";
            lbl_MainTitle.Text = "Shipping Container";
            ClassLib.ComFunction.SetLangDic(this);
			
			DataTable vDt = null;

			// Ship Factory Setting
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt,  cmb_shipFactory,  0,  1,  false);
			cmb_shipFactory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose();

			// Cont Unit Setting
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBC10");
			COM.ComCtl.Set_ComboList(vDt, cmb_contUnit, 1, 1, false);
			cmb_contUnit.Splits[0].DisplayColumns["Name"].Visible = false;
			cmb_contUnit.SelectedIndex = 0;
			vDt.Dispose();

			// Division
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBS10");
			COM.ComCtl.Set_ComboList(vDt, cmb_division, 1, 2, true);
			cmb_division.SelectedIndex = 0;
			vDt.Dispose();

			this.txt_contNo.TextChanged += _txtContNoEvent;
			_cmbContNoEvent = new System.EventHandler(this.cmb_contNo_SelectedValueChanged);

			if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Update))
				SetDataFromDataTable(SELECT_SBS_SHIP_CONT(COM.ComVar.Parameter_PopUp[1], COM.ComVar.Parameter_PopUp[2], COM.ComVar.Parameter_PopUp[3]));
			else if (COM.ComVar.Parameter_PopUp != null && COM.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Insert))
				SetDataFromParameter();
			else
			{
				dt_shipYmd.Enabled		 = true;
				dt_shipYmd.Value		 = (DateTime)ClassLib.ComVar.Parameter_PopUp_Object[1];
				dt_outYmd.Value			 = (DateTime)ClassLib.ComVar.Parameter_PopUp_Object[1];
				dt_rtaYmd.Value			 = (DateTime)ClassLib.ComVar.Parameter_PopUp_Object[1];
				cmb_shipFactory.ReadOnly = false;
				cmb_shipFactory.SelectedValue = COM.ComVar.Parameter_PopUp[0];
			}
		}

		private void Txt_ContNoTextChangedProcess()
		{
			try
			{
				if (isRun)
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

		private void Cmb_ContNoSelectedValueChangedProcess()
		{
			try
			{
				this.txt_contNo.TextChanged -= _txtContNoEvent;

				isRun = false;
				txt_contNo.Text				= cmb_contNo.GetItemText(cmb_contNo.SelectedIndex, 0);
				cmb_contUnit.SelectedValue	= cmb_contNo.GetItemText(cmb_contNo.SelectedIndex, 1);
				isRun = true;

				this.txt_contNo.TextChanged += _txtContNoEvent;
			}
			catch //(Exception ex)
			{
                //ClassLib.ComFunction.User_Message(ex.Message, "ContNoSelected", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_VirtualContainerClickProcess()
		{
			try
			{		
				this.cmb_contNo.SelectedValueChanged -= _cmbContNoEvent;
				this.txt_contNo.TextChanged -= _txtContNoEvent;

				isRun = false;
				txt_contNo.Text = "";

				DataTable vDt = new DataTable("Comoo List");
				DataRow	newrow = null;
				vDt.Columns.Add(new DataColumn("Code", Type.GetType("System.String")));
				vDt.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
				
				for(int i = 0 ; i < 5 ; i++)
				{
					newrow = vDt.NewRow();
					newrow["Code"] = "Virtual000" + (i + 1);
					newrow["Name"] = "40FT";
					vDt.Rows.Add(newrow);   
				}

				COM.ComCtl.Set_ComboList(vDt, cmb_contNo, 0, 1, false);
				ClassLib.ComFunction.SetComboStyle(cmb_contNo, new string[]{"Container", "Unit"}, new int[]{130, 70}, new bool[]{true, true}, "Container");
				cmb_contNo.DropDownWidth = 220;
				vDt.Dispose();

				isRun = true;

				this.txt_contNo.TextChanged += _txtContNoEvent;
				this.cmb_contNo.SelectedValueChanged += _cmbContNoEvent;
			}
			catch (Exception ex)
			{
				//ClassLib.ComFunction.User_Message(ex.Message, "VirtualContainer", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Btn_ApplyClickProcess()
		{
			COM.SSP vGrid = (COM.SSP)ClassLib.ComVar.Parameter_PopUp_Object[0];
			int vContNoCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxCONT_NO;
			int vShipYmdCol = (int)ClassLib.TBSBS_SHIP_CONTAINER.IxSHIP_YMD;
			string vContNo = ClassLib.ComFunction.Empty_Combo(cmb_contNo, "");
			string vShipYmd = dt_shipYmd.Text;

			if (!ClassLib.ComVar.Parameter_PopUp[0].Equals(ClassLib.ComVar.Update))
			{
				if (!ClassLib.ComFunction.CheckCellData(vGrid, new int[]{vContNoCol, vShipYmdCol}, new string[]{vContNo, vShipYmd}, 0))
				{
					if (txt_seq.Text.Equals(""))
						COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Insert);
					else
						COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Update);

					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			else
			{
				if (txt_seq.Text.Equals(""))
					COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Insert);
				else
					COM.ComVar.Parameter_PopUp = GetData(ClassLib.ComVar.Update);

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
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
		public DataTable SELECT_SBS_SHIP_CONT(string arg_ship_ymd, string arg_ship_fact, string arg_ship_seq)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(4);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBS_SHIP_CONTAINER.SELECT_SBS_SHIP_CONT";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_SHIP_YMD";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_FACT";
			MyOraDB.Parameter_Name[2] = "ARG_SHIP_SEQ";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_ship_ymd;
			MyOraDB.Parameter_Values[1] = arg_ship_fact;
			MyOraDB.Parameter_Values[2] = arg_ship_seq;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
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

		#region 정합성 체크


		#endregion

	}
}

