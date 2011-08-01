using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdOrder
{
	public class Pop_SetDirectLotDayily : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리

		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label lbl_Lot;
		private System.Windows.Forms.Label lbl_PlanYMD;
		private System.Windows.Forms.TextBox txt_Lot;
		private System.Windows.Forms.TextBox txt_FactoryName;
		private System.Windows.Forms.TextBox txt_Factory;
		public C1.Win.C1List.C1Combo cmb_LineCd;
		public System.Windows.Forms.DateTimePicker dpick_PlanYMD;
		private System.ComponentModel.IContainer components = null;

		#endregion

		#region 생성자, 소멸자

		public Pop_SetDirectLotDayily()
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

		#endregion

		#region 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetDirectLotDayily));
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.lbl_Lot = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.lbl_PlanYMD = new System.Windows.Forms.Label();
			this.txt_Lot = new System.Windows.Forms.TextBox();
			this.txt_FactoryName = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.cmb_LineCd = new C1.Win.C1List.C1Combo();
			this.dpick_PlanYMD = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).BeginInit();
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
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(40, 55);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 70;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(40, 99);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 67;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Lot
			// 
			this.lbl_Lot.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Lot.ImageIndex = 0;
			this.lbl_Lot.ImageList = this.img_Label;
			this.lbl_Lot.Location = new System.Drawing.Point(40, 77);
			this.lbl_Lot.Name = "lbl_Lot";
			this.lbl_Lot.Size = new System.Drawing.Size(100, 21);
			this.lbl_Lot.TabIndex = 66;
			this.lbl_Lot.Text = "LOT";
			this.lbl_Lot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(241, 153);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 65;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 153);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 64;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// lbl_PlanYMD
			// 
			this.lbl_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_PlanYMD.ImageIndex = 0;
			this.lbl_PlanYMD.ImageList = this.img_Label;
			this.lbl_PlanYMD.Location = new System.Drawing.Point(40, 121);
			this.lbl_PlanYMD.Name = "lbl_PlanYMD";
			this.lbl_PlanYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_PlanYMD.TabIndex = 71;
			this.lbl_PlanYMD.Text = "Plan Date";
			this.lbl_PlanYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_Lot
			// 
			this.txt_Lot.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Lot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Lot.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Lot.Location = new System.Drawing.Point(141, 77);
			this.txt_Lot.MaxLength = 60;
			this.txt_Lot.Name = "txt_Lot";
			this.txt_Lot.ReadOnly = true;
			this.txt_Lot.Size = new System.Drawing.Size(210, 21);
			this.txt_Lot.TabIndex = 189;
			this.txt_Lot.Text = "";
			// 
			// txt_FactoryName
			// 
			this.txt_FactoryName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_FactoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_FactoryName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_FactoryName.Location = new System.Drawing.Point(211, 55);
			this.txt_FactoryName.MaxLength = 60;
			this.txt_FactoryName.Name = "txt_FactoryName";
			this.txt_FactoryName.ReadOnly = true;
			this.txt_FactoryName.Size = new System.Drawing.Size(140, 21);
			this.txt_FactoryName.TabIndex = 187;
			this.txt_FactoryName.Text = "";
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Factory.Location = new System.Drawing.Point(141, 55);
			this.txt_Factory.MaxLength = 60;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.ReadOnly = true;
			this.txt_Factory.Size = new System.Drawing.Size(69, 21);
			this.txt_Factory.TabIndex = 186;
			this.txt_Factory.Text = "";
			// 
			// cmb_LineCd
			// 
			this.cmb_LineCd.AddItemCols = 0;
			this.cmb_LineCd.AddItemSeparator = ';';
			this.cmb_LineCd.AllowRowSizing = C1.Win.C1List.RowSizingEnum.AllRows;
			this.cmb_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cmb_LineCd.Caption = "";
			this.cmb_LineCd.CaptionHeight = 17;
			this.cmb_LineCd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
			this.cmb_LineCd.ColumnCaptionHeight = 18;
			this.cmb_LineCd.ColumnFooterHeight = 18;
			this.cmb_LineCd.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
			this.cmb_LineCd.ContentHeight = 17;
			this.cmb_LineCd.DeadAreaBackColor = System.Drawing.Color.Empty;
			this.cmb_LineCd.EditorBackColor = System.Drawing.SystemColors.Window;
			this.cmb_LineCd.EditorFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cmb_LineCd.EditorForeColor = System.Drawing.SystemColors.WindowText;
			this.cmb_LineCd.EditorHeight = 17;
			this.cmb_LineCd.Font = new System.Drawing.Font("Verdana", 9F);
			this.cmb_LineCd.GapHeight = 2;
			this.cmb_LineCd.ItemHeight = 15;
			this.cmb_LineCd.Location = new System.Drawing.Point(141, 99);
			this.cmb_LineCd.MatchEntryTimeout = ((long)(2000));
			this.cmb_LineCd.MaxDropDownItems = ((short)(5));
			this.cmb_LineCd.MaxLength = 32767;
			this.cmb_LineCd.MouseCursor = System.Windows.Forms.Cursors.Default;
			this.cmb_LineCd.Name = "cmb_LineCd";
			this.cmb_LineCd.PartialRightColumn = false;
			this.cmb_LineCd.PropBag = "<?xml version=\"1.0\"?><Blob><Styles type=\"C1.Win.C1List.Design.ContextWrapper\"><Da" +
				"ta>Group{BackColor:ControlDark;Border:None,,0, 0, 0, 0;AlignVert:Center;}Style2{" +
				"}Style5{}Style4{}Style7{}Style6{}EvenRow{BackColor:Aqua;}Selected{ForeColor:High" +
				"lightText;BackColor:Highlight;}Style3{}Inactive{ForeColor:InactiveCaptionText;Ba" +
				"ckColor:InactiveCaption;}Footer{}Caption{AlignHorz:Center;}Normal{Font:Verdana, " +
				"9pt;BackColor:Window;}HighlightRow{ForeColor:HighlightText;BackColor:Highlight;}" +
				"Style9{AlignHorz:Near;}OddRow{}RecordSelector{AlignImage:Center;}Heading{Wrap:Tr" +
				"ue;AlignVert:Center;Border:Raised,,1, 1, 1, 1;ForeColor:ControlText;BackColor:Co" +
				"ntrol;}Style8{}Style10{}Style11{}Style1{}</Data></Styles><Splits><C1.Win.C1List." +
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
				"><DefaultRecSelWidth>17</DefaultRecSelWidth></Blob>";
			this.cmb_LineCd.RowDivider.Color = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
			this.cmb_LineCd.RowSubDividerColor = System.Drawing.Color.DarkGray;
			this.cmb_LineCd.Size = new System.Drawing.Size(210, 21);
			this.cmb_LineCd.TabIndex = 185;
			this.cmb_LineCd.SelectedValueChanged += new System.EventHandler(this.cmb_LineCd_SelectedValueChanged);
			// 
			// dpick_PlanYMD
			// 
			this.dpick_PlanYMD.CustomFormat = "yyyyMMdd";
			this.dpick_PlanYMD.Font = new System.Drawing.Font("Verdana", 9F);
			this.dpick_PlanYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_PlanYMD.Location = new System.Drawing.Point(141, 121);
			this.dpick_PlanYMD.Name = "dpick_PlanYMD";
			this.dpick_PlanYMD.Size = new System.Drawing.Size(211, 22);
			this.dpick_PlanYMD.TabIndex = 190;
			this.dpick_PlanYMD.ValueChanged += new System.EventHandler(this.dpick_PlanYMD_ValueChanged);
			// 
			// Pop_SetDirectLotDayily
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 186);
			this.Controls.Add(this.dpick_PlanYMD);
			this.Controls.Add(this.txt_Lot);
			this.Controls.Add(this.txt_FactoryName);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.cmb_LineCd);
			this.Controls.Add(this.lbl_PlanYMD);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.lbl_LineCd);
			this.Controls.Add(this.lbl_Lot);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_SetDirectLotDayily";
			this.Text = "LOT Daily";
			this.Load += new System.EventHandler(this.Pop_SetDirectLotDayily_Load);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.lbl_Lot, 0);
			this.Controls.SetChildIndex(this.lbl_LineCd, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.lbl_PlanYMD, 0);
			this.Controls.SetChildIndex(this.cmb_LineCd, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_FactoryName, 0);
			this.Controls.SetChildIndex(this.txt_Lot, 0);
			this.Controls.SetChildIndex(this.dpick_PlanYMD, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			((System.ComponentModel.ISupportInitialize)(this.cmb_LineCd)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion 

		#region 변수 정의
 
		
		private COM.OraDB MyOraDB = new COM.OraDB();
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave;

		private string _Factory, _LotNo, _LotSeq;
		private string _DaySeq, _LineCd, _PlanYMD;
		private string _LoadDiv;
		private string _ShipDateF_50 = "";
		private bool _LOT_All_Before_40_Flag;

		//MPS에서
		//라인 이동할때 현재 라인 선택시 이동 못하도록 하기 위한 변수
		public string _Sel_LineCd;




		#endregion 

		#region 멤버 메서드
 
		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
 		 
			try
			{


				ClassLib.ComFunction.SetLangDic(this);

				_LoadDiv = ClassLib.ComVar.Parameter_PopUp[5];   // 0 : LOT, 1 : MPS, 2 : MPS-Move dayseq
			

				//Title 
				if(_LoadDiv == "0")
				{
					this.Text = "Create LOT Daily";
					lbl_MainTitle.Text = "Display Create LOT Daily";

				}
				else if(_LoadDiv == "1")
				{
					this.Text = "Move into Another Line";
					lbl_MainTitle.Text = "Move into Another Line";

				}
				else if(_LoadDiv == "2")
				{
					this.Text = "Change Asy. Date";
					lbl_MainTitle.Text = "Change Asy. Date";

				}


				Init_Control(); 


			
				

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Init_Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 


		}


		private void Init_Control()
		{

			dpick_PlanYMD.CustomFormat = " "; 

			//{factory, factory_name, lot_no, lot_seq, po_no} 

			_Factory = ClassLib.ComVar.Parameter_PopUp[0];
			_LotNo = ClassLib.ComVar.Parameter_PopUp[2];
			_LotSeq = ClassLib.ComVar.Parameter_PopUp[3]; 

			
			txt_Factory.Text = _Factory; 
			txt_FactoryName.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
			txt_Lot.Text = _LotNo + "-" + _LotSeq; 

			
			DataTable dt_ret = FlexAPS.ProdBase.Form_PB_Line.Select_SPB_LINE(_Factory); 
			ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_LineCd, 1, 2, false, COM.ComVar.ComboList_Visible.Name); 



			if(ClassLib.ComVar.Parameter_PopUp[4] == "" || ClassLib.ComVar.Parameter_PopUp[4] == "________") return;

			dpick_PlanYMD.Text = MyComFunction.ConvertDate2Type(ClassLib.ComVar.Parameter_PopUp[4]);
		 
			if(_LoadDiv == "2") 
			{
				_PlanYMD =ClassLib.ComVar.Parameter_PopUp[4];
				_LineCd = ClassLib.ComVar.Parameter_PopUp[6];  
				cmb_LineCd.SelectedValue = _LineCd;
				_DaySeq = ClassLib.ComVar.Parameter_PopUp[7];
				_ShipDateF_50 = ClassLib.ComVar.Parameter_PopUp[8];
				_LOT_All_Before_40_Flag = ClassLib.ComVar.Parameter_PopUp[9] == "Y" ? true : false;
				
			}


		}



		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{
			this.Close();
		}

   
 

		#endregion 

		#region 이벤트 처리

		


		private void btn_Save_Click(object sender, System.EventArgs e)
		{

			try
			{

				this.Cursor = Cursors.WaitCursor;



				if(_LoadDiv == "0")
				{
					Save_SPB_LOT_DAILY();  
				} 
				else if(_LoadDiv == "1")
				{
					COM.ComVar.Parameter_PopUp = new string[] {cmb_LineCd.SelectedValue.ToString(), dpick_PlanYMD.Text};
				}
				else if(_LoadDiv == "2")
				{

					// LOT 이 모두 SHIPPING 40 이전에 배치되면 처리 가능.
					// 선택된 PLAN_DATE 가 현재 일자보다 이전이고, SHIPPING 40 이전에 배치되면, 처리 하지 않음.
					if(! _LOT_All_Before_40_Flag 
						&& Convert.ToInt32(dpick_PlanYMD.Text) <= Convert.ToInt32(_PlanYMD)
						&& Convert.ToInt32(dpick_PlanYMD.Text) < Convert.ToInt32(_ShipDateF_50) )
					{


						// poweruser 권한이면, 비밀번호 인증 후. 작업 가능 처리
						if(ClassLib.ComVar.This_PowerUser_YN == "Y")
						{

							FlexAPS.ProdPlan.Pop_Password pop_password = new FlexAPS.ProdPlan.Pop_Password();
							pop_password.ShowDialog();

							// 비밀번호 인증 캔슬이거나, 비밀번호 인증 실패일 경우 처리 불가능
							if(! pop_password._Apply_Flag) 
							{
								_CloseSave = false;
								this.Close(); 
								return;
							}

							if(! pop_password._Password_OK_Flag) 
							{
								_CloseSave = false;
								this.Close(); 
								return;
							} 


						}
						else
						{

							ClassLib.ComFunction.User_Message("Shipping area. Can't move LOT.", "LOT Move", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
							_CloseSave = false;
							this.Close();
							return;
						}


					}

					ReSet_SP_SPO_CHG_LOT_DAILY(); 
				}



				_CloseSave = true;
				Close_Form();

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
 

		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 1; 
		}

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 0;
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			 
			_CloseSave = false;
			Close_Form();
		} 

		private void btn_Cancel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 1;
		}

		private void btn_Cancel_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Cancel.ImageIndex = 0;
		}

 
		private void dpick_PlanYMD_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_PlanYMD.CustomFormat = "yyyyMMdd"; 
		}

	
		private void cmb_LineCd_SelectedValueChanged(object sender, System.EventArgs e)
		{
 
			try
			{

				if(_LoadDiv == "0") return; 
 
			 
				if(cmb_LineCd.SelectedIndex != -1 && cmb_LineCd.SelectedValue.ToString() == _Sel_LineCd)
				{
					MessageBox.Show("Select Another Line"); 
					cmb_LineCd.SelectedIndex = -1; 
					return; 
				}
		 
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

 
		}

		#endregion 

		#region DB Connect

		 


		/// <summary>
		/// Save_SPB_LOT_DAYILY : 
		/// </summary>
		private void Save_SPB_LOT_DAILY() 
		{  

			DataSet ds_ret;

			try
			{
				MyOraDB.ReDim_Parameter(6); 
 
				MyOraDB.Process_Name = "SP_SPO_Create_DLotDaily"; 
  
				MyOraDB.Parameter_Name[0] = "arg_factory";
				MyOraDB.Parameter_Name[1] = "arg_lot_no";
				MyOraDB.Parameter_Name[2] = "arg_lot_seq"; 
				MyOraDB.Parameter_Name[3] = "arg_line_cd"; 
				MyOraDB.Parameter_Name[4] = "arg_plan_ymd"; 
				MyOraDB.Parameter_Name[5] = "arg_upd_user";  
  
				for (int i = 0; i <= 5; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			
 
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _LotNo;
				MyOraDB.Parameter_Values[2] = _LotSeq;
				MyOraDB.Parameter_Values[3] = cmb_LineCd.SelectedValue.ToString();
				MyOraDB.Parameter_Values[4] = dpick_PlanYMD.Text;
				MyOraDB.Parameter_Values[5] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Run_Parameter(true);  

  

				//SP_SPO_Assign_LOT3 procedure에서 전개속성에 세팅되어 있으면 사이즈 배분함

//				MyOraDB.ReDim_Parameter(4); 
// 
//				MyOraDB.Process_Name = "SP_SPO_Assign_Daily_Size"; 
//  
//				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
//				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
//				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
//				MyOraDB.Parameter_Name[3] = "ARG_UPD_USER"; 
//  
//				for (int i = 0; i <= 3; i++)
//				{
//					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
//				}			
//
//			 
//				MyOraDB.Parameter_Values[0] = _Factory;
//				MyOraDB.Parameter_Values[1] = _LotNo;
//				MyOraDB.Parameter_Values[2] = _LotSeq;
//				MyOraDB.Parameter_Values[3] = ClassLib.ComVar.This_User;  
//
//
//				MyOraDB.Add_Run_Parameter(false);   


				ds_ret =  MyOraDB.Exe_Run_Procedure();	 

			 
				if(ds_ret == null) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				}
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_SPB_LOT_DAILY", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 

			
			 

 
		}



		/// <summary>
		/// ReSet_SP_SPO_CHG_LOT_DAILY : 
		/// </summary>
		private void ReSet_SP_SPO_CHG_LOT_DAILY() 
		{  

			DataSet ds_ret;

			try
			{ 
				MyOraDB.ReDim_Parameter(7); 
	
				MyOraDB.Process_Name = "SP_SPO_CHG_LOT_DAILY";    

				MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
				MyOraDB.Parameter_Name[1] = "ARG_LOT_NO";
				MyOraDB.Parameter_Name[2] = "ARG_LOT_SEQ"; 
				MyOraDB.Parameter_Name[3] = "ARG_DAY_SEQ";
				MyOraDB.Parameter_Name[4] = "ARG_STR_YMD";
				MyOraDB.Parameter_Name[5] = "ARG_ALL_YN";
				MyOraDB.Parameter_Name[6] = "ARG_UPD_USER"; 
	
				for (int i = 0; i <= 6; i++)
				{
					MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
				}			

				
				MyOraDB.Parameter_Values[0] = _Factory;
				MyOraDB.Parameter_Values[1] = _LotNo;
				MyOraDB.Parameter_Values[2] = _LotSeq;
				MyOraDB.Parameter_Values[3] = _DaySeq;
				MyOraDB.Parameter_Values[4] = dpick_PlanYMD.Text.Replace(ClassLib.ComVar.This_SetedDateSign, "");  
				MyOraDB.Parameter_Values[5] = "Y";
				MyOraDB.Parameter_Values[6] = ClassLib.ComVar.This_User;  


				MyOraDB.Add_Run_Parameter(true);   
				ds_ret =  MyOraDB.Exe_Run_Procedure(); 

				if(ds_ret == null) 
				{
					ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsDoNotRun, this);
				}
				else
				{
					
					
					#region e-mail


//					//--------------------------------------------------------------------------------------------------
//					// e-mail
//					//--------------------------------------------------------------------------------------------------
//                    System.Web.Mail.MailMessage mail = new System.Web.Mail.MailMessage();
//            
//					mail.From = COM.ComVar.This_User;
//					mail.To = "hwanjeong.jeong@dskorea.com";
//					mail.Subject = @"Shipping Schedule 'Yellow' 구간 생산계획(MPS) 변경";
//					mail.BodyFormat = System.Web.Mail.MailFormat.Html;
//					mail.Body = @"Shipping Schedule 'Yellow' 구간 생산계획(MPS) 변경되었습니다."
//						           + "\r\n\r\n" + @"Line : " + _LineCd
//					               + "\r\n" + @"Plan Date : " + _PlanYMD
//					               + "\r\n" + @"LOT : " + _LotNo + "-" + _LotSeq;
//					 
//
//					System.Web.Mail.SmtpMail.SmtpServer = "203.228.108.7";
//					System.Web.Mail.SmtpMail.Send(mail);


					#endregion


				}



			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ReSet_SP_SPO_CHG_LOT_DAILY", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
			 

			

 
		}



		#endregion 


		
		private void Pop_SetDirectLotDayily_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
 

		

		
	 


	}
}

