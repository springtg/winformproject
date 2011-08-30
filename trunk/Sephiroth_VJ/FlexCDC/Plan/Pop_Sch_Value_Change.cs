using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
	public class Pop_Sch_Value_Change : COM.PCHWinForm.Pop_Small
    {
        #region Control Setting

        private System.Windows.Forms.Label lbl_value;
		private System.Windows.Forms.Label btn_save;
        private Label btn_cancel;
        public C1.Win.C1List.C1Combo cmb_category;
        public C1.Win.C1List.C1Combo cmb_td;
        private Label lbl_td;
        private Label lbl_gender;
        public C1.Win.C1List.C1Combo cmb_gender;
        private TextBox txt_remark;
        private Label lbl_remarks;
		private System.ComponentModel.IContainer components = null;        

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
        
        #region Designer Setting
        /// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Sch_Value_Change));
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
            this.lbl_value = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.cmb_category = new C1.Win.C1List.C1Combo();
            this.cmb_td = new C1.Win.C1List.C1Combo();
            this.lbl_td = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.cmb_gender = new C1.Win.C1List.C1Combo();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.lbl_remarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_td)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(282, 23);
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
            // lbl_value
            // 
            this.lbl_value.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.ImageIndex = 0;
            this.lbl_value.ImageList = this.img_Label;
            this.lbl_value.Location = new System.Drawing.Point(12, 34);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(100, 21);
            this.lbl_value.TabIndex = 360;
            this.lbl_value.Text = "Category";
            this.lbl_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_save.ImageIndex = 0;
            this.btn_save.ImageList = this.img_Button;
            this.btn_save.Location = new System.Drawing.Point(170, 193);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 24);
            this.btn_save.TabIndex = 362;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(240, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 24);
            this.btn_cancel.TabIndex = 363;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // cmb_category
            // 
            this.cmb_category.AddItemSeparator = ';';
            this.cmb_category.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_category.Caption = "";
            this.cmb_category.CaptionHeight = 17;
            this.cmb_category.CaptionStyle = style25;
            this.cmb_category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_category.ColumnCaptionHeight = 18;
            this.cmb_category.ColumnFooterHeight = 18;
            this.cmb_category.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_category.ContentHeight = 17;
            this.cmb_category.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_category.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_category.EditorFont = new System.Drawing.Font("Verdana", 9F);
            this.cmb_category.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_category.EditorHeight = 17;
            this.cmb_category.EvenRowStyle = style26;
            this.cmb_category.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_category.FooterStyle = style27;
            this.cmb_category.HeadingStyle = style28;
            this.cmb_category.HighLightRowStyle = style29;
            this.cmb_category.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_category.Images"))));
            this.cmb_category.ItemHeight = 15;
            this.cmb_category.Location = new System.Drawing.Point(113, 34);
            this.cmb_category.MatchEntryTimeout = ((long)(2000));
            this.cmb_category.MaxDropDownItems = ((short)(5));
            this.cmb_category.MaxLength = 32767;
            this.cmb_category.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_category.Name = "cmb_category";
            this.cmb_category.OddRowStyle = style30;
            this.cmb_category.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_category.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_category.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_category.SelectedStyle = style31;
            this.cmb_category.Size = new System.Drawing.Size(200, 21);
            this.cmb_category.Style = style32;
            this.cmb_category.TabIndex = 755;
            this.cmb_category.PropBag = resources.GetString("cmb_category.PropBag");
            // 
            // cmb_td
            // 
            this.cmb_td.AddItemSeparator = ';';
            this.cmb_td.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_td.Caption = "";
            this.cmb_td.CaptionHeight = 17;
            this.cmb_td.CaptionStyle = style33;
            this.cmb_td.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_td.ColumnCaptionHeight = 18;
            this.cmb_td.ColumnFooterHeight = 18;
            this.cmb_td.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_td.ContentHeight = 17;
            this.cmb_td.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_td.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_td.EditorFont = new System.Drawing.Font("Verdana", 9F);
            this.cmb_td.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_td.EditorHeight = 17;
            this.cmb_td.EvenRowStyle = style34;
            this.cmb_td.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_td.FooterStyle = style35;
            this.cmb_td.HeadingStyle = style36;
            this.cmb_td.HighLightRowStyle = style37;
            this.cmb_td.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_td.Images"))));
            this.cmb_td.ItemHeight = 15;
            this.cmb_td.Location = new System.Drawing.Point(113, 78);
            this.cmb_td.MatchEntryTimeout = ((long)(2000));
            this.cmb_td.MaxDropDownItems = ((short)(5));
            this.cmb_td.MaxLength = 32767;
            this.cmb_td.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_td.Name = "cmb_td";
            this.cmb_td.OddRowStyle = style38;
            this.cmb_td.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_td.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_td.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_td.SelectedStyle = style39;
            this.cmb_td.Size = new System.Drawing.Size(200, 21);
            this.cmb_td.Style = style40;
            this.cmb_td.TabIndex = 756;
            this.cmb_td.PropBag = resources.GetString("cmb_td.PropBag");
            // 
            // lbl_td
            // 
            this.lbl_td.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_td.ImageIndex = 0;
            this.lbl_td.ImageList = this.img_Label;
            this.lbl_td.Location = new System.Drawing.Point(12, 78);
            this.lbl_td.Name = "lbl_td";
            this.lbl_td.Size = new System.Drawing.Size(100, 21);
            this.lbl_td.TabIndex = 757;
            this.lbl_td.Text = "T/D";
            this.lbl_td.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_gender
            // 
            this.lbl_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gender.ImageIndex = 0;
            this.lbl_gender.ImageList = this.img_Label;
            this.lbl_gender.Location = new System.Drawing.Point(12, 56);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(100, 21);
            this.lbl_gender.TabIndex = 759;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_gender
            // 
            this.cmb_gender.AddItemSeparator = ';';
            this.cmb_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_gender.Caption = "";
            this.cmb_gender.CaptionHeight = 17;
            this.cmb_gender.CaptionStyle = style41;
            this.cmb_gender.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_gender.ColumnCaptionHeight = 18;
            this.cmb_gender.ColumnFooterHeight = 18;
            this.cmb_gender.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_gender.ContentHeight = 17;
            this.cmb_gender.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_gender.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_gender.EditorFont = new System.Drawing.Font("Verdana", 9F);
            this.cmb_gender.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_gender.EditorHeight = 17;
            this.cmb_gender.EvenRowStyle = style42;
            this.cmb_gender.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_gender.FooterStyle = style43;
            this.cmb_gender.HeadingStyle = style44;
            this.cmb_gender.HighLightRowStyle = style45;
            this.cmb_gender.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_gender.Images"))));
            this.cmb_gender.ItemHeight = 15;
            this.cmb_gender.Location = new System.Drawing.Point(113, 56);
            this.cmb_gender.MatchEntryTimeout = ((long)(2000));
            this.cmb_gender.MaxDropDownItems = ((short)(5));
            this.cmb_gender.MaxLength = 32767;
            this.cmb_gender.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.OddRowStyle = style46;
            this.cmb_gender.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_gender.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_gender.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_gender.SelectedStyle = style47;
            this.cmb_gender.Size = new System.Drawing.Size(200, 21);
            this.cmb_gender.Style = style48;
            this.cmb_gender.TabIndex = 758;
            this.cmb_gender.PropBag = resources.GetString("cmb_gender.PropBag");
            // 
            // txt_remark
            // 
            this.txt_remark.BackColor = System.Drawing.SystemColors.Window;
            this.txt_remark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_remark.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_remark.ForeColor = System.Drawing.Color.Black;
            this.txt_remark.Location = new System.Drawing.Point(113, 100);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Multiline = true;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_remark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_remark.Size = new System.Drawing.Size(200, 89);
            this.txt_remark.TabIndex = 2034;
            // 
            // lbl_remarks
            // 
            this.lbl_remarks.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_remarks.ImageIndex = 0;
            this.lbl_remarks.ImageList = this.img_Label;
            this.lbl_remarks.Location = new System.Drawing.Point(12, 100);
            this.lbl_remarks.Name = "lbl_remarks";
            this.lbl_remarks.Size = new System.Drawing.Size(100, 21);
            this.lbl_remarks.TabIndex = 2035;
            this.lbl_remarks.Tag = "21";
            this.lbl_remarks.Text = "Remarks";
            this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Pop_Sch_Value_Change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(316, 220);
            this.Controls.Add(this.txt_remark);
            this.Controls.Add(this.lbl_remarks);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.lbl_td);
            this.Controls.Add(this.cmb_td);
            this.Controls.Add(this.cmb_category);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_value);
            this.Name = "Pop_Sch_Value_Change";
            this.Load += new System.EventHandler(this.Pop_Sch_Value_Change_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.lbl_value, 0);
            this.Controls.SetChildIndex(this.btn_save, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.Controls.SetChildIndex(this.cmb_category, 0);
            this.Controls.SetChildIndex(this.cmb_td, 0);
            this.Controls.SetChildIndex(this.lbl_td, 0);
            this.Controls.SetChildIndex(this.cmb_gender, 0);
            this.Controls.SetChildIndex(this.lbl_gender, 0);
            this.Controls.SetChildIndex(this.lbl_remarks, 0);
            this.Controls.SetChildIndex(this.txt_remark, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_td)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_gender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        #region User Define Variable
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private Plan.Form_Sch_Management_02 _main_form = null;        
        #endregion

        #region Resource
        public Pop_Sch_Value_Change()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        public Pop_Sch_Value_Change(Plan.Form_Sch_Management_02 arg_form)
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

            _main_form = arg_form;            
        }
        #endregion

        #region Form Loading
        private void Pop_Sch_Value_Change_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
        }
        private void Init_Form()
        {
            int sct_row = _main_form.fgrid_main.Selection.r1;
            int sct_col = _main_form.fgrid_main.Selection.c1;

            this.Text = "Category/TD Change";
            this.lbl_MainTitle.Text = "Category/TD Change";

            DataTable dt_ret = SELECT_CATEGORY();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_category, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
                        
            cmb_category.SelectedValue = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY].ToString().Trim();

            //Gendor
            string _factory = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
            string _gender   = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER].ToString().Trim();
            dt_ret = ClassLib.ComVar.Select_ComCode(_factory, ClassLib.ComVar.CxGen);
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_gender, 1, 2, false, false);

            cmb_gender.SelectedValue = _gender;

            dt_ret = SELECT_TD();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_td, 0, 1, false, COM.ComVar.ComboList_Visible.Name);

            cmb_td.SelectedValue = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD].ToString().Trim();

            txt_remark.Text = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS].ToString().Trim();
        }

        private DataTable SELECT_CATEGORY()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_CATEGORY";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        private DataTable SELECT_TD()
        {
            try
            {
                string Proc_Name = "PKG_SXC_SCH_02_SELECT.SELECT_SCH_TD";

                MyOraDB.ReDim_Parameter(2);
                MyOraDB.Process_Name = Proc_Name;

                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

                MyOraDB.Parameter_Values[0] = COM.ComVar.This_Factory;
                MyOraDB.Parameter_Values[1] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet DS_Ret = MyOraDB.Exe_Select_Procedure();

                if (DS_Ret == null) return null;

                return DS_Ret.Tables[Proc_Name];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Button Event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                int sct_row = _main_form.fgrid_main.Selection.r1;

                string[] arg_value = new string[7];

                arg_value[0] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxFACTORY].ToString().Trim();
                arg_value[1] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxMODEL_ID].ToString().Trim();
                arg_value[2] = _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxSRF_NO].ToString().Trim();
                arg_value[3] = cmb_category.SelectedValue.ToString().Trim();
                arg_value[4] = cmb_gender.SelectedValue.ToString().Trim();
                arg_value[5] = cmb_td.SelectedValue.ToString().Trim();
                arg_value[6] = txt_remark.Text.Trim();

                if (UPDATE_SXC_SCH_HEAD_POP(arg_value))
                {
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY]   = arg_value[3];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxCATEGORY_V] = cmb_category.SelectedText.Trim();                    
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxGENDER]     = arg_value[4];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxTD]         = arg_value[5];
                    _main_form.fgrid_main[sct_row, (int)ClassLib.TBSXC_SCH_MANAGEMENT.IxREMARKS]    = arg_value[6];

                    this.Close();
                }
                
            }
            catch
            {

            }
            finally
            {
                
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool UPDATE_SXC_SCH_HEAD_POP(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(8);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_HEAD_POP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_CATEGORY";
                MyOraDB.Parameter_Name[4] = "ARG_GENDER";
                MyOraDB.Parameter_Name[5] = "ARG_TD_CODE";
                MyOraDB.Parameter_Name[6] = "ARG_REMARKS";
                MyOraDB.Parameter_Name[7] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                
                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = arg_value[4];
                MyOraDB.Parameter_Values[5] = arg_value[5];
                MyOraDB.Parameter_Values[6] = arg_value[6];
                MyOraDB.Parameter_Values[7] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion
    }
}



