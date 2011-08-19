using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Windows.Forms;
using FarPoint.Win.Spread.CellType;

namespace FlexMRP.MRP
{
	public class Form_BM_Shipping_Parameter : COM.PCHWinForm.Pop_Medium
	{
		#region 디자이너에서 생성한 변수

		private C1.Win.C1Sizer.C1Sizer c1Sizer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label btn_new;
		private System.Windows.Forms.Label btn_save;
		private C1.Win.C1List.C1Combo cmb_factory;
		private System.Windows.Forms.Label lbl_factory;
		private System.Windows.Forms.Label btn_search;
		private System.ComponentModel.IContainer components = null;

		#endregion

		private COM.SSP spd_main;
		private FarPoint.Win.Spread.SheetView spd_main_Sheet1;



		private COM.OraDB MyOraDB = new COM.OraDB();
		private FarPoint.Win.Spread.SheetView _mainSheet;
		private int _factoryCol = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxFACTORY;
		private int _paraCodeCol = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxPARA_CD;
		private int _paraNameCol = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxPARA_NAME;
		private int _paraValue1Col = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxPARA_VALUE1;
		private System.Windows.Forms.Label lbl_comCode;
		private C1.Win.C1List.C1Combo cmb_paraCode;
		private int _remarksCol = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxREMARKS;

		#region 생성자 / 소멸자

