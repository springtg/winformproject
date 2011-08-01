using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;  
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.CellType;
using System.Drawing.Printing;
using FarPoint.Win;
using System.Drawing.Drawing2D;
using System.Globalization;
using FarPoint.Win.Spread.Model;
using Microsoft.Win32;


namespace COM
{
	  

		#region class ListItem 
		class ListItem 
		{ 
			private string _Text; 
			private string _Value; 

			public ListItem(String Text, String Value) 
			{ 
				this._Text = Text; 
				this._Value = Value; 
			} 

			public string Text
			{
				get{return _Text;}
				set{_Text = value;}
			}

			public string Value
			{
				get{return _Value;}
				set{_Value = value;}
			}


			public override string ToString() 
			{ 
				if(this.Text == null)
					return "";
				else
					return this.Text; 
			} 
		} 
		#endregion

		#region Shell Spread ComboBox
		[Serializable()]
		public class SSPComboBoxCellType: FarPoint.Win.Spread.CellType.ComboBoxCellType 
		{ 
			ComboBox cbo; 
			public delegate void comboSelChangeDelegate();
			public delegate void comboClickDelegate();
			public delegate void comboEnterDelegate();
			public delegate void comboMouseWheelDelegate();		
			public delegate void comboDisplayMemberChangedDelegate();		
			public delegate void comboSelChangeWithParamsDelegate(object sender, EventArgs e);
			public delegate void comboDropDownDelegate(object sender, EventArgs e);

			public event comboClickDelegate comboClick;
			public event comboSelChangeDelegate comboSelChange;
			public event comboEnterDelegate comboEnter;
			public event comboDisplayMemberChangedDelegate comboDisplayMemberChanged;
			public event comboSelChangeWithParamsDelegate comboSelChangeWithParams;
			public event comboDropDownDelegate comboDropDown;
			public event comboMouseWheelDelegate comboMouseWheel;

			//Font f = new Font("Verdana", 8.25f); 
			bool withlist = true;

			#region SpreadComboBox
	
		 

			public SSPComboBoxCellType(DataTable dt, string DisplayMember, string ValueMember, bool RequiresBlankFirstLine)  
			{ 
				//The first column should be the value and the second should be the display 
				try 
				{ 
					long nlAdded; 
					cbo = new ComboBox(); 
				
					cbo.SelectedIndexChanged+=new EventHandler(cbo_SelectedIndexChangedWithParams);
					cbo.SelectedIndexChanged+=new EventHandler(cbo_SelectedIndexChanged);
					cbo.Click+=new EventHandler(cbo_Click);
					cbo.DisplayMemberChanged+=new EventHandler(cbo_DisplayMemberChanged);
					cbo.DropDown+=new EventHandler(cbo_DropDown);
					cbo.Enter+=new EventHandler(cbo_Enter);
					cbo.MouseWheel+=new MouseEventHandler(cbo_MouseWheel);

					if(RequiresBlankFirstLine)
					{
						//Create a new list item 
						ListItem li = new ListItem("", "0"); 

						//Add it to the combo 
						nlAdded = cbo.Items.Add(li); 
					}

					foreach(DataRow dr in dt.Rows) 
					{ 
						//Create a new list item 
						ListItem li = new ListItem(dr[DisplayMember].ToString(), dr[ValueMember].ToString()); 
						//Add it to the combo 
						nlAdded = cbo.Items.Add(li); 
					} 

					cbo.DropDownStyle = ComboBoxStyle.DropDownList;				
					//cbo.Font = f;
					//cbo.SelectedIndex = 0; //test
				} 
				catch // (Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 
			} 

		 
			#endregion
		
			#region AddItems
			public void AddItems(DataTable dt, string DisplayMember, string ValueMember, bool RequiresBlankFirstLine)
			{
				//The first column should be the value and the second should be the display 
				try 
				{ 
					long nlAdded; 
				
					if(RequiresBlankFirstLine)
					{					
						ListItem li = new ListItem("", "0"); //Create a new list item 
					
						nlAdded = cbo.Items.Add(li);  //Add it to the combo 
					}

					foreach(DataRow dr in dt.Rows) 
					{ 
						//Create a new list item 
						ListItem li = new ListItem(dr[DisplayMember].ToString(), dr[ValueMember].ToString()); 
					
						nlAdded = cbo.Items.Add(li); //Add it to the combo 
					}

					//Debug.WriteLine("cnt: " + cbo.Items.Count);

					//cbo.SelectedIndex = 0;
				} 
				catch // (Exception ex)
				{
					//ShellExceptionManager.Publish(ex);
				} 
			}

