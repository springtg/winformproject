using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexVJ_Common.DPUFE
{
	public class Form_Select_Model : COM.VJ_CommonWinForm.Pop_Normal
	{
		private System.Windows.Forms.PictureBox pic_head7;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Panel pnl_head;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pic_head3;
		private System.Windows.Forms.PictureBox pic_head4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private C1.Win.C1Input.C1Label btn_Search;
		private System.Windows.Forms.Label lbl_ModelCode;
		private System.Windows.Forms.Label lbl_ModelName;
		private System.Windows.Forms.TextBox txt_ModelName;
		private C1.Win.C1Input.C1Label btn_Select;
		private COM.FSP fgrid_Model;
		private System.Windows.Forms.TextBox txt_ModelCode;
		private System.ComponentModel.IContainer components = null;

		public Form_Select_Model(string p_dev_Name)
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();
			_dev_name = p_dev_Name;

			// TODO: Add any initialization after the InitializeComponent call
		}

		/// <summary>
		/// Clean up any resources being used.
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

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form_Select_Model));
			this.pic_head7 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pnl_head = new System.Windows.Forms.Panel();
			this.btn_Select = new C1.Win.C1Input.C1Label();
			this.lbl_ModelName = new System.Windows.Forms.Label();
			this.txt_ModelName = new System.Windows.Forms.TextBox();
			this.btn_Search = new C1.Win.C1Input.C1Label();
			this.lbl_ModelCode = new System.Windows.Forms.Label();
			this.txt_ModelCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pic_head3 = new System.Windows.Forms.PictureBox();
			this.pic_head4 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.fgrid_Model = new COM.FSP();
			this.pnl_head.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btn_Select)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Model)).BeginInit();
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
			this.lbl_MainTitle.Text = "Select Model";
			// 
			// image_List
			// 
			this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
			// 
			// img_Action
			// 
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			// 
			// img_SmallButton
			// 
			this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
			// 
			// pic_head7
			// 
			this.pic_head7.Location = new System.Drawing.Point(0, 0);
			this.pic_head7.Name = "pic_head7";
			this.pic_head7.TabIndex = 0;
			this.pic_head7.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.TabIndex = 0;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Location = new System.Drawing.Point(0, 0);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.TabIndex = 0;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Location = new System.Drawing.Point(0, 0);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.TabIndex = 0;
			this.pictureBox4.TabStop = false;
			// 
			// pnl_head
			// 
			this.pnl_head.BackColor = System.Drawing.SystemColors.Window;
			this.pnl_head.Controls.Add(this.btn_Select);
			this.pnl_head.Controls.Add(this.lbl_ModelName);
			this.pnl_head.Controls.Add(this.txt_ModelName);
			this.pnl_head.Controls.Add(this.btn_Search);
			this.pnl_head.Controls.Add(this.lbl_ModelCode);
			this.pnl_head.Controls.Add(this.txt_ModelCode);
			this.pnl_head.Controls.Add(this.label2);
			this.pnl_head.Controls.Add(this.pic_head3);
			this.pnl_head.Controls.Add(this.pic_head4);
			this.pnl_head.Controls.Add(this.pictureBox1);
			this.pnl_head.Controls.Add(this.pictureBox6);
			this.pnl_head.Controls.Add(this.pictureBox7);
			this.pnl_head.Controls.Add(this.pictureBox8);
			this.pnl_head.Controls.Add(this.pictureBox9);
			this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnl_head.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pnl_head.Location = new System.Drawing.Point(0, 80);
			this.pnl_head.Name = "pnl_head";
			this.pnl_head.Size = new System.Drawing.Size(494, 96);
			this.pnl_head.TabIndex = 30;
			// 
			// btn_Select
			// 
			this.btn_Select.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Select.ImageIndex = 0;
			this.btn_Select.ImageList = this.img_Button;
			this.btn_Select.Location = new System.Drawing.Point(368, 56);
			this.btn_Select.Name = "btn_Select";
			this.btn_Select.Size = new System.Drawing.Size(72, 23);
			this.btn_Select.TabIndex = 569;
			this.btn_Select.Tag = null;
			this.btn_Select.Text = "Select";
			this.btn_Select.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Select.TextDetached = true;
			this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
			// 
			// lbl_ModelName
			// 
			this.lbl_ModelName.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ModelName.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ModelName.ImageIndex = 1;
			this.lbl_ModelName.ImageList = this.img_Label;
			this.lbl_ModelName.Location = new System.Drawing.Point(16, 56);
			this.lbl_ModelName.Name = "lbl_ModelName";
			this.lbl_ModelName.Size = new System.Drawing.Size(100, 21);
			this.lbl_ModelName.TabIndex = 568;
			this.lbl_ModelName.Text = "Model Name";
			this.lbl_ModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ModelName
			// 
			this.txt_ModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelName.Location = new System.Drawing.Point(120, 56);
			this.txt_ModelName.Name = "txt_ModelName";
			this.txt_ModelName.Size = new System.Drawing.Size(240, 22);
			this.txt_ModelName.TabIndex = 567;
			this.txt_ModelName.Text = "";
			this.txt_ModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ModelName_KeyDown);
			// 
			// btn_Search
			// 
			this.btn_Search.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btn_Search.ImageIndex = 0;
			this.btn_Search.ImageList = this.img_Button;
			this.btn_Search.Location = new System.Drawing.Point(368, 32);
			this.btn_Search.Name = "btn_Search";
			this.btn_Search.Size = new System.Drawing.Size(72, 23);
			this.btn_Search.TabIndex = 566;
			this.btn_Search.Tag = null;
			this.btn_Search.Text = "Search";
			this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Search.TextDetached = true;
			this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
			// 
			// lbl_ModelCode
			// 
			this.lbl_ModelCode.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_ModelCode.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_ModelCode.ImageIndex = 1;
			this.lbl_ModelCode.ImageList = this.img_Label;
			this.lbl_ModelCode.Location = new System.Drawing.Point(16, 32);
			this.lbl_ModelCode.Name = "lbl_ModelCode";
			this.lbl_ModelCode.Size = new System.Drawing.Size(100, 21);
			this.lbl_ModelCode.TabIndex = 405;
			this.lbl_ModelCode.Text = "Model Code";
			this.lbl_ModelCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txt_ModelCode
			// 
			this.txt_ModelCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_ModelCode.Location = new System.Drawing.Point(120, 32);
			this.txt_ModelCode.Name = "txt_ModelCode";
			this.txt_ModelCode.Size = new System.Drawing.Size(240, 22);
			this.txt_ModelCode.TabIndex = 0;
			this.txt_ModelCode.Text = "";
			this.txt_ModelCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ModelCode_KeyDown);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Window;
			this.label2.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Navy;
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(231, 30);
			this.label2.TabIndex = 393;
			this.label2.Text = "      Search Information";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pic_head3
			// 
			this.pic_head3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head3.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head3.Image = ((System.Drawing.Image)(resources.GetObject("pic_head3.Image")));
			this.pic_head3.Location = new System.Drawing.Point(478, 80);
			this.pic_head3.Name = "pic_head3";
			this.pic_head3.Size = new System.Drawing.Size(16, 16);
			this.pic_head3.TabIndex = 45;
			this.pic_head3.TabStop = false;
			// 
			// pic_head4
			// 
			this.pic_head4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pic_head4.BackColor = System.Drawing.SystemColors.Window;
			this.pic_head4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pic_head4.Image = ((System.Drawing.Image)(resources.GetObject("pic_head4.Image")));
			this.pic_head4.Location = new System.Drawing.Point(136, 79);
			this.pic_head4.Name = "pic_head4";
			this.pic_head4.Size = new System.Drawing.Size(454, 18);
			this.pic_head4.TabIndex = 40;
			this.pic_head4.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(192)));
			this.pictureBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(393, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(101, 55);
			this.pictureBox1.TabIndex = 46;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(478, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(16, 32);
			this.pictureBox6.TabIndex = 44;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox7.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 80);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(168, 20);
			this.pictureBox7.TabIndex = 43;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox8.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(160, 0);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(414, 32);
			this.pictureBox8.TabIndex = 39;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pictureBox9.BackColor = System.Drawing.SystemColors.Window;
			this.pictureBox9.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(0, 0);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(168, 78);
			this.pictureBox9.TabIndex = 41;
			this.pictureBox9.TabStop = false;
			// 
			// fgrid_Model
			// 
			this.fgrid_Model.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_Model.ColumnInfo = "10,1,0,0,0,80,Columns:";
			this.fgrid_Model.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fgrid_Model.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(2)));
			this.fgrid_Model.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_Model.Location = new System.Drawing.Point(0, 176);
			this.fgrid_Model.Name = "fgrid_Model";
			this.fgrid_Model.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
			this.fgrid_Model.Size = new System.Drawing.Size(494, 192);
			this.fgrid_Model.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:Verdana, 7pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_Model.TabIndex = 179;
			this.fgrid_Model.DoubleClick += new System.EventHandler(this.fgrid_Model_DoubleClick);
			this.fgrid_Model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fgrid_Model_KeyDown);
			// 
			// Form_Select_Model
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(494, 368);
			this.Controls.Add(this.fgrid_Model);
			this.Controls.Add(this.pnl_head);
			this.Name = "Form_Select_Model";
			this.Text = "Select Model";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Select_Model_KeyDown);
			this.Load += new System.EventHandler(this.Form_Select_Model_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pnl_head, 0);
			this.Controls.SetChildIndex(this.fgrid_Model, 0);
			this.pnl_head.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.btn_Select)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_Model)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region "Declare Variable"
		private int _RowFixed = 1;
		private COM.OraDB oraDB = null;
		private string _dev_name = "";
		#endregion

		#region "Event"

		private void Form_Select_Model_Load(object sender, System.EventArgs e)
		{
			//DialogResult = DialogResult.Cancel;
			oraDB=new COM.OraDB();
			InitControl();
			if (_dev_name!="")
			{
				txt_ModelName.Text = _dev_name;
				Display_FlexGrid(Search_Data(txt_ModelCode.Text.Trim(),txt_ModelName.Text.Trim()),ref fgrid_Model);
			}
		}

		private void btn_Search_Click(object sender, System.EventArgs e)
		{
			Display_FlexGrid(Search_Data(txt_ModelCode.Text.Trim(),txt_ModelName.Text.Trim()),ref fgrid_Model);
		}

		private void btn_Select_Click(object sender, System.EventArgs e)
		{
			fgrid_Model_DoubleClick(fgrid_Model,null) ;
		}

		private void txt_ModelName_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyData.Equals(Keys.Enter))
				Display_FlexGrid(Search_Data(txt_ModelCode.Text.Trim(),txt_ModelName.Text.Trim()),ref fgrid_Model);
			if (e.KeyData.Equals((Keys.Escape)))
			{
				DialogResult = DialogResult.Cancel;
			}
		}
		private void fgrid_Model_DoubleClick(object sender, System.EventArgs e)
		{
			COM.FSP l_fgrid_Model=(COM.FSP)sender;
			if (l_fgrid_Model.Rows.Count <= _RowFixed)
			{
				DialogResult = DialogResult.Cancel;
			}
			else
			{
				this.Tag =  fgrid_Model[fgrid_Model.RowSel,1].ToString();
				DialogResult = DialogResult.OK;
			}
		}
		private void txt_ModelCode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			 if(e.KeyData.Equals(Keys.Enter))
				 Display_FlexGrid(Search_Data(txt_ModelCode.Text.Trim(),txt_ModelName.Text.Trim()),ref fgrid_Model);
			if (e.KeyData.Equals((Keys.Escape)))
			{
				DialogResult = DialogResult.Cancel;
			}
		}

		private void Clear_FlexGrid(COM.FSP p_fgControl)
		{
			if (p_fgControl.Rows.Fixed != p_fgControl.Rows.Count)
			{				
				p_fgControl.Clear(ClearFlags.UserData, p_fgControl.Rows.Fixed, 1, p_fgControl.Rows.Count - 1, p_fgControl.Cols.Count - 1);
				p_fgControl.Rows.Count = p_fgControl.Rows.Fixed;					
			}
				
		}

		private void Display_FlexGrid(DataTable arg_dt,ref COM.FSP  p_fgControl)
		{
			Clear_FlexGrid(p_fgControl);
			int iCount = arg_dt.Rows.Count;
			_RowFixed = p_fgControl.Rows.Fixed;
			for (int iRow = 0 ; iRow < iCount ; iRow++)
			{				
				C1.Win.C1FlexGrid.Node newRow = p_fgControl.Rows.InsertNode(_RowFixed + iRow, 1);

				p_fgControl[newRow.Row.Index, 0] = "";

				for (int iCol = 1 ; iCol <= arg_dt.Columns.Count ; iCol++)
				{
					p_fgControl[newRow.Row.Index, iCol] = arg_dt.Rows[iRow].ItemArray[iCol-1];
				}
			}
		}

		private void Form_Select_Model_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Escape))
			{
				DialogResult = DialogResult.Cancel;
			}
		}

		private void fgrid_Model_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyData.Equals(Keys.Escape))
			{
				DialogResult = DialogResult.Cancel;
			}
			if (e.KeyData.Equals(Keys.Enter))
			{
				fgrid_Model_DoubleClick(fgrid_Model,null) ;
			}
		}

		
		
		
		#endregion

		#region "Method"

		private void InitControl()
		{
			txt_ModelName.Text=string.Empty;
			txt_ModelCode.Text = string.Empty;
			fgrid_Model.Set_Grid("LST_SVM_DP_LOAD","3",1,COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForModify, false);
		}


		private DataTable Search_Data(string p_model_cd, string p_model_name)
		{
			try 
			{
				this.Cursor = Cursors.WaitCursor;

				DataSet ds_ret;

				oraDB.ReDim_Parameter(3); 

				//01.PROCEDURE명
				oraDB.Process_Name = "PKG_SVM_DP_LOAD.SP_SEL_SDC_MODEL"; 

				//02.ARGURMENT 명
				oraDB.Parameter_Name[0] = "ARG_MODEL_CD";
				oraDB.Parameter_Name[1] = "ARG_MODEL_NAME";
				oraDB.Parameter_Name[2] = "OUT_CURSOR"; 
      
				//03.DATA TYPE 정의
				oraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				oraDB.Parameter_Type[2] = (int)OracleType.Cursor;

				//04.DATA 정의
				oraDB.Parameter_Values[0] = p_model_cd;
				oraDB.Parameter_Values[1] = p_model_name;
				oraDB.Parameter_Values[2] = ""; 

				oraDB.Add_Select_Parameter(true);
				ds_ret = oraDB.Exe_Select_Procedure();

				if(ds_ret == null) return null;
				return ds_ret.Tables[oraDB.Process_Name];

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Search_Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return null;
			}
			finally
			{
				this.Cursor = Cursors.Default;
			}

		}
		

		#endregion

	}
}

