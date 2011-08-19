using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_Work_Info_User : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.Windows.Forms.Label btn_search;
		public COM.FSP fgrid_ingwork;
		private System.ComponentModel.IContainer components = null;


		#region 사용자 변수

		private COM.OraDB oraDB = null;
		public System.Windows.Forms.ImageList img_Action;
		private int _RowFixed;
		private Form_Home frm = null;


		#endregion

		public Pop_PS_Work_Info_User()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		public Pop_PS_Work_Info_User(Form_Home arg_frm)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			frm = arg_frm;


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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Work_Info_User));
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.btn_search = new System.Windows.Forms.Label();
			this.fgrid_ingwork = new COM.FSP();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_save
			// 
			this.btn_save.ImageIndex = 2;
			this.btn_save.ImageList = this.imgs_new_btn;
			this.btn_save.Location = new System.Drawing.Point(527, 416);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 110;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(446, 416);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 109;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_search
			// 
			this.btn_search.ImageIndex = 0;
			this.btn_search.ImageList = this.imgs_new_btn;
			this.btn_search.Location = new System.Drawing.Point(608, 416);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(80, 23);
			this.btn_search.TabIndex = 108;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// fgrid_ingwork
			// 
			this.fgrid_ingwork.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_ingwork.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_ingwork.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_ingwork.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_ingwork.Location = new System.Drawing.Point(7, 40);
			this.fgrid_ingwork.Name = "fgrid_ingwork";
			this.fgrid_ingwork.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_ingwork.Size = new System.Drawing.Size(680, 368);
			this.fgrid_ingwork.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_ingwork.TabIndex = 111;
			this.fgrid_ingwork.DoubleClick += new System.EventHandler(this.fgrid_ingwork_DoubleClick);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_PS_Work_Info_User
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 448);
			this.Controls.Add(this.fgrid_ingwork);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_search);
			this.Name = "Pop_PS_Work_Info_User";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_PS_Work_Info_User_Closing);
			this.Load += new System.EventHandler(this.Pop_PS_Work_Info_User_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_search, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			this.Controls.SetChildIndex(this.fgrid_ingwork, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_ingwork)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_Work_Info_User_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		public void init_Form()
		{

			this.Text = "Auto Work Info List";
			this.lbl_MainTitle.Text = "Auto Work Info List";
			ClassLib.ComFunction.SetLangDic(this);
			
			oraDB = new COM.OraDB();


			
			//DataTable dt = oraDB.Select_ComCode(ClassLib.ComVar.This_Factory, "PS12");
			//ClassLib.ComCtl.Set_ComboList(dt, cmb_Seach, 1, 2, true);
			//cmb_Seach.SelectedIndex = 0;

			//그리드 설정
			fgrid_ingwork.Set_Grid("SPS_WORKINFO_USER","1", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, false);
			fgrid_ingwork.Set_Action_Image(img_Action);
			_RowFixed = fgrid_ingwork.Rows.Fixed;
			Search();
			//fgrid_ingwork.AutoSizeCols();
			
		}

		private void btn_search_Click(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void Search()
		{
			fgrid_ingwork.Rows.Count = _RowFixed;

			DataTable dt = Select_SPS_Notice_IngWork("I");

			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;

			for(int i=0; i<dt_row; i++)
			{
				fgrid_ingwork.Rows.Add();

				for(int j=0; j<dt_col; j++)
				{
					if(j == (int)ClassLib.SPS_WORKINFO_USER.IxDBUPD_YMD)
					{
						ClassLib.ComFunction comfunc = new ERP.ClassLib.ComFunction();
						fgrid_ingwork[fgrid_ingwork.Rows.Count-1, j+1] = "[ " + comfunc.ConvertDate2Type(dt.Rows[i].ItemArray[j].ToString()) + " ]";
					}
					else
					{
						fgrid_ingwork[fgrid_ingwork.Rows.Count-1, j+1] = dt.Rows[i].ItemArray[j].ToString();
					}
				}
			}

		}



		private DataTable Select_SPS_Notice_IngWork(string arg_division)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_WORKINFO_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_DIVISION";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = arg_division;
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			return  DS_Ret.Tables[Proc_Name];
		}

		private void Delete_SPS_WorkInfo_List(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_WORKINFO_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_COMMON";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = "N";
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_seq;


			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}



		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			int sct_row01 = fgrid_ingwork.Selection.r1;
			int sct_row02 = fgrid_ingwork.Selection.r2+1;

			for(int i=sct_row01; i<sct_row02; i++)
			{
				fgrid_ingwork[i, (int)ClassLib.SPS_WORKINFO_USER.IxGRDIVISION] = "D";
			}
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			for(int i=_RowFixed; i<fgrid_ingwork.Rows.Count; i++)
			{
				if(fgrid_ingwork[i, (int)ClassLib.SPS_WORKINFO_USER.IxGRDIVISION] != null)
				{
					if(fgrid_ingwork[i, (int)ClassLib.SPS_WORKINFO_USER.IxGRDIVISION].ToString() == "D")
					{
						Delete_SPS_WorkInfo_List(fgrid_ingwork[i, (int)ClassLib.SPS_WORKINFO_USER.IxGRSEQ].ToString());
					}
				}
			}

			Search();
		}

		private void fgrid_ingwork_DoubleClick(object sender, System.EventArgs e)
		{
			if(fgrid_ingwork.Rows.Count <= fgrid_ingwork.Rows.Fixed) return;

			int sct_row = fgrid_ingwork.Selection.r1;
		    string seq = fgrid_ingwork[sct_row, (int)ClassLib.SPS_WORKINFO_USER.IxGRSEQ].ToString();
			Pop_PS_Work_Info_View view = new Pop_PS_Work_Info_View(seq);
			view.ShowDialog();
			
			Search();

		}

		private void Pop_PS_Work_Info_User_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if(frm != null)
				{
					frm.Get_AutoMess();
				}
			}
			catch
			{
			}
		}



	}
}

