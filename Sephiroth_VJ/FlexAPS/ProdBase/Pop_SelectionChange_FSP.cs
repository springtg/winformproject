using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;



namespace FlexAPS.ProdBase
{
	public class Pop_SelectionChange_FSP : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lbl_ColumnDesc;
		private System.Windows.Forms.TextBox txt_;
		private C1.Win.C1List.C1Combo cmb_;
		private System.Windows.Forms.Label btn_Apply;
		private System.Windows.Forms.Label btn_Cancel;
		private System.ComponentModel.IContainer components = null;

		public Pop_SelectionChange_FSP()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}


 
		COM.FSP _Grid;
		C1.Win.C1FlexGrid.CellRange _Cell;
		string _ColumnDesc;
		bool _Default_Set_Flag = true;


		public Pop_SelectionChange_FSP(COM.FSP arg_grid, C1.Win.C1FlexGrid.CellRange arg_cell, string arg_column_desc)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			_Grid = arg_grid;
			_Cell = arg_cell;
			_ColumnDesc = arg_column_desc;


			Init_Form();


		}


		public Pop_SelectionChange_FSP(COM.FSP arg_grid, C1.Win.C1FlexGrid.CellRange arg_cell, string arg_column_desc, bool arg_default_set_flag)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.



			_Grid = arg_grid;
			_Cell = arg_cell;
			_ColumnDesc = arg_column_desc;
			_Default_Set_Flag = arg_default_set_flag;


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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SelectionChange_FSP));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbl_ColumnDesc = new System.Windows.Forms.Label();
			this.cmb_ = new C1.Win.C1List.C1Combo();
			this.txt_ = new System.Windows.Forms.TextBox();
			this.btn_Apply = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cmb_)).BeginInit();
			this.SuspendLayout();
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle"; 
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.lbl_ColumnDesc);
			this.groupBox1.Controls.Add(this.cmb_);
			this.groupBox1.Controls.Add(this.txt_);
			this.groupBox1.Location = new System.Drawing.Point(5, 40);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(385, 40);
			this.groupBox1.TabIndex = 49;
			this.groupBox1.TabStop = false;
			// 
			// lbl_ColumnDesc
			// 
			this.lbl_ColumnDesc.ImageIndex = 0;
			this.lbl_ColumnDesc.ImageList = this.img_Label;
			this.lbl_ColumnDesc.Location = new System.Drawing.Point(7, 13);
			this.lbl_ColumnDesc.Name = "lbl_ColumnDesc";
			this.lbl_ColumnDesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_ColumnDesc.TabIndex = 103;
			this.lbl_ColumnDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cmb_
			// 
			this.cmb_.AccessibleDescription = "";
			this.cmb_.AccessibleName = "";
			this.cmb_.AddItemCols = 0;
			this.cmb_.AddItemSeparator = ';';
			this.cmb_.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_.Caption = "";
			this.cmb_.CaptionHeight = 17;
			this.cmb_.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_.ColumnCaptionHeight = 18;
			this.cmb_.ColumnFooterHeight = 18;
			this.cmb_.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_.ContentHeight = 16;
			this.cmb_.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_.EditorFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_.EditorHeight = 16;
			this.cmb_.Font = new System.Drawing.Font("Verdana", 9F);
			this.cmb_.GapHeight = 2;
			this.cmb_.ItemHeight = 15;
			this.cmb_.Location = new System.Drawing.Point(108, 14);
			this.cmb_.MatchEntryTimeout = ((long)(2000));
			this.cmb_.MaxDropDownItems = ((short)(5));
			this.cmb_.MaxLength = 32767;
			this.cmb_.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_.Name = "cmb_";
			this.cmb_.PartialRightColumn = false;
			this.cmb_.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{AlignVert:Center;Border:None,,0, 0, 0, 0;BackColor:ControlDark;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style1{}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:True;BackColor:Co" +
				"ntrol;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;AlignVert:Center;}Style8{}" +
				"Style10{}Style11{}Style9{AlignHorz:Near;}</Data></Styles><Splits><C1.Win.C1List." +
				"ListBoxView AllowColSelect=\"False\" Name=\"\" CaptionHeight=\"18\" ColumnCaptionHeigh" +
				"t=\"18\" ColumnFooterHeight=\"18\" VerticalScrollGroup=\"1\" HorizontalScrollGroup=\"1\"" +
				"><ClientRect>0, 0, 116, 156</ClientRect><VScrollBar><Width>17</Width></VScrollBa" +
				"r><HScrollBar><Height>17</Height></HScrollBar><CaptionStyle parent=\"Style2\" me=\"" +
				"Style9\" /><EvenRowStyle parent=\"EvenRow\" me=\"Style7\" /><FooterStyle parent=\"Foot" +
				"er\" me=\"Style3\" /><GroupStyle parent=\"Group\" me=\"Style11\" /><HeadingStyle parent" +
				"=\"Heading\" me=\"Style2\" /><HighLightRowStyle parent=\"HighlightRow\" me=\"Style6\" />" +
				"<InactiveStyle parent=\"Inactive\" me=\"Style4\" /><OddRowStyle parent=\"OddRow\" me=\"" +
				"Style8\" /><RecordSelectorStyle parent=\"RecordSelector\" me=\"Style10\" /><SelectedS" +
				"tyle parent=\"Selected\" me=\"Style5\" /><Style parent=\"Normal\" me=\"Style1\" /></C1.W" +
				"in.C1List.ListBoxView></Splits><NamedStyles><Style parent=\"\" me=\"Normal\" /><Styl" +
				"e parent=\"Normal\" me=\"Heading\" /><Style parent=\"Heading\" me=\"Footer\" /><Style pa" +
				"rent=\"Heading\" me=\"Caption\" /><Style parent=\"Heading\" me=\"Inactive\" /><Style par" +
				"ent=\"Normal\" me=\"Selected\" /><Style parent=\"Normal\" me=\"HighlightRow\" /><Style p" +
				"arent=\"Normal\" me=\"EvenRow\" /><Style parent=\"Normal\" me=\"OddRow\" /><Style parent" +
				"=\"Heading\" me=\"RecordSelector\" /><Style parent=\"Caption\" me=\"Group\" /></NamedSty" +
				"les><vertSplits>1</vertSplits><horzSplits>1</horzSplits><Layout>Modified</Layout" +
				"><DefaultRecSelWidth>16</DefaultRecSelWidth></Blob>";
			this.cmb_.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_.Size = new System.Drawing.Size(120, 20);
			this.cmb_.TabIndex = 52;
			this.cmb_.Visible = false;
			// 
			// txt_
			// 
			this.txt_.BackColor = System.Drawing.Color.White;
			this.txt_.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.txt_.Location = new System.Drawing.Point(229, 13);
			this.txt_.MaxLength = 100;
			this.txt_.Name = "txt_";
			this.txt_.Size = new System.Drawing.Size(120, 21);
			this.txt_.TabIndex = 53;
			this.txt_.Text = "";
			this.txt_.Visible = false;
			// 
			// btn_Apply
			// 
			this.btn_Apply.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Apply.ImageIndex = 0;
			this.btn_Apply.ImageList = this.img_Button;
			this.btn_Apply.Location = new System.Drawing.Point(249, 89);
			this.btn_Apply.Name = "btn_Apply";
			this.btn_Apply.Size = new System.Drawing.Size(70, 24);
			this.btn_Apply.TabIndex = 237;
			this.btn_Apply.Text = "Apply";
			this.btn_Apply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
			this.btn_Apply.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Apply.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Apply.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Apply.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(320, 89);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 238;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseHover += new System.EventHandler(this.btn_MouseHover);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// Pop_SelectionChange_FSP
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 120);
			this.Controls.Add(this.btn_Apply);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.groupBox1);
			this.Name = "Pop_SelectionChange_FSP";
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Apply, 0);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cmb_)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 멤버 메서드

 
		/// <summary>
		/// Init_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{ 
			try
			{
				this.Text = "Update selection row";
				lbl_MainTitle.Text = "Update selection row"; 


				ClassLib.ComFunction.SetLangDic(this); 


				Create_Control();
  
  	 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

 
 

		/// <summary>
		/// Create_Control : 셀타입에 따라서 콘트롤 표시
		/// </summary>
		private void Create_Control()
		{

			 

			lbl_ColumnDesc.Text = _ColumnDesc;


			

			if(_Grid.Cols[_Cell.c1].DataMap != null)
			{
 
				
				cmb_.Location = new Point(108, 13);
				cmb_.Size = new Size(268, 21);  

				cmb_.Visible = true; 



				//--------------------------------------------------------------------------------------
				// set combo list
				//--------------------------------------------------------------------------------------
				DataTable dt_ret = new DataTable("Combo List");
				dt_ret.Columns.Add(new DataColumn("CODE", typeof(string) ) );
				dt_ret.Columns.Add(new DataColumn("NAME", typeof(string) ) );



				System.Collections.IDictionary id = _Grid.Cols[_Cell.c1].DataMap;
				System.Collections.IEnumerator enum_code = id.Keys.GetEnumerator();
				System.Collections.IEnumerator enum_desc = id.Values.GetEnumerator();
 

				string[] combo_code = new string[id.Count];
				string[] combo_desc = new string[id.Count];
  
				 
				int count = 0; 

				while(enum_code.MoveNext() )
				{ 
					combo_code[count++] = enum_code.Current.ToString();  

				} // end while 
 

				count = 0; 


				while(enum_desc.MoveNext() )
				{ 
					combo_desc[count++] = enum_desc.Current.ToString();  

				} // end while 
 


				DataRow dr;

				for(int i = 0; i < combo_code.Length; i++)
				{
					dr = dt_ret.NewRow();

					dr["CODE"] = combo_code[i];
					dr["NAME"] = combo_desc[i];

					dt_ret.Rows.Add(dr);

				}

				ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_, 0, 1, false, 80, 170); 

				

				//--------------------------------------------------------------------------------------
 
				cmb_.SelectedValue = _Grid[_Cell.r1, _Cell.c1].ToString();


			}
			else
			{ 
				txt_.Location = new Point(108, 13);
				txt_.Size = new Size(268, 21); 
   
				txt_.Visible = true;



				if(_Default_Set_Flag)
				{
					txt_.Text = _Grid[_Cell.r1, _Cell.c1].ToString();
				}



			} // end if




			
		}



		#endregion 

		#region 이벤트 처리



		#region 버튼클릭시 이미지변경
 

		private void btn_MouseHover(object sender, System.EventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
			
		}

		private void btn_MouseLeave(object sender, System.EventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 

		}

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label; 
			 
			//image index default : 0, 2, 4
			if(src.ImageIndex % 2 == 0)
			{
				src.ImageIndex = src.ImageIndex + 1;
			}
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;

			//image index default : 1, 3, 5
			if(src.ImageIndex % 2 == 1)
			{
				src.ImageIndex = src.ImageIndex - 1;
			} 
		}

		
 

		#endregion  




		public bool _Close_Save = false;


		private void btn_Apply_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Close_Save = true; 
				

				string return_data = "";

				if(_Grid.Cols[_Cell.c1].DataMap != null) 
				{ 

					return_data = cmb_.SelectedValue.ToString(); 

				}
				else
				{  
					return_data = txt_.Text; 

				} // end if


				ClassLib.ComVar.Parameter_PopUp = new string[] { return_data };

				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Apply_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			try
			{
				_Close_Save = false;
				this.Close();
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Cancel_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
 


		#endregion 


	}
}

