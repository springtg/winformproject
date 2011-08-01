using System;
using System.Windows.Forms;
using System.Drawing;

namespace FlexAPS.ClassLib
{
	/// <summary>
	/// Class_PERT_Detail에 대한 요약 설명입니다.
	/// </summary>
	public class Class_PERT_Detail : Class_PERT
	{


		public struct DOrder_Parameter
		{
			public System.Data.DataRow[] arg_row;
			public Lassalle.Flow.AddFlow arg_addflow;
			public int arg_left;
			public int arg_top;
			public int arg_width;
			public int arg_height;
			public int arg_type;      //node property type
			public int arg_colcount;  //day_seq count
			public int arg_rowcount;  //data area count (plan_ymd, alo_qty, result....)
			public bool arg_detailyn; //detail area visible yn

		}


		public Lassalle.Flow.Node[] DayQty;        // = new Lassalle.Flow.Node(); 
		public DOrder_Parameter ParaList = new DOrder_Parameter();
	

		public int DOrder() 
		{

			Left = ParaList.arg_left;
			Top = ParaList.arg_top;
			Width = ParaList.arg_width;
			Height = ParaList.arg_height;

			AddFlow_Draw = ParaList.arg_addflow;
 
			Top = Draw_Req(ParaList.arg_row[0], ParaList.arg_colcount, ParaList.arg_rowcount);

			if(ParaList.arg_detailyn)
				Top = Draw_Req_Lot(ParaList.arg_row); 


 			Set_Node_Prop(HeaderCd, ParaList.arg_type);

			Set_Node_Prop(TotQty, 2);
			Set_Node_Prop(SumQty, 2);
			Set_Node_Prop(RemainQty, 2);



			return Top;
 

		}



		public int Draw_Req(System.Data.DataRow arg_row, int arg_colcount, int arg_rowcount)
		{
 
			int left_point;
			int dayqty_width = 50;
			int count = 0;
 
			DayQty = new Lassalle.Flow.Node[arg_colcount * arg_rowcount];

			HeaderCd = AddFlow_Draw.Nodes.Add(Left, Top , Width, Height, ""); 

			Top = (int)HeaderCd.Location.Y + (int)HeaderCd.Size.Height;  
				
			left_point = Left;

			for(int i = 0; i < arg_rowcount; i++)
			{
				for(int j = 0; j < arg_colcount; j++)
				{
					DayQty[count] = AddFlow_Draw.Nodes.Add(left_point, Top, dayqty_width, Height, ""); //(int)HeaderCd.Size.Width / arg_count
					Set_Node_Prop(DayQty[count], 2);
 
					left_point = (int)DayQty[j].Location.X + dayqty_width;   //(int)HeaderCd.Size.Width / arg_count; 

					count++;
				}
 
				Top = (int)DayQty[arg_colcount - 1].Location.Y + (int)HeaderCd.Size.Height;
				left_point = Left;
	
			}
			
			if((arg_colcount * dayqty_width) > HeaderCd.Size.Width)
				HeaderCd.Size = new Size(arg_colcount * dayqty_width, Height);

			Top = (int)DayQty[count - 1].Location.Y + (int)HeaderCd.Size.Height; 
	

			return Top;

		}




		public Class_PERT_Detail()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}


	}
}
