using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;


namespace ERP.ErpCom
{
	public class Pop_SetMajorCd : COM.APSWinForm.Pop_Small
	{

		#region 컨트롤 정의 및 리소스 정리 

		private System.Windows.Forms.CheckBox chk_SystemYN;
		private System.Windows.Forms.TextBox txt_Value3;
		private System.Windows.Forms.TextBox txt_Remarks;
		private System.Windows.Forms.TextBox txt_Desc4;
		private System.Windows.Forms.TextBox txt_Value4;
		private System.Windows.Forms.TextBox txt_Desc3;
		private System.Windows.Forms.TextBox txt_Desc2;
		private System.Windows.Forms.TextBox txt_Value2;
		private System.Windows.Forms.TextBox txt_Desc1;
		private System.Windows.Forms.TextBox txt_Value1;
		private System.Windows.Forms.TextBox txt_Name;
		private System.Windows.Forms.TextBox txt_Code;
		private System.Windows.Forms.Label btn_Save;
		private System.Windows.Forms.Label btn_Delete;
		private System.Windows.Forms.Label btn_Cancel;
		private System.Windows.Forms.Label lbl_Code;
		private System.Windows.Forms.Label lbl_Name;
		private System.Windows.Forms.Label lbl_Remarks;
		private System.Windows.Forms.Label lbl_Desc4;
		private System.Windows.Forms.Label lbl_Value4;
		private System.Windows.Forms.Label lbl_Desc3;
		private System.Windows.Forms.Label lbl_Value3;
		private System.Windows.Forms.Label lbl_Desc2;
		private System.Windows.Forms.Label lbl_Value2;
		private System.Windows.Forms.Label lbl_Desc1;
		private System.Windows.Forms.Label lbl_Value1;
		private System.Windows.Forms.Label lbl_SystemYN;
		private System.ComponentModel.IContainer components = null;

