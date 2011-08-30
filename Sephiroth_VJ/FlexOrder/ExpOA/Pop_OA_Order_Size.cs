using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using C1.Win.C1FlexGrid;
using System.Data.OracleClient;
using System.IO;


namespace FlexOrder.ExpOA
{
	public class Pop_OA_Order_Size : COM.OrderWinForm.Pop_Large
	{
		#region 컨트롤정의 및 리소스정의
		private System.Windows.Forms.Panel pnl_OA_Info;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label lbl_OBS_Type;
		private System.Windows.Forms.Label lbl_St;
		private System.Windows.Forms.Label lbl_Factory;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.Label lbl_OA_Title;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.PictureBox pictureBox28;
		private System.Windows.Forms.PictureBox pictureBox29;
		private System.Windows.Forms.PictureBox pictureBox30;
		private System.Windows.Forms.PictureBox pictureBox31;
		private System.Windows.Forms.PictureBox pictureBox32;
		private System.Windows.Forms.Panel pnl_Body;
		public COM.FSP fgrid_Size;
		private System.Windows.Forms.TextBox txt_Factory;
		private System.Windows.Forms.TextBox txt_Obs_Type;
		private System.Windows.Forms.TextBox txt_Style_Cd;
		private System.Windows.Forms.TextBox txt_Obs_Id;
		private System.Windows.Forms.Label lbl_OBS_ID;
		private System.ComponentModel.IContainer components = null;

