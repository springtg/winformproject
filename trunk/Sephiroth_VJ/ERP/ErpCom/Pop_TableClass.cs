using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
//using C1.C1PrintDocument;

namespace ERP.ErpCom
{
	public class Pop_TableClass : COM.APSWinForm.Pop_Large
	{
		private System.ComponentModel.IContainer components = null;

		public Pop_TableClass()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_TableClass));
			this.lbl_PKG = new System.Windows.Forms.Label();
			this.lbl_MakeEnum = new System.Windows.Forms.Label();
			this.txt_Class = new System.Windows.Forms.TextBox();
			this.lbl_MakeClass = new System.Windows.Forms.Label();
			this.btn_Search = new System.Windows.Forms.Label();
			this.txt_Desc = new System.Windows.Forms.TextBox();
			this.txt_Table = new System.Windows.Forms.TextBox();
			this.lbl_Desc = new System.Windows.Forms.Label();
			this.lbl_Table = new System.Windows.Forms.Label();
			this.fgrid_Sub = new COM.FSP();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Sub)).BeginInit();
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
			// lbl_PKG
			// 
			this.lbl_PKG.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_PKG.ImageIndex = 0;
			this.lbl_PKG.ImageList = this.img_Button;
			this.lbl_PKG.Location = new System.Drawing.Point(467, 44);
			this.lbl_PKG.Name = "lbl_PKG";
			this.lbl_PKG.Size = new System.Drawing.Size(72, 23);
			this.lbl_PKG.TabIndex = 113;
			this.lbl_PKG.Text = "PKG 문장";
			this.lbl_PKG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_PKG.Click += new System.EventHandler(this.lbl_PKG_Click);
			this.lbl_PKG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.lbl_PKG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lbl_MakeEnum
			// 
			this.lbl_MakeEnum.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MakeEnum.ImageIndex = 0;
			this.lbl_MakeEnum.ImageList = this.img_Button;
			this.lbl_MakeEnum.Location = new System.Drawing.Point(538, 44);
			this.lbl_MakeEnum.Name = "lbl_MakeEnum";
			this.lbl_MakeEnum.Size = new System.Drawing.Size(72, 23);
			this.lbl_MakeEnum.TabIndex = 112;
			this.lbl_MakeEnum.Text = "Enum문장";
			this.lbl_MakeEnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_MakeEnum.Click += new System.EventHandler(this.lbl_MakeEnum_Click);
			this.lbl_MakeEnum.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.lbl_MakeEnum.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_Class
			// 
			this.txt_Class.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Class.Location = new System.Drawing.Point(10, 232);
			this.txt_Class.Multiline = true;
			this.txt_Class.Name = "txt_Class";
			this.txt_Class.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txt_Class.Size = new System.Drawing.Size(670, 328);
			this.txt_Class.TabIndex = 111;
			this.txt_Class.Text = "";
			// 
			// lbl_MakeClass
			// 
			this.lbl_MakeClass.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_MakeClass.ImageIndex = 0;
			this.lbl_MakeClass.ImageList = this.img_Button;
			this.lbl_MakeClass.Location = new System.Drawing.Point(609, 44);
			this.lbl_MakeClass.Name = "lbl_MakeClass";
			this.lbl_MakeClass.Size = new System.Drawing.Size(72, 23);
			this.lbl_MakeClass.TabIndex = 110;
			this.lbl_MakeClass.Text = "클래스문장";
			this.lbl_MakeClass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_MakeClass.Click += new System.EventHandler(this.lbl_MakeClass_Click);
			this.lbl_MakeClass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.lbl_MakeClass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Search
			// 
			this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_Button;
			this.btn_Search.Location = new System.Drawing.Point(396, 44);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(72, 23);
			this.btn_Search.TabIndex = 109;
			this.btn_Search.Text = "테이블검색";
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			this.btn_Search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_Desc
			// 
			this.txt_Desc.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc.Enabled = false;
			this.txt_Desc.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc.Location = new System.Drawing.Point(111, 68);
			this.txt_Desc.MaxLength = 60;
			this.txt_Desc.Name = "txt_Desc";
			this.txt_Desc.ReadOnly = true;
			this.txt_Desc.Size = new System.Drawing.Size(570, 21);
			this.txt_Desc.TabIndex = 108;
			this.txt_Desc.Text = "";
			// 
			// txt_Table
			// 
			this.txt_Table.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Table.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Table.Location = new System.Drawing.Point(111, 46);
			this.txt_Table.MaxLength = 60;
			this.txt_Table.Name = "txt_Table";
			this.txt_Table.Size = new System.Drawing.Size(210, 21);
			this.txt_Table.TabIndex = 107;
			this.txt_Table.Text = "";
			// 
			// lbl_Desc
			// 
			this.lbl_Desc.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Desc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Desc.ImageIndex = 0;
			this.lbl_Desc.ImageList = this.img_Label;
			this.lbl_Desc.Location = new System.Drawing.Point(10, 68);
			this.lbl_Desc.Name = "lbl_Desc";
			this.lbl_Desc.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc.TabIndex = 106;
			this.lbl_Desc.Text = "테이블 설명";
			this.lbl_Desc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Table
			// 
			this.lbl_Table.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Table.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Table.ImageIndex = 0;
			this.lbl_Table.ImageList = this.img_Label;
			this.lbl_Table.Location = new System.Drawing.Point(10, 46);
			this.lbl_Table.Name = "lbl_Table";
			this.lbl_Table.Size = new System.Drawing.Size(100, 21);
			this.lbl_Table.TabIndex = 105;
			this.lbl_Table.Text = "테이블";
			this.lbl_Table.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// fgrid_Sub
			// 
			this.fgrid_Sub.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Sub.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Sub.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Sub.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Sub.Location = new System.Drawing.Point(10, 96);
			this.fgrid_Sub.Name = "fgrid_Sub";
			this.fgrid_Sub.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Sub.Size = new System.Drawing.Size(670, 128);
			this.fgrid_Sub.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:193, 221, 253;ForeColor:HighlightText;}	Focus{BackColor:193, 221, 253;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Sub.TabIndex = 104;
			// 
			// Pop_TableClass
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 575);
			this.Controls.Add(this.lbl_PKG);
			this.Controls.Add(this.lbl_MakeEnum);
			this.Controls.Add(this.txt_Class);
			this.Controls.Add(this.lbl_MakeClass);
			this.Controls.Add(this.btn_Search);
			this.Controls.Add(this.txt_Desc);
			this.Controls.Add(this.txt_Table);
			this.Controls.Add(this.lbl_Desc);
			this.Controls.Add(this.lbl_Table);
			this.Controls.Add(this.fgrid_Sub);
			this.Name = "Pop_TableClass";
			this.Text = "Column List of Table";
			this.Load += new System.EventHandler(this.Pop_TableClass_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.fgrid_Sub, 0);
			this.Controls.SetChildIndex(this.lbl_Table, 0);
			this.Controls.SetChildIndex(this.lbl_Desc, 0);
			this.Controls.SetChildIndex(this.txt_Table, 0);
			this.Controls.SetChildIndex(this.txt_Desc, 0);
			this.Controls.SetChildIndex(this.btn_Search, 0);
			this.Controls.SetChildIndex(this.lbl_MakeClass, 0);
			this.Controls.SetChildIndex(this.txt_Class, 0);
			this.Controls.SetChildIndex(this.lbl_MakeEnum, 0);
			this.Controls.SetChildIndex(this.lbl_PKG, 0);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Sub)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		

		#region 변수 정의

		//		int ixTable=1;
		int ixOrder=2;
		int ixColumn = 3;
		int ixDesc = 4;
		int ixDataType=5;
		int ixDataLenth=6;
		int ixPK_YN=9;
		private System.Windows.Forms.Label lbl_PKG;
		private System.Windows.Forms.Label lbl_MakeEnum;
		private System.Windows.Forms.TextBox txt_Class;
		private System.Windows.Forms.Label lbl_MakeClass;
		private System.Windows.Forms.Label btn_Search;
		private System.Windows.Forms.TextBox txt_Desc;
		private System.Windows.Forms.TextBox txt_Table;
		private System.Windows.Forms.Label lbl_Desc;
		private System.Windows.Forms.Label lbl_Table;
		public COM.FSP fgrid_Sub;

		private int _Rowfixed;

	
		#endregion

		#region 멤버 메서드
     

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			// 타이틀 지정
			this.Text ="Column List of Table";
			this.lbl_MainTitle.Text = "Column List of Table";
			ClassLib.ComFunction.SetLangDic(this);



			this.txt_Table.Text =COM.ComVar.Parameter_PopUp[0];
			this.txt_Desc.Text = COM.ComVar.Parameter_PopUp[1];

			// 그리드 설정
			this.fgrid_Sub.Set_Grid_Comm( "TABLE_COLUMN_DESC", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, true);  
			_Rowfixed = fgrid_Sub.Rows.Fixed;

			Select_SubData_List();


		}

		/// <summary>
		/// Select_SubData_List : 테이블에 대한 세부 칼럼 list
		/// </summary>
		private void Select_SubData_List()
		{

			COM.OraDB oraDB = new COM.OraDB();

			string Proc_Name = "PKG_SCM_TABLE.SELECT_TABLE_COLUMN";

			//// DB에서 언어 Dictionary 추출
			oraDB.ReDim_Parameter(2);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_TABLE_NAME";
			oraDB.Parameter_Name[1] = "OUT_CURSOR"; 

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = this.txt_Table.Text;
			oraDB.Parameter_Values[1] = "";

			oraDB.Add_Select_Parameter(false);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			//if(DS_Ret == null) return null ;
			
			DataTable dt_list = DS_Ret.Tables[Proc_Name];

			int i;

			fgrid_Sub.Rows.Count = _Rowfixed; 
			fgrid_Sub.Cols.Count = dt_list.Columns.Count + 1; 
 
			// Set List
			for(i=0; i < dt_list.Rows.Count; i++)
			{

				fgrid_Sub.AddItem(dt_list.Rows[i].ItemArray, fgrid_Sub.Rows.Count, 1);
				fgrid_Sub[i + _Rowfixed, 0] = ""; 

			} 

			fgrid_Sub.AutoSizeCols();

		}

		#endregion

		

		private void Pop_TableClass_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



		#region 이벤트 처리


		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Select_SubData_List();
		}

		private void lbl_MakeClass_Click(object sender, System.EventArgs e)
		{
			string str_text;
			str_text = "" ;
			str_text = str_text + "	/// <summary> " + "\r\n";
			str_text = str_text + "	/// " + this.txt_Table.Text + " 테이블 인덱스 Class \r\n";
			str_text = str_text + "	/// </summary> "+ "\r\n";
			str_text = str_text + "	public class TB" + this.txt_Table.Text + "\r\n";
			str_text = str_text + "	{ \r\n";

			for (int i=_Rowfixed ; i< fgrid_Sub.Rows.Count -1 ;i++)
			{
				str_text = str_text + "		public static int Ix" + fgrid_Sub[i,ixColumn] + " =" + fgrid_Sub[i,ixOrder] + ";			// " + fgrid_Sub[i,ixDesc]+ "	:" +fgrid_Sub[i,ixDataType] + "(" + fgrid_Sub[i,ixDataLenth] + ") \r\n";
			}
			str_text = str_text + "\r\n		public TB"+ this.txt_Table.Text + "() \r\n";
			str_text = str_text + "		{ \r\n";
			str_text = str_text + "		} \r\n";
			str_text = str_text + "	}  \r\n";

			this.txt_Class.Text = str_text;

		}

		private void lbl_MakeEnum_Click(object sender, System.EventArgs e)
		{
			string str_text;
			str_text = "" ;
			str_text = str_text + "	/// <summary> " + "\r\n";
			str_text = str_text + "	/// " + this.txt_Table.Text + " 테이블 인덱스 Enum \r\n";
			str_text = str_text + "	/// </summary> "+ "\r\n";
			str_text = str_text + "	public enum TB" + this.txt_Table.Text + " : int \r\n";
			str_text = str_text + "	{ \r\n";

			str_text = str_text + "		IxMaxCt = " + fgrid_Sub[fgrid_Sub.Rows.Count -1,ixOrder] + ",		// 인덱스 Count \r\n";
			for (int i=_Rowfixed ; i< fgrid_Sub.Rows.Count ;i++)
			{
				str_text = str_text + "		Ix" + fgrid_Sub[i,ixColumn] + " =" + fgrid_Sub[i,ixOrder] + ",			// " + fgrid_Sub[i,ixDesc]+ "	:" +fgrid_Sub[i,ixDataType] + "(" + fgrid_Sub[i,ixDataLenth] + ") \r\n";
			}
			str_text = str_text + "	}  \r\n";

			this.txt_Class.Text = str_text;
		}

		private void lbl_PKG_Click(object sender, System.EventArgs e)
		{
			string str_text;
			int j=0;
			str_text = "  \r\n" ;

			str_text = str_text + "	/*****************************/		\r\n";
			str_text = str_text + "	/*  " + this.txt_Table.Text +" 리스트 저장  */		\r\n";
			str_text = str_text + "	/*****************************/		\r\n";
			str_text = str_text + "    PROCEDURE SAVE_" + this.txt_Table.Text + " (  \r\n";
			str_text = str_text + "			  				  ARG_DIVISION IN  VARCHAR2, \r\n							  ";
			for(int i=_Rowfixed;  i< fgrid_Sub.Rows.Count-2 ;i++)
			{
				//str_text = str_text + "ARG_" + fgrid_Sub[i,ixColumn] + " IN  " + fgrid_Sub[i,ixDataType] + ", " ;
				str_text = str_text + "ARG_" + fgrid_Sub[i,ixColumn] + " IN  VARCHAR2, " ;
				j += 1;
				if(j>=3)
				{
					str_text = str_text + "	\r\n			  				  ";
					j=0;
				}
			}
			//str_text = str_text + "ARG_" + fgrid_Sub[fgrid_Sub.Rows.Count-2,ixColumn] + " IN  " + fgrid_Sub[fgrid_Sub.Rows.Count-2,ixDataType] + " )  \r\n";
			str_text = str_text + "ARG_" + fgrid_Sub[fgrid_Sub.Rows.Count-2,ixColumn] + " IN VARCHAR2 )  \r\n";
			str_text = str_text + "    IS \r\n\r\n";
			
//			str_text = str_text + "    SQL_ERR	   NUMBER; \r\n\r\n";

			str_text = str_text + "    BEGIN	\r\n\r\n";

			str_text = str_text + "		 IF ARG_DIVISION = 'I' THEN	\r\n\r\n";

			str_text = str_text + "		       INSERT INTO " + this.txt_Table.Text + "(" ;
			j=0;
			for(int i=_Rowfixed;  i< fgrid_Sub.Rows.Count-1 ;i++)
			{
				str_text = str_text + fgrid_Sub[i,ixColumn] + ",";
				j+= 1;
				if(j>=3)
				{
					str_text = str_text + "	\r\n					                ";		
					j=0;
				}
			}
			str_text = str_text + fgrid_Sub[fgrid_Sub.Rows.Count-1,ixColumn] +")	\r\n";
			if (fgrid_Sub[_Rowfixed,ixDataType].ToString() == "NUMBER")
			{
				str_text = str_text + "		       VALUES(NVL(TRIM(ARG_" + fgrid_Sub[_Rowfixed,ixColumn] + "), 0),";
			}	
			else
			{
				str_text = str_text + "		       VALUES(ARG_" + fgrid_Sub[_Rowfixed,ixColumn] + ",";
			}
			j=1;
			for(int i=_Rowfixed+1;  i< fgrid_Sub.Rows.Count-2 ;i++)
			{
				if (fgrid_Sub[i,ixDataType].ToString() == "NUMBER")
				{
					str_text = str_text  + "NVL(TRIM(ARG_" + fgrid_Sub[i,ixColumn] + "), 0),";
				}
				else
				{
					str_text = str_text  + "ARG_" + fgrid_Sub[i,ixColumn] + ",";
				}
				j+= 1;
				if(j>=3)
				{
					str_text = str_text + "	\r\n		              ";
					
					j=0;
				}
			}																		  
			str_text = str_text + "ARG_" + fgrid_Sub[fgrid_Sub.Rows.Count-2,ixColumn] + ",SYSDATE); \r\n\r\n";

			str_text = str_text + "		 ELSIF ARG_DIVISION = 'D' THEN	\r\n\r\n";

			str_text = str_text + "		 	   DELETE FROM " + this.txt_Table.Text ;
			for(int i=_Rowfixed;  i< fgrid_Sub.Rows.Count-1 ;i++)
			{
				if(fgrid_Sub[i,ixPK_YN].ToString()=="Y" && i==_Rowfixed)
				{
					str_text = str_text + "\r\n			         WHERE " + fgrid_Sub[i,ixColumn] + " = ARG_" + fgrid_Sub[i,ixColumn] ;
				}
				else if(fgrid_Sub[i,ixPK_YN].ToString()=="Y" )
				{
					str_text = str_text + "\r\n			           AND " + fgrid_Sub[i,ixColumn] + "= ARG_"+ fgrid_Sub[i,ixColumn] ;
				}
			}
			str_text = str_text + ";	\r\n\r\n";								   

			str_text = str_text + "		 ELSIF ARG_DIVISION = 'U' THEN	\r\n\r\n";

			str_text = str_text + "		 	   UPDATE " + this.txt_Table.Text+" SET \r\n";
			
			j=0;

			bool First = true;

			for(int i=_Rowfixed;  i< fgrid_Sub.Rows.Count-1 ;i++)
			{
				if(fgrid_Sub[i,ixPK_YN].ToString() != "Y")
				{
					if(First==true)
					{
						if (fgrid_Sub[i,ixDataType].ToString() == "NUMBER")
						{
							str_text = str_text + "			          " + fgrid_Sub[i,ixColumn] + " = NVL(TRIM(ARG_" + fgrid_Sub[i,ixColumn] + "), 0),";
						}
						else
						{
							str_text = str_text + "			          " + fgrid_Sub[i,ixColumn] + " = ARG_" + fgrid_Sub[i,ixColumn] + ",";
						}
						First=false;
					}
					else
					{
						if (fgrid_Sub[i,ixDataType].ToString() == "NUMBER")
						{
							str_text = str_text +  fgrid_Sub[i,ixColumn] + " = NVL(TRIM(ARG_" + fgrid_Sub[i,ixColumn]+ "), 0)," ;
						}
						else
						{
							str_text = str_text +  fgrid_Sub[i,ixColumn] + " = ARG_" + fgrid_Sub[i,ixColumn]+ "," ;
						}
					}
					j+= 1;
				}
				if(j>=3)
				{
					str_text = str_text + "	\r\n			          ";
					j=0;
				}
			}
			str_text = str_text + "UPD_YMD = SYSDATE  ";
			for(int i=_Rowfixed;  i< fgrid_Sub.Rows.Count -1;i++)
			{
				if(fgrid_Sub[i,ixPK_YN].ToString()=="Y" && i==_Rowfixed)
				{
					str_text = str_text + "\r\n			         WHERE " + fgrid_Sub[i,ixColumn] + " = ARG_" + fgrid_Sub[i,ixColumn] ;
				}
				else if(fgrid_Sub[i,ixPK_YN].ToString()=="Y" )
				{
					str_text = str_text + "\r\n			           AND " + fgrid_Sub[i,ixColumn] + "= ARG_"+ fgrid_Sub[i,ixColumn] ;
				}
			}
			str_text = str_text + ";	\r\n\r\n";
			str_text = str_text + "		 END IF;	\r\n\r\n";
//
//
//			str_text = str_text + "	EXCEPTION		\r\n";
//			str_text = str_text + "		WHEN OTHERS THEN		\r\n";
//			str_text = str_text + "		SQL_ERR  := SQLCODE;		\r\n";
//			str_text = str_text + "		DBMS_OUTPUT.PUT_LINE('#ERROR#'||SQLERRM||'#');		\r\n\r\n\r\n";


			str_text = str_text + "    END SAVE_"+ this.txt_Table.Text + "; \r\n";

			this.txt_Class.Text = str_text;

		}
	

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		
			Label src = sender as Label;
//			src.Update(); 

			src.ImageIndex = 1;

//			// apply to others
//			if (src.Equals(this.btn_Search))
//			{
//				btn_Search.ImageIndex = 1;
//			}
			 
 

		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
//			src.Update(); 

			src.ImageIndex = 0;
		}



		#endregion


		 
	} 
}

