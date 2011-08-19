using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;

namespace FlexMRP.MRP
{
	// 공통 인터페이스
	public interface IOperation
	{
		int GetSearchRows();
		void CheckStatus();
		bool Confirm();
        void RunProcess(string arg_factory, string arg_ShipType, string arg_mrpNo, string arg_PlanStart, string arg_PlanEnd);
	}

	public class Ctl_BM_MRP_Operation : System.Windows.Forms.UserControl
	{
		#region 디자이너 생성 변수

		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label btn_next;
		private System.Windows.Forms.Label lbl_prev;
		private System.Windows.Forms.Form _mdiParent;
		private IOperation _curForm;
		public System.Windows.Forms.ImageList img_Menu;
		public System.Windows.Forms.ImageList img_Button;
		private System.Windows.Forms.ImageList img_Type;
		private System.Windows.Forms.ImageList img_Action;
		private System.Windows.Forms.ListView lst_main;
		private System.Windows.Forms.ImageList img_Event;

		#endregion

		#region 사용자 정의 변수

		private int _curProcessNum = 0;
		private int _default = 20, _check = 10, _select = 0;
		private string _mrpShipNo, _planStart, _planEnd;
		private ArrayList _processList = new ArrayList();
		private int[] _imageIndex;
		private Form_BM_MRP_Operation _startForm;

		#endregion

		#region 생성자 / 소멸자

		public Ctl_BM_MRP_Operation(Form arg_startForm)
		{
			InitializeComponent();

			_mdiParent = arg_startForm.MdiParent;
			_startForm = (Form_BM_MRP_Operation)arg_startForm;

			init_form();
		}

		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#endregion

