using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid; 
using Lassalle.Flow;

namespace FlexAPS.ClassLib
{
	/// <summary>
	/// Common_Function에 대한 요약 설명입니다.
	/// </summary>
	public class ComFunction : COM.ComFunction
	{
		public ComFunction()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}
 
 

		#region AddFlow 적용 함수


		/// <summary>
		/// Clear_AddFlow : AddFlow 초기화
		/// </summary>
		public static void Clear_AddFlow(Lassalle.Flow.AddFlow arg_addflow)
		{
			arg_addflow.Items.Clear();
			arg_addflow.ResetDefNodeProp();
			arg_addflow.ResetDefLinkProp();
			arg_addflow.ResetGrid();
			arg_addflow.ResetText();
			ComFunction.Set_DefNodeProp(arg_addflow);
 
			arg_addflow.BackColor = Color.White;
			arg_addflow.Grid.Draw = true;
			arg_addflow.Grid.Snap = false;
			arg_addflow.Grid.Style = GridStyle.DottedLines;
			arg_addflow.Grid.Color = Color.Silver;
			arg_addflow.Grid.Size = new Size(10, 10);
 

		}



		/// <summary>
		/// default node 속성 정의
		/// </summary>
		/// <param name="sType"></param> 
		public static void Set_DefNodeProp(Lassalle.Flow.AddFlow arg_addflow)
		{ 
			 
			arg_addflow.DefNodeProp.Alignment = Alignment.CenterMIDDLE;
			arg_addflow.DefNodeProp.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			arg_addflow.DefNodeProp.DrawColor = Color.Black;
			arg_addflow.DefNodeProp.DrawWidth = 1;
			arg_addflow.DefNodeProp.FillColor = Color.White; 
			arg_addflow.DefNodeProp.Font = ComFunction.ToFont(""); 
			arg_addflow.DefNodeProp.Gradient = false; 
			arg_addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle; 
			arg_addflow.DefNodeProp.TextColor = Color.Black; 
			
		}



		/// <summary>
		/// Font string 분리해서 Font 스타일 만들기
		/// </summary>
		/// <param name="sfont"></param>
		/// <returns></returns>
		public static Font ToFont(string arg_font)
		{     
			string familyName = "";
			float size = 0;
			FontStyle style = FontStyle.Regular;

			if(arg_font != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_font.Split(delimiter); 
  
				familyName = token[0].ToString();
				size = Convert.ToSingle(token[1]);
				
				if (Convert.ToBoolean(token[2]))
				{
					style = style | FontStyle.Bold;
				}

				if (Convert.ToBoolean(token[3]))
				{
					style = style | FontStyle.Italic;
				}

				if (Convert.ToBoolean(token[4]))
				{
					style = style | FontStyle.Strikeout;
				}

				if (Convert.ToBoolean(token[5]))
				{
					style = style | FontStyle.Underline;
				}

				return new Font(familyName, size, style);  
			}
			else
			{
				return new Font("Verdana", 6);
			} 
			
		}