		public Pop_SetMajorCd()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_SetMajorCd));
			this.chk_SystemYN = new System.Windows.Forms.CheckBox();
			this.txt_Value3 = new System.Windows.Forms.TextBox();
			this.txt_Remarks = new System.Windows.Forms.TextBox();
			this.txt_Desc4 = new System.Windows.Forms.TextBox();
			this.txt_Value4 = new System.Windows.Forms.TextBox();
			this.txt_Desc3 = new System.Windows.Forms.TextBox();
			this.txt_Desc2 = new System.Windows.Forms.TextBox();
			this.txt_Value2 = new System.Windows.Forms.TextBox();
			this.txt_Desc1 = new System.Windows.Forms.TextBox();
			this.txt_Value1 = new System.Windows.Forms.TextBox();
			this.txt_Name = new System.Windows.Forms.TextBox();
			this.txt_Code = new System.Windows.Forms.TextBox();
			this.lbl_Remarks = new System.Windows.Forms.Label();
			this.lbl_Desc4 = new System.Windows.Forms.Label();
			this.lbl_Value4 = new System.Windows.Forms.Label();
			this.lbl_Desc3 = new System.Windows.Forms.Label();
			this.lbl_Value3 = new System.Windows.Forms.Label();
			this.lbl_Desc2 = new System.Windows.Forms.Label();
			this.lbl_Value2 = new System.Windows.Forms.Label();
			this.lbl_Desc1 = new System.Windows.Forms.Label();
			this.lbl_Value1 = new System.Windows.Forms.Label();
			this.lbl_SystemYN = new System.Windows.Forms.Label();
			this.lbl_Code = new System.Windows.Forms.Label();
			this.lbl_Name = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Label();
			this.btn_Cancel = new System.Windows.Forms.Label();
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
			// chk_SystemYN
			// 
			this.chk_SystemYN.BackColor = System.Drawing.Color.Transparent;
			this.chk_SystemYN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.chk_SystemYN.Location = new System.Drawing.Point(141, 99);
			this.chk_SystemYN.Name = "chk_SystemYN";
			this.chk_SystemYN.Size = new System.Drawing.Size(16, 21);
			this.chk_SystemYN.TabIndex = 115;
			// 
			// txt_Value3
			// 
			this.txt_Value3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value3.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value3.Location = new System.Drawing.Point(141, 219);
			this.txt_Value3.MaxLength = 20;
			this.txt_Value3.Name = "txt_Value3";
			this.txt_Value3.Size = new System.Drawing.Size(210, 21);
			this.txt_Value3.TabIndex = 114;
			this.txt_Value3.Text = "";
			// 
			// txt_Remarks
			// 
			this.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Remarks.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Remarks.Location = new System.Drawing.Point(141, 307);
			this.txt_Remarks.MaxLength = 100;
			this.txt_Remarks.Name = "txt_Remarks";
			this.txt_Remarks.Size = new System.Drawing.Size(210, 21);
			this.txt_Remarks.TabIndex = 113;
			this.txt_Remarks.Text = "";
			// 
			// txt_Desc4
			// 
			this.txt_Desc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc4.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc4.Location = new System.Drawing.Point(141, 285);
			this.txt_Desc4.MaxLength = 50;
			this.txt_Desc4.Name = "txt_Desc4";
			this.txt_Desc4.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc4.TabIndex = 112;
			this.txt_Desc4.Text = "";
			// 
			// txt_Value4
			// 
			this.txt_Value4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value4.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value4.Location = new System.Drawing.Point(141, 263);
			this.txt_Value4.MaxLength = 20;
			this.txt_Value4.Name = "txt_Value4";
			this.txt_Value4.Size = new System.Drawing.Size(210, 21);
			this.txt_Value4.TabIndex = 111;
			this.txt_Value4.Text = "";
			// 
			// txt_Desc3
			// 
			this.txt_Desc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc3.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc3.Location = new System.Drawing.Point(141, 241);
			this.txt_Desc3.MaxLength = 50;
			this.txt_Desc3.Name = "txt_Desc3";
			this.txt_Desc3.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc3.TabIndex = 110;
			this.txt_Desc3.Text = "";
			// 
			// txt_Desc2
			// 
			this.txt_Desc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc2.Location = new System.Drawing.Point(141, 197);
			this.txt_Desc2.MaxLength = 50;
			this.txt_Desc2.Name = "txt_Desc2";
			this.txt_Desc2.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc2.TabIndex = 109;
			this.txt_Desc2.Text = "";
			// 
			// txt_Value2
			// 
			this.txt_Value2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value2.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value2.Location = new System.Drawing.Point(141, 175);
			this.txt_Value2.MaxLength = 20;
			this.txt_Value2.Name = "txt_Value2";
			this.txt_Value2.Size = new System.Drawing.Size(210, 21);
			this.txt_Value2.TabIndex = 108;
			this.txt_Value2.Text = "";
			// 
			// txt_Desc1
			// 
			this.txt_Desc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Desc1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Desc1.Location = new System.Drawing.Point(141, 153);
			this.txt_Desc1.MaxLength = 50;
			this.txt_Desc1.Name = "txt_Desc1";
			this.txt_Desc1.Size = new System.Drawing.Size(210, 21);
			this.txt_Desc1.TabIndex = 107;
			this.txt_Desc1.Text = "";
			// 
			// txt_Value1
			// 
			this.txt_Value1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Value1.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Value1.Location = new System.Drawing.Point(141, 131);
			this.txt_Value1.MaxLength = 20;
			this.txt_Value1.Name = "txt_Value1";
			this.txt_Value1.Size = new System.Drawing.Size(210, 21);
			this.txt_Value1.TabIndex = 106;
			this.txt_Value1.Text = "";
			// 
			// txt_Name
			// 
			this.txt_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Name.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Name.Location = new System.Drawing.Point(141, 77);
			this.txt_Name.MaxLength = 60;
			this.txt_Name.Name = "txt_Name";
			this.txt_Name.Size = new System.Drawing.Size(210, 21);
			this.txt_Name.TabIndex = 95;
			this.txt_Name.Text = "";
			// 
			// txt_Code
			// 
			this.txt_Code.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Code.Font = new System.Drawing.Font("Verdana", 8.5F);
			this.txt_Code.Location = new System.Drawing.Point(141, 55);
			this.txt_Code.MaxLength = 10;
			this.txt_Code.Name = "txt_Code";
			this.txt_Code.Size = new System.Drawing.Size(210, 21);
			this.txt_Code.TabIndex = 94;
			this.txt_Code.Text = "";
			// 
			// lbl_Remarks
			// 
			this.lbl_Remarks.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Remarks.ImageIndex = 0;
			this.lbl_Remarks.ImageList = this.img_Label;
			this.lbl_Remarks.Location = new System.Drawing.Point(40, 307);
			this.lbl_Remarks.Name = "lbl_Remarks";
			this.lbl_Remarks.Size = new System.Drawing.Size(100, 21);
			this.lbl_Remarks.TabIndex = 105;
			this.lbl_Remarks.Text = "비고";
			this.lbl_Remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc4
			// 
			this.lbl_Desc4.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc4.ImageIndex = 0;
			this.lbl_Desc4.ImageList = this.img_Label;
			this.lbl_Desc4.Location = new System.Drawing.Point(40, 285);
			this.lbl_Desc4.Name = "lbl_Desc4";
			this.lbl_Desc4.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc4.TabIndex = 104;
			this.lbl_Desc4.Text = "코드 설명4";
			this.lbl_Desc4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Value4
			// 
			this.lbl_Value4.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value4.ImageIndex = 0;
			this.lbl_Value4.ImageList = this.img_Label;
			this.lbl_Value4.Location = new System.Drawing.Point(40, 263);
			this.lbl_Value4.Name = "lbl_Value4";
			this.lbl_Value4.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value4.TabIndex = 103;
			this.lbl_Value4.Text = "코드값4";
			this.lbl_Value4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc3
			// 
			this.lbl_Desc3.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc3.ImageIndex = 0;
			this.lbl_Desc3.ImageList = this.img_Label;
			this.lbl_Desc3.Location = new System.Drawing.Point(40, 241);
			this.lbl_Desc3.Name = "lbl_Desc3";
			this.lbl_Desc3.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc3.TabIndex = 102;
			this.lbl_Desc3.Text = "코드 설명3";
			this.lbl_Desc3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Value3
			// 
			this.lbl_Value3.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value3.ImageIndex = 0;
			this.lbl_Value3.ImageList = this.img_Label;
			this.lbl_Value3.Location = new System.Drawing.Point(40, 219);
			this.lbl_Value3.Name = "lbl_Value3";
			this.lbl_Value3.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value3.TabIndex = 101;
			this.lbl_Value3.Text = "코드값3";
			this.lbl_Value3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc2
			// 
			this.lbl_Desc2.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc2.ImageIndex = 0;
			this.lbl_Desc2.ImageList = this.img_Label;
			this.lbl_Desc2.Location = new System.Drawing.Point(40, 197);
			this.lbl_Desc2.Name = "lbl_Desc2";
			this.lbl_Desc2.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc2.TabIndex = 100;
			this.lbl_Desc2.Text = "코드 설명2";
			this.lbl_Desc2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Value2
			// 
			this.lbl_Value2.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value2.ImageIndex = 0;
			this.lbl_Value2.ImageList = this.img_Label;
			this.lbl_Value2.Location = new System.Drawing.Point(40, 175);
			this.lbl_Value2.Name = "lbl_Value2";
			this.lbl_Value2.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value2.TabIndex = 99;
			this.lbl_Value2.Text = "코드값2";
			this.lbl_Value2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Desc1
			// 
			this.lbl_Desc1.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Desc1.ImageIndex = 0;
			this.lbl_Desc1.ImageList = this.img_Label;
			this.lbl_Desc1.Location = new System.Drawing.Point(40, 153);
			this.lbl_Desc1.Name = "lbl_Desc1";
			this.lbl_Desc1.Size = new System.Drawing.Size(100, 21);
			this.lbl_Desc1.TabIndex = 98;
			this.lbl_Desc1.Text = "코드 설명1";
			this.lbl_Desc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Value1
			// 
			this.lbl_Value1.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Value1.ImageIndex = 0;
			this.lbl_Value1.ImageList = this.img_Label;
			this.lbl_Value1.Location = new System.Drawing.Point(40, 131);
			this.lbl_Value1.Name = "lbl_Value1";
			this.lbl_Value1.Size = new System.Drawing.Size(100, 21);
			this.lbl_Value1.TabIndex = 97;
			this.lbl_Value1.Text = "코드값1";
			this.lbl_Value1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_SystemYN
			// 
			this.lbl_SystemYN.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_SystemYN.ImageIndex = 1;
			this.lbl_SystemYN.ImageList = this.img_Label;
			this.lbl_SystemYN.Location = new System.Drawing.Point(40, 99);
			this.lbl_SystemYN.Name = "lbl_SystemYN";
			this.lbl_SystemYN.Size = new System.Drawing.Size(100, 21);
			this.lbl_SystemYN.TabIndex = 96;
			this.lbl_SystemYN.Text = "시스템 코드";
			this.lbl_SystemYN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Code
			// 
			this.lbl_Code.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Code.ImageIndex = 1;
			this.lbl_Code.ImageList = this.img_Label;
			this.lbl_Code.Location = new System.Drawing.Point(40, 55);
			this.lbl_Code.Name = "lbl_Code";
			this.lbl_Code.Size = new System.Drawing.Size(100, 21);
			this.lbl_Code.TabIndex = 93;
			this.lbl_Code.Text = "코드 아이디";
			this.lbl_Code.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Name
			// 
			this.lbl_Name.Font = new System.Drawing.Font("Verdana", 9F);
			this.lbl_Name.ImageIndex = 1;
			this.lbl_Name.ImageList = this.img_Label;
			this.lbl_Name.Location = new System.Drawing.Point(40, 77);
			this.lbl_Name.Name = "lbl_Name";
			this.lbl_Name.Size = new System.Drawing.Size(100, 21);
			this.lbl_Name.TabIndex = 92;
			this.lbl_Name.Text = "코드 이름";
			this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Save
			// 
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 0;
			this.btn_Save.ImageList = this.img_Button;
			this.btn_Save.Location = new System.Drawing.Point(170, 344);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(70, 23);
			this.btn_Save.TabIndex = 91;
			this.btn_Save.Text = "Apply";
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			this.btn_Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseUp);
			this.btn_Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Save_MouseDown);
			// 
			// btn_Delete
			// 
			this.btn_Delete.ImageIndex = 0;
			this.btn_Delete.ImageList = this.img_Button;
			this.btn_Delete.Location = new System.Drawing.Point(241, 344);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.Size = new System.Drawing.Size(70, 23);
			this.btn_Delete.TabIndex = 90;
			this.btn_Delete.Text = "Delete";
			this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
			this.btn_Delete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseUp);
			this.btn_Delete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Delete_MouseDown);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.ImageIndex = 0;
			this.btn_Cancel.ImageList = this.img_Button;
			this.btn_Cancel.Location = new System.Drawing.Point(312, 344);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(70, 23);
			this.btn_Cancel.TabIndex = 89;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			this.btn_Cancel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseUp);
			this.btn_Cancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Cancel_MouseDown);
			// 
			// Pop_SetMajorCd
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 378);
			this.Controls.Add(this.chk_SystemYN);
			this.Controls.Add(this.txt_Value3);
			this.Controls.Add(this.txt_Remarks);
			this.Controls.Add(this.txt_Desc4);
			this.Controls.Add(this.txt_Value4);
			this.Controls.Add(this.txt_Desc3);
			this.Controls.Add(this.txt_Desc2);
			this.Controls.Add(this.txt_Value2);
			this.Controls.Add(this.txt_Desc1);
			this.Controls.Add(this.txt_Value1);
			this.Controls.Add(this.txt_Name);
			this.Controls.Add(this.txt_Code);
			this.Controls.Add(this.lbl_Remarks);
			this.Controls.Add(this.lbl_Desc4);
			this.Controls.Add(this.lbl_Value4);
			this.Controls.Add(this.lbl_Desc3);
			this.Controls.Add(this.lbl_Value3);
			this.Controls.Add(this.lbl_Desc2);
			this.Controls.Add(this.lbl_Value2);
			this.Controls.Add(this.lbl_Desc1);
			this.Controls.Add(this.lbl_Value1);
			this.Controls.Add(this.lbl_SystemYN);
			this.Controls.Add(this.lbl_Code);
			this.Controls.Add(this.lbl_Name);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.btn_Delete);
			this.Controls.Add(this.btn_Cancel);
			this.Name = "Pop_SetMajorCd";
			this.Text = "Set Common Code";
			this.Load += new System.EventHandler(this.Pop_SetMajorCd_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.btn_Cancel, 0);
			this.Controls.SetChildIndex(this.btn_Delete, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.lbl_Name, 0);
			this.Controls.SetChildIndex(this.lbl_Code, 0);
			this.Controls.SetChildIndex(this.lbl_SystemYN, 0);
			this.Controls.SetChildIndex(this.lbl_Value1, 0);
			this.Controls.SetChildIndex(this.lbl_Desc1, 0);
			this.Controls.SetChildIndex(this.lbl_Value2, 0);
			this.Controls.SetChildIndex(this.lbl_Desc2, 0);
			this.Controls.SetChildIndex(this.lbl_Value3, 0);
			this.Controls.SetChildIndex(this.lbl_Desc3, 0);
			this.Controls.SetChildIndex(this.lbl_Value4, 0);
			this.Controls.SetChildIndex(this.lbl_Desc4, 0);
			this.Controls.SetChildIndex(this.lbl_Remarks, 0);
			this.Controls.SetChildIndex(this.txt_Code, 0);
			this.Controls.SetChildIndex(this.txt_Name, 0);
			this.Controls.SetChildIndex(this.txt_Value1, 0);
			this.Controls.SetChildIndex(this.txt_Desc1, 0);
			this.Controls.SetChildIndex(this.txt_Value2, 0);
			this.Controls.SetChildIndex(this.txt_Desc2, 0);
			this.Controls.SetChildIndex(this.txt_Desc3, 0);
			this.Controls.SetChildIndex(this.txt_Value4, 0);
			this.Controls.SetChildIndex(this.txt_Desc4, 0);
			this.Controls.SetChildIndex(this.txt_Remarks, 0);
			this.Controls.SetChildIndex(this.txt_Value3, 0);
			this.Controls.SetChildIndex(this.chk_SystemYN, 0);
			this.ResumeLayout(false);

		}
		#endregion


		
		#region 변수 정의

		private COM.OraDB MyOraDB = new COM.OraDB();

		private string _Factory; 

		#endregion

		
		#region 멤버 메서드

 
		/// <summary>
		/// Inti_Form : Form Load 시 초기화 작업
		/// </summary>
		private void Init_Form()
		{
			//Title
			this.Text = "Set Common Code";
			this.lbl_MainTitle.Text = "Major Code Information";

			ClassLib.ComFunction.SetLangDic(this);



			_Factory = COM.ComVar.Parameter_PopUp[0];
			txt_Code.Text = COM.ComVar.Parameter_PopUp[1];
			txt_Name.Text = COM.ComVar.Parameter_PopUp[3];
			chk_SystemYN.Checked = Convert.ToBoolean((COM.ComVar.Parameter_PopUp[4] == "") ? "False" : COM.ComVar.Parameter_PopUp[4]);  
			txt_Value1.Text = COM.ComVar.Parameter_PopUp[5]; 
			txt_Desc1.Text = COM.ComVar.Parameter_PopUp[6]; 
			txt_Value2.Text = COM.ComVar.Parameter_PopUp[7]; 
			txt_Desc2.Text = COM.ComVar.Parameter_PopUp[8]; 
			txt_Value3.Text = COM.ComVar.Parameter_PopUp[9]; 
			txt_Desc3.Text = COM.ComVar.Parameter_PopUp[10]; 
			txt_Value4.Text = COM.ComVar.Parameter_PopUp[11]; 
			txt_Desc4.Text = COM.ComVar.Parameter_PopUp[12]; 
			txt_Remarks.Text = COM.ComVar.Parameter_PopUp[13];  
 
		}


		/// <summary>
		/// Close_Form : Form Close 시 작업
		/// </summary>
		private void Close_Form()
		{
			COM.ComVar.Parameter_PopUp = new string[] {txt_Code.Text, txt_Name.Text};
			this.Close();
		}


		/// <summary>
		/// Save_Code : 공통 코드 저장
		/// </summary>
		private void Save_Code()
		{
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(16); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_CODE.SAVE_CODE_LIST";
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_DIVISION";
			MyOraDB.Parameter_Name[1] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[2] = "ARG_COM_CD"; 
			MyOraDB.Parameter_Name[3] = "ARG_COM_SEQ"; 
			MyOraDB.Parameter_Name[4] = "ARG_COM_NAME"; 
			MyOraDB.Parameter_Name[5] = "ARG_SYSTEM_YN"; 
			MyOraDB.Parameter_Name[6] = "ARG_COM_VALUE1"; 
			MyOraDB.Parameter_Name[7] = "ARG_COM_DESC1"; 
			MyOraDB.Parameter_Name[8] = "ARG_COM_VALUE2"; 
			MyOraDB.Parameter_Name[9] = "ARG_COM_DESC2"; 
			MyOraDB.Parameter_Name[10] = "ARG_COM_VALUE3"; 
			MyOraDB.Parameter_Name[11] = "ARG_COM_DESC3"; 
			MyOraDB.Parameter_Name[12] = "ARG_COM_VALUE4"; 
			MyOraDB.Parameter_Name[13] = "ARG_COM_DESC4"; 
			MyOraDB.Parameter_Name[14] = "ARG_REMARKS"; 
			MyOraDB.Parameter_Name[15] = "ARG_UPD_USER"; 


			//03.DATA TYPE
			for (int i = 0; i <= 15; i++)
			{
				MyOraDB.Parameter_Type[i] = (int)OracleType.VarChar;
			}			

			
			//04.DATA 정의 

			if (COM.ComVar.Parameter_PopUp[1] == "" || COM.ComVar.Parameter_PopUp[1] != txt_Code.Text)    //초기 코드 없는 경우 (신규일때)
			{
				MyOraDB.Parameter_Values[0] = "I";
			}
			else
			{
				MyOraDB.Parameter_Values[0] = "U";
			} 
			 
			MyOraDB.Parameter_Values[1] = _Factory; 
			MyOraDB.Parameter_Values[2] = txt_Code.Text;
			MyOraDB.Parameter_Values[3] = "0"; 
			MyOraDB.Parameter_Values[4] = txt_Name.Text; 
			MyOraDB.Parameter_Values[5] = (chk_SystemYN.Checked) ? "Y" : "N"; 
			MyOraDB.Parameter_Values[6] = txt_Value1.Text; 
			MyOraDB.Parameter_Values[7] = txt_Desc1.Text; 
			MyOraDB.Parameter_Values[8] = txt_Value2.Text; 
			MyOraDB.Parameter_Values[9] = txt_Desc2.Text; 
			MyOraDB.Parameter_Values[10] = txt_Value3.Text; 
			MyOraDB.Parameter_Values[11] = txt_Desc3.Text; 
			MyOraDB.Parameter_Values[12] = txt_Value4.Text; 
			MyOraDB.Parameter_Values[13] = txt_Desc4.Text; 
			MyOraDB.Parameter_Values[14] = txt_Remarks.Text; 
			MyOraDB.Parameter_Values[15] = COM.ComVar.This_User; 

    		MyOraDB.Add_Modify_Parameter(true); 

			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
			//Error 처리
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}
			 

		}



		/// <summary>
		/// Delete_Code : 공통코드 삭제 (이하 리스트 모두 삭제)
		/// </summary>
		private void Delete_Code()
		{
			 
			DataSet ds_ret;

			MyOraDB.ReDim_Parameter(2); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SCM_CODE.DELETE_CODE";
 
			//02.ARGURMENT명 
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_COM_CD"; 

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			
			//04.DATA 정의 
			MyOraDB.Parameter_Values[0] = _Factory; 
			MyOraDB.Parameter_Values[1] = txt_Code.Text; 

			MyOraDB.Add_Modify_Parameter(true); 

			ds_ret =  MyOraDB.Exe_Modify_Procedure();			// Modify Procedure 실행		

			
			//Error 처리
			if(ds_ret == null) 
			{
				MessageBox.Show("Error") ;
				
			}


		}


		#endregion


		#region 이벤트 처리 
 

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
			Save_Code();
			Close_Form();
		}


		private void btn_Save_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 1;
		}

		private void btn_Save_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Save.ImageIndex = 0;
		}	


		private void btn_Delete_Click(object sender, System.EventArgs e)
		{
			Delete_Code();
			Close_Form();
		}


		private void btn_Delete_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 1;
		}

		private void btn_Delete_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			btn_Delete.ImageIndex = 0;
		}


		private void btn_Cancel_Click(object sender, System.EventArgs e)
		{
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

		#endregion




		private void Pop_SetMajorCd_Load(object sender, System.EventArgs e)
		{
			Init_Form(); 
		}

		 
		 


	}
}