		#region 구성 요소 디자이너에서 생성한 코드
		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Ctl_BM_MRP_Operation));
			this.img_Action = new System.Windows.Forms.ImageList(this.components);
			this.img_Menu = new System.Windows.Forms.ImageList(this.components);
			this.img_Button = new System.Windows.Forms.ImageList(this.components);
			this.btn_next = new System.Windows.Forms.Label();
			this.lbl_prev = new System.Windows.Forms.Label();
			this.img_Type = new System.Windows.Forms.ImageList(this.components);
			this.lst_main = new System.Windows.Forms.ListView();
			this.img_Event = new System.Windows.Forms.ImageList(this.components);
			this.SuspendLayout();
			// 
			// img_Action
			// 
			this.img_Action.ImageSize = new System.Drawing.Size(32, 32);
			this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
			this.img_Action.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// img_Menu
			// 
			this.img_Menu.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Menu.ImageSize = new System.Drawing.Size(38, 38);
			this.img_Menu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Menu.ImageStream")));
			this.img_Menu.TransparentColor = System.Drawing.Color.FromArgb(((System.Byte)(181)), ((System.Byte)(206)), ((System.Byte)(240)));
			// 
			// img_Button
			// 
			this.img_Button.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Button.ImageSize = new System.Drawing.Size(80, 23);
			this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
			this.img_Button.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btn_next
			// 
			this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_next.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.btn_next.Font = new System.Drawing.Font("굴림", 9F);
			this.btn_next.ImageIndex = 0;
			this.btn_next.ImageList = this.img_Button;
			this.btn_next.Location = new System.Drawing.Point(784, 72);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(80, 24);
			this.btn_next.TabIndex = 403;
			this.btn_next.Text = "Next";
			this.btn_next.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// lbl_prev
			// 
			this.lbl_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_prev.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(239)), ((System.Byte)(248)), ((System.Byte)(251)));
			this.lbl_prev.Font = new System.Drawing.Font("굴림", 9F);
			this.lbl_prev.ImageIndex = 0;
			this.lbl_prev.ImageList = this.img_Button;
			this.lbl_prev.Location = new System.Drawing.Point(703, 72);
			this.lbl_prev.Name = "lbl_prev";
			this.lbl_prev.Size = new System.Drawing.Size(80, 24);
			this.lbl_prev.TabIndex = 403;
			this.lbl_prev.Text = "Previous";
			this.lbl_prev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_prev.Click += new System.EventHandler(this.lbl_prev_Click);
			// 
			// img_Type
			// 
			this.img_Type.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Type.ImageSize = new System.Drawing.Size(16, 16);
			this.img_Type.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Type.ImageStream")));
			this.img_Type.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lst_main
			// 
			this.lst_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lst_main.BackColor = System.Drawing.Color.AliceBlue;
			this.lst_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lst_main.FullRowSelect = true;
			this.lst_main.HideSelection = false;
			this.lst_main.LabelWrap = false;
			this.lst_main.LargeImageList = this.img_Event;
			this.lst_main.Location = new System.Drawing.Point(8, 8);
			this.lst_main.MultiSelect = false;
			this.lst_main.Name = "lst_main";
			this.lst_main.Size = new System.Drawing.Size(856, 56);
			this.lst_main.TabIndex = 0;
			this.lst_main.DoubleClick += new System.EventHandler(this.lst_main_DoubleClick);
			// 
			// img_Event
			// 
			this.img_Event.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.img_Event.ImageSize = new System.Drawing.Size(65, 23);
			this.img_Event.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Event.ImageStream")));
			this.img_Event.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// Ctl_BM_MRP_Operation
			// 
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.lbl_prev);
			this.Controls.Add(this.lst_main);
			this.Name = "Ctl_BM_MRP_Operation";
			this.Size = new System.Drawing.Size(872, 104);
			this.ResumeLayout(false);

		}
		#endregion

		#region 초기화, 폼관련

		private void init_form()
		{
			DataTable vDt = ClassLib.ComVar.Select_ComCode(COM.ComVar.This_Factory,"SBM11");

			_imageIndex = new int[vDt.Rows.Count];

			for (int i = 0 ; i < vDt.Rows.Count ; i++)
			{
				lst_main.Items.Add(new ListViewItem(vDt.Rows[i][2].ToString(), i + _default));
				_processList.Add(vDt.Rows[i][4].ToString());
				_imageIndex[i] = _default;
			}
		}

		private Form OpenForm(string arg_program)
		{
			try
			{
				string project_main = "FlexMRP.MRP.";
				string project = "FlexMRP";

				System.Reflection.Assembly asm = System.Reflection.Assembly.Load(project); 
				Type t = asm.GetType(project_main + arg_program);
				Form frm = null;

				if (t != null)
				{
					frm = (Form)Activator.CreateInstance(t);
					frm.MdiParent = _mdiParent;
					if (_curForm != null)
						((Form)_curForm).Dispose();

					_curForm = (IOperation)frm;					
					ImageSet();
				}
				else
				{
					ClassLib.ComFunction.User_Message(arg_program + " is not found!!");
				}

				return frm;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "OpenForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return null;
			}
		}

		private void FormClose()
		{
			int vChilds = _mdiParent.MdiChildren.Length;

			for (int vIdx = vChilds - 1 ; vIdx >= 0 ; vIdx--)
			{
				if (!(_mdiParent.MdiParent.MdiChildren[vIdx] is Form_BM_Ready_Order))
					_mdiParent.MdiParent.MdiChildren[vIdx].Close();
			}
		}

		#endregion

		#region Validate Check

		private bool ValidateCheck(int arg_process)
		{
			try
			{
				// 공통 체크 - 데이터 검색 여부
                //if (arg_process > 0 && _curForm.GetSearchRows() <= 0)
                //{
                //    ClassLib.ComFunction.User_Message("Data not found", "Process-" + arg_process, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return false;
                //}

				/**************************************************************** 
				 * 공통 체크 - Sbm_Ready 테이블 체크
				 * 1. 데이터가 있는 경우 이미지 리스트의 이미지 인덱스 갱신
				 * 2. 데이터가 없는 경우 - 0, 구간 자체가 생성 되지 않은 경우
				 *						   1, 선적 구간이 생성되지 않은 경우
				 ****************************************************************/

				DataTable vDt = ClassLib.ComFunction.SELECT_CHECK_STATUS(_startForm.Factory, _startForm.ShipType, "40");

				if (vDt.Rows.Count > 0)
				{
					for (int i = 0 ; i < _imageIndex.Length ; i++)
						_imageIndex[i] = Convert.ToInt32(vDt.Rows[0][i]);

					if (_imageIndex[arg_process] != _check)
					{
						ClassLib.ComFunction.User_Message("Not confirmed process", "Process-" + arg_process, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}

					ImageSet();
				}
				else
				{
					if (arg_process == 0)
					{
                        //DataTable vDt2 = ClassLib.ComFunction.SELECT_OPERATION_INFO((int)ClassLib.ComVar.MRPProcessNum.ShippingSectionCreate + "", _startForm.Factory, _startForm.ShipType, _mrpShipNo);

                        //if (vDt2.Rows[0][0].ToString().Equals("-1"))
                        //{
                        //    if (ClassLib.ComFunction.User_Message("Do you want to create shipping section?", "Create", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        //        return false;

                        //    RUN_SHIPPING_SECTION_CREATE(_startForm.Factory, _startForm.ShipType);
                        //    ClassLib.ComFunction.User_Message("Shipping section create complete", "Create", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
					}
					else if (arg_process == 1)
					{
						ClassLib.ComFunction.User_Message("Not found next shipping section", "Process-1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
				}
				
				vDt.Dispose();

				// 부분별 체크
				switch (arg_process)
				{
					case 0:	 // 최초 선적 구간 생성 이전
						_imageIndex[0] = _check;
						ImageSet();
						break;
					case 1:  // 선적 구간 생성 여부
						DataTable vDt3 = ClassLib.ComFunction.SELECT_OPERATION_INFO(arg_process.ToString(), _startForm.Factory, _startForm.ShipType, _mrpShipNo);

						_mrpShipNo	= vDt3.Rows[0][2].ToString();
						_planStart	= vDt3.Rows[0][3].ToString();
						_planEnd	= vDt3.Rows[0][4].ToString();

						vDt3.Dispose();
						break;
					case 2:  // 나머지 체크

						break;
					case 3:

						break;
					case 4:

						break;
					case 5:

						break;
					case 6:

						break;
					case 7:

						break;
					case 8:

						break;
				}

				return true;
			}
			catch(Exception ex)
			{
				ClassLib.ComFunction.User_Message(ex.Message, "ValidateCheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}

		#endregion

		#region 버튼 이벤트

		private void btn_next_Click(object sender, System.EventArgs e)
		{
			if (ValidateCheck(_curProcessNum))
			{
				if (_curProcessNum < _processList.Count - 1)
				{
					Form frm = OpenForm(_processList[++_curProcessNum].ToString());
					if (frm != null)
					{
						((IOperation)frm).RunProcess(_startForm.Factory, _startForm.ShipType, _mrpShipNo, _planStart, _planEnd);
						frm.Show();
					}
				}
				else
				{
					ClassLib.ComFunction.User_Message("Last Process", "Next", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void lbl_prev_Click(object sender, System.EventArgs e)
		{
			if (_curProcessNum > 1)
			{
				Form frm = OpenForm(_processList[--_curProcessNum].ToString());
				if (frm != null)
				{
					((IOperation)frm).RunProcess(_startForm.Factory, _startForm.ShipType, _mrpShipNo, _planStart, _planEnd);
					frm.Show();
				}
			}
			else
			{
				ClassLib.ComFunction.User_Message("First Process", "Next", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void lst_main_DoubleClick(object sender, System.EventArgs e)
		{
			int vDest = lst_main.SelectedIndices[0];

			if (vDest == 0)
				return;

			if (this._imageIndex[vDest] != _default)
			{
				if (_mrpShipNo == null)
				{
					if (!ValidateCheck(1))
						return;
				}
				else
				{
					if (!ValidateCheck(_curProcessNum))
						return;
				}

				_curProcessNum = lst_main.SelectedIndices[0];

				Form frm = OpenForm(_processList[lst_main.SelectedIndices[0]].ToString());
				if (frm != null)
				{
					((IOperation)frm).RunProcess(_startForm.Factory, _startForm.ShipType, _mrpShipNo, _planStart, _planEnd);
					frm.Show();
				}
			}
		}

		private void ImageSet()
		{
			for (int i = 0 ; i < _imageIndex.Length ; i++)
			{
				lst_main.Items[i].ImageIndex = i + _imageIndex[i];
			}

			lst_main.Items[_curProcessNum].ImageIndex = _curProcessNum + _select;
		}

		#endregion
		
		#region DB Connect


		/// <summary>
		/// PKG_SBM_SHIPPING : 선적 구간 생성
		/// </summary>
		public void RUN_SHIPPING_SECTION_CREATE(string arg_factory, string arg_ship_type)
		{
			COM.OraDB MyOraDB = new COM.OraDB();

			MyOraDB.ReDim_Parameter(2);

			//01.PROCEDURE명
			MyOraDB.Process_Name = "PKG_SBM_SHIPPING.RUN_SHIPPING_SECTION_CREATE";

			//02.ARGURMENT 명
			MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
			MyOraDB.Parameter_Name[1] = "ARG_SHIP_TYPE";

			//03.DATA TYPE 정의
			MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
			MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;

			//04.DATA 정의
			MyOraDB.Parameter_Values[0] = arg_factory;
			MyOraDB.Parameter_Values[1] = arg_ship_type;

			MyOraDB.Add_Modify_Parameter(true);
			MyOraDB.Exe_Modify_Procedure();
		}

		#endregion

	}
}
