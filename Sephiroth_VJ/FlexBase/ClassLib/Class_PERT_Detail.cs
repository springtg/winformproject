using System;
using System.Windows.Forms;
using System.Drawing;

namespace FlexBase.ClassLib
{
	/// <summary>
	/// Class_PERT_Detail�� ���� ��� �����Դϴ�.
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
 
			//Top = Draw_Req(ParaList.arg_row[0], ParaList.arg_colcount, ParaList.arg_rowcount); 

			Top = Draw_Head(ParaList.arg_row[0], ParaList.arg_colcount, ParaList.arg_rowcount);

			if(ParaList.arg_detailyn)
			{
				Top = Draw_Req_Lot(ParaList.arg_row); 
			}


 			Set_Node_Prop(HeaderCd, ParaList.arg_type);

			Set_Node_Prop(TotQty, 2);
			Set_Node_Prop(SumQty, 2);
			Set_Node_Prop(RemainQty, 2);



			return Top;
 

		}

 
 

	
		public int Draw_Head(System.Data.DataRow arg_row, int arg_colcount, int arg_rowcount)
		{
 

			int left_point;
			int dayqty_width = 60;
			int count = 0;
 
			DayQty = new Lassalle.Flow.Node[arg_colcount * arg_rowcount];

			HeaderCd = AddFlow_Draw.Nodes.Add(Left, Top , Width, Height, ""); 

			Top = (int)HeaderCd.Location.Y + (int)HeaderCd.Size.Height;  
				
			left_point = Left;
 

			for(int i = 0; i < arg_colcount; i++)
			{
				for(int j = 0; j < arg_rowcount; j++)
				{
					DayQty[count] = AddFlow_Draw.Nodes.Add(left_point, Top, dayqty_width, Height, count.ToString() );  
					Set_Node_Prop(DayQty[count], 2); 
					left_point = (int)DayQty[count].Location.X + (int)DayQty[count].Size.Width; 
 
					count++;
				}
 
				Top += (int)HeaderCd.Size.Height;
				left_point = Left;
	
			}
			
			if((arg_rowcount * dayqty_width) > HeaderCd.Size.Width)
				HeaderCd.Size = new Size(arg_rowcount * dayqty_width, Height);
 


			Top += (int)HeaderCd.Size.Height;
	

			return Top;

 
		}


		public int Draw_Head_Add(System.Data.DataRow[] arg_row)
		{  
			 
			DetailCd = new Lassalle.Flow.Node[arg_row.Length];
 
			Top -= Height;

			for(int i = 0; i < arg_row.Length; i++)
			{ 
				DetailCd[i] = AddFlow_Draw.Nodes.Add(Left, Top, Width, Height, "");
 
				Top = (int)DetailCd[i].Location.Y + (int)DetailCd[i].Size.Height;

				Set_Node_Prop(DetailCd[i], 3);

			}

			return Top + Height;
		}


 


		public Class_PERT_Detail()
		{
			//
			// TODO: ���⿡ ������ ���� �߰��մϴ�.
			//
		}


	}
}
