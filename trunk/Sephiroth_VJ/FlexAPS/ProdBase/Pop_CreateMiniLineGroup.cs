using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace FlexAPS.ProdBase
{
	public class Pop_CreateMiniLineGroup : COM.APSWinForm.Pop_Small
	{
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.TextBox txt_FactoryName;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.Label lbl_LineCd;
		private System.Windows.Forms.TextBox txt_LineCd;
		private System.Windows.Forms.TextBox txt_LineName;
		private System.Windows.Forms.Label lbl_MLine;
		private System.Windows.Forms.TextBox txt_MLineCd;
		private System.Windows.Forms.Label lb_MLineGroup;
		private System.Windows.Forms.TextBox txt_MLineGroup;
		private System.Windows.Forms.ImageList img_MiniButton;
		private System.Windows.Forms.Label btn_CreateGroup;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public Pop_CreateMiniLineGroup()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_CreateMiniLineGroup));
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.lbl_MLine = new System.Windows.Forms.Label();
			this.lbl_LineCd = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
			this.lb_MLineGroup = new System.Windows.Forms.Label();
			this.txt_LineCd = new System.Windows.Forms.TextBox();
			this.txt_FactoryName = new System.Windows.Forms.TextBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.txt_LineName = new System.Windows.Forms.TextBox();
			this.txt_MLineGroup = new System.Windows.Forms.TextBox();
			this.txt_MLineCd = new System.Windows.Forms.TextBox();
			this.img_MiniButton = new System.Windows.Forms.ImageList(this.components);
			this.btn_CreateGroup = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
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
			// lbl_MLine
			// 
			this.lbl_MLine.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_MLine.ImageIndex = 0;
			this.lbl_MLine.ImageList = this.img_Label;
			this.lbl_MLine.Location = new System.Drawing.Point(40, 133);
			this.lbl_MLine.Name = "lbl_MLine";
			this.lbl_MLine.Size = new System.Drawing.Size(100, 21);
			this.lbl_MLine.TabIndex = 67;
			this.lbl_MLine.Text = "MiniLine";
			this.lbl_MLine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_LineCd
			// 
			this.lbl_LineCd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_LineCd.ImageIndex = 0;
			this.lbl_LineCd.ImageList = this.img_Label;
			this.lbl_LineCd.Location = new System.Drawing.Point(40, 77);
			this.lbl_LineCd.Name = "lbl_LineCd";
			this.lbl_LineCd.Size = new System.Drawing.Size(100, 21);
			this.lbl_LineCd.TabIndex = 66;
			this.lbl_LineCd.Text = "Line";
			this.lbl_LineCd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(241, 208);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 65;
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
			this.btn_Cancel.Location = new System.Drawing.Point(312, 208);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 64;
			this.btn_Cancel.Text = "Close";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// lb_MLineGroup
			// 
			this.lb_MLineGroup.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_MLineGroup.ImageIndex = 0;
			this.lb_MLineGroup.ImageList = this.img_Label;
			this.lb_MLineGroup.Location = new System.Drawing.Point(40, 175);
			this.lb_MLineGroup.Name = "lb_MLineGroup";
			this.lb_MLineGroup.Size = new System.Drawing.Size(100, 21);
			this.lb_MLineGroup.TabIndex = 71;
			this.lb_MLineGroup.Text = "Group ID";
			this.lb_MLineGroup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.txt_LineCd.TabIndex = 189;
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
			this.txt_LineName.TabIndex = 190;
			this.txt_LineName.Text = "";
			// 
			// txt_MLineGroup
			// 
			this.txt_MLineGroup.BackColor = System.Drawing.SystemColors.Window;
			this.txt_MLineGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MLineGroup.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MLineGroup.Location = new System.Drawing.Point(141, 175);
			this.txt_MLineGroup.MaxLength = 60;
			this.txt_MLineGroup.Name = "txt_MLineGroup";
			this.txt_MLineGroup.Size = new System.Drawing.Size(210, 21);
			this.txt_MLineGroup.TabIndex = 193;
			this.txt_MLineGroup.Text = "";
			// 
			// txt_MLineCd
			// 
			this.txt_MLineCd.BackColor = System.Drawing.SystemColors.Window;
			this.txt_MLineCd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_MLineCd.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_MLineCd.Location = new System.Drawing.Point(141, 133);
			this.txt_MLineCd.MaxLength = 60;
			this.txt_MLineCd.Name = "txt_MLineCd";
			this.txt_MLineCd.Size = new System.Drawing.Size(210, 21);
			this.txt_MLineCd.TabIndex = 191;
			this.txt_MLineCd.Text = "";
			// 
			// img_MiniButton
			// 
			this.img_MiniButton.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_MiniButton.ImageSize = new System.Drawing.Size(21, 21);
			this.img_MiniButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_MiniButton.ImageStream")));
			this.img_MiniButton.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_CreateGroup
			// 
			this.btn_CreateGroup.ImageIndex = 0;
			this.btn_CreateGroup.ImageList = this.img_MiniButton;
			this.btn_CreateGroup.Location = new System.Drawing.Point(352, 175);
			this.btn_CreateGroup.Name = "btn_CreateGroup";
			this.btn_CreateGroup.Size = new System.Drawing.Size(21, 21);
			this.btn_CreateGroup.TabIndex = 194;
			this.btn_CreateGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_CreateGroup.Click += new System.EventHandler(this.btn_CreateGroup_Click);
			this.btn_CreateGroup.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
			this.btn_CreateGroup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(141, 154);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 21);
			this.label1.TabIndex = 195;
			this.label1.Text = "FORMAT : G00";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(141, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 21);
			this.label2.TabIndex = 196;
			this.label2.Text = "FORMAT : UPS#01/UPS#02/.../";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_CreateMiniLineGroup
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 240);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_CreateGroup);
			this.Controls.Add(this.txt_MLineGroup);
			this.Controls.Add(this.txt_MLineCd);
			this.Controls.Add(this.txt_LineName);
			this.Controls.Add(this.txt_LineCd);
			this.Controls.Add(this.txt_FactoryName);
			this.Controls.Add(this.txt_Factory);
			this.Controls.Add(this.lb_MLineGroup);
			this.Controls.Add(this.lbl_Factory);
			this.Controls.Add(this.lbl_MLine);
			this.Controls.Add(this.lbl_LineCd);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_CreateMiniLineGroup";
			this.Text = "Create MiniLine Group";
			this.Load += new System.EventHandler(this.Pop_CreateMiniLineGroup_Load);
			this.Activated += new System.EventHandler(this.Pop_CreateMiniLineGroup_Activated);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.lbl_LineCd, 0);
			this.Controls.SetChildIndex(this.lbl_MLine, 0);
			this.Controls.SetChildIndex(this.lbl_Factory, 0);
			this.Controls.SetChildIndex(this.lb_MLineGroup, 0);
			this.Controls.SetChildIndex(this.txt_Factory, 0);
			this.Controls.SetChildIndex(this.txt_FactoryName, 0);
			this.Controls.SetChildIndex(this.txt_LineCd, 0);
			this.Controls.SetChildIndex(this.txt_LineName, 0);
			this.Controls.SetChildIndex(this.txt_MLineCd, 0);
			this.Controls.SetChildIndex(this.txt_MLineGroup, 0);
			this.Controls.SetChildIndex(this.btn_CreateGroup, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.ResumeLayout(false);

		}
		#endregion


		#region 변수 정의
 
		
		private COM.OraDB MyOraDB = new COM.OraDB(); 

		//폼 닫힐때 일어난 이벤트 (save : true, cancel : false)
		public bool _CloseSave;
 
 

		#endregion 

		#region 멤버 메서드
 
		
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
 		 
			 
			this.Text = "Create MiniLine Group";
			this.lbl_MainTitle.Text = "Create MiniLine Group"; 
 
			ClassLib.ComFunction.SetLangDic(this);

	


 			txt_Factory.Text =  ClassLib.ComVar.Parameter_PopUp[0]; 
 			txt_FactoryName.Text = ClassLib.ComVar.Parameter_PopUp[1]; 
			txt_LineCd.Text =  ClassLib.ComVar.Parameter_PopUp[2]; 
			txt_LineName.Text = ClassLib.ComVar.Parameter_PopUp[3];
			txt_MLineCd.Text = ClassLib.ComVar.Parameter_PopUp[4];
			
			 

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

		 

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			 
 			COM.ComVar.Parameter_PopUp = new string[] {txt_MLineGroup.Text};
			 
			_CloseSave = true;
			Close_Form();

		}
 
 

		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
			 
			_CloseSave = false;
			Close_Form();
		} 
 
   
		private void btn_CreateGroup_Click(object sender, System.EventArgs e)
		{
			string groupid = "";

			groupid = Get_Next_GroupID();

			txt_MLineGroup.Text = groupid;

 
		}



		#endregion 

		#region DB Connect

		  

		/// <summary>
		/// Get_Next_GroupID : 순차적으로 그룹 아이디 
		/// </summary>
		/// <returns></returns>
		private string Get_Next_GroupID()
		{
			DataSet ds_ret;
			string process_name = "PKG_SPB_LINE.GET_NEXT_GROUPID";

			MyOraDB.ReDim_Parameter(3); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;
 
			//02.ARGURMENT명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY"; 
			MyOraDB.Parameter_Name[1] = "ARG_LINE_CD";
			MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar; 
			MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;
			 
			//04.DATA 정의  
			MyOraDB.Parameter_Values[0] = txt_Factory.Text; 
			MyOraDB.Parameter_Values[1] = txt_LineCd.Text; 
			MyOraDB.Parameter_Values[2] = ""; 

			MyOraDB.Add_Select_Parameter(true); 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name].Rows[0].ItemArray[0].ToString(); 
		}



		#endregion


		private void Pop_CreateMiniLineGroup_Activated(object sender, System.EventArgs e)
		{
			txt_MLineGroup.Focus();
		}


		private void Pop_CreateMiniLineGroup_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}



	

		


	}
}

