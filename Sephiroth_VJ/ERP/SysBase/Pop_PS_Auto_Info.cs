using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_Auto_Info : COM.APSWinForm.Pop_Large
	{
		public COM.FSP fgrid_autoinfo;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_save;
		private System.Windows.Forms.Label btn_delete;
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ImageList img_Action;



		private COM.OraDB oraDB = null;
		private int _RowFixed;

		public Pop_PS_Auto_Info()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}



		private Form_Home frm = null;

		public Pop_PS_Auto_Info(Form_Home arg_frm)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Auto_Info));
			this.fgrid_autoinfo = new COM.FSP();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_save = new System.Windows.Forms.Label();
			this.btn_delete = new System.Windows.Forms.Label();
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_autoinfo)).BeginInit();
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
			// fgrid_autoinfo
			// 
			this.fgrid_autoinfo.AllowEditing = false;
			this.fgrid_autoinfo.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_autoinfo.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_autoinfo.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_autoinfo.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_autoinfo.Location = new System.Drawing.Point(8, 40);
			this.fgrid_autoinfo.Name = "fgrid_autoinfo";
			this.fgrid_autoinfo.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_autoinfo.Size = new System.Drawing.Size(680, 392);
			this.fgrid_autoinfo.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_autoinfo.TabIndex = 98;
			this.fgrid_autoinfo.DoubleClick += new System.EventHandler(this.fgrid_autoinfo_DoubleClick);
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
			this.btn_save.Location = new System.Drawing.Point(608, 440);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(80, 23);
			this.btn_save.TabIndex = 106;
			this.btn_save.Visible = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(527, 440);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 105;
			this.btn_delete.Visible = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// img_Action
			// 
			this.img_Action.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Action.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Pop_PS_Auto_Info
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 468);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.fgrid_autoinfo);
			this.Name = "Pop_PS_Auto_Info";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_PS_Auto_Info_Closing);
			this.Load += new System.EventHandler(this.Pop_PS_Auto_Info_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_autoinfo, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.Controls.SetChildIndex(this.btn_save, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_autoinfo)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_Auto_Info_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.Text = "On Air";
			this.lbl_MainTitle.Text = "On Air";
			ClassLib.ComFunction.SetLangDic(this);
			oraDB = new COM.OraDB();


			if(ClassLib.ComVar.This_Admin_YN == "Y")
			{
				btn_save.Visible = true;
				btn_delete.Visible = true;
			}


			fgrid_autoinfo.Set_Grid("SPS_AUTO_INFO","2", 1,ClassLib.ComVar.This_Lang,COM.ComVar.Grid_Type.ForModify, false);
			_RowFixed = fgrid_autoinfo.Rows.Count;
			fgrid_autoinfo.Set_Action_Image(img_Action);
			fgrid_autoinfo.ExtendLastCol = false;
			Search();

		}


		private void Search()
		{
			fgrid_autoinfo.Rows.Count = _RowFixed;

			// 전체 행 모두 조회
			int max_display_row = -1; 
			DataTable dt = Select_SPS_Auto_Info(-1);

			int dt_row = dt.Rows.Count;
			int dt_col = dt.Columns.Count;

			ClassLib.ComFunction comfunc = new ERP.ClassLib.ComFunction();

			for(int i=0; i<dt_row; i++)
			{
				fgrid_autoinfo.Rows.Add();
				for(int j=0; j<dt_col; j++)
				{
					if(j==5)
					{
						
						fgrid_autoinfo[fgrid_autoinfo.Rows.Count-1, 1+j] = comfunc.ConvertDate2Type( dt.Rows[i].ItemArray[j].ToString());
					}
					else
					{
						fgrid_autoinfo[fgrid_autoinfo.Rows.Count-1, 1+j] = dt.Rows[i].ItemArray[j].ToString();
					}
				}
			}
		}



		/// <summary>
		/// Select_SPS_Auto_Info : 자동 업무 메시지 가져오기
		/// </summary>
		/// <returns>정상:DataTable  오류:null</returns>
		private DataTable Select_SPS_Auto_Info(int arg_max_display_row)
		{
			string Proc_Name = "PKG_SPS_HOME.SELECT_AUTO_INFO_1";

			oraDB.ReDim_Parameter(3);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_ROWNUM";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_max_display_row.ToString();
			oraDB.Parameter_Values[2] = "";

			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null;
			
			return  DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Delete_SPS_Auto_Info : 자동 업무 메시지 지우기
		/// </summary>
		private void Delete_SPS_Auto_Info(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_AUTO_INFO";

			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[1] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_autoinfo.Selection.r1;
			int sct_row2 = fgrid_autoinfo.Selection.r2+1;

			if(sct_row < _RowFixed) return;

			for(int i=sct_row; i<sct_row2; i++)
			{
				fgrid_autoinfo[i, 0] = "D";
			}
		}

		private void fgrid_autoinfo_DoubleClick(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_autoinfo.Selection.r1;

			if(fgrid_autoinfo[sct_row,0] != null)
			{
				if(fgrid_autoinfo[sct_row,0].ToString() == "D")
				{
					fgrid_autoinfo[sct_row, 0] = "";
				}
			}
		}

		private void btn_save_Click(object sender, System.EventArgs e)
		{
			for(int i=_RowFixed; i<fgrid_autoinfo.Rows.Count; i++)
			{
				if(fgrid_autoinfo[i,0] != null)
				{
					if(fgrid_autoinfo[i, 0].ToString() == "D")
					{
						string arg_seq = fgrid_autoinfo[i, 2].ToString(); 
						Delete_SPS_Auto_Info(arg_seq);

					}
				}
			}

			Search();
		}

		private void Pop_PS_Auto_Info_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				if(frm != null)
				{
					frm.Get_Auto_Info();
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_PS_Auto_Info_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		 



	}
}

