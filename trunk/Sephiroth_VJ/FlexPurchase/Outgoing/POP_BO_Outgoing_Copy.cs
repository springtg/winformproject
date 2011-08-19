using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
namespace FlexPurchase.Outgoing
{
	public class POP_BO_Outgoing_Copy : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤정의 및 리소스
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.Windows.Forms.GroupBox grp_group;
		private System.Windows.Forms.DateTimePicker dpick_from;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_factory_From;
		private System.Windows.Forms.Label lbl_workLine_From;
		private System.Windows.Forms.Label lbl_OutProcess_From;
		private System.Windows.Forms.Label lbl_OutDate_From;
		private System.Windows.Forms.Label lbl_OutNo_From;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private C1.Win.C1List.C1Combo cmb_outProcess_From;
		private C1.Win.C1List.C1Combo cmb_workLine_From;
		private System.Windows.Forms.DateTimePicker dpick_To;
		private System.Windows.Forms.Label lbl_OutDate_To;
		private C1.Win.C1List.C1Combo cmb_Factory_From;
		private C1.Win.C1List.C1Combo cmb_OutDivision_From;
		private System.Windows.Forms.Label lbl_OutDivision_From;
		private C1.Win.C1List.C1Combo cmb_OutNo_From;
		private System.Windows.Forms.TextBox txt_OutNo_To;
		private System.Windows.Forms.Label cmb_OutNo_To;
		private System.Windows.Forms.Label btn_Outno;
		private System.ComponentModel.IContainer components = null;

