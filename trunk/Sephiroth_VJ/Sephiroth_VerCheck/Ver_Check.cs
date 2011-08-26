using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Xml;
using System.Threading;
using System.Net;
using System.Web;
using System.Diagnostics;

namespace Sephiroth_VerCheck
{
	/// <summary>
	/// Form1에 대한 요약 설명입니다.
	/// </summary>
	public class Ver_Check : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pBox;
		private System.Windows.Forms.Label lbl_total;
		private System.Windows.Forms.ProgressBar pBar2;
		private System.Windows.Forms.Label lbl_name;
		private System.Windows.Forms.ProgressBar pBar;
		private System.Windows.Forms.Label btn_close;
		private System.Windows.Forms.Label btn_down;
		private System.Windows.Forms.ImageList imglist;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label label_line;
		private System.Windows.Forms.TextBox txt_desc;
		private System.Windows.Forms.PictureBox pBox1;



		#region 변수 설정

		private FileInfo fileinfo = null;

		private string Server_check_path = "";
		private string Client_check_path = Application.StartupPath;
		private string Version_File      = "version_check.xml";
		private string server_url        = "server_url.xml";


		private XmlDocument doc = new XmlDocument();
		private XmlNodeList serverurl = null;
		private XmlNodeList clientlist = null;
		private XmlNodeList serverlist = null;
		//private string file_name = "";
		//private string file_version = "";
		private string file_seq = "";
		private int file_size = 0;
		private string div = ":";



		private int _IxSEQ      = 0;			
		private int _IxPNAME    = 1;		
		private int _IxPVERSION = 2;
		private int _IxFSIZE    = 3;
		private int _IxDIR	   = 4;
		//private int IxREGIST   = 5;



		private int _IxURLSEQ    = 0;
		private int _IxURLIP     = 1;
		private int _IxURLDIR    = 2;
		private int _IxURLNAME   = 3;
		private int _IxURLDYN    = 4;



		private string down_file = "";
		private string down_dir  = "";


		Thread downThread = null;

		string erp_path = "ERP.exe";
		



		private bool form_check = false;
		private System.Windows.Forms.Label lbl_copy;
		private WebClient myWebClient = null;

		#endregion

