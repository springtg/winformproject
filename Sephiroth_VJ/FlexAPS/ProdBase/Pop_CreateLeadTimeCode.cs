using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_CreateLeadTimeCode : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_FactoryName;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label lbl_LTCd;
		private System.Windows.Forms.Label lbl_LTDesc;
		public System.Windows.Forms.CheckBox chk_DefaultYN;
		private System.Windows.Forms.Label lbl_DefaultYN;
		public System.Windows.Forms.TextBox txt_LTCd;
		public System.Windows.Forms.TextBox txt_LTDesc;
		public System.Windows.Forms.DateTimePicker dpick_ApplyYMD;
		public System.Windows.Forms.Label lbl_ApplyYMD;
		public System.Windows.Forms.TextBox txt_ApplyYMD;
		public System.Windows.Forms.Label lbl_ApplyYMDNew;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateLeadTimeCode()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateLeadTimeCode));
			this.txt_LTCd = new System.Windows.Forms.TextBox();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.txt_FactoryName = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_LTCd = new System.Windows.Forms.Label();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.txt_LTDesc = new System.Windows.Forms.TextBox();
			this.lbl_LTDesc = new System.Windows.Forms.Label();
			this.chk_DefaultYN = new System.Windows.Forms.CheckBox();
			this.lbl_DefaultYN = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.dpick_ApplyYMD = new System.Windows.Forms.DateTimePicker();
			this.txt_ApplyYMD = new System.Windows.Forms.TextBox();
			this.lbl_ApplyYMD = new System.Windows.Forms.Label();
			this.lbl_ApplyYMDNew = new System.Windows.Forms.Label();
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
			// txt_LTCd
			// 
			this.txt_LTCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_LTCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LTCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LTCd.Location = new System.Drawing.Point(141, 112);
			this.txt_LTCd.MaxLength = 10;
			this.txt_LTCd.Name = "txt_LTCd";
			this.txt_LTCd.Size = new System.Drawing.Size(210, 21);
			this.txt_LTCd.TabIndex = 201;
			this.txt_LTCd.Text = "";
			// 
			// txt_LineName
			// 
			this.txt_LineName.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineName.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineName.Location = new System.Drawing.Point(211, 77);
			this.txt_LineName.MaxLength = 60;
			this.txt_LineName.Name = "txt_LineName";
			this.txt_LineName.ReadOnly = true;
			this.txt_LineName.Size = new System.Drawing.Size(140, 21);
			this.txt_LineName.TabIndex = 200;
			this.txt_LineName.Text = "";
			// 
			// txt_LineCd
			// 
			this.txt_LineCd.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_LineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_LineCd.Location = new System.Drawing.Point(141, 77);
			this.txt_LineCd.MaxLength = 60;
			this.txt_LineCd.Name = "txt_LineCd";
			this.txt_LineCd.ReadOnly = true;
			this.txt_LineCd.Size = new System.Drawing.Size(69, 21);
			this.txt_LineCd.TabIndex = 199;
			this.txt_LineCd.Text = "";
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
			this.txt_FactoryName.TabIndex = 198;
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
			this.txt_Factory.TabIndex = 197;
			this.txt_Factory.Text = "";
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_Factory.ImageIndex = 0;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(40, 55);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 196;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LTCd
			// 
			this.lbl_LTCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LTCd.ImageIndex = 0;
			this.lbl_LTCd.ImageList = this.img_Label;
			this.lbl_LTCd.Location = new System.Drawing.Point(40, 112);
			this.lbl_LTCd.Name = "lbl_LTCd";
			this.lbl_LTCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LTCd.TabIndex = 195;
			this.lbl_LTCd.Text = "L/T Code";
			this.lbl_LTCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(40, 77);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 194;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(170, 261);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 193;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 261);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 192;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// txt_LTDesc
			// 
			this.txt_LTDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_LTDesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_LTDesc.Location = new System.Drawing.Point(141, 134);
			this.txt_LTDesc.MaxLength = 50;
			this.txt_LTDesc.Name = "txt_LTDesc";
			this.txt_LTDesc.Size = new System.Drawing.Size(210, 22);
			this.txt_LTDesc.TabIndex = 207;
			this.txt_LTDesc.Text = "";
			// 
			// lbl_LTDesc
			// 
			this.lbl_LTDesc.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LTDesc.ImageIndex = 0;
			this.lbl_LTDesc.ImageList = this.img_Label;
			this.lbl_LTDesc.Location = new System.Drawing.Point(40, 134);
			this.lbl_LTDesc.Name = "lbl_LTDesc";
			this.lbl_LTDesc.Size = new System.Drawing.Size(100, 21);
			this.lbl_LTDesc.TabIndex = 202;
			this.lbl_LTDesc.Text = "L/T Description";
			this.lbl_LTDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// chk_DefaultYN
			// 
			this.chk_DefaultYN.BackColor = System.Drawing.Color.Transparent;
			this.chk_DefaultYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_DefaultYN.Location = new System.Drawing.Point(141, 156);
			this.chk_DefaultYN.Name = "chk_DefaultYN";
			this.chk_DefaultYN.Size = new System.Drawing.Size(16, 21);
			this.chk_DefaultYN.TabIndex = 206;
			// 
			// lbl_DefaultYN
			// 
			this.lbl_DefaultYN.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_DefaultYN.ImageIndex = 0;
			this.lbl_DefaultYN.ImageList = this.img_Label;
			this.lbl_DefaultYN.Location = new System.Drawing.Point(40, 156);
			this.lbl_DefaultYN.Name = "lbl_DefaultYN";
			this.lbl_DefaultYN.Size = new System.Drawing.Size(100, 21);
			this.lbl_DefaultYN.TabIndex = 205;
			this.lbl_DefaultYN.Text = "Standard Y/N";
			this.lbl_DefaultYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Delete
			// 
			this.btn_Delete.ImageIndex = 0;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(241, 261);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(70, 23);
			this.btn_Delete.TabIndex = 204;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// dpick_ApplyYMD
			// 
			this.dpick_ApplyYMD.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ApplyYMD.CustomFormat = "yyyyMMdd";
			this.dpick_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.dpick_ApplyYMD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpick_ApplyYMD.Location = new System.Drawing.Point(141, 192);
			this.dpick_ApplyYMD.Name = "dpick_ApplyYMD";
			this.dpick_ApplyYMD.Size = new System.Drawing.Size(211, 22);
			this.dpick_ApplyYMD.TabIndex = 209;
			this.dpick_ApplyYMD.ValueChanged += new System.EventHandler(this.dpick_ApplyYMD_ValueChanged);
			// 
			// txt_ApplyYMD
			// 
			this.txt_ApplyYMD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txt_ApplyYMD.Location = new System.Drawing.Point(144, 216);
			this.txt_ApplyYMD.MaxLength = 50;
			this.txt_ApplyYMD.Name = "txt_ApplyYMD";
			this.txt_ApplyYMD.Size = new System.Drawing.Size(210, 22);
			this.txt_ApplyYMD.TabIndex = 211;
			this.txt_ApplyYMD.Text = "";
			this.txt_ApplyYMD.Visible = false;
			// 
			// lbl_ApplyYMD
			// 
			this.lbl_ApplyYMD.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ApplyYMD.ImageIndex = 0;
			this.lbl_ApplyYMD.ImageList = this.img_Label;
			this.lbl_ApplyYMD.Location = new System.Drawing.Point(40, 216);
			this.lbl_ApplyYMD.Name = "lbl_ApplyYMD";
			this.lbl_ApplyYMD.Size = new System.Drawing.Size(100, 21);
			this.lbl_ApplyYMD.TabIndex = 210;
			this.lbl_ApplyYMD.Text = "Old ApplyDate";
			this.lbl_ApplyYMD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_ApplyYMD.Visible = false;
			// 
			// lbl_ApplyYMDNew
			// 
			this.lbl_ApplyYMDNew.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ApplyYMDNew.ImageIndex = 0;
			this.lbl_ApplyYMDNew.ImageList = this.img_Label;
			this.lbl_ApplyYMDNew.Location = new System.Drawing.Point(40, 192);
			this.lbl_ApplyYMDNew.Name = "lbl_ApplyYMDNew";
			this.lbl_ApplyYMDNew.Size = new System.Drawing.Size(100, 21);
			this.lbl_ApplyYMDNew.TabIndex = 208;
			this.lbl_ApplyYMDNew.Text = "New ApplyDate";
			this.lbl_ApplyYMDNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_CreateLeadTimeCode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(392, 296);
			this.Controls.Add(this.txt_ApplyYMD);
			this.Controls.Add(this.lbl_ApplyYMD);
			this.Controls.Add(this.dpick_ApplyYMD);
			this.Controls.Add(this.lbl_ApplyYMDNew);
			this.Controls.Add(this.chk_DefaultYN);
			this.Controls.Add(this.lbl_DefaultYN);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.txt_LTDesc);
			this.Controls.Add(this.lbl_LTDesc);
			this.Controls.Add(this.txt_LTCd);
			this.Controls.Add(this.txt_LineName);
			this.Controls.Add(this.txt_LineCd);
			this.Controls.Add(this.txt_FactoryName);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.lbl_LTCd);
			this.Controls.Add(this.lbl_LineCd);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_CreateLeadTimeCode";
			this.Text = "Create LeadTime Code";
			this.Load += new System.EventHandler(this.Pop_CreateLeadTimeCode_Load);
			this.ResumeLayout(false);

		}
		#endregion
 
		#endregion  

		#region 변수 정의 

		private COM.OraDB MyOraDB = new COM.OraDB(); 
		private COM.ComFunction MyComFunction = new COM.ComFunction();

		// leadtime_cd event(0), apply_ymd event(1)
		private string _LoadEvent;

		//신규입력 또는 수정상태 표시 플래그
		private bool _Insert_Flag; 

		//폼 닫힐때 일어난 이벤트 (저장(I, U), 삭제(D), 취소(C))
		public string _CloseEvent;

		#endregion 

		#region 멤버 메서드

		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{

			ClassLib.ComFunction.SetLangDic(this);


			dpick_ApplyYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType; 

			_LoadEvent = ClassLib.ComVar.Parameter_PopUp[0]; 
 
			//create leadtime_cd
			if(_LoadEvent == "0") 
			{
				this.Text = "Create LeadTime Code";
				this.lbl_MainTitle.Text = "Create LeadTime Code"; 
			}
				//create apply_ymd
			else if(_LoadEvent == "1")
			{
				this.Text = "Create Apply Date";
				this.lbl_MainTitle.Text = "Create Apply Date"; 
			}
  

			//{factory, factory_name, linecd, line_name,
			// leadtime_cd, leadtime_desc, default_yn}
			txt_Factory.Text = ClassLib.ComVar.Parameter_PopUp[1];  
			txt_FactoryName.Text = ClassLib.ComVar.Parameter_PopUp[2];
			txt_LineCd.Text = ClassLib.ComVar.Parameter_PopUp[3];
			txt_LineName.Text = ClassLib.ComVar.Parameter_PopUp[4];
			txt_LTCd.Text = ClassLib.ComVar.Parameter_PopUp[5];
			txt_LTDesc.Text = ClassLib.ComVar.Parameter_PopUp[6];
			chk_DefaultYN.Checked = Convert.ToBoolean(ClassLib.ComVar.Parameter_PopUp[7]);
 
			//create leadtime_cd
			if(_LoadEvent == "0") 
			{
				if(chk_DefaultYN.Checked) chk_DefaultYN.Enabled = false;

				if(txt_LTCd.Text == "") 
					_Insert_Flag = true;
				else
				{
					txt_LTCd.ReadOnly = true;
					txt_LTCd.BackColor = ClassLib.ComVar.ClrReadOnly;
				}

			}
				//create apply_ymd
			else if(_LoadEvent == "1")
			{ 
				txt_ApplyYMD.Text = ClassLib.ComVar.Parameter_PopUp[8];
				if(txt_ApplyYMD.Text.Trim() == "") _Insert_Flag = true;

			} 

		}



		
