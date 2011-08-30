using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlexCosting.Management.Costing.Pop
{
    public partial class Pop_CBD_Master_CopyCBD : COM.PCHWinForm.Pop_Small
    {
        #region Constructor

        public Pop_CBD_Master_CopyCBD()
        {
            InitializeComponent();

            Init_Form();
        }

        #endregion

        #region User Define Variable
        
        private COM.OraDB MyOraDB = new COM.OraDB();
        private string _CBDVer = null;
        private string _FOBType = null;

        #endregion

        #region Form Loading

        private void Init_Form()
        {
            //Title
            this.Text = "Copy CBD";
            this.lbl_MainTitle.Text = "Copy CBD";
            ClassLib.ComFunction.SetLangDic(this);

            DataTable vDT = COM.ComFunction.Select_Factory_List();
            COM.ComFunction.Set_ComboList(vDT, cmb_DevFac, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComFunction.Set_ComboList(vDT, cmb_DevFac2, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComFunction.Set_ComboList(vDT, cmb_prod_fac, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComFunction.Set_ComboList(vDT, cmb_prod_fac2, 0, 1, false, COM.ComVar.ComboList_Visible.Name);
            cmb_DevFac.ReadOnly = true;
            cmb_DevFac2.ReadOnly = false;
            cmb_DevFac.Enabled = false;
            cmb_DevFac2.Enabled = true;
            cmb_prod_fac.ReadOnly = true;
            cmb_prod_fac2.ReadOnly = false;
            cmb_prod_fac.Enabled = false;
            cmb_prod_fac2.Enabled = true;

            vDT.Dispose();

            vDT = MyOraDB.Select_ComCode(COM.ComVar.This_Factory, "SFB_06");
            COM.ComFunction.Set_ComboList(vDT, cmb_RoundCD1, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            COM.ComFunction.Set_ComboList(vDT, cmb_RoundCD2, 1, 2, false, COM.ComVar.ComboList_Visible.Name);
            vDT.Dispose();

            vDT = new ClassLib.ComFunction_Cost().Select_Season(COM.ComVar.This_Factory);
            COM.ComCtl.Set_ComboList(vDT, cmb_season_cd, 0, 1, false);
            COM.ComCtl.Set_ComboList(vDT, cmb_season_cd2, 0, 1, false);
            vDT.Dispose();
        }

        #endregion

        #region Apply Data

        private void btn_apply_Click(object sender, EventArgs e)
        {
            try
            {
                Apply_Data();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Apply_Data()
        {
            string sDevFac = cmb_DevFac.SelectedValue.ToString();
            string sProdFac = cmb_prod_fac.SelectedValue.ToString();
            string sMOID = txt_MOID.Text;
            string sCBDID = txt_CBDID.Text;
            string sCBDVer = _CBDVer;
            string sFOBType = _FOBType;//cmb_RoundCD1.SelectedValue.ToString();
            string sSeason = cmb_season_cd.SelectedValue.ToString();

            string sDevFac2 = cmb_DevFac2.SelectedValue.ToString();
            string sProdFac2 = cmb_prod_fac2.SelectedValue.ToString();
            txt_MOID2.Text = txt_MOID2.Text.Trim();
            string sMOID2 = txt_MOID2.Text;
            txt_CBDID2.Text = txt_CBDID2.Text.Trim();
            string sCBDID2 = txt_CBDID2.Text;
            string sCBDVer2 = _CBDVer;
            string sFOBType2 = cmb_RoundCD2.SelectedValue.ToString();
            string sSeason2 = cmb_season_cd2.SelectedValue.ToString();
            string sDesc = txt_desc.Text;
            string sUPDUser = COM.ComVar.This_User;

            if (sDevFac2.Trim().Equals("")  ||
                sProdFac2.Trim().Equals("") ||
                sMOID2.Trim().Equals("")    ||
                sCBDID2.Trim().Equals("")   ||
                sFOBType2.Trim().Equals(""))
                return;

            if (sFOBType2.Equals("Y0000"))
            {
                DataTable vDT = SELECT_NEXT_CBD_VER(sDevFac2, sMOID2, sCBDID2, sFOBType2);
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    string sCBDSeqNew = vDT.Rows[0][0] == null ? "" : vDT.Rows[0][0].ToString();
                    if (sCBDSeqNew.Equals(""))
                    {
                        MessageBox.Show("CBD Seq create error", "CBD Seq");
                        return;
                    }
                    else
                    {
                        sCBDVer2 = sCBDSeqNew;
                        _CBDVer = sCBDSeqNew;
                    }
                }
            }
            else
            {
                DataTable vDT = SELECT_SFX_CBD_MASTER_CBD_ID(sDevFac2, sMOID2, sCBDID2, sCBDVer2, sFOBType2, sSeason2);
                if (vDT != null && vDT.Rows.Count > 0)
                {
                    string sCBDIDNew = vDT.Rows[0][0] == null ? "" : vDT.Rows[0][0].ToString();
                    if (sCBDIDNew.Equals(""))
                    {
                        MessageBox.Show("CBD ID create error", "CBD ID");
                        return;
                    }
                    else
                    {
                        sCBDID2 = sCBDIDNew;
                        txt_CBDID2.Text = sCBDIDNew;
                    }
                }
            }

            if (!sDevFac.Equals(sDevFac2) || !sMOID.Equals(sMOID2) || !sCBDID.Equals(sCBDID2) || !sFOBType.Equals(sFOBType2) || !sCBDVer.Equals(sCBDVer2))
            {
                if (SAVE_SFX_CBD_MASTER_COPY(sDevFac, sProdFac, sMOID, sCBDID, sCBDVer, sFOBType, sSeason, sDevFac2, sProdFac2, sMOID2, sCBDID2, sCBDVer2, sFOBType2, sSeason2, "20", sDesc, "S", sUPDUser))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("CBD copy error", "Copy");
            return;

        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SELECT_SFX_CBD_MASTER_CBD_ID : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_SFX_CBD_MASTER_CBD_ID(string arg_dev_fac2, string arg_moid2, string arg_cbd_id2, string arg_cbd_seq2, string arg_fob_type_cd2, string arg_season_cd2)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(7);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SELECT_SFX_CBD_MASTER_CBD_ID";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC2";
                MyOraDB.Parameter_Name[1] = "ARG_MOID2";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID2";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_SEQ2";
                MyOraDB.Parameter_Name[4] = "ARG_FOB_TYPE_CD2";
                MyOraDB.Parameter_Name[5] = "ARG_SEASON_CD2";
                MyOraDB.Parameter_Name[6] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac2;
                MyOraDB.Parameter_Values[1] = arg_moid2;
                MyOraDB.Parameter_Values[2] = arg_cbd_id2;
                MyOraDB.Parameter_Values[3] = arg_cbd_seq2;
                MyOraDB.Parameter_Values[4] = arg_fob_type_cd2;
                MyOraDB.Parameter_Values[5] = arg_season_cd2;
                MyOraDB.Parameter_Values[6] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SELECT_NEXT_CBD_VER : 
        /// </summary>
        /// <returns>DataTable</returns>
        public DataTable SELECT_NEXT_CBD_VER(string arg_dev_fac, string arg_moid, string arg_cbd_id, string arg_fob_type_cd)
        {
            try
            {
                DataSet vds_ret;

                MyOraDB.ReDim_Parameter(5);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SELECT_NEXT_CBD_VER";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_MOID";
                MyOraDB.Parameter_Name[2] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[3] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[4] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_moid;
                MyOraDB.Parameter_Values[2] = arg_cbd_id;
                MyOraDB.Parameter_Values[3] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[4] = "";

                MyOraDB.Add_Select_Parameter(true);
                vds_ret = MyOraDB.Exe_Select_Procedure();
                if (vds_ret == null) return null;

                return vds_ret.Tables[MyOraDB.Process_Name];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        /// <summary>
        /// PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_COPY : 
        /// </summary>
        public bool SAVE_SFX_CBD_MASTER_COPY(string arg_dev_fac, string arg_prod_fac, string arg_moid, string arg_cbd_id, string arg_cbd_seq, string arg_fob_type_cd, string arg_season_cd, string arg_dev_fac2, string arg_prod_fac2, string arg_moid2, string arg_cbd_id2, string arg_cbd_seq2, string arg_fob_type_cd2, string arg_season_cd2, string arg_rev_reason, string arg_desc, string arg_status_cd, string arg_upd_user)
        {
            try
            {

                MyOraDB.ReDim_Parameter(19);

                //01.PROCEDURE명
                MyOraDB.Process_Name = "PKG_SFX_CBD_MASTER_SAVE.SAVE_SFX_CBD_MASTER_COPY";

                //02.ARGURMENT 명
                MyOraDB.Parameter_Name[0] = "ARG_DEV_FAC";
                MyOraDB.Parameter_Name[1] = "ARG_PROD_FAC";
                MyOraDB.Parameter_Name[2] = "ARG_MOID";
                MyOraDB.Parameter_Name[3] = "ARG_CBD_ID";
                MyOraDB.Parameter_Name[4] = "ARG_CBD_SEQ";
                MyOraDB.Parameter_Name[5] = "ARG_FOB_TYPE_CD";
                MyOraDB.Parameter_Name[6] = "ARG_SEASON_CD";
                MyOraDB.Parameter_Name[7] = "ARG_DEV_FAC2";
                MyOraDB.Parameter_Name[8] = "ARG_PROD_FAC2";
                MyOraDB.Parameter_Name[9] = "ARG_MOID2";
                MyOraDB.Parameter_Name[10] = "ARG_CBD_ID2";
                MyOraDB.Parameter_Name[11] = "ARG_CBD_SEQ2";
                MyOraDB.Parameter_Name[12] = "ARG_FOB_TYPE_CD2";
                MyOraDB.Parameter_Name[13] = "ARG_SEASON_CD2";
                MyOraDB.Parameter_Name[14] = "ARG_REV_REASON";
                MyOraDB.Parameter_Name[15] = "ARG_DESC";
                MyOraDB.Parameter_Name[16] = "ARG_STATUS_CD";
                MyOraDB.Parameter_Name[17] = "ARG_UPD_USER";
                MyOraDB.Parameter_Name[18] = "OUT_CURSOR";

                //03.DATA TYPE 정의
                MyOraDB.Parameter_Type[0] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[1] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[2] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[3] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[4] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[5] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[6] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[7] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[8] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[9] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[10] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[11] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[12] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[13] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[14] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[15] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[16] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[17] = (int)OracleType.VarChar;
                MyOraDB.Parameter_Type[18] = (int)OracleType.Cursor;

                //04.DATA 정의
                MyOraDB.Parameter_Values[0] = arg_dev_fac;
                MyOraDB.Parameter_Values[1] = arg_prod_fac;
                MyOraDB.Parameter_Values[2] = arg_moid;
                MyOraDB.Parameter_Values[3] = arg_cbd_id;
                MyOraDB.Parameter_Values[4] = arg_cbd_seq;
                MyOraDB.Parameter_Values[5] = arg_fob_type_cd;
                MyOraDB.Parameter_Values[6] = arg_season_cd;
                MyOraDB.Parameter_Values[7] = arg_dev_fac2;
                MyOraDB.Parameter_Values[8] = arg_prod_fac2;
                MyOraDB.Parameter_Values[9] = arg_moid2;
                MyOraDB.Parameter_Values[10] = arg_cbd_id2;
                MyOraDB.Parameter_Values[11] = arg_cbd_seq2;
                MyOraDB.Parameter_Values[12] = arg_fob_type_cd2;
                MyOraDB.Parameter_Values[13] = arg_season_cd2;
                MyOraDB.Parameter_Values[14] = arg_rev_reason;
                MyOraDB.Parameter_Values[15] = arg_desc;
                MyOraDB.Parameter_Values[16] = arg_status_cd;
                MyOraDB.Parameter_Values[17] = arg_upd_user;
                MyOraDB.Parameter_Values[18] = "";

                MyOraDB.Add_Select_Parameter(true);
                if (MyOraDB.Exe_Select_Procedure() == null)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Cancel Data

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                Cancel_Data();
            }
            catch (Exception ex)
            {
                ClassLib.ComFunction.User_Message(ex.Message, "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cancel_Data()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #endregion

        #region Properties

        #region Setter 

        public string DevFac
        {
            set
            {
                cmb_DevFac.SelectedValue = cmb_DevFac2.SelectedValue = value;
            }
        }

        public string ProdFac
        {
            set
            {
                cmb_prod_fac.SelectedValue = cmb_prod_fac2.SelectedValue = value;
            }
        }

        public string MOID
        {
            set
            {
                txt_MOID.Text = txt_MOID2.Text = value;
            }
        }

        public string CBDID
        {
            set
            {
                txt_CBDID.Text = txt_CBDID2.Text = value;
            }
        }

        public string CBDVer
        {
            set
            {
                _CBDVer = value;
            }
        }

        public string FOBType
        {
            set
            {
                _FOBType = value;
            }
        }

        public string RoundCD
        {
            set
            {
                cmb_RoundCD1.SelectedValue = cmb_RoundCD2.SelectedValue = value;
            }
        }

        public string Season
        {
            set
            {
                cmb_season_cd.SelectedValue = cmb_season_cd2.SelectedValue = value;
            }
        }

        #endregion

        #region Getter 

        public string NewDevFac
        {
            get
            {
                return cmb_DevFac2.SelectedValue.ToString();
            }
        }

        public string NewMOID
        {
            get
            {
                return txt_MOID2.Text.Trim();
            }
        }

        public string NewCBDID
        {
            get
            {
                return txt_CBDID2.Text.Trim();
            }
        }

        public string NewCBDVer
        {
            get
            {
                return _CBDVer;
            }
        }

        public string NewRoundCD
        {
            get
            {
                return cmb_RoundCD2.SelectedValue.ToString();
            }
        }

        #endregion

        #endregion
    }
}