		public Ver_Check()
		{
			//
			// Windows Form 디자이너 지원에 필요합니다.
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent를 호출한 다음 생성자 코드를 추가합니다.
			//
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

		#region Windows Form 디자이너에서 생성한 코드
		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다.
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Ver_Check));
			this.pBox = new System.Windows.Forms.PictureBox();
			this.lbl_total = new System.Windows.Forms.Label();
			this.pBar2 = new System.Windows.Forms.ProgressBar();
			this.lbl_name = new System.Windows.Forms.Label();
			this.pBar = new System.Windows.Forms.ProgressBar();
			this.btn_close = new System.Windows.Forms.Label();
			this.imglist = new System.Windows.Forms.ImageList(this.components);
			this.btn_down = new System.Windows.Forms.Label();
			this.label_line = new System.Windows.Forms.Label();
			this.txt_desc = new System.Windows.Forms.TextBox();
			this.pBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_copy = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pBox
			// 
			this.pBox.Image = ((System.Drawing.Image)(resources.GetObject("pBox.Image")));
			this.pBox.Location = new System.Drawing.Point(0, 0);
			this.pBox.Name = "pBox";
			this.pBox.Size = new System.Drawing.Size(358, 94);
			this.pBox.TabIndex = 0;
			this.pBox.TabStop = false;
			// 
			// lbl_total
			// 
			this.lbl_total.BackColor = System.Drawing.Color.Transparent;
			this.lbl_total.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_total.Location = new System.Drawing.Point(10, 104);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(338, 15);
			this.lbl_total.TabIndex = 2;
			// 
			// pBar2
			// 
			this.pBar2.Location = new System.Drawing.Point(10, 152);
			this.pBar2.Name = "pBar2";
			this.pBar2.Size = new System.Drawing.Size(338, 8);
			this.pBar2.TabIndex = 7;
			// 
			// lbl_name
			// 
			this.lbl_name.BackColor = System.Drawing.Color.Transparent;
			this.lbl_name.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_name.Location = new System.Drawing.Point(10, 136);
			this.lbl_name.Name = "lbl_name";
			this.lbl_name.Size = new System.Drawing.Size(338, 15);
			this.lbl_name.TabIndex = 6;
			// 
			// pBar
			// 
			this.pBar.Location = new System.Drawing.Point(10, 120);
			this.pBar.Name = "pBar";
			this.pBar.Size = new System.Drawing.Size(338, 8);
			this.pBar.TabIndex = 5;
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.Transparent;
			this.btn_close.ImageIndex = 2;
			this.btn_close.ImageList = this.imglist;
			this.btn_close.Location = new System.Drawing.Point(304, 195);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(44, 19);
			this.btn_close.TabIndex = 9;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// imglist
			// 
			this.imglist.ImageSize = new System.Drawing.Size(44, 19);
			this.imglist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglist.ImageStream")));
			this.imglist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_down
			// 
			this.btn_down.BackColor = System.Drawing.Color.Transparent;
			this.btn_down.ImageIndex = 0;
			this.btn_down.ImageList = this.imglist;
			this.btn_down.Location = new System.Drawing.Point(304, 166);
			this.btn_down.Name = "btn_down";
			this.btn_down.Size = new System.Drawing.Size(44, 19);
			this.btn_down.TabIndex = 8;
			this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
			// 
			// label_line
			// 
			this.label_line.Image = ((System.Drawing.Image)(resources.GetObject("label_line.Image")));
			this.label_line.Location = new System.Drawing.Point(10, 166);
			this.label_line.Name = "label_line";
			this.label_line.Size = new System.Drawing.Size(288, 48);
			this.label_line.TabIndex = 11;
			// 
			// txt_desc
			// 
			this.txt_desc.BackColor = System.Drawing.Color.White;
			this.txt_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_desc.Cursor = System.Windows.Forms.Cursors.No;
			this.txt_desc.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.txt_desc.Location = new System.Drawing.Point(11, 167);
			this.txt_desc.Multiline = true;
			this.txt_desc.Name = "txt_desc";
			this.txt_desc.ReadOnly = true;
			this.txt_desc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txt_desc.Size = new System.Drawing.Size(286, 46);
			this.txt_desc.TabIndex = 12;
			this.txt_desc.Text = "";
			// 
			// pBox1
			// 
			this.pBox1.Image = ((System.Drawing.Image)(resources.GetObject("pBox1.Image")));
			this.pBox1.Location = new System.Drawing.Point(0, 0);
			this.pBox1.Name = "pBox1";
			this.pBox1.Size = new System.Drawing.Size(358, 94);
			this.pBox1.TabIndex = 13;
			this.pBox1.TabStop = false;
			// 
			// lbl_copy
			// 
			this.lbl_copy.BackColor = System.Drawing.Color.Transparent;
			this.lbl_copy.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(129)));
			this.lbl_copy.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.lbl_copy.Location = new System.Drawing.Point(31, 218);
			this.lbl_copy.Name = "lbl_copy";
			this.lbl_copy.Size = new System.Drawing.Size(297, 18);
			this.lbl_copy.TabIndex = 14;
			this.lbl_copy.Text = "Sephiroth System Version Check Program Ver1.01";
			this.lbl_copy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Ver_Check
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(358, 236);
			this.Controls.Add(this.lbl_copy);
			this.Controls.Add(this.pBox1);
			this.Controls.Add(this.txt_desc);
			this.Controls.Add(this.label_line);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_down);
			this.Controls.Add(this.pBar2);
			this.Controls.Add(this.lbl_name);
			this.Controls.Add(this.pBar);
			this.Controls.Add(this.lbl_total);
			this.Controls.Add(this.pBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Ver_Check";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Version Check";
			this.Load += new System.EventHandler(this.Ver_Check_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// 해당 응용 프로그램의 주 진입점입니다.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Ver_Check());
		}


		#region 메소드
		
		private void Init_Form()
		{


			this.Size = new Size(358, 236);
			pBox1.Size = new Size(358,94);

			pBar.Location = new Point(10, 120);
			pBar.Size = new Size(338, 8);

			pBar2.Location = new Point(10, 152);
			pBar2.Size = new Size(338, 8);

			txt_desc.Location = new Point(11, 167);
			txt_desc.Size = new Size(286, 46);

			btn_down.Location = new Point(304, 166);
			btn_down.Size = new Size(44,19);

			btn_close.Location = new Point(304, 195);
			btn_close.Size = new Size(44, 19);




			pBox.Visible = false;
			pBox1.Visible = true;
			lbl_total.Text = "File Total Size : 0 byte";


			try
			{

				doc = new XmlDocument();
				doc.Load(Client_check_path + @"\" + server_url);
				serverurl = doc.DocumentElement.ChildNodes;


				for(int i=0; i<serverurl.Count+1; i++)
				{
					if(i==serverurl.Count)
					{
						Error_txt("Can not connect The file server!");
						return;
					}


					Server_check_path = serverurl.Item(i).ChildNodes[_IxURLIP].FirstChild.Value.ToString()
						+ serverurl.Item(i).ChildNodes[_IxURLDIR].FirstChild.Value.ToString();
					Version_File      = serverurl.Item(i).ChildNodes[_IxURLNAME].FirstChild.Value.ToString();
					string serverdown_yn = serverurl.Item(i).ChildNodes[_IxURLDYN].FirstChild.Value.ToString();

					if(serverdown_yn.ToUpper() != "Y")
					{
						try
						{
							doc.Load(Server_check_path + Version_File);
							serverlist = doc.DocumentElement.ChildNodes;
							break;
						}
						catch//(Exception ex)
						{
							//MessageBox.Show(ex.ToString());
						}
					}
				}
			
				File_Exists();
			}
			catch
			{
				Error_txt("Can not find The file server!");
				return;
			}
		}
		
		private void File_Exists()
		{
			View_Desc("Ready To File Download!!");
			btn_down.Focus();
			
			fileinfo = new FileInfo(Client_check_path +@"\"+ Version_File);

			if(fileinfo.Exists)
			{

				string file_name = "";
				decimal file_version =0;
				string file_serseq = "";

				bool seq_check = true;
			
			
				

				try
				{
					//doc = new XmlDocument();
					doc.Load(Server_check_path + Version_File);
					serverlist = doc.DocumentElement.ChildNodes;
				}
				catch
				{
					Error_txt("The file server is not operate.");
					return;
				}


				for(int i=0; i<serverlist.Count; i++)
				{
					seq_check = true;

					file_name = serverlist.Item(i).ChildNodes[_IxPNAME].FirstChild.Value.ToString();
					file_version = decimal.Parse(serverlist.Item(i).ChildNodes[_IxPVERSION].FirstChild.Value.ToString());
					file_serseq = serverlist.Item(i).ChildNodes[_IxSEQ].FirstChild.Value.ToString();

					
				
					doc.Load(Client_check_path +@"\"+ Version_File);
					clientlist = doc.DocumentElement.ChildNodes;
				

					for(int j=0; j<clientlist.Count; j++)
					{
						if(file_name == clientlist.Item(j).ChildNodes[_IxPNAME].FirstChild.Value.ToString())
						{
							seq_check = false;
							if(file_version > decimal.Parse(clientlist.Item(j).ChildNodes[_IxPVERSION].FirstChild.Value.ToString()))
							{
								file_seq += file_serseq+":";
								break;
							}
						}
					}
				
					if(seq_check)
					{
						file_seq += file_serseq+":";
					}	
				}
			
			

				if(file_seq == "")
				{
					Process.Start(erp_path);
					Dispose();
				}
				else
				{	
					Show_File(file_seq);	
				}
			}
			else
			{
				Show_File(file_seq);
			}

			
		}



		private void Show_File(string arg_file_seq)
		{
			//xml 불러오기
			doc = new XmlDocument();
			doc.Load(Server_check_path + Version_File);

			serverlist = doc.DocumentElement.ChildNodes;

			if(file_seq == "")
			{

				for(int i=0; i<serverlist.Count; i++)
				{
					down_file += serverlist.Item(i).ChildNodes[_IxPNAME].FirstChild.Value.ToString()+":";
					down_dir  += serverlist.Item(i).ChildNodes[_IxDIR].FirstChild.Value.ToString()+":";
					file_size += int.Parse(serverlist.Item(i).ChildNodes[_IxFSIZE].FirstChild.Value.ToString());
				}
			
				lbl_total.Text = "File Total Size : " + file_size + "byte";
				lbl_name.Text  = "File Name : " + serverlist.Item(0).ChildNodes[_IxPNAME].FirstChild.Value.ToString()
					+ "     File Size : " + serverlist.Item(0).ChildNodes[_IxFSIZE].FirstChild.Value.ToString() + "byte";

			
			}
			else
			{
				string[] file_seqs = file_seq.Split(div.ToCharArray());

				for(int j=0; j<file_seqs.Length-1; j++)
				{

					for(int k=0; k<serverlist.Count; k++)
					{
						if(file_seqs[j] ==  serverlist.Item(k).ChildNodes[_IxSEQ].FirstChild.Value.ToString())
						{
							down_file += serverlist.Item(k).ChildNodes[_IxPNAME].FirstChild.Value.ToString()+":";
							down_dir  += serverlist.Item(k).ChildNodes[_IxDIR].FirstChild.Value.ToString()+":";
							file_size += int.Parse(serverlist.Item(k).ChildNodes[_IxFSIZE].FirstChild.Value.ToString());
							if(j==0)
							{
								lbl_name.Text  = "File Name : " + serverlist.Item(k).ChildNodes[_IxPNAME].FirstChild.Value.ToString()
									+ "     File Size : " + serverlist.Item(k).ChildNodes[_IxFSIZE].FirstChild.Value.ToString() + "byte";
							}
							break;
						}
					}
				}
				lbl_total.Text = "File Total Size : " + file_size + "byte";
			}


			btn_down_Click(null,null);
		}


		private void File_down()
		{

			pBox.Visible = true;
			pBox1.Visible = false;

			string myStringWebResource = null;
			string[] file_name = down_file.Split(div.ToCharArray());
			string[] file_dir = down_dir.Split(div.ToCharArray());
			
			WebClient myWebClient = new WebClient();
			
			
			
			FileStream fs =  null;
			BinaryWriter bw = null;
			byte[] file_unit = null;
			
			


			pBar.Maximum = file_name.Length;

			for(int i=0; i<file_name.Length-1; i++)
			{
				pBar.Value = i+1;	

				pBar2.Maximum = 100;
				pBar2.Value = 10;
				lbl_name.Text  = "File Name : " + serverlist.Item(i).ChildNodes[_IxPNAME].FirstChild.Value.ToString()
					+ "     File Size : " + serverlist.Item(i).ChildNodes[_IxFSIZE].FirstChild.Value.ToString() + "byte";

				View_Desc(file_name[i] + " Downloading....");

				pBar2.Value = 25;
				myStringWebResource = Server_check_path + file_name[i];
				
				pBar2.Value = 35;
				fs = new FileStream(Application.StartupPath + file_dir[i].Trim() + file_name[i], FileMode.Create, FileAccess.Write);
				bw = new BinaryWriter(fs);


				//try
				//{
					//myWebClient = new WebClient();
					file_unit = myWebClient.DownloadData(myStringWebResource);
					//myWebClient.DownloadFile(Server_check_path, file_name[i]);
					//myWebClient = null;
				//}
				//catch(Exception ex)
				//{
				//	MessageBox.Show(ex.ToString());
				//	Error_txt(file_name[i] + " have some problem!!");
				//	return;
				//}
				pBar2.Value = 60;
				bw.Write(file_unit);
				bw.Close();
				pBar2.Value = 100;

				View_Desc(file_name[i] + "Download Success!");
			}

			pBar.Value = file_name.Length;


			View_Desc("All File Download Complete!!");

			form_check = true;
			//btn_close.Focus();

			pBox.Visible = false;
			pBox1.Visible = true;

			Process.Start(erp_path);

			this.Close();
		}


		private void View_Desc(string arg_desc)
		{
			txt_desc.AppendText(arg_desc + "\r\n");
			txt_desc.Focus();
			txt_desc.ScrollToCaret();
		}



		private void Error_txt(string arg_Error)
		{
			btn_down.Enabled = false;
			txt_desc.Text = arg_Error;
		}

		#endregion

		#region 이벤트

		private void Ver_Check_Load(object sender, System.EventArgs e)
		{
			Init_Form();
		}
		
		/// <summary>
		/// 다운 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_down_Click(object sender, System.EventArgs e)
		{
			downThread = new Thread(new ThreadStart(File_down));
			downThread.Start();

			btn_down.Enabled = false;
		}
		
		
		/// <summary>
		/// 닫기 버튼 클릭
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_close_Click(object sender, System.EventArgs e)
		{
			if(downThread != null)
			{
				downThread.Abort();
			}

			if(form_check)
			{
				Process.Start(erp_path);
			}
			this.Close();
		}

		#endregion
	}
}
