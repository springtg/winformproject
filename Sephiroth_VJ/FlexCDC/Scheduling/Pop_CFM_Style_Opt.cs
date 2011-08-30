using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;
using System.Xml;
using System.IO;

namespace FlexCDC.Scheduling
{
	public class Pop_CFM_Style_Opt : COM.APSWinForm.Pop_Large
	{
		#region 컨트롤정의 및 리소스 정의
		private System.ComponentModel.IContainer components = null;

		private COM.OraDB OraDB = new COM.OraDB();
		private COM.FSP grdCFM;
		
		private Scheduling.Pop_CFM_Add sReqForm = null;
		private string sFactory = null;
		private string sSeason  = null;
		private string sDPO     = null;
		private string sStyleNo = null;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ImageList img_MiniButton;

		private int _RowFixed;
		//private string _form_type = null;
		//private SRF.Form_SD_SRFLoding srfLoding = null;
		//private int _TailRowFixed;
		//private Form_DB_Modelinfo modelInfo = null;
		//private string user_id = null;
		//private int loding_sct_row = 0;
		//private SRF.Form_SRFUPLoding srftest = null;
		//private string Group_Dir = null;



		public Pop_CFM_Style_Opt()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

	   
		#region 메인폼에 따른 변수정의 

		public Pop_CFM_Style_Opt(Scheduling.Pop_CFM_Add argReqForm, string argFactory, string argSeason, string argDPO, string argStyleNo)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			sReqForm = argReqForm;
			sFactory = argFactory;
			sSeason  = argSeason;
			sDPO     = argDPO;
			sStyleNo = argStyleNo;
		}

		#endregion 

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CFM_Style_Opt));
			this.grdCFM = new COM.FSP();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btnClose = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.grdCFM)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Location = new System.Drawing.Point(40, 12);
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			this.lbl_MainTitle.Size = new System.Drawing.Size(267, 22);
			this.lbl_MainTitle.Text = "Selected CFM Shoe Style";
			// 
			// grdCFM
			// 
			this.grdCFM.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.grdCFM.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.grdCFM.AutoResize = false;
			this.grdCFM.BackColor = System.Drawing.SystemColors.Window;
			this.grdCFM.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.grdCFM.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.grdCFM.Font = new System.Drawing.Font("굴림", 9F);
			this.grdCFM.ForeColor = System.Drawing.SystemColors.WindowText;
			this.grdCFM.Location = new System.Drawing.Point(7, 48);
			this.grdCFM.Name = "grdCFM";
			this.grdCFM.Rows.Fixed = 0;
			this.grdCFM.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.grdCFM.Size = new System.Drawing.Size(869, 384);
			this.grdCFM.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.grdCFM.TabIndex = 124;
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(792, 16);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 24);
			this.btnClose.TabIndex = 125;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// Pop_CFM_Style_Opt
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(882, 440);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.grdCFM);
			this.Name = "Pop_CFM_Style_Opt";
			this.Text = "Sample Request";
			this.Load += new System.EventHandler(this.Pop_CFM_Style_Opt_Load);
			this.Controls.SetChildIndex(this.grdCFM, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btnClose, 0);
			((System.ComponentModel.ISupportInitialize)(this.grdCFM)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	
		#region  메쏘드 정의 

		private void Init_Form()
		{
			grdCFM.Set_Grid("SDC_CFM_SCH_STYLE", "2", 2, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, true);
			//grdCFM.Mark_Grid_Menu();
			_RowFixed = grdCFM.Rows.Fixed;
			grdCFM.AutoSizeCols();

			//Show_grdCFM_Dat();
		}

		private void Show_grdCFM_Data()
		{
			grdCFM.Rows.Count = _RowFixed;

			DataTable vDt = Select_CFM_Style_Info();

			int dt_rows = vDt.Rows.Count;
			int dt_cols = vDt.Columns.Count;

			MessageBox.Show(dt_rows.ToString());

			for(int i=0; i<dt_rows; i++)
			{
				grdCFM.AddItem(vDt.Rows[i].ItemArray, grdCFM.Rows.Count, 1);
			}

			grdCFM.AutoSizeCols();
		}

		#endregion  

		#region DB 컨넥트

		/// <summary>
		/// SDC_PJ_HEAD,TAIL/SEM_OBS, SDC_STYLE : Style Information 
		/// </summary>
		/// <returns></returns>
		private DataTable Select_CFM_Style_Info()
		{
			string Proc_Name = "PKG_SDC_CFM.SELECT_SDC_CFM_STYLE_INFO";

			OraDB.ReDim_Parameter(5);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "ARG_FACTORY";
			OraDB.Parameter_Name[1] = "ARG_DPO_ID";
			OraDB.Parameter_Name[2] = "ARG_SEASON";
			OraDB.Parameter_Name[3] = "ARG_STYLENO";
			OraDB.Parameter_Name[4] = "OUT_CURSOR";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = sFactory;
			OraDB.Parameter_Values[1] = sSeason;
			OraDB.Parameter_Values[2] = sDPO;
			OraDB.Parameter_Values[3] = sStyleNo;
			OraDB.Parameter_Values[4] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		#endregion 

		private void Pop_CFM_Style_Opt_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void btnClose_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}



}

