using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.Data;
using FarPoint.Win.Spread;

namespace FlexCDC.BaseInfo
{
	public class Pop_Spec_Editer : COM.PCHWinForm.Pop_Small
	{
		private COM.FSP fgrid_spec;
		private System.ComponentModel.IContainer components = null;
		private COM.OraDB OraDB = new COM.OraDB();

		private int _RowFixde;

		private CDC_Bom.Form_Bom_Editer formBomEditer = null;
		private Purchase.Form_Pur_request_master formReqmaster = null;
		private string edit_type = null;
		private int edit_row =0;
		private string change_r_flg = "U";

		public Pop_Spec_Editer()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


		//부분 처리
		public Pop_Spec_Editer(CDC_Bom.Form_Bom_Editer arg_form, string arg_edit_type, int arg_edit_row, string arg_change_r_flg)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			formBomEditer = arg_form;
			edit_type = arg_edit_type;
			edit_row = arg_edit_row;
			change_r_flg = arg_change_r_flg;
		}

		//부분 처리
		public Pop_Spec_Editer(Purchase.Form_Pur_request_master arg_form, string arg_edit_type, int arg_edit_row, string arg_change_r_flg)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			formReqmaster = arg_form;
			edit_type = arg_edit_type;
			edit_row = arg_edit_row;
			change_r_flg = arg_change_r_flg;
		}


		//일괄 처리
		public Pop_Spec_Editer(CDC_Bom.Form_Bom_Editer arg_form, string arg_edit_type, string arg_change_r_flg)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			formBomEditer = arg_form;
			edit_type = arg_edit_type;
			change_r_flg = arg_change_r_flg;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_Spec_Editer));
			this.fgrid_spec = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_spec)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// fgrid_spec
			// 
			this.fgrid_spec.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_spec.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_spec.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_spec.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_spec.Location = new System.Drawing.Point(8, 48);
			this.fgrid_spec.Name = "fgrid_spec";
			this.fgrid_spec.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_spec.Size = new System.Drawing.Size(378, 320);
			this.fgrid_spec.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_spec.TabIndex = 153;
			this.fgrid_spec.DoubleClick += new System.EventHandler(this.fgrid_spec_DoubleClick);
			// 
			// Pop_Spec_Editer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 375);
			this.Controls.Add(this.fgrid_spec);
			this.Name = "Pop_Spec_Editer";
			this.Load += new System.EventHandler(this.Pop_Spec_Editer_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_spec, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_spec)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_Spec_Editer_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{
//			DataTable dt_ret;
//			dt_ret = ClassLib.ComVar.Select_ComCode(ClassLib.ComVar.This_Factory, ClassLib.ComVar.CxSpecDiv);
//			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Division, 1, 2, false, ClassLib.ComVar.ComboList_Visible.Name); 

			fgrid_spec.Set_Grid("SXD_SPEC", "1", 1, COM.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
			fgrid_spec.Rows.Count = _RowFixde;


			Search_SBC_SPEC();


		}

		/// <summary>
		/// Search_SBC_SPEC : 
		/// </summary>
		private void Search_SBC_SPEC()
		{
			try
			{
				DataTable dt_ret;
				dt_ret = Select_sdd_spec();

				int dt_row = dt_ret.Rows.Count;
				int dt_col = dt_ret.Columns.Count;

				fgrid_spec.Rows.Count = _RowFixde;

				for(int i=0; i<dt_row; i++)
				{
					fgrid_spec.AddItem(dt_ret.Rows[i].ItemArray, fgrid_spec.Rows.Count, 1);
				}
 
				fgrid_spec.AutoSizeCols();

			} 
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_SBC_SPEC", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}
		}

		/// <summary>
		/// Select_SBC_SPEC :  
		/// </summary>
		/// <returns></returns>
		public DataTable Select_sdd_spec()
		{
  
			DataSet ds_ret;
 
			OraDB.ReDim_Parameter(1); 

			//01.PROCEDURE명
			OraDB.Process_Name = "PKG_SXD_SRF_03_SELECT.SELECT_SXC_SPECCD";
 
			//02.ARGURMENT명
			OraDB.Parameter_Name[0] = "OUT_CURSOR";

			//03.DATA TYPE
			OraDB.Parameter_Type[0] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			OraDB.Parameter_Values[0] = ""; 

			OraDB.Add_Select_Parameter(true);
 
			ds_ret = OraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[OraDB.Process_Name]; 
		}

		private void fgrid_spec_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_spec.Selection.r1;
			
			string spec_cd = fgrid_spec[sct_row, 1].ToString();
			string spec_name = fgrid_spec[sct_row, 2].ToString();


			if(formBomEditer!=null)
			{
				if(edit_row != 0)
				{

					formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD] = spec_cd;
					formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = spec_name;

					//flg 처리
					formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = change_r_flg;
					formBomEditer.fgrid_detail[edit_row, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = change_r_flg;
				}
				else
				{
					for(int i = formBomEditer._RowFixed_detali; i<formBomEditer.fgrid_detail.Rows.Count; i++)
					{
						if(formBomEditer.fgrid_detail[i,(int)ClassLib.TBSXD_SRF_TAIL.IxSRF_LEVEL].Equals("1"))
						{
							if(formBomEditer.fgrid_detail.Rows[i].Selected)
							{
								if(!formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION].Equals("I"))
								{
									formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxDIVISION] = "U";
								}
								formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxCHANGE_R_FLG] = "U";
								formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxSTATUS] = "Y";
								formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_CD] = spec_cd;
								formBomEditer.fgrid_detail[i, (int)ClassLib.TBSXD_SRF_TAIL.IxPCC_SPEC_NAME] = spec_name;
							}
						}
					}
				}
			}
			else if(formReqmaster != null)
			{
				if(!formReqmaster.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION].Equals("I"))
				{
					formReqmaster.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxDIVISION] = "U";
				}
				formReqmaster.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_CD] = spec_cd;
				formReqmaster.flg_request1[edit_row, (int)ClassLib.TBSXO_PUR_REQ.IxPCC_SPEC_DESC] = spec_name;
			}


			this.Close();

		}
	}
}