			// value 만 가진 datasource
			public object DataSource
			{
				get
				{
					IEnumerator vEnum = cbo.Items.GetEnumerator();

					string [] arr = new string[cbo.Items.Count];

					for (int i =0; vEnum.MoveNext(); i++)
					{
						ListItem item = (ListItem)vEnum.Current;
						arr[i] = item.Value + "-" + item.Text;
					}

					return arr;
				}
			}

			// code, value 를 가진 DataSource
			public object DataSourceWithCode
			{
				get
				{
					IEnumerator vEnum = cbo.Items.GetEnumerator();

					string [][] arr = new string[2][];
					string [] arr_code = new string[cbo.Items.Count];
					string [] arr_value = new string[cbo.Items.Count];

					for (int i =0; vEnum.MoveNext(); i++)
					{
						ListItem item = (ListItem)vEnum.Current;						
						arr_code[i] = item.Value;
						arr_value[i] = item.Text;
					}
					arr[0] = arr_code;
					arr[1] = arr_value;

					return arr;
				}
			}

			#endregion
		
			#region AddItem
			public void AddItem(string Text, string Value)
			{
				//The first column should be the value and the second should be the display 
				try 
				{ 
					//Create a new list item 
					ListItem li = new ListItem(Text, Value); 
					
					cbo.Items.Add(li); //Add it to the combo 
					cbo.Sorted = true;
				} 
				catch // (Exception ex)
				{
					//ShellExceptionManager.Publish(ex);
				} 
			}
			#endregion



			public override object IsReservedLocation(Graphics g, int x, int y, Rectangle rc, FarPoint.Win.Spread.Appearance appearance, object value, float zoomFactor)
			{
				//return base.IsReservedLocation (g, x, y, rc, appearance, value, zoomFactor);


				return null;
			}


			public override Control GetEditorControl(FarPoint.Win.Spread.Appearance appearance, float zoomFactor) 
			{ 			
				return cbo; 
			} 

			public override object GetEditorValue() 
			{ 
				if(cbo.SelectedIndex== -1) 
					if(cbo.Items.Count > 0)
					{
						cbo.SelectedIndex = 0;
						return ((ListItem)cbo.SelectedItem).Value; 
					}
					else
						return -1; 
				else 
					return ((ListItem)cbo.SelectedItem).Value; 
			}


			#region PaintCell

			public override void PaintCell(Graphics g, Rectangle r, FarPoint.Win.Spread.Appearance appearance, object value, bool isSelected, bool isLocked, float zoomFactor) 
			{ 
				StringFormat objStringFormat; 
				Brush brushText; 
				RectangleF rectfText; 
				Brush brushBackground; 

				//Rectangle rectComboButton; 

				value = this.DecodeValue(value);
				brushBackground = new SolidBrush(appearance.BackColor); 
				g.FillRectangle(brushBackground, r); 

				objStringFormat = new StringFormat(); 
				objStringFormat.Alignment = StringAlignment.Near; 
				objStringFormat.LineAlignment = StringAlignment.Center; 	

				rectfText = new RectangleF(r.X + 2, r.Y, r.Width-2, r.Height); 
				brushText = new SolidBrush(appearance.ForeColor); 
				g.DrawString(value.ToString(), appearance.Font, brushText, rectfText, objStringFormat); 

				//this code is responsible for drawing the combo button that you click... not the whole combo control cell !
				//ControlPaint.DrawComboButton(g, new Rectangle(r.Right - 17, r.Y, 17, r.Height), ButtonState.Flat); 

 
 
			} 
			#endregion
   
			public void SelectedIndex(int value)
			{
				SetEditorValue(value); 
			}

			public int GetIndexFromValue(object value)
			{
				int i = 0;
				if(value!=null) 
				{ 
					foreach(ListItem li in cbo.Items) 
					{ 
						if(li.Value.ToString() == value.ToString()) 
						{
							return i;
						}
						i += 1; 
					} 
				} 

				return i;
			}

			public override void SetEditorValue(object value) 
			{ 
				int i = 0; 
				if(value!=null) 
				{ 
					foreach(ListItem li in cbo.Items) 
					{ 
						if(li.Value.ToString() == value.ToString()) 
						{
							if (cbo.SelectedIndex != i)
								cbo.SelectedIndex = i; 
							return;
						}
						i += 1; 
					} 
				} 
			} 

			public void cbo_SelectedIndexChangedWithParams(object sender, EventArgs e)
			{
				/// By encapsulation the "comboSelChange()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboSelChangeWithParams(sender, e);
				}
				catch// (Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 
			}
			public void cbo_SelectedIndexChanged(object sender, EventArgs e)
			{
				/// By encapsulation the "comboSelChange()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboSelChange();
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 
			}

			public void cbo_DropDown(object sender, EventArgs e)
			{
				/// By encapsulation the "comboDropDown()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboDropDown(sender, e);
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 
			}

