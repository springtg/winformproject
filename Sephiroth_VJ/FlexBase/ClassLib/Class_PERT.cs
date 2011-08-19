using System;
using System.Windows.Forms;
using Lassalle.Flow;
using System.Drawing;

namespace FlexBase.ClassLib
{
	/// <summary>
	/// Class_DOrder에 대한 요약 설명입니다.
	/// </summary>
	public class Class_PERT
	{
 
 
		public Lassalle.Flow.Node HeaderCd = new Lassalle.Flow.Node();
		public Lassalle.Flow.Node TotQty = new Lassalle.Flow.Node();
		public Lassalle.Flow.Node SumQty = new Lassalle.Flow.Node();
		public Lassalle.Flow.Node RemainQty = new Lassalle.Flow.Node();
	
		public Lassalle.Flow.Node[] DetailCd;

		public int Left;
		public int Top;
		public int Width;
		public int Height;

		public Lassalle.Flow.AddFlow AddFlow_Draw;

	 

		public int DOrder(System.Data.DataRow[] arg_row, Lassalle.Flow.AddFlow arg_addflow, int arg_left, int arg_top, int arg_width, int arg_height, int arg_type) 
		{
  
			Left = arg_left;
			Top = arg_top;
			Width = arg_width;
			Height = arg_height;

			AddFlow_Draw = arg_addflow;
 
			Top = Draw_Req(arg_row[0]);
			Top = Draw_Req_Lot(arg_row); 


			Set_Node_Prop(HeaderCd, arg_type);
			Set_Node_Prop(TotQty, 2);
			Set_Node_Prop(SumQty, 2);
			Set_Node_Prop(RemainQty, 2);

			return Top;
 

		}


	

		public int Draw_Req(System.Data.DataRow arg_row)
		{
 
			int left_point;
 
			HeaderCd = AddFlow_Draw.Nodes.Add(Left, Top , Width, Height, ""); 

			Top = (int)HeaderCd.Location.Y + (int)HeaderCd.Size.Height;  
				
			TotQty = AddFlow_Draw.Nodes.Add(Left, Top, (int)HeaderCd.Size.Width / 3, Height, ""); 
					
			left_point = (int)TotQty.Location.X + (int)HeaderCd.Size.Width / 3; 
				
			SumQty = AddFlow_Draw.Nodes.Add(left_point, Top, (int)HeaderCd.Size.Width / 3, Height, "");
	
			left_point =(int)SumQty.Location.X + (int)HeaderCd.Size.Width / 3;
	
			RemainQty = AddFlow_Draw.Nodes.Add(left_point, Top, (int)HeaderCd.Size.Width / 3 + 1, Height, "");
			 	
			Top = (int)RemainQty.Location.Y + (int)HeaderCd.Size.Height; 
	

			return Top;

		}



		public int Draw_Req_Lot(System.Data.DataRow[] arg_row)
		{  
			 
			DetailCd = new Lassalle.Flow.Node[arg_row.Length];

			//if(arg_row.Length == 0) return Top;

			for(int i = 0; i < arg_row.Length; i++)
			{ 
				DetailCd[i] = AddFlow_Draw.Nodes.Add(Left, Top, Width, Height, "");
 
				Top = (int)DetailCd[i].Location.Y + (int)DetailCd[i].Size.Height;

				Set_Node_Prop(DetailCd[i], 3);

			}

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
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
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
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
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
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
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
					arg_node.Font = ClassLib.ComFunction.ToFont("Verdana/7/False/False/False/False"); 
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
