using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCDC.FOB
{
    public partial class Pop_FOB_Master : COM.APSWinForm.Pop_Small
    {
        #region 생성자
        public Pop_FOB_Master()
        {
            InitializeComponent();
        }
        public Pop_FOB_Master(string arg_factory, string arg_obs_id, string arg_style_cd)
        {
            InitializeComponent();

            factory  = arg_factory;
            obs_id   = arg_obs_id;
            style_cd = arg_style_cd;
        }
        #endregion

        #region 사용자 정의 변수
        private COM.OraDB MyOraDB = new COM.OraDB();
        public string factory = "", obs_id = "", style_cd = "", style_name = "";
        public bool save_flg = false;
        #endregion
        
        #region Form Loading
        private void Pop_FOB_Master_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Init_Form();
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
        
        private void Init_Form()
        {

            // Title 
            this.Text = "FOB Master";
            this.lbl_MainTitle.Text = "FOB Master";
            ClassLib.ComFunction.SetLangDic(this);


            // Factory Combobox Add Items
            System.Data.DataTable dt_ret = ClassLib.ComFunction.Select_Factory_List();
            ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Factory, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            dt_ret.Dispose();
            
            cmb_Factory.SelectedValue = factory;
            txt_obs_id.Text = obs_id;
            txt_Style.Text = style_cd.Replace("-", "");
            Event_txt_Style_KeyUp();

            txt_Style.CharacterCasing = CharacterCasing.Upper;
        }
        #endregion

        #region Control Event
        private void txt_style_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (e.KeyCode != Keys.Enter) return;

                Event_txt_Style_KeyUp();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_txt_Style_KeyUp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Event_txt_Style_KeyUp()
        {

            //-------------------------------------------------------------------------
            // 기타 콘트롤 초기화 
            cmb_Style.SelectedIndex = -1;            
            //-------------------------------------------------------------------------


            // set combo : style list
            Init_Control_cmb_Style();



            string stylecd = "";
            int exist_index = -1;

            stylecd = txt_Style.Text.Trim();

            exist_index = txt_Style.Text.IndexOf("-", 0);

            if (exist_index == -1 && stylecd.Length == 9)
            {
                stylecd = stylecd.Substring(0, 6) + "-" + stylecd.Substring(6, 3);
            }

            cmb_Style.SelectedIndex = 1;
            
        }

        private void Init_Control_cmb_Style()
        {

            if (cmb_Factory.SelectedIndex == -1) return;

            DataTable dt_ret = get_style_name_pop();

            ClassLib.ComFunction.Set_ComboList_5(dt_ret, cmb_Style, 0, 1, 1, 1, 1, true, 100, 250);
            //ClassLib.ComCtl.Set_ComboList(dt_ret, cmb_Style, 0, 1, true, ClassLib.ComVar.ComboList_Visible.Code_Name);
            cmb_Style.SelectedIndex = 0;           

            dt_ret.Dispose();

        }

        private void cmb_style_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                Event_cmb_Style_SelectedValueChanged();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Event_cmb_Style_SelectedValueChanged", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void Event_cmb_Style_SelectedValueChanged()
        {

            if (cmb_Factory.SelectedIndex == -1 || cmb_Style.SelectedIndex == -1) return;


            //-------------------------------------------------------------------------
            // 기타 콘트롤 초기화 
            
            //-------------------------------------------------------------------------


            //0 : style code, 1 : style name, 2 : gen, 3 : presto, 4 : model name 
            txt_Style.Text = cmb_Style.SelectedValue.ToString();


        }

        private DataTable get_style_name_pop()
        {
            try
            {
                MyOraDB.ReDim_Parameter(3);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_EBM_FOB_SELECT.GET_STYLE_NAME_POP";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_FACTORY";
                MyOraDB.Parameter_Name[1] = "ARG_STYLE_CD";
                MyOraDB.Parameter_Name[2] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = cmb_Factory.SelectedValue.ToString();
                MyOraDB.Parameter_Values[1] = txt_Style.Text;
                MyOraDB.Parameter_Values[2] = "";

                MyOraDB.Add_Select_Parameter(true);
                DataSet ds_ret = MyOraDB.Exe_Select_Procedure();

                if (ds_ret == null) return null;
                return ds_ret.Tables[MyOraDB.Process_Name];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #region Apply Click
        private void btn_save_Click(object sender, EventArgs e)
        {
            factory    = cmb_Factory.SelectedValue.ToString();
            obs_id     = txt_obs_id.Text;
            style_cd   = txt_Style.Text;
            style_name = cmb_Style.Text;

            save_flg = true;

            this.Close();
        }
        #endregion

        #region Close Click
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

