using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexBase.MaterialBase
{
	public class Pop_Mcs : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox grp_Mcs;
		private System.Windows.Forms.Label lbl_Mcs_Name;
		private System.Windows.Forms.Label lbl_Mcs_Cd;
		public COM.FSP fgrid_Mcs;
		private System.Windows.Forms.TextBox txt_Mcs_Name;
		private C1.Win.C1List.C1Combo cmb_Mcs;
		private System.Windows.Forms.Label btn_Mcs;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_apply;
		private System.ComponentModel.IContainer components = null;


		public Pop_Mcs()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			Init_Form();

		}


		private string _McsCd = "", _McsName = "";

		public Pop_Mcs(string arg_mcscd, 
			string arg_mcsname)
		{ 
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			_McsCd = arg_mcscd;
			_McsName = arg_mcsname;
			

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_Mcs));
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            this.grp_Mcs = new System.Windows.Forms.GroupBox();
            this.btn_Mcs = new System.Windows.Forms.Label();
            this.txt_Mcs_Name = new System.Windows.Forms.TextBox();
            this.cmb_Mcs = new C1.Win.C1List.C1Combo();
            this.lbl_Mcs_Name = new System.Windows.Forms.Label();
            this.lbl_Mcs_Cd = new System.Windows.Forms.Label();
            this.fgrid_Mcs = new COM.FSP();
            this.btn_close = new System.Windows.Forms.Label();
            this.btn_apply = new System.Windows.Forms.Label();
            this.grp_Mcs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).BeginInit();
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
            // grp_Mcs
            // 
            this.grp_Mcs.BackColor = System.Drawing.SystemColors.Window;
            this.grp_Mcs.Controls.Add(this.btn_Mcs);
            this.grp_Mcs.Controls.Add(this.txt_Mcs_Name);
            this.grp_Mcs.Controls.Add(this.cmb_Mcs);
            this.grp_Mcs.Controls.Add(this.lbl_Mcs_Name);
            this.grp_Mcs.Controls.Add(this.lbl_Mcs_Cd);
            this.grp_Mcs.Location = new System.Drawing.Point(5, 32);
            this.grp_Mcs.Name = "grp_Mcs";
            this.grp_Mcs.Size = new System.Drawing.Size(386, 66);
            this.grp_Mcs.TabIndex = 30;
            this.grp_Mcs.TabStop = false;
            // 
            // btn_Mcs
            // 
            this.btn_Mcs.ImageIndex = 27;
            this.btn_Mcs.ImageList = this.img_SmallButton;
            this.btn_Mcs.Location = new System.Drawing.Point(357, 14);
            this.btn_Mcs.Name = "btn_Mcs";
            this.btn_Mcs.Size = new System.Drawing.Size(21, 21);
            this.btn_Mcs.TabIndex = 669;
            this.btn_Mcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Mcs.Click += new System.EventHandler(this.btn_Mcs_Click);
            // 
            // txt_Mcs_Name
            // 
            this.txt_Mcs_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Mcs_Name.Font = new System.Drawing.Font("굴림", 9F);
            this.txt_Mcs_Name.Location = new System.Drawing.Point(108, 36);
            this.txt_Mcs_Name.Name = "txt_Mcs_Name";
            this.txt_Mcs_Name.Size = new System.Drawing.Size(270, 21);
            this.txt_Mcs_Name.TabIndex = 177;
            this.txt_Mcs_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mcs_Name_KeyPress);
            // 
            // cmb_Mcs
            // 
            this.cmb_Mcs.AddItemSeparator = ';';
            this.cmb_Mcs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmb_Mcs.Caption = "";
            this.cmb_Mcs.CaptionHeight = 17;
            this.cmb_Mcs.CaptionStyle = style9;
            this.cmb_Mcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmb_Mcs.ColumnCaptionHeight = 18;
            this.cmb_Mcs.ColumnFooterHeight = 18;
            this.cmb_Mcs.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmb_Mcs.ContentHeight = 17;
            this.cmb_Mcs.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmb_Mcs.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmb_Mcs.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmb_Mcs.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mcs.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Mcs.EditorHeight = 17;
            this.cmb_Mcs.EvenRowStyle = style10;
            this.cmb_Mcs.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Mcs.FooterStyle = style11;
            this.cmb_Mcs.HeadingStyle = style12;
            this.cmb_Mcs.HighLightRowStyle = style13;
            this.cmb_Mcs.Images.Add(((System.Drawing.Image)(resources.GetObject("cmb_Mcs.Images"))));
            this.cmb_Mcs.ItemHeight = 15;
            this.cmb_Mcs.Location = new System.Drawing.Point(108, 14);
            this.cmb_Mcs.MatchEntryTimeout = ((long)(2000));
            this.cmb_Mcs.MaxDropDownItems = ((short)(5));
            this.cmb_Mcs.MaxLength = 32767;
            this.cmb_Mcs.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmb_Mcs.Name = "cmb_Mcs";
            this.cmb_Mcs.OddRowStyle = style14;
            this.cmb_Mcs.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.cmb_Mcs.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cmb_Mcs.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmb_Mcs.SelectedStyle = style15;
            this.cmb_Mcs.Size = new System.Drawing.Size(248, 21);
            this.cmb_Mcs.Style = style16;
            this.cmb_Mcs.TabIndex = 175;
            this.cmb_Mcs.SelectedValueChanged += new System.EventHandler(this.cmb_Mcs_SelectedValueChanged);
            this.cmb_Mcs.PropBag = resources.GetString("cmb_Mcs.PropBag");
            // 
            // lbl_Mcs_Name
            // 
            this.lbl_Mcs_Name.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mcs_Name.ImageIndex = 0;
            this.lbl_Mcs_Name.ImageList = this.img_Label;
            this.lbl_Mcs_Name.Location = new System.Drawing.Point(8, 36);
            this.lbl_Mcs_Name.Name = "lbl_Mcs_Name";
            this.lbl_Mcs_Name.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mcs_Name.TabIndex = 173;
            this.lbl_Mcs_Name.Text = "Mcs Name";
            this.lbl_Mcs_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Mcs_Cd
            // 
            this.lbl_Mcs_Cd.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mcs_Cd.ImageIndex = 0;
            this.lbl_Mcs_Cd.ImageList = this.img_Label;
            this.lbl_Mcs_Cd.Location = new System.Drawing.Point(8, 14);
            this.lbl_Mcs_Cd.Name = "lbl_Mcs_Cd";
            this.lbl_Mcs_Cd.Size = new System.Drawing.Size(100, 21);
            this.lbl_Mcs_Cd.TabIndex = 172;
            this.lbl_Mcs_Cd.Text = "Mcs Code";
            this.lbl_Mcs_Cd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fgrid_Mcs
            // 
            this.fgrid_Mcs.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_Mcs.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_Mcs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fgrid_Mcs.Location = new System.Drawing.Point(5, 100);
            this.fgrid_Mcs.Name = "fgrid_Mcs";
            this.fgrid_Mcs.Rows.DefaultSize = 18;
            this.fgrid_Mcs.Size = new System.Drawing.Size(384, 275);
            this.fgrid_Mcs.StyleInfo = resources.GetString("fgrid_Mcs.StyleInfo");
            this.fgrid_Mcs.TabIndex = 170;
            this.fgrid_Mcs.DoubleClick += new System.EventHandler(this.fgrid_Mcs_DoubleClick);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_close.ImageIndex = 0;
            this.btn_close.ImageList = this.img_Button;
            this.btn_close.Location = new System.Drawing.Point(317, 380);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(70, 24);
            this.btn_close.TabIndex = 546;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_apply.ImageIndex = 0;
            this.btn_apply.ImageList = this.img_Button;
            this.btn_apply.Location = new System.Drawing.Point(246, 380);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(70, 24);
            this.btn_apply.TabIndex = 545;
            this.btn_apply.Text = "Apply";
            this.btn_apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Pop_Mcs
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 408);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.fgrid_Mcs);
            this.Controls.Add(this.grp_Mcs);
            this.Name = "Pop_Mcs";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_Mcs_Closing);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.grp_Mcs, 0);
            this.Controls.SetChildIndex(this.fgrid_Mcs, 0);
            this.Controls.SetChildIndex(this.btn_apply, 0);
            this.Controls.SetChildIndex(this.btn_close, 0);
            this.grp_Mcs.ResumeLayout(false);
            this.grp_Mcs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_Mcs)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region 변수정의

		int _Rowfixed = 2;
		private COM.OraDB _MyOraDB = new COM.OraDB();
		
		#endregion

		#region 멤버메쏘드
		private void Init_Form()
		{
            try
            {

                //DataTable dt_list;
                //Title
                this.Text = "Mcs Search";
                lbl_MainTitle.Text = "Mcs Search";
                ClassLib.ComFunction.SetLangDic(this);

                // 그리드 설정
                fgrid_Mcs.Set_Grid("SBC_MCS", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);

               
                DataTable dt_list;             
                dt_list = SelectMcs();               
                ClassLib.ComCtl.Set_ComboList_AddItem(dt_list, cmb_Mcs, 0, 1);
               

                SetMcs();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "SetMcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

		}

		/// <summary>
		///  DisPlayMcs: Mcs  뿌리기
		/// </summary>
		/// <returns></returns>
		private void DisPlayMcs(DataTable arg_dt)
		{
			fgrid_Mcs.Rows.Count = _Rowfixed;

			for (int i =0; i < arg_dt.Rows.Count ; i++)
			{   
             	fgrid_Mcs.Rows.Insert(_Rowfixed+i);
			
				for (int  j=0 ;j<arg_dt.Columns.Count ;j++)
				{  					
					if (arg_dt.Rows[i].ItemArray[j] == null)  break;
					fgrid_Mcs[i+ _Rowfixed,j+1] =  ClassLib.ComFunction.Empty_String(arg_dt.Rows[i].ItemArray[j].ToString()," ");
				}

			}

		}



		/// <summary>
		/// SetMcs: Mcs Display
		/// </summary>
		/// <returns></returns>
		private void SetMcs()
		{
			
			try
			{

				DataTable dt_list;

				dt_list = SelectMcs();
				DisPlayMcs(dt_list);

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "SetMcs", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}




		#endregion

		#region DB컨넥트
		/// <summary>
		/// SelectMcsCode: Mcs Code  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectMcsCode()
		{

			DataSet ds_ret; int iCnt;
			
			iCnt  =  3;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_MCS.SELECT_SBC_MCS";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			_MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			_MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = " ";
			_MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_Combo(cmb_Mcs," ");
			_MyOraDB.Parameter_Values[2] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}


	
		/// <summary>
		///  SelectMcs:Mcs  조회
		/// </summary>
		/// <returns></returns>
		public DataTable SelectMcs()
		{

			DataSet ds_ret; int iCnt;
			
			iCnt  =  3;
			_MyOraDB.ReDim_Parameter(iCnt); 

			//01.PROCEDURE명
			_MyOraDB.Process_Name = "PKG_SBC_MCS.SELECT_SBC_MCS";
 
			//02.ARGURMENT명
			_MyOraDB.Parameter_Name[0] = "ARG_VALUE1";
			_MyOraDB.Parameter_Name[1] = "ARG_VALUE2";
			_MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			_MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			_MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			_MyOraDB.Parameter_Values[0] = COM.ComFunction.Empty_Combo(cmb_Mcs," ");
			_MyOraDB.Parameter_Values[1] = COM.ComFunction.Empty_String(txt_Mcs_Name.Text.ToUpper()," ");
			_MyOraDB.Parameter_Values[2] = ""; 

			_MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = _MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[_MyOraDB.Process_Name]; 
		}


		#endregion

		#region 이벤트처리
		
		
		private void btn_apply_Click(object sender, System.EventArgs e)
		{
			this.Close();		
		}

		
		private void btn_close_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}


		private void btn_Mcs_Click(object sender, System.EventArgs e)
		{
		
			SetMcs();

		}

		private void cmb_Mcs_SelectedValueChanged(object sender, System.EventArgs e)
		{
			SetMcs();
		}


		private void txt_Mcs_Name_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			

			if(e.KeyChar == (char)13)
			{
				SetMcs();
				
			}
		}


		private void Pop_Mcs_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				COM.ComVar.Parameter_PopUp = new string[]
					{
						fgrid_Mcs[fgrid_Mcs.Selection.r1,(int)ClassLib.TBSBC_MCS.IxMCS_CD].ToString(),
						fgrid_Mcs[fgrid_Mcs.Selection.r1,(int)ClassLib.TBSBC_MCS.IxMCS_NAME].ToString()
					};
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Pop_Mcs_Closing", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}

		
		private void fgrid_Mcs_DoubleClick(object sender, System.EventArgs e)
		{
			this.Close();
		}


	    #endregion


	}
}