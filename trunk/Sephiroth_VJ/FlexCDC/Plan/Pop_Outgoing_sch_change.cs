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
	public class Pop_Plan_sch_change : COM.PCHWinForm.Pop_Small
    {
        #region 컨트롤 정의 및 리소스 정의
        private C1.Win.C1List.C1Combo cmb_Factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label lbl_model;
		private System.Windows.Forms.Label lbl_lot;
		private System.Windows.Forms.Label lbl_prod_ymd;
		private System.Windows.Forms.TextBox txt_lot_no;
		private System.Windows.Forms.TextBox txt_lot_seq;
		private System.Windows.Forms.TextBox txt_model;
		private System.Windows.Forms.DateTimePicker dpk_prod;
		private System.Windows.Forms.Label btn_change;
		private System.ComponentModel.IContainer components = null;

        public Pop_Plan_sch_change()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}
        public Pop_Plan_sch_change(Form_Plan_sch arg_form, string arg_update_type, string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_line_cd, string arg_cmp_cd, string arg_op_cd,
                                   string arg_model,       string arg_cutting,     string arg_ets,     string arg_op_name)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			
			outgoingSch = arg_form;
            update_type = arg_update_type;

            factory = arg_factory;
            lot_no  = arg_lot_no;
            lot_seq = arg_lot_seq;
            day_seq = arg_day_seq;
            line_cd = arg_line_cd;
            cmp_cd  = arg_cmp_cd;
            op_cd   = arg_op_cd;			

			model       = arg_model;
			ets         = arg_ets;
			cutting     = arg_cutting;
			op_name     = arg_op_name;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Plan_sch_change));
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.cmb_Factory = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.txt_lot_no = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.txt_lot_seq = new System.Windows.Forms.TextBox();
            this.lbl_lot = new System.Windows.Forms.Label();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.dpk_prod = new System.Windows.Forms.DateTimePicker();
            this.lbl_prod_ymd = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Label();
            this.dpk_cutting = new System.Windows.Forms.DateTimePicker();
            this.lbl_cutting = new System.Windows.Forms.Label();
            this.txt_day_seq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).BeginInit();
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
            this.lbl_MainTitle.Size = new System.Drawing.Size(384, 23);
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
            // cmb_Factory
            // 
            this.cmb_Factory.AddItemCols = 0;
            this.cmb_Factory.AddItemSeparator = ';';
            this.cmb_Factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Factory.Caption = "";
            this.cmb_Factory.CaptionHeight = 17;
            this.cmb_Factory.CaptionStyle = style1;
            this.cmb_Factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Factory.ColumnCaptionHeight = 18;
            this.cmb_Factory.ColumnFooterHeight = 18;
            this.cmb_Factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Factory.ContentHeight = 17;
            this.cmb_Factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Factory.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Factory.EditorHeight = 17;
            this.cmb_Factory.EvenRowStyle = style2;
            this.cmb_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Factory.FooterStyle = style3;
            this.cmb_Factory.GapHeight = 2;
            this.cmb_Factory.HeadingStyle = style4;
            this.cmb_Factory.HighLightRowStyle = style5;
            this.cmb_Factory.ItemHeight = 15;
            this.cmb_Factory.Location = new System.Drawing.Point(109, 56);
            this.cmb_Factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_Factory.MaxDropDownItems = ((short)(5));
            this.cmb_Factory.MaxLength = 32767;
            this.cmb_Factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Factory.Name = "cmb_Factory";
            this.cmb_Factory.OddRowStyle = style6;
            this.cmb_Factory.PartialRightColumn = false;
            this.cmb_Factory.PropBag = resources.GetString("cmb_Factory.PropBag");
            this.cmb_Factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Factory.SelectedStyle = style7;
            this.cmb_Factory.Size = new System.Drawing.Size(300, 21);
            this.cmb_Factory.Style = style8;
            this.cmb_Factory.TabIndex = 352;
            // 
            // lbl_factory
            // 
            this.lbl_factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 0;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 56);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 351;
            this.lbl_factory.Tag = "0";
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lot_no
            // 
            this.txt_lot_no.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lot_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lot_no.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lot_no.ForeColor = System.Drawing.Color.Black;
            this.txt_lot_no.Location = new System.Drawing.Point(109, 102);
            this.txt_lot_no.MaxLength = 100;
            this.txt_lot_no.Name = "txt_lot_no";
            this.txt_lot_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lot_no.Size = new System.Drawing.Size(234, 20);
            this.txt_lot_no.TabIndex = 356;
            // 
            // lbl_model
            // 
            this.lbl_model.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.ImageIndex = 0;
            this.lbl_model.ImageList = this.img_Label;
            this.lbl_model.Location = new System.Drawing.Point(8, 79);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(100, 21);
            this.lbl_model.TabIndex = 355;
            this.lbl_model.Text = "Dev. Name";
            this.lbl_model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lot_seq
            // 
            this.txt_lot_seq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_lot_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_lot_seq.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_lot_seq.ForeColor = System.Drawing.Color.Black;
            this.txt_lot_seq.Location = new System.Drawing.Point(344, 102);
            this.txt_lot_seq.MaxLength = 100;
            this.txt_lot_seq.Name = "txt_lot_seq";
            this.txt_lot_seq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lot_seq.Size = new System.Drawing.Size(32, 20);
            this.txt_lot_seq.TabIndex = 357;
            // 
            // lbl_lot
            // 
            this.lbl_lot.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lot.ImageIndex = 0;
            this.lbl_lot.ImageList = this.img_Label;
            this.lbl_lot.Location = new System.Drawing.Point(8, 102);
            this.lbl_lot.Name = "lbl_lot";
            this.lbl_lot.Size = new System.Drawing.Size(100, 21);
            this.lbl_lot.TabIndex = 358;
            this.lbl_lot.Text = "Lot";
            this.lbl_lot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_model
            // 
            this.txt_model.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_model.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_model.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_model.ForeColor = System.Drawing.Color.Black;
            this.txt_model.Location = new System.Drawing.Point(109, 79);
            this.txt_model.MaxLength = 100;
            this.txt_model.Name = "txt_model";
            this.txt_model.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_model.Size = new System.Drawing.Size(300, 20);
            this.txt_model.TabIndex = 359;
            // 
            // dpk_prod
            // 
            this.dpk_prod.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_prod.Enabled = false;
            this.dpk_prod.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_prod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_prod.Location = new System.Drawing.Point(310, 124);
            this.dpk_prod.Name = "dpk_prod";
            this.dpk_prod.Size = new System.Drawing.Size(100, 22);
            this.dpk_prod.TabIndex = 361;
            this.dpk_prod.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            this.dpk_prod.CloseUp += new System.EventHandler(this.dpk_prod_CloseUp);
            // 
            // lbl_prod_ymd
            // 
            this.lbl_prod_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prod_ymd.ImageIndex = 0;
            this.lbl_prod_ymd.ImageList = this.img_Label;
            this.lbl_prod_ymd.Location = new System.Drawing.Point(209, 124);
            this.lbl_prod_ymd.Name = "lbl_prod_ymd";
            this.lbl_prod_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_prod_ymd.TabIndex = 360;
            this.lbl_prod_ymd.Text = "Product";
            this.lbl_prod_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_change.ImageIndex = 0;
            this.btn_change.ImageList = this.img_Button;
            this.btn_change.Location = new System.Drawing.Point(337, 32);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(74, 23);
            this.btn_change.TabIndex = 362;
            this.btn_change.Text = "Save";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // dpk_cutting
            // 
            this.dpk_cutting.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_cutting.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpk_cutting.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_cutting.Location = new System.Drawing.Point(109, 124);
            this.dpk_cutting.Name = "dpk_cutting";
            this.dpk_cutting.Size = new System.Drawing.Size(100, 22);
            this.dpk_cutting.TabIndex = 366;
            this.dpk_cutting.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            this.dpk_cutting.CloseUp += new System.EventHandler(this.dpk_cutting_CloseUp);
            // 
            // lbl_cutting
            // 
            this.lbl_cutting.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cutting.ImageIndex = 0;
            this.lbl_cutting.ImageList = this.img_Label;
            this.lbl_cutting.Location = new System.Drawing.Point(8, 124);
            this.lbl_cutting.Name = "lbl_cutting";
            this.lbl_cutting.Size = new System.Drawing.Size(100, 21);
            this.lbl_cutting.TabIndex = 365;
            this.lbl_cutting.Text = "Cutting";
            this.lbl_cutting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_day_seq
            // 
            this.txt_day_seq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_day_seq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_day_seq.Font = new System.Drawing.Font("Verdana", 8F);
            this.txt_day_seq.ForeColor = System.Drawing.Color.Black;
            this.txt_day_seq.Location = new System.Drawing.Point(377, 102);
            this.txt_day_seq.MaxLength = 100;
            this.txt_day_seq.Name = "txt_day_seq";
            this.txt_day_seq.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_day_seq.Size = new System.Drawing.Size(32, 20);
            this.txt_day_seq.TabIndex = 367;
            // 
            // Pop_Plan_sch_change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(418, 154);
            this.Controls.Add(this.txt_day_seq);
            this.Controls.Add(this.dpk_cutting);
            this.Controls.Add(this.lbl_cutting);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dpk_prod);
            this.Controls.Add(this.lbl_prod_ymd);
            this.Controls.Add(this.txt_model);
            this.Controls.Add(this.lbl_lot);
            this.Controls.Add(this.txt_lot_seq);
            this.Controls.Add(this.txt_lot_no);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.cmb_Factory);
            this.Controls.Add(this.lbl_factory);
            this.Name = "Pop_Plan_sch_change";
            this.Load += new System.EventHandler(this.Pop_Plan_sch_change_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.lbl_factory, 0);
            this.Controls.SetChildIndex(this.cmb_Factory, 0);
            this.Controls.SetChildIndex(this.lbl_model, 0);
            this.Controls.SetChildIndex(this.txt_lot_no, 0);
            this.Controls.SetChildIndex(this.txt_lot_seq, 0);
            this.Controls.SetChildIndex(this.lbl_lot, 0);
            this.Controls.SetChildIndex(this.txt_model, 0);
            this.Controls.SetChildIndex(this.lbl_prod_ymd, 0);
            this.Controls.SetChildIndex(this.dpk_prod, 0);
            this.Controls.SetChildIndex(this.btn_change, 0);
            this.Controls.SetChildIndex(this.lbl_cutting, 0);
            this.Controls.SetChildIndex(this.dpk_cutting, 0);
            this.Controls.SetChildIndex(this.txt_day_seq, 0);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Factory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion
        
        #region 사용자 정의 변수
        private Form_Plan_sch outgoingSch = null;
        private string factory = ClassLib.ComVar.This_CDC_Factory;
        private string update_type = "";
        private string model = "";
        private string lot_no = "";
        private string lot_seq = "";
        private string day_seq = "";
        private string status = "";
        private string endday = "";

        private string line_cd = "";
        private string cmp_cd = "";
        private string op_cd = "";

        private string cutting = DateTime.Now.AddDays(-5).ToString("yyyyMMdd");
        private string ets = DateTime.Now.ToString("yyyyMMdd");
        private System.Windows.Forms.DateTimePicker dpk_cutting;
        private System.Windows.Forms.Label lbl_cutting;
        private COM.ComFunction comfunction = new COM.ComFunction();
        private System.Windows.Forms.TextBox txt_day_seq;
        private COM.OraDB OraDB = new COM.OraDB();

        private string op_name = null;

        public bool save_yn = false;
        #endregion

        #region Form Loading 
        private void Pop_Plan_sch_change_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			dpk_cutting.Focus();
		}        	
		private void Init_Form()
		{
			this.Text               = "Lot Information";

			if(update_type == "M")
			{
				this.lbl_MainTitle.Text = "Lot Information(Apply To Model)";
			}
			else
			{
				this.lbl_MainTitle.Text = "Lot Information(Apply To Bom)";
			}
			
			//ClassLib.ComFunction.SetLangDic(this);


			
			//Factory Setting 
			DataTable dt_ret = COM.ComFunction.Select_Factory_List_CDC();
			COM.ComCtl.Set_Factory_List(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Code_Name);
			cmb_Factory.SelectedValue = factory;

			cmb_Factory.Enabled = false;

			txt_model.Text   = model;
			txt_lot_no.Text  = lot_no;
			txt_lot_seq.Text = lot_seq;
			txt_day_seq.Text = day_seq;

            lbl_cutting.Text = op_name;

			dpk_prod.Text = comfunction.ConvertDate2Type(ets);
			dpk_cutting.Text = comfunction.ConvertDate2Type(cutting);

        }

        private DataTable Select_FGA_Date(string arg_factory, string arg_form, string arg_to, string arg_lot_no, string arg_lot_seq, string arg_day_seq)
        {
            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = "pkg_sxg_mps_02_select.select_fga_date";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";
            OraDB.Parameter_Name[1] = "ARG_FROM";
            OraDB.Parameter_Name[2] = "ARG_TO";
            OraDB.Parameter_Name[3] = "ARG_LOT_NO";
            OraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[5] = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[6] = "OUT_CURSOR";

            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6] = (int)OracleType.Cursor;

            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_form;
            OraDB.Parameter_Values[2] = arg_to;
            OraDB.Parameter_Values[3] = arg_lot_no;
            OraDB.Parameter_Values[4] = arg_lot_seq;
            OraDB.Parameter_Values[5] = arg_day_seq;
            OraDB.Parameter_Values[6] = "";

            OraDB.Add_Select_Parameter(true);
            DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            if (DS_Ret == null) return null;

            return DS_Ret.Tables[OraDB.Process_Name];
        }
        #endregion

        #region Conterol Event & Save Data
        private void dpk_prod_CloseUp(object sender, System.EventArgs e)
        {

        }
        private void dpk_cutting_CloseUp(object sender, System.EventArgs e)
        {
            dpk_prod.Text = comfunction.ConvertDate2Type(Select_FGA_Date(cmb_Factory.SelectedValue.ToString(), cutting, dpk_cutting.Value.ToString("yyyyMMdd"), txt_lot_no.Text, txt_lot_seq.Text, txt_day_seq.Text).Rows[0].ItemArray[0].ToString());
        }
        private void btn_change_Click(object sender, System.EventArgs e)
		{
            string holy_flg = Get_holiday().Rows[0].ItemArray[0].ToString();
            string confirm  = Select_confirm_date().Rows[0].ItemArray[0].ToString();
            string now      = DateTime.Now.ToString("yyyyMMdd");
            string set_date = dpk_cutting.Value.ToString("yyyyMMdd");

            if (holy_flg == "N")
            {
                //if (int.Parse(set_date) <= int.Parse(now))
                //{
                //    MessageBox.Show("This date is earlier than Today. Please select another day.");
                //    return;
                //}
                //if (int.Parse(set_date) <= int.Parse(confirm))
                //{
                //    MessageBox.Show("This date is earlier than Confirm Date. Please select another day.");
                //    return;
                //}

                if (update_type.Equals("M"))
                {
                    int sct_row = outgoingSch.flg_sch.Selection.r1;
                    int row_fix = outgoingSch.flg_sch.Rows.Fixed + 1;
                    int row_cnt = outgoingSch.flg_sch.Rows.Count;

                    string srf_no = outgoingSch.flg_sch[sct_row, (int)ClassLib.TBSXO_OUT_SCH.IxSRF_NO].ToString();

                    for (int i = row_fix; i < row_cnt; i++)
                    {
                        string _srf_no = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxSRF_NO].ToString();

                        if (srf_no == _srf_no)
                        {
                            if (outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxSTATUS].ToString().Equals("Y"))
                            {
                                string arg_factory = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxFACTORY].ToString();
                                string arg_lot_no  = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxLOT_NO].ToString();
                                string arg_lot_seq = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxLOT_SEQ].ToString();
                                string arg_day_seq = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxDAY_SEQ].ToString();

                                string arg_line_cd = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxLINE_CD].ToString();
                                string arg_cmp_cd  = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxCMP_CD].ToString();
                                string arg_op_cd   = outgoingSch.flg_sch[i, (int)ClassLib.TBSXO_OUT_SCH.IxOP_CD].ToString();


                                ETS_CHANGE(arg_factory, arg_lot_no, arg_lot_seq, arg_day_seq, arg_line_cd, arg_cmp_cd, arg_op_cd, dpk_cutting.Value.ToString("yyyyMMdd"));
                            }
                        }
                    }
                }
                else
                {
                    ETS_CHANGE(factory, lot_no, lot_seq, day_seq, line_cd, cmp_cd, op_cd, dpk_cutting.Value.ToString("yyyyMMdd"));
                }

                save_yn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("This is Holiday. Please select another day."); 
            }
            
		}

        private DataTable Get_holiday()
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(3);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_02_select.get_holiday";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "arg_date";
            OraDB.Parameter_Name[2] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = dpk_cutting.Value.ToString("yyyyMMdd");
            OraDB.Parameter_Values[2] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private DataTable Select_confirm_date()
        {
            DataSet ds_Search;

            OraDB.ReDim_Parameter(2);

            //01.PROCEDURE명
            OraDB.Process_Name = "pkg_sxg_mps_02_select.get_sxg_confirm_date";

            //02.ARGURMENT명
            OraDB.Parameter_Name[0] = "arg_factory";
            OraDB.Parameter_Name[1] = "out_cursor";

            //03. DATA TYPE 정의
            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.Cursor;

            //04. DATA 정의
            OraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
            OraDB.Parameter_Values[1] = "";


            OraDB.Add_Select_Parameter(true);
            ds_Search = OraDB.Exe_Select_Procedure();

            return ds_Search.Tables[OraDB.Process_Name];

        }
        private void ETS_CHANGE(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_line_cd, string arg_cmp_cd, string arg_op_cd, string arg_dir_ymd)
        {
            OraDB.ReDim_Parameter(7);
            OraDB.Process_Name = "PKG_SXG_MPS_02.update_sxg_mps_lot_daily";

            OraDB.Parameter_Name[0]  = "ARG_FACTORY";
            OraDB.Parameter_Name[1]  = "ARG_LOT_NO";
            OraDB.Parameter_Name[2]  = "ARG_LOT_SEQ";
            OraDB.Parameter_Name[3]  = "ARG_DAY_SEQ";
            OraDB.Parameter_Name[4]  = "ARG_LINE_CD";            
            OraDB.Parameter_Name[5]  = "ARG_DIR_YMD";            
            OraDB.Parameter_Name[6]  = "ARG_UPD_USER";
            

            OraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[4]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[5]  = (int)OracleType.VarChar;
            OraDB.Parameter_Type[6]  = (int)OracleType.VarChar;
           

            OraDB.Parameter_Values[0]  = arg_factory;
            OraDB.Parameter_Values[1]  = arg_lot_no;
            OraDB.Parameter_Values[2]  = arg_lot_seq;
            OraDB.Parameter_Values[3]  = arg_day_seq;
            OraDB.Parameter_Values[4] = "001";// arg_line_cd;            
            OraDB.Parameter_Values[5]  = arg_dir_ymd;          
            OraDB.Parameter_Values[6]  = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();
        }

        private string ETS_CHANGE_PLAN(string arg_factory, string arg_lot_no, string arg_lot_seq, string arg_day_seq, string arg_line_cd, string arg_cmp_cd, string arg_op_cd, string arg_dir_ymd)
        {
            OraDB.ReDim_Parameter(3);
            OraDB.Process_Name = "PKG_SXG_MPS_02.update_sxg_mps_lot_daily_all";

            OraDB.Parameter_Name[0] = "ARG_FACTORY";            
            OraDB.Parameter_Name[1] = "ARG_PLAN_YMD";
            OraDB.Parameter_Name[2] = "ARG_UPD_USER";


            OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
            OraDB.Parameter_Type[2] = (int)OracleType.VarChar;          


            OraDB.Parameter_Values[0] = arg_factory;
            OraDB.Parameter_Values[1] = arg_dir_ymd;
            OraDB.Parameter_Values[2] = COM.ComVar.This_User;

            OraDB.Add_Modify_Parameter(true);
            OraDB.Exe_Modify_Procedure();


            return "N";

            //OraDB.Add_Select_Parameter(true);
            //DataSet DS_Ret = OraDB.Exe_Select_Procedure();

            //if (DS_Ret == null) return null;

            //return DS_Ret.Tables[OraDB.Process_Name];
        }	
        #endregion
    }
}