		public POP_BO_Outgoing_Copy()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POP_BO_Outgoing_Copy));
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
            C1.Win.C1List.Style style33 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style34 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style35 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style36 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style37 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style38 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style39 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style40 = new C1.Win.C1List.Style();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.grp_group = new System.Windows.Forms.GroupBox();
            this.btn_Outno = new System.Windows.Forms.Label();
            this.cmb_OutNo_From = new C1.Win.C1List.C1Combo();
            this.lbl_OutNo_From = new System.Windows.Forms.Label();
            this.cmb_Factory_From = new C1.Win.C1List.C1Combo();
            this.lbl_factory_From = new System.Windows.Forms.Label();
            this.lbl_workLine_From = new System.Windows.Forms.Label();
            this.lbl_OutProcess_From = new System.Windows.Forms.Label();
            this.cmb_OutDivision_From = new C1.Win.C1List.C1Combo();
            this.lbl_OutDivision_From = new System.Windows.Forms.Label();
            this.dpick_from = new System.Windows.Forms.DateTimePicker();
            this.cmb_outProcess_From = new C1.Win.C1List.C1Combo();
            this.lbl_OutDate_From = new System.Windows.Forms.Label();
            this.cmb_workLine_From = new C1.Win.C1List.C1Combo();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_OutNo_To = new System.Windows.Forms.TextBox();
            this.cmb_OutNo_To = new System.Windows.Forms.Label();
            this.dpick_To = new System.Windows.Forms.DateTimePicker();
            this.lbl_OutDate_To = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutNo_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDivision_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess_From)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine_From)).BeginInit();
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
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(328, 23);
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
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(280, 288);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(72, 23);
            this.btn_close.TabIndex = 549;
            this.btn_close.Text = "Close";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(208, 288);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(72, 23);
            this.btn_apply.TabIndex = 548;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // grp_group
            // 
            this.grp_group.BackColor = System.Drawing.Color.Transparent;
            this.grp_group.Controls.Add(this.btn_Outno);
            this.grp_group.Controls.Add(this.cmb_OutNo_From);
            this.grp_group.Controls.Add(this.lbl_OutNo_From);
            this.grp_group.Controls.Add(this.cmb_Factory_From);
            this.grp_group.Controls.Add(this.lbl_factory_From);
            this.grp_group.Controls.Add(this.lbl_workLine_From);
            this.grp_group.Controls.Add(this.lbl_OutProcess_From);
            this.grp_group.Controls.Add(this.cmb_OutDivision_From);
            this.grp_group.Controls.Add(this.lbl_OutDivision_From);
            this.grp_group.Controls.Add(this.dpick_from);
            this.grp_group.Controls.Add(this.cmb_outProcess_From);
            this.grp_group.Controls.Add(this.lbl_OutDate_From);
            this.grp_group.Controls.Add(this.cmb_workLine_From);
            this.grp_group.Controls.Add(this.label1);
            this.grp_group.Location = new System.Drawing.Point(8, 40);
            this.grp_group.Name = "grp_group";
            this.grp_group.Size = new System.Drawing.Size(344, 160);
            this.grp_group.TabIndex = 550;
            this.grp_group.TabStop = false;
            this.grp_group.Text = "Original Outgoing";
            // 
            // btn_Outno
            // 
            this.btn_Outno.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Outno.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Outno.ImageIndex = 27;
            this.btn_Outno.ImageList = this.img_SmallButton;
            this.btn_Outno.Location = new System.Drawing.Point(307, 104);
            this.btn_Outno.Name = "btn_Outno";
            this.btn_Outno.Size = new System.Drawing.Size(24, 21);
            this.btn_Outno.TabIndex = 560;
            this.btn_Outno.Tag = "Search";
            this.btn_Outno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Outno.Click += new System.EventHandler(this.btn_Outno_Click);
            // 
            // cmb_OutNo_From
            // 
            this.cmb_OutNo_From.AddItemCols = 0;
            this.cmb_OutNo_From.AddItemSeparator = ';';
            this.cmb_OutNo_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutNo_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutNo_From.Caption = "";
            this.cmb_OutNo_From.CaptionHeight = 17;
            this.cmb_OutNo_From.CaptionStyle = style1;
            this.cmb_OutNo_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutNo_From.ColumnCaptionHeight = 18;
            this.cmb_OutNo_From.ColumnFooterHeight = 18;
            this.cmb_OutNo_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutNo_From.ContentHeight = 16;
            this.cmb_OutNo_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutNo_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutNo_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutNo_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutNo_From.EditorHeight = 16;
            this.cmb_OutNo_From.EvenRowStyle = style2;
            this.cmb_OutNo_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutNo_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutNo_From.FooterStyle = style3;
            this.cmb_OutNo_From.GapHeight = 2;
            this.cmb_OutNo_From.HeadingStyle = style4;
            this.cmb_OutNo_From.HighLightRowStyle = style5;
            this.cmb_OutNo_From.ItemHeight = 15;
            this.cmb_OutNo_From.Location = new System.Drawing.Point(110, 126);
            this.cmb_OutNo_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutNo_From.MaxDropDownItems = ((short)(5));
            this.cmb_OutNo_From.MaxLength = 32767;
            this.cmb_OutNo_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OutNo_From.Name = "cmb_OutNo_From";
            this.cmb_OutNo_From.OddRowStyle = style6;
            this.cmb_OutNo_From.PartialRightColumn = false;
            this.cmb_OutNo_From.PropBag = resources.GetString("cmb_OutNo_From.PropBag");
            this.cmb_OutNo_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutNo_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutNo_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutNo_From.SelectedStyle = style7;
            this.cmb_OutNo_From.Size = new System.Drawing.Size(220, 20);
            this.cmb_OutNo_From.Style = style8;
            this.cmb_OutNo_From.TabIndex = 559;
            // 
            // lbl_OutNo_From
            // 
            this.lbl_OutNo_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutNo_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutNo_From.ImageIndex = 1;
            this.lbl_OutNo_From.ImageList = this.img_Label;
            this.lbl_OutNo_From.Location = new System.Drawing.Point(8, 126);
            this.lbl_OutNo_From.Name = "lbl_OutNo_From";
            this.lbl_OutNo_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutNo_From.TabIndex = 558;
            this.lbl_OutNo_From.Text = "Request No";
            this.lbl_OutNo_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_Factory_From
            // 
            this.cmb_Factory_From.AddItemCols = 0;
            this.cmb_Factory_From.AddItemSeparator = ';';
            this.cmb_Factory_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory_From.Caption = "";
            this.cmb_Factory_From.CaptionHeight = 17;
            this.cmb_Factory_From.CaptionStyle = style9;
            this.cmb_Factory_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory_From.ColumnCaptionHeight = 18;
            this.cmb_Factory_From.ColumnFooterHeight = 18;
            this.cmb_Factory_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory_From.ContentHeight = 16;
            this.cmb_Factory_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_Factory_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory_From.EditorHeight = 16;
            this.cmb_Factory_From.EvenRowStyle = style10;
            this.cmb_Factory_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_Factory_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory_From.FooterStyle = style11;
            this.cmb_Factory_From.GapHeight = 2;
            this.cmb_Factory_From.HeadingStyle = style12;
            this.cmb_Factory_From.HighLightRowStyle = style13;
            this.cmb_Factory_From.ItemHeight = 15;
            this.cmb_Factory_From.Location = new System.Drawing.Point(110, 16);
            this.cmb_Factory_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory_From.MaxDropDownItems = ((short)(5));
            this.cmb_Factory_From.MaxLength = 32767;
            this.cmb_Factory_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory_From.Name = "cmb_Factory_From";
            this.cmb_Factory_From.OddRowStyle = style14;
            this.cmb_Factory_From.PartialRightColumn = false;
            this.cmb_Factory_From.PropBag = resources.GetString("cmb_Factory_From.PropBag");
            this.cmb_Factory_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory_From.SelectedStyle = style15;
            this.cmb_Factory_From.Size = new System.Drawing.Size(220, 20);
            this.cmb_Factory_From.Style = style16;
            this.cmb_Factory_From.TabIndex = 547;
            // 
            // lbl_factory_From
            // 
            this.lbl_factory_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory_From.ImageIndex = 1;
            this.lbl_factory_From.ImageList = this.img_Label;
            this.lbl_factory_From.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory_From.Name = "lbl_factory_From";
            this.lbl_factory_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory_From.TabIndex = 550;
            this.lbl_factory_From.Text = "Factory";
            this.lbl_factory_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_workLine_From
            // 
            this.lbl_workLine_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_workLine_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_workLine_From.ImageIndex = 1;
            this.lbl_workLine_From.ImageList = this.img_Label;
            this.lbl_workLine_From.Location = new System.Drawing.Point(8, 104);
            this.lbl_workLine_From.Name = "lbl_workLine_From";
            this.lbl_workLine_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_workLine_From.TabIndex = 556;
            this.lbl_workLine_From.Text = "Work Line";
            this.lbl_workLine_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_OutProcess_From
            // 
            this.lbl_OutProcess_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutProcess_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutProcess_From.ImageIndex = 1;
            this.lbl_OutProcess_From.ImageList = this.img_Label;
            this.lbl_OutProcess_From.Location = new System.Drawing.Point(8, 82);
            this.lbl_OutProcess_From.Name = "lbl_OutProcess_From";
            this.lbl_OutProcess_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutProcess_From.TabIndex = 553;
            this.lbl_OutProcess_From.Text = "Out Process";
            this.lbl_OutProcess_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_OutDivision_From
            // 
            this.cmb_OutDivision_From.AddItemCols = 0;
            this.cmb_OutDivision_From.AddItemSeparator = ';';
            this.cmb_OutDivision_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_OutDivision_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_OutDivision_From.Caption = "";
            this.cmb_OutDivision_From.CaptionHeight = 17;
            this.cmb_OutDivision_From.CaptionStyle = style17;
            this.cmb_OutDivision_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_OutDivision_From.ColumnCaptionHeight = 18;
            this.cmb_OutDivision_From.ColumnFooterHeight = 18;
            this.cmb_OutDivision_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_OutDivision_From.ContentHeight = 16;
            this.cmb_OutDivision_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_OutDivision_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_OutDivision_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_OutDivision_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_OutDivision_From.EditorHeight = 16;
            this.cmb_OutDivision_From.EvenRowStyle = style18;
            this.cmb_OutDivision_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_OutDivision_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutDivision_From.FooterStyle = style19;
            this.cmb_OutDivision_From.GapHeight = 2;
            this.cmb_OutDivision_From.HeadingStyle = style20;
            this.cmb_OutDivision_From.HighLightRowStyle = style21;
            this.cmb_OutDivision_From.ItemHeight = 15;
            this.cmb_OutDivision_From.Location = new System.Drawing.Point(110, 60);
            this.cmb_OutDivision_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_OutDivision_From.MaxDropDownItems = ((short)(5));
            this.cmb_OutDivision_From.MaxLength = 32767;
            this.cmb_OutDivision_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_OutDivision_From.Name = "cmb_OutDivision_From";
            this.cmb_OutDivision_From.OddRowStyle = style22;
            this.cmb_OutDivision_From.PartialRightColumn = false;
            this.cmb_OutDivision_From.PropBag = resources.GetString("cmb_OutDivision_From.PropBag");
            this.cmb_OutDivision_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_OutDivision_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_OutDivision_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_OutDivision_From.SelectedStyle = style23;
            this.cmb_OutDivision_From.Size = new System.Drawing.Size(220, 20);
            this.cmb_OutDivision_From.Style = style24;
            this.cmb_OutDivision_From.TabIndex = 552;
            // 
            // lbl_OutDivision_From
            // 
            this.lbl_OutDivision_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDivision_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDivision_From.ImageIndex = 1;
            this.lbl_OutDivision_From.ImageList = this.img_Label;
            this.lbl_OutDivision_From.Location = new System.Drawing.Point(8, 60);
            this.lbl_OutDivision_From.Name = "lbl_OutDivision_From";
            this.lbl_OutDivision_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDivision_From.TabIndex = 551;
            this.lbl_OutDivision_From.Text = "Out Division";
            this.lbl_OutDivision_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_from
            // 
            this.dpick_from.CustomFormat = "";
            this.dpick_from.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_from.Location = new System.Drawing.Point(110, 38);
            this.dpick_from.Name = "dpick_from";
            this.dpick_from.Size = new System.Drawing.Size(221, 21);
            this.dpick_from.TabIndex = 548;
            this.dpick_from.ValueChanged += new System.EventHandler(this.dpick_from_ValueChanged);
            // 
            // cmb_outProcess_From
            // 
            this.cmb_outProcess_From.AddItemCols = 0;
            this.cmb_outProcess_From.AddItemSeparator = ';';
            this.cmb_outProcess_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_outProcess_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_outProcess_From.Caption = "";
            this.cmb_outProcess_From.CaptionHeight = 17;
            this.cmb_outProcess_From.CaptionStyle = style25;
            this.cmb_outProcess_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_outProcess_From.ColumnCaptionHeight = 18;
            this.cmb_outProcess_From.ColumnFooterHeight = 18;
            this.cmb_outProcess_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_outProcess_From.ContentHeight = 16;
            this.cmb_outProcess_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_outProcess_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_outProcess_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_outProcess_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_outProcess_From.EditorHeight = 16;
            this.cmb_outProcess_From.EvenRowStyle = style26;
            this.cmb_outProcess_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_outProcess_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_outProcess_From.FooterStyle = style27;
            this.cmb_outProcess_From.GapHeight = 2;
            this.cmb_outProcess_From.HeadingStyle = style28;
            this.cmb_outProcess_From.HighLightRowStyle = style29;
            this.cmb_outProcess_From.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.cmb_outProcess_From.ItemHeight = 15;
            this.cmb_outProcess_From.Location = new System.Drawing.Point(110, 82);
            this.cmb_outProcess_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_outProcess_From.MaxDropDownItems = ((short)(5));
            this.cmb_outProcess_From.MaxLength = 32767;
            this.cmb_outProcess_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_outProcess_From.Name = "cmb_outProcess_From";
            this.cmb_outProcess_From.OddRowStyle = style30;
            this.cmb_outProcess_From.PartialRightColumn = false;
            this.cmb_outProcess_From.PropBag = resources.GetString("cmb_outProcess_From.PropBag");
            this.cmb_outProcess_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_outProcess_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_outProcess_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_outProcess_From.SelectedStyle = style31;
            this.cmb_outProcess_From.Size = new System.Drawing.Size(220, 20);
            this.cmb_outProcess_From.Style = style32;
            this.cmb_outProcess_From.TabIndex = 554;
            this.cmb_outProcess_From.TextChanged += new System.EventHandler(this.cmb_outProcess_From_TextChanged);
            // 
            // lbl_OutDate_From
            // 
            this.lbl_OutDate_From.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDate_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDate_From.ImageIndex = 1;
            this.lbl_OutDate_From.ImageList = this.img_Label;
            this.lbl_OutDate_From.Location = new System.Drawing.Point(8, 38);
            this.lbl_OutDate_From.Name = "lbl_OutDate_From";
            this.lbl_OutDate_From.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDate_From.TabIndex = 549;
            this.lbl_OutDate_From.Text = "Outgoing Date";
            this.lbl_OutDate_From.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_workLine_From
            // 
            this.cmb_workLine_From.AddItemCols = 0;
            this.cmb_workLine_From.AddItemSeparator = ';';
            this.cmb_workLine_From.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_workLine_From.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_workLine_From.Caption = "";
            this.cmb_workLine_From.CaptionHeight = 17;
            this.cmb_workLine_From.CaptionStyle = style33;
            this.cmb_workLine_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_workLine_From.ColumnCaptionHeight = 18;
            this.cmb_workLine_From.ColumnFooterHeight = 18;
            this.cmb_workLine_From.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_workLine_From.ContentHeight = 16;
            this.cmb_workLine_From.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_workLine_From.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_workLine_From.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_workLine_From.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_workLine_From.EditorHeight = 16;
            this.cmb_workLine_From.EvenRowStyle = style34;
            this.cmb_workLine_From.FlatStyle = C1.Win.C1List.FlatModeEnum.System;
            this.cmb_workLine_From.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_workLine_From.FooterStyle = style35;
            this.cmb_workLine_From.GapHeight = 2;
            this.cmb_workLine_From.HeadingStyle = style36;
            this.cmb_workLine_From.HighLightRowStyle = style37;
            this.cmb_workLine_From.ItemHeight = 15;
            this.cmb_workLine_From.Location = new System.Drawing.Point(110, 104);
            this.cmb_workLine_From.MatchEntryTimeout = ((long)(2000));
            this.cmb_workLine_From.MaxDropDownItems = ((short)(5));
            this.cmb_workLine_From.MaxLength = 32767;
            this.cmb_workLine_From.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_workLine_From.Name = "cmb_workLine_From";
            this.cmb_workLine_From.OddRowStyle = style38;
            this.cmb_workLine_From.PartialRightColumn = false;
            this.cmb_workLine_From.PropBag = resources.GetString("cmb_workLine_From.PropBag");
            this.cmb_workLine_From.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_workLine_From.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_workLine_From.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_workLine_From.SelectedStyle = style39;
            this.cmb_workLine_From.Size = new System.Drawing.Size(198, 20);
            this.cmb_workLine_From.Style = style40;
            this.cmb_workLine_From.TabIndex = 555;
            this.cmb_workLine_From.TextChanged += new System.EventHandler(this.cmb_workLine_From_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label1.ImageIndex = 0;
            this.label1.ImageList = this.img_Button;
            this.label1.Location = new System.Drawing.Point(576, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 557;
            this.label1.Text = "Apply";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_OutNo_To);
            this.groupBox1.Controls.Add(this.cmb_OutNo_To);
            this.groupBox1.Controls.Add(this.dpick_To);
            this.groupBox1.Controls.Add(this.lbl_OutDate_To);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(8, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 72);
            this.groupBox1.TabIndex = 551;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target Outgoing";
            // 
            // txt_OutNo_To
            // 
            this.txt_OutNo_To.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OutNo_To.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_OutNo_To.Location = new System.Drawing.Point(110, 38);
            this.txt_OutNo_To.MaxLength = 10;
            this.txt_OutNo_To.Name = "txt_OutNo_To";
            this.txt_OutNo_To.Size = new System.Drawing.Size(216, 21);
            this.txt_OutNo_To.TabIndex = 559;
            // 
            // cmb_OutNo_To
            // 
            this.cmb_OutNo_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.cmb_OutNo_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_OutNo_To.ImageIndex = 1;
            this.cmb_OutNo_To.ImageList = this.img_Label;
            this.cmb_OutNo_To.Location = new System.Drawing.Point(8, 38);
            this.cmb_OutNo_To.Name = "cmb_OutNo_To";
            this.cmb_OutNo_To.Size = new System.Drawing.Size(100, 21);
            this.cmb_OutNo_To.TabIndex = 558;
            this.cmb_OutNo_To.Text = "Request No";
            this.cmb_OutNo_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dpick_To
            // 
            this.dpick_To.CustomFormat = "";
            this.dpick_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpick_To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpick_To.Location = new System.Drawing.Point(110, 16);
            this.dpick_To.Name = "dpick_To";
            this.dpick_To.Size = new System.Drawing.Size(221, 21);
            this.dpick_To.TabIndex = 548;
            // 
            // lbl_OutDate_To
            // 
            this.lbl_OutDate_To.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_OutDate_To.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_OutDate_To.ImageIndex = 1;
            this.lbl_OutDate_To.ImageList = this.img_Label;
            this.lbl_OutDate_To.Location = new System.Drawing.Point(8, 16);
            this.lbl_OutDate_To.Name = "lbl_OutDate_To";
            this.lbl_OutDate_To.Size = new System.Drawing.Size(100, 21);
            this.lbl_OutDate_To.TabIndex = 549;
            this.lbl_OutDate_To.Text = "Outgoing Date";
            this.lbl_OutDate_To.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.label7.ImageIndex = 0;
            this.label7.ImageList = this.img_Button;
            this.label7.Location = new System.Drawing.Point(576, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 23);
            this.label7.TabIndex = 557;
            this.label7.Text = "Apply";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // POP_BO_Outgoing_Copy
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(362, 320);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grp_group);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Name = "POP_BO_Outgoing_Copy";
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.Controls.SetChildIndex(this.grp_group, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.grp_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutNo_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_OutDivision_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_outProcess_From)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_workLine_From)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 변수

		private COM.OraDB MyOraDB   = new COM.OraDB();

		#endregion 
		
		#region 버튼이벤트
		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		
		private void btn_apply_Click(object sender, System.EventArgs e)
		{   
			
			try
			{ 
				if ((Check_Apply())  != true) 
					return;

				DialogResult result = new DialogResult(); 

				result = ClassLib.ComFunction.User_Message("Do you want to Save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
				if ( result.ToString() == "Yes")
				{
					DataTable vDt;

					vDt  = SAVE_SBO_OUT_COPY();
					txt_OutNo_To.Text = vDt.Rows[0].ItemArray[0].ToString();
				}
				
	

				ClassLib.ComVar.Job_Line    =  cmb_workLine_From.SelectedValue.ToString();
				ClassLib.ComVar.Job_Process =  cmb_outProcess_From.SelectedValue.ToString();
				ClassLib.ComVar.Job_No      =  txt_OutNo_To.Text ;

				this.Close();
				
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.ToString());
				
			}	


		}


		private void cmb_workLine_From_TextChanged(object sender, System.EventArgs e)
		{
		    Search_Outgoing_No();
		}


		private void btn_Outno_Click(object sender, System.EventArgs e)
		{
			DataTable vDt;

			vDt = Select_Out_No();
			COM.ComCtl.Set_ComboList(vDt, cmb_OutNo_From, 0, 1, false);
			cmb_OutNo_From.SelectedIndex = -1;
			vDt.Dispose() ;
		}




		#endregion 

		#region 공통메쏘드

		private void Init_Form()
        {

            this.Text = "Outgoing Copy";
            lbl_MainTitle.Text = "Outgoing Copy";
            ClassLib.ComFunction.SetLangDic(this);

			// Factory Combobox Setting
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_Factory_From, 0, 1, false);
			vDt.Dispose();
			cmb_Factory_From.SelectedValue = ClassLib.ComVar.This_Factory;


			// out_div set    cmb_outDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
			COM.ComCtl.Set_ComboList(vDt, cmb_OutDivision_From  , 1, 2, false, 56,0);
			cmb_OutDivision_From.SelectedIndex = -1;

			//	cmb_outProcess
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Process_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_outProcess_From, 0, 1, false);
			cmb_outProcess_From.SelectedIndex = -1;
			vDt.Dispose() ;


			// cmb_workLine
			vDt = FlexPurchase.ClassLib.ComFunction.Select_Work_Line_List(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_workLine_From, 0, 1, false);
			cmb_workLine_From.SelectedIndex = -1;
			vDt.Dispose() ;


			// out_div set    cmb_outDiv
			vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBO02");
			COM.ComCtl.Set_ComboList(vDt, cmb_OutDivision_From , 1, 2, false, 56,0);
			cmb_OutDivision_From.SelectedValue   = 3;
			cmb_OutDivision_From.Enabled = false;
			vDt.Dispose() ;
			
			Search_Outgoing_No();


		}

		private bool Check_Apply()
		{


			if ((cmb_Factory_From.SelectedIndex       ==  -1) ||
				(cmb_OutDivision_From.SelectedIndex   ==  -1) ||
				(cmb_OutNo_From.SelectedIndex         ==  -1) ||
				(cmb_outProcess_From.SelectedIndex    ==  -1) ||
				(cmb_workLine_From.SelectedIndex      ==  -1) )
			{
				ClassLib.ComFunction.User_Message(ClassLib.ComVar.MgsWrongInput);
				return false;
			}

            DataTable vDt;
			vDt  = Check_New_Out_No();

			if ((vDt.Rows.Count != 0 ) )
			{
				ClassLib.ComFunction.User_Message("Theere is data already..");
				return false;
			}


			return true;


		}
		#endregion 

		#region DB관리
		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable Select_Out_No()
		{
			
			
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_DIFECTIVE.SELECT_SBO_OUT_PROCESS_NO";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY_FROM";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_LINE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_DIVISION_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS_FROM";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory_From, " ");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_workLine_From , " ");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_OutDivision_From  , " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_outProcess_From, " ");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];			


		}



		/// <summary>
		/// SELECT_SBB_REMAINDER : 
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable Check_New_Out_No()
		{
			
			
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(6);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_DIFECTIVE.SELECT_SBO_CHECK_COPY";


			MyOraDB.Parameter_Name[0] = "ARG_FACTORY_FROM";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_LINE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_DIVISION_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS_FROM";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory_From, " ");
			MyOraDB.Parameter_Values[1] = dpick_To.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_workLine_From , " ");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_OutDivision_From  , " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_outProcess_From, " ");
			MyOraDB.Parameter_Values[5] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];

			


		}



		/// <summary>
		/// SAVE_SBO_OUT_COPY :  불출 복사
		/// </summary>
		public DataTable SAVE_SBO_OUT_COPY()
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(9);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBO_OUTGOING_DIFECTIVE.SAVE_SBO_OUT_COPY";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY_FROM";
			MyOraDB.Parameter_Name[1] = "ARG_OUT_YMD_FROM";
			MyOraDB.Parameter_Name[2] = "ARG_OUT_LINE_FROM";
			MyOraDB.Parameter_Name[3] = "ARG_OUT_DIVISION_FROM";
			MyOraDB.Parameter_Name[4] = "ARG_OUT_PROCESS_FROM";
			MyOraDB.Parameter_Name[5] = "ARG_OUT_NO_FROM";
			MyOraDB.Parameter_Name[6] = "ARG_OUT_YMD_TO";
			MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";
			MyOraDB.Parameter_Name[8] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Factory_From, " ");
			MyOraDB.Parameter_Values[1] = dpick_from.Text.Replace("-","");
			MyOraDB.Parameter_Values[2] = COM.ComFunction.Empty_Combo(cmb_workLine_From , " ");
			MyOraDB.Parameter_Values[3] = COM.ComFunction.Empty_Combo(cmb_OutDivision_From  , " ");
			MyOraDB.Parameter_Values[4] = COM.ComFunction.Empty_Combo(cmb_outProcess_From, " ");
			MyOraDB.Parameter_Values[5] = COM.ComFunction.Empty_Combo(cmb_OutNo_From  , " ");
			MyOraDB.Parameter_Values[6] = dpick_To.Text.Replace("-","");
            MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;
			MyOraDB.Parameter_Values[8] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];

		}


		#endregion  

		private void dpick_from_ValueChanged(object sender, System.EventArgs e)
		{
			Search_Outgoing_No();
		}

		private void Search_Outgoing_No()
		{ 	
			DataTable vDt;

			vDt = Select_Out_No();
			COM.ComCtl.Set_ComboList(vDt, cmb_OutNo_From, 0, 1, false);
			cmb_OutNo_From.SelectedIndex = -1;
			vDt.Dispose() ;

		}

		private void cmb_outProcess_From_TextChanged(object sender, System.EventArgs e)
		{
			Search_Outgoing_No();
		}


 
	}
}