		public Form_BM_Shipping_Parameter()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BM_Shipping_Parameter));
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
            this.spd_main = new COM.SSP();
            this.spd_main_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_new = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Label();
            this.cmb_factory = new C1.Win.C1List.C1Combo();
            this.cmb_paraCode = new C1.Win.C1List.C1Combo();
            this.lbl_factory = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Label();
            this.lbl_comCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_paraCode)).BeginInit();
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
            this.c1Sizer1.Controls.Add(this.spd_main);
            this.c1Sizer1.Controls.Add(this.groupBox1);
            this.c1Sizer1.GridDefinition = "16.588785046729:False:False;78.7383177570093:False:False;0.934579439252336:False:" +
                "True;\t0.576368876080692:False:True;96.5417867435159:False:False;0.57636887608069" +
                "2:False:True;";
            this.c1Sizer1.Location = new System.Drawing.Point(0, 40);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(694, 428);
            this.c1Sizer1.TabIndex = 26;
            this.c1Sizer1.TabStop = false;
            // 
            // spd_main
            // 
            this.spd_main.Location = new System.Drawing.Point(12, 79);
            this.spd_main.Name = "spd_main";
            this.spd_main.Sheets.Add(this.spd_main_Sheet1);
            this.spd_main.Size = new System.Drawing.Size(670, 337);
            this.spd_main.TabIndex = 31;
            this.spd_main.EditModeOn += new System.EventHandler(this.spd_main_EditModeOn);
            this.spd_main.EditChange += new FarPoint.Win.Spread.EditorNotifyEventHandler(this.spd_main_EditChange);
            // 
            // spd_main_Sheet1
            // 
            this.spd_main_Sheet1.SheetName = "Sheet1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_new);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.cmb_factory);
            this.groupBox1.Controls.Add(this.cmb_paraCode);
            this.groupBox1.Controls.Add(this.lbl_factory);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.lbl_comCode);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 71);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // btn_new
            // 
            this.btn_new.ImageIndex = 15;
            this.btn_new.ImageList = this.img_SmallButton;
            this.btn_new.Location = new System.Drawing.Point(610, 38);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(21, 21);
            this.btn_new.TabIndex = 186;
            this.btn_new.Tag = "Search";
            this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            this.btn_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseDown);
            this.btn_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_new_MouseUp);
            // 
            // btn_save
            // 
            this.btn_save.ImageIndex = 25;
            this.btn_save.ImageList = this.img_SmallButton;
            this.btn_save.Location = new System.Drawing.Point(632, 38);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(21, 21);
            this.btn_save.TabIndex = 185;
            this.btn_save.Tag = "Search";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            this.btn_save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseDown);
            this.btn_save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_save_MouseUp);
            // 
            // cmb_factory
            // 
            this.cmb_factory.AddItemCols = 0;
            this.cmb_factory.AddItemSeparator = ';';
            this.cmb_factory.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_factory.Caption = "";
            this.cmb_factory.CaptionHeight = 17;
            this.cmb_factory.CaptionStyle = style17;
            this.cmb_factory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_factory.ColumnCaptionHeight = 18;
            this.cmb_factory.ColumnFooterHeight = 18;
            this.cmb_factory.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_factory.ContentHeight = 16;
            this.cmb_factory.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_factory.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_factory.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_factory.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_factory.EditorHeight = 16;
            this.cmb_factory.EvenRowStyle = style18;
            this.cmb_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_factory.FooterStyle = style19;
            this.cmb_factory.GapHeight = 2;
            this.cmb_factory.HeadingStyle = style20;
            this.cmb_factory.HighLightRowStyle = style21;
            this.cmb_factory.ItemHeight = 15;
            this.cmb_factory.Location = new System.Drawing.Point(109, 16);
            this.cmb_factory.MatchEntryTimeout = ((long)(2000));
            this.cmb_factory.MaxDropDownItems = ((short)(5));
            this.cmb_factory.MaxLength = 32767;
            this.cmb_factory.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_factory.Name = "cmb_factory";
            this.cmb_factory.OddRowStyle = style22;
            this.cmb_factory.PartialRightColumn = false;
            this.cmb_factory.PropBag = resources.GetString("cmb_factory.PropBag");
            this.cmb_factory.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_factory.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_factory.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_factory.SelectedStyle = style23;
            this.cmb_factory.Size = new System.Drawing.Size(200, 20);
            this.cmb_factory.Style = style24;
            this.cmb_factory.TabIndex = 1;
            // 
            // cmb_paraCode
            // 
            this.cmb_paraCode.AddItemCols = 0;
            this.cmb_paraCode.AddItemSeparator = ';';
            this.cmb_paraCode.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
            this.cmb_paraCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_paraCode.Caption = "";
            this.cmb_paraCode.CaptionHeight = 17;
            this.cmb_paraCode.CaptionStyle = style25;
            this.cmb_paraCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_paraCode.ColumnCaptionHeight = 18;
            this.cmb_paraCode.ColumnFooterHeight = 18;
            this.cmb_paraCode.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_paraCode.ContentHeight = 16;
            this.cmb_paraCode.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_paraCode.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_paraCode.EditorFont = new System.Drawing.Font("굴림", 9F);
            this.cmb_paraCode.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_paraCode.EditorHeight = 16;
            this.cmb_paraCode.EvenRowStyle = style26;
            this.cmb_paraCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_paraCode.FooterStyle = style27;
            this.cmb_paraCode.GapHeight = 2;
            this.cmb_paraCode.HeadingStyle = style28;
            this.cmb_paraCode.HighLightRowStyle = style29;
            this.cmb_paraCode.ItemHeight = 15;
            this.cmb_paraCode.Location = new System.Drawing.Point(431, 16);
            this.cmb_paraCode.MatchEntryTimeout = ((long)(2000));
            this.cmb_paraCode.MaxDropDownItems = ((short)(5));
            this.cmb_paraCode.MaxLength = 32767;
            this.cmb_paraCode.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_paraCode.Name = "cmb_paraCode";
            this.cmb_paraCode.OddRowStyle = style30;
            this.cmb_paraCode.PartialRightColumn = false;
            this.cmb_paraCode.PropBag = resources.GetString("cmb_paraCode.PropBag");
            this.cmb_paraCode.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_paraCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_paraCode.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_paraCode.SelectedStyle = style31;
            this.cmb_paraCode.Size = new System.Drawing.Size(200, 20);
            this.cmb_paraCode.Style = style32;
            this.cmb_paraCode.TabIndex = 3;
            // 
            // lbl_factory
            // 
            this.lbl_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_factory.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_factory.ImageIndex = 1;
            this.lbl_factory.ImageList = this.img_Label;
            this.lbl_factory.Location = new System.Drawing.Point(8, 16);
            this.lbl_factory.Name = "lbl_factory";
            this.lbl_factory.Size = new System.Drawing.Size(100, 21);
            this.lbl_factory.TabIndex = 180;
            this.lbl_factory.Text = "Factory";
            this.lbl_factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.ImageIndex = 27;
            this.btn_search.ImageList = this.img_SmallButton;
            this.btn_search.Location = new System.Drawing.Point(632, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(21, 21);
            this.btn_search.TabIndex = 184;
            this.btn_search.Tag = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // lbl_comCode
            // 
            this.lbl_comCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.lbl_comCode.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_comCode.ImageIndex = 0;
            this.lbl_comCode.ImageList = this.img_Label;
            this.lbl_comCode.Location = new System.Drawing.Point(330, 16);
            this.lbl_comCode.Name = "lbl_comCode";
            this.lbl_comCode.Size = new System.Drawing.Size(100, 21);
            this.lbl_comCode.TabIndex = 52;
            this.lbl_comCode.Text = "Code";
            this.lbl_comCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_BM_Shipping_Parameter
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(694, 468);
            this.Controls.Add(this.c1Sizer1);
            this.Name = "Form_BM_Shipping_Parameter";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Closed += new System.EventHandler(this.Form_Closed);
            this.Controls.SetChildIndex(this.c1Sizer1, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spd_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spd_main_Sheet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_factory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_paraCode)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 그리드 이벤트

		private void spd_main_EditModeOn(object sender, System.EventArgs e)
		{						
			this.Grid_EditModeOnProcess(spd_main) ;
		}		

		private void spd_main_EditChange(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
		{			
			spd_main.Update_Row(img_Action);
		}

		#endregion

		#region 컨트롤 이벤트

		private void Form_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Form_Closed(object sender, System.EventArgs e)
		{
			this.Dispose(true);
		}

		private void btn_new_Click(object sender, System.EventArgs e)
		{
			this.btn_NewProcess();
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			this.btn_SearchProcess();
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			this.btn_SaveProcess();
		}

		#region 버튼 클릭

		private void btn_search_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 27;
		}

		private void btn_search_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_search.ImageIndex = 26;
		}

		private void btn_save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 25;
		}

		private void btn_save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_save.ImageIndex = 24;		
		}

		private void btn_new_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 15;		
		}

		private void btn_new_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_new.ImageIndex = 14;
		}

		#endregion

		#endregion

		#region 이벤트 처리 메서드

		#region 초기화

		private void Init_Form()
		{
			this.Text = "Shipping Parameter";
			lbl_MainTitle.Text = "Shipping Parameter";

            ClassLib.ComFunction.SetLangDic(this);

			// factory set
			DataTable vDt = null;
			vDt = COM.ComFunction.Select_Factory_List();
			COM.ComCtl.Set_ComboList(vDt, cmb_factory, 0, 1, false);
			cmb_factory.SelectedValue = ClassLib.ComVar.This_Factory;
			vDt.Dispose() ;

			// com code set
			vDt = this.SELECT_SCM_CODE_LIST(ClassLib.ComVar.This_Factory);
			COM.ComCtl.Set_ComboList(vDt, cmb_paraCode, 0, 1, true);
			cmb_paraCode.SelectedIndex = 0;
			vDt.Dispose() ;

			// user define varable set
			_mainSheet = spd_main.Sheets[0];

			// grid set
			spd_main.Set_Spread_Comm("SBM_SHIP_PARAMETER", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
		}

		#endregion

		#region 툴바 메뉴 이벤트

		private void btn_NewProcess()
		{
			try
			{
				spd_main.ClearAll();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
		}

		private void btn_SearchProcess()
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;

				int vComValueCol = (int)ClassLib.TBSBM_SHIP_PARAMETER.IxMaxCt - 1;

				string vFactory = COM.ComFunction.Empty_Combo(cmb_factory, "");
				string vParaCode = COM.ComFunction.Empty_Combo(cmb_paraCode, "");
				
				ComboBoxCellType vCombo = null;
				ListBox vTemp = null;
				
				DataTable vDt = this.SELECT_SBM_SHIPPING_PARAMETER(vFactory, vParaCode);

				if (vDt.Rows.Count > 0)
				{
					_mainSheet.RowCount = 0;
					vDt.Rows.Add(vDt.NewRow());

					for (int vRow = 0, idx = 0 ; idx < vDt.Rows.Count - 1 ; vRow++, idx++)
					{
						vTemp = new ListBox();

						while (true)
						{
							vTemp.Items.Add(vDt.Rows[idx].ItemArray[vComValueCol + 1]);

							if (!vDt.Rows[idx].ItemArray[_paraCodeCol - 1].ToString().Equals(vDt.Rows[idx + 1].ItemArray[_paraCodeCol - 1].ToString()))
								break;

							idx++;
						}

						_mainSheet.Rows.Add(vRow, 1);
						vCombo = new ComboBoxCellType();
						//vTemp.SelectedValue = vDt.Rows[idx].ItemArray[_paraValue1Col - 1];
						vCombo.ListControl = vTemp;
						_mainSheet.Cells[vRow, _paraValue1Col].CellType = vCombo;

						Grid_SetData(vRow, vDt.Rows[idx]);
					}
				}
				else
				{
					spd_main.ClearAll();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSearch, this);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}			
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		private void Grid_SetData(int arg_row, DataRow arg_vdr)
		{
			_mainSheet.Cells[arg_row, _factoryCol].Text = arg_vdr.ItemArray[_factoryCol - 1].ToString();
			_mainSheet.Cells[arg_row, _paraCodeCol].Text = arg_vdr.ItemArray[_paraCodeCol - 1].ToString();
			_mainSheet.Cells[arg_row, _paraNameCol].Text = arg_vdr.ItemArray[_paraNameCol - 1].ToString();
			_mainSheet.Cells[arg_row, _remarksCol].Text = arg_vdr.ItemArray[_remarksCol - 1].ToString();
			_mainSheet.Cells[arg_row, _paraValue1Col].Text = arg_vdr.ItemArray[_paraValue1Col - 1].ToString();
		}

		private void btn_SaveProcess()
		{
			try
			{				
				this.Cursor = Cursors.WaitCursor;

				if (MessageBox.Show(this, "Do you want to save?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					if (MyOraDB.Save_Spread("PKG_SBM_SHIPPING_PARAMETER.SAVE_SBM_SHIPPING_PARAMETER", spd_main))
                        spd_main.Refresh_Division();
				}

				ClassLib.ComFunction.Status_Bar_Message(ClassLib.ComVar.MgsEndSave, this);
			}
			catch (Exception ex)
			{			
				MessageBox.Show(ex.Message);
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		#endregion

		#region 그리드 이벤트

		private void Grid_EditModeOnProcess(COM.SSP arg_grid)
		{
			int vRow = arg_grid.Sheets[0].ActiveRowIndex ;
			int vCol = arg_grid.Sheets[0].ActiveColumnIndex ;
			
			if (arg_grid.Sheets[0].Cells[vRow, vCol].Value == null || arg_grid.Sheets[0].Columns[vCol].CellType == null)
				return;
			
			arg_grid.Buffer_CellData = arg_grid.Sheets[0].Cells[vRow, vCol].Value.ToString();
			string vTemp = arg_grid.Sheets[0].Columns[vCol].CellType.ToString() ;
			if (vTemp == "CheckBoxCellType" )
			{
				arg_grid.Buffer_CellData = "000" ;
				arg_grid.Update_Row(img_Action) ;
			}
		}

		#endregion

		#endregion

		#region DBConnect

		/// <summary>
		/// PKG_SBM_SHIPPING_PARAMETER : Parameter 리스트 가져오기
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SBM_SHIPPING_PARAMETER(string arg_factory, string arg_para_cd)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(3);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_PARAMETER.SELECT_SBM_SHIPPING_PARAMETER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PARA_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_para_cd;
			MyOraDB.Parameter_Values[2] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_PARAMETER : 공통코드 리스트 가져오기 ( MRP 관련 )
		/// </summary>
		/// <returns>DataTable</returns>
		public DataTable SELECT_SCM_CODE_LIST(string arg_factory)
		{
			DataSet vds_ret;

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_PARAMETER.SELECT_SCM_CODE_LIST";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = "";

			MyOraDB.Add_Select_Parameter(true);
			vds_ret = MyOraDB.Exe_Select_Procedure();
			if(vds_ret == null) return null ;

			return vds_ret.Tables[MyOraDB.Process_Name];
		}

		/// <summary>
		/// PKG_SBM_SHIPPING_PARAMETER : Parameter 리스트 저장
		/// </summary>
		public void SAVE_SBM_SHIPPING_PARAMETER()
		{

			MyOraDB.ReDim_Parameter(10);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING_PARAMETER.SAVE_SBM_SHIPPING_PARAMETER";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_PARA_CD";
			MyOraDB.Parameter_Name[2] = "ARG_PARA_NAME";
			MyOraDB.Parameter_Name[3] = "ARG_PARA_VALUE1";
			MyOraDB.Parameter_Name[4] = "ARG_PARA_VALUE2";
			MyOraDB.Parameter_Name[5] = "ARG_PARA_VALUE3";
			MyOraDB.Parameter_Name[6] = "ARG_PARA_VALUE4";
			MyOraDB.Parameter_Name[7] = "ARG_PARA_VALUE5";
			MyOraDB.Parameter_Name[8] = "ARG_REMARKS";
			MyOraDB.Parameter_Name[9] = "ARG_UPD_USER";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;

			//04.DATA 정의
			for (int vRow = 0 ; vRow < spd_main.Sheets[0].RowCount ; vRow++)
			{
//				MyOraDB.Parameter_Values[0] = arg_factory;
//				MyOraDB.Parameter_Values[1] = arg_para_cd;
//				MyOraDB.Parameter_Values[2] = arg_para_name;
//				MyOraDB.Parameter_Values[3] = arg_para_value1;
//				MyOraDB.Parameter_Values[4] = arg_para_value2;
//				MyOraDB.Parameter_Values[5] = arg_para_value3;
//				MyOraDB.Parameter_Values[6] = arg_para_value4;
//				MyOraDB.Parameter_Values[7] = arg_para_value5;
//				MyOraDB.Parameter_Values[8] = arg_remarks;
//				MyOraDB.Parameter_Values[9] = arg_upd_user;
			}

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		#endregion

	}
}

