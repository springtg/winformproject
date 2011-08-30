using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Lassalle.Flow;

namespace FlexOrder.ClassLib
{
	/// <summary>
	/// ObjList에 대한 요약 설명입니다.
	/// </summary>
	public class Class_PERT
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
			public int arg_rowcount;  //data area count (plan_ymd, alo_qty, result....)
			public bool arg_detailyn; //detail area visible yn
		}

		public Lassalle.Flow.Node Style = new Lassalle.Flow.Node();
		public Lassalle.Flow.Node Sum   = new Lassalle.Flow.Node();
		public Lassalle.Flow.Node[] BP_NO;
		public Lassalle.Flow.Node[] PRD_QTY;

		public int Left;
		public int Top;
		public int Width;
		public int Height;

		public Lassalle.Flow.AddFlow AddFlow_Draw;

		public DOrder_Parameter ParaList = new DOrder_Parameter();

		public int DOrder() 
		{
			Left = ParaList.arg_left;
			Top = ParaList.arg_top;
			Width = ParaList.arg_width;
			Height = ParaList.arg_height;

			AddFlow_Draw = ParaList.arg_addflow;
 
			Top = Draw_BP_OA(ParaList.arg_row[0], ParaList.arg_rowcount);
	
			Set_Node_Prop(Style, ParaList.arg_type);
			Set_Node_Prop(Sum,   ParaList.arg_type);

			return Top; 
		}


	

		public int Draw_BP_OA(System.Data.DataRow arg_row, int arg_rowcount)
		{
			int left_point;
			int count = 0;
 
			BP_NO   = new Lassalle.Flow.Node[arg_rowcount]; 
			PRD_QTY = new Lassalle.Flow.Node[arg_rowcount];  

			Style = AddFlow_Draw.Nodes.Add(Left, Top , Width, Height, ""); 

			Top = (int)Style.Location.Y + (int)Style.Size.Height;  				

			for(int i = 0; i < arg_rowcount; i++)
			{
			    left_point     = Left;
				BP_NO[count]   = AddFlow_Draw.Nodes.Add(left_point, Top, Style.Size.Width/2, Height, "");

				left_point     = (int)BP_NO[i].Location.X + (int)Style.Size.Width/2;   //(int)HeaderCd.Size.Width / arg_count; 
				PRD_QTY[count] = AddFlow_Draw.Nodes.Add(left_point, Top, Style.Size.Width/2, Height, "");

				Set_Node_Prop(BP_NO[count],   2);
				Set_Node_Prop(PRD_QTY[count], 2);
 
				count++;
 
				Top = (int)BP_NO[count-1].Location.Y + (int)Style.Size.Height;
			}

			Sum = AddFlow_Draw.Nodes.Add(Left, Top , Width, Height, ""); 
			Top = (int)Sum.Location.Y + (int)Sum.Size.Height;
			
			return Top;
		}

		public void Set_Node_Prop(Lassalle.Flow.Node arg_node, int arg_div)
		{
			switch(arg_div)
			{
				case 0:      // HeaderCd

					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/8/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(128, 255, 128); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 

					break;

				case 1:      // HeaderCd

					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/8/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(255, 128, 255); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 

					break;


				case 2:      // qty area

					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/8/False/False/False/False"); 
					arg_node.Gradient = false;  
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 

					break;

				case 3:      // DetailCd 
 
					arg_node.Alignment = Alignment.CenterMIDDLE;
					arg_node.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
					arg_node.DrawColor = Color.Black;
					arg_node.DrawWidth = 1;
					arg_node.FillColor = Color.White; 
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/8/False/False/False/False"); 
					arg_node.Gradient = true; 
					arg_node.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
					arg_node.GradientColor = Color.FromArgb(255, 255, 128); 
					arg_node.Shape.Style = ShapeStyle.Rectangle; 
					arg_node.TextColor = Color.Black; 

					break;
			}
		}

		public Class_PERT()
		{
			//
			// TODO: 여기에 생성자 논리를 추가합니다.
			//
		}

	}
}
