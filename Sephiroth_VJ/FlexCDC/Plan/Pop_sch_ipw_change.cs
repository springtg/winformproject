using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Data.OracleClient;
using C1.Win.C1FlexGrid;

namespace FlexCDC.Plan
{
	public class Pop_sch_ipw_change : COM.PCHWinForm.Pop_Small
    {
        #region 컨트롤 정의 및 리소스 정의

        private System.Windows.Forms.Label lbl_ipw_ymd;
		private System.Windows.Forms.DateTimePicker dtp_ipw_ymd;
		private System.Windows.Forms.Label btn_change;
        private Label btn_cancel;
		private System.ComponentModel.IContainer components = null;        

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pop_sch_ipw_change));
            this.dtp_ipw_ymd = new System.Windows.Forms.DateTimePicker();
            this.lbl_ipw_ymd = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // img_Label
            // 
            this.img_Label.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Label.ImageStream")));
            this.img_Label.Images.SetKeyName(0, "");
            this.img_Label.Images.SetKeyName(1, "");
            this.img_Label.Images.SetKeyName(2, "");
            // 
            // img_Button
            // 
            this.img_Button.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Button.ImageStream")));
            this.img_Button.Images.SetKeyName(0, "");
            this.img_Button.Images.SetKeyName(1, "");
            // 
            // lbl_MainTitle
            // 
            this.lbl_MainTitle.Size = new System.Drawing.Size(336, 23);
            // 
            // image_List
            // 
            this.image_List.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image_List.ImageStream")));
            this.image_List.Images.SetKeyName(0, "");
            this.image_List.Images.SetKeyName(1, "");
            this.image_List.Images.SetKeyName(2, "");
            this.image_List.Images.SetKeyName(3, "");
            this.image_List.Images.SetKeyName(4, "");
            this.image_List.Images.SetKeyName(5, "");
            this.image_List.Images.SetKeyName(6, "");
            this.image_List.Images.SetKeyName(7, "");
            this.image_List.Images.SetKeyName(8, "");
            this.image_List.Images.SetKeyName(9, "");
            this.image_List.Images.SetKeyName(10, "");
            this.image_List.Images.SetKeyName(11, "");
            this.image_List.Images.SetKeyName(12, "");
            this.image_List.Images.SetKeyName(13, "");
            // 
            // img_Action
            // 
            this.img_Action.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_Action.ImageStream")));
            this.img_Action.Images.SetKeyName(0, "");
            this.img_Action.Images.SetKeyName(1, "");
            this.img_Action.Images.SetKeyName(2, "");
            // 
            // img_SmallButton
            // 
            this.img_SmallButton.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("img_SmallButton.ImageStream")));
            this.img_SmallButton.Images.SetKeyName(0, "");
            this.img_SmallButton.Images.SetKeyName(1, "");
            this.img_SmallButton.Images.SetKeyName(2, "");
            this.img_SmallButton.Images.SetKeyName(3, "");
            this.img_SmallButton.Images.SetKeyName(4, "");
            this.img_SmallButton.Images.SetKeyName(5, "");
            this.img_SmallButton.Images.SetKeyName(6, "");
            this.img_SmallButton.Images.SetKeyName(7, "");
            this.img_SmallButton.Images.SetKeyName(8, "");
            this.img_SmallButton.Images.SetKeyName(9, "");
            this.img_SmallButton.Images.SetKeyName(10, "");
            this.img_SmallButton.Images.SetKeyName(11, "");
            this.img_SmallButton.Images.SetKeyName(12, "");
            this.img_SmallButton.Images.SetKeyName(13, "");
            this.img_SmallButton.Images.SetKeyName(14, "");
            this.img_SmallButton.Images.SetKeyName(15, "");
            this.img_SmallButton.Images.SetKeyName(16, "");
            this.img_SmallButton.Images.SetKeyName(17, "");
            this.img_SmallButton.Images.SetKeyName(18, "");
            this.img_SmallButton.Images.SetKeyName(19, "");
            this.img_SmallButton.Images.SetKeyName(20, "");
            this.img_SmallButton.Images.SetKeyName(21, "");
            this.img_SmallButton.Images.SetKeyName(22, "");
            this.img_SmallButton.Images.SetKeyName(23, "");
            this.img_SmallButton.Images.SetKeyName(24, "");
            this.img_SmallButton.Images.SetKeyName(25, "");
            this.img_SmallButton.Images.SetKeyName(26, "");
            this.img_SmallButton.Images.SetKeyName(27, "");
            this.img_SmallButton.Images.SetKeyName(28, "");
            this.img_SmallButton.Images.SetKeyName(29, "");
            // 
            // dtp_ipw_ymd
            // 
            this.dtp_ipw_ymd.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ipw_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ipw_ymd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ipw_ymd.Location = new System.Drawing.Point(113, 34);
            this.dtp_ipw_ymd.Name = "dtp_ipw_ymd";
            this.dtp_ipw_ymd.Size = new System.Drawing.Size(100, 22);
            this.dtp_ipw_ymd.TabIndex = 361;
            this.dtp_ipw_ymd.Value = new System.DateTime(2007, 11, 19, 14, 18, 56, 968);
            // 
            // lbl_ipw_ymd
            // 
            this.lbl_ipw_ymd.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ipw_ymd.ImageIndex = 0;
            this.lbl_ipw_ymd.ImageList = this.img_Label;
            this.lbl_ipw_ymd.Location = new System.Drawing.Point(12, 34);
            this.lbl_ipw_ymd.Name = "lbl_ipw_ymd";
            this.lbl_ipw_ymd.Size = new System.Drawing.Size(100, 21);
            this.lbl_ipw_ymd.TabIndex = 360;
            this.lbl_ipw_ymd.Text = "IPW";
            this.lbl_ipw_ymd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_change.ImageIndex = 0;
            this.btn_change.ImageList = this.img_Button;
            this.btn_change.Location = new System.Drawing.Point(215, 33);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(70, 24);
            this.btn_change.TabIndex = 362;
            this.btn_change.Text = "Save";
            this.btn_change.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(248)))), ((int)(((byte)(251)))));
            this.btn_cancel.ImageIndex = 0;
            this.btn_cancel.ImageList = this.img_Button;
            this.btn_cancel.Location = new System.Drawing.Point(285, 33);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(74, 24);
            this.btn_cancel.TabIndex = 363;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Pop_sch_ipw_change
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.ClientSize = new System.Drawing.Size(370, 65);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.dtp_ipw_ymd);
            this.Controls.Add(this.lbl_ipw_ymd);
            this.Name = "Pop_sch_ipw_change";
            this.Load += new System.EventHandler(this.Pop_sch_ipw_change_Load);
            this.Controls.SetChildIndex(this.lbl_MainTitle, 0);
            this.Controls.SetChildIndex(this.lbl_ipw_ymd, 0);
            this.Controls.SetChildIndex(this.dtp_ipw_ymd, 0);
            this.Controls.SetChildIndex(this.btn_change, 0);
            this.Controls.SetChildIndex(this.btn_cancel, 0);
            this.ResumeLayout(false);

		}
		#endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();//WebService 접속 개체 생성
        private string[] _temp_value = new string[4];
        public bool _save_flg = false;
        #endregion

        #region 생성자
        public Pop_sch_ipw_change()
        {
            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }

        public Pop_sch_ipw_change(string [] arg_value)
        {
            _temp_value = arg_value;

            // 이 호출은 Windows Form 디자이너에 필요합니다.
            InitializeComponent();

            // TODO: InitializeComponent를 호출한 다음 초기화 작업을 추가합니다.
        }
        #endregion
        
        #region Form Loading
        private void Pop_sch_ipw_change_Load(object sender, EventArgs e)
        {
            try
            {
                Init_Form();
            }
            catch
            {
 
            }
        }

        private void Init_Form()
        {
            this.Text = "PCC_IPW Change";
            this.lbl_MainTitle.Text = "PCC_IPW Change";
            ClassLib.ComFunction.SetLangDic(this);

            int year  = int.Parse(_temp_value[3].Substring(0, 4));
            int month = int.Parse(_temp_value[3].Substring(4, 2));
            int day   = int.Parse(_temp_value[3].Substring(6, 2));

            DateTime ipw_ymd = new DateTime(year, month, day);

            dtp_ipw_ymd.Value = ipw_ymd;

        }
        #endregion

        #region Button Event
        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                string[] arg_value = new string[4];
                arg_value[0] = _temp_value[0];
                arg_value[1] = _temp_value[1];
                arg_value[2] = _temp_value[2];
                arg_value[3] = dtp_ipw_ymd.Value.ToString("yyyyMMdd");

                if (UPDATE_SXC_SCH_IPW_YMD(arg_value))
                {
                    _save_flg = true;
                    this.Close();
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default; 
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {

            }            
        }

        private bool UPDATE_SXC_SCH_IPW_YMD(string[] arg_value)
        {
            try
            {
                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SXC_SCH_02.UPDATE_SXC_SCH_IPW";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_MODEL_ID";
                MyOraDB.Parameter_Name[2] = "ARG_SRF_NO";
                MyOraDB.Parameter_Name[3] = "ARG_IPW_YMD";
                MyOraDB.Parameter_Name[4] = "ARG_UPD_USER";

                //03.DATA TYPE 정의                
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_value[0];
                MyOraDB.Parameter_Values[1] = arg_value[1];
                MyOraDB.Parameter_Values[2] = arg_value[2];
                MyOraDB.Parameter_Values[3] = arg_value[3];
                MyOraDB.Parameter_Values[4] = ClassLib.ComVar.This_User;

                MyOraDB.Add_Modify_Parameter(true);
                MyOraDB.Exe_Modify_Procedure();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        #endregion
    }
}