		/// <summary>
		/// 노드 정보 가져오기
		/// </summary>
		public static void Set_NodeProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Node arg_node, int arg_index)
		{ 
			   
			double width = 0, height = 0;

			//Alignment
			foreach (Alignment v in Enum.GetValues(typeof(Alignment)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxALIGNMENT].ToString() == v.GetHashCode().ToString())
				{
					arg_node.Alignment = v; 
					break;
				}
			}

			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_node.DashStyle = v;
					break;
				}
			}


            if (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWCOLOR] == null
                || arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWCOLOR].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_node.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWCOLOR].ToString()));
            }


            if (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWWIDTH] == null
                || arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWWIDTH].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_node.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxDRAWWIDTH].ToString());
            }


            if (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFILLCOLOR] == null
                || arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFILLCOLOR].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_node.FillColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFILLCOLOR].ToString()));
            }


			//Font 속성
			arg_node.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxFONT].ToString());


			//Gradient 속성
			arg_node.Gradient = (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADI_YN].ToString() == "Y" ? true : false);

			if (arg_node.Gradient)
			{
				arg_node.GradientColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADICOLOR].ToString()));
				
				foreach (System.Drawing.Drawing2D.LinearGradientMode v in Enum.GetValues(typeof(System.Drawing.Drawing2D.LinearGradientMode)))
				{
					if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxGRADIMODE].ToString() == v.GetHashCode().ToString())
					{
						arg_node.GradientMode = v;
						break;
					}
				}
			}   //end if
    
			//Shaow 
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHADOW].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHADOW].ToString().Split(delimiter); 

				/////shadow -> style
				foreach (ShadowStyle v in Enum.GetValues(typeof(ShadowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shadow.Style = v;
						break;
					}
				}
              
				/////shadow -> color, width, height
				arg_node.Shadow.Color = Color.FromArgb(Convert.ToInt32(token[1]));
				arg_node.Shadow.Size = new Size(Convert.ToInt32(token[2]), Convert.ToInt32(token[3]));

			}

			//Shape
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHAPE].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxSHAPE].ToString().Split(delimiter); 

				////shape -> style
				foreach (ShapeStyle v in Enum.GetValues(typeof(ShapeStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Style = v;
						break;
					}
				}  
		 
				////shape -> orientation
				foreach (ShapeOrientation v in Enum.GetValues(typeof(ShapeOrientation)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_node.Shape.Orientation = v;
						break;
					}
				}  
			} 

			//Node Size
			if(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxWIDTH].ToString() != "" && arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxHEIGHT].ToString() != "")
			{
				width = Convert.ToDouble(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxWIDTH].ToString());
				height = Convert.ToDouble(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxHEIGHT].ToString());

				arg_node.Size = new Size((int)width, (int)height);
 
			}
  
			//TextColor
            if (arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxTEXTCOLOR] == null
                || arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxTEXTCOLOR].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_node.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.NODE_DEF.IxTEXTCOLOR].ToString()));
            }

		}


		/// <summary>
		///Set_LinkProp : link 속성 정의
		/// </summary>
		public static void Set_LinkProp(C1FlexGrid arg_fgrid, Lassalle.Flow.Link arg_link, int arg_index)
		{
			 
		
			//ALLOW_DST 
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_DST].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_DST].ToString().Split(delimiter); 

				////allow_Dst -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Style = v;
						break;
					}
				}

				////allow_Dst -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Size = v;
						break;
					}
				}  

				////allow_Dst -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowDst.Angle = v;
						break;
					}
				}

				////allow_Dst -> Filled 
				arg_link.ArrowDst.Filled = Convert.ToBoolean(token[3]);

			}


			//ALLOW_MID 
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_MID].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_MID].ToString().Split(delimiter); 

				////allow_Mid -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Style = v;
						break;
					}
				}

				////allow_Mid -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Size = v;
						break;
					}
				}  

				////allow_Mid -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowMid.Angle = v;
						break;
					}
				}

				////allow_Mid -> Filled 
				arg_link.ArrowMid.Filled = Convert.ToBoolean(token[3]);

			}


			//ALLOW_ORG
			if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_ORG].ToString() != "")
			{
				char[] delimiter = "/".ToCharArray();
				string[] token = null; 

				token = arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxARROW_ORG].ToString().Split(delimiter); 

				////allow_Org -> style(head)
				foreach (Lassalle.Flow.ArrowStyle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowStyle)))
				{
					if(token[0] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Style = v;
						break;
					}
				}

				////allow_Org -> size
				foreach (Lassalle.Flow.ArrowSize v in Enum.GetValues(typeof(Lassalle.Flow.ArrowSize)))
				{
					if(token[1] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Size = v;
						break;
					}
				}  

				////allow_Org -> Angle
				foreach (Lassalle.Flow.ArrowAngle v in Enum.GetValues(typeof(Lassalle.Flow.ArrowAngle)))
				{
					if(token[2] == v.GetHashCode().ToString())
					{
						arg_link.ArrowOrg.Angle = v;
						break;
					}
				}

				////allow_Org -> Filled 
				arg_link.ArrowOrg.Filled = Convert.ToBoolean(token[3]);

			}

	
			//DashStyle
			foreach (System.Drawing.Drawing2D.DashStyle v in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)))
			{
				if(arg_fgrid[arg_index,(int)ClassLib.LINK_DEF.IxDASHSTYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_link.DashStyle = v;
					break;
				}
			}

            if (arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWCOLOR] == null
                || arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWCOLOR].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_link.DrawColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWCOLOR].ToString()));
            }

            if (arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWWIDTH] == null
                || arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWWIDTH].ToString().Trim().Equals(""))
            {
            }
            else
            {
                arg_link.DrawWidth = Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxDRAWWIDTH].ToString());
            }


			//Font 속성
			arg_link.Font = ClassLib.ComFunction.ToFont(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxFONT].ToString()); 
 
	 
			//Jump 속성
			foreach (Jump v in Enum.GetValues(typeof(Jump)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxJUMP].ToString().ToString() == v.GetHashCode().ToString())
				{
					arg_link.Jump = v; 
					break;
				}
			}

			//Line -> Style
			foreach (LineStyle v in Enum.GetValues(typeof(LineStyle)))
			{
				if(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxLINE_STYLE].ToString() == v.GetHashCode().ToString())
				{
					arg_link.Line.Style = v; 
					break;
				}
			}

			//Line -> RoundCorner
			arg_link.Line.RoundedCorner = Convert.ToBoolean(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxLINE_ROUND].ToString());

			//			//Tag
			//			arg_link.Tag = arg_fgrid[arg_index, _BLTag_ix].ToString();

			//Text

            ////TextColor
            //if (arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxTEXTCOLOR].ToString().Trim() != "")
            //{
            //    arg_link.TextColor = Color.FromArgb(Convert.ToInt32(arg_fgrid[arg_index, (int)ClassLib.LINK_DEF.IxTEXTCOLOR].ToString()));
            //}
			

			//ToolTip
 

