using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using C1.Win.C1FlexGrid;
using System.Drawing.Imaging;
using System.Data;
using System.Data.OracleClient;
using Lassalle.Flow;
using Lassalle.DlgFlow;

namespace FlexCDC.CDC_Bom
{
	public class Pop_IMG_Editer : COM.PCHWinForm.Pop_Medium
	{

		private COM.OraDB OraDB = new COM.OraDB();
		private System.Windows.Forms.Panel pal_base;
		private Lassalle.Flow.AddFlow addflow_Img;
		private System.Windows.Forms.TextBox txt_remarks;
		private System.Windows.Forms.Label lbl_remarks;
		private System.Windows.Forms.Label btn_Append;
		private System.Windows.Forms.Label btn_Save;
		private COM.FSP fgrid_part;
		private System.ComponentModel.IContainer components = null;
		private Form_Project_Manager _from = null;
		private string _factory = null;
		private string _srf_no = null;
		private string _bom_id = null;
		private string _ub_type = null;
		private string _image_seq = null;
		private string file_info = "";
		private int click_count = 1;

		//510, 310 
		private float _MaxImageWidth = 490;
		private float _MaxImageHeight = 290;

		public Pop_IMG_Editer()
		{
			// 이 호출은 Windows Form 디자이너에 필요합니다.
			InitializeComponent();

			// TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
		}

		public Pop_IMG_Editer(Form_Project_Manager arg_frm, string arg_factory, string arg_srf_no, string arg_bom_id, string arg_ub_type, string arg_image_seq)
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
			
