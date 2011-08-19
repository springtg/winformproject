using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;


namespace FlexBase.MaterialBase
{
	public class Pop_GroupSearch : COM.PCHWinForm.Pop_Small
	{
		#region 컨트롤 정의 및 리소스 정리

		public COM.FSP fgrid_GroupTree;
		private System.ComponentModel.IContainer components = null;

		public Pop_GroupSearch()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			 
		}



		private string _GroupType = null;
		private string _Group_L = null;
		

		public Pop_GroupSearch(string arg_group_type, string arg_group_l)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
			
			_GroupType = arg_group_type;
			_Group_L = arg_group_l;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_GroupSearch));
            this.fgrid_GroupTree = new COM.FSP();
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_GroupTree)).BeginInit();
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
            this.lbl_MainTitle.Location = new System.Drawing.Point(34, 7);
            this.lbl_MainTitle.Size = new System.Drawing.Size(358, 22);
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
            // fgrid_GroupTree
            // 
            this.fgrid_GroupTree.BackColor = System.Drawing.SystemColors.Window;
            this.fgrid_GroupTree.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgrid_GroupTree.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgrid_GroupTree.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fgrid_GroupTree.Location = new System.Drawing.Point(7, 40);
            this.fgrid_GroupTree.Name = "fgrid_GroupTree";
            this.fgrid_GroupTree.Size = new System.Drawing.Size(380, 320);
            this.fgrid_GroupTree.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgrid_GroupTree.Styles"));
            this.fgrid_GroupTree.TabIndex = 164;
            this.fgrid_GroupTree.DoubleClick += new System.EventHandler(this.fgrid_GroupTree_DoubleClick);
            // 
            // Pop_GroupSearch
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(394, 368);
            this.Controls.Add(this.fgrid_GroupTree);
            this.Name = "Pop_GroupSearch";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Pop_GroupSearch_Closing);
            this.Controls.SetChildIndex(this.fgrid_GroupTree, 0);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            ((System.ComponentModel.ISupportInitialize)(this.fgrid_GroupTree)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의

		private int _Rowfixed = 2;
		public string Delete_Result = null;
		public int DeleteRow;
		public System.Windows.Forms.ImageList imageList1;
		public string arg_datamode;
		private COM.OraDB MyOraDB = new COM.OraDB();


		private string _GroupL = "", _GroupM = "";
		private string _GroupCd = "", _GroupName = "";
        private string _ManCharge_DS = "", _ManCharge_QD = "", _ManCharge_VJ = "", _ManCharge_JJ = "";



		#endregion 

		#region 멤버 메서드

		private void Init_Form()
		{
			try
			{
                this.Text = "Search Item Group";
                this.lbl_MainTitle.Text = "Search Item Group";
				ClassLib.ComFunction.SetLangDic(this);

				// 그리드 설정 Tree
				fgrid_GroupTree.Set_Grid("SBC_ITEM_GROUP", "2", 1, ClassLib.ComVar.This_Lang, ClassLib.ComVar.Grid_Type.ForModify, false);
                fgrid_GroupTree.ExtendLastCol = true;
				Select_Menu_List();
				SetCols();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
		}


		/// <summary>
		/// Select_Menu_List : 조회부에 맞는 데이터 그리드에 표시
		/// </summary>
		private void Select_Menu_List()
		{
			 
			DataTable dt_ret;
			//dt_ret = Select_Group(_GroupType);

			string group_type = ClassLib.ComFunction.Empty_String(_GroupType, " ");
			string group_l = ClassLib.ComFunction.Empty_String(_Group_L, " ");
			string group_level = _Level_SecondClass.ToString();

			dt_ret = Select_Group_List(group_type, group_l, group_level);


			fgrid_GroupTree.Rows.Count = _Rowfixed;
			fgrid_GroupTree.Cols.Count = dt_ret.Columns.Count + 1; 

			for(int i = 0; i < dt_ret.Rows.Count; i++)
			{
				fgrid_GroupTree.Rows.InsertNode(i + _Rowfixed,int.Parse(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_LEVEL-1].ToString()) - 1 );
				insertcell(i, dt_ret.Rows[i].ItemArray);

				Draw_Color(dt_ret.Rows[i].ItemArray[(int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_LEVEL - 1].ToString(), i + _Rowfixed);
			}

			SetCols();

			dt_ret.Dispose();
			 
		}



		/// <summary>
		/// Draw_Color : 레벨 별 행 색깔 지정
		/// </summary>
		/// <param name="arg_level"></param>
		private void Draw_Color(string arg_level, int arg_selrow)
		{
			System.Drawing.Color row_color = Color.Empty;

			switch(Convert.ToInt32(arg_level) )
			{
					// group type
				case 1:
					row_color = ClassLib.ComVar.ClrLevel_1st;
					break;
					
					// first class
				case 2:
					row_color = ClassLib.ComVar.ClrLevel_2nd;
					break;
					
					// second class
				case 3:
					row_color = ClassLib.ComVar.ClrLevel_3rd;
					break;
					
					// third class
				case 4: 
					break; 

			} // end switch

			fgrid_GroupTree.GetCellRange(arg_selrow, 1, arg_selrow, fgrid_GroupTree.Cols.Count - 1).StyleNew.BackColor = row_color;
		}



		/// <summary>
		/// insertcell : 그리드에 값 넣기
		/// </summary>
		/// <param name="arg_row"></param>
		/// <param name="arg_incell"></param>
		private void insertcell(int arg_row, object[] arg_incell)
		{
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxDIVISION] = "";
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_NAME] = arg_incell[0].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_CD] = arg_incell[1].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_LEVEL] = arg_incell[2].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_TYPE] = arg_incell[3].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_L] = arg_incell[4].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_M] = arg_incell[5].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_S] = arg_incell[6].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_DS] = arg_incell[7].ToString();
			fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_QD] = arg_incell[8].ToString();
            fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_VJ] = arg_incell[9].ToString();
            fgrid_GroupTree[arg_row + _Rowfixed, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_JJ] = arg_incell[10].ToString();

		}

		/// <summary>
		/// setCols : 그리드를 트리 형식으로 표시
		/// </summary>
		private void SetCols()
		{
			fgrid_GroupTree.Tree.Column = (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_NAME;
			fgrid_GroupTree.Tree.Show(2);
		}

	 

		#endregion 

		#region 이벤트 처리

		private void Pop_GroupSearch_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			ClassLib.ComVar.Parameter_PopUp = new string[] {_GroupType, 
															   _GroupL, 
															   _GroupM, 
															   _GroupCd, 
															   _GroupName,
			                                                   _ManCharge_DS,
			                                                   _ManCharge_QD,
			                                                   _ManCharge_VJ,
                                                               _ManCharge_JJ};
		}

		#region 이벤트_그리드 관련

		/// <summary>
		/// 그리드 더블 클릭시
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void fgrid_GroupTree_DoubleClick(object sender, System.EventArgs e)
		{
			Return_GroupCode();
		}



		// 마지막 아이템 그룹 레벨
		private int _Level_SecondClass = 3;
		//private int _Level_ThirdClass = 4;



		/// <summary>
		/// Return_GroupCode : 
		/// </summary>
		private void Return_GroupCode()
		{
			try
			{
				int sel_row = 0, sel_level = 0; 

				sel_row = fgrid_GroupTree.Selection.r1; 
				if(sel_row < fgrid_GroupTree.Rows.Fixed) return;
				
				sel_level = Convert.ToInt32(fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_LEVEL].ToString() );
				if(sel_level != _Level_SecondClass) //!= _Level_ThirdClass) 
				{
					//ClassLib.ComFunction.User_Message("Return Only Third Class", "Item Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					ClassLib.ComFunction.User_Message("Return Only Second Class", "Item Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
 
				//DataTable dt_ret;

				_GroupCd = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_CD].ToString();
				//dt_ret = Check_Duplicate_DB(_GroupCd);
 

				string group_type = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP.IxGROUP_TYPE].ToString();

				//bool return_yn = Convert.IsDBNull(dt_ret.Rows[0].ItemArray[0]);
				bool return_yn = true;



				// 중복 아님, 저장 가능
				if(return_yn)  
				{
					_GroupL = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_L].ToString();
					_GroupM = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_M].ToString(); 
					_GroupName = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxGROUP_NAME].ToString(); 

					_ManCharge_DS = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_DS].ToString(); 
					_ManCharge_QD = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_QD].ToString();
                    _ManCharge_VJ = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_VJ].ToString();
                    _ManCharge_JJ = fgrid_GroupTree[sel_row, (int)ClassLib.TBSBC_ITEM_GROUP_SEARCH.IxMAN_CHARGE_JJ].ToString(); 


					//dt_ret.Dispose(); 
					this.Close();

				} // end if
				else
				{
					ClassLib.ComFunction.User_Message("Duplicate Group Code : [" + _GroupCd + "]", "Return", MessageBoxButtons.OK, MessageBoxIcon.Error);

					_GroupCd = "";
					_GroupL = "";
					_GroupM = "";
					_GroupName = "";

					_ManCharge_DS = ""; 
					_ManCharge_QD = "";
                    _ManCharge_VJ = "";
                    _ManCharge_JJ = ""; 

					//dt_ret.Dispose(); 

				} 

			}

			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message( ex.Message,"Return_GroupCode",MessageBoxButtons.OK,MessageBoxIcon.Error); 
			}
		}



		

		#endregion

		#endregion
		
		#region DB Connect

		/// <summary>
		/// Group 조회
		/// </summary>
		/// <returns></returns>
		public static DataTable Select_Group(string arg_group_type)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			DataSet ds_ret;
			string process_name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE";

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_GROUP_TYPE"; 
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_group_type; 
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ; 
			return ds_ret.Tables[process_name]; 
		}




		/// <summary>
		/// Select_Group_List : Group List 조회
		/// </summary>
		/// <returns></returns>
		private DataTable Select_Group_List(string arg_group_type, string arg_group_l, string arg_group_level)
		{
			 
			DataSet ds_ret;
			string process_name = "PKG_SBC_ITEM_GROUP.SELECT_SBC_ITEM_GROUP_TYPE_2";

			MyOraDB.ReDim_Parameter(4); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_GROUP_TYPE";
			MyOraDB.Parameter_Name[1] = "ARG_GROUP_L";
			MyOraDB.Parameter_Name[2] = "ARG_GROUP_LEVEL";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = arg_group_type; 
			MyOraDB.Parameter_Values[1] = arg_group_l;
			MyOraDB.Parameter_Values[2] = arg_group_level;
			MyOraDB.Parameter_Values[3] = "";

			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 
		}







		/// <summary>
		/// Check_Duplicate_DB : 
		/// </summary>
		///<param name="arg_groupcd"></param>
		/// <returns></returns>
		private DataTable Check_Duplicate_DB(string arg_groupcd)
		{  
			try
			{
				DataSet ds_ret;  

				MyOraDB.ReDim_Parameter(2);
				MyOraDB.Process_Name = "PKG_SBC_ITEM.CHECK_GROUP_CD_EXIST"; 
				
				MyOraDB.Parameter_Name[0] = "ARG_GROUP_CD"; 
				MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor; 

				MyOraDB.Parameter_Values[0] = @"'" + arg_groupcd + @"'";
				MyOraDB.Parameter_Values[1] = ""; 
				 
				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null; 
				return ds_ret.Tables[MyOraDB.Process_Name]; 
				  

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Check_Duplicate_DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			} 
		}


		#endregion




	}
}