//			// 노드 내부까지 라인 표시 옵션
//			arg_link.AdjustOrg = true;
//			arg_link.AdjustDst = true;

			// 링크 좌표 설정 가능
//            link = .Nodes(7).OutLinks.Add(.Nodes(0))
//            link.Points(0) = New PointF(350, 240)
//            link.Points(1) = New PointF(464, 64)



		}



		/// <summary>
		/// Get_Index : 실제 노드 인덱스 번호로 그려질때 인덱스 가져오기
		/// 그려질때는 실제 노드 인덱스 사용 못함 (중간에 삭제된것 있을 수 있으므로)
		/// </summary>
		/// <param name="arg_fgrid">해당 데이터 그리드</param>
		/// <param name="arg_nodeix">org, dst 노드 번호</param>
		/// <param name="arg_index">그리드에서 노드 인덱스 번호</param>
		/// <returns></returns>
		public static int Get_Index(C1FlexGrid arg_fgrid, string arg_nodeix, int arg_index, int arg_rowfixed)
		{
			int i;
			int temp_row = 0;
			int temp_nodecd = 0; 
			string node_cd = "";
			int node_cd_length = 0;


			for(i = arg_rowfixed; i < arg_fgrid.Rows.Count; i++)
			{
				node_cd = arg_fgrid[i, arg_index].ToString();
				node_cd_length = arg_fgrid[i, arg_index].ToString().Length;

				temp_nodecd = Convert.ToInt32(node_cd.Substring(node_cd_length - 4, 4));

				if(temp_nodecd == Convert.ToInt32(arg_nodeix))
				{
					temp_row = i - arg_rowfixed;
					break;
				} 

			}  //end for i
  
			return temp_row; 

		}



		#endregion 

		#region 생산의뢰일자, DPO 리스트 찾기


		/// <summary>
		/// Select_ReqNo_Date : 생산의뢰일자 리스트 찾기
		/// </summary>
		/// <param name="arg_div">SEM_REQ or SPO_RECV or SPO_RECV_LOT 구분자 (E or P or L)</param>
		/// <returns></returns>
		public static DataTable Select_ReqNo_Date(string arg_factory, string arg_div)
		{ 
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_REQNO_DATE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_div; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
			
		}


		/// <summary>
		/// Select_DPO : DPO 리스트 찾기
		/// </summary>
		/// <param name="arg_div">SEM_REQ or SPO_RECV or SPO_RECV_LOT 구분자 (E or P or L)</param>
		/// <returns></returns>
		public static DataTable Select_DPO(string arg_factory, string arg_div)
		{  
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
			
			try
			{
				string process_name = "PKG_SPO_ORDER_BSC.SELECT_DPO";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
  
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_DIVISION"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";
 
				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			  
				MyOraDB.Parameter_Values[0] = arg_factory; 
				MyOraDB.Parameter_Values[1] = arg_div; 
				MyOraDB.Parameter_Values[2] = ""; 

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name]; 
			}
			catch
			{
				return null;
			}
 
			
		}

		#endregion

		#region BOM Routing Form 표시 (Form 개체 return)

		public ProdBase.Form_PB_BOMRout Show_Rout()
		{
			ProdBase.Form_PB_BOMRout frm_rout = new ProdBase.Form_PB_BOMRout();
			frm_rout.MdiParent = ClassLib.ComVar.static_form; 
			ClassLib.ComVar.MenuClick_Flag = false;
			frm_rout.Show();
			return frm_rout;
		}

		#endregion

		#region Essential Check

		public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt)
		{
			if (arg_cmb != null)
			{
				for (int i =0; i < arg_cmb.Length; i++)
				{
					if (arg_cmb[i].SelectedIndex < 0)
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_cmb[i].Focus(); 
						return false;
					}
				}
			}
			if (arg_txt != null)
			{
				for (int i =0; i < arg_txt.Length; i++)
				{
					if (arg_txt[i].Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_txt[i].Focus(); 
						return false;
					}
				}
			}
			return true;		
		}


		public static bool Essentiality_check(C1.Win.C1List.C1Combo[] arg_cmb, System.Windows.Forms.TextBox[] arg_txt, bool arg_blank_check)
		{
			if (arg_cmb != null)
			{
				for (int i =0; i < arg_cmb.Length; i++)
				{
					if (arg_cmb[i].SelectedIndex < 0 || arg_cmb[i].SelectedValue.ToString().Trim() == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_cmb[i].Focus(); 
						return false;
					}
				}
			}
			if (arg_txt != null)
			{
				for (int i =0; i < arg_txt.Length; i++)
				{
					if (arg_txt[i].Text == "")
					{
						ClassLib.ComFunction.User_Message("Input Essential Condition.", "Essentiality_check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						arg_txt[i].Focus(); 
						return false;
					}
				}
			}
			return true;		
		}


		#endregion 

		#region Report Directory

		// Report Directory 
		public static string Set_RD_Directory(string arg_FormName)
		{
			//			return Application.StartupPath +"\\Report\\"+ arg_FormName + ".mrd";
			//return "C:\\Sephiroth\\FlexPurchase\\Report\\" + arg_FormName + ".mrd";

			return Application.StartupPath +"\\Report\\Production\\" + arg_FormName + ".mrd";
		}

		#endregion

		#region gender의 사이즈 문대 표시


		/// <summary>
		/// Set_DefaultSize_Head_CM_SIZE : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_gen"></param>
		/// <param name="arg_rowfixed"></param>
		/// <param name="arg_gen_ix"></param>
		/// <param name="arg_cs_size_start_ix"></param>
		public static void Set_DefaultSize_Head_CM_SIZE(COM.FSP arg_grid, string arg_factory, string arg_gen, int arg_rowfixed, int arg_gen_ix, int arg_cs_size_start_ix)
		{

			
			try
			{

				DataTable dt_gen;
				DataTable dt_size_cm;
				DataTable dt_size;

				int size_count = 0;

				string[] new_data = new string[arg_gen_ix + 1]; 
			 

				arg_grid.Rows.Count = arg_rowfixed;
				arg_grid.Cols.Count = arg_gen_ix + 1;
				arg_grid.Rows[1].Visible = false;


				//------------------------------------------------
				//젠더 표시

				dt_gen = ClassLib.ComVar.Select_ComCode(arg_factory, COM.ComVar.CxGen);  

  
				new_data[0] = "";

				for(int i = 0; i < dt_gen.Rows.Count; i++)
				{

					for(int j = 1; j < arg_gen_ix; j++)
					{
						new_data[j] = arg_grid[1, j].ToString();

					} // end for j

					new_data[arg_gen_ix] = dt_gen.Rows[i].ItemArray[(int)COM.TBSCM_CODE.IxCOM_VALUE2].ToString();
				
					// 모든 gender 표시
					if(arg_gen.Trim().Equals("") )
					{
						arg_grid.AddItem(new_data, arg_grid.Rows.Count, 0);
					}
					else
					{
						if(new_data[arg_gen_ix].ToString() == arg_gen.Trim() )
						{
							arg_grid.AddItem(new_data, arg_grid.Rows.Count, 0);
						}
					}


				} // end for i


				// 모든 gender 표시
				if(arg_gen.Trim().Equals("") )
				{
					arg_grid.Rows.Fixed = arg_rowfixed + dt_gen.Rows.Count;
				}
				else
				{
					arg_grid.Rows.Fixed = arg_rowfixed + 1;
				}

			
 
				//------------------------------------------------------
				//eu_size 문대 표시
				//"ME", "WO" 간의 기준문대 맞추기 위함 ("ME" = 3T, "WO" = 5)
				//------------------------------------------------------
				dt_size_cm = Select_Gen_Size_CM_SIZE(arg_factory, " ");

				// dt_size_cm.rows[j].itemarray[0] : eu_size, [1] : cm_size
				//------------------------------------------------------
				//젠더 중 제일 긴 사이즈 문대 갯수만큼 그리드 컬럼 조절
				size_count = dt_size_cm.Rows.Count + arg_cs_size_start_ix;

				if(size_count > arg_grid.Cols.Count) arg_grid.Cols.Count = size_count; 
				//------------------------------------------------------

				for(int j = 0; j < dt_size_cm.Rows.Count; j++)
				{
					arg_grid[0, arg_cs_size_start_ix + j] = dt_size_cm.Rows[j].ItemArray[0];
				} // end for j
				//------------------------------------------------------




				//------------------------------------------------
				//사이즈 문대 표시 

				for(int i = arg_rowfixed; i < arg_grid.Rows.Count; i++)   //dt_gen.Rows.Count; i++)
				{

					
					dt_size = Select_Gen_Size(arg_factory, arg_grid[i, arg_gen_ix].ToString());   //dt_gen.Rows[i].ItemArray[1].ToString());

					// dt_size.rows[j].itemarray[0] : cs_size, [1] : cm_size, [2] : eu_size
					//------------------------------------------------------
					//젠더 중 제일 긴 사이즈 문대 갯수만큼 그리드 컬럼 조절
					size_count = dt_size.Rows.Count + arg_cs_size_start_ix;

					if(size_count > arg_grid.Cols.Count) arg_grid.Cols.Count = size_count; 
					//------------------------------------------------------
  


					if( arg_grid[i, arg_gen_ix].ToString() == "ME" || arg_grid[i, arg_gen_ix].ToString() == "WO" )
					{

						for(int j = 0; j < dt_size.Rows.Count; j++)
						{

							for(int k = arg_cs_size_start_ix; k < arg_grid.Cols.Count; k++)
							{
								// eu_size 비교
								// dt_size.rows[j].itemarray[0] : cs_size, [1] : cm_size, [2] : eu_size
								// dt_size_cm.rows[j].itemarray[0] : eu_size, [1] : cm_size
								if( Convert.ToDouble(dt_size.Rows[j].ItemArray[2].ToString() ) == Convert.ToDouble(arg_grid[0, k].ToString()) )
								{
									arg_grid[i, k] = dt_size.Rows[j].ItemArray[0];
									break;
								}
							} // end for k

						} // end for j

						
					}
					else
					{
						for(int j = 0; j < dt_size.Rows.Count; j++)
						{
							arg_grid[i, arg_cs_size_start_ix + j] = dt_size.Rows[j].ItemArray[0];
						}

					} // end if (gen == "ME" || gen == "WO")

 
				}
 
 

				


				//------------------------------------------------
		 
				for(int i = arg_gen_ix + 1; i < arg_grid.Cols.Count; i++)
				{
					arg_grid.Cols[i].Width = 45;  
					arg_grid.Cols[i].AllowSorting = false;
				
					for(int j = arg_rowfixed; j < arg_grid.Rows.Fixed; j++)
					{
						if(arg_grid[j, i] == null) arg_grid[j, i] = "x";
						arg_grid.Rows[j].TextAlign = TextAlignEnum.CenterCenter; 
					}

				}
 
			 
 
				arg_grid.AllowMerging = AllowMergingEnum.FixedOnly;

				for(int i = 1; i <= arg_gen_ix; i++)
				{
					arg_grid.Cols[i].AllowMerging = true;
				}
   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_DefaultSize_Head_CM_SIZE", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}



		}



		/// <summary>
		/// Set_DefaultSize_Head : 
		/// </summary>
		/// <param name="arg_grid"></param>
		/// <param name="arg_factory"></param>
		/// <param name="arg_gen"></param>
		/// <param name="arg_rowfixed"></param>
		/// <param name="arg_gen_ix"></param>
		/// <param name="arg_cs_size_start_ix"></param> 
		public static void Set_DefaultSize_Head(COM.FSP arg_grid, string arg_factory, string arg_gen, int arg_rowfixed, int arg_gen_ix, int arg_cs_size_start_ix)
		{


			try
			{

				DataTable dt_gen;  
				DataTable dt_size;

				int size_count = 0;

				string[] new_data = new string[arg_gen_ix + 1]; 
			 


				arg_grid.Rows.Count = arg_rowfixed;
				arg_grid.Cols.Count = arg_gen_ix + 1;
				arg_grid.Rows[1].Visible = false;


				//------------------------------------------------
				//젠더 표시

				dt_gen = ClassLib.ComVar.Select_ComCode(arg_factory, COM.ComVar.CxGen);  

  
				new_data[0] = "";

				for(int i = 0; i < dt_gen.Rows.Count; i++)
				{

					for(int j = 1; j < arg_gen_ix; j++)
					{
						new_data[j] = arg_grid[1, j].ToString();

					} // end for j

					new_data[arg_gen_ix] = dt_gen.Rows[i].ItemArray[(int)COM.TBSCM_CODE.IxCOM_VALUE2].ToString();
				
					// 모든 gender 표시
					if(arg_gen.Trim().Equals("") )
					{
						arg_grid.AddItem(new_data, arg_grid.Rows.Count, 0);
					}
					else
					{
						if(new_data[arg_gen_ix].ToString() == arg_gen.Trim() )
						{
							arg_grid.AddItem(new_data, arg_grid.Rows.Count, 0);
						}
					}


				} // end for i


				// 모든 gender 표시
				if(arg_gen.Trim().Equals("") )
				{
					arg_grid.Rows.Fixed = arg_rowfixed + dt_gen.Rows.Count;
				}
				else
				{
					arg_grid.Rows.Fixed = arg_rowfixed + 1;
				}

			
 


				//------------------------------------------------
				//사이즈 문대 표시 

				for(int i = arg_rowfixed; i < arg_grid.Rows.Count; i++)   //dt_gen.Rows.Count; i++)
				{
					dt_size = Select_Gen_Size(arg_factory, arg_grid[i, arg_gen_ix].ToString());   //dt_gen.Rows[i].ItemArray[1].ToString());

					//------------------------------------------------------
					//젠더 중 제일 긴 사이즈 문대 갯수만큼 그리드 컬럼 조절
					size_count = dt_size.Rows.Count + arg_cs_size_start_ix;

					if(size_count > arg_grid.Cols.Count) arg_grid.Cols.Count = size_count; 
					//------------------------------------------------------
  
					for(int j = 0; j < dt_size.Rows.Count; j++)
					{
						arg_grid[i, arg_cs_size_start_ix + j] = dt_size.Rows[j].ItemArray[0];
					}

 
				}
 
 
				//------------------------------------------------
		 
				for(int i = arg_gen_ix + 1; i < arg_grid.Cols.Count; i++)
				{
					arg_grid.Cols[i].Width = 45;  
					arg_grid.Cols[i].AllowSorting = false;
				
					for(int j = arg_rowfixed; j < arg_grid.Rows.Fixed; j++)
					{
						if(arg_grid[j, i] == null) arg_grid[j, i] = "x";
						arg_grid.Rows[j].TextAlign = TextAlignEnum.CenterCenter; 
					}

				}
 
			 
 
				arg_grid.AllowMerging = AllowMergingEnum.FixedOnly;

				for(int i = 1; i <= arg_gen_ix; i++)
				{
					arg_grid.Cols[i].AllowMerging = true;
				}
   

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Set_DefaultSize_Head", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

		}



		/// <summary>
		/// Select_Gen_Size : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		public static DataTable Select_Gen_Size(string arg_factory, string arg_gen)
		{

			try
			{
				
				COM.OraDB MyOraDB = new COM.OraDB();
				DataSet ds_ret;

				string process_name = "PKG_SPO_ORDER_BSC.SELECT_GEN_SIZE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_GEN"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_gen; 
				MyOraDB.Parameter_Values[2] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null;
			}


			 
		}




		/// <summary>
		/// Select_Gen_Size_CM_SIZE : 
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_gen"></param>
		/// <returns></returns>
		public static DataTable Select_Gen_Size_CM_SIZE(string arg_factory, string arg_gen)
		{

			try
			{
				
				COM.OraDB MyOraDB = new COM.OraDB();
				DataSet ds_ret;

				string process_name = "PKG_SPO_ORDER_BSC.SELECT_GEN_SIZE_CM_SIZE";

				MyOraDB.ReDim_Parameter(3); 
 
				MyOraDB.Process_Name = process_name;
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_GEN"; 
				MyOraDB.Parameter_Name[2] = "OUT_CURSOR";  

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;  
				MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
				MyOraDB.Parameter_Values[0] = arg_factory;
				MyOraDB.Parameter_Values[1] = arg_gen; 
				MyOraDB.Parameter_Values[2] = "";   

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[process_name]; 

			}
			catch
			{ 
				return null;
			}


			 
		}




		#endregion

		#region 공통 쿼리 (style list, lot list)


		/// <summary>
		/// Select_SDC_STYLE : Style List - Like 처리, gen, pst_yn 포함 (SDC_STYLE)
		/// </summary>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		public static DataTable Select_SDC_STYLE(string arg_style_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(2); 

			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SDC_STYLE";

			MyOraDB.Parameter_Name[0] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[1] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = arg_style_cd;
			MyOraDB.Parameter_Values[1] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
			
		}



		/// <summary>
		/// Select_SDC_STYLE : Style List - Like 처리, gen, pst_yn 포함 (SDC_STYLE)
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_style_cd"></param>
		/// <returns></returns>
		public static DataTable Select_SDC_STYLE(string arg_factory, string arg_obs_id, string arg_style_cd)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(4); 

			MyOraDB.Process_Name = "PKG_SBC_COMMON.SELECT_SDC_STYLE_DPO";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_obs_id;
			MyOraDB.Parameter_Values[2] = arg_style_cd;
			MyOraDB.Parameter_Values[3] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
			
		}


		

		/// <summary>
		/// Select_SPO_LOT_COMBO : LOT List - Like 처리, factory, obs_id, style_cd
		/// </summary>
		/// <param name="arg_factory"></param>
		/// <param name="arg_obs_id"></param>
		/// <param name="arg_style_cd"></param>
		/// <param name="arg_lot_no"></param>
		/// <param name="arg_lot_seq"></param>
		/// <returns></returns>
		public static DataTable Select_SPO_LOT_COMBO(string arg_factory, 
			string arg_obs_id, 
			string arg_style_cd, 
			string arg_lot_no, 
			string arg_lot_seq)
		{
			COM.OraDB MyOraDB = new COM.OraDB();
			DataSet ds_ret;
		
			MyOraDB.ReDim_Parameter(6); 

			MyOraDB.Process_Name = "PKG_SPO_MPS_HISTORY_BSC.SELECT_SPO_LOT_COMBO";

			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_OBS_ID";
			MyOraDB.Parameter_Name[2] = "ARG_STYLE_CD";
			MyOraDB.Parameter_Name[3] = "ARG_LOT_NO";
			MyOraDB.Parameter_Name[4] = "ARG_LOT_SEQ";
			MyOraDB.Parameter_Name[5] = "OUT_CURSOR"; 

			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[5] = (int)OracleType.Cursor;
			
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_obs_id;
			MyOraDB.Parameter_Values[2] = arg_style_cd;
			MyOraDB.Parameter_Values[3] = arg_lot_no; 
			MyOraDB.Parameter_Values[4] = arg_lot_seq; 
			MyOraDB.Parameter_Values[5] = ""; 

			MyOraDB.Add_Select_Parameter(true);
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null;
			return ds_ret.Tables[MyOraDB.Process_Name]; 
			
		}


		#endregion

		#region 몰드 관련 함수 from 베트남


		/// <summary>
		/// Select_Man_Charge : 담당자리스트
		/// </summary>
		/// <param name="arg_factory">공장코드e</param>
		/// <returns>DataTable</returns>
		public static DataTable Select_Man_Charge_ByCom(string arg_factory,string arg_com)
		{

			COM.OraDB oraDB = new COM.OraDB();


			string Proc_Name = "PKG_SBC_COMMON.SELECT_SCM_MAN_CHARGE_BYCOM";


			oraDB.ReDim_Parameter(3);

			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_FACTORY";
			oraDB.Parameter_Name[1] = "ARG_COM";
			oraDB.Parameter_Name[2] = "OUT_CURSOR";


			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.Cursor;


			oraDB.Parameter_Values[0] = arg_factory;
			oraDB.Parameter_Values[1] = arg_com;
			oraDB.Parameter_Values[2] = "";


			oraDB.Add_Select_Parameter(false);

			DataSet DS_Ret = oraDB.Exe_Select_Procedure();


			if(DS_Ret == null) return null ;


			return  DS_Ret.Tables[Proc_Name];

		}



		#endregion


	}
}
