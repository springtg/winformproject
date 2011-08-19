using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;

namespace ERP.SysBase
{
	public class Pop_PS_Work_Info_View : COM.APSWinForm.Pop_Large
	{
		private System.Windows.Forms.Label lbl_title;
		private System.Windows.Forms.Label lbl_contents;
		private System.Windows.Forms.ImageList imgs_new_btn;
		private System.Windows.Forms.Label btn_delete;
		private System.ComponentModel.IContainer components = null;


		private COM.OraDB oraDB = null;
		private System.Windows.Forms.TextBox txt_title;
		private System.Windows.Forms.TextBox txt_contents;
		private string seq = "";

		public Pop_PS_Work_Info_View(string arg_seq)
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.

			seq = arg_seq;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_PS_Work_Info_View));
			this.lbl_title = new System.Windows.Forms.Label();
			this.txt_title = new System.Windows.Forms.TextBox();
			this.lbl_contents = new System.Windows.Forms.Label();
			this.txt_contents = new System.Windows.Forms.TextBox();
			this.imgs_new_btn = new System.Windows.Forms.ImageList(this.components);
			this.btn_delete = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// img_Button
			// 
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			// 
			// img_Label
			// 
			this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
			// 
			// lbl_MainTitle
			// 
			this.lbl_MainTitle.Name = "lbl_MainTitle";
			// 
			// lbl_title
			// 
			this.lbl_title.ImageIndex = 0;
			this.lbl_title.ImageList = this.img_Label;
			this.lbl_title.Location = new System.Drawing.Point(8, 64);
			this.lbl_title.Name = "lbl_title";
			this.lbl_title.Size = new System.Drawing.Size(100, 21);
			this.lbl_title.TabIndex = 101;
			this.lbl_title.Text = "Title";
			this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_title
			// 
			this.txt_title.BackColor = System.Drawing.Color.White;
			this.txt_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_title.Location = new System.Drawing.Point(109, 64);
			this.txt_title.Name = "txt_title";
			this.txt_title.ReadOnly = true;
			this.txt_title.Size = new System.Drawing.Size(579, 21);
			this.txt_title.TabIndex = 120;
			this.txt_title.Text = "";
			// 
			// lbl_contents
			// 
			this.lbl_contents.ImageIndex = 0;
			this.lbl_contents.ImageList = this.img_Label;
			this.lbl_contents.Location = new System.Drawing.Point(8, 86);
			this.lbl_contents.Name = "lbl_contents";
			this.lbl_contents.Size = new System.Drawing.Size(100, 21);
			this.lbl_contents.TabIndex = 110;
			this.lbl_contents.Text = "Contents";
			this.lbl_contents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_contents
			// 
			this.txt_contents.BackColor = System.Drawing.Color.White;
			this.txt_contents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_contents.Location = new System.Drawing.Point(109, 86);
			this.txt_contents.Multiline = true;
			this.txt_contents.Name = "txt_contents";
			this.txt_contents.ReadOnly = true;
			this.txt_contents.Size = new System.Drawing.Size(579, 218);
			this.txt_contents.TabIndex = 119;
			this.txt_contents.Text = "";
			// 
			// imgs_new_btn
			// 
			this.imgs_new_btn.ImageSize = new System.Drawing.Size(80, 23);
			this.imgs_new_btn.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs_new_btn.ImageStream")));
			this.imgs_new_btn.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_delete.ImageIndex = 6;
			this.btn_delete.ImageList = this.imgs_new_btn;
			this.btn_delete.Location = new System.Drawing.Point(608, 312);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(80, 23);
			this.btn_delete.TabIndex = 118;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// Pop_PS_Work_Info_View
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(694, 344);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.txt_contents);
			this.Controls.Add(this.lbl_contents);
			this.Controls.Add(this.txt_title);
			this.Controls.Add(this.lbl_title);
			this.Name = "Pop_PS_Work_Info_View";
			this.Load += new System.EventHandler(this.Pop_PS_Work_Info_View_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.lbl_title, 0);
			this.Controls.SetChildIndex(this.txt_title, 0);
			this.Controls.SetChildIndex(this.lbl_contents, 0);
			this.Controls.SetChildIndex(this.txt_contents, 0);
			this.Controls.SetChildIndex(this.btn_delete, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_PS_Work_Info_View_Load(object sender, System.EventArgs e)
		{
			init_Form();
		}

		private void init_Form()
		{
			this.Text = "Auto Work Info View";
			this.lbl_MainTitle.Text = "Auto Work Info View";

			ClassLib.ComFunction.SetLangDic(this);

			oraDB = new COM.OraDB();
			View(seq);
		}

		private void View(string arg_seq)
		{
			DataTable dt = View_Auto_Work(arg_seq);

			string seq = dt.Rows[0].ItemArray[0].ToString();
			string title = dt.Rows[0].ItemArray[1].ToString();
			string contents = dt.Rows[0].ItemArray[1].ToString();


			
			txt_title.Text = title;
			txt_contents.Text = contents;
		}


		private DataTable View_Auto_Work(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.VIEW_WORKINFO_USER";

			oraDB.ReDim_Parameter(5);
			oraDB.Process_Name = Proc_Name; 

			oraDB.Parameter_Name[0] = "ARG_COMMON";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_SEQ";
			oraDB.Parameter_Name[4] = "OUT_CURSOR"; 
			
			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[4] = (int)OracleType.Cursor;

			oraDB.Parameter_Values[0] = "N";
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_seq;
			oraDB.Parameter_Values[4] = "";


			oraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = oraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return  DS_Ret.Tables[Proc_Name];
		}

		private void btn_delete_Click(object sender, System.EventArgs e)
		{
			DialogResult dr = ClassLib.ComFunction.Data_Message(ClassLib.ComVar.MgsChooseDelete);
			if(DialogResult.Yes == dr)
			{
				Delete_SPS_WorkInfo_List(seq);
				this.Close();
			}
		}


		private void Delete_SPS_WorkInfo_List(string arg_seq)
		{
			string Proc_Name = "PKG_SPS_HOME.DELETE_WORKINFO_USER";

			oraDB.ReDim_Parameter(4);
			oraDB.Process_Name = Proc_Name ;


			oraDB.Parameter_Name[0] = "ARG_COMMON";
			oraDB.Parameter_Name[1] = "ARG_FACTORY";
			oraDB.Parameter_Name[2] = "ARG_USER_ID";
			oraDB.Parameter_Name[3] = "ARG_SEQ";

			oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			oraDB.Parameter_Type[3] = (int)OracleType.VarChar;

			oraDB.Parameter_Values[0] = "N";
			oraDB.Parameter_Values[1] = ClassLib.ComVar.This_Factory;
			oraDB.Parameter_Values[2] = ClassLib.ComVar.This_User;
			oraDB.Parameter_Values[3] = arg_seq;

			oraDB.Add_Modify_Parameter(true);
			oraDB.Exe_Modify_Procedure();
		}
	}
}