			private void cbo_Click(object sender, EventArgs e)
			{
				/// By encapsulation the "comboClick()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboClick();
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 			
			}

			private void cbo_DisplayMemberChanged(object sender, EventArgs e)
			{
				/// By encapsulation the "comboDisplayMemberChanged()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboDisplayMemberChanged();
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 			
			}

			private void cbo_Enter(object sender, EventArgs e)
			{
				/// By encapsulation the "comboDisplayMemberChanged()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboEnter();
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 			

			}

			private void cbo_MouseWheel(object sender, MouseEventArgs e)
			{
				/// By encapsulation the "comboDisplayMemberChanged()" in a Try?Catch statement, it means that 
				/// every ComboBox column that uses this class does NOT need to declare the event
				/// 

				try
				{
					comboMouseWheel();
				}
				catch //(Exception ex)
				{
					////ShellExceptionManager.Publish(ex);
				} 			

			}
			public override string Format(object o)    
			{     
				// TODO:  Add SpreadComboBox.Format implementation      
				//return base.Format (o);      
				if(cbo.SelectedIndex== -1)
					if(cbo.Items.Count > 0)
					{       
						cbo.SelectedIndex = 0;  
						return ((ListItem)cbo.SelectedItem).Text;
					}       
					else
						return null; 
				else
					return ((ListItem)cbo.SelectedItem).Text; 
			}
			public string DecodeValue(object value)
			{
				int i = 0;
				string retVal = "";
				if (withlist) 
				{
					if (value!=null) 
					{ 
						if (cbo.Items.Count == 0)
						{
							retVal = "";
						}
						else 
						{
							foreach(ListItem li in cbo.Items) 
							{ 
								if (li.Value == "")
								{
									if(li.Value.Trim()== value.ToString().Trim()  || li.Text.Trim()== value.ToString().Trim()) 
									{ 
										retVal = li.Text; 
										break; 
									}
								}
								else
								{
									try
									{							
										if (IsDate(li.Value))
										{
											if(Convert.ToDateTime(li.Value.Trim())== Convert.ToDateTime(value.ToString().Trim())
												|| Convert.ToDateTime(li.Text.Trim())== Convert.ToDateTime(value.ToString().Trim())) 
											{ 
												retVal =  li.Text; 
												break; 
											} 
										}
										else
										{
											if(li.Value.Trim()== value.ToString().Trim())
											{
												retVal =  li.Text; 
												break; 
											} 
										}
									}
									catch
									{
										if(li.Value.Trim()== value.ToString().Trim())
										{ 
											retVal =  li.Text; 
											break; 
										} 
									}
								}
								i++; 
							} 
						}
					}
					else
						retVal =  "";
				}
				else
				{
					if (value!=null) 
					{ 
						foreach(DataRow dr in ((DataTable)this.cbo.DataSource).Rows) 
						{
							if (dr[cbo.ValueMember].GetType().ToString() == "System.Int64" ||
								dr[cbo.ValueMember].GetType().ToString() == "System.Int32" ||
								dr[cbo.ValueMember].GetType().ToString() == "System.Int16")
							{
								if ( Convert.ToInt64(dr[cbo.ValueMember]) == Convert.ToInt64(value))
								{
									value = dr[cbo.DisplayMember];
									break;
								}
							}
							else
							{
								if ( Convert.ToString(dr[cbo.ValueMember]) == Convert.ToString(value))
								{
									value = dr[cbo.DisplayMember];
									break;
								}
							}
	
						}
					}
				}
				return retVal;
			}


			#region IsDate
			public static bool IsDate(string str)
			{
				bool result = true;
				DateTime date;

				/// to be a valid date the length has to be atleast 5 "05/06" so to stop the
				/// error occuring as much we can return false is length < 5
				if (str.Length < 5)
					result = false;
				else
				{
					try
					{
						date = Convert.ToDateTime(str);
					}
					catch
					{
						result = false;
					}
				}

				return result;
			}
			#endregion



			/// <summary>
			/// DataDisplay : 
			/// </summary>
			public object DataDisplay
			{
				get
				{					
					string [] arr = new string[cbo.Items.Count];
					int i = 0; 
					foreach(ListItem li in cbo.Items) 
					{ 
						arr[i] =  li.Text; 
						i = i +1; 
					}

					return arr;
				}
			}



			
			/// <summary>
			/// DataDisplay : 
			/// </summary>
			public object DataValue
			{
				get
				{					
					string [] arr = new string[cbo.Items.Count];
					int i = 0; 
					foreach(ListItem li in cbo.Items) 
					{ 
						arr[i] =  li.Value; 
						i = i +1; 
					}

					return arr;
				}
			}






		} 

		#endregion
	


		 
}