		public Pop_OA_Order_Size()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_OA_Order_Size));
			this.pnl_OA_Info = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lbl_OBS_Type = new System.Windows.Forms.Label();
			this.lbl_St = new System.Windows.Forms.Label();
			this.lbl_Factory = new System.Windows.Forms.Label();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.lbl_OA_Title = new System.Windows.Forms.Label();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox28 = new System.Windows.Forms.PictureBox();
			this.pictureBox29 = new System.Windows.Forms.PictureBox();
			this.pictureBox30 = new System.Windows.Forms.PictureBox();
			this.pictureBox31 = new System.Windows.Forms.PictureBox();
			this.pictureBox32 = new System.Windows.Forms.PictureBox();
			this.txt_Factory = new System.Windows.Forms.TextBox();
			this.txt_Obs_Type = new System.Windows.Forms.TextBox();
			this.txt_Style_Cd = new System.Windows.Forms.TextBox();
			this.pnl_Body = new System.Windows.Forms.Panel();
			this.fgrid_Size = new COM.FSP();
			this.txt_Obs_Id = new System.Windows.Forms.TextBox();
			this.lbl_OBS_ID = new System.Windows.Forms.Label();
			this.pnl_OA_Info.SuspendLayout();
			this.panel7.SuspendLayout();
			this.pnl_Body.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).BeginInit();
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
			// pnl_OA_Info
			// 
			this.pnl_OA_Info.Controls.Add(this.panel7);
			this.pnl_OA_Info.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_OA_Info.DockPadding.Right = 4;
			this.pnl_OA_Info.Location = new System.Drawing.Point(8, 8);
			this.pnl_OA_Info.Name = "pnl_OA_Info";
			this.pnl_OA_Info.Size = new System.Drawing.Size(682, 80);
			this.pnl_OA_Info.TabIndex = 129;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.RosyBrown;
			this.panel7.Controls.Add(this.txt_Obs_Id);
			this.panel7.Controls.Add(this.lbl_OBS_ID);
			this.panel7.Controls.Add(this.txt_Style_Cd);
			this.panel7.Controls.Add(this.txt_Obs_Type);
			this.panel7.Controls.Add(this.txt_Factory);
			this.panel7.Controls.Add(this.lbl_OBS_Type);
			this.panel7.Controls.Add(this.lbl_St);
			this.panel7.Controls.Add(this.lbl_Factory);
			this.panel7.Controls.Add(this.pictureBox25);
			this.panel7.Controls.Add(this.pictureBox26);
			this.panel7.Controls.Add(this.lbl_OA_Title);
			this.panel7.Controls.Add(this.pictureBox27);
			this.panel7.Controls.Add(this.pictureBox28);
			this.panel7.Controls.Add(this.pictureBox29);
			this.panel7.Controls.Add(this.pictureBox30);
			this.panel7.Controls.Add(this.pictureBox31);
			this.panel7.Controls.Add(this.pictureBox32);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(678, 80);
			this.panel7.TabIndex = 1;
			// 
			// lbl_OBS_Type
			// 
			this.lbl_OBS_Type.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_Type.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_Type.ImageIndex = 2;
			this.lbl_OBS_Type.ImageList = this.img_Label;
			this.lbl_OBS_Type.Location = new System.Drawing.Point(352, 32);
			this.lbl_OBS_Type.Name = "lbl_OBS_Type";
			this.lbl_OBS_Type.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_Type.TabIndex = 203;
			this.lbl_OBS_Type.Text = "OBS Type";
			this.lbl_OBS_Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_St
			// 
			this.lbl_St.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_St.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_St.ImageIndex = 2;
			this.lbl_St.ImageList = this.img_Label;
			this.lbl_St.Location = new System.Drawing.Point(352, 54);
			this.lbl_St.Name = "lbl_St";
			this.lbl_St.Size = new System.Drawing.Size(100, 21);
			this.lbl_St.TabIndex = 200;
			this.lbl_St.Text = "Style Cd";
			this.lbl_St.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Factory
			// 
			this.lbl_Factory.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_Factory.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_Factory.ImageIndex = 2;
			this.lbl_Factory.ImageList = this.img_Label;
			this.lbl_Factory.Location = new System.Drawing.Point(16, 32);
			this.lbl_Factory.Name = "lbl_Factory";
			this.lbl_Factory.Size = new System.Drawing.Size(100, 21);
			this.lbl_Factory.TabIndex = 115;
			this.lbl_Factory.Text = "Factory";
			this.lbl_Factory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox25
			// 
			this.pictureBox25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox25.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox25.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(168, -1);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(494, 32);
			this.pictureBox25.TabIndex = 2;
			this.pictureBox25.TabStop = false;
			// 
			// pictureBox26
			// 
			this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox26.BackColor = System.Drawing.SystemColors.Highlight;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(656, 0);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(22, 32);
			this.pictureBox26.TabIndex = 1;
			this.pictureBox26.TabStop = false;
			// 
			// lbl_OA_Title
			// 
			this.lbl_OA_Title.BackColor = System.Drawing.SystemColors.Highlight;
			this.lbl_OA_Title.Image = ((System.Drawing.Image)(resources.GetObject("lbl_OA_Title.Image")));
			this.lbl_OA_Title.Location = new System.Drawing.Point(0, 0);
			this.lbl_OA_Title.Name = "lbl_OA_Title";
			this.lbl_OA_Title.Size = new System.Drawing.Size(172, 32);
			this.lbl_OA_Title.TabIndex = 0;
			this.lbl_OA_Title.Text = "      Adjust Info.";
			this.lbl_OA_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox27
			// 
			this.pictureBox27.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox27.BackColor = System.Drawing.Color.MediumBlue;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(659, 32);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(19, 34);
			this.pictureBox27.TabIndex = 5;
			this.pictureBox27.TabStop = false;
			// 
			// pictureBox28
			// 
			this.pictureBox28.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox28.BackColor = System.Drawing.SystemColors.HotTrack;
			this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
			this.pictureBox28.Location = new System.Drawing.Point(0, 24);
			this.pictureBox28.Name = "pictureBox28";
			this.pictureBox28.Size = new System.Drawing.Size(32, 45);
			this.pictureBox28.TabIndex = 3;
			this.pictureBox28.TabStop = false;
			// 
			// pictureBox29
			// 
			this.pictureBox29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox29.BackColor = System.Drawing.Color.Blue;
			this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
			this.pictureBox29.Location = new System.Drawing.Point(588, 66);
			this.pictureBox29.Name = "pictureBox29";
			this.pictureBox29.Size = new System.Drawing.Size(90, 14);
			this.pictureBox29.TabIndex = 8;
			this.pictureBox29.TabStop = false;
			// 
			// pictureBox30
			// 
			this.pictureBox30.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox30.BackColor = System.Drawing.Color.Blue;
			this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
			this.pictureBox30.Location = new System.Drawing.Point(72, 66);
			this.pictureBox30.Name = "pictureBox30";
			this.pictureBox30.Size = new System.Drawing.Size(590, 14);
			this.pictureBox30.TabIndex = 9;
			this.pictureBox30.TabStop = false;
			// 
			// pictureBox31
			// 
			this.pictureBox31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox31.BackColor = System.Drawing.Color.Blue;
			this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
			this.pictureBox31.Location = new System.Drawing.Point(0, 66);
			this.pictureBox31.Name = "pictureBox31";
			this.pictureBox31.Size = new System.Drawing.Size(80, 14);
			this.pictureBox31.TabIndex = 6;
			this.pictureBox31.TabStop = false;
			// 
			// pictureBox32
			// 
			this.pictureBox32.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox32.BackColor = System.Drawing.Color.Navy;
			this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
			this.pictureBox32.Location = new System.Drawing.Point(32, 24);
			this.pictureBox32.Name = "pictureBox32";
			this.pictureBox32.Size = new System.Drawing.Size(630, 48);
			this.pictureBox32.TabIndex = 4;
			this.pictureBox32.TabStop = false;
			// 
			// txt_Factory
			// 
			this.txt_Factory.BackColor = System.Drawing.Color.White;
			this.txt_Factory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Factory.Enabled = false;
			this.txt_Factory.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Factory.Location = new System.Drawing.Point(117, 34);
			this.txt_Factory.MaxLength = 100;
			this.txt_Factory.Name = "txt_Factory";
			this.txt_Factory.Size = new System.Drawing.Size(210, 19);
			this.txt_Factory.TabIndex = 207;
			this.txt_Factory.Text = "";
			// 
			// txt_Obs_Type
			// 
			this.txt_Obs_Type.BackColor = System.Drawing.Color.White;
			this.txt_Obs_Type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Obs_Type.Enabled = false;
			this.txt_Obs_Type.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Obs_Type.Location = new System.Drawing.Point(454, 32);
			this.txt_Obs_Type.MaxLength = 100;
			this.txt_Obs_Type.Name = "txt_Obs_Type";
			this.txt_Obs_Type.Size = new System.Drawing.Size(210, 19);
			this.txt_Obs_Type.TabIndex = 208;
			this.txt_Obs_Type.Text = "";
			// 
			// txt_Style_Cd
			// 
			this.txt_Style_Cd.BackColor = System.Drawing.Color.White;
			this.txt_Style_Cd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Style_Cd.Enabled = false;
			this.txt_Style_Cd.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Style_Cd.Location = new System.Drawing.Point(454, 55);
			this.txt_Style_Cd.MaxLength = 100;
			this.txt_Style_Cd.Name = "txt_Style_Cd";
			this.txt_Style_Cd.Size = new System.Drawing.Size(210, 19);
			this.txt_Style_Cd.TabIndex = 209;
			this.txt_Style_Cd.Text = "";
			// 
			// pnl_Body
			// 
			this.pnl_Body.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_Body.Controls.Add(this.fgrid_Size);
			this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnl_Body.Location = new System.Drawing.Point(8, 96);
			this.pnl_Body.Name = "pnl_Body";
			this.pnl_Body.Size = new System.Drawing.Size(682, 64);
			this.pnl_Body.TabIndex = 130;
			// 
			// fgrid_Size
			// 
			this.fgrid_Size.AutoResize = false;
			this.fgrid_Size.BackColor = System.Drawing.Color.White;
			this.fgrid_Size.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_Size.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_Size.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Size.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.fgrid_Size.ForeColor = System.Drawing.Color.Black;
			this.fgrid_Size.KeyActionEnter = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
			this.fgrid_Size.Location = new System.Drawing.Point(0, 0);
			this.fgrid_Size.Name = "fgrid_Size";
			this.fgrid_Size.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.fgrid_Size.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_Size.Size = new System.Drawing.Size(682, 64);
			this.fgrid_Size.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 8.25pt;BackColor:White;ForeColor:Black;}	Alternate{BackColor:245, 248, 232;}	Fixed{BackColor:226, 245, 153;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:236, 247, 187;}	Focus{BackColor:236, 247, 187;Border:Flat,1,Black,Both;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Size.TabIndex = 131;
			// 
			// txt_Obs_Id
			// 
			this.txt_Obs_Id.BackColor = System.Drawing.Color.White;
			this.txt_Obs_Id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Obs_Id.Enabled = false;
			this.txt_Obs_Id.Font = new System.Drawing.Font("Verdana", 7F);
			this.txt_Obs_Id.Location = new System.Drawing.Point(117, 55);
			this.txt_Obs_Id.MaxLength = 100;
			this.txt_Obs_Id.Name = "txt_Obs_Id";
			this.txt_Obs_Id.Size = new System.Drawing.Size(210, 19);
			this.txt_Obs_Id.TabIndex = 208;
			this.txt_Obs_Id.Text = "";
			// 
			// lbl_OBS_ID
			// 
			this.lbl_OBS_ID.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_OBS_ID.Font = new System.Drawing.Font("Verdana", 8F);
			this.lbl_OBS_ID.ImageIndex = 2;
			this.lbl_OBS_ID.ImageList = this.img_Label;
			this.lbl_OBS_ID.Location = new System.Drawing.Point(16, 54);
			this.lbl_OBS_ID.Name = "lbl_OBS_ID";
			this.lbl_OBS_ID.Size = new System.Drawing.Size(100, 21);
			this.lbl_OBS_ID.TabIndex = 207;
			this.lbl_OBS_ID.Text = "OBS ID";
			this.lbl_OBS_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Pop_OA_Order_Size
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(698, 168);
			this.Controls.Add(this.pnl_Body);
			this.Controls.Add(this.pnl_OA_Info);
			this.DockPadding.All = 8;
			this.Name = "Pop_OA_Order_Size";
			this.Load += new System.EventHandler(this.Pop_OA_Order_Size_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_OA_Info, 0);
			this.Controls.SetChildIndex(this.pnl_Body, 0);
			this.pnl_OA_Info.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.pnl_Body.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Size)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region 사용자 정의 

		private ClassLib.OraDB  MyOraDB = new ClassLib.OraDB();


		#endregion 

		#region 공통 메쏘드

		

		private void  Init_Form()
		{

			//Setting  Title
			this.Text = "Size Info";
			this.lbl_MainTitle.Text = "Size Info";
			ClassLib.ComFunction.SetLangDic(this);

			txt_Factory.Text  = ClassLib.ComVar.Parameter_PopUp[0];
			txt_Obs_Type.Text  = ClassLib.ComVar.Parameter_PopUp[1];
			txt_Obs_Id.Text  = ClassLib.ComVar.Parameter_PopUp[2];			
			txt_Style_Cd.Text  = ClassLib.ComVar.Parameter_PopUp[3];


			Set_Obs_Size();


		}



		private void  Set_Obs_Size()
		{
           DataTable dt_list;

		   dt_list  = Select_Obs_Size();

		   if (dt_list.Rows.Count  == 0) return; 

		   Display_Size(dt_list );



		}

		private void  Display_Size(DataTable  arg_list)
		{
			try
			{

				
				this.Cursor = Cursors.WaitCursor;

				fgrid_Size.Rows.Count  = fgrid_Size.Rows.Fixed+1;

				fgrid_Size.Cols.Count   =  0;

				for (int i  = 0 ; i <= arg_list.Rows.Count -1   ; i++)
				{
					fgrid_Size.Cols.Count  ++;

					fgrid_Size[fgrid_Size.Rows.Count-2,fgrid_Size.Cols.Count-1] = arg_list.Rows[i].ItemArray[0].ToString();
					fgrid_Size[fgrid_Size.Rows.Count-1,fgrid_Size.Cols.Count-1] = arg_list.Rows[i].ItemArray[1].ToString();
 
					
				    fgrid_Size.Cols[fgrid_Size.Cols.Count-1].Width   = 70;

				}

				 fgrid_Size.Rows[fgrid_Size.Rows.Count-2].TextAlign = TextAlignEnum.CenterCenter ;
			}
			catch (Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Display_Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				this.Cursor = Cursors.Default; 

			}


		}





		#endregion 

		#region 이벤트 처리 


		#endregion 

		#region DB 컨넥트 
		private DataTable  Select_Obs_Size()
		{
			DataSet ds_ret;


			string process_name = "PKG_SEM_OA_CREATE.SELECT_SEM_OBS_POP_SIZE_LIST";


			MyOraDB.ReDim_Parameter(5); 

			//01.PROCEDURE명
			MyOraDB.Process_Name = process_name;

			MyOraDB.Parameter_Name[0]  = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1]  = "ARG_OBS_NU";
			MyOraDB.Parameter_Name[2]  = "ARG_OBS_SEQ_NU";
			MyOraDB.Parameter_Name[3]  = "ARG_CHG_NU";
			MyOraDB.Parameter_Name[4]  = "OUT_CURSOR";

			//03.DATA TYPE
			MyOraDB.Parameter_Type[0]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[2]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[3]  = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[4]  = (int)OracleType.Cursor;

			//04.DATA 정의  
			MyOraDB.Parameter_Values[0]  = ClassLib.ComVar.Parameter_PopUp[0].ToString();
			MyOraDB.Parameter_Values[1]  = ClassLib.ComVar.Parameter_PopUp[4].ToString();
			MyOraDB.Parameter_Values[2]  = ClassLib.ComVar.Parameter_PopUp[5].ToString();
			MyOraDB.Parameter_Values[3]  = ClassLib.ComVar.Parameter_PopUp[6].ToString();
			MyOraDB.Parameter_Values[4]  = "";
			
			MyOraDB.Add_Select_Parameter(true);
 
			ds_ret = MyOraDB.Exe_Select_Procedure();

			if(ds_ret == null) return null ;
			
			return ds_ret.Tables[process_name]; 

		}


		#endregion 

		private void Pop_OA_Order_Size_Load(object sender, System.EventArgs e)
		{
			Init_Form();
			
		}

		private void txt_Style_Cd_TextChanged(object sender, System.EventArgs e)
		{
		
		}



	}
}