			_from      = arg_frm;
			_factory   = arg_factory;
			_srf_no    = arg_srf_no;
			_bom_id    = arg_bom_id;
			_ub_type   = arg_ub_type;
			_image_seq = arg_image_seq;

			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Pop_IMG_Editer));
			this.pal_base = new System.Windows.Forms.Panel();
			this.addflow_Img = new Lassalle.Flow.AddFlow();
			this.txt_remarks = new System.Windows.Forms.TextBox();
			this.lbl_remarks = new System.Windows.Forms.Label();
			this.btn_Append = new System.Windows.Forms.Label();
			this.btn_Save = new System.Windows.Forms.Label();
			this.fgrid_part = new COM.FSP();
			this.pal_base.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).BeginInit();
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
			this.lbl_MainTitle.Size = new System.Drawing.Size(566, 23);
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
			// pal_base
			// 
			this.pal_base.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pal_base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pal_base.Controls.Add(this.addflow_Img);
			this.pal_base.Location = new System.Drawing.Point(8, 88);
			this.pal_base.Name = "pal_base";
			this.pal_base.Size = new System.Drawing.Size(512, 312);
			this.pal_base.TabIndex = 345;
			// 
			// addflow_Img
			// 
			this.addflow_Img.AutoScroll = true;
			this.addflow_Img.AutoScrollMinSize = new System.Drawing.Size(130, 110);
			this.addflow_Img.BackColor = System.Drawing.SystemColors.Window;
			this.addflow_Img.CanDrawNode = false;
			this.addflow_Img.DefLinkProp.AdjustDst = true;
			this.addflow_Img.DefLinkProp.Text = null;
			this.addflow_Img.DefLinkProp.Tooltip = null;
			this.addflow_Img.DefLinkProp.Url = null;
			this.addflow_Img.Dock = System.Windows.Forms.DockStyle.Fill;
			this.addflow_Img.Font = new System.Drawing.Font("굴림", 9F);
			this.addflow_Img.ForeColor = System.Drawing.SystemColors.ControlText;
			this.addflow_Img.Location = new System.Drawing.Point(0, 0);
			this.addflow_Img.Name = "addflow_Img";
			this.addflow_Img.PageUnit = System.Drawing.GraphicsUnit.Pixel;
			this.addflow_Img.ScrollbarsDisplayMode = Lassalle.Flow.ScrollbarsDisplayMode.SizeOfDiagramOnly;
			this.addflow_Img.Size = new System.Drawing.Size(510, 310);
			this.addflow_Img.TabIndex = 43;
			// 
			// txt_remarks
			// 
			this.txt_remarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_remarks.Location = new System.Drawing.Point(528, 112);
			this.txt_remarks.Multiline = true;
			this.txt_remarks.Name = "txt_remarks";
			this.txt_remarks.Size = new System.Drawing.Size(160, 256);
			this.txt_remarks.TabIndex = 350;
			this.txt_remarks.Text = "";
			// 
			// lbl_remarks
			// 
			this.lbl_remarks.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbl_remarks.ImageIndex = 0;
			this.lbl_remarks.ImageList = this.img_Label;
			this.lbl_remarks.Location = new System.Drawing.Point(528, 88);
			this.lbl_remarks.Name = "lbl_remarks";
			this.lbl_remarks.Size = new System.Drawing.Size(100, 21);
			this.lbl_remarks.TabIndex = 349;
			this.lbl_remarks.Tag = "1";
			this.lbl_remarks.Text = "Remarks";
			this.lbl_remarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btn_Append
			// 
			this.btn_Append.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Append.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Append.ImageIndex = 0;
			this.btn_Append.ImageList = this.img_Button;
			this.btn_Append.Location = new System.Drawing.Point(528, 376);
			this.btn_Append.Name = "btn_Append";
			this.btn_Append.Size = new System.Drawing.Size(70, 23);
			this.btn_Append.TabIndex = 352;
			this.btn_Append.Text = "Add";
			this.btn_Append.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Append.Click += new System.EventHandler(this.btn_Append_Click);
			// 
			// btn_Save
			// 
			this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_Save.ImageIndex = 11;
			this.btn_Save.ImageList = this.image_List;
			this.btn_Save.Location = new System.Drawing.Point(608, 376);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(80, 24);
			this.btn_Save.TabIndex = 351;
			this.btn_Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// fgrid_part
			// 
			this.fgrid_part.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.Both;
			this.fgrid_part.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.fgrid_part.AutoResize = false;
			this.fgrid_part.BackColor = System.Drawing.SystemColors.Window;
			this.fgrid_part.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
			this.fgrid_part.ColumnInfo = "10,1,0,0,0,95,Columns:";
			this.fgrid_part.ForeColor = System.Drawing.SystemColors.WindowText;
			this.fgrid_part.Location = new System.Drawing.Point(9, 408);
			this.fgrid_part.Name = "fgrid_part";
			this.fgrid_part.Rows.Fixed = 0;
			this.fgrid_part.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
			this.fgrid_part.Size = new System.Drawing.Size(680, 152);
			this.fgrid_part.Styles = new C1.Win.C1FlexGrid.CellStyleCollection(@"Normal{Font:굴림, 9pt;}	Alternate{BackColor:240, 244, 250;}	Fixed{BackColor:135, 179, 234;ForeColor:White;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this.fgrid_part.TabIndex = 353;
			this.fgrid_part.DoubleClick += new System.EventHandler(this.fgrid_part_Click);
			// 
			// Pop_IMG_Editer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(698, 566);
			this.Controls.Add(this.fgrid_part);
			this.Controls.Add(this.btn_Append);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.txt_remarks);
			this.Controls.Add(this.lbl_remarks);
			this.Controls.Add(this.pal_base);
			this.Name = "Pop_IMG_Editer";
			this.Load += new System.EventHandler(this.Pop_IMG_Editer_Load);
			this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
			this.Controls.SetChildIndex(this.pal_base, 0);
			this.Controls.SetChildIndex(this.lbl_remarks, 0);
			this.Controls.SetChildIndex(this.txt_remarks, 0);
			this.Controls.SetChildIndex(this.btn_Save, 0);
			this.Controls.SetChildIndex(this.btn_Append, 0);
			this.Controls.SetChildIndex(this.fgrid_part, 0);
			this.pal_base.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.fgrid_part)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void Pop_IMG_Editer_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}

		private void Init_Form()
		{

            try
            {
                this.Cursor = Cursors.WaitCursor;

                fgrid_part.Set_Grid_CDC("SXD_SRF_TAIL_PART", "1", 1, COM.ComVar.This_Lang, COM.ComVar.Grid_Type.ForSearch, false);
                fgrid_part.Set_Action_Image(img_Action);



                //fgrid_part.AutoSizeCols();

                // AddFlow 초기화
                Clear_AddFlow(addflow_Img);

                Show_data();

            }
            catch
            {
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

		public static void Clear_AddFlow(Lassalle.Flow.AddFlow arg_addflow)
		{
			arg_addflow.Items.Clear();
			
			/*
			arg_addflow.BackColor = Color.White;
			arg_addflow.Grid.Color = Color.White;
			arg_addflow.Grid.Draw = true;
			arg_addflow.Grid.Snap = false;
			arg_addflow.Grid.Style = GridStyle.DottedLines;
			arg_addflow.Grid.Size = new Size(10, 10);
			*/

			arg_addflow.DefNodeProp.Shape.Style = ShapeStyle.Rectangle;
		}


		private void Show_data()
		{
			DataTable dt = Select_sdc_pj_tail_image();

			int dt_rows = dt.Rows.Count;
			int dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				byte[] MyData = null;
				MyData = (byte[])dt.Rows[i].ItemArray[0];

				txt_remarks.Text = dt.Rows[i].ItemArray[1].ToString();

				MemoryStream ms = new MemoryStream(MyData); 
				System.Drawing.Bitmap true_image = new System.Drawing.Bitmap(ms); 

				Image img = true_image;
				float imgFwidth = float.Parse(img.Width.ToString());
				float imgFheight  = float.Parse(img.Height.ToString());

				Rectangle rect = new Rectangle(1, 1, Convert.ToInt32(imgFwidth - 2), Convert.ToInt32(imgFheight - 2) ); // 잘라낼 영역으로 사용  
				PixelFormat pixf =  img.PixelFormat; // 이미지의 픽셀포맷 
				Bitmap bt_img = ((Bitmap)img).Clone(rect, pixf); 
				img = (Image)bt_img;

				imgFwidth = float.Parse(img.Width.ToString());
				imgFheight  = float.Parse(img.Height.ToString());
				
				addflow_Img.Images.Add(img);
				// Create nodes
				// 이미지 크기가 기본 addflow 영역보다 클 경우는 줄여서 load
				imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
				imgFwidth  = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;

 

				Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(0, 0, true_image.Width,true_image.Height);




				// 이미지 노드의 라인색
				node1.DrawColor = Color.Transparent;
				// 이미지 노드의 투명화
				node1.FillColor = Color.Transparent; 


 
				node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
				node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode; 

				// 노드 태그가 -1 이면 이미지 노드라고 정의하고, edit 못하도록 처리
				node1.Tag = "-1";

				






				int imgIndex = addflow_Img.Images.Count;

				if(imgIndex <= 0)
				{
					node1.ImageIndex = 0;
				}
				else
				{
					node1.ImageIndex = (imgIndex-1);
					//MessageBox.Show((imgIndex).ToString());
				}

				addflow_Img.Nodes.Add(node1);
			}


			dt = Select_sdd_srf_tail_part_list();

			dt_rows = dt.Rows.Count;
			dt_cols = dt.Columns.Count;

			for(int i=0; i<dt_rows; i++)
			{
				fgrid_part.AddItem(dt.Rows[i].ItemArray, fgrid_part.Rows.Count, 1);
			}

			fgrid_part.AutoSizeCols();
		}

		private DataTable Select_sdd_srf_tail_part_list()
		{
			string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXD_SRF_TAIL_PART_LIST";

			OraDB.ReDim_Parameter(4);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_srf_no";
			OraDB.Parameter_Name[2] = "arg_bom_id";
			OraDB.Parameter_Name[3] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = _factory;
			OraDB.Parameter_Values[1] = _srf_no;
			OraDB.Parameter_Values[2] = _bom_id;
			OraDB.Parameter_Values[3] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}


		/// <summary>
		/// Save_Image : 
		/// </summary>
		private DataTable Select_sdc_pj_tail_image()
		{
			string Proc_Name = "PKG_SXD_SRF_01_SELECT.SELECT_SXC_PJ_MAST_IMAGE";

			OraDB.ReDim_Parameter(6);
			OraDB.Process_Name = Proc_Name ;

			OraDB.Parameter_Name[0] = "arg_factory";
			OraDB.Parameter_Name[1] = "arg_srf_no";
			OraDB.Parameter_Name[2] = "arg_bom_id";
			OraDB.Parameter_Name[3] = "arg_ub_type";
			OraDB.Parameter_Name[4] = "arg_image_seq";
			OraDB.Parameter_Name[5] = "out_cursor";

			OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
			OraDB.Parameter_Type[5] = (int)OracleType.Cursor;

			OraDB.Parameter_Values[0] = _factory;
			OraDB.Parameter_Values[1] = _srf_no;
			OraDB.Parameter_Values[2] = _bom_id;
			OraDB.Parameter_Values[3] = _ub_type;
			OraDB.Parameter_Values[4] = _image_seq;
			OraDB.Parameter_Values[5] = "";

			OraDB.Add_Select_Parameter(true);
			DataSet DS_Ret = OraDB.Exe_Select_Procedure();

			if(DS_Ret == null) return null ;
			
			return DS_Ret.Tables[Proc_Name];
		}

		private void btn_Append_Click(object sender, System.EventArgs e)
		{

            try
            {
                this.Cursor = Cursors.WaitCursor;

                //			// AddFlow 초기화
                //			Clear_AddFlow(addflow_Img);
                //




                string m_strPath = null;
                OpenFileDialog openDlg = new OpenFileDialog();

                // 파일오픈에 대한 기초환경 설정 부분 >> 시작
                // 현재 업로드되는 파일은 "gif, jpg" 만 가능하며, 추가 가능하다.
                openDlg.InitialDirectory = "c:\\";
                openDlg.DefaultExt = "jpg, gif";
                openDlg.Filter = "Image File (*.jpg)|*.jpg|Image File(*.gif)|*.gif";
                //openDlg.FilterIndex = 2;
                openDlg.RestoreDirectory = false;
                // 파일오픈에 대한 기초환경 설정부분 >> 끝

                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    //addflow 초기화 부분 (주석 풀지 말것 ~ !)
                    //addflow_Img.Images.Clear();

                    m_strPath = openDlg.FileName;

                    // 이미지 Resource 추가.
                    addflow_Img.Images.Add(m_strPath);

                    // 호출된 이미지 Resource 의 Size 구하는 부분
                    Image img = Image.FromFile(m_strPath);
                    float imgFwidth = float.Parse(img.Width.ToString());
                    float imgFheight = float.Parse(img.Height.ToString());

                    // Create nodes

                    // 이미지 크기가 기본 addflow 영역보다 클 경우는 줄여서 load
                    imgFheight = (imgFheight < _MaxImageHeight) ? imgFheight : _MaxImageHeight;
                    imgFwidth = (imgFwidth < _MaxImageWidth) ? imgFwidth : _MaxImageWidth;



                    Lassalle.Flow.Node node1 = new Lassalle.Flow.Node(10, 10, imgFwidth, imgFheight);




                    // 이미지 노드의 라인색
                    node1.DrawColor = Color.Transparent;
                    // 이미지 노드의 투명화
                    node1.FillColor = Color.Transparent;



                    node1.Shape.Style = Lassalle.Flow.ShapeStyle.Rectangle;
                    node1.AutoSize = Lassalle.Flow.AutoSize.ImageToNode;

                    // 노드 태그가 -1 이면 이미지 노드라고 정의하고, edit 못하도록 처리
                    node1.Tag = "-1";








                    int imgIndex = addflow_Img.Images.Count;

                    if (imgIndex <= 0)
                    {
                        node1.ImageIndex = 0;
                    }
                    else
                    {
                        node1.ImageIndex = (imgIndex - 1);
                        //MessageBox.Show((imgIndex).ToString());
                    }

                    addflow_Img.Nodes.Add(node1);
                }

                // Stream Setting Part
                // Stream myStream;
                // if(openDlg.ShowDialog() == DialogResult.OK)
                // {
                //	   if((myStream = openDlg.OpenFile()) != null)
                //     {
                //			-- Database 의 BLOB Type 에 저장 설정하는 부분
                //			myStream.Close();
                //     }
                // }
            }
            catch
            {
                this.Cursor = Cursors.Default;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

		private void btn_Save_Click(object sender, System.EventArgs e)
		{
            try
            {
                this.Cursor = Cursors.WaitCursor;

                // 파일 저장시 "년월일시초.jpg" 로 작성된다. >> 시작
                string year = (DateTime.Now.Year).ToString();
                string month = (DateTime.Now.Month).ToString();
                string day = (DateTime.Now.Day).ToString();
                string second = (DateTime.Now.Second).ToString();
                string mile = (DateTime.Now.Millisecond).ToString();

                string tempDay = year + month + day + second + mile + ".jpg";
                // 파일 저장시 "년월일시초.jpg" 로 작성된다. >> 끝

                //Metafile mf = addflow_Img.ExportMetafile(false, true, false); 

                Metafile mf = addflow_Img.ExportMetafile(false, true, true, true, true);



                // 이미지 파일이 저장되는 물리적 위치.
                string targetPath = Application.StartupPath + @"\";

                mf.Save(targetPath + tempDay, ImageFormat.Jpeg);

                //mf.Size = new Size(100,100);
                file_info = targetPath + tempDay;//추가 



                if (DialogResult.Yes == MessageBox.Show("Old image delete...\r\nDo you want to continue?", "Information", MessageBoxButtons.YesNo))
                {
                    if (Save_sdc_pj_tail_image(file_info))
                    {
                        FileInfo file = new FileInfo(file_info);
                        file.Delete();
                        ClassLib.ComFunction.Data_Message(COM.ComVar.MgsEndSave, this);
                    }
                    else
                    {
                        ClassLib.ComFunction.Data_Message(COM.ComVar.MgsDoNotSave, this);
                    }
                }
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                ClassLib.ComFunction.User_Message(ex.Message, "btn_Save_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
		}

		
		/// <summary>
		/// Save_Image : 
		/// </summary>
		private bool Save_sdc_pj_tail_image(string arg_file_name)
		{
			try
			{
 
				bool ret;

				OraDB.ReDim_Parameter(10);
 
 
				//01.PROCEDURE명
				OraDB.Process_Name = "pkg_sxd_srf_01.save_sxc_pj_mast_image";

				//02.ARGURMENT 명
				OraDB.Parameter_Name[0] = "arg_factory";
				OraDB.Parameter_Name[1] = "arg_srf_no";
				OraDB.Parameter_Name[2] = "arg_bom_id";
				OraDB.Parameter_Name[3] = "arg_ub_type";
				OraDB.Parameter_Name[4] = "arg_image_seq";
				OraDB.Parameter_Name[5] = "arg_image";
				OraDB.Parameter_Name[6] = "arg_point";
				OraDB.Parameter_Name[7] = "arg_remarks";
				OraDB.Parameter_Name[8] = "arg_status";
				OraDB.Parameter_Name[9] = "arg_upd_user";

				//03.DATA TYPE 정의
				OraDB.Parameter_Type[0] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[1] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[2] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[3] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[4] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[5] = (int)OracleType.Blob;
				OraDB.Parameter_Type[6] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[7] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[8] = (int)OracleType.VarChar;
				OraDB.Parameter_Type[9] = (int)OracleType.VarChar;

				//04.DATA 정의
				OraDB.Parameter_Values[0] = _factory;
				OraDB.Parameter_Values[1] = _srf_no;
				OraDB.Parameter_Values[2] = _bom_id;
				OraDB.Parameter_Values[3] = _ub_type;
				OraDB.Parameter_Values[4] = _image_seq;
				OraDB.Parameter_Values[5] = " ";
				OraDB.Parameter_Values[6] = " ";

				string remarks = " ";
				if(txt_remarks.Text.Length > 0)
				{
					remarks = txt_remarks.Text;
				}


				OraDB.Parameter_Values[7] = remarks;
				OraDB.Parameter_Values[8] = " ";
				OraDB.Parameter_Values[9] = ClassLib.ComVar.This_User;
  
				byte[] photo = null;
				photo = GetPhoto(arg_file_name);
				ret = OraDB.Exe_Modify_Procedure_Blob(photo);
				return ret;

			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "Save_Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			} 
		}

		/// <summary>
		/// GetPhoto : 
		/// </summary>
		/// <param name="arg_filename"></param>
		/// <returns></returns>
		private byte[] GetPhoto(string arg_filename)
		{
			FileStream fs = new FileStream(arg_filename, FileMode.Open, FileAccess.Read);
			BinaryReader br = new BinaryReader(fs);

			byte[] photo = br.ReadBytes((int)fs.Length);   
				
			br.Close();
			fs.Close();

			return photo;

		}

		private void fgrid_part_Click(object sender, System.EventArgs e)
		{
			int sct_row = fgrid_part.Selection.r1;
			int sct_col = fgrid_part.Selection.c1;

			string mat_desc = fgrid_part[sct_row, (int)ClassLib.TBSXD_SRF_TAIL_PART_LIST.IxMAT_NAME].ToString();

			try
			{
				Add_Desc_Node(mat_desc);
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "btn_ApplyDesc_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Add_Desc_Node : 새로운 description node 추가
		/// </summary>
		private void Add_Desc_Node(string arg_desc)
		{
			click_count++;
			Lassalle.Flow.Node node = new Lassalle.Flow.Node(click_count*10, click_count*10, 100, 40, arg_desc);

			node.Tag = "";
			node.Shape.Style = ShapeStyle.Rectangle;

			addflow_Img.Nodes.Add(node);

 

		}
	}
}