//		/// <summary>
//		/// Check_Max_ApplyYMD : 바꾸고자 하는 리드타임 적용 일자는 항상 최대일자여야 함
//		/// </summary>
//		/// <returns></returns>
//		private bool Check_Max_ApplyYMD()
//		{
//			string max_value = "";
//
//			max_value = Get_Max_ApplyYMD();
//
//			// max apply_ymd = null일 경우
//			if(max_value == "_") return true;
//
//			if(Convert.ToInt32(dpick_ApplyYMD.Text) > Convert.ToInt32(max_value) ) 
//				return true;
//			else
//			{
//				MessageBox.Show("최대 리드타임 적용일자 입력");
//				return false;
//			}
//		}


		#endregion 

		#region 이벤트 처리 

		private void btn_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 1;
		}

		private void btn_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Label src = sender as Label;
			src.ImageIndex = 0;
		}

		#endregion
 
		#region DB Connect
 

		/// <summary>
		/// Get_Max_ApplyYMD : 최대 리드타임 적용일자 추출
		/// </summary>
		/// <returns></returns>
		private string Get_Max_ApplyYMD()
		{ 
			DataSet ds_ret = null;

			try
			{
				string process_name = "PKG_SPB_LINE.GET_MAX_APPLYYMD";

				MyOraDB.ReDim_Parameter(4); 
 
				MyOraDB.Process_Name = process_name; 
 
				MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[2] = "ARG_LEADTIME_CD"; 
				MyOraDB.Parameter_Name[3] = "OUT_CURSOR";

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar; 
				MyOraDB.Parameter_Type[3] = (int)OracleType.Cursor;
				 
				MyOraDB.Parameter_Values[0] = txt_Factory.Text; 
				MyOraDB.Parameter_Values[1] = txt_LineCd.Text;
				MyOraDB.Parameter_Values[2] = txt_LTCd.Text;
				MyOraDB.Parameter_Values[3] = "";  

				MyOraDB.Add_Select_Parameter(true); 
				ds_ret = MyOraDB.Exe_Select_Procedure();	 
				
				if(ds_ret == null) return null ; 
				return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Get_Max_ApplyYMD",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return null;
			} 
		}


		/// <summary>
		/// Update_SPB_LINEOP_LEADTIME :  
		/// </summary>
		private bool Update_SPB_LINEOP_LEADTIME(string arg_division)
		{ 
			try
			{
				MyOraDB.ReDim_Parameter(9);  
				MyOraDB.Process_Name = "PKG_SPB_LINE.UPDATE_SPB_LINEOP_LEADTIME"; 

				MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
				MyOraDB.Parameter_Name[1] = "ARG_FACTORY"; 
				MyOraDB.Parameter_Name[2] = "ARG_LINE_CD";
				MyOraDB.Parameter_Name[3] = "ARG_LEADTIME_CD";
				MyOraDB.Parameter_Name[4] = "ARG_LEADTIME_DESC";
				MyOraDB.Parameter_Name[5] = "ARG_APPLY_YMD";
				MyOraDB.Parameter_Name[6] = "ARG_APPLY_YMD_NEW";
				MyOraDB.Parameter_Name[7] = "ARG_DEFAULT_YN"; 
				MyOraDB.Parameter_Name[8] = "ARG_UPD_USER"; 

				MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				 
				MyOraDB.Parameter_Values[0] = arg_division; 
				MyOraDB.Parameter_Values[1] = txt_Factory.Text;
				MyOraDB.Parameter_Values[2] = txt_LineCd.Text;
				MyOraDB.Parameter_Values[3] = txt_LTCd.Text; 
				MyOraDB.Parameter_Values[4] = txt_LTDesc.Text;
				MyOraDB.Parameter_Values[5] = ClassLib.ComFunction.Empty_String(txt_ApplyYMD.Text, " ");
				MyOraDB.Parameter_Values[6] = ClassLib.ComFunction.Empty_String(MyComFunction.ConvertDate2DbType(dpick_ApplyYMD.Text), " ");			 
				MyOraDB.Parameter_Values[7] = (chk_DefaultYN.Checked) ? "Y" : "N";  
				MyOraDB.Parameter_Values[8] = ClassLib.ComVar.This_User;

				MyOraDB.Add_Modify_Parameter(true);	 
				MyOraDB.Exe_Modify_Procedure();		 
				
				return true;

			}
			catch(Exception ex)
			{
				MessageBox.Show( ex.Message,"Update_SPB_LINEOP_LEADTIME",MessageBoxButtons.OK,MessageBoxIcon.Error) ;
				return false;
			} 
		}


		#endregion


		private void Pop_CreateLeadTimeCode_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			//신규등록인 경우는 그냥 폼 닫기
			//기존정보인 경우는 update 후 폼 닫기 
			
			bool save_flag = false;

			switch(_LoadEvent)
			{
				case "0":       //create leadtime_cd

					if(_Insert_Flag)
					{
						//코드 중복 체크 필요

						_CloseEvent = "I"; 
						ClassLib.ComVar.Parameter_PopUp = new string[] {txt_LTCd.Text, 
																		txt_LTDesc.Text, 
																		chk_DefaultYN.Checked.ToString()};
					}
					else 
					{
						_CloseEvent = "U"; 
						Update_SPB_LINEOP_LEADTIME("U");
					}

					break;

				case "1":       //create apply_ymd

					if(_Insert_Flag)
					{
						_CloseEvent = "I"; 
						ClassLib.ComVar.Parameter_PopUp = new string[] {MyComFunction.ConvertDate2DbType(dpick_ApplyYMD.Text) };
					}
					else
					{
						_CloseEvent = "U";
						//save_flag = Check_Max_ApplyYMD();
						if(save_flag) Update_SPB_LINEOP_LEADTIME("U");
					}

					break; 
			}
			
		 
			
			this.Close();
		}
 

		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			_CloseEvent = "D";
			Update_SPB_LINEOP_LEADTIME("D");

			this.Close();
		}

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			_CloseEvent = "C";
			this.Close();
		}

		private void dpick_ApplyYMD_ValueChanged(object sender, System.EventArgs e)
		{
			dpick_ApplyYMD.CustomFormat = ClassLib.ComVar.This_SetedDateType;  
		}
	
 
	}
}

