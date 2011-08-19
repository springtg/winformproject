using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 

namespace FlexBase.Yield
{
	public class Pop_Yield_Template : COM.PCHWinForm.Pop_Normal_Light
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Label lbl_template;
		private C1.Win.C1List.C1Combo cmb_BOMTemp;
		private System.Windows.Forms.Label lbl_BOMTemp;
		private System.Windows.Forms.GroupBox groupBox1;
		private COM.FSP fgrid_YieldTemp;
		public System.Windows.Forms.ImageList img_LongButton;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Refresh;
		private System.Windows.Forms.Label btn_SearchTemp;
		private System.ComponentModel.IContainer components = null;

		public Pop_Yield_Template()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}




		private string _BOMTempCd = "";

		public Pop_Yield_Template(string arg_bom_tempcd)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.




			_BOMTempCd = arg_bom_tempcd;



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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Yield_Template));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.lbl_template = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_BOMTemp = new C1.Win.C1List.C1Combo();
            this.lbl_BOMTemp = new System.Windows.Forms.Label();
            this.btn_Refresh = new System.Windows.Forms.Label();
            this.btn_SearchTemp = new System.Windows.Forms.Label();
            this.img_LongButton = new System.Windows.Forms.ImageList(this.components);
            this.fgrid_YieldTemp = new COM.FSP();
            this.btn_Cancel = new System.Windows.Forms.Label();
            this.btn_Apply = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldTemp)).BeginInit();
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
            this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            this.img_Button.Images.SetKeyName(2, "");
            this.img_Button.Images.SetKeyName(3, "");
            // 
            // lbl_template
            // 
            this.lbl_template.Location = new System.Drawing.Point(0, 0);
            this.lbl_template.Name = "lbl_template";
            this.lbl_template.Size = new System.Drawing.Size(100, 23);
            this.lbl_template.TabIndex = 0;
            this.lbl_template.Text = "Template";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmb_BOMTemp);
            this.groupBox1.Controls.Add(this.lbl_BOMTemp);
            this.groupBox1.Controls.Add(this.btn_Refresh);
            this.groupBox1.Controls.Add(this.btn_SearchTemp);
            this.groupBox1.Location = new System.Drawing.Point(5, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 43);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // cmb_BOMTemp
            // 
            this.cmb_BOMTemp.AccessibleDescription = "";
            this.cmb_BOMTemp.AccessibleName = "";
            this.cmb_BOMTemp.AddItemCols = 0;
            this.cmb_BOMTemp.AddItemSeparator = ';';
            this.cmb_BOMTemp.AllowRowSizing = C1.Win.C1List.RowSizingEnum.None;
            this.cmb_BOMTemp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_BOMTemp.Caption = "";
            this.cmb_BOMTemp.CaptionHeight = 17;
            this.cmb_BOMTemp.CaptionStyle = style9;
            this.cmb_BOMTemp.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_BOMTemp.ColumnCaptionHeight = 18;
            this.cmb_BOMTemp.ColumnFooterHeight = 18;
            this.cmb_BOMTemp.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_BOMTemp.ContentHeight = 17;
            this.cmb_BOMTemp.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_BOMTemp.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_BOMTemp.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_BOMTemp.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_BOMTemp.EditorHeight = 17;
            this.cmb_BOMTemp.EvenRowStyle = style10;
            this.cmb_BOMTemp.Font = new System.Drawing.Font("굴림", 9F);
            this.cmb_BOMTemp.FooterStyle = style11;
            this.cmb_BOMTemp.GapHeight = 2;
            this.cmb_BOMTemp.HeadingStyle = style12;
            this.cmb_BOMTemp.HighLightRowStyle = style13;
            this.cmb_BOMTemp.ItemHeight = 15;
            this.cmb_BOMTemp.Location = new System.Drawing.Point(108, 14);
            this.cmb_BOMTemp.MatchEntryTimeout = ((long)(2000));
            this.cmb_BOMTemp.MaxDropDownItems = ((short)(5));
            this.cmb_BOMTemp.MaxLength = 32767;
            this.cmb_BOMTemp.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_BOMTemp.Name = "cmb_BOMTemp";
            this.cmb_BOMTemp.OddRowStyle = style14;
            this.cmb_BOMTemp.PartialRightColumn = false;
            this.cmb_BOMTemp.PropBag = resources.GetString("cmb_BOMTemp.PropBag");
            this.cmb_BOMTemp.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_BOMTemp.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_BOMTemp.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_BOMTemp.SelectedStyle = style15;
            this.cmb_BOMTemp.Size = new System.Drawing.Size(180, 21);
            this.cmb_BOMTemp.Style = style16;
            this.cmb_BOMTemp.TabIndex = 656;
            this.cmb_BOMTemp.SelectedValueChanged += new System.EventHandler(this.cmb_BOMTemp_SelectedValueChanged);
            // 
            // lbl_BOMTemp
            // 
            this.lbl_BOMTemp.Font = new System.Drawing.Font("굴림", 9F);
            this.lbl_BOMTemp.ImageIndex = 0;
            this.lbl_BOMTemp.ImageList = this.img_Label;
            this.lbl_BOMTemp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_BOMTemp.Location = new System.Drawing.Point(7, 14);
            this.lbl_BOMTemp.Name = "lbl_BOMTemp";
            this.lbl_BOMTemp.Size = new System.Drawing.Size(100, 21);
            this.lbl_BOMTemp.TabIndex = 658;
            this.lbl_BOMTemp.Text = "BOM Template";
            this.lbl_BOMTemp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Refresh.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Refresh.ImageIndex = 2;
            this.btn_Refresh.ImageList = this.img_Button;
            this.btn_Refresh.Location = new System.Drawing.Point(289, 13);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(80, 23);
            this.btn_Refresh.TabIndex = 665;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            this.btn_Refresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Refresh.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Refresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_SearchTemp
            // 
            this.btn_SearchTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_SearchTemp.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_SearchTemp.ImageIndex = 0;
            this.btn_SearchTemp.ImageList = this.img_LongButton;
            this.btn_SearchTemp.Location = new System.Drawing.Point(370, 13);
            this.btn_SearchTemp.Name = "btn_SearchTemp";
            this.btn_SearchTemp.Size = new System.Drawing.Size(150, 23);
            this.btn_SearchTemp.TabIndex = 666;
            this.btn_SearchTemp.Text = "Search BOM Template";
            this.btn_SearchTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_SearchTemp.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_SearchTemp.Click += new System.EventHandler(this.btn_SearchTemp_Click);
            this.btn_SearchTemp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_SearchTemp.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_SearchTemp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // img_LongButton
            // 
            this.img_LongButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_LongButton.ImageStream")));
            this.img_LongButton.TransparentColor = System.Drawing.Color.Transparent;
            this.img_LongButton.Images.SetKeyName(0, "");
            this.img_LongButton.Images.SetKeyName(1, "");
            // 
            // fgrid_YieldTemp
            // 
            this.fgrid_YieldTemp.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_YieldTemp.ColumnInfo = "10,1,0,0,0,75,Columns:";
            this.fgrid_YieldTemp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_YieldTemp.Location = new System.Drawing.Point(5, 85);
            this.fgrid_YieldTemp.Name = "fgrid_YieldTemp";
            this.fgrid_YieldTemp.Size = new System.Drawing.Size(585, 347);
            this.fgrid_YieldTemp.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_YieldTemp.Styles"));
            this.fgrid_YieldTemp.TabIndex = 660;
            this.fgrid_YieldTemp.DoubleClick += new System.EventHandler(this.fgrid_YieldTemp_DoubleClick);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Cancel.ImageIndex = 2;
            this.btn_Cancel.ImageList = this.img_Button;
            this.btn_Cancel.Location = new System.Drawing.Point(509, 439);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_Cancel.TabIndex = 664;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_Apply.Font = new System.Drawing.Font("Verdana", 9F);
            this.btn_Apply.ImageIndex = 2;
            this.btn_Apply.ImageList = this.img_Button;
            this.btn_Apply.Location = new System.Drawing.Point(428, 439);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(80, 23);
            this.btn_Apply.TabIndex = 663;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
            this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // Pop_Yield_Template
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.fgrid_YieldTemp);
            this.Name = "Pop_Yield_Template";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Yield_Template_Closing);
            this.Controls.SetChildIndex(this.fgrid_YieldTemp, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btn_Apply, 0);
            this.Controls.SetChildIndex(this.btn_Cancel, 0);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_BOMTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_YieldTemp)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB(); 
 
					  
		//return 또는 cancel 이벤트 체크
		public bool _CancelFlag = true;

		#endregion	  
		 
		#region 멤버 메서드

		private void Init_Form()
		{ 
			try
			{
				//Title
				this.Text = "Yield Template";
				lbl_MainTitle.Text = "Yield Template";


                ClassLib.ComFunction.SetLangDic(this);

 
				// 그리드 설정
				fgrid_YieldTemp.Set_Grid("SBC_YIELD_TEMPLATE", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);  
				fgrid_YieldTemp.Styles.Alternate.BackColor = Color.Empty;
 

				//template bom code combo list 
				DataTable dt_ret;  
				dt_ret = FlexBase.Yield.Form_BC_BOMTemplate.Select_TemplateTree_Code(" ");
				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_BOMTemp, 0, 1, true, COM.ComVar.ComboList_Visible.Name); 
				dt_ret.Dispose();

				cmb_BOMTemp.SelectedValue = _BOMTempCd;
			
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	

 
		}



		/// <summary>
		/// Search_YieldTemp : 
		/// </summary>
		private void Search_YieldTemp()
		{
			try
			{
				string bom_tempcd = ClassLib.ComFunction.Empty_Combo(cmb_BOMTemp, " ");
			    DataTable dt_ret = Select_SBC_YIELD_TEMPLATE(bom_tempcd);

				Display_GridTree(dt_ret);

				dt_ret.Dispose();


			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_YieldTemp", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
 

		private void Display_GridTree(DataTable arg_dt)
		{
			fgrid_YieldTemp.Rows.Count = fgrid_YieldTemp.Rows.Fixed;  
			fgrid_YieldTemp.Tree.Column = (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxITEM_NAME2;

			for(int i = 0; i < arg_dt.Rows.Count; i++)
			{
				fgrid_YieldTemp.Rows.InsertNode(i + fgrid_YieldTemp.Rows.Fixed, arg_dt.Rows[i].ItemArray[(int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_LEVEL - 1].ToString().Length - 1);			
				insertcell(i, arg_dt.Rows[i].ItemArray);
			}
 
		}


		/// <summary>
		/// insertcell : 그리드에 값 넣기
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_incell"></param>
		private void insertcell(int arg_row, object[] arg_incell)
		{
			int rowfixed = fgrid_YieldTemp.Rows.Fixed;

			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxYIELD_TEMP_CD] = arg_incell[0].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_TREE_CD]	= arg_incell[1].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_TREE_NAME] = arg_incell[2].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_CD] = arg_incell[3].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_LEVEL] = arg_incell[4].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_STAGE] = arg_incell[5].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxITEM_CD] = arg_incell[6].ToString();
			fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxITEM_NAME2] = arg_incell[7].ToString();


			if(fgrid_YieldTemp[arg_row + rowfixed, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_LEVEL].ToString() == "1")
			{
				fgrid_YieldTemp.Rows[arg_row + rowfixed].StyleNew.BackColor = ClassLib.ComVar.ClrLevel_1st;
			}



		}

 

		/// <summary>
		/// Show_BOMTemplate : 
		/// </summary>
		private void Show_BOMTemplate()
		{
			try
			{
				FlexBase.Yield.Form_BC_BOMTemplate pop_form = new Form_BC_BOMTemplate();
				pop_form.WindowState = System.Windows.Forms.FormWindowState.Normal;

				pop_form.ShowDialog();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Show_BOMTemplate", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		/// <summary>
		/// Return_Data : 
		/// </summary>
		private void Return_Data()
		{
			
			try
			{ 
				if(_CancelFlag)
				{
					COM.ComVar.Parameter_PopUp = new string[] { "", "" };
				}
				else
				{
					COM.ComVar.Parameter_PopUp = new string[]
					{
						fgrid_YieldTemp[fgrid_YieldTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxYIELD_TEMP_CD].ToString(),
						fgrid_YieldTemp[fgrid_YieldTemp.Selection.r1, (int)ClassLib.TBSBC_YIELD_TEMPLATE.IxTEMPLATE_TREE_CD].ToString()
					};

				} // end if

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Item_List_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		#endregion 

		#region 이벤트 처리


		private void cmb_BOMTemp_SelectedValueChanged(object sender, System.EventArgs e)
		{
			Search_YieldTemp();
		}

		private void btn_Refresh_Click(object sender, System.EventArgs e)
		{
			Search_YieldTemp();
		}

		private void btn_SearchTemp_Click(object sender, System.EventArgs e)
		{
			Show_BOMTemplate();
		}

		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			if(fgrid_YieldTemp.Rows.Count <= fgrid_YieldTemp.Rows.Fixed) return;

			_CancelFlag = false;
			this.Close();
		}

		private void fgrid_YieldTemp_DoubleClick(object sender, System.EventArgs e)
		{
			if(fgrid_YieldTemp.Rows.Count <= fgrid_YieldTemp.Rows.Fixed) return;

			_CancelFlag = false;
			this.Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CancelFlag = true;
			this.Close();

		} 
		

		private void Pop_Yield_Template_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Return_Data();
		}


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





		#endregion

		#region DB Connect

		/// <summary>
		/// Select_SBC_YIELD_TEMPLATE : TemplateTree Code 조회
		/// </summary>
		/// <param name="arg_template_tree_cd">BOM Template Code</param>
		/// <returns></returns>
		private DataTable Select_SBC_YIELD_TEMPLATE(string arg_template_tree_cd)
		{ 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2); 
 
			MyOraDB.Process_Name = "PKG_SBC_YIELD.SELECT_SBC_YIELD_TEMPLATE";
  
			MyOraDB.Parameter_Name[0] = "ARG_TEMPLATE_TREE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";
 
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			   
			MyOraDB.Parameter_Values[0] = arg_template_tree_cd;
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null; 
			return ds_ret.Tables[MyOraDB.Process_Name]; 
		}


		#endregion

		



	}
}

