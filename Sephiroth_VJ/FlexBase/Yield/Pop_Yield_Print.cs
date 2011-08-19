using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexBase.Yield
{
	public class Pop_Yield_Print : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_Style;
		private System.Windows.Forms.Label lbl_Print_Div;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.Label label2;
		private C1.Win.C1List.C1Combo cmb_Size_To;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.TextBox txt_Style_Name;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private C1.Win.C1List.C1Combo cmb_Size_From;
		private C1.Win.C1List.C1Combo cmb_Print_Div;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Print;
		private System.ComponentModel.IContainer components = null;

		public Pop_Yield_Print()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Print));
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style41 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style42 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style43 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style44 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style45 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style46 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style47 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style48 = new C1.Win.C1List.Style();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_Size_From = new C1.Win.C1List.C1Combo();
            this.txt_Style_Name = new System.Windows.Forms.TextBox();
            this.txt_Style_Cd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Print_Div = new C1.Win.C1List.C1Combo();
            this.cmb_Size_To = new C1.Win.C1List.C1Combo();
            this.txt_Factory = new System.Windows.Forms.TextBox();
            this.lbl_Style = new System.Windows.Forms.Label();
            this.lbl_Print_Div = new System.Windows.Forms.Label();
            this.lbl_Factory = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Print = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print_Div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_To)).BeginInit();
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
            this.groupBox1.Controls.Add(this.cmb_Size_From);
            this.groupBox1.Controls.Add(this.txt_Style_Name);
            this.groupBox1.Controls.Add(this.txt_Style_Cd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_Print_Div);
            this.groupBox1.Controls.Add(this.cmb_Size_To);
            this.groupBox1.Controls.Add(this.txt_Factory);
            this.groupBox1.Controls.Add(this.lbl_Style);
            this.groupBox1.Controls.Add(this.lbl_Print_Div);
            this.groupBox1.Controls.Add(this.lbl_Factory);
            this.groupBox1.Location = new System.Drawing.Point(5, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 108);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // cmb_Size_From
            // 
            this.cmb_Size_From.AccessibleDescription = "";
            this.cmb_Size_From.AccessibleName = "";
            this.cmb_Size_From.AddItemCols = 0;
            this.cmb_Size_From.AddItemSeparator = ';';
            this.cmb_Size_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Size_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Size_From.Caption = "";
            this.cmb_Size_From.CaptionHeight = 17;
            this.cmb_Size_From.CaptionStyle = style25;
            this.cmb_Size_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Size_From.ColumnCaptionHeight = 18;
            this.cmb_Size_From.ColumnFooterHeight = 18;
            this.cmb_Size_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Size_From.ContentHeight = 17;
            this.cmb_Size_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Size_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Size_From.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Size_From.EditorHeight = 17;
            this.cmb_Size_From.EvenRowStyle = style26;
            this.cmb_Size_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_From.FooterStyle = style27;
            this.cmb_Size_From.GapHeight = 2;
            this.cmb_Size_From.HeadingStyle = style28;
            this.cmb_Size_From.HighLightRowStyle = style29;
            this.cmb_Size_From.ItemHeight = 15;
            this.cmb_Size_From.Location = new System.Drawing.Point(108, 80);
            this.cmb_Size_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_Size_From.MaxDropDownItems = ((short)(5));
            this.cmb_Size_From.MaxLength = 32767;
            this.cmb_Size_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Size_From.Name = "cmb_Size_From";
            this.cmb_Size_From.OddRowStyle = style30;
            this.cmb_Size_From.PartialRightColumn = false;
            this.cmb_Size_From.PropBag = resources.GetString("cmb_Size_From.PropBag");
            this.cmb_Size_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Size_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Size_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Size_From.SelectedStyle = style31;
            this.cmb_Size_From.Size = new System.Drawing.Size(127, 21);
            this.cmb_Size_From.Style = style32;
            this.cmb_Size_From.TabIndex = 574;
            // 
            // txt_Style_Name
            // 
            this.txt_Style_Name.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Style_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style_Name.Location = new System.Drawing.Point(243, 36);
            this.txt_Style_Name.MaxLength = 18;
            this.txt_Style_Name.Name = "txt_Style_Name";
            this.txt_Style_Name.Size = new System.Drawing.Size(133, 21);
            this.txt_Style_Name.TabIndex = 573;
            // 
            // txt_Style_Cd
            // 
            this.txt_Style_Cd.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Style_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Style_Cd.Location = new System.Drawing.Point(108, 36);
            this.txt_Style_Cd.MaxLength = 18;
            this.txt_Style_Cd.Name = "txt_Style_Cd";
            this.txt_Style_Cd.Size = new System.Drawing.Size(133, 21);
            this.txt_Style_Cd.TabIndex = 572;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(233, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 21);
            this.label2.TabIndex = 570;
            this.label2.Text = "~";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Label;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 569;
            this.label1.Text = "Size";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Print_Div
            // 
            this.cmb_Print_Div.AccessibleDescription = "";
            this.cmb_Print_Div.AccessibleName = "";
            this.cmb_Print_Div.AddItemCols = 0;
            this.cmb_Print_Div.AddItemSeparator = ';';
            this.cmb_Print_Div.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Print_Div.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Print_Div.Caption = "";
            this.cmb_Print_Div.CaptionHeight = 17;
            this.cmb_Print_Div.CaptionStyle = style33;
            this.cmb_Print_Div.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Print_Div.ColumnCaptionHeight = 18;
            this.cmb_Print_Div.ColumnFooterHeight = 18;
            this.cmb_Print_Div.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Print_Div.ContentHeight = 17;
            this.cmb_Print_Div.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Print_Div.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Print_Div.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Print_Div.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Print_Div.EditorHeight = 17;
            this.cmb_Print_Div.EvenRowStyle = style34;
            this.cmb_Print_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Print_Div.FooterStyle = style35;
            this.cmb_Print_Div.GapHeight = 2;
            this.cmb_Print_Div.HeadingStyle = style36;
            this.cmb_Print_Div.HighLightRowStyle = style37;
            this.cmb_Print_Div.ItemHeight = 15;
            this.cmb_Print_Div.Location = new System.Drawing.Point(108, 58);
            this.cmb_Print_Div.MatchEntryTimeout = ((long)(2000));
            this.cmb_Print_Div.MaxDropDownItems = ((short)(5));
            this.cmb_Print_Div.MaxLength = 32767;
            this.cmb_Print_Div.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Print_Div.Name = "cmb_Print_Div";
            this.cmb_Print_Div.OddRowStyle = style38;
            this.cmb_Print_Div.PartialRightColumn = false;
            this.cmb_Print_Div.PropBag = resources.GetString("cmb_Print_Div.PropBag");
            this.cmb_Print_Div.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Print_Div.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Print_Div.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Print_Div.SelectedStyle = style39;
            this.cmb_Print_Div.Size = new System.Drawing.Size(268, 21);
            this.cmb_Print_Div.Style = style40;
            this.cmb_Print_Div.TabIndex = 548;
            // 
            // cmb_Size_To
            // 
            this.cmb_Size_To.AccessibleDescription = "";
            this.cmb_Size_To.AccessibleName = "";
            this.cmb_Size_To.AddItemCols = 0;
            this.cmb_Size_To.AddItemSeparator = ';';
            this.cmb_Size_To.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_Size_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Size_To.Caption = "";
            this.cmb_Size_To.CaptionHeight = 17;
            this.cmb_Size_To.CaptionStyle = style41;
            this.cmb_Size_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Size_To.ColumnCaptionHeight = 18;
            this.cmb_Size_To.ColumnFooterHeight = 18;
            this.cmb_Size_To.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Size_To.ContentHeight = 17;
            this.cmb_Size_To.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Size_To.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Size_To.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_To.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Size_To.EditorHeight = 17;
            this.cmb_Size_To.EvenRowStyle = style42;
            this.cmb_Size_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Size_To.FooterStyle = style43;
            this.cmb_Size_To.GapHeight = 2;
            this.cmb_Size_To.HeadingStyle = style44;
            this.cmb_Size_To.HighLightRowStyle = style45;
            this.cmb_Size_To.ItemHeight = 15;
            this.cmb_Size_To.Location = new System.Drawing.Point(249, 80);
            this.cmb_Size_To.MatchEntryTimeout = ((long)(2000));
            this.cmb_Size_To.MaxDropDownItems = ((short)(5));
            this.cmb_Size_To.MaxLength = 32767;
            this.cmb_Size_To.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Size_To.Name = "cmb_Size_To";
            this.cmb_Size_To.OddRowStyle = style46;
            this.cmb_Size_To.PartialRightColumn = false;
            this.cmb_Size_To.PropBag = resources.GetString("cmb_Size_To.PropBag");
            this.cmb_Size_To.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Size_To.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Size_To.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Size_To.SelectedStyle = style47;
            this.cmb_Size_To.Size = new System.Drawing.Size(127, 21);
            this.cmb_Size_To.Style = style48;
            this.cmb_Size_To.TabIndex = 40;
            // 
            // txt_Factory
            // 
            this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Factory.Location = new System.Drawing.Point(108, 14);
            this.txt_Factory.MaxLength = 100;
            this.txt_Factory.Name = "txt_Factory";
            this.txt_Factory.ReadOnly = true;
            this.txt_Factory.Size = new System.Drawing.Size(268, 21);
            this.txt_Factory.TabIndex = 545;
            this.txt_Factory.TabStop = false;
            // 
            // lbl_Style
            // 
            this.lbl_Style.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Style.ImageIndex = 0;
            this.lbl_Style.ImageList = this.img_Label;
            this.lbl_Style.Location = new System.Drawing.Point(7, 36);
            this.lbl_Style.Name = "lbl_Style";
            this.lbl_Style.Size = new System.Drawing.Size(100, 21);
            this.lbl_Style.TabIndex = 542;
            this.lbl_Style.Text = "Style Code";
            this.lbl_Style.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Print_Div
            // 
            this.lbl_Print_Div.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Print_Div.ImageIndex = 0;
            this.lbl_Print_Div.ImageList = this.img_Label;
            this.lbl_Print_Div.Location = new System.Drawing.Point(7, 58);
            this.lbl_Print_Div.Name = "lbl_Print_Div";
            this.lbl_Print_Div.Size = new System.Drawing.Size(100, 21);
            this.lbl_Print_Div.TabIndex = 541;
            this.lbl_Print_Div.Text = "Print Option";
            this.lbl_Print_Div.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Factory
            // 
            this.lbl_Factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_Factory.ImageIndex = 0;
            this.lbl_Factory.ImageList = this.img_Label;
            this.lbl_Factory.Location = new System.Drawing.Point(7, 14);
            this.lbl_Factory.Name = "lbl_Factory";
            this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_Factory.TabIndex = 540;
            this.lbl_Factory.Text = "Factory";
            this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 0;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(319, 146);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
            this.btn_Cancel.TabIndex = 635;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Print.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Print.ImageIndex = 0;
            this.btn_Print.ImageList = this.img_Button;
            this.btn_Print.Location = new System.Drawing.Point(248, 146);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(70, 23);
            this.btn_Print.TabIndex = 634;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Print.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            this.btn_Print.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Print.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Print.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_Print
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 176);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pop_Yield_Print";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_Print, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Print_Div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Size_To)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의
		string _Prseto  ="",_Gen="";


		#endregion 


		#region 멤버 메쏘드

		private void Init_Form()
		{

			//Title
			this.Text = "Yield Print";
			lbl_MainTitle.Text = "  Yield Print";
			ClassLib.ComFunction.SetLangDic(this);

			txt_Factory.Text     = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Style_Cd.Text    = ClassLib.ComVar.Parameter_PopUp[1];
			txt_Style_Name.Text  = ClassLib.ComVar.Parameter_PopUp[2];
            _Prseto              = ClassLib.ComVar.Parameter_PopUp[3];
			_Gen                 = ClassLib.ComVar.Parameter_PopUp[4];

			// Print Div
			DataTable dt_list;

			dt_list =  ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory,  ClassLib.ComVar.CxFormulaComponent);
			COM.ComCtl.Set_ComboList(dt_list, cmb_Print_Div , 1, 2,  true, true);
			cmb_Print_Div.SelectedIndex    = -1;


			// Size From  ~ To
			dt_list = SelectSizeRun();
			COM.ComCtl.Set_ComboList(dt_list,cmb_Size_From , 0, 0,  false, false);
			cmb_Size_From.SelectedIndex    = 1;
			COM.ComCtl.Set_ComboList(dt_list, cmb_Size_To , 0, 0,  false, false);
			cmb_Size_To.SelectedIndex    = 1;


			dt_list.Dispose();



		}


		#endregion 

		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  

		#region 버튼 이벤트
		private void btn_Print_Click(object sender, System.EventArgs e)
		{
		
			string mrd_Filename = "Form_BC_Yield.mrd" ;
			string Para         = " ";

			#region 출력조건

			int  iCnt  = 5;
			string [] aHead =  new string[iCnt];	


			aHead[0]    = txt_Factory.Text;
			aHead[1]    = txt_Style_Cd.Text;
			aHead[2]    = ClassLib.ComFunction.Empty_Combo(cmb_Print_Div," ");
			aHead[3]    = ClassLib.ComFunction.Empty_Combo(cmb_Size_From," ");
			aHead[4]    = ClassLib.ComFunction.Empty_Combo(cmb_Size_To," ");
			
			#endregion
	
			Para = 	" /rp ";
			for (int i  = 1 ; i<= iCnt ; i++)
			{				
				Para = Para + "[" + aHead[i-1] + "] ";
			}
	
			FlexBase.Report.Form_RdViewer   report = new FlexBase.Report.Form_RdViewer ( mrd_Filename, Para);
			report.Show();	
		}

		
		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		#endregion


		#region DB 컨넥트
		/// <summary>
		/// SelectSizeRun: SelectSizeRun
		/// </summary>
		/// <returns></returns>
		public DataTable SelectSizeRun()
		{

			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret; int iCnt;
			
			iCnt  =  4;
			MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SEM_COMMON.SELECT_SEM_GEN_SIZE";
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_GEN";
			MyOraDB.Parameter_Name[2] = "ARG_PST_YN";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;			
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = txt_Factory.Text;
			MyOraDB.Parameter_Values[1] = _Gen;
			MyOraDB.Parameter_Values[2] = _Prseto;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}



		#endregion

	


	}
}

